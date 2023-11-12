using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperclassMethodAssignment
{
    public abstract class Person
    {
        //create a class called Person and give it two properties, each of data type string
        //one called FirstName, the other LastName
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //give the class a void method called SayName() that takes no parameters and simply writes
        //the person's full name to the console in the format of "Name:[full name]"
        public abstract void SayName();

    }
}
