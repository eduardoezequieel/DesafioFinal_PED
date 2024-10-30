namespace ProyectoFinal_PED.Helpers
{
    internal static class GlobalState
    {
        public static Panel PanelContainer { get; set; }        

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
