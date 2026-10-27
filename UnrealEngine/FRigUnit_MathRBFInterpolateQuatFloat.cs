using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000648 RID: 1608
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathRBFInterpolateQuatFloat")]
	[UnrealStructLayout(256, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 256)]
	public class FRigUnit_MathRBFInterpolateQuatFloat : FRigUnit_MathRBFInterpolateQuatBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060055CB RID: 21963 RVA: 0x0007C4B0 File Offset: 0x0007A6B0
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathRBFInterpolateQuatFloat._ScriptStructPtr != 0) ? FRigUnit_MathRBFInterpolateQuatFloat._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathRBFInterpolateQuatFloat", ref FRigUnit_MathRBFInterpolateQuatFloat._ScriptStructPtr);
		}

		// Token: 0x170014A0 RID: 5280
		// (get) Token: 0x060055CC RID: 21964 RVA: 0x0007C4D4 File Offset: 0x0007A6D4
		// (set) Token: 0x060055CD RID: 21965 RVA: 0x0007C517 File Offset: 0x0007A717
		public TArray<FMathRBFInterpolateQuatFloat_Target> Targets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMathRBFInterpolateQuatFloat_Target> result;
				if ((result = this._Targets) == null)
				{
					result = (this._Targets = new TArray<FMathRBFInterpolateQuatFloat_Target>(base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateQuatFloat.__PropertyOffset_Targets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Targets.CopyAssign(value);
			}
		}

		// Token: 0x170014A1 RID: 5281
		// (get) Token: 0x060055CE RID: 21966 RVA: 0x0007C525 File Offset: 0x0007A725
		// (set) Token: 0x060055CF RID: 21967 RVA: 0x0007C535 File Offset: 0x0007A735
		public unsafe float Output
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateQuatFloat.__PropertyOffset_Output);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateQuatFloat.__PropertyOffset_Output) = value;
			}
		}

		// Token: 0x060055D0 RID: 21968 RVA: 0x0007C546 File Offset: 0x0007A746
		public FRigUnit_MathRBFInterpolateQuatFloat()
		{
		}

		// Token: 0x060055D1 RID: 21969 RVA: 0x0007C550 File Offset: 0x0007A750
		public FRigUnit_MathRBFInterpolateQuatFloat(TArray<FMathRBFInterpolateQuatFloat_Target> Targets, float Output, FQuat Input, ERBFQuatDistanceType DistanceFunction, ERBFKernelType SmoothingFunction, float SmoothingAngle, bool bNormalizeOutput, FVector TwistAxis, FRigUnit_MathRBFInterpolateQuatWorkData WorkData)
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

		// Token: 0x060055D2 RID: 21970 RVA: 0x0007C5A8 File Offset: 0x0007A7A8
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathRBFInterpolateQuatFloat.StaticStruct();
		}

		// Token: 0x060055D3 RID: 21971 RVA: 0x0007C5B4 File Offset: 0x0007A7B4
		[NullableContext(2)]
		public FRigUnit_MathRBFInterpolateQuatFloat(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060055D4 RID: 21972 RVA: 0x0007C5BE File Offset: 0x0007A7BE
		public FRigUnit_MathRBFInterpolateQuatFloat(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060055D5 RID: 21973 RVA: 0x0007C5C9 File Offset: 0x0007A7C9
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathRBFInterpolateQuatFloat(Pointer, false, true);
		}

		// Token: 0x060055D6 RID: 21974 RVA: 0x0007C5D3 File Offset: 0x0007A7D3
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathRBFInterpolateQuatFloat(Pointer, MemoryOwner);
		}

		// Token: 0x0400289A RID: 10394
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathRBFInterpolateQuatFloat";

		// Token: 0x0400289B RID: 10395
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400289C RID: 10396
		internal static int __PropertyOffset_Targets;

		// Token: 0x0400289D RID: 10397
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMathRBFInterpolateQuatFloat_Target> _Targets;

		// Token: 0x0400289E RID: 10398
		internal static int __PropertyOffset_Output;
	}
}
