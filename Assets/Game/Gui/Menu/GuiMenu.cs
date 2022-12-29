using UnityEngine;
using System.Collections;
using PowerTools.Quest;
using PowerScript;
using static GlobalScript;

public class GuiMenu : GuiScript<GuiMenu>
{


	IEnumerator OnClickSelectStage( IGuiControl control )
	{
		Control("MainGrid").Hide();
		Control("ChapterGrid").Show();
		yield return E.Break;
	}

	void OnShow()
	{
		Container("ChapterGrid").Hide();
	}
}