using System;
using System.Text;
using ConsoleApp1;
//Console.WriteLine("Hello, World!");


/*
 1.What type would you choose for the following “numbers”?
        A person’s telephone number
            => String because a phone number can contain various character
               such as digits,hyphens, parentheses, and plus signs, and they can
               vary in length.

        A person’s height
            => double because if I were to store the height in meters.
               If I wanted to store height in feet and inches, I would ccreate a
               custom object with feet and inches integer fields.

        A person’s age
            => integer data type but if I wanted to go precise memory wise, I
               would use byte or short.

        A person’s gender (Male, Female, Prefer Not To Answer)
            => String

        A person’s salary
            =>decimal because it is the high precision floating point number.

        A book’s ISBN
            =>String because they are not used for mathematical claculation and
              they consist of 13 to 14 character with hyphens.

        A book’s price
            =>decimal because it is the high precision floating point number.

        A book’s shipping weight
            => double or decimal

        A country’s population
            =>ulong because it can hold because they can store integer values up
              to 64 bit and the populatioon can never be negative.

        The number of stars in the universe
            =>BigInteger data type available in the System.Numerics because the
              number of stars in the universe is a very lareg number that
              exceeds the range of the built-in numeric data types in C#.

        The number of employees in each of the small or medium businesses in the
        United Kingdom (up to about 50,000 employees per business
            => ulong as it can store upto 64 bits of positive integers.

2. What are the difference between value type and reference type variables? What is
boxing and unboxing?
    =>Value type variables are the variables thatthat directly contains its data in memory
      whereas reference type is a data type that holds a reference to the memory
      location where the actual data is stored.Value types and references are
      stored in stack memory, and reference type(object, array) are stored in
      heap memory.Value type will not be collected by garbage collector, while
      reference type will be collected by a garbage collector.Value type can be
      created by Struct or Enum, while reference type can be created by class,
      interface, delegate or array.Value type cannot accept null values, but
      reference type can accept null values.
            Boxing is process of wrapping value type to reference type. Unboxing
      is unwrrappig refrence type to value type.

3. What is meant by the terms managed resource and unmanaged resource in .NET?
    =>A managed resource is any resource that is managed by the .NET runtime,
      such as memory allocated by the Common Language Runtime (CLR) for objects
      created by the managed code. An unmanaged resource is any resource that is
      not managed by the CLR.

4. Whats the purpose of Garbage Collector in .NET?
    => Garbage collector automatically tracks the use of memory by the
      application and releases memory that is no longer needed, freeing up
      memory for other parts of the application. Garbage collector manages the
      managed heap where the reference types get stored. It periodically scans
      the managed heap to identify objects that are no longer referenced by the
      application and frees up the space.



***************Controlling Flow and Converting Types********************

 1. What happens when you divide an int variable by 0?
    =>Dividing an integer variable by 0 in C# results in a runtime error called
    "DivideByZeroException"

2.What happens when you divide a double variable by 0?
    =>Dividing a double variable by 0 in C# produces a special value called
    "infinity" or "NaN".

3.What happens when you overflow an int variable, that is, set it to a value beyond its
range?
    =>Overflowing an int variable (or any other numeric type) can result
    inunexpected behavior.When an int variable is set to a value beyond its
    range,the variable wraps around to the other end of the range. This is
    called an "overflow".

4.What is the difference between x = y++; and x = ++y;?
    =>x = y++; assigns the current value of y to x, and then increments the
          value of y. The value of y is incremented after the assignment takes
          place.
      x = ++y; increments the value of y first, and then assigns the incremented
          value to x. The value of y is incremented before the assignment takes
          place.

5. What is the difference between break, continue, and return when used inside a loop
statement?
    =>Break is used to terminate a loop, continue is used to skip
      the remaining statements in a loop body for the current iteration, and
      return is used to exit the loop and the function that contains the loop.

6.What are the three parts of a for statement and which of them are required?
    => A for statement consists of three parts separated by a semicolon;
       initalization, condition and iteration. Of the three parts, only the
       condition is required; the initialization and iteration parts are optional.

       for(initalization; condition; iteration){ }

7. What is the difference between the = and == operators?
    =>The = operator is the assignment operator, used to assign a value to a variable.
      On the other hand, the == operator is the equality operator, used to
      compare two values to see if they are equal.

8. Does the following statement compile? for ( ; true; ) ;
    => Yes it compiles because even though it does not have initalization and
       iteration part, which are optional, it has got condition part which is
       mandatory field for for loop.

9. What does the underscore _ represent in a switch expression?
    =>The underscore (_) character replaces the default keyword to signify that
      it should match anything if reached

10.What interface must an object implement to be enumerated over by using the
foreach statement?
    => The IEnumerable interface provides iteration over a collection-type
        object in a class.
 
 
 ******************************************************************************


What will happen if this code executes?
int max = 500;
for (byte i = 0; i < max; i++)
{
WriteLine(i);
}
Create a console application and enter the preceding code. Run the console application
and view the output. What happens?
What code could you add (don’t change any of the preceding code) to warn us about the
problem?

=> First of all, we have to write Console and dot operator before WriteLine andeLine
 and after that, byte can only store value from 0 to from 0 to 255. The loop
iterates till 500, so there is an integer overflow after 255 and the loop restarts from 0
making it continous loop.

 
 *****************************Arrays And String******************************
 

1. When to use String vs. StringBuilder in C# ?
    =>Since String is immutable, it is very good to store some sensitive data like
    username and password. Because once you assign a value to it, the value
    itself can not be modified. StringBuilder is mutable so we use it inside the
    method implementation so that we can modify the strings based on the needs.

2. What is the base class for all arrays in C#?
    =>The System.Array class is the base class for all the arrays in C#

3. How do you sort an array in C#?
    =>The way to sort an array in C# is using Array.Sort method,which sorts the
      elements of an array in ascending order.

4. What property of an array object can be used to get the total number of
    elements  an array?
    =>The Length property of an array object to get the total number of elements
    in the array.

5. Can you store multiple data types in System.Array?
    =>Yes, we can store multiple data types in a System.Array in C#. However,
      it is important to note that when you store different data types in an
      array, the array is treated as an array of objects, and each element in
      the array must be boxed to an object reference.

6. What’s the difference between the System.Array.CopyTo() and
   System.Array.Clone()?
   =>Both the System.Array.CopyTo() and System.Array.Clone() methods allow you
    to create a copy of an array in C#.The System.Array.CopyTo() method copies
    the entire array into an existing array, starting at a specified index.

    The System.Array.Clone() method creates a shallow copy of the array. This
    means that it creates a new array with the same length and elements as the
    original array, but the new array is a separate object in memory.                                                                                                
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 */

//FizzBuzz fizz = new FizzBuzz();
//fizz.CountingGame();

//RandomNumber random = new RandomNumber();
//random.calculation();

//PrintPyramid printPyramid = new PrintPyramid();
//printPyramid.Print();

//ManageList list = new ManageList();
//list.ModifyList();

//RotateArray array = new RotateArray();
//array.Rotate();

//LongestSequence longest = new LongestSequence();
//longest.FindLongestSequence();

//FrequentNumber num = new FrequentNumber();
//num.FindFrequentNumber();

//ReverseString str = new ReverseString();
//str.ReverseUsingArray();
//str.ReverseUsingLoop();

//ReverseSentence reverse = new ReverseSentence();
//reverse.Reverse();

//Palindrome palindrome = new Palindrome();
//palindrome.FindPalindrome();

ParseUrl parseUrl = new ParseUrl();
parseUrl.Parse();