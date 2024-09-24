using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgData.Assessment.BLL
{
    public class PersonService
    {
        public Person SavePersonData(string name, string? address)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name is required.");
            }

            // Mock returning the entered data
            return new Person(name, address);
        }
    }
}
