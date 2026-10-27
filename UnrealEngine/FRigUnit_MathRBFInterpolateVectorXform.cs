using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000653 RID: 1619
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathRBFInterpolateVectorXform")]
	[UnrealStructLayout(256, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 256)]
	public class FRigUnit_MathRBFInterpolateVectorXform : FRigUnit_MathRBFInterpolateVectorBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600564D RID: 22093 RVA: 0x0007D08C File Offset: 0x0007B28C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathRBFInterpolateVectorXform._ScriptStructPtr != 0) ? FRigUnit_MathRBFInterpolateVectorXform._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathRBFInterpolateVectorXform", ref FRigUnit_MathRBFInterpolateVectorXform._ScriptStructPtr);
		}

		// Token: 0x170014B6 RID: 5302
		// (get) Token: 0x0600564E RID: 22094 RVA: 0x0007D0B0 File Offset: 0x0007B2B0
		// (set) Token: 0x0600564F RID: 22095 RVA: 0x0007D0F3 File Offset: 0x0007B2F3
		public TArray<FMathRBFInterpolateVectorXform_Target> Targets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMathRBFInterpolateVectorXform_Target> result;
				if ((result = this._Targets) == null)
				{
					result = (this._Targets = new TArray<FMathRBFInterpolateVectorXform_Target>(base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateVectorXform.__PropertyOffset_Targets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Targets.CopyAssign(value);
			}
		}

		// Token: 0x170014B7 RID: 5303
		// (get) Token: 0x06005650 RID: 22096 RVA: 0x0007D101 File Offset: 0x0007B301
		// (set) Token: 0x06005651 RID: 22097 RVA: 0x0007D115 File Offset: 0x0007B315
		public unsafe FTransform Output
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateVectorXform.__PropertyOffset_Output);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateVectorXform.__PropertyOffset_Output) = value;
			}
		}

		// Token: 0x06005652 RID: 22098 RVA: 0x0007D12A File Offset: 0x0007B32A
		public FRigUnit_MathRBFInterpolateVectorXform()
		{
		}

		// Token: 0x06005653 RID: 22099 RVA: 0x0007D134 File Offset: 0x0007B334
		public FRigUnit_MathRBFInterpolateVectorXform(TArray<FMathRBFInterpolateVectorXform_Target> Targets, FTransform Output, FVector Input, ERBFVectorDistanceType DistanceFunction, ERBFKernelType SmoothingFunction, float SmoothingRadius, bool bNormalizeOutput, FRigUnit_MathRBFInterpolateVectorWorkData WorkData)
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

		// Token: 0x06005654 RID: 22100 RVA: 0x0007D184 File Offset: 0x0007B384
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathRBFInterpolateVectorXform.StaticStruct();
		}

		// Token: 0x06005655 RID: 22101 RVA: 0x0007D190 File Offset: 0x0007B390
		[NullableContext(2)]
		public FRigUnit_MathRBFInterpolateVectorXform(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005656 RID: 22102 RVA: 0x0007D19A File Offset: 0x0007B39A
		public FRigUnit_MathRBFInterpolateVectorXform(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005657 RID: 22103 RVA: 0x0007D1A5 File Offset: 0x0007B3A5
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathRBFInterpolateVectorXform(Pointer, false, true);
		}

		// Token: 0x06005658 RID: 22104 RVA: 0x0007D1AF File Offset: 0x0007B3AF
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathRBFInterpolateVectorXform(Pointer, MemoryOwner);
		}

		// Token: 0x040028CF RID: 10447
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathRBFInterpolateVectorXform";

		// Token: 0x040028D0 RID: 10448
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040028D1 RID: 10449
		internal static int __PropertyOffset_Targets;

		// Token: 0x040028D2 RID: 10450
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMathRBFInterpolateVectorXform_Target> _Targets;

		// Token: 0x040028D3 RID: 10451
		internal static int __PropertyOffset_Output;
	}
}
