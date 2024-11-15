using System.Windows.Forms;

public static class Prompt
{
    public static string ShowDialog(string text, string caption, int width = 500, int height = 150)
    {
        Form prompt = new Form()
        {
            Width = width,
            Height = height,
            FormBorderStyle = FormBorderStyle.FixedDialog,
            Text = caption,
            StartPosition = FormStartPosition.CenterScreen
        };

        Label textLabel = new Label() { Left = 50, Top = 20, Text = text, AutoSize = true };
        TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = width - 100 };
        Button confirmation = new Button() { Text = "Ok", Left = width - 150, Width = 100, Top = height - 70, DialogResult = DialogResult.OK };

        confirmation.Click += (sender, e) => { prompt.Close(); };

        prompt.Controls.Add(textLabel);
        prompt.Controls.Add(textBox);
        prompt.Controls.Add(confirmation);
        prompt.AcceptButton = confirmation;

        return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : string.Empty;
    }
}

