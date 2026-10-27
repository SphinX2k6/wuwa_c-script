using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020006F8 RID: 1784
	[UnrealObjectPath("/Script/ControlRig.RigUnit_UnaryQuaternionOp")]
	[UnrealStructLayout(48, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRigUnit_UnaryQuaternionOp : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006074 RID: 24692 RVA: 0x0008A658 File Offset: 0x00088858
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_UnaryQuaternionOp._ScriptStructPtr != 0) ? FRigUnit_UnaryQuaternionOp._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_UnaryQuaternionOp", ref FRigUnit_UnaryQuaternionOp._ScriptStructPtr);
		}

		// Token: 0x17001738 RID: 5944
		// (get) Token: 0x06006075 RID: 24693 RVA: 0x0008A67C File Offset: 0x0008887C
		// (set) Token: 0x06006076 RID: 24694 RVA: 0x0008A690 File Offset: 0x00088890
		public unsafe FQuat Argument
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_UnaryQuaternionOp.__PropertyOffset_Argument);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_UnaryQuaternionOp.__PropertyOffset_Argument) = value;
			}
		}

		// Token: 0x17001739 RID: 5945
		// (get) Token: 0x06006077 RID: 24695 RVA: 0x0008A6A5 File Offset: 0x000888A5
		// (set) Token: 0x06006078 RID: 24696 RVA: 0x0008A6B9 File Offset: 0x000888B9
		public unsafe FQuat Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_UnaryQuaternionOp.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_UnaryQuaternionOp.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x06006079 RID: 24697 RVA: 0x0008A6CE File Offset: 0x000888CE
		public FRigUnit_UnaryQuaternionOp()
		{
		}

		// Token: 0x0600607A RID: 24698 RVA: 0x0008A6D6 File Offset: 0x000888D6
		public FRigUnit_UnaryQuaternionOp(FQuat Argument, FQuat Result)
		{
			this.Argument = Argument;
			this.Result = Result;
		}

		// Token: 0x0600607B RID: 24699 RVA: 0x0008A6EC File Offset: 0x000888EC
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_UnaryQuaternionOp.StaticStruct();
		}

		// Token: 0x0600607C RID: 24700 RVA: 0x0008A6F8 File Offset: 0x000888F8
		[NullableContext(2)]
		public FRigUnit_UnaryQuaternionOp(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600607D RID: 24701 RVA: 0x0008A702 File Offset: 0x00088902
		public FRigUnit_UnaryQuaternionOp(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600607E RID: 24702 RVA: 0x0008A70D File Offset: 0x0008890D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_UnaryQuaternionOp(Pointer, false, true);
		}

		// Token: 0x0600607F RID: 24703 RVA: 0x0008A717 File Offset: 0x00088917
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_UnaryQuaternionOp(Pointer, MemoryOwner);
		}

		// Token: 0x04002D21 RID: 11553
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_UnaryQuaternionOp";

		// Token: 0x04002D22 RID: 11554
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002D23 RID: 11555
		internal static int __PropertyOffset_Argument;

		// Token: 0x04002D24 RID: 11556
		internal static int __PropertyOffset_Result;
	}
}
