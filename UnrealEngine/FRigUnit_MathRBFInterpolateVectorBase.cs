using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200064D RID: 1613
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathRBFInterpolateVectorBase")]
	[UnrealStructLayout(192, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 192)]
	public class FRigUnit_MathRBFInterpolateVectorBase : FRigUnit_MathRBFInterpolateBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005602 RID: 22018 RVA: 0x0007C9D8 File Offset: 0x0007ABD8
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathRBFInterpolateVectorBase._ScriptStructPtr != 0) ? FRigUnit_MathRBFInterpolateVectorBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathRBFInterpolateVectorBase", ref FRigUnit_MathRBFInterpolateVectorBase._ScriptStructPtr);
		}

		// Token: 0x170014A8 RID: 5288
		// (get) Token: 0x06005603 RID: 22019 RVA: 0x0007C9FC File Offset: 0x0007ABFC
		// (set) Token: 0x06005604 RID: 22020 RVA: 0x0007CA10 File Offset: 0x0007AC10
		public unsafe FVector Input
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateVectorBase.__PropertyOffset_Input);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateVectorBase.__PropertyOffset_Input) = value;
			}
		}

		// Token: 0x170014A9 RID: 5289
		// (get) Token: 0x06005605 RID: 22021 RVA: 0x0007CA25 File Offset: 0x0007AC25
		// (set) Token: 0x06005606 RID: 22022 RVA: 0x0007CA35 File Offset: 0x0007AC35
		public unsafe ERBFVectorDistanceType DistanceFunction
		{
			get
			{
				return (ERBFVectorDistanceType)(*(base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateVectorBase.__PropertyOffset_DistanceFunction));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateVectorBase.__PropertyOffset_DistanceFunction) = (byte)value;
			}
		}

		// Token: 0x170014AA RID: 5290
		// (get) Token: 0x06005607 RID: 22023 RVA: 0x0007CA46 File Offset: 0x0007AC46
		// (set) Token: 0x06005608 RID: 22024 RVA: 0x0007CA56 File Offset: 0x0007AC56
		public unsafe ERBFKernelType SmoothingFunction
		{
			get
			{
				return (ERBFKernelType)(*(base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateVectorBase.__PropertyOffset_SmoothingFunction));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateVectorBase.__PropertyOffset_SmoothingFunction) = (byte)value;
			}
		}

		// Token: 0x170014AB RID: 5291
		// (get) Token: 0x06005609 RID: 22025 RVA: 0x0007CA67 File Offset: 0x0007AC67
		// (set) Token: 0x0600560A RID: 22026 RVA: 0x0007CA77 File Offset: 0x0007AC77
		public unsafe float SmoothingRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateVectorBase.__PropertyOffset_SmoothingRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateVectorBase.__PropertyOffset_SmoothingRadius) = value;
			}
		}

		// Token: 0x170014AC RID: 5292
		// (get) Token: 0x0600560B RID: 22027 RVA: 0x0007CA88 File Offset: 0x0007AC88
		// (set) Token: 0x0600560C RID: 22028 RVA: 0x0007CA98 File Offset: 0x0007AC98
		public unsafe bool bNormalizeOutput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateVectorBase.__PropertyOffset_bNormalizeOutput) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateVectorBase.__PropertyOffset_bNormalizeOutput) = (value ? 1 : 0);
			}
		}

		// Token: 0x170014AD RID: 5293
		// (get) Token: 0x0600560D RID: 22029 RVA: 0x0007CAAC File Offset: 0x0007ACAC
		// (set) Token: 0x0600560E RID: 22030 RVA: 0x0007CAEF File Offset: 0x0007ACEF
		public FRigUnit_MathRBFInterpolateVectorWorkData WorkData
		{
			get
			{
				base.FastCheckIsValid();
				FRigUnit_MathRBFInterpolateVectorWorkData result;
				if ((result = this._WorkData) == null)
				{
					result = (this._WorkData = new FRigUnit_MathRBFInterpolateVectorWorkData(base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateVectorBase.__PropertyOffset_WorkData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigUnit_MathRBFInterpolateVectorWorkData.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_MathRBFInterpolateVectorBase.__PropertyOffset_WorkData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600560F RID: 22031 RVA: 0x0007CB10 File Offset: 0x0007AD10
		public FRigUnit_MathRBFInterpolateVectorBase()
		{
		}

		// Token: 0x06005610 RID: 22032 RVA: 0x0007CB18 File Offset: 0x0007AD18
		public FRigUnit_MathRBFInterpolateVectorBase(FVector Input, ERBFVectorDistanceType DistanceFunction, ERBFKernelType SmoothingFunction, float SmoothingRadius, bool bNormalizeOutput, FRigUnit_MathRBFInterpolateVectorWorkData WorkData)
		{
			this.Input = Input;
			this.DistanceFunction = DistanceFunction;
			this.SmoothingFunction = SmoothingFunction;
			this.SmoothingRadius = SmoothingRadius;
			this.bNormalizeOutput = bNormalizeOutput;
			this.WorkData = WorkData;
		}

		// Token: 0x06005611 RID: 22033 RVA: 0x0007CB4D File Offset: 0x0007AD4D
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathRBFInterpolateVectorBase.StaticStruct();
		}

		// Token: 0x06005612 RID: 22034 RVA: 0x0007CB59 File Offset: 0x0007AD59
		[NullableContext(2)]
		public FRigUnit_MathRBFInterpolateVectorBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005613 RID: 22035 RVA: 0x0007CB63 File Offset: 0x0007AD63
		public FRigUnit_MathRBFInterpolateVectorBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005614 RID: 22036 RVA: 0x0007CB6E File Offset: 0x0007AD6E
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathRBFInterpolateVectorBase(Pointer, false, true);
		}

		// Token: 0x06005615 RID: 22037 RVA: 0x0007CB78 File Offset: 0x0007AD78
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathRBFInterpolateVectorBase(Pointer, MemoryOwner);
		}

		// Token: 0x040028B0 RID: 10416
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathRBFInterpolateVectorBase";

		// Token: 0x040028B1 RID: 10417
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040028B2 RID: 10418
		internal static int __PropertyOffset_Input;

		// Token: 0x040028B3 RID: 10419
		internal static int __PropertyOffset_DistanceFunction;

		// Token: 0x040028B4 RID: 10420
		internal static int __PropertyOffset_SmoothingFunction;

		// Token: 0x040028B5 RID: 10421
		internal static int __PropertyOffset_SmoothingRadius;

		// Token: 0x040028B6 RID: 10422
		internal static int __PropertyOffset_bNormalizeOutput;

		// Token: 0x040028B7 RID: 10423
		internal static int __PropertyOffset_WorkData;

		// Token: 0x040028B8 RID: 10424
		[Nullable(2)]
		private FRigUnit_MathRBFInterpolateVectorWorkData _WorkData;
	}
}
