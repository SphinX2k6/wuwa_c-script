using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005C8 RID: 1480
	[UnrealObjectPath("/Script/ControlRig.RigUnit_HighlevelBase")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FRigUnit_HighlevelBase : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600500A RID: 20490 RVA: 0x00076449 File Offset: 0x00074649
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_HighlevelBase._ScriptStructPtr != 0) ? FRigUnit_HighlevelBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_HighlevelBase", ref FRigUnit_HighlevelBase._ScriptStructPtr);
		}

		// Token: 0x0600500B RID: 20491 RVA: 0x0007646D File Offset: 0x0007466D
		public FRigUnit_HighlevelBase()
		{
		}

		// Token: 0x0600500C RID: 20492 RVA: 0x00076475 File Offset: 0x00074675
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_HighlevelBase.StaticStruct();
		}

		// Token: 0x0600500D RID: 20493 RVA: 0x00076481 File Offset: 0x00074681
		[NullableContext(2)]
		public FRigUnit_HighlevelBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600500E RID: 20494 RVA: 0x0007648B File Offset: 0x0007468B
		public FRigUnit_HighlevelBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600500F RID: 20495 RVA: 0x00076496 File Offset: 0x00074696
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_HighlevelBase(Pointer, false, true);
		}

		// Token: 0x06005010 RID: 20496 RVA: 0x000764A0 File Offset: 0x000746A0
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_HighlevelBase(Pointer, MemoryOwner);
		}

		// Token: 0x040026A8 RID: 9896
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_HighlevelBase";

		// Token: 0x040026A9 RID: 9897
		private static IntPtr _ScriptStructPtr;
	}
}
