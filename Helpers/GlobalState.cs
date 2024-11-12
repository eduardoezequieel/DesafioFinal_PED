using ProyectoFinal_PED.Models;

namespace ProyectoFinal_PED.Helpers
{
    internal static class GlobalState
    {
        public static Panel PanelContainer { get; set; }
        private static User currentUser;
        public static void SetCurrentUser(User user)
        {
            currentUser = user;
        }

        public static User GetCurrentUser()
        {
            return currentUser;
        }

        public static void SetPanelContainer(Panel panel)
        {
            PanelContainer = panel;
        }

        public static void LoadView(UserControl viewToShow)
        {
            PanelContainer.Controls.Clear();
            PanelContainer.Controls.Add(viewToShow);
        }

    }
}
