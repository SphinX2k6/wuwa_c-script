using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001980 RID: 6528
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroHotPatch.KuroAppSetting")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UKuroAppSetting : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060183F3 RID: 99315 RVA: 0x0023C2DA File Offset: 0x0023A4DA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAppSetting._ClassPtr;
		}

		// Token: 0x060183F4 RID: 99316 RVA: 0x0023C2E8 File Offset: 0x0023A4E8
		public UKuroAppSetting() : this(BuiltinUtils.AllocNativeUObject(UKuroAppSetting.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060183F5 RID: 99317 RVA: 0x0023C310 File Offset: 0x0023A510
		public UKuroAppSetting(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAppSetting.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170060F7 RID: 24823
		// (get) Token: 0x060183F6 RID: 99318 RVA: 0x0023C343 File Offset: 0x0023A543
		// (set) Token: 0x060183F7 RID: 99319 RVA: 0x0023C357 File Offset: 0x0023A557
		public unsafe string AppVersion
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UKuroAppSetting.__PropertyOffset_AppVersion)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UKuroAppSetting.__PropertyOffset_AppVersion)), value);
			}
		}

		// Token: 0x170060F8 RID: 24824
		// (get) Token: 0x060183F8 RID: 99320 RVA: 0x0023C36C File Offset: 0x0023A56C
		// (set) Token: 0x060183F9 RID: 99321 RVA: 0x0023C380 File Offset: 0x0023A580
		public unsafe string AppBuildNum
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UKuroAppSetting.__PropertyOffset_AppBuildNum)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UKuroAppSetting.__PropertyOffset_AppBuildNum)), value);
			}
		}

		// Token: 0x170060F9 RID: 24825
		// (get) Token: 0x060183FA RID: 99322 RVA: 0x0023C395 File Offset: 0x0023A595
		// (set) Token: 0x060183FB RID: 99323 RVA: 0x0023C3A9 File Offset: 0x0023A5A9
		public unsafe string AppReleaseType
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UKuroAppSetting.__PropertyOffset_AppReleaseType)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UKuroAppSetting.__PropertyOffset_AppReleaseType)), value);
			}
		}

		// Token: 0x170060FA RID: 24826
		// (get) Token: 0x060183FC RID: 99324 RVA: 0x0023C3BE File Offset: 0x0023A5BE
		// (set) Token: 0x060183FD RID: 99325 RVA: 0x0023C3D2 File Offset: 0x0023A5D2
		public unsafe string InternalUse
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UKuroAppSetting.__PropertyOffset_InternalUse)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UKuroAppSetting.__PropertyOffset_InternalUse)), value);
			}
		}

		// Token: 0x170060FB RID: 24827
		// (get) Token: 0x060183FE RID: 99326 RVA: 0x0023C3E7 File Offset: 0x0023A5E7
		// (set) Token: 0x060183FF RID: 99327 RVA: 0x0023C3FB File Offset: 0x0023A5FB
		public unsafe string ParallelApp
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UKuroAppSetting.__PropertyOffset_ParallelApp)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UKuroAppSetting.__PropertyOffset_ParallelApp)), value);
			}
		}

		// Token: 0x170060FC RID: 24828
		// (get) Token: 0x06018400 RID: 99328 RVA: 0x0023C410 File Offset: 0x0023A610
		// (set) Token: 0x06018401 RID: 99329 RVA: 0x0023C424 File Offset: 0x0023A624
		public unsafe string PakChunksToCopy
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UKuroAppSetting.__PropertyOffset_PakChunksToCopy)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UKuroAppSetting.__PropertyOffset_PakChunksToCopy)), value);
			}
		}

		// Token: 0x170060FD RID: 24829
		// (get) Token: 0x06018402 RID: 99330 RVA: 0x0023C439 File Offset: 0x0023A639
		// (set) Token: 0x06018403 RID: 99331 RVA: 0x0023C449 File Offset: 0x0023A649
		public unsafe bool bPakCopyCheck
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAppSetting.__PropertyOffset_bPakCopyCheck) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAppSetting.__PropertyOffset_bPakCopyCheck) = (value ? 1 : 0);
			}
		}

		// Token: 0x170060FE RID: 24830
		// (get) Token: 0x06018404 RID: 99332 RVA: 0x0023C45A File Offset: 0x0023A65A
		// (set) Token: 0x06018405 RID: 99333 RVA: 0x0023C46A File Offset: 0x0023A66A
		public unsafe bool bLocalPackaging
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAppSetting.__PropertyOffset_bLocalPackaging) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAppSetting.__PropertyOffset_bLocalPackaging) = (value ? 1 : 0);
			}
		}

		// Token: 0x170060FF RID: 24831
		// (get) Token: 0x06018406 RID: 99334 RVA: 0x0023C47B File Offset: 0x0023A67B
		// (set) Token: 0x06018407 RID: 99335 RVA: 0x0023C48B File Offset: 0x0023A68B
		public unsafe bool bNeedHotPatch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAppSetting.__PropertyOffset_bNeedHotPatch) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAppSetting.__PropertyOffset_bNeedHotPatch) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006100 RID: 24832
		// (get) Token: 0x06018408 RID: 99336 RVA: 0x0023C49C File Offset: 0x0023A69C
		// (set) Token: 0x06018409 RID: 99337 RVA: 0x0023C4AC File Offset: 0x0023A6AC
		public unsafe bool bSeparateVideo
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAppSetting.__PropertyOffset_bSeparateVideo) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAppSetting.__PropertyOffset_bSeparateVideo) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006101 RID: 24833
		// (get) Token: 0x0601840A RID: 99338 RVA: 0x0023C4BD File Offset: 0x0023A6BD
		// (set) Token: 0x0601840B RID: 99339 RVA: 0x0023C4CD File Offset: 0x0023A6CD
		public unsafe bool bEnableOptionalPackage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAppSetting.__PropertyOffset_bEnableOptionalPackage) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAppSetting.__PropertyOffset_bEnableOptionalPackage) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601840C RID: 99340 RVA: 0x0023C4DE File Offset: 0x0023A6DE
		static UKuroAppSetting()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroHotPatch.KuroAppSetting");
		}

		// Token: 0x0601840D RID: 99341 RVA: 0x0023C4EC File Offset: 0x0023A6EC
		protected UKuroAppSetting(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D21C RID: 53788
		public new const string __ObjectPath = "/Script/KuroHotPatch.KuroAppSetting";

		// Token: 0x0400D21D RID: 53789
		private static IntPtr _ClassPtr;

		// Token: 0x0400D21E RID: 53790
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D21F RID: 53791
		internal static int __PropertyOffset_AppVersion;

		// Token: 0x0400D220 RID: 53792
		internal static int __PropertyOffset_AppBuildNum;

		// Token: 0x0400D221 RID: 53793
		internal static int __PropertyOffset_AppReleaseType;

		// Token: 0x0400D222 RID: 53794
		internal static int __PropertyOffset_InternalUse;

		// Token: 0x0400D223 RID: 53795
		internal static int __PropertyOffset_ParallelApp;

		// Token: 0x0400D224 RID: 53796
		internal static int __PropertyOffset_PakChunksToCopy;

		// Token: 0x0400D225 RID: 53797
		internal static int __PropertyOffset_bPakCopyCheck;

		// Token: 0x0400D226 RID: 53798
		internal static int __PropertyOffset_bLocalPackaging;

		// Token: 0x0400D227 RID: 53799
		internal static int __PropertyOffset_bNeedHotPatch;

		// Token: 0x0400D228 RID: 53800
		internal static int __PropertyOffset_bSeparateVideo;

		// Token: 0x0400D229 RID: 53801
		internal static int __PropertyOffset_bEnableOptionalPackage;
	}
}
