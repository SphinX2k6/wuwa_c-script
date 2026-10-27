using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000642 RID: 1602
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathQuaternionToRotator")]
	[UnrealStructLayout(48, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRigUnit_MathQuaternionToRotator : FRigUnit_MathQuaternionBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005582 RID: 21890 RVA: 0x0007BF3A File Offset: 0x0007A13A
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathQuaternionToRotator._ScriptStructPtr != 0) ? FRigUnit_MathQuaternionToRotator._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathQuaternionToRotator", ref FRigUnit_MathQuaternionToRotator._ScriptStructPtr);
		}

		// Token: 0x17001493 RID: 5267
		// (get) Token: 0x06005583 RID: 21891 RVA: 0x0007BF5E File Offset: 0x0007A15E
		// (set) Token: 0x06005584 RID: 21892 RVA: 0x0007BF72 File Offset: 0x0007A172
		public unsafe FQuat Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionToRotator.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionToRotator.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x17001494 RID: 5268
		// (get) Token: 0x06005585 RID: 21893 RVA: 0x0007BF87 File Offset: 0x0007A187
		// (set) Token: 0x06005586 RID: 21894 RVA: 0x0007BF9B File Offset: 0x0007A19B
		public unsafe FRotator Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionToRotator.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionToRotator.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x06005587 RID: 21895 RVA: 0x0007BFB0 File Offset: 0x0007A1B0
		public FRigUnit_MathQuaternionToRotator()
		{
		}

		// Token: 0x06005588 RID: 21896 RVA: 0x0007BFB8 File Offset: 0x0007A1B8
		public FRigUnit_MathQuaternionToRotator(FQuat Value, FRotator Result)
		{
			this.Value = Value;
			this.Result = Result;
		}

		// Token: 0x06005589 RID: 21897 RVA: 0x0007BFCE File Offset: 0x0007A1CE
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathQuaternionToRotator.StaticStruct();
		}

		// Token: 0x0600558A RID: 21898 RVA: 0x0007BFDA File Offset: 0x0007A1DA
		[NullableContext(2)]
		public FRigUnit_MathQuaternionToRotator(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600558B RID: 21899 RVA: 0x0007BFE4 File Offset: 0x0007A1E4
		public FRigUnit_MathQuaternionToRotator(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600558C RID: 21900 RVA: 0x0007BFEF File Offset: 0x0007A1EF
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathQuaternionToRotator(Pointer, false, true);
		}

		// Token: 0x0600558D RID: 21901 RVA: 0x0007BFF9 File Offset: 0x0007A1F9
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathQuaternionToRotator(Pointer, MemoryOwner);
		}

		// Token: 0x0400287F RID: 10367
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathQuaternionToRotator";

		// Token: 0x04002880 RID: 10368
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002881 RID: 10369
		internal static int __PropertyOffset_Value;

		// Token: 0x04002882 RID: 10370
		internal static int __PropertyOffset_Result;
	}
}
