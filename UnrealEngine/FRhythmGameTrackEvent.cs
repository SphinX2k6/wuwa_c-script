using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001C26 RID: 7206
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.RhythmGameTrackEvent")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FRhythmGameTrackEvent : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601BD6F RID: 114031 RVA: 0x0028F9CF File Offset: 0x0028DBCF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRhythmGameTrackEvent._ScriptStructPtr != 0) ? FRhythmGameTrackEvent._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.RhythmGameTrackEvent", ref FRhythmGameTrackEvent._ScriptStructPtr);
		}

		// Token: 0x17007059 RID: 28761
		// (get) Token: 0x0601BD70 RID: 114032 RVA: 0x0028F9F3 File Offset: 0x0028DBF3
		// (set) Token: 0x0601BD71 RID: 114033 RVA: 0x0028FA03 File Offset: 0x0028DC03
		public unsafe float TimePoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRhythmGameTrackEvent.__PropertyOffset_TimePoint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRhythmGameTrackEvent.__PropertyOffset_TimePoint) = value;
			}
		}

		// Token: 0x1700705A RID: 28762
		// (get) Token: 0x0601BD72 RID: 114034 RVA: 0x0028FA14 File Offset: 0x0028DC14
		// (set) Token: 0x0601BD73 RID: 114035 RVA: 0x0028FA24 File Offset: 0x0028DC24
		public unsafe int TrackType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRhythmGameTrackEvent.__PropertyOffset_TrackType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRhythmGameTrackEvent.__PropertyOffset_TrackType) = value;
			}
		}

		// Token: 0x1700705B RID: 28763
		// (get) Token: 0x0601BD74 RID: 114036 RVA: 0x0028FA35 File Offset: 0x0028DC35
		// (set) Token: 0x0601BD75 RID: 114037 RVA: 0x0028FA45 File Offset: 0x0028DC45
		public unsafe float EventValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRhythmGameTrackEvent.__PropertyOffset_EventValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRhythmGameTrackEvent.__PropertyOffset_EventValue) = value;
			}
		}

		// Token: 0x0601BD76 RID: 114038 RVA: 0x0028FA56 File Offset: 0x0028DC56
		public FRhythmGameTrackEvent()
		{
		}

		// Token: 0x0601BD77 RID: 114039 RVA: 0x0028FA5E File Offset: 0x0028DC5E
		public FRhythmGameTrackEvent(float TimePoint, int TrackType, float EventValue)
		{
			this.TimePoint = TimePoint;
			this.TrackType = TrackType;
			this.EventValue = EventValue;
		}

		// Token: 0x0601BD78 RID: 114040 RVA: 0x0028FA7B File Offset: 0x0028DC7B
		protected override IntPtr GetUStructPtr()
		{
			return FRhythmGameTrackEvent.StaticStruct();
		}

		// Token: 0x0601BD79 RID: 114041 RVA: 0x0028FA87 File Offset: 0x0028DC87
		[NullableContext(2)]
		public FRhythmGameTrackEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601BD7A RID: 114042 RVA: 0x0028FA91 File Offset: 0x0028DC91
		public FRhythmGameTrackEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601BD7B RID: 114043 RVA: 0x0028FA9C File Offset: 0x0028DC9C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRhythmGameTrackEvent(Pointer, false, true);
		}

		// Token: 0x0601BD7C RID: 114044 RVA: 0x0028FAA6 File Offset: 0x0028DCA6
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRhythmGameTrackEvent(Pointer, MemoryOwner);
		}

		// Token: 0x0400EF5D RID: 61277
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.RhythmGameTrackEvent";

		// Token: 0x0400EF5E RID: 61278
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400EF5F RID: 61279
		internal static int __PropertyOffset_TimePoint;

		// Token: 0x0400EF60 RID: 61280
		internal static int __PropertyOffset_TrackType;

		// Token: 0x0400EF61 RID: 61281
		internal static int __PropertyOffset_EventValue;
	}
}
