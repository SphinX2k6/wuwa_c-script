using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200064E RID: 1614
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathRBFInterpolateVectorColor")]
	[UnrealStructLayout(224, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 224)]
	public class FRigUnit_MathRBFInterpolateVectorColor : FRigUnit_MathRBFInterpolateVectorBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005616 RID: 22038 RVA: 0x0007CB81 File Offset: 0x0007AD81
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathRBFInterpolateVectorColor._ScriptStructPtr != 0) ? FRigUnit_MathRBFInterpolateVectorColor._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathRBFInterpolateVectorColor", ref FRigUnit_MathRBFInterpolateVectorColor._ScriptStructPtr);
		}

		// Token: 0x170014AE RID: 5294
		// (get) Token: 0x06005617 RID: 22039 RVA: 0x0007CBA8 File Offset: 0x0007ADA8
		// (set) Token: 0x06005618 RID: 22040 RVA: 0x0007CBEB File Offset: 0x0007ADEB
		public TArray<FMathRBFInterpolateVectorColor_Target> Targets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMathRBFInterpolateVectorColor_Target> result;
				if ((result = this._Targets) == null)
				{
					result = (this._Targets = new TArray<FMathRBFInterpolateVectorColor_Target>(base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateVectorColor.__PropertyOffset_Targets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Targets.CopyAssign(value);
			}
		}

		// Token: 0x170014AF RID: 5295
		// (get) Token: 0x06005619 RID: 22041 RVA: 0x0007CBF9 File Offset: 0x0007ADF9
		// (set) Token: 0x0600561A RID: 22042 RVA: 0x0007CC0D File Offset: 0x0007AE0D
		public unsafe FLinearColor Output
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateVectorColor.__PropertyOffset_Output);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateVectorColor.__PropertyOffset_Output) = value;
			}
		}

		// Token: 0x0600561B RID: 22043 RVA: 0x0007CC22 File Offset: 0x0007AE22
		public FRigUnit_MathRBFInterpolateVectorColor()
		{
		}

		// Token: 0x0600561C RID: 22044 RVA: 0x0007CC2C File Offset: 0x0007AE2C
		public FRigUnit_MathRBFInterpolateVectorColor(TArray<FMathRBFInterpolateVectorColor_Target> Targets, FLinearColor Output, FVector Input, ERBFVectorDistanceType DistanceFunction, ERBFKernelType SmoothingFunction, float SmoothingRadius, bool bNormalizeOutput, FRigUnit_MathRBFInterpolateVectorWorkData WorkData)
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

		// Token: 0x0600561D RID: 22045 RVA: 0x0007CC7C File Offset: 0x0007AE7C
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathRBFInterpolateVectorColor.StaticStruct();
		}

		// Token: 0x0600561E RID: 22046 RVA: 0x0007CC88 File Offset: 0x0007AE88
		[NullableContext(2)]
		public FRigUnit_MathRBFInterpolateVectorColor(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600561F RID: 22047 RVA: 0x0007CC92 File Offset: 0x0007AE92
		public FRigUnit_MathRBFInterpolateVectorColor(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005620 RID: 22048 RVA: 0x0007CC9D File Offset: 0x0007AE9D
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathRBFInterpolateVectorColor(Pointer, false, true);
		}

		// Token: 0x06005621 RID: 22049 RVA: 0x0007CCA7 File Offset: 0x0007AEA7
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathRBFInterpolateVectorColor(Pointer, MemoryOwner);
		}

		// Token: 0x040028B9 RID: 10425
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathRBFInterpolateVectorColor";

		// Token: 0x040028BA RID: 10426
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040028BB RID: 10427
		internal static int __PropertyOffset_Targets;

		// Token: 0x040028BC RID: 10428
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMathRBFInterpolateVectorColor_Target> _Targets;

		// Token: 0x040028BD RID: 10429
		internal static int __PropertyOffset_Output;
	}
}
