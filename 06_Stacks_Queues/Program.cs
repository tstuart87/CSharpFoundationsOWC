using _06_Stacks_Queues;

StackQueueMethods _sqm = new StackQueueMethods();

// STACKS && QUEUES
// Count() - returns total number of items
// Peek() - returns item, does not remove it
// Contains(T) - returns bool if T is present
// Clear() - clears items from collection

// QUEUES
// Enqueue() - adds to the Queue
// Dequeue() - removes from the Queue

// STACKS
// Push() - add to the Stack
// Pop() - removes from the Stack

Queue<char> charQueue = new Queue<char>();
Stack<int> intStack = new Stack<int>();

charQueue.Enqueue('a');
charQueue.Enqueue('b');
charQueue.Enqueue('c');
charQueue.Enqueue('d');

intStack.Push(1);
intStack.Push(2);
intStack.Push(3);
intStack.Push(4);

char x = charQueue.Dequeue();
int y = intStack.Pop();

_sqm.PrintAll(charQueue);
_sqm.PrintAll(intStack);

Console.WriteLine(x);
Console.WriteLine(y);

bool doesQueueContainC = charQueue.Contains('c');
Console.WriteLine(doesQueueContainC);

char someChar = charQueue.Peek();
Console.WriteLine(someChar);

Console.WriteLine(intStack.Count());