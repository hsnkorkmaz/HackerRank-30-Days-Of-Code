using System;
using System.Collections.Generic;
using System.IO;

class Solution18 {
    //Write your code here
 public Stack<char> s_char = new Stack<char>();
    public Queue<char> q_char = new Queue<char>();

    void pushCharacter(char c)
    {
        s_char.Push(c);
    }

    char popCharacter()
    {
        return s_char.Pop();
    }
    void enqueueCharacter(char c)
    {
        q_char.Enqueue(c);
    }

    char dequeueCharacter()
    {
        return q_char.Dequeue();
    }
}