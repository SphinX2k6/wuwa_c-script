using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000425 RID: 1061
	[UnrealObjectPath("/Script/KuroGameScreenshot.KuroGameScreenshotBPLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroGameScreenshotBPLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600663E RID: 26174 RVA: 0x00092D0C File Offset: 0x00090F0C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroGameScreenshotBPLibrary._ClassPtr;
		}

		// Token: 0x0600663F RID: 26175 RVA: 0x00092D18 File Offset: 0x00090F18
		public UKuroGameScreenshotBPLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroGameScreenshotBPLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006640 RID: 26176 RVA: 0x00092D40 File Offset: 0x00090F40
		[NullableContext(1)]
		public UKuroGameScreenshotBPLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroGameScreenshotBPLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006641 RID: 26177 RVA: 0x00092D74 File Offset: 0x00090F74
		[NullableContext(1)]
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(UKuroGameScreenshotBPLibrary._ClassDefaultObjectPtr, UKuroGameScreenshotBPLibrary.__SaveScreenshot_NativeFunctionPtr, (void*)ptr);
			TArray<FColor> tarray2 = Colors;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Colors);
			}
			UnrealReflectionUtils.DestroyStruct(UKuroGameScreenshotBPLibrary.__SaveScreenshot_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06006642 RID: 26178 RVA: 0x00092E08 File Offset: 0x00091008
		[NullableContext(2)]
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(UKuroGameScreenshotBPLibrary._ClassDefaultObjectPtr, UKuroGameScreenshotBPLibrary.__SaveColorArrayToOpenHarmonyAlbum_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroGameScreenshotBPLibrary.__SaveColorArrayToOpenHarmonyAlbum_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06006643 RID: 26179 RVA: 0x00092E80 File Offset: 0x00091080
		[NullableContext(2)]
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(UKuroGameScreenshotBPLibrary._ClassDefaultObjectPtr, UKuroGameScreenshotBPLibrary.__SaveColorArrayToIosAlbum_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroGameScreenshotBPLibrary.__SaveColorArrayToIosAlbum_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06006644 RID: 26180 RVA: 0x00092EF8 File Offset: 0x000910F8
		[NullableContext(2)]
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(UKuroGameScreenshotBPLibrary._ClassDefaultObjectPtr, UKuroGameScreenshotBPLibrary.__SaveColorArrayToAndroidAlbum_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroGameScreenshotBPLibrary.__SaveColorArrayToAndroidAlbum_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06006645 RID: 26181 RVA: 0x00092F70 File Offset: 0x00091170
		[NullableContext(2)]
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(UKuroGameScreenshotBPLibrary._ClassDefaultObjectPtr, UKuroGameScreenshotBPLibrary.__PrepareTakeScreenshot_NativeFunctionPtr, (void*)ptr);
			UGameScreenshotTask orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UGameScreenshotTask>(ptr->__Result);
			UnrealReflectionUtils.DestroyStruct(UKuroGameScreenshotBPLibrary.__PrepareTakeScreenshot_NativeFunctionPtr, (void*)ptr, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x06006646 RID: 26182 RVA: 0x0009301C File Offset: 0x0009121C
		[SkipLocalsInit]
		public unsafe static bool IsPhotoLibraryAuthorized()
		{
			UKuroGameScreenshotBPLibrary.__IsPhotoLibraryAuthorized_FunctionParams* ptr = stackalloc UKuroGameScreenshotBPLibrary.__IsPhotoLibraryAuthorized_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroGameScreenshotBPLibrary.__IsPhotoLibraryAuthorized_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroGameScreenshotBPLibrary.__IsPhotoLibraryAuthorized_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroGameScreenshotBPLibrary._ClassDefaultObjectPtr, UKuroGameScreenshotBPLibrary.__IsPhotoLibraryAuthorized_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06006647 RID: 26183 RVA: 0x00093060 File Offset: 0x00091260
		[NullableContext(2)]
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(UKuroGameScreenshotBPLibrary._ClassDefaultObjectPtr, UKuroGameScreenshotBPLibrary.__ConvertColorsToBitmap_NativeFunctionPtr, (void*)ptr);
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

		// Token: 0x06006648 RID: 26184 RVA: 0x00093110 File Offset: 0x00091310
		[NullableContext(2)]
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(UKuroGameScreenshotBPLibrary._ClassDefaultObjectPtr, UKuroGameScreenshotBPLibrary.__CompressConvertColorsToBitmap_NativeFunctionPtr, (void*)ptr);
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

		// Token: 0x06006649 RID: 26185 RVA: 0x000931BD File Offset: 0x000913BD
		static UKuroGameScreenshotBPLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameScreenshot.KuroGameScreenshotBPLibrary");
		}

		// Token: 0x0600664A RID: 26186 RVA: 0x000931CB File Offset: 0x000913CB
		protected UKuroGameScreenshotBPLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002AFB RID: 11003
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameScreenshot.KuroGameScreenshotBPLibrary";

		// Token: 0x04002AFC RID: 11004
		private static IntPtr _ClassPtr;

		// Token: 0x04002AFD RID: 11005
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002AFE RID: 11006
		private static IntPtr __SaveScreenshot_NativeFunctionPtr;

		// Token: 0x04002AFF RID: 11007
		private static IntPtr __SaveColorArrayToOpenHarmonyAlbum_NativeFunctionPtr;

		// Token: 0x04002B00 RID: 11008
		private static IntPtr __SaveColorArrayToIosAlbum_NativeFunctionPtr;

		// Token: 0x04002B01 RID: 11009
		private static IntPtr __SaveColorArrayToAndroidAlbum_NativeFunctionPtr;

		// Token: 0x04002B02 RID: 11010
		private static IntPtr __PrepareTakeScreenshot_NativeFunctionPtr;

		// Token: 0x04002B03 RID: 11011
		private static IntPtr __IsPhotoLibraryAuthorized_NativeFunctionPtr;

		// Token: 0x04002B04 RID: 11012
		private static IntPtr __ConvertColorsToBitmap_NativeFunctionPtr;

		// Token: 0x04002B05 RID: 11013
		private static IntPtr __CompressConvertColorsToBitmap_NativeFunctionPtr;

		// Token: 0x02000B21 RID: 2849
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __SaveScreenshot_FunctionParams
		{
			// Token: 0x04005BD5 RID: 23509
			[FieldOffset(0)]
			public FString FilePath;

			// Token: 0x04005BD6 RID: 23510
			[FieldOffset(16)]
			public int Width;

			// Token: 0x04005BD7 RID: 23511
			[FieldOffset(20)]
			public int Height;

			// Token: 0x04005BD8 RID: 23512
			[FieldOffset(24)]
			public byte Colors;
		}

		// Token: 0x02000B22 RID: 2850
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __SaveColorArrayToOpenHarmonyAlbum_FunctionParams
		{
			// Token: 0x04005BD9 RID: 23513
			[FieldOffset(0)]
			public int Width;

			// Token: 0x04005BDA RID: 23514
			[FieldOffset(4)]
			public int Height;

			// Token: 0x04005BDB RID: 23515
			[FieldOffset(8)]
			public byte BitMap;
		}

		// Token: 0x02000B23 RID: 2851
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __SaveColorArrayToIosAlbum_FunctionParams
		{
			// Token: 0x04005BDC RID: 23516
			[FieldOffset(0)]
			public int Width;

			// Token: 0x04005BDD RID: 23517
			[FieldOffset(4)]
			public int Height;

			// Token: 0x04005BDE RID: 23518
			[FieldOffset(8)]
			public byte Colors;
		}

		// Token: 0x02000B24 RID: 2852
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __SaveColorArrayToAndroidAlbum_FunctionParams
		{
			// Token: 0x04005BDF RID: 23519
			[FieldOffset(0)]
			public int Width;

			// Token: 0x04005BE0 RID: 23520
			[FieldOffset(4)]
			public int Height;

			// Token: 0x04005BE1 RID: 23521
			[FieldOffset(8)]
			public byte BitMap;
		}

		// Token: 0x02000B25 RID: 2853
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __PrepareTakeScreenshot_FunctionParams
		{
			// Token: 0x04005BE2 RID: 23522
			[FieldOffset(0)]
			public IntPtr Outer;

			// Token: 0x04005BE3 RID: 23523
			[FieldOffset(8)]
			public FString InFilename;

			// Token: 0x04005BE4 RID: 23524
			[FieldOffset(24)]
			public FVector2D MinCaptureRegion;

			// Token: 0x04005BE5 RID: 23525
			[FieldOffset(32)]
			public FVector2D MaxCaptureRegion;

			// Token: 0x04005BE6 RID: 23526
			[FieldOffset(40)]
			public float ScreenshotResolutionX;

			// Token: 0x04005BE7 RID: 23527
			[FieldOffset(44)]
			public float ScreenshotResolutionY;

			// Token: 0x04005BE8 RID: 23528
			[FieldOffset(48)]
			public bool SaveFile;

			// Token: 0x04005BE9 RID: 23529
			[FieldOffset(52)]
			public int ResolutionMultiplier;

			// Token: 0x04005BEA RID: 23530
			[FieldOffset(56)]
			public IntPtr __Result;
		}

		// Token: 0x02000B26 RID: 2854
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsPhotoLibraryAuthorized_FunctionParams
		{
			// Token: 0x04005BEB RID: 23531
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02000B27 RID: 2855
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __ConvertColorsToBitmap_FunctionParams
		{
			// Token: 0x04005BEC RID: 23532
			[FieldOffset(0)]
			public int Width;

			// Token: 0x04005BED RID: 23533
			[FieldOffset(4)]
			public int Height;

			// Token: 0x04005BEE RID: 23534
			[FieldOffset(8)]
			public byte Colors;

			// Token: 0x04005BEF RID: 23535
			[FieldOffset(24)]
			public byte BitMap;
		}

		// Token: 0x02000B28 RID: 2856
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __CompressConvertColorsToBitmap_FunctionParams
		{
			// Token: 0x04005BF0 RID: 23536
			[FieldOffset(0)]
			public int Width;

			// Token: 0x04005BF1 RID: 23537
			[FieldOffset(4)]
			public int Height;

			// Token: 0x04005BF2 RID: 23538
			[FieldOffset(8)]
			public byte Colors;

			// Token: 0x04005BF3 RID: 23539
			[FieldOffset(24)]
			public byte BitMap;
		}
	}
}
