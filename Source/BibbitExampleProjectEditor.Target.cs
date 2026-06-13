// Copyright BIBBIT Michal Nowak.

using UnrealBuildTool;

public class BibbitExampleProjectEditorTarget : TargetRules
{
	public BibbitExampleProjectEditorTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		ExtraModuleNames.Add("BibbitExampleProject");
	}
}
