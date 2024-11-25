namespace ProyectoFinal_PED.Models
{
    public class Menu
    {
        public int IdMenu { get; set; }
        public string Nombre { get; set; }

        public Menu(int idMenu, string nombre)
        {
            IdMenu = idMenu;
            Nombre = nombre;
        }

        public Menu(string nombre)
        {
            Nombre = nombre;
        }
    }
}
