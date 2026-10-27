using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200025D RID: 605
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkWindowsInitializationSettings")]
	[UnrealStructLayout(288, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 288)]
	public class UAkWindowsInitializationSettings : UAkPlatformInitializationSettingsBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002379 RID: 9081 RVA: 0x000347E8 File Offset: 0x000329E8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkWindowsInitializationSettings._ClassPtr;
		}

		// Token: 0x0600237A RID: 9082 RVA: 0x000347F4 File Offset: 0x000329F4
		public UAkWindowsInitializationSettings() : this(BuiltinUtils.AllocNativeUObject(UAkWindowsInitializationSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600237B RID: 9083 RVA: 0x0003481C File Offset: 0x00032A1C
		public UAkWindowsInitializationSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkWindowsInitializationSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x0600237C RID: 9084 RVA: 0x00034850 File Offset: 0x00032A50
		// (set) Token: 0x0600237D RID: 9085 RVA: 0x00034889 File Offset: 0x00032A89
		public FAkCommonInitializationSettingsWithSampleRate CommonSettings
		{
			get
			{
				base.FastCheckIsValid();
				FAkCommonInitializationSettingsWithSampleRate result;
				if ((result = this._CommonSettings) == null)
				{
					result = (this._CommonSettings = new FAkCommonInitializationSettingsWithSampleRate(base.NativePtr + (IntPtr)UAkWindowsInitializationSettings.__PropertyOffset_CommonSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkCommonInitializationSettingsWithSampleRate.StaticStruct(), base.NativePtr + (IntPtr)UAkWindowsInitializationSettings.__PropertyOffset_CommonSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x0600237E RID: 9086 RVA: 0x000348AC File Offset: 0x00032AAC
		// (set) Token: 0x0600237F RID: 9087 RVA: 0x000348E5 File Offset: 0x00032AE5
		public FAkCommunicationSettingsWithSystemInitialization CommunicationSettings
		{
			get
			{
				base.FastCheckIsValid();
				FAkCommunicationSettingsWithSystemInitialization result;
				if ((result = this._CommunicationSettings) == null)
				{
					result = (this._CommunicationSettings = new FAkCommunicationSettingsWithSystemInitialization(base.NativePtr + (IntPtr)UAkWindowsInitializationSettings.__PropertyOffset_CommunicationSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkCommunicationSettingsWithSystemInitialization.StaticStruct(), base.NativePtr + (IntPtr)UAkWindowsInitializationSettings.__PropertyOffset_CommunicationSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x06002380 RID: 9088 RVA: 0x00034908 File Offset: 0x00032B08
		// (set) Token: 0x06002381 RID: 9089 RVA: 0x00034941 File Offset: 0x00032B41
		public FAkWindowsAdvancedInitializationSettings AdvancedSettings
		{
			get
			{
				base.FastCheckIsValid();
				FAkWindowsAdvancedInitializationSettings result;
				if ((result = this._AdvancedSettings) == null)
				{
					result = (this._AdvancedSettings = new FAkWindowsAdvancedInitializationSettings(base.NativePtr + (IntPtr)UAkWindowsInitializationSettings.__PropertyOffset_AdvancedSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkWindowsAdvancedInitializationSettings.StaticStruct(), base.NativePtr + (IntPtr)UAkWindowsInitializationSettings.__PropertyOffset_AdvancedSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06002382 RID: 9090 RVA: 0x00034962 File Offset: 0x00032B62
		public void MigrateMultiCoreRendering(bool NewValue)
		{
			UAkWindowsInitializationSettings.__MigrateMultiCoreRendering_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06002383 RID: 9091
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MigrateMultiCoreRendering_Internal(IntPtr @this, bool NewValue);

		// Token: 0x06002384 RID: 9092 RVA: 0x00034970 File Offset: 0x00032B70
		static UAkWindowsInitializationSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkWindowsInitializationSettings");
		}

		// Token: 0x06002385 RID: 9093 RVA: 0x0003497E File Offset: 0x00032B7E
		protected UAkWindowsInitializationSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000C40 RID: 3136
		public new const string __ObjectPath = "/Script/AkAudio.AkWindowsInitializationSettings";

		// Token: 0x04000C41 RID: 3137
		private static IntPtr _ClassPtr;

		// Token: 0x04000C42 RID: 3138
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000C43 RID: 3139
		internal static int __PropertyOffset_CommonSettings;

		// Token: 0x04000C44 RID: 3140
		[Nullable(2)]
		private FAkCommonInitializationSettingsWithSampleRate _CommonSettings;

		// Token: 0x04000C45 RID: 3141
		internal static int __PropertyOffset_CommunicationSettings;

		// Token: 0x04000C46 RID: 3142
		[Nullable(2)]
		private FAkCommunicationSettingsWithSystemInitialization _CommunicationSettings;

		// Token: 0x04000C47 RID: 3143
		internal static int __PropertyOffset_AdvancedSettings;

		// Token: 0x04000C48 RID: 3144
		[Nullable(2)]
		private FAkWindowsAdvancedInitializationSettings _AdvancedSettings;
	}
}
