using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020006D3 RID: 1747
	[UnrealObjectPath("/Script/ControlRig.RigUnit_SimBase")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FRigUnit_SimBase : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005D97 RID: 23959 RVA: 0x000865CD File Offset: 0x000847CD
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_SimBase._ScriptStructPtr != 0) ? FRigUnit_SimBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_SimBase", ref FRigUnit_SimBase._ScriptStructPtr);
		}

		// Token: 0x06005D98 RID: 23960 RVA: 0x000865F1 File Offset: 0x000847F1
		public FRigUnit_SimBase()
		{
		}

		// Token: 0x06005D99 RID: 23961 RVA: 0x000865F9 File Offset: 0x000847F9
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_SimBase.StaticStruct();
		}

		// Token: 0x06005D9A RID: 23962 RVA: 0x00086605 File Offset: 0x00084805
		[NullableContext(2)]
		public FRigUnit_SimBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005D9B RID: 23963 RVA: 0x0008660F File Offset: 0x0008480F
		public FRigUnit_SimBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005D9C RID: 23964 RVA: 0x0008661A File Offset: 0x0008481A
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_SimBase(Pointer, false, true);
		}

		// Token: 0x06005D9D RID: 23965 RVA: 0x00086624 File Offset: 0x00084824
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_SimBase(Pointer, MemoryOwner);
		}

		// Token: 0x04002BCD RID: 11213
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_SimBase";

		// Token: 0x04002BCE RID: 11214
		private static IntPtr _ScriptStructPtr;
	}
}
