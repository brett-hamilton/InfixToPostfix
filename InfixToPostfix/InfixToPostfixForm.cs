///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:           Project 3 - Infix to Postfix Conversion
//	File Name:         InfixToPostfixForm.cs
//	Description:       The main form for the program, handles all UI and click events
//	Course:            CSCI 2210 - Data Structures	
//	Author:            Brett Hamilton, hamiltonb@etsu.edu, Dept. of Computing, East Tennessee State University
//	Created:           Thursday, November 7, 2019
//	Copyright:         Brett Hamilton, 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Utils.Tools;

namespace InfixToPostfix
{
	/// <summary>
	/// Shows the main program form, allowing user to open a text file and convert infix expressions
	///		to postfix expressions
	/// </summary>
	public partial class InfixToPostfixForm : Form
	{
		List<Postfix> postfixes = new List<Postfix> ( );

		#region Constructors and Loading
		/// <summary>
		/// Default constructor
		/// </summary>
		public InfixToPostfixForm ( )
		{
			InitializeComponent ( );
		} // end InfixToPostfixForm
		#endregion

		#region Click Events
		/// <summary>
		/// Allows user to open a text file with infix expressions and convert to postfix notation
		/// </summary>
		/// <param name="sender">The open file menu option</param>
		/// <param name="e">The event instance containing the event data</param>
		private void openInfixDataFileToolStripMenuItem_Click (object sender, EventArgs e)
		{
			string path = string.Empty;

			// Setup an open file dialog
			OpenFileDialog dlg = new OpenFileDialog ( );
			dlg.Filter = "text files|*.txt;*.text|all files|*.*";
			dlg.InitialDirectory = @"..\..\InfixFiles";
			dlg.Title = "Select a Text File with Infix Expressions to Convert";

			// Try to get the text file from the dialog
			if (dlg.ShowDialog ( ) == DialogResult.OK)
				path = dlg.FileName;
			else
			{
				MessageBox.Show (this, "No file selected. You must select a text file containing " +
					"infix expressions to use the Infix to Postfix program.", "No File Selected",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			StreamReader rdr = null;
			string line = string.Empty;

			try
			{
				rdr = new StreamReader (path);

				// Read data until end of file
				while (rdr.Peek ( ) != -1)
				{
					line = rdr.ReadLine ( );

					// Create postfix expressions
					Postfix newPostfix = new Postfix (line);
					postfixes.Add (newPostfix);
				}
			}
			catch (Exception)
			{
				MessageBox.Show (this, "File could not be opened. Please select a valid text " +
					"file containing infix expressions.", "Error Opening File", 
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			finally
			{
				if (rdr != null)
					rdr.Close ( );
			}

			// Update infix expression listbox
			foreach (Postfix pf in postfixes)
				listBoxInfix.Items.Add (pf.InfixExpression);

			listBoxInfix.Enabled = true;
			listBoxInfix.SelectedIndex = 0;
		} // end openInfixDataFileToolStripMenuItem_Click

		/// <summary>
		/// When "Clear" button is clicked, clear text boxes
		/// </summary>
		/// <param name="sender">The clear button that fired event</param>
		/// <param name="e">The event instance containing information about event</param>
		private void btnClear_Click (object sender, EventArgs e)
		{
			tbInfix.Clear ( );
			tbPostfix.Clear ( );
		} // end btnClear_Click

		/// <summary>
		/// Selects all text when infix text box has focus
		/// </summary>
		/// <param name="sender">The infix expression text box</param>
		/// <param name="e">The event instance containing information about the event</param>
		private void tbInfix_Enter (object sender, EventArgs e)
		{
			tbInfix.SelectAll ( );
		} // end tbInfix_Enter

		/// <summary>
		/// Attempts to convert text that is in infix expression text box to postfix expression
		/// </summary>
		/// <param name="sender">The generate postfix button</param>
		/// <param name="e">The event instance containing information about the event</param>
		private void btnGenerate_Click (object sender, EventArgs e)
		{
			string infix = tbInfix.Text;

			Postfix newPostfix = new Postfix (infix);
			tbPostfix.Text = newPostfix.PostfixExpression;
		} // end btnGenerate_Click

		/// <summary>
		/// Closes the program when "Exit" button or exit file menu option is clicked
		/// </summary>
		/// <param name="sender">The control that was clicked to exit the program</param>
		/// <param name="e">The event instance containing information about the event</param>
		private void btnExit_Click (object sender, EventArgs e)
		{
			this.Close ( );
		} // end btnExit_Click

		/// <summary>
		/// Displays the About form with program information and logo
		/// </summary>
		/// <param name="sender">The about button from the help menu</param>
		/// <param name="e">The event instance containing information about the event</param>
		private void aboutInfixToPostfixToolStripMenuItem_Click (object sender, EventArgs e)
		{
			AboutBoxForm about = new AboutBoxForm ( );
			about.ShowDialog ( );
		} // end aboutInfixToPostfixToolStripMenuItem_Click
		#endregion

		#region Exit Message		
		/// <summary>
		/// Displays an exit message when user closes program in any way
		/// </summary>
		/// <param name="sender">The source that is closing the form</param>
		/// <param name="e">The event instance containing information about the event</param>
		private void InfixToPostfixForm_FormClosing (object sender, FormClosingEventArgs e)
		{
			string msg = "Thank you for using Infix to Postfix! If you have questions or comments, " +
				"email them to hamiltonb@etsu.edu. Have a great day!";

			GoodbyeMessage (msg);
		} // end InfixToPostfixForm_FormClosing
		#endregion

		/// <summary>
		/// Updates the text boxes with data pertaining to current list selection
		/// </summary>
		/// <param name="sender">The list option selected</param>
		/// <param name="e">The event instance containing information about the event</param>
		private void listBoxInfix_SelectedIndexChanged (object sender, EventArgs e)
		{
			int index = listBoxInfix.SelectedIndex;

			tbInfix.Text = postfixes[index].InfixExpression;
			tbPostfix.Text = postfixes[index].PostfixExpression;
		} // end listBoxInfix_SelectedIndexChanged


	}
} // end InfixToPostfixForm
