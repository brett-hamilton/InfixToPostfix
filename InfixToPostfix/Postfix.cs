///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:           Project 3 - Infix to Postfix Conversion
//	File Name:         Postfix.cs
//	Description:       Responsible for converting an infix expression to a postfix expression
//	Course:            CSCI 2210 - Data Structures	
//	Author:            Brett Hamilton, hamiltonb@etsu.edu, Dept. of Computing, East Tennessee State University
//	Created:           Thursday, November 7, 2019
//	Copyright:         Brett Hamilton, 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Utils.Tools;

namespace InfixToPostfix
{
	/// <summary>
	/// Converts a string infix expression to a postfix expression, utilizing a Stack of Operators
	/// </summary>
	public class Postfix
	{
		private string StrOps = "=+-/*()";      // All possible operators

		#region Properties		
		/// <summary>
		/// Gets or sets the original infix expression
		/// </summary>
		/// <value>The infix expression</value>
		public string InfixExpression { get; set; }
		/// <summary>
		/// Gets or sets the new postfix expression
		/// </summary>
		/// <value>The postfix expression</value>
		public string PostfixExpression { get; set; }
		#endregion

		#region Constructors		
		/// <summary>
		/// Default constructor
		/// </summary>
		public Postfix ( )
		{
			InfixExpression = string.Empty;
			PostfixExpression = string.Empty;
		} // end Postfix

		/// <summary>
		/// Parameterized constructor
		/// </summary>
		/// <param name="input">The string representing the infix expression</param>
		public Postfix (string input)
		{
			InfixExpression = input;

			PostfixExpression = Convert ( );
		} // end Postfix
		#endregion

		#region Convert to Postfix
		/// <summary>
		/// Converts the infix expression to a postfix expression for display in the form
		/// </summary>
		/// <returns>Formatted string postfix expression</returns>
		private string Convert ( )
		{
			string infix		= InfixExpression;
			string postfix		= string.Empty;
			Stack<Operator> stk = new Stack<Operator> ( );
			Operator tempOp;

			if (string.IsNullOrEmpty (infix))		// If this is a blank line, return empty string
				return postfix;

			List<string> tokens = Tokenize (infix, StrOps);		// Convert infix to tokens

			for (int i = 0; i < tokens.Count; i++)
			{
				// If token is operand, concatenate to postfix
				if (tokens[i].IndexOfAny (StrOps.ToCharArray ( )) < 0)
					postfix += tokens[i] + "  ";
				else
				{
					tempOp = new Operator (tokens[i]);

					if (tempOp.Symbol == "(")
						stk.Push (tempOp);
					else if (tempOp.Symbol == ")")
					{
						bool found = false;		// Assume open parenthesis not found until otherwise
						
						// Pop stack until open parenthesis found
						while (!found && stk.Count > 0)
						{
							if (stk.Peek ( ).Symbol == "(")
							{
								stk.Pop ( );
								found = true;
							}
							else
							{
								postfix += stk.Peek ( ).Symbol + "  ";
								stk.Pop ( );
							}
							
						}

						// Error message if open parenthesis not found
						if (!found)
							return "*** ERROR ***\tUnpaired open parenthesis";
					}
					else
					{
						// Pop stack until end is reached, operator of lower precedence is found,
						//	or open parenthesis found
						while (stk.Count > 0 && tempOp <= stk.Peek ( ) && stk.Peek ( ).Symbol != "(")
						{
							postfix += stk.Peek ( ).Symbol + "  ";
							stk.Pop ( );
						}

						stk.Push (tempOp);
					}
				}
			}

			// Empty remaining stack
			while (stk.Count > 0)
			{
				// Error if open parenthesis was not paired
				if (stk.Peek ( ).Symbol == "(")
					return "*** ERROR ***\tUnpaired open parenthesis";
				else
				{
					postfix += stk.Peek ( ).Symbol + "  ";
					stk.Pop ( );
				}
			}

			return postfix;
		} // end Convert
		#endregion
	} // end Postfix
}
