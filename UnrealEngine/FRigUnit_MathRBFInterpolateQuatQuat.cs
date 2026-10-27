using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000649 RID: 1609
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathRBFInterpolateQuatQuat")]
	[UnrealStructLayout(256, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 256)]
	public class FRigUnit_MathRBFInterpolateQuatQuat : FRigUnit_MathRBFInterpolateQuatBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060055D7 RID: 21975 RVA: 0x0007C5DC File Offset: 0x0007A7DC
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathRBFInterpolateQuatQuat._ScriptStructPtr != 0) ? FRigUnit_MathRBFInterpolateQuatQuat._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathRBFInterpolateQuatQuat", ref FRigUnit_MathRBFInterpolateQuatQuat._ScriptStructPtr);
		}

		// Token: 0x170014A2 RID: 5282
		// (get) Token: 0x060055D8 RID: 21976 RVA: 0x0007C600 File Offset: 0x0007A800
		// (set) Token: 0x060055D9 RID: 21977 RVA: 0x0007C643 File Offset: 0x0007A843
		public TArray<FMathRBFInterpolateQuatQuat_Target> Targets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMathRBFInterpolateQuatQuat_Target> result;
				if ((result = this._Targets) == null)
				{
					result = (this._Targets = new TArray<FMathRBFInterpolateQuatQuat_Target>(base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateQuatQuat.__PropertyOffset_Targets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Targets.CopyAssign(value);
			}
		}

		// Token: 0x170014A3 RID: 5283
		// (get) Token: 0x060055DA RID: 21978 RVA: 0x0007C651 File Offset: 0x0007A851
		// (set) Token: 0x060055DB RID: 21979 RVA: 0x0007C665 File Offset: 0x0007A865
		public unsafe FQuat Output
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateQuatQuat.__PropertyOffset_Output);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateQuatQuat.__PropertyOffset_Output) = value;
			}
		}

		// Token: 0x060055DC RID: 21980 RVA: 0x0007C67A File Offset: 0x0007A87A
		public FRigUnit_MathRBFInterpolateQuatQuat()
		{
		}

		// Token: 0x060055DD RID: 21981 RVA: 0x0007C684 File Offset: 0x0007A884
		public FRigUnit_MathRBFInterpolateQuatQuat(TArray<FMathRBFInterpolateQuatQuat_Target> Targets, FQuat Output, FQuat Input, ERBFQuatDistanceType DistanceFunction, ERBFKernelType SmoothingFunction, float SmoothingAngle, bool bNormalizeOutput, FVector TwistAxis, FRigUnit_MathRBFInterpolateQuatWorkData WorkData)
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

		// Token: 0x060055DE RID: 21982 RVA: 0x0007C6DC File Offset: 0x0007A8DC
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathRBFInterpolateQuatQuat.StaticStruct();
		}

		// Token: 0x060055DF RID: 21983 RVA: 0x0007C6E8 File Offset: 0x0007A8E8
		[NullableContext(2)]
		public FRigUnit_MathRBFInterpolateQuatQuat(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060055E0 RID: 21984 RVA: 0x0007C6F2 File Offset: 0x0007A8F2
		public FRigUnit_MathRBFInterpolateQuatQuat(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060055E1 RID: 21985 RVA: 0x0007C6FD File Offset: 0x0007A8FD
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathRBFInterpolateQuatQuat(Pointer, false, true);
		}

		// Token: 0x060055E2 RID: 21986 RVA: 0x0007C707 File Offset: 0x0007A907
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathRBFInterpolateQuatQuat(Pointer, MemoryOwner);
		}

		// Token: 0x0400289F RID: 10399
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathRBFInterpolateQuatQuat";

		// Token: 0x040028A0 RID: 10400
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040028A1 RID: 10401
		internal static int __PropertyOffset_Targets;

		// Token: 0x040028A2 RID: 10402
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMathRBFInterpolateQuatQuat_Target> _Targets;

		// Token: 0x040028A3 RID: 10403
		internal static int __PropertyOffset_Output;
	}
}
