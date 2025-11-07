using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductObject
{
    class Product
    {
        // A private field that stores the actual name value (accessible only inside this class)
        private string Name;

        public string Description;

        public int Price;

        // A public property that controls access to the private field 'Name'
        public string Name_ {
            //bunu ise propertyni mueyyen sert odendikde cixartmaq ucun istifade edirik
            // The 'get' accessor controls how the value is read 
            get
            {
                if(Price>500)
                {
                    return Name;
                }
                return null;
            }

            //bunu umumi deyisiklikler etmek ucun istifade edirik
            // The 'set' accessor controls how the value is assigned
            set
            {
                value = value.Trim();
                
                if (value.Length >3)
                {
                    //char firstLetter = value[0];
                    //firstLetter = char.ToUpper(firstLetter);
                    string firstLetter = value[0].ToString().ToUpper();//bele de isleyir; yuxaridaki kimi de
                    string restLetters = value.Substring(1);
                    restLetters = restLetters.ToLower();
                    string word = firstLetter + restLetters;
                    Name = word;
                }
                // If it doesn't meet the condition, nothing happens (the value is ignored)
            }
        }
        //property istifade edende ctorun icinde de field evezine propertyni yazirsiniz(Name_)
        public Product(string name, string description, int price)
        {
            Name_ = name; //propertyni(Name_) qeyd edirik; fieldi yox(Name)
            Description = description;
            Price = price;
        }

        public virtual void SayName()
        {
            Console.WriteLine($"Name: {Name}");
        }
    }
}

