using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000240 RID: 576
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkSettingsPerUser")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class UAkSettingsPerUser : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060021E9 RID: 8681 RVA: 0x000325B1 File Offset: 0x000307B1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkSettingsPerUser._ClassPtr;
		}

		// Token: 0x060021EA RID: 8682 RVA: 0x000325C0 File Offset: 0x000307C0
		public UAkSettingsPerUser() : this(BuiltinUtils.AllocNativeUObject(UAkSettingsPerUser.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060021EB RID: 8683 RVA: 0x000325E8 File Offset: 0x000307E8
		public UAkSettingsPerUser(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkSettingsPerUser.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x060021EC RID: 8684 RVA: 0x0003261C File Offset: 0x0003081C
		// (set) Token: 0x060021ED RID: 8685 RVA: 0x00032655 File Offset: 0x00030855
		public FDirectoryPath WwiseWindowsInstallationPath
		{
			get
			{
				base.FastCheckIsValid();
				FDirectoryPath result;
				if ((result = this._WwiseWindowsInstallationPath) == null)
				{
					result = (this._WwiseWindowsInstallationPath = new FDirectoryPath(base.NativePtr + (IntPtr)UAkSettingsPerUser.__PropertyOffset_WwiseWindowsInstallationPath, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FDirectoryPath.StaticStruct(), base.NativePtr + (IntPtr)UAkSettingsPerUser.__PropertyOffset_WwiseWindowsInstallationPath, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x060021EE RID: 8686 RVA: 0x00032678 File Offset: 0x00030878
		// (set) Token: 0x060021EF RID: 8687 RVA: 0x000326B1 File Offset: 0x000308B1
		public FFilePath WwiseMacInstallationPath
		{
			get
			{
				base.FastCheckIsValid();
				FFilePath result;
				if ((result = this._WwiseMacInstallationPath) == null)
				{
					result = (this._WwiseMacInstallationPath = new FFilePath(base.NativePtr + (IntPtr)UAkSettingsPerUser.__PropertyOffset_WwiseMacInstallationPath, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFilePath.StaticStruct(), base.NativePtr + (IntPtr)UAkSettingsPerUser.__PropertyOffset_WwiseMacInstallationPath, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x060021F0 RID: 8688 RVA: 0x000326D4 File Offset: 0x000308D4
		// (set) Token: 0x060021F1 RID: 8689 RVA: 0x0003270D File Offset: 0x0003090D
		public FDirectoryPath GeneratedSoundBanksFolderUserOverride
		{
			get
			{
				base.FastCheckIsValid();
				FDirectoryPath result;
				if ((result = this._GeneratedSoundBanksFolderUserOverride) == null)
				{
					result = (this._GeneratedSoundBanksFolderUserOverride = new FDirectoryPath(base.NativePtr + (IntPtr)UAkSettingsPerUser.__PropertyOffset_GeneratedSoundBanksFolderUserOverride, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FDirectoryPath.StaticStruct(), base.NativePtr + (IntPtr)UAkSettingsPerUser.__PropertyOffset_GeneratedSoundBanksFolderUserOverride, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x060021F2 RID: 8690 RVA: 0x0003272E File Offset: 0x0003092E
		// (set) Token: 0x060021F3 RID: 8691 RVA: 0x00032742 File Offset: 0x00030942
		public unsafe string WaapiIPAddress
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UAkSettingsPerUser.__PropertyOffset_WaapiIPAddress)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UAkSettingsPerUser.__PropertyOffset_WaapiIPAddress)), value);
			}
		}

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x060021F4 RID: 8692 RVA: 0x00032757 File Offset: 0x00030957
		// (set) Token: 0x060021F5 RID: 8693 RVA: 0x00032767 File Offset: 0x00030967
		public unsafe uint WaapiPort
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkSettingsPerUser.__PropertyOffset_WaapiPort);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkSettingsPerUser.__PropertyOffset_WaapiPort) = (int)value;
			}
		}

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x060021F6 RID: 8694 RVA: 0x00032778 File Offset: 0x00030978
		// (set) Token: 0x060021F7 RID: 8695 RVA: 0x00032788 File Offset: 0x00030988
		public unsafe bool bAutoConnectToWAAPI
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkSettingsPerUser.__PropertyOffset_bAutoConnectToWAAPI) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkSettingsPerUser.__PropertyOffset_bAutoConnectToWAAPI) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x060021F8 RID: 8696 RVA: 0x00032799 File Offset: 0x00030999
		// (set) Token: 0x060021F9 RID: 8697 RVA: 0x000327A9 File Offset: 0x000309A9
		public unsafe bool AutoSyncSelection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkSettingsPerUser.__PropertyOffset_AutoSyncSelection) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkSettingsPerUser.__PropertyOffset_AutoSyncSelection) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x060021FA RID: 8698 RVA: 0x000327BA File Offset: 0x000309BA
		// (set) Token: 0x060021FB RID: 8699 RVA: 0x000327CA File Offset: 0x000309CA
		public unsafe uint WaapiTranslatorTimeout
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkSettingsPerUser.__PropertyOffset_WaapiTranslatorTimeout);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkSettingsPerUser.__PropertyOffset_WaapiTranslatorTimeout) = (int)value;
			}
		}

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x060021FC RID: 8700 RVA: 0x000327DB File Offset: 0x000309DB
		// (set) Token: 0x060021FD RID: 8701 RVA: 0x000327EB File Offset: 0x000309EB
		public unsafe bool SuppressGeneratedSoundBanksPathWarnings
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkSettingsPerUser.__PropertyOffset_SuppressGeneratedSoundBanksPathWarnings) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkSettingsPerUser.__PropertyOffset_SuppressGeneratedSoundBanksPathWarnings) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x060021FE RID: 8702 RVA: 0x000327FC File Offset: 0x000309FC
		// (set) Token: 0x060021FF RID: 8703 RVA: 0x0003280C File Offset: 0x00030A0C
		public unsafe bool SoundDataGenerationSkipLanguage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkSettingsPerUser.__PropertyOffset_SoundDataGenerationSkipLanguage) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkSettingsPerUser.__PropertyOffset_SoundDataGenerationSkipLanguage) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x06002200 RID: 8704 RVA: 0x0003281D File Offset: 0x00030A1D
		// (set) Token: 0x06002201 RID: 8705 RVA: 0x0003282D File Offset: 0x00030A2D
		public unsafe bool AskForWwiseAssetReload
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkSettingsPerUser.__PropertyOffset_AskForWwiseAssetReload) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkSettingsPerUser.__PropertyOffset_AskForWwiseAssetReload) = (value ? 1 : 0);
			}
		}

		// Token: 0x06002202 RID: 8706 RVA: 0x0003283E File Offset: 0x00030A3E
		static UAkSettingsPerUser()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkSettingsPerUser");
		}

		// Token: 0x06002203 RID: 8707 RVA: 0x0003284C File Offset: 0x00030A4C
		protected UAkSettingsPerUser(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000B9B RID: 2971
		public new const string __ObjectPath = "/Script/AkAudio.AkSettingsPerUser";

		// Token: 0x04000B9C RID: 2972
		private static IntPtr _ClassPtr;

		// Token: 0x04000B9D RID: 2973
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000B9E RID: 2974
		internal static int __PropertyOffset_WwiseWindowsInstallationPath;

		// Token: 0x04000B9F RID: 2975
		[Nullable(2)]
		private FDirectoryPath _WwiseWindowsInstallationPath;

		// Token: 0x04000BA0 RID: 2976
		internal static int __PropertyOffset_WwiseMacInstallationPath;

		// Token: 0x04000BA1 RID: 2977
		[Nullable(2)]
		private FFilePath _WwiseMacInstallationPath;

		// Token: 0x04000BA2 RID: 2978
		internal static int __PropertyOffset_GeneratedSoundBanksFolderUserOverride;

		// Token: 0x04000BA3 RID: 2979
		[Nullable(2)]
		private FDirectoryPath _GeneratedSoundBanksFolderUserOverride;

		// Token: 0x04000BA4 RID: 2980
		internal static int __PropertyOffset_WaapiIPAddress;

		// Token: 0x04000BA5 RID: 2981
		internal static int __PropertyOffset_WaapiPort;

		// Token: 0x04000BA6 RID: 2982
		internal static int __PropertyOffset_bAutoConnectToWAAPI;

		// Token: 0x04000BA7 RID: 2983
		internal static int __PropertyOffset_AutoSyncSelection;

		// Token: 0x04000BA8 RID: 2984
		internal static int __PropertyOffset_WaapiTranslatorTimeout;

		// Token: 0x04000BA9 RID: 2985
		internal static int __PropertyOffset_SuppressGeneratedSoundBanksPathWarnings;

		// Token: 0x04000BAA RID: 2986
		internal static int __PropertyOffset_SoundDataGenerationSkipLanguage;

		// Token: 0x04000BAB RID: 2987
		internal static int __PropertyOffset_AskForWwiseAssetReload;
	}
}
