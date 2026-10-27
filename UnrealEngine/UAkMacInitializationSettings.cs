using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200021C RID: 540
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkMacInitializationSettings")]
	[UnrealStructLayout(288, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 288)]
	public class UAkMacInitializationSettings : UAkPlatformInitializationSettingsBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001FF1 RID: 8177 RVA: 0x0002F580 File Offset: 0x0002D780
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkMacInitializationSettings._ClassPtr;
		}

		// Token: 0x06001FF2 RID: 8178 RVA: 0x0002F58C File Offset: 0x0002D78C
		public UAkMacInitializationSettings() : this(BuiltinUtils.AllocNativeUObject(UAkMacInitializationSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001FF3 RID: 8179 RVA: 0x0002F5B4 File Offset: 0x0002D7B4
		public UAkMacInitializationSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkMacInitializationSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x06001FF4 RID: 8180 RVA: 0x0002F5E8 File Offset: 0x0002D7E8
		// (set) Token: 0x06001FF5 RID: 8181 RVA: 0x0002F621 File Offset: 0x0002D821
		public FAkCommonInitializationSettingsWithSampleRate CommonSettings
		{
			get
			{
				base.FastCheckIsValid();
				FAkCommonInitializationSettingsWithSampleRate result;
				if ((result = this._CommonSettings) == null)
				{
					result = (this._CommonSettings = new FAkCommonInitializationSettingsWithSampleRate(base.NativePtr + (IntPtr)UAkMacInitializationSettings.__PropertyOffset_CommonSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkCommonInitializationSettingsWithSampleRate.StaticStruct(), base.NativePtr + (IntPtr)UAkMacInitializationSettings.__PropertyOffset_CommonSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x06001FF6 RID: 8182 RVA: 0x0002F644 File Offset: 0x0002D844
		// (set) Token: 0x06001FF7 RID: 8183 RVA: 0x0002F67D File Offset: 0x0002D87D
		public FAkCommunicationSettingsWithSystemInitialization CommunicationSettings
		{
			get
			{
				base.FastCheckIsValid();
				FAkCommunicationSettingsWithSystemInitialization result;
				if ((result = this._CommunicationSettings) == null)
				{
					result = (this._CommunicationSettings = new FAkCommunicationSettingsWithSystemInitialization(base.NativePtr + (IntPtr)UAkMacInitializationSettings.__PropertyOffset_CommunicationSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkCommunicationSettingsWithSystemInitialization.StaticStruct(), base.NativePtr + (IntPtr)UAkMacInitializationSettings.__PropertyOffset_CommunicationSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x06001FF8 RID: 8184 RVA: 0x0002F6A0 File Offset: 0x0002D8A0
		// (set) Token: 0x06001FF9 RID: 8185 RVA: 0x0002F6D9 File Offset: 0x0002D8D9
		public FAkMacAdvancedInitializationSettings AdvancedSettings
		{
			get
			{
				base.FastCheckIsValid();
				FAkMacAdvancedInitializationSettings result;
				if ((result = this._AdvancedSettings) == null)
				{
					result = (this._AdvancedSettings = new FAkMacAdvancedInitializationSettings(base.NativePtr + (IntPtr)UAkMacInitializationSettings.__PropertyOffset_AdvancedSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkMacAdvancedInitializationSettings.StaticStruct(), base.NativePtr + (IntPtr)UAkMacInitializationSettings.__PropertyOffset_AdvancedSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06001FFA RID: 8186 RVA: 0x0002F6FA File Offset: 0x0002D8FA
		public void MigrateMultiCoreRendering(bool NewValue)
		{
			UAkMacInitializationSettings.__MigrateMultiCoreRendering_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06001FFB RID: 8187
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MigrateMultiCoreRendering_Internal(IntPtr @this, bool NewValue);

		// Token: 0x06001FFC RID: 8188 RVA: 0x0002F708 File Offset: 0x0002D908
		static UAkMacInitializationSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkMacInitializationSettings");
		}

		// Token: 0x06001FFD RID: 8189 RVA: 0x0002F716 File Offset: 0x0002D916
		protected UAkMacInitializationSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000AA5 RID: 2725
		public new const string __ObjectPath = "/Script/AkAudio.AkMacInitializationSettings";

		// Token: 0x04000AA6 RID: 2726
		private static IntPtr _ClassPtr;

		// Token: 0x04000AA7 RID: 2727
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000AA8 RID: 2728
		internal static int __PropertyOffset_CommonSettings;

		// Token: 0x04000AA9 RID: 2729
		[Nullable(2)]
		private FAkCommonInitializationSettingsWithSampleRate _CommonSettings;

		// Token: 0x04000AAA RID: 2730
		internal static int __PropertyOffset_CommunicationSettings;

		// Token: 0x04000AAB RID: 2731
		[Nullable(2)]
		private FAkCommunicationSettingsWithSystemInitialization _CommunicationSettings;

		// Token: 0x04000AAC RID: 2732
		internal static int __PropertyOffset_AdvancedSettings;

		// Token: 0x04000AAD RID: 2733
		[Nullable(2)]
		private FAkMacAdvancedInitializationSettings _AdvancedSettings;
	}
}
