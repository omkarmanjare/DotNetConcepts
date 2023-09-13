using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedConcepts
{
    //1. A class marked as sealed will have all its methods sealed by default
    //2. Sealed class and sealed method in C# programming is used to stop a developer to extend a class or override a method accidentally
    //3. Sealed class can be instantiated but cannot be inheritated further
    //4.As insatnce of sealed calss can be created , sealed classes can have normal and statis constructor
    //5. By default all static classes are sealed i.e. they cannot be inherited
    //6.If we don’t want to allow subclasses to override the superclass method and to ensure that all sub-classes use the same superclass method logic then that method should be declared as sealed


    public sealed class Employee 
    {        
    }

    //This one wont compile
    //public class Manager : Employee {}
    
    // *******************

    public class Emplyee_1 
    {
        public virtual void Method1() {}
    }

    public class Emplyee_2 : Emplyee_1
    {
        sealed public override void Method1(){}
    }
    public class Emplyee_3 : Emplyee_2
    {
        //won't compile as this Method1() is makerd as sealed and cannot be overridden further
       // public override void Method1() { } 
    }
    //***********************************************************

   
}
