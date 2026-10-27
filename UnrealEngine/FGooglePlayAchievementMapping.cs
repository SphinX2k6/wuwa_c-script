using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020002B2 RID: 690
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AndroidRuntimeSettings.GooglePlayAchievementMapping")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FGooglePlayAchievementMapping : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600267C RID: 9852 RVA: 0x00039ECB File Offset: 0x000380CB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGooglePlayAchievementMapping._ScriptStructPtr != 0) ? FGooglePlayAchievementMapping._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AndroidRuntimeSettings.GooglePlayAchievementMapping", ref FGooglePlayAchievementMapping._ScriptStructPtr);
		}

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x0600267D RID: 9853 RVA: 0x00039EEF File Offset: 0x000380EF
		// (set) Token: 0x0600267E RID: 9854 RVA: 0x00039F03 File Offset: 0x00038103
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FGooglePlayAchievementMapping.__PropertyOffset_Name)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FGooglePlayAchievementMapping.__PropertyOffset_Name)), value);
			}
		}

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x0600267F RID: 9855 RVA: 0x00039F18 File Offset: 0x00038118
		// (set) Token: 0x06002680 RID: 9856 RVA: 0x00039F2C File Offset: 0x0003812C
		public unsafe string AchievementID
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FGooglePlayAchievementMapping.__PropertyOffset_AchievementID)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FGooglePlayAchievementMapping.__PropertyOffset_AchievementID)), value);
			}
		}

		// Token: 0x06002681 RID: 9857 RVA: 0x00039F41 File Offset: 0x00038141
		public FGooglePlayAchievementMapping()
		{
		}

		// Token: 0x06002682 RID: 9858 RVA: 0x00039F49 File Offset: 0x00038149
		public FGooglePlayAchievementMapping(string Name, string AchievementID)
		{
			this.Name = Name;
			this.AchievementID = AchievementID;
		}

		// Token: 0x06002683 RID: 9859 RVA: 0x00039F5F File Offset: 0x0003815F
		protected override IntPtr GetUStructPtr()
		{
			return FGooglePlayAchievementMapping.StaticStruct();
		}

		// Token: 0x06002684 RID: 9860 RVA: 0x00039F6B File Offset: 0x0003816B
		[NullableContext(2)]
		public FGooglePlayAchievementMapping(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002685 RID: 9861 RVA: 0x00039F75 File Offset: 0x00038175
		public FGooglePlayAchievementMapping(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002686 RID: 9862 RVA: 0x00039F80 File Offset: 0x00038180
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGooglePlayAchievementMapping(Pointer, false, true);
		}

		// Token: 0x06002687 RID: 9863 RVA: 0x00039F8A File Offset: 0x0003818A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGooglePlayAchievementMapping(Pointer, MemoryOwner);
		}

		// Token: 0x04000F1D RID: 3869
		public const string __ObjectPath = "/Script/AndroidRuntimeSettings.GooglePlayAchievementMapping";

		// Token: 0x04000F1E RID: 3870
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000F1F RID: 3871
		internal static int __PropertyOffset_Name;

		// Token: 0x04000F20 RID: 3872
		internal static int __PropertyOffset_AchievementID;
	}
}
