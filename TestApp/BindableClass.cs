using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class BindableClass : IEnumerable
    {
        public string Name { get; set; }
        public int Age { get; set; }

        int[] people = new[] { 1, 2, 3 };
        int currentElement = 0;

        public IEnumerator GetEnumerator()
        {
            int actualElement = people[currentElement];
            yield return actualElement;
            currentElement++;
        }

        public override string ToString()
        {
            return $"{Name} : {Age}";
        }
    }
}
