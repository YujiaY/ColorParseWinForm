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

/* Examples of how to parse Colours data into and out of JSON format.
 * Author: Ivone Bennett, NM Tafe, 31/8/2017
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
            Dictionary<string, string> colourPairs = new Dictionary<string, string>();
            //The built-in class System.Drawing.Color has heaps of pre-defined colours
            colourPairs.Add("aliceblue", "#f0f8ff");
            colourPairs.Add("antiquewhite", "#faebd7");
            colourPairs.Add("brown", "#a52a2a");

            // First, convert colours in Dictionary data structure to a Json string
            string output = cp.serializeColoursData(colourPairs);
            labelJsonString.Text = output;

            // Next, convert the Json string back to a Dictionary object
            Dictionary<string, string> myColoursDic = cp.deserialiseColoursData(output);
            // Logging - writes to the debugger output window, not to a log file.
            System.Diagnostics.Debug.WriteLine("aliceblue hex code is " + myColoursDic["aliceblue"]);
            System.Diagnostics.Debug.WriteLine("antiquewhite hex code is " + myColoursDic["antiquewhite"]);

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
            // set up colours data
            ColorRainbow[] crArr = new ColorRainbow[3];
            ColorRainbow cr = new ColorRainbow();
            cr.name = "aliceblue";
            cr.hexcode = "#f0f8ff";
            crArr[0] = cr;
            cr = new ColorRainbow();
            cr.name = "antiquewhite";
            cr.hexcode = "#faebd7";
            crArr[1] = cr;
            cr = new ColorRainbow();
            cr.name = "brown";
            cr.hexcode = "#a52a2a";
            crArr[2] = cr;

            // Convert to Json and back again
            string output = JsonConvert.SerializeObject(crArr);
            labelJsonString.Text = output;

            ColorRainbow[] myColours = JsonConvert.DeserializeObject<ColorRainbow[]>(output);

            // Display colours in a Listbox on the screen
            ListBox lb = new ListBox();
            foreach (var cra in crArr) // implicitly defined datatype for variable dic
            {
                System.Diagnostics.Debug.WriteLine("colour key is " + cra.name);
                System.Diagnostics.Debug.WriteLine("colour hexcode is " + cra.hexcode);
                lb.Items.Add(cra.name);
            }
            flowLayoutPanelColors.Controls.Add(lb);
        }

        // Note: You can use JSONSerializer to write to and from text files.
    }
}
