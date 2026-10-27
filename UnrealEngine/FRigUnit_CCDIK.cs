using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000559 RID: 1369
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_CCDIK")]
	[UnrealStructLayout(336, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 336)]
	public class FRigUnit_CCDIK : FRigUnit_HighlevelBaseMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600486D RID: 18541 RVA: 0x0006B580 File Offset: 0x00069780
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_CCDIK._ScriptStructPtr != 0) ? FRigUnit_CCDIK._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_CCDIK", ref FRigUnit_CCDIK._ScriptStructPtr);
		}

		// Token: 0x170011A7 RID: 4519
		// (get) Token: 0x0600486E RID: 18542 RVA: 0x0006B5A4 File Offset: 0x000697A4
		// (set) Token: 0x0600486F RID: 18543 RVA: 0x0006B5B8 File Offset: 0x000697B8
		public unsafe FName StartBone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_CCDIK.__PropertyOffset_StartBone);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_CCDIK.__PropertyOffset_StartBone) = value;
			}
		}

		// Token: 0x170011A8 RID: 4520
		// (get) Token: 0x06004870 RID: 18544 RVA: 0x0006B5CD File Offset: 0x000697CD
		// (set) Token: 0x06004871 RID: 18545 RVA: 0x0006B5E1 File Offset: 0x000697E1
		public unsafe FName EffectorBone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_CCDIK.__PropertyOffset_EffectorBone);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_CCDIK.__PropertyOffset_EffectorBone) = value;
			}
		}

		// Token: 0x170011A9 RID: 4521
		// (get) Token: 0x06004872 RID: 18546 RVA: 0x0006B5F6 File Offset: 0x000697F6
		// (set) Token: 0x06004873 RID: 18547 RVA: 0x0006B60A File Offset: 0x0006980A
		public unsafe FTransform EffectorTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_CCDIK.__PropertyOffset_EffectorTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_CCDIK.__PropertyOffset_EffectorTransform) = value;
			}
		}

		// Token: 0x170011AA RID: 4522
		// (get) Token: 0x06004874 RID: 18548 RVA: 0x0006B61F File Offset: 0x0006981F
		// (set) Token: 0x06004875 RID: 18549 RVA: 0x0006B62F File Offset: 0x0006982F
		public unsafe float Precision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_CCDIK.__PropertyOffset_Precision);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_CCDIK.__PropertyOffset_Precision) = value;
			}
		}

		// Token: 0x170011AB RID: 4523
		// (get) Token: 0x06004876 RID: 18550 RVA: 0x0006B640 File Offset: 0x00069840
		// (set) Token: 0x06004877 RID: 18551 RVA: 0x0006B650 File Offset: 0x00069850
		public unsafe float Weight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_CCDIK.__PropertyOffset_Weight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_CCDIK.__PropertyOffset_Weight) = value;
			}
		}

		// Token: 0x170011AC RID: 4524
		// (get) Token: 0x06004878 RID: 18552 RVA: 0x0006B661 File Offset: 0x00069861
		// (set) Token: 0x06004879 RID: 18553 RVA: 0x0006B671 File Offset: 0x00069871
		public unsafe int MaxIterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_CCDIK.__PropertyOffset_MaxIterations);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_CCDIK.__PropertyOffset_MaxIterations) = value;
			}
		}

		// Token: 0x170011AD RID: 4525
		// (get) Token: 0x0600487A RID: 18554 RVA: 0x0006B682 File Offset: 0x00069882
		// (set) Token: 0x0600487B RID: 18555 RVA: 0x0006B692 File Offset: 0x00069892
		public unsafe bool bStartFromTail
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_CCDIK.__PropertyOffset_bStartFromTail) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_CCDIK.__PropertyOffset_bStartFromTail) = (value ? 1 : 0);
			}
		}

		// Token: 0x170011AE RID: 4526
		// (get) Token: 0x0600487C RID: 18556 RVA: 0x0006B6A3 File Offset: 0x000698A3
		// (set) Token: 0x0600487D RID: 18557 RVA: 0x0006B6B3 File Offset: 0x000698B3
		public unsafe float BaseRotationLimit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_CCDIK.__PropertyOffset_BaseRotationLimit);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_CCDIK.__PropertyOffset_BaseRotationLimit) = value;
			}
		}

		// Token: 0x170011AF RID: 4527
		// (get) Token: 0x0600487E RID: 18558 RVA: 0x0006B6C4 File Offset: 0x000698C4
		// (set) Token: 0x0600487F RID: 18559 RVA: 0x0006B707 File Offset: 0x00069907
		public TArray<FRigUnit_CCDIK_RotationLimit> RotationLimits
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRigUnit_CCDIK_RotationLimit> result;
				if ((result = this._RotationLimits) == null)
				{
					result = (this._RotationLimits = new TArray<FRigUnit_CCDIK_RotationLimit>(base.NativePtr + (IntPtr)FRigUnit_CCDIK.__PropertyOffset_RotationLimits, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.RotationLimits.CopyAssign(value);
			}
		}

		// Token: 0x170011B0 RID: 4528
		// (get) Token: 0x06004880 RID: 18560 RVA: 0x0006B715 File Offset: 0x00069915
		// (set) Token: 0x06004881 RID: 18561 RVA: 0x0006B725 File Offset: 0x00069925
		public unsafe bool bPropagateToChildren
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_CCDIK.__PropertyOffset_bPropagateToChildren) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_CCDIK.__PropertyOffset_bPropagateToChildren) = (value ? 1 : 0);
			}
		}

		// Token: 0x170011B1 RID: 4529
		// (get) Token: 0x06004882 RID: 18562 RVA: 0x0006B738 File Offset: 0x00069938
		// (set) Token: 0x06004883 RID: 18563 RVA: 0x0006B77B File Offset: 0x0006997B
		public FRigUnit_CCDIK_WorkData WorkData
		{
			get
			{
				base.FastCheckIsValid();
				FRigUnit_CCDIK_WorkData result;
				if ((result = this._WorkData) == null)
				{
					result = (this._WorkData = new FRigUnit_CCDIK_WorkData(base.NativePtr + (IntPtr)FRigUnit_CCDIK.__PropertyOffset_WorkData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigUnit_CCDIK_WorkData.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_CCDIK.__PropertyOffset_WorkData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06004884 RID: 18564 RVA: 0x0006B79C File Offset: 0x0006999C
		public FRigUnit_CCDIK()
		{
		}

		// Token: 0x06004885 RID: 18565 RVA: 0x0006B7A4 File Offset: 0x000699A4
		public FRigUnit_CCDIK(FName StartBone, FName EffectorBone, FTransform EffectorTransform, float Precision, float Weight, int MaxIterations, bool bStartFromTail, float BaseRotationLimit, TArray<FRigUnit_CCDIK_RotationLimit> RotationLimits, bool bPropagateToChildren, FRigUnit_CCDIK_WorkData WorkData, FControlRigExecuteContext ExecuteContext)
		{
			this.StartBone = StartBone;
			this.EffectorBone = EffectorBone;
			this.EffectorTransform = EffectorTransform;
			this.Precision = Precision;
			this.Weight = Weight;
			this.MaxIterations = MaxIterations;
			this.bStartFromTail = bStartFromTail;
			this.BaseRotationLimit = BaseRotationLimit;
			this.RotationLimits = RotationLimits;
			this.bPropagateToChildren = bPropagateToChildren;
			this.WorkData = WorkData;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06004886 RID: 18566 RVA: 0x0006B814 File Offset: 0x00069A14
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_CCDIK.StaticStruct();
		}

		// Token: 0x06004887 RID: 18567 RVA: 0x0006B820 File Offset: 0x00069A20
		[NullableContext(2)]
		public FRigUnit_CCDIK(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004888 RID: 18568 RVA: 0x0006B82A File Offset: 0x00069A2A
		public FRigUnit_CCDIK(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004889 RID: 18569 RVA: 0x0006B835 File Offset: 0x00069A35
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_CCDIK(Pointer, false, true);
		}

		// Token: 0x0600488A RID: 18570 RVA: 0x0006B83F File Offset: 0x00069A3F
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_CCDIK(Pointer, MemoryOwner);
		}

		// Token: 0x04002320 RID: 8992
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_CCDIK";

		// Token: 0x04002321 RID: 8993
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002322 RID: 8994
		internal static int __PropertyOffset_StartBone;

		// Token: 0x04002323 RID: 8995
		internal static int __PropertyOffset_EffectorBone;

		// Token: 0x04002324 RID: 8996
		internal static int __PropertyOffset_EffectorTransform;

		// Token: 0x04002325 RID: 8997
		internal static int __PropertyOffset_Precision;

		// Token: 0x04002326 RID: 8998
		internal static int __PropertyOffset_Weight;

		// Token: 0x04002327 RID: 8999
		internal static int __PropertyOffset_MaxIterations;

		// Token: 0x04002328 RID: 9000
		internal static int __PropertyOffset_bStartFromTail;

		// Token: 0x04002329 RID: 9001
		internal static int __PropertyOffset_BaseRotationLimit;

		// Token: 0x0400232A RID: 9002
		internal static int __PropertyOffset_RotationLimits;

		// Token: 0x0400232B RID: 9003
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRigUnit_CCDIK_RotationLimit> _RotationLimits;

		// Token: 0x0400232C RID: 9004
		internal static int __PropertyOffset_bPropagateToChildren;

		// Token: 0x0400232D RID: 9005
		internal static int __PropertyOffset_WorkData;

		// Token: 0x0400232E RID: 9006
		[Nullable(2)]
		private FRigUnit_CCDIK_WorkData _WorkData;
	}
}
