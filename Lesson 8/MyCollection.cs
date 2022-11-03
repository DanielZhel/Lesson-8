using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8
{
    public class MyCollection : Collection<int>
    {
        public int Value { get; set; }

        public static MyCollection operator +(MyCollection myCollection1, MyCollection myCollection2)
        {
            
            return new MyCollection { Value = myCollection1.Value + myCollection2.Value };
        }

        
    }
}
