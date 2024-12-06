using UnrealBuildTool;

public class homework2ServerTarget : TargetRules
{
	public homework2ServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("homework2");
	}
}
