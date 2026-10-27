using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005F4 RID: 1524
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathFloatConstant")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigUnit_MathFloatConstant : FRigUnit_MathFloatBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060051F6 RID: 20982 RVA: 0x000785C3 File Offset: 0x000767C3
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathFloatConstant._ScriptStructPtr != 0) ? FRigUnit_MathFloatConstant._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathFloatConstant", ref FRigUnit_MathFloatConstant._ScriptStructPtr);
		}

		// Token: 0x17001404 RID: 5124
		// (get) Token: 0x060051F7 RID: 20983 RVA: 0x000785E7 File Offset: 0x000767E7
		// (set) Token: 0x060051F8 RID: 20984 RVA: 0x000785F7 File Offset: 0x000767F7
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatConstant.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatConstant.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x060051F9 RID: 20985 RVA: 0x00078608 File Offset: 0x00076808
		public FRigUnit_MathFloatConstant()
		{
		}

		// Token: 0x060051FA RID: 20986 RVA: 0x00078610 File Offset: 0x00076810
		public FRigUnit_MathFloatConstant(float Value)
		{
			this.Value = Value;
		}

		// Token: 0x060051FB RID: 20987 RVA: 0x0007861F File Offset: 0x0007681F
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathFloatConstant.StaticStruct();
		}

		// Token: 0x060051FC RID: 20988 RVA: 0x0007862B File Offset: 0x0007682B
		[NullableContext(2)]
		public FRigUnit_MathFloatConstant(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060051FD RID: 20989 RVA: 0x00078635 File Offset: 0x00076835
		public FRigUnit_MathFloatConstant(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060051FE RID: 20990 RVA: 0x00078640 File Offset: 0x00076840
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathFloatConstant(Pointer, false, true);
		}

		// Token: 0x060051FF RID: 20991 RVA: 0x0007864A File Offset: 0x0007684A
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathFloatConstant(Pointer, MemoryOwner);
		}

		// Token: 0x04002754 RID: 10068
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathFloatConstant";

		// Token: 0x04002755 RID: 10069
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002756 RID: 10070
		internal static int __PropertyOffset_Value;
	}
}
