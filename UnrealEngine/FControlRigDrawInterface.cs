using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020004C4 RID: 1220
	[UnrealObjectPath("/Script/ControlRig.ControlRigDrawInterface")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FControlRigDrawInterface : FControlRigDrawContainer, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004193 RID: 16787 RVA: 0x00062381 File Offset: 0x00060581
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FControlRigDrawInterface._ScriptStructPtr != 0) ? FControlRigDrawInterface._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.ControlRigDrawInterface", ref FControlRigDrawInterface._ScriptStructPtr);
		}

		// Token: 0x06004194 RID: 16788 RVA: 0x000623A5 File Offset: 0x000605A5
		public FControlRigDrawInterface()
		{
		}

		// Token: 0x06004195 RID: 16789 RVA: 0x000623AD File Offset: 0x000605AD
		[NullableContext(1)]
		public FControlRigDrawInterface(TArray<FControlRigDrawInstruction> Instructions)
		{
			base.Instructions = Instructions;
		}

		// Token: 0x06004196 RID: 16790 RVA: 0x000623BC File Offset: 0x000605BC
		protected override IntPtr GetUStructPtr()
		{
			return FControlRigDrawInterface.StaticStruct();
		}

		// Token: 0x06004197 RID: 16791 RVA: 0x000623C8 File Offset: 0x000605C8
		[NullableContext(2)]
		public FControlRigDrawInterface(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004198 RID: 16792 RVA: 0x000623D2 File Offset: 0x000605D2
		public FControlRigDrawInterface(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004199 RID: 16793 RVA: 0x000623DD File Offset: 0x000605DD
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FControlRigDrawInterface(Pointer, false, true);
		}

		// Token: 0x0600419A RID: 16794 RVA: 0x000623E7 File Offset: 0x000605E7
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FControlRigDrawInterface(Pointer, MemoryOwner);
		}

		// Token: 0x04001F34 RID: 7988
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.ControlRigDrawInterface";

		// Token: 0x04001F35 RID: 7989
		private static IntPtr _ScriptStructPtr;
	}
}
