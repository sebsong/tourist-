﻿/*
------------------------------------------------
Generated by Cradle 2.0.1.0
https://github.com/daterre/Cradle

Original file: rando_translated.html
Story format: Harlowe
------------------------------------------------
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cradle;
using IStoryThread = System.Collections.Generic.IEnumerable<Cradle.StoryOutput>;
using Cradle.StoryFormats.Harlowe;

public partial class @rando_translated: Cradle.StoryFormats.Harlowe.HarloweStory
{
	#region Variables
	// ---------------

	public class VarDefs: RuntimeVars
	{
		public VarDefs()
		{
		}

	}

	public new VarDefs Vars
	{
		get { return (VarDefs) base.Vars; }
	}

	// ---------------
	#endregion

	#region Initialization
	// ---------------

	public readonly Cradle.StoryFormats.Harlowe.HarloweRuntimeMacros macros1;

	@rando_translated()
	{
		this.StartPassage = "rando1";

		base.Vars = new VarDefs() { Story = this, StrictMode = true };

		macros1 = new Cradle.StoryFormats.Harlowe.HarloweRuntimeMacros() { Story = this };

		base.Init();
		passage1_Init();
	}

	// ---------------
	#endregion

	// .............
	// #1: rando1

	void passage1_Init()
	{
		this.Passages[@"rando1"] = new StoryPassage(@"rando1", new string[]{ "end", }, passage1_Main);
	}

	IStoryThread passage1_Main()
	{
		yield return text("I hear the painting is located in the top left corner. It's hard to spot, so you'll need to get real close.");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("space", "rando1", null);
		yield break;
	}


}