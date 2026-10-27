using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002A9B RID: 10907
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/XboxCommonGDKPlatformEditor.XboxCommonGDKTargetSettings")]
	[UnrealStructLayout(520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 520)]
	public abstract class UXboxCommonGDKTargetSettings : UGDKTargetSettings, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028349 RID: 164681 RVA: 0x003D29FA File Offset: 0x003D0BFA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UXboxCommonGDKTargetSettings._ClassPtr;
		}

		// Token: 0x17009967 RID: 39271
		// (get) Token: 0x0602834A RID: 164682 RVA: 0x003D2A06 File Offset: 0x003D0C06
		// (set) Token: 0x0602834B RID: 164683 RVA: 0x003D2A16 File Offset: 0x003D0C16
		public unsafe bool bAutoConfigureMessageTransport
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UXboxCommonGDKTargetSettings.__PropertyOffset_bAutoConfigureMessageTransport) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UXboxCommonGDKTargetSettings.__PropertyOffset_bAutoConfigureMessageTransport) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009968 RID: 39272
		// (get) Token: 0x0602834C RID: 164684 RVA: 0x003D2A27 File Offset: 0x003D0C27
		// (set) Token: 0x0602834D RID: 164685 RVA: 0x003D2A37 File Offset: 0x003D0C37
		public unsafe int MessageTransportSocketPort
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UXboxCommonGDKTargetSettings.__PropertyOffset_MessageTransportSocketPort);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UXboxCommonGDKTargetSettings.__PropertyOffset_MessageTransportSocketPort) = value;
			}
		}

		// Token: 0x17009969 RID: 39273
		// (get) Token: 0x0602834E RID: 164686 RVA: 0x003D2A48 File Offset: 0x003D0C48
		// (set) Token: 0x0602834F RID: 164687 RVA: 0x003D2A58 File Offset: 0x003D0C58
		public unsafe bool bDebugConsoleInputEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UXboxCommonGDKTargetSettings.__PropertyOffset_bDebugConsoleInputEnable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UXboxCommonGDKTargetSettings.__PropertyOffset_bDebugConsoleInputEnable) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700996A RID: 39274
		// (get) Token: 0x06028350 RID: 164688 RVA: 0x003D2A69 File Offset: 0x003D0C69
		// (set) Token: 0x06028351 RID: 164689 RVA: 0x003D2A79 File Offset: 0x003D0C79
		public unsafe int DebugConsoleInputPort
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UXboxCommonGDKTargetSettings.__PropertyOffset_DebugConsoleInputPort);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UXboxCommonGDKTargetSettings.__PropertyOffset_DebugConsoleInputPort) = value;
			}
		}

		// Token: 0x1700996B RID: 39275
		// (get) Token: 0x06028352 RID: 164690 RVA: 0x003D2A8C File Offset: 0x003D0C8C
		// (set) Token: 0x06028353 RID: 164691 RVA: 0x003D2AC5 File Offset: 0x003D0CC5
		public TArray<int> DebugNetworkPorts
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._DebugNetworkPorts) == null)
				{
					result = (this._DebugNetworkPorts = new TArray<int>(base.NativePtr + (IntPtr)UXboxCommonGDKTargetSettings.__PropertyOffset_DebugNetworkPorts, this));
				}
				return result;
			}
			set
			{
				this.DebugNetworkPorts.CopyAssign(value);
			}
		}

		// Token: 0x1700996C RID: 39276
		// (get) Token: 0x06028354 RID: 164692 RVA: 0x003D2AD3 File Offset: 0x003D0CD3
		// (set) Token: 0x06028355 RID: 164693 RVA: 0x003D2AE3 File Offset: 0x003D0CE3
		public unsafe int PersistentLocalStorage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UXboxCommonGDKTargetSettings.__PropertyOffset_PersistentLocalStorage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UXboxCommonGDKTargetSettings.__PropertyOffset_PersistentLocalStorage) = value;
			}
		}

		// Token: 0x1700996D RID: 39277
		// (get) Token: 0x06028356 RID: 164694 RVA: 0x003D2AF4 File Offset: 0x003D0CF4
		// (set) Token: 0x06028357 RID: 164695 RVA: 0x003D2B04 File Offset: 0x003D0D04
		public unsafe bool bUploadLogsToWer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UXboxCommonGDKTargetSettings.__PropertyOffset_bUploadLogsToWer) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UXboxCommonGDKTargetSettings.__PropertyOffset_bUploadLogsToWer) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700996E RID: 39278
		// (get) Token: 0x06028358 RID: 164696 RVA: 0x003D2B15 File Offset: 0x003D0D15
		// (set) Token: 0x06028359 RID: 164697 RVA: 0x003D2B25 File Offset: 0x003D0D25
		public unsafe bool bUseForwardShading
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UXboxCommonGDKTargetSettings.__PropertyOffset_bUseForwardShading) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UXboxCommonGDKTargetSettings.__PropertyOffset_bUseForwardShading) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700996F RID: 39279
		// (get) Token: 0x0602835A RID: 164698 RVA: 0x003D2B36 File Offset: 0x003D0D36
		// (set) Token: 0x0602835B RID: 164699 RVA: 0x003D2B46 File Offset: 0x003D0D46
		public unsafe uint DefaultStackSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UXboxCommonGDKTargetSettings.__PropertyOffset_DefaultStackSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UXboxCommonGDKTargetSettings.__PropertyOffset_DefaultStackSize) = (int)value;
			}
		}

		// Token: 0x17009970 RID: 39280
		// (get) Token: 0x0602835C RID: 164700 RVA: 0x003D2B57 File Offset: 0x003D0D57
		// (set) Token: 0x0602835D RID: 164701 RVA: 0x003D2B67 File Offset: 0x003D0D67
		public unsafe uint DebugStackSizeOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UXboxCommonGDKTargetSettings.__PropertyOffset_DebugStackSizeOverride);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UXboxCommonGDKTargetSettings.__PropertyOffset_DebugStackSizeOverride) = (int)value;
			}
		}

		// Token: 0x17009971 RID: 39281
		// (get) Token: 0x0602835E RID: 164702 RVA: 0x003D2B78 File Offset: 0x003D0D78
		// (set) Token: 0x0602835F RID: 164703 RVA: 0x003D2B88 File Offset: 0x003D0D88
		public unsafe uint DefaultStackSizeCommit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UXboxCommonGDKTargetSettings.__PropertyOffset_DefaultStackSizeCommit);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UXboxCommonGDKTargetSettings.__PropertyOffset_DefaultStackSizeCommit) = (int)value;
			}
		}

		// Token: 0x17009972 RID: 39282
		// (get) Token: 0x06028360 RID: 164704 RVA: 0x003D2B99 File Offset: 0x003D0D99
		// (set) Token: 0x06028361 RID: 164705 RVA: 0x003D2BA9 File Offset: 0x003D0DA9
		public unsafe bool bSuppressInitialChunkSizeWarnings
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UXboxCommonGDKTargetSettings.__PropertyOffset_bSuppressInitialChunkSizeWarnings) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UXboxCommonGDKTargetSettings.__PropertyOffset_bSuppressInitialChunkSizeWarnings) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009973 RID: 39283
		// (get) Token: 0x06028362 RID: 164706 RVA: 0x003D2BBA File Offset: 0x003D0DBA
		// (set) Token: 0x06028363 RID: 164707 RVA: 0x003D2BCA File Offset: 0x003D0DCA
		public unsafe bool bSuppressDiscMasteringWarnings
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UXboxCommonGDKTargetSettings.__PropertyOffset_bSuppressDiscMasteringWarnings) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UXboxCommonGDKTargetSettings.__PropertyOffset_bSuppressDiscMasteringWarnings) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009974 RID: 39284
		// (get) Token: 0x06028364 RID: 164708 RVA: 0x003D2BDB File Offset: 0x003D0DDB
		// (set) Token: 0x06028365 RID: 164709 RVA: 0x003D2BEB File Offset: 0x003D0DEB
		public unsafe bool bAlignFilesLargeThanBlockInPak
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UXboxCommonGDKTargetSettings.__PropertyOffset_bAlignFilesLargeThanBlockInPak) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UXboxCommonGDKTargetSettings.__PropertyOffset_bAlignFilesLargeThanBlockInPak) = (value ? 1 : 0);
			}
		}

		// Token: 0x06028366 RID: 164710 RVA: 0x003D2BFC File Offset: 0x003D0DFC
		static UXboxCommonGDKTargetSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/XboxCommonGDKPlatformEditor.XboxCommonGDKTargetSettings");
		}

		// Token: 0x06028367 RID: 164711 RVA: 0x003D2C0C File Offset: 0x003D0E0C
		protected UXboxCommonGDKTargetSettings() : this(BuiltinUtils.AllocNativeUObject(UXboxCommonGDKTargetSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028368 RID: 164712 RVA: 0x003D2C34 File Offset: 0x003D0E34
		protected UXboxCommonGDKTargetSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040160BE RID: 90302
		public new const string __ObjectPath = "/Script/XboxCommonGDKPlatformEditor.XboxCommonGDKTargetSettings";

		// Token: 0x040160BF RID: 90303
		private static IntPtr _ClassPtr;

		// Token: 0x040160C0 RID: 90304
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040160C1 RID: 90305
		internal static int __PropertyOffset_bAutoConfigureMessageTransport;

		// Token: 0x040160C2 RID: 90306
		internal static int __PropertyOffset_MessageTransportSocketPort;

		// Token: 0x040160C3 RID: 90307
		internal static int __PropertyOffset_bDebugConsoleInputEnable;

		// Token: 0x040160C4 RID: 90308
		internal static int __PropertyOffset_DebugConsoleInputPort;

		// Token: 0x040160C5 RID: 90309
		internal static int __PropertyOffset_DebugNetworkPorts;

		// Token: 0x040160C6 RID: 90310
		[Nullable(2)]
		private TArray<int> _DebugNetworkPorts;

		// Token: 0x040160C7 RID: 90311
		internal static int __PropertyOffset_PersistentLocalStorage;

		// Token: 0x040160C8 RID: 90312
		internal static int __PropertyOffset_bUploadLogsToWer;

		// Token: 0x040160C9 RID: 90313
		internal static int __PropertyOffset_bUseForwardShading;

		// Token: 0x040160CA RID: 90314
		internal static int __PropertyOffset_DefaultStackSize;

		// Token: 0x040160CB RID: 90315
		internal static int __PropertyOffset_DebugStackSizeOverride;

		// Token: 0x040160CC RID: 90316
		internal static int __PropertyOffset_DefaultStackSizeCommit;

		// Token: 0x040160CD RID: 90317
		internal static int __PropertyOffset_bSuppressInitialChunkSizeWarnings;

		// Token: 0x040160CE RID: 90318
		internal static int __PropertyOffset_bSuppressDiscMasteringWarnings;

		// Token: 0x040160CF RID: 90319
		internal static int __PropertyOffset_bAlignFilesLargeThanBlockInPak;
	}
}
