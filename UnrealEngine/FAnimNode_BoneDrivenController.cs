using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002D8 RID: 728
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_BoneDrivenController")]
	[UnrealStructLayout(432, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 432)]
	public class FAnimNode_BoneDrivenController : FAnimNode_SkeletalControlBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060028C4 RID: 10436 RVA: 0x0003D644 File Offset: 0x0003B844
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_BoneDrivenController._ScriptStructPtr != 0) ? FAnimNode_BoneDrivenController._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_BoneDrivenController", ref FAnimNode_BoneDrivenController._ScriptStructPtr);
		}

		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x060028C5 RID: 10437 RVA: 0x0003D668 File Offset: 0x0003B868
		// (set) Token: 0x060028C6 RID: 10438 RVA: 0x0003D6AB File Offset: 0x0003B8AB
		public FBoneReference SourceBone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._SourceBone) == null)
				{
					result = (this._SourceBone = new FBoneReference(base.NativePtr + (IntPtr)FAnimNode_BoneDrivenController.__PropertyOffset_SourceBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_BoneDrivenController.__PropertyOffset_SourceBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x060028C7 RID: 10439 RVA: 0x0003D6CC File Offset: 0x0003B8CC
		// (set) Token: 0x060028C8 RID: 10440 RVA: 0x0003D6E0 File Offset: 0x0003B8E0
		[Nullable(2)]
		public unsafe UCurveFloat DrivingCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_BoneDrivenController.__PropertyOffset_DrivingCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_BoneDrivenController.__PropertyOffset_DrivingCurve, value);
			}
		}

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x060028C9 RID: 10441 RVA: 0x0003D6F5 File Offset: 0x0003B8F5
		// (set) Token: 0x060028CA RID: 10442 RVA: 0x0003D705 File Offset: 0x0003B905
		public unsafe float Multiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_BoneDrivenController.__PropertyOffset_Multiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_BoneDrivenController.__PropertyOffset_Multiplier) = value;
			}
		}

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x060028CB RID: 10443 RVA: 0x0003D716 File Offset: 0x0003B916
		// (set) Token: 0x060028CC RID: 10444 RVA: 0x0003D726 File Offset: 0x0003B926
		public unsafe float RangeMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_BoneDrivenController.__PropertyOffset_RangeMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_BoneDrivenController.__PropertyOffset_RangeMin) = value;
			}
		}

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x060028CD RID: 10445 RVA: 0x0003D737 File Offset: 0x0003B937
		// (set) Token: 0x060028CE RID: 10446 RVA: 0x0003D747 File Offset: 0x0003B947
		public unsafe float RangeMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_BoneDrivenController.__PropertyOffset_RangeMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_BoneDrivenController.__PropertyOffset_RangeMax) = value;
			}
		}

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x060028CF RID: 10447 RVA: 0x0003D758 File Offset: 0x0003B958
		// (set) Token: 0x060028D0 RID: 10448 RVA: 0x0003D768 File Offset: 0x0003B968
		public unsafe float RemappedMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_BoneDrivenController.__PropertyOffset_RemappedMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_BoneDrivenController.__PropertyOffset_RemappedMin) = value;
			}
		}

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x060028D1 RID: 10449 RVA: 0x0003D779 File Offset: 0x0003B979
		// (set) Token: 0x060028D2 RID: 10450 RVA: 0x0003D789 File Offset: 0x0003B989
		public unsafe float RemappedMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_BoneDrivenController.__PropertyOffset_RemappedMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_BoneDrivenController.__PropertyOffset_RemappedMax) = value;
			}
		}

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x060028D3 RID: 10451 RVA: 0x0003D79A File Offset: 0x0003B99A
		// (set) Token: 0x060028D4 RID: 10452 RVA: 0x0003D7AE File Offset: 0x0003B9AE
		public unsafe FName ParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_BoneDrivenController.__PropertyOffset_ParameterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_BoneDrivenController.__PropertyOffset_ParameterName) = value;
			}
		}

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x060028D5 RID: 10453 RVA: 0x0003D7C4 File Offset: 0x0003B9C4
		// (set) Token: 0x060028D6 RID: 10454 RVA: 0x0003D807 File Offset: 0x0003BA07
		public FBoneReference TargetBone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._TargetBone) == null)
				{
					result = (this._TargetBone = new FBoneReference(base.NativePtr + (IntPtr)FAnimNode_BoneDrivenController.__PropertyOffset_TargetBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_BoneDrivenController.__PropertyOffset_TargetBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x060028D7 RID: 10455 RVA: 0x0003D828 File Offset: 0x0003BA28
		// (set) Token: 0x060028D8 RID: 10456 RVA: 0x0003D838 File Offset: 0x0003BA38
		public unsafe EDrivenDestinationMode DestinationMode
		{
			get
			{
				return (EDrivenDestinationMode)(*(base.NativePtr + (IntPtr)FAnimNode_BoneDrivenController.__PropertyOffset_DestinationMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_BoneDrivenController.__PropertyOffset_DestinationMode) = (byte)value;
			}
		}

		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x060028D9 RID: 10457 RVA: 0x0003D849 File Offset: 0x0003BA49
		// (set) Token: 0x060028DA RID: 10458 RVA: 0x0003D859 File Offset: 0x0003BA59
		public unsafe EDrivenBoneModificationMode ModificationMode
		{
			get
			{
				return (EDrivenBoneModificationMode)(*(base.NativePtr + (IntPtr)FAnimNode_BoneDrivenController.__PropertyOffset_ModificationMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_BoneDrivenController.__PropertyOffset_ModificationMode) = (byte)value;
			}
		}

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x060028DB RID: 10459 RVA: 0x0003D86A File Offset: 0x0003BA6A
		// (set) Token: 0x060028DC RID: 10460 RVA: 0x0003D87E File Offset: 0x0003BA7E
		[Nullable(0)]
		public unsafe TEnumAsByte<EComponentType> SourceComponent
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_BoneDrivenController.__PropertyOffset_SourceComponent);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_BoneDrivenController.__PropertyOffset_SourceComponent) = value;
			}
		}

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x060028DD RID: 10461 RVA: 0x0003D893 File Offset: 0x0003BA93
		// (set) Token: 0x060028DE RID: 10462 RVA: 0x0003D8AC File Offset: 0x0003BAAC
		public unsafe bool bUseRange
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_BoneDrivenController.__PropertyOffset_bUseRange) & FAnimNode_BoneDrivenController.__PropertyMask_bUseRange) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_BoneDrivenController.__PropertyOffset_bUseRange) = ((*(base.NativePtr + (IntPtr)FAnimNode_BoneDrivenController.__PropertyOffset_bUseRange) & ~FAnimNode_BoneDrivenController.__PropertyMask_bUseRange) | (value ? FAnimNode_BoneDrivenController.__PropertyMask_bUseRange : 0));
			}
		}

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x060028DF RID: 10463 RVA: 0x0003D8DC File Offset: 0x0003BADC
		// (set) Token: 0x060028E0 RID: 10464 RVA: 0x0003D8F5 File Offset: 0x0003BAF5
		public unsafe bool bAffectTargetTranslationX
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_BoneDrivenController.__PropertyOffset_bAffectTargetTranslationX) & FAnimNode_BoneDrivenController.__PropertyMask_bAffectTargetTranslationX) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_BoneDrivenController.__PropertyOffset_bAffectTargetTranslationX) = ((*(base.NativePtr + (IntPtr)FAnimNode_BoneDrivenController.__PropertyOffset_bAffectTargetTranslationX) & ~FAnimNode_BoneDrivenController.__PropertyMask_bAffectTargetTranslationX) | (value ? FAnimNode_BoneDrivenController.__PropertyMask_bAffectTargetTranslationX : 0));
			}
		}

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x060028E1 RID: 10465 RVA: 0x0003D925 File Offset: 0x0003BB25
		// (set) Token: 0x060028E2 RID: 10466 RVA: 0x0003D93E File Offset: 0x0003BB3E
		public unsafe bool bAffectTargetTranslationY
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_BoneDrivenController.__PropertyOffset_bAffectTargetTranslationY) & FAnimNode_BoneDrivenController.__PropertyMask_bAffectTargetTranslationY) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_BoneDrivenController.__PropertyOffset_bAffectTargetTranslationY) = ((*(base.NativePtr + (IntPtr)FAnimNode_BoneDrivenController.__PropertyOffset_bAffectTargetTranslationY) & ~FAnimNode_BoneDrivenController.__PropertyMask_bAffectTargetTranslationY) | (value ? FAnimNode_BoneDrivenController.__PropertyMask_bAffectTargetTranslationY : 0));
			}
		}

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x060028E3 RID: 10467 RVA: 0x0003D96E File Offset: 0x0003BB6E
		// (set) Token: 0x060028E4 RID: 10468 RVA: 0x0003D987 File Offset: 0x0003BB87
		public unsafe bool bAffectTargetTranslationZ
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_BoneDrivenController.__PropertyOffset_bAffectTargetTranslationZ) & FAnimNode_BoneDrivenController.__PropertyMask_bAffectTargetTranslationZ) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_BoneDrivenController.__PropertyOffset_bAffectTargetTranslationZ) = ((*(base.NativePtr + (IntPtr)FAnimNode_BoneDrivenController.__PropertyOffset_bAffectTargetTranslationZ) & ~FAnimNode_BoneDrivenController.__PropertyMask_bAffectTargetTranslationZ) | (value ? FAnimNode_BoneDrivenController.__PropertyMask_bAffectTargetTranslationZ : 0));
			}
		}

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x060028E5 RID: 10469 RVA: 0x0003D9B7 File Offset: 0x0003BBB7
		// (set) Token: 0x060028E6 RID: 10470 RVA: 0x0003D9D0 File Offset: 0x0003BBD0
		public unsafe bool bAffectTargetRotationX
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_BoneDrivenController.__PropertyOffset_bAffectTargetRotationX) & FAnimNode_BoneDrivenController.__PropertyMask_bAffectTargetRotationX) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_BoneDrivenController.__PropertyOffset_bAffectTargetRotationX) = ((*(base.NativePtr + (IntPtr)FAnimNode_BoneDrivenController.__PropertyOffset_bAffectTargetRotationX) & ~FAnimNode_BoneDrivenController.__PropertyMask_bAffectTargetRotationX) | (value ? FAnimNode_BoneDrivenController.__PropertyMask_bAffectTargetRotationX : 0));
			}
		}

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x060028E7 RID: 10471 RVA: 0x0003DA00 File Offset: 0x0003BC00
		// (set) Token: 0x060028E8 RID: 10472 RVA: 0x0003DA19 File Offset: 0x0003BC19
		public unsafe bool bAffectTargetRotationY
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_BoneDrivenController.__PropertyOffset_bAffectTargetRotationY) & FAnimNode_BoneDrivenController.__PropertyMask_bAffectTargetRotationY) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_BoneDrivenController.__PropertyOffset_bAffectTargetRotationY) = ((*(base.NativePtr + (IntPtr)FAnimNode_BoneDrivenController.__PropertyOffset_bAffectTargetRotationY) & ~FAnimNode_BoneDrivenController.__PropertyMask_bAffectTargetRotationY) | (value ? FAnimNode_BoneDrivenController.__PropertyMask_bAffectTargetRotationY : 0));
			}
		}

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x060028E9 RID: 10473 RVA: 0x0003DA49 File Offset: 0x0003BC49
		// (set) Token: 0x060028EA RID: 10474 RVA: 0x0003DA62 File Offset: 0x0003BC62
		public unsafe bool bAffectTargetRotationZ
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_BoneDrivenController.__PropertyOffset_bAffectTargetRotationZ) & FAnimNode_BoneDrivenController.__PropertyMask_bAffectTargetRotationZ) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_BoneDrivenController.__PropertyOffset_bAffectTargetRotationZ) = ((*(base.NativePtr + (IntPtr)FAnimNode_BoneDrivenController.__PropertyOffset_bAffectTargetRotationZ) & ~FAnimNode_BoneDrivenController.__PropertyMask_bAffectTargetRotationZ) | (value ? FAnimNode_BoneDrivenController.__PropertyMask_bAffectTargetRotationZ : 0));
			}
		}

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x060028EB RID: 10475 RVA: 0x0003DA92 File Offset: 0x0003BC92
		// (set) Token: 0x060028EC RID: 10476 RVA: 0x0003DAAB File Offset: 0x0003BCAB
		public unsafe bool bAffectTargetScaleX
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_BoneDrivenController.__PropertyOffset_bAffectTargetScaleX) & FAnimNode_BoneDrivenController.__PropertyMask_bAffectTargetScaleX) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_BoneDrivenController.__PropertyOffset_bAffectTargetScaleX) = ((*(base.NativePtr + (IntPtr)FAnimNode_BoneDrivenController.__PropertyOffset_bAffectTargetScaleX) & ~FAnimNode_BoneDrivenController.__PropertyMask_bAffectTargetScaleX) | (value ? FAnimNode_BoneDrivenController.__PropertyMask_bAffectTargetScaleX : 0));
			}
		}

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x060028ED RID: 10477 RVA: 0x0003DADB File Offset: 0x0003BCDB
		// (set) Token: 0x060028EE RID: 10478 RVA: 0x0003DAF4 File Offset: 0x0003BCF4
		public unsafe bool bAffectTargetScaleY
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_BoneDrivenController.__PropertyOffset_bAffectTargetScaleY) & FAnimNode_BoneDrivenController.__PropertyMask_bAffectTargetScaleY) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_BoneDrivenController.__PropertyOffset_bAffectTargetScaleY) = ((*(base.NativePtr + (IntPtr)FAnimNode_BoneDrivenController.__PropertyOffset_bAffectTargetScaleY) & ~FAnimNode_BoneDrivenController.__PropertyMask_bAffectTargetScaleY) | (value ? FAnimNode_BoneDrivenController.__PropertyMask_bAffectTargetScaleY : 0));
			}
		}

		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x060028EF RID: 10479 RVA: 0x0003DB24 File Offset: 0x0003BD24
		// (set) Token: 0x060028F0 RID: 10480 RVA: 0x0003DB3D File Offset: 0x0003BD3D
		public unsafe bool bAffectTargetScaleZ
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_BoneDrivenController.__PropertyOffset_bAffectTargetScaleZ) & FAnimNode_BoneDrivenController.__PropertyMask_bAffectTargetScaleZ) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_BoneDrivenController.__PropertyOffset_bAffectTargetScaleZ) = ((*(base.NativePtr + (IntPtr)FAnimNode_BoneDrivenController.__PropertyOffset_bAffectTargetScaleZ) & ~FAnimNode_BoneDrivenController.__PropertyMask_bAffectTargetScaleZ) | (value ? FAnimNode_BoneDrivenController.__PropertyMask_bAffectTargetScaleZ : 0));
			}
		}

		// Token: 0x060028F1 RID: 10481 RVA: 0x0003DB6D File Offset: 0x0003BD6D
		public FAnimNode_BoneDrivenController()
		{
		}

		// Token: 0x060028F2 RID: 10482 RVA: 0x0003DB78 File Offset: 0x0003BD78
		public FAnimNode_BoneDrivenController(FBoneReference SourceBone, UCurveFloat DrivingCurve, float Multiplier, float RangeMin, float RangeMax, float RemappedMin, float RemappedMax, FName ParameterName, FBoneReference TargetBone, [Nullable(0)] TEnumAsByte<EComponentType> TargetComponent_DEPRECATED, EDrivenDestinationMode DestinationMode, EDrivenBoneModificationMode ModificationMode, [Nullable(0)] TEnumAsByte<EComponentType> SourceComponent, bool bUseRange, bool bAffectTargetTranslationX, bool bAffectTargetTranslationY, bool bAffectTargetTranslationZ, bool bAffectTargetRotationX, bool bAffectTargetRotationY, bool bAffectTargetRotationZ, bool bAffectTargetScaleX, bool bAffectTargetScaleY, bool bAffectTargetScaleZ, FComponentSpacePoseLink ComponentPose, int LODThreshold, int KuroLODMask, float ActualAlpha, EAnimAlphaInputType AlphaInputType, bool bAlphaBoolEnabled, bool bParallelEvalEnabled, bool bEnableOnMobile, float Alpha, FInputScaleBias AlphaScaleBias, FInputAlphaBoolBlend AlphaBoolBlend, FName AlphaCurveName, FInputScaleBiasClamp AlphaScaleBiasClamp)
		{
			this.SourceBone = SourceBone;
			this.DrivingCurve = DrivingCurve;
			this.Multiplier = Multiplier;
			this.RangeMin = RangeMin;
			this.RangeMax = RangeMax;
			this.RemappedMin = RemappedMin;
			this.RemappedMax = RemappedMax;
			this.ParameterName = ParameterName;
			this.TargetBone = TargetBone;
			this.DestinationMode = DestinationMode;
			this.ModificationMode = ModificationMode;
			this.SourceComponent = SourceComponent;
			this.bUseRange = bUseRange;
			this.bAffectTargetTranslationX = bAffectTargetTranslationX;
			this.bAffectTargetTranslationY = bAffectTargetTranslationY;
			this.bAffectTargetTranslationZ = bAffectTargetTranslationZ;
			this.bAffectTargetRotationX = bAffectTargetRotationX;
			this.bAffectTargetRotationY = bAffectTargetRotationY;
			this.bAffectTargetRotationZ = bAffectTargetRotationZ;
			this.bAffectTargetScaleX = bAffectTargetScaleX;
			this.bAffectTargetScaleY = bAffectTargetScaleY;
			this.bAffectTargetScaleZ = bAffectTargetScaleZ;
			base.ComponentPose = ComponentPose;
			base.LODThreshold = LODThreshold;
			base.KuroLODMask = KuroLODMask;
			base.ActualAlpha = ActualAlpha;
			base.AlphaInputType = AlphaInputType;
			base.bAlphaBoolEnabled = bAlphaBoolEnabled;
			base.bParallelEvalEnabled = bParallelEvalEnabled;
			base.bEnableOnMobile = bEnableOnMobile;
			base.Alpha = Alpha;
			base.AlphaScaleBias = AlphaScaleBias;
			base.AlphaBoolBlend = AlphaBoolBlend;
			base.AlphaCurveName = AlphaCurveName;
			base.AlphaScaleBiasClamp = AlphaScaleBiasClamp;
		}

		// Token: 0x060028F3 RID: 10483 RVA: 0x0003DCA0 File Offset: 0x0003BEA0
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_BoneDrivenController.StaticStruct();
		}

		// Token: 0x060028F4 RID: 10484 RVA: 0x0003DCAC File Offset: 0x0003BEAC
		[NullableContext(2)]
		public FAnimNode_BoneDrivenController(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060028F5 RID: 10485 RVA: 0x0003DCB6 File Offset: 0x0003BEB6
		public FAnimNode_BoneDrivenController(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060028F6 RID: 10486 RVA: 0x0003DCC1 File Offset: 0x0003BEC1
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_BoneDrivenController(Pointer, false, true);
		}

		// Token: 0x060028F7 RID: 10487 RVA: 0x0003DCCB File Offset: 0x0003BECB
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_BoneDrivenController(Pointer, MemoryOwner);
		}

		// Token: 0x0400103D RID: 4157
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_BoneDrivenController";

		// Token: 0x0400103E RID: 4158
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400103F RID: 4159
		internal static int __PropertyOffset_SourceBone;

		// Token: 0x04001040 RID: 4160
		[Nullable(2)]
		private FBoneReference _SourceBone;

		// Token: 0x04001041 RID: 4161
		internal static int __PropertyOffset_DrivingCurve;

		// Token: 0x04001042 RID: 4162
		internal static int __PropertyOffset_Multiplier;

		// Token: 0x04001043 RID: 4163
		internal static int __PropertyOffset_RangeMin;

		// Token: 0x04001044 RID: 4164
		internal static int __PropertyOffset_RangeMax;

		// Token: 0x04001045 RID: 4165
		internal static int __PropertyOffset_RemappedMin;

		// Token: 0x04001046 RID: 4166
		internal static int __PropertyOffset_RemappedMax;

		// Token: 0x04001047 RID: 4167
		internal static int __PropertyOffset_ParameterName;

		// Token: 0x04001048 RID: 4168
		internal static int __PropertyOffset_TargetBone;

		// Token: 0x04001049 RID: 4169
		[Nullable(2)]
		private FBoneReference _TargetBone;

		// Token: 0x0400104A RID: 4170
		internal static int __PropertyOffset_DestinationMode;

		// Token: 0x0400104B RID: 4171
		internal static int __PropertyOffset_ModificationMode;

		// Token: 0x0400104C RID: 4172
		internal static int __PropertyOffset_SourceComponent;

		// Token: 0x0400104D RID: 4173
		internal static int __PropertyOffset_bUseRange;

		// Token: 0x0400104E RID: 4174
		internal static byte __PropertyMask_bUseRange;

		// Token: 0x0400104F RID: 4175
		internal static int __PropertyOffset_bAffectTargetTranslationX;

		// Token: 0x04001050 RID: 4176
		internal static byte __PropertyMask_bAffectTargetTranslationX;

		// Token: 0x04001051 RID: 4177
		internal static int __PropertyOffset_bAffectTargetTranslationY;

		// Token: 0x04001052 RID: 4178
		internal static byte __PropertyMask_bAffectTargetTranslationY;

		// Token: 0x04001053 RID: 4179
		internal static int __PropertyOffset_bAffectTargetTranslationZ;

		// Token: 0x04001054 RID: 4180
		internal static byte __PropertyMask_bAffectTargetTranslationZ;

		// Token: 0x04001055 RID: 4181
		internal static int __PropertyOffset_bAffectTargetRotationX;

		// Token: 0x04001056 RID: 4182
		internal static byte __PropertyMask_bAffectTargetRotationX;

		// Token: 0x04001057 RID: 4183
		internal static int __PropertyOffset_bAffectTargetRotationY;

		// Token: 0x04001058 RID: 4184
		internal static byte __PropertyMask_bAffectTargetRotationY;

		// Token: 0x04001059 RID: 4185
		internal static int __PropertyOffset_bAffectTargetRotationZ;

		// Token: 0x0400105A RID: 4186
		internal static byte __PropertyMask_bAffectTargetRotationZ;

		// Token: 0x0400105B RID: 4187
		internal static int __PropertyOffset_bAffectTargetScaleX;

		// Token: 0x0400105C RID: 4188
		internal static byte __PropertyMask_bAffectTargetScaleX;

		// Token: 0x0400105D RID: 4189
		internal static int __PropertyOffset_bAffectTargetScaleY;

		// Token: 0x0400105E RID: 4190
		internal static byte __PropertyMask_bAffectTargetScaleY;

		// Token: 0x0400105F RID: 4191
		internal static int __PropertyOffset_bAffectTargetScaleZ;

		// Token: 0x04001060 RID: 4192
		internal static byte __PropertyMask_bAffectTargetScaleZ;
	}
}
