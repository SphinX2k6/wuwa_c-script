using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005D7 RID: 1495
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathBase")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FRigUnit_MathBase : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060050D4 RID: 20692 RVA: 0x00077422 File Offset: 0x00075622
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathBase._ScriptStructPtr != 0) ? FRigUnit_MathBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathBase", ref FRigUnit_MathBase._ScriptStructPtr);
		}

		// Token: 0x060050D5 RID: 20693 RVA: 0x00077446 File Offset: 0x00075646
		public FRigUnit_MathBase()
		{
		}

		// Token: 0x060050D6 RID: 20694 RVA: 0x0007744E File Offset: 0x0007564E
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathBase.StaticStruct();
		}

		// Token: 0x060050D7 RID: 20695 RVA: 0x0007745A File Offset: 0x0007565A
		[NullableContext(2)]
		public FRigUnit_MathBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060050D8 RID: 20696 RVA: 0x00077464 File Offset: 0x00075664
		public FRigUnit_MathBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060050D9 RID: 20697 RVA: 0x0007746F File Offset: 0x0007566F
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathBase(Pointer, false, true);
		}

		// Token: 0x060050DA RID: 20698 RVA: 0x00077479 File Offset: 0x00075679
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathBase(Pointer, MemoryOwner);
		}

		// Token: 0x040026FB RID: 9979
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathBase";

		// Token: 0x040026FC RID: 9980
		private static IntPtr _ScriptStructPtr;
	}
}
