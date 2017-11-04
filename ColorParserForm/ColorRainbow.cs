using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

/* Examples of how to parse Colours data into and out of JSON format.
 * This class uses a Class as the data structure.
 */
namespace ColorParserForm
{
    class ColorRainbow
    {
        public string name { get; set; }
        public string hexcode { get; set; }

        // To see an example of using a Class as the data structure
        // go to Json.NET documentation at https://www.newtonsoft.com/json/help/html/SerializingJSON.htm

    }
}
