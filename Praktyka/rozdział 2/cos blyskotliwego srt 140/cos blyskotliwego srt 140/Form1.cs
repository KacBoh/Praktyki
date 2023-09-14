namespace cos_blyskotliwego_srt_140
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void przycisk_Click(object sender, EventArgs e)
        {
            while (Visible)
            {
                Random c = new Random();
                

                this.BackColor = Color.FromArgb(c.Next(0,256), 255 - c.Next(0,256), c.Next(0,256));
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);
            }
            
        }
    }
}