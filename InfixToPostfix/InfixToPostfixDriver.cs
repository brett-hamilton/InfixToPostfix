///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:           Project 3 - Infix to Postfix Conversion
//	File Name:         InfixToPostfixDriver.cs
//	Description:       Runs the infix to postfix converter program, handling the forms for display
//	Course:            CSCI 2210 - Data Structures	
//	Author:            Brett Hamilton, hamiltonb@etsu.edu, Dept. of Computing, East Tennessee State University
//	Created:           Thursday, November 7, 2019
//	Copyright:         Brett Hamilton, 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfixToPostfix
{
	/// <summary>
	/// Runs the infix to postfix converter program, starting with splash screen
	/// </summary>
	public static class InfixToPostfixDriver
	{
		#region Main
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		public static void Main ( )
		{
			Application.EnableVisualStyles ( );
			Application.SetCompatibleTextRenderingDefault (false);
			Application.Run (new SplashForm ( ));
			Application.Run (new InfixToPostfixForm ( ));
		} // end Main
		#endregion
	} // end InfixToPostfixDriver
}
