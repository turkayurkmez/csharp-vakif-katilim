namespace FormBagSample
{
    public partial class Form2 : Form, IIncludeFormBag
    {
        public Form2()
        {
            FormBag = new FormBag();
            InitializeComponent();
        }

        public dynamic FormBag { get; }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = FormBag.Info;
            label2.Text = FormBag.Number.ToString();
        }
    }
}
