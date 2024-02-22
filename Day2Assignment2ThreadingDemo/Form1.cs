namespace Day2Assignment2ThreadingDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcess1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ýþlem1");
        }

        private void btnProcess2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ýþlem2");
        }

        // windows form single thread çalýþýr.
        // bilgisayar kaynaklarýna göre her iþlem bir thredin tamamýný kullanacak þekilde ayarlanabilir
        // buna multithreading denir
        // thread sayýsýndan fazla iþlem varsa bir thread boþalana kadar iþelm bekler
        // asenkron çalýþma ise hem single hem multithread ile çalýþabilir.
        // bir thread birden fazla iþlem için paylaþýmlý kullanýlýr.
        // .NET Framework arkaplanda bunu yönetir.
    }
}
