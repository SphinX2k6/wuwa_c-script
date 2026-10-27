using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020002B3 RID: 691
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AndroidRuntimeSettings.GooglePlayLeaderboardMapping")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FGooglePlayLeaderboardMapping : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002688 RID: 9864 RVA: 0x00039F93 File Offset: 0x00038193
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGooglePlayLeaderboardMapping._ScriptStructPtr != 0) ? FGooglePlayLeaderboardMapping._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AndroidRuntimeSettings.GooglePlayLeaderboardMapping", ref FGooglePlayLeaderboardMapping._ScriptStructPtr);
		}

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x06002689 RID: 9865 RVA: 0x00039FB7 File Offset: 0x000381B7
		// (set) Token: 0x0600268A RID: 9866 RVA: 0x00039FCB File Offset: 0x000381CB
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FGooglePlayLeaderboardMapping.__PropertyOffset_Name)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FGooglePlayLeaderboardMapping.__PropertyOffset_Name)), value);
			}
		}

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x0600268B RID: 9867 RVA: 0x00039FE0 File Offset: 0x000381E0
		// (set) Token: 0x0600268C RID: 9868 RVA: 0x00039FF4 File Offset: 0x000381F4
		public unsafe string LeaderboardID
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FGooglePlayLeaderboardMapping.__PropertyOffset_LeaderboardID)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FGooglePlayLeaderboardMapping.__PropertyOffset_LeaderboardID)), value);
			}
		}

		// Token: 0x0600268D RID: 9869 RVA: 0x0003A009 File Offset: 0x00038209
		public FGooglePlayLeaderboardMapping()
		{
		}

		// Token: 0x0600268E RID: 9870 RVA: 0x0003A011 File Offset: 0x00038211
		public FGooglePlayLeaderboardMapping(string Name, string LeaderboardID)
		{
			this.Name = Name;
			this.LeaderboardID = LeaderboardID;
		}

		// Token: 0x0600268F RID: 9871 RVA: 0x0003A027 File Offset: 0x00038227
		protected override IntPtr GetUStructPtr()
		{
			return FGooglePlayLeaderboardMapping.StaticStruct();
		}

		// Token: 0x06002690 RID: 9872 RVA: 0x0003A033 File Offset: 0x00038233
		[NullableContext(2)]
		public FGooglePlayLeaderboardMapping(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002691 RID: 9873 RVA: 0x0003A03D File Offset: 0x0003823D
		public FGooglePlayLeaderboardMapping(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002692 RID: 9874 RVA: 0x0003A048 File Offset: 0x00038248
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGooglePlayLeaderboardMapping(Pointer, false, true);
		}

		// Token: 0x06002693 RID: 9875 RVA: 0x0003A052 File Offset: 0x00038252
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGooglePlayLeaderboardMapping(Pointer, MemoryOwner);
		}

		// Token: 0x04000F21 RID: 3873
		public const string __ObjectPath = "/Script/AndroidRuntimeSettings.GooglePlayLeaderboardMapping";

		// Token: 0x04000F22 RID: 3874
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000F23 RID: 3875
		internal static int __PropertyOffset_Name;

		// Token: 0x04000F24 RID: 3876
		internal static int __PropertyOffset_LeaderboardID;
	}
}
