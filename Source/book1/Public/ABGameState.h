// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "book1.h"
#include "GameFramework/GameStateBase.h"
#include "ABGameState.generated.h"

/**
 * 
 */
UCLASS()
class BOOK1_API AABGameState : public AGameStateBase
{
	GENERATED_BODY()

public:
	AABGameState();

public:
	int32 GetTotalGameScore() const;
	void AddGameScore();
	void SetGameCleared();
	bool IsGameCleared() const;

private:
	UPROPERTY(Transient)
	int32 TotalGameScore;

	UPROPERTY(Transient)
		bool bGameCleared;
};
