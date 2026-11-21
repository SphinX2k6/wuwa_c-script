using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000619 RID: 1561
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.TrophyData")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FTrophyData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060088D1 RID: 35025 RVA: 0x000CE7C2 File Offset: 0x000CC9C2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTrophyData._ScriptStructPtr != 0) ? FTrophyData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroUtility.TrophyData", ref FTrophyData._ScriptStructPtr);
		}

		// Token: 0x17001980 RID: 6528
		// (get) Token: 0x060088D2 RID: 35026 RVA: 0x000CE7E6 File Offset: 0x000CC9E6
		// (set) Token: 0x060088D3 RID: 35027 RVA: 0x000CE7F6 File Offset: 0x000CC9F6
		public unsafe int trophyId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTrophyData.__PropertyOffset_trophyId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTrophyData.__PropertyOffset_trophyId) = value;
			}
		}

		// Token: 0x17001981 RID: 6529
		// (get) Token: 0x060088D4 RID: 35028 RVA: 0x000CE807 File Offset: 0x000CCA07
		// (set) Token: 0x060088D5 RID: 35029 RVA: 0x000CE817 File Offset: 0x000CCA17
		public unsafe bool unlocked
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTrophyData.__PropertyOffset_unlocked) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTrophyData.__PropertyOffset_unlocked) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001982 RID: 6530
		// (get) Token: 0x060088D6 RID: 35030 RVA: 0x000CE828 File Offset: 0x000CCA28
		// (set) Token: 0x060088D7 RID: 35031 RVA: 0x000CE838 File Offset: 0x000CCA38
		public unsafe int progressType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTrophyData.__PropertyOffset_progressType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTrophyData.__PropertyOffset_progressType) = value;
			}
		}

		// Token: 0x17001983 RID: 6531
		// (get) Token: 0x060088D8 RID: 35032 RVA: 0x000CE849 File Offset: 0x000CCA49
		// (set) Token: 0x060088D9 RID: 35033 RVA: 0x000CE85D File Offset: 0x000CCA5D
		public unsafe string progress
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FTrophyData.__PropertyOffset_progress)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FTrophyData.__PropertyOffset_progress)), value);
			}
		}

		// Token: 0x17001984 RID: 6532
		// (get) Token: 0x060088DA RID: 35034 RVA: 0x000CE872 File Offset: 0x000CCA72
		// (set) Token: 0x060088DB RID: 35035 RVA: 0x000CE886 File Offset: 0x000CCA86
		public unsafe string timestamp
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FTrophyData.__PropertyOffset_timestamp)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FTrophyData.__PropertyOffset_timestamp)), value);
			}
		}

		// Token: 0x060088DC RID: 35036 RVA: 0x000CE89B File Offset: 0x000CCA9B
		public FTrophyData()
		{
		}

		// Token: 0x060088DD RID: 35037 RVA: 0x000CE8A3 File Offset: 0x000CCAA3
		protected override IntPtr GetUStructPtr()
		{
			return FTrophyData.StaticStruct();
		}

		// Token: 0x060088DE RID: 35038 RVA: 0x000CE8AF File Offset: 0x000CCAAF
		[NullableContext(2)]
		public FTrophyData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060088DF RID: 35039 RVA: 0x000CE8B9 File Offset: 0x000CCAB9
		public FTrophyData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060088E0 RID: 35040 RVA: 0x000CE8C4 File Offset: 0x000CCAC4
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTrophyData(Pointer, false, true);
		}

		// Token: 0x060088E1 RID: 35041 RVA: 0x000CE8CE File Offset: 0x000CCACE
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTrophyData(Pointer, MemoryOwner);
		}

		// Token: 0x04003B63 RID: 15203
		public const string __ObjectPath = "/Script/KuroUtility.TrophyData";

		// Token: 0x04003B64 RID: 15204
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003B65 RID: 15205
		internal static int __PropertyOffset_trophyId;

		// Token: 0x04003B66 RID: 15206
		internal static int __PropertyOffset_unlocked;

		// Token: 0x04003B67 RID: 15207
		internal static int __PropertyOffset_progressType;

		// Token: 0x04003B68 RID: 15208
		internal static int __PropertyOffset_progress;

		// Token: 0x04003B69 RID: 15209
		internal static int __PropertyOffset_timestamp;
	}
}
