// VALUE TYPES
// Value Types are stored in the STACK.

// BOOLS and CHARS

bool isDeclared; // Declaring a variable - not assigning it a value.
isDeclared = true; // Assiging a value to an existing variable.

bool isDeclaredAndInitialized = true;

char character = 'a'; // Single Quotes for chars in C#.
char symbol = '?';
char number = '7';
char space = ' ';
char specialCharacter = '\n'; // This is the NEW LINE char.


// WHOLE NUMBERS - bytes, shorts, ints, longs.

byte age = 89; // BYTES can't be negative - max out at 255
sbyte negativeAge = -20; // signed byte.

short shortExample = 3245;

int someNumber = 12; //No quotes or suffixes for WHOLE NUMBERS
int max = 2147483647;
uint unsignedInt = 28; //unsigned int.

long bigWholeNumber = 9223372036854775807;


// FLOATING POINT NUMBERS - not whole numbers - they have decimal places. floats, doubles, decimals.
// FLOATING POINT NUMBERS use suffixes.

float floatExample = 1.04567896f; //F
double doubleExample = 8.87264395842d; //D
decimal decimalExample = 2.45678946543m; //M

float x = 1.123456789123456789123456789123456789123456789f; // 7 decimal places
double y = 1.123456789123456789123456789123456789123456789d; // 17 
decimal z = 1.123456789123456789123456789123456789123456789m; // 28

// Console.WriteLine(x);
// Console.WriteLine(y);
// Console.WriteLine(z);

// enum PastryType { cake, cupcake, eclaire, croissant };

// DATE VALUE TYPES

DateTime today = DateTime.Today;
// DateTimeOffSet today = DateTimeOffset.Today;



// REFERENCE TYPES - Reference Types are stored on the HEAP.

string firstName = "Bob";
string lastName = "Darryl";

string concatFullName = firstName + " " + lastName;
string compositeFullName = string.Format("Hi my name is {0} {1}", firstName, lastName);
string interpolFullName = $"{firstName} {lastName}";

// Console.WriteLine(concatFullName);
// Console.WriteLine(compositeFullName);
// Console.WriteLine(interpolFullName);


//ARRAYS

string[] stringArray = { "hello", "world", "!" };

Console.WriteLine(stringArray[0]);

//LISTS
List<string> listOfStrings = new List<string>();
listOfStrings.Add("dog");
listOfStrings.Remove("dog");

List<int> listOfInts = new List<int>();

//QUEUES AND DICTIONARIES
Queue<string> firstInFirstOut = new Queue<string>();

Dictionary<int, string> keyAndValue = new Dictionary<int, string>();

keyAndValue.Add(7, "Agent");

Console.WriteLine(keyAndValue[7]);