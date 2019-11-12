///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:           Project 3 - Infix to Postfix Conversion
//	File Name:         Tools.cs
//	Description:       Static class to provide common methods for use in other classes
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
using System.Windows.Forms;

namespace Utils
{
	/// <summary>
	/// Provide common, useful static methods to be used in other classes where appropriate
	/// </summary>
	public static class Tools
	{
		#region Tokenize
		/// <summary>
		/// Converts a string to a list of tokens based on specified delimiters
		/// </summary>
		/// <param name="original">The string to be tokenized</param>
		/// <param name="delimiters">The set of delimiters used to tokenize the string</param>
		/// <returns>A list of strings representing the tokens</returns>
		public static List<string> Tokenize (string original, string delimiters)
		{
			List<string> tokens = new List<string> ( );
			string text = Clean (original);
			string token = string.Empty;            // Holds token from text to put in list

			while (!string.IsNullOrEmpty (text))
			{
				int col = text.IndexOfAny (delimiters.ToCharArray ( ));     // Search for delimiter

				if (col == 0)
				{
					// Set column to first if delimiter is found at first position
					col = 1;
				}

				if (col < 0)
				{
					// If delimiter not found, the rest of text is a token
					col = text.Length;
				}

				token = text.Substring (0, col);
				tokens.Add (token);

				if (col < text.Length)
				{
					// If there is more text to read, cut off the token just added
					text = text.Substring (col);
				}
				else
				{
					// No text left to read
					text = string.Empty;
				}

				// Ignore spaces and tab characters
				text = text.Trim (" \t".ToCharArray ( ));
			}

			return tokens;
		} // end Tokenize

		/// <summary>
		/// Trims off any leading or trailing spaces or tabs from string and replaces the
		///		\r\n sequence with a single newline character
		/// </summary>
		/// <param name="text">The string that needs to be trimmed</param>
		/// <returns>The original string without leading or trailing spaces or tabs</returns>
		private static string Clean (string txt)
		{
			string cleanedTxt = txt.Trim (" \t\n\r".ToCharArray ( ));
			cleanedTxt = cleanedTxt.Replace ("\r\n", "\n");

			return cleanedTxt;
		} // end Clean
		#endregion

		#region Goodbye Message		
		/// <summary>
		/// Displays a goodbye message box to the user before the program closes
		/// </summary>
		/// <param name="msg">The message to be displayed</param>
		/// <param name="author">The author of the program</param>
		/// <param name="subtitle">The course or subtitle</param>
		public static void GoodbyeMessage (string msg, string author="Brett Hamilton",
			string subtitle="Computer Science - 2210 Data Structures")
		{
			string body = $"Created by: {author}\n{subtitle}\n\n{msg}";

			MessageBox.Show (body, "Goodbye and Thank You", MessageBoxButtons.OK,
				MessageBoxIcon.Information);
		} // end GoodbyeMessage
		#endregion
	} // end Tools
}
