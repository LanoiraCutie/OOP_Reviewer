using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hi, this is Lanoira!");
        Introduction();
    }

    private static void Introduction()
    {
        /* **OBJECT ORIENTED PROGRAMMING**
        OOP / Object-Oriented programming -> approach to software development in which the structure of the software is based on objects 
            interacting with each other to accomplish a task.
        History of OOP
            1960s - began with the programming language Simula.
            1970s - evolved further with the introduction of Smalltalk.
            1980s - Renewed interest in OOP methodologies; C++ and Eiffel.
            1990s - The rise of Java attracted a large following.
            2002 - OOP languages are a cornerstone of modern programming.

        Pillars of OOP:
        ABSTRACTION - Hiding of Information
        INHERITANCE - Sharing of Information
        ENCAPSULATION - Grouping of Information
        POLYMORPHISM - Redefining of Information

        Comments in C# (Trust me, it is the same with Java)
        Single line (//) - for brief explanations
        Multi line (/*) - for longer explanations 
        XML documentation (///) - providing detailed information
        */
        VariablesDataTypes();
    }

    private static void VariablesDataTypes()
    {
        /* **C# Variables, Constants, Data Types, Constructors**
         * C# Variables:
         * int - stores integers (whole numbers), without decimals*, such as 123 or -123
         * double - stores floating point numbers, with decimals*, such as 19.99 or -19.99
         * char - stores single characters, such as 'a' or 'B'. Char values are surrounded by single quotes
         * string - stores text, such as "Hello World". String values are surrounded by double quotes
         * bool - stores values with two states: true or false
        */

        //Declaring (Creating) Variables - {type variableName = value;} should be self-explanatory knowing you are 2nd years.
        string name = "Lanoira";
        Console.WriteLine($"i am {name}");

        //Ofcourse you can also declare without assigning.
        int myAge; //create a variable that should store a number.
        myAge = 17; 
        Console.WriteLine($"I am {myAge} years old, ");
        myAge = 18; //if you assign a new value to an existing one, it will overwrite the previous value.
        Console.WriteLine($"And I will be {myAge} years old.");

        //Constant - you can add the const keyword if you don't want others (or yourself) to overwrite existing values
        //(this will declare the variable as "constant", which means unchangeable and read-only):
        const bool cute = true;

        //Display Variables - WriteLine() used to display variable values to the console window.
        Console.WriteLine($"am i cute? {cute}"); //combine both text and variable, you can also use "+" character too.

        //some uses of "+": to add a variable to another variable, and as a mathematical operator.
        string secname = " Peruere";
        string givname = name + secname;
        Console.WriteLine($"My given name is {givname}");
        int addition = 10;
        Console.WriteLine($"My age plus 10: {myAge} + {addition} = {myAge + addition}"); //myAge + addition

        //declare more than one variable of the same type, use comma-separated list.
        int x = 5, y = 6, z = 7;

        /* Data Types - It is important to use the correct data type for the corresponding variable.
         *  int - Stores whole numbers from -2,147,483,648 to 2,147,483,647
         *  long (end with "L") - Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
         *  float (end with "F") - Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
         *  double (end with "D")- Stores fractional numbers. Sufficient for storing 15 decimal digits
         *  bool - Stores true or false values
         *  char ('') - Stores a single character/letter, surrounded by single quotes
         *  string ("") - Stores a sequence of characters, surrounded by double quotes
         * 
         * Numbers - divided into two groups:
         *  Integer types - stores whole numbers, positive or negative (such as 123 or -456), without decimals.
         *  Floating point - types represents numbers with a fractional part, containing one or more decimals.
         *                 - can also be a scientific number with an "e" to indicate the power of 10
         *  
         */
        /* Constructors - is a special method that is used to initialize objects. 
        * The advantage of a constructor, is that it is called when an object of a class is created.
        * 
        * Constructor Parameters - Constructors can also take parameters, which is used to initialize fields.
        * constructors are very useful, as they help reducing the amount of code.
        */
        Section section = new Section("BSIT", "2-5"); //This can be called a Public Access Specifier.
    }
}

class Section
{
    //These are Member Variables.
    public string Department;
    public string SecName;
    private string ending = "Have a good day / good night, thank you!"; //Private Access Modifier

    public Section(string Departmentinit, string SecNameinit)
    {
        Department = Departmentinit;
        SecName = SecNameinit;
        ControlStructures();
    }

    public void ControlStructures()
    {
        Console.WriteLine($"I am on {Department} {SecName}");

        /* **3 BASIC CONTROL STRUCTURES**
         *   Sequential Logic - simplest form of control structure. It ensures that code executes in the order it appears, one statement after another.
         *   Selection logic - controls which blocks of code are executed based on conditions. 
         *                     This includes:
         *                     if (one way) - The if statement evaluates a condition. If the condition is true, it executes a specific block of code.
         *                     if-else (two way) - allows you to execute one block of code if a condition is true and a different block if the condition is false.
         *                     nested if statements (multiple way) - to create more complex decision-making structures.
         *   Iteration Logic - Iteration, also known as looping, allows sections of code to be repeated based on a condition. 
         *                     Common iteration structures include: 
         *                     for - Executes a block of code a specific number of times.
         *                     while - Repeats code as long as a condition is true.
         *                     do-while - Similar to while, but the condition is checked after the code executes, ensuring the loop runs at least once.
         */

        while (true)
        {
            Console.WriteLine("Continue? Yes/No");
            String answer = Console.ReadLine();
            if (answer.Equals("Yes")) {
                ImplementEncapsulation();
                break;
            }
            else
            {
                continue;
            }
        }
    }

    public void ImplementEncapsulation() //This is a Member Function.
    {
        /* **ENCAPSULATION**
         * Encapsulation - Encapsulation is defined 'as the process of enclosing one or more items within a physical or logical package'.
         * C# supports the following access specifiers −
         *  Public
         *  Private
         *  Protected
         *  Internal
         *  Protected internal
         *
         * Member Function and Member Variables:
         *  Member Variables: These are variables that belong to a class. They hold data or state for the class. You can also call them fields.
         *  Member Functions: These are functions (also called methods) that belong to a class. They define behaviors or actions that objects of the class can perform.
         *  
         * Public Access Specifier - allows a class to expose its member variables and member functions to other functions and objects.
         * Private Access Specifier - allows a class to hide its member variables and member functions from other functions and objects.
         *                            Only functions of the same class can access its private members.
         * Protected Access Specifier - allows a child class to access the member variables and member functions of its base class.
         * Internal Access Specifier - allows a class to expose its member variables and member functions to other functions and objects in the current assembly.
         * Protected Internal Access Specifier - allows a class to hide its member variables and member functions from other class objects and functions,
         *                                       except a child class within the same application.
         */

        Console.WriteLine(ending);
        Console.ReadKey();
    }
}

