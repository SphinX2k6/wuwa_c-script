using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000510 RID: 1296
	[UnrealObjectPath("/Script/ControlRig.MathRBFInterpolateVectorXform_Target")]
	[UnrealStructLayout(64, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FMathRBFInterpolateVectorXform_Target : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060043A3 RID: 17315 RVA: 0x00064B56 File Offset: 0x00062D56
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMathRBFInterpolateVectorXform_Target._ScriptStructPtr != 0) ? FMathRBFInterpolateVectorXform_Target._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.MathRBFInterpolateVectorXform_Target", ref FMathRBFInterpolateVectorXform_Target._ScriptStructPtr);
		}

		// Token: 0x17001060 RID: 4192
		// (get) Token: 0x060043A4 RID: 17316 RVA: 0x00064B7A File Offset: 0x00062D7A
		// (set) Token: 0x060043A5 RID: 17317 RVA: 0x00064B8E File Offset: 0x00062D8E
		public unsafe FVector Target
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMathRBFInterpolateVectorXform_Target.__PropertyOffset_Target);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMathRBFInterpolateVectorXform_Target.__PropertyOffset_Target) = value;
			}
		}

		// Token: 0x17001061 RID: 4193
		// (get) Token: 0x060043A6 RID: 17318 RVA: 0x00064BA3 File Offset: 0x00062DA3
		// (set) Token: 0x060043A7 RID: 17319 RVA: 0x00064BB7 File Offset: 0x00062DB7
		public unsafe FTransform Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMathRBFInterpolateVectorXform_Target.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMathRBFInterpolateVectorXform_Target.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x060043A8 RID: 17320 RVA: 0x00064BCC File Offset: 0x00062DCC
		public FMathRBFInterpolateVectorXform_Target()
		{
		}

		// Token: 0x060043A9 RID: 17321 RVA: 0x00064BD4 File Offset: 0x00062DD4
		public FMathRBFInterpolateVectorXform_Target(FVector Target, FTransform Value)
		{
			this.Target = Target;
			this.Value = Value;
		}

		// Token: 0x060043AA RID: 17322 RVA: 0x00064BEA File Offset: 0x00062DEA
		protected override IntPtr GetUStructPtr()
		{
			return FMathRBFInterpolateVectorXform_Target.StaticStruct();
		}

		// Token: 0x060043AB RID: 17323 RVA: 0x00064BF6 File Offset: 0x00062DF6
		[NullableContext(2)]
		public FMathRBFInterpolateVectorXform_Target(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060043AC RID: 17324 RVA: 0x00064C00 File Offset: 0x00062E00
		public FMathRBFInterpolateVectorXform_Target(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060043AD RID: 17325 RVA: 0x00064C0B File Offset: 0x00062E0B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMathRBFInterpolateVectorXform_Target(Pointer, false, true);
		}

		// Token: 0x060043AE RID: 17326 RVA: 0x00064C15 File Offset: 0x00062E15
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMathRBFInterpolateVectorXform_Target(Pointer, MemoryOwner);
		}

		// Token: 0x040020EB RID: 8427
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.MathRBFInterpolateVectorXform_Target";

		// Token: 0x040020EC RID: 8428
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040020ED RID: 8429
		internal static int __PropertyOffset_Target;

		// Token: 0x040020EE RID: 8430
		internal static int __PropertyOffset_Value;
	}
}
