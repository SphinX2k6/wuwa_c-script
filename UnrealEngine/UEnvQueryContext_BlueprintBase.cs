using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200018E RID: 398
	[UnrealObjectPath("/Script/AIModule.EnvQueryContext_BlueprintBase")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class UEnvQueryContext_BlueprintBase : UEnvQueryContext, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060018D8 RID: 6360 RVA: 0x0002487D File Offset: 0x00022A7D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEnvQueryContext_BlueprintBase._ClassPtr;
		}

		// Token: 0x060018D9 RID: 6361 RVA: 0x0002488C File Offset: 0x00022A8C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ProvideSingleLocation(UObject QuerierObject, AActor QuerierActor, ref FVector ResultingLocation)
		{
			UEnvQueryContext_BlueprintBase.__ProvideSingleLocation_FunctionParams* ptr = stackalloc UEnvQueryContext_BlueprintBase.__ProvideSingleLocation_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UEnvQueryContext_BlueprintBase.__ProvideSingleLocation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UEnvQueryContext_BlueprintBase.__ProvideSingleLocation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->QuerierObject = ((QuerierObject != null) ? QuerierObject.NativePtr : IntPtr.Zero);
			ptr->QuerierActor = ((QuerierActor != null) ? QuerierActor.NativePtr : IntPtr.Zero);
			ptr->ResultingLocation = ResultingLocation;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, UEnvQueryContext_BlueprintBase.__ProvideSingleLocation_NativeFunctionPtr, (void*)ptr);
			ResultingLocation = ptr->ResultingLocation;
		}

		// Token: 0x060018DA RID: 6362 RVA: 0x00024910 File Offset: 0x00022B10
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ProvideSingleActor(UObject QuerierObject, AActor QuerierActor, ref AActor ResultingActor)
		{
			UEnvQueryContext_BlueprintBase.__ProvideSingleActor_FunctionParams* ptr = stackalloc UEnvQueryContext_BlueprintBase.__ProvideSingleActor_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UEnvQueryContext_BlueprintBase.__ProvideSingleActor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UEnvQueryContext_BlueprintBase.__ProvideSingleActor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->QuerierObject = ((QuerierObject != null) ? QuerierObject.NativePtr : IntPtr.Zero);
			ptr->QuerierActor = ((QuerierActor != null) ? QuerierActor.NativePtr : IntPtr.Zero);
			ref UEnvQueryContext_BlueprintBase.__ProvideSingleActor_FunctionParams ptr2 = ref *ptr;
			AActor aactor = ResultingActor;
			ptr2.ResultingActor = ((aactor != null) ? aactor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, UEnvQueryContext_BlueprintBase.__ProvideSingleActor_NativeFunctionPtr, (void*)ptr);
			ResultingActor = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(ptr->ResultingActor);
		}

		// Token: 0x060018DB RID: 6363 RVA: 0x000249A0 File Offset: 0x00022BA0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ProvideLocationsSet(UObject QuerierObject, AActor QuerierActor, ref TArray<FVector> ResultingLocationSet)
		{
			UEnvQueryContext_BlueprintBase.__ProvideLocationsSet_FunctionParams* ptr = stackalloc UEnvQueryContext_BlueprintBase.__ProvideLocationsSet_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UEnvQueryContext_BlueprintBase.__ProvideLocationsSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UEnvQueryContext_BlueprintBase.__ProvideLocationsSet_NativeFunctionPtr, (void*)ptr, 1);
			ptr->QuerierObject = ((QuerierObject != null) ? QuerierObject.NativePtr : IntPtr.Zero);
			ptr->QuerierActor = ((QuerierActor != null) ? QuerierActor.NativePtr : IntPtr.Zero);
			TArray<FVector> tarray = ResultingLocationSet;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->ResultingLocationSet);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, UEnvQueryContext_BlueprintBase.__ProvideLocationsSet_NativeFunctionPtr, (void*)ptr);
			TArray<FVector> tarray2 = ResultingLocationSet;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->ResultingLocationSet);
			}
			UnrealReflectionUtils.DestroyStruct(UEnvQueryContext_BlueprintBase.__ProvideLocationsSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060018DC RID: 6364 RVA: 0x00024A44 File Offset: 0x00022C44
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ProvideActorsSet(UObject QuerierObject, AActor QuerierActor, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<AActor> ResultingActorsSet)
		{
			UEnvQueryContext_BlueprintBase.__ProvideActorsSet_FunctionParams* ptr = stackalloc UEnvQueryContext_BlueprintBase.__ProvideActorsSet_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UEnvQueryContext_BlueprintBase.__ProvideActorsSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UEnvQueryContext_BlueprintBase.__ProvideActorsSet_NativeFunctionPtr, (void*)ptr, 1);
			ptr->QuerierObject = ((QuerierObject != null) ? QuerierObject.NativePtr : IntPtr.Zero);
			ptr->QuerierActor = ((QuerierActor != null) ? QuerierActor.NativePtr : IntPtr.Zero);
			TArray<AActor> tarray = ResultingActorsSet;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->ResultingActorsSet);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, UEnvQueryContext_BlueprintBase.__ProvideActorsSet_NativeFunctionPtr, (void*)ptr);
			TArray<AActor> tarray2 = ResultingActorsSet;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->ResultingActorsSet);
			}
			UnrealReflectionUtils.DestroyStruct(UEnvQueryContext_BlueprintBase.__ProvideActorsSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060018DD RID: 6365 RVA: 0x00024AE8 File Offset: 0x00022CE8
		static UEnvQueryContext_BlueprintBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.EnvQueryContext_BlueprintBase");
		}

		// Token: 0x060018DE RID: 6366 RVA: 0x00024AF8 File Offset: 0x00022CF8
		protected UEnvQueryContext_BlueprintBase() : this(BuiltinUtils.AllocNativeUObject(UEnvQueryContext_BlueprintBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x00024B20 File Offset: 0x00022D20
		protected UEnvQueryContext_BlueprintBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040006F9 RID: 1785
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.EnvQueryContext_BlueprintBase";

		// Token: 0x040006FA RID: 1786
		private static IntPtr _ClassPtr;

		// Token: 0x040006FB RID: 1787
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040006FC RID: 1788
		private static IntPtr __ProvideSingleLocation_NativeFunctionPtr;

		// Token: 0x040006FD RID: 1789
		private static IntPtr __ProvideSingleActor_NativeFunctionPtr;

		// Token: 0x040006FE RID: 1790
		private static IntPtr __ProvideLocationsSet_NativeFunctionPtr;

		// Token: 0x040006FF RID: 1791
		private static IntPtr __ProvideActorsSet_NativeFunctionPtr;

		// Token: 0x02002B63 RID: 11107
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __ProvideSingleLocation_FunctionParams
		{
			// Token: 0x040163DF RID: 91103
			[FieldOffset(0)]
			public IntPtr QuerierObject;

			// Token: 0x040163E0 RID: 91104
			[FieldOffset(8)]
			public IntPtr QuerierActor;

			// Token: 0x040163E1 RID: 91105
			[FieldOffset(16)]
			public FVector ResultingLocation;
		}

		// Token: 0x02002B64 RID: 11108
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __ProvideSingleActor_FunctionParams
		{
			// Token: 0x040163E2 RID: 91106
			[FieldOffset(0)]
			public IntPtr QuerierObject;

			// Token: 0x040163E3 RID: 91107
			[FieldOffset(8)]
			public IntPtr QuerierActor;

			// Token: 0x040163E4 RID: 91108
			[FieldOffset(16)]
			public IntPtr ResultingActor;
		}

		// Token: 0x02002B65 RID: 11109
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __ProvideLocationsSet_FunctionParams
		{
			// Token: 0x040163E5 RID: 91109
			[FieldOffset(0)]
			public IntPtr QuerierObject;

			// Token: 0x040163E6 RID: 91110
			[FieldOffset(8)]
			public IntPtr QuerierActor;

			// Token: 0x040163E7 RID: 91111
			[FieldOffset(16)]
			public byte ResultingLocationSet;
		}

		// Token: 0x02002B66 RID: 11110
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __ProvideActorsSet_FunctionParams
		{
			// Token: 0x040163E8 RID: 91112
			[FieldOffset(0)]
			public IntPtr QuerierObject;

			// Token: 0x040163E9 RID: 91113
			[FieldOffset(8)]
			public IntPtr QuerierActor;

			// Token: 0x040163EA RID: 91114
			[FieldOffset(16)]
			public byte ResultingActorsSet;
		}
	}
}
