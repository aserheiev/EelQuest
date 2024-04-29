using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace EelQuest
{

    public class LocationData
    {
        public Location[] Locations { get; set; }
    }

    public class Location
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Exit[] Exits { get; set; }
        public Object[] Objects { get; set; }
    }

    public class Exit
    {
        public int Destination { get; set; }
        public string Name { get; set; }
        public bool Obvious { get; set; }
    }

    public class Object
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LookDescription { get; set; }
        public string GetDescription { get; set; }
        public string MainDialogue { get; set; }
        public string SecondaryDialogue { get; set; }
        public string TertiaryDialogue { get; set; }
        public bool CanPickup { get; set; }
        public bool PickedUp { get; set; }
        public bool IsAnEel { get; set; }
        public DialogueTopic[] Dialoguetopics { get; set; }
    }

    public class DialogueTopic
    {
        public string Subject { get; set; }
        public string Response { get; set; }
        public string SecondaryResponse { get; set; }
    }
    
    public class ParseData
    {
        public LocationData locationData;
        
        string jsonData = File.ReadAllText(@"..\..\locations.json");

        private void LocationParse()
        {
            locationData = JsonConvert.DeserializeObject<LocationData>(jsonData);
        }

        public ParseData()
        {
            LocationParse();
        }

    }

}
