using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200118A RID: 4490
	[UnrealObjectPath("/Script/Engine.StateMachineStateDebugData")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FStateMachineStateDebugData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060107FC RID: 67580 RVA: 0x00183A3B File Offset: 0x00181C3B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FStateMachineStateDebugData._ScriptStructPtr != 0) ? FStateMachineStateDebugData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.StateMachineStateDebugData", ref FStateMachineStateDebugData._ScriptStructPtr);
		}

		// Token: 0x060107FD RID: 67581 RVA: 0x00183A5F File Offset: 0x00181C5F
		public FStateMachineStateDebugData()
		{
		}

		// Token: 0x060107FE RID: 67582 RVA: 0x00183A67 File Offset: 0x00181C67
		protected override IntPtr GetUStructPtr()
		{
			return FStateMachineStateDebugData.StaticStruct();
		}

		// Token: 0x060107FF RID: 67583 RVA: 0x00183A73 File Offset: 0x00181C73
		[NullableContext(2)]
		public FStateMachineStateDebugData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010800 RID: 67584 RVA: 0x00183A7D File Offset: 0x00181C7D
		public FStateMachineStateDebugData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010801 RID: 67585 RVA: 0x00183A88 File Offset: 0x00181C88
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FStateMachineStateDebugData(Pointer, false, true);
		}

		// Token: 0x06010802 RID: 67586 RVA: 0x00183A92 File Offset: 0x00181C92
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FStateMachineStateDebugData(Pointer, MemoryOwner);
		}

		// Token: 0x04008D32 RID: 36146
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.StateMachineStateDebugData";

		// Token: 0x04008D33 RID: 36147
		private static IntPtr _ScriptStructPtr;
	}
}
