using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020015C6 RID: 5574
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KawaiiPhysics.AnimNode_KawaiiPhysics")]
	[UnrealStructLayout(784, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 784)]
	public class FAnimNode_KawaiiPhysics : FAnimNode_KawaiiPhysicsBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014176 RID: 82294 RVA: 0x001D7F06 File Offset: 0x001D6106
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_KawaiiPhysics._ScriptStructPtr != 0) ? FAnimNode_KawaiiPhysics._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KawaiiPhysics.AnimNode_KawaiiPhysics", ref FAnimNode_KawaiiPhysics._ScriptStructPtr);
		}

		// Token: 0x17004EB4 RID: 20148
		// (get) Token: 0x06014177 RID: 82295 RVA: 0x001D7F2C File Offset: 0x001D612C
		// (set) Token: 0x06014178 RID: 82296 RVA: 0x001D7F6F File Offset: 0x001D616F
		public FBoneReference RootBone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._RootBone) == null)
				{
					result = (this._RootBone = new FBoneReference(base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysics.__PropertyOffset_RootBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_KawaiiPhysics.__PropertyOffset_RootBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06014179 RID: 82297 RVA: 0x001D7F90 File Offset: 0x001D6190
		public FAnimNode_KawaiiPhysics()
		{
		}

		// Token: 0x0601417A RID: 82298 RVA: 0x001D7F98 File Offset: 0x001D6198
		public FAnimNode_KawaiiPhysics(FBoneReference RootBone, TArray<FBoneReference> ExcludeBones, bool bDebugEnableAdjustBone, int TargetFramerate, bool OverrideTargetFramerate, int IgnoreMechanicsLevel, bool bNewIgnoreMechanics, FKawaiiPhysicsSettings PhysicsSettings, UCurveFloat DampingCurve, UCurveFloat WorldDampingLocationCurve, UCurveFloat WorldDampingRotationCurve, UCurveFloat StiffnessCurve, UCurveFloat RadiusCurve, UCurveFloat HalfWidthCurve, UCurveFloat LimitAngleCurve, bool bUpdatePhysicsSettingsInGame, float DummyBoneLength, EBoneForwardAxis BoneForwardAxis, EPlanarConstraint PlanarConstraint, TArray<FSphericalLimit> SphericalLimits, TArray<FCapsuleLimit> CapsuleLimits, TArray<FPlanarLimit> PlanarLimits, UKawaiiPhysicsLimitsDataAsset LimitsDataAsset, TArray<FSphericalLimit> SphericalLimitsData, TArray<FCapsuleLimit> CapsuleLimitsData, TArray<FPlanarLimit> PlanarLimitsData, float TeleportDistanceThreshold, float TeleportRotationThreshold, FVector Gravity, bool bEnableWind, float WindScale, TArray<FKawaiiPhysicsModifyBone> ModifyBones, bool bEnableSimulate, float AlphaScale, float TotalBoneLength, FTransform PreSkelCompTransform, bool bInitPhysicsSettings, bool bEditing, FComponentSpacePoseLink ComponentPose, int LODThreshold, int KuroLODMask, float ActualAlpha, EAnimAlphaInputType AlphaInputType, bool bAlphaBoolEnabled, bool bParallelEvalEnabled, bool bEnableOnMobile, float Alpha, FInputScaleBias AlphaScaleBias, FInputAlphaBoolBlend AlphaBoolBlend, FName AlphaCurveName, FInputScaleBiasClamp AlphaScaleBiasClamp)
		{
			this.RootBone = RootBone;
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

		// Token: 0x0601417B RID: 82299 RVA: 0x001D8131 File Offset: 0x001D6331
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_KawaiiPhysics.StaticStruct();
		}

		// Token: 0x0601417C RID: 82300 RVA: 0x001D813D File Offset: 0x001D633D
		[NullableContext(2)]
		public FAnimNode_KawaiiPhysics(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601417D RID: 82301 RVA: 0x001D8147 File Offset: 0x001D6347
		public FAnimNode_KawaiiPhysics(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601417E RID: 82302 RVA: 0x001D8152 File Offset: 0x001D6352
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_KawaiiPhysics(Pointer, false, true);
		}

		// Token: 0x0601417F RID: 82303 RVA: 0x001D815C File Offset: 0x001D635C
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_KawaiiPhysics(Pointer, MemoryOwner);
		}

		// Token: 0x0400AECB RID: 44747
		public new const string __ObjectPath = "/Script/KawaiiPhysics.AnimNode_KawaiiPhysics";

		// Token: 0x0400AECC RID: 44748
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400AECD RID: 44749
		internal static int __PropertyOffset_RootBone;

		// Token: 0x0400AECE RID: 44750
		[Nullable(2)]
		private FBoneReference _RootBone;
	}
}
