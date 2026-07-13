using UnrealBuildTool;

public class AcousticRayTracingTarget : TargetRules
{
	public AcousticRayTracingTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("AcousticRayTracing");
	}
}
