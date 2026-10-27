using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000230 RID: 560
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkOpenHarmonyInitializationSettings")]
	[UnrealStructLayout(288, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 288)]
	public class UAkOpenHarmonyInitializationSettings : UAkPlatformInitializationSettingsBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060020CD RID: 8397 RVA: 0x00030C90 File Offset: 0x0002EE90
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkOpenHarmonyInitializationSettings._ClassPtr;
		}

		// Token: 0x060020CE RID: 8398 RVA: 0x00030C9C File Offset: 0x0002EE9C
		public UAkOpenHarmonyInitializationSettings() : this(BuiltinUtils.AllocNativeUObject(UAkOpenHarmonyInitializationSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060020CF RID: 8399 RVA: 0x00030CC4 File Offset: 0x0002EEC4
		public UAkOpenHarmonyInitializationSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkOpenHarmonyInitializationSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x060020D0 RID: 8400 RVA: 0x00030CF8 File Offset: 0x0002EEF8
		// (set) Token: 0x060020D1 RID: 8401 RVA: 0x00030D31 File Offset: 0x0002EF31
		public FAkCommonInitializationSettingsWithSampleRate CommonSettings
		{
			get
			{
				base.FastCheckIsValid();
				FAkCommonInitializationSettingsWithSampleRate result;
				if ((result = this._CommonSettings) == null)
				{
					result = (this._CommonSettings = new FAkCommonInitializationSettingsWithSampleRate(base.NativePtr + (IntPtr)UAkOpenHarmonyInitializationSettings.__PropertyOffset_CommonSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkCommonInitializationSettingsWithSampleRate.StaticStruct(), base.NativePtr + (IntPtr)UAkOpenHarmonyInitializationSettings.__PropertyOffset_CommonSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x060020D2 RID: 8402 RVA: 0x00030D54 File Offset: 0x0002EF54
		// (set) Token: 0x060020D3 RID: 8403 RVA: 0x00030D8D File Offset: 0x0002EF8D
		public FAkCommunicationSettingsWithSystemInitialization CommunicationSettings
		{
			get
			{
				base.FastCheckIsValid();
				FAkCommunicationSettingsWithSystemInitialization result;
				if ((result = this._CommunicationSettings) == null)
				{
					result = (this._CommunicationSettings = new FAkCommunicationSettingsWithSystemInitialization(base.NativePtr + (IntPtr)UAkOpenHarmonyInitializationSettings.__PropertyOffset_CommunicationSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkCommunicationSettingsWithSystemInitialization.StaticStruct(), base.NativePtr + (IntPtr)UAkOpenHarmonyInitializationSettings.__PropertyOffset_CommunicationSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x060020D4 RID: 8404 RVA: 0x00030DB0 File Offset: 0x0002EFB0
		// (set) Token: 0x060020D5 RID: 8405 RVA: 0x00030DE9 File Offset: 0x0002EFE9
		public FAkOpenHarmonyAdvancedInitializationSettings AdvancedSettings
		{
			get
			{
				base.FastCheckIsValid();
				FAkOpenHarmonyAdvancedInitializationSettings result;
				if ((result = this._AdvancedSettings) == null)
				{
					result = (this._AdvancedSettings = new FAkOpenHarmonyAdvancedInitializationSettings(base.NativePtr + (IntPtr)UAkOpenHarmonyInitializationSettings.__PropertyOffset_AdvancedSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkOpenHarmonyAdvancedInitializationSettings.StaticStruct(), base.NativePtr + (IntPtr)UAkOpenHarmonyInitializationSettings.__PropertyOffset_AdvancedSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060020D6 RID: 8406 RVA: 0x00030E0A File Offset: 0x0002F00A
		public void MigrateMultiCoreRendering(bool NewValue)
		{
			UAkOpenHarmonyInitializationSettings.__MigrateMultiCoreRendering_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x060020D7 RID: 8407
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MigrateMultiCoreRendering_Internal(IntPtr @this, bool NewValue);

		// Token: 0x060020D8 RID: 8408 RVA: 0x00030E18 File Offset: 0x0002F018
		static UAkOpenHarmonyInitializationSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkOpenHarmonyInitializationSettings");
		}

		// Token: 0x060020D9 RID: 8409 RVA: 0x00030E26 File Offset: 0x0002F026
		protected UAkOpenHarmonyInitializationSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000B08 RID: 2824
		public new const string __ObjectPath = "/Script/AkAudio.AkOpenHarmonyInitializationSettings";

		// Token: 0x04000B09 RID: 2825
		private static IntPtr _ClassPtr;

		// Token: 0x04000B0A RID: 2826
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000B0B RID: 2827
		internal static int __PropertyOffset_CommonSettings;

		// Token: 0x04000B0C RID: 2828
		[Nullable(2)]
		private FAkCommonInitializationSettingsWithSampleRate _CommonSettings;

		// Token: 0x04000B0D RID: 2829
		internal static int __PropertyOffset_CommunicationSettings;

		// Token: 0x04000B0E RID: 2830
		[Nullable(2)]
		private FAkCommunicationSettingsWithSystemInitialization _CommunicationSettings;

		// Token: 0x04000B0F RID: 2831
		internal static int __PropertyOffset_AdvancedSettings;

		// Token: 0x04000B10 RID: 2832
		[Nullable(2)]
		private FAkOpenHarmonyAdvancedInitializationSettings _AdvancedSettings;
	}
}
