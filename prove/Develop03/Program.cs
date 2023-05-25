using System;

class Program
{
  static void Main(string[] args)
  {
    // create random class object

    // Create class object (instantiate) (create an instanxe of)
    // (access type *when its a class attribute*) (class type) (object name) = new (constructor)
    Scripture scripture1 = new Scripture("And it came to pass");
    References reference1 = new References("John", "3", "5");

    // created embedded function (method)
    bool Display()
    {
        foreach (Word word in scripture1.GetWords())
        {
            Console.Write(word.GetWord() + " ");
        }
        // print the reference by calling the GetRefernce method (reference1.GetReference())

        // call the GetWordsHIdden
        // if that return is true
            // return false

        // Ask the user if they want to quit or continue
        // capture input in a variable
        // if input was "quit"
        //      return false
        // else return true
    }

    // while(Display())
    //  use a loop and random class to hide three words
    
    






  }
}