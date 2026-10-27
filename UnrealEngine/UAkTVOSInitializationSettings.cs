using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200024F RID: 591
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkTVOSInitializationSettings")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 304)]
	public class UAkTVOSInitializationSettings : UAkPlatformInitializationSettingsBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060022E4 RID: 8932 RVA: 0x00033A74 File Offset: 0x00031C74
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkTVOSInitializationSettings._ClassPtr;
		}

		// Token: 0x060022E5 RID: 8933 RVA: 0x00033A80 File Offset: 0x00031C80
		public UAkTVOSInitializationSettings() : this(BuiltinUtils.AllocNativeUObject(UAkTVOSInitializationSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060022E6 RID: 8934 RVA: 0x00033AA8 File Offset: 0x00031CA8
		public UAkTVOSInitializationSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkTVOSInitializationSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x060022E7 RID: 8935 RVA: 0x00033ADC File Offset: 0x00031CDC
		// (set) Token: 0x060022E8 RID: 8936 RVA: 0x00033B15 File Offset: 0x00031D15
		public FAkCommonInitializationSettingsWithSampleRate CommonSettings
		{
			get
			{
				base.FastCheckIsValid();
				FAkCommonInitializationSettingsWithSampleRate result;
				if ((result = this._CommonSettings) == null)
				{
					result = (this._CommonSettings = new FAkCommonInitializationSettingsWithSampleRate(base.NativePtr + (IntPtr)UAkTVOSInitializationSettings.__PropertyOffset_CommonSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkCommonInitializationSettingsWithSampleRate.StaticStruct(), base.NativePtr + (IntPtr)UAkTVOSInitializationSettings.__PropertyOffset_CommonSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x060022E9 RID: 8937 RVA: 0x00033B38 File Offset: 0x00031D38
		// (set) Token: 0x060022EA RID: 8938 RVA: 0x00033B71 File Offset: 0x00031D71
		public FAkAudioSession AudioSession
		{
			get
			{
				base.FastCheckIsValid();
				FAkAudioSession result;
				if ((result = this._AudioSession) == null)
				{
					result = (this._AudioSession = new FAkAudioSession(base.NativePtr + (IntPtr)UAkTVOSInitializationSettings.__PropertyOffset_AudioSession, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkAudioSession.StaticStruct(), base.NativePtr + (IntPtr)UAkTVOSInitializationSettings.__PropertyOffset_AudioSession, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x060022EB RID: 8939 RVA: 0x00033B94 File Offset: 0x00031D94
		// (set) Token: 0x060022EC RID: 8940 RVA: 0x00033BCD File Offset: 0x00031DCD
		public FAkCommunicationSettingsWithSystemInitialization CommunicationSettings
		{
			get
			{
				base.FastCheckIsValid();
				FAkCommunicationSettingsWithSystemInitialization result;
				if ((result = this._CommunicationSettings) == null)
				{
					result = (this._CommunicationSettings = new FAkCommunicationSettingsWithSystemInitialization(base.NativePtr + (IntPtr)UAkTVOSInitializationSettings.__PropertyOffset_CommunicationSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkCommunicationSettingsWithSystemInitialization.StaticStruct(), base.NativePtr + (IntPtr)UAkTVOSInitializationSettings.__PropertyOffset_CommunicationSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x060022ED RID: 8941 RVA: 0x00033BF0 File Offset: 0x00031DF0
		// (set) Token: 0x060022EE RID: 8942 RVA: 0x00033C29 File Offset: 0x00031E29
		public FAkTVOSAdvancedInitializationSettings AdvancedSettings
		{
			get
			{
				base.FastCheckIsValid();
				FAkTVOSAdvancedInitializationSettings result;
				if ((result = this._AdvancedSettings) == null)
				{
					result = (this._AdvancedSettings = new FAkTVOSAdvancedInitializationSettings(base.NativePtr + (IntPtr)UAkTVOSInitializationSettings.__PropertyOffset_AdvancedSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkTVOSAdvancedInitializationSettings.StaticStruct(), base.NativePtr + (IntPtr)UAkTVOSInitializationSettings.__PropertyOffset_AdvancedSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060022EF RID: 8943 RVA: 0x00033C4A File Offset: 0x00031E4A
		static UAkTVOSInitializationSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkTVOSInitializationSettings");
		}

		// Token: 0x060022F0 RID: 8944 RVA: 0x00033C58 File Offset: 0x00031E58
		protected UAkTVOSInitializationSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000C0F RID: 3087
		public new const string __ObjectPath = "/Script/AkAudio.AkTVOSInitializationSettings";

		// Token: 0x04000C10 RID: 3088
		private static IntPtr _ClassPtr;

		// Token: 0x04000C11 RID: 3089
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000C12 RID: 3090
		internal static int __PropertyOffset_CommonSettings;

		// Token: 0x04000C13 RID: 3091
		[Nullable(2)]
		private FAkCommonInitializationSettingsWithSampleRate _CommonSettings;

		// Token: 0x04000C14 RID: 3092
		internal static int __PropertyOffset_AudioSession;

		// Token: 0x04000C15 RID: 3093
		[Nullable(2)]
		private FAkAudioSession _AudioSession;

		// Token: 0x04000C16 RID: 3094
		internal static int __PropertyOffset_CommunicationSettings;

		// Token: 0x04000C17 RID: 3095
		[Nullable(2)]
		private FAkCommunicationSettingsWithSystemInitialization _CommunicationSettings;

		// Token: 0x04000C18 RID: 3096
		internal static int __PropertyOffset_AdvancedSettings;

		// Token: 0x04000C19 RID: 3097
		[Nullable(2)]
		private FAkTVOSAdvancedInitializationSettings _AdvancedSettings;
	}
}
