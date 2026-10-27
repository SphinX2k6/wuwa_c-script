using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002882 RID: 10370
	[UnrealObjectPath("/Script/SMSystem.SMDebugStateMachine")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FSMDebugStateMachine : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602661E RID: 157214 RVA: 0x003A56BD File Offset: 0x003A38BD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSMDebugStateMachine._ScriptStructPtr != 0) ? FSMDebugStateMachine._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SMSystem.SMDebugStateMachine", ref FSMDebugStateMachine._ScriptStructPtr);
		}

		// Token: 0x0602661F RID: 157215 RVA: 0x003A56E1 File Offset: 0x003A38E1
		public FSMDebugStateMachine()
		{
		}

		// Token: 0x06026620 RID: 157216 RVA: 0x003A56E9 File Offset: 0x003A38E9
		protected override IntPtr GetUStructPtr()
		{
			return FSMDebugStateMachine.StaticStruct();
		}

		// Token: 0x06026621 RID: 157217 RVA: 0x003A56F5 File Offset: 0x003A38F5
		[NullableContext(2)]
		public FSMDebugStateMachine(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026622 RID: 157218 RVA: 0x003A56FF File Offset: 0x003A38FF
		public FSMDebugStateMachine(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026623 RID: 157219 RVA: 0x003A570A File Offset: 0x003A390A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSMDebugStateMachine(Pointer, false, true);
		}

		// Token: 0x06026624 RID: 157220 RVA: 0x003A5714 File Offset: 0x003A3914
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSMDebugStateMachine(Pointer, MemoryOwner);
		}

		// Token: 0x040150D3 RID: 86227
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SMSystem.SMDebugStateMachine";

		// Token: 0x040150D4 RID: 86228
		private static IntPtr _ScriptStructPtr;
	}
}
