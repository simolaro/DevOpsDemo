using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HideAndSeek
{
    public partial class Form1 : Form 
    {
        Location currentLocation;
        int nombreDeplacement = 0 ;

        Outside garden;
        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        OutsideWithHidingPlace driveway;
        RoomWithDoor livingRoom;
        RoomWithDoor kitchen ;
        Room dinningRoom;
        Room stairs;
        Room upstairsHallway;
        Room masterBedroom;
        Room secondBedroom;
        Room bathroom;
        Opponent opponent;

        public Form1()
        {
            InitializeComponent();
            CreateObjets();
            //MoveToANewLocation(frontYard);
        }

        private void CreateObjets()
        {
            livingRoom = new RoomWithDoor("living Room", "an antique carpet", "closet", "an oak door with a brass knob");
            kitchen = new RoomWithDoor("Kitchen", "a wood table", "cabinet", "a screen door");
            dinningRoom = new Room("Dinning Room", "a crystal chandelier");
            stairs = new Room("Stairs", "a wooden bannister");
            upstairsHallway = new Room("Upstairs Hallway", "a picture of a dog");
            masterBedroom = new RoomWithHidingPlace("Master Bedroom", "a large bed", "under the bed");
            secondBedroom = new RoomWithHidingPlace("Second Bedroom", "a small bed", "under the bed");
            bathroom = new RoomWithHidingPlace("Bathroom", "a toilet and a sink", "in the shower");

            garden = new OutsideWithHidingPlace("garden", false, "shed");
            driveway = new OutsideWithHidingPlace("driveway", false, "garage");
            frontYard = new OutsideWithDoor("frontyard", true, "behind the tree", "an oak door with a brass knob");
            backYard = new OutsideWithDoor("backyard", false, "under the picnic table", "a screen door");

            livingRoom.Exits = new Location[] { dinningRoom };
            dinningRoom.Exits = new Location[] { livingRoom, kitchen };
            kitchen.Exits = new Location[] { dinningRoom };
            stairs.Exits = new Location[] { livingRoom, upstairsHallway };
            upstairsHallway.Exits = new Location[] { masterBedroom, secondBedroom, bathroom };
            masterBedroom.Exits = new Location[] { upstairsHallway };
            secondBedroom.Exits = new Location[] { upstairsHallway };
            bathroom.Exits = new Location[] { upstairsHallway };

            frontYard.Exits = new Location[] { backYard, garden, driveway };
            garden.Exits = new Location[] { backYard, frontYard };
            backYard.Exits = new Location[] { frontYard, garden, driveway };
            driveway.Exits = new Location[] { frontYard, backYard };

            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;

            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;

            opponent = new Opponent(frontYard);
            currentLocation = frontYard;

        }


        private void MoveToANewLocation(Location newLocation)  
        {
            currentLocation = newLocation;

            comboBox1.Items.Clear();
            for (int i = 0; i < currentLocation.Exits.Length; i++)
            {
                comboBox1.Items.Add(currentLocation.Exits[i].Name);
            }
            //comboBox1.SelectedIndex = 0;

            // Set the description textbox
            description.Text = currentLocation.Description;
            RedrawForm();
        }

        private void goHere_Click(object sender, EventArgs e)
        {
            MoveToANewLocation(currentLocation.Exits[comboBox1.SelectedIndex]);
            nombreDeplacement++;
        }

        private void goThroughTheDoor_Click(object sender, EventArgs e)
        {
            // faut aller chercher un champ de l'objet attaché à Location
            IHasExteriorDoor thisExtDoor = currentLocation as IHasExteriorDoor;
            MoveToANewLocation(thisExtDoor.DoorLocation);
        }


        private void HideButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 10; i++)
            {
                description.Text += i + "..." + '\n';
                opponent.Move();
                Application.DoEvents();
                System.Threading.Thread.Sleep(500);
            }

            description.Text += "Ready or not, here I come!" + '\n';
            Application.DoEvents();
            System.Threading.Thread.Sleep(900);

            hideButton.Visible = false;
            goHere.Visible = true;
            comboBox1.Visible = true;

            RedrawForm(); 
        }

        private void RedrawForm()
        {
            // puts the right text in the description text box - ???
            description.Text = currentLocation.Description;

            // Makes button visible or not

            // Si Opponent est caché
              // if(opponent.)
            // Set the "Go through the door
            if (currentLocation is IHasExteriorDoor) { goThroughTheDoor.Visible = true; }
            else { goThroughTheDoor.Visible = false; }

            // Set "Check!" button
            if (currentLocation is IHasHidingPlace)
            {
                IHasHidingPlace thisLocation = currentLocation as IHasHidingPlace;
                check.Visible = true;
                check.Text = "Check " + thisLocation.HidingPlace;  // Set the middle button
            }
            else { check.Visible = false; }

            // initialisation du combo box
            comboBox1.Items.Clear();
            for (int i = 0; i < currentLocation.Exits.Length; i++)
            {
                comboBox1.Items.Add(currentLocation.Exits[i].Name);
            }
        }

        private void ResetGame()
        {
            // Reset opponent
            opponent = new Opponent(frontYard);
            nombreDeplacement = 0;

            // initialise screen. 
            // buttons
            goThroughTheDoor.Visible = false;
            check.Visible = false;
            goHere.Visible = false;
            comboBox1.Visible = false;
            hideButton.Visible = true;

            // Set descriptions
            description.Text = " ";
            check.Text = "check";
        }

        private void check_Click(object sender, EventArgs e)
        {
            nombreDeplacement++;

            if (opponent.Check(currentLocation))
            {
                MessageBox.Show("You found me in " + nombreDeplacement + " moves!");
                ResetGame();
            }

        }
    }
}
