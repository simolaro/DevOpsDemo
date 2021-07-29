using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExploreTheHouse
{
    public partial class Form1 : Form 
    {
        Location currentLocation;

        Outside garden;
        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        RoomWithDoor livingRoom;
        RoomWithDoor kitchen ;
        Room dinningRoom;

        public Form1()
        {
            InitializeComponent();
            CreateObjets();
            MoveToANewLocation(frontYard);
        }

        private void CreateObjets()
        {
            livingRoom = new RoomWithDoor("living Room", "an antique carpet", "an oak door with a brass knob");
            kitchen = new RoomWithDoor("Kitchen", "a wood table", "a screen door");
            dinningRoom = new Room("Dinning Room", "a crystal chandelier");

            garden = new Outside("garden", false);
            frontYard = new OutsideWithDoor("frontyard", true, "an oak door with a brass knob");
            backYard = new OutsideWithDoor("backyard", false, "a screen door");

            livingRoom.Exits = new Location[] { dinningRoom };
            dinningRoom.Exits = new Location[] { livingRoom, kitchen };
            kitchen.Exits = new Location[] { dinningRoom };
            frontYard.Exits = new Location[] { backYard, garden };
            garden.Exits = new Location[] { backYard, frontYard };
            backYard.Exits = new Location[] { frontYard, garden };

            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;

            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;
        }


        private void MoveToANewLocation(Location newLocation)  
        {
            currentLocation = newLocation;
            comboBox1.Items.Clear();

            for (int i = 0; i < currentLocation.Exits.Length; i++)
            {
                comboBox1.Items.Add(currentLocation.Exits[i].Name);
            }

            comboBox1.SelectedIndex = 0;

            // Set the description textbox
            description.Text = currentLocation.Description;

            // Set the "Go through the door
            if (currentLocation is IHasExteriorDoor) { goThroughTheDoor.Visible = true; }
            else                                     { goThroughTheDoor.Visible = false;}
        }

        private void goHere_Click(object sender, EventArgs e)
        {
            MoveToANewLocation(currentLocation.Exits[comboBox1.SelectedIndex]);
        }

        private void goThroughTheDoor_Click(object sender, EventArgs e)
        {
            // faut aller chercher un champ de l'objet attaché à Location
            IHasExteriorDoor thisExtDoor = currentLocation as IHasExteriorDoor;
            MoveToANewLocation(thisExtDoor.DoorLocation);
        }
    }
}
