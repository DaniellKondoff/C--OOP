using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Mankind
{
    public class Human
    {
        protected string nameFirst;
        protected string nameLast;

        public Human(string nameFirst, string nameLast)
        {
            this.NameFirst = nameFirst;
            this.NameLast = nameLast;
        }

        public string NameFirst
        {
            get { return this.nameFirst; }
            private set
            {
                char firstLetter = value[0];
                if (char.IsLower(firstLetter))
                {
                    throw new ArgumentException("Expected upper case letter!Argument: firstName");
                }

                if (value.Length<4)
                {
                    throw new ArgumentException("Expected length at least 4 symbols!Argument: firstName");
                }

                this.nameFirst = value;
            }
        }

        public string NameLast
        {
            get
            {
                return this.nameLast;
            }

           private set
            {
                char lastLetter = value[0];
                if (char.IsLower(lastLetter))
                {
                    throw new ArgumentException("Expected upper case letter!Argument: lastName");
                }

                if (value.Length < 3)
                {
                    throw new ArgumentException("Expected length at least 3 symbols!Argument: lastName");
                }

                this.nameLast = value;
            }
        }
    }
}
