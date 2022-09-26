// Fill out your copyright notice in the Description page of Project Settings.

// #pragma clang diagnostic ignored "-Wundef"
// #pragma clang diagnostic ignored "-Wignored-attributes"
// #pragma clang diagnostic ignored "-Wshadow"
// #pragma clang diagnostic ignored "-Wcompound-token-split-by-macro"
// #pragma clang diagnostic ignored "-Wc++20-extensions"

#include "G4ProceduralMeshComponent.h"

// #include <g4/common/g4_FloatTypes.h>
// #include <g4/generators/g4_IGeometryProvider.h>
// #include <g4/generators/g4_IMeshBuffer.h>
// #include <g4/util/g4_LinearInterpolator.h>
// #include <g4/util/g4_SimplePointGenerator.h>
// #include <g4/util/g4_VectorMeshBuffer.h>

// #include <array>
// #include <cstring>
// #include <vector>

namespace {

// class GeometryProvider final : public g4::IGeometryProvider
// {
// public:
//     virtual ~GeometryProvider() noexcept = default;

//     virtual int GetVertexCount() const noexcept override
//     {
//         return static_cast<int>(m_Vertices.size());
//     }

//     virtual void GetVertex(g4::Vertex* pOutVertex, int index) const noexcept override
//     {
//         std::memcpy(pOutVertex, &m_Vertices[index], sizeof(g4::Vertex));
//     }

//     virtual int GetEdgeCount() const noexcept override { return static_cast<int>(m_Edges.size());
//     }

//     virtual void GetEdgeConnection(g4::EdgeConnection* pOutEdgeConnection,
//                                    int index) const noexcept override
//     {
//         std::memcpy(pOutEdgeConnection, &m_Edges[index], sizeof(g4::EdgeConnection));
//     }

// private:
//     // clang-format off
//     std::array<g4::Vertex, 2> m_Vertices      = {{
//         {0.0f, 0.0f, 0.0f, 0.0f},
//         {30.0f, 0.0f, 0.0f, 0.0f}
//     }};
//     // clang-format on
//     std::array<g4::EdgeConnection, 1> m_Edges = {g4::MakeEdge(0, 1)};
// };

}  // namespace

UG4ProceduralMeshComponent::UG4ProceduralMeshComponent(const FObjectInitializer& objectInitializer)
    : Super(objectInitializer)
{
    PrimaryComponentTick.bCanEverTick = true;
    // m_pGeometryProvider               = new GeometryProvider{};
}

// UG4ProceduralMeshComponent::~UG4ProceduralMeshComponent() noexcept
// {
//     // delete m_pGeometryProvider;
// }

void UG4ProceduralMeshComponent::InitializeComponent()
{
    Super::InitializeComponent();
    PrimaryComponentTick.SetTickFunctionEnable(true);
}

void UG4ProceduralMeshComponent::TickComponent(float deltaTime,
                                               enum ELevelTick tickType,
                                               FActorComponentTickFunction* pThisFunction)
{
    if (GetNumSections() == 0) {
        // const auto result = add(7, 8);
        // rust_function();
        const auto result = 15;
        UE_LOG(LogTemp, Warning, TEXT("Hello Log : %d"), result);
        // auto* pInstance = create_generator();
        // destroy_generator(pInstance);
        // g4::util::LinearInterpolator interpolator;
        // g4::util::SimplePointGenerator pointGenerator;
        // g4::util::VectorMeshBuffer meshBuffer;
        // m_Generator.Execute(&meshBuffer, m_pGeometryProvider, &interpolator, &pointGenerator);
        // Generate(nullptr);
        // A();

        // 頂点群
        TArray<FVector> vertices;
        // インデックス群
        TArray<int32> indices;
        // 法線群（今回は空っぽのまま）
        TArray<FVector> normals;
        // テクスチャー座標群
        TArray<FVector2D> texcoords0;
        // 頂点カラー群（今回は空っぽのまま）
        TArray<FLinearColor> vertex_colors;
        // 接線群（今回は空っぽのまま）
        TArray<FProcMeshTangent> tangents;

        constexpr auto length = 100.0f;
        vertices.Emplace(0.0f, 0.0f, 30.0f);
        vertices.Emplace(0.0f, length, 30.0f);
        vertices.Emplace(length, 0.0f, 30.0f);
        indices.Emplace(0);
        indices.Emplace(1);
        indices.Emplace(2);
        CreateMeshSection_LinearColor(0, vertices, indices, normals, texcoords0, vertex_colors,
                                      tangents, true);
    }
}