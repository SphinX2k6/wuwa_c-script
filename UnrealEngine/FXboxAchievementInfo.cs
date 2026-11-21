using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200061E RID: 1566
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.XboxAchievementInfo")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FXboxAchievementInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600891E RID: 35102 RVA: 0x000CEE82 File Offset: 0x000CD082
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FXboxAchievementInfo._ScriptStructPtr != 0) ? FXboxAchievementInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroUtility.XboxAchievementInfo", ref FXboxAchievementInfo._ScriptStructPtr);
		}

		// Token: 0x17001993 RID: 6547
		// (get) Token: 0x0600891F RID: 35103 RVA: 0x000CEEA6 File Offset: 0x000CD0A6
		// (set) Token: 0x06008920 RID: 35104 RVA: 0x000CEEBA File Offset: 0x000CD0BA
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

		// Token: 0x17001994 RID: 6548
		// (get) Token: 0x06008921 RID: 35105 RVA: 0x000CEECF File Offset: 0x000CD0CF
		// (set) Token: 0x06008922 RID: 35106 RVA: 0x000CEEDF File Offset: 0x000CD0DF
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

		// Token: 0x17001995 RID: 6549
		// (get) Token: 0x06008923 RID: 35107 RVA: 0x000CEEF0 File Offset: 0x000CD0F0
		// (set) Token: 0x06008924 RID: 35108 RVA: 0x000CEF00 File Offset: 0x000CD100
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

		// Token: 0x06008925 RID: 35109 RVA: 0x000CEF11 File Offset: 0x000CD111
		public FXboxAchievementInfo()
		{
		}

		// Token: 0x06008926 RID: 35110 RVA: 0x000CEF19 File Offset: 0x000CD119
		protected override IntPtr GetUStructPtr()
		{
			return FXboxAchievementInfo.StaticStruct();
		}

		// Token: 0x06008927 RID: 35111 RVA: 0x000CEF25 File Offset: 0x000CD125
		[NullableContext(2)]
		public FXboxAchievementInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008928 RID: 35112 RVA: 0x000CEF2F File Offset: 0x000CD12F
		public FXboxAchievementInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008929 RID: 35113 RVA: 0x000CEF3A File Offset: 0x000CD13A
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FXboxAchievementInfo(Pointer, false, true);
		}

		// Token: 0x0600892A RID: 35114 RVA: 0x000CEF44 File Offset: 0x000CD144
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FXboxAchievementInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04003B84 RID: 15236
		public const string __ObjectPath = "/Script/KuroUtility.XboxAchievementInfo";

		// Token: 0x04003B85 RID: 15237
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003B86 RID: 15238
		internal static int __PropertyOffset_Id;

		// Token: 0x04003B87 RID: 15239
		internal static int __PropertyOffset_bIsAchieved;

		// Token: 0x04003B88 RID: 15240
		internal static int __PropertyOffset_ProgressState;
	}
}
