using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018A7 RID: 6311
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.EffectModelNiagara")]
	[UnrealStructLayout(2600, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2600)]
	public class UEffectModelNiagara : UEffectModelBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601740D RID: 95245 RVA: 0x0021EC41 File Offset: 0x0021CE41
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEffectModelNiagara._ClassPtr;
		}

		// Token: 0x0601740E RID: 95246 RVA: 0x0021EC50 File Offset: 0x0021CE50
		public UEffectModelNiagara() : this(BuiltinUtils.AllocNativeUObject(UEffectModelNiagara.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601740F RID: 95247 RVA: 0x0021EC78 File Offset: 0x0021CE78
		public UEffectModelNiagara(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEffectModelNiagara.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005D95 RID: 23957
		// (get) Token: 0x06017410 RID: 95248 RVA: 0x0021ECAC File Offset: 0x0021CEAC
		// (set) Token: 0x06017411 RID: 95249 RVA: 0x0021ECE5 File Offset: 0x0021CEE5
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

		// Token: 0x17005D96 RID: 23958
		// (get) Token: 0x06017412 RID: 95250 RVA: 0x0021ED08 File Offset: 0x0021CF08
		// (set) Token: 0x06017413 RID: 95251 RVA: 0x0021ED41 File Offset: 0x0021CF41
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

		// Token: 0x17005D97 RID: 23959
		// (get) Token: 0x06017414 RID: 95252 RVA: 0x0021ED64 File Offset: 0x0021CF64
		// (set) Token: 0x06017415 RID: 95253 RVA: 0x0021ED9D File Offset: 0x0021CF9D
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

		// Token: 0x17005D98 RID: 23960
		// (get) Token: 0x06017416 RID: 95254 RVA: 0x0021EDBE File Offset: 0x0021CFBE
		// (set) Token: 0x06017417 RID: 95255 RVA: 0x0021EDD2 File Offset: 0x0021CFD2
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

		// Token: 0x17005D99 RID: 23961
		// (get) Token: 0x06017418 RID: 95256 RVA: 0x0021EDE8 File Offset: 0x0021CFE8
		// (set) Token: 0x06017419 RID: 95257 RVA: 0x0021EE21 File Offset: 0x0021D021
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

		// Token: 0x17005D9A RID: 23962
		// (get) Token: 0x0601741A RID: 95258 RVA: 0x0021EE30 File Offset: 0x0021D030
		// (set) Token: 0x0601741B RID: 95259 RVA: 0x0021EE69 File Offset: 0x0021D069
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

		// Token: 0x17005D9B RID: 23963
		// (get) Token: 0x0601741C RID: 95260 RVA: 0x0021EE78 File Offset: 0x0021D078
		// (set) Token: 0x0601741D RID: 95261 RVA: 0x0021EEB1 File Offset: 0x0021D0B1
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

		// Token: 0x17005D9C RID: 23964
		// (get) Token: 0x0601741E RID: 95262 RVA: 0x0021EEC0 File Offset: 0x0021D0C0
		// (set) Token: 0x0601741F RID: 95263 RVA: 0x0021EEF9 File Offset: 0x0021D0F9
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

		// Token: 0x17005D9D RID: 23965
		// (get) Token: 0x06017420 RID: 95264 RVA: 0x0021EF07 File Offset: 0x0021D107
		// (set) Token: 0x06017421 RID: 95265 RVA: 0x0021EF17 File Offset: 0x0021D117
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

		// Token: 0x17005D9E RID: 23966
		// (get) Token: 0x06017422 RID: 95266 RVA: 0x0021EF28 File Offset: 0x0021D128
		// (set) Token: 0x06017423 RID: 95267 RVA: 0x0021EF38 File Offset: 0x0021D138
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

		// Token: 0x17005D9F RID: 23967
		// (get) Token: 0x06017424 RID: 95268 RVA: 0x0021EF49 File Offset: 0x0021D149
		// (set) Token: 0x06017425 RID: 95269 RVA: 0x0021EF59 File Offset: 0x0021D159
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

		// Token: 0x17005DA0 RID: 23968
		// (get) Token: 0x06017426 RID: 95270 RVA: 0x0021EF6C File Offset: 0x0021D16C
		// (set) Token: 0x06017427 RID: 95271 RVA: 0x0021EFA5 File Offset: 0x0021D1A5
		public TArray<FEffectModelNiagaraExtraState> ExtraStates
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FEffectModelNiagaraExtraState> result;
				if ((result = this._ExtraStates) == null)
				{
					result = (this._ExtraStates = new TArray<FEffectModelNiagaraExtraState>(base.NativePtr + (IntPtr)UEffectModelNiagara.__PropertyOffset_ExtraStates, this));
				}
				return result;
			}
			set
			{
				this.ExtraStates.CopyAssign(value);
			}
		}

		// Token: 0x17005DA1 RID: 23969
		// (get) Token: 0x06017428 RID: 95272 RVA: 0x0021EFB3 File Offset: 0x0021D1B3
		// (set) Token: 0x06017429 RID: 95273 RVA: 0x0021EFC3 File Offset: 0x0021D1C3
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

		// Token: 0x17005DA2 RID: 23970
		// (get) Token: 0x0601742A RID: 95274 RVA: 0x0021EFD4 File Offset: 0x0021D1D4
		// (set) Token: 0x0601742B RID: 95275 RVA: 0x0021EFE4 File Offset: 0x0021D1E4
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

		// Token: 0x17005DA3 RID: 23971
		// (get) Token: 0x0601742C RID: 95276 RVA: 0x0021EFF5 File Offset: 0x0021D1F5
		// (set) Token: 0x0601742D RID: 95277 RVA: 0x0021F005 File Offset: 0x0021D205
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

		// Token: 0x17005DA4 RID: 23972
		// (get) Token: 0x0601742E RID: 95278 RVA: 0x0021F018 File Offset: 0x0021D218
		// (set) Token: 0x0601742F RID: 95279 RVA: 0x0021F051 File Offset: 0x0021D251
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

		// Token: 0x17005DA5 RID: 23973
		// (get) Token: 0x06017430 RID: 95280 RVA: 0x0021F074 File Offset: 0x0021D274
		// (set) Token: 0x06017431 RID: 95281 RVA: 0x0021F0AD File Offset: 0x0021D2AD
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

		// Token: 0x17005DA6 RID: 23974
		// (get) Token: 0x06017432 RID: 95282 RVA: 0x0021F0D0 File Offset: 0x0021D2D0
		// (set) Token: 0x06017433 RID: 95283 RVA: 0x0021F109 File Offset: 0x0021D309
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

		// Token: 0x17005DA7 RID: 23975
		// (get) Token: 0x06017434 RID: 95284 RVA: 0x0021F12A File Offset: 0x0021D32A
		// (set) Token: 0x06017435 RID: 95285 RVA: 0x0021F13A File Offset: 0x0021D33A
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

		// Token: 0x17005DA8 RID: 23976
		// (get) Token: 0x06017436 RID: 95286 RVA: 0x0021F14B File Offset: 0x0021D34B
		// (set) Token: 0x06017437 RID: 95287 RVA: 0x0021F15B File Offset: 0x0021D35B
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

		// Token: 0x17005DA9 RID: 23977
		// (get) Token: 0x06017438 RID: 95288 RVA: 0x0021F16C File Offset: 0x0021D36C
		// (set) Token: 0x06017439 RID: 95289 RVA: 0x0021F17C File Offset: 0x0021D37C
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

		// Token: 0x0601743A RID: 95290 RVA: 0x0021F18D File Offset: 0x0021D38D
		static UEffectModelNiagara()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.EffectModelNiagara");
		}

		// Token: 0x0601743B RID: 95291 RVA: 0x0021F19B File Offset: 0x0021D39B
		protected UEffectModelNiagara(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C9E0 RID: 51680
		public new const string __ObjectPath = "/Script/KuroGameplay.EffectModelNiagara";

		// Token: 0x0400C9E1 RID: 51681
		private static IntPtr _ClassPtr;

		// Token: 0x0400C9E2 RID: 51682
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C9E3 RID: 51683
		internal static int __PropertyOffset_Location;

		// Token: 0x0400C9E4 RID: 51684
		[Nullable(2)]
		private FKuroCurveVector _Location;

		// Token: 0x0400C9E5 RID: 51685
		internal static int __PropertyOffset_Rotation;

		// Token: 0x0400C9E6 RID: 51686
		[Nullable(2)]
		private FKuroCurveVector _Rotation;

		// Token: 0x0400C9E7 RID: 51687
		internal static int __PropertyOffset_Scale;

		// Token: 0x0400C9E8 RID: 51688
		[Nullable(2)]
		private FKuroCurveVector _Scale;

		// Token: 0x0400C9E9 RID: 51689
		internal static int __PropertyOffset_NiagaraRef;

		// Token: 0x0400C9EA RID: 51690
		internal static int __PropertyOffset_FloatParameters;

		// Token: 0x0400C9EB RID: 51691
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveFloat> _FloatParameters;

		// Token: 0x0400C9EC RID: 51692
		internal static int __PropertyOffset_ColorParameters;

		// Token: 0x0400C9ED RID: 51693
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveLinearColor> _ColorParameters;

		// Token: 0x0400C9EE RID: 51694
		internal static int __PropertyOffset_VectorParameters;

		// Token: 0x0400C9EF RID: 51695
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveVector> _VectorParameters;

		// Token: 0x0400C9F0 RID: 51696
		internal static int __PropertyOffset_ObjectParameters;

		// Token: 0x0400C9F1 RID: 51697
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UObject> _ObjectParameters;

		// Token: 0x0400C9F2 RID: 51698
		internal static int __PropertyOffset_DeactivateOnStop;

		// Token: 0x0400C9F3 RID: 51699
		internal static int __PropertyOffset_ReceiveDecal;

		// Token: 0x0400C9F4 RID: 51700
		internal static int __PropertyOffset_TranslucencySortPriority;

		// Token: 0x0400C9F5 RID: 51701
		internal static int __PropertyOffset_ExtraStates;

		// Token: 0x0400C9F6 RID: 51702
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FEffectModelNiagaraExtraState> _ExtraStates;

		// Token: 0x0400C9F7 RID: 51703
		internal static int __PropertyOffset_bCastShadow;

		// Token: 0x0400C9F8 RID: 51704
		internal static int __PropertyOffset_bForceRenderInBurst;

		// Token: 0x0400C9F9 RID: 51705
		internal static int __PropertyOffset_IgnoreMobileSimulationOptimize;

		// Token: 0x0400C9FA RID: 51706
		internal static int __PropertyOffset_GlobalScale;

		// Token: 0x0400C9FB RID: 51707
		[Nullable(2)]
		private FKuroCurveFloat _GlobalScale;

		// Token: 0x0400C9FC RID: 51708
		internal static int __PropertyOffset_GlobalColor;

		// Token: 0x0400C9FD RID: 51709
		[Nullable(2)]
		private FKuroCurveLinearColor _GlobalColor;

		// Token: 0x0400C9FE RID: 51710
		internal static int __PropertyOffset_GlobalAlpha;

		// Token: 0x0400C9FF RID: 51711
		[Nullable(2)]
		private FKuroCurveFloat _GlobalAlpha;

		// Token: 0x0400CA00 RID: 51712
		internal static int __PropertyOffset_bBodyOpacityUseGlobalAlpha;

		// Token: 0x0400CA01 RID: 51713
		internal static int __PropertyOffset_bPointCloudNiagara;

		// Token: 0x0400CA02 RID: 51714
		internal static int __PropertyOffset_bScreenNiagara;
	}
}
