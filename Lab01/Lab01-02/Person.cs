using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_02
{
    class Person
    {
        private string personID;
        private string fullName;

        public string PersonID
        {
            get
            {
                return personID;
            }
            set
            {
                personID = value;
            }
        }
        public string FullName
        {
            get
            {
                return fullName;
            }
            set
            {
                fullName = value;
            }
        }


        public Person() 
        { 
        
        }

        public Person(string id, string name)
        {
            personID = id;
            FullName = name;
        }

        public virtual void Nhap()
        {
            Console.Write(" Nhap ID: ");
            PersonID = Console.ReadLine();

            Console.Write(" Nhap Ho va Ten: ");
            FullName = Console.ReadLine();
        }

        public virtual void Xuat()
        {
            Console.Write("Ho Ten:{0} \t ID:{1}",this.fullName, this.personID);

        }
    }
}
