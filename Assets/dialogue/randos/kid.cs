﻿/*
------------------------------------------------
Generated by Cradle 2.0.1.0
https://github.com/daterre/Cradle

Original file: kid.html
Story format: Harlowe
------------------------------------------------
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cradle;
using IStoryThread = System.Collections.Generic.IEnumerable<Cradle.StoryOutput>;
using Cradle.StoryFormats.Harlowe;

public partial class @kid: Cradle.StoryFormats.Harlowe.HarloweStory
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

	@kid()
	{
		this.StartPassage = "kid1";

		base.Vars = new VarDefs() { Story = this, StrictMode = true };

		macros1 = new Cradle.StoryFormats.Harlowe.HarloweRuntimeMacros() { Story = this };

		base.Init();
		passage1_Init();
	}

	// ---------------
	#endregion

	// .............
	// #1: kid1

	void passage1_Init()
	{
		this.Passages[@"kid1"] = new StoryPassage(@"kid1", new string[]{ "end", }, passage1_Main);
	}

	IStoryThread passage1_Main()
	{
		yield return text("Don't pet my dog... He's a weirdo");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("space", "kid1", null);
		yield break;
	}


}