using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000647 RID: 1607
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathRBFInterpolateQuatColor")]
	[UnrealStructLayout(256, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 256)]
	public class FRigUnit_MathRBFInterpolateQuatColor : FRigUnit_MathRBFInterpolateQuatBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060055BF RID: 21951 RVA: 0x0007C379 File Offset: 0x0007A579
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathRBFInterpolateQuatColor._ScriptStructPtr != 0) ? FRigUnit_MathRBFInterpolateQuatColor._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathRBFInterpolateQuatColor", ref FRigUnit_MathRBFInterpolateQuatColor._ScriptStructPtr);
		}

		// Token: 0x1700149E RID: 5278
		// (get) Token: 0x060055C0 RID: 21952 RVA: 0x0007C3A0 File Offset: 0x0007A5A0
		// (set) Token: 0x060055C1 RID: 21953 RVA: 0x0007C3E3 File Offset: 0x0007A5E3
		public TArray<FMathRBFInterpolateQuatColor_Target> Targets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMathRBFInterpolateQuatColor_Target> result;
				if ((result = this._Targets) == null)
				{
					result = (this._Targets = new TArray<FMathRBFInterpolateQuatColor_Target>(base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateQuatColor.__PropertyOffset_Targets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Targets.CopyAssign(value);
			}
		}

		// Token: 0x1700149F RID: 5279
		// (get) Token: 0x060055C2 RID: 21954 RVA: 0x0007C3F1 File Offset: 0x0007A5F1
		// (set) Token: 0x060055C3 RID: 21955 RVA: 0x0007C405 File Offset: 0x0007A605
		public unsafe FLinearColor Output
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateQuatColor.__PropertyOffset_Output);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateQuatColor.__PropertyOffset_Output) = value;
			}
		}

		// Token: 0x060055C4 RID: 21956 RVA: 0x0007C41A File Offset: 0x0007A61A
		public FRigUnit_MathRBFInterpolateQuatColor()
		{
		}

		// Token: 0x060055C5 RID: 21957 RVA: 0x0007C424 File Offset: 0x0007A624
		public FRigUnit_MathRBFInterpolateQuatColor(TArray<FMathRBFInterpolateQuatColor_Target> Targets, FLinearColor Output, FQuat Input, ERBFQuatDistanceType DistanceFunction, ERBFKernelType SmoothingFunction, float SmoothingAngle, bool bNormalizeOutput, FVector TwistAxis, FRigUnit_MathRBFInterpolateQuatWorkData WorkData)
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

		// Token: 0x060055C6 RID: 21958 RVA: 0x0007C47C File Offset: 0x0007A67C
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathRBFInterpolateQuatColor.StaticStruct();
		}

		// Token: 0x060055C7 RID: 21959 RVA: 0x0007C488 File Offset: 0x0007A688
		[NullableContext(2)]
		public FRigUnit_MathRBFInterpolateQuatColor(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060055C8 RID: 21960 RVA: 0x0007C492 File Offset: 0x0007A692
		public FRigUnit_MathRBFInterpolateQuatColor(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060055C9 RID: 21961 RVA: 0x0007C49D File Offset: 0x0007A69D
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathRBFInterpolateQuatColor(Pointer, false, true);
		}

		// Token: 0x060055CA RID: 21962 RVA: 0x0007C4A7 File Offset: 0x0007A6A7
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathRBFInterpolateQuatColor(Pointer, MemoryOwner);
		}

		// Token: 0x04002895 RID: 10389
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathRBFInterpolateQuatColor";

		// Token: 0x04002896 RID: 10390
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002897 RID: 10391
		internal static int __PropertyOffset_Targets;

		// Token: 0x04002898 RID: 10392
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMathRBFInterpolateQuatColor_Target> _Targets;

		// Token: 0x04002899 RID: 10393
		internal static int __PropertyOffset_Output;
	}
}
