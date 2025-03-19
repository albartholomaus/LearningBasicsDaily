// See https://aka.ms/new-console-template for more information
using LearningBasics.PracticePlace;


char[][] board = new char[][]
{
    new char[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
    new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
    new char[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
    new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
    new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
    new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
    new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
    new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
    new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
};

TimeMap timeMap = new TimeMap();
timeMap.Set("alice", "happy", 1);  // store the key "alice" and value "happy" along with timestamp = 1.
Console.WriteLine(timeMap.Get("alice", 1));          // return "happy"
Console.WriteLine(timeMap.Get("alice", 2));          // return "happy", there is no value stored for timestamp 2, thus we return the value at timestamp 1.
timeMap.Set("alice", "sad", 3);    // store the key "alice" and value "sad" along with timestamp = 3.
Console.WriteLine(timeMap.Get("alice", 3));           // return "sad"

