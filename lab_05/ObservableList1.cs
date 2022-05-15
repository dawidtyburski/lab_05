using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_05
{
    public class ObservableList1<T>
    {
        
        private List<T> objects = new List<T>();

        public int Length()
        {
            if (objects.Count > 0)
            {
                return objects.Count;
            }
            else return 0;
        }
        
        public void Add(T param)
        {
            objects.Add(param);
            Console.WriteLine($"{param} added");

        }
        public T Get(int index)
        {
            if (index < objects.Count)
            {
                return objects[index];
            }
            else return default(T);
        }
        public void Set(string index, string newValue)
        {
            objects[Int32.Parse(index)] = (T)Convert.ChangeType(newValue, typeof(T));
        }
        public void RemoveAt(int index)
        {
            List<T> obj = new List<T>();

            for(int j = 0; j< objects.Count; j++)
            {
                 if (j != index)
                 {
                     obj.Add(objects[j]);
                 }
                 else continue;
            }
            objects = obj;                
        }
    }
}
