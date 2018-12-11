using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


namespace RandomColoursService1._0
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRandomColoursService" in both code and config file together.
    [ServiceContract]
    public interface IRandomColoursService
    {
        [OperationContract]
        /*Here we are declaring a new service contract. The call will return a Color annd will accept a list of Colours.
        The method is defined in RandomColoursService.svc*/
        Color GenerateRandomColour(List<Color> usedColours);


    }
}
