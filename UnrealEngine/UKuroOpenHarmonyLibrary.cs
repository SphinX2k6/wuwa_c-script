using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005DF RID: 1503
	[UnrealObjectPath("/Script/KuroUtility.KuroOpenHarmonyLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroOpenHarmonyLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060084D8 RID: 34008 RVA: 0x000C50A6 File Offset: 0x000C32A6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroOpenHarmonyLibrary._ClassPtr;
		}

		// Token: 0x060084D9 RID: 34009 RVA: 0x000C50B4 File Offset: 0x000C32B4
		public UKuroOpenHarmonyLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroOpenHarmonyLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060084DA RID: 34010 RVA: 0x000C50DC File Offset: 0x000C32DC
		[NullableContext(1)]
		public UKuroOpenHarmonyLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroOpenHarmonyLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060084DB RID: 34011 RVA: 0x000C5110 File Offset: 0x000C3310
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void UpdateGameConfigInfo(in FKuroHarmonyGameConfigInfo ConfigInfo)
		{
			UKuroOpenHarmonyLibrary.__UpdateGameConfigInfo_FunctionParams* ptr = stackalloc UKuroOpenHarmonyLibrary.__UpdateGameConfigInfo_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(UKuroOpenHarmonyLibrary.__UpdateGameConfigInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroOpenHarmonyLibrary.__UpdateGameConfigInfo_NativeFunctionPtr, (void*)ptr, 1);
			if (ConfigInfo != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroHarmonyGameConfigInfo.StaticStruct(), &ptr->ConfigInfo, ConfigInfo.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(UKuroOpenHarmonyLibrary._ClassDefaultObjectPtr, UKuroOpenHarmonyLibrary.__UpdateGameConfigInfo_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroOpenHarmonyLibrary.__UpdateGameConfigInfo_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060084DC RID: 34012 RVA: 0x000C5184 File Offset: 0x000C3384
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static bool JumpToAppGalleryStore(string BundleName)
		{
			UKuroOpenHarmonyLibrary.__JumpToAppGalleryStore_FunctionParams* ptr = stackalloc UKuroOpenHarmonyLibrary.__JumpToAppGalleryStore_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroOpenHarmonyLibrary.__JumpToAppGalleryStore_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroOpenHarmonyLibrary.__JumpToAppGalleryStore_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->BundleName), BundleName);
			UnrealReflectionUtils.CallUFunction(UKuroOpenHarmonyLibrary._ClassDefaultObjectPtr, UKuroOpenHarmonyLibrary.__JumpToAppGalleryStore_NativeFunctionPtr, (void*)ptr);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroOpenHarmonyLibrary.__JumpToAppGalleryStore_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x060084DD RID: 34013 RVA: 0x000C51E8 File Offset: 0x000C33E8
		[SkipLocalsInit]
		public unsafe static bool IsScreenFolded()
		{
			UKuroOpenHarmonyLibrary.__IsScreenFolded_FunctionParams* ptr = stackalloc UKuroOpenHarmonyLibrary.__IsScreenFolded_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroOpenHarmonyLibrary.__IsScreenFolded_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroOpenHarmonyLibrary.__IsScreenFolded_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroOpenHarmonyLibrary._ClassDefaultObjectPtr, UKuroOpenHarmonyLibrary.__IsScreenFolded_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060084DE RID: 34014 RVA: 0x000C522C File Offset: 0x000C342C
		[SkipLocalsInit]
		public unsafe static bool IsFoldableScreen()
		{
			UKuroOpenHarmonyLibrary.__IsFoldableScreen_FunctionParams* ptr = stackalloc UKuroOpenHarmonyLibrary.__IsFoldableScreen_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroOpenHarmonyLibrary.__IsFoldableScreen_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroOpenHarmonyLibrary.__IsFoldableScreen_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroOpenHarmonyLibrary._ClassDefaultObjectPtr, UKuroOpenHarmonyLibrary.__IsFoldableScreen_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060084DF RID: 34015 RVA: 0x000C5270 File Offset: 0x000C3470
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void InitGamePerformance(in FKuroHarmonyGamePackageInfo PackageInfo)
		{
			UKuroOpenHarmonyLibrary.__InitGamePerformance_FunctionParams* ptr = stackalloc UKuroOpenHarmonyLibrary.__InitGamePerformance_FunctionParams[(UIntPtr)87] + 15L / (long)sizeof(UKuroOpenHarmonyLibrary.__InitGamePerformance_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroOpenHarmonyLibrary.__InitGamePerformance_NativeFunctionPtr, (void*)ptr, 1);
			if (PackageInfo != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroHarmonyGamePackageInfo.StaticStruct(), &ptr->PackageInfo, PackageInfo.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(UKuroOpenHarmonyLibrary._ClassDefaultObjectPtr, UKuroOpenHarmonyLibrary.__InitGamePerformance_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroOpenHarmonyLibrary.__InitGamePerformance_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060084E0 RID: 34016 RVA: 0x000C52E3 File Offset: 0x000C34E3
		[SkipLocalsInit]
		public static void ClearFoldStateChangeDelegate()
		{
			UnrealReflectionUtils.CallUFunction(UKuroOpenHarmonyLibrary._ClassDefaultObjectPtr, UKuroOpenHarmonyLibrary.__ClearFoldStateChangeDelegate_NativeFunctionPtr, null);
		}

		// Token: 0x060084E1 RID: 34017 RVA: 0x000C52F8 File Offset: 0x000C34F8
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void AddFoldStateChangeDelegate(in FOpenHarmonyFoldStateChangeHandler Handler)
		{
			UKuroOpenHarmonyLibrary.__AddFoldStateChangeDelegate_FunctionParams* ptr = stackalloc UKuroOpenHarmonyLibrary.__AddFoldStateChangeDelegate_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UKuroOpenHarmonyLibrary.__AddFoldStateChangeDelegate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroOpenHarmonyLibrary.__AddFoldStateChangeDelegate_NativeFunctionPtr, (void*)ptr, 1);
			IntPtr dest = &ptr->Handler;
			FOpenHarmonyFoldStateChangeHandler fopenHarmonyFoldStateChangeHandler = Handler;
			FScriptDelegate.NativeCopy(dest, (fopenHarmonyFoldStateChangeHandler != null) ? fopenHarmonyFoldStateChangeHandler.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroOpenHarmonyLibrary._ClassDefaultObjectPtr, UKuroOpenHarmonyLibrary.__AddFoldStateChangeDelegate_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroOpenHarmonyLibrary.__AddFoldStateChangeDelegate_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060084E2 RID: 34018 RVA: 0x000C5362 File Offset: 0x000C3562
		static UKuroOpenHarmonyLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroOpenHarmonyLibrary");
		}

		// Token: 0x060084E3 RID: 34019 RVA: 0x000C5370 File Offset: 0x000C3570
		protected UKuroOpenHarmonyLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003A04 RID: 14852
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroOpenHarmonyLibrary";

		// Token: 0x04003A05 RID: 14853
		private static IntPtr _ClassPtr;

		// Token: 0x04003A06 RID: 14854
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003A07 RID: 14855
		private static IntPtr __UpdateGameConfigInfo_NativeFunctionPtr;

		// Token: 0x04003A08 RID: 14856
		private static IntPtr __JumpToAppGalleryStore_NativeFunctionPtr;

		// Token: 0x04003A09 RID: 14857
		private static IntPtr __IsScreenFolded_NativeFunctionPtr;

		// Token: 0x04003A0A RID: 14858
		private static IntPtr __IsFoldableScreen_NativeFunctionPtr;

		// Token: 0x04003A0B RID: 14859
		private static IntPtr __InitGamePerformance_NativeFunctionPtr;

		// Token: 0x04003A0C RID: 14860
		private static IntPtr __ClearFoldStateChangeDelegate_NativeFunctionPtr;

		// Token: 0x04003A0D RID: 14861
		private static IntPtr __AddFoldStateChangeDelegate_NativeFunctionPtr;

		// Token: 0x02000D6A RID: 3434
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __UpdateGameConfigInfo_FunctionParams
		{
			// Token: 0x04006025 RID: 24613
			[FieldOffset(0)]
			public byte ConfigInfo;
		}

		// Token: 0x02000D6B RID: 3435
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __JumpToAppGalleryStore_FunctionParams
		{
			// Token: 0x04006026 RID: 24614
			[FieldOffset(0)]
			public FString BundleName;

			// Token: 0x04006027 RID: 24615
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x02000D6C RID: 3436
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsScreenFolded_FunctionParams
		{
			// Token: 0x04006028 RID: 24616
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02000D6D RID: 3437
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsFoldableScreen_FunctionParams
		{
			// Token: 0x04006029 RID: 24617
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02000D6E RID: 3438
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __InitGamePerformance_FunctionParams
		{
			// Token: 0x0400602A RID: 24618
			[FieldOffset(0)]
			public byte PackageInfo;
		}

		// Token: 0x02000D6F RID: 3439
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __AddFoldStateChangeDelegate_FunctionParams
		{
			// Token: 0x0400602B RID: 24619
			[FieldOffset(0)]
			public byte Handler;
		}
	}
}
