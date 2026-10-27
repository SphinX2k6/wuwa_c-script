using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200020F RID: 527
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkIOSInitializationSettings")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 304)]
	public class UAkIOSInitializationSettings : UAkPlatformInitializationSettingsBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001F63 RID: 8035 RVA: 0x0002E69C File Offset: 0x0002C89C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkIOSInitializationSettings._ClassPtr;
		}

		// Token: 0x06001F64 RID: 8036 RVA: 0x0002E6A8 File Offset: 0x0002C8A8
		public UAkIOSInitializationSettings() : this(BuiltinUtils.AllocNativeUObject(UAkIOSInitializationSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001F65 RID: 8037 RVA: 0x0002E6D0 File Offset: 0x0002C8D0
		public UAkIOSInitializationSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkIOSInitializationSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x06001F66 RID: 8038 RVA: 0x0002E704 File Offset: 0x0002C904
		// (set) Token: 0x06001F67 RID: 8039 RVA: 0x0002E73D File Offset: 0x0002C93D
		public FAkCommonInitializationSettingsWithSampleRate CommonSettings
		{
			get
			{
				base.FastCheckIsValid();
				FAkCommonInitializationSettingsWithSampleRate result;
				if ((result = this._CommonSettings) == null)
				{
					result = (this._CommonSettings = new FAkCommonInitializationSettingsWithSampleRate(base.NativePtr + (IntPtr)UAkIOSInitializationSettings.__PropertyOffset_CommonSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkCommonInitializationSettingsWithSampleRate.StaticStruct(), base.NativePtr + (IntPtr)UAkIOSInitializationSettings.__PropertyOffset_CommonSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x06001F68 RID: 8040 RVA: 0x0002E760 File Offset: 0x0002C960
		// (set) Token: 0x06001F69 RID: 8041 RVA: 0x0002E799 File Offset: 0x0002C999
		public FAkAudioSession AudioSession
		{
			get
			{
				base.FastCheckIsValid();
				FAkAudioSession result;
				if ((result = this._AudioSession) == null)
				{
					result = (this._AudioSession = new FAkAudioSession(base.NativePtr + (IntPtr)UAkIOSInitializationSettings.__PropertyOffset_AudioSession, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkAudioSession.StaticStruct(), base.NativePtr + (IntPtr)UAkIOSInitializationSettings.__PropertyOffset_AudioSession, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x06001F6A RID: 8042 RVA: 0x0002E7BC File Offset: 0x0002C9BC
		// (set) Token: 0x06001F6B RID: 8043 RVA: 0x0002E7F5 File Offset: 0x0002C9F5
		public FAkCommunicationSettingsWithSystemInitialization CommunicationSettings
		{
			get
			{
				base.FastCheckIsValid();
				FAkCommunicationSettingsWithSystemInitialization result;
				if ((result = this._CommunicationSettings) == null)
				{
					result = (this._CommunicationSettings = new FAkCommunicationSettingsWithSystemInitialization(base.NativePtr + (IntPtr)UAkIOSInitializationSettings.__PropertyOffset_CommunicationSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkCommunicationSettingsWithSystemInitialization.StaticStruct(), base.NativePtr + (IntPtr)UAkIOSInitializationSettings.__PropertyOffset_CommunicationSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x06001F6C RID: 8044 RVA: 0x0002E818 File Offset: 0x0002CA18
		// (set) Token: 0x06001F6D RID: 8045 RVA: 0x0002E851 File Offset: 0x0002CA51
		public FAkIOSAdvancedInitializationSettings AdvancedSettings
		{
			get
			{
				base.FastCheckIsValid();
				FAkIOSAdvancedInitializationSettings result;
				if ((result = this._AdvancedSettings) == null)
				{
					result = (this._AdvancedSettings = new FAkIOSAdvancedInitializationSettings(base.NativePtr + (IntPtr)UAkIOSInitializationSettings.__PropertyOffset_AdvancedSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkIOSAdvancedInitializationSettings.StaticStruct(), base.NativePtr + (IntPtr)UAkIOSInitializationSettings.__PropertyOffset_AdvancedSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06001F6E RID: 8046 RVA: 0x0002E872 File Offset: 0x0002CA72
		static UAkIOSInitializationSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkIOSInitializationSettings");
		}

		// Token: 0x06001F6F RID: 8047 RVA: 0x0002E880 File Offset: 0x0002CA80
		protected UAkIOSInitializationSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000A59 RID: 2649
		public new const string __ObjectPath = "/Script/AkAudio.AkIOSInitializationSettings";

		// Token: 0x04000A5A RID: 2650
		private static IntPtr _ClassPtr;

		// Token: 0x04000A5B RID: 2651
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000A5C RID: 2652
		internal static int __PropertyOffset_CommonSettings;

		// Token: 0x04000A5D RID: 2653
		[Nullable(2)]
		private FAkCommonInitializationSettingsWithSampleRate _CommonSettings;

		// Token: 0x04000A5E RID: 2654
		internal static int __PropertyOffset_AudioSession;

		// Token: 0x04000A5F RID: 2655
		[Nullable(2)]
		private FAkAudioSession _AudioSession;

		// Token: 0x04000A60 RID: 2656
		internal static int __PropertyOffset_CommunicationSettings;

		// Token: 0x04000A61 RID: 2657
		[Nullable(2)]
		private FAkCommunicationSettingsWithSystemInitialization _CommunicationSettings;

		// Token: 0x04000A62 RID: 2658
		internal static int __PropertyOffset_AdvancedSettings;

		// Token: 0x04000A63 RID: 2659
		[Nullable(2)]
		private FAkIOSAdvancedInitializationSettings _AdvancedSettings;
	}
}
