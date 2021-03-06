///////////////////////////////////////////////////////////////////////////////
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

namespace Epiroc._Suraj
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The DB_Validation recording.
    /// </summary>
    [TestModule("2f05f6ac-49c8-44f2-8334-4a2ccdb723bb", ModuleType.Recording, 1)]
    public partial class DB_Validation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Epiroc.EpirocRepository repository.
        /// </summary>
        public static global::Epiroc.EpirocRepository repo = global::Epiroc.EpirocRepository.Instance;

        static DB_Validation instance = new DB_Validation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DB_Validation()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DB_Validation Instance
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

            try {
                //Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='1') on item 'DemoApp.LblNumberOfPersonsNumber'.", repo.DemoApp.LblNumberOfPersonsNumberInfo, new RecordItemIndex(0));
                //Validate.AttributeEqual(repo.DemoApp.LblNumberOfPersonsNumberInfo, "Text", "1", null, false);
                //Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(0)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
