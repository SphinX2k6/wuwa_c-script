using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001945 RID: 6469
	[UnrealObjectPath("/Script/KuroGameScreenshot.KuroGameScreenshotBPLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroGameScreenshotBPLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017F9B RID: 98203 RVA: 0x002326BC File Offset: 0x002308BC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroGameScreenshotBPLibrary._ClassPtr;
		}

		// Token: 0x06017F9C RID: 98204 RVA: 0x002326C8 File Offset: 0x002308C8
		public UKuroGameScreenshotBPLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroGameScreenshotBPLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017F9D RID: 98205 RVA: 0x002326F0 File Offset: 0x002308F0
		[NullableContext(1)]
		public UKuroGameScreenshotBPLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroGameScreenshotBPLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06017F9E RID: 98206 RVA: 0x00232724 File Offset: 0x00230924
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SaveScreenshot(string FilePath, int Width, int Height, [Nullable(2)] in TArray<FColor> Colors)
		{
			UKuroGameScreenshotBPLibrary.__SaveScreenshot_FunctionParams* ptr = stackalloc UKuroGameScreenshotBPLibrary.__SaveScreenshot_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UKuroGameScreenshotBPLibrary.__SaveScreenshot_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroGameScreenshotBPLibrary.__SaveScreenshot_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->FilePath), FilePath);
			ptr->Width = Width;
			ptr->Height = Height;
			TArray<FColor> tarray = Colors;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Colors);
			}
			UnrealReflectionUtils.CallUFunction(UKuroGameScreenshotBPLibrary._ClassDefaultObjectPtr, UKuroGameScreenshotBPLibrary.__SaveScreenshot_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FColor> tarray2 = Colors;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Colors);
			}
			UnrealReflectionUtils.DestroyStruct(UKuroGameScreenshotBPLibrary.__SaveScreenshot_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06017F9F RID: 98207 RVA: 0x002327B8 File Offset: 0x002309B8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SaveColorArrayToOpenHarmonyAlbum(int Width, int Height, TArray<byte> BitMap)
		{
			UKuroGameScreenshotBPLibrary.__SaveColorArrayToOpenHarmonyAlbum_FunctionParams* ptr = stackalloc UKuroGameScreenshotBPLibrary.__SaveColorArrayToOpenHarmonyAlbum_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroGameScreenshotBPLibrary.__SaveColorArrayToOpenHarmonyAlbum_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroGameScreenshotBPLibrary.__SaveColorArrayToOpenHarmonyAlbum_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Width = Width;
			ptr->Height = Height;
			if (BitMap != null)
			{
				BitMap.CopyTo(&ptr->BitMap, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(UKuroGameScreenshotBPLibrary._ClassDefaultObjectPtr, UKuroGameScreenshotBPLibrary.__SaveColorArrayToOpenHarmonyAlbum_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroGameScreenshotBPLibrary.__SaveColorArrayToOpenHarmonyAlbum_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06017FA0 RID: 98208 RVA: 0x00232830 File Offset: 0x00230A30
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SaveColorArrayToIosAlbum(int Width, int Height, TArray<FColor> Colors)
		{
			UKuroGameScreenshotBPLibrary.__SaveColorArrayToIosAlbum_FunctionParams* ptr = stackalloc UKuroGameScreenshotBPLibrary.__SaveColorArrayToIosAlbum_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroGameScreenshotBPLibrary.__SaveColorArrayToIosAlbum_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroGameScreenshotBPLibrary.__SaveColorArrayToIosAlbum_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Width = Width;
			ptr->Height = Height;
			if (Colors != null)
			{
				Colors.CopyTo(&ptr->Colors, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(UKuroGameScreenshotBPLibrary._ClassDefaultObjectPtr, UKuroGameScreenshotBPLibrary.__SaveColorArrayToIosAlbum_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroGameScreenshotBPLibrary.__SaveColorArrayToIosAlbum_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06017FA1 RID: 98209 RVA: 0x002328A8 File Offset: 0x00230AA8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SaveColorArrayToAndroidAlbum(int Width, int Height, TArray<byte> BitMap)
		{
			UKuroGameScreenshotBPLibrary.__SaveColorArrayToAndroidAlbum_FunctionParams* ptr = stackalloc UKuroGameScreenshotBPLibrary.__SaveColorArrayToAndroidAlbum_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroGameScreenshotBPLibrary.__SaveColorArrayToAndroidAlbum_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroGameScreenshotBPLibrary.__SaveColorArrayToAndroidAlbum_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Width = Width;
			ptr->Height = Height;
			if (BitMap != null)
			{
				BitMap.CopyTo(&ptr->BitMap, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(UKuroGameScreenshotBPLibrary._ClassDefaultObjectPtr, UKuroGameScreenshotBPLibrary.__SaveColorArrayToAndroidAlbum_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroGameScreenshotBPLibrary.__SaveColorArrayToAndroidAlbum_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06017FA2 RID: 98210 RVA: 0x00232920 File Offset: 0x00230B20
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static UGameScreenshotTask PrepareTakeScreenshot(UObject Outer, [Nullable(1)] string InFilename, FVector2D MinCaptureRegion, FVector2D MaxCaptureRegion, float ScreenshotResolutionX, float ScreenshotResolutionY, bool SaveFile, int ResolutionMultiplier = 1)
		{
			UKuroGameScreenshotBPLibrary.__PrepareTakeScreenshot_FunctionParams* ptr = stackalloc UKuroGameScreenshotBPLibrary.__PrepareTakeScreenshot_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(UKuroGameScreenshotBPLibrary.__PrepareTakeScreenshot_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroGameScreenshotBPLibrary.__PrepareTakeScreenshot_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Outer = ((Outer != null) ? Outer.NativePtr : IntPtr.Zero);
			FString.CopyFrom((void*)(&ptr->InFilename), InFilename);
			ptr->MinCaptureRegion = MinCaptureRegion;
			ptr->MaxCaptureRegion = MaxCaptureRegion;
			ptr->ScreenshotResolutionX = ScreenshotResolutionX;
			ptr->ScreenshotResolutionY = ScreenshotResolutionY;
			ptr->SaveFile = SaveFile;
			ptr->ResolutionMultiplier = ResolutionMultiplier;
			UnrealReflectionUtils.CallUFunction(UKuroGameScreenshotBPLibrary._ClassDefaultObjectPtr, UKuroGameScreenshotBPLibrary.__PrepareTakeScreenshot_NativeFunctionPtr, (void*)ptr, 0);
			UGameScreenshotTask orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UGameScreenshotTask>(ptr->__Result);
			UnrealReflectionUtils.DestroyStruct(UKuroGameScreenshotBPLibrary.__PrepareTakeScreenshot_NativeFunctionPtr, (void*)ptr, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x06017FA3 RID: 98211 RVA: 0x002329CC File Offset: 0x00230BCC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool IsPhotoLibraryAuthorized()
		{
			UKuroGameScreenshotBPLibrary.__IsPhotoLibraryAuthorized_FunctionParams* ptr = stackalloc UKuroGameScreenshotBPLibrary.__IsPhotoLibraryAuthorized_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroGameScreenshotBPLibrary.__IsPhotoLibraryAuthorized_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroGameScreenshotBPLibrary.__IsPhotoLibraryAuthorized_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroGameScreenshotBPLibrary._ClassDefaultObjectPtr, UKuroGameScreenshotBPLibrary.__IsPhotoLibraryAuthorized_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06017FA4 RID: 98212 RVA: 0x00232A14 File Offset: 0x00230C14
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void ConvertColorsToBitmap(int Width, int Height, in TArray<FColor> Colors, ref TArray<byte> BitMap)
		{
			UKuroGameScreenshotBPLibrary.__ConvertColorsToBitmap_FunctionParams* ptr = stackalloc UKuroGameScreenshotBPLibrary.__ConvertColorsToBitmap_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UKuroGameScreenshotBPLibrary.__ConvertColorsToBitmap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroGameScreenshotBPLibrary.__ConvertColorsToBitmap_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Width = Width;
			ptr->Height = Height;
			TArray<FColor> tarray = Colors;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Colors);
			}
			TArray<byte> tarray2 = BitMap;
			if (tarray2 != null)
			{
				tarray2.MoveTo(&ptr->BitMap);
			}
			UnrealReflectionUtils.CallUFunction(UKuroGameScreenshotBPLibrary._ClassDefaultObjectPtr, UKuroGameScreenshotBPLibrary.__ConvertColorsToBitmap_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FColor> tarray3 = Colors;
			if (tarray3 != null)
			{
				tarray3.MoveAssign(&ptr->Colors);
			}
			TArray<byte> tarray4 = BitMap;
			if (tarray4 != null)
			{
				tarray4.MoveAssign(&ptr->BitMap);
			}
			UnrealReflectionUtils.DestroyStruct(UKuroGameScreenshotBPLibrary.__ConvertColorsToBitmap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06017FA5 RID: 98213 RVA: 0x00232AC4 File Offset: 0x00230CC4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void CompressConvertColorsToBitmap(int Width, int Height, in TArray<FColor> Colors, ref TArray<byte> BitMap)
		{
			UKuroGameScreenshotBPLibrary.__CompressConvertColorsToBitmap_FunctionParams* ptr = stackalloc UKuroGameScreenshotBPLibrary.__CompressConvertColorsToBitmap_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UKuroGameScreenshotBPLibrary.__CompressConvertColorsToBitmap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroGameScreenshotBPLibrary.__CompressConvertColorsToBitmap_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Width = Width;
			ptr->Height = Height;
			TArray<FColor> tarray = Colors;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Colors);
			}
			TArray<byte> tarray2 = BitMap;
			if (tarray2 != null)
			{
				tarray2.MoveTo(&ptr->BitMap);
			}
			UnrealReflectionUtils.CallUFunction(UKuroGameScreenshotBPLibrary._ClassDefaultObjectPtr, UKuroGameScreenshotBPLibrary.__CompressConvertColorsToBitmap_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FColor> tarray3 = Colors;
			if (tarray3 != null)
			{
				tarray3.MoveAssign(&ptr->Colors);
			}
			TArray<byte> tarray4 = BitMap;
			if (tarray4 != null)
			{
				tarray4.MoveAssign(&ptr->BitMap);
			}
			UnrealReflectionUtils.DestroyStruct(UKuroGameScreenshotBPLibrary.__CompressConvertColorsToBitmap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06017FA6 RID: 98214 RVA: 0x00232B72 File Offset: 0x00230D72
		static UKuroGameScreenshotBPLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameScreenshot.KuroGameScreenshotBPLibrary");
		}

		// Token: 0x06017FA7 RID: 98215 RVA: 0x00232B80 File Offset: 0x00230D80
		protected UKuroGameScreenshotBPLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CF81 RID: 53121
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameScreenshot.KuroGameScreenshotBPLibrary";

		// Token: 0x0400CF82 RID: 53122
		private static IntPtr _ClassPtr;

		// Token: 0x0400CF83 RID: 53123
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CF84 RID: 53124
		private static IntPtr __SaveScreenshot_NativeFunctionPtr;

		// Token: 0x0400CF85 RID: 53125
		private static IntPtr __SaveColorArrayToOpenHarmonyAlbum_NativeFunctionPtr;

		// Token: 0x0400CF86 RID: 53126
		private static IntPtr __SaveColorArrayToIosAlbum_NativeFunctionPtr;

		// Token: 0x0400CF87 RID: 53127
		private static IntPtr __SaveColorArrayToAndroidAlbum_NativeFunctionPtr;

		// Token: 0x0400CF88 RID: 53128
		private static IntPtr __PrepareTakeScreenshot_NativeFunctionPtr;

		// Token: 0x0400CF89 RID: 53129
		private static IntPtr __IsPhotoLibraryAuthorized_NativeFunctionPtr;

		// Token: 0x0400CF8A RID: 53130
		private static IntPtr __ConvertColorsToBitmap_NativeFunctionPtr;

		// Token: 0x0400CF8B RID: 53131
		private static IntPtr __CompressConvertColorsToBitmap_NativeFunctionPtr;

		// Token: 0x0200300D RID: 12301
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __SaveScreenshot_FunctionParams
		{
			// Token: 0x04016C2C RID: 93228
			[FieldOffset(0)]
			public FString FilePath;

			// Token: 0x04016C2D RID: 93229
			[FieldOffset(16)]
			public int Width;

			// Token: 0x04016C2E RID: 93230
			[FieldOffset(20)]
			public int Height;

			// Token: 0x04016C2F RID: 93231
			[FieldOffset(24)]
			public byte Colors;
		}

		// Token: 0x0200300E RID: 12302
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __SaveColorArrayToOpenHarmonyAlbum_FunctionParams
		{
			// Token: 0x04016C30 RID: 93232
			[FieldOffset(0)]
			public int Width;

			// Token: 0x04016C31 RID: 93233
			[FieldOffset(4)]
			public int Height;

			// Token: 0x04016C32 RID: 93234
			[FieldOffset(8)]
			public byte BitMap;
		}

		// Token: 0x0200300F RID: 12303
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __SaveColorArrayToIosAlbum_FunctionParams
		{
			// Token: 0x04016C33 RID: 93235
			[FieldOffset(0)]
			public int Width;

			// Token: 0x04016C34 RID: 93236
			[FieldOffset(4)]
			public int Height;

			// Token: 0x04016C35 RID: 93237
			[FieldOffset(8)]
			public byte Colors;
		}

		// Token: 0x02003010 RID: 12304
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __SaveColorArrayToAndroidAlbum_FunctionParams
		{
			// Token: 0x04016C36 RID: 93238
			[FieldOffset(0)]
			public int Width;

			// Token: 0x04016C37 RID: 93239
			[FieldOffset(4)]
			public int Height;

			// Token: 0x04016C38 RID: 93240
			[FieldOffset(8)]
			public byte BitMap;
		}

		// Token: 0x02003011 RID: 12305
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __PrepareTakeScreenshot_FunctionParams
		{
			// Token: 0x04016C39 RID: 93241
			[FieldOffset(0)]
			public IntPtr Outer;

			// Token: 0x04016C3A RID: 93242
			[FieldOffset(8)]
			public FString InFilename;

			// Token: 0x04016C3B RID: 93243
			[FieldOffset(24)]
			public FVector2D MinCaptureRegion;

			// Token: 0x04016C3C RID: 93244
			[FieldOffset(32)]
			public FVector2D MaxCaptureRegion;

			// Token: 0x04016C3D RID: 93245
			[FieldOffset(40)]
			public float ScreenshotResolutionX;

			// Token: 0x04016C3E RID: 93246
			[FieldOffset(44)]
			public float ScreenshotResolutionY;

			// Token: 0x04016C3F RID: 93247
			[FieldOffset(48)]
			public bool SaveFile;

			// Token: 0x04016C40 RID: 93248
			[FieldOffset(52)]
			public int ResolutionMultiplier;

			// Token: 0x04016C41 RID: 93249
			[FieldOffset(56)]
			public IntPtr __Result;
		}

		// Token: 0x02003012 RID: 12306
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsPhotoLibraryAuthorized_FunctionParams
		{
			// Token: 0x04016C42 RID: 93250
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003013 RID: 12307
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __ConvertColorsToBitmap_FunctionParams
		{
			// Token: 0x04016C43 RID: 93251
			[FieldOffset(0)]
			public int Width;

			// Token: 0x04016C44 RID: 93252
			[FieldOffset(4)]
			public int Height;

			// Token: 0x04016C45 RID: 93253
			[FieldOffset(8)]
			public byte Colors;

			// Token: 0x04016C46 RID: 93254
			[FieldOffset(24)]
			public byte BitMap;
		}

		// Token: 0x02003014 RID: 12308
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __CompressConvertColorsToBitmap_FunctionParams
		{
			// Token: 0x04016C47 RID: 93255
			[FieldOffset(0)]
			public int Width;

			// Token: 0x04016C48 RID: 93256
			[FieldOffset(4)]
			public int Height;

			// Token: 0x04016C49 RID: 93257
			[FieldOffset(8)]
			public byte Colors;

			// Token: 0x04016C4A RID: 93258
			[FieldOffset(24)]
			public byte BitMap;
		}
	}
}
