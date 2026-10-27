using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020007B8 RID: 1976
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/Engine.ActorContainerID")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FActorContainerID : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060069B8 RID: 27064 RVA: 0x00097D46 File Offset: 0x00095F46
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FActorContainerID._ScriptStructPtr != 0) ? FActorContainerID._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ActorContainerID", ref FActorContainerID._ScriptStructPtr);
		}

		// Token: 0x17001902 RID: 6402
		// (get) Token: 0x060069B9 RID: 27065 RVA: 0x00097D6A File Offset: 0x00095F6A
		// (set) Token: 0x060069BA RID: 27066 RVA: 0x00097D7E File Offset: 0x00095F7E
		public unsafe FGuid Guid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FActorContainerID.__PropertyOffset_Guid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FActorContainerID.__PropertyOffset_Guid) = value;
			}
		}

		// Token: 0x060069BB RID: 27067 RVA: 0x00097D93 File Offset: 0x00095F93
		public FActorContainerID()
		{
		}

		// Token: 0x060069BC RID: 27068 RVA: 0x00097D9B File Offset: 0x00095F9B
		public FActorContainerID(FGuid Guid)
		{
			this.Guid = Guid;
		}

		// Token: 0x060069BD RID: 27069 RVA: 0x00097DAA File Offset: 0x00095FAA
		protected override IntPtr GetUStructPtr()
		{
			return FActorContainerID.StaticStruct();
		}

		// Token: 0x060069BE RID: 27070 RVA: 0x00097DB6 File Offset: 0x00095FB6
		[NullableContext(2)]
		public FActorContainerID(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060069BF RID: 27071 RVA: 0x00097DC0 File Offset: 0x00095FC0
		public FActorContainerID(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060069C0 RID: 27072 RVA: 0x00097DCB File Offset: 0x00095FCB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FActorContainerID(Pointer, false, true);
		}

		// Token: 0x060069C1 RID: 27073 RVA: 0x00097DD5 File Offset: 0x00095FD5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FActorContainerID(Pointer, MemoryOwner);
		}

		// Token: 0x040032F9 RID: 13049
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ActorContainerID";

		// Token: 0x040032FA RID: 13050
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040032FB RID: 13051
		internal static int __PropertyOffset_Guid;
	}
}
