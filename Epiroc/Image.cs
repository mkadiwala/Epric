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

namespace Epiroc
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Image recording.
    /// </summary>
    [TestModule("65393119-7c75-44ad-9417-1b4b2b559244", ModuleType.Recording, 1)]
    public partial class Image : ITestModule
    {
        /// <summary>
        /// Holds an instance of the EpirocRepository repository.
        /// </summary>
        public static EpirocRepository repo = EpirocRepository.Instance;

        static Image instance = new Image();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Image()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Image Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Paint3D.ToolText' at .531;.75.", repo.Paint3D.ToolTextInfo, new RecordItemIndex(0));
            repo.Paint3D.ToolText.Click(".531;.75");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse None Move item 'Paint3D.SwitchViewText' at .762;.5.", repo.Paint3D.SwitchViewTextInfo, new RecordItemIndex(1));
            repo.Paint3D.SwitchViewText.MoveTo(".762;.5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Paint3D.ZoomInteractor' at 18;84.", repo.Paint3D.ZoomInteractorInfo, new RecordItemIndex(2));
            repo.Paint3D.ZoomInteractor.Click(new Location(ZoomInteractor_Screenshot1, "18;84", ZoomInteractor_Screenshot1_Options));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Paint3D.ZoomInteractor' at 4;15.", repo.Paint3D.ZoomInteractorInfo, new RecordItemIndex(3));
            repo.Paint3D.ZoomInteractor.Click(new Location(ZoomInteractor_Screenshot1_2, "4;15", ZoomInteractor_Screenshot1_2_Options));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating CompareImage (Screenshot: 'Screenshot1' with region {X=176,Y=360,Width=150,Height=132}) on item 'Paint3D.ZoomInteractor'.", repo.Paint3D.ZoomInteractorInfo, new RecordItemIndex(4));
            Validate.CompareImage(repo.Paint3D.ZoomInteractorInfo, ZoomInteractor_Screenshot1_3, ZoomInteractor_Screenshot1_3_Options, null, new Validate.Options(){ReportSimilarity=Validate.ResultOption.Always, ReportDifferenceImages=Validate.ResultOption.Always, ReportExpectedAndActualImages=Validate.ResultOption.Always});
            Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Paint3D.ZoomInteractor' at 4;4.", repo.Paint3D.ZoomInteractorInfo, new RecordItemIndex(5));
            //repo.Paint3D.ZoomInteractor.Click(new Location(ZoomInteractor_Screenshot2, "4;4", ZoomInteractor_Screenshot2_Options));
            //Delay.Milliseconds(0);
            
        }

#region Image Feature Data
        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage ZoomInteractor_Screenshot1
        { get { return repo.Paint3D.ZoomInteractorInfo.GetScreenshot1(new Rectangle(190, 375, 119, 94)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions ZoomInteractor_Screenshot1_Options
        { get { return Imaging.FindOptions.Parse("0.97;EdgesSobel;0,0,0,0;True;10000000;0ms"); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage ZoomInteractor_Screenshot1_2
        { get { return repo.Paint3D.ZoomInteractorInfo.GetScreenshot1(new Rectangle(324, 271, 8, 19)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions ZoomInteractor_Screenshot1_2_Options
        { get { return Imaging.FindOptions.Default; } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage ZoomInteractor_Screenshot1_3
        { get { return repo.Paint3D.ZoomInteractorInfo.GetScreenshot1(new Rectangle(176, 360, 150, 132)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions ZoomInteractor_Screenshot1_3_Options
        { get { return Imaging.FindOptions.Parse("0.97;None;176,360,150,132;True;10000000;0ms"); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage ZoomInteractor_Screenshot2
        { get { return repo.Paint3D.ZoomInteractorInfo.GetScreenshot2(new Rectangle(319, 328, 8, 8)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions ZoomInteractor_Screenshot2_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}
