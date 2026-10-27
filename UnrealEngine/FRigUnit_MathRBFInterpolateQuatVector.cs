using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200064A RID: 1610
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathRBFInterpolateQuatVector")]
	[UnrealStructLayout(256, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 256)]
	public class FRigUnit_MathRBFInterpolateQuatVector : FRigUnit_MathRBFInterpolateQuatBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060055E3 RID: 21987 RVA: 0x0007C710 File Offset: 0x0007A910
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathRBFInterpolateQuatVector._ScriptStructPtr != 0) ? FRigUnit_MathRBFInterpolateQuatVector._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathRBFInterpolateQuatVector", ref FRigUnit_MathRBFInterpolateQuatVector._ScriptStructPtr);
		}

		// Token: 0x170014A4 RID: 5284
		// (get) Token: 0x060055E4 RID: 21988 RVA: 0x0007C734 File Offset: 0x0007A934
		// (set) Token: 0x060055E5 RID: 21989 RVA: 0x0007C777 File Offset: 0x0007A977
		public TArray<FMathRBFInterpolateQuatVector_Target> Targets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMathRBFInterpolateQuatVector_Target> result;
				if ((result = this._Targets) == null)
				{
					result = (this._Targets = new TArray<FMathRBFInterpolateQuatVector_Target>(base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateQuatVector.__PropertyOffset_Targets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Targets.CopyAssign(value);
			}
		}

		// Token: 0x170014A5 RID: 5285
		// (get) Token: 0x060055E6 RID: 21990 RVA: 0x0007C785 File Offset: 0x0007A985
		// (set) Token: 0x060055E7 RID: 21991 RVA: 0x0007C799 File Offset: 0x0007A999
		public unsafe FVector Output
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateQuatVector.__PropertyOffset_Output);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateQuatVector.__PropertyOffset_Output) = value;
			}
		}

		// Token: 0x060055E8 RID: 21992 RVA: 0x0007C7AE File Offset: 0x0007A9AE
		public FRigUnit_MathRBFInterpolateQuatVector()
		{
		}

		// Token: 0x060055E9 RID: 21993 RVA: 0x0007C7B8 File Offset: 0x0007A9B8
		public FRigUnit_MathRBFInterpolateQuatVector(TArray<FMathRBFInterpolateQuatVector_Target> Targets, FVector Output, FQuat Input, ERBFQuatDistanceType DistanceFunction, ERBFKernelType SmoothingFunction, float SmoothingAngle, bool bNormalizeOutput, FVector TwistAxis, FRigUnit_MathRBFInterpolateQuatWorkData WorkData)
		{
			this.Targets = Targets;
			this.Output = Output;
			base.Input = Input;
			base.DistanceFunction = DistanceFunction;
			base.SmoothingFunction = SmoothingFunction;
			base.SmoothingAngle = SmoothingAngle;
			base.bNormalizeOutput = bNormalizeOutput;
			base.TwistAxis = TwistAxis;
			base.WorkData = WorkData;
		}

		// Token: 0x060055EA RID: 21994 RVA: 0x0007C810 File Offset: 0x0007AA10
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathRBFInterpolateQuatVector.StaticStruct();
		}

		// Token: 0x060055EB RID: 21995 RVA: 0x0007C81C File Offset: 0x0007AA1C
		[NullableContext(2)]
		public FRigUnit_MathRBFInterpolateQuatVector(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060055EC RID: 21996 RVA: 0x0007C826 File Offset: 0x0007AA26
		public FRigUnit_MathRBFInterpolateQuatVector(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060055ED RID: 21997 RVA: 0x0007C831 File Offset: 0x0007AA31
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathRBFInterpolateQuatVector(Pointer, false, true);
		}

		// Token: 0x060055EE RID: 21998 RVA: 0x0007C83B File Offset: 0x0007AA3B
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathRBFInterpolateQuatVector(Pointer, MemoryOwner);
		}

		// Token: 0x040028A4 RID: 10404
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathRBFInterpolateQuatVector";

		// Token: 0x040028A5 RID: 10405
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040028A6 RID: 10406
		internal static int __PropertyOffset_Targets;

		// Token: 0x040028A7 RID: 10407
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMathRBFInterpolateQuatVector_Target> _Targets;

		// Token: 0x040028A8 RID: 10408
		internal static int __PropertyOffset_Output;
	}
}
