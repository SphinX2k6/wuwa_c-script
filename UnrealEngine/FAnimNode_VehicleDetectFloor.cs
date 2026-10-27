using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001624 RID: 5668
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.AnimNode_VehicleDetectFloor")]
	[UnrealStructLayout(640, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 640)]
	public class FAnimNode_VehicleDetectFloor : FAnimNode_SkeletalControlBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060147F8 RID: 83960 RVA: 0x001E2760 File Offset: 0x001E0960
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_VehicleDetectFloor._ScriptStructPtr != 0) ? FAnimNode_VehicleDetectFloor._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.AnimNode_VehicleDetectFloor", ref FAnimNode_VehicleDetectFloor._ScriptStructPtr);
		}

		// Token: 0x170050AE RID: 20654
		// (get) Token: 0x060147F9 RID: 83961 RVA: 0x001E2784 File Offset: 0x001E0984
		// (set) Token: 0x060147FA RID: 83962 RVA: 0x001E27C7 File Offset: 0x001E09C7
		public FBoneReference BodyBone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._BodyBone) == null)
				{
					result = (this._BodyBone = new FBoneReference(base.NativePtr + (IntPtr)FAnimNode_VehicleDetectFloor.__PropertyOffset_BodyBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_VehicleDetectFloor.__PropertyOffset_BodyBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170050AF RID: 20655
		// (get) Token: 0x060147FB RID: 83963 RVA: 0x001E27E8 File Offset: 0x001E09E8
		// (set) Token: 0x060147FC RID: 83964 RVA: 0x001E282B File Offset: 0x001E0A2B
		public TArray<FVehicleWheelData> Wheels
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVehicleWheelData> result;
				if ((result = this._Wheels) == null)
				{
					result = (this._Wheels = new TArray<FVehicleWheelData>(base.NativePtr + (IntPtr)FAnimNode_VehicleDetectFloor.__PropertyOffset_Wheels, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Wheels.CopyAssign(value);
			}
		}

		// Token: 0x170050B0 RID: 20656
		// (get) Token: 0x060147FD RID: 83965 RVA: 0x001E2839 File Offset: 0x001E0A39
		// (set) Token: 0x060147FE RID: 83966 RVA: 0x001E2849 File Offset: 0x001E0A49
		public unsafe float WheelAutoTurnToForwardAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_VehicleDetectFloor.__PropertyOffset_WheelAutoTurnToForwardAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_VehicleDetectFloor.__PropertyOffset_WheelAutoTurnToForwardAlpha) = value;
			}
		}

		// Token: 0x170050B1 RID: 20657
		// (get) Token: 0x060147FF RID: 83967 RVA: 0x001E285C File Offset: 0x001E0A5C
		// (set) Token: 0x06014800 RID: 83968 RVA: 0x001E289F File Offset: 0x001E0A9F
		public TArray<FTrailerConnector> Connectors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTrailerConnector> result;
				if ((result = this._Connectors) == null)
				{
					result = (this._Connectors = new TArray<FTrailerConnector>(base.NativePtr + (IntPtr)FAnimNode_VehicleDetectFloor.__PropertyOffset_Connectors, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Connectors.CopyAssign(value);
			}
		}

		// Token: 0x170050B2 RID: 20658
		// (get) Token: 0x06014801 RID: 83969 RVA: 0x001E28B0 File Offset: 0x001E0AB0
		// (set) Token: 0x06014802 RID: 83970 RVA: 0x001E28F3 File Offset: 0x001E0AF3
		public TArray<FVehicleWheelData> TrailerWheels
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVehicleWheelData> result;
				if ((result = this._TrailerWheels) == null)
				{
					result = (this._TrailerWheels = new TArray<FVehicleWheelData>(base.NativePtr + (IntPtr)FAnimNode_VehicleDetectFloor.__PropertyOffset_TrailerWheels, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TrailerWheels.CopyAssign(value);
			}
		}

		// Token: 0x170050B3 RID: 20659
		// (get) Token: 0x06014803 RID: 83971 RVA: 0x001E2901 File Offset: 0x001E0B01
		// (set) Token: 0x06014804 RID: 83972 RVA: 0x001E2911 File Offset: 0x001E0B11
		public unsafe float TrailerYawLag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_VehicleDetectFloor.__PropertyOffset_TrailerYawLag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_VehicleDetectFloor.__PropertyOffset_TrailerYawLag) = value;
			}
		}

		// Token: 0x170050B4 RID: 20660
		// (get) Token: 0x06014805 RID: 83973 RVA: 0x001E2922 File Offset: 0x001E0B22
		// (set) Token: 0x06014806 RID: 83974 RVA: 0x001E2932 File Offset: 0x001E0B32
		public unsafe float TrailerPitchLag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_VehicleDetectFloor.__PropertyOffset_TrailerPitchLag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_VehicleDetectFloor.__PropertyOffset_TrailerPitchLag) = value;
			}
		}

		// Token: 0x170050B5 RID: 20661
		// (get) Token: 0x06014807 RID: 83975 RVA: 0x001E2943 File Offset: 0x001E0B43
		// (set) Token: 0x06014808 RID: 83976 RVA: 0x001E2953 File Offset: 0x001E0B53
		public unsafe float TrailerSoftLimitDeg
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_VehicleDetectFloor.__PropertyOffset_TrailerSoftLimitDeg);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_VehicleDetectFloor.__PropertyOffset_TrailerSoftLimitDeg) = value;
			}
		}

		// Token: 0x170050B6 RID: 20662
		// (get) Token: 0x06014809 RID: 83977 RVA: 0x001E2964 File Offset: 0x001E0B64
		// (set) Token: 0x0601480A RID: 83978 RVA: 0x001E2974 File Offset: 0x001E0B74
		public unsafe float ExtraTraceDown
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_VehicleDetectFloor.__PropertyOffset_ExtraTraceDown);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_VehicleDetectFloor.__PropertyOffset_ExtraTraceDown) = value;
			}
		}

		// Token: 0x170050B7 RID: 20663
		// (get) Token: 0x0601480B RID: 83979 RVA: 0x001E2985 File Offset: 0x001E0B85
		// (set) Token: 0x0601480C RID: 83980 RVA: 0x001E2999 File Offset: 0x001E0B99
		[Nullable(0)]
		public unsafe TEnumAsByte<ETraceTypeQuery> TraceChannel
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_VehicleDetectFloor.__PropertyOffset_TraceChannel);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_VehicleDetectFloor.__PropertyOffset_TraceChannel) = value;
			}
		}

		// Token: 0x170050B8 RID: 20664
		// (get) Token: 0x0601480D RID: 83981 RVA: 0x001E29AE File Offset: 0x001E0BAE
		// (set) Token: 0x0601480E RID: 83982 RVA: 0x001E29C2 File Offset: 0x001E0BC2
		[Nullable(0)]
		public unsafe TEnumAsByte<EAxis> RootUpAxis
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_VehicleDetectFloor.__PropertyOffset_RootUpAxis);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_VehicleDetectFloor.__PropertyOffset_RootUpAxis) = value;
			}
		}

		// Token: 0x170050B9 RID: 20665
		// (get) Token: 0x0601480F RID: 83983 RVA: 0x001E29D8 File Offset: 0x001E0BD8
		// (set) Token: 0x06014810 RID: 83984 RVA: 0x001E2A1B File Offset: 0x001E0C1B
		public FVehicleAxisData BodyAxis
		{
			get
			{
				base.FastCheckIsValid();
				FVehicleAxisData result;
				if ((result = this._BodyAxis) == null)
				{
					result = (this._BodyAxis = new FVehicleAxisData(base.NativePtr + (IntPtr)FAnimNode_VehicleDetectFloor.__PropertyOffset_BodyAxis, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FVehicleAxisData.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_VehicleDetectFloor.__PropertyOffset_BodyAxis, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170050BA RID: 20666
		// (get) Token: 0x06014811 RID: 83985 RVA: 0x001E2A3C File Offset: 0x001E0C3C
		// (set) Token: 0x06014812 RID: 83986 RVA: 0x001E2A4C File Offset: 0x001E0C4C
		public unsafe float ChassisTiltMaxDist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_VehicleDetectFloor.__PropertyOffset_ChassisTiltMaxDist);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_VehicleDetectFloor.__PropertyOffset_ChassisTiltMaxDist) = value;
			}
		}

		// Token: 0x170050BB RID: 20667
		// (get) Token: 0x06014813 RID: 83987 RVA: 0x001E2A5D File Offset: 0x001E0C5D
		// (set) Token: 0x06014814 RID: 83988 RVA: 0x001E2A6D File Offset: 0x001E0C6D
		public unsafe bool bApplyChassisVerticalOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_VehicleDetectFloor.__PropertyOffset_bApplyChassisVerticalOffset) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_VehicleDetectFloor.__PropertyOffset_bApplyChassisVerticalOffset) = (value ? 1 : 0);
			}
		}

		// Token: 0x170050BC RID: 20668
		// (get) Token: 0x06014815 RID: 83989 RVA: 0x001E2A7E File Offset: 0x001E0C7E
		// (set) Token: 0x06014816 RID: 83990 RVA: 0x001E2A8E File Offset: 0x001E0C8E
		public unsafe float ChassisHeightLerp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_VehicleDetectFloor.__PropertyOffset_ChassisHeightLerp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_VehicleDetectFloor.__PropertyOffset_ChassisHeightLerp) = value;
			}
		}

		// Token: 0x170050BD RID: 20669
		// (get) Token: 0x06014817 RID: 83991 RVA: 0x001E2A9F File Offset: 0x001E0C9F
		// (set) Token: 0x06014818 RID: 83992 RVA: 0x001E2AAF File Offset: 0x001E0CAF
		public unsafe bool bDebugDraw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_VehicleDetectFloor.__PropertyOffset_bDebugDraw) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_VehicleDetectFloor.__PropertyOffset_bDebugDraw) = (value ? 1 : 0);
			}
		}

		// Token: 0x170050BE RID: 20670
		// (get) Token: 0x06014819 RID: 83993 RVA: 0x001E2AC0 File Offset: 0x001E0CC0
		// (set) Token: 0x0601481A RID: 83994 RVA: 0x001E2AD0 File Offset: 0x001E0CD0
		public unsafe bool bDebugLog
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_VehicleDetectFloor.__PropertyOffset_bDebugLog) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_VehicleDetectFloor.__PropertyOffset_bDebugLog) = (value ? 1 : 0);
			}
		}

		// Token: 0x170050BF RID: 20671
		// (get) Token: 0x0601481B RID: 83995 RVA: 0x001E2AE1 File Offset: 0x001E0CE1
		// (set) Token: 0x0601481C RID: 83996 RVA: 0x001E2AF1 File Offset: 0x001E0CF1
		public unsafe float PlaneNormalInterpSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_VehicleDetectFloor.__PropertyOffset_PlaneNormalInterpSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_VehicleDetectFloor.__PropertyOffset_PlaneNormalInterpSpeed) = value;
			}
		}

		// Token: 0x170050C0 RID: 20672
		// (get) Token: 0x0601481D RID: 83997 RVA: 0x001E2B02 File Offset: 0x001E0D02
		// (set) Token: 0x0601481E RID: 83998 RVA: 0x001E2B12 File Offset: 0x001E0D12
		public unsafe float PlaneHeightInterpSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_VehicleDetectFloor.__PropertyOffset_PlaneHeightInterpSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_VehicleDetectFloor.__PropertyOffset_PlaneHeightInterpSpeed) = value;
			}
		}

		// Token: 0x170050C1 RID: 20673
		// (get) Token: 0x0601481F RID: 83999 RVA: 0x001E2B23 File Offset: 0x001E0D23
		// (set) Token: 0x06014820 RID: 84000 RVA: 0x001E2B33 File Offset: 0x001E0D33
		public unsafe float NoContactPointWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_VehicleDetectFloor.__PropertyOffset_NoContactPointWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_VehicleDetectFloor.__PropertyOffset_NoContactPointWeight) = value;
			}
		}

		// Token: 0x170050C2 RID: 20674
		// (get) Token: 0x06014821 RID: 84001 RVA: 0x001E2B44 File Offset: 0x001E0D44
		// (set) Token: 0x06014822 RID: 84002 RVA: 0x001E2B54 File Offset: 0x001E0D54
		public unsafe float DefaultChassisHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_VehicleDetectFloor.__PropertyOffset_DefaultChassisHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_VehicleDetectFloor.__PropertyOffset_DefaultChassisHeight) = value;
			}
		}

		// Token: 0x170050C3 RID: 20675
		// (get) Token: 0x06014823 RID: 84003 RVA: 0x001E2B65 File Offset: 0x001E0D65
		// (set) Token: 0x06014824 RID: 84004 RVA: 0x001E2B75 File Offset: 0x001E0D75
		public unsafe bool EnableChassisAdjust
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_VehicleDetectFloor.__PropertyOffset_EnableChassisAdjust) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_VehicleDetectFloor.__PropertyOffset_EnableChassisAdjust) = (value ? 1 : 0);
			}
		}

		// Token: 0x06014825 RID: 84005 RVA: 0x001E2B86 File Offset: 0x001E0D86
		public FAnimNode_VehicleDetectFloor()
		{
		}

		// Token: 0x06014826 RID: 84006 RVA: 0x001E2B90 File Offset: 0x001E0D90
		public FAnimNode_VehicleDetectFloor(FBoneReference BodyBone, TArray<FVehicleWheelData> Wheels, float WheelAutoTurnToForwardAlpha, TArray<FTrailerConnector> Connectors, TArray<FVehicleWheelData> TrailerWheels, float TrailerYawLag, float TrailerPitchLag, float TrailerSoftLimitDeg, float ExtraTraceDown, [Nullable(0)] TEnumAsByte<ETraceTypeQuery> TraceChannel, [Nullable(0)] TEnumAsByte<EAxis> RootUpAxis, FVehicleAxisData BodyAxis, float ChassisTiltMaxDist, bool bApplyChassisVerticalOffset, float ChassisHeightLerp, bool bDebugDraw, bool bDebugLog, float PlaneNormalInterpSpeed, float PlaneHeightInterpSpeed, float NoContactPointWeight, float DefaultChassisHeight, bool EnableChassisAdjust, FComponentSpacePoseLink ComponentPose, int LODThreshold, int KuroLODMask, float ActualAlpha, EAnimAlphaInputType AlphaInputType, bool bAlphaBoolEnabled, bool bParallelEvalEnabled, bool bEnableOnMobile, float Alpha, FInputScaleBias AlphaScaleBias, FInputAlphaBoolBlend AlphaBoolBlend, FName AlphaCurveName, FInputScaleBiasClamp AlphaScaleBiasClamp)
		{
			this.BodyBone = BodyBone;
			this.Wheels = Wheels;
			this.WheelAutoTurnToForwardAlpha = WheelAutoTurnToForwardAlpha;
			this.Connectors = Connectors;
			this.TrailerWheels = TrailerWheels;
			this.TrailerYawLag = TrailerYawLag;
			this.TrailerPitchLag = TrailerPitchLag;
			this.TrailerSoftLimitDeg = TrailerSoftLimitDeg;
			this.ExtraTraceDown = ExtraTraceDown;
			this.TraceChannel = TraceChannel;
			this.RootUpAxis = RootUpAxis;
			this.BodyAxis = BodyAxis;
			this.ChassisTiltMaxDist = ChassisTiltMaxDist;
			this.bApplyChassisVerticalOffset = bApplyChassisVerticalOffset;
			this.ChassisHeightLerp = ChassisHeightLerp;
			this.bDebugDraw = bDebugDraw;
			this.bDebugLog = bDebugLog;
			this.PlaneNormalInterpSpeed = PlaneNormalInterpSpeed;
			this.PlaneHeightInterpSpeed = PlaneHeightInterpSpeed;
			this.NoContactPointWeight = NoContactPointWeight;
			this.DefaultChassisHeight = DefaultChassisHeight;
			this.EnableChassisAdjust = EnableChassisAdjust;
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

		// Token: 0x06014827 RID: 84007 RVA: 0x001E2CB8 File Offset: 0x001E0EB8
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_VehicleDetectFloor.StaticStruct();
		}

		// Token: 0x06014828 RID: 84008 RVA: 0x001E2CC4 File Offset: 0x001E0EC4
		[NullableContext(2)]
		public FAnimNode_VehicleDetectFloor(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014829 RID: 84009 RVA: 0x001E2CCE File Offset: 0x001E0ECE
		public FAnimNode_VehicleDetectFloor(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601482A RID: 84010 RVA: 0x001E2CD9 File Offset: 0x001E0ED9
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_VehicleDetectFloor(Pointer, false, true);
		}

		// Token: 0x0601482B RID: 84011 RVA: 0x001E2CE3 File Offset: 0x001E0EE3
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_VehicleDetectFloor(Pointer, MemoryOwner);
		}

		// Token: 0x0400B25F RID: 45663
		public new const string __ObjectPath = "/Script/KuroAnim.AnimNode_VehicleDetectFloor";

		// Token: 0x0400B260 RID: 45664
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B261 RID: 45665
		internal static int __PropertyOffset_BodyBone;

		// Token: 0x0400B262 RID: 45666
		[Nullable(2)]
		private FBoneReference _BodyBone;

		// Token: 0x0400B263 RID: 45667
		internal static int __PropertyOffset_Wheels;

		// Token: 0x0400B264 RID: 45668
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FVehicleWheelData> _Wheels;

		// Token: 0x0400B265 RID: 45669
		internal static int __PropertyOffset_WheelAutoTurnToForwardAlpha;

		// Token: 0x0400B266 RID: 45670
		internal static int __PropertyOffset_Connectors;

		// Token: 0x0400B267 RID: 45671
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FTrailerConnector> _Connectors;

		// Token: 0x0400B268 RID: 45672
		internal static int __PropertyOffset_TrailerWheels;

		// Token: 0x0400B269 RID: 45673
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FVehicleWheelData> _TrailerWheels;

		// Token: 0x0400B26A RID: 45674
		internal static int __PropertyOffset_TrailerYawLag;

		// Token: 0x0400B26B RID: 45675
		internal static int __PropertyOffset_TrailerPitchLag;

		// Token: 0x0400B26C RID: 45676
		internal static int __PropertyOffset_TrailerSoftLimitDeg;

		// Token: 0x0400B26D RID: 45677
		internal static int __PropertyOffset_ExtraTraceDown;

		// Token: 0x0400B26E RID: 45678
		internal static int __PropertyOffset_TraceChannel;

		// Token: 0x0400B26F RID: 45679
		internal static int __PropertyOffset_RootUpAxis;

		// Token: 0x0400B270 RID: 45680
		internal static int __PropertyOffset_BodyAxis;

		// Token: 0x0400B271 RID: 45681
		[Nullable(2)]
		private FVehicleAxisData _BodyAxis;

		// Token: 0x0400B272 RID: 45682
		internal static int __PropertyOffset_ChassisTiltMaxDist;

		// Token: 0x0400B273 RID: 45683
		internal static int __PropertyOffset_bApplyChassisVerticalOffset;

		// Token: 0x0400B274 RID: 45684
		internal static int __PropertyOffset_ChassisHeightLerp;

		// Token: 0x0400B275 RID: 45685
		internal static int __PropertyOffset_bDebugDraw;

		// Token: 0x0400B276 RID: 45686
		internal static int __PropertyOffset_bDebugLog;

		// Token: 0x0400B277 RID: 45687
		internal static int __PropertyOffset_PlaneNormalInterpSpeed;

		// Token: 0x0400B278 RID: 45688
		internal static int __PropertyOffset_PlaneHeightInterpSpeed;

		// Token: 0x0400B279 RID: 45689
		internal static int __PropertyOffset_NoContactPointWeight;

		// Token: 0x0400B27A RID: 45690
		internal static int __PropertyOffset_DefaultChassisHeight;

		// Token: 0x0400B27B RID: 45691
		internal static int __PropertyOffset_EnableChassisAdjust;
	}
}
