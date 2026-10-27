using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000678 RID: 1656
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathVectorLengthSquared")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_MathVectorLengthSquared : FRigUnit_MathVectorBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005831 RID: 22577 RVA: 0x0007F2B3 File Offset: 0x0007D4B3
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathVectorLengthSquared._ScriptStructPtr != 0) ? FRigUnit_MathVectorLengthSquared._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathVectorLengthSquared", ref FRigUnit_MathVectorLengthSquared._ScriptStructPtr);
		}

		// Token: 0x17001515 RID: 5397
		// (get) Token: 0x06005832 RID: 22578 RVA: 0x0007F2D7 File Offset: 0x0007D4D7
		// (set) Token: 0x06005833 RID: 22579 RVA: 0x0007F2EB File Offset: 0x0007D4EB
		public unsafe FVector Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorLengthSquared.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorLengthSquared.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x17001516 RID: 5398
		// (get) Token: 0x06005834 RID: 22580 RVA: 0x0007F300 File Offset: 0x0007D500
		// (set) Token: 0x06005835 RID: 22581 RVA: 0x0007F310 File Offset: 0x0007D510
		public unsafe float Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorLengthSquared.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorLengthSquared.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x06005836 RID: 22582 RVA: 0x0007F321 File Offset: 0x0007D521
		public FRigUnit_MathVectorLengthSquared()
		{
		}

		// Token: 0x06005837 RID: 22583 RVA: 0x0007F329 File Offset: 0x0007D529
		public FRigUnit_MathVectorLengthSquared(FVector Value, float Result)
		{
			this.Value = Value;
			this.Result = Result;
		}

		// Token: 0x06005838 RID: 22584 RVA: 0x0007F33F File Offset: 0x0007D53F
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathVectorLengthSquared.StaticStruct();
		}

		// Token: 0x06005839 RID: 22585 RVA: 0x0007F34B File Offset: 0x0007D54B
		[NullableContext(2)]
		public FRigUnit_MathVectorLengthSquared(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600583A RID: 22586 RVA: 0x0007F355 File Offset: 0x0007D555
		public FRigUnit_MathVectorLengthSquared(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600583B RID: 22587 RVA: 0x0007F360 File Offset: 0x0007D560
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathVectorLengthSquared(Pointer, false, true);
		}

		// Token: 0x0600583C RID: 22588 RVA: 0x0007F36A File Offset: 0x0007D56A
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathVectorLengthSquared(Pointer, MemoryOwner);
		}

		// Token: 0x0400297D RID: 10621
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathVectorLengthSquared";

		// Token: 0x0400297E RID: 10622
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400297F RID: 10623
		internal static int __PropertyOffset_Value;

		// Token: 0x04002980 RID: 10624
		internal static int __PropertyOffset_Result;
	}
}
