// ─────────────────────────────────────────────────────────────────────────────
// WARNING: If you're looking here for answers, you're only cheating yourself.
// Stop scrolling and go learn by playing the game!
// ─────────────────────────────────────────────────────────────────────────────

using System.Collections.Generic;

namespace QuizGame
{
    public static class Questions
    {
        public static List<Question> GetAllQuestions()
        {
            return new List<Question>
            {
                // ===================== EASY (1) =====================
                new Question
                {
                    Text = "Which keyword declares a variable in C#?",
                    Choices = new[] { "var", "let", "define", "declare" },
                    CorrectAnswer = "var",
                    Difficulty = 1
                },
                new Question
                {
                    Text = "Which symbol starts a single-line comment?",
                    Choices = new[] { "//", "/*", "<!--", "##" },
                    CorrectAnswer = "//",
                    Difficulty = 1
                },
                new Question
                {
                    Text = "Default value of an uninitialized int field?",
                    Choices = new[] { "0", "1", "null", "undefined" },
                    CorrectAnswer = "0",
                    Difficulty = 1
                },
                new Question
                {
                    Text = "Which type stores true/false?",
                    Choices = new[] { "bool", "int", "string", "char" },
                    CorrectAnswer = "bool",
                    Difficulty = 1
                },
                new Question
                {
                    Text = "What is the output of Console.WriteLine(1 + 2);?",
                    Choices = new[] { "3", "12", "'1+2'", "Error" },
                    CorrectAnswer = "3",
                    Difficulty = 1
                },
                new Question
                {
                    Text = "What is the extension for C# files?",
                    Choices = new[] { ".cs", ".csharp", ".java", ".cpp" },
                    CorrectAnswer = ".cs",
                    Difficulty = 1
                },
                new Question
                {
                    Text = "Which keyword defines a class?",
                    Choices = new[] { "class", "object", "struct", "module" },
                    CorrectAnswer = "class",
                    Difficulty = 1
                },
                new Question
                {
                    Text = "What is the output of Console.WriteLine(\"Hello\" + \"World\");?",
                    Choices = new[] { "HelloWorld", "Hello World", "Error", "Hello+World" },
                    CorrectAnswer = "HelloWorld",
                    Difficulty = 1
                },
                new Question
                {
                    Text = "Which keyword exits a loop early?",
                    Choices = new[] { "break", "exit", "stop", "return" },
                    CorrectAnswer = "break",
                    Difficulty = 1
                },
                new Question
                {
                    Text = "Which type stores a single character?",
                    Choices = new[] { "char", "string", "byte", "bool" },
                    CorrectAnswer = "char",
                    Difficulty = 1
                },
                new Question
                {
                    Text = "Which method is the entry point of a console application?",
                    Choices = new[] { "Main()", "Start()", "Init()", "Run()" },
                    CorrectAnswer = "Main()",
                    Difficulty = 1
                },
                new Question
                {
                    Text = "Which loop checks the condition before each iteration?",
                    Choices = new[] { "for", "do-while", "while", "foreach" },
                    CorrectAnswer = "while",
                    Difficulty = 1
                },
                new Question
                {
                    Text = "Which operator compares two values for equality?",
                    Choices = new[] { "==", "=", "!=", ">=" },
                    CorrectAnswer = "==",
                    Difficulty = 1
                },
                new Question
                {
                    Text = "Which keyword creates a new object?",
                    Choices = new[] { "new", "create", "alloc", "instance" },
                    CorrectAnswer = "new",
                    Difficulty = 1
                },
                new Question
                {
                    Text = "Which type is used to store text?",
                    Choices = new[] { "string", "int", "bool", "char" },
                    CorrectAnswer = "string",
                    Difficulty = 1
                },
                new Question
                {
                    Text = "Which collection allows duplicate elements?",
                    Choices = new[] { "List", "HashSet", "Dictionary", "Queue" },
                    CorrectAnswer = "List",
                    Difficulty = 1
                },
                new Question
                {
                    Text = "Which value type stores fractional numbers?",
                    Choices = new[] { "double", "bool", "char", "string" },
                    CorrectAnswer = "double",
                    Difficulty = 1
                },
                new Question
                {
                    Text = "Which keyword defines a compile-time constant?",
                    Choices = new[] { "const", "var", "readonly", "static" },
                    CorrectAnswer = "const",
                    Difficulty = 1
                },
                new Question
                {
                    Text = "Which operator increments a value by one?",
                    Choices = new[] { "++", "+=", "--", "//" },
                    CorrectAnswer = "++",
                    Difficulty = 1
                },
                new Question
                {
                    Text = "What does Console.ReadLine() return?",
                    Choices = new[] { "string", "char", "int", "void" },
                    CorrectAnswer = "string",
                    Difficulty = 1
                },

                // ===================== MEDIUM (2) =====================
                new Question
                {
                    Text = "Which access modifier hides members from other classes?",
                    Choices = new[] { "private", "public", "internal", "protected" },
                    CorrectAnswer = "private",
                    Difficulty = 2
                },
                new Question
                {
                    Text = "Which symbol is used to inherit from a base class?",
                    Choices = new[] { ":", "extends", "inherits", "base" },
                    CorrectAnswer = ":",
                    Difficulty = 2
                },
                new Question
                {
                    Text = "Which interface allows external custom sorting?",
                    Choices = new[] { "IComparer", "IEnumerable", "IDisposable", "ICloneable" },
                    CorrectAnswer = "IComparer",
                    Difficulty = 2
                },
                new Question
                {
                    Text = "Which collection stores key-value pairs?",
                    Choices = new[] { "Dictionary", "List", "Queue", "Stack" },
                    CorrectAnswer = "Dictionary",
                    Difficulty = 2
                },
                new Question
                {
                    Text = "What does a try-catch-finally block handle?",
                    Choices = new[] { "Exceptions", "Loops", "Events", "Casting" },
                    CorrectAnswer = "Exceptions",
                    Difficulty = 2
                },
                new Question
                {
                    Text = "Which keyword hides an inherited member?",
                    Choices = new[] { "new", "hide", "override", "sealed" },
                    CorrectAnswer = "new",
                    Difficulty = 2
                },
                new Question
                {
                    Text = "What is boxing in C#?",
                    Choices = new[] { "Value type to object", "Object to value type", "Casting int to string", "String to int" },
                    CorrectAnswer = "Value type to object",
                    Difficulty = 2
                },
                new Question
                {
                    Text = "Which type is a reference type?",
                    Choices = new[] { "string", "int", "bool", "struct" },
                    CorrectAnswer = "string",
                    Difficulty = 2
                },
                new Question
                {
                    Text = "Which keyword marks a method as overridable?",
                    Choices = new[] { "virtual", "override", "sealed", "static" },
                    CorrectAnswer = "virtual",
                    Difficulty = 2
                },
                new Question
                {
                    Text = "What does the 'params' keyword allow?",
                    Choices = new[] { "Variable number of arguments", "Optional return", "Named parameters", "Multiple return types" },
                    CorrectAnswer = "Variable number of arguments",
                    Difficulty = 2
                },
                new Question
                {
                    Text = "Which keyword prevents a class from being inherited?",
                    Choices = new[] { "sealed", "static", "private", "readonly" },
                    CorrectAnswer = "sealed",
                    Difficulty = 2
                },
                new Question
                {
                    Text = "Which collection does not allow duplicate keys?",
                    Choices = new[] { "Dictionary", "List", "Queue", "Stack" },
                    CorrectAnswer = "Dictionary",
                    Difficulty = 2
                },
                new Question
                {
                    Text = "Which method converts a string to an int?",
                    Choices = new[] { "int.Parse", "ToString", "Convert.ToString", "Math.Round" },
                    CorrectAnswer = "int.Parse",
                    Difficulty = 2
                },
                new Question
                {
                    Text = "What does the 'is' operator check?",
                    Choices = new[] { "Type compatibility", "Equality", "Reference", "Size" },
                    CorrectAnswer = "Type compatibility",
                    Difficulty = 2
                },
                new Question
                {
                    Text = "What does the 'as' operator do?",
                    Choices = new[] { "Safe casting", "String concatenation", "Arithmetic", "Comparison" },
                    CorrectAnswer = "Safe casting",
                    Difficulty = 2
                },
                new Question
                {
                    Text = "Which keyword defines an interface?",
                    Choices = new[] { "interface", "abstract", "class", "implements" },
                    CorrectAnswer = "interface",
                    Difficulty = 2
                },
                new Question
                {
                    Text = "Which keyword ensures IDisposable objects are disposed automatically?",
                    Choices = new[] { "using", "finally", "close", "delete" },
                    CorrectAnswer = "using",
                    Difficulty = 2
                },
                new Question
                {
                    Text = "What is the default value of a bool field?",
                    Choices = new[] { "false", "true", "null", "0" },
                    CorrectAnswer = "false",
                    Difficulty = 2
                },
                new Question
                {
                    Text = "Which exception occurs when accessing an invalid array index?",
                    Choices = new[] { "IndexOutOfRangeException", "ArgumentNullException", "NullReferenceException", "InvalidCastException" },
                    CorrectAnswer = "IndexOutOfRangeException",
                    Difficulty = 2
                },
                new Question
                {
                    Text = "Which loop is designed for iterating over collections?",
                    Choices = new[] { "foreach", "for", "while", "do-while" },
                    CorrectAnswer = "foreach",
                    Difficulty = 2
                },

                // ===================== HARD (3) =====================
                new Question
                {
                    Text = "Where are reference type objects stored?",
                    Choices = new[] { "Heap", "Stack", "Cache", "Register" },
                    CorrectAnswer = "Heap",
                    Difficulty = 3
                },
                new Question
                {
                    Text = "Where are value types typically stored?",
                    Choices = new[] { "Stack", "Heap", "Disk", "Cache" },
                    CorrectAnswer = "Stack",
                    Difficulty = 3
                },
                new Question
                {
                    Text = "Which keyword makes a class abstract?",
                    Choices = new[] { "abstract", "sealed", "virtual", "base" },
                    CorrectAnswer = "abstract",
                    Difficulty = 3
                },
                new Question
                {
                    Text = "What does the 'lock' keyword ensure?",
                    Choices = new[] { "Thread safety", "Memory allocation", "Inheritance", "Garbage collection" },
                    CorrectAnswer = "Thread safety",
                    Difficulty = 3
                },
                new Question
                {
                    Text = "Which keyword is used to return elements from an iterator?",
                    Choices = new[] { "yield", "iterator", "foreach", "await" },
                    CorrectAnswer = "yield",
                    Difficulty = 3
                },
                new Question
                {
                    Text = "What does the 'volatile' keyword indicate?",
                    Choices = new[] { "Field modified by multiple threads", "Immutable value", "Garbage collected field", "Static variable" },
                    CorrectAnswer = "Field modified by multiple threads",
                    Difficulty = 3
                },
                new Question
                {
                    Text = "What is the purpose of the 'unsafe' keyword?",
                    Choices = new[] { "Allows pointer code", "Prevents inheritance", "Marks constant", "Blocks threading" },
                    CorrectAnswer = "Allows pointer code",
                    Difficulty = 3
                },
                new Question
                {
                    Text = "Which LINQ method filters a sequence?",
                    Choices = new[] { "Where", "Select", "GroupBy", "OrderBy" },
                    CorrectAnswer = "Where",
                    Difficulty = 3
                },
                new Question
                {
                    Text = "Which LINQ method projects elements?",
                    Choices = new[] { "Select", "Where", "Join", "Skip" },
                    CorrectAnswer = "Select",
                    Difficulty = 3
                },
                new Question
                {
                    Text = "What does the 'nameof' operator return?",
                    Choices = new[] { "String name of symbol", "Type name", "Namespace", "File path" },
                    CorrectAnswer = "String name of symbol",
                    Difficulty = 3
                },
                new Question
                {
                    Text = "What does the 'checked' keyword do?",
                    Choices = new[] { "Enables overflow checking", "Disables overflow checking", "Locks object", "Checks null" },
                    CorrectAnswer = "Enables overflow checking",
                    Difficulty = 3
                },
                new Question
                {
                    Text = "What does the 'fixed' keyword do?",
                    Choices = new[] { "Pins object in memory", "Locks object", "Fixes bug", "Marks constant" },
                    CorrectAnswer = "Pins object in memory",
                    Difficulty = 3
                },
                new Question
                {
                    Text = "Which attribute marks code as obsolete?",
                    Choices = new[] { "Obsolete", "Deprecated", "Remove", "Legacy" },
                    CorrectAnswer = "Obsolete",
                    Difficulty = 3
                },
                new Question
                {
                    Text = "What does the 'stackalloc' keyword do?",
                    Choices = new[] { "Allocates memory on stack", "Allocates heap memory", "Allocates static memory", "Allocates disk space" },
                    CorrectAnswer = "Allocates memory on stack",
                    Difficulty = 3
                },
                new Question
                {
                    Text = "Which keyword awaits the completion of an async task?",
                    Choices = new[] { "await", "async", "yield", "task" },
                    CorrectAnswer = "await",
                    Difficulty = 3
                },
                new Question
                {
                    Text = "What does the 'sealed' keyword do to a method?",
                    Choices = new[] { "Prevents override", "Allows override", "Makes static", "Hides method" },
                    CorrectAnswer = "Prevents override",
                    Difficulty = 3
                },
                new Question
                {
                    Text = "What is the difference between 'ref' and 'out' parameters?",
                    Choices = new[] { "ref needs initialization, out does not", "out needs initialization, ref does not", "Both need initialization", "Neither needs initialization" },
                    CorrectAnswer = "ref needs initialization, out does not",
                    Difficulty = 3
                },
                new Question
                {
                    Text = "Which GC generation are new objects allocated in?",
                    Choices = new[] { "Gen0", "Gen1", "Gen2", "LargeObjectHeap" },
                    CorrectAnswer = "Gen0",
                    Difficulty = 3
                },
                new Question
                {
                    Text = "What is IL code executed by?",
                    Choices = new[] { "CLR", "JVM", "Compiler", "JIT" },
                    CorrectAnswer = "CLR",
                    Difficulty = 3
                },
                new Question
                {
                    Text = "What is the purpose of the Span<T> type in C#?",
                    Choices = new[]
                    {
                        "To represent a contiguous region of arbitrary memory safely",
                        "To store generic collections on the heap",
                        "To provide parallel execution",
                        "To manage unmanaged resources automatically"
                    },
                    CorrectAnswer = "To represent a contiguous region of arbitrary memory safely",
                    Difficulty = 3
                },
            };
        }
    }
}
