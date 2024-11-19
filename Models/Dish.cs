namespace ProyectoFinal_PED.Models
{
    public class Dish
    {
        public int IdPlatillo { get; set; }
        public int IdMenu { get; set; }
        public string Nombre { get; set; } // Asegúrate de que esta propiedad existe
        public decimal Precio { get; set; }

        public Dish(int idMenu, string nombre, decimal precio)
        {
            IdMenu = idMenu;
            Nombre = nombre;
            Precio = precio;
        }

        public Dish(int idPlatillo, int idMenu, string nombre, decimal precio)
        {
            IdPlatillo = idPlatillo;
            IdMenu = idMenu;
            Nombre = nombre;
            Precio = precio;
        }
    }
}

