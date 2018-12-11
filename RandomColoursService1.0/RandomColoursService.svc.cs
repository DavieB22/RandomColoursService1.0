using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
//This assembly reference is required to used the Color type
using System.Drawing;

namespace RandomColoursService1._0
{ 
    //Here the service contract that we declared IRandomColoursService.cs is defined.  
    public class RandomColoursService : IRandomColoursService
    {
       //UsedColours is passed into the method from front_End form when the front_End makes a call.
       //The method accepts a list of Used colours and returns a single colour. Colours - usedColours = availableColours. 
       //A single colour from the available colours list is returned per call. 
       public Color GenerateRandomColour(List<Color> usedColours)
        {
            //This is the initial List of 6 colours that that service could potentially return.
            List<Color> colours = new List<Color>{ Color.Red, Color.Blue, Color.Purple, Color.Black, Color.White, Color.Gray };

            //create new instance of random used to randomise the returning of a colour.
            Random rand = new Random();

            //Create new list of available colours. Colours - usedcolours = available colours. 
            List<Color> availableColours = colours.Except(usedColours).ToList();

            //return a single colour per call of a random number between 0 whats left in available colours once the three object colours are removed.
            return availableColours[rand.Next(0, availableColours.Count)];
        }
    }
}
