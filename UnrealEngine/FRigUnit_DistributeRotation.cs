using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000599 RID: 1433
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_DistributeRotation")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 248)]
	public class FRigUnit_DistributeRotation : FRigUnit_HighlevelBaseMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004CDF RID: 19679 RVA: 0x000719FC File Offset: 0x0006FBFC
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_DistributeRotation._ScriptStructPtr != 0) ? FRigUnit_DistributeRotation._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_DistributeRotation", ref FRigUnit_DistributeRotation._ScriptStructPtr);
		}

		// Token: 0x170012E1 RID: 4833
		// (get) Token: 0x06004CE0 RID: 19680 RVA: 0x00071A20 File Offset: 0x0006FC20
		// (set) Token: 0x06004CE1 RID: 19681 RVA: 0x00071A34 File Offset: 0x0006FC34
		public unsafe FName StartBone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DistributeRotation.__PropertyOffset_StartBone);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DistributeRotation.__PropertyOffset_StartBone) = value;
			}
		}

		// Token: 0x170012E2 RID: 4834
		// (get) Token: 0x06004CE2 RID: 19682 RVA: 0x00071A49 File Offset: 0x0006FC49
		// (set) Token: 0x06004CE3 RID: 19683 RVA: 0x00071A5D File Offset: 0x0006FC5D
		public unsafe FName EndBone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DistributeRotation.__PropertyOffset_EndBone);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DistributeRotation.__PropertyOffset_EndBone) = value;
			}
		}

		// Token: 0x170012E3 RID: 4835
		// (get) Token: 0x06004CE4 RID: 19684 RVA: 0x00071A74 File Offset: 0x0006FC74
		// (set) Token: 0x06004CE5 RID: 19685 RVA: 0x00071AB7 File Offset: 0x0006FCB7
		public TArray<FRigUnit_DistributeRotation_Rotation> Rotations
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRigUnit_DistributeRotation_Rotation> result;
				if ((result = this._Rotations) == null)
				{
					result = (this._Rotations = new TArray<FRigUnit_DistributeRotation_Rotation>(base.NativePtr + (IntPtr)FRigUnit_DistributeRotation.__PropertyOffset_Rotations, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Rotations.CopyAssign(value);
			}
		}

		// Token: 0x170012E4 RID: 4836
		// (get) Token: 0x06004CE6 RID: 19686 RVA: 0x00071AC5 File Offset: 0x0006FCC5
		// (set) Token: 0x06004CE7 RID: 19687 RVA: 0x00071AD5 File Offset: 0x0006FCD5
		public unsafe EControlRigAnimEasingType RotationEaseType
		{
			get
			{
				return (EControlRigAnimEasingType)(*(base.NativePtr + (IntPtr)FRigUnit_DistributeRotation.__PropertyOffset_RotationEaseType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DistributeRotation.__PropertyOffset_RotationEaseType) = (byte)value;
			}
		}

		// Token: 0x170012E5 RID: 4837
		// (get) Token: 0x06004CE8 RID: 19688 RVA: 0x00071AE6 File Offset: 0x0006FCE6
		// (set) Token: 0x06004CE9 RID: 19689 RVA: 0x00071AF6 File Offset: 0x0006FCF6
		public unsafe float Weight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DistributeRotation.__PropertyOffset_Weight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DistributeRotation.__PropertyOffset_Weight) = value;
			}
		}

		// Token: 0x170012E6 RID: 4838
		// (get) Token: 0x06004CEA RID: 19690 RVA: 0x00071B07 File Offset: 0x0006FD07
		// (set) Token: 0x06004CEB RID: 19691 RVA: 0x00071B17 File Offset: 0x0006FD17
		public unsafe bool bPropagateToChildren
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DistributeRotation.__PropertyOffset_bPropagateToChildren) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DistributeRotation.__PropertyOffset_bPropagateToChildren) = (value ? 1 : 0);
			}
		}

		// Token: 0x170012E7 RID: 4839
		// (get) Token: 0x06004CEC RID: 19692 RVA: 0x00071B28 File Offset: 0x0006FD28
		// (set) Token: 0x06004CED RID: 19693 RVA: 0x00071B6B File Offset: 0x0006FD6B
		public FRigUnit_DistributeRotation_WorkData WorkData
		{
			get
			{
				base.FastCheckIsValid();
				FRigUnit_DistributeRotation_WorkData result;
				if ((result = this._WorkData) == null)
				{
					result = (this._WorkData = new FRigUnit_DistributeRotation_WorkData(base.NativePtr + (IntPtr)FRigUnit_DistributeRotation.__PropertyOffset_WorkData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigUnit_DistributeRotation_WorkData.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_DistributeRotation.__PropertyOffset_WorkData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06004CEE RID: 19694 RVA: 0x00071B8C File Offset: 0x0006FD8C
		public FRigUnit_DistributeRotation()
		{
		}

		// Token: 0x06004CEF RID: 19695 RVA: 0x00071B94 File Offset: 0x0006FD94
		public FRigUnit_DistributeRotation(FName StartBone, FName EndBone, TArray<FRigUnit_DistributeRotation_Rotation> Rotations, EControlRigAnimEasingType RotationEaseType, float Weight, bool bPropagateToChildren, FRigUnit_DistributeRotation_WorkData WorkData, FControlRigExecuteContext ExecuteContext)
		{
			this.StartBone = StartBone;
			this.EndBone = EndBone;
			this.Rotations = Rotations;
			this.RotationEaseType = RotationEaseType;
			this.Weight = Weight;
			this.bPropagateToChildren = bPropagateToChildren;
			this.WorkData = WorkData;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06004CF0 RID: 19696 RVA: 0x00071BE4 File Offset: 0x0006FDE4
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_DistributeRotation.StaticStruct();
		}

		// Token: 0x06004CF1 RID: 19697 RVA: 0x00071BF0 File Offset: 0x0006FDF0
		[NullableContext(2)]
		public FRigUnit_DistributeRotation(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004CF2 RID: 19698 RVA: 0x00071BFA File Offset: 0x0006FDFA
		public FRigUnit_DistributeRotation(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004CF3 RID: 19699 RVA: 0x00071C05 File Offset: 0x0006FE05
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_DistributeRotation(Pointer, false, true);
		}

		// Token: 0x06004CF4 RID: 19700 RVA: 0x00071C0F File Offset: 0x0006FE0F
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_DistributeRotation(Pointer, MemoryOwner);
		}

		// Token: 0x04002528 RID: 9512
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_DistributeRotation";

		// Token: 0x04002529 RID: 9513
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400252A RID: 9514
		internal static int __PropertyOffset_StartBone;

		// Token: 0x0400252B RID: 9515
		internal static int __PropertyOffset_EndBone;

		// Token: 0x0400252C RID: 9516
		internal static int __PropertyOffset_Rotations;

		// Token: 0x0400252D RID: 9517
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRigUnit_DistributeRotation_Rotation> _Rotations;

		// Token: 0x0400252E RID: 9518
		internal static int __PropertyOffset_RotationEaseType;

		// Token: 0x0400252F RID: 9519
		internal static int __PropertyOffset_Weight;

		// Token: 0x04002530 RID: 9520
		internal static int __PropertyOffset_bPropagateToChildren;

		// Token: 0x04002531 RID: 9521
		internal static int __PropertyOffset_WorkData;

		// Token: 0x04002532 RID: 9522
		[Nullable(2)]
		private FRigUnit_DistributeRotation_WorkData _WorkData;
	}
}
