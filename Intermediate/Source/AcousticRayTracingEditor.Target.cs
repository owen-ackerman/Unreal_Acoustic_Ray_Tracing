using UnrealBuildTool;

public class AcousticRayTracingEditorTarget : TargetRules
{
	public AcousticRayTracingEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("AcousticRayTracing");
	}
}
