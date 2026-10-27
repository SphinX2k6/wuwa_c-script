using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005DE RID: 1502
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathBoolEquals")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigUnit_MathBoolEquals : FRigUnit_MathBoolBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005112 RID: 20754 RVA: 0x000777AD File Offset: 0x000759AD
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathBoolEquals._ScriptStructPtr != 0) ? FRigUnit_MathBoolEquals._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathBoolEquals", ref FRigUnit_MathBoolEquals._ScriptStructPtr);
		}

		// Token: 0x170013E9 RID: 5097
		// (get) Token: 0x06005113 RID: 20755 RVA: 0x000777D1 File Offset: 0x000759D1
		// (set) Token: 0x06005114 RID: 20756 RVA: 0x000777E1 File Offset: 0x000759E1
		public unsafe bool A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathBoolEquals.__PropertyOffset_A) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathBoolEquals.__PropertyOffset_A) = (value ? 1 : 0);
			}
		}

		// Token: 0x170013EA RID: 5098
		// (get) Token: 0x06005115 RID: 20757 RVA: 0x000777F2 File Offset: 0x000759F2
		// (set) Token: 0x06005116 RID: 20758 RVA: 0x00077802 File Offset: 0x00075A02
		public unsafe bool B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathBoolEquals.__PropertyOffset_B) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathBoolEquals.__PropertyOffset_B) = (value ? 1 : 0);
			}
		}

		// Token: 0x170013EB RID: 5099
		// (get) Token: 0x06005117 RID: 20759 RVA: 0x00077813 File Offset: 0x00075A13
		// (set) Token: 0x06005118 RID: 20760 RVA: 0x00077823 File Offset: 0x00075A23
		public unsafe bool Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathBoolEquals.__PropertyOffset_Result) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathBoolEquals.__PropertyOffset_Result) = (value ? 1 : 0);
			}
		}

		// Token: 0x06005119 RID: 20761 RVA: 0x00077834 File Offset: 0x00075A34
		public FRigUnit_MathBoolEquals()
		{
		}

		// Token: 0x0600511A RID: 20762 RVA: 0x0007783C File Offset: 0x00075A3C
		public FRigUnit_MathBoolEquals(bool A, bool B, bool Result)
		{
			this.A = A;
			this.B = B;
			this.Result = Result;
		}

		// Token: 0x0600511B RID: 20763 RVA: 0x00077859 File Offset: 0x00075A59
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathBoolEquals.StaticStruct();
		}

		// Token: 0x0600511C RID: 20764 RVA: 0x00077865 File Offset: 0x00075A65
		[NullableContext(2)]
		public FRigUnit_MathBoolEquals(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600511D RID: 20765 RVA: 0x0007786F File Offset: 0x00075A6F
		public FRigUnit_MathBoolEquals(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600511E RID: 20766 RVA: 0x0007787A File Offset: 0x00075A7A
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathBoolEquals(Pointer, false, true);
		}

		// Token: 0x0600511F RID: 20767 RVA: 0x00077884 File Offset: 0x00075A84
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathBoolEquals(Pointer, MemoryOwner);
		}

		// Token: 0x0400270D RID: 9997
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathBoolEquals";

		// Token: 0x0400270E RID: 9998
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400270F RID: 9999
		internal static int __PropertyOffset_A;

		// Token: 0x04002710 RID: 10000
		internal static int __PropertyOffset_B;

		// Token: 0x04002711 RID: 10001
		internal static int __PropertyOffset_Result;
	}
}
