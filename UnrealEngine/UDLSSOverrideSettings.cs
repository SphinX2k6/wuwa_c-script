using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000782 RID: 1922
	[UnrealObjectPath("/Script/DLSS.DLSSOverrideSettings")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UDLSSOverrideSettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006434 RID: 25652 RVA: 0x0008FE87 File Offset: 0x0008E087
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDLSSOverrideSettings._ClassPtr;
		}

		// Token: 0x06006435 RID: 25653 RVA: 0x0008FE94 File Offset: 0x0008E094
		public UDLSSOverrideSettings() : this(BuiltinUtils.AllocNativeUObject(UDLSSOverrideSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006436 RID: 25654 RVA: 0x0008FEBC File Offset: 0x0008E0BC
		[NullableContext(1)]
		public UDLSSOverrideSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDLSSOverrideSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170017B7 RID: 6071
		// (get) Token: 0x06006437 RID: 25655 RVA: 0x0008FEEF File Offset: 0x0008E0EF
		// (set) Token: 0x06006438 RID: 25656 RVA: 0x0008FEFF File Offset: 0x0008E0FF
		public unsafe bool bShowDLSSIncompatiblePluginsToolsWarnings
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDLSSOverrideSettings.__PropertyOffset_bShowDLSSIncompatiblePluginsToolsWarnings) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDLSSOverrideSettings.__PropertyOffset_bShowDLSSIncompatiblePluginsToolsWarnings) = (value ? 1 : 0);
			}
		}

		// Token: 0x170017B8 RID: 6072
		// (get) Token: 0x06006439 RID: 25657 RVA: 0x0008FF10 File Offset: 0x0008E110
		// (set) Token: 0x0600643A RID: 25658 RVA: 0x0008FF20 File Offset: 0x0008E120
		public unsafe EDLSSSettingOverride ShowDLSSSDebugOnScreenMessages
		{
			get
			{
				return (EDLSSSettingOverride)(*(base.NativePtr + (IntPtr)UDLSSOverrideSettings.__PropertyOffset_ShowDLSSSDebugOnScreenMessages));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDLSSOverrideSettings.__PropertyOffset_ShowDLSSSDebugOnScreenMessages) = (byte)value;
			}
		}

		// Token: 0x170017B9 RID: 6073
		// (get) Token: 0x0600643B RID: 25659 RVA: 0x0008FF31 File Offset: 0x0008E131
		// (set) Token: 0x0600643C RID: 25660 RVA: 0x0008FF41 File Offset: 0x0008E141
		public unsafe EDLSSSettingOverride EnableDLSSInEditorViewportsOverride
		{
			get
			{
				return (EDLSSSettingOverride)(*(base.NativePtr + (IntPtr)UDLSSOverrideSettings.__PropertyOffset_EnableDLSSInEditorViewportsOverride));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDLSSOverrideSettings.__PropertyOffset_EnableDLSSInEditorViewportsOverride) = (byte)value;
			}
		}

		// Token: 0x170017BA RID: 6074
		// (get) Token: 0x0600643D RID: 25661 RVA: 0x0008FF52 File Offset: 0x0008E152
		// (set) Token: 0x0600643E RID: 25662 RVA: 0x0008FF62 File Offset: 0x0008E162
		public unsafe EDLSSSettingOverride EnableDLSSInPlayInEditorViewportsOverride
		{
			get
			{
				return (EDLSSSettingOverride)(*(base.NativePtr + (IntPtr)UDLSSOverrideSettings.__PropertyOffset_EnableDLSSInPlayInEditorViewportsOverride));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDLSSOverrideSettings.__PropertyOffset_EnableDLSSInPlayInEditorViewportsOverride) = (byte)value;
			}
		}

		// Token: 0x0600643F RID: 25663 RVA: 0x0008FF73 File Offset: 0x0008E173
		static UDLSSOverrideSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/DLSS.DLSSOverrideSettings");
		}

		// Token: 0x06006440 RID: 25664 RVA: 0x0008FF81 File Offset: 0x0008E181
		protected UDLSSOverrideSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400304C RID: 12364
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/DLSS.DLSSOverrideSettings";

		// Token: 0x0400304D RID: 12365
		private static IntPtr _ClassPtr;

		// Token: 0x0400304E RID: 12366
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400304F RID: 12367
		internal static int __PropertyOffset_bShowDLSSIncompatiblePluginsToolsWarnings;

		// Token: 0x04003050 RID: 12368
		internal static int __PropertyOffset_ShowDLSSSDebugOnScreenMessages;

		// Token: 0x04003051 RID: 12369
		internal static int __PropertyOffset_EnableDLSSInEditorViewportsOverride;

		// Token: 0x04003052 RID: 12370
		internal static int __PropertyOffset_EnableDLSSInPlayInEditorViewportsOverride;
	}
}
