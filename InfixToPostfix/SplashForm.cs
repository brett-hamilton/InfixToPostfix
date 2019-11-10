///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:           Project 3 - Infix to Postfix Conversion
//	File Name:         SplashForm.cs
//	Description:       Displays the splash screen when the program is started
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfixToPostfix
{
	/// <summary>
	/// Loads the splash screen with program information and graphics
	/// </summary>
	public partial class SplashForm : Form
	{
		#region Constructor and Form Load
		/// <summary>
		/// Default constructor that initializes that splash screen
		/// </summary>
		public SplashForm ( )
		{
			InitializeComponent ( );
		} // end SplashForm

		/// <summary>
		/// Replace version label with current product version upon form load
		/// </summary>
		/// <param name="sender">The object sending the event</param>
		/// <param name="e">The event instance that holds event information</param>
		private void SplashForm_Load (object sender, EventArgs e)
		{
			this.labelSplashVersion.Text = $"Version {Application.ProductVersion}";
		} // end SplashForm_Load
		#endregion

		#region Timer		
		/// <summary>
		/// After tick event, close the splash screen
		/// </summary>
		/// <param name="sender">The timer generating the tick event</param>
		/// <param name="e">The event instance that holds event information</param>
		private void timerSplash_Tick (object sender, EventArgs e)
		{
			this.Close ( );
		} // end timerSplash_Tick
		#endregion
	} // end SplashForm
}
