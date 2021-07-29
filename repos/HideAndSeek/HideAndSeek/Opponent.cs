using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HideAndSeek
{
    class Opponent
    {
        private Location MyLocation;
        private Random randomMove;

        public Opponent(Location hidingLocation)
        {
            MyLocation = hidingLocation;
            randomMove = new Random();
            

            // find the random hiding place
            for(int i = 0; i<10; i++)
            {
                Move();
            }
        }

        // Move the opponent from his current location to an new location. 
        public void Move()
        {
            Random randomMove = new Random();
            Random random = new Random();
            int workVar;

            // Room with door ? Flip a coin 
            if(MyLocation is IHasExteriorDoor)
            {
                if (randomMove.Next(2) == 1) // passer par la porte
                {
                    IHasExteriorDoor locationDoor = MyLocation as IHasExteriorDoor ;
                    MyLocation = locationDoor.DoorLocation;
                }

                // Choose one of the exits ramdomly
                // déterminer combien de location il y a
                do
                {
                    workVar = MyLocation.Exits.Length;
                    workVar = randomMove.Next(workVar);
                    MyLocation = MyLocation.Exits[workVar];
                } while (!(MyLocation is IHasHidingPlace)); 
            }

        }

        public bool Check(Location location)
        {
            return location == MyLocation ;
        }

    }
}
