using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000BAE RID: 2990
	[UnrealObjectPath("/Script/Engine.EventTrackKey")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FEventTrackKey : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060092A2 RID: 37538 RVA: 0x000D2548 File Offset: 0x000D0748
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FEventTrackKey._ScriptStructPtr != 0) ? FEventTrackKey._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.EventTrackKey", ref FEventTrackKey._ScriptStructPtr);
		}

		// Token: 0x1700231B RID: 8987
		// (get) Token: 0x060092A3 RID: 37539 RVA: 0x000D256C File Offset: 0x000D076C
		// (set) Token: 0x060092A4 RID: 37540 RVA: 0x000D257C File Offset: 0x000D077C
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEventTrackKey.__PropertyOffset_Time);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEventTrackKey.__PropertyOffset_Time) = value;
			}
		}

		// Token: 0x1700231C RID: 8988
		// (get) Token: 0x060092A5 RID: 37541 RVA: 0x000D258D File Offset: 0x000D078D
		// (set) Token: 0x060092A6 RID: 37542 RVA: 0x000D25A1 File Offset: 0x000D07A1
		public unsafe FName EventName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEventTrackKey.__PropertyOffset_EventName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEventTrackKey.__PropertyOffset_EventName) = value;
			}
		}

		// Token: 0x060092A7 RID: 37543 RVA: 0x000D25B6 File Offset: 0x000D07B6
		public FEventTrackKey()
		{
		}

		// Token: 0x060092A8 RID: 37544 RVA: 0x000D25BE File Offset: 0x000D07BE
		public FEventTrackKey(float Time, FName EventName)
		{
			this.Time = Time;
			this.EventName = EventName;
		}

		// Token: 0x060092A9 RID: 37545 RVA: 0x000D25D4 File Offset: 0x000D07D4
		protected override IntPtr GetUStructPtr()
		{
			return FEventTrackKey.StaticStruct();
		}

		// Token: 0x060092AA RID: 37546 RVA: 0x000D25E0 File Offset: 0x000D07E0
		[NullableContext(2)]
		public FEventTrackKey(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060092AB RID: 37547 RVA: 0x000D25EA File Offset: 0x000D07EA
		public FEventTrackKey(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060092AC RID: 37548 RVA: 0x000D25F5 File Offset: 0x000D07F5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FEventTrackKey(Pointer, false, true);
		}

		// Token: 0x060092AD RID: 37549 RVA: 0x000D25FF File Offset: 0x000D07FF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FEventTrackKey(Pointer, MemoryOwner);
		}

		// Token: 0x04005247 RID: 21063
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.EventTrackKey";

		// Token: 0x04005248 RID: 21064
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005249 RID: 21065
		internal static int __PropertyOffset_Time;

		// Token: 0x0400524A RID: 21066
		internal static int __PropertyOffset_EventName;
	}
}
