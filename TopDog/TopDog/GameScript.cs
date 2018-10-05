using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace TopDog
{
    /// <summary>
    /// This contains all the stuff needed for the game to run.
    /// </summary>
    class GameScript
    {
        private int cardNum;
        JsonSerializer serializer = new JsonSerializer();
        

        /// <summary>
        /// Loads the Database and gets the game ready
        /// </summary>
        public void LoadStuff()
        {
            cardNum = 4;
            //serializer.Converters.Add(new JavaScriptDateTimeConverter());
            serializer.NullValueHandling = NullValueHandling.Ignore;
            StreamReader sw = new StreamReader("DogData.txt");

        } 
    }
}
