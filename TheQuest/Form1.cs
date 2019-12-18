using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheQuest
{
    public partial class MainForm : Form
    {
        private Game game;
        private Random random = new Random();

        public MainForm()
        {
            InitializeComponent();
        }

        public void UpdateCharacters()
        {
            player.Location = game.PlayerLocation;
            playerHitPoints.Text = game.PlayerHitPoints.ToString();
            bool showBat = false;
            bool showGhost = false;
            bool showGhoul = false;
            int enemiesShown = 0;

            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy is Bat)
                {
                    bat.Location = enemy.Location;
                    batHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showBat = true;
                        enemiesShown++;
                    }
                }

                if (enemy is Ghost)
                {
                    ghost.Location = enemy.Location;
                    ghostHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhost = true;
                        enemiesShown++;
                    }
                }

                if (enemy is Ghoul)
                {
                    ghoul.Location = enemy.Location;
                    ghoulHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhoul = true;
                        enemiesShown++;
                    }
                }
            }

            if (!showBat)
            {
                bat.Visible = false;
                batHitPoints.Text = "";
            }
            else
            {
                bat.Visible = true;
            }

            if (!showGhost)
            {
                ghost.Visible = false;
                ghostHitPoints.Text = "";
            }
            else
            {
                ghost.Visible = true;
            }

            if (!showGhoul)
            {
                ghoul.Visible = false;
                ghoulHitPoints.Text = "";
            }
            else
            {
                ghoul.Visible = true;
            }

            sword.Visible = false;
            bow.Visible = false;
            redPotion.Visible = false;
            bluePotion.Visible = false;
            mace.Visible = false;
            Control weaponControl = null;
            switch (game.WeaponInRoom.Name)
            {
                case "Sword":
                    weaponControl = sword;
                    break;
                case "Bow":
                    weaponControl = bow;
                    break;
                case "Red Potion":
                    weaponControl = redPotion;
                    break;
                case "Blue Potion":
                    weaponControl = bluePotion;
                    break;
                case "Mace":
                    weaponControl = mace;
                    break;
                default:
                    break;
            }

            weaponControl.Visible = true;
            inventorySword.Visible = game.CheckPlayerInventory("Sword");
            inventoryBluePotion.Visible = game.CheckPlayerInventory("Blue Potion");
            inventoryBow.Visible = game.CheckPlayerInventory("Bow");
            inventoryRedPotion.Visible = game.CheckPlayerInventory("Red Potion");
            inventoryMace.Visible = game.CheckPlayerInventory("Mace");
            weaponControl.Location = game.WeaponInRoom.Location;
            if (game.WeaponInRoom.PickedUp)
            {
                weaponControl.Visible = false;
            }
            else
            {
                weaponControl.Visible = true;
            }

            if (game.PlayerHitPoints <= 0)
            {
                MessageBox.Show("WASTED");
                Application.Exit();
            }

            if (enemiesShown < 1)
            {
                MessageBox.Show("You have cleared the room!");
                game.NewLevel(random);
                UpdateCharacters();
            }
        }

        public void attackButtonsVisibilityIsPotion()
        {
            attackUpButton.Visible = true;
            attackDownButton.Visible = false;
            attackLeftButton.Visible = false;
            attackRightButton.Visible = false;
        }

        public void attackButtonsVisibilityIsNotPotion()
        {
            attackUpButton.Visible = true;
            attackDownButton.Visible = true;
            attackLeftButton.Visible = true;
            attackRightButton.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(120, 90, 694, 235));
            game.NewLevel(random);
            UpdateCharacters();
        }

        private void moveUpButton_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Up, random);
            UpdateCharacters();
        }

        private void moveDownButton_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Down, random);
            UpdateCharacters();
        }

        private void moveLeftButton_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Left, random);
            UpdateCharacters();
        }

        private void moveRightButton_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Right, random);
            UpdateCharacters();
        }

        private void attackUpButton_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Up, random);
            UpdateCharacters();
        }

        private void attackDownButton_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Down, random);
            UpdateCharacters();
        }

        private void attackLeftButton_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Left, random);
            UpdateCharacters();
        }

        private void attackRightButton_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Right, random);
            UpdateCharacters();
        }

        private void inventorySword_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Sword"))
            {
                game.Equip("Sword");
                inventorySword.BorderStyle = BorderStyle.Fixed3D;
                inventoryBluePotion.BorderStyle = BorderStyle.None;
                inventoryBow.BorderStyle = BorderStyle.None;
                inventoryRedPotion.BorderStyle = BorderStyle.None;
                inventoryMace.BorderStyle = BorderStyle.None;
                attackButtonsVisibilityIsNotPotion();
            }
        }

        private void inventoryBluePotion_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Blue Potion"))
            {
                game.Equip("Blue Potion");
                inventorySword.BorderStyle = BorderStyle.None;
                inventoryBluePotion.BorderStyle = BorderStyle.Fixed3D;
                inventoryBow.BorderStyle = BorderStyle.None;
                inventoryRedPotion.BorderStyle = BorderStyle.None;
                inventoryMace.BorderStyle = BorderStyle.None;
                attackButtonsVisibilityIsPotion();
            }
        }

        private void inventoryBow_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Bow"))
            {
                game.Equip("Bow");
                inventorySword.BorderStyle = BorderStyle.None;
                inventoryBluePotion.BorderStyle = BorderStyle.None;
                inventoryBow.BorderStyle = BorderStyle.Fixed3D;
                inventoryRedPotion.BorderStyle = BorderStyle.None;
                inventoryMace.BorderStyle = BorderStyle.None;
                attackButtonsVisibilityIsNotPotion();
            }
        }

        private void inventoryRedPotion_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Red Potion"))
            {
                game.Equip("Red Potion");
                inventorySword.BorderStyle = BorderStyle.None;
                inventoryBluePotion.BorderStyle = BorderStyle.None;
                inventoryBow.BorderStyle = BorderStyle.None;
                inventoryRedPotion.BorderStyle = BorderStyle.Fixed3D;
                inventoryMace.BorderStyle = BorderStyle.None;
                attackButtonsVisibilityIsPotion();
            }
        }

        private void inventoryMace_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Mace"))
            {
                game.Equip("Mace");
                inventorySword.BorderStyle = BorderStyle.None;
                inventoryBluePotion.BorderStyle = BorderStyle.None;
                inventoryBow.BorderStyle = BorderStyle.None;
                inventoryRedPotion.BorderStyle = BorderStyle.None;
                inventoryMace.BorderStyle = BorderStyle.Fixed3D;
                attackButtonsVisibilityIsNotPotion();
            }
        }
    }
}
