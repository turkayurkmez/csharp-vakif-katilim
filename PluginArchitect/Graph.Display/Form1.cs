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
                //1. se�ilen klas�r i�indeki t�m plugin'ler gelmeli.
                var plugList = PlugInHelper.GetPlugins(folderBrowserDialog.SelectedPath);

                //2. Bu plugin'ler men�ye eklenmeli
                plugList.ForEach(p =>
                {
                    ToolStripMenuItem item = new ToolStripMenuItem(p.Name);
                    plugsToolStripMenuItem.DropDownItems.Add(item);

                });
            }
        }
    }
}