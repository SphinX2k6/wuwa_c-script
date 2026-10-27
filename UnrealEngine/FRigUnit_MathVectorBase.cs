using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000666 RID: 1638
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathVectorBase")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FRigUnit_MathVectorBase : FRigUnit_MathBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005748 RID: 22344 RVA: 0x0007E2D1 File Offset: 0x0007C4D1
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathVectorBase._ScriptStructPtr != 0) ? FRigUnit_MathVectorBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathVectorBase", ref FRigUnit_MathVectorBase._ScriptStructPtr);
		}

		// Token: 0x06005749 RID: 22345 RVA: 0x0007E2F5 File Offset: 0x0007C4F5
		public FRigUnit_MathVectorBase()
		{
		}

		// Token: 0x0600574A RID: 22346 RVA: 0x0007E2FD File Offset: 0x0007C4FD
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathVectorBase.StaticStruct();
		}

		// Token: 0x0600574B RID: 22347 RVA: 0x0007E309 File Offset: 0x0007C509
		[NullableContext(2)]
		public FRigUnit_MathVectorBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600574C RID: 22348 RVA: 0x0007E313 File Offset: 0x0007C513
		public FRigUnit_MathVectorBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600574D RID: 22349 RVA: 0x0007E31E File Offset: 0x0007C51E
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathVectorBase(Pointer, false, true);
		}

		// Token: 0x0600574E RID: 22350 RVA: 0x0007E328 File Offset: 0x0007C528
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathVectorBase(Pointer, MemoryOwner);
		}

		// Token: 0x0400292B RID: 10539
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathVectorBase";

		// Token: 0x0400292C RID: 10540
		private static IntPtr _ScriptStructPtr;
	}
}
