using UnrealBuildTool;

public class AcousticRayTracingClientTarget : TargetRules
{
	public AcousticRayTracingClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("AcousticRayTracing");
	}
}
