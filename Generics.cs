using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedConcepts
{
    //Generic vs NonGeneric Collections
    //Error prone: since non-generic collections are untyped, it requires frequent casting between object and the actual type you're expecting.
    //Since the compiler can't check that your types are consistent, it's easier to put the wrong type in the wrong collection.
    //Less performant: generic collections have the advantage that value types don't have to be boxed as object.
    //For instance, a List<int> stores its data in an int[]. That's far better than storing the data in object[] as that requires boxing.

    class NonGenericCollections
    {
        public ArrayList arrayList;
        public SortedList sortedList; 
        public NonGenericCollections()
        {
            arrayList = new ArrayList();
        }

        #region ArrayList
        //Array : HArray has a fixed size, strongly-typed.It means if we declare an Array of string type, then we cannot store the integer value in that array.
        //The array provides better performance than the ArrayList because an array stores the same type of data which doesn't need unnecessary boxing or unboxing.Arrays dont store null
        //ArrayLists do not have a specific size. When we initialize an arraylist, it will initially allocate the memory for 4 elements. When we add the 5th element,
        //ArrayList will automatically redimension to double of its current size. So, the size will increase as 4, 8, 16
        // you can store any type of data in ArrayList.ArrayList can store null.
        public void ArrayList()
        {
            arrayList.Add("123");
            arrayList.Add(123);  //Also methods to Insert, Remove, RemoveAt
            foreach(Object obj in arrayList)
            {
                Console.WriteLine("{0}", obj);
            }
            
        }
        #endregion

        #region SortedList
        public void SortedList()
        {
            sortedList = new SortedList();
            sortedList.Add("XYZ", "!");
            sortedList.Add("PQR", "World");
            sortedList.Add("@#$", "Hello");
            sortedList.Add("ABC", "Hello");
            sortedList.Add(1234, "Hello");
            for (int i = 0; i < sortedList.Count; i++)
            {
                Console.WriteLine("\t{0}:\t{1}", sortedList.GetKey(i), sortedList.GetByIndex(i));
            }
            Console.WriteLine();
        }
        #endregion

        #region Hashtable
        //Each element is a key/value pair stored in a DictionaryEntry object. A key cannot be null, but a value can be.
        // A HashTable is immutable and cannot have duplicate entries. 
        //When items are added to a hash table, a hash code is generated automatically. This code is hidden from the developer.
        //All access to the table's values is achieved using the key object for identification.
        //As the items in the collection are sorted according to the hidden hash code, the items should be considered to be randomly ordered.
        //The performance of the hashtable is less as compared to the ArrayList because of this key conversion (converting the key to an integer hashcode).
        public void Hashtable() {
            Hashtable numberNames = new Hashtable();
            numberNames.Add(1, "One"); //adding a key/value using the Add() method
            numberNames.Add(2, "Two");
            numberNames.Add("QAZ", "Three");
            numberNames["12112"] = 1;

            //to get all keys or all values only

            ICollection valueColl = numberNames.Values;
            ICollection keyColl = numberNames.Keys;

            Console.WriteLine(numberNames["QAZ"]);
            numberNames.Remove("1"); 
            foreach (object i in numberNames.Keys)
                Console.WriteLine(i);
            foreach (object J in numberNames.Values)
                Console.WriteLine(J);
            foreach (DictionaryEntry di in numberNames)
                Console.WriteLine("keys={0} values={1}", di.Key, di.Value);
            Console.ReadKey();

            //clone method
            Hashtable cloneHashtable = (Hashtable)numberNames.Clone();

        }
        #endregion

        #region LinkedList
        #endregion

        #region Dictionary
        #endregion


        #region Stack
        #endregion


        #region Queue
        #endregion


    }

    // SortedList<TKey, TValue> vs SortedDictionary<TKey, TValue>

    class Generics
    {
    }
}
