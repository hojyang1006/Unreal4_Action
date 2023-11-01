// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class book1Target : TargetRules
{
	public book1Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		//DefaultBuildSettings = BuildSettingsVersion.V2;
		//ExtraModuleNames.Add("book1");
		ExtraModuleNames.AddRange(new string[] { "book1","ArenaBattleSetting" });
	}
}
