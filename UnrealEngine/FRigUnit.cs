using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200052E RID: 1326
	[UnrealObjectPath("/Script/ControlRig.RigUnit")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FRigUnit : FRigVMStruct, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600457F RID: 17791 RVA: 0x000676FA File Offset: 0x000658FA
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit._ScriptStructPtr != 0) ? FRigUnit._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit", ref FRigUnit._ScriptStructPtr);
		}

		// Token: 0x06004580 RID: 17792 RVA: 0x0006771E File Offset: 0x0006591E
		public FRigUnit()
		{
		}

		// Token: 0x06004581 RID: 17793 RVA: 0x00067726 File Offset: 0x00065926
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit.StaticStruct();
		}

		// Token: 0x06004582 RID: 17794 RVA: 0x00067732 File Offset: 0x00065932
		[NullableContext(2)]
		public FRigUnit(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004583 RID: 17795 RVA: 0x0006773C File Offset: 0x0006593C
		public FRigUnit(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004584 RID: 17796 RVA: 0x00067747 File Offset: 0x00065947
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit(Pointer, false, true);
		}

		// Token: 0x06004585 RID: 17797 RVA: 0x00067751 File Offset: 0x00065951
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit(Pointer, MemoryOwner);
		}

		// Token: 0x040021D7 RID: 8663
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit";

		// Token: 0x040021D8 RID: 8664
		private static IntPtr _ScriptStructPtr;
	}
}
