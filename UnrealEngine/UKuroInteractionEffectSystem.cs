using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019A5 RID: 6565
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroInteractionEffect.KuroInteractionEffectSystem")]
	[UnrealStructLayout(1104, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1104)]
	public class UKuroInteractionEffectSystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060186DC RID: 100060 RVA: 0x002400E4 File Offset: 0x0023E2E4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroInteractionEffectSystem._ClassPtr;
		}

		// Token: 0x060186DD RID: 100061 RVA: 0x002400F0 File Offset: 0x0023E2F0
		public UKuroInteractionEffectSystem() : this(BuiltinUtils.AllocNativeUObject(UKuroInteractionEffectSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060186DE RID: 100062 RVA: 0x00240118 File Offset: 0x0023E318
		[NullableContext(1)]
		public UKuroInteractionEffectSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroInteractionEffectSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006197 RID: 24983
		// (get) Token: 0x060186DF RID: 100063 RVA: 0x0024014C File Offset: 0x0023E34C
		// (set) Token: 0x060186E0 RID: 100064 RVA: 0x00240185 File Offset: 0x0023E385
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

		// Token: 0x17006198 RID: 24984
		// (get) Token: 0x060186E1 RID: 100065 RVA: 0x00240194 File Offset: 0x0023E394
		// (set) Token: 0x060186E2 RID: 100066 RVA: 0x002401CD File Offset: 0x0023E3CD
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

		// Token: 0x17006199 RID: 24985
		// (get) Token: 0x060186E3 RID: 100067 RVA: 0x002401DC File Offset: 0x0023E3DC
		// (set) Token: 0x060186E4 RID: 100068 RVA: 0x00240215 File Offset: 0x0023E415
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

		// Token: 0x1700619A RID: 24986
		// (get) Token: 0x060186E5 RID: 100069 RVA: 0x00240223 File Offset: 0x0023E423
		// (set) Token: 0x060186E6 RID: 100070 RVA: 0x00240233 File Offset: 0x0023E433
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

		// Token: 0x1700619B RID: 24987
		// (get) Token: 0x060186E7 RID: 100071 RVA: 0x00240244 File Offset: 0x0023E444
		// (set) Token: 0x060186E8 RID: 100072 RVA: 0x00240258 File Offset: 0x0023E458
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

		// Token: 0x1700619C RID: 24988
		// (get) Token: 0x060186E9 RID: 100073 RVA: 0x0024026D File Offset: 0x0023E46D
		// (set) Token: 0x060186EA RID: 100074 RVA: 0x00240281 File Offset: 0x0023E481
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

		// Token: 0x060186EB RID: 100075 RVA: 0x00240296 File Offset: 0x0023E496
		public void SetGlobalUINiagaraPause(bool bPause)
		{
			UKuroInteractionEffectSystem.__SetGlobalUINiagaraPause_Internal(base.NativePtr, bPause);
		}

		// Token: 0x060186EC RID: 100076 RVA: 0x002402A4 File Offset: 0x0023E4A4
		[NullableContext(1)]
		public FKuroInteractionEffectTraceStaticMesh SearchInteractionStaticMeshConfig([Nullable(2)] UStaticMesh StaticMesh)
		{
			return new FKuroInteractionEffectTraceStaticMesh(UKuroInteractionEffectSystem.__SearchInteractionStaticMeshConfig_Internal(base.NativePtr, (StaticMesh != null) ? StaticMesh.NativePtr : IntPtr.Zero), null);
		}

		// Token: 0x060186ED RID: 100077 RVA: 0x002402C7 File Offset: 0x0023E4C7
		[NullableContext(1)]
		public TArray<int> SearchInteractionFoliageArray([Nullable(new byte[]
		{
			2,
			1
		})] TArray<string> FoliageTypeNames)
		{
			return new TArray<int>(UKuroInteractionEffectSystem.__SearchInteractionFoliageArray_Internal(base.NativePtr, (FoliageTypeNames ?? new TArray<string>()).NativePtr), null);
		}

		// Token: 0x060186EE RID: 100078 RVA: 0x002402EC File Offset: 0x0023E4EC
		[NullableContext(1)]
		public unsafe int SearchInteractionFoliage(string FoliageTypeName)
		{
			FString fstring = FString.AllocTemp(FoliageTypeName);
			int result = UKuroInteractionEffectSystem.__SearchInteractionFoliage_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060186EF RID: 100079 RVA: 0x00240316 File Offset: 0x0023E516
		public void RegisterSPModelCharacterEIComp(UNiagaraComponent InNiagaraComp, UKuroEnviInteractionComponent SourceEIComp)
		{
			UKuroInteractionEffectSystem.__RegisterSPModelCharacterEIComp_Internal(base.NativePtr, (InNiagaraComp != null) ? InNiagaraComp.NativePtr : IntPtr.Zero, (SourceEIComp != null) ? SourceEIComp.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060186F0 RID: 100080 RVA: 0x00240343 File Offset: 0x0023E543
		public void RegisterNDIKuroRenderingEIComp(UNiagaraComponent InNiagaraComp, UKuroEnviInteractionComponent SourceEIComp)
		{
			UKuroInteractionEffectSystem.__RegisterNDIKuroRenderingEIComp_Internal(base.NativePtr, (InNiagaraComp != null) ? InNiagaraComp.NativePtr : IntPtr.Zero, (SourceEIComp != null) ? SourceEIComp.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060186F1 RID: 100081 RVA: 0x00240370 File Offset: 0x0023E570
		public static UKuroInteractionEffectSystem GetKuroInteractionEffectSystem(UWorld World)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroInteractionEffectSystem>(UKuroInteractionEffectSystem.__GetKuroInteractionEffectSystem_Internal((World != null) ? World.NativePtr : IntPtr.Zero));
		}

		// Token: 0x060186F2 RID: 100082 RVA: 0x0024038C File Offset: 0x0023E58C
		public bool GetGlobalUINiagaraPause()
		{
			return UKuroInteractionEffectSystem.__GetGlobalUINiagaraPause_Internal(base.NativePtr);
		}

		// Token: 0x060186F3 RID: 100083
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGlobalUINiagaraPause_Internal(IntPtr @this, bool bPause);

		// Token: 0x060186F4 RID: 100084
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SearchInteractionStaticMeshConfig_Internal(IntPtr @this, IntPtr StaticMesh);

		// Token: 0x060186F5 RID: 100085
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SearchInteractionFoliageArray_Internal(IntPtr @this, IntPtr FoliageTypeNames);

		// Token: 0x060186F6 RID: 100086
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __SearchInteractionFoliage_Internal(IntPtr @this, in FString FoliageTypeName);

		// Token: 0x060186F7 RID: 100087
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterSPModelCharacterEIComp_Internal(IntPtr @this, IntPtr InNiagaraComp, IntPtr SourceEIComp);

		// Token: 0x060186F8 RID: 100088
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterNDIKuroRenderingEIComp_Internal(IntPtr @this, IntPtr InNiagaraComp, IntPtr SourceEIComp);

		// Token: 0x060186F9 RID: 100089
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetKuroInteractionEffectSystem_Internal(IntPtr World);

		// Token: 0x060186FA RID: 100090
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetGlobalUINiagaraPause_Internal(IntPtr @this);

		// Token: 0x060186FB RID: 100091 RVA: 0x00240399 File Offset: 0x0023E599
		static UKuroInteractionEffectSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroInteractionEffect.KuroInteractionEffectSystem");
		}

		// Token: 0x060186FC RID: 100092 RVA: 0x002403A7 File Offset: 0x0023E5A7
		protected UKuroInteractionEffectSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D33A RID: 54074
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroInteractionEffect.KuroInteractionEffectSystem";

		// Token: 0x0400D33B RID: 54075
		private static IntPtr _ClassPtr;

		// Token: 0x0400D33C RID: 54076
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D33D RID: 54077
		internal static int __PropertyOffset_EnviInteractionCollections;

		// Token: 0x0400D33E RID: 54078
		[Nullable(new byte[]
		{
			2,
			0,
			1,
			1
		})]
		private TMap<TWeakObjectPtr<UKuroEnviInteractionComponent>, FKuroEnviInteractionData> _EnviInteractionCollections;

		// Token: 0x0400D33F RID: 54079
		internal static int __PropertyOffset_SPModelEICompCollections;

		// Token: 0x0400D340 RID: 54080
		[Nullable(new byte[]
		{
			2,
			0,
			1,
			0,
			1
		})]
		private TMap<TWeakObjectPtr<UNiagaraComponent>, TWeakObjectPtr<UKuroEnviInteractionComponent>> _SPModelEICompCollections;

		// Token: 0x0400D341 RID: 54081
		internal static int __PropertyOffset_NDIKuroRenderingCollections;

		// Token: 0x0400D342 RID: 54082
		[Nullable(new byte[]
		{
			2,
			0,
			1,
			0,
			1
		})]
		private TMap<TWeakObjectPtr<UNiagaraComponent>, TWeakObjectPtr<UKuroEnviInteractionComponent>> _NDIKuroRenderingCollections;

		// Token: 0x0400D343 RID: 54083
		internal static int __PropertyOffset_GrassCutReadBack;

		// Token: 0x0400D344 RID: 54084
		internal static int __PropertyOffset_IEMeshInteractionConfigTable;

		// Token: 0x0400D345 RID: 54085
		internal static int __PropertyOffset_WaterSimMPC;
	}
}
