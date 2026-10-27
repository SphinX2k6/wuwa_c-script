using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EC4 RID: 7876
	[UnrealObjectPath("/Script/KuroUtility.KuroOpenHarmonyLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroOpenHarmonyLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DE24 RID: 122404 RVA: 0x002C33B6 File Offset: 0x002C15B6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroOpenHarmonyLibrary._ClassPtr;
		}

		// Token: 0x0601DE25 RID: 122405 RVA: 0x002C33C4 File Offset: 0x002C15C4
		public UKuroOpenHarmonyLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroOpenHarmonyLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DE26 RID: 122406 RVA: 0x002C33EC File Offset: 0x002C15EC
		[NullableContext(1)]
		public UKuroOpenHarmonyLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroOpenHarmonyLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601DE27 RID: 122407 RVA: 0x002C3420 File Offset: 0x002C1620
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void UpdateGameConfigInfo(in FKuroHarmonyGameConfigInfo ConfigInfo)
		{
			UKuroOpenHarmonyLibrary.__UpdateGameConfigInfo_FunctionParams* ptr = stackalloc UKuroOpenHarmonyLibrary.__UpdateGameConfigInfo_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(UKuroOpenHarmonyLibrary.__UpdateGameConfigInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroOpenHarmonyLibrary.__UpdateGameConfigInfo_NativeFunctionPtr, (void*)ptr, 1);
			if (ConfigInfo != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroHarmonyGameConfigInfo.StaticStruct(), &ptr->ConfigInfo, ConfigInfo.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(UKuroOpenHarmonyLibrary._ClassDefaultObjectPtr, UKuroOpenHarmonyLibrary.__UpdateGameConfigInfo_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroOpenHarmonyLibrary.__UpdateGameConfigInfo_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601DE28 RID: 122408 RVA: 0x002C3494 File Offset: 0x002C1694
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void InitGamePerformance(in FKuroHarmonyGamePackageInfo PackageInfo)
		{
			UKuroOpenHarmonyLibrary.__InitGamePerformance_FunctionParams* ptr = stackalloc UKuroOpenHarmonyLibrary.__InitGamePerformance_FunctionParams[(UIntPtr)87] + 15L / (long)sizeof(UKuroOpenHarmonyLibrary.__InitGamePerformance_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroOpenHarmonyLibrary.__InitGamePerformance_NativeFunctionPtr, (void*)ptr, 1);
			if (PackageInfo != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroHarmonyGamePackageInfo.StaticStruct(), &ptr->PackageInfo, PackageInfo.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(UKuroOpenHarmonyLibrary._ClassDefaultObjectPtr, UKuroOpenHarmonyLibrary.__InitGamePerformance_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroOpenHarmonyLibrary.__InitGamePerformance_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601DE29 RID: 122409 RVA: 0x002C3508 File Offset: 0x002C1708
		static UKuroOpenHarmonyLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroOpenHarmonyLibrary");
		}

		// Token: 0x0601DE2A RID: 122410 RVA: 0x002C3516 File Offset: 0x002C1716
		protected UKuroOpenHarmonyLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040102FB RID: 66299
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroOpenHarmonyLibrary";

		// Token: 0x040102FC RID: 66300
		private static IntPtr _ClassPtr;

		// Token: 0x040102FD RID: 66301
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040102FE RID: 66302
		private static IntPtr __UpdateGameConfigInfo_NativeFunctionPtr;

		// Token: 0x040102FF RID: 66303
		private static IntPtr __InitGamePerformance_NativeFunctionPtr;

		// Token: 0x02003318 RID: 13080
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __UpdateGameConfigInfo_FunctionParams
		{
			// Token: 0x040171F2 RID: 94706
			[FieldOffset(0)]
			public byte ConfigInfo;
		}

		// Token: 0x02003319 RID: 13081
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __InitGamePerformance_FunctionParams
		{
			// Token: 0x040171F3 RID: 94707
			[FieldOffset(0)]
			public byte PackageInfo;
		}
	}
}
