using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020015C8 RID: 5576
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KawaiiPhysics.AnimNode_KawaiiPhysicsGroup")]
	[UnrealStructLayout(864, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 864)]
	public class FAnimNode_KawaiiPhysicsGroup : FAnimNode_KawaiiPhysicsBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060141CE RID: 82382 RVA: 0x001D8A05 File Offset: 0x001D6C05
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_KawaiiPhysicsGroup._ScriptStructPtr != 0) ? FAnimNode_KawaiiPhysicsGroup._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KawaiiPhysics.AnimNode_KawaiiPhysicsGroup", ref FAnimNode_KawaiiPhysicsGroup._ScriptStructPtr);
		}

		// Token: 0x17004ED8 RID: 20184
		// (get) Token: 0x060141CF RID: 82383 RVA: 0x001D8A2C File Offset: 0x001D6C2C
		// (set) Token: 0x060141D0 RID: 82384 RVA: 0x001D8A6F File Offset: 0x001D6C6F
		public TArray<FBoneReference> RootBones
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBoneReference> result;
				if ((result = this._RootBones) == null)
				{
					result = (this._RootBones = new TArray<FBoneReference>(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsGroup.__PropertyOffset_RootBones, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.RootBones.CopyAssign(value);
			}
		}

		// Token: 0x17004ED9 RID: 20185
		// (get) Token: 0x060141D1 RID: 82385 RVA: 0x001D8A80 File Offset: 0x001D6C80
		// (set) Token: 0x060141D2 RID: 82386 RVA: 0x001D8AC3 File Offset: 0x001D6CC3
		public TArray<FKawaiiMultiFix> MultFixParamsArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKawaiiMultiFix> result;
				if ((result = this._MultFixParamsArray) == null)
				{
					result = (this._MultFixParamsArray = new TArray<FKawaiiMultiFix>(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsGroup.__PropertyOffset_MultFixParamsArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MultFixParamsArray.CopyAssign(value);
			}
		}

		// Token: 0x17004EDA RID: 20186
		// (get) Token: 0x060141D3 RID: 82387 RVA: 0x001D8AD1 File Offset: 0x001D6CD1
		// (set) Token: 0x060141D4 RID: 82388 RVA: 0x001D8AE1 File Offset: 0x001D6CE1
		public unsafe bool bUseInMultFix
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsGroup.__PropertyOffset_bUseInMultFix) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsGroup.__PropertyOffset_bUseInMultFix) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004EDB RID: 20187
		// (get) Token: 0x060141D5 RID: 82389 RVA: 0x001D8AF2 File Offset: 0x001D6CF2
		// (set) Token: 0x060141D6 RID: 82390 RVA: 0x001D8B02 File Offset: 0x001D6D02
		public unsafe float MultiFixMaxScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsGroup.__PropertyOffset_MultiFixMaxScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsGroup.__PropertyOffset_MultiFixMaxScale) = value;
			}
		}

		// Token: 0x17004EDC RID: 20188
		// (get) Token: 0x060141D7 RID: 82391 RVA: 0x001D8B13 File Offset: 0x001D6D13
		// (set) Token: 0x060141D8 RID: 82392 RVA: 0x001D8B23 File Offset: 0x001D6D23
		public unsafe float MultiFixGradientDescentAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsGroup.__PropertyOffset_MultiFixGradientDescentAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsGroup.__PropertyOffset_MultiFixGradientDescentAlpha) = value;
			}
		}

		// Token: 0x17004EDD RID: 20189
		// (get) Token: 0x060141D9 RID: 82393 RVA: 0x001D8B34 File Offset: 0x001D6D34
		// (set) Token: 0x060141DA RID: 82394 RVA: 0x001D8B44 File Offset: 0x001D6D44
		public unsafe int MultiFixMaxIter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsGroup.__PropertyOffset_MultiFixMaxIter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsGroup.__PropertyOffset_MultiFixMaxIter) = value;
			}
		}

		// Token: 0x17004EDE RID: 20190
		// (get) Token: 0x060141DB RID: 82395 RVA: 0x001D8B58 File Offset: 0x001D6D58
		// (set) Token: 0x060141DC RID: 82396 RVA: 0x001D8B9B File Offset: 0x001D6D9B
		public TArray<FKawaiiBoneBind> BindInfos
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKawaiiBoneBind> result;
				if ((result = this._BindInfos) == null)
				{
					result = (this._BindInfos = new TArray<FKawaiiBoneBind>(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsGroup.__PropertyOffset_BindInfos, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BindInfos.CopyAssign(value);
			}
		}

		// Token: 0x17004EDF RID: 20191
		// (get) Token: 0x060141DD RID: 82397 RVA: 0x001D8BA9 File Offset: 0x001D6DA9
		// (set) Token: 0x060141DE RID: 82398 RVA: 0x001D8BB9 File Offset: 0x001D6DB9
		public unsafe bool bBindLockRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsGroup.__PropertyOffset_bBindLockRotation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsGroup.__PropertyOffset_bBindLockRotation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004EE0 RID: 20192
		// (get) Token: 0x060141DF RID: 82399 RVA: 0x001D8BCA File Offset: 0x001D6DCA
		// (set) Token: 0x060141E0 RID: 82400 RVA: 0x001D8BDE File Offset: 0x001D6DDE
		[Nullable(2)]
		public unsafe UCurveFloat WindCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_KawaiiPhysicsGroup.__PropertyOffset_WindCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_KawaiiPhysicsGroup.__PropertyOffset_WindCurve, value);
			}
		}

		// Token: 0x17004EE1 RID: 20193
		// (get) Token: 0x060141E1 RID: 82401 RVA: 0x001D8BF3 File Offset: 0x001D6DF3
		// (set) Token: 0x060141E2 RID: 82402 RVA: 0x001D8C03 File Offset: 0x001D6E03
		public unsafe float StandardWindSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsGroup.__PropertyOffset_StandardWindSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsGroup.__PropertyOffset_StandardWindSpeed) = value;
			}
		}

		// Token: 0x17004EE2 RID: 20194
		// (get) Token: 0x060141E3 RID: 82403 RVA: 0x001D8C14 File Offset: 0x001D6E14
		// (set) Token: 0x060141E4 RID: 82404 RVA: 0x001D8C24 File Offset: 0x001D6E24
		public unsafe float DistanceToWindRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsGroup.__PropertyOffset_DistanceToWindRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysicsGroup.__PropertyOffset_DistanceToWindRate) = value;
			}
		}

		// Token: 0x060141E5 RID: 82405 RVA: 0x001D8C35 File Offset: 0x001D6E35
		public FAnimNode_KawaiiPhysicsGroup()
		{
		}

		// Token: 0x060141E6 RID: 82406 RVA: 0x001D8C40 File Offset: 0x001D6E40
		public FAnimNode_KawaiiPhysicsGroup(TArray<FBoneReference> RootBones, TArray<FKawaiiMultiFix> MultFixParamsArray, bool bUseInMultFix, float MultiFixMaxScale, float MultiFixGradientDescentAlpha, int MultiFixMaxIter, TArray<FKawaiiBoneBind> BindInfos, bool bBindLockRotation, UCurveFloat WindCurve, float StandardWindSpeed, float DistanceToWindRate, TArray<FBoneReference> ExcludeBones, bool bDebugEnableAdjustBone, int TargetFramerate, bool OverrideTargetFramerate, int IgnoreMechanicsLevel, bool bNewIgnoreMechanics, FKawaiiPhysicsSettings PhysicsSettings, UCurveFloat DampingCurve, UCurveFloat WorldDampingLocationCurve, UCurveFloat WorldDampingRotationCurve, UCurveFloat StiffnessCurve, UCurveFloat RadiusCurve, UCurveFloat HalfWidthCurve, UCurveFloat LimitAngleCurve, bool bUpdatePhysicsSettingsInGame, float DummyBoneLength, EBoneForwardAxis BoneForwardAxis, EPlanarConstraint PlanarConstraint, TArray<FSphericalLimit> SphericalLimits, TArray<FCapsuleLimit> CapsuleLimits, TArray<FPlanarLimit> PlanarLimits, UKawaiiPhysicsLimitsDataAsset LimitsDataAsset, TArray<FSphericalLimit> SphericalLimitsData, TArray<FCapsuleLimit> CapsuleLimitsData, TArray<FPlanarLimit> PlanarLimitsData, float TeleportDistanceThreshold, float TeleportRotationThreshold, FVector Gravity, bool bEnableWind, float WindScale, TArray<FKawaiiPhysicsModifyBone> ModifyBones, bool bEnableSimulate, float AlphaScale, float TotalBoneLength, FTransform PreSkelCompTransform, bool bInitPhysicsSettings, bool bEditing, FComponentSpacePoseLink ComponentPose, int LODThreshold, int KuroLODMask, float ActualAlpha, EAnimAlphaInputType AlphaInputType, bool bAlphaBoolEnabled, bool bParallelEvalEnabled, bool bEnableOnMobile, float Alpha, FInputScaleBias AlphaScaleBias, FInputAlphaBoolBlend AlphaBoolBlend, FName AlphaCurveName, FInputScaleBiasClamp AlphaScaleBiasClamp)
		{
			this.RootBones = RootBones;
			this.MultFixParamsArray = MultFixParamsArray;
			this.bUseInMultFix = bUseInMultFix;
			this.MultiFixMaxScale = MultiFixMaxScale;
			this.MultiFixGradientDescentAlpha = MultiFixGradientDescentAlpha;
			this.MultiFixMaxIter = MultiFixMaxIter;
			this.BindInfos = BindInfos;
			this.bBindLockRotation = bBindLockRotation;
			this.WindCurve = WindCurve;
			this.StandardWindSpeed = StandardWindSpeed;
			this.DistanceToWindRate = DistanceToWindRate;
			base.ExcludeBones = ExcludeBones;
			base.TargetFramerate = TargetFramerate;
			base.OverrideTargetFramerate = OverrideTargetFramerate;
			base.IgnoreMechanicsLevel = IgnoreMechanicsLevel;
			base.bNewIgnoreMechanics = bNewIgnoreMechanics;
			base.PhysicsSettings = PhysicsSettings;
			base.DampingCurve = DampingCurve;
			base.WorldDampingLocationCurve = WorldDampingLocationCurve;
			base.WorldDampingRotationCurve = WorldDampingRotationCurve;
			base.StiffnessCurve = StiffnessCurve;
			base.RadiusCurve = RadiusCurve;
			base.HalfWidthCurve = HalfWidthCurve;
			base.LimitAngleCurve = LimitAngleCurve;
			base.bUpdatePhysicsSettingsInGame = bUpdatePhysicsSettingsInGame;
			base.DummyBoneLength = DummyBoneLength;
			base.BoneForwardAxis = BoneForwardAxis;
			base.PlanarConstraint = PlanarConstraint;
			base.SphericalLimits = SphericalLimits;
			base.CapsuleLimits = CapsuleLimits;
			base.PlanarLimits = PlanarLimits;
			base.LimitsDataAsset = LimitsDataAsset;
			base.SphericalLimitsData = SphericalLimitsData;
			base.CapsuleLimitsData = CapsuleLimitsData;
			base.PlanarLimitsData = PlanarLimitsData;
			base.TeleportDistanceThreshold = TeleportDistanceThreshold;
			base.TeleportRotationThreshold = TeleportRotationThreshold;
			base.Gravity = Gravity;
			base.bEnableWind = bEnableWind;
			base.WindScale = WindScale;
			base.ModifyBones = ModifyBones;
			base.bEnableSimulate = bEnableSimulate;
			base.AlphaScale = AlphaScale;
			base.TotalBoneLength = TotalBoneLength;
			base.PreSkelCompTransform = PreSkelCompTransform;
			base.bInitPhysicsSettings = bInitPhysicsSettings;
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

		// Token: 0x060141E7 RID: 82407 RVA: 0x001D8E28 File Offset: 0x001D7028
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_KawaiiPhysicsGroup.StaticStruct();
		}

		// Token: 0x060141E8 RID: 82408 RVA: 0x001D8E34 File Offset: 0x001D7034
		[NullableContext(2)]
		public FAnimNode_KawaiiPhysicsGroup(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060141E9 RID: 82409 RVA: 0x001D8E3E File Offset: 0x001D703E
		public FAnimNode_KawaiiPhysicsGroup(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060141EA RID: 82410 RVA: 0x001D8E49 File Offset: 0x001D7049
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_KawaiiPhysicsGroup(Pointer, false, true);
		}

		// Token: 0x060141EB RID: 82411 RVA: 0x001D8E53 File Offset: 0x001D7053
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_KawaiiPhysicsGroup(Pointer, MemoryOwner);
		}

		// Token: 0x0400AEFD RID: 44797
		public new const string __ObjectPath = "/Script/KawaiiPhysics.AnimNode_KawaiiPhysicsGroup";

		// Token: 0x0400AEFE RID: 44798
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400AEFF RID: 44799
		internal static int __PropertyOffset_RootBones;

		// Token: 0x0400AF00 RID: 44800
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBoneReference> _RootBones;

		// Token: 0x0400AF01 RID: 44801
		internal static int __PropertyOffset_MultFixParamsArray;

		// Token: 0x0400AF02 RID: 44802
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKawaiiMultiFix> _MultFixParamsArray;

		// Token: 0x0400AF03 RID: 44803
		internal static int __PropertyOffset_bUseInMultFix;

		// Token: 0x0400AF04 RID: 44804
		internal static int __PropertyOffset_MultiFixMaxScale;

		// Token: 0x0400AF05 RID: 44805
		internal static int __PropertyOffset_MultiFixGradientDescentAlpha;

		// Token: 0x0400AF06 RID: 44806
		internal static int __PropertyOffset_MultiFixMaxIter;

		// Token: 0x0400AF07 RID: 44807
		internal static int __PropertyOffset_BindInfos;

		// Token: 0x0400AF08 RID: 44808
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKawaiiBoneBind> _BindInfos;

		// Token: 0x0400AF09 RID: 44809
		internal static int __PropertyOffset_bBindLockRotation;

		// Token: 0x0400AF0A RID: 44810
		internal static int __PropertyOffset_WindCurve;

		// Token: 0x0400AF0B RID: 44811
		internal static int __PropertyOffset_StandardWindSpeed;

		// Token: 0x0400AF0C RID: 44812
		internal static int __PropertyOffset_DistanceToWindRate;
	}
}
