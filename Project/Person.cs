using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Person
    {
        #region access modifier  
        /* The type or member can be accessed by any other code in the same assembly or another assembly that references it.*/
        #endregion

        #region abstract class characteristics
        /*classes that cannot be instantiated, and are frequently either partially implemented, 
         * or not at all implemented. The abstract modifier indicates that the thing being modified 
         * has a missing or incomplete implementation. 
         * This incomplete characteristic of an abstract class is not something to be worried about 
         * as the subclasses that use the abstract class will extend and ultimately complete its implementation
         * Abstract classes have the following features:
                    • An abstract class cannot be instantiated.
                    • An abstract class may contain abstract methods and accessors.
                    • A non-abstract class derived from an abstract class must include actual implementations of all inherited abstract methods and accessors.*/
        #endregion

        #region data members
        private string Id, name, Phone, Dates, Status;
        #endregion

        #region Properties
        public string ID
        {
            get { return Id; }
            set { Id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Telephone
        {
            get { return Phone; }
            set { Phone = value; }
        }
        public string dates
        {
            get { return Dates; }
            set { Dates = value; }
        }
        public string status
        {
            get { return Status; }
            set { Status = value; }
        }
        #endregion

        #region Construtor
        public Person()
        {
            Id = "";
            name = "";
            Phone = "";
        }

        public Person(string pID, string pName, string pPhone)
        {
            Id = pID;
            name = pName;
            Phone = pPhone;
        }
        #endregion

        #region ToStringMethod
        public override string ToString()
        {
            return name + '\n' + Phone;
        }

        #endregion
    }
}
