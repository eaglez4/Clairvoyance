// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class ClairvoyanceTarget : TargetRules
{
	public ClairvoyanceTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		bUsesSteam = true;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "Clairvoyance" } );
	}
}
