// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class PakFileUtilitiesEx : ModuleRules
{
	public PakFileUtilitiesEx(ReadOnlyTargetRules Target) : base(Target)
	{
		PrivateDependencyModuleNames.AddRange(new string[] { "Core", "PakFile", "Json", "Projects", "RSA" });

        PrivateIncludePathModuleNames.AddRange(
            new string[] {
                "Json"
        });
        OptimizeCode = CodeOptimization.InShippingBuildsOnly;
    }
}
