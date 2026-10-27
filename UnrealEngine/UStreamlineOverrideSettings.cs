using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028D2 RID: 10450
	[UnrealObjectPath("/Script/StreamlineRHI.StreamlineOverrideSettings")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UStreamlineOverrideSettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026C5F RID: 158815 RVA: 0x003B2323 File Offset: 0x003B0523
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UStreamlineOverrideSettings._ClassPtr;
		}

		// Token: 0x06026C60 RID: 158816 RVA: 0x003B2330 File Offset: 0x003B0530
		public UStreamlineOverrideSettings() : this(BuiltinUtils.AllocNativeUObject(UStreamlineOverrideSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026C61 RID: 158817 RVA: 0x003B2358 File Offset: 0x003B0558
		[NullableContext(1)]
		public UStreamlineOverrideSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UStreamlineOverrideSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009554 RID: 38228
		// (get) Token: 0x06026C62 RID: 158818 RVA: 0x003B238B File Offset: 0x003B058B
		// (set) Token: 0x06026C63 RID: 158819 RVA: 0x003B239B File Offset: 0x003B059B
		public unsafe EStreamlineSettingOverride LoadDebugOverlayOverride
		{
			get
			{
				return (EStreamlineSettingOverride)(*(base.NativePtr + (IntPtr)UStreamlineOverrideSettings.__PropertyOffset_LoadDebugOverlayOverride));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStreamlineOverrideSettings.__PropertyOffset_LoadDebugOverlayOverride) = (byte)value;
			}
		}

		// Token: 0x17009555 RID: 38229
		// (get) Token: 0x06026C64 RID: 158820 RVA: 0x003B23AC File Offset: 0x003B05AC
		// (set) Token: 0x06026C65 RID: 158821 RVA: 0x003B23BC File Offset: 0x003B05BC
		public unsafe EStreamlineSettingOverride AllowOTAUpdateOverride
		{
			get
			{
				return (EStreamlineSettingOverride)(*(base.NativePtr + (IntPtr)UStreamlineOverrideSettings.__PropertyOffset_AllowOTAUpdateOverride));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStreamlineOverrideSettings.__PropertyOffset_AllowOTAUpdateOverride) = (byte)value;
			}
		}

		// Token: 0x17009556 RID: 38230
		// (get) Token: 0x06026C66 RID: 158822 RVA: 0x003B23CD File Offset: 0x003B05CD
		// (set) Token: 0x06026C67 RID: 158823 RVA: 0x003B23DD File Offset: 0x003B05DD
		public unsafe EStreamlineSettingOverride EnableDLSSFGInPlayInEditorViewportsOverride
		{
			get
			{
				return (EStreamlineSettingOverride)(*(base.NativePtr + (IntPtr)UStreamlineOverrideSettings.__PropertyOffset_EnableDLSSFGInPlayInEditorViewportsOverride));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStreamlineOverrideSettings.__PropertyOffset_EnableDLSSFGInPlayInEditorViewportsOverride) = (byte)value;
			}
		}

		// Token: 0x17009557 RID: 38231
		// (get) Token: 0x06026C68 RID: 158824 RVA: 0x003B23EE File Offset: 0x003B05EE
		// (set) Token: 0x06026C69 RID: 158825 RVA: 0x003B23FE File Offset: 0x003B05FE
		public unsafe EStreamlineSettingOverride UseSlSetTagOverride
		{
			get
			{
				return (EStreamlineSettingOverride)(*(base.NativePtr + (IntPtr)UStreamlineOverrideSettings.__PropertyOffset_UseSlSetTagOverride));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStreamlineOverrideSettings.__PropertyOffset_UseSlSetTagOverride) = (byte)value;
			}
		}

		// Token: 0x06026C6A RID: 158826 RVA: 0x003B240F File Offset: 0x003B060F
		static UStreamlineOverrideSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/StreamlineRHI.StreamlineOverrideSettings");
		}

		// Token: 0x06026C6B RID: 158827 RVA: 0x003B241D File Offset: 0x003B061D
		protected UStreamlineOverrideSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015487 RID: 87175
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/StreamlineRHI.StreamlineOverrideSettings";

		// Token: 0x04015488 RID: 87176
		private static IntPtr _ClassPtr;

		// Token: 0x04015489 RID: 87177
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401548A RID: 87178
		internal static int __PropertyOffset_LoadDebugOverlayOverride;

		// Token: 0x0401548B RID: 87179
		internal static int __PropertyOffset_AllowOTAUpdateOverride;

		// Token: 0x0401548C RID: 87180
		internal static int __PropertyOffset_EnableDLSSFGInPlayInEditorViewportsOverride;

		// Token: 0x0401548D RID: 87181
		internal static int __PropertyOffset_UseSlSetTagOverride;
	}
}
