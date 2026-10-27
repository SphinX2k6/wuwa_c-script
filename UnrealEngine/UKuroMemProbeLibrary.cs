using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EC1 RID: 7873
	[UnrealObjectPath("/Script/KuroUtility.KuroMemProbeLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroMemProbeLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DDF6 RID: 122358 RVA: 0x002C2F64 File Offset: 0x002C1164
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroMemProbeLibrary._ClassPtr;
		}

		// Token: 0x0601DDF7 RID: 122359 RVA: 0x002C2F70 File Offset: 0x002C1170
		public UKuroMemProbeLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroMemProbeLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DDF8 RID: 122360 RVA: 0x002C2F98 File Offset: 0x002C1198
		[NullableContext(1)]
		public UKuroMemProbeLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroMemProbeLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601DDF9 RID: 122361 RVA: 0x002C2FCC File Offset: 0x002C11CC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void MemSnapshotFull(string Marker)
		{
			UKuroMemProbeLibrary.__MemSnapshotFull_FunctionParams* ptr = stackalloc UKuroMemProbeLibrary.__MemSnapshotFull_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroMemProbeLibrary.__MemSnapshotFull_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroMemProbeLibrary.__MemSnapshotFull_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Marker), Marker);
			UnrealReflectionUtils.CallUFunction(UKuroMemProbeLibrary._ClassDefaultObjectPtr, UKuroMemProbeLibrary.__MemSnapshotFull_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroMemProbeLibrary.__MemSnapshotFull_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601DDFA RID: 122362 RVA: 0x002C302C File Offset: 0x002C122C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void MemSnapshot(string Marker)
		{
			UKuroMemProbeLibrary.__MemSnapshot_FunctionParams* ptr = stackalloc UKuroMemProbeLibrary.__MemSnapshot_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroMemProbeLibrary.__MemSnapshot_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroMemProbeLibrary.__MemSnapshot_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Marker), Marker);
			UnrealReflectionUtils.CallUFunction(UKuroMemProbeLibrary._ClassDefaultObjectPtr, UKuroMemProbeLibrary.__MemSnapshot_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroMemProbeLibrary.__MemSnapshot_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601DDFB RID: 122363 RVA: 0x002C308C File Offset: 0x002C128C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void MemDumpSmaps(string Marker)
		{
			UKuroMemProbeLibrary.__MemDumpSmaps_FunctionParams* ptr = stackalloc UKuroMemProbeLibrary.__MemDumpSmaps_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroMemProbeLibrary.__MemDumpSmaps_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroMemProbeLibrary.__MemDumpSmaps_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Marker), Marker);
			UnrealReflectionUtils.CallUFunction(UKuroMemProbeLibrary._ClassDefaultObjectPtr, UKuroMemProbeLibrary.__MemDumpSmaps_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroMemProbeLibrary.__MemDumpSmaps_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601DDFC RID: 122364 RVA: 0x002C30EC File Offset: 0x002C12EC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static string GetMemProbeDir()
		{
			UKuroMemProbeLibrary.__GetMemProbeDir_FunctionParams* ptr = stackalloc UKuroMemProbeLibrary.__GetMemProbeDir_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroMemProbeLibrary.__GetMemProbeDir_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroMemProbeLibrary.__GetMemProbeDir_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroMemProbeLibrary._ClassDefaultObjectPtr, UKuroMemProbeLibrary.__GetMemProbeDir_NativeFunctionPtr, (void*)ptr, 0);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroMemProbeLibrary.__GetMemProbeDir_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601DDFD RID: 122365 RVA: 0x002C3148 File Offset: 0x002C1348
		static UKuroMemProbeLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroMemProbeLibrary");
		}

		// Token: 0x0601DDFE RID: 122366 RVA: 0x002C3156 File Offset: 0x002C1356
		protected UKuroMemProbeLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040102EE RID: 66286
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroMemProbeLibrary";

		// Token: 0x040102EF RID: 66287
		private static IntPtr _ClassPtr;

		// Token: 0x040102F0 RID: 66288
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040102F1 RID: 66289
		private static IntPtr __MemSnapshotFull_NativeFunctionPtr;

		// Token: 0x040102F2 RID: 66290
		private static IntPtr __MemSnapshot_NativeFunctionPtr;

		// Token: 0x040102F3 RID: 66291
		private static IntPtr __MemDumpSmaps_NativeFunctionPtr;

		// Token: 0x040102F4 RID: 66292
		private static IntPtr __GetMemProbeDir_NativeFunctionPtr;

		// Token: 0x02003314 RID: 13076
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __MemSnapshotFull_FunctionParams
		{
			// Token: 0x040171EE RID: 94702
			[FieldOffset(0)]
			public FString Marker;
		}

		// Token: 0x02003315 RID: 13077
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __MemSnapshot_FunctionParams
		{
			// Token: 0x040171EF RID: 94703
			[FieldOffset(0)]
			public FString Marker;
		}

		// Token: 0x02003316 RID: 13078
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __MemDumpSmaps_FunctionParams
		{
			// Token: 0x040171F0 RID: 94704
			[FieldOffset(0)]
			public FString Marker;
		}

		// Token: 0x02003317 RID: 13079
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetMemProbeDir_FunctionParams
		{
			// Token: 0x040171F1 RID: 94705
			[FieldOffset(0)]
			public FString __Result;
		}
	}
}
