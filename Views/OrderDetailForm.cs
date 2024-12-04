using ProyectoFinal_PED.Controllers;
using ProyectoFinal_PED.Helpers;
using ProyectoFinal_PED.Models;

namespace ProyectoFinal_PED.Views
{
    public partial class OrderDetailForm : UserControl
    {
        private Order Order;
        private OrderDetail? OrderDetail = null;
        private MenusController menuController = new MenusController();
        private DishesController dishesController = new DishesController();
        private OrderController orderController = new OrderController();

        private Dictionary<int, Menu> availableMenus = new Dictionary<int, Menu>();
        private List<Dish> availableDishes = new List<Dish>();
        public OrderDetailForm(Order order, OrderDetail? orderDetail)
        {
            InitializeComponent();

            this.Order = order;
            this.OrderDetail = orderDetail;

            this.LoadMenus();

            if (orderDetail != null)
            {
                this.quantityTxt.Text = orderDetail.Quantity.ToString();
                this.titleLbl.Text = "Editar detalle de orden";
            }
        }

        private async void LoadMenus()
        {
            this.availableMenus.Clear();
            this.showMenuLoading(true);
            this.availableMenus = await this.menuController.GetMenus();

            this.menuCb.DisplayMember = "Nombre";
            this.menuCb.ValueMember = "IdMenu";
            this.menuCb.DataSource = this.availableMenus.Values.ToList();

            this.showMenuLoading(false);

            if(this.OrderDetail != null)
            {
                this.menuCb.SelectedValue = this.OrderDetail.Menu?.IdMenu;
            }
        }

        private async void LoadDishes(int? menuId)
        {
            this.availableDishes.Clear();
            this.showDishesLoading(true);

            if (menuId == null)
            {
                this.availableDishes = new List<Dish>();
                return;
            }

            this.availableDishes = await this.dishesController.GetDishesByMenuId((int)menuId);

            this.dishCb.DisplayMember = "Nombre";
            this.dishCb.ValueMember = "IdPlatillo";
            this.dishCb.DataSource = this.availableDishes;

            this.showDishesLoading(false);

            if (this.OrderDetail != null)
            {
                this.dishCb.SelectedValue = this.OrderDetail.Dish?.IdPlatillo;
            }
        }

        private void showMenuLoading(bool show)
        {
            menuLoadingSpinner.Visible = show;
        }

        private void showDishesLoading(bool show)
        {
            dishLoadingSpinner.Visible = show;
        }

        private async void AddDetailOrder()
        {
            var dishId = this.dishCb.SelectedValue;
            string quantity = this.quantityTxt.Text;
            int quantityNumber;
            bool validQuantity = int.TryParse(quantity, out quantityNumber);

            if (dishId == null || String.IsNullOrEmpty(quantity))
            {
                MessageBox.Show("Por favor, complete los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (validQuantity == false || quantityNumber < 1)
            {
                MessageBox.Show("La cantidad debe ser un número entero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (quantityNumber > 1000)
            {
                MessageBox.Show("La cantidad no puede ser mayor a 1000.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int dishIdParsed = (int)dishId!;

            Dish? dish = availableDishes.Find(d => d.IdPlatillo == dishIdParsed);

            if (dish == null) return;

            Decimal subtotal = dish.Precio * quantityNumber;

            OrderDetail orderDetail = new OrderDetail(0, this.Order.Id, dish.IdPlatillo, quantityNumber, subtotal, null, null);

            (bool result, string message) = await this.orderController.AddOrderDetail(orderDetail);

            if (!result)
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(message, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            GlobalState.LoadView(new OrderDetailManagement(this.Order));
        }

        private async void UpdateDetailOrder()
        {
            if (this.OrderDetail == null) return;
            var dishId = this.dishCb.SelectedValue;
            string quantity = this.quantityTxt.Text;
            int quantityNumber;
            bool validQuantity = int.TryParse(quantity, out quantityNumber);

            if (dishId == null || String.IsNullOrEmpty(quantity))
            {
                MessageBox.Show("Por favor, complete los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (validQuantity == false || quantityNumber < 1)
            {
                MessageBox.Show("La cantidad debe ser un número entero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (quantityNumber > 1000)
            {
                MessageBox.Show("La cantidad no puede ser mayor a 1000.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int dishIdParsed = (int)dishId!;
            Dish? dish = availableDishes.Find(d => d.IdPlatillo == dishIdParsed);

            if (dish == null) return;

            Decimal subtotal = dish.Precio * quantityNumber;

            OrderDetail orderDetail = new OrderDetail((int?)this.OrderDetail.Id ?? 0, this.Order.Id, dish.IdPlatillo, quantityNumber, subtotal, null, null);

            (bool result, string message) = await this.orderController.UpdateOrderDetail(orderDetail);

            if (!result)
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(message, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            GlobalState.LoadView(new OrderDetailManagement(this.Order));
        }

        private void menuCb_SelectedValueChanged(object sender, EventArgs e)
        {
            var menuId = this.menuCb.SelectedValue;            

            if(menuId == null) return;

            this.LoadDishes((int)menuId);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (this.OrderDetail == null)
            {
                this.AddDetailOrder();
            }
            else
            {
                this.UpdateDetailOrder();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            GlobalState.LoadView(new OrderDetailManagement(this.Order));
        }
    }
}
