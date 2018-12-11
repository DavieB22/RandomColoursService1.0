using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front_End
{
    public partial class Front_End : Form
    {
        RandomColoursServiceReference.RandomColoursServiceClient ws = null;

        /*3 properties are created that can be used in any method. 
         Set the initial colours which will populate the first usedColours list
         Which is passed to the wcf service with each call and 
         deducted from a new list of available colours to be returned.
          */
        Color BackgroundColour { get; set; } = Color.Red;
        Color ButtonColour { get; set; } = Color.Blue;
        Color TextColour { get; set; } = Color.Gray;
        
        public Front_End()
        {
            InitializeComponent();
            //Set objects colour to = the corresponsing property
            this.BackColor = BackgroundColour;
            btnBackground.BackColor = ButtonColour;
            btnText.BackColor = ButtonColour;
            btnButtons.BackColor = ButtonColour;
            lblTitle.ForeColor = TextColour;
            btnBackground.ForeColor = TextColour;
            btnButtons.ForeColor = TextColour;
            btnText.ForeColor = TextColour;
        }
        private void Front_End_Load(object sender, EventArgs e)
        {
            ws = new RandomColoursServiceReference.RandomColoursServiceClient();
        }

        private void BtnBackground_Click(object sender, EventArgs e)
        {
            //When the button is clicked a new list of usedColours is generate which consists of the three colour properties.
            List<Color> usedColours = new List<Color>() { BackgroundColour, ButtonColour, TextColour };

            /*A new call is made to fill in the background colour with a new random colour. 
            The current colours are passed in with the call and won't return in this call.*/
            BackgroundColour = ws.GenerateRandomColour(usedColours);

            //Change the background to the new random colour.
            this.BackColor = BackgroundColour;
            
        }

        private void BtnButtons_Click(object sender, EventArgs e)
        {
            //When the button is clicked a new list of usedColours is generate which consists of the three colour properties.
            List<Color> usedColours = new List<Color>() { BackgroundColour, ButtonColour, TextColour };

            /*A new call is made to fill in the button colour with a new random colour. 
            The current colours are passed in with the call and won't return in this call.*/
            ButtonColour = ws.GenerateRandomColour(usedColours);

            //Change the buttons colour to the new random colour.
            btnButtons.BackColor = ButtonColour;
            btnText.BackColor = ButtonColour;
            btnBackground.BackColor = ButtonColour;
        }

        private void BtnText_Click(object sender, EventArgs e)
        {
            //When the button is clicked a new list of usedColours is generate which consists of the three colour properties.
            List<Color> usedColours = new List<Color>() { BackgroundColour, ButtonColour, TextColour };

            /*A new call is made to fill in the background colour with a new random colour. 
            The current colours are passed in with the call and won't return in this call.*/
            TextColour = ws.GenerateRandomColour(usedColours);

            //Change the text to the new random colour.
            lblTitle.ForeColor = TextColour;
            btnText.ForeColor = TextColour;
            btnBackground.ForeColor = TextColour;
            btnButtons.ForeColor = TextColour;
        }
       
    }
}
