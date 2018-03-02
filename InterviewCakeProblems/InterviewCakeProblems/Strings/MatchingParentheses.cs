﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeProblems.Strings
{
    public class MatchingParentheses
    {
        /// <summary>
        /// Problem #28
        /// Write a method that, given a sentence like the one above, 
        /// along with the position of an opening parenthesis, 
        /// finds the corresponding closing parenthesis.
        /// </summary>
        /// <param name="sentence"></param>
        /// <param name="openingParenIndex"></param>
        /// <returns></returns>
        public int GetClosingParentheses(string sentence, int openingParenIndex)
        {
            int openNestedParens = 0;

            for (int position = openingParenIndex + 1; position < sentence.Length; position++)
            {
                char c = sentence[position];

                if (c == '(')
                {
                    openNestedParens++;
                }
                else if (c == ')')
                {
                    if (openNestedParens == 0)
                    {
                        return position;
                    }
                    else
                    {
                        openNestedParens--;
                    }
                }
            }

            throw new ArgumentException("No closing parenthesis :(", nameof(sentence));
        }
    }
}
