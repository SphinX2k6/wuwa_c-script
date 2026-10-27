using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000650 RID: 1616
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathRBFInterpolateVectorQuat")]
	[UnrealStructLayout(224, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 224)]
	public class FRigUnit_MathRBFInterpolateVectorQuat : FRigUnit_MathRBFInterpolateVectorBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600562E RID: 22062 RVA: 0x0007CDD4 File Offset: 0x0007AFD4
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathRBFInterpolateVectorQuat._ScriptStructPtr != 0) ? FRigUnit_MathRBFInterpolateVectorQuat._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathRBFInterpolateVectorQuat", ref FRigUnit_MathRBFInterpolateVectorQuat._ScriptStructPtr);
		}

		// Token: 0x170014B2 RID: 5298
		// (get) Token: 0x0600562F RID: 22063 RVA: 0x0007CDF8 File Offset: 0x0007AFF8
		// (set) Token: 0x06005630 RID: 22064 RVA: 0x0007CE3B File Offset: 0x0007B03B
		public TArray<FMathRBFInterpolateVectorQuat_Target> Targets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMathRBFInterpolateVectorQuat_Target> result;
				if ((result = this._Targets) == null)
				{
					result = (this._Targets = new TArray<FMathRBFInterpolateVectorQuat_Target>(base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateVectorQuat.__PropertyOffset_Targets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Targets.CopyAssign(value);
			}
		}

		// Token: 0x170014B3 RID: 5299
		// (get) Token: 0x06005631 RID: 22065 RVA: 0x0007CE49 File Offset: 0x0007B049
		// (set) Token: 0x06005632 RID: 22066 RVA: 0x0007CE5D File Offset: 0x0007B05D
		public unsafe FQuat Output
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateVectorQuat.__PropertyOffset_Output);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateVectorQuat.__PropertyOffset_Output) = value;
			}
		}

		// Token: 0x06005633 RID: 22067 RVA: 0x0007CE72 File Offset: 0x0007B072
		public FRigUnit_MathRBFInterpolateVectorQuat()
		{
		}

		// Token: 0x06005634 RID: 22068 RVA: 0x0007CE7C File Offset: 0x0007B07C
		public FRigUnit_MathRBFInterpolateVectorQuat(TArray<FMathRBFInterpolateVectorQuat_Target> Targets, FQuat Output, FVector Input, ERBFVectorDistanceType DistanceFunction, ERBFKernelType SmoothingFunction, float SmoothingRadius, bool bNormalizeOutput, FRigUnit_MathRBFInterpolateVectorWorkData WorkData)
		{
			this.Targets = Targets;
			this.Output = Output;
			base.Input = Input;
			base.DistanceFunction = DistanceFunction;
			base.SmoothingFunction = SmoothingFunction;
			base.SmoothingRadius = SmoothingRadius;
			base.bNormalizeOutput = bNormalizeOutput;
			base.WorkData = WorkData;
		}

		// Token: 0x06005635 RID: 22069 RVA: 0x0007CECC File Offset: 0x0007B0CC
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathRBFInterpolateVectorQuat.StaticStruct();
		}

		// Token: 0x06005636 RID: 22070 RVA: 0x0007CED8 File Offset: 0x0007B0D8
		[NullableContext(2)]
		public FRigUnit_MathRBFInterpolateVectorQuat(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005637 RID: 22071 RVA: 0x0007CEE2 File Offset: 0x0007B0E2
		public FRigUnit_MathRBFInterpolateVectorQuat(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005638 RID: 22072 RVA: 0x0007CEED File Offset: 0x0007B0ED
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathRBFInterpolateVectorQuat(Pointer, false, true);
		}

		// Token: 0x06005639 RID: 22073 RVA: 0x0007CEF7 File Offset: 0x0007B0F7
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathRBFInterpolateVectorQuat(Pointer, MemoryOwner);
		}

		// Token: 0x040028C3 RID: 10435
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathRBFInterpolateVectorQuat";

		// Token: 0x040028C4 RID: 10436
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040028C5 RID: 10437
		internal static int __PropertyOffset_Targets;

		// Token: 0x040028C6 RID: 10438
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMathRBFInterpolateVectorQuat_Target> _Targets;

		// Token: 0x040028C7 RID: 10439
		internal static int __PropertyOffset_Output;
	}
}
