using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000651 RID: 1617
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathRBFInterpolateVectorVector")]
	[UnrealStructLayout(224, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 224)]
	public class FRigUnit_MathRBFInterpolateVectorVector : FRigUnit_MathRBFInterpolateVectorBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600563A RID: 22074 RVA: 0x0007CF00 File Offset: 0x0007B100
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathRBFInterpolateVectorVector._ScriptStructPtr != 0) ? FRigUnit_MathRBFInterpolateVectorVector._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathRBFInterpolateVectorVector", ref FRigUnit_MathRBFInterpolateVectorVector._ScriptStructPtr);
		}

		// Token: 0x170014B4 RID: 5300
		// (get) Token: 0x0600563B RID: 22075 RVA: 0x0007CF24 File Offset: 0x0007B124
		// (set) Token: 0x0600563C RID: 22076 RVA: 0x0007CF67 File Offset: 0x0007B167
		public TArray<FMathRBFInterpolateVectorVector_Target> Targets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMathRBFInterpolateVectorVector_Target> result;
				if ((result = this._Targets) == null)
				{
					result = (this._Targets = new TArray<FMathRBFInterpolateVectorVector_Target>(base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateVectorVector.__PropertyOffset_Targets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Targets.CopyAssign(value);
			}
		}

		// Token: 0x170014B5 RID: 5301
		// (get) Token: 0x0600563D RID: 22077 RVA: 0x0007CF75 File Offset: 0x0007B175
		// (set) Token: 0x0600563E RID: 22078 RVA: 0x0007CF89 File Offset: 0x0007B189
		public unsafe FVector Output
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateVectorVector.__PropertyOffset_Output);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateVectorVector.__PropertyOffset_Output) = value;
			}
		}

		// Token: 0x0600563F RID: 22079 RVA: 0x0007CF9E File Offset: 0x0007B19E
		public FRigUnit_MathRBFInterpolateVectorVector()
		{
		}

		// Token: 0x06005640 RID: 22080 RVA: 0x0007CFA8 File Offset: 0x0007B1A8
		public FRigUnit_MathRBFInterpolateVectorVector(TArray<FMathRBFInterpolateVectorVector_Target> Targets, FVector Output, FVector Input, ERBFVectorDistanceType DistanceFunction, ERBFKernelType SmoothingFunction, float SmoothingRadius, bool bNormalizeOutput, FRigUnit_MathRBFInterpolateVectorWorkData WorkData)
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

		// Token: 0x06005641 RID: 22081 RVA: 0x0007CFF8 File Offset: 0x0007B1F8
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathRBFInterpolateVectorVector.StaticStruct();
		}

		// Token: 0x06005642 RID: 22082 RVA: 0x0007D004 File Offset: 0x0007B204
		[NullableContext(2)]
		public FRigUnit_MathRBFInterpolateVectorVector(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005643 RID: 22083 RVA: 0x0007D00E File Offset: 0x0007B20E
		public FRigUnit_MathRBFInterpolateVectorVector(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005644 RID: 22084 RVA: 0x0007D019 File Offset: 0x0007B219
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathRBFInterpolateVectorVector(Pointer, false, true);
		}

		// Token: 0x06005645 RID: 22085 RVA: 0x0007D023 File Offset: 0x0007B223
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathRBFInterpolateVectorVector(Pointer, MemoryOwner);
		}

		// Token: 0x040028C8 RID: 10440
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathRBFInterpolateVectorVector";

		// Token: 0x040028C9 RID: 10441
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040028CA RID: 10442
		internal static int __PropertyOffset_Targets;

		// Token: 0x040028CB RID: 10443
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMathRBFInterpolateVectorVector_Target> _Targets;

		// Token: 0x040028CC RID: 10444
		internal static int __PropertyOffset_Output;
	}
}
