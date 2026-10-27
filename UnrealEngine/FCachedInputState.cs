using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001C3D RID: 7229
	[UnrealObjectPath("/Script/KuroRhythmGame.CachedInputState")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FCachedInputState : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601C090 RID: 114832 RVA: 0x00294300 File Offset: 0x00292500
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCachedInputState._ScriptStructPtr != 0) ? FCachedInputState._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRhythmGame.CachedInputState", ref FCachedInputState._ScriptStructPtr);
		}

		// Token: 0x17007159 RID: 29017
		// (get) Token: 0x0601C091 RID: 114833 RVA: 0x00294324 File Offset: 0x00292524
		// (set) Token: 0x0601C092 RID: 114834 RVA: 0x00294334 File Offset: 0x00292534
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

		// Token: 0x1700715A RID: 29018
		// (get) Token: 0x0601C093 RID: 114835 RVA: 0x00294345 File Offset: 0x00292545
		// (set) Token: 0x0601C094 RID: 114836 RVA: 0x00294355 File Offset: 0x00292555
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

		// Token: 0x1700715B RID: 29019
		// (get) Token: 0x0601C095 RID: 114837 RVA: 0x00294366 File Offset: 0x00292566
		// (set) Token: 0x0601C096 RID: 114838 RVA: 0x00294376 File Offset: 0x00292576
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

		// Token: 0x0601C097 RID: 114839 RVA: 0x00294387 File Offset: 0x00292587
		public FCachedInputState()
		{
		}

		// Token: 0x0601C098 RID: 114840 RVA: 0x0029438F File Offset: 0x0029258F
		public FCachedInputState(float PressEventTime, float ReleaseEventTime, bool bFinalState)
		{
			this.PressEventTime = PressEventTime;
			this.ReleaseEventTime = ReleaseEventTime;
			this.bFinalState = bFinalState;
		}

		// Token: 0x0601C099 RID: 114841 RVA: 0x002943AC File Offset: 0x002925AC
		protected override IntPtr GetUStructPtr()
		{
			return FCachedInputState.StaticStruct();
		}

		// Token: 0x0601C09A RID: 114842 RVA: 0x002943B8 File Offset: 0x002925B8
		[NullableContext(2)]
		public FCachedInputState(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C09B RID: 114843 RVA: 0x002943C2 File Offset: 0x002925C2
		public FCachedInputState(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C09C RID: 114844 RVA: 0x002943CD File Offset: 0x002925CD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCachedInputState(Pointer, false, true);
		}

		// Token: 0x0601C09D RID: 114845 RVA: 0x002943D7 File Offset: 0x002925D7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCachedInputState(Pointer, MemoryOwner);
		}

		// Token: 0x0400F0FA RID: 61690
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRhythmGame.CachedInputState";

		// Token: 0x0400F0FB RID: 61691
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F0FC RID: 61692
		internal static int __PropertyOffset_PressEventTime;

		// Token: 0x0400F0FD RID: 61693
		internal static int __PropertyOffset_ReleaseEventTime;

		// Token: 0x0400F0FE RID: 61694
		internal static int __PropertyOffset_bFinalState;
	}
}
