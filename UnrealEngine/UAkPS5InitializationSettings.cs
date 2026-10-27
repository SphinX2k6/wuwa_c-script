using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000238 RID: 568
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkPS5InitializationSettings")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 296)]
	public class UAkPS5InitializationSettings : UAkPlatformInitializationSettingsBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600212F RID: 8495 RVA: 0x000314BC File Offset: 0x0002F6BC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkPS5InitializationSettings._ClassPtr;
		}

		// Token: 0x06002130 RID: 8496 RVA: 0x000314C8 File Offset: 0x0002F6C8
		public UAkPS5InitializationSettings() : this(BuiltinUtils.AllocNativeUObject(UAkPS5InitializationSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002131 RID: 8497 RVA: 0x000314F0 File Offset: 0x0002F6F0
		public UAkPS5InitializationSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkPS5InitializationSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x06002132 RID: 8498 RVA: 0x00031524 File Offset: 0x0002F724
		// (set) Token: 0x06002133 RID: 8499 RVA: 0x0003155D File Offset: 0x0002F75D
		public FAkCommonInitializationSettings CommonSettings
		{
			get
			{
				base.FastCheckIsValid();
				FAkCommonInitializationSettings result;
				if ((result = this._CommonSettings) == null)
				{
					result = (this._CommonSettings = new FAkCommonInitializationSettings(base.NativePtr + (IntPtr)UAkPS5InitializationSettings.__PropertyOffset_CommonSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkCommonInitializationSettings.StaticStruct(), base.NativePtr + (IntPtr)UAkPS5InitializationSettings.__PropertyOffset_CommonSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x06002134 RID: 8500 RVA: 0x00031580 File Offset: 0x0002F780
		// (set) Token: 0x06002135 RID: 8501 RVA: 0x000315B9 File Offset: 0x0002F7B9
		public FAkCommunicationSettingsWithSystemInitialization CommunicationSettings
		{
			get
			{
				base.FastCheckIsValid();
				FAkCommunicationSettingsWithSystemInitialization result;
				if ((result = this._CommunicationSettings) == null)
				{
					result = (this._CommunicationSettings = new FAkCommunicationSettingsWithSystemInitialization(base.NativePtr + (IntPtr)UAkPS5InitializationSettings.__PropertyOffset_CommunicationSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkCommunicationSettingsWithSystemInitialization.StaticStruct(), base.NativePtr + (IntPtr)UAkPS5InitializationSettings.__PropertyOffset_CommunicationSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x06002136 RID: 8502 RVA: 0x000315DC File Offset: 0x0002F7DC
		// (set) Token: 0x06002137 RID: 8503 RVA: 0x00031615 File Offset: 0x0002F815
		public FAkPS5AdvancedInitializationSettings AdvancedSettings
		{
			get
			{
				base.FastCheckIsValid();
				FAkPS5AdvancedInitializationSettings result;
				if ((result = this._AdvancedSettings) == null)
				{
					result = (this._AdvancedSettings = new FAkPS5AdvancedInitializationSettings(base.NativePtr + (IntPtr)UAkPS5InitializationSettings.__PropertyOffset_AdvancedSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkPS5AdvancedInitializationSettings.StaticStruct(), base.NativePtr + (IntPtr)UAkPS5InitializationSettings.__PropertyOffset_AdvancedSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06002138 RID: 8504 RVA: 0x00031636 File Offset: 0x0002F836
		static UAkPS5InitializationSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkPS5InitializationSettings");
		}

		// Token: 0x06002139 RID: 8505 RVA: 0x00031644 File Offset: 0x0002F844
		protected UAkPS5InitializationSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000B33 RID: 2867
		public new const string __ObjectPath = "/Script/AkAudio.AkPS5InitializationSettings";

		// Token: 0x04000B34 RID: 2868
		private static IntPtr _ClassPtr;

		// Token: 0x04000B35 RID: 2869
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000B36 RID: 2870
		internal static int __PropertyOffset_CommonSettings;

		// Token: 0x04000B37 RID: 2871
		[Nullable(2)]
		private FAkCommonInitializationSettings _CommonSettings;

		// Token: 0x04000B38 RID: 2872
		internal static int __PropertyOffset_CommunicationSettings;

		// Token: 0x04000B39 RID: 2873
		[Nullable(2)]
		private FAkCommunicationSettingsWithSystemInitialization _CommunicationSettings;

		// Token: 0x04000B3A RID: 2874
		internal static int __PropertyOffset_AdvancedSettings;

		// Token: 0x04000B3B RID: 2875
		[Nullable(2)]
		private FAkPS5AdvancedInitializationSettings _AdvancedSettings;
	}
}
