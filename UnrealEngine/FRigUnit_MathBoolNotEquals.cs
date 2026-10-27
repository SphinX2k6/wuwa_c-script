using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005E1 RID: 1505
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathBoolNotEquals")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigUnit_MathBoolNotEquals : FRigUnit_MathBoolBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005130 RID: 20784 RVA: 0x00077980 File Offset: 0x00075B80
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathBoolNotEquals._ScriptStructPtr != 0) ? FRigUnit_MathBoolNotEquals._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathBoolNotEquals", ref FRigUnit_MathBoolNotEquals._ScriptStructPtr);
		}

		// Token: 0x170013EC RID: 5100
		// (get) Token: 0x06005131 RID: 20785 RVA: 0x000779A4 File Offset: 0x00075BA4
		// (set) Token: 0x06005132 RID: 20786 RVA: 0x000779B4 File Offset: 0x00075BB4
		public unsafe bool A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathBoolNotEquals.__PropertyOffset_A) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathBoolNotEquals.__PropertyOffset_A) = (value ? 1 : 0);
			}
		}

		// Token: 0x170013ED RID: 5101
		// (get) Token: 0x06005133 RID: 20787 RVA: 0x000779C5 File Offset: 0x00075BC5
		// (set) Token: 0x06005134 RID: 20788 RVA: 0x000779D5 File Offset: 0x00075BD5
		public unsafe bool B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathBoolNotEquals.__PropertyOffset_B) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathBoolNotEquals.__PropertyOffset_B) = (value ? 1 : 0);
			}
		}

		// Token: 0x170013EE RID: 5102
		// (get) Token: 0x06005135 RID: 20789 RVA: 0x000779E6 File Offset: 0x00075BE6
		// (set) Token: 0x06005136 RID: 20790 RVA: 0x000779F6 File Offset: 0x00075BF6
		public unsafe bool Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathBoolNotEquals.__PropertyOffset_Result) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathBoolNotEquals.__PropertyOffset_Result) = (value ? 1 : 0);
			}
		}

		// Token: 0x06005137 RID: 20791 RVA: 0x00077A07 File Offset: 0x00075C07
		public FRigUnit_MathBoolNotEquals()
		{
		}

		// Token: 0x06005138 RID: 20792 RVA: 0x00077A0F File Offset: 0x00075C0F
		public FRigUnit_MathBoolNotEquals(bool A, bool B, bool Result)
		{
			this.A = A;
			this.B = B;
			this.Result = Result;
		}

		// Token: 0x06005139 RID: 20793 RVA: 0x00077A2C File Offset: 0x00075C2C
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathBoolNotEquals.StaticStruct();
		}

		// Token: 0x0600513A RID: 20794 RVA: 0x00077A38 File Offset: 0x00075C38
		[NullableContext(2)]
		public FRigUnit_MathBoolNotEquals(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600513B RID: 20795 RVA: 0x00077A42 File Offset: 0x00075C42
		public FRigUnit_MathBoolNotEquals(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600513C RID: 20796 RVA: 0x00077A4D File Offset: 0x00075C4D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathBoolNotEquals(Pointer, false, true);
		}

		// Token: 0x0600513D RID: 20797 RVA: 0x00077A57 File Offset: 0x00075C57
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathBoolNotEquals(Pointer, MemoryOwner);
		}

		// Token: 0x04002716 RID: 10006
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathBoolNotEquals";

		// Token: 0x04002717 RID: 10007
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002718 RID: 10008
		internal static int __PropertyOffset_A;

		// Token: 0x04002719 RID: 10009
		internal static int __PropertyOffset_B;

		// Token: 0x0400271A RID: 10010
		internal static int __PropertyOffset_Result;
	}
}
