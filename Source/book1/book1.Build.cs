// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class book1 : ModuleRules
{
	public book1(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay","UMG", "NavigationSystem","AIModule","GameplayTasks"});

		PrivateDependencyModuleNames.AddRange(new string[] { "ArenaBattleSetting" });
	}
	
}
