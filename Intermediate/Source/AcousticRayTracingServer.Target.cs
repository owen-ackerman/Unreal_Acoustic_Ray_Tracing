using UnrealBuildTool;

public class AcousticRayTracingServerTarget : TargetRules
{
	public AcousticRayTracingServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("AcousticRayTracing");
	}
}
