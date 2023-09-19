namespace zarządzane_ulem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Zbieranie nektaru", "Wytwarzanie miodu" });
            workers[1] = new Worker(new string[] { "Pielęgnacja jaj", "Nauczanie pszczółek" });
            workers[2] = new Worker(new string[] { "Utrzymywanie ula", "Wytwarzanie miodu" });
            workers[3] = new Worker(new string[] { "Zbieranie nektaru", "Wytwarzanie miodu", "Patrol z żądłami" });

            queen = new Queen(workers);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private Queen queen;


        private void NextShift_Click(object sender, EventArgs e)
        {
            report.Text = queen.WorkTheNextShift();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (queen.AssignWork(workerBeeJob.Text, (int)shifts.Value) == false)
            {
                MessageBox.Show("Nie ma robotnic do tego zadania");
            }
            else MessageBox.Show("Zadanie " + workerBeeJob.Text + " zostanie ukończone za " + shifts.Value);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}