using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200064C RID: 1612
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathRBFInterpolateQuatXform")]
	[UnrealStructLayout(288, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 288)]
	public class FRigUnit_MathRBFInterpolateQuatXform : FRigUnit_MathRBFInterpolateQuatBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060055F6 RID: 22006 RVA: 0x0007C8A4 File Offset: 0x0007AAA4
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathRBFInterpolateQuatXform._ScriptStructPtr != 0) ? FRigUnit_MathRBFInterpolateQuatXform._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathRBFInterpolateQuatXform", ref FRigUnit_MathRBFInterpolateQuatXform._ScriptStructPtr);
		}

		// Token: 0x170014A6 RID: 5286
		// (get) Token: 0x060055F7 RID: 22007 RVA: 0x0007C8C8 File Offset: 0x0007AAC8
		// (set) Token: 0x060055F8 RID: 22008 RVA: 0x0007C90B File Offset: 0x0007AB0B
		public TArray<FMathRBFInterpolateQuatXform_Target> Targets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMathRBFInterpolateQuatXform_Target> result;
				if ((result = this._Targets) == null)
				{
					result = (this._Targets = new TArray<FMathRBFInterpolateQuatXform_Target>(base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateQuatXform.__PropertyOffset_Targets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Targets.CopyAssign(value);
			}
		}

		// Token: 0x170014A7 RID: 5287
		// (get) Token: 0x060055F9 RID: 22009 RVA: 0x0007C919 File Offset: 0x0007AB19
		// (set) Token: 0x060055FA RID: 22010 RVA: 0x0007C92D File Offset: 0x0007AB2D
		public unsafe FTransform Output
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateQuatXform.__PropertyOffset_Output);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateQuatXform.__PropertyOffset_Output) = value;
			}
		}

		// Token: 0x060055FB RID: 22011 RVA: 0x0007C942 File Offset: 0x0007AB42
		public FRigUnit_MathRBFInterpolateQuatXform()
		{
		}

		// Token: 0x060055FC RID: 22012 RVA: 0x0007C94C File Offset: 0x0007AB4C
		public FRigUnit_MathRBFInterpolateQuatXform(TArray<FMathRBFInterpolateQuatXform_Target> Targets, FTransform Output, FQuat Input, ERBFQuatDistanceType DistanceFunction, ERBFKernelType SmoothingFunction, float SmoothingAngle, bool bNormalizeOutput, FVector TwistAxis, FRigUnit_MathRBFInterpolateQuatWorkData WorkData)
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

		// Token: 0x060055FD RID: 22013 RVA: 0x0007C9A4 File Offset: 0x0007ABA4
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathRBFInterpolateQuatXform.StaticStruct();
		}

		// Token: 0x060055FE RID: 22014 RVA: 0x0007C9B0 File Offset: 0x0007ABB0
		[NullableContext(2)]
		public FRigUnit_MathRBFInterpolateQuatXform(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060055FF RID: 22015 RVA: 0x0007C9BA File Offset: 0x0007ABBA
		public FRigUnit_MathRBFInterpolateQuatXform(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005600 RID: 22016 RVA: 0x0007C9C5 File Offset: 0x0007ABC5
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathRBFInterpolateQuatXform(Pointer, false, true);
		}

		// Token: 0x06005601 RID: 22017 RVA: 0x0007C9CF File Offset: 0x0007ABCF
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathRBFInterpolateQuatXform(Pointer, MemoryOwner);
		}

		// Token: 0x040028AB RID: 10411
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathRBFInterpolateQuatXform";

		// Token: 0x040028AC RID: 10412
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040028AD RID: 10413
		internal static int __PropertyOffset_Targets;

		// Token: 0x040028AE RID: 10414
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMathRBFInterpolateQuatXform_Target> _Targets;

		// Token: 0x040028AF RID: 10415
		internal static int __PropertyOffset_Output;
	}
}
