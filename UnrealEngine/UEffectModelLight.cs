using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003C6 RID: 966
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.EffectModelLight")]
	[UnrealStructLayout(2104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2104)]
	public class UEffectModelLight : UEffectModelBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005E4C RID: 24140 RVA: 0x000856D2 File Offset: 0x000838D2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEffectModelLight._ClassPtr;
		}

		// Token: 0x06005E4D RID: 24141 RVA: 0x000856E0 File Offset: 0x000838E0
		public UEffectModelLight() : this(BuiltinUtils.AllocNativeUObject(UEffectModelLight.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005E4E RID: 24142 RVA: 0x00085708 File Offset: 0x00083908
		public UEffectModelLight(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEffectModelLight.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170012AC RID: 4780
		// (get) Token: 0x06005E4F RID: 24143 RVA: 0x0008573C File Offset: 0x0008393C
		// (set) Token: 0x06005E50 RID: 24144 RVA: 0x00085775 File Offset: 0x00083975
		public FKuroCurveVector Location
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveVector result;
				if ((result = this._Location) == null)
				{
					result = (this._Location = new FKuroCurveVector(base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_Location, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveVector.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_Location, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170012AD RID: 4781
		// (get) Token: 0x06005E51 RID: 24145 RVA: 0x00085798 File Offset: 0x00083998
		// (set) Token: 0x06005E52 RID: 24146 RVA: 0x000857D1 File Offset: 0x000839D1
		public FKuroCurveFloat Intensity
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._Intensity) == null)
				{
					result = (this._Intensity = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_Intensity, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_Intensity, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170012AE RID: 4782
		// (get) Token: 0x06005E53 RID: 24147 RVA: 0x000857F4 File Offset: 0x000839F4
		// (set) Token: 0x06005E54 RID: 24148 RVA: 0x0008582D File Offset: 0x00083A2D
		public FKuroCurveLinearColor Color
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._Color) == null)
				{
					result = (this._Color = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_Color, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_Color, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170012AF RID: 4783
		// (get) Token: 0x06005E55 RID: 24149 RVA: 0x00085850 File Offset: 0x00083A50
		// (set) Token: 0x06005E56 RID: 24150 RVA: 0x00085889 File Offset: 0x00083A89
		public FKuroCurveFloat Radius
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._Radius) == null)
				{
					result = (this._Radius = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_Radius, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_Radius, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170012B0 RID: 4784
		// (get) Token: 0x06005E57 RID: 24151 RVA: 0x000858AC File Offset: 0x00083AAC
		// (set) Token: 0x06005E58 RID: 24152 RVA: 0x000858E5 File Offset: 0x00083AE5
		public FKuroCurveFloat FalloffExponent
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._FalloffExponent) == null)
				{
					result = (this._FalloffExponent = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_FalloffExponent, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_FalloffExponent, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170012B1 RID: 4785
		// (get) Token: 0x06005E59 RID: 24153 RVA: 0x00085906 File Offset: 0x00083B06
		// (set) Token: 0x06005E5A RID: 24154 RVA: 0x00085916 File Offset: 0x00083B16
		public unsafe bool bUseSpotLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_bUseSpotLight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_bUseSpotLight) = (value ? 1 : 0);
			}
		}

		// Token: 0x170012B2 RID: 4786
		// (get) Token: 0x06005E5B RID: 24155 RVA: 0x00085928 File Offset: 0x00083B28
		// (set) Token: 0x06005E5C RID: 24156 RVA: 0x00085961 File Offset: 0x00083B61
		public FKuroCurveFloat InnerConeAngle
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._InnerConeAngle) == null)
				{
					result = (this._InnerConeAngle = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_InnerConeAngle, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_InnerConeAngle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170012B3 RID: 4787
		// (get) Token: 0x06005E5D RID: 24157 RVA: 0x00085984 File Offset: 0x00083B84
		// (set) Token: 0x06005E5E RID: 24158 RVA: 0x000859BD File Offset: 0x00083BBD
		public FKuroCurveFloat OuterConeAngle
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._OuterConeAngle) == null)
				{
					result = (this._OuterConeAngle = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_OuterConeAngle, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_OuterConeAngle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170012B4 RID: 4788
		// (get) Token: 0x06005E5F RID: 24159 RVA: 0x000859DE File Offset: 0x00083BDE
		// (set) Token: 0x06005E60 RID: 24160 RVA: 0x000859EE File Offset: 0x00083BEE
		public unsafe bool bUseAsVolumetricLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_bUseAsVolumetricLight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_bUseAsVolumetricLight) = (value ? 1 : 0);
			}
		}

		// Token: 0x170012B5 RID: 4789
		// (get) Token: 0x06005E61 RID: 24161 RVA: 0x000859FF File Offset: 0x00083BFF
		// (set) Token: 0x06005E62 RID: 24162 RVA: 0x00085A13 File Offset: 0x00083C13
		[Nullable(0)]
		public unsafe TEnumAsByte<ELightQualityType> LightQualityType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_LightQualityType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_LightQualityType) = value;
			}
		}

		// Token: 0x170012B6 RID: 4790
		// (get) Token: 0x06005E63 RID: 24163 RVA: 0x00085A28 File Offset: 0x00083C28
		// (set) Token: 0x06005E64 RID: 24164 RVA: 0x00085A38 File Offset: 0x00083C38
		public unsafe float SourceRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_SourceRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_SourceRadius) = value;
			}
		}

		// Token: 0x170012B7 RID: 4791
		// (get) Token: 0x06005E65 RID: 24165 RVA: 0x00085A49 File Offset: 0x00083C49
		// (set) Token: 0x06005E66 RID: 24166 RVA: 0x00085A59 File Offset: 0x00083C59
		public unsafe float SoftSourceRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_SoftSourceRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_SoftSourceRadius) = value;
			}
		}

		// Token: 0x170012B8 RID: 4792
		// (get) Token: 0x06005E67 RID: 24167 RVA: 0x00085A6A File Offset: 0x00083C6A
		// (set) Token: 0x06005E68 RID: 24168 RVA: 0x00085A7A File Offset: 0x00083C7A
		public unsafe float SourceLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_SourceLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_SourceLength) = value;
			}
		}

		// Token: 0x170012B9 RID: 4793
		// (get) Token: 0x06005E69 RID: 24169 RVA: 0x00085A8B File Offset: 0x00083C8B
		// (set) Token: 0x06005E6A RID: 24170 RVA: 0x00085A9B File Offset: 0x00083C9B
		public unsafe bool AllowAnyRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_AllowAnyRadius) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_AllowAnyRadius) = (value ? 1 : 0);
			}
		}

		// Token: 0x170012BA RID: 4794
		// (get) Token: 0x06005E6B RID: 24171 RVA: 0x00085AAC File Offset: 0x00083CAC
		// (set) Token: 0x06005E6C RID: 24172 RVA: 0x00085AE5 File Offset: 0x00083CE5
		public FKuroCurveFloat CharacterLightAlpha
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._CharacterLightAlpha) == null)
				{
					result = (this._CharacterLightAlpha = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_CharacterLightAlpha, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_CharacterLightAlpha, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170012BB RID: 4795
		// (get) Token: 0x06005E6D RID: 24173 RVA: 0x00085B06 File Offset: 0x00083D06
		// (set) Token: 0x06005E6E RID: 24174 RVA: 0x00085B16 File Offset: 0x00083D16
		public unsafe float CharacterFalloffExponent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_CharacterFalloffExponent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_CharacterFalloffExponent) = value;
			}
		}

		// Token: 0x170012BC RID: 4796
		// (get) Token: 0x06005E6F RID: 24175 RVA: 0x00085B27 File Offset: 0x00083D27
		// (set) Token: 0x06005E70 RID: 24176 RVA: 0x00085B37 File Offset: 0x00083D37
		public unsafe float CharacterBlendAtten
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_CharacterBlendAtten);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_CharacterBlendAtten) = value;
			}
		}

		// Token: 0x170012BD RID: 4797
		// (get) Token: 0x06005E71 RID: 24177 RVA: 0x00085B48 File Offset: 0x00083D48
		// (set) Token: 0x06005E72 RID: 24178 RVA: 0x00085B58 File Offset: 0x00083D58
		public unsafe float CharacterBlendIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_CharacterBlendIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_CharacterBlendIntensity) = value;
			}
		}

		// Token: 0x170012BE RID: 4798
		// (get) Token: 0x06005E73 RID: 24179 RVA: 0x00085B69 File Offset: 0x00083D69
		// (set) Token: 0x06005E74 RID: 24180 RVA: 0x00085B79 File Offset: 0x00083D79
		public unsafe int CharacterPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_CharacterPriority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_CharacterPriority) = value;
			}
		}

		// Token: 0x170012BF RID: 4799
		// (get) Token: 0x06005E75 RID: 24181 RVA: 0x00085B8A File Offset: 0x00083D8A
		// (set) Token: 0x06005E76 RID: 24182 RVA: 0x00085B9A File Offset: 0x00083D9A
		public unsafe float CharacterIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_CharacterIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_CharacterIntensity) = value;
			}
		}

		// Token: 0x170012C0 RID: 4800
		// (get) Token: 0x06005E77 RID: 24183 RVA: 0x00085BAB File Offset: 0x00083DAB
		// (set) Token: 0x06005E78 RID: 24184 RVA: 0x00085BBF File Offset: 0x00083DBF
		public unsafe FLinearColor CharacterColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_CharacterColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_CharacterColor) = value;
			}
		}

		// Token: 0x170012C1 RID: 4801
		// (get) Token: 0x06005E79 RID: 24185 RVA: 0x00085BD4 File Offset: 0x00083DD4
		// (set) Token: 0x06005E7A RID: 24186 RVA: 0x00085BE4 File Offset: 0x00083DE4
		public unsafe float CharacterShadowIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_CharacterShadowIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_CharacterShadowIntensity) = value;
			}
		}

		// Token: 0x170012C2 RID: 4802
		// (get) Token: 0x06005E7B RID: 24187 RVA: 0x00085BF5 File Offset: 0x00083DF5
		// (set) Token: 0x06005E7C RID: 24188 RVA: 0x00085C05 File Offset: 0x00083E05
		public unsafe float CharacterRealTimeShadowIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_CharacterRealTimeShadowIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_CharacterRealTimeShadowIntensity) = value;
			}
		}

		// Token: 0x170012C3 RID: 4803
		// (get) Token: 0x06005E7D RID: 24189 RVA: 0x00085C16 File Offset: 0x00083E16
		// (set) Token: 0x06005E7E RID: 24190 RVA: 0x00085C26 File Offset: 0x00083E26
		public unsafe float CharacterDesaturationIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_CharacterDesaturationIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_CharacterDesaturationIntensity) = value;
			}
		}

		// Token: 0x170012C4 RID: 4804
		// (get) Token: 0x06005E7F RID: 24191 RVA: 0x00085C37 File Offset: 0x00083E37
		// (set) Token: 0x06005E80 RID: 24192 RVA: 0x00085C47 File Offset: 0x00083E47
		public unsafe float CharacterHardIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_CharacterHardIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_CharacterHardIntensity) = value;
			}
		}

		// Token: 0x170012C5 RID: 4805
		// (get) Token: 0x06005E81 RID: 24193 RVA: 0x00085C58 File Offset: 0x00083E58
		// (set) Token: 0x06005E82 RID: 24194 RVA: 0x00085C6C File Offset: 0x00083E6C
		public unsafe FLinearColor CharacterHardColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_CharacterHardColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_CharacterHardColor) = value;
			}
		}

		// Token: 0x170012C6 RID: 4806
		// (get) Token: 0x06005E83 RID: 24195 RVA: 0x00085C81 File Offset: 0x00083E81
		// (set) Token: 0x06005E84 RID: 24196 RVA: 0x00085C95 File Offset: 0x00083E95
		public unsafe FLinearColor CharacterHardShadowColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_CharacterHardShadowColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_CharacterHardShadowColor) = value;
			}
		}

		// Token: 0x170012C7 RID: 4807
		// (get) Token: 0x06005E85 RID: 24197 RVA: 0x00085CAA File Offset: 0x00083EAA
		// (set) Token: 0x06005E86 RID: 24198 RVA: 0x00085CBA File Offset: 0x00083EBA
		public unsafe float CharacterHardBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_CharacterHardBlend);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_CharacterHardBlend) = value;
			}
		}

		// Token: 0x170012C8 RID: 4808
		// (get) Token: 0x06005E87 RID: 24199 RVA: 0x00085CCB File Offset: 0x00083ECB
		// (set) Token: 0x06005E88 RID: 24200 RVA: 0x00085CDB File Offset: 0x00083EDB
		public unsafe bool bCastShadowPc
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_bCastShadowPc) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_bCastShadowPc) = (value ? 1 : 0);
			}
		}

		// Token: 0x170012C9 RID: 4809
		// (get) Token: 0x06005E89 RID: 24201 RVA: 0x00085CEC File Offset: 0x00083EEC
		// (set) Token: 0x06005E8A RID: 24202 RVA: 0x00085D00 File Offset: 0x00083F00
		public unsafe FName DriveEffectByWeatherCustomDataName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_DriveEffectByWeatherCustomDataName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_DriveEffectByWeatherCustomDataName) = value;
			}
		}

		// Token: 0x06005E8B RID: 24203 RVA: 0x00085D15 File Offset: 0x00083F15
		static UEffectModelLight()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.EffectModelLight");
		}

		// Token: 0x06005E8C RID: 24204 RVA: 0x00085D23 File Offset: 0x00083F23
		protected UEffectModelLight(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400276E RID: 10094
		public new const string __ObjectPath = "/Script/KuroGameplay.EffectModelLight";

		// Token: 0x0400276F RID: 10095
		private static IntPtr _ClassPtr;

		// Token: 0x04002770 RID: 10096
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002771 RID: 10097
		internal static int __PropertyOffset_Location;

		// Token: 0x04002772 RID: 10098
		[Nullable(2)]
		private FKuroCurveVector _Location;

		// Token: 0x04002773 RID: 10099
		internal static int __PropertyOffset_Intensity;

		// Token: 0x04002774 RID: 10100
		[Nullable(2)]
		private FKuroCurveFloat _Intensity;

		// Token: 0x04002775 RID: 10101
		internal static int __PropertyOffset_Color;

		// Token: 0x04002776 RID: 10102
		[Nullable(2)]
		private FKuroCurveLinearColor _Color;

		// Token: 0x04002777 RID: 10103
		internal static int __PropertyOffset_Radius;

		// Token: 0x04002778 RID: 10104
		[Nullable(2)]
		private FKuroCurveFloat _Radius;

		// Token: 0x04002779 RID: 10105
		internal static int __PropertyOffset_FalloffExponent;

		// Token: 0x0400277A RID: 10106
		[Nullable(2)]
		private FKuroCurveFloat _FalloffExponent;

		// Token: 0x0400277B RID: 10107
		internal static int __PropertyOffset_bUseSpotLight;

		// Token: 0x0400277C RID: 10108
		internal static int __PropertyOffset_InnerConeAngle;

		// Token: 0x0400277D RID: 10109
		[Nullable(2)]
		private FKuroCurveFloat _InnerConeAngle;

		// Token: 0x0400277E RID: 10110
		internal static int __PropertyOffset_OuterConeAngle;

		// Token: 0x0400277F RID: 10111
		[Nullable(2)]
		private FKuroCurveFloat _OuterConeAngle;

		// Token: 0x04002780 RID: 10112
		internal static int __PropertyOffset_bUseAsVolumetricLight;

		// Token: 0x04002781 RID: 10113
		internal static int __PropertyOffset_LightQualityType;

		// Token: 0x04002782 RID: 10114
		internal static int __PropertyOffset_SourceRadius;

		// Token: 0x04002783 RID: 10115
		internal static int __PropertyOffset_SoftSourceRadius;

		// Token: 0x04002784 RID: 10116
		internal static int __PropertyOffset_SourceLength;

		// Token: 0x04002785 RID: 10117
		internal static int __PropertyOffset_AllowAnyRadius;

		// Token: 0x04002786 RID: 10118
		internal static int __PropertyOffset_CharacterLightAlpha;

		// Token: 0x04002787 RID: 10119
		[Nullable(2)]
		private FKuroCurveFloat _CharacterLightAlpha;

		// Token: 0x04002788 RID: 10120
		internal static int __PropertyOffset_CharacterFalloffExponent;

		// Token: 0x04002789 RID: 10121
		internal static int __PropertyOffset_CharacterBlendAtten;

		// Token: 0x0400278A RID: 10122
		internal static int __PropertyOffset_CharacterBlendIntensity;

		// Token: 0x0400278B RID: 10123
		internal static int __PropertyOffset_CharacterPriority;

		// Token: 0x0400278C RID: 10124
		internal static int __PropertyOffset_CharacterIntensity;

		// Token: 0x0400278D RID: 10125
		internal static int __PropertyOffset_CharacterColor;

		// Token: 0x0400278E RID: 10126
		internal static int __PropertyOffset_CharacterShadowIntensity;

		// Token: 0x0400278F RID: 10127
		internal static int __PropertyOffset_CharacterRealTimeShadowIntensity;

		// Token: 0x04002790 RID: 10128
		internal static int __PropertyOffset_CharacterDesaturationIntensity;

		// Token: 0x04002791 RID: 10129
		internal static int __PropertyOffset_CharacterHardIntensity;

		// Token: 0x04002792 RID: 10130
		internal static int __PropertyOffset_CharacterHardColor;

		// Token: 0x04002793 RID: 10131
		internal static int __PropertyOffset_CharacterHardShadowColor;

		// Token: 0x04002794 RID: 10132
		internal static int __PropertyOffset_CharacterHardBlend;

		// Token: 0x04002795 RID: 10133
		internal static int __PropertyOffset_bCastShadowPc;

		// Token: 0x04002796 RID: 10134
		internal static int __PropertyOffset_DriveEffectByWeatherCustomDataName;
	}
}
