using System;
using Xunit;
using health_record_app.Models;

namespace tests
{
    public class DoctorTest
    {
        [Fact]

        public void UpdateName()
        {

          //Update Name
            Console.Write("New name: ");
            var newName = Console.ReadLine();
            book.UpdateName(newName);
        
        }

        public void UpdateSSN(){
             //Update SSN
            Console.Write("New publisher: ");
            var newSSN = Console.ReadLine();
            book.UpdateSSN(newSSN);

        }
    }

}
