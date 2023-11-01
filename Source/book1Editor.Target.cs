// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class book1EditorTarget : TargetRules
{
	public book1EditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		//DefaultBuildSettings = BuildSettingsVersion.V2;
		//ExtraModuleNames.Add("book1");
		ExtraModuleNames.AddRange(new string[] { "book1", "ArenaBattleSetting" });
	}
}
