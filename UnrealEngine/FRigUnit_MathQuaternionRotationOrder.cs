using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200063B RID: 1595
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathQuaternionRotationOrder")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigUnit_MathQuaternionRotationOrder : FRigUnit_MathBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005520 RID: 21792 RVA: 0x0007B89F File Offset: 0x00079A9F
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathQuaternionRotationOrder._ScriptStructPtr != 0) ? FRigUnit_MathQuaternionRotationOrder._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathQuaternionRotationOrder", ref FRigUnit_MathQuaternionRotationOrder._ScriptStructPtr);
		}

		// Token: 0x1700147E RID: 5246
		// (get) Token: 0x06005521 RID: 21793 RVA: 0x0007B8C3 File Offset: 0x00079AC3
		// (set) Token: 0x06005522 RID: 21794 RVA: 0x0007B8D3 File Offset: 0x00079AD3
		public unsafe EControlRigRotationOrder RotationOrder
		{
			get
			{
				return (EControlRigRotationOrder)(*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionRotationOrder.__PropertyOffset_RotationOrder));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionRotationOrder.__PropertyOffset_RotationOrder) = (byte)value;
			}
		}

		// Token: 0x06005523 RID: 21795 RVA: 0x0007B8E4 File Offset: 0x00079AE4
		public FRigUnit_MathQuaternionRotationOrder()
		{
		}

		// Token: 0x06005524 RID: 21796 RVA: 0x0007B8EC File Offset: 0x00079AEC
		public FRigUnit_MathQuaternionRotationOrder(EControlRigRotationOrder RotationOrder)
		{
			this.RotationOrder = RotationOrder;
		}

		// Token: 0x06005525 RID: 21797 RVA: 0x0007B8FB File Offset: 0x00079AFB
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathQuaternionRotationOrder.StaticStruct();
		}

		// Token: 0x06005526 RID: 21798 RVA: 0x0007B907 File Offset: 0x00079B07
		[NullableContext(2)]
		public FRigUnit_MathQuaternionRotationOrder(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005527 RID: 21799 RVA: 0x0007B911 File Offset: 0x00079B11
		public FRigUnit_MathQuaternionRotationOrder(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005528 RID: 21800 RVA: 0x0007B91C File Offset: 0x00079B1C
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathQuaternionRotationOrder(Pointer, false, true);
		}

		// Token: 0x06005529 RID: 21801 RVA: 0x0007B926 File Offset: 0x00079B26
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathQuaternionRotationOrder(Pointer, MemoryOwner);
		}

		// Token: 0x0400285C RID: 10332
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathQuaternionRotationOrder";

		// Token: 0x0400285D RID: 10333
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400285E RID: 10334
		internal static int __PropertyOffset_RotationOrder;
	}
}
