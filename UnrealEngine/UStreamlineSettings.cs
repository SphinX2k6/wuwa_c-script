using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028D3 RID: 10451
	[UnrealObjectPath("/Script/StreamlineRHI.StreamlineSettings")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UStreamlineSettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026C6C RID: 158828 RVA: 0x003B2426 File Offset: 0x003B0626
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UStreamlineSettings._ClassPtr;
		}

		// Token: 0x06026C6D RID: 158829 RVA: 0x003B2434 File Offset: 0x003B0634
		public UStreamlineSettings() : this(BuiltinUtils.AllocNativeUObject(UStreamlineSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026C6E RID: 158830 RVA: 0x003B245C File Offset: 0x003B065C
		[NullableContext(1)]
		public UStreamlineSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UStreamlineSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009558 RID: 38232
		// (get) Token: 0x06026C6F RID: 158831 RVA: 0x003B248F File Offset: 0x003B068F
		// (set) Token: 0x06026C70 RID: 158832 RVA: 0x003B249F File Offset: 0x003B069F
		public unsafe bool bLoadDebugOverlay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStreamlineSettings.__PropertyOffset_bLoadDebugOverlay) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStreamlineSettings.__PropertyOffset_bLoadDebugOverlay) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009559 RID: 38233
		// (get) Token: 0x06026C71 RID: 158833 RVA: 0x003B24B0 File Offset: 0x003B06B0
		// (set) Token: 0x06026C72 RID: 158834 RVA: 0x003B24C0 File Offset: 0x003B06C0
		public unsafe bool bAllowOTAUpdate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStreamlineSettings.__PropertyOffset_bAllowOTAUpdate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStreamlineSettings.__PropertyOffset_bAllowOTAUpdate) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700955A RID: 38234
		// (get) Token: 0x06026C73 RID: 158835 RVA: 0x003B24D1 File Offset: 0x003B06D1
		// (set) Token: 0x06026C74 RID: 158836 RVA: 0x003B24E1 File Offset: 0x003B06E1
		public unsafe int NVIDIANGXApplicationId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStreamlineSettings.__PropertyOffset_NVIDIANGXApplicationId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStreamlineSettings.__PropertyOffset_NVIDIANGXApplicationId) = value;
			}
		}

		// Token: 0x1700955B RID: 38235
		// (get) Token: 0x06026C75 RID: 158837 RVA: 0x003B24F2 File Offset: 0x003B06F2
		// (set) Token: 0x06026C76 RID: 158838 RVA: 0x003B2502 File Offset: 0x003B0702
		public unsafe bool bEnableStreamlineD3D12
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStreamlineSettings.__PropertyOffset_bEnableStreamlineD3D12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStreamlineSettings.__PropertyOffset_bEnableStreamlineD3D12) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700955C RID: 38236
		// (get) Token: 0x06026C77 RID: 158839 RVA: 0x003B2513 File Offset: 0x003B0713
		// (set) Token: 0x06026C78 RID: 158840 RVA: 0x003B2523 File Offset: 0x003B0723
		public unsafe bool bEnableStreamlineD3D11
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStreamlineSettings.__PropertyOffset_bEnableStreamlineD3D11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStreamlineSettings.__PropertyOffset_bEnableStreamlineD3D11) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700955D RID: 38237
		// (get) Token: 0x06026C79 RID: 158841 RVA: 0x003B2534 File Offset: 0x003B0734
		// (set) Token: 0x06026C7A RID: 158842 RVA: 0x003B2544 File Offset: 0x003B0744
		public unsafe bool bEnableDLSSFGInPlayInEditorViewports
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStreamlineSettings.__PropertyOffset_bEnableDLSSFGInPlayInEditorViewports) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStreamlineSettings.__PropertyOffset_bEnableDLSSFGInPlayInEditorViewports) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700955E RID: 38238
		// (get) Token: 0x06026C7B RID: 158843 RVA: 0x003B2555 File Offset: 0x003B0755
		// (set) Token: 0x06026C7C RID: 158844 RVA: 0x003B2565 File Offset: 0x003B0765
		public unsafe bool bUseSlSetTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStreamlineSettings.__PropertyOffset_bUseSlSetTag) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStreamlineSettings.__PropertyOffset_bUseSlSetTag) = (value ? 1 : 0);
			}
		}

		// Token: 0x06026C7D RID: 158845 RVA: 0x003B2576 File Offset: 0x003B0776
		static UStreamlineSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/StreamlineRHI.StreamlineSettings");
		}

		// Token: 0x06026C7E RID: 158846 RVA: 0x003B2584 File Offset: 0x003B0784
		protected UStreamlineSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401548E RID: 87182
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/StreamlineRHI.StreamlineSettings";

		// Token: 0x0401548F RID: 87183
		private static IntPtr _ClassPtr;

		// Token: 0x04015490 RID: 87184
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015491 RID: 87185
		internal static int __PropertyOffset_bLoadDebugOverlay;

		// Token: 0x04015492 RID: 87186
		internal static int __PropertyOffset_bAllowOTAUpdate;

		// Token: 0x04015493 RID: 87187
		internal static int __PropertyOffset_NVIDIANGXApplicationId;

		// Token: 0x04015494 RID: 87188
		internal static int __PropertyOffset_bEnableStreamlineD3D12;

		// Token: 0x04015495 RID: 87189
		internal static int __PropertyOffset_bEnableStreamlineD3D11;

		// Token: 0x04015496 RID: 87190
		internal static int __PropertyOffset_bEnableDLSSFGInPlayInEditorViewports;

		// Token: 0x04015497 RID: 87191
		internal static int __PropertyOffset_bUseSlSetTag;
	}
}
