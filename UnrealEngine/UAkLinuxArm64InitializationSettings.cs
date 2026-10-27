using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000216 RID: 534
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkLinuxArm64InitializationSettings")]
	[UnrealStructLayout(280, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 280)]
	public class UAkLinuxArm64InitializationSettings : UAkPlatformInitializationSettingsBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001FBC RID: 8124 RVA: 0x0002EF47 File Offset: 0x0002D147
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkLinuxArm64InitializationSettings._ClassPtr;
		}

		// Token: 0x06001FBD RID: 8125 RVA: 0x0002EF54 File Offset: 0x0002D154
		public UAkLinuxArm64InitializationSettings() : this(BuiltinUtils.AllocNativeUObject(UAkLinuxArm64InitializationSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001FBE RID: 8126 RVA: 0x0002EF7C File Offset: 0x0002D17C
		public UAkLinuxArm64InitializationSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkLinuxArm64InitializationSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x06001FBF RID: 8127 RVA: 0x0002EFB0 File Offset: 0x0002D1B0
		// (set) Token: 0x06001FC0 RID: 8128 RVA: 0x0002EFE9 File Offset: 0x0002D1E9
		public FAkCommonInitializationSettingsWithSampleRate CommonSettings
		{
			get
			{
				base.FastCheckIsValid();
				FAkCommonInitializationSettingsWithSampleRate result;
				if ((result = this._CommonSettings) == null)
				{
					result = (this._CommonSettings = new FAkCommonInitializationSettingsWithSampleRate(base.NativePtr + (IntPtr)UAkLinuxArm64InitializationSettings.__PropertyOffset_CommonSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkCommonInitializationSettingsWithSampleRate.StaticStruct(), base.NativePtr + (IntPtr)UAkLinuxArm64InitializationSettings.__PropertyOffset_CommonSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x06001FC1 RID: 8129 RVA: 0x0002F00C File Offset: 0x0002D20C
		// (set) Token: 0x06001FC2 RID: 8130 RVA: 0x0002F045 File Offset: 0x0002D245
		public FAkCommunicationSettingsWithSystemInitialization CommunicationSettings
		{
			get
			{
				base.FastCheckIsValid();
				FAkCommunicationSettingsWithSystemInitialization result;
				if ((result = this._CommunicationSettings) == null)
				{
					result = (this._CommunicationSettings = new FAkCommunicationSettingsWithSystemInitialization(base.NativePtr + (IntPtr)UAkLinuxArm64InitializationSettings.__PropertyOffset_CommunicationSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkCommunicationSettingsWithSystemInitialization.StaticStruct(), base.NativePtr + (IntPtr)UAkLinuxArm64InitializationSettings.__PropertyOffset_CommunicationSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x06001FC3 RID: 8131 RVA: 0x0002F068 File Offset: 0x0002D268
		// (set) Token: 0x06001FC4 RID: 8132 RVA: 0x0002F0A1 File Offset: 0x0002D2A1
		public FAkAdvancedInitializationSettingsWithMultiCoreRendering AdvancedSettings
		{
			get
			{
				base.FastCheckIsValid();
				FAkAdvancedInitializationSettingsWithMultiCoreRendering result;
				if ((result = this._AdvancedSettings) == null)
				{
					result = (this._AdvancedSettings = new FAkAdvancedInitializationSettingsWithMultiCoreRendering(base.NativePtr + (IntPtr)UAkLinuxArm64InitializationSettings.__PropertyOffset_AdvancedSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkAdvancedInitializationSettingsWithMultiCoreRendering.StaticStruct(), base.NativePtr + (IntPtr)UAkLinuxArm64InitializationSettings.__PropertyOffset_AdvancedSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06001FC5 RID: 8133 RVA: 0x0002F0C2 File Offset: 0x0002D2C2
		public void MigrateMultiCoreRendering(bool NewValue)
		{
			UAkLinuxArm64InitializationSettings.__MigrateMultiCoreRendering_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06001FC6 RID: 8134
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MigrateMultiCoreRendering_Internal(IntPtr @this, bool NewValue);

		// Token: 0x06001FC7 RID: 8135 RVA: 0x0002F0D0 File Offset: 0x0002D2D0
		static UAkLinuxArm64InitializationSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkLinuxArm64InitializationSettings");
		}

		// Token: 0x06001FC8 RID: 8136 RVA: 0x0002F0DE File Offset: 0x0002D2DE
		protected UAkLinuxArm64InitializationSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000A86 RID: 2694
		public new const string __ObjectPath = "/Script/AkAudio.AkLinuxArm64InitializationSettings";

		// Token: 0x04000A87 RID: 2695
		private static IntPtr _ClassPtr;

		// Token: 0x04000A88 RID: 2696
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000A89 RID: 2697
		internal static int __PropertyOffset_CommonSettings;

		// Token: 0x04000A8A RID: 2698
		[Nullable(2)]
		private FAkCommonInitializationSettingsWithSampleRate _CommonSettings;

		// Token: 0x04000A8B RID: 2699
		internal static int __PropertyOffset_CommunicationSettings;

		// Token: 0x04000A8C RID: 2700
		[Nullable(2)]
		private FAkCommunicationSettingsWithSystemInitialization _CommunicationSettings;

		// Token: 0x04000A8D RID: 2701
		internal static int __PropertyOffset_AdvancedSettings;

		// Token: 0x04000A8E RID: 2702
		[Nullable(2)]
		private FAkAdvancedInitializationSettingsWithMultiCoreRendering _AdvancedSettings;
	}
}
