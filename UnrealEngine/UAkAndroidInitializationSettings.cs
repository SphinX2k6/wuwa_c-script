using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001EB RID: 491
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkAndroidInitializationSettings")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 296)]
	public class UAkAndroidInitializationSettings : UAkPlatformInitializationSettingsBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001D03 RID: 7427 RVA: 0x0002B348 File Offset: 0x00029548
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkAndroidInitializationSettings._ClassPtr;
		}

		// Token: 0x06001D04 RID: 7428 RVA: 0x0002B354 File Offset: 0x00029554
		public UAkAndroidInitializationSettings() : this(BuiltinUtils.AllocNativeUObject(UAkAndroidInitializationSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001D05 RID: 7429 RVA: 0x0002B37C File Offset: 0x0002957C
		public UAkAndroidInitializationSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkAndroidInitializationSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x06001D06 RID: 7430 RVA: 0x0002B3B0 File Offset: 0x000295B0
		// (set) Token: 0x06001D07 RID: 7431 RVA: 0x0002B3E9 File Offset: 0x000295E9
		public FAkCommonInitializationSettingsWithSampleRate CommonSettings
		{
			get
			{
				base.FastCheckIsValid();
				FAkCommonInitializationSettingsWithSampleRate result;
				if ((result = this._CommonSettings) == null)
				{
					result = (this._CommonSettings = new FAkCommonInitializationSettingsWithSampleRate(base.NativePtr + (IntPtr)UAkAndroidInitializationSettings.__PropertyOffset_CommonSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkCommonInitializationSettingsWithSampleRate.StaticStruct(), base.NativePtr + (IntPtr)UAkAndroidInitializationSettings.__PropertyOffset_CommonSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x06001D08 RID: 7432 RVA: 0x0002B40C File Offset: 0x0002960C
		// (set) Token: 0x06001D09 RID: 7433 RVA: 0x0002B445 File Offset: 0x00029645
		public FAkCommunicationSettingsWithSystemInitialization CommunicationSettings
		{
			get
			{
				base.FastCheckIsValid();
				FAkCommunicationSettingsWithSystemInitialization result;
				if ((result = this._CommunicationSettings) == null)
				{
					result = (this._CommunicationSettings = new FAkCommunicationSettingsWithSystemInitialization(base.NativePtr + (IntPtr)UAkAndroidInitializationSettings.__PropertyOffset_CommunicationSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkCommunicationSettingsWithSystemInitialization.StaticStruct(), base.NativePtr + (IntPtr)UAkAndroidInitializationSettings.__PropertyOffset_CommunicationSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x06001D0A RID: 7434 RVA: 0x0002B468 File Offset: 0x00029668
		// (set) Token: 0x06001D0B RID: 7435 RVA: 0x0002B4A1 File Offset: 0x000296A1
		public FAkAndroidAdvancedInitializationSettings AdvancedSettings
		{
			get
			{
				base.FastCheckIsValid();
				FAkAndroidAdvancedInitializationSettings result;
				if ((result = this._AdvancedSettings) == null)
				{
					result = (this._AdvancedSettings = new FAkAndroidAdvancedInitializationSettings(base.NativePtr + (IntPtr)UAkAndroidInitializationSettings.__PropertyOffset_AdvancedSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkAndroidAdvancedInitializationSettings.StaticStruct(), base.NativePtr + (IntPtr)UAkAndroidInitializationSettings.__PropertyOffset_AdvancedSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06001D0C RID: 7436 RVA: 0x0002B4C2 File Offset: 0x000296C2
		public void MigrateMultiCoreRendering(bool NewValue)
		{
			UAkAndroidInitializationSettings.__MigrateMultiCoreRendering_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06001D0D RID: 7437
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MigrateMultiCoreRendering_Internal(IntPtr @this, bool NewValue);

		// Token: 0x06001D0E RID: 7438 RVA: 0x0002B4D0 File Offset: 0x000296D0
		static UAkAndroidInitializationSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkAndroidInitializationSettings");
		}

		// Token: 0x06001D0F RID: 7439 RVA: 0x0002B4DE File Offset: 0x000296DE
		protected UAkAndroidInitializationSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000983 RID: 2435
		public new const string __ObjectPath = "/Script/AkAudio.AkAndroidInitializationSettings";

		// Token: 0x04000984 RID: 2436
		private static IntPtr _ClassPtr;

		// Token: 0x04000985 RID: 2437
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000986 RID: 2438
		internal static int __PropertyOffset_CommonSettings;

		// Token: 0x04000987 RID: 2439
		[Nullable(2)]
		private FAkCommonInitializationSettingsWithSampleRate _CommonSettings;

		// Token: 0x04000988 RID: 2440
		internal static int __PropertyOffset_CommunicationSettings;

		// Token: 0x04000989 RID: 2441
		[Nullable(2)]
		private FAkCommunicationSettingsWithSystemInitialization _CommunicationSettings;

		// Token: 0x0400098A RID: 2442
		internal static int __PropertyOffset_AdvancedSettings;

		// Token: 0x0400098B RID: 2443
		[Nullable(2)]
		private FAkAndroidAdvancedInitializationSettings _AdvancedSettings;
	}
}
