namespace UcakBiletRezervasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota : " + comboBox1.Text + " - " + comboBox2.Text + " Date : " + dateTimePicker1.Text + " Clock : " + maskedTextBox1.Text + " Yolcu Bilgileri ~ Name : " + textBox1.Text + "IdNo : " + maskedTextBox2.Text + " Phone : " + maskedTextBox3.Text);
            MessageBox.Show("Passenger Registration (Yolcu Kaydý Yapýldý.)");


        }

        // burada biz <>  bu butonu kullandýk 3 adýmda  basta bize bir temp yani tasýyýcý (romurk) lazýmdý 
        // bundan dolayý 1.Adým comboBox2'daki deðeri temp'e atamak 
        // 2.adým  comboBox1'daki degeri comboBox2'e atamak  su an temp'de 2nin degeri var 2'de ise 1'in degeri
        // ve 1 kendisi bos 
        // 3.adým temp'deki degeri 1'e atamak ve exit 
        private void button2_Click(object sender, EventArgs e)
        {
            string temp = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = temp;

        }
    }
}