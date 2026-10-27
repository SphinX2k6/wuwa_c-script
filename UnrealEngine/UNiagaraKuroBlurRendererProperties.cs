using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020025B5 RID: 9653
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraKuroBlurRendererProperties")]
	[UnrealStructLayout(6336, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 6336)]
	public class UNiagaraKuroBlurRendererProperties : UNiagaraSpriteRendererProperties, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023DB5 RID: 146869 RVA: 0x003504B7 File Offset: 0x0034E6B7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraKuroBlurRendererProperties._ClassPtr;
		}

		// Token: 0x06023DB6 RID: 146870 RVA: 0x003504C4 File Offset: 0x0034E6C4
		public UNiagaraKuroBlurRendererProperties() : this(BuiltinUtils.AllocNativeUObject(UNiagaraKuroBlurRendererProperties.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023DB7 RID: 146871 RVA: 0x003504EC File Offset: 0x0034E6EC
		public UNiagaraKuroBlurRendererProperties(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraKuroBlurRendererProperties.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170089CA RID: 35274
		// (get) Token: 0x06023DB8 RID: 146872 RVA: 0x0035051F File Offset: 0x0034E71F
		// (set) Token: 0x06023DB9 RID: 146873 RVA: 0x0035052F File Offset: 0x0034E72F
		public unsafe bool bUseProfile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_bUseProfile) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_bUseProfile) = (value ? 1 : 0);
			}
		}

		// Token: 0x170089CB RID: 35275
		// (get) Token: 0x06023DBA RID: 146874 RVA: 0x00350540 File Offset: 0x0034E740
		// (set) Token: 0x06023DBB RID: 146875 RVA: 0x00350554 File Offset: 0x0034E754
		[Nullable(2)]
		public unsafe UKuroBlurProfile KuroBlurProfile
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroBlurProfile>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraKuroBlurRendererProperties.__PropertyOffset_KuroBlurProfile);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraKuroBlurRendererProperties.__PropertyOffset_KuroBlurProfile, value);
			}
		}

		// Token: 0x170089CC RID: 35276
		// (get) Token: 0x06023DBC RID: 146876 RVA: 0x00350569 File Offset: 0x0034E769
		// (set) Token: 0x06023DBD RID: 146877 RVA: 0x00350579 File Offset: 0x0034E779
		public unsafe float KuroBlurIntensityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_KuroBlurIntensityScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_KuroBlurIntensityScale) = value;
			}
		}

		// Token: 0x170089CD RID: 35277
		// (get) Token: 0x06023DBE RID: 146878 RVA: 0x0035058A File Offset: 0x0034E78A
		// (set) Token: 0x06023DBF RID: 146879 RVA: 0x0035059A File Offset: 0x0034E79A
		public unsafe bool bKuroBlurDrawSpriteMesh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_bKuroBlurDrawSpriteMesh) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_bKuroBlurDrawSpriteMesh) = (value ? 1 : 0);
			}
		}

		// Token: 0x170089CE RID: 35278
		// (get) Token: 0x06023DC0 RID: 146880 RVA: 0x003505AC File Offset: 0x0034E7AC
		// (set) Token: 0x06023DC1 RID: 146881 RVA: 0x003505E5 File Offset: 0x0034E7E5
		public FKuroBlurSettings KuroBlurInlineSettings
		{
			get
			{
				base.FastCheckIsValid();
				FKuroBlurSettings result;
				if ((result = this._KuroBlurInlineSettings) == null)
				{
					result = (this._KuroBlurInlineSettings = new FKuroBlurSettings(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_KuroBlurInlineSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroBlurSettings.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_KuroBlurInlineSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170089CF RID: 35279
		// (get) Token: 0x06023DC2 RID: 146882 RVA: 0x00350606 File Offset: 0x0034E806
		// (set) Token: 0x06023DC3 RID: 146883 RVA: 0x0035061F File Offset: 0x0034E81F
		public unsafe bool bKuroBlurMigratedToSettings
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_bKuroBlurMigratedToSettings) & UNiagaraKuroBlurRendererProperties.__PropertyMask_bKuroBlurMigratedToSettings) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_bKuroBlurMigratedToSettings) = ((*(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_bKuroBlurMigratedToSettings) & ~UNiagaraKuroBlurRendererProperties.__PropertyMask_bKuroBlurMigratedToSettings) | (value ? UNiagaraKuroBlurRendererProperties.__PropertyMask_bKuroBlurMigratedToSettings : 0));
			}
		}

		// Token: 0x170089D0 RID: 35280
		// (get) Token: 0x06023DC4 RID: 146884 RVA: 0x0035064F File Offset: 0x0034E84F
		// (set) Token: 0x06023DC5 RID: 146885 RVA: 0x0035065F File Offset: 0x0034E85F
		public unsafe float KuroBlurIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_KuroBlurIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_KuroBlurIntensity) = value;
			}
		}

		// Token: 0x170089D1 RID: 35281
		// (get) Token: 0x06023DC6 RID: 146886 RVA: 0x00350670 File Offset: 0x0034E870
		// (set) Token: 0x06023DC7 RID: 146887 RVA: 0x00350680 File Offset: 0x0034E880
		public unsafe int KuroBlurSampleCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_KuroBlurSampleCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_KuroBlurSampleCount) = value;
			}
		}

		// Token: 0x170089D2 RID: 35282
		// (get) Token: 0x06023DC8 RID: 146888 RVA: 0x00350691 File Offset: 0x0034E891
		// (set) Token: 0x06023DC9 RID: 146889 RVA: 0x003506A1 File Offset: 0x0034E8A1
		public unsafe float KuroDistanceInfluence
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_KuroDistanceInfluence);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_KuroDistanceInfluence) = value;
			}
		}

		// Token: 0x170089D3 RID: 35283
		// (get) Token: 0x06023DCA RID: 146890 RVA: 0x003506B2 File Offset: 0x0034E8B2
		// (set) Token: 0x06023DCB RID: 146891 RVA: 0x003506C2 File Offset: 0x0034E8C2
		public unsafe float KuroReferenceScreenRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_KuroReferenceScreenRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_KuroReferenceScreenRadius) = value;
			}
		}

		// Token: 0x170089D4 RID: 35284
		// (get) Token: 0x06023DCC RID: 146892 RVA: 0x003506D3 File Offset: 0x0034E8D3
		// (set) Token: 0x06023DCD RID: 146893 RVA: 0x003506E3 File Offset: 0x0034E8E3
		public unsafe EKuroBlurRadialMode KuroRadialMode
		{
			get
			{
				return (EKuroBlurRadialMode)(*(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_KuroRadialMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_KuroRadialMode) = (byte)value;
			}
		}

		// Token: 0x170089D5 RID: 35285
		// (get) Token: 0x06023DCE RID: 146894 RVA: 0x003506F4 File Offset: 0x0034E8F4
		// (set) Token: 0x06023DCF RID: 146895 RVA: 0x00350704 File Offset: 0x0034E904
		public unsafe float KuroRadialBlurScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_KuroRadialBlurScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_KuroRadialBlurScale) = value;
			}
		}

		// Token: 0x170089D6 RID: 35286
		// (get) Token: 0x06023DD0 RID: 146896 RVA: 0x00350715 File Offset: 0x0034E915
		// (set) Token: 0x06023DD1 RID: 146897 RVA: 0x00350729 File Offset: 0x0034E929
		public unsafe FVector2D KuroRadialBlurCenterOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_KuroRadialBlurCenterOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_KuroRadialBlurCenterOffset) = value;
			}
		}

		// Token: 0x170089D7 RID: 35287
		// (get) Token: 0x06023DD2 RID: 146898 RVA: 0x0035073E File Offset: 0x0034E93E
		// (set) Token: 0x06023DD3 RID: 146899 RVA: 0x0035074E File Offset: 0x0034E94E
		public unsafe float KuroRadialFalloff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_KuroRadialFalloff);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_KuroRadialFalloff) = value;
			}
		}

		// Token: 0x170089D8 RID: 35288
		// (get) Token: 0x06023DD4 RID: 146900 RVA: 0x0035075F File Offset: 0x0034E95F
		// (set) Token: 0x06023DD5 RID: 146901 RVA: 0x0035076F File Offset: 0x0034E96F
		public unsafe float KuroSpinAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_KuroSpinAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_KuroSpinAngle) = value;
			}
		}

		// Token: 0x170089D9 RID: 35289
		// (get) Token: 0x06023DD6 RID: 146902 RVA: 0x00350780 File Offset: 0x0034E980
		// (set) Token: 0x06023DD7 RID: 146903 RVA: 0x00350794 File Offset: 0x0034E994
		public unsafe FVector2D KuroDirectionalDir
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_KuroDirectionalDir);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_KuroDirectionalDir) = value;
			}
		}

		// Token: 0x170089DA RID: 35290
		// (get) Token: 0x06023DD8 RID: 146904 RVA: 0x003507A9 File Offset: 0x0034E9A9
		// (set) Token: 0x06023DD9 RID: 146905 RVA: 0x003507B9 File Offset: 0x0034E9B9
		public unsafe float KuroJitterStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_KuroJitterStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_KuroJitterStrength) = value;
			}
		}

		// Token: 0x170089DB RID: 35291
		// (get) Token: 0x06023DDA RID: 146906 RVA: 0x003507CA File Offset: 0x0034E9CA
		// (set) Token: 0x06023DDB RID: 146907 RVA: 0x003507DA File Offset: 0x0034E9DA
		public unsafe EKuroBlurDispersionMode KuroDispersionMode
		{
			get
			{
				return (EKuroBlurDispersionMode)(*(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_KuroDispersionMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_KuroDispersionMode) = (byte)value;
			}
		}

		// Token: 0x170089DC RID: 35292
		// (get) Token: 0x06023DDC RID: 146908 RVA: 0x003507EB File Offset: 0x0034E9EB
		// (set) Token: 0x06023DDD RID: 146909 RVA: 0x003507FB File Offset: 0x0034E9FB
		public unsafe float KuroDispersionScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_KuroDispersionScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_KuroDispersionScale) = value;
			}
		}

		// Token: 0x170089DD RID: 35293
		// (get) Token: 0x06023DDE RID: 146910 RVA: 0x0035080C File Offset: 0x0034EA0C
		// (set) Token: 0x06023DDF RID: 146911 RVA: 0x00350820 File Offset: 0x0034EA20
		public unsafe FVector KuroDispersionChannelScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_KuroDispersionChannelScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_KuroDispersionChannelScale) = value;
			}
		}

		// Token: 0x170089DE RID: 35294
		// (get) Token: 0x06023DE0 RID: 146912 RVA: 0x00350835 File Offset: 0x0034EA35
		// (set) Token: 0x06023DE1 RID: 146913 RVA: 0x00350845 File Offset: 0x0034EA45
		public unsafe float KuroDispersionBrightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_KuroDispersionBrightness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_KuroDispersionBrightness) = value;
			}
		}

		// Token: 0x170089DF RID: 35295
		// (get) Token: 0x06023DE2 RID: 146914 RVA: 0x00350856 File Offset: 0x0034EA56
		// (set) Token: 0x06023DE3 RID: 146915 RVA: 0x0035086A File Offset: 0x0034EA6A
		public unsafe FVector2D KuroLateralDir
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_KuroLateralDir);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_KuroLateralDir) = value;
			}
		}

		// Token: 0x170089E0 RID: 35296
		// (get) Token: 0x06023DE4 RID: 146916 RVA: 0x0035087F File Offset: 0x0034EA7F
		// (set) Token: 0x06023DE5 RID: 146917 RVA: 0x00350898 File Offset: 0x0034EA98
		public unsafe bool bKuroBlurUseDynamicParam
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_bKuroBlurUseDynamicParam) & UNiagaraKuroBlurRendererProperties.__PropertyMask_bKuroBlurUseDynamicParam) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_bKuroBlurUseDynamicParam) = ((*(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_bKuroBlurUseDynamicParam) & ~UNiagaraKuroBlurRendererProperties.__PropertyMask_bKuroBlurUseDynamicParam) | (value ? UNiagaraKuroBlurRendererProperties.__PropertyMask_bKuroBlurUseDynamicParam : 0));
			}
		}

		// Token: 0x170089E1 RID: 35297
		// (get) Token: 0x06023DE6 RID: 146918 RVA: 0x003508C8 File Offset: 0x0034EAC8
		// (set) Token: 0x06023DE7 RID: 146919 RVA: 0x003508D8 File Offset: 0x0034EAD8
		public unsafe int KuroBlurDynamicParamIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_KuroBlurDynamicParamIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_KuroBlurDynamicParamIndex) = value;
			}
		}

		// Token: 0x170089E2 RID: 35298
		// (get) Token: 0x06023DE8 RID: 146920 RVA: 0x003508E9 File Offset: 0x0034EAE9
		// (set) Token: 0x06023DE9 RID: 146921 RVA: 0x00350902 File Offset: 0x0034EB02
		public unsafe bool bKuroBlurDriveIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_bKuroBlurDriveIntensity) & UNiagaraKuroBlurRendererProperties.__PropertyMask_bKuroBlurDriveIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_bKuroBlurDriveIntensity) = ((*(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_bKuroBlurDriveIntensity) & ~UNiagaraKuroBlurRendererProperties.__PropertyMask_bKuroBlurDriveIntensity) | (value ? UNiagaraKuroBlurRendererProperties.__PropertyMask_bKuroBlurDriveIntensity : 0));
			}
		}

		// Token: 0x170089E3 RID: 35299
		// (get) Token: 0x06023DEA RID: 146922 RVA: 0x00350932 File Offset: 0x0034EB32
		// (set) Token: 0x06023DEB RID: 146923 RVA: 0x0035094B File Offset: 0x0034EB4B
		public unsafe bool bKuroBlurDriveBlur
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_bKuroBlurDriveBlur) & UNiagaraKuroBlurRendererProperties.__PropertyMask_bKuroBlurDriveBlur) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_bKuroBlurDriveBlur) = ((*(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_bKuroBlurDriveBlur) & ~UNiagaraKuroBlurRendererProperties.__PropertyMask_bKuroBlurDriveBlur) | (value ? UNiagaraKuroBlurRendererProperties.__PropertyMask_bKuroBlurDriveBlur : 0));
			}
		}

		// Token: 0x170089E4 RID: 35300
		// (get) Token: 0x06023DEC RID: 146924 RVA: 0x0035097B File Offset: 0x0034EB7B
		// (set) Token: 0x06023DED RID: 146925 RVA: 0x00350994 File Offset: 0x0034EB94
		public unsafe bool bKuroBlurDriveDispersion
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_bKuroBlurDriveDispersion) & UNiagaraKuroBlurRendererProperties.__PropertyMask_bKuroBlurDriveDispersion) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_bKuroBlurDriveDispersion) = ((*(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_bKuroBlurDriveDispersion) & ~UNiagaraKuroBlurRendererProperties.__PropertyMask_bKuroBlurDriveDispersion) | (value ? UNiagaraKuroBlurRendererProperties.__PropertyMask_bKuroBlurDriveDispersion : 0));
			}
		}

		// Token: 0x170089E5 RID: 35301
		// (get) Token: 0x06023DEE RID: 146926 RVA: 0x003509C4 File Offset: 0x0034EBC4
		// (set) Token: 0x06023DEF RID: 146927 RVA: 0x003509D8 File Offset: 0x0034EBD8
		public unsafe FVector4 KuroBlurDynamicParamDefault
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_KuroBlurDynamicParamDefault);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_KuroBlurDynamicParamDefault) = value;
			}
		}

		// Token: 0x170089E6 RID: 35302
		// (get) Token: 0x06023DF0 RID: 146928 RVA: 0x003509ED File Offset: 0x0034EBED
		// (set) Token: 0x06023DF1 RID: 146929 RVA: 0x00350A06 File Offset: 0x0034EC06
		public unsafe bool bKuroBlurUseControlMaterial
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_bKuroBlurUseControlMaterial) & UNiagaraKuroBlurRendererProperties.__PropertyMask_bKuroBlurUseControlMaterial) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_bKuroBlurUseControlMaterial) = ((*(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_bKuroBlurUseControlMaterial) & ~UNiagaraKuroBlurRendererProperties.__PropertyMask_bKuroBlurUseControlMaterial) | (value ? UNiagaraKuroBlurRendererProperties.__PropertyMask_bKuroBlurUseControlMaterial : 0));
			}
		}

		// Token: 0x170089E7 RID: 35303
		// (get) Token: 0x06023DF2 RID: 146930 RVA: 0x00350A36 File Offset: 0x0034EC36
		// (set) Token: 0x06023DF3 RID: 146931 RVA: 0x00350A46 File Offset: 0x0034EC46
		public unsafe float KuroBlurFlowInfluenceBlur
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_KuroBlurFlowInfluenceBlur);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_KuroBlurFlowInfluenceBlur) = value;
			}
		}

		// Token: 0x170089E8 RID: 35304
		// (get) Token: 0x06023DF4 RID: 146932 RVA: 0x00350A57 File Offset: 0x0034EC57
		// (set) Token: 0x06023DF5 RID: 146933 RVA: 0x00350A67 File Offset: 0x0034EC67
		public unsafe float KuroBlurFlowInfluenceDispersion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_KuroBlurFlowInfluenceDispersion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_KuroBlurFlowInfluenceDispersion) = value;
			}
		}

		// Token: 0x170089E9 RID: 35305
		// (get) Token: 0x06023DF6 RID: 146934 RVA: 0x00350A78 File Offset: 0x0034EC78
		// (set) Token: 0x06023DF7 RID: 146935 RVA: 0x00350A88 File Offset: 0x0034EC88
		public unsafe float KuroBlurMaskThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_KuroBlurMaskThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_KuroBlurMaskThreshold) = value;
			}
		}

		// Token: 0x170089EA RID: 35306
		// (get) Token: 0x06023DF8 RID: 146936 RVA: 0x00350A99 File Offset: 0x0034EC99
		// (set) Token: 0x06023DF9 RID: 146937 RVA: 0x00350AA9 File Offset: 0x0034ECA9
		public unsafe float KuroBlurMaskThresholdMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_KuroBlurMaskThresholdMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraKuroBlurRendererProperties.__PropertyOffset_KuroBlurMaskThresholdMax) = value;
			}
		}

		// Token: 0x06023DFA RID: 146938 RVA: 0x00350ABA File Offset: 0x0034ECBA
		static UNiagaraKuroBlurRendererProperties()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraKuroBlurRendererProperties");
		}

		// Token: 0x06023DFB RID: 146939 RVA: 0x00350AC8 File Offset: 0x0034ECC8
		protected UNiagaraKuroBlurRendererProperties(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013390 RID: 78736
		public new const string __ObjectPath = "/Script/Niagara.NiagaraKuroBlurRendererProperties";

		// Token: 0x04013391 RID: 78737
		private static IntPtr _ClassPtr;

		// Token: 0x04013392 RID: 78738
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013393 RID: 78739
		internal static int __PropertyOffset_bUseProfile;

		// Token: 0x04013394 RID: 78740
		internal static int __PropertyOffset_KuroBlurProfile;

		// Token: 0x04013395 RID: 78741
		internal static int __PropertyOffset_KuroBlurIntensityScale;

		// Token: 0x04013396 RID: 78742
		internal static int __PropertyOffset_bKuroBlurDrawSpriteMesh;

		// Token: 0x04013397 RID: 78743
		internal static int __PropertyOffset_KuroBlurInlineSettings;

		// Token: 0x04013398 RID: 78744
		[Nullable(2)]
		private FKuroBlurSettings _KuroBlurInlineSettings;

		// Token: 0x04013399 RID: 78745
		internal static int __PropertyOffset_bKuroBlurMigratedToSettings;

		// Token: 0x0401339A RID: 78746
		internal static byte __PropertyMask_bKuroBlurMigratedToSettings;

		// Token: 0x0401339B RID: 78747
		internal static int __PropertyOffset_KuroBlurIntensity;

		// Token: 0x0401339C RID: 78748
		internal static int __PropertyOffset_KuroBlurSampleCount;

		// Token: 0x0401339D RID: 78749
		internal static int __PropertyOffset_KuroDistanceInfluence;

		// Token: 0x0401339E RID: 78750
		internal static int __PropertyOffset_KuroReferenceScreenRadius;

		// Token: 0x0401339F RID: 78751
		internal static int __PropertyOffset_KuroRadialMode;

		// Token: 0x040133A0 RID: 78752
		internal static int __PropertyOffset_KuroRadialBlurScale;

		// Token: 0x040133A1 RID: 78753
		internal static int __PropertyOffset_KuroRadialBlurCenterOffset;

		// Token: 0x040133A2 RID: 78754
		internal static int __PropertyOffset_KuroRadialFalloff;

		// Token: 0x040133A3 RID: 78755
		internal static int __PropertyOffset_KuroSpinAngle;

		// Token: 0x040133A4 RID: 78756
		internal static int __PropertyOffset_KuroDirectionalDir;

		// Token: 0x040133A5 RID: 78757
		internal static int __PropertyOffset_KuroJitterStrength;

		// Token: 0x040133A6 RID: 78758
		internal static int __PropertyOffset_KuroDispersionMode;

		// Token: 0x040133A7 RID: 78759
		internal static int __PropertyOffset_KuroDispersionScale;

		// Token: 0x040133A8 RID: 78760
		internal static int __PropertyOffset_KuroDispersionChannelScale;

		// Token: 0x040133A9 RID: 78761
		internal static int __PropertyOffset_KuroDispersionBrightness;

		// Token: 0x040133AA RID: 78762
		internal static int __PropertyOffset_KuroLateralDir;

		// Token: 0x040133AB RID: 78763
		internal static int __PropertyOffset_bKuroBlurUseDynamicParam;

		// Token: 0x040133AC RID: 78764
		internal static byte __PropertyMask_bKuroBlurUseDynamicParam;

		// Token: 0x040133AD RID: 78765
		internal static int __PropertyOffset_KuroBlurDynamicParamIndex;

		// Token: 0x040133AE RID: 78766
		internal static int __PropertyOffset_bKuroBlurDriveIntensity;

		// Token: 0x040133AF RID: 78767
		internal static byte __PropertyMask_bKuroBlurDriveIntensity;

		// Token: 0x040133B0 RID: 78768
		internal static int __PropertyOffset_bKuroBlurDriveBlur;

		// Token: 0x040133B1 RID: 78769
		internal static byte __PropertyMask_bKuroBlurDriveBlur;

		// Token: 0x040133B2 RID: 78770
		internal static int __PropertyOffset_bKuroBlurDriveDispersion;

		// Token: 0x040133B3 RID: 78771
		internal static byte __PropertyMask_bKuroBlurDriveDispersion;

		// Token: 0x040133B4 RID: 78772
		internal static int __PropertyOffset_KuroBlurDynamicParamDefault;

		// Token: 0x040133B5 RID: 78773
		internal static int __PropertyOffset_bKuroBlurUseControlMaterial;

		// Token: 0x040133B6 RID: 78774
		internal static byte __PropertyMask_bKuroBlurUseControlMaterial;

		// Token: 0x040133B7 RID: 78775
		internal static int __PropertyOffset_KuroBlurFlowInfluenceBlur;

		// Token: 0x040133B8 RID: 78776
		internal static int __PropertyOffset_KuroBlurFlowInfluenceDispersion;

		// Token: 0x040133B9 RID: 78777
		internal static int __PropertyOffset_KuroBlurMaskThreshold;

		// Token: 0x040133BA RID: 78778
		internal static int __PropertyOffset_KuroBlurMaskThresholdMax;
	}
}
