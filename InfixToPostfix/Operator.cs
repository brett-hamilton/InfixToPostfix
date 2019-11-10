///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:           Project 3 - Infix to Postfix Conversion
//	File Name:         Operator.cs
//	Description:       Represents an operator and defines the precedence to determine the order of operations
//						to be used to construct postfix expression
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

namespace InfixToPostfix
{
	/// <summary>
	/// Represents an operator symbol, sets the precendence, and allows the operator to be compared
	///		to other operators for construction of postfix expression in another class
	/// </summary>
	public class Operator
	{
		#region Properties
		/// <summary>
		/// Gets or sets the precedence of the operator
		/// </summary>
		/// <value>The number representing the precendence</value>
		public int Precedence { get; set; }
		
		/// <summary>
		/// Gets or sets the string verison of the symbol
		/// </summary>
		/// <value>String representation of the symbol</value>
		public string Symbol { get; set; }
		#endregion

		#region Constructors
		/// <summary>
		/// Default constructor for operators
		/// </summary>
		public Operator ( )
		{
			Precedence = 0;
			Symbol = string.Empty;
		} // end Operator

		/// <summary>
		/// Parameterized constructor for operators
		/// </summary>
		/// <param name="op">The operation to be created</param>
		public Operator (string op)
		{
			Symbol = op;

			// Deterimine the precendence based on the operator
			switch (op)
			{
				case "(":
				case ")":
					Precedence = 3;
					break;
				case "/":
				case "*":
					Precedence = 2;
					break;
				case "+":
				case "-":
					Precedence = 1;
					break;
				case "=":
					Precedence = 0;
					break;
			}
		} // end Operator
		#endregion

		#region Comparisons		
		/// <summary>
		/// Determines if one Operator is greater than another
		/// </summary>
		/// <param name="lhs">The left hand side operand</param>
		/// <param name="rhs">The right hand side operand</param>
		/// <returns>True if lhs operator is greater than rhs operator</returns>
		public static bool operator >= (Operator lhs, Operator rhs)
		{
			return lhs.Precedence >= rhs.Precedence;
		} // end operator >=

		/// <summary>
		/// Determines if one Operator is less than another
		/// </summary>
		/// <param name="lhs">The left hand side operand</param>
		/// <param name="rhs">The right hand side operand</param>
		/// <returns>True if lhs operator is less than rhs operator</returns>
		public static bool operator <= (Operator lhs, Operator rhs)
		{
			return lhs.Precedence <= rhs.Precedence;
		} // end operator <=
		#endregion
	} // end Operator
}
