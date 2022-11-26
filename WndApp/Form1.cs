using WndApp.DAL;
using WndApp.Model;
using WndApp.Test;

namespace WndApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KitapDB db = new KitapDB();
            tabControl1.SelectTab(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Merhaba Merhaba Merhaba Merhaba Merhaba Merhaba Merhaba Merhaba Merhaba Merhaba Merhaba Merhaba Merhaba Merhaba Merhaba Merhaba";

            MessageBox.Show("", "", MessageBoxButtons.YesNo);

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new UrunDB().UrunBul("road");
        }
    }
}