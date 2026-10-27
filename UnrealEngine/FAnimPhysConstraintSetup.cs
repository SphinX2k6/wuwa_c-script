using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200030A RID: 778
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimPhysConstraintSetup")]
	[UnrealStructLayout(84, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 84)]
	public class FAnimPhysConstraintSetup : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002CF3 RID: 11507 RVA: 0x00045087 File Offset: 0x00043287
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimPhysConstraintSetup._ScriptStructPtr != 0) ? FAnimPhysConstraintSetup._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimPhysConstraintSetup", ref FAnimPhysConstraintSetup._ScriptStructPtr);
		}

		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x06002CF4 RID: 11508 RVA: 0x000450AB File Offset: 0x000432AB
		// (set) Token: 0x06002CF5 RID: 11509 RVA: 0x000450BB File Offset: 0x000432BB
		public unsafe AnimPhysLinearConstraintType LinearXLimitType
		{
			get
			{
				return (AnimPhysLinearConstraintType)(*(base.NativePtr + (IntPtr)FAnimPhysConstraintSetup.__PropertyOffset_LinearXLimitType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimPhysConstraintSetup.__PropertyOffset_LinearXLimitType) = (byte)value;
			}
		}

		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x06002CF6 RID: 11510 RVA: 0x000450CC File Offset: 0x000432CC
		// (set) Token: 0x06002CF7 RID: 11511 RVA: 0x000450DC File Offset: 0x000432DC
		public unsafe AnimPhysLinearConstraintType LinearYLimitType
		{
			get
			{
				return (AnimPhysLinearConstraintType)(*(base.NativePtr + (IntPtr)FAnimPhysConstraintSetup.__PropertyOffset_LinearYLimitType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimPhysConstraintSetup.__PropertyOffset_LinearYLimitType) = (byte)value;
			}
		}

		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x06002CF8 RID: 11512 RVA: 0x000450ED File Offset: 0x000432ED
		// (set) Token: 0x06002CF9 RID: 11513 RVA: 0x000450FD File Offset: 0x000432FD
		public unsafe AnimPhysLinearConstraintType LinearZLimitType
		{
			get
			{
				return (AnimPhysLinearConstraintType)(*(base.NativePtr + (IntPtr)FAnimPhysConstraintSetup.__PropertyOffset_LinearZLimitType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimPhysConstraintSetup.__PropertyOffset_LinearZLimitType) = (byte)value;
			}
		}

		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x06002CFA RID: 11514 RVA: 0x0004510E File Offset: 0x0004330E
		// (set) Token: 0x06002CFB RID: 11515 RVA: 0x00045122 File Offset: 0x00043322
		public unsafe FVector LinearAxesMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimPhysConstraintSetup.__PropertyOffset_LinearAxesMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimPhysConstraintSetup.__PropertyOffset_LinearAxesMin) = value;
			}
		}

		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x06002CFC RID: 11516 RVA: 0x00045137 File Offset: 0x00043337
		// (set) Token: 0x06002CFD RID: 11517 RVA: 0x0004514B File Offset: 0x0004334B
		public unsafe FVector LinearAxesMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimPhysConstraintSetup.__PropertyOffset_LinearAxesMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimPhysConstraintSetup.__PropertyOffset_LinearAxesMax) = value;
			}
		}

		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x06002CFE RID: 11518 RVA: 0x00045160 File Offset: 0x00043360
		// (set) Token: 0x06002CFF RID: 11519 RVA: 0x00045170 File Offset: 0x00043370
		public unsafe AnimPhysAngularConstraintType AngularConstraintType
		{
			get
			{
				return (AnimPhysAngularConstraintType)(*(base.NativePtr + (IntPtr)FAnimPhysConstraintSetup.__PropertyOffset_AngularConstraintType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimPhysConstraintSetup.__PropertyOffset_AngularConstraintType) = (byte)value;
			}
		}

		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x06002D00 RID: 11520 RVA: 0x00045181 File Offset: 0x00043381
		// (set) Token: 0x06002D01 RID: 11521 RVA: 0x00045191 File Offset: 0x00043391
		public unsafe AnimPhysTwistAxis TwistAxis
		{
			get
			{
				return (AnimPhysTwistAxis)(*(base.NativePtr + (IntPtr)FAnimPhysConstraintSetup.__PropertyOffset_TwistAxis));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimPhysConstraintSetup.__PropertyOffset_TwistAxis) = (byte)value;
			}
		}

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x06002D02 RID: 11522 RVA: 0x000451A2 File Offset: 0x000433A2
		// (set) Token: 0x06002D03 RID: 11523 RVA: 0x000451B2 File Offset: 0x000433B2
		public unsafe AnimPhysTwistAxis AngularTargetAxis
		{
			get
			{
				return (AnimPhysTwistAxis)(*(base.NativePtr + (IntPtr)FAnimPhysConstraintSetup.__PropertyOffset_AngularTargetAxis));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimPhysConstraintSetup.__PropertyOffset_AngularTargetAxis) = (byte)value;
			}
		}

		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x06002D04 RID: 11524 RVA: 0x000451C3 File Offset: 0x000433C3
		// (set) Token: 0x06002D05 RID: 11525 RVA: 0x000451D3 File Offset: 0x000433D3
		public unsafe float ConeAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimPhysConstraintSetup.__PropertyOffset_ConeAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimPhysConstraintSetup.__PropertyOffset_ConeAngle) = value;
			}
		}

		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x06002D06 RID: 11526 RVA: 0x000451E4 File Offset: 0x000433E4
		// (set) Token: 0x06002D07 RID: 11527 RVA: 0x000451F8 File Offset: 0x000433F8
		public unsafe FVector AngularLimitsMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimPhysConstraintSetup.__PropertyOffset_AngularLimitsMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimPhysConstraintSetup.__PropertyOffset_AngularLimitsMin) = value;
			}
		}

		// Token: 0x17000B35 RID: 2869
		// (get) Token: 0x06002D08 RID: 11528 RVA: 0x0004520D File Offset: 0x0004340D
		// (set) Token: 0x06002D09 RID: 11529 RVA: 0x00045221 File Offset: 0x00043421
		public unsafe FVector AngularLimitsMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimPhysConstraintSetup.__PropertyOffset_AngularLimitsMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimPhysConstraintSetup.__PropertyOffset_AngularLimitsMax) = value;
			}
		}

		// Token: 0x17000B36 RID: 2870
		// (get) Token: 0x06002D0A RID: 11530 RVA: 0x00045236 File Offset: 0x00043436
		// (set) Token: 0x06002D0B RID: 11531 RVA: 0x0004524A File Offset: 0x0004344A
		public unsafe FVector AngularTarget
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimPhysConstraintSetup.__PropertyOffset_AngularTarget);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimPhysConstraintSetup.__PropertyOffset_AngularTarget) = value;
			}
		}

		// Token: 0x06002D0C RID: 11532 RVA: 0x0004525F File Offset: 0x0004345F
		public FAnimPhysConstraintSetup()
		{
		}

		// Token: 0x06002D0D RID: 11533 RVA: 0x00045268 File Offset: 0x00043468
		public FAnimPhysConstraintSetup(AnimPhysLinearConstraintType LinearXLimitType, AnimPhysLinearConstraintType LinearYLimitType, AnimPhysLinearConstraintType LinearZLimitType, FVector LinearAxesMin, FVector LinearAxesMax, AnimPhysAngularConstraintType AngularConstraintType, AnimPhysTwistAxis TwistAxis, AnimPhysTwistAxis AngularTargetAxis, float ConeAngle, float AngularXAngle_DEPRECATED, float AngularYAngle_DEPRECATED, float AngularZAngle_DEPRECATED, FVector AngularLimitsMin, FVector AngularLimitsMax, FVector AngularTarget)
		{
			this.LinearXLimitType = LinearXLimitType;
			this.LinearYLimitType = LinearYLimitType;
			this.LinearZLimitType = LinearZLimitType;
			this.LinearAxesMin = LinearAxesMin;
			this.LinearAxesMax = LinearAxesMax;
			this.AngularConstraintType = AngularConstraintType;
			this.TwistAxis = TwistAxis;
			this.AngularTargetAxis = AngularTargetAxis;
			this.ConeAngle = ConeAngle;
			this.AngularLimitsMin = AngularLimitsMin;
			this.AngularLimitsMax = AngularLimitsMax;
			this.AngularTarget = AngularTarget;
		}

		// Token: 0x06002D0E RID: 11534 RVA: 0x000452D8 File Offset: 0x000434D8
		protected override IntPtr GetUStructPtr()
		{
			return FAnimPhysConstraintSetup.StaticStruct();
		}

		// Token: 0x06002D0F RID: 11535 RVA: 0x000452E4 File Offset: 0x000434E4
		[NullableContext(2)]
		public FAnimPhysConstraintSetup(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002D10 RID: 11536 RVA: 0x000452EE File Offset: 0x000434EE
		public FAnimPhysConstraintSetup(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002D11 RID: 11537 RVA: 0x000452F9 File Offset: 0x000434F9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimPhysConstraintSetup(Pointer, false, true);
		}

		// Token: 0x06002D12 RID: 11538 RVA: 0x00045303 File Offset: 0x00043503
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimPhysConstraintSetup(Pointer, MemoryOwner);
		}

		// Token: 0x04001294 RID: 4756
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AnimGraphRuntime.AnimPhysConstraintSetup";

		// Token: 0x04001295 RID: 4757
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001296 RID: 4758
		internal static int __PropertyOffset_LinearXLimitType;

		// Token: 0x04001297 RID: 4759
		internal static int __PropertyOffset_LinearYLimitType;

		// Token: 0x04001298 RID: 4760
		internal static int __PropertyOffset_LinearZLimitType;

		// Token: 0x04001299 RID: 4761
		internal static int __PropertyOffset_LinearAxesMin;

		// Token: 0x0400129A RID: 4762
		internal static int __PropertyOffset_LinearAxesMax;

		// Token: 0x0400129B RID: 4763
		internal static int __PropertyOffset_AngularConstraintType;

		// Token: 0x0400129C RID: 4764
		internal static int __PropertyOffset_TwistAxis;

		// Token: 0x0400129D RID: 4765
		internal static int __PropertyOffset_AngularTargetAxis;

		// Token: 0x0400129E RID: 4766
		internal static int __PropertyOffset_ConeAngle;

		// Token: 0x0400129F RID: 4767
		internal static int __PropertyOffset_AngularLimitsMin;

		// Token: 0x040012A0 RID: 4768
		internal static int __PropertyOffset_AngularLimitsMax;

		// Token: 0x040012A1 RID: 4769
		internal static int __PropertyOffset_AngularTarget;
	}
}
