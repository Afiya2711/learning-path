using System;
namespace Component1
{
    public class Adiition
    {
        private int i=0,j=0;
        public int var1
        {
            get
            {
                return i;
            }
            System{
                i=value;
            }
        }
        public int var3
        {
            get{return j;}
            set{j=value}
        }
        public int Sum()
        {
            return  i+j;
        }
    }
}
