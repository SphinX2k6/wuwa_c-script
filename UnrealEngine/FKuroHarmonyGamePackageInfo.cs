using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005D9 RID: 1497
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.KuroHarmonyGamePackageInfo")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FKuroHarmonyGamePackageInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008485 RID: 33925 RVA: 0x000C4A91 File Offset: 0x000C2C91
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroHarmonyGamePackageInfo._ScriptStructPtr != 0) ? FKuroHarmonyGamePackageInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroUtility.KuroHarmonyGamePackageInfo", ref FKuroHarmonyGamePackageInfo._ScriptStructPtr);
		}

		// Token: 0x1700196B RID: 6507
		// (get) Token: 0x06008486 RID: 33926 RVA: 0x000C4AB5 File Offset: 0x000C2CB5
		// (set) Token: 0x06008487 RID: 33927 RVA: 0x000C4AC5 File Offset: 0x000C2CC5
		public unsafe int MessageType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHarmonyGamePackageInfo.__PropertyOffset_MessageType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHarmonyGamePackageInfo.__PropertyOffset_MessageType) = value;
			}
		}

		// Token: 0x1700196C RID: 6508
		// (get) Token: 0x06008488 RID: 33928 RVA: 0x000C4AD6 File Offset: 0x000C2CD6
		// (set) Token: 0x06008489 RID: 33929 RVA: 0x000C4AEA File Offset: 0x000C2CEA
		public unsafe string BundleName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroHarmonyGamePackageInfo.__PropertyOffset_BundleName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroHarmonyGamePackageInfo.__PropertyOffset_BundleName)), value);
			}
		}

		// Token: 0x1700196D RID: 6509
		// (get) Token: 0x0600848A RID: 33930 RVA: 0x000C4AFF File Offset: 0x000C2CFF
		// (set) Token: 0x0600848B RID: 33931 RVA: 0x000C4B13 File Offset: 0x000C2D13
		public unsafe string AppVersion
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroHarmonyGamePackageInfo.__PropertyOffset_AppVersion)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroHarmonyGamePackageInfo.__PropertyOffset_AppVersion)), value);
			}
		}

		// Token: 0x1700196E RID: 6510
		// (get) Token: 0x0600848C RID: 33932 RVA: 0x000C4B28 File Offset: 0x000C2D28
		// (set) Token: 0x0600848D RID: 33933 RVA: 0x000C4B38 File Offset: 0x000C2D38
		public unsafe int EngineType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHarmonyGamePackageInfo.__PropertyOffset_EngineType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHarmonyGamePackageInfo.__PropertyOffset_EngineType) = value;
			}
		}

		// Token: 0x1700196F RID: 6511
		// (get) Token: 0x0600848E RID: 33934 RVA: 0x000C4B49 File Offset: 0x000C2D49
		// (set) Token: 0x0600848F RID: 33935 RVA: 0x000C4B5D File Offset: 0x000C2D5D
		public unsafe string EngineVersion
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroHarmonyGamePackageInfo.__PropertyOffset_EngineVersion)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroHarmonyGamePackageInfo.__PropertyOffset_EngineVersion)), value);
			}
		}

		// Token: 0x17001970 RID: 6512
		// (get) Token: 0x06008490 RID: 33936 RVA: 0x000C4B72 File Offset: 0x000C2D72
		// (set) Token: 0x06008491 RID: 33937 RVA: 0x000C4B82 File Offset: 0x000C2D82
		public unsafe int GameType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHarmonyGamePackageInfo.__PropertyOffset_GameType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHarmonyGamePackageInfo.__PropertyOffset_GameType) = value;
			}
		}

		// Token: 0x17001971 RID: 6513
		// (get) Token: 0x06008492 RID: 33938 RVA: 0x000C4B93 File Offset: 0x000C2D93
		// (set) Token: 0x06008493 RID: 33939 RVA: 0x000C4BA3 File Offset: 0x000C2DA3
		public unsafe bool bVulkanSupported
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHarmonyGamePackageInfo.__PropertyOffset_bVulkanSupported) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHarmonyGamePackageInfo.__PropertyOffset_bVulkanSupported) = (value ? 1 : 0);
			}
		}

		// Token: 0x06008494 RID: 33940 RVA: 0x000C4BB4 File Offset: 0x000C2DB4
		public FKuroHarmonyGamePackageInfo()
		{
		}

		// Token: 0x06008495 RID: 33941 RVA: 0x000C4BBC File Offset: 0x000C2DBC
		protected override IntPtr GetUStructPtr()
		{
			return FKuroHarmonyGamePackageInfo.StaticStruct();
		}

		// Token: 0x06008496 RID: 33942 RVA: 0x000C4BC8 File Offset: 0x000C2DC8
		[NullableContext(2)]
		public FKuroHarmonyGamePackageInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008497 RID: 33943 RVA: 0x000C4BD2 File Offset: 0x000C2DD2
		public FKuroHarmonyGamePackageInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008498 RID: 33944 RVA: 0x000C4BDD File Offset: 0x000C2DDD
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroHarmonyGamePackageInfo(Pointer, false, true);
		}

		// Token: 0x06008499 RID: 33945 RVA: 0x000C4BE7 File Offset: 0x000C2DE7
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroHarmonyGamePackageInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040039E9 RID: 14825
		public const string __ObjectPath = "/Script/KuroUtility.KuroHarmonyGamePackageInfo";

		// Token: 0x040039EA RID: 14826
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040039EB RID: 14827
		internal static int __PropertyOffset_MessageType;

		// Token: 0x040039EC RID: 14828
		internal static int __PropertyOffset_BundleName;

		// Token: 0x040039ED RID: 14829
		internal static int __PropertyOffset_AppVersion;

		// Token: 0x040039EE RID: 14830
		internal static int __PropertyOffset_EngineType;

		// Token: 0x040039EF RID: 14831
		internal static int __PropertyOffset_EngineVersion;

		// Token: 0x040039F0 RID: 14832
		internal static int __PropertyOffset_GameType;

		// Token: 0x040039F1 RID: 14833
		internal static int __PropertyOffset_bVulkanSupported;
	}
}
