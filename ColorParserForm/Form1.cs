using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

/* Examples of how to parse Colours data into and out of JSON format.
 */
namespace ColorParserForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // This example uses dictionary objects
        private void btnJsonDictionary_Click(object sender, EventArgs e)
        {
            ColourParserDictionary cp = new ColourParserDictionary();

            // Set up some colours data (must be key-value pairs)

            //Read clor setup from text file:
            string jsonallfile = File.ReadAllText(@"..\\..\\..\\jsonColoursHex.txt");
                        
            IList<ColorRainbow> crs = JsonConvert.DeserializeObject<List<ColorRainbow>>(jsonallfile);


            // Old method ,only usable for format like:
            //  { "name":"aliceblue","hexcode":"#f0f8ff"}{ "name":"antiquewhite","hexcode":"#faebd7"}
            /*
             * 
            IList<ColorRainbow> crs = new List<ColorRainbow>();
            JsonTextReader reader = new JsonTextReader(new StringReader(jsonallfile));
            reader.SupportMultipleContent = true;

            while (true)
            {
                if (!reader.Read())
                {
                    break;
                }

                JsonSerializer serializer = new JsonSerializer();
                ColorRainbow crtemp = serializer.Deserialize<ColorRainbow>(reader);

                crs.Add(crtemp);
            }
            */
            //End of old method

            Dictionary<string, string> colourPairs = new Dictionary<string, string>();
            //The built-in class System.Drawing.Color has heaps of pre-defined colours

            foreach (var crb in crs)
            {
                colourPairs.Add(crb.name, crb.hexcode);
            }

            // First, convert colours in Dictionary data structure to a Json string
            string output = cp.serializeColoursData(colourPairs);
            labelJsonString.Text = output;

            // Next, convert the Json string back to a Dictionary object
            Dictionary<string, string> myColoursDic = cp.deserialiseColoursData(output);
            // Logging - writes to the debugger output window, not to a log file.

           // System.Diagnostics.Debug.WriteLine("aliceblue hex code is " + myColoursDic["aliceblue"]);
           // System.Diagnostics.Debug.WriteLine("antiquewhite hex code is " + myColoursDic["antiquewhite"]);

            // Dynamically display the colours on the screen
            foreach (var dic in colourPairs) // implicitly defined datatype for variable dic
            {
                System.Diagnostics.Debug.WriteLine("colour key is " + dic.Key.ToString());
                Label lblColor = new Label();
                lblColor.Text = dic.Key.ToString();
                Color dicColor = ColorTranslator.FromHtml(dic.Value.ToString());
                lblColor.BackColor = dicColor;
                lblColor.AutoSize = true;                
                flowLayoutPanelColors.Controls.Add(lblColor);               
            }
        }

        // This example uses an array of class objects
        private void btnJsonClass_Click(object sender, EventArgs e)
        {
            //Read clor setup from text file:
            string jsonallfile = File.ReadAllText(@"..\\..\\..\\jsonColoursHex.txt");

            IList<ColorRainbow> crs = JsonConvert.DeserializeObject<List<ColorRainbow>>(jsonallfile);

            //
            //End of Another way part1
            //

            // Convert to Json and back again
            string output = JsonConvert.SerializeObject(crs);
            labelJsonString.Text = output;

            //Output to file

            System.IO.File.WriteAllText(@"..\..\..\jsonColoursHexOutput.txt", output);

            // Display colours in a Listbox on the screen

            ListBox lb = new ListBox();
            foreach (var crb in crs) // implicitly defined datatype for variable dic
            {
                System.Diagnostics.Debug.WriteLine("Colour Name is " + crb.name);
                System.Diagnostics.Debug.WriteLine("Colour Hexcode is " + crb.hexcode);
                lb.Items.Add(crb.name);
            }
            //
            
            //
            flowLayoutPanelColors.Controls.Add(lb);
        }

        

        // Note: You can use JSONSerializer to write to and from text files.
    }
}
