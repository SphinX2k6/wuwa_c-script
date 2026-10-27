using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001189 RID: 4489
	[UnrealObjectPath("/Script/Engine.StateMachineDebugData")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 176)]
	public class FStateMachineDebugData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060107F5 RID: 67573 RVA: 0x001839DB File Offset: 0x00181BDB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FStateMachineDebugData._ScriptStructPtr != 0) ? FStateMachineDebugData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.StateMachineDebugData", ref FStateMachineDebugData._ScriptStructPtr);
		}

		// Token: 0x060107F6 RID: 67574 RVA: 0x001839FF File Offset: 0x00181BFF
		public FStateMachineDebugData()
		{
		}

		// Token: 0x060107F7 RID: 67575 RVA: 0x00183A07 File Offset: 0x00181C07
		protected override IntPtr GetUStructPtr()
		{
			return FStateMachineDebugData.StaticStruct();
		}

		// Token: 0x060107F8 RID: 67576 RVA: 0x00183A13 File Offset: 0x00181C13
		[NullableContext(2)]
		public FStateMachineDebugData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060107F9 RID: 67577 RVA: 0x00183A1D File Offset: 0x00181C1D
		public FStateMachineDebugData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060107FA RID: 67578 RVA: 0x00183A28 File Offset: 0x00181C28
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FStateMachineDebugData(Pointer, false, true);
		}

		// Token: 0x060107FB RID: 67579 RVA: 0x00183A32 File Offset: 0x00181C32
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FStateMachineDebugData(Pointer, MemoryOwner);
		}

		// Token: 0x04008D30 RID: 36144
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.StateMachineDebugData";

		// Token: 0x04008D31 RID: 36145
		private static IntPtr _ScriptStructPtr;
	}
}
