using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005D8 RID: 1496
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.KuroHarmonyGameConfigInfo")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FKuroHarmonyGameConfigInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008466 RID: 33894 RVA: 0x000C4895 File Offset: 0x000C2A95
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroHarmonyGameConfigInfo._ScriptStructPtr != 0) ? FKuroHarmonyGameConfigInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroUtility.KuroHarmonyGameConfigInfo", ref FKuroHarmonyGameConfigInfo._ScriptStructPtr);
		}

		// Token: 0x1700195F RID: 6495
		// (get) Token: 0x06008467 RID: 33895 RVA: 0x000C48B9 File Offset: 0x000C2AB9
		// (set) Token: 0x06008468 RID: 33896 RVA: 0x000C48C9 File Offset: 0x000C2AC9
		public unsafe int MessageType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHarmonyGameConfigInfo.__PropertyOffset_MessageType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHarmonyGameConfigInfo.__PropertyOffset_MessageType) = value;
			}
		}

		// Token: 0x17001960 RID: 6496
		// (get) Token: 0x06008469 RID: 33897 RVA: 0x000C48DA File Offset: 0x000C2ADA
		// (set) Token: 0x0600846A RID: 33898 RVA: 0x000C48EA File Offset: 0x000C2AEA
		public unsafe int MaxPictureQualityLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHarmonyGameConfigInfo.__PropertyOffset_MaxPictureQualityLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHarmonyGameConfigInfo.__PropertyOffset_MaxPictureQualityLevel) = value;
			}
		}

		// Token: 0x17001961 RID: 6497
		// (get) Token: 0x0600846B RID: 33899 RVA: 0x000C48FB File Offset: 0x000C2AFB
		// (set) Token: 0x0600846C RID: 33900 RVA: 0x000C490B File Offset: 0x000C2B0B
		public unsafe int CurrentPictureQualityLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHarmonyGameConfigInfo.__PropertyOffset_CurrentPictureQualityLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHarmonyGameConfigInfo.__PropertyOffset_CurrentPictureQualityLevel) = value;
			}
		}

		// Token: 0x17001962 RID: 6498
		// (get) Token: 0x0600846D RID: 33901 RVA: 0x000C491C File Offset: 0x000C2B1C
		// (set) Token: 0x0600846E RID: 33902 RVA: 0x000C492C File Offset: 0x000C2B2C
		public unsafe int MaxFrameRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHarmonyGameConfigInfo.__PropertyOffset_MaxFrameRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHarmonyGameConfigInfo.__PropertyOffset_MaxFrameRate) = value;
			}
		}

		// Token: 0x17001963 RID: 6499
		// (get) Token: 0x0600846F RID: 33903 RVA: 0x000C493D File Offset: 0x000C2B3D
		// (set) Token: 0x06008470 RID: 33904 RVA: 0x000C494D File Offset: 0x000C2B4D
		public unsafe int CurrentFrameRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHarmonyGameConfigInfo.__PropertyOffset_CurrentFrameRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHarmonyGameConfigInfo.__PropertyOffset_CurrentFrameRate) = value;
			}
		}

		// Token: 0x17001964 RID: 6500
		// (get) Token: 0x06008471 RID: 33905 RVA: 0x000C495E File Offset: 0x000C2B5E
		// (set) Token: 0x06008472 RID: 33906 RVA: 0x000C4972 File Offset: 0x000C2B72
		public unsafe string MaxResolution
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroHarmonyGameConfigInfo.__PropertyOffset_MaxResolution)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroHarmonyGameConfigInfo.__PropertyOffset_MaxResolution)), value);
			}
		}

		// Token: 0x17001965 RID: 6501
		// (get) Token: 0x06008473 RID: 33907 RVA: 0x000C4987 File Offset: 0x000C2B87
		// (set) Token: 0x06008474 RID: 33908 RVA: 0x000C499B File Offset: 0x000C2B9B
		public unsafe string CurrentResolution
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroHarmonyGameConfigInfo.__PropertyOffset_CurrentResolution)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroHarmonyGameConfigInfo.__PropertyOffset_CurrentResolution)), value);
			}
		}

		// Token: 0x17001966 RID: 6502
		// (get) Token: 0x06008475 RID: 33909 RVA: 0x000C49B0 File Offset: 0x000C2BB0
		// (set) Token: 0x06008476 RID: 33910 RVA: 0x000C49C0 File Offset: 0x000C2BC0
		public unsafe bool bAntiAliasing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHarmonyGameConfigInfo.__PropertyOffset_bAntiAliasing) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHarmonyGameConfigInfo.__PropertyOffset_bAntiAliasing) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001967 RID: 6503
		// (get) Token: 0x06008477 RID: 33911 RVA: 0x000C49D1 File Offset: 0x000C2BD1
		// (set) Token: 0x06008478 RID: 33912 RVA: 0x000C49E1 File Offset: 0x000C2BE1
		public unsafe bool bShadow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHarmonyGameConfigInfo.__PropertyOffset_bShadow) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHarmonyGameConfigInfo.__PropertyOffset_bShadow) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001968 RID: 6504
		// (get) Token: 0x06008479 RID: 33913 RVA: 0x000C49F2 File Offset: 0x000C2BF2
		// (set) Token: 0x0600847A RID: 33914 RVA: 0x000C4A02 File Offset: 0x000C2C02
		public unsafe bool bMultithreading
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHarmonyGameConfigInfo.__PropertyOffset_bMultithreading) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHarmonyGameConfigInfo.__PropertyOffset_bMultithreading) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001969 RID: 6505
		// (get) Token: 0x0600847B RID: 33915 RVA: 0x000C4A13 File Offset: 0x000C2C13
		// (set) Token: 0x0600847C RID: 33916 RVA: 0x000C4A23 File Offset: 0x000C2C23
		public unsafe bool bParticle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHarmonyGameConfigInfo.__PropertyOffset_bParticle) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHarmonyGameConfigInfo.__PropertyOffset_bParticle) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700196A RID: 6506
		// (get) Token: 0x0600847D RID: 33917 RVA: 0x000C4A34 File Offset: 0x000C2C34
		// (set) Token: 0x0600847E RID: 33918 RVA: 0x000C4A44 File Offset: 0x000C2C44
		public unsafe bool bHdMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroHarmonyGameConfigInfo.__PropertyOffset_bHdMode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroHarmonyGameConfigInfo.__PropertyOffset_bHdMode) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600847F RID: 33919 RVA: 0x000C4A55 File Offset: 0x000C2C55
		public FKuroHarmonyGameConfigInfo()
		{
		}

		// Token: 0x06008480 RID: 33920 RVA: 0x000C4A5D File Offset: 0x000C2C5D
		protected override IntPtr GetUStructPtr()
		{
			return FKuroHarmonyGameConfigInfo.StaticStruct();
		}

		// Token: 0x06008481 RID: 33921 RVA: 0x000C4A69 File Offset: 0x000C2C69
		[NullableContext(2)]
		public FKuroHarmonyGameConfigInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008482 RID: 33922 RVA: 0x000C4A73 File Offset: 0x000C2C73
		public FKuroHarmonyGameConfigInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008483 RID: 33923 RVA: 0x000C4A7E File Offset: 0x000C2C7E
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroHarmonyGameConfigInfo(Pointer, false, true);
		}

		// Token: 0x06008484 RID: 33924 RVA: 0x000C4A88 File Offset: 0x000C2C88
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroHarmonyGameConfigInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040039DB RID: 14811
		public const string __ObjectPath = "/Script/KuroUtility.KuroHarmonyGameConfigInfo";

		// Token: 0x040039DC RID: 14812
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040039DD RID: 14813
		internal static int __PropertyOffset_MessageType;

		// Token: 0x040039DE RID: 14814
		internal static int __PropertyOffset_MaxPictureQualityLevel;

		// Token: 0x040039DF RID: 14815
		internal static int __PropertyOffset_CurrentPictureQualityLevel;

		// Token: 0x040039E0 RID: 14816
		internal static int __PropertyOffset_MaxFrameRate;

		// Token: 0x040039E1 RID: 14817
		internal static int __PropertyOffset_CurrentFrameRate;

		// Token: 0x040039E2 RID: 14818
		internal static int __PropertyOffset_MaxResolution;

		// Token: 0x040039E3 RID: 14819
		internal static int __PropertyOffset_CurrentResolution;

		// Token: 0x040039E4 RID: 14820
		internal static int __PropertyOffset_bAntiAliasing;

		// Token: 0x040039E5 RID: 14821
		internal static int __PropertyOffset_bShadow;

		// Token: 0x040039E6 RID: 14822
		internal static int __PropertyOffset_bMultithreading;

		// Token: 0x040039E7 RID: 14823
		internal static int __PropertyOffset_bParticle;

		// Token: 0x040039E8 RID: 14824
		internal static int __PropertyOffset_bHdMode;
	}
}
