// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class ClairvoyanceEditorTarget : TargetRules
{
	public ClairvoyanceEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		bUsesSteam = true;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "Clairvoyance" } );
	}
}
