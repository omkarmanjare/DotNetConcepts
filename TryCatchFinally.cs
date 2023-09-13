using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedConcepts
{
    class TryCatchFinally
    {
        //Normal try catch block 
        void SimpleTryCatch()
        {
            try
            {
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Attempted divide by zero. {0}", ex.Message);
            }
        }
        void TryWithMultipleCatch()  //try catch with multiplel catch
        {
            try
            {
            }
            catch (StackOverflowException ex)
            {
                Console.WriteLine("Overflow. {0}", ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Attempted divide by zero. {0}", ex.Message);

            }
            catch (Exception ex)
            {
                Console.WriteLine("General exception. {0}", ex.Message);
            }
        }

        //try and finally
        void TryFinally()
        {
            try
            {
            }
            finally // we should have catch or finally...one of them atleast
            {
                Console.WriteLine("Clean up start!");
            }
        }

        void TryCatchFinallyy()
        {
            // FileStream fs = default;
            try
            {
            }

            catch (FileNotFoundException ex)
            {
            }

            finally
            {
            }            
        }
        void TryCatchFinallyyu()
        {
            // FileStream fs = default;
            try
            {
                try { Console.WriteLine("Clean up start!"); }
                catch { Console.WriteLine("Clean up start!"); }
                finally { Console.WriteLine("Clean up start!"); }
            }

            catch (FileNotFoundException ex)
            {
                try { Console.WriteLine("Clean up start!"); }
                catch { Console.WriteLine("Clean up start!"); }
                finally { Console.WriteLine("Clean up start!"); }
            }

            finally
            {
                try { Console.WriteLine("Clean up start!"); }
                catch { Console.WriteLine("Clean up start!"); }
                finally { Console.WriteLine("Clean up start!"); }
            }
        }

        // When you do throw ex, that thrown exception becomes the "original" one.So all previous stack trace will not be there.
        // If you do throw, the exception just goes down the line and you'll get the full stack trace.
        void ThrowThrowEx()
        {
            try { }
            catch (Exception ex) { throw new Exception(); }
        }

        void ThrowThrowEx1()
        {
            try { }
            catch { throw; }
        }
    }
}
