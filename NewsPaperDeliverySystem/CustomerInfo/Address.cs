//Written By: Josh Levine, Anand Patel, Alex Ciaramella
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewsPaperDeliverySystem.CustomerInfo
{
    class Address
    {
        //address fields
        String street;
        String zipCode; 
        String city;
        String state;   

        //defult constructor
        public Address()
        {
            street  = "None";
            zipCode = "None";
            city    = "None";
            state   = "None";
        }

        // Purpose:
        //      constructor of the class takes 4 strings and populates the address
        public Address(String street, String zipCode, String city, String state)
        {
            this.street  = street;
            this.zipCode = zipCode;
            this.city    = city;
            this.state   = state;
        }

        //Purpose:
        //  returns the street of the address
        public String getStreet()
        {
            return street;
        }

        //Purpose:
        //  Takes in a string and sets the street to this string
        public void setStreet(String street)
        {
            this.street = street;
        }

        //Purpose:
        //  returns the zipcode of the address
        public String getZipCode()
        {
            return zipCode;
        }

        //Purpose:
        //  Takes in a string and sets the zipCode to this string
        public void setZipCode(String zipCode)
        {
            this.zipCode = zipCode;
        }

        //Purpose:
        //  returns the city of the address
        public String getCity()
        {
            return city;
        }

        //Purpose:
        //  Takes in a string and sets the city to this string
        public void setCity(String city)
        {
            this.city = city;
        }

        //Purpose:
        //  returns the state of the address
        public String getState()
        {
            return state;
        }

        //Purpose:
        //  Takes in a string and sets the state to this string
        public void setState(String state)
        {
            this.state = state;
        }

        //Purpose:
        //  returns a string of all the fields in class
        //  EX: 20 Dickinson street, Glassboro NJ, 08028
        public String toString()
        {
            return street + "," + city + "," + state + "," + zipCode; 
        }
    }
}
