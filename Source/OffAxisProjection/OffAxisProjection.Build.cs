// Some copyright should be here...

using UnrealBuildTool;
using System.IO;

public class OffAxisProjection : ModuleRules
{
	public OffAxisProjection(ReadOnlyTargetRules Target) : base(Target)
	{
        //PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
        PrivatePCHHeaderFile = "Public/OffAxisProjection.h";

        PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Public"));
				
		
		PrivateIncludePaths.AddRange(
			new string[] {
				"OffAxisProjection/Private",
				
				// ... add other private include paths required here ...
			}
			);
			
		
		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
                "Slate",
                "SlateCore",
                "InputCore",
                "UMG",
                // ... add other public dependencies that you statically link with here ...
			}
            );
			
		
		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"CoreUObject",
				"Engine",
			    "ShaderCore",
                "HeadMountedDisplay",        
                "RHI",
                "RenderCore",
				// ... add private dependencies that you statically link with here ...	
			}
            );
		
		
		DynamicallyLoadedModuleNames.AddRange(
			new string[]
			{
				// ... add any modules that your module loads dynamically here ...
			}
			);
	}
}
