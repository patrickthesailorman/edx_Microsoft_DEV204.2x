using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edx_Microsoft_DEV204._2x
{
    // Defining Class Members
    public class DrinksMachine
    {
      // The following statements define a property with a private field.
      private string _location;
      public string Location
      {
          get
          {
            return _location;
          }
          set
          {
            if (value != null) 
                _location = value;
          }
      }
      // The following statements define properties.
      public string Make {get; set;}
      public string Model {get; set;}
      // The following statements define methods.
      public void MakeCappuccino()
      {
          // Method logic goes here.
      }
      public void MakeEspresso()
      {
          // Method logic goes here.
      }
      // The following statement defines an event. The delegate definition is not shown.
      public event OutOfBeansHandler OutOfBeans;
    }

    public partial class DrinksMachine
    {

      public void MakeCappuccino()
      {
          // Method logic goes here.
      }
    }

    public partial class DrinksMachine
    {

      public void MakeEspresso()
      {
          // Method logic goes here.
      }
    }
}