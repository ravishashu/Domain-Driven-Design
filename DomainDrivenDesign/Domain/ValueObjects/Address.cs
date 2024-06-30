﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ValueObjects
{
    namespace Domain.ValueObjects
    {
        public class Address
        {
            public string Street { get; }
            public string City { get; }
            public string State { get; }
            public string ZipCode { get; }

            public Address(string street, string city, string state, string zipCode)
            {
                Street = street;
                City = city;
                State = state;
                ZipCode = zipCode;
            }

            // Override equality methods if necessary
        }
    }

}
