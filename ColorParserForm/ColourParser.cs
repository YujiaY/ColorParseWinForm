using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

/* Examples of how to parse Colours data into and out of JSON format.
 * This class uses a Dictionary as the data structure.
 */
namespace ColorParserForm
{
    class ColourParserDictionary
    {
        // This method serializes data into Json format.
        // Input: A key-value pair data structure (in this case a Dictionary)
        // Output: a Json string 
        public String serializeColoursData(Dictionary<string, string> colourPairs)
        {           
            string jsonString = JsonConvert.SerializeObject(colourPairs);
            System.Diagnostics.Debug.WriteLine(jsonString); // Logging - writes to the debugger output window, not to a log file.
            return jsonString;
        }     

        // This method deserializes a Json formatted string into a key-value pair data structure.
        public Dictionary<string, string> deserialiseColoursData(string inputJsonString)
        {
            Dictionary<string, string> favColours = JsonConvert.DeserializeObject<Dictionary<string, string>>(inputJsonString);            
            return favColours;
        }
        
    }
}
