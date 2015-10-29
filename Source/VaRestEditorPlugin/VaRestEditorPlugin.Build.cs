// Some copyright should be here...

using UnrealBuildTool;

public class VaRestEditorPlugin : ModuleRules
{
	public VaRestEditorPlugin(TargetInfo Target)
	{
		
		PublicIncludePaths.AddRange(
			new string[] {
				"VaRestPlugin",
				"VaRestPlugin/Public"
				
				// ... add public include paths required here ...
			}
			);
				
		
		PrivateIncludePaths.AddRange(
			new string[] {
				"VaRestEditorPlugin/Private",
				
				// ... add other private include paths required here ...
			}
			);
			
		
		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
			        "VaRestPlugin"	
				// ... add other public dependencies that you statically link with here ...
			}
			);
			
		
		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
                            "CoreUObject",
                            "Engine",
                            "Slate",
                            "SlateCore",
                            "InputCore",
                            "AssetTools",
                            "UnrealEd", // for FAssetEditorManager
                            "KismetWidgets",
                            "KismetCompiler",
                            "BlueprintGraph",
                            "GraphEditor",
                            "Kismet",  // for FWorkflowCentricApplication
                            "PropertyEditor",
                            "EditorStyle",
                            "Sequencer",
                            "DetailCustomizations",
                            "Settings",
                            "RenderCore"	
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