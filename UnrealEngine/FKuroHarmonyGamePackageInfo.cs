using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001EBB RID: 7867
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.KuroHarmonyGamePackageInfo")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FKuroHarmonyGamePackageInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601DDB9 RID: 122297 RVA: 0x002C2A68 File Offset: 0x002C0C68
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroHarmonyGamePackageInfo._ScriptStructPtr != 0) ? FKuroHarmonyGamePackageInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroUtility.KuroHarmonyGamePackageInfo", ref FKuroHarmonyGamePackageInfo._ScriptStructPtr);
		}

		// Token: 0x170077AC RID: 30636
		// (get) Token: 0x0601DDBA RID: 122298 RVA: 0x002C2A8C File Offset: 0x002C0C8C
		// (set) Token: 0x0601DDBB RID: 122299 RVA: 0x002C2A9C File Offset: 0x002C0C9C
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

		// Token: 0x170077AD RID: 30637
		// (get) Token: 0x0601DDBC RID: 122300 RVA: 0x002C2AAD File Offset: 0x002C0CAD
		// (set) Token: 0x0601DDBD RID: 122301 RVA: 0x002C2AC1 File Offset: 0x002C0CC1
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

		// Token: 0x170077AE RID: 30638
		// (get) Token: 0x0601DDBE RID: 122302 RVA: 0x002C2AD6 File Offset: 0x002C0CD6
		// (set) Token: 0x0601DDBF RID: 122303 RVA: 0x002C2AEA File Offset: 0x002C0CEA
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

		// Token: 0x170077AF RID: 30639
		// (get) Token: 0x0601DDC0 RID: 122304 RVA: 0x002C2AFF File Offset: 0x002C0CFF
		// (set) Token: 0x0601DDC1 RID: 122305 RVA: 0x002C2B0F File Offset: 0x002C0D0F
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

		// Token: 0x170077B0 RID: 30640
		// (get) Token: 0x0601DDC2 RID: 122306 RVA: 0x002C2B20 File Offset: 0x002C0D20
		// (set) Token: 0x0601DDC3 RID: 122307 RVA: 0x002C2B34 File Offset: 0x002C0D34
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

		// Token: 0x170077B1 RID: 30641
		// (get) Token: 0x0601DDC4 RID: 122308 RVA: 0x002C2B49 File Offset: 0x002C0D49
		// (set) Token: 0x0601DDC5 RID: 122309 RVA: 0x002C2B59 File Offset: 0x002C0D59
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

		// Token: 0x170077B2 RID: 30642
		// (get) Token: 0x0601DDC6 RID: 122310 RVA: 0x002C2B6A File Offset: 0x002C0D6A
		// (set) Token: 0x0601DDC7 RID: 122311 RVA: 0x002C2B7A File Offset: 0x002C0D7A
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

		// Token: 0x0601DDC8 RID: 122312 RVA: 0x002C2B8B File Offset: 0x002C0D8B
		public FKuroHarmonyGamePackageInfo()
		{
		}

		// Token: 0x0601DDC9 RID: 122313 RVA: 0x002C2B93 File Offset: 0x002C0D93
		public FKuroHarmonyGamePackageInfo(int MessageType, string BundleName, string AppVersion, int EngineType, string EngineVersion, int GameType, bool bVulkanSupported)
		{
			this.MessageType = MessageType;
			this.BundleName = BundleName;
			this.AppVersion = AppVersion;
			this.EngineType = EngineType;
			this.EngineVersion = EngineVersion;
			this.GameType = GameType;
			this.bVulkanSupported = bVulkanSupported;
		}

		// Token: 0x0601DDCA RID: 122314 RVA: 0x002C2BD0 File Offset: 0x002C0DD0
		protected override IntPtr GetUStructPtr()
		{
			return FKuroHarmonyGamePackageInfo.StaticStruct();
		}

		// Token: 0x0601DDCB RID: 122315 RVA: 0x002C2BDC File Offset: 0x002C0DDC
		[NullableContext(2)]
		public FKuroHarmonyGamePackageInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DDCC RID: 122316 RVA: 0x002C2BE6 File Offset: 0x002C0DE6
		public FKuroHarmonyGamePackageInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DDCD RID: 122317 RVA: 0x002C2BF1 File Offset: 0x002C0DF1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroHarmonyGamePackageInfo(Pointer, false, true);
		}

		// Token: 0x0601DDCE RID: 122318 RVA: 0x002C2BFB File Offset: 0x002C0DFB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroHarmonyGamePackageInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040102D3 RID: 66259
		public const string __ObjectPath = "/Script/KuroUtility.KuroHarmonyGamePackageInfo";

		// Token: 0x040102D4 RID: 66260
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040102D5 RID: 66261
		internal static int __PropertyOffset_MessageType;

		// Token: 0x040102D6 RID: 66262
		internal static int __PropertyOffset_BundleName;

		// Token: 0x040102D7 RID: 66263
		internal static int __PropertyOffset_AppVersion;

		// Token: 0x040102D8 RID: 66264
		internal static int __PropertyOffset_EngineType;

		// Token: 0x040102D9 RID: 66265
		internal static int __PropertyOffset_EngineVersion;

		// Token: 0x040102DA RID: 66266
		internal static int __PropertyOffset_GameType;

		// Token: 0x040102DB RID: 66267
		internal static int __PropertyOffset_bVulkanSupported;
	}
}
