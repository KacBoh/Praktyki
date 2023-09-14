namespace Zmiana_etykiety_jako_aplikacja_windows
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (label1.Text == "Text z lewej")
                {
                    label1.Text = "Text z prawej";
                    label1.TextAlign = ContentAlignment.MiddleRight;
                }
                else
                {
                    label1.Text = "Text z lewej";
                    label1.TextAlign = ContentAlignment.MiddleLeft;
                }
            }
            else
            if (checkBox1.Checked == false)
            {
                label1.Text = "Zmienianie tekstu jest wyłączone";
                label1.TextAlign = ContentAlignment.MiddleCenter;
            }

        }
    }
}