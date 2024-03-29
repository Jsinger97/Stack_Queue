﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Stackqueue
{
    class Intstack
    {
        private const int maxsize = 10;
        private int top = 0;
        private int[] array = new int[maxsize];

        public void Push(int value)
        {   //increase top by one
            array[top ++] = value;
        }
        public int Pop()
        {   //decrease top by one
            return array[--top];
        }

        public int Peek()
        {
            //return without moving at the head of the stack
            return array[top];

        }
        public bool IsEmpty()
        {
            return top == 0;
        }
        public bool IsFull()
        {
            return top == maxsize;
        }
        public string Print()
        {
            StringBuilder output = new StringBuilder();
            for (int i = top - 1; i >= 0; i--)
                output.Append(array[i] + Environment.NewLine);
            return output.ToString();
        }
    }
}
