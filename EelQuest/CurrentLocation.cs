using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EelQuest
{

    public class CurrentLocation
    {

        // I don't think I need this to be a singleton but maybe later
        // private static readonly Lazy<LocationManager> lazy = new Lazy<LocationManager>(() => new LocationManager());
        // public static LocationManager Instance { get { return lazy.Value; } }

        ParseData parseData;

        int roomID;
        string roomName;
        string description;
        List<Exit> exits = new List<Exit>();
        
        public CurrentLocation()
        {
            parseData = new ParseData();
            roomID = 0;
            UpdateFields(roomID);
        }

        public void PrintCurrentLocationData()
        {
            Console.WriteLine(roomID);
            Console.WriteLine(roomName);
            Console.WriteLine(description);

            foreach (var exit in exits)
            {
                Console.WriteLine(exit.Name);
                Console.WriteLine(exit.Destination);
            }
        }

        private void UpdateFields(int newID)
        {
            roomName = parseData.locationData.Locations[newID].Name;
            description = parseData.locationData.Locations[newID].Description;

            foreach (Exit exit in parseData.locationData.Locations[newID].Exits)
            {
                exits.Add(exit);
            }

        }

        public void ChangeRoom(int destinationID)
        {
            roomID = destinationID;
            UpdateFields(roomID);
        }

    }
}

