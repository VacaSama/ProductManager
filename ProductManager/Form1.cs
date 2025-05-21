namespace ProductManager
{
    public partial class product_Form : Form
    {
        public product_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Source Control!");
        }

        private void add_bttn_Click(object sender, EventArgs e)
        {
            Product p = new()
            {
                Name = product_txtbox.Text
            };
            MessageBox.Show("Product added to database!");
        }
    }
}
