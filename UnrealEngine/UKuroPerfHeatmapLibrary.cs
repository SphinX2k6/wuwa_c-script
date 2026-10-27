using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D01 RID: 3329
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KuroPerfHeatmapLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroPerfHeatmapLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B13E RID: 45374 RVA: 0x000FBA92 File Offset: 0x000F9C92
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroPerfHeatmapLibrary._ClassPtr;
		}

		// Token: 0x0600B13F RID: 45375 RVA: 0x000FBAA0 File Offset: 0x000F9CA0
		public UKuroPerfHeatmapLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroPerfHeatmapLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B140 RID: 45376 RVA: 0x000FBAC8 File Offset: 0x000F9CC8
		public UKuroPerfHeatmapLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroPerfHeatmapLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600B141 RID: 45377
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void WaitForRenderAssetsStreamingFinished();

		// Token: 0x0600B142 RID: 45378 RVA: 0x000FBAFB File Offset: 0x000F9CFB
		public static TArray<bool> TestCameraIntersectSceneComponent([Nullable(2)] UCameraComponent Camera, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<USceneComponent> SceneComponents)
		{
			return new TArray<bool>(UKuroPerfHeatmapLibrary.__TestCameraIntersectSceneComponent_Internal((Camera != null) ? Camera.NativePtr : IntPtr.Zero, (SceneComponents ?? new TArray<USceneComponent>()).NativePtr), null);
		}

		// Token: 0x0600B143 RID: 45379 RVA: 0x000FBB28 File Offset: 0x000F9D28
		public static TArray<bool> TestBoxIntersectSceneComponent(FBox Box, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<USceneComponent> SceneComponents)
		{
			return new TArray<bool>(UKuroPerfHeatmapLibrary.__TestBoxIntersectSceneComponent_Internal(Box, (SceneComponents ?? new TArray<USceneComponent>()).NativePtr), null);
		}

		// Token: 0x0600B144 RID: 45380
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetPreviewES3();

		// Token: 0x0600B145 RID: 45381 RVA: 0x000FBB48 File Offset: 0x000F9D48
		public unsafe static bool SaveFile(string Content, string Path)
		{
			FString fstring = FString.AllocTemp(Content);
			FString fstring2 = FString.AllocTemp(Path);
			bool result = UKuroPerfHeatmapLibrary.__SaveFile_Internal(fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x0600B146 RID: 45382
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsShaderCompiling();

		// Token: 0x0600B147 RID: 45383
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsCapturingFinished();

		// Token: 0x0600B148 RID: 45384
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetStatIncMax(FName StatName);

		// Token: 0x0600B149 RID: 45385
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetStatIncAverage(FName StatName);

		// Token: 0x0600B14A RID: 45386 RVA: 0x000FBB7E File Offset: 0x000F9D7E
		public static TArray<FName> GetStatGroupNames(FName GroupName)
		{
			return new TArray<FName>(UKuroPerfHeatmapLibrary.__GetStatGroupNames_Internal(GroupName), null);
		}

		// Token: 0x0600B14B RID: 45387 RVA: 0x000FBB8C File Offset: 0x000F9D8C
		[NullableContext(2)]
		public static int GetNumTrianglesOfStaticMesh(UStaticMesh StaticMesh, int LOD)
		{
			return UKuroPerfHeatmapLibrary.__GetNumTrianglesOfStaticMesh_Internal((StaticMesh != null) ? StaticMesh.NativePtr : IntPtr.Zero, LOD);
		}

		// Token: 0x0600B14C RID: 45388 RVA: 0x000FBBA4 File Offset: 0x000F9DA4
		public unsafe static UClassStackOnlyPtr FindClassByName(string Name)
		{
			FString fstring = FString.AllocTemp(Name);
			IntPtr ptr = UKuroPerfHeatmapLibrary.__FindClassByName_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return ptr;
		}

		// Token: 0x0600B14D RID: 45389 RVA: 0x000FBBCD File Offset: 0x000F9DCD
		public static FKuroFrameStatsCaptureResult EndCaptureFrameStats()
		{
			return new FKuroFrameStatsCaptureResult(UKuroPerfHeatmapLibrary.__EndCaptureFrameStats_Internal(), null);
		}

		// Token: 0x0600B14E RID: 45390
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void BeginCaptureFrameStatsMode(int NumFrames, int DelayFrames, EKuroFrameStatsCaptureMode Mode);

		// Token: 0x0600B14F RID: 45391
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void BeginCaptureFrameStats(int NumFrames, int DelayFrames);

		// Token: 0x0600B150 RID: 45392
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __TestCameraIntersectSceneComponent_Internal(IntPtr Camera, IntPtr SceneComponents);

		// Token: 0x0600B151 RID: 45393
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __TestBoxIntersectSceneComponent_Internal(FBox Box, IntPtr SceneComponents);

		// Token: 0x0600B152 RID: 45394
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SaveFile_Internal(in FString Content, in FString Path);

		// Token: 0x0600B153 RID: 45395
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetStatGroupNames_Internal(FName GroupName);

		// Token: 0x0600B154 RID: 45396
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumTrianglesOfStaticMesh_Internal(IntPtr StaticMesh, int LOD);

		// Token: 0x0600B155 RID: 45397
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindClassByName_Internal(in FString Name);

		// Token: 0x0600B156 RID: 45398
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __EndCaptureFrameStats_Internal();

		// Token: 0x0600B157 RID: 45399 RVA: 0x000FBBDA File Offset: 0x000F9DDA
		static UKuroPerfHeatmapLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.KuroPerfHeatmapLibrary");
		}

		// Token: 0x0600B158 RID: 45400 RVA: 0x000FBBE8 File Offset: 0x000F9DE8
		protected UKuroPerfHeatmapLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005CDB RID: 23771
		public new const string __ObjectPath = "/Script/Engine.KuroPerfHeatmapLibrary";

		// Token: 0x04005CDC RID: 23772
		private static IntPtr _ClassPtr;

		// Token: 0x04005CDD RID: 23773
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
