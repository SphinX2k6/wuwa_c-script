using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020006F2 RID: 1778
	[UnrealObjectPath("/Script/ControlRig.RigUnit_TwoBoneIKFK")]
	[UnrealStructLayout(560, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 560)]
	public class FRigUnit_TwoBoneIKFK : FRigUnitMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005F98 RID: 24472 RVA: 0x0008912A File Offset: 0x0008732A
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_TwoBoneIKFK._ScriptStructPtr != 0) ? FRigUnit_TwoBoneIKFK._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_TwoBoneIKFK", ref FRigUnit_TwoBoneIKFK._ScriptStructPtr);
		}

		// Token: 0x170016E2 RID: 5858
		// (get) Token: 0x06005F99 RID: 24473 RVA: 0x0008914E File Offset: 0x0008734E
		// (set) Token: 0x06005F9A RID: 24474 RVA: 0x00089162 File Offset: 0x00087362
		public unsafe FName StartJoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKFK.__PropertyOffset_StartJoint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKFK.__PropertyOffset_StartJoint) = value;
			}
		}

		// Token: 0x170016E3 RID: 5859
		// (get) Token: 0x06005F9B RID: 24475 RVA: 0x00089177 File Offset: 0x00087377
		// (set) Token: 0x06005F9C RID: 24476 RVA: 0x0008918B File Offset: 0x0008738B
		public unsafe FName EndJoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKFK.__PropertyOffset_EndJoint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKFK.__PropertyOffset_EndJoint) = value;
			}
		}

		// Token: 0x170016E4 RID: 5860
		// (get) Token: 0x06005F9D RID: 24477 RVA: 0x000891A0 File Offset: 0x000873A0
		// (set) Token: 0x06005F9E RID: 24478 RVA: 0x000891B4 File Offset: 0x000873B4
		public unsafe FVector PoleTarget
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKFK.__PropertyOffset_PoleTarget);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKFK.__PropertyOffset_PoleTarget) = value;
			}
		}

		// Token: 0x170016E5 RID: 5861
		// (get) Token: 0x06005F9F RID: 24479 RVA: 0x000891C9 File Offset: 0x000873C9
		// (set) Token: 0x06005FA0 RID: 24480 RVA: 0x000891D9 File Offset: 0x000873D9
		public unsafe float Spin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKFK.__PropertyOffset_Spin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKFK.__PropertyOffset_Spin) = value;
			}
		}

		// Token: 0x170016E6 RID: 5862
		// (get) Token: 0x06005FA1 RID: 24481 RVA: 0x000891EA File Offset: 0x000873EA
		// (set) Token: 0x06005FA2 RID: 24482 RVA: 0x000891FE File Offset: 0x000873FE
		public unsafe FTransform EndEffector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKFK.__PropertyOffset_EndEffector);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKFK.__PropertyOffset_EndEffector) = value;
			}
		}

		// Token: 0x170016E7 RID: 5863
		// (get) Token: 0x06005FA3 RID: 24483 RVA: 0x00089213 File Offset: 0x00087413
		// (set) Token: 0x06005FA4 RID: 24484 RVA: 0x00089223 File Offset: 0x00087423
		public unsafe float IKBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKFK.__PropertyOffset_IKBlend);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKFK.__PropertyOffset_IKBlend) = value;
			}
		}

		// Token: 0x170016E8 RID: 5864
		// (get) Token: 0x06005FA5 RID: 24485 RVA: 0x00089234 File Offset: 0x00087434
		// (set) Token: 0x06005FA6 RID: 24486 RVA: 0x00089248 File Offset: 0x00087448
		public unsafe FTransform StartJointFKTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKFK.__PropertyOffset_StartJointFKTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKFK.__PropertyOffset_StartJointFKTransform) = value;
			}
		}

		// Token: 0x170016E9 RID: 5865
		// (get) Token: 0x06005FA7 RID: 24487 RVA: 0x0008925D File Offset: 0x0008745D
		// (set) Token: 0x06005FA8 RID: 24488 RVA: 0x00089271 File Offset: 0x00087471
		public unsafe FTransform MidJointFKTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKFK.__PropertyOffset_MidJointFKTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKFK.__PropertyOffset_MidJointFKTransform) = value;
			}
		}

		// Token: 0x170016EA RID: 5866
		// (get) Token: 0x06005FA9 RID: 24489 RVA: 0x00089286 File Offset: 0x00087486
		// (set) Token: 0x06005FAA RID: 24490 RVA: 0x0008929A File Offset: 0x0008749A
		public unsafe FTransform EndJointFKTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKFK.__PropertyOffset_EndJointFKTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKFK.__PropertyOffset_EndJointFKTransform) = value;
			}
		}

		// Token: 0x170016EB RID: 5867
		// (get) Token: 0x06005FAB RID: 24491 RVA: 0x000892AF File Offset: 0x000874AF
		// (set) Token: 0x06005FAC RID: 24492 RVA: 0x000892BF File Offset: 0x000874BF
		public unsafe float PreviousFKIKBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKFK.__PropertyOffset_PreviousFKIKBlend);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKFK.__PropertyOffset_PreviousFKIKBlend) = value;
			}
		}

		// Token: 0x170016EC RID: 5868
		// (get) Token: 0x06005FAD RID: 24493 RVA: 0x000892D0 File Offset: 0x000874D0
		// (set) Token: 0x06005FAE RID: 24494 RVA: 0x000892E4 File Offset: 0x000874E4
		public unsafe FTransform StartJointIKTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKFK.__PropertyOffset_StartJointIKTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKFK.__PropertyOffset_StartJointIKTransform) = value;
			}
		}

		// Token: 0x170016ED RID: 5869
		// (get) Token: 0x06005FAF RID: 24495 RVA: 0x000892F9 File Offset: 0x000874F9
		// (set) Token: 0x06005FB0 RID: 24496 RVA: 0x0008930D File Offset: 0x0008750D
		public unsafe FTransform MidJointIKTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKFK.__PropertyOffset_MidJointIKTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKFK.__PropertyOffset_MidJointIKTransform) = value;
			}
		}

		// Token: 0x170016EE RID: 5870
		// (get) Token: 0x06005FB1 RID: 24497 RVA: 0x00089322 File Offset: 0x00087522
		// (set) Token: 0x06005FB2 RID: 24498 RVA: 0x00089336 File Offset: 0x00087536
		public unsafe FTransform EndJointIKTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKFK.__PropertyOffset_EndJointIKTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKFK.__PropertyOffset_EndJointIKTransform) = value;
			}
		}

		// Token: 0x170016EF RID: 5871
		// (get) Token: 0x06005FB3 RID: 24499 RVA: 0x0008934B File Offset: 0x0008754B
		// (set) Token: 0x06005FB4 RID: 24500 RVA: 0x0008935B File Offset: 0x0008755B
		public unsafe int StartJointIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKFK.__PropertyOffset_StartJointIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKFK.__PropertyOffset_StartJointIndex) = value;
			}
		}

		// Token: 0x170016F0 RID: 5872
		// (get) Token: 0x06005FB5 RID: 24501 RVA: 0x0008936C File Offset: 0x0008756C
		// (set) Token: 0x06005FB6 RID: 24502 RVA: 0x0008937C File Offset: 0x0008757C
		public unsafe int MidJointIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKFK.__PropertyOffset_MidJointIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKFK.__PropertyOffset_MidJointIndex) = value;
			}
		}

		// Token: 0x170016F1 RID: 5873
		// (get) Token: 0x06005FB7 RID: 24503 RVA: 0x0008938D File Offset: 0x0008758D
		// (set) Token: 0x06005FB8 RID: 24504 RVA: 0x0008939D File Offset: 0x0008759D
		public unsafe int EndJointIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKFK.__PropertyOffset_EndJointIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKFK.__PropertyOffset_EndJointIndex) = value;
			}
		}

		// Token: 0x170016F2 RID: 5874
		// (get) Token: 0x06005FB9 RID: 24505 RVA: 0x000893AE File Offset: 0x000875AE
		// (set) Token: 0x06005FBA RID: 24506 RVA: 0x000893BE File Offset: 0x000875BE
		public unsafe float UpperLimbLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKFK.__PropertyOffset_UpperLimbLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKFK.__PropertyOffset_UpperLimbLength) = value;
			}
		}

		// Token: 0x170016F3 RID: 5875
		// (get) Token: 0x06005FBB RID: 24507 RVA: 0x000893CF File Offset: 0x000875CF
		// (set) Token: 0x06005FBC RID: 24508 RVA: 0x000893DF File Offset: 0x000875DF
		public unsafe float LowerLimbLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKFK.__PropertyOffset_LowerLimbLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKFK.__PropertyOffset_LowerLimbLength) = value;
			}
		}

		// Token: 0x06005FBD RID: 24509 RVA: 0x000893F0 File Offset: 0x000875F0
		public FRigUnit_TwoBoneIKFK()
		{
		}

		// Token: 0x06005FBE RID: 24510 RVA: 0x000893F8 File Offset: 0x000875F8
		[NullableContext(1)]
		public FRigUnit_TwoBoneIKFK(FName StartJoint, FName EndJoint, FVector PoleTarget, float Spin, FTransform EndEffector, float IKBlend, FTransform StartJointFKTransform, FTransform MidJointFKTransform, FTransform EndJointFKTransform, float PreviousFKIKBlend, FTransform StartJointIKTransform, FTransform MidJointIKTransform, FTransform EndJointIKTransform, int StartJointIndex, int MidJointIndex, int EndJointIndex, float UpperLimbLength, float LowerLimbLength, FControlRigExecuteContext ExecuteContext)
		{
			this.StartJoint = StartJoint;
			this.EndJoint = EndJoint;
			this.PoleTarget = PoleTarget;
			this.Spin = Spin;
			this.EndEffector = EndEffector;
			this.IKBlend = IKBlend;
			this.StartJointFKTransform = StartJointFKTransform;
			this.MidJointFKTransform = MidJointFKTransform;
			this.EndJointFKTransform = EndJointFKTransform;
			this.PreviousFKIKBlend = PreviousFKIKBlend;
			this.StartJointIKTransform = StartJointIKTransform;
			this.MidJointIKTransform = MidJointIKTransform;
			this.EndJointIKTransform = EndJointIKTransform;
			this.StartJointIndex = StartJointIndex;
			this.MidJointIndex = MidJointIndex;
			this.EndJointIndex = EndJointIndex;
			this.UpperLimbLength = UpperLimbLength;
			this.LowerLimbLength = LowerLimbLength;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06005FBF RID: 24511 RVA: 0x000894A0 File Offset: 0x000876A0
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_TwoBoneIKFK.StaticStruct();
		}

		// Token: 0x06005FC0 RID: 24512 RVA: 0x000894AC File Offset: 0x000876AC
		[NullableContext(2)]
		public FRigUnit_TwoBoneIKFK(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005FC1 RID: 24513 RVA: 0x000894B6 File Offset: 0x000876B6
		public FRigUnit_TwoBoneIKFK(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005FC2 RID: 24514 RVA: 0x000894C1 File Offset: 0x000876C1
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_TwoBoneIKFK(Pointer, false, true);
		}

		// Token: 0x06005FC3 RID: 24515 RVA: 0x000894CB File Offset: 0x000876CB
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_TwoBoneIKFK(Pointer, MemoryOwner);
		}

		// Token: 0x04002CB1 RID: 11441
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_TwoBoneIKFK";

		// Token: 0x04002CB2 RID: 11442
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002CB3 RID: 11443
		internal static int __PropertyOffset_StartJoint;

		// Token: 0x04002CB4 RID: 11444
		internal static int __PropertyOffset_EndJoint;

		// Token: 0x04002CB5 RID: 11445
		internal static int __PropertyOffset_PoleTarget;

		// Token: 0x04002CB6 RID: 11446
		internal static int __PropertyOffset_Spin;

		// Token: 0x04002CB7 RID: 11447
		internal static int __PropertyOffset_EndEffector;

		// Token: 0x04002CB8 RID: 11448
		internal static int __PropertyOffset_IKBlend;

		// Token: 0x04002CB9 RID: 11449
		internal static int __PropertyOffset_StartJointFKTransform;

		// Token: 0x04002CBA RID: 11450
		internal static int __PropertyOffset_MidJointFKTransform;

		// Token: 0x04002CBB RID: 11451
		internal static int __PropertyOffset_EndJointFKTransform;

		// Token: 0x04002CBC RID: 11452
		internal static int __PropertyOffset_PreviousFKIKBlend;

		// Token: 0x04002CBD RID: 11453
		internal static int __PropertyOffset_StartJointIKTransform;

		// Token: 0x04002CBE RID: 11454
		internal static int __PropertyOffset_MidJointIKTransform;

		// Token: 0x04002CBF RID: 11455
		internal static int __PropertyOffset_EndJointIKTransform;

		// Token: 0x04002CC0 RID: 11456
		internal static int __PropertyOffset_StartJointIndex;

		// Token: 0x04002CC1 RID: 11457
		internal static int __PropertyOffset_MidJointIndex;

		// Token: 0x04002CC2 RID: 11458
		internal static int __PropertyOffset_EndJointIndex;

		// Token: 0x04002CC3 RID: 11459
		internal static int __PropertyOffset_UpperLimbLength;

		// Token: 0x04002CC4 RID: 11460
		internal static int __PropertyOffset_LowerLimbLength;
	}
}
