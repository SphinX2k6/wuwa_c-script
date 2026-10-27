using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005CE RID: 1486
	[UnrealObjectPath("/Script/ControlRig.RigUnit_ItemBase")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FRigUnit_ItemBase : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600503F RID: 20543 RVA: 0x000767C7 File Offset: 0x000749C7
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_ItemBase._ScriptStructPtr != 0) ? FRigUnit_ItemBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_ItemBase", ref FRigUnit_ItemBase._ScriptStructPtr);
		}

		// Token: 0x06005040 RID: 20544 RVA: 0x000767EB File Offset: 0x000749EB
		public FRigUnit_ItemBase()
		{
		}

		// Token: 0x06005041 RID: 20545 RVA: 0x000767F3 File Offset: 0x000749F3
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_ItemBase.StaticStruct();
		}

		// Token: 0x06005042 RID: 20546 RVA: 0x000767FF File Offset: 0x000749FF
		[NullableContext(2)]
		public FRigUnit_ItemBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005043 RID: 20547 RVA: 0x00076809 File Offset: 0x00074A09
		public FRigUnit_ItemBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005044 RID: 20548 RVA: 0x00076814 File Offset: 0x00074A14
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_ItemBase(Pointer, false, true);
		}

		// Token: 0x06005045 RID: 20549 RVA: 0x0007681E File Offset: 0x00074A1E
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_ItemBase(Pointer, MemoryOwner);
		}

		// Token: 0x040026B9 RID: 9913
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_ItemBase";

		// Token: 0x040026BA RID: 9914
		private static IntPtr _ScriptStructPtr;
	}
}
