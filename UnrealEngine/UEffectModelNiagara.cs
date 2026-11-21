using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003CA RID: 970
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.EffectModelNiagara")]
	[UnrealStructLayout(2600, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2600)]
	public class UEffectModelNiagara : UEffectModelBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005EAE RID: 24238 RVA: 0x00085FF9 File Offset: 0x000841F9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEffectModelNiagara._ClassPtr;
		}

		// Token: 0x06005EAF RID: 24239 RVA: 0x00086008 File Offset: 0x00084208
		public UEffectModelNiagara() : this(BuiltinUtils.AllocNativeUObject(UEffectModelNiagara.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005EB0 RID: 24240 RVA: 0x00086030 File Offset: 0x00084230
		public UEffectModelNiagara(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEffectModelNiagara.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170012D3 RID: 4819
		// (get) Token: 0x06005EB1 RID: 24241 RVA: 0x00086064 File Offset: 0x00084264
		// (set) Token: 0x06005EB2 RID: 24242 RVA: 0x0008609D File Offset: 0x0008429D
		public FKuroCurveVector Location
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveVector result;
				if ((result = this._Location) == null)
				{
					result = (this._Location = new FKuroCurveVector(base.NativePtr + (IntPtr)UEffectModelNiagara.__PropertyOffset_Location, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveVector.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelNiagara.__PropertyOffset_Location, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170012D4 RID: 4820
		// (get) Token: 0x06005EB3 RID: 24243 RVA: 0x000860C0 File Offset: 0x000842C0
		// (set) Token: 0x06005EB4 RID: 24244 RVA: 0x000860F9 File Offset: 0x000842F9
		public FKuroCurveVector Rotation
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveVector result;
				if ((result = this._Rotation) == null)
				{
					result = (this._Rotation = new FKuroCurveVector(base.NativePtr + (IntPtr)UEffectModelNiagara.__PropertyOffset_Rotation, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveVector.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelNiagara.__PropertyOffset_Rotation, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170012D5 RID: 4821
		// (get) Token: 0x06005EB5 RID: 24245 RVA: 0x0008611C File Offset: 0x0008431C
		// (set) Token: 0x06005EB6 RID: 24246 RVA: 0x00086155 File Offset: 0x00084355
		public FKuroCurveVector Scale
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveVector result;
				if ((result = this._Scale) == null)
				{
					result = (this._Scale = new FKuroCurveVector(base.NativePtr + (IntPtr)UEffectModelNiagara.__PropertyOffset_Scale, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveVector.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelNiagara.__PropertyOffset_Scale, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170012D6 RID: 4822
		// (get) Token: 0x06005EB7 RID: 24247 RVA: 0x00086176 File Offset: 0x00084376
		// (set) Token: 0x06005EB8 RID: 24248 RVA: 0x0008618A File Offset: 0x0008438A
		[Nullable(2)]
		public unsafe UNiagaraSystem NiagaraRef
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelNiagara.__PropertyOffset_NiagaraRef);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelNiagara.__PropertyOffset_NiagaraRef, value);
			}
		}

		// Token: 0x170012D7 RID: 4823
		// (get) Token: 0x06005EB9 RID: 24249 RVA: 0x000861A0 File Offset: 0x000843A0
		// (set) Token: 0x06005EBA RID: 24250 RVA: 0x000861D9 File Offset: 0x000843D9
		public TMap<FName, FKuroCurveFloat> FloatParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKuroCurveFloat> result;
				if ((result = this._FloatParameters) == null)
				{
					result = (this._FloatParameters = new TMap<FName, FKuroCurveFloat>(base.NativePtr + (IntPtr)UEffectModelNiagara.__PropertyOffset_FloatParameters, this));
				}
				return result;
			}
			set
			{
				this.FloatParameters.CopyAssign(value);
			}
		}

		// Token: 0x170012D8 RID: 4824
		// (get) Token: 0x06005EBB RID: 24251 RVA: 0x000861E8 File Offset: 0x000843E8
		// (set) Token: 0x06005EBC RID: 24252 RVA: 0x00086221 File Offset: 0x00084421
		public TMap<FName, FKuroCurveLinearColor> ColorParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKuroCurveLinearColor> result;
				if ((result = this._ColorParameters) == null)
				{
					result = (this._ColorParameters = new TMap<FName, FKuroCurveLinearColor>(base.NativePtr + (IntPtr)UEffectModelNiagara.__PropertyOffset_ColorParameters, this));
				}
				return result;
			}
			set
			{
				this.ColorParameters.CopyAssign(value);
			}
		}

		// Token: 0x170012D9 RID: 4825
		// (get) Token: 0x06005EBD RID: 24253 RVA: 0x00086230 File Offset: 0x00084430
		// (set) Token: 0x06005EBE RID: 24254 RVA: 0x00086269 File Offset: 0x00084469
		public TMap<FName, FKuroCurveVector> VectorParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKuroCurveVector> result;
				if ((result = this._VectorParameters) == null)
				{
					result = (this._VectorParameters = new TMap<FName, FKuroCurveVector>(base.NativePtr + (IntPtr)UEffectModelNiagara.__PropertyOffset_VectorParameters, this));
				}
				return result;
			}
			set
			{
				this.VectorParameters.CopyAssign(value);
			}
		}

		// Token: 0x170012DA RID: 4826
		// (get) Token: 0x06005EBF RID: 24255 RVA: 0x00086278 File Offset: 0x00084478
		// (set) Token: 0x06005EC0 RID: 24256 RVA: 0x000862B1 File Offset: 0x000844B1
		public TMap<FName, UObject> ObjectParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, UObject> result;
				if ((result = this._ObjectParameters) == null)
				{
					result = (this._ObjectParameters = new TMap<FName, UObject>(base.NativePtr + (IntPtr)UEffectModelNiagara.__PropertyOffset_ObjectParameters, this));
				}
				return result;
			}
			set
			{
				this.ObjectParameters.CopyAssign(value);
			}
		}

		// Token: 0x170012DB RID: 4827
		// (get) Token: 0x06005EC1 RID: 24257 RVA: 0x000862BF File Offset: 0x000844BF
		// (set) Token: 0x06005EC2 RID: 24258 RVA: 0x000862CF File Offset: 0x000844CF
		public unsafe bool DeactivateOnStop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelNiagara.__PropertyOffset_DeactivateOnStop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelNiagara.__PropertyOffset_DeactivateOnStop) = (value ? 1 : 0);
			}
		}

		// Token: 0x170012DC RID: 4828
		// (get) Token: 0x06005EC3 RID: 24259 RVA: 0x000862E0 File Offset: 0x000844E0
		// (set) Token: 0x06005EC4 RID: 24260 RVA: 0x000862F0 File Offset: 0x000844F0
		public unsafe bool ReceiveDecal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelNiagara.__PropertyOffset_ReceiveDecal) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelNiagara.__PropertyOffset_ReceiveDecal) = (value ? 1 : 0);
			}
		}

		// Token: 0x170012DD RID: 4829
		// (get) Token: 0x06005EC5 RID: 24261 RVA: 0x00086301 File Offset: 0x00084501
		// (set) Token: 0x06005EC6 RID: 24262 RVA: 0x00086311 File Offset: 0x00084511
		public unsafe int TranslucencySortPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelNiagara.__PropertyOffset_TranslucencySortPriority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelNiagara.__PropertyOffset_TranslucencySortPriority) = value;
			}
		}

		// Token: 0x170012DE RID: 4830
		// (get) Token: 0x06005EC7 RID: 24263 RVA: 0x00086322 File Offset: 0x00084522
		// (set) Token: 0x06005EC8 RID: 24264 RVA: 0x00086332 File Offset: 0x00084532
		public unsafe bool bCastShadow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelNiagara.__PropertyOffset_bCastShadow) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelNiagara.__PropertyOffset_bCastShadow) = (value ? 1 : 0);
			}
		}

		// Token: 0x170012DF RID: 4831
		// (get) Token: 0x06005EC9 RID: 24265 RVA: 0x00086343 File Offset: 0x00084543
		// (set) Token: 0x06005ECA RID: 24266 RVA: 0x00086353 File Offset: 0x00084553
		public unsafe bool bForceCSMShadow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelNiagara.__PropertyOffset_bForceCSMShadow) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelNiagara.__PropertyOffset_bForceCSMShadow) = (value ? 1 : 0);
			}
		}

		// Token: 0x170012E0 RID: 4832
		// (get) Token: 0x06005ECB RID: 24267 RVA: 0x00086364 File Offset: 0x00084564
		// (set) Token: 0x06005ECC RID: 24268 RVA: 0x00086374 File Offset: 0x00084574
		public unsafe bool bForceRenderInBurst
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelNiagara.__PropertyOffset_bForceRenderInBurst) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelNiagara.__PropertyOffset_bForceRenderInBurst) = (value ? 1 : 0);
			}
		}

		// Token: 0x170012E1 RID: 4833
		// (get) Token: 0x06005ECD RID: 24269 RVA: 0x00086385 File Offset: 0x00084585
		// (set) Token: 0x06005ECE RID: 24270 RVA: 0x00086395 File Offset: 0x00084595
		public unsafe bool IgnoreMobileSimulationOptimize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelNiagara.__PropertyOffset_IgnoreMobileSimulationOptimize) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelNiagara.__PropertyOffset_IgnoreMobileSimulationOptimize) = (value ? 1 : 0);
			}
		}

		// Token: 0x170012E2 RID: 4834
		// (get) Token: 0x06005ECF RID: 24271 RVA: 0x000863A8 File Offset: 0x000845A8
		// (set) Token: 0x06005ED0 RID: 24272 RVA: 0x000863E1 File Offset: 0x000845E1
		public FKuroCurveFloat GlobalScale
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._GlobalScale) == null)
				{
					result = (this._GlobalScale = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelNiagara.__PropertyOffset_GlobalScale, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelNiagara.__PropertyOffset_GlobalScale, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170012E3 RID: 4835
		// (get) Token: 0x06005ED1 RID: 24273 RVA: 0x00086404 File Offset: 0x00084604
		// (set) Token: 0x06005ED2 RID: 24274 RVA: 0x0008643D File Offset: 0x0008463D
		public FKuroCurveLinearColor GlobalColor
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._GlobalColor) == null)
				{
					result = (this._GlobalColor = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)UEffectModelNiagara.__PropertyOffset_GlobalColor, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelNiagara.__PropertyOffset_GlobalColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170012E4 RID: 4836
		// (get) Token: 0x06005ED3 RID: 24275 RVA: 0x00086460 File Offset: 0x00084660
		// (set) Token: 0x06005ED4 RID: 24276 RVA: 0x00086499 File Offset: 0x00084699
		public FKuroCurveFloat GlobalAlpha
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._GlobalAlpha) == null)
				{
					result = (this._GlobalAlpha = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelNiagara.__PropertyOffset_GlobalAlpha, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelNiagara.__PropertyOffset_GlobalAlpha, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170012E5 RID: 4837
		// (get) Token: 0x06005ED5 RID: 24277 RVA: 0x000864BA File Offset: 0x000846BA
		// (set) Token: 0x06005ED6 RID: 24278 RVA: 0x000864CA File Offset: 0x000846CA
		public unsafe bool bBodyOpacityUseGlobalAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelNiagara.__PropertyOffset_bBodyOpacityUseGlobalAlpha) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelNiagara.__PropertyOffset_bBodyOpacityUseGlobalAlpha) = (value ? 1 : 0);
			}
		}

		// Token: 0x170012E6 RID: 4838
		// (get) Token: 0x06005ED7 RID: 24279 RVA: 0x000864DB File Offset: 0x000846DB
		// (set) Token: 0x06005ED8 RID: 24280 RVA: 0x000864EB File Offset: 0x000846EB
		public unsafe bool bPointCloudNiagara
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelNiagara.__PropertyOffset_bPointCloudNiagara) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelNiagara.__PropertyOffset_bPointCloudNiagara) = (value ? 1 : 0);
			}
		}

		// Token: 0x170012E7 RID: 4839
		// (get) Token: 0x06005ED9 RID: 24281 RVA: 0x000864FC File Offset: 0x000846FC
		// (set) Token: 0x06005EDA RID: 24282 RVA: 0x0008650C File Offset: 0x0008470C
		public unsafe bool bScreenNiagara
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelNiagara.__PropertyOffset_bScreenNiagara) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelNiagara.__PropertyOffset_bScreenNiagara) = (value ? 1 : 0);
			}
		}

		// Token: 0x06005EDB RID: 24283 RVA: 0x0008651D File Offset: 0x0008471D
		static UEffectModelNiagara()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.EffectModelNiagara");
		}

		// Token: 0x06005EDC RID: 24284 RVA: 0x0008652B File Offset: 0x0008472B
		protected UEffectModelNiagara(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040027A9 RID: 10153
		public new const string __ObjectPath = "/Script/KuroGameplay.EffectModelNiagara";

		// Token: 0x040027AA RID: 10154
		private static IntPtr _ClassPtr;

		// Token: 0x040027AB RID: 10155
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040027AC RID: 10156
		internal static int __PropertyOffset_Location;

		// Token: 0x040027AD RID: 10157
		[Nullable(2)]
		private FKuroCurveVector _Location;

		// Token: 0x040027AE RID: 10158
		internal static int __PropertyOffset_Rotation;

		// Token: 0x040027AF RID: 10159
		[Nullable(2)]
		private FKuroCurveVector _Rotation;

		// Token: 0x040027B0 RID: 10160
		internal static int __PropertyOffset_Scale;

		// Token: 0x040027B1 RID: 10161
		[Nullable(2)]
		private FKuroCurveVector _Scale;

		// Token: 0x040027B2 RID: 10162
		internal static int __PropertyOffset_NiagaraRef;

		// Token: 0x040027B3 RID: 10163
		internal static int __PropertyOffset_FloatParameters;

		// Token: 0x040027B4 RID: 10164
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveFloat> _FloatParameters;

		// Token: 0x040027B5 RID: 10165
		internal static int __PropertyOffset_ColorParameters;

		// Token: 0x040027B6 RID: 10166
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveLinearColor> _ColorParameters;

		// Token: 0x040027B7 RID: 10167
		internal static int __PropertyOffset_VectorParameters;

		// Token: 0x040027B8 RID: 10168
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveVector> _VectorParameters;

		// Token: 0x040027B9 RID: 10169
		internal static int __PropertyOffset_ObjectParameters;

		// Token: 0x040027BA RID: 10170
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UObject> _ObjectParameters;

		// Token: 0x040027BB RID: 10171
		internal static int __PropertyOffset_DeactivateOnStop;

		// Token: 0x040027BC RID: 10172
		internal static int __PropertyOffset_ReceiveDecal;

		// Token: 0x040027BD RID: 10173
		internal static int __PropertyOffset_TranslucencySortPriority;

		// Token: 0x040027BE RID: 10174
		internal static int __PropertyOffset_bCastShadow;

		// Token: 0x040027BF RID: 10175
		internal static int __PropertyOffset_bForceCSMShadow;

		// Token: 0x040027C0 RID: 10176
		internal static int __PropertyOffset_bForceRenderInBurst;

		// Token: 0x040027C1 RID: 10177
		internal static int __PropertyOffset_IgnoreMobileSimulationOptimize;

		// Token: 0x040027C2 RID: 10178
		internal static int __PropertyOffset_GlobalScale;

		// Token: 0x040027C3 RID: 10179
		[Nullable(2)]
		private FKuroCurveFloat _GlobalScale;

		// Token: 0x040027C4 RID: 10180
		internal static int __PropertyOffset_GlobalColor;

		// Token: 0x040027C5 RID: 10181
		[Nullable(2)]
		private FKuroCurveLinearColor _GlobalColor;

		// Token: 0x040027C6 RID: 10182
		internal static int __PropertyOffset_GlobalAlpha;

		// Token: 0x040027C7 RID: 10183
		[Nullable(2)]
		private FKuroCurveFloat _GlobalAlpha;

		// Token: 0x040027C8 RID: 10184
		internal static int __PropertyOffset_bBodyOpacityUseGlobalAlpha;

		// Token: 0x040027C9 RID: 10185
		internal static int __PropertyOffset_bPointCloudNiagara;

		// Token: 0x040027CA RID: 10186
		internal static int __PropertyOffset_bScreenNiagara;
	}
}
