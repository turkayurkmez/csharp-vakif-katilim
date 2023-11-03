namespace FormBagSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.FormBag.Info = textBoxValue.Text;
            form2.FormBag.Number = new Random().Next(1, 100);

            form2.Show();
        }
    }
}