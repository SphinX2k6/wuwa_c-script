using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005E5 RID: 1509
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathColorBase")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FRigUnit_MathColorBase : FRigUnit_MathBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600515A RID: 20826 RVA: 0x00077C12 File Offset: 0x00075E12
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathColorBase._ScriptStructPtr != 0) ? FRigUnit_MathColorBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathColorBase", ref FRigUnit_MathColorBase._ScriptStructPtr);
		}

		// Token: 0x0600515B RID: 20827 RVA: 0x00077C36 File Offset: 0x00075E36
		public FRigUnit_MathColorBase()
		{
		}

		// Token: 0x0600515C RID: 20828 RVA: 0x00077C3E File Offset: 0x00075E3E
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathColorBase.StaticStruct();
		}

		// Token: 0x0600515D RID: 20829 RVA: 0x00077C4A File Offset: 0x00075E4A
		[NullableContext(2)]
		public FRigUnit_MathColorBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600515E RID: 20830 RVA: 0x00077C54 File Offset: 0x00075E54
		public FRigUnit_MathColorBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600515F RID: 20831 RVA: 0x00077C5F File Offset: 0x00075E5F
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathColorBase(Pointer, false, true);
		}

		// Token: 0x06005160 RID: 20832 RVA: 0x00077C69 File Offset: 0x00075E69
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathColorBase(Pointer, MemoryOwner);
		}

		// Token: 0x04002723 RID: 10019
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathColorBase";

		// Token: 0x04002724 RID: 10020
		private static IntPtr _ScriptStructPtr;
	}
}
