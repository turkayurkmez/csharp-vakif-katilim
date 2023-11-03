using Graph.Library;

namespace Graph.Display
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pluginEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.SelectedPath = Environment.CurrentDirectory;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                //1. seçilen klasör içindeki tüm plugin'ler gelmeli.
                var plugList = PlugInHelper.GetPlugins(folderBrowserDialog.SelectedPath);

                //2. Bu plugin'ler menüye eklenmeli
                plugList.ForEach(p =>
                {
                    ToolStripMenuItem item = new ToolStripMenuItem(p.Name);
                    plugsToolStripMenuItem.DropDownItems.Add(item);
                    item.Click += Item_Click;
                    loadedPlugins.Add(p.Name, p);
                });
            }
        }

        Dictionary<string, Plug> loadedPlugins = new Dictionary<string, Plug>();
        private void Item_Click(object? sender, EventArgs e)
        {
            string name = (sender as ToolStripItem).Text;
            if (loadedPlugins.ContainsKey(name))
            {
                var plug = loadedPlugins[name];
                IPlug plugInstance = (IPlug)PlugInHelper.CreateInstance(plug);
                plugInstance.Draw(panel1.CreateGraphics(), new SolidBrush(buttonColor.BackColor), x, y, width, height);
            }
        }

        int x, y, width, height;
        private void buttonColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                buttonColor.BackColor = colorDialog.Color;
                x = int.Parse(textBoxX.Text);
                y = int.Parse(textBoxY.Text);
                width = int.Parse(textBoxWidth.Text);
                height = int.Parse(textBoxHeight.Text);
            }
        }
    }
}