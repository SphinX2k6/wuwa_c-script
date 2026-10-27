using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020011EC RID: 4588
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.TimelineEventEntry")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FTimelineEventEntry : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010E97 RID: 69271 RVA: 0x0018D38D File Offset: 0x0018B58D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTimelineEventEntry._ScriptStructPtr != 0) ? FTimelineEventEntry._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.TimelineEventEntry", ref FTimelineEventEntry._ScriptStructPtr);
		}

		// Token: 0x17004212 RID: 16914
		// (get) Token: 0x06010E98 RID: 69272 RVA: 0x0018D3B1 File Offset: 0x0018B5B1
		// (set) Token: 0x06010E99 RID: 69273 RVA: 0x0018D3C1 File Offset: 0x0018B5C1
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTimelineEventEntry.__PropertyOffset_Time);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTimelineEventEntry.__PropertyOffset_Time) = value;
			}
		}

		// Token: 0x17004213 RID: 16915
		// (get) Token: 0x06010E9A RID: 69274 RVA: 0x0018D3D4 File Offset: 0x0018B5D4
		// (set) Token: 0x06010E9B RID: 69275 RVA: 0x0018D417 File Offset: 0x0018B617
		public FOnTimelineEvent EventFunc
		{
			get
			{
				base.FastCheckIsValid();
				FOnTimelineEvent result;
				if ((result = this._EventFunc) == null)
				{
					result = (this._EventFunc = new FOnTimelineEvent(base.NativePtr + (IntPtr)FTimelineEventEntry.__PropertyOffset_EventFunc, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)FTimelineEventEntry.__PropertyOffset_EventFunc, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06010E9C RID: 69276 RVA: 0x0018D438 File Offset: 0x0018B638
		public FTimelineEventEntry()
		{
		}

		// Token: 0x06010E9D RID: 69277 RVA: 0x0018D440 File Offset: 0x0018B640
		public FTimelineEventEntry(float Time, FOnTimelineEvent EventFunc)
		{
			this.Time = Time;
			this.EventFunc = EventFunc;
		}

		// Token: 0x06010E9E RID: 69278 RVA: 0x0018D456 File Offset: 0x0018B656
		protected override IntPtr GetUStructPtr()
		{
			return FTimelineEventEntry.StaticStruct();
		}

		// Token: 0x06010E9F RID: 69279 RVA: 0x0018D462 File Offset: 0x0018B662
		[NullableContext(2)]
		public FTimelineEventEntry(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010EA0 RID: 69280 RVA: 0x0018D46C File Offset: 0x0018B66C
		public FTimelineEventEntry(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010EA1 RID: 69281 RVA: 0x0018D477 File Offset: 0x0018B677
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTimelineEventEntry(Pointer, false, true);
		}

		// Token: 0x06010EA2 RID: 69282 RVA: 0x0018D481 File Offset: 0x0018B681
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTimelineEventEntry(Pointer, MemoryOwner);
		}

		// Token: 0x040090F3 RID: 37107
		public const string __ObjectPath = "/Script/Engine.TimelineEventEntry";

		// Token: 0x040090F4 RID: 37108
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040090F5 RID: 37109
		internal static int __PropertyOffset_Time;

		// Token: 0x040090F6 RID: 37110
		internal static int __PropertyOffset_EventFunc;

		// Token: 0x040090F7 RID: 37111
		[Nullable(2)]
		private FOnTimelineEvent _EventFunc;
	}
}
