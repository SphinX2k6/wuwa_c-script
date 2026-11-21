using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200022D RID: 557
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KuroPerfHeatmapLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroPerfHeatmapLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002D01 RID: 11521 RVA: 0x0003F931 File Offset: 0x0003DB31
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroPerfHeatmapLibrary._ClassPtr;
		}

		// Token: 0x06002D02 RID: 11522 RVA: 0x0003F940 File Offset: 0x0003DB40
		public UKuroPerfHeatmapLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroPerfHeatmapLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002D03 RID: 11523 RVA: 0x0003F968 File Offset: 0x0003DB68
		public UKuroPerfHeatmapLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroPerfHeatmapLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06002D04 RID: 11524
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void WaitForRenderAssetsStreamingFinished();

		// Token: 0x06002D05 RID: 11525 RVA: 0x0003F99B File Offset: 0x0003DB9B
		public static TArray<bool> TestCameraIntersectSceneComponent([Nullable(2)] UCameraComponent Camera, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<USceneComponent> SceneComponents)
		{
			return new TArray<bool>(UKuroPerfHeatmapLibrary.__TestCameraIntersectSceneComponent_Internal((Camera != null) ? Camera.NativePtr : IntPtr.Zero, (SceneComponents ?? new TArray<USceneComponent>()).NativePtr), null);
		}

		// Token: 0x06002D06 RID: 11526 RVA: 0x0003F9C8 File Offset: 0x0003DBC8
		public static TArray<bool> TestBoxIntersectSceneComponent(FBox Box, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<USceneComponent> SceneComponents)
		{
			return new TArray<bool>(UKuroPerfHeatmapLibrary.__TestBoxIntersectSceneComponent_Internal(Box, (SceneComponents ?? new TArray<USceneComponent>()).NativePtr), null);
		}

		// Token: 0x06002D07 RID: 11527
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetPreviewES3();

		// Token: 0x06002D08 RID: 11528 RVA: 0x0003F9E8 File Offset: 0x0003DBE8
		public unsafe static bool SaveFile(string Content, string Path)
		{
			FString fstring = FString.AllocTemp(Content);
			FString fstring2 = FString.AllocTemp(Path);
			bool result = UKuroPerfHeatmapLibrary.__SaveFile_Internal(fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06002D09 RID: 11529
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsShaderCompiling();

		// Token: 0x06002D0A RID: 11530
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsCapturingFinished();

		// Token: 0x06002D0B RID: 11531
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetStatIncMax(FName StatName);

		// Token: 0x06002D0C RID: 11532
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetStatIncAverage(FName StatName);

		// Token: 0x06002D0D RID: 11533 RVA: 0x0003FA1E File Offset: 0x0003DC1E
		public static TArray<FName> GetStatGroupNames(FName GroupName)
		{
			return new TArray<FName>(UKuroPerfHeatmapLibrary.__GetStatGroupNames_Internal(GroupName), null);
		}

		// Token: 0x06002D0E RID: 11534 RVA: 0x0003FA2C File Offset: 0x0003DC2C
		[NullableContext(2)]
		public static int GetNumTrianglesOfStaticMesh(UStaticMesh StaticMesh, int LOD)
		{
			return UKuroPerfHeatmapLibrary.__GetNumTrianglesOfStaticMesh_Internal((StaticMesh != null) ? StaticMesh.NativePtr : IntPtr.Zero, LOD);
		}

		// Token: 0x06002D0F RID: 11535 RVA: 0x0003FA44 File Offset: 0x0003DC44
		public unsafe static UClassStackOnlyPtr FindClassByName(string Name)
		{
			FString fstring = FString.AllocTemp(Name);
			IntPtr ptr = UKuroPerfHeatmapLibrary.__FindClassByName_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return ptr;
		}

		// Token: 0x06002D10 RID: 11536 RVA: 0x0003FA6D File Offset: 0x0003DC6D
		public static FKuroFrameStatsCaptureResult EndCaptureFrameStats()
		{
			return new FKuroFrameStatsCaptureResult(UKuroPerfHeatmapLibrary.__EndCaptureFrameStats_Internal(), null);
		}

		// Token: 0x06002D11 RID: 11537
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void BeginCaptureFrameStatsMode(int NumFrames, int DelayFrames, EKuroFrameStatsCaptureMode Mode);

		// Token: 0x06002D12 RID: 11538
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void BeginCaptureFrameStats(int NumFrames, int DelayFrames);

		// Token: 0x06002D13 RID: 11539
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __TestCameraIntersectSceneComponent_Internal(IntPtr Camera, IntPtr SceneComponents);

		// Token: 0x06002D14 RID: 11540
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __TestBoxIntersectSceneComponent_Internal(FBox Box, IntPtr SceneComponents);

		// Token: 0x06002D15 RID: 11541
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SaveFile_Internal(in FString Content, in FString Path);

		// Token: 0x06002D16 RID: 11542
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetStatGroupNames_Internal(FName GroupName);

		// Token: 0x06002D17 RID: 11543
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumTrianglesOfStaticMesh_Internal(IntPtr StaticMesh, int LOD);

		// Token: 0x06002D18 RID: 11544
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindClassByName_Internal(in FString Name);

		// Token: 0x06002D19 RID: 11545
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __EndCaptureFrameStats_Internal();

		// Token: 0x06002D1A RID: 11546 RVA: 0x0003FA7A File Offset: 0x0003DC7A
		static UKuroPerfHeatmapLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.KuroPerfHeatmapLibrary");
		}

		// Token: 0x06002D1B RID: 11547 RVA: 0x0003FA88 File Offset: 0x0003DC88
		protected UKuroPerfHeatmapLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000E4C RID: 3660
		public new const string __ObjectPath = "/Script/Engine.KuroPerfHeatmapLibrary";

		// Token: 0x04000E4D RID: 3661
		private static IntPtr _ClassPtr;

		// Token: 0x04000E4E RID: 3662
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
