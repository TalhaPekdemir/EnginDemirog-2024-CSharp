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
            MessageBox.Show("��lem1");
        }

        private void btnProcess2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("��lem2");
        }

        // windows form single thread �al���r.
        // bilgisayar kaynaklar�na g�re her i�lem bir thredin tamam�n� kullanacak �ekilde ayarlanabilir
        // buna multithreading denir
        // thread say�s�ndan fazla i�lem varsa bir thread bo�alana kadar i�elm bekler
        // asenkron �al��ma ise hem single hem multithread ile �al��abilir.
        // bir thread birden fazla i�lem i�in payla��ml� kullan�l�r.
        // .NET Framework arkaplanda bunu y�netir.
    }
}
