using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020025B6 RID: 9654
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraLightRendererProperties")]
	[UnrealStructLayout(1832, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1832)]
	public class UNiagaraLightRendererProperties : UNiagaraRendererProperties, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023DFC RID: 146940 RVA: 0x00350AD1 File Offset: 0x0034ECD1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraLightRendererProperties._ClassPtr;
		}

		// Token: 0x06023DFD RID: 146941 RVA: 0x00350AE0 File Offset: 0x0034ECE0
		public UNiagaraLightRendererProperties() : this(BuiltinUtils.AllocNativeUObject(UNiagaraLightRendererProperties.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023DFE RID: 146942 RVA: 0x00350B08 File Offset: 0x0034ED08
		public UNiagaraLightRendererProperties(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraLightRendererProperties.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170089EB RID: 35307
		// (get) Token: 0x06023DFF RID: 146943 RVA: 0x00350B3B File Offset: 0x0034ED3B
		// (set) Token: 0x06023E00 RID: 146944 RVA: 0x00350B54 File Offset: 0x0034ED54
		public unsafe bool bUseInverseSquaredFalloff
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraLightRendererProperties.__PropertyOffset_bUseInverseSquaredFalloff) & UNiagaraLightRendererProperties.__PropertyMask_bUseInverseSquaredFalloff) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraLightRendererProperties.__PropertyOffset_bUseInverseSquaredFalloff) = ((*(base.NativePtr + (IntPtr)UNiagaraLightRendererProperties.__PropertyOffset_bUseInverseSquaredFalloff) & ~UNiagaraLightRendererProperties.__PropertyMask_bUseInverseSquaredFalloff) | (value ? UNiagaraLightRendererProperties.__PropertyMask_bUseInverseSquaredFalloff : 0));
			}
		}

		// Token: 0x170089EC RID: 35308
		// (get) Token: 0x06023E01 RID: 146945 RVA: 0x00350B84 File Offset: 0x0034ED84
		// (set) Token: 0x06023E02 RID: 146946 RVA: 0x00350B9D File Offset: 0x0034ED9D
		public unsafe bool bAffectsTranslucency
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraLightRendererProperties.__PropertyOffset_bAffectsTranslucency) & UNiagaraLightRendererProperties.__PropertyMask_bAffectsTranslucency) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraLightRendererProperties.__PropertyOffset_bAffectsTranslucency) = ((*(base.NativePtr + (IntPtr)UNiagaraLightRendererProperties.__PropertyOffset_bAffectsTranslucency) & ~UNiagaraLightRendererProperties.__PropertyMask_bAffectsTranslucency) | (value ? UNiagaraLightRendererProperties.__PropertyMask_bAffectsTranslucency : 0));
			}
		}

		// Token: 0x170089ED RID: 35309
		// (get) Token: 0x06023E03 RID: 146947 RVA: 0x00350BCD File Offset: 0x0034EDCD
		// (set) Token: 0x06023E04 RID: 146948 RVA: 0x00350BDD File Offset: 0x0034EDDD
		public unsafe float RadiusScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraLightRendererProperties.__PropertyOffset_RadiusScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraLightRendererProperties.__PropertyOffset_RadiusScale) = value;
			}
		}

		// Token: 0x170089EE RID: 35310
		// (get) Token: 0x06023E05 RID: 146949 RVA: 0x00350BEE File Offset: 0x0034EDEE
		// (set) Token: 0x06023E06 RID: 146950 RVA: 0x00350C02 File Offset: 0x0034EE02
		public unsafe FVector ColorAdd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraLightRendererProperties.__PropertyOffset_ColorAdd);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraLightRendererProperties.__PropertyOffset_ColorAdd) = value;
			}
		}

		// Token: 0x170089EF RID: 35311
		// (get) Token: 0x06023E07 RID: 146951 RVA: 0x00350C18 File Offset: 0x0034EE18
		// (set) Token: 0x06023E08 RID: 146952 RVA: 0x00350C51 File Offset: 0x0034EE51
		public FNiagaraVariableAttributeBinding LightRenderingEnabledBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._LightRenderingEnabledBinding) == null)
				{
					result = (this._LightRenderingEnabledBinding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraLightRendererProperties.__PropertyOffset_LightRenderingEnabledBinding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraLightRendererProperties.__PropertyOffset_LightRenderingEnabledBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170089F0 RID: 35312
		// (get) Token: 0x06023E09 RID: 146953 RVA: 0x00350C74 File Offset: 0x0034EE74
		// (set) Token: 0x06023E0A RID: 146954 RVA: 0x00350CAD File Offset: 0x0034EEAD
		public FNiagaraVariableAttributeBinding LightExponentBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._LightExponentBinding) == null)
				{
					result = (this._LightExponentBinding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraLightRendererProperties.__PropertyOffset_LightExponentBinding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraLightRendererProperties.__PropertyOffset_LightExponentBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170089F1 RID: 35313
		// (get) Token: 0x06023E0B RID: 146955 RVA: 0x00350CD0 File Offset: 0x0034EED0
		// (set) Token: 0x06023E0C RID: 146956 RVA: 0x00350D09 File Offset: 0x0034EF09
		public FNiagaraVariableAttributeBinding PositionBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._PositionBinding) == null)
				{
					result = (this._PositionBinding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraLightRendererProperties.__PropertyOffset_PositionBinding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraLightRendererProperties.__PropertyOffset_PositionBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170089F2 RID: 35314
		// (get) Token: 0x06023E0D RID: 146957 RVA: 0x00350D2C File Offset: 0x0034EF2C
		// (set) Token: 0x06023E0E RID: 146958 RVA: 0x00350D65 File Offset: 0x0034EF65
		public FNiagaraVariableAttributeBinding ColorBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._ColorBinding) == null)
				{
					result = (this._ColorBinding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraLightRendererProperties.__PropertyOffset_ColorBinding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraLightRendererProperties.__PropertyOffset_ColorBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170089F3 RID: 35315
		// (get) Token: 0x06023E0F RID: 146959 RVA: 0x00350D88 File Offset: 0x0034EF88
		// (set) Token: 0x06023E10 RID: 146960 RVA: 0x00350DC1 File Offset: 0x0034EFC1
		public FNiagaraVariableAttributeBinding RadiusBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._RadiusBinding) == null)
				{
					result = (this._RadiusBinding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraLightRendererProperties.__PropertyOffset_RadiusBinding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraLightRendererProperties.__PropertyOffset_RadiusBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170089F4 RID: 35316
		// (get) Token: 0x06023E11 RID: 146961 RVA: 0x00350DE4 File Offset: 0x0034EFE4
		// (set) Token: 0x06023E12 RID: 146962 RVA: 0x00350E1D File Offset: 0x0034F01D
		public FNiagaraVariableAttributeBinding VolumetricScatteringBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._VolumetricScatteringBinding) == null)
				{
					result = (this._VolumetricScatteringBinding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraLightRendererProperties.__PropertyOffset_VolumetricScatteringBinding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraLightRendererProperties.__PropertyOffset_VolumetricScatteringBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06023E13 RID: 146963 RVA: 0x00350E3E File Offset: 0x0034F03E
		static UNiagaraLightRendererProperties()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraLightRendererProperties");
		}

		// Token: 0x06023E14 RID: 146964 RVA: 0x00350E4C File Offset: 0x0034F04C
		protected UNiagaraLightRendererProperties(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040133BB RID: 78779
		public new const string __ObjectPath = "/Script/Niagara.NiagaraLightRendererProperties";

		// Token: 0x040133BC RID: 78780
		private static IntPtr _ClassPtr;

		// Token: 0x040133BD RID: 78781
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040133BE RID: 78782
		internal static int __PropertyOffset_bUseInverseSquaredFalloff;

		// Token: 0x040133BF RID: 78783
		internal static byte __PropertyMask_bUseInverseSquaredFalloff;

		// Token: 0x040133C0 RID: 78784
		internal static int __PropertyOffset_bAffectsTranslucency;

		// Token: 0x040133C1 RID: 78785
		internal static byte __PropertyMask_bAffectsTranslucency;

		// Token: 0x040133C2 RID: 78786
		internal static int __PropertyOffset_RadiusScale;

		// Token: 0x040133C3 RID: 78787
		internal static int __PropertyOffset_ColorAdd;

		// Token: 0x040133C4 RID: 78788
		internal static int __PropertyOffset_LightRenderingEnabledBinding;

		// Token: 0x040133C5 RID: 78789
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _LightRenderingEnabledBinding;

		// Token: 0x040133C6 RID: 78790
		internal static int __PropertyOffset_LightExponentBinding;

		// Token: 0x040133C7 RID: 78791
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _LightExponentBinding;

		// Token: 0x040133C8 RID: 78792
		internal static int __PropertyOffset_PositionBinding;

		// Token: 0x040133C9 RID: 78793
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _PositionBinding;

		// Token: 0x040133CA RID: 78794
		internal static int __PropertyOffset_ColorBinding;

		// Token: 0x040133CB RID: 78795
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _ColorBinding;

		// Token: 0x040133CC RID: 78796
		internal static int __PropertyOffset_RadiusBinding;

		// Token: 0x040133CD RID: 78797
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _RadiusBinding;

		// Token: 0x040133CE RID: 78798
		internal static int __PropertyOffset_VolumetricScatteringBinding;

		// Token: 0x040133CF RID: 78799
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _VolumetricScatteringBinding;
	}
}
