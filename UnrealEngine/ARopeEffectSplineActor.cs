using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C78 RID: 7288
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRopeEffect.RopeEffectSplineActor")]
	[UnrealStructLayout(1120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1120)]
	public class ARopeEffectSplineActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C475 RID: 115829 RVA: 0x0029AEF5 File Offset: 0x002990F5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ARopeEffectSplineActor._ClassPtr;
		}

		// Token: 0x0601C476 RID: 115830 RVA: 0x0029AF04 File Offset: 0x00299104
		public ARopeEffectSplineActor() : this(BuiltinUtils.AllocNativeUObject(ARopeEffectSplineActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C477 RID: 115831 RVA: 0x0029AF2C File Offset: 0x0029912C
		public ARopeEffectSplineActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ARopeEffectSplineActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007251 RID: 29265
		// (get) Token: 0x0601C478 RID: 115832 RVA: 0x0029AF5F File Offset: 0x0029915F
		// (set) Token: 0x0601C479 RID: 115833 RVA: 0x0029AF73 File Offset: 0x00299173
		[Nullable(2)]
		public unsafe USplineComponent RopeRootComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ARopeEffectSplineActor.__PropertyOffset_RopeRootComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ARopeEffectSplineActor.__PropertyOffset_RopeRootComponent, value);
			}
		}

		// Token: 0x17007252 RID: 29266
		// (get) Token: 0x0601C47A RID: 115834 RVA: 0x0029AF88 File Offset: 0x00299188
		// (set) Token: 0x0601C47B RID: 115835 RVA: 0x0029AFC1 File Offset: 0x002991C1
		public TArray<USplineComponent> SplineComponents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<USplineComponent> result;
				if ((result = this._SplineComponents) == null)
				{
					result = (this._SplineComponents = new TArray<USplineComponent>(base.NativePtr + (IntPtr)ARopeEffectSplineActor.__PropertyOffset_SplineComponents, this));
				}
				return result;
			}
			set
			{
				this.SplineComponents.CopyAssign(value);
			}
		}

		// Token: 0x17007253 RID: 29267
		// (get) Token: 0x0601C47C RID: 115836 RVA: 0x0029AFD0 File Offset: 0x002991D0
		// (set) Token: 0x0601C47D RID: 115837 RVA: 0x0029B009 File Offset: 0x00299209
		public TArray<UNiagaraComponent> NiagaraComponents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UNiagaraComponent> result;
				if ((result = this._NiagaraComponents) == null)
				{
					result = (this._NiagaraComponents = new TArray<UNiagaraComponent>(base.NativePtr + (IntPtr)ARopeEffectSplineActor.__PropertyOffset_NiagaraComponents, this));
				}
				return result;
			}
			set
			{
				this.NiagaraComponents.CopyAssign(value);
			}
		}

		// Token: 0x17007254 RID: 29268
		// (get) Token: 0x0601C47E RID: 115838 RVA: 0x0029B018 File Offset: 0x00299218
		// (set) Token: 0x0601C47F RID: 115839 RVA: 0x0029B051 File Offset: 0x00299251
		public TArray<FRopeSkinningData> RopeSkinningData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRopeSkinningData> result;
				if ((result = this._RopeSkinningData) == null)
				{
					result = (this._RopeSkinningData = new TArray<FRopeSkinningData>(base.NativePtr + (IntPtr)ARopeEffectSplineActor.__PropertyOffset_RopeSkinningData, this));
				}
				return result;
			}
			set
			{
				this.RopeSkinningData.CopyAssign(value);
			}
		}

		// Token: 0x17007255 RID: 29269
		// (get) Token: 0x0601C480 RID: 115840 RVA: 0x0029B05F File Offset: 0x0029925F
		// (set) Token: 0x0601C481 RID: 115841 RVA: 0x0029B073 File Offset: 0x00299273
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<USkeletalMeshComponent> TargetSkeletalMeshComponent
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)ARopeEffectSplineActor.__PropertyOffset_TargetSkeletalMeshComponent);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)ARopeEffectSplineActor.__PropertyOffset_TargetSkeletalMeshComponent) = value;
			}
		}

		// Token: 0x17007256 RID: 29270
		// (get) Token: 0x0601C482 RID: 115842 RVA: 0x0029B088 File Offset: 0x00299288
		// (set) Token: 0x0601C483 RID: 115843 RVA: 0x0029B09C File Offset: 0x0029929C
		[Nullable(2)]
		public unsafe URopeEffectDataAsset ConfigDataAsset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<URopeEffectDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + ARopeEffectSplineActor.__PropertyOffset_ConfigDataAsset);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ARopeEffectSplineActor.__PropertyOffset_ConfigDataAsset, value);
			}
		}

		// Token: 0x0601C484 RID: 115844 RVA: 0x0029B0B4 File Offset: 0x002992B4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRopeNiagaraAsset(UNiagaraSystem NiagaraAsset)
		{
			ARopeEffectSplineActor.__SetRopeNiagaraAsset_FunctionParams* ptr = stackalloc ARopeEffectSplineActor.__SetRopeNiagaraAsset_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(ARopeEffectSplineActor.__SetRopeNiagaraAsset_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ARopeEffectSplineActor.__SetRopeNiagaraAsset_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NiagaraAsset = ((NiagaraAsset != null) ? NiagaraAsset.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ARopeEffectSplineActor.__SetRopeNiagaraAsset_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601C485 RID: 115845 RVA: 0x0029B10C File Offset: 0x0029930C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int GetTotalRopeCount()
		{
			ARopeEffectSplineActor.__GetTotalRopeCount_FunctionParams* ptr = stackalloc ARopeEffectSplineActor.__GetTotalRopeCount_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ARopeEffectSplineActor.__GetTotalRopeCount_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ARopeEffectSplineActor.__GetTotalRopeCount_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ARopeEffectSplineActor.__GetTotalRopeCount_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601C486 RID: 115846 RVA: 0x0029B154 File Offset: 0x00299354
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe USplineComponent GetSplineComponentByIndex(int Index)
		{
			ARopeEffectSplineActor.__GetSplineComponentByIndex_FunctionParams* ptr = stackalloc ARopeEffectSplineActor.__GetSplineComponentByIndex_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ARopeEffectSplineActor.__GetSplineComponentByIndex_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ARopeEffectSplineActor.__GetSplineComponentByIndex_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Index = Index;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ARopeEffectSplineActor.__GetSplineComponentByIndex_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USplineComponent>(ptr->__Result);
		}

		// Token: 0x0601C487 RID: 115847 RVA: 0x0029B1A8 File Offset: 0x002993A8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe UNiagaraComponent GetRopeNiagaraComponentByIndex(int Index)
		{
			ARopeEffectSplineActor.__GetRopeNiagaraComponentByIndex_FunctionParams* ptr = stackalloc ARopeEffectSplineActor.__GetRopeNiagaraComponentByIndex_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ARopeEffectSplineActor.__GetRopeNiagaraComponentByIndex_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ARopeEffectSplineActor.__GetRopeNiagaraComponentByIndex_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Index = Index;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ARopeEffectSplineActor.__GetRopeNiagaraComponentByIndex_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UNiagaraComponent>(ptr->__Result);
		}

		// Token: 0x0601C488 RID: 115848 RVA: 0x0029B1FC File Offset: 0x002993FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void GetAllSplineComponents([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<USplineComponent> OutSplines)
		{
			ARopeEffectSplineActor.__GetAllSplineComponents_FunctionParams* ptr = stackalloc ARopeEffectSplineActor.__GetAllSplineComponents_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ARopeEffectSplineActor.__GetAllSplineComponents_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ARopeEffectSplineActor.__GetAllSplineComponents_NativeFunctionPtr, (void*)ptr, 1);
			TArray<USplineComponent> tarray = OutSplines;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutSplines);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ARopeEffectSplineActor.__GetAllSplineComponents_NativeFunctionPtr, (void*)ptr, 0);
			TArray<USplineComponent> tarray2 = OutSplines;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutSplines);
			}
			UnrealReflectionUtils.DestroyStruct(ARopeEffectSplineActor.__GetAllSplineComponents_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601C489 RID: 115849 RVA: 0x0029B278 File Offset: 0x00299478
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void GetAllRopeNiagaraComponents([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UNiagaraComponent> OutNiagaras)
		{
			ARopeEffectSplineActor.__GetAllRopeNiagaraComponents_FunctionParams* ptr = stackalloc ARopeEffectSplineActor.__GetAllRopeNiagaraComponents_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ARopeEffectSplineActor.__GetAllRopeNiagaraComponents_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ARopeEffectSplineActor.__GetAllRopeNiagaraComponents_NativeFunctionPtr, (void*)ptr, 1);
			TArray<UNiagaraComponent> tarray = OutNiagaras;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutNiagaras);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ARopeEffectSplineActor.__GetAllRopeNiagaraComponents_NativeFunctionPtr, (void*)ptr, 0);
			TArray<UNiagaraComponent> tarray2 = OutNiagaras;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutNiagaras);
			}
			UnrealReflectionUtils.DestroyStruct(ARopeEffectSplineActor.__GetAllRopeNiagaraComponents_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601C48A RID: 115850 RVA: 0x0029B2F4 File Offset: 0x002994F4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int BindNiagaraToRopeSplines(UNiagaraComponent NiagaraComp)
		{
			ARopeEffectSplineActor.__BindNiagaraToRopeSplines_FunctionParams* ptr = stackalloc ARopeEffectSplineActor.__BindNiagaraToRopeSplines_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ARopeEffectSplineActor.__BindNiagaraToRopeSplines_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ARopeEffectSplineActor.__BindNiagaraToRopeSplines_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NiagaraComp = ((NiagaraComp != null) ? NiagaraComp.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ARopeEffectSplineActor.__BindNiagaraToRopeSplines_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601C48B RID: 115851 RVA: 0x0029B350 File Offset: 0x00299550
		static ARopeEffectSplineActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRopeEffect.RopeEffectSplineActor");
		}

		// Token: 0x0601C48C RID: 115852 RVA: 0x0029B35E File Offset: 0x0029955E
		protected ARopeEffectSplineActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F348 RID: 62280
		public new const string __ObjectPath = "/Script/KuroRopeEffect.RopeEffectSplineActor";

		// Token: 0x0400F349 RID: 62281
		private static IntPtr _ClassPtr;

		// Token: 0x0400F34A RID: 62282
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F34B RID: 62283
		internal static int __PropertyOffset_RopeRootComponent;

		// Token: 0x0400F34C RID: 62284
		internal static int __PropertyOffset_SplineComponents;

		// Token: 0x0400F34D RID: 62285
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USplineComponent> _SplineComponents;

		// Token: 0x0400F34E RID: 62286
		internal static int __PropertyOffset_NiagaraComponents;

		// Token: 0x0400F34F RID: 62287
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UNiagaraComponent> _NiagaraComponents;

		// Token: 0x0400F350 RID: 62288
		internal static int __PropertyOffset_RopeSkinningData;

		// Token: 0x0400F351 RID: 62289
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRopeSkinningData> _RopeSkinningData;

		// Token: 0x0400F352 RID: 62290
		internal static int __PropertyOffset_TargetSkeletalMeshComponent;

		// Token: 0x0400F353 RID: 62291
		internal static int __PropertyOffset_ConfigDataAsset;

		// Token: 0x0400F354 RID: 62292
		private static IntPtr __SetRopeNiagaraAsset_NativeFunctionPtr;

		// Token: 0x0400F355 RID: 62293
		private static IntPtr __GetTotalRopeCount_NativeFunctionPtr;

		// Token: 0x0400F356 RID: 62294
		private static IntPtr __GetSplineComponentByIndex_NativeFunctionPtr;

		// Token: 0x0400F357 RID: 62295
		private static IntPtr __GetRopeNiagaraComponentByIndex_NativeFunctionPtr;

		// Token: 0x0400F358 RID: 62296
		private static IntPtr __GetAllSplineComponents_NativeFunctionPtr;

		// Token: 0x0400F359 RID: 62297
		private static IntPtr __GetAllRopeNiagaraComponents_NativeFunctionPtr;

		// Token: 0x0400F35A RID: 62298
		private static IntPtr __BindNiagaraToRopeSplines_NativeFunctionPtr;

		// Token: 0x02003211 RID: 12817
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetRopeNiagaraAsset_FunctionParams
		{
			// Token: 0x04017074 RID: 94324
			[FieldOffset(0)]
			public IntPtr NiagaraAsset;
		}

		// Token: 0x02003212 RID: 12818
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetTotalRopeCount_FunctionParams
		{
			// Token: 0x04017075 RID: 94325
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02003213 RID: 12819
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetSplineComponentByIndex_FunctionParams
		{
			// Token: 0x04017076 RID: 94326
			[FieldOffset(0)]
			public int Index;

			// Token: 0x04017077 RID: 94327
			[FieldOffset(8)]
			public IntPtr __Result;
		}

		// Token: 0x02003214 RID: 12820
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetRopeNiagaraComponentByIndex_FunctionParams
		{
			// Token: 0x04017078 RID: 94328
			[FieldOffset(0)]
			public int Index;

			// Token: 0x04017079 RID: 94329
			[FieldOffset(8)]
			public IntPtr __Result;
		}

		// Token: 0x02003215 RID: 12821
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetAllSplineComponents_FunctionParams
		{
			// Token: 0x0401707A RID: 94330
			[FieldOffset(0)]
			public byte OutSplines;
		}

		// Token: 0x02003216 RID: 12822
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetAllRopeNiagaraComponents_FunctionParams
		{
			// Token: 0x0401707B RID: 94331
			[FieldOffset(0)]
			public byte OutNiagaras;
		}

		// Token: 0x02003217 RID: 12823
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __BindNiagaraToRopeSplines_FunctionParams
		{
			// Token: 0x0401707C RID: 94332
			[FieldOffset(0)]
			public IntPtr NiagaraComp;

			// Token: 0x0401707D RID: 94333
			[FieldOffset(8)]
			public int __Result;
		}
	}
}
