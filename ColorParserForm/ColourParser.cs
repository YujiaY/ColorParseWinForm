using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

/* Examples of how to parse Colours data into and out of JSON format.
 */
namespace ColorParserForm
{
    class ColourParserDictionary
    {
        // This method serializes data into Json format.
        public String serializeColoursData(Dictionary<string, string> colourPairs)
        {           
            string jsonString = JsonConvert.SerializeObject(colourPairs);
            System.Diagnostics.Debug.WriteLine(jsonString);
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
