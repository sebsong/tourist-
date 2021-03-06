﻿/*
------------------------------------------------
Generated by Cradle 2.0.1.0
https://github.com/daterre/Cradle

Original file: grumpy_guy4.html
Story format: Harlowe
------------------------------------------------
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cradle;
using IStoryThread = System.Collections.Generic.IEnumerable<Cradle.StoryOutput>;
using Cradle.StoryFormats.Harlowe;

public partial class @grumpy_guy4: Cradle.StoryFormats.Harlowe.HarloweStory
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

	@grumpy_guy4()
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
		yield return text("Thanks for the COAL HOT!");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("space", "rando1", null);
		yield break;
	}


}