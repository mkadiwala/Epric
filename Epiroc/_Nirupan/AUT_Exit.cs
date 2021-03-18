﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
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
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace Epiroc._Nirupan
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording1 recording.
    /// </summary>
    [TestModule("d6749a22-61e0-45bc-a6f7-455b058294e6", ModuleType.Recording, 1)]
    public partial class AUT_Exit : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Epiroc.EpirocRepository repository.
        /// </summary>
        public static global::Epiroc.EpirocRepository repo = global::Epiroc.EpirocRepository.Instance;

        static AUT_Exit instance = new AUT_Exit();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AUT_Exit()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AUT_Exit Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            // Close AUT
            Report.Log(ReportLevel.Info, "Section", "Close AUT", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DemoApp.RxButtonExit' at 31;9.", repo.DemoApp.RxButtonExitInfo, new RecordItemIndex(1));
            repo.DemoApp.RxButtonExit.Click("31;9");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}