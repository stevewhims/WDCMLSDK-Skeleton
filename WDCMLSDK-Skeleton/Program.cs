using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using WDCMLSDK;
using WDCMLSDKBase;

namespace WDCMLSDK_Skeleton
{
}

namespace WDCMLSDKDerived
{
	using WDCMLSDK_Skeleton;

	/// <summary>
	/// See the xml docs for ProgramBase.
	/// </summary>
	internal class Program : ProgramBase
	{
		// Logs
		private Log exampleLog = null;

		// Data
		private DocSet win10Docs = null;
		//private Dictionary<string, string> uniqueKeyMap = null;
		//private Dictionary<string, List<string>> nonUniqueKeyMap = null;

		static int Main(string[] args)
		{
			return (new Program()).Run();
		}

		protected override void OnRun()
		{
			// Load a docset.
			this.win10Docs = DocSet.CreateDocSet(DocSetType.ConceptualAndReference, Platform.UWPWindows10, "Win10 docs");

			this.exampleLog = new Log()
			{
				Label = "Text log containing info too verbose for the console.",
				Filename = "Example_Log.txt",
				AnnouncementStyle = ConsoleWriteStyle.Default
			};
			this.RegisterLog(this.exampleLog);
			this.exampleLog.Add("Example message.");

			//this.uniqueKeyMap = this.LoadUniqueKeyMap("uniqueKeyMap.txt");
			//this.nonUniqueKeyMap = this.LoadNonUniqueKeyMap("nonUniqueKeyMap.txt");
		}
	}
}