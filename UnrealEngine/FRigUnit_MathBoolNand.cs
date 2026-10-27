using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005DF RID: 1503
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathBoolNand")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigUnit_MathBoolNand : FRigUnit_MathBoolBinaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005120 RID: 20768 RVA: 0x0007788D File Offset: 0x00075A8D
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathBoolNand._ScriptStructPtr != 0) ? FRigUnit_MathBoolNand._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathBoolNand", ref FRigUnit_MathBoolNand._ScriptStructPtr);
		}

		// Token: 0x06005121 RID: 20769 RVA: 0x000778B1 File Offset: 0x00075AB1
		public FRigUnit_MathBoolNand()
		{
		}

		// Token: 0x06005122 RID: 20770 RVA: 0x000778B9 File Offset: 0x00075AB9
		public FRigUnit_MathBoolNand(bool A, bool B, bool Result)
		{
			base.A = A;
			base.B = B;
			base.Result = Result;
		}

		// Token: 0x06005123 RID: 20771 RVA: 0x000778D6 File Offset: 0x00075AD6
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathBoolNand.StaticStruct();
		}

		// Token: 0x06005124 RID: 20772 RVA: 0x000778E2 File Offset: 0x00075AE2
		[NullableContext(2)]
		public FRigUnit_MathBoolNand(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005125 RID: 20773 RVA: 0x000778EC File Offset: 0x00075AEC
		public FRigUnit_MathBoolNand(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005126 RID: 20774 RVA: 0x000778F7 File Offset: 0x00075AF7
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathBoolNand(Pointer, false, true);
		}

		// Token: 0x06005127 RID: 20775 RVA: 0x00077901 File Offset: 0x00075B01
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathBoolNand(Pointer, MemoryOwner);
		}

		// Token: 0x04002712 RID: 10002
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathBoolNand";

		// Token: 0x04002713 RID: 10003
		private static IntPtr _ScriptStructPtr;
	}
}
