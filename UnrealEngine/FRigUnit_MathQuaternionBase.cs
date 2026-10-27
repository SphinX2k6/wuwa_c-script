using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200062E RID: 1582
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathQuaternionBase")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FRigUnit_MathQuaternionBase : FRigUnit_MathBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600547F RID: 21631 RVA: 0x0007ADF4 File Offset: 0x00078FF4
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathQuaternionBase._ScriptStructPtr != 0) ? FRigUnit_MathQuaternionBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathQuaternionBase", ref FRigUnit_MathQuaternionBase._ScriptStructPtr);
		}

		// Token: 0x06005480 RID: 21632 RVA: 0x0007AE18 File Offset: 0x00079018
		public FRigUnit_MathQuaternionBase()
		{
		}

		// Token: 0x06005481 RID: 21633 RVA: 0x0007AE20 File Offset: 0x00079020
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathQuaternionBase.StaticStruct();
		}

		// Token: 0x06005482 RID: 21634 RVA: 0x0007AE2C File Offset: 0x0007902C
		[NullableContext(2)]
		public FRigUnit_MathQuaternionBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005483 RID: 21635 RVA: 0x0007AE36 File Offset: 0x00079036
		public FRigUnit_MathQuaternionBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005484 RID: 21636 RVA: 0x0007AE41 File Offset: 0x00079041
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathQuaternionBase(Pointer, false, true);
		}

		// Token: 0x06005485 RID: 21637 RVA: 0x0007AE4B File Offset: 0x0007904B
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathQuaternionBase(Pointer, MemoryOwner);
		}

		// Token: 0x04002825 RID: 10277
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathQuaternionBase";

		// Token: 0x04002826 RID: 10278
		private static IntPtr _ScriptStructPtr;
	}
}
