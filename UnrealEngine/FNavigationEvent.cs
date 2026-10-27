using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002823 RID: 10275
	[UnrealObjectPath("/Script/SlateCore.NavigationEvent")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FNavigationEvent : FInputEvent, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060262E9 RID: 156393 RVA: 0x0039F0C4 File Offset: 0x0039D2C4
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNavigationEvent._ScriptStructPtr != 0) ? FNavigationEvent._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SlateCore.NavigationEvent", ref FNavigationEvent._ScriptStructPtr);
		}

		// Token: 0x060262EA RID: 156394 RVA: 0x0039F0E8 File Offset: 0x0039D2E8
		public FNavigationEvent()
		{
		}

		// Token: 0x060262EB RID: 156395 RVA: 0x0039F0F0 File Offset: 0x0039D2F0
		protected override IntPtr GetUStructPtr()
		{
			return FNavigationEvent.StaticStruct();
		}

		// Token: 0x060262EC RID: 156396 RVA: 0x0039F0FC File Offset: 0x0039D2FC
		[NullableContext(2)]
		public FNavigationEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060262ED RID: 156397 RVA: 0x0039F106 File Offset: 0x0039D306
		public FNavigationEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060262EE RID: 156398 RVA: 0x0039F111 File Offset: 0x0039D311
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNavigationEvent(Pointer, false, true);
		}

		// Token: 0x060262EF RID: 156399 RVA: 0x0039F11B File Offset: 0x0039D31B
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNavigationEvent(Pointer, MemoryOwner);
		}

		// Token: 0x04014E5E RID: 85598
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SlateCore.NavigationEvent";

		// Token: 0x04014E5F RID: 85599
		private static IntPtr _ScriptStructPtr;
	}
}
