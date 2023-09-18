using Microsoft.VisualBasic;
using System;
using System.Xml;

namespace Wyścigi_str_225
{
    public partial class Form1 : Form
    {
        Greyhound[] GreyhoundArray = new Greyhound[4];
        Guy[] GuyArray = new Guy[3];
        Random Randomizer = new Random();

        public Form1()
        {
            GuyArray[0] = new Guy() { Imie = "Janek", Cash = 50, Mylabel = JanekLabel, MyRadioButton = JanekRadio };
            GuyArray[1] = new Guy() { Imie = "bartek", Cash = 70, Mylabel = BartekLabel, MyRadioButton = BartekRadio };
            GuyArray[2] = new Guy() { Imie = "Arek", Cash = 10, Mylabel = ArekLabel, MyRadioButton = ArekRadio };
            
            GuyArray[0].MyBet.Bettor = GuyArray[0];
            GuyArray[1].MyBet.Bettor = GuyArray[1];
            GuyArray[2].MyBet.Bettor = GuyArray[2];

            InitializeComponent();
            GreyhoundArray[0] = new Greyhound() { MyPictureBox = dogPicture1, MyRandom = Randomizer, RaceTrackLength = RaceTrackBox.Width };//Stworzenie
            GreyhoundArray[1] = new Greyhound() { MyPictureBox = dogPicture2, MyRandom = Randomizer, RaceTrackLength = RaceTrackBox.Width };//każdego
            GreyhoundArray[2] = new Greyhound() { MyPictureBox = dogPicture3, MyRandom = Randomizer, RaceTrackLength = RaceTrackBox.Width };//psa
            GreyhoundArray[3] = new Greyhound() { MyPictureBox = dogPicture4, MyRandom = Randomizer, RaceTrackLength = RaceTrackBox.Width };

            imie.Text = GuyArray[0].Imie;

            GuyArray[0].UpdateLabels();
            GuyArray[1].UpdateLabels();
            GuyArray[2].UpdateLabels();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Guynumer = 0;
            if (JanekRadio.Checked)
                Guynumer = 1;
            if (BartekRadio.Checked)
                Guynumer = 2;
            if (ArekRadio.Checked)
                Guynumer = 3;

            GuyArray[Guynumer].PlaceBet((int)updownZaklad.Value, (int)updownPies.Value);
            GuyArray[Guynumer].MyRadioButton.Enabled = false;
            GuyArray[Guynumer].UpdateLabels();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < GreyhoundArray.Length; i++)
            {
                if (GreyhoundArray[i].Run() == true)
                {
                    groupBox1.Enabled = true;
                    timer1.Stop();
                    i++;
                    var wynik = MessageBox.Show("Chart nr: " + i + " wygrał wyścig");

                    GreyhoundArray[0].TakeStartingPosition();
                    GreyhoundArray[1].TakeStartingPosition();
                    GreyhoundArray[2].TakeStartingPosition();
                    GreyhoundArray[3].TakeStartingPosition();


                    for (int j = 0; j < GuyArray.Length; j++)
                    {
                        if (GuyArray[j].MyBet == null)
                            break;
                        else
                        {
                            GuyArray[j].MyRadioButton.Enabled = true;
                            GuyArray[j].MyBet.PayOut(i);
                            GuyArray[j].Collect(i);
                            GuyArray[j].UpdateLabels();
                            GuyArray[j].ClearBet();
                        }
                    }
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}