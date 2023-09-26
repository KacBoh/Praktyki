using System.Windows.Forms;

namespace Laboratorium_Wyprawa
{
    public partial class Form1 : Form
    {
        private Game game;
        private Random random = new Random();

        private void Form1_load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(78, 57, 420, 155));
            game.NewLevel(random);
            UpdateCharacters();
        }

        public void UpdateCharacters()
        {
            picPlayer.Location = game.PlayerLocation;
            playerHitPoits.Text = game.PlayerHitPoints.ToString();
            bool showBat = false;
            bool showGhost = false;
            bool showGhoul = false;
            int enemiesShown = 0;

            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy is Bat)
                {
                    picBat.Location = enemy.Location;
                    batlabe.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showBat = true;
                        enemiesShown++;
                    }
                }
                else if (enemy is Ghost)
                {
                    picGhost.Location = enemy.Location;
                    ghostHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhost = true;
                        enemiesShown++;
                    }
                }
                else if (enemy is Ghoul)
                {
                    picGhoul.Location = enemy.Location;
                    ghoulHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhoul = true;
                        enemiesShown++;
                    }
                }
            }
            picBat.Visible = showBat;
            picGhost.Visible = showGhost;
            picGhoul.Visible = showGhoul;

            picSword.Visible = false;
            picMace.Visible = false;
            picBow.Visible = false;
            picBluePotion.Visible = false;
            picRedPotion.Visible = false;

            Control weaponControl = null;

            switch (game.WeaponInRoom.Name)
            {
                case "Miecz":
                    weaponControl = picSword;
                    break;
                case "£uk":
                    weaponControl = picBow;
                    break;
                case "Bu³awa":
                    weaponControl = picMace;
                    break;
                case "Czerwona mikstura":
                    weaponControl = picRedPotion;
                    break;
                case "Niebieska mikstura":
                    weaponControl = picBluePotion;
                    break;
            }

            weaponControl.Visible = true;

            inventorySword.Visible = game.CheckPlayerInventory("Miecz");
            inventoryBow.Visible = game.CheckPlayerInventory("£uk");
            inventoryMace.Visible = game.CheckPlayerInventory("Bu³awa");
            inventoryRedPotion.Visible = game.CheckPlayerInventory("Czerwona mikstura");
            inventoryBluePotion.Visible = game.CheckPlayerInventory("Niebieska mikstura");

            weaponControl.Location = game.WeaponInRoom.Location;
            if (game.WeaponInRoom.PickedUp)
                weaponControl.Visible = false;
            else
                weaponControl.Visible = true;


            if (game.PlayerHitPoints <= 0)
            {
                MessageBox.Show("zosta³eœ zabity");
                Application.Exit();
            }

            if (enemiesShown < 1)
            {
                MessageBox.Show("Pokona³eœ przeciwników na tym poziomie");
                if (game.NewLevel(random) == 8)
                {
                    Application.Exit();
                }
                else
                    UpdateCharacters();

            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}