using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200066F RID: 1647
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathVectorDistance")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FRigUnit_MathVectorDistance : FRigUnit_MathVectorBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060057C1 RID: 22465 RVA: 0x0007EB6F File Offset: 0x0007CD6F
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathVectorDistance._ScriptStructPtr != 0) ? FRigUnit_MathVectorDistance._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathVectorDistance", ref FRigUnit_MathVectorDistance._ScriptStructPtr);
		}

		// Token: 0x17001501 RID: 5377
		// (get) Token: 0x060057C2 RID: 22466 RVA: 0x0007EB93 File Offset: 0x0007CD93
		// (set) Token: 0x060057C3 RID: 22467 RVA: 0x0007EBA7 File Offset: 0x0007CDA7
		public unsafe FVector A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorDistance.__PropertyOffset_A);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorDistance.__PropertyOffset_A) = value;
			}
		}

		// Token: 0x17001502 RID: 5378
		// (get) Token: 0x060057C4 RID: 22468 RVA: 0x0007EBBC File Offset: 0x0007CDBC
		// (set) Token: 0x060057C5 RID: 22469 RVA: 0x0007EBD0 File Offset: 0x0007CDD0
		public unsafe FVector B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorDistance.__PropertyOffset_B);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorDistance.__PropertyOffset_B) = value;
			}
		}

		// Token: 0x17001503 RID: 5379
		// (get) Token: 0x060057C6 RID: 22470 RVA: 0x0007EBE5 File Offset: 0x0007CDE5
		// (set) Token: 0x060057C7 RID: 22471 RVA: 0x0007EBF5 File Offset: 0x0007CDF5
		public unsafe float Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorDistance.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorDistance.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x060057C8 RID: 22472 RVA: 0x0007EC06 File Offset: 0x0007CE06
		public FRigUnit_MathVectorDistance()
		{
		}

		// Token: 0x060057C9 RID: 22473 RVA: 0x0007EC0E File Offset: 0x0007CE0E
		public FRigUnit_MathVectorDistance(FVector A, FVector B, float Result)
		{
			this.A = A;
			this.B = B;
			this.Result = Result;
		}

		// Token: 0x060057CA RID: 22474 RVA: 0x0007EC2B File Offset: 0x0007CE2B
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathVectorDistance.StaticStruct();
		}

		// Token: 0x060057CB RID: 22475 RVA: 0x0007EC37 File Offset: 0x0007CE37
		[NullableContext(2)]
		public FRigUnit_MathVectorDistance(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060057CC RID: 22476 RVA: 0x0007EC41 File Offset: 0x0007CE41
		public FRigUnit_MathVectorDistance(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060057CD RID: 22477 RVA: 0x0007EC4C File Offset: 0x0007CE4C
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathVectorDistance(Pointer, false, true);
		}

		// Token: 0x060057CE RID: 22478 RVA: 0x0007EC56 File Offset: 0x0007CE56
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathVectorDistance(Pointer, MemoryOwner);
		}

		// Token: 0x04002957 RID: 10583
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathVectorDistance";

		// Token: 0x04002958 RID: 10584
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002959 RID: 10585
		internal static int __PropertyOffset_A;

		// Token: 0x0400295A RID: 10586
		internal static int __PropertyOffset_B;

		// Token: 0x0400295B RID: 10587
		internal static int __PropertyOffset_Result;
	}
}
