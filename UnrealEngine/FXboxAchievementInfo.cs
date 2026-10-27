using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001F13 RID: 7955
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.XboxAchievementInfo")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FXboxAchievementInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E2F8 RID: 123640 RVA: 0x002CE20E File Offset: 0x002CC40E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FXboxAchievementInfo._ScriptStructPtr != 0) ? FXboxAchievementInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroUtility.XboxAchievementInfo", ref FXboxAchievementInfo._ScriptStructPtr);
		}

		// Token: 0x170077E3 RID: 30691
		// (get) Token: 0x0601E2F9 RID: 123641 RVA: 0x002CE232 File Offset: 0x002CC432
		// (set) Token: 0x0601E2FA RID: 123642 RVA: 0x002CE246 File Offset: 0x002CC446
		public unsafe string Id
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FXboxAchievementInfo.__PropertyOffset_Id)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FXboxAchievementInfo.__PropertyOffset_Id)), value);
			}
		}

		// Token: 0x170077E4 RID: 30692
		// (get) Token: 0x0601E2FB RID: 123643 RVA: 0x002CE25B File Offset: 0x002CC45B
		// (set) Token: 0x0601E2FC RID: 123644 RVA: 0x002CE26B File Offset: 0x002CC46B
		public unsafe bool bIsAchieved
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FXboxAchievementInfo.__PropertyOffset_bIsAchieved) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FXboxAchievementInfo.__PropertyOffset_bIsAchieved) = (value ? 1 : 0);
			}
		}

		// Token: 0x170077E5 RID: 30693
		// (get) Token: 0x0601E2FD RID: 123645 RVA: 0x002CE27C File Offset: 0x002CC47C
		// (set) Token: 0x0601E2FE RID: 123646 RVA: 0x002CE28C File Offset: 0x002CC48C
		public unsafe int ProgressState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FXboxAchievementInfo.__PropertyOffset_ProgressState);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FXboxAchievementInfo.__PropertyOffset_ProgressState) = value;
			}
		}

		// Token: 0x0601E2FF RID: 123647 RVA: 0x002CE29D File Offset: 0x002CC49D
		public FXboxAchievementInfo()
		{
		}

		// Token: 0x0601E300 RID: 123648 RVA: 0x002CE2A5 File Offset: 0x002CC4A5
		public FXboxAchievementInfo(string Id, bool bIsAchieved, int ProgressState)
		{
			this.Id = Id;
			this.bIsAchieved = bIsAchieved;
			this.ProgressState = ProgressState;
		}

		// Token: 0x0601E301 RID: 123649 RVA: 0x002CE2C2 File Offset: 0x002CC4C2
		protected override IntPtr GetUStructPtr()
		{
			return FXboxAchievementInfo.StaticStruct();
		}

		// Token: 0x0601E302 RID: 123650 RVA: 0x002CE2CE File Offset: 0x002CC4CE
		[NullableContext(2)]
		public FXboxAchievementInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E303 RID: 123651 RVA: 0x002CE2D8 File Offset: 0x002CC4D8
		public FXboxAchievementInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E304 RID: 123652 RVA: 0x002CE2E3 File Offset: 0x002CC4E3
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FXboxAchievementInfo(Pointer, false, true);
		}

		// Token: 0x0601E305 RID: 123653 RVA: 0x002CE2ED File Offset: 0x002CC4ED
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FXboxAchievementInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040104B9 RID: 66745
		public const string __ObjectPath = "/Script/KuroUtility.XboxAchievementInfo";

		// Token: 0x040104BA RID: 66746
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040104BB RID: 66747
		internal static int __PropertyOffset_Id;

		// Token: 0x040104BC RID: 66748
		internal static int __PropertyOffset_bIsAchieved;

		// Token: 0x040104BD RID: 66749
		internal static int __PropertyOffset_ProgressState;
	}
}
