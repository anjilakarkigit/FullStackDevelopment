using ConsoleApp2 ;
using ConsoleApp2.ObjectOrientedConcepts;

// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

/*
 03 Object-Oriented Programming
Test your knowledge

1. What are the six combinations of access modifier keywords and what do they do? 
=> The six six combinations of access modifier keywords are:
a.Public: accessible everywhere
b.Protected: accessible in the same class or derived class
c.Internal: accessible in the same assembly
d.Private: accessible only in current class
e.protected internal: access to the member from within the same assembly and any class that derives from 
f.private protected: access to the member within the same class and any class that derives from it and 
    is also within the same assembly.

2.What is the difference between the static, const, and readonly keywords when applied to
a type member?
=>static: members belong to the class itself instead of any instance
 const: used to define a compile-time constant value that is fixed and cannot be changed at runtime.
 readonly: a value that is fixed and cannot be changed after it is initialized.
 
 Static members belong to the type itself and can be accessed using the type name, while const and readonly members
 belong to instances of the type.const members are fixed compile-time constants that cannot be changed at runtime, while
 readonly members can be initialized at runtime but cannot be changed after initialization.const members are implicitly 
 static, while readonly members are not implicitly static.

3. What does a constructor do?
=>It is a special method which shares the same name of the class, and doesn’t have any return type, not even void.
It is used to create an object of the class and initialize class members.

4. Why is the partial keyword useful?
=>The partial keyword is useful because it provides a way to split a class, method, or struct into multiple files, 
without affecting the behavior of the compiled code. This allows for more flexible and organized code organization, and
can make it easier for multiple developers to work on the same codebase.

5. What is a tuple?
=>A tuple is an object that can hold a fixed number of elements, each of which can have a different data type. Example:
           Tuple<int, string> myTuple = Tuple.Create(1, "Hello");
           
6. What does the C# record keyword do?
=>The record keyword in C# is a new feature introduced in C# 9.0 that allows developers to define classes that are 
designed to store data and are automatically implemented with built-in functionality for equality, immutability, and 
deconstruction.

7. What does overloading and overriding mean?
=>Overloading is a feature in object-oriented programming that allows multiple methods in the same class to have the 
same name but different parameters. Overriding is a feature that allows a subclass to provide a different implementation 
of a method that is already defined in its parent class.

8. What is the difference between a field and a property?
=>In C#, a field is a variable that is declared within a class and is used to store data. A property, on the other hand,
 is a way to provide controlled access to a class's fields.

9. How do you make a method parameter optional?
=>We can make a method parameter optional by specifying a default value for the parameter. When a default value is 
specified, the parameter becomes optional, which means that it can be omitted when calling the method.

10. What is an interface and how is it different from abstract class?
=>An interface is a type that defines a set of abstract methods and properties that a class can implement. An interface 
does not contain any implementation code, but simply specifies the signature of the methods and properties that a class
 must implement.
 An abstract class, on the other hand, is a class that cannot be instantiated directly, but must be subclassed.
 An abstract class can contain both abstract and concrete methods and properties, which means that it can contain 
 implementation code as well as abstract members that must be implemented by a subclass.
 
11.What accessibility level are members of an interface?
=> Members of an interface are always public by default.You can explicitly specify the access level of interface members
 using access modifiers such as public, private, protected, internal, or protected internal, but specifying an access
 modifier on an interface member is redundant, since all interface members are implicitly public

12. True/False. Polymorphism allows derived classes to provide different implementations
of the same method.
=> True

13. True/False. The override keyword is used to indicate that a method in a derived class is
providing its own implementation of a method.
=>True

Note:the new keyword is used to provide a new implementation for a member in a derived class that has the same name as 
a member in the base class, but is not marked as virtual in the base class. The override keyword is used to provide a 
new implementation for a member in a derived class that has the same name as a member in the base class, and is marked 
as virtual in the base class.


14. True/False. The new keyword is used to indicate that a method in a derived class is
providing its own implementation of a method.
=>True

15. True/False. Abstract methods can be used in a normal (non-abstract) class.
=> False

16.True/False. Normal (non-abstract) methods can be used in an abstract class. 
=> True

17. True/False.Derived classes can override methods that were virtual in the base class. 
=> True

18. True/False.Derived classes can override methods that were abstract in the base class. 
=>True

19. True/False.In a derived class, you can override a method that was neither virtual nor abstract in the
base class.
=> True but with some restrictions. 

Note:  In C#, you can use the new keyword to hide a non-virtual method of the base class in a derived class, providing a
 new implementation that is specific to the derived class. However, this does not actually override the method in the 
 base class. Instead, it simply hides the base class implementation, so that the new implementation is used only when 
 the method is called on an instance of the derived class. If the method is called on an instance of the base class, 
 the original implementation will be used.

20. True/False. A class that implements an interface does not have to provide an
implementation for all of the members of the interface.
=> False

21. True/False. A class that implements an interface is allowed to have other members that
aren’t defined in the interface.
=> True

22. True/False. A class can have more than one base class.
=> False

23. True/False. A class can implement more than one interface.
=>True. In C#, a class can implement multiple interfaces. 
 
 
 
 
 */
 
// ReverseNumber r1 = new ReverseNumber();
// int[] numbers = r1.GenerateNumbers();
// r1.Reverse(numbers);
// r1.PrintNumbers(numbers);
 

// for (int i = 1; i <= 10; i++)
// {
//       Console.Write(" "+Fibionacci.FibonacciCalculation(i));
// }

// Create a ball with size 10 and red color
Ball ball1 = new Ball(10, 255, 0, 0);

// Create a ball with size 5 and blue color
Ball ball2 = new Ball(5, 0, 0, 255);

// Throw the first ball
ball1.Throw();

// Pop the second ball
ball2.Pop();

// Try to throw the second ball
ball2.Throw();

// Print the number of times each ball has been thrown
Console.WriteLine("Ball 1 has been thrown {0} times.", ball1.ThrowCount);
Console.WriteLine("Ball 2 has been thrown {0} times.", ball2.ThrowCount);
 
 
 
 
 
 