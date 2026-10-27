using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005DB RID: 1499
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathBoolConstant")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigUnit_MathBoolConstant : FRigUnit_MathBoolBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060050F8 RID: 20728 RVA: 0x0007763F File Offset: 0x0007583F
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathBoolConstant._ScriptStructPtr != 0) ? FRigUnit_MathBoolConstant._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathBoolConstant", ref FRigUnit_MathBoolConstant._ScriptStructPtr);
		}

		// Token: 0x170013E8 RID: 5096
		// (get) Token: 0x060050F9 RID: 20729 RVA: 0x00077663 File Offset: 0x00075863
		// (set) Token: 0x060050FA RID: 20730 RVA: 0x00077673 File Offset: 0x00075873
		public unsafe bool Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathBoolConstant.__PropertyOffset_Value) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathBoolConstant.__PropertyOffset_Value) = (value ? 1 : 0);
			}
		}

		// Token: 0x060050FB RID: 20731 RVA: 0x00077684 File Offset: 0x00075884
		public FRigUnit_MathBoolConstant()
		{
		}

		// Token: 0x060050FC RID: 20732 RVA: 0x0007768C File Offset: 0x0007588C
		public FRigUnit_MathBoolConstant(bool Value)
		{
			this.Value = Value;
		}

		// Token: 0x060050FD RID: 20733 RVA: 0x0007769B File Offset: 0x0007589B
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathBoolConstant.StaticStruct();
		}

		// Token: 0x060050FE RID: 20734 RVA: 0x000776A7 File Offset: 0x000758A7
		[NullableContext(2)]
		public FRigUnit_MathBoolConstant(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060050FF RID: 20735 RVA: 0x000776B1 File Offset: 0x000758B1
		public FRigUnit_MathBoolConstant(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005100 RID: 20736 RVA: 0x000776BC File Offset: 0x000758BC
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathBoolConstant(Pointer, false, true);
		}

		// Token: 0x06005101 RID: 20737 RVA: 0x000776C6 File Offset: 0x000758C6
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathBoolConstant(Pointer, MemoryOwner);
		}

		// Token: 0x04002706 RID: 9990
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathBoolConstant";

		// Token: 0x04002707 RID: 9991
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002708 RID: 9992
		internal static int __PropertyOffset_Value;
	}
}
