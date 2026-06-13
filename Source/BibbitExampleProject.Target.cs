// Copyright BIBBIT Michal Nowak.

using UnrealBuildTool;

public class BibbitExampleProjectTarget : TargetRules
{
	public BibbitExampleProjectTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		ExtraModuleNames.Add("BibbitExampleProject");
	}
}
