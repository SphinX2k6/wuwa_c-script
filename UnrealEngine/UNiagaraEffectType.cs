using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002599 RID: 9625
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraEffectType")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 296)]
	public class UNiagaraEffectType : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023BB3 RID: 146355 RVA: 0x0034D44A File Offset: 0x0034B64A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraEffectType._ClassPtr;
		}

		// Token: 0x06023BB4 RID: 146356 RVA: 0x0034D458 File Offset: 0x0034B658
		public UNiagaraEffectType() : this(BuiltinUtils.AllocNativeUObject(UNiagaraEffectType.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023BB5 RID: 146357 RVA: 0x0034D480 File Offset: 0x0034B680
		public UNiagaraEffectType(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraEffectType.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700893F RID: 35135
		// (get) Token: 0x06023BB6 RID: 146358 RVA: 0x0034D4B3 File Offset: 0x0034B6B3
		// (set) Token: 0x06023BB7 RID: 146359 RVA: 0x0034D4C3 File Offset: 0x0034B6C3
		public unsafe ENiagaraScalabilityUpdateFrequency UpdateFrequency
		{
			get
			{
				return (ENiagaraScalabilityUpdateFrequency)(*(base.NativePtr + (IntPtr)UNiagaraEffectType.__PropertyOffset_UpdateFrequency));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraEffectType.__PropertyOffset_UpdateFrequency) = (int)value;
			}
		}

		// Token: 0x17008940 RID: 35136
		// (get) Token: 0x06023BB8 RID: 146360 RVA: 0x0034D4D4 File Offset: 0x0034B6D4
		// (set) Token: 0x06023BB9 RID: 146361 RVA: 0x0034D4E4 File Offset: 0x0034B6E4
		public unsafe ENiagaraCullReaction CullReaction
		{
			get
			{
				return (ENiagaraCullReaction)(*(base.NativePtr + (IntPtr)UNiagaraEffectType.__PropertyOffset_CullReaction));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraEffectType.__PropertyOffset_CullReaction) = (int)value;
			}
		}

		// Token: 0x17008941 RID: 35137
		// (get) Token: 0x06023BBA RID: 146362 RVA: 0x0034D4F5 File Offset: 0x0034B6F5
		// (set) Token: 0x06023BBB RID: 146363 RVA: 0x0034D509 File Offset: 0x0034B709
		[Nullable(2)]
		public unsafe UNiagaraSignificanceHandler SignificanceHandler
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSignificanceHandler>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraEffectType.__PropertyOffset_SignificanceHandler);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraEffectType.__PropertyOffset_SignificanceHandler, value);
			}
		}

		// Token: 0x17008942 RID: 35138
		// (get) Token: 0x06023BBC RID: 146364 RVA: 0x0034D520 File Offset: 0x0034B720
		// (set) Token: 0x06023BBD RID: 146365 RVA: 0x0034D559 File Offset: 0x0034B759
		public TArray<FNiagaraSystemScalabilitySettings> DetailLevelScalabilitySettings_DEPRECATED
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNiagaraSystemScalabilitySettings> result;
				if ((result = this._DetailLevelScalabilitySettings_DEPRECATED) == null)
				{
					result = (this._DetailLevelScalabilitySettings_DEPRECATED = new TArray<FNiagaraSystemScalabilitySettings>(base.NativePtr + (IntPtr)UNiagaraEffectType.__PropertyOffset_DetailLevelScalabilitySettings_DEPRECATED, this));
				}
				return result;
			}
			set
			{
				this.DetailLevelScalabilitySettings_DEPRECATED.CopyAssign(value);
			}
		}

		// Token: 0x17008943 RID: 35139
		// (get) Token: 0x06023BBE RID: 146366 RVA: 0x0034D568 File Offset: 0x0034B768
		// (set) Token: 0x06023BBF RID: 146367 RVA: 0x0034D5A1 File Offset: 0x0034B7A1
		public FNiagaraSystemScalabilitySettingsArray SystemScalabilitySettings
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraSystemScalabilitySettingsArray result;
				if ((result = this._SystemScalabilitySettings) == null)
				{
					result = (this._SystemScalabilitySettings = new FNiagaraSystemScalabilitySettingsArray(base.NativePtr + (IntPtr)UNiagaraEffectType.__PropertyOffset_SystemScalabilitySettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraSystemScalabilitySettingsArray.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraEffectType.__PropertyOffset_SystemScalabilitySettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008944 RID: 35140
		// (get) Token: 0x06023BC0 RID: 146368 RVA: 0x0034D5C4 File Offset: 0x0034B7C4
		// (set) Token: 0x06023BC1 RID: 146369 RVA: 0x0034D5FD File Offset: 0x0034B7FD
		public FNiagaraEmitterScalabilitySettingsArray EmitterScalabilitySettings
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraEmitterScalabilitySettingsArray result;
				if ((result = this._EmitterScalabilitySettings) == null)
				{
					result = (this._EmitterScalabilitySettings = new FNiagaraEmitterScalabilitySettingsArray(base.NativePtr + (IntPtr)UNiagaraEffectType.__PropertyOffset_EmitterScalabilitySettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraEmitterScalabilitySettingsArray.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraEffectType.__PropertyOffset_EmitterScalabilitySettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008945 RID: 35141
		// (get) Token: 0x06023BC2 RID: 146370 RVA: 0x0034D620 File Offset: 0x0034B820
		// (set) Token: 0x06023BC3 RID: 146371 RVA: 0x0034D659 File Offset: 0x0034B859
		public FNiagaraSystemSimulationTickSettingsArray SystemSimulationTickSettings
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraSystemSimulationTickSettingsArray result;
				if ((result = this._SystemSimulationTickSettings) == null)
				{
					result = (this._SystemSimulationTickSettings = new FNiagaraSystemSimulationTickSettingsArray(base.NativePtr + (IntPtr)UNiagaraEffectType.__PropertyOffset_SystemSimulationTickSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraSystemSimulationTickSettingsArray.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraEffectType.__PropertyOffset_SystemSimulationTickSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06023BC4 RID: 146372 RVA: 0x0034D67A File Offset: 0x0034B87A
		static UNiagaraEffectType()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraEffectType");
		}

		// Token: 0x06023BC5 RID: 146373 RVA: 0x0034D688 File Offset: 0x0034B888
		protected UNiagaraEffectType(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401328C RID: 78476
		public new const string __ObjectPath = "/Script/Niagara.NiagaraEffectType";

		// Token: 0x0401328D RID: 78477
		private static IntPtr _ClassPtr;

		// Token: 0x0401328E RID: 78478
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401328F RID: 78479
		internal static int __PropertyOffset_UpdateFrequency;

		// Token: 0x04013290 RID: 78480
		internal static int __PropertyOffset_CullReaction;

		// Token: 0x04013291 RID: 78481
		internal static int __PropertyOffset_SignificanceHandler;

		// Token: 0x04013292 RID: 78482
		internal static int __PropertyOffset_DetailLevelScalabilitySettings_DEPRECATED;

		// Token: 0x04013293 RID: 78483
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNiagaraSystemScalabilitySettings> _DetailLevelScalabilitySettings_DEPRECATED;

		// Token: 0x04013294 RID: 78484
		internal static int __PropertyOffset_SystemScalabilitySettings;

		// Token: 0x04013295 RID: 78485
		[Nullable(2)]
		private FNiagaraSystemScalabilitySettingsArray _SystemScalabilitySettings;

		// Token: 0x04013296 RID: 78486
		internal static int __PropertyOffset_EmitterScalabilitySettings;

		// Token: 0x04013297 RID: 78487
		[Nullable(2)]
		private FNiagaraEmitterScalabilitySettingsArray _EmitterScalabilitySettings;

		// Token: 0x04013298 RID: 78488
		internal static int __PropertyOffset_SystemSimulationTickSettings;

		// Token: 0x04013299 RID: 78489
		[Nullable(2)]
		private FNiagaraSystemSimulationTickSettingsArray _SystemSimulationTickSettings;
	}
}
