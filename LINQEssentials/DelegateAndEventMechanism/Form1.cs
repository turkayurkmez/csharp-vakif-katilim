namespace DelegateAndEventMechanism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductService productService = new ProductService();
            productService.ProductCreated += ProductService_ProductCreated;

            Product product = new Product { Name = "Mikrofon", Price = 1000 };
            productService.Create(product);
        }

        private void ProductService_ProductCreated(object sender, ProductCreatedEventArgs e)
        {
            string message = $"{e.Product.Name} isimli ürün, {e.Owner} tarafından {e.CreatedTime} anında db'ye kaydedildi";
            MessageBox.Show(message);
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void all_click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Red;
        }
    }
}