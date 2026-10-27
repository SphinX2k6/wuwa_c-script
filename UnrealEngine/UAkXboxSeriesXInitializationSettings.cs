using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000266 RID: 614
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkXboxSeriesXInitializationSettings")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 296)]
	public class UAkXboxSeriesXInitializationSettings : UAkPlatformInitializationSettingsBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060023DB RID: 9179 RVA: 0x00035259 File Offset: 0x00033459
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkXboxSeriesXInitializationSettings._ClassPtr;
		}

		// Token: 0x060023DC RID: 9180 RVA: 0x00035268 File Offset: 0x00033468
		public UAkXboxSeriesXInitializationSettings() : this(BuiltinUtils.AllocNativeUObject(UAkXboxSeriesXInitializationSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060023DD RID: 9181 RVA: 0x00035290 File Offset: 0x00033490
		public UAkXboxSeriesXInitializationSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkXboxSeriesXInitializationSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x060023DE RID: 9182 RVA: 0x000352C4 File Offset: 0x000334C4
		// (set) Token: 0x060023DF RID: 9183 RVA: 0x000352FD File Offset: 0x000334FD
		public FAkCommonInitializationSettings CommonSettings
		{
			get
			{
				base.FastCheckIsValid();
				FAkCommonInitializationSettings result;
				if ((result = this._CommonSettings) == null)
				{
					result = (this._CommonSettings = new FAkCommonInitializationSettings(base.NativePtr + (IntPtr)UAkXboxSeriesXInitializationSettings.__PropertyOffset_CommonSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkCommonInitializationSettings.StaticStruct(), base.NativePtr + (IntPtr)UAkXboxSeriesXInitializationSettings.__PropertyOffset_CommonSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x060023E0 RID: 9184 RVA: 0x00035320 File Offset: 0x00033520
		// (set) Token: 0x060023E1 RID: 9185 RVA: 0x00035359 File Offset: 0x00033559
		public FAkCommunicationSettingsWithSystemInitialization CommunicationSettings
		{
			get
			{
				base.FastCheckIsValid();
				FAkCommunicationSettingsWithSystemInitialization result;
				if ((result = this._CommunicationSettings) == null)
				{
					result = (this._CommunicationSettings = new FAkCommunicationSettingsWithSystemInitialization(base.NativePtr + (IntPtr)UAkXboxSeriesXInitializationSettings.__PropertyOffset_CommunicationSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkCommunicationSettingsWithSystemInitialization.StaticStruct(), base.NativePtr + (IntPtr)UAkXboxSeriesXInitializationSettings.__PropertyOffset_CommunicationSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x060023E2 RID: 9186 RVA: 0x0003537C File Offset: 0x0003357C
		// (set) Token: 0x060023E3 RID: 9187 RVA: 0x000353B5 File Offset: 0x000335B5
		public FAkXSXAdvancedInitializationSettings AdvancedSettings
		{
			get
			{
				base.FastCheckIsValid();
				FAkXSXAdvancedInitializationSettings result;
				if ((result = this._AdvancedSettings) == null)
				{
					result = (this._AdvancedSettings = new FAkXSXAdvancedInitializationSettings(base.NativePtr + (IntPtr)UAkXboxSeriesXInitializationSettings.__PropertyOffset_AdvancedSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkXSXAdvancedInitializationSettings.StaticStruct(), base.NativePtr + (IntPtr)UAkXboxSeriesXInitializationSettings.__PropertyOffset_AdvancedSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060023E4 RID: 9188 RVA: 0x000353D6 File Offset: 0x000335D6
		public void MigrateMultiCoreRendering(bool NewValue)
		{
			UAkXboxSeriesXInitializationSettings.__MigrateMultiCoreRendering_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x060023E5 RID: 9189
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MigrateMultiCoreRendering_Internal(IntPtr @this, bool NewValue);

		// Token: 0x060023E6 RID: 9190 RVA: 0x000353E4 File Offset: 0x000335E4
		static UAkXboxSeriesXInitializationSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkXboxSeriesXInitializationSettings");
		}

		// Token: 0x060023E7 RID: 9191 RVA: 0x000353F2 File Offset: 0x000335F2
		protected UAkXboxSeriesXInitializationSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000C74 RID: 3188
		public new const string __ObjectPath = "/Script/AkAudio.AkXboxSeriesXInitializationSettings";

		// Token: 0x04000C75 RID: 3189
		private static IntPtr _ClassPtr;

		// Token: 0x04000C76 RID: 3190
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000C77 RID: 3191
		internal static int __PropertyOffset_CommonSettings;

		// Token: 0x04000C78 RID: 3192
		[Nullable(2)]
		private FAkCommonInitializationSettings _CommonSettings;

		// Token: 0x04000C79 RID: 3193
		internal static int __PropertyOffset_CommunicationSettings;

		// Token: 0x04000C7A RID: 3194
		[Nullable(2)]
		private FAkCommunicationSettingsWithSystemInitialization _CommunicationSettings;

		// Token: 0x04000C7B RID: 3195
		internal static int __PropertyOffset_AdvancedSettings;

		// Token: 0x04000C7C RID: 3196
		[Nullable(2)]
		private FAkXSXAdvancedInitializationSettings _AdvancedSettings;
	}
}
