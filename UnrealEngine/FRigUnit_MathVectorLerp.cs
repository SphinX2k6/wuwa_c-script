using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000679 RID: 1657
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathVectorLerp")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRigUnit_MathVectorLerp : FRigUnit_MathVectorBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600583D RID: 22589 RVA: 0x0007F373 File Offset: 0x0007D573
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathVectorLerp._ScriptStructPtr != 0) ? FRigUnit_MathVectorLerp._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathVectorLerp", ref FRigUnit_MathVectorLerp._ScriptStructPtr);
		}

		// Token: 0x17001517 RID: 5399
		// (get) Token: 0x0600583E RID: 22590 RVA: 0x0007F397 File Offset: 0x0007D597
		// (set) Token: 0x0600583F RID: 22591 RVA: 0x0007F3AB File Offset: 0x0007D5AB
		public unsafe FVector A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorLerp.__PropertyOffset_A);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorLerp.__PropertyOffset_A) = value;
			}
		}

		// Token: 0x17001518 RID: 5400
		// (get) Token: 0x06005840 RID: 22592 RVA: 0x0007F3C0 File Offset: 0x0007D5C0
		// (set) Token: 0x06005841 RID: 22593 RVA: 0x0007F3D4 File Offset: 0x0007D5D4
		public unsafe FVector B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorLerp.__PropertyOffset_B);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorLerp.__PropertyOffset_B) = value;
			}
		}

		// Token: 0x17001519 RID: 5401
		// (get) Token: 0x06005842 RID: 22594 RVA: 0x0007F3E9 File Offset: 0x0007D5E9
		// (set) Token: 0x06005843 RID: 22595 RVA: 0x0007F3F9 File Offset: 0x0007D5F9
		public unsafe float T
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorLerp.__PropertyOffset_T);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorLerp.__PropertyOffset_T) = value;
			}
		}

		// Token: 0x1700151A RID: 5402
		// (get) Token: 0x06005844 RID: 22596 RVA: 0x0007F40A File Offset: 0x0007D60A
		// (set) Token: 0x06005845 RID: 22597 RVA: 0x0007F41E File Offset: 0x0007D61E
		public unsafe FVector Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorLerp.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorLerp.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x06005846 RID: 22598 RVA: 0x0007F433 File Offset: 0x0007D633
		public FRigUnit_MathVectorLerp()
		{
		}

		// Token: 0x06005847 RID: 22599 RVA: 0x0007F43B File Offset: 0x0007D63B
		public FRigUnit_MathVectorLerp(FVector A, FVector B, float T, FVector Result)
		{
			this.A = A;
			this.B = B;
			this.T = T;
			this.Result = Result;
		}

		// Token: 0x06005848 RID: 22600 RVA: 0x0007F460 File Offset: 0x0007D660
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathVectorLerp.StaticStruct();
		}

		// Token: 0x06005849 RID: 22601 RVA: 0x0007F46C File Offset: 0x0007D66C
		[NullableContext(2)]
		public FRigUnit_MathVectorLerp(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600584A RID: 22602 RVA: 0x0007F476 File Offset: 0x0007D676
		public FRigUnit_MathVectorLerp(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600584B RID: 22603 RVA: 0x0007F481 File Offset: 0x0007D681
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathVectorLerp(Pointer, false, true);
		}

		// Token: 0x0600584C RID: 22604 RVA: 0x0007F48B File Offset: 0x0007D68B
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathVectorLerp(Pointer, MemoryOwner);
		}

		// Token: 0x04002981 RID: 10625
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathVectorLerp";

		// Token: 0x04002982 RID: 10626
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002983 RID: 10627
		internal static int __PropertyOffset_A;

		// Token: 0x04002984 RID: 10628
		internal static int __PropertyOffset_B;

		// Token: 0x04002985 RID: 10629
		internal static int __PropertyOffset_T;

		// Token: 0x04002986 RID: 10630
		internal static int __PropertyOffset_Result;
	}
}
