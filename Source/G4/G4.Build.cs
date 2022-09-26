// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.IO;

public class G4 : ModuleRules
{
    public G4(ReadOnlyTargetRules Target) : base(Target)
    {        
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });

        PrivateDependencyModuleNames.AddRange(new string[] { });

        // Uncomment if you are using Slate UI
        // PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

        // Uncomment if you are using online features
        // PrivateDependencyModuleNames.Add("OnlineSubsystem");

        // bUseRTTI = true;
        // bEnableExceptions = true;

        // PublicDefinitions.Add("G4_HEADER_ONLY_MODE");
        PublicDefinitions.Add("CGAL_NOT_HEADER_ONLY=0");
        PublicDefinitions.Add("CGAL_NO_MPFR=1");
        PublicDefinitions.Add("CGAL_NO_GMP=1");
        PublicDefinitions.Add("CGAL_DISABLE_GMP=1");
        // PublicDefinitions.Add("CGAL_DISABLE_NPFR=1");
        // PublicDefinitions.Add("CGAL_USE_LEDA=0");
        // PublicDefinitions.Add("CGAL_CXX20=0");
        // PublicDefinitions.Add("CGAL_FORCE_IFORMAT_DOUBLE=0");
        // PublicDefinitions.Add("BOOST_MSVC=0");
        // PublicDefinitions.Add("_MSC_VER=0");
        // PublicDefinitions.Add("_MSC_FULL_VER=0");

        // To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
        PublicIncludePaths.Add(Path.Combine("/usr", "include"));
        PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "eigen"));

        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "boost", "assert", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "boost", "array", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "boost", "algorithm", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "boost", "any", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "boost", "bimap", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "boost", "bind", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "boost", "config", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "boost", "container", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "boost", "container_hash", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "boost", "core", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "boost", "concept_check", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "boost", "detail", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "boost", "dynamic_bitset", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "boost", "foreach", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "boost", "fusion", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "boost", "format", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "boost", "graph", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "boost", "heap", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "boost", "iterator", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "boost", "intrusive", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "boost", "io", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "boost", "integer", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "boost", "lambda", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "boost", "lexical", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "boost", "mpl", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "boost", "move", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "boost", "math", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "boost", "mp11", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "boost", "multiprecision", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "boost", "multi_index", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "boost", "numeric", "conversion", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "boost", "optional", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "boost", "parameter", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "boost", "property_map", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "boost", "predef", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "boost", "preprocessor", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "boost", "range", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "boost", "random", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "boost", "smart_ptr", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "boost", "static_assert", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "boost", "serialization", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "boost", "type_traits", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "boost", "tuple", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "boost", "throw_exception", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "boost", "type_index", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "boost", "utility", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "boost", "unordered", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "boost", "variant", "include"));

        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "cgal", "AABB_tree", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "cgal", "Algebraic_foundations", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "cgal", "Arithmetic_kernel", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "cgal", "BGL", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "cgal", "Circulator", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "cgal", "Cartesian_kernel", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "cgal", "Distance_2", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "cgal", "Distance_3", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "cgal", "Poisson_surface_reconstruction_3", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "cgal", "Filtered_kernel", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "cgal", "Generator", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "cgal", "Homogeneous_kernel", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "cgal", "Hash_map", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "cgal", "HalfedgeDS", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "cgal", "Installation", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "cgal", "Interval_support", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "cgal", "Intersections_2", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "cgal", "Intersections_3", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "cgal", "Intersections_3", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "cgal", "Property_map", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "cgal", "Kernel_23", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "cgal", "Kernel_d", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "cgal", "Mesher_level", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "cgal", "Modular_arithmetic", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "cgal", "Modifier", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "cgal", "Number_types", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "cgal", "Point_set_processing_3", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "cgal", "Polyhedron", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "cgal", "Polygon_mesh_processing", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "cgal", "Profiling_tools", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "cgal", "Principal_component_analysis_LGPL", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "cgal", "Random_numbers", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "cgal", "Spatial_sorting", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "cgal", "Spatial_searching", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "cgal", "Solver_interface", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "cgal", "Surface_mesher", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "cgal", "Stream_support", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "cgal", "STL_Extension", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "cgal", "TDS_3", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "cgal", "Triangulation_3", "include"));
        // PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Externals", "cgal", "Union_find", "include")); 

        PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Libraries", "libg4.a"));

        // PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Libraries", "libg4.so"));
        // RuntimeDependencies.Add(Path.Combine(ModuleDirectory, "..", "..", "Externals", "g4", "Libraries", "libg4.so"));

        // PublicAdditionalLibraries.Add("/media/shuto/d/shuto/develop/github/GMP/.libs/libgmp.a");
        // PublicAdditionalLibraries.Add("gmp");
        // PublicAdditionalLibraries.Add("mpfr");
        // PublicAdditionalLibraries.Add(Path.Combine("/media", "shuto", "d", "shuto", "develop", "github", "sj", "g4", "Sources", "g4-sys", "target", "debug", "libg4_sys.a"));
        // PublicDelayLoadDLLs.Add("libg4_sys.so");
        // PublicDelayLoadDLLs.Add(Path.Combine("/media", "shuto", "d", "shuto", "develop", "github", "sj", "g4", "Sources", "g4-sys", "target", "debug", "libg4_sys.so"));
        // RuntimeDependencies.Add(Path.Combine("/media", "shuto", "d", "shuto", "develop", "github", "sj", "g4", "Sources", "g4-sys", "target", "debug"));

        // PublicAdditionalLibraries.Add(Path.Combine("/media", "shuto", "d", "shuto", "develop", "github", "GMP", ".libs", "libgmp.a"));
        // PublicAdditionalLibraries.Add(Path.Combine("/usr", "lib", "x86_64-linux-gnu", "libmpfr.so"));
        // PublicAdditionalLibraries.Add(Path.Combine("/usr", "lib", "gcc", "x86_64-linux-gnu", "11", "libstdc++.a"));
        // PublicAdditionalLibraries.Add(Path.Combine("libstdc++.a"));
        // PublicAdditionalLibraries.Add("libc++");
    }
}
