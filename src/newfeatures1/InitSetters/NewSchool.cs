using System;

namespace newfeatures1.InitSetters
{
    public class NewSchool
    {
        private readonly string address;
        public int Number { get; init; }

        public string Address
        {
            get => address;
            init => address = value ?? throw new ArgumentNullException(nameof(Address));
        }
    }
}