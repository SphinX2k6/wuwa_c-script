using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200064F RID: 1615
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathRBFInterpolateVectorFloat")]
	[UnrealStructLayout(224, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 224)]
	public class FRigUnit_MathRBFInterpolateVectorFloat : FRigUnit_MathRBFInterpolateVectorBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005622 RID: 22050 RVA: 0x0007CCB0 File Offset: 0x0007AEB0
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathRBFInterpolateVectorFloat._ScriptStructPtr != 0) ? FRigUnit_MathRBFInterpolateVectorFloat._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathRBFInterpolateVectorFloat", ref FRigUnit_MathRBFInterpolateVectorFloat._ScriptStructPtr);
		}

		// Token: 0x170014B0 RID: 5296
		// (get) Token: 0x06005623 RID: 22051 RVA: 0x0007CCD4 File Offset: 0x0007AED4
		// (set) Token: 0x06005624 RID: 22052 RVA: 0x0007CD17 File Offset: 0x0007AF17
		public TArray<FMathRBFInterpolateVectorFloat_Target> Targets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMathRBFInterpolateVectorFloat_Target> result;
				if ((result = this._Targets) == null)
				{
					result = (this._Targets = new TArray<FMathRBFInterpolateVectorFloat_Target>(base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateVectorFloat.__PropertyOffset_Targets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Targets.CopyAssign(value);
			}
		}

		// Token: 0x170014B1 RID: 5297
		// (get) Token: 0x06005625 RID: 22053 RVA: 0x0007CD25 File Offset: 0x0007AF25
		// (set) Token: 0x06005626 RID: 22054 RVA: 0x0007CD35 File Offset: 0x0007AF35
		public unsafe float Output
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateVectorFloat.__PropertyOffset_Output);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateVectorFloat.__PropertyOffset_Output) = value;
			}
		}

		// Token: 0x06005627 RID: 22055 RVA: 0x0007CD46 File Offset: 0x0007AF46
		public FRigUnit_MathRBFInterpolateVectorFloat()
		{
		}

		// Token: 0x06005628 RID: 22056 RVA: 0x0007CD50 File Offset: 0x0007AF50
		public FRigUnit_MathRBFInterpolateVectorFloat(TArray<FMathRBFInterpolateVectorFloat_Target> Targets, float Output, FVector Input, ERBFVectorDistanceType DistanceFunction, ERBFKernelType SmoothingFunction, float SmoothingRadius, bool bNormalizeOutput, FRigUnit_MathRBFInterpolateVectorWorkData WorkData)
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

		// Token: 0x06005629 RID: 22057 RVA: 0x0007CDA0 File Offset: 0x0007AFA0
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathRBFInterpolateVectorFloat.StaticStruct();
		}

		// Token: 0x0600562A RID: 22058 RVA: 0x0007CDAC File Offset: 0x0007AFAC
		[NullableContext(2)]
		public FRigUnit_MathRBFInterpolateVectorFloat(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600562B RID: 22059 RVA: 0x0007CDB6 File Offset: 0x0007AFB6
		public FRigUnit_MathRBFInterpolateVectorFloat(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600562C RID: 22060 RVA: 0x0007CDC1 File Offset: 0x0007AFC1
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathRBFInterpolateVectorFloat(Pointer, false, true);
		}

		// Token: 0x0600562D RID: 22061 RVA: 0x0007CDCB File Offset: 0x0007AFCB
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathRBFInterpolateVectorFloat(Pointer, MemoryOwner);
		}

		// Token: 0x040028BE RID: 10430
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathRBFInterpolateVectorFloat";

		// Token: 0x040028BF RID: 10431
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040028C0 RID: 10432
		internal static int __PropertyOffset_Targets;

		// Token: 0x040028C1 RID: 10433
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMathRBFInterpolateVectorFloat_Target> _Targets;

		// Token: 0x040028C2 RID: 10434
		internal static int __PropertyOffset_Output;
	}
}
