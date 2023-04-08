using UnrealBuildTool;

public class FYPmechanicsTarget : TargetRules
{
	public FYPmechanicsTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("FYPmechanics");
	}
}
