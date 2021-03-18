/*
 * Created by Ranorex
 * User: mkadiwala
 * Date: 3/18/2021
 * Time: 9:37 AM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace Epiroc
{
    /// <summary>
    /// Creates a Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    [UserCodeCollection]
    public class GlobalCodeCollection
    {
    	public static string gblFirstName = "-1";
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
        
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void TypeText2(Adapter Textbox, string value)
        {
        	Textbox.Click();
        	Textbox.PressKeys(value);
        	Report.Info("Vaule added");       	
        }
        
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public void TypeTextLocal(Adapter Textbox, string Value)
        {
        	if(Textbox.Element.GetAttributeValueText("Text").Equals(""))
        	{
        		Textbox.Click();
        		Textbox.PressKeys(Value);
        		Report.Success("All is good");
        	}
        	else
        	{
        		//do something clear the text
        		Report.Warn("just a warning");
        	}
        }
    }
}
