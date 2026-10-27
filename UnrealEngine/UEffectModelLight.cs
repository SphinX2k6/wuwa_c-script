using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018A3 RID: 6307
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.EffectModelLight")]
	[UnrealStructLayout(2104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2104)]
	public class UEffectModelLight : UEffectModelBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060173A7 RID: 95143 RVA: 0x0021E2CE File Offset: 0x0021C4CE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEffectModelLight._ClassPtr;
		}

		// Token: 0x060173A8 RID: 95144 RVA: 0x0021E2DC File Offset: 0x0021C4DC
		public UEffectModelLight() : this(BuiltinUtils.AllocNativeUObject(UEffectModelLight.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060173A9 RID: 95145 RVA: 0x0021E304 File Offset: 0x0021C504
		public UEffectModelLight(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEffectModelLight.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005D6C RID: 23916
		// (get) Token: 0x060173AA RID: 95146 RVA: 0x0021E338 File Offset: 0x0021C538
		// (set) Token: 0x060173AB RID: 95147 RVA: 0x0021E371 File Offset: 0x0021C571
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

		// Token: 0x17005D6D RID: 23917
		// (get) Token: 0x060173AC RID: 95148 RVA: 0x0021E394 File Offset: 0x0021C594
		// (set) Token: 0x060173AD RID: 95149 RVA: 0x0021E3CD File Offset: 0x0021C5CD
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

		// Token: 0x17005D6E RID: 23918
		// (get) Token: 0x060173AE RID: 95150 RVA: 0x0021E3F0 File Offset: 0x0021C5F0
		// (set) Token: 0x060173AF RID: 95151 RVA: 0x0021E429 File Offset: 0x0021C629
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

		// Token: 0x17005D6F RID: 23919
		// (get) Token: 0x060173B0 RID: 95152 RVA: 0x0021E44C File Offset: 0x0021C64C
		// (set) Token: 0x060173B1 RID: 95153 RVA: 0x0021E485 File Offset: 0x0021C685
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

		// Token: 0x17005D70 RID: 23920
		// (get) Token: 0x060173B2 RID: 95154 RVA: 0x0021E4A8 File Offset: 0x0021C6A8
		// (set) Token: 0x060173B3 RID: 95155 RVA: 0x0021E4E1 File Offset: 0x0021C6E1
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

		// Token: 0x17005D71 RID: 23921
		// (get) Token: 0x060173B4 RID: 95156 RVA: 0x0021E502 File Offset: 0x0021C702
		// (set) Token: 0x060173B5 RID: 95157 RVA: 0x0021E512 File Offset: 0x0021C712
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

		// Token: 0x17005D72 RID: 23922
		// (get) Token: 0x060173B6 RID: 95158 RVA: 0x0021E524 File Offset: 0x0021C724
		// (set) Token: 0x060173B7 RID: 95159 RVA: 0x0021E55D File Offset: 0x0021C75D
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

		// Token: 0x17005D73 RID: 23923
		// (get) Token: 0x060173B8 RID: 95160 RVA: 0x0021E580 File Offset: 0x0021C780
		// (set) Token: 0x060173B9 RID: 95161 RVA: 0x0021E5B9 File Offset: 0x0021C7B9
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

		// Token: 0x17005D74 RID: 23924
		// (get) Token: 0x060173BA RID: 95162 RVA: 0x0021E5DA File Offset: 0x0021C7DA
		// (set) Token: 0x060173BB RID: 95163 RVA: 0x0021E5EA File Offset: 0x0021C7EA
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

		// Token: 0x17005D75 RID: 23925
		// (get) Token: 0x060173BC RID: 95164 RVA: 0x0021E5FB File Offset: 0x0021C7FB
		// (set) Token: 0x060173BD RID: 95165 RVA: 0x0021E60F File Offset: 0x0021C80F
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

		// Token: 0x17005D76 RID: 23926
		// (get) Token: 0x060173BE RID: 95166 RVA: 0x0021E624 File Offset: 0x0021C824
		// (set) Token: 0x060173BF RID: 95167 RVA: 0x0021E634 File Offset: 0x0021C834
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

		// Token: 0x17005D77 RID: 23927
		// (get) Token: 0x060173C0 RID: 95168 RVA: 0x0021E645 File Offset: 0x0021C845
		// (set) Token: 0x060173C1 RID: 95169 RVA: 0x0021E655 File Offset: 0x0021C855
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

		// Token: 0x17005D78 RID: 23928
		// (get) Token: 0x060173C2 RID: 95170 RVA: 0x0021E666 File Offset: 0x0021C866
		// (set) Token: 0x060173C3 RID: 95171 RVA: 0x0021E676 File Offset: 0x0021C876
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

		// Token: 0x17005D79 RID: 23929
		// (get) Token: 0x060173C4 RID: 95172 RVA: 0x0021E687 File Offset: 0x0021C887
		// (set) Token: 0x060173C5 RID: 95173 RVA: 0x0021E697 File Offset: 0x0021C897
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

		// Token: 0x17005D7A RID: 23930
		// (get) Token: 0x060173C6 RID: 95174 RVA: 0x0021E6A8 File Offset: 0x0021C8A8
		// (set) Token: 0x060173C7 RID: 95175 RVA: 0x0021E6E1 File Offset: 0x0021C8E1
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

		// Token: 0x17005D7B RID: 23931
		// (get) Token: 0x060173C8 RID: 95176 RVA: 0x0021E702 File Offset: 0x0021C902
		// (set) Token: 0x060173C9 RID: 95177 RVA: 0x0021E712 File Offset: 0x0021C912
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

		// Token: 0x17005D7C RID: 23932
		// (get) Token: 0x060173CA RID: 95178 RVA: 0x0021E723 File Offset: 0x0021C923
		// (set) Token: 0x060173CB RID: 95179 RVA: 0x0021E733 File Offset: 0x0021C933
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

		// Token: 0x17005D7D RID: 23933
		// (get) Token: 0x060173CC RID: 95180 RVA: 0x0021E744 File Offset: 0x0021C944
		// (set) Token: 0x060173CD RID: 95181 RVA: 0x0021E754 File Offset: 0x0021C954
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

		// Token: 0x17005D7E RID: 23934
		// (get) Token: 0x060173CE RID: 95182 RVA: 0x0021E765 File Offset: 0x0021C965
		// (set) Token: 0x060173CF RID: 95183 RVA: 0x0021E779 File Offset: 0x0021C979
		[Nullable(0)]
		public unsafe TEnumAsByte<EToonLightType> ToonLightType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_ToonLightType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelLight.__PropertyOffset_ToonLightType) = value;
			}
		}

		// Token: 0x17005D7F RID: 23935
		// (get) Token: 0x060173D0 RID: 95184 RVA: 0x0021E78E File Offset: 0x0021C98E
		// (set) Token: 0x060173D1 RID: 95185 RVA: 0x0021E79E File Offset: 0x0021C99E
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

		// Token: 0x17005D80 RID: 23936
		// (get) Token: 0x060173D2 RID: 95186 RVA: 0x0021E7AF File Offset: 0x0021C9AF
		// (set) Token: 0x060173D3 RID: 95187 RVA: 0x0021E7BF File Offset: 0x0021C9BF
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

		// Token: 0x17005D81 RID: 23937
		// (get) Token: 0x060173D4 RID: 95188 RVA: 0x0021E7D0 File Offset: 0x0021C9D0
		// (set) Token: 0x060173D5 RID: 95189 RVA: 0x0021E7E4 File Offset: 0x0021C9E4
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

		// Token: 0x17005D82 RID: 23938
		// (get) Token: 0x060173D6 RID: 95190 RVA: 0x0021E7F9 File Offset: 0x0021C9F9
		// (set) Token: 0x060173D7 RID: 95191 RVA: 0x0021E809 File Offset: 0x0021CA09
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

		// Token: 0x17005D83 RID: 23939
		// (get) Token: 0x060173D8 RID: 95192 RVA: 0x0021E81A File Offset: 0x0021CA1A
		// (set) Token: 0x060173D9 RID: 95193 RVA: 0x0021E82A File Offset: 0x0021CA2A
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

		// Token: 0x17005D84 RID: 23940
		// (get) Token: 0x060173DA RID: 95194 RVA: 0x0021E83B File Offset: 0x0021CA3B
		// (set) Token: 0x060173DB RID: 95195 RVA: 0x0021E84B File Offset: 0x0021CA4B
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

		// Token: 0x17005D85 RID: 23941
		// (get) Token: 0x060173DC RID: 95196 RVA: 0x0021E85C File Offset: 0x0021CA5C
		// (set) Token: 0x060173DD RID: 95197 RVA: 0x0021E86C File Offset: 0x0021CA6C
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

		// Token: 0x17005D86 RID: 23942
		// (get) Token: 0x060173DE RID: 95198 RVA: 0x0021E87D File Offset: 0x0021CA7D
		// (set) Token: 0x060173DF RID: 95199 RVA: 0x0021E891 File Offset: 0x0021CA91
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

		// Token: 0x17005D87 RID: 23943
		// (get) Token: 0x060173E0 RID: 95200 RVA: 0x0021E8A6 File Offset: 0x0021CAA6
		// (set) Token: 0x060173E1 RID: 95201 RVA: 0x0021E8BA File Offset: 0x0021CABA
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

		// Token: 0x17005D88 RID: 23944
		// (get) Token: 0x060173E2 RID: 95202 RVA: 0x0021E8CF File Offset: 0x0021CACF
		// (set) Token: 0x060173E3 RID: 95203 RVA: 0x0021E8DF File Offset: 0x0021CADF
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

		// Token: 0x17005D89 RID: 23945
		// (get) Token: 0x060173E4 RID: 95204 RVA: 0x0021E8F0 File Offset: 0x0021CAF0
		// (set) Token: 0x060173E5 RID: 95205 RVA: 0x0021E900 File Offset: 0x0021CB00
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

		// Token: 0x17005D8A RID: 23946
		// (get) Token: 0x060173E6 RID: 95206 RVA: 0x0021E911 File Offset: 0x0021CB11
		// (set) Token: 0x060173E7 RID: 95207 RVA: 0x0021E925 File Offset: 0x0021CB25
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

		// Token: 0x060173E8 RID: 95208 RVA: 0x0021E93A File Offset: 0x0021CB3A
		static UEffectModelLight()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.EffectModelLight");
		}

		// Token: 0x060173E9 RID: 95209 RVA: 0x0021E948 File Offset: 0x0021CB48
		protected UEffectModelLight(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C9A3 RID: 51619
		public new const string __ObjectPath = "/Script/KuroGameplay.EffectModelLight";

		// Token: 0x0400C9A4 RID: 51620
		private static IntPtr _ClassPtr;

		// Token: 0x0400C9A5 RID: 51621
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C9A6 RID: 51622
		internal static int __PropertyOffset_Location;

		// Token: 0x0400C9A7 RID: 51623
		[Nullable(2)]
		private FKuroCurveVector _Location;

		// Token: 0x0400C9A8 RID: 51624
		internal static int __PropertyOffset_Intensity;

		// Token: 0x0400C9A9 RID: 51625
		[Nullable(2)]
		private FKuroCurveFloat _Intensity;

		// Token: 0x0400C9AA RID: 51626
		internal static int __PropertyOffset_Color;

		// Token: 0x0400C9AB RID: 51627
		[Nullable(2)]
		private FKuroCurveLinearColor _Color;

		// Token: 0x0400C9AC RID: 51628
		internal static int __PropertyOffset_Radius;

		// Token: 0x0400C9AD RID: 51629
		[Nullable(2)]
		private FKuroCurveFloat _Radius;

		// Token: 0x0400C9AE RID: 51630
		internal static int __PropertyOffset_FalloffExponent;

		// Token: 0x0400C9AF RID: 51631
		[Nullable(2)]
		private FKuroCurveFloat _FalloffExponent;

		// Token: 0x0400C9B0 RID: 51632
		internal static int __PropertyOffset_bUseSpotLight;

		// Token: 0x0400C9B1 RID: 51633
		internal static int __PropertyOffset_InnerConeAngle;

		// Token: 0x0400C9B2 RID: 51634
		[Nullable(2)]
		private FKuroCurveFloat _InnerConeAngle;

		// Token: 0x0400C9B3 RID: 51635
		internal static int __PropertyOffset_OuterConeAngle;

		// Token: 0x0400C9B4 RID: 51636
		[Nullable(2)]
		private FKuroCurveFloat _OuterConeAngle;

		// Token: 0x0400C9B5 RID: 51637
		internal static int __PropertyOffset_bUseAsVolumetricLight;

		// Token: 0x0400C9B6 RID: 51638
		internal static int __PropertyOffset_LightQualityType;

		// Token: 0x0400C9B7 RID: 51639
		internal static int __PropertyOffset_SourceRadius;

		// Token: 0x0400C9B8 RID: 51640
		internal static int __PropertyOffset_SoftSourceRadius;

		// Token: 0x0400C9B9 RID: 51641
		internal static int __PropertyOffset_SourceLength;

		// Token: 0x0400C9BA RID: 51642
		internal static int __PropertyOffset_AllowAnyRadius;

		// Token: 0x0400C9BB RID: 51643
		internal static int __PropertyOffset_CharacterLightAlpha;

		// Token: 0x0400C9BC RID: 51644
		[Nullable(2)]
		private FKuroCurveFloat _CharacterLightAlpha;

		// Token: 0x0400C9BD RID: 51645
		internal static int __PropertyOffset_CharacterFalloffExponent;

		// Token: 0x0400C9BE RID: 51646
		internal static int __PropertyOffset_CharacterBlendAtten;

		// Token: 0x0400C9BF RID: 51647
		internal static int __PropertyOffset_CharacterBlendIntensity;

		// Token: 0x0400C9C0 RID: 51648
		internal static int __PropertyOffset_ToonLightType;

		// Token: 0x0400C9C1 RID: 51649
		internal static int __PropertyOffset_CharacterPriority;

		// Token: 0x0400C9C2 RID: 51650
		internal static int __PropertyOffset_CharacterIntensity;

		// Token: 0x0400C9C3 RID: 51651
		internal static int __PropertyOffset_CharacterColor;

		// Token: 0x0400C9C4 RID: 51652
		internal static int __PropertyOffset_CharacterShadowIntensity;

		// Token: 0x0400C9C5 RID: 51653
		internal static int __PropertyOffset_CharacterRealTimeShadowIntensity;

		// Token: 0x0400C9C6 RID: 51654
		internal static int __PropertyOffset_CharacterDesaturationIntensity;

		// Token: 0x0400C9C7 RID: 51655
		internal static int __PropertyOffset_CharacterHardIntensity;

		// Token: 0x0400C9C8 RID: 51656
		internal static int __PropertyOffset_CharacterHardColor;

		// Token: 0x0400C9C9 RID: 51657
		internal static int __PropertyOffset_CharacterHardShadowColor;

		// Token: 0x0400C9CA RID: 51658
		internal static int __PropertyOffset_CharacterHardBlend;

		// Token: 0x0400C9CB RID: 51659
		internal static int __PropertyOffset_bCastShadowPc;

		// Token: 0x0400C9CC RID: 51660
		internal static int __PropertyOffset_DriveEffectByWeatherCustomDataName;
	}
}
