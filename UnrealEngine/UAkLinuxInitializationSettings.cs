using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000218 RID: 536
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkLinuxInitializationSettings")]
	[UnrealStructLayout(280, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 280)]
	public class UAkLinuxInitializationSettings : UAkPlatformInitializationSettingsBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001FCE RID: 8142 RVA: 0x0002F166 File Offset: 0x0002D366
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkLinuxInitializationSettings._ClassPtr;
		}

		// Token: 0x06001FCF RID: 8143 RVA: 0x0002F174 File Offset: 0x0002D374
		public UAkLinuxInitializationSettings() : this(BuiltinUtils.AllocNativeUObject(UAkLinuxInitializationSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001FD0 RID: 8144 RVA: 0x0002F19C File Offset: 0x0002D39C
		public UAkLinuxInitializationSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkLinuxInitializationSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x06001FD1 RID: 8145 RVA: 0x0002F1D0 File Offset: 0x0002D3D0
		// (set) Token: 0x06001FD2 RID: 8146 RVA: 0x0002F209 File Offset: 0x0002D409
		public FAkCommonInitializationSettingsWithSampleRate CommonSettings
		{
			get
			{
				base.FastCheckIsValid();
				FAkCommonInitializationSettingsWithSampleRate result;
				if ((result = this._CommonSettings) == null)
				{
					result = (this._CommonSettings = new FAkCommonInitializationSettingsWithSampleRate(base.NativePtr + (IntPtr)UAkLinuxInitializationSettings.__PropertyOffset_CommonSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkCommonInitializationSettingsWithSampleRate.StaticStruct(), base.NativePtr + (IntPtr)UAkLinuxInitializationSettings.__PropertyOffset_CommonSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x06001FD3 RID: 8147 RVA: 0x0002F22C File Offset: 0x0002D42C
		// (set) Token: 0x06001FD4 RID: 8148 RVA: 0x0002F265 File Offset: 0x0002D465
		public FAkCommunicationSettingsWithSystemInitialization CommunicationSettings
		{
			get
			{
				base.FastCheckIsValid();
				FAkCommunicationSettingsWithSystemInitialization result;
				if ((result = this._CommunicationSettings) == null)
				{
					result = (this._CommunicationSettings = new FAkCommunicationSettingsWithSystemInitialization(base.NativePtr + (IntPtr)UAkLinuxInitializationSettings.__PropertyOffset_CommunicationSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkCommunicationSettingsWithSystemInitialization.StaticStruct(), base.NativePtr + (IntPtr)UAkLinuxInitializationSettings.__PropertyOffset_CommunicationSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x06001FD5 RID: 8149 RVA: 0x0002F288 File Offset: 0x0002D488
		// (set) Token: 0x06001FD6 RID: 8150 RVA: 0x0002F2C1 File Offset: 0x0002D4C1
		public FAkAdvancedInitializationSettingsWithMultiCoreRendering AdvancedSettings
		{
			get
			{
				base.FastCheckIsValid();
				FAkAdvancedInitializationSettingsWithMultiCoreRendering result;
				if ((result = this._AdvancedSettings) == null)
				{
					result = (this._AdvancedSettings = new FAkAdvancedInitializationSettingsWithMultiCoreRendering(base.NativePtr + (IntPtr)UAkLinuxInitializationSettings.__PropertyOffset_AdvancedSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkAdvancedInitializationSettingsWithMultiCoreRendering.StaticStruct(), base.NativePtr + (IntPtr)UAkLinuxInitializationSettings.__PropertyOffset_AdvancedSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06001FD7 RID: 8151 RVA: 0x0002F2E2 File Offset: 0x0002D4E2
		public void MigrateMultiCoreRendering(bool NewValue)
		{
			UAkLinuxInitializationSettings.__MigrateMultiCoreRendering_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06001FD8 RID: 8152
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MigrateMultiCoreRendering_Internal(IntPtr @this, bool NewValue);

		// Token: 0x06001FD9 RID: 8153 RVA: 0x0002F2F0 File Offset: 0x0002D4F0
		static UAkLinuxInitializationSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkLinuxInitializationSettings");
		}

		// Token: 0x06001FDA RID: 8154 RVA: 0x0002F2FE File Offset: 0x0002D4FE
		protected UAkLinuxInitializationSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000A92 RID: 2706
		public new const string __ObjectPath = "/Script/AkAudio.AkLinuxInitializationSettings";

		// Token: 0x04000A93 RID: 2707
		private static IntPtr _ClassPtr;

		// Token: 0x04000A94 RID: 2708
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000A95 RID: 2709
		internal static int __PropertyOffset_CommonSettings;

		// Token: 0x04000A96 RID: 2710
		[Nullable(2)]
		private FAkCommonInitializationSettingsWithSampleRate _CommonSettings;

		// Token: 0x04000A97 RID: 2711
		internal static int __PropertyOffset_CommunicationSettings;

		// Token: 0x04000A98 RID: 2712
		[Nullable(2)]
		private FAkCommunicationSettingsWithSystemInitialization _CommunicationSettings;

		// Token: 0x04000A99 RID: 2713
		internal static int __PropertyOffset_AdvancedSettings;

		// Token: 0x04000A9A RID: 2714
		[Nullable(2)]
		private FAkAdvancedInitializationSettingsWithMultiCoreRendering _AdvancedSettings;
	}
}
