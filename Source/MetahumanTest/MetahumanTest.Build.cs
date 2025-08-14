// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class MetahumanTest : ModuleRules
{
	public MetahumanTest(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"MetahumanTest",
			"MetahumanTest/Variant_Platforming",
			"MetahumanTest/Variant_Combat",
			"MetahumanTest/Variant_Combat/AI",
			"MetahumanTest/Variant_SideScrolling",
			"MetahumanTest/Variant_SideScrolling/Gameplay",
			"MetahumanTest/Variant_SideScrolling/AI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
