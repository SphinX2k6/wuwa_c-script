using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020000CD RID: 205
	[UnrealObjectPath("/Script/AkAudio.AkSegmentInfo")]
	[UnrealStructLayout(36, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 36)]
	public class FAkSegmentInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06000F13 RID: 3859 RVA: 0x000175A6 File Offset: 0x000157A6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAkSegmentInfo._ScriptStructPtr != 0) ? FAkSegmentInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.AkSegmentInfo", ref FAkSegmentInfo._ScriptStructPtr);
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000F14 RID: 3860 RVA: 0x000175CA File Offset: 0x000157CA
		// (set) Token: 0x06000F15 RID: 3861 RVA: 0x000175DA File Offset: 0x000157DA
		public unsafe int CurrentPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkSegmentInfo.__PropertyOffset_CurrentPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkSegmentInfo.__PropertyOffset_CurrentPosition) = value;
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000F16 RID: 3862 RVA: 0x000175EB File Offset: 0x000157EB
		// (set) Token: 0x06000F17 RID: 3863 RVA: 0x000175FB File Offset: 0x000157FB
		public unsafe int PreEntryDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkSegmentInfo.__PropertyOffset_PreEntryDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkSegmentInfo.__PropertyOffset_PreEntryDuration) = value;
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000F18 RID: 3864 RVA: 0x0001760C File Offset: 0x0001580C
		// (set) Token: 0x06000F19 RID: 3865 RVA: 0x0001761C File Offset: 0x0001581C
		public unsafe int ActiveDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkSegmentInfo.__PropertyOffset_ActiveDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkSegmentInfo.__PropertyOffset_ActiveDuration) = value;
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000F1A RID: 3866 RVA: 0x0001762D File Offset: 0x0001582D
		// (set) Token: 0x06000F1B RID: 3867 RVA: 0x0001763D File Offset: 0x0001583D
		public unsafe int PostExitDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkSegmentInfo.__PropertyOffset_PostExitDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkSegmentInfo.__PropertyOffset_PostExitDuration) = value;
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000F1C RID: 3868 RVA: 0x0001764E File Offset: 0x0001584E
		// (set) Token: 0x06000F1D RID: 3869 RVA: 0x0001765E File Offset: 0x0001585E
		public unsafe int RemainingLookAheadTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkSegmentInfo.__PropertyOffset_RemainingLookAheadTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkSegmentInfo.__PropertyOffset_RemainingLookAheadTime) = value;
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000F1E RID: 3870 RVA: 0x0001766F File Offset: 0x0001586F
		// (set) Token: 0x06000F1F RID: 3871 RVA: 0x0001767F File Offset: 0x0001587F
		public unsafe float BeatDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkSegmentInfo.__PropertyOffset_BeatDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkSegmentInfo.__PropertyOffset_BeatDuration) = value;
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000F20 RID: 3872 RVA: 0x00017690 File Offset: 0x00015890
		// (set) Token: 0x06000F21 RID: 3873 RVA: 0x000176A0 File Offset: 0x000158A0
		public unsafe float BarDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkSegmentInfo.__PropertyOffset_BarDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkSegmentInfo.__PropertyOffset_BarDuration) = value;
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000F22 RID: 3874 RVA: 0x000176B1 File Offset: 0x000158B1
		// (set) Token: 0x06000F23 RID: 3875 RVA: 0x000176C1 File Offset: 0x000158C1
		public unsafe float GridDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkSegmentInfo.__PropertyOffset_GridDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkSegmentInfo.__PropertyOffset_GridDuration) = value;
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000F24 RID: 3876 RVA: 0x000176D2 File Offset: 0x000158D2
		// (set) Token: 0x06000F25 RID: 3877 RVA: 0x000176E2 File Offset: 0x000158E2
		public unsafe float GridOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkSegmentInfo.__PropertyOffset_GridOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkSegmentInfo.__PropertyOffset_GridOffset) = value;
			}
		}

		// Token: 0x06000F26 RID: 3878 RVA: 0x000176F3 File Offset: 0x000158F3
		public FAkSegmentInfo()
		{
		}

		// Token: 0x06000F27 RID: 3879 RVA: 0x000176FB File Offset: 0x000158FB
		protected override IntPtr GetUStructPtr()
		{
			return FAkSegmentInfo.StaticStruct();
		}

		// Token: 0x06000F28 RID: 3880 RVA: 0x00017707 File Offset: 0x00015907
		[NullableContext(2)]
		public FAkSegmentInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06000F29 RID: 3881 RVA: 0x00017711 File Offset: 0x00015911
		public FAkSegmentInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x0001771C File Offset: 0x0001591C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAkSegmentInfo(Pointer, false, true);
		}

		// Token: 0x06000F2B RID: 3883 RVA: 0x00017726 File Offset: 0x00015926
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAkSegmentInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04000305 RID: 773
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AkAudio.AkSegmentInfo";

		// Token: 0x04000306 RID: 774
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000307 RID: 775
		internal static int __PropertyOffset_CurrentPosition;

		// Token: 0x04000308 RID: 776
		internal static int __PropertyOffset_PreEntryDuration;

		// Token: 0x04000309 RID: 777
		internal static int __PropertyOffset_ActiveDuration;

		// Token: 0x0400030A RID: 778
		internal static int __PropertyOffset_PostExitDuration;

		// Token: 0x0400030B RID: 779
		internal static int __PropertyOffset_RemainingLookAheadTime;

		// Token: 0x0400030C RID: 780
		internal static int __PropertyOffset_BeatDuration;

		// Token: 0x0400030D RID: 781
		internal static int __PropertyOffset_BarDuration;

		// Token: 0x0400030E RID: 782
		internal static int __PropertyOffset_GridDuration;

		// Token: 0x0400030F RID: 783
		internal static int __PropertyOffset_GridOffset;
	}
}
