// Copyright Epic Games, Inc. All Rights Reserved.

#include "book1GameMode.h"
#include "book1Character.h"
#include "UObject/ConstructorHelpers.h"

Abook1GameMode::Abook1GameMode()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnBPClass(TEXT("/Game/ThirdPersonCPP/Blueprints/ThirdPersonCharacter"));
	if (PlayerPawnBPClass.Class != NULL)
	{
		DefaultPawnClass = PlayerPawnBPClass.Class;
	}
}
