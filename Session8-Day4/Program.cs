using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session8_Day4
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("Name", "RAM");
            ht.Add("Age", "34");
            ht.Add("City", "NOIDA");
            ht.Add("Gender", "MALE");
            ht.Add(5, 345);
            Console.WriteLine(ht.ToString());//writtern System.Collections.Hashtable

            Console.Write(ht.GetHashCode());// hash code of ht-> 46104728345  
          

            foreach (object key in ht.Keys)
            {
                //Console.WriteLine("" + ht[key] + ""); // It will writtern vaules 345, RAM,34,NOIDA,MALE
               // Console.WriteLine($"a value is key {key} \t ");// It will writtern  5,Name,Age ,City ,Gender
            }

            foreach (object key in ht.Values)
            {
               Console.WriteLine($"{key}");//It will writtern vaules 345, RAM,34,NOIDA,MALE
               Console.WriteLine($"a value is key {key} \t ");//It will writtern vaules 345, RAM,34,NOIDA,MALE
            }
           // Console.WriteLine(ht["Gender"]);


            Console.ReadKey();

            //================================================================================================================================
            //   ArrayList arrayList= new ArrayList();
            //    arrayList.Add(50);
            //    arrayList.Add(60);
            //    arrayList.Add(7);
            //      arrayList.Add(5);
            //    arrayList.Add(100);
            //    arrayList.Add(6);
            //    arrayList.Add(90);
            //    //arrayList.Add("AKSHAT");
            //    arrayList.Insert(3, 555);
            //    arrayList.RemoveAt(0);//remove 0th index value
            //    arrayList.Remove(5);//remove value of 5 ,which is first come in arraylist 
            //    arrayList.Sort();//sort homogeneous data in array by assending order 6,7,50,60,90,100,555
            //    foreach (object i in arrayList)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    Console.WriteLine("array capacity is:"+arrayList.Capacity);
            //    Console.ReadKey();


        }
        }
}
