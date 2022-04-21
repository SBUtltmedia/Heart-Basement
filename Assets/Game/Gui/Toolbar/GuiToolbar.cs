using UnityEngine;
using System.Collections;
using PowerTools.Quest;
using PowerScript;
using static GlobalScript;

public class GuiToolbar : GuiScript<GuiToolbar>
{


	IEnumerator OnClickNewButtonText( IGuiControl control )
	{
		Settings.LanguageId = (Settings.LanguageId + 1) % Settings.GetLanguages().Length;
		
		
		yield return E.Break;
	}
}