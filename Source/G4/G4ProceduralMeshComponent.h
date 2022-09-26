// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

// #include <g4/generators/g4_Generator.h>

#include "CoreMinimal.h"
#include "ProceduralMeshComponent.h"

// clang-format off
#include "G4ProceduralMeshComponent.generated.h"
// clang-format on

namespace g4 {
class IGeometryProvider;
}

/**
 *
 */
UCLASS(editinlinenew, meta = (BlueprintSpawnableComponent), ClassGroup = Rendering)
class G4_API UG4ProceduralMeshComponent : public UProceduralMeshComponent
{
    GENERATED_UCLASS_BODY()

public:
    // virtual ~UG4ProceduralMeshComponent() noexcept;

    UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = Material)
    class UMaterialInterface *pMaterial;

private:
    virtual void InitializeComponent() override;

    virtual void TickComponent(float deltaTime,
                               enum ELevelTick tickType,
                               FActorComponentTickFunction *pThisFunction) override;

private:
    // g4::Generator m_Generator;
    // g4::IGeometryProvider *m_pGeometryProvider = nullptr;
};
