using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200051A RID: 1306
	[UnrealObjectPath("/Script/KuroRopeEffect.RopeEffectSplineActor")]
	[UnrealStructLayout(1120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1120)]
	public class ARopeEffectSplineActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007A16 RID: 31254 RVA: 0x000B31DC File Offset: 0x000B13DC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ARopeEffectSplineActor._ClassPtr;
		}

		// Token: 0x06007A17 RID: 31255 RVA: 0x000B31E8 File Offset: 0x000B13E8
		public ARopeEffectSplineActor() : this(BuiltinUtils.AllocNativeUObject(ARopeEffectSplineActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007A18 RID: 31256 RVA: 0x000B3210 File Offset: 0x000B1410
		[NullableContext(1)]
		public ARopeEffectSplineActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ARopeEffectSplineActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170017B3 RID: 6067
		// (get) Token: 0x06007A19 RID: 31257 RVA: 0x000B3243 File Offset: 0x000B1443
		// (set) Token: 0x06007A1A RID: 31258 RVA: 0x000B3257 File Offset: 0x000B1457
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

		// Token: 0x170017B4 RID: 6068
		// (get) Token: 0x06007A1B RID: 31259 RVA: 0x000B326C File Offset: 0x000B146C
		// (set) Token: 0x06007A1C RID: 31260 RVA: 0x000B32A5 File Offset: 0x000B14A5
		[Nullable(1)]
		public TArray<USplineComponent> SplineComponents
		{
			[NullableContext(1)]
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
			[NullableContext(1)]
			set
			{
				this.SplineComponents.CopyAssign(value);
			}
		}

		// Token: 0x170017B5 RID: 6069
		// (get) Token: 0x06007A1D RID: 31261 RVA: 0x000B32B4 File Offset: 0x000B14B4
		// (set) Token: 0x06007A1E RID: 31262 RVA: 0x000B32ED File Offset: 0x000B14ED
		[Nullable(1)]
		public TArray<UNiagaraComponent> NiagaraComponents
		{
			[NullableContext(1)]
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
			[NullableContext(1)]
			set
			{
				this.NiagaraComponents.CopyAssign(value);
			}
		}

		// Token: 0x170017B6 RID: 6070
		// (get) Token: 0x06007A1F RID: 31263 RVA: 0x000B32FB File Offset: 0x000B14FB
		// (set) Token: 0x06007A20 RID: 31264 RVA: 0x000B330F File Offset: 0x000B150F
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

		// Token: 0x170017B7 RID: 6071
		// (get) Token: 0x06007A21 RID: 31265 RVA: 0x000B3324 File Offset: 0x000B1524
		// (set) Token: 0x06007A22 RID: 31266 RVA: 0x000B3338 File Offset: 0x000B1538
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

		// Token: 0x06007A23 RID: 31267 RVA: 0x000B3350 File Offset: 0x000B1550
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetRopeNiagaraAsset(UNiagaraSystem NiagaraAsset)
		{
			ARopeEffectSplineActor.__SetRopeNiagaraAsset_FunctionParams* ptr = stackalloc ARopeEffectSplineActor.__SetRopeNiagaraAsset_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(ARopeEffectSplineActor.__SetRopeNiagaraAsset_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ARopeEffectSplineActor.__SetRopeNiagaraAsset_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NiagaraAsset = ((NiagaraAsset != null) ? NiagaraAsset.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ARopeEffectSplineActor.__SetRopeNiagaraAsset_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06007A24 RID: 31268 RVA: 0x000B33A8 File Offset: 0x000B15A8
		[SkipLocalsInit]
		public unsafe int GetTotalRopeCount()
		{
			ARopeEffectSplineActor.__GetTotalRopeCount_FunctionParams* ptr = stackalloc ARopeEffectSplineActor.__GetTotalRopeCount_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ARopeEffectSplineActor.__GetTotalRopeCount_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ARopeEffectSplineActor.__GetTotalRopeCount_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ARopeEffectSplineActor.__GetTotalRopeCount_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06007A25 RID: 31269 RVA: 0x000B33F0 File Offset: 0x000B15F0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe USplineComponent GetSplineComponentByIndex(int Index)
		{
			ARopeEffectSplineActor.__GetSplineComponentByIndex_FunctionParams* ptr = stackalloc ARopeEffectSplineActor.__GetSplineComponentByIndex_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ARopeEffectSplineActor.__GetSplineComponentByIndex_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ARopeEffectSplineActor.__GetSplineComponentByIndex_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Index = Index;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ARopeEffectSplineActor.__GetSplineComponentByIndex_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USplineComponent>(ptr->__Result);
		}

		// Token: 0x06007A26 RID: 31270 RVA: 0x000B3444 File Offset: 0x000B1644
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe UNiagaraComponent GetRopeNiagaraComponentByIndex(int Index)
		{
			ARopeEffectSplineActor.__GetRopeNiagaraComponentByIndex_FunctionParams* ptr = stackalloc ARopeEffectSplineActor.__GetRopeNiagaraComponentByIndex_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ARopeEffectSplineActor.__GetRopeNiagaraComponentByIndex_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ARopeEffectSplineActor.__GetRopeNiagaraComponentByIndex_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Index = Index;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ARopeEffectSplineActor.__GetRopeNiagaraComponentByIndex_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UNiagaraComponent>(ptr->__Result);
		}

		// Token: 0x06007A27 RID: 31271 RVA: 0x000B3498 File Offset: 0x000B1698
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ARopeEffectSplineActor.__GetAllSplineComponents_NativeFunctionPtr, (void*)ptr);
			TArray<USplineComponent> tarray2 = OutSplines;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutSplines);
			}
			UnrealReflectionUtils.DestroyStruct(ARopeEffectSplineActor.__GetAllSplineComponents_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007A28 RID: 31272 RVA: 0x000B3510 File Offset: 0x000B1710
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ARopeEffectSplineActor.__GetAllRopeNiagaraComponents_NativeFunctionPtr, (void*)ptr);
			TArray<UNiagaraComponent> tarray2 = OutNiagaras;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutNiagaras);
			}
			UnrealReflectionUtils.DestroyStruct(ARopeEffectSplineActor.__GetAllRopeNiagaraComponents_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007A29 RID: 31273 RVA: 0x000B3588 File Offset: 0x000B1788
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe int BindNiagaraToRopeSplines(UNiagaraComponent NiagaraComp)
		{
			ARopeEffectSplineActor.__BindNiagaraToRopeSplines_FunctionParams* ptr = stackalloc ARopeEffectSplineActor.__BindNiagaraToRopeSplines_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ARopeEffectSplineActor.__BindNiagaraToRopeSplines_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ARopeEffectSplineActor.__BindNiagaraToRopeSplines_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NiagaraComp = ((NiagaraComp != null) ? NiagaraComp.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ARopeEffectSplineActor.__BindNiagaraToRopeSplines_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06007A2A RID: 31274 RVA: 0x000B35E3 File Offset: 0x000B17E3
		static ARopeEffectSplineActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRopeEffect.RopeEffectSplineActor");
		}

		// Token: 0x06007A2B RID: 31275 RVA: 0x000B35F1 File Offset: 0x000B17F1
		protected ARopeEffectSplineActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040033E5 RID: 13285
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRopeEffect.RopeEffectSplineActor";

		// Token: 0x040033E6 RID: 13286
		private static IntPtr _ClassPtr;

		// Token: 0x040033E7 RID: 13287
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040033E8 RID: 13288
		internal static int __PropertyOffset_RopeRootComponent;

		// Token: 0x040033E9 RID: 13289
		internal static int __PropertyOffset_SplineComponents;

		// Token: 0x040033EA RID: 13290
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USplineComponent> _SplineComponents;

		// Token: 0x040033EB RID: 13291
		internal static int __PropertyOffset_NiagaraComponents;

		// Token: 0x040033EC RID: 13292
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UNiagaraComponent> _NiagaraComponents;

		// Token: 0x040033ED RID: 13293
		internal static int __PropertyOffset_TargetSkeletalMeshComponent;

		// Token: 0x040033EE RID: 13294
		internal static int __PropertyOffset_ConfigDataAsset;

		// Token: 0x040033EF RID: 13295
		private static IntPtr __SetRopeNiagaraAsset_NativeFunctionPtr;

		// Token: 0x040033F0 RID: 13296
		private static IntPtr __GetTotalRopeCount_NativeFunctionPtr;

		// Token: 0x040033F1 RID: 13297
		private static IntPtr __GetSplineComponentByIndex_NativeFunctionPtr;

		// Token: 0x040033F2 RID: 13298
		private static IntPtr __GetRopeNiagaraComponentByIndex_NativeFunctionPtr;

		// Token: 0x040033F3 RID: 13299
		private static IntPtr __GetAllSplineComponents_NativeFunctionPtr;

		// Token: 0x040033F4 RID: 13300
		private static IntPtr __GetAllRopeNiagaraComponents_NativeFunctionPtr;

		// Token: 0x040033F5 RID: 13301
		private static IntPtr __BindNiagaraToRopeSplines_NativeFunctionPtr;

		// Token: 0x02000C86 RID: 3206
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetRopeNiagaraAsset_FunctionParams
		{
			// Token: 0x04005EE8 RID: 24296
			[FieldOffset(0)]
			public IntPtr NiagaraAsset;
		}

		// Token: 0x02000C87 RID: 3207
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetTotalRopeCount_FunctionParams
		{
			// Token: 0x04005EE9 RID: 24297
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02000C88 RID: 3208
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetSplineComponentByIndex_FunctionParams
		{
			// Token: 0x04005EEA RID: 24298
			[FieldOffset(0)]
			public int Index;

			// Token: 0x04005EEB RID: 24299
			[FieldOffset(8)]
			public IntPtr __Result;
		}

		// Token: 0x02000C89 RID: 3209
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetRopeNiagaraComponentByIndex_FunctionParams
		{
			// Token: 0x04005EEC RID: 24300
			[FieldOffset(0)]
			public int Index;

			// Token: 0x04005EED RID: 24301
			[FieldOffset(8)]
			public IntPtr __Result;
		}

		// Token: 0x02000C8A RID: 3210
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetAllSplineComponents_FunctionParams
		{
			// Token: 0x04005EEE RID: 24302
			[FieldOffset(0)]
			public byte OutSplines;
		}

		// Token: 0x02000C8B RID: 3211
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetAllRopeNiagaraComponents_FunctionParams
		{
			// Token: 0x04005EEF RID: 24303
			[FieldOffset(0)]
			public byte OutNiagaras;
		}

		// Token: 0x02000C8C RID: 3212
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __BindNiagaraToRopeSplines_FunctionParams
		{
			// Token: 0x04005EF0 RID: 24304
			[FieldOffset(0)]
			public IntPtr NiagaraComp;

			// Token: 0x04005EF1 RID: 24305
			[FieldOffset(8)]
			public int __Result;
		}
	}
}
