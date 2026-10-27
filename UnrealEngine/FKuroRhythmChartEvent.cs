using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001C47 RID: 7239
	[UnrealObjectPath("/Script/KuroRhythmGame.KuroRhythmChartEvent")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FKuroRhythmChartEvent : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601C0BC RID: 114876 RVA: 0x002946AE File Offset: 0x002928AE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroRhythmChartEvent._ScriptStructPtr != 0) ? FKuroRhythmChartEvent._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRhythmGame.KuroRhythmChartEvent", ref FKuroRhythmChartEvent._ScriptStructPtr);
		}

		// Token: 0x17007162 RID: 29026
		// (get) Token: 0x0601C0BD RID: 114877 RVA: 0x002946D2 File Offset: 0x002928D2
		// (set) Token: 0x0601C0BE RID: 114878 RVA: 0x002946E2 File Offset: 0x002928E2
		public unsafe float Beat
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmChartEvent.__PropertyOffset_Beat);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmChartEvent.__PropertyOffset_Beat) = value;
			}
		}

		// Token: 0x17007163 RID: 29027
		// (get) Token: 0x0601C0BF RID: 114879 RVA: 0x002946F3 File Offset: 0x002928F3
		// (set) Token: 0x0601C0C0 RID: 114880 RVA: 0x00294703 File Offset: 0x00292903
		public unsafe EKuroRhythmChartEventType EventType
		{
			get
			{
				return (EKuroRhythmChartEventType)(*(base.NativePtr + (IntPtr)FKuroRhythmChartEvent.__PropertyOffset_EventType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmChartEvent.__PropertyOffset_EventType) = (byte)value;
			}
		}

		// Token: 0x17007164 RID: 29028
		// (get) Token: 0x0601C0C1 RID: 114881 RVA: 0x00294714 File Offset: 0x00292914
		// (set) Token: 0x0601C0C2 RID: 114882 RVA: 0x00294724 File Offset: 0x00292924
		public unsafe float EventValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmChartEvent.__PropertyOffset_EventValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmChartEvent.__PropertyOffset_EventValue) = value;
			}
		}

		// Token: 0x17007165 RID: 29029
		// (get) Token: 0x0601C0C3 RID: 114883 RVA: 0x00294735 File Offset: 0x00292935
		// (set) Token: 0x0601C0C4 RID: 114884 RVA: 0x00294745 File Offset: 0x00292945
		public unsafe float AbsoluteTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmChartEvent.__PropertyOffset_AbsoluteTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmChartEvent.__PropertyOffset_AbsoluteTime) = value;
			}
		}

		// Token: 0x0601C0C5 RID: 114885 RVA: 0x00294756 File Offset: 0x00292956
		public FKuroRhythmChartEvent()
		{
		}

		// Token: 0x0601C0C6 RID: 114886 RVA: 0x0029475E File Offset: 0x0029295E
		public FKuroRhythmChartEvent(float Beat, EKuroRhythmChartEventType EventType, float EventValue, float AbsoluteTime)
		{
			this.Beat = Beat;
			this.EventType = EventType;
			this.EventValue = EventValue;
			this.AbsoluteTime = AbsoluteTime;
		}

		// Token: 0x0601C0C7 RID: 114887 RVA: 0x00294783 File Offset: 0x00292983
		protected override IntPtr GetUStructPtr()
		{
			return FKuroRhythmChartEvent.StaticStruct();
		}

		// Token: 0x0601C0C8 RID: 114888 RVA: 0x0029478F File Offset: 0x0029298F
		[NullableContext(2)]
		public FKuroRhythmChartEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C0C9 RID: 114889 RVA: 0x00294799 File Offset: 0x00292999
		public FKuroRhythmChartEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C0CA RID: 114890 RVA: 0x002947A4 File Offset: 0x002929A4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroRhythmChartEvent(Pointer, false, true);
		}

		// Token: 0x0601C0CB RID: 114891 RVA: 0x002947AE File Offset: 0x002929AE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroRhythmChartEvent(Pointer, MemoryOwner);
		}

		// Token: 0x0400F14E RID: 61774
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRhythmGame.KuroRhythmChartEvent";

		// Token: 0x0400F14F RID: 61775
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F150 RID: 61776
		internal static int __PropertyOffset_Beat;

		// Token: 0x0400F151 RID: 61777
		internal static int __PropertyOffset_EventType;

		// Token: 0x0400F152 RID: 61778
		internal static int __PropertyOffset_EventValue;

		// Token: 0x0400F153 RID: 61779
		internal static int __PropertyOffset_AbsoluteTime;
	}
}
