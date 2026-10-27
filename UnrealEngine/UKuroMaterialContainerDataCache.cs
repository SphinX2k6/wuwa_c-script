using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B37 RID: 6967
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialContainerDataCache")]
	[UnrealStructLayout(22168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 22168)]
	public class UKuroMaterialContainerDataCache : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601A501 RID: 107777 RVA: 0x0026D186 File Offset: 0x0026B386
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroMaterialContainerDataCache._ClassPtr;
		}

		// Token: 0x0601A502 RID: 107778 RVA: 0x0026D194 File Offset: 0x0026B394
		public UKuroMaterialContainerDataCache() : this(BuiltinUtils.AllocNativeUObject(UKuroMaterialContainerDataCache.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601A503 RID: 107779 RVA: 0x0026D1BC File Offset: 0x0026B3BC
		public UKuroMaterialContainerDataCache(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroMaterialContainerDataCache.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170069DB RID: 27099
		// (get) Token: 0x0601A504 RID: 107780 RVA: 0x0026D1EF File Offset: 0x0026B3EF
		// (set) Token: 0x0601A505 RID: 107781 RVA: 0x0026D1FF File Offset: 0x0026B3FF
		public unsafe int Version
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_Version);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_Version) = value;
			}
		}

		// Token: 0x170069DC RID: 27100
		// (get) Token: 0x0601A506 RID: 107782 RVA: 0x0026D210 File Offset: 0x0026B410
		// (set) Token: 0x0601A507 RID: 107783 RVA: 0x0026D220 File Offset: 0x0026B420
		public unsafe bool bUseAbsoluteSpaceCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_bUseAbsoluteSpaceCurve) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_bUseAbsoluteSpaceCurve) = (value ? 1 : 0);
			}
		}

		// Token: 0x170069DD RID: 27101
		// (get) Token: 0x0601A508 RID: 107784 RVA: 0x0026D231 File Offset: 0x0026B431
		// (set) Token: 0x0601A509 RID: 107785 RVA: 0x0026D241 File Offset: 0x0026B441
		public unsafe bool bHighPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_bHighPriority) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_bHighPriority) = (value ? 1 : 0);
			}
		}

		// Token: 0x170069DE RID: 27102
		// (get) Token: 0x0601A50A RID: 107786 RVA: 0x0026D254 File Offset: 0x0026B454
		// (set) Token: 0x0601A50B RID: 107787 RVA: 0x0026D28D File Offset: 0x0026B48D
		public FKuroInterpolateRangeTime RangeTime
		{
			get
			{
				base.FastCheckIsValid();
				FKuroInterpolateRangeTime result;
				if ((result = this._RangeTime) == null)
				{
					result = (this._RangeTime = new FKuroInterpolateRangeTime(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_RangeTime, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroInterpolateRangeTime.StaticStruct(), base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_RangeTime, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170069DF RID: 27103
		// (get) Token: 0x0601A50C RID: 107788 RVA: 0x0026D2AE File Offset: 0x0026B4AE
		// (set) Token: 0x0601A50D RID: 107789 RVA: 0x0026D2BE File Offset: 0x0026B4BE
		public unsafe EKuroCharacterControllerApplyType MaterialApplyType
		{
			get
			{
				return (EKuroCharacterControllerApplyType)(*(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_MaterialApplyType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_MaterialApplyType) = (byte)value;
			}
		}

		// Token: 0x170069E0 RID: 27104
		// (get) Token: 0x0601A50E RID: 107790 RVA: 0x0026D2CF File Offset: 0x0026B4CF
		// (set) Token: 0x0601A50F RID: 107791 RVA: 0x0026D2DF File Offset: 0x0026B4DF
		public unsafe bool bMaskOriginEffects
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_bMaskOriginEffects) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_bMaskOriginEffects) = (value ? 1 : 0);
			}
		}

		// Token: 0x170069E1 RID: 27105
		// (get) Token: 0x0601A510 RID: 107792 RVA: 0x0026D2F0 File Offset: 0x0026B4F0
		// (set) Token: 0x0601A511 RID: 107793 RVA: 0x0026D300 File Offset: 0x0026B500
		public unsafe bool ForceBattle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_ForceBattle) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_ForceBattle) = (value ? 1 : 0);
			}
		}

		// Token: 0x170069E2 RID: 27106
		// (get) Token: 0x0601A512 RID: 107794 RVA: 0x0026D311 File Offset: 0x0026B511
		// (set) Token: 0x0601A513 RID: 107795 RVA: 0x0026D321 File Offset: 0x0026B521
		public unsafe bool ForceBattleMask
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_ForceBattleMask) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_ForceBattleMask) = (value ? 1 : 0);
			}
		}

		// Token: 0x170069E3 RID: 27107
		// (get) Token: 0x0601A514 RID: 107796 RVA: 0x0026D332 File Offset: 0x0026B532
		// (set) Token: 0x0601A515 RID: 107797 RVA: 0x0026D342 File Offset: 0x0026B542
		public unsafe bool ForceAlphaTest
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_ForceAlphaTest) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_ForceAlphaTest) = (value ? 1 : 0);
			}
		}

		// Token: 0x170069E4 RID: 27108
		// (get) Token: 0x0601A516 RID: 107798 RVA: 0x0026D354 File Offset: 0x0026B554
		// (set) Token: 0x0601A517 RID: 107799 RVA: 0x0026D38D File Offset: 0x0026B58D
		public FKuroMaterialControlFilter Filter
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialControlFilter result;
				if ((result = this._Filter) == null)
				{
					result = (this._Filter = new FKuroMaterialControlFilter(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_Filter, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialControlFilter.StaticStruct(), base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_Filter, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170069E5 RID: 27109
		// (get) Token: 0x0601A518 RID: 107800 RVA: 0x0026D3AE File Offset: 0x0026B5AE
		// (set) Token: 0x0601A519 RID: 107801 RVA: 0x0026D3BE File Offset: 0x0026B5BE
		public unsafe bool bUseRim
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_bUseRim) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_bUseRim) = (value ? 1 : 0);
			}
		}

		// Token: 0x170069E6 RID: 27110
		// (get) Token: 0x0601A51A RID: 107802 RVA: 0x0026D3D0 File Offset: 0x0026B5D0
		// (set) Token: 0x0601A51B RID: 107803 RVA: 0x0026D409 File Offset: 0x0026B609
		public FKuroMaterialControllerParam_Rim RimParam
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialControllerParam_Rim result;
				if ((result = this._RimParam) == null)
				{
					result = (this._RimParam = new FKuroMaterialControllerParam_Rim(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_RimParam, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialControllerParam_Rim.StaticStruct(), base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_RimParam, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170069E7 RID: 27111
		// (get) Token: 0x0601A51C RID: 107804 RVA: 0x0026D42A File Offset: 0x0026B62A
		// (set) Token: 0x0601A51D RID: 107805 RVA: 0x0026D43A File Offset: 0x0026B63A
		public unsafe bool bUseDissolve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_bUseDissolve) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_bUseDissolve) = (value ? 1 : 0);
			}
		}

		// Token: 0x170069E8 RID: 27112
		// (get) Token: 0x0601A51E RID: 107806 RVA: 0x0026D44C File Offset: 0x0026B64C
		// (set) Token: 0x0601A51F RID: 107807 RVA: 0x0026D485 File Offset: 0x0026B685
		public FKuroMaterialControllerParam_Dissolve DissolveParam
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialControllerParam_Dissolve result;
				if ((result = this._DissolveParam) == null)
				{
					result = (this._DissolveParam = new FKuroMaterialControllerParam_Dissolve(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_DissolveParam, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialControllerParam_Dissolve.StaticStruct(), base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_DissolveParam, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170069E9 RID: 27113
		// (get) Token: 0x0601A520 RID: 107808 RVA: 0x0026D4A6 File Offset: 0x0026B6A6
		// (set) Token: 0x0601A521 RID: 107809 RVA: 0x0026D4B6 File Offset: 0x0026B6B6
		public unsafe bool bUseOutline
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_bUseOutline) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_bUseOutline) = (value ? 1 : 0);
			}
		}

		// Token: 0x170069EA RID: 27114
		// (get) Token: 0x0601A522 RID: 107810 RVA: 0x0026D4C8 File Offset: 0x0026B6C8
		// (set) Token: 0x0601A523 RID: 107811 RVA: 0x0026D501 File Offset: 0x0026B701
		public FKuroMaterialControllerParam_Outline OutlineParam
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialControllerParam_Outline result;
				if ((result = this._OutlineParam) == null)
				{
					result = (this._OutlineParam = new FKuroMaterialControllerParam_Outline(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_OutlineParam, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialControllerParam_Outline.StaticStruct(), base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_OutlineParam, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170069EB RID: 27115
		// (get) Token: 0x0601A524 RID: 107812 RVA: 0x0026D522 File Offset: 0x0026B722
		// (set) Token: 0x0601A525 RID: 107813 RVA: 0x0026D532 File Offset: 0x0026B732
		public unsafe bool bUseColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_bUseColor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_bUseColor) = (value ? 1 : 0);
			}
		}

		// Token: 0x170069EC RID: 27116
		// (get) Token: 0x0601A526 RID: 107814 RVA: 0x0026D544 File Offset: 0x0026B744
		// (set) Token: 0x0601A527 RID: 107815 RVA: 0x0026D57D File Offset: 0x0026B77D
		public FKuroMaterialControllerParam_Color ColorParam
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialControllerParam_Color result;
				if ((result = this._ColorParam) == null)
				{
					result = (this._ColorParam = new FKuroMaterialControllerParam_Color(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_ColorParam, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialControllerParam_Color.StaticStruct(), base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_ColorParam, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170069ED RID: 27117
		// (get) Token: 0x0601A528 RID: 107816 RVA: 0x0026D59E File Offset: 0x0026B79E
		// (set) Token: 0x0601A529 RID: 107817 RVA: 0x0026D5AE File Offset: 0x0026B7AE
		public unsafe bool bUseTextureSample
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_bUseTextureSample) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_bUseTextureSample) = (value ? 1 : 0);
			}
		}

		// Token: 0x170069EE RID: 27118
		// (get) Token: 0x0601A52A RID: 107818 RVA: 0x0026D5C0 File Offset: 0x0026B7C0
		// (set) Token: 0x0601A52B RID: 107819 RVA: 0x0026D5F9 File Offset: 0x0026B7F9
		public FKuroMaterialControllerParam_TextureSample TextureSampleParam
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialControllerParam_TextureSample result;
				if ((result = this._TextureSampleParam) == null)
				{
					result = (this._TextureSampleParam = new FKuroMaterialControllerParam_TextureSample(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_TextureSampleParam, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialControllerParam_TextureSample.StaticStruct(), base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_TextureSampleParam, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170069EF RID: 27119
		// (get) Token: 0x0601A52C RID: 107820 RVA: 0x0026D61A File Offset: 0x0026B81A
		// (set) Token: 0x0601A52D RID: 107821 RVA: 0x0026D62A File Offset: 0x0026B82A
		public unsafe bool bUseMotionOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_bUseMotionOffset) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_bUseMotionOffset) = (value ? 1 : 0);
			}
		}

		// Token: 0x170069F0 RID: 27120
		// (get) Token: 0x0601A52E RID: 107822 RVA: 0x0026D63C File Offset: 0x0026B83C
		// (set) Token: 0x0601A52F RID: 107823 RVA: 0x0026D675 File Offset: 0x0026B875
		public FKuroMaterialControllerParam_MotionOffset MotionOffsetParam
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialControllerParam_MotionOffset result;
				if ((result = this._MotionOffsetParam) == null)
				{
					result = (this._MotionOffsetParam = new FKuroMaterialControllerParam_MotionOffset(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_MotionOffsetParam, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialControllerParam_MotionOffset.StaticStruct(), base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_MotionOffsetParam, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170069F1 RID: 27121
		// (get) Token: 0x0601A530 RID: 107824 RVA: 0x0026D696 File Offset: 0x0026B896
		// (set) Token: 0x0601A531 RID: 107825 RVA: 0x0026D6A6 File Offset: 0x0026B8A6
		public unsafe bool bUseDither
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_bUseDither) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_bUseDither) = (value ? 1 : 0);
			}
		}

		// Token: 0x170069F2 RID: 27122
		// (get) Token: 0x0601A532 RID: 107826 RVA: 0x0026D6B8 File Offset: 0x0026B8B8
		// (set) Token: 0x0601A533 RID: 107827 RVA: 0x0026D6F1 File Offset: 0x0026B8F1
		public FKuroMaterialControllerParam_Dither DitherParam
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialControllerParam_Dither result;
				if ((result = this._DitherParam) == null)
				{
					result = (this._DitherParam = new FKuroMaterialControllerParam_Dither(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_DitherParam, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialControllerParam_Dither.StaticStruct(), base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_DitherParam, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170069F3 RID: 27123
		// (get) Token: 0x0601A534 RID: 107828 RVA: 0x0026D712 File Offset: 0x0026B912
		// (set) Token: 0x0601A535 RID: 107829 RVA: 0x0026D722 File Offset: 0x0026B922
		public unsafe bool bUseCustom
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_bUseCustom) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_bUseCustom) = (value ? 1 : 0);
			}
		}

		// Token: 0x170069F4 RID: 27124
		// (get) Token: 0x0601A536 RID: 107830 RVA: 0x0026D734 File Offset: 0x0026B934
		// (set) Token: 0x0601A537 RID: 107831 RVA: 0x0026D76D File Offset: 0x0026B96D
		public FKuroMaterialControllerParam_Custom CustomParam
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialControllerParam_Custom result;
				if ((result = this._CustomParam) == null)
				{
					result = (this._CustomParam = new FKuroMaterialControllerParam_Custom(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_CustomParam, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialControllerParam_Custom.StaticStruct(), base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_CustomParam, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170069F5 RID: 27125
		// (get) Token: 0x0601A538 RID: 107832 RVA: 0x0026D790 File Offset: 0x0026B990
		// (set) Token: 0x0601A539 RID: 107833 RVA: 0x0026D7C9 File Offset: 0x0026B9C9
		public FKuroMaterialControllerParam_MaterialReplace MaterialReplaceParam
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialControllerParam_MaterialReplace result;
				if ((result = this._MaterialReplaceParam) == null)
				{
					result = (this._MaterialReplaceParam = new FKuroMaterialControllerParam_MaterialReplace(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_MaterialReplaceParam, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialControllerParam_MaterialReplace.StaticStruct(), base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_MaterialReplaceParam, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170069F6 RID: 27126
		// (get) Token: 0x0601A53A RID: 107834 RVA: 0x0026D7EA File Offset: 0x0026B9EA
		// (set) Token: 0x0601A53B RID: 107835 RVA: 0x0026D7FA File Offset: 0x0026B9FA
		public unsafe bool bAllowMaterialUnreverted
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_bAllowMaterialUnreverted) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_bAllowMaterialUnreverted) = (value ? 1 : 0);
			}
		}

		// Token: 0x170069F7 RID: 27127
		// (get) Token: 0x0601A53C RID: 107836 RVA: 0x0026D80B File Offset: 0x0026BA0B
		// (set) Token: 0x0601A53D RID: 107837 RVA: 0x0026D81B File Offset: 0x0026BA1B
		public unsafe bool bMaterialReplaceReceiveEffects
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_bMaterialReplaceReceiveEffects) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_bMaterialReplaceReceiveEffects) = (value ? 1 : 0);
			}
		}

		// Token: 0x170069F8 RID: 27128
		// (get) Token: 0x0601A53E RID: 107838 RVA: 0x0026D82C File Offset: 0x0026BA2C
		// (set) Token: 0x0601A53F RID: 107839 RVA: 0x0026D865 File Offset: 0x0026BA65
		public FKuroMaterialControllerParam_BaseMaterialReplace BaseMaterialReplaceParam
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialControllerParam_BaseMaterialReplace result;
				if ((result = this._BaseMaterialReplaceParam) == null)
				{
					result = (this._BaseMaterialReplaceParam = new FKuroMaterialControllerParam_BaseMaterialReplace(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_BaseMaterialReplaceParam, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialControllerParam_BaseMaterialReplace.StaticStruct(), base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_BaseMaterialReplaceParam, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170069F9 RID: 27129
		// (get) Token: 0x0601A540 RID: 107840 RVA: 0x0026D886 File Offset: 0x0026BA86
		// (set) Token: 0x0601A541 RID: 107841 RVA: 0x0026D896 File Offset: 0x0026BA96
		public unsafe bool bUseXRay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_bUseXRay) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_bUseXRay) = (value ? 1 : 0);
			}
		}

		// Token: 0x170069FA RID: 27130
		// (get) Token: 0x0601A542 RID: 107842 RVA: 0x0026D8A8 File Offset: 0x0026BAA8
		// (set) Token: 0x0601A543 RID: 107843 RVA: 0x0026D8E1 File Offset: 0x0026BAE1
		public FKuroMaterialControllerParam_XRay XRayParam
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialControllerParam_XRay result;
				if ((result = this._XRayParam) == null)
				{
					result = (this._XRayParam = new FKuroMaterialControllerParam_XRay(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_XRayParam, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialControllerParam_XRay.StaticStruct(), base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_XRayParam, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170069FB RID: 27131
		// (get) Token: 0x0601A544 RID: 107844 RVA: 0x0026D902 File Offset: 0x0026BB02
		// (set) Token: 0x0601A545 RID: 107845 RVA: 0x0026D912 File Offset: 0x0026BB12
		public unsafe bool bUseBodyOpacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_bUseBodyOpacity) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_bUseBodyOpacity) = (value ? 1 : 0);
			}
		}

		// Token: 0x170069FC RID: 27132
		// (get) Token: 0x0601A546 RID: 107846 RVA: 0x0026D924 File Offset: 0x0026BB24
		// (set) Token: 0x0601A547 RID: 107847 RVA: 0x0026D95D File Offset: 0x0026BB5D
		public FKuroMaterialCurveFloatGroup BodyOpacityCurve
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialCurveFloatGroup result;
				if ((result = this._BodyOpacityCurve) == null)
				{
					result = (this._BodyOpacityCurve = new FKuroMaterialCurveFloatGroup(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_BodyOpacityCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialCurveFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_BodyOpacityCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170069FD RID: 27133
		// (get) Token: 0x0601A548 RID: 107848 RVA: 0x0026D97E File Offset: 0x0026BB7E
		// (set) Token: 0x0601A549 RID: 107849 RVA: 0x0026D98E File Offset: 0x0026BB8E
		public unsafe bool bHasStartCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_bHasStartCurve) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_bHasStartCurve) = (value ? 1 : 0);
			}
		}

		// Token: 0x170069FE RID: 27134
		// (get) Token: 0x0601A54A RID: 107850 RVA: 0x0026D99F File Offset: 0x0026BB9F
		// (set) Token: 0x0601A54B RID: 107851 RVA: 0x0026D9AF File Offset: 0x0026BBAF
		public unsafe bool bHasLoopCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_bHasLoopCurve) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_bHasLoopCurve) = (value ? 1 : 0);
			}
		}

		// Token: 0x170069FF RID: 27135
		// (get) Token: 0x0601A54C RID: 107852 RVA: 0x0026D9C0 File Offset: 0x0026BBC0
		// (set) Token: 0x0601A54D RID: 107853 RVA: 0x0026D9D0 File Offset: 0x0026BBD0
		public unsafe bool bHasEndCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_bHasEndCurve) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMaterialContainerDataCache.__PropertyOffset_bHasEndCurve) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601A54E RID: 107854 RVA: 0x0026D9E1 File Offset: 0x0026BBE1
		static UKuroMaterialContainerDataCache()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialContainerDataCache");
		}

		// Token: 0x0601A54F RID: 107855 RVA: 0x0026D9EF File Offset: 0x0026BBEF
		protected UKuroMaterialContainerDataCache(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E470 RID: 58480
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialContainerDataCache";

		// Token: 0x0400E471 RID: 58481
		private static IntPtr _ClassPtr;

		// Token: 0x0400E472 RID: 58482
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E473 RID: 58483
		internal static int __PropertyOffset_Version;

		// Token: 0x0400E474 RID: 58484
		internal static int __PropertyOffset_bUseAbsoluteSpaceCurve;

		// Token: 0x0400E475 RID: 58485
		internal static int __PropertyOffset_bHighPriority;

		// Token: 0x0400E476 RID: 58486
		internal static int __PropertyOffset_RangeTime;

		// Token: 0x0400E477 RID: 58487
		[Nullable(2)]
		private FKuroInterpolateRangeTime _RangeTime;

		// Token: 0x0400E478 RID: 58488
		internal static int __PropertyOffset_MaterialApplyType;

		// Token: 0x0400E479 RID: 58489
		internal static int __PropertyOffset_bMaskOriginEffects;

		// Token: 0x0400E47A RID: 58490
		internal static int __PropertyOffset_ForceBattle;

		// Token: 0x0400E47B RID: 58491
		internal static int __PropertyOffset_ForceBattleMask;

		// Token: 0x0400E47C RID: 58492
		internal static int __PropertyOffset_ForceAlphaTest;

		// Token: 0x0400E47D RID: 58493
		internal static int __PropertyOffset_Filter;

		// Token: 0x0400E47E RID: 58494
		[Nullable(2)]
		private FKuroMaterialControlFilter _Filter;

		// Token: 0x0400E47F RID: 58495
		internal static int __PropertyOffset_bUseRim;

		// Token: 0x0400E480 RID: 58496
		internal static int __PropertyOffset_RimParam;

		// Token: 0x0400E481 RID: 58497
		[Nullable(2)]
		private FKuroMaterialControllerParam_Rim _RimParam;

		// Token: 0x0400E482 RID: 58498
		internal static int __PropertyOffset_bUseDissolve;

		// Token: 0x0400E483 RID: 58499
		internal static int __PropertyOffset_DissolveParam;

		// Token: 0x0400E484 RID: 58500
		[Nullable(2)]
		private FKuroMaterialControllerParam_Dissolve _DissolveParam;

		// Token: 0x0400E485 RID: 58501
		internal static int __PropertyOffset_bUseOutline;

		// Token: 0x0400E486 RID: 58502
		internal static int __PropertyOffset_OutlineParam;

		// Token: 0x0400E487 RID: 58503
		[Nullable(2)]
		private FKuroMaterialControllerParam_Outline _OutlineParam;

		// Token: 0x0400E488 RID: 58504
		internal static int __PropertyOffset_bUseColor;

		// Token: 0x0400E489 RID: 58505
		internal static int __PropertyOffset_ColorParam;

		// Token: 0x0400E48A RID: 58506
		[Nullable(2)]
		private FKuroMaterialControllerParam_Color _ColorParam;

		// Token: 0x0400E48B RID: 58507
		internal static int __PropertyOffset_bUseTextureSample;

		// Token: 0x0400E48C RID: 58508
		internal static int __PropertyOffset_TextureSampleParam;

		// Token: 0x0400E48D RID: 58509
		[Nullable(2)]
		private FKuroMaterialControllerParam_TextureSample _TextureSampleParam;

		// Token: 0x0400E48E RID: 58510
		internal static int __PropertyOffset_bUseMotionOffset;

		// Token: 0x0400E48F RID: 58511
		internal static int __PropertyOffset_MotionOffsetParam;

		// Token: 0x0400E490 RID: 58512
		[Nullable(2)]
		private FKuroMaterialControllerParam_MotionOffset _MotionOffsetParam;

		// Token: 0x0400E491 RID: 58513
		internal static int __PropertyOffset_bUseDither;

		// Token: 0x0400E492 RID: 58514
		internal static int __PropertyOffset_DitherParam;

		// Token: 0x0400E493 RID: 58515
		[Nullable(2)]
		private FKuroMaterialControllerParam_Dither _DitherParam;

		// Token: 0x0400E494 RID: 58516
		internal static int __PropertyOffset_bUseCustom;

		// Token: 0x0400E495 RID: 58517
		internal static int __PropertyOffset_CustomParam;

		// Token: 0x0400E496 RID: 58518
		[Nullable(2)]
		private FKuroMaterialControllerParam_Custom _CustomParam;

		// Token: 0x0400E497 RID: 58519
		internal static int __PropertyOffset_MaterialReplaceParam;

		// Token: 0x0400E498 RID: 58520
		[Nullable(2)]
		private FKuroMaterialControllerParam_MaterialReplace _MaterialReplaceParam;

		// Token: 0x0400E499 RID: 58521
		internal static int __PropertyOffset_bAllowMaterialUnreverted;

		// Token: 0x0400E49A RID: 58522
		internal static int __PropertyOffset_bMaterialReplaceReceiveEffects;

		// Token: 0x0400E49B RID: 58523
		internal static int __PropertyOffset_BaseMaterialReplaceParam;

		// Token: 0x0400E49C RID: 58524
		[Nullable(2)]
		private FKuroMaterialControllerParam_BaseMaterialReplace _BaseMaterialReplaceParam;

		// Token: 0x0400E49D RID: 58525
		internal static int __PropertyOffset_bUseXRay;

		// Token: 0x0400E49E RID: 58526
		internal static int __PropertyOffset_XRayParam;

		// Token: 0x0400E49F RID: 58527
		[Nullable(2)]
		private FKuroMaterialControllerParam_XRay _XRayParam;

		// Token: 0x0400E4A0 RID: 58528
		internal static int __PropertyOffset_bUseBodyOpacity;

		// Token: 0x0400E4A1 RID: 58529
		internal static int __PropertyOffset_BodyOpacityCurve;

		// Token: 0x0400E4A2 RID: 58530
		[Nullable(2)]
		private FKuroMaterialCurveFloatGroup _BodyOpacityCurve;

		// Token: 0x0400E4A3 RID: 58531
		internal static int __PropertyOffset_bHasStartCurve;

		// Token: 0x0400E4A4 RID: 58532
		internal static int __PropertyOffset_bHasLoopCurve;

		// Token: 0x0400E4A5 RID: 58533
		internal static int __PropertyOffset_bHasEndCurve;
	}
}
