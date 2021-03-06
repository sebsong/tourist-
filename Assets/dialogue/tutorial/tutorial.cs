﻿/*
------------------------------------------------
Generated by Cradle 2.0.1.0
https://github.com/daterre/Cradle

Original file: tutorial.html
Story format: Harlowe
------------------------------------------------
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cradle;
using IStoryThread = System.Collections.Generic.IEnumerable<Cradle.StoryOutput>;
using Cradle.StoryFormats.Harlowe;

public partial class @tutorial: Cradle.StoryFormats.Harlowe.HarloweStory
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

	@tutorial()
	{
		this.StartPassage = "npc0";

		base.Vars = new VarDefs() { Story = this, StrictMode = true };

		macros1 = new Cradle.StoryFormats.Harlowe.HarloweRuntimeMacros() { Story = this };

		base.Init();
		passage1_Init();
		passage2_Init();
		passage3_Init();
		passage4_Init();
		passage5_Init();
		passage6_Init();
		passage7_Init();
	}

	// ---------------
	#endregion

	// .............
	// #1: npc0

	void passage1_Init()
	{
		this.Passages[@"npc0"] = new StoryPassage(@"npc0", new string[]{  }, passage1_Main);
	}

	IStoryThread passage1_Main()
	{
		yield return text("Welcome to town!  Or as we like to say, Comet Owlet Won!  ");
		yield return lineBreak();
		yield return link("space", "npc1", null);
		yield break;
	}


	// .............
	// #2: player1

	void passage2_Init()
	{
		this.Passages[@"player1"] = new StoryPassage(@"player1", new string[]{ "player", }, passage2_Main);
	}

	IStoryThread passage2_Main()
	{
		yield return text("Oh no! Where’s my backpack? I must have left it somewhere along the way to town.");
		yield return lineBreak();
		yield return link("space", "player2", null);
		yield break;
	}


	// .............
	// #3: npc1

	void passage3_Init()
	{
		this.Passages[@"npc1"] = new StoryPassage(@"npc1", new string[]{  }, passage3_Main);
	}

	IStoryThread passage3_Main()
	{
		yield return text("Get it?  Like, an anagram. Like we talk in anagrams. ");
		yield return lineBreak();
		yield return link("space", "player0", null);
		yield break;
	}


	// .............
	// #4: player0

	void passage4_Init()
	{
		this.Passages[@"player0"] = new StoryPassage(@"player0", new string[]{ "player", }, passage4_Main);
	}

	IStoryThread passage4_Main()
	{
		yield return text("Good thing I have my backpack full of travel guides and anagram dictionaries...");
		yield return lineBreak();
		yield return link("space", "npc2", null);
		yield break;
	}


	// .............
	// #5: npc2

	void passage5_Init()
	{
		this.Passages[@"npc2"] = new StoryPassage(@"npc2", new string[]{  }, passage5_Main);
	}

	IStoryThread passage5_Main()
	{
		yield return text("Backpack?  TAB WHACK PACK? You know there is HONG TIN on your back, right?");
		yield return lineBreak();
		yield return link("space", "player1", null);
		yield break;
	}


	// .............
	// #6: player2

	void passage6_Init()
	{
		this.Passages[@"player2"] = new StoryPassage(@"player2", new string[]{ "player", }, passage6_Main);
	}

	IStoryThread passage6_Main()
	{
		yield return text("Maybe the people around here can help me if I talk to enough of them!");
		yield return lineBreak();
		yield return link("space", "player3", null);
		yield break;
	}


	// .............
	// #7: player3

	void passage7_Init()
	{
		this.Passages[@"player3"] = new StoryPassage(@"player3", new string[]{ "player", "end", }, passage7_Main);
	}

	IStoryThread passage7_Main()
	{
		yield return text("After all, who needs travel guides and dictionaries when you can learn directly from the locals?");
		yield return lineBreak();
		yield return link("space", "npc0", null);
		yield break;
	}


}