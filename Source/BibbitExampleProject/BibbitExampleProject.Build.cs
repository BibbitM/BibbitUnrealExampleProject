// Copyright BIBBIT Michal Nowak.

using UnrealBuildTool;

public class BibbitExampleProject : ModuleRules
{
	public BibbitExampleProject(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(["Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput"]);

		PrivateDependencyModuleNames.AddRange([]);
	}
}