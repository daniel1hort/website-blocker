using System.Windows.Forms;

namespace WebsiteBlocker
{
    public partial class Form1 : Form
    {
        private string HostsPath => "C:\\Windows\\System32\\drivers\\etc\\hosts";

        public Form1()
        {
            InitializeComponent();
            RefreshData();

            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
            button1.BackColor = StyleSettings.Jet;
            button2.BackColor = StyleSettings.Jet;
            button1.ForeColor = StyleSettings.PaleDogwood;
            button2.ForeColor = StyleSettings.PaleDogwood;
            button1.FlatAppearance.BorderColor = StyleSettings.Redwood;
            button2.FlatAppearance.BorderColor = StyleSettings.Redwood;

            textBox1.BackColor = StyleSettings.Jet;
            textBox1.ForeColor = StyleSettings.PaleDogwood;
            textBox1.PlaceholderText = "www.anything.com";
            textBox1.Text = string.Empty;

            listBox1.DrawMode = DrawMode.OwnerDrawVariable;
            listBox1.DrawItem += ListBox1_DrawItem;
            listBox1.MeasureItem += ListBox1_MeasureItem;

            BackColor = StyleSettings.Jet;
            listBox1.BackColor = StyleSettings.Jet;
            panel1.BackColor = StyleSettings.Redwood;
            panel2.BackColor = StyleSettings.Jet;
        }

        private void ListBox1_MeasureItem(object? sender, MeasureItemEventArgs e)
        {
            var listbox = (ListBox)sender!;
            e.ItemHeight = listbox.Font.Height + StyleSettings.Padding * 2;
        }

        private void ListBox1_DrawItem(object? sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;

            var listbox = (ListBox)sender!;
            var item = listbox.Items[e.Index];
            var selected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;

            e.DrawBackground();
            //e.DrawFocusRectangle();

            using var primary = new SolidBrush(StyleSettings.Jet);
            using var secondary = new SolidBrush(StyleSettings.Redwood);
            using var text = new SolidBrush(StyleSettings.PaleDogwood);

            var backColor = selected switch
            {
                true => secondary,
                false => primary
            };
            var textBounds = e.Bounds;
            textBounds.Offset(e.Bounds.Height / 2, StyleSettings.Padding);

            e.Graphics.FillRectangle(primary, e.Bounds);
            e.Graphics.FillEllipse(backColor, e.Bounds.X, e.Bounds.Y, e.Bounds.Height, e.Bounds.Height);
            e.Graphics.FillEllipse(backColor, e.Bounds.X + e.Bounds.Width - e.Bounds.Height, e.Bounds.Y, e.Bounds.Height, e.Bounds.Height);
            e.Graphics.FillRectangle(backColor, e.Bounds.X + e.Bounds.Height * .5f, e.Bounds.Y, e.Bounds.Width - e.Bounds.Height, e.Bounds.Height);
            e.Graphics.DrawString(item.ToString(), e.Font!, text, textBounds, StringFormat.GenericDefault);
        }

        private void Button2_Click(object? sender, EventArgs e)
        {
            var selected = listBox1.SelectedItem as string;
            if (selected is null)
                return;

            var lines = File.ReadAllLines(HostsPath);
            var toWrite = lines.Where(a => a != $"127.0.0.1 {selected}");
            File.WriteAllLines(HostsPath, toWrite);
            RefreshData();
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
                return;

            var line = $"127.0.0.1 {textBox1.Text}";
            File.AppendAllLines(HostsPath, new[] { line });
            RefreshData();

            textBox1.Text = string.Empty;
            textBox1.Focus();
        }

        private void RefreshData()
        {
            var lines = File.ReadAllLines(HostsPath);
            var all = lines.Select(a => a.Trim())
                .Where(a => a.StartsWith("127.0.0.1"))
                .Select(a => a.Split(' ').Last())
                .Where(a => a.Length > 0)
                .Where(a => !a.Contains("docker"));
            listBox1.Items.Clear();
            listBox1.Items.AddRange(all.ToArray());
        }
    }
}