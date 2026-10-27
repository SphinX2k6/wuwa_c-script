using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000260 RID: 608
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkWinGDKInitializationSettings")]
	[UnrealStructLayout(288, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 288)]
	public class UAkWinGDKInitializationSettings : UAkPlatformInitializationSettingsBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002397 RID: 9111 RVA: 0x00034B80 File Offset: 0x00032D80
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkWinGDKInitializationSettings._ClassPtr;
		}

		// Token: 0x06002398 RID: 9112 RVA: 0x00034B8C File Offset: 0x00032D8C
		public UAkWinGDKInitializationSettings() : this(BuiltinUtils.AllocNativeUObject(UAkWinGDKInitializationSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002399 RID: 9113 RVA: 0x00034BB4 File Offset: 0x00032DB4
		public UAkWinGDKInitializationSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkWinGDKInitializationSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x0600239A RID: 9114 RVA: 0x00034BE8 File Offset: 0x00032DE8
		// (set) Token: 0x0600239B RID: 9115 RVA: 0x00034C21 File Offset: 0x00032E21
		public FAkCommonInitializationSettingsWithSampleRate CommonSettings
		{
			get
			{
				base.FastCheckIsValid();
				FAkCommonInitializationSettingsWithSampleRate result;
				if ((result = this._CommonSettings) == null)
				{
					result = (this._CommonSettings = new FAkCommonInitializationSettingsWithSampleRate(base.NativePtr + (IntPtr)UAkWinGDKInitializationSettings.__PropertyOffset_CommonSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkCommonInitializationSettingsWithSampleRate.StaticStruct(), base.NativePtr + (IntPtr)UAkWinGDKInitializationSettings.__PropertyOffset_CommonSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x0600239C RID: 9116 RVA: 0x00034C44 File Offset: 0x00032E44
		// (set) Token: 0x0600239D RID: 9117 RVA: 0x00034C7D File Offset: 0x00032E7D
		public FAkCommunicationSettingsWithSystemInitialization CommunicationSettings
		{
			get
			{
				base.FastCheckIsValid();
				FAkCommunicationSettingsWithSystemInitialization result;
				if ((result = this._CommunicationSettings) == null)
				{
					result = (this._CommunicationSettings = new FAkCommunicationSettingsWithSystemInitialization(base.NativePtr + (IntPtr)UAkWinGDKInitializationSettings.__PropertyOffset_CommunicationSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkCommunicationSettingsWithSystemInitialization.StaticStruct(), base.NativePtr + (IntPtr)UAkWinGDKInitializationSettings.__PropertyOffset_CommunicationSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x0600239E RID: 9118 RVA: 0x00034CA0 File Offset: 0x00032EA0
		// (set) Token: 0x0600239F RID: 9119 RVA: 0x00034CD9 File Offset: 0x00032ED9
		public FAkWinGDKAdvancedInitializationSettings AdvancedSettings
		{
			get
			{
				base.FastCheckIsValid();
				FAkWinGDKAdvancedInitializationSettings result;
				if ((result = this._AdvancedSettings) == null)
				{
					result = (this._AdvancedSettings = new FAkWinGDKAdvancedInitializationSettings(base.NativePtr + (IntPtr)UAkWinGDKInitializationSettings.__PropertyOffset_AdvancedSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkWinGDKAdvancedInitializationSettings.StaticStruct(), base.NativePtr + (IntPtr)UAkWinGDKInitializationSettings.__PropertyOffset_AdvancedSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060023A0 RID: 9120 RVA: 0x00034CFA File Offset: 0x00032EFA
		public void MigrateMultiCoreRendering(bool NewValue)
		{
			UAkWinGDKInitializationSettings.__MigrateMultiCoreRendering_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x060023A1 RID: 9121
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MigrateMultiCoreRendering_Internal(IntPtr @this, bool NewValue);

		// Token: 0x060023A2 RID: 9122 RVA: 0x00034D08 File Offset: 0x00032F08
		static UAkWinGDKInitializationSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkWinGDKInitializationSettings");
		}

		// Token: 0x060023A3 RID: 9123 RVA: 0x00034D16 File Offset: 0x00032F16
		protected UAkWinGDKInitializationSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000C50 RID: 3152
		public new const string __ObjectPath = "/Script/AkAudio.AkWinGDKInitializationSettings";

		// Token: 0x04000C51 RID: 3153
		private static IntPtr _ClassPtr;

		// Token: 0x04000C52 RID: 3154
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000C53 RID: 3155
		internal static int __PropertyOffset_CommonSettings;

		// Token: 0x04000C54 RID: 3156
		[Nullable(2)]
		private FAkCommonInitializationSettingsWithSampleRate _CommonSettings;

		// Token: 0x04000C55 RID: 3157
		internal static int __PropertyOffset_CommunicationSettings;

		// Token: 0x04000C56 RID: 3158
		[Nullable(2)]
		private FAkCommunicationSettingsWithSystemInitialization _CommunicationSettings;

		// Token: 0x04000C57 RID: 3159
		internal static int __PropertyOffset_AdvancedSettings;

		// Token: 0x04000C58 RID: 3160
		[Nullable(2)]
		private FAkWinGDKAdvancedInitializationSettings _AdvancedSettings;
	}
}
