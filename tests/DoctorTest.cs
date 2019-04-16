using System;
using Xunit;
using health_record_app.Models;

namespace tests
{
    public class DoctorTest
    {
        [Fact]

        public void UpdateDoc()
        {
          //Arrange
          var doc = new Doctor(){
              id = 1,
              first_name = "Marcus",
              last_name = "Cambridge",
              social_security_number = "467-99-9485",
              specialty = "Cardiovascular"
          };

          //Update Name
            Console.Write("New name: ");
            var newName = Console.ReadLine();
            doc.UpdateName(newName);
        
             //Update SSN
            Console.Write("New SSN: ");
            var newSSN = Console.ReadLine();
            doc.UpdateSSN(newSSN);
        

        }
    }

}
