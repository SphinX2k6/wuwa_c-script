using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002516 RID: 9494
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.KuroBlurSettings")]
	[UnrealStructLayout(896, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 896)]
	public class FKuroBlurSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602341F RID: 144415 RVA: 0x00342599 File Offset: 0x00340799
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroBlurSettings._ScriptStructPtr != 0) ? FKuroBlurSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.KuroBlurSettings", ref FKuroBlurSettings._ScriptStructPtr);
		}

		// Token: 0x17008789 RID: 34697
		// (get) Token: 0x06023420 RID: 144416 RVA: 0x003425BD File Offset: 0x003407BD
		// (set) Token: 0x06023421 RID: 144417 RVA: 0x003425CD File Offset: 0x003407CD
		public unsafe float KuroBlurIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroBlurIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroBlurIntensity) = value;
			}
		}

		// Token: 0x1700878A RID: 34698
		// (get) Token: 0x06023422 RID: 144418 RVA: 0x003425DE File Offset: 0x003407DE
		// (set) Token: 0x06023423 RID: 144419 RVA: 0x003425EE File Offset: 0x003407EE
		public unsafe int KuroBlurSampleCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroBlurSampleCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroBlurSampleCount) = value;
			}
		}

		// Token: 0x1700878B RID: 34699
		// (get) Token: 0x06023424 RID: 144420 RVA: 0x003425FF File Offset: 0x003407FF
		// (set) Token: 0x06023425 RID: 144421 RVA: 0x0034260F File Offset: 0x0034080F
		public unsafe float KuroDistanceInfluence
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroDistanceInfluence);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroDistanceInfluence) = value;
			}
		}

		// Token: 0x1700878C RID: 34700
		// (get) Token: 0x06023426 RID: 144422 RVA: 0x00342620 File Offset: 0x00340820
		// (set) Token: 0x06023427 RID: 144423 RVA: 0x00342630 File Offset: 0x00340830
		public unsafe float KuroReferenceScreenRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroReferenceScreenRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroReferenceScreenRadius) = value;
			}
		}

		// Token: 0x1700878D RID: 34701
		// (get) Token: 0x06023428 RID: 144424 RVA: 0x00342644 File Offset: 0x00340844
		// (set) Token: 0x06023429 RID: 144425 RVA: 0x00342687 File Offset: 0x00340887
		public FKuroBlurCurve KuroLifeProfile
		{
			get
			{
				base.FastCheckIsValid();
				FKuroBlurCurve result;
				if ((result = this._KuroLifeProfile) == null)
				{
					result = (this._KuroLifeProfile = new FKuroBlurCurve(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroLifeProfile, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroBlurCurve.StaticStruct(), base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroLifeProfile, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700878E RID: 34702
		// (get) Token: 0x0602342A RID: 144426 RVA: 0x003426A8 File Offset: 0x003408A8
		// (set) Token: 0x0602342B RID: 144427 RVA: 0x003426B8 File Offset: 0x003408B8
		public unsafe int KuroLifeDriveTargets
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroLifeDriveTargets);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroLifeDriveTargets) = value;
			}
		}

		// Token: 0x1700878F RID: 34703
		// (get) Token: 0x0602342C RID: 144428 RVA: 0x003426C9 File Offset: 0x003408C9
		// (set) Token: 0x0602342D RID: 144429 RVA: 0x003426D9 File Offset: 0x003408D9
		public unsafe EKuroBlurRadialMode KuroRadialMode
		{
			get
			{
				return (EKuroBlurRadialMode)(*(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroRadialMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroRadialMode) = (byte)value;
			}
		}

		// Token: 0x17008790 RID: 34704
		// (get) Token: 0x0602342E RID: 144430 RVA: 0x003426EA File Offset: 0x003408EA
		// (set) Token: 0x0602342F RID: 144431 RVA: 0x003426FA File Offset: 0x003408FA
		public unsafe float KuroRadialBlurScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroRadialBlurScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroRadialBlurScale) = value;
			}
		}

		// Token: 0x17008791 RID: 34705
		// (get) Token: 0x06023430 RID: 144432 RVA: 0x0034270B File Offset: 0x0034090B
		// (set) Token: 0x06023431 RID: 144433 RVA: 0x0034271F File Offset: 0x0034091F
		public unsafe FVector2D KuroRadialBlurCenterOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroRadialBlurCenterOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroRadialBlurCenterOffset) = value;
			}
		}

		// Token: 0x17008792 RID: 34706
		// (get) Token: 0x06023432 RID: 144434 RVA: 0x00342734 File Offset: 0x00340934
		// (set) Token: 0x06023433 RID: 144435 RVA: 0x00342744 File Offset: 0x00340944
		public unsafe float KuroRadialFalloff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroRadialFalloff);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroRadialFalloff) = value;
			}
		}

		// Token: 0x17008793 RID: 34707
		// (get) Token: 0x06023434 RID: 144436 RVA: 0x00342758 File Offset: 0x00340958
		// (set) Token: 0x06023435 RID: 144437 RVA: 0x0034279B File Offset: 0x0034099B
		public FKuroBlurCurve KuroRadialProfile
		{
			get
			{
				base.FastCheckIsValid();
				FKuroBlurCurve result;
				if ((result = this._KuroRadialProfile) == null)
				{
					result = (this._KuroRadialProfile = new FKuroBlurCurve(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroRadialProfile, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroBlurCurve.StaticStruct(), base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroRadialProfile, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008794 RID: 34708
		// (get) Token: 0x06023436 RID: 144438 RVA: 0x003427BC File Offset: 0x003409BC
		// (set) Token: 0x06023437 RID: 144439 RVA: 0x003427CC File Offset: 0x003409CC
		public unsafe EKuroBlurCurveTarget KuroRadialProfileTarget
		{
			get
			{
				return (EKuroBlurCurveTarget)(*(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroRadialProfileTarget));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroRadialProfileTarget) = (byte)value;
			}
		}

		// Token: 0x17008795 RID: 34709
		// (get) Token: 0x06023438 RID: 144440 RVA: 0x003427E0 File Offset: 0x003409E0
		// (set) Token: 0x06023439 RID: 144441 RVA: 0x00342823 File Offset: 0x00340A23
		public FKuroBlurCurve KuroDirectionProfile
		{
			get
			{
				base.FastCheckIsValid();
				FKuroBlurCurve result;
				if ((result = this._KuroDirectionProfile) == null)
				{
					result = (this._KuroDirectionProfile = new FKuroBlurCurve(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroDirectionProfile, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroBlurCurve.StaticStruct(), base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroDirectionProfile, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008796 RID: 34710
		// (get) Token: 0x0602343A RID: 144442 RVA: 0x00342844 File Offset: 0x00340A44
		// (set) Token: 0x0602343B RID: 144443 RVA: 0x00342854 File Offset: 0x00340A54
		public unsafe float KuroMaxDeflectionAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroMaxDeflectionAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroMaxDeflectionAngle) = value;
			}
		}

		// Token: 0x17008797 RID: 34711
		// (get) Token: 0x0602343C RID: 144444 RVA: 0x00342868 File Offset: 0x00340A68
		// (set) Token: 0x0602343D RID: 144445 RVA: 0x003428AB File Offset: 0x00340AAB
		public FKuroBlurCurve KuroSampleWeight
		{
			get
			{
				base.FastCheckIsValid();
				FKuroBlurCurve result;
				if ((result = this._KuroSampleWeight) == null)
				{
					result = (this._KuroSampleWeight = new FKuroBlurCurve(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroSampleWeight, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroBlurCurve.StaticStruct(), base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroSampleWeight, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008798 RID: 34712
		// (get) Token: 0x0602343E RID: 144446 RVA: 0x003428CC File Offset: 0x00340ACC
		// (set) Token: 0x0602343F RID: 144447 RVA: 0x003428DC File Offset: 0x00340ADC
		public unsafe float KuroBlurStreakStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroBlurStreakStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroBlurStreakStrength) = value;
			}
		}

		// Token: 0x17008799 RID: 34713
		// (get) Token: 0x06023440 RID: 144448 RVA: 0x003428ED File Offset: 0x00340AED
		// (set) Token: 0x06023441 RID: 144449 RVA: 0x003428FD File Offset: 0x00340AFD
		public unsafe float KuroBlurStreakCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroBlurStreakCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroBlurStreakCount) = value;
			}
		}

		// Token: 0x1700879A RID: 34714
		// (get) Token: 0x06023442 RID: 144450 RVA: 0x0034290E File Offset: 0x00340B0E
		// (set) Token: 0x06023443 RID: 144451 RVA: 0x0034291E File Offset: 0x00340B1E
		public unsafe float KuroSpinAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroSpinAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroSpinAngle) = value;
			}
		}

		// Token: 0x1700879B RID: 34715
		// (get) Token: 0x06023444 RID: 144452 RVA: 0x0034292F File Offset: 0x00340B2F
		// (set) Token: 0x06023445 RID: 144453 RVA: 0x00342943 File Offset: 0x00340B43
		public unsafe FVector2D KuroDirectionalDir
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroDirectionalDir);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroDirectionalDir) = value;
			}
		}

		// Token: 0x1700879C RID: 34716
		// (get) Token: 0x06023446 RID: 144454 RVA: 0x00342958 File Offset: 0x00340B58
		// (set) Token: 0x06023447 RID: 144455 RVA: 0x00342968 File Offset: 0x00340B68
		public unsafe bool bKuroBlurWorldSpaceDir
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_bKuroBlurWorldSpaceDir) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_bKuroBlurWorldSpaceDir) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700879D RID: 34717
		// (get) Token: 0x06023448 RID: 144456 RVA: 0x00342979 File Offset: 0x00340B79
		// (set) Token: 0x06023449 RID: 144457 RVA: 0x0034298D File Offset: 0x00340B8D
		public unsafe FVector KuroBlurDirectionalWorldDir
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroBlurDirectionalWorldDir);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroBlurDirectionalWorldDir) = value;
			}
		}

		// Token: 0x1700879E RID: 34718
		// (get) Token: 0x0602344A RID: 144458 RVA: 0x003429A2 File Offset: 0x00340BA2
		// (set) Token: 0x0602344B RID: 144459 RVA: 0x003429B2 File Offset: 0x00340BB2
		public unsafe float KuroJitterStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroJitterStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroJitterStrength) = value;
			}
		}

		// Token: 0x1700879F RID: 34719
		// (get) Token: 0x0602344C RID: 144460 RVA: 0x003429C3 File Offset: 0x00340BC3
		// (set) Token: 0x0602344D RID: 144461 RVA: 0x003429D3 File Offset: 0x00340BD3
		public unsafe bool bKuroBlurUseDepth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_bKuroBlurUseDepth) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_bKuroBlurUseDepth) = (value ? 1 : 0);
			}
		}

		// Token: 0x170087A0 RID: 34720
		// (get) Token: 0x0602344E RID: 144462 RVA: 0x003429E4 File Offset: 0x00340BE4
		// (set) Token: 0x0602344F RID: 144463 RVA: 0x00342A27 File Offset: 0x00340C27
		public FKuroBlurCurve KuroDepthProfile
		{
			get
			{
				base.FastCheckIsValid();
				FKuroBlurCurve result;
				if ((result = this._KuroDepthProfile) == null)
				{
					result = (this._KuroDepthProfile = new FKuroBlurCurve(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroDepthProfile, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroBlurCurve.StaticStruct(), base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroDepthProfile, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170087A1 RID: 34721
		// (get) Token: 0x06023450 RID: 144464 RVA: 0x00342A48 File Offset: 0x00340C48
		// (set) Token: 0x06023451 RID: 144465 RVA: 0x00342A58 File Offset: 0x00340C58
		public unsafe EKuroBlurCurveTarget KuroDepthProfileTarget
		{
			get
			{
				return (EKuroBlurCurveTarget)(*(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroDepthProfileTarget));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroDepthProfileTarget) = (byte)value;
			}
		}

		// Token: 0x170087A2 RID: 34722
		// (get) Token: 0x06023452 RID: 144466 RVA: 0x00342A69 File Offset: 0x00340C69
		// (set) Token: 0x06023453 RID: 144467 RVA: 0x00342A79 File Offset: 0x00340C79
		public unsafe float KuroBlurDepthRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroBlurDepthRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroBlurDepthRange) = value;
			}
		}

		// Token: 0x170087A3 RID: 34723
		// (get) Token: 0x06023454 RID: 144468 RVA: 0x00342A8A File Offset: 0x00340C8A
		// (set) Token: 0x06023455 RID: 144469 RVA: 0x00342A9A File Offset: 0x00340C9A
		public unsafe int KuroExcludeShadingModels
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroExcludeShadingModels);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroExcludeShadingModels) = value;
			}
		}

		// Token: 0x170087A4 RID: 34724
		// (get) Token: 0x06023456 RID: 144470 RVA: 0x00342AAB File Offset: 0x00340CAB
		// (set) Token: 0x06023457 RID: 144471 RVA: 0x00342ABB File Offset: 0x00340CBB
		public unsafe float KuroExcludeDepthMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroExcludeDepthMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroExcludeDepthMin) = value;
			}
		}

		// Token: 0x170087A5 RID: 34725
		// (get) Token: 0x06023458 RID: 144472 RVA: 0x00342ACC File Offset: 0x00340CCC
		// (set) Token: 0x06023459 RID: 144473 RVA: 0x00342ADC File Offset: 0x00340CDC
		public unsafe float KuroExcludeDepthMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroExcludeDepthMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroExcludeDepthMax) = value;
			}
		}

		// Token: 0x170087A6 RID: 34726
		// (get) Token: 0x0602345A RID: 144474 RVA: 0x00342AED File Offset: 0x00340CED
		// (set) Token: 0x0602345B RID: 144475 RVA: 0x00342AFD File Offset: 0x00340CFD
		public unsafe EKuroBlurDispersionMode KuroDispersionMode
		{
			get
			{
				return (EKuroBlurDispersionMode)(*(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroDispersionMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroDispersionMode) = (byte)value;
			}
		}

		// Token: 0x170087A7 RID: 34727
		// (get) Token: 0x0602345C RID: 144476 RVA: 0x00342B0E File Offset: 0x00340D0E
		// (set) Token: 0x0602345D RID: 144477 RVA: 0x00342B1E File Offset: 0x00340D1E
		public unsafe float KuroDispersionScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroDispersionScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroDispersionScale) = value;
			}
		}

		// Token: 0x170087A8 RID: 34728
		// (get) Token: 0x0602345E RID: 144478 RVA: 0x00342B2F File Offset: 0x00340D2F
		// (set) Token: 0x0602345F RID: 144479 RVA: 0x00342B43 File Offset: 0x00340D43
		public unsafe FVector KuroDispersionChannelScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroDispersionChannelScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroDispersionChannelScale) = value;
			}
		}

		// Token: 0x170087A9 RID: 34729
		// (get) Token: 0x06023460 RID: 144480 RVA: 0x00342B58 File Offset: 0x00340D58
		// (set) Token: 0x06023461 RID: 144481 RVA: 0x00342B68 File Offset: 0x00340D68
		public unsafe float KuroDispersionBrightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroDispersionBrightness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroDispersionBrightness) = value;
			}
		}

		// Token: 0x170087AA RID: 34730
		// (get) Token: 0x06023462 RID: 144482 RVA: 0x00342B79 File Offset: 0x00340D79
		// (set) Token: 0x06023463 RID: 144483 RVA: 0x00342B8D File Offset: 0x00340D8D
		public unsafe FVector2D KuroLateralDir
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroLateralDir);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroLateralDir) = value;
			}
		}

		// Token: 0x170087AB RID: 34731
		// (get) Token: 0x06023464 RID: 144484 RVA: 0x00342BA2 File Offset: 0x00340DA2
		// (set) Token: 0x06023465 RID: 144485 RVA: 0x00342BB2 File Offset: 0x00340DB2
		public unsafe bool bKuroBlurUseDynamicParam
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_bKuroBlurUseDynamicParam) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_bKuroBlurUseDynamicParam) = (value ? 1 : 0);
			}
		}

		// Token: 0x170087AC RID: 34732
		// (get) Token: 0x06023466 RID: 144486 RVA: 0x00342BC3 File Offset: 0x00340DC3
		// (set) Token: 0x06023467 RID: 144487 RVA: 0x00342BD3 File Offset: 0x00340DD3
		public unsafe int KuroBlurDynamicParamIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroBlurDynamicParamIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroBlurDynamicParamIndex) = value;
			}
		}

		// Token: 0x170087AD RID: 34733
		// (get) Token: 0x06023468 RID: 144488 RVA: 0x00342BE4 File Offset: 0x00340DE4
		// (set) Token: 0x06023469 RID: 144489 RVA: 0x00342BF4 File Offset: 0x00340DF4
		public unsafe bool bKuroBlurDriveIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_bKuroBlurDriveIntensity) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_bKuroBlurDriveIntensity) = (value ? 1 : 0);
			}
		}

		// Token: 0x170087AE RID: 34734
		// (get) Token: 0x0602346A RID: 144490 RVA: 0x00342C05 File Offset: 0x00340E05
		// (set) Token: 0x0602346B RID: 144491 RVA: 0x00342C15 File Offset: 0x00340E15
		public unsafe bool bKuroBlurDriveBlur
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_bKuroBlurDriveBlur) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_bKuroBlurDriveBlur) = (value ? 1 : 0);
			}
		}

		// Token: 0x170087AF RID: 34735
		// (get) Token: 0x0602346C RID: 144492 RVA: 0x00342C26 File Offset: 0x00340E26
		// (set) Token: 0x0602346D RID: 144493 RVA: 0x00342C36 File Offset: 0x00340E36
		public unsafe bool bKuroBlurDriveDispersion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_bKuroBlurDriveDispersion) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_bKuroBlurDriveDispersion) = (value ? 1 : 0);
			}
		}

		// Token: 0x170087B0 RID: 34736
		// (get) Token: 0x0602346E RID: 144494 RVA: 0x00342C47 File Offset: 0x00340E47
		// (set) Token: 0x0602346F RID: 144495 RVA: 0x00342C5B File Offset: 0x00340E5B
		public unsafe FVector4 KuroBlurDynamicParamDefault
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroBlurDynamicParamDefault);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroBlurDynamicParamDefault) = value;
			}
		}

		// Token: 0x170087B1 RID: 34737
		// (get) Token: 0x06023470 RID: 144496 RVA: 0x00342C70 File Offset: 0x00340E70
		// (set) Token: 0x06023471 RID: 144497 RVA: 0x00342C80 File Offset: 0x00340E80
		public unsafe bool bKuroBlurUseControlMaterial
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_bKuroBlurUseControlMaterial) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_bKuroBlurUseControlMaterial) = (value ? 1 : 0);
			}
		}

		// Token: 0x170087B2 RID: 34738
		// (get) Token: 0x06023472 RID: 144498 RVA: 0x00342C91 File Offset: 0x00340E91
		// (set) Token: 0x06023473 RID: 144499 RVA: 0x00342CA1 File Offset: 0x00340EA1
		public unsafe float KuroBlurFlowInfluenceBlur
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroBlurFlowInfluenceBlur);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroBlurFlowInfluenceBlur) = value;
			}
		}

		// Token: 0x170087B3 RID: 34739
		// (get) Token: 0x06023474 RID: 144500 RVA: 0x00342CB2 File Offset: 0x00340EB2
		// (set) Token: 0x06023475 RID: 144501 RVA: 0x00342CC2 File Offset: 0x00340EC2
		public unsafe float KuroBlurFlowInfluenceDispersion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroBlurFlowInfluenceDispersion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroBlurFlowInfluenceDispersion) = value;
			}
		}

		// Token: 0x170087B4 RID: 34740
		// (get) Token: 0x06023476 RID: 144502 RVA: 0x00342CD3 File Offset: 0x00340ED3
		// (set) Token: 0x06023477 RID: 144503 RVA: 0x00342CE3 File Offset: 0x00340EE3
		public unsafe float KuroBlurMaskThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroBlurMaskThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroBlurMaskThreshold) = value;
			}
		}

		// Token: 0x170087B5 RID: 34741
		// (get) Token: 0x06023478 RID: 144504 RVA: 0x00342CF4 File Offset: 0x00340EF4
		// (set) Token: 0x06023479 RID: 144505 RVA: 0x00342D04 File Offset: 0x00340F04
		public unsafe float KuroBlurMaskThresholdMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroBlurMaskThresholdMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_KuroBlurMaskThresholdMax) = value;
			}
		}

		// Token: 0x170087B6 RID: 34742
		// (get) Token: 0x0602347A RID: 144506 RVA: 0x00342D15 File Offset: 0x00340F15
		// (set) Token: 0x0602347B RID: 144507 RVA: 0x00342D25 File Offset: 0x00340F25
		public unsafe bool bKuroCurvesMigrated
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_bKuroCurvesMigrated) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_bKuroCurvesMigrated) = (value ? 1 : 0);
			}
		}

		// Token: 0x170087B7 RID: 34743
		// (get) Token: 0x0602347C RID: 144508 RVA: 0x00342D36 File Offset: 0x00340F36
		// (set) Token: 0x0602347D RID: 144509 RVA: 0x00342D4A File Offset: 0x00340F4A
		[Nullable(2)]
		public unsafe UCurveFloat KuroRadialProfileCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroBlurSettings.__PropertyOffset_KuroRadialProfileCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroBlurSettings.__PropertyOffset_KuroRadialProfileCurve, value);
			}
		}

		// Token: 0x170087B8 RID: 34744
		// (get) Token: 0x0602347E RID: 144510 RVA: 0x00342D5F File Offset: 0x00340F5F
		// (set) Token: 0x0602347F RID: 144511 RVA: 0x00342D73 File Offset: 0x00340F73
		[Nullable(2)]
		public unsafe UCurveFloat KuroSampleWeightCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroBlurSettings.__PropertyOffset_KuroSampleWeightCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroBlurSettings.__PropertyOffset_KuroSampleWeightCurve, value);
			}
		}

		// Token: 0x170087B9 RID: 34745
		// (get) Token: 0x06023480 RID: 144512 RVA: 0x00342D88 File Offset: 0x00340F88
		// (set) Token: 0x06023481 RID: 144513 RVA: 0x00342D9C File Offset: 0x00340F9C
		[Nullable(2)]
		public unsafe UCurveFloat KuroDepthProfileCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroBlurSettings.__PropertyOffset_KuroDepthProfileCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroBlurSettings.__PropertyOffset_KuroDepthProfileCurve, value);
			}
		}

		// Token: 0x170087BA RID: 34746
		// (get) Token: 0x06023482 RID: 144514 RVA: 0x00342DB1 File Offset: 0x00340FB1
		// (set) Token: 0x06023483 RID: 144515 RVA: 0x00342DC1 File Offset: 0x00340FC1
		public unsafe bool bKuroCurveTargetsMigrated
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_bKuroCurveTargetsMigrated) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBlurSettings.__PropertyOffset_bKuroCurveTargetsMigrated) = (value ? 1 : 0);
			}
		}

		// Token: 0x06023484 RID: 144516 RVA: 0x00342DD2 File Offset: 0x00340FD2
		public FKuroBlurSettings()
		{
		}

		// Token: 0x06023485 RID: 144517 RVA: 0x00342DDC File Offset: 0x00340FDC
		public FKuroBlurSettings(float KuroBlurIntensity, int KuroBlurSampleCount, float KuroDistanceInfluence, float KuroReferenceScreenRadius, FKuroBlurCurve KuroLifeProfile, int KuroLifeDriveTargets, EKuroBlurRadialMode KuroRadialMode, float KuroRadialBlurScale, FVector2D KuroRadialBlurCenterOffset, float KuroRadialFalloff, FKuroBlurCurve KuroRadialProfile, EKuroBlurCurveTarget KuroRadialProfileTarget, FKuroBlurCurve KuroDirectionProfile, float KuroMaxDeflectionAngle, FKuroBlurCurve KuroSampleWeight, float KuroBlurStreakStrength, float KuroBlurStreakCount, float KuroSpinAngle, FVector2D KuroDirectionalDir, bool bKuroBlurWorldSpaceDir, FVector KuroBlurDirectionalWorldDir, float KuroJitterStrength, bool bKuroBlurUseDepth, FKuroBlurCurve KuroDepthProfile, EKuroBlurCurveTarget KuroDepthProfileTarget, float KuroBlurDepthRange, int KuroExcludeShadingModels, float KuroExcludeDepthMin, float KuroExcludeDepthMax, EKuroBlurDispersionMode KuroDispersionMode, float KuroDispersionScale, FVector KuroDispersionChannelScale, float KuroDispersionBrightness, FVector2D KuroLateralDir, bool bKuroBlurUseDynamicParam, int KuroBlurDynamicParamIndex, bool bKuroBlurDriveIntensity, bool bKuroBlurDriveBlur, bool bKuroBlurDriveDispersion, FVector4 KuroBlurDynamicParamDefault, bool bKuroBlurUseControlMaterial, float KuroBlurFlowInfluenceBlur, float KuroBlurFlowInfluenceDispersion, float KuroBlurMaskThreshold, float KuroBlurMaskThresholdMax, bool bKuroCurvesMigrated, UCurveFloat KuroRadialProfileCurve, UCurveFloat KuroSampleWeightCurve, UCurveFloat KuroDepthProfileCurve, bool bKuroCurveTargetsMigrated)
		{
			this.KuroBlurIntensity = KuroBlurIntensity;
			this.KuroBlurSampleCount = KuroBlurSampleCount;
			this.KuroDistanceInfluence = KuroDistanceInfluence;
			this.KuroReferenceScreenRadius = KuroReferenceScreenRadius;
			this.KuroLifeProfile = KuroLifeProfile;
			this.KuroLifeDriveTargets = KuroLifeDriveTargets;
			this.KuroRadialMode = KuroRadialMode;
			this.KuroRadialBlurScale = KuroRadialBlurScale;
			this.KuroRadialBlurCenterOffset = KuroRadialBlurCenterOffset;
			this.KuroRadialFalloff = KuroRadialFalloff;
			this.KuroRadialProfile = KuroRadialProfile;
			this.KuroRadialProfileTarget = KuroRadialProfileTarget;
			this.KuroDirectionProfile = KuroDirectionProfile;
			this.KuroMaxDeflectionAngle = KuroMaxDeflectionAngle;
			this.KuroSampleWeight = KuroSampleWeight;
			this.KuroBlurStreakStrength = KuroBlurStreakStrength;
			this.KuroBlurStreakCount = KuroBlurStreakCount;
			this.KuroSpinAngle = KuroSpinAngle;
			this.KuroDirectionalDir = KuroDirectionalDir;
			this.bKuroBlurWorldSpaceDir = bKuroBlurWorldSpaceDir;
			this.KuroBlurDirectionalWorldDir = KuroBlurDirectionalWorldDir;
			this.KuroJitterStrength = KuroJitterStrength;
			this.bKuroBlurUseDepth = bKuroBlurUseDepth;
			this.KuroDepthProfile = KuroDepthProfile;
			this.KuroDepthProfileTarget = KuroDepthProfileTarget;
			this.KuroBlurDepthRange = KuroBlurDepthRange;
			this.KuroExcludeShadingModels = KuroExcludeShadingModels;
			this.KuroExcludeDepthMin = KuroExcludeDepthMin;
			this.KuroExcludeDepthMax = KuroExcludeDepthMax;
			this.KuroDispersionMode = KuroDispersionMode;
			this.KuroDispersionScale = KuroDispersionScale;
			this.KuroDispersionChannelScale = KuroDispersionChannelScale;
			this.KuroDispersionBrightness = KuroDispersionBrightness;
			this.KuroLateralDir = KuroLateralDir;
			this.bKuroBlurUseDynamicParam = bKuroBlurUseDynamicParam;
			this.KuroBlurDynamicParamIndex = KuroBlurDynamicParamIndex;
			this.bKuroBlurDriveIntensity = bKuroBlurDriveIntensity;
			this.bKuroBlurDriveBlur = bKuroBlurDriveBlur;
			this.bKuroBlurDriveDispersion = bKuroBlurDriveDispersion;
			this.KuroBlurDynamicParamDefault = KuroBlurDynamicParamDefault;
			this.bKuroBlurUseControlMaterial = bKuroBlurUseControlMaterial;
			this.KuroBlurFlowInfluenceBlur = KuroBlurFlowInfluenceBlur;
			this.KuroBlurFlowInfluenceDispersion = KuroBlurFlowInfluenceDispersion;
			this.KuroBlurMaskThreshold = KuroBlurMaskThreshold;
			this.KuroBlurMaskThresholdMax = KuroBlurMaskThresholdMax;
			this.bKuroCurvesMigrated = bKuroCurvesMigrated;
			this.KuroRadialProfileCurve = KuroRadialProfileCurve;
			this.KuroSampleWeightCurve = KuroSampleWeightCurve;
			this.KuroDepthProfileCurve = KuroDepthProfileCurve;
			this.bKuroCurveTargetsMigrated = bKuroCurveTargetsMigrated;
		}

		// Token: 0x06023486 RID: 144518 RVA: 0x00342F7C File Offset: 0x0034117C
		protected override IntPtr GetUStructPtr()
		{
			return FKuroBlurSettings.StaticStruct();
		}

		// Token: 0x06023487 RID: 144519 RVA: 0x00342F88 File Offset: 0x00341188
		[NullableContext(2)]
		public FKuroBlurSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023488 RID: 144520 RVA: 0x00342F92 File Offset: 0x00341192
		public FKuroBlurSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023489 RID: 144521 RVA: 0x00342F9D File Offset: 0x0034119D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroBlurSettings(Pointer, false, true);
		}

		// Token: 0x0602348A RID: 144522 RVA: 0x00342FA7 File Offset: 0x003411A7
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroBlurSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04012ED9 RID: 77529
		public const string __ObjectPath = "/Script/Niagara.KuroBlurSettings";

		// Token: 0x04012EDA RID: 77530
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012EDB RID: 77531
		internal static int __PropertyOffset_KuroBlurIntensity;

		// Token: 0x04012EDC RID: 77532
		internal static int __PropertyOffset_KuroBlurSampleCount;

		// Token: 0x04012EDD RID: 77533
		internal static int __PropertyOffset_KuroDistanceInfluence;

		// Token: 0x04012EDE RID: 77534
		internal static int __PropertyOffset_KuroReferenceScreenRadius;

		// Token: 0x04012EDF RID: 77535
		internal static int __PropertyOffset_KuroLifeProfile;

		// Token: 0x04012EE0 RID: 77536
		[Nullable(2)]
		private FKuroBlurCurve _KuroLifeProfile;

		// Token: 0x04012EE1 RID: 77537
		internal static int __PropertyOffset_KuroLifeDriveTargets;

		// Token: 0x04012EE2 RID: 77538
		internal static int __PropertyOffset_KuroRadialMode;

		// Token: 0x04012EE3 RID: 77539
		internal static int __PropertyOffset_KuroRadialBlurScale;

		// Token: 0x04012EE4 RID: 77540
		internal static int __PropertyOffset_KuroRadialBlurCenterOffset;

		// Token: 0x04012EE5 RID: 77541
		internal static int __PropertyOffset_KuroRadialFalloff;

		// Token: 0x04012EE6 RID: 77542
		internal static int __PropertyOffset_KuroRadialProfile;

		// Token: 0x04012EE7 RID: 77543
		[Nullable(2)]
		private FKuroBlurCurve _KuroRadialProfile;

		// Token: 0x04012EE8 RID: 77544
		internal static int __PropertyOffset_KuroRadialProfileTarget;

		// Token: 0x04012EE9 RID: 77545
		internal static int __PropertyOffset_KuroDirectionProfile;

		// Token: 0x04012EEA RID: 77546
		[Nullable(2)]
		private FKuroBlurCurve _KuroDirectionProfile;

		// Token: 0x04012EEB RID: 77547
		internal static int __PropertyOffset_KuroMaxDeflectionAngle;

		// Token: 0x04012EEC RID: 77548
		internal static int __PropertyOffset_KuroSampleWeight;

		// Token: 0x04012EED RID: 77549
		[Nullable(2)]
		private FKuroBlurCurve _KuroSampleWeight;

		// Token: 0x04012EEE RID: 77550
		internal static int __PropertyOffset_KuroBlurStreakStrength;

		// Token: 0x04012EEF RID: 77551
		internal static int __PropertyOffset_KuroBlurStreakCount;

		// Token: 0x04012EF0 RID: 77552
		internal static int __PropertyOffset_KuroSpinAngle;

		// Token: 0x04012EF1 RID: 77553
		internal static int __PropertyOffset_KuroDirectionalDir;

		// Token: 0x04012EF2 RID: 77554
		internal static int __PropertyOffset_bKuroBlurWorldSpaceDir;

		// Token: 0x04012EF3 RID: 77555
		internal static int __PropertyOffset_KuroBlurDirectionalWorldDir;

		// Token: 0x04012EF4 RID: 77556
		internal static int __PropertyOffset_KuroJitterStrength;

		// Token: 0x04012EF5 RID: 77557
		internal static int __PropertyOffset_bKuroBlurUseDepth;

		// Token: 0x04012EF6 RID: 77558
		internal static int __PropertyOffset_KuroDepthProfile;

		// Token: 0x04012EF7 RID: 77559
		[Nullable(2)]
		private FKuroBlurCurve _KuroDepthProfile;

		// Token: 0x04012EF8 RID: 77560
		internal static int __PropertyOffset_KuroDepthProfileTarget;

		// Token: 0x04012EF9 RID: 77561
		internal static int __PropertyOffset_KuroBlurDepthRange;

		// Token: 0x04012EFA RID: 77562
		internal static int __PropertyOffset_KuroExcludeShadingModels;

		// Token: 0x04012EFB RID: 77563
		internal static int __PropertyOffset_KuroExcludeDepthMin;

		// Token: 0x04012EFC RID: 77564
		internal static int __PropertyOffset_KuroExcludeDepthMax;

		// Token: 0x04012EFD RID: 77565
		internal static int __PropertyOffset_KuroDispersionMode;

		// Token: 0x04012EFE RID: 77566
		internal static int __PropertyOffset_KuroDispersionScale;

		// Token: 0x04012EFF RID: 77567
		internal static int __PropertyOffset_KuroDispersionChannelScale;

		// Token: 0x04012F00 RID: 77568
		internal static int __PropertyOffset_KuroDispersionBrightness;

		// Token: 0x04012F01 RID: 77569
		internal static int __PropertyOffset_KuroLateralDir;

		// Token: 0x04012F02 RID: 77570
		internal static int __PropertyOffset_bKuroBlurUseDynamicParam;

		// Token: 0x04012F03 RID: 77571
		internal static int __PropertyOffset_KuroBlurDynamicParamIndex;

		// Token: 0x04012F04 RID: 77572
		internal static int __PropertyOffset_bKuroBlurDriveIntensity;

		// Token: 0x04012F05 RID: 77573
		internal static int __PropertyOffset_bKuroBlurDriveBlur;

		// Token: 0x04012F06 RID: 77574
		internal static int __PropertyOffset_bKuroBlurDriveDispersion;

		// Token: 0x04012F07 RID: 77575
		internal static int __PropertyOffset_KuroBlurDynamicParamDefault;

		// Token: 0x04012F08 RID: 77576
		internal static int __PropertyOffset_bKuroBlurUseControlMaterial;

		// Token: 0x04012F09 RID: 77577
		internal static int __PropertyOffset_KuroBlurFlowInfluenceBlur;

		// Token: 0x04012F0A RID: 77578
		internal static int __PropertyOffset_KuroBlurFlowInfluenceDispersion;

		// Token: 0x04012F0B RID: 77579
		internal static int __PropertyOffset_KuroBlurMaskThreshold;

		// Token: 0x04012F0C RID: 77580
		internal static int __PropertyOffset_KuroBlurMaskThresholdMax;

		// Token: 0x04012F0D RID: 77581
		internal static int __PropertyOffset_bKuroCurvesMigrated;

		// Token: 0x04012F0E RID: 77582
		internal static int __PropertyOffset_KuroRadialProfileCurve;

		// Token: 0x04012F0F RID: 77583
		internal static int __PropertyOffset_KuroSampleWeightCurve;

		// Token: 0x04012F10 RID: 77584
		internal static int __PropertyOffset_KuroDepthProfileCurve;

		// Token: 0x04012F11 RID: 77585
		internal static int __PropertyOffset_bKuroCurveTargetsMigrated;
	}
}
