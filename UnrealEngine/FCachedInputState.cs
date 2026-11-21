using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020004F7 RID: 1271
	[UnrealObjectPath("/Script/KuroRhythmGame.CachedInputState")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FCachedInputState : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007769 RID: 30569 RVA: 0x000AE86B File Offset: 0x000ACA6B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCachedInputState._ScriptStructPtr != 0) ? FCachedInputState._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRhythmGame.CachedInputState", ref FCachedInputState._ScriptStructPtr);
		}

		// Token: 0x17001701 RID: 5889
		// (get) Token: 0x0600776A RID: 30570 RVA: 0x000AE88F File Offset: 0x000ACA8F
		// (set) Token: 0x0600776B RID: 30571 RVA: 0x000AE89F File Offset: 0x000ACA9F
		public unsafe float PressEventTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCachedInputState.__PropertyOffset_PressEventTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCachedInputState.__PropertyOffset_PressEventTime) = value;
			}
		}

		// Token: 0x17001702 RID: 5890
		// (get) Token: 0x0600776C RID: 30572 RVA: 0x000AE8B0 File Offset: 0x000ACAB0
		// (set) Token: 0x0600776D RID: 30573 RVA: 0x000AE8C0 File Offset: 0x000ACAC0
		public unsafe float ReleaseEventTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCachedInputState.__PropertyOffset_ReleaseEventTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCachedInputState.__PropertyOffset_ReleaseEventTime) = value;
			}
		}

		// Token: 0x17001703 RID: 5891
		// (get) Token: 0x0600776E RID: 30574 RVA: 0x000AE8D1 File Offset: 0x000ACAD1
		// (set) Token: 0x0600776F RID: 30575 RVA: 0x000AE8E1 File Offset: 0x000ACAE1
		public unsafe bool bFinalState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCachedInputState.__PropertyOffset_bFinalState) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCachedInputState.__PropertyOffset_bFinalState) = (value ? 1 : 0);
			}
		}

		// Token: 0x06007770 RID: 30576 RVA: 0x000AE8F2 File Offset: 0x000ACAF2
		public FCachedInputState()
		{
		}

		// Token: 0x06007771 RID: 30577 RVA: 0x000AE8FA File Offset: 0x000ACAFA
		protected override IntPtr GetUStructPtr()
		{
			return FCachedInputState.StaticStruct();
		}

		// Token: 0x06007772 RID: 30578 RVA: 0x000AE906 File Offset: 0x000ACB06
		[NullableContext(2)]
		public FCachedInputState(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007773 RID: 30579 RVA: 0x000AE910 File Offset: 0x000ACB10
		public FCachedInputState(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007774 RID: 30580 RVA: 0x000AE91B File Offset: 0x000ACB1B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCachedInputState(Pointer, false, true);
		}

		// Token: 0x06007775 RID: 30581 RVA: 0x000AE925 File Offset: 0x000ACB25
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCachedInputState(Pointer, MemoryOwner);
		}

		// Token: 0x04003251 RID: 12881
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRhythmGame.CachedInputState";

		// Token: 0x04003252 RID: 12882
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003253 RID: 12883
		internal static int __PropertyOffset_PressEventTime;

		// Token: 0x04003254 RID: 12884
		internal static int __PropertyOffset_ReleaseEventTime;

		// Token: 0x04003255 RID: 12885
		internal static int __PropertyOffset_bFinalState;
	}
}
