﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace Epiroc
{
    public partial class CodeModules
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void CheckSQL(string UserID)
        {
            //Custom code
            Report.Info("Ran SQL validation: "+UserID);
        }

        public void TypeText(Adapter Textbox, string Value)
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

        public void MergedUserCodeMethod(RepoItemInfo textInfo, RepoItemInfo textInfo1)
        {
        	
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'textInfo' at 65;13.", textInfo);
            textInfo.FindAdapter<Text>().Click("65;13");
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$FirstName' with focus on 'textInfo'.", textInfo);
            textInfo.FindAdapter<Text>().PressKeys(FirstName);
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'textInfo1' at 26;15.", textInfo1);
            textInfo1.FindAdapter<Text>().Click("26;15");
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$LastName' with focus on 'textInfo1'.", textInfo1);
            textInfo1.FindAdapter<Text>().PressKeys(LastName);
        }

    }
}
