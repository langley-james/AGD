using System.ComponentModel.DataAnnotations;

namespace AgData.Assessment.BLL
{
    public class Person
    {
        [Required]
        public string Name { get; set; }

        private string? _address;
        public string Address
        {
            get => _address ?? ""; // always return an empty string if Address is null
            set => _address = value;
        }

        public Person(string name, string? address = null)
        {
            // ensuring Name is required
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name), "Name is required.");
            }

            Name = name;
            _address = address; // allow Address to be null during initialization
        }
    }
}