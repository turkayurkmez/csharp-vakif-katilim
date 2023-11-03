namespace ThreadingAndTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        Thread thread;
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Butona tıklandı");
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // thread = new Thread(new ThreadStart(syncCount));
            //thread.Start();
            await syncCount();

            MessageBox.Show("Bitti");
        }

        private async Task syncCount()
        {
            //for (int i = 0; i < 5000; i++)
            //{
            //    label1.Text = i.ToString();
            //}
            //return Task.CompletedTask;
            await Task.Run(() =>
            {
                for (int i = 0; i < 5000; i++)
                {
                    label1.Text = i.ToString();
                }
            });
        }
    }
}