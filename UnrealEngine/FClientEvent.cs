using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020012E2 RID: 4834
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameMatrix.ClientEvent")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FClientEvent : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06011B84 RID: 72580 RVA: 0x001A03AC File Offset: 0x0019E5AC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FClientEvent._ScriptStructPtr != 0) ? FClientEvent._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameMatrix.ClientEvent", ref FClientEvent._ScriptStructPtr);
		}

		// Token: 0x17004565 RID: 17765
		// (get) Token: 0x06011B85 RID: 72581 RVA: 0x001A03D0 File Offset: 0x0019E5D0
		// (set) Token: 0x06011B86 RID: 72582 RVA: 0x001A03E4 File Offset: 0x0019E5E4
		public unsafe string Event
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FClientEvent.__PropertyOffset_Event)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FClientEvent.__PropertyOffset_Event)), value);
			}
		}

		// Token: 0x06011B87 RID: 72583 RVA: 0x001A03F9 File Offset: 0x0019E5F9
		public FClientEvent()
		{
		}

		// Token: 0x06011B88 RID: 72584 RVA: 0x001A0401 File Offset: 0x0019E601
		public FClientEvent(string Event)
		{
			this.Event = Event;
		}

		// Token: 0x06011B89 RID: 72585 RVA: 0x001A0410 File Offset: 0x0019E610
		protected override IntPtr GetUStructPtr()
		{
			return FClientEvent.StaticStruct();
		}

		// Token: 0x06011B8A RID: 72586 RVA: 0x001A041C File Offset: 0x0019E61C
		[NullableContext(2)]
		public FClientEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06011B8B RID: 72587 RVA: 0x001A0426 File Offset: 0x0019E626
		public FClientEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06011B8C RID: 72588 RVA: 0x001A0431 File Offset: 0x0019E631
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FClientEvent(Pointer, false, true);
		}

		// Token: 0x06011B8D RID: 72589 RVA: 0x001A043B File Offset: 0x0019E63B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FClientEvent(Pointer, MemoryOwner);
		}

		// Token: 0x0400982D RID: 38957
		public const string __ObjectPath = "/Script/GameMatrix.ClientEvent";

		// Token: 0x0400982E RID: 38958
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400982F RID: 38959
		internal static int __PropertyOffset_Event;
	}
}
