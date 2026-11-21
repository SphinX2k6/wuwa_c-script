using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000451 RID: 1105
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroInteractionEffect.KuroInteractionEffectSystem")]
	[UnrealStructLayout(1936, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1936)]
	public class UKuroInteractionEffectSystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006AD9 RID: 27353 RVA: 0x0009B9D9 File Offset: 0x00099BD9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroInteractionEffectSystem._ClassPtr;
		}

		// Token: 0x06006ADA RID: 27354 RVA: 0x0009B9E8 File Offset: 0x00099BE8
		public UKuroInteractionEffectSystem() : this(BuiltinUtils.AllocNativeUObject(UKuroInteractionEffectSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006ADB RID: 27355 RVA: 0x0009BA10 File Offset: 0x00099C10
		[NullableContext(1)]
		public UKuroInteractionEffectSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroInteractionEffectSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700154C RID: 5452
		// (get) Token: 0x06006ADC RID: 27356 RVA: 0x0009BA44 File Offset: 0x00099C44
		// (set) Token: 0x06006ADD RID: 27357 RVA: 0x0009BA7D File Offset: 0x00099C7D
		[Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})]
		public TMap<TWeakObjectPtr<UKuroEnviInteractionComponent>, FKuroEnviInteractionData> EnviInteractionCollections
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TWeakObjectPtr<UKuroEnviInteractionComponent>, FKuroEnviInteractionData> result;
				if ((result = this._EnviInteractionCollections) == null)
				{
					result = (this._EnviInteractionCollections = new TMap<TWeakObjectPtr<UKuroEnviInteractionComponent>, FKuroEnviInteractionData>(base.NativePtr + (IntPtr)UKuroInteractionEffectSystem.__PropertyOffset_EnviInteractionCollections, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1,
				1
			})]
			set
			{
				this.EnviInteractionCollections.CopyAssign(value);
			}
		}

		// Token: 0x1700154D RID: 5453
		// (get) Token: 0x06006ADE RID: 27358 RVA: 0x0009BA8C File Offset: 0x00099C8C
		// (set) Token: 0x06006ADF RID: 27359 RVA: 0x0009BAC5 File Offset: 0x00099CC5
		[Nullable(new byte[]
		{
			1,
			0,
			1,
			0,
			1
		})]
		public TMap<TWeakObjectPtr<UNiagaraComponent>, TWeakObjectPtr<UKuroEnviInteractionComponent>> SPModelEICompCollections
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TWeakObjectPtr<UNiagaraComponent>, TWeakObjectPtr<UKuroEnviInteractionComponent>> result;
				if ((result = this._SPModelEICompCollections) == null)
				{
					result = (this._SPModelEICompCollections = new TMap<TWeakObjectPtr<UNiagaraComponent>, TWeakObjectPtr<UKuroEnviInteractionComponent>>(base.NativePtr + (IntPtr)UKuroInteractionEffectSystem.__PropertyOffset_SPModelEICompCollections, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1,
				0,
				1
			})]
			set
			{
				this.SPModelEICompCollections.CopyAssign(value);
			}
		}

		// Token: 0x1700154E RID: 5454
		// (get) Token: 0x06006AE0 RID: 27360 RVA: 0x0009BAD4 File Offset: 0x00099CD4
		// (set) Token: 0x06006AE1 RID: 27361 RVA: 0x0009BB0D File Offset: 0x00099D0D
		[Nullable(new byte[]
		{
			1,
			0,
			1,
			0,
			1
		})]
		public TMap<TWeakObjectPtr<UNiagaraComponent>, TWeakObjectPtr<UKuroEnviInteractionComponent>> NDIKuroRenderingCollections
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TWeakObjectPtr<UNiagaraComponent>, TWeakObjectPtr<UKuroEnviInteractionComponent>> result;
				if ((result = this._NDIKuroRenderingCollections) == null)
				{
					result = (this._NDIKuroRenderingCollections = new TMap<TWeakObjectPtr<UNiagaraComponent>, TWeakObjectPtr<UKuroEnviInteractionComponent>>(base.NativePtr + (IntPtr)UKuroInteractionEffectSystem.__PropertyOffset_NDIKuroRenderingCollections, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1,
				0,
				1
			})]
			set
			{
				this.NDIKuroRenderingCollections.CopyAssign(value);
			}
		}

		// Token: 0x1700154F RID: 5455
		// (get) Token: 0x06006AE2 RID: 27362 RVA: 0x0009BB1B File Offset: 0x00099D1B
		// (set) Token: 0x06006AE3 RID: 27363 RVA: 0x0009BB2B File Offset: 0x00099D2B
		public unsafe float GrassCutReadBack
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroInteractionEffectSystem.__PropertyOffset_GrassCutReadBack);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroInteractionEffectSystem.__PropertyOffset_GrassCutReadBack) = value;
			}
		}

		// Token: 0x17001550 RID: 5456
		// (get) Token: 0x06006AE4 RID: 27364 RVA: 0x0009BB3C File Offset: 0x00099D3C
		// (set) Token: 0x06006AE5 RID: 27365 RVA: 0x0009BB50 File Offset: 0x00099D50
		public unsafe UDataTable IEMeshInteractionConfigTable
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroInteractionEffectSystem.__PropertyOffset_IEMeshInteractionConfigTable);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroInteractionEffectSystem.__PropertyOffset_IEMeshInteractionConfigTable, value);
			}
		}

		// Token: 0x17001551 RID: 5457
		// (get) Token: 0x06006AE6 RID: 27366 RVA: 0x0009BB65 File Offset: 0x00099D65
		// (set) Token: 0x06006AE7 RID: 27367 RVA: 0x0009BB79 File Offset: 0x00099D79
		public unsafe UMaterialParameterCollection WaterSimMPC
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroInteractionEffectSystem.__PropertyOffset_WaterSimMPC);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroInteractionEffectSystem.__PropertyOffset_WaterSimMPC, value);
			}
		}

		// Token: 0x06006AE8 RID: 27368 RVA: 0x0009BB8E File Offset: 0x00099D8E
		public void SetGlobalUINiagaraPause(bool bPause)
		{
			UKuroInteractionEffectSystem.__SetGlobalUINiagaraPause_Internal(base.NativePtr, bPause);
		}

		// Token: 0x06006AE9 RID: 27369 RVA: 0x0009BB9C File Offset: 0x00099D9C
		[NullableContext(1)]
		public FKuroInteractionEffectTraceStaticMesh SearchInteractionStaticMeshConfig([Nullable(2)] UStaticMesh StaticMesh)
		{
			return new FKuroInteractionEffectTraceStaticMesh(UKuroInteractionEffectSystem.__SearchInteractionStaticMeshConfig_Internal(base.NativePtr, (StaticMesh != null) ? StaticMesh.NativePtr : IntPtr.Zero), null);
		}

		// Token: 0x06006AEA RID: 27370 RVA: 0x0009BBBF File Offset: 0x00099DBF
		[NullableContext(1)]
		public TArray<int> SearchInteractionFoliageArray([Nullable(new byte[]
		{
			2,
			1
		})] TArray<string> FoliageTypeNames)
		{
			return new TArray<int>(UKuroInteractionEffectSystem.__SearchInteractionFoliageArray_Internal(base.NativePtr, (FoliageTypeNames ?? new TArray<string>()).NativePtr), null);
		}

		// Token: 0x06006AEB RID: 27371 RVA: 0x0009BBE4 File Offset: 0x00099DE4
		[NullableContext(1)]
		public unsafe int SearchInteractionFoliage(string FoliageTypeName)
		{
			FString fstring = FString.AllocTemp(FoliageTypeName);
			int result = UKuroInteractionEffectSystem.__SearchInteractionFoliage_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06006AEC RID: 27372 RVA: 0x0009BC0E File Offset: 0x00099E0E
		public void RegisterSPModelCharacterEIComp(UNiagaraComponent InNiagaraComp, UKuroEnviInteractionComponent SourceEIComp)
		{
			UKuroInteractionEffectSystem.__RegisterSPModelCharacterEIComp_Internal(base.NativePtr, (InNiagaraComp != null) ? InNiagaraComp.NativePtr : IntPtr.Zero, (SourceEIComp != null) ? SourceEIComp.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006AED RID: 27373 RVA: 0x0009BC3B File Offset: 0x00099E3B
		public void RegisterNDIKuroRenderingEIComp(UNiagaraComponent InNiagaraComp, UKuroEnviInteractionComponent SourceEIComp)
		{
			UKuroInteractionEffectSystem.__RegisterNDIKuroRenderingEIComp_Internal(base.NativePtr, (InNiagaraComp != null) ? InNiagaraComp.NativePtr : IntPtr.Zero, (SourceEIComp != null) ? SourceEIComp.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006AEE RID: 27374 RVA: 0x0009BC68 File Offset: 0x00099E68
		public void RefreshInteractionVoxelBakeData()
		{
			UKuroInteractionEffectSystem.__RefreshInteractionVoxelBakeData_Internal(base.NativePtr);
		}

		// Token: 0x06006AEF RID: 27375 RVA: 0x0009BC75 File Offset: 0x00099E75
		public static UKuroInteractionEffectSystem GetKuroInteractionEffectSystem(UWorld World)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroInteractionEffectSystem>(UKuroInteractionEffectSystem.__GetKuroInteractionEffectSystem_Internal((World != null) ? World.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06006AF0 RID: 27376 RVA: 0x0009BC91 File Offset: 0x00099E91
		public bool GetGlobalUINiagaraPause()
		{
			return UKuroInteractionEffectSystem.__GetGlobalUINiagaraPause_Internal(base.NativePtr);
		}

		// Token: 0x06006AF1 RID: 27377
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGlobalUINiagaraPause_Internal(IntPtr @this, bool bPause);

		// Token: 0x06006AF2 RID: 27378
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SearchInteractionStaticMeshConfig_Internal(IntPtr @this, IntPtr StaticMesh);

		// Token: 0x06006AF3 RID: 27379
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SearchInteractionFoliageArray_Internal(IntPtr @this, IntPtr FoliageTypeNames);

		// Token: 0x06006AF4 RID: 27380
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __SearchInteractionFoliage_Internal(IntPtr @this, in FString FoliageTypeName);

		// Token: 0x06006AF5 RID: 27381
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterSPModelCharacterEIComp_Internal(IntPtr @this, IntPtr InNiagaraComp, IntPtr SourceEIComp);

		// Token: 0x06006AF6 RID: 27382
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterNDIKuroRenderingEIComp_Internal(IntPtr @this, IntPtr InNiagaraComp, IntPtr SourceEIComp);

		// Token: 0x06006AF7 RID: 27383
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RefreshInteractionVoxelBakeData_Internal(IntPtr @this);

		// Token: 0x06006AF8 RID: 27384
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetKuroInteractionEffectSystem_Internal(IntPtr World);

		// Token: 0x06006AF9 RID: 27385
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetGlobalUINiagaraPause_Internal(IntPtr @this);

		// Token: 0x06006AFA RID: 27386 RVA: 0x0009BC9E File Offset: 0x00099E9E
		static UKuroInteractionEffectSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroInteractionEffect.KuroInteractionEffectSystem");
		}

		// Token: 0x06006AFB RID: 27387 RVA: 0x0009BCAC File Offset: 0x00099EAC
		protected UKuroInteractionEffectSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002D53 RID: 11603
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroInteractionEffect.KuroInteractionEffectSystem";

		// Token: 0x04002D54 RID: 11604
		private static IntPtr _ClassPtr;

		// Token: 0x04002D55 RID: 11605
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002D56 RID: 11606
		internal static int __PropertyOffset_EnviInteractionCollections;

		// Token: 0x04002D57 RID: 11607
		[Nullable(new byte[]
		{
			2,
			0,
			1,
			1
		})]
		private TMap<TWeakObjectPtr<UKuroEnviInteractionComponent>, FKuroEnviInteractionData> _EnviInteractionCollections;

		// Token: 0x04002D58 RID: 11608
		internal static int __PropertyOffset_SPModelEICompCollections;

		// Token: 0x04002D59 RID: 11609
		[Nullable(new byte[]
		{
			2,
			0,
			1,
			0,
			1
		})]
		private TMap<TWeakObjectPtr<UNiagaraComponent>, TWeakObjectPtr<UKuroEnviInteractionComponent>> _SPModelEICompCollections;

		// Token: 0x04002D5A RID: 11610
		internal static int __PropertyOffset_NDIKuroRenderingCollections;

		// Token: 0x04002D5B RID: 11611
		[Nullable(new byte[]
		{
			2,
			0,
			1,
			0,
			1
		})]
		private TMap<TWeakObjectPtr<UNiagaraComponent>, TWeakObjectPtr<UKuroEnviInteractionComponent>> _NDIKuroRenderingCollections;

		// Token: 0x04002D5C RID: 11612
		internal static int __PropertyOffset_GrassCutReadBack;

		// Token: 0x04002D5D RID: 11613
		internal static int __PropertyOffset_IEMeshInteractionConfigTable;

		// Token: 0x04002D5E RID: 11614
		internal static int __PropertyOffset_WaterSimMPC;
	}
}
