using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001D5 RID: 469
	[UnrealObjectPath("/Script/AIModule.PawnActionEvent")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FPawnActionEvent : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06001BB2 RID: 7090 RVA: 0x000294ED File Offset: 0x000276ED
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPawnActionEvent._ScriptStructPtr != 0) ? FPawnActionEvent._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AIModule.PawnActionEvent", ref FPawnActionEvent._ScriptStructPtr);
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x06001BB3 RID: 7091 RVA: 0x00029511 File Offset: 0x00027711
		// (set) Token: 0x06001BB4 RID: 7092 RVA: 0x00029525 File Offset: 0x00027725
		[Nullable(2)]
		public unsafe UPawnAction Action
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPawnAction>(base.NativePtr / (IntPtr)sizeof(void*) + FPawnActionEvent.__PropertyOffset_Action);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FPawnActionEvent.__PropertyOffset_Action, value);
			}
		}

		// Token: 0x06001BB5 RID: 7093 RVA: 0x0002953A File Offset: 0x0002773A
		public FPawnActionEvent()
		{
		}

		// Token: 0x06001BB6 RID: 7094 RVA: 0x00029542 File Offset: 0x00027742
		[NullableContext(1)]
		public FPawnActionEvent(UPawnAction Action)
		{
			this.Action = Action;
		}

		// Token: 0x06001BB7 RID: 7095 RVA: 0x00029551 File Offset: 0x00027751
		protected override IntPtr GetUStructPtr()
		{
			return FPawnActionEvent.StaticStruct();
		}

		// Token: 0x06001BB8 RID: 7096 RVA: 0x0002955D File Offset: 0x0002775D
		[NullableContext(2)]
		public FPawnActionEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001BB9 RID: 7097 RVA: 0x00029567 File Offset: 0x00027767
		public FPawnActionEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001BBA RID: 7098 RVA: 0x00029572 File Offset: 0x00027772
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPawnActionEvent(Pointer, false, true);
		}

		// Token: 0x06001BBB RID: 7099 RVA: 0x0002957C File Offset: 0x0002777C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPawnActionEvent(Pointer, MemoryOwner);
		}

		// Token: 0x040008E8 RID: 2280
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AIModule.PawnActionEvent";

		// Token: 0x040008E9 RID: 2281
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040008EA RID: 2282
		internal static int __PropertyOffset_Action;
	}
}
