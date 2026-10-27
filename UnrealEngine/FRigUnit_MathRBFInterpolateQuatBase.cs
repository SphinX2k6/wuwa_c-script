using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000646 RID: 1606
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathRBFInterpolateQuatBase")]
	[UnrealStructLayout(224, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 224)]
	public class FRigUnit_MathRBFInterpolateQuatBase : FRigUnit_MathRBFInterpolateBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060055A9 RID: 21929 RVA: 0x0007C1A0 File Offset: 0x0007A3A0
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathRBFInterpolateQuatBase._ScriptStructPtr != 0) ? FRigUnit_MathRBFInterpolateQuatBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathRBFInterpolateQuatBase", ref FRigUnit_MathRBFInterpolateQuatBase._ScriptStructPtr);
		}

		// Token: 0x17001497 RID: 5271
		// (get) Token: 0x060055AA RID: 21930 RVA: 0x0007C1C4 File Offset: 0x0007A3C4
		// (set) Token: 0x060055AB RID: 21931 RVA: 0x0007C1D8 File Offset: 0x0007A3D8
		public unsafe FQuat Input
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateQuatBase.__PropertyOffset_Input);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateQuatBase.__PropertyOffset_Input) = value;
			}
		}

		// Token: 0x17001498 RID: 5272
		// (get) Token: 0x060055AC RID: 21932 RVA: 0x0007C1ED File Offset: 0x0007A3ED
		// (set) Token: 0x060055AD RID: 21933 RVA: 0x0007C1FD File Offset: 0x0007A3FD
		public unsafe ERBFQuatDistanceType DistanceFunction
		{
			get
			{
				return (ERBFQuatDistanceType)(*(base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateQuatBase.__PropertyOffset_DistanceFunction));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateQuatBase.__PropertyOffset_DistanceFunction) = (byte)value;
			}
		}

		// Token: 0x17001499 RID: 5273
		// (get) Token: 0x060055AE RID: 21934 RVA: 0x0007C20E File Offset: 0x0007A40E
		// (set) Token: 0x060055AF RID: 21935 RVA: 0x0007C21E File Offset: 0x0007A41E
		public unsafe ERBFKernelType SmoothingFunction
		{
			get
			{
				return (ERBFKernelType)(*(base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateQuatBase.__PropertyOffset_SmoothingFunction));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateQuatBase.__PropertyOffset_SmoothingFunction) = (byte)value;
			}
		}

		// Token: 0x1700149A RID: 5274
		// (get) Token: 0x060055B0 RID: 21936 RVA: 0x0007C22F File Offset: 0x0007A42F
		// (set) Token: 0x060055B1 RID: 21937 RVA: 0x0007C23F File Offset: 0x0007A43F
		public unsafe float SmoothingAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateQuatBase.__PropertyOffset_SmoothingAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateQuatBase.__PropertyOffset_SmoothingAngle) = value;
			}
		}

		// Token: 0x1700149B RID: 5275
		// (get) Token: 0x060055B2 RID: 21938 RVA: 0x0007C250 File Offset: 0x0007A450
		// (set) Token: 0x060055B3 RID: 21939 RVA: 0x0007C260 File Offset: 0x0007A460
		public unsafe bool bNormalizeOutput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateQuatBase.__PropertyOffset_bNormalizeOutput) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateQuatBase.__PropertyOffset_bNormalizeOutput) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700149C RID: 5276
		// (get) Token: 0x060055B4 RID: 21940 RVA: 0x0007C271 File Offset: 0x0007A471
		// (set) Token: 0x060055B5 RID: 21941 RVA: 0x0007C285 File Offset: 0x0007A485
		public unsafe FVector TwistAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateQuatBase.__PropertyOffset_TwistAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateQuatBase.__PropertyOffset_TwistAxis) = value;
			}
		}

		// Token: 0x1700149D RID: 5277
		// (get) Token: 0x060055B6 RID: 21942 RVA: 0x0007C29C File Offset: 0x0007A49C
		// (set) Token: 0x060055B7 RID: 21943 RVA: 0x0007C2DF File Offset: 0x0007A4DF
		public FRigUnit_MathRBFInterpolateQuatWorkData WorkData
		{
			get
			{
				base.FastCheckIsValid();
				FRigUnit_MathRBFInterpolateQuatWorkData result;
				if ((result = this._WorkData) == null)
				{
					result = (this._WorkData = new FRigUnit_MathRBFInterpolateQuatWorkData(base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateQuatBase.__PropertyOffset_WorkData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigUnit_MathRBFInterpolateQuatWorkData.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateQuatBase.__PropertyOffset_WorkData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060055B8 RID: 21944 RVA: 0x0007C300 File Offset: 0x0007A500
		public FRigUnit_MathRBFInterpolateQuatBase()
		{
		}

		// Token: 0x060055B9 RID: 21945 RVA: 0x0007C308 File Offset: 0x0007A508
		public FRigUnit_MathRBFInterpolateQuatBase(FQuat Input, ERBFQuatDistanceType DistanceFunction, ERBFKernelType SmoothingFunction, float SmoothingAngle, bool bNormalizeOutput, FVector TwistAxis, FRigUnit_MathRBFInterpolateQuatWorkData WorkData)
		{
			this.Input = Input;
			this.DistanceFunction = DistanceFunction;
			this.SmoothingFunction = SmoothingFunction;
			this.SmoothingAngle = SmoothingAngle;
			this.bNormalizeOutput = bNormalizeOutput;
			this.TwistAxis = TwistAxis;
			this.WorkData = WorkData;
		}

		// Token: 0x060055BA RID: 21946 RVA: 0x0007C345 File Offset: 0x0007A545
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathRBFInterpolateQuatBase.StaticStruct();
		}

		// Token: 0x060055BB RID: 21947 RVA: 0x0007C351 File Offset: 0x0007A551
		[NullableContext(2)]
		public FRigUnit_MathRBFInterpolateQuatBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060055BC RID: 21948 RVA: 0x0007C35B File Offset: 0x0007A55B
		public FRigUnit_MathRBFInterpolateQuatBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060055BD RID: 21949 RVA: 0x0007C366 File Offset: 0x0007A566
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathRBFInterpolateQuatBase(Pointer, false, true);
		}

		// Token: 0x060055BE RID: 21950 RVA: 0x0007C370 File Offset: 0x0007A570
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathRBFInterpolateQuatBase(Pointer, MemoryOwner);
		}

		// Token: 0x0400288B RID: 10379
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathRBFInterpolateQuatBase";

		// Token: 0x0400288C RID: 10380
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400288D RID: 10381
		internal static int __PropertyOffset_Input;

		// Token: 0x0400288E RID: 10382
		internal static int __PropertyOffset_DistanceFunction;

		// Token: 0x0400288F RID: 10383
		internal static int __PropertyOffset_SmoothingFunction;

		// Token: 0x04002890 RID: 10384
		internal static int __PropertyOffset_SmoothingAngle;

		// Token: 0x04002891 RID: 10385
		internal static int __PropertyOffset_bNormalizeOutput;

		// Token: 0x04002892 RID: 10386
		internal static int __PropertyOffset_TwistAxis;

		// Token: 0x04002893 RID: 10387
		internal static int __PropertyOffset_WorkData;

		// Token: 0x04002894 RID: 10388
		[Nullable(2)]
		private FRigUnit_MathRBFInterpolateQuatWorkData _WorkData;
	}
}
