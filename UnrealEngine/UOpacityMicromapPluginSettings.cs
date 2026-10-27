using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002623 RID: 9763
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/OpacityMicroMap.OpacityMicromapPluginSettings")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UOpacityMicromapPluginSettings : UDeveloperSettings, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060244BE RID: 148670 RVA: 0x0035BCDA File Offset: 0x00359EDA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UOpacityMicromapPluginSettings._ClassPtr;
		}

		// Token: 0x060244BF RID: 148671 RVA: 0x0035BCE8 File Offset: 0x00359EE8
		public UOpacityMicromapPluginSettings() : this(BuiltinUtils.AllocNativeUObject(UOpacityMicromapPluginSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060244C0 RID: 148672 RVA: 0x0035BD10 File Offset: 0x00359F10
		public UOpacityMicromapPluginSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UOpacityMicromapPluginSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008BC2 RID: 35778
		// (get) Token: 0x060244C1 RID: 148673 RVA: 0x0035BD43 File Offset: 0x00359F43
		// (set) Token: 0x060244C2 RID: 148674 RVA: 0x0035BD53 File Offset: 0x00359F53
		public unsafe bool bEnableOpacityMicromaps
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UOpacityMicromapPluginSettings.__PropertyOffset_bEnableOpacityMicromaps) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOpacityMicromapPluginSettings.__PropertyOffset_bEnableOpacityMicromaps) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008BC3 RID: 35779
		// (get) Token: 0x060244C3 RID: 148675 RVA: 0x0035BD64 File Offset: 0x00359F64
		// (set) Token: 0x060244C4 RID: 148676 RVA: 0x0035BD74 File Offset: 0x00359F74
		public unsafe bool bUseOMMSDKBaker
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UOpacityMicromapPluginSettings.__PropertyOffset_bUseOMMSDKBaker) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOpacityMicromapPluginSettings.__PropertyOffset_bUseOMMSDKBaker) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008BC4 RID: 35780
		// (get) Token: 0x060244C5 RID: 148677 RVA: 0x0035BD85 File Offset: 0x00359F85
		// (set) Token: 0x060244C6 RID: 148678 RVA: 0x0035BD95 File Offset: 0x00359F95
		public unsafe bool bBuildOMMsOnUIChanges
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UOpacityMicromapPluginSettings.__PropertyOffset_bBuildOMMsOnUIChanges) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOpacityMicromapPluginSettings.__PropertyOffset_bBuildOMMsOnUIChanges) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008BC5 RID: 35781
		// (get) Token: 0x060244C7 RID: 148679 RVA: 0x0035BDA6 File Offset: 0x00359FA6
		// (set) Token: 0x060244C8 RID: 148680 RVA: 0x0035BDB6 File Offset: 0x00359FB6
		public unsafe bool bBuildOMMsOnLevelSaved
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UOpacityMicromapPluginSettings.__PropertyOffset_bBuildOMMsOnLevelSaved) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOpacityMicromapPluginSettings.__PropertyOffset_bBuildOMMsOnLevelSaved) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008BC6 RID: 35782
		// (get) Token: 0x060244C9 RID: 148681 RVA: 0x0035BDC8 File Offset: 0x00359FC8
		// (set) Token: 0x060244CA RID: 148682 RVA: 0x0035BE01 File Offset: 0x0035A001
		public TArray<FOpacityMaskTextureDesc> OpacityMaskTextureParams
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FOpacityMaskTextureDesc> result;
				if ((result = this._OpacityMaskTextureParams) == null)
				{
					result = (this._OpacityMaskTextureParams = new TArray<FOpacityMaskTextureDesc>(base.NativePtr + (IntPtr)UOpacityMicromapPluginSettings.__PropertyOffset_OpacityMaskTextureParams, this));
				}
				return result;
			}
			set
			{
				this.OpacityMaskTextureParams.CopyAssign(value);
			}
		}

		// Token: 0x17008BC7 RID: 35783
		// (get) Token: 0x060244CB RID: 148683 RVA: 0x0035BE0F File Offset: 0x0035A00F
		// (set) Token: 0x060244CC RID: 148684 RVA: 0x0035BE1F File Offset: 0x0035A01F
		public unsafe int OmmCookMaxLod
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UOpacityMicromapPluginSettings.__PropertyOffset_OmmCookMaxLod);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOpacityMicromapPluginSettings.__PropertyOffset_OmmCookMaxLod) = value;
			}
		}

		// Token: 0x17008BC8 RID: 35784
		// (get) Token: 0x060244CD RID: 148685 RVA: 0x0035BE30 File Offset: 0x0035A030
		// (set) Token: 0x060244CE RID: 148686 RVA: 0x0035BE40 File Offset: 0x0035A040
		public unsafe EOpacityMicromapFormat OmmCookFormat
		{
			get
			{
				return (EOpacityMicromapFormat)(*(base.NativePtr + (IntPtr)UOpacityMicromapPluginSettings.__PropertyOffset_OmmCookFormat));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOpacityMicromapPluginSettings.__PropertyOffset_OmmCookFormat) = (short)value;
			}
		}

		// Token: 0x17008BC9 RID: 35785
		// (get) Token: 0x060244CF RID: 148687 RVA: 0x0035BE51 File Offset: 0x0035A051
		// (set) Token: 0x060244D0 RID: 148688 RVA: 0x0035BE61 File Offset: 0x0035A061
		public unsafe int OmmCookMaxKBPerLOD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UOpacityMicromapPluginSettings.__PropertyOffset_OmmCookMaxKBPerLOD);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOpacityMicromapPluginSettings.__PropertyOffset_OmmCookMaxKBPerLOD) = value;
			}
		}

		// Token: 0x17008BCA RID: 35786
		// (get) Token: 0x060244D1 RID: 148689 RVA: 0x0035BE72 File Offset: 0x0035A072
		// (set) Token: 0x060244D2 RID: 148690 RVA: 0x0035BE82 File Offset: 0x0035A082
		public unsafe float OmmCookDynamicSubdivisionScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UOpacityMicromapPluginSettings.__PropertyOffset_OmmCookDynamicSubdivisionScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOpacityMicromapPluginSettings.__PropertyOffset_OmmCookDynamicSubdivisionScale) = value;
			}
		}

		// Token: 0x17008BCB RID: 35787
		// (get) Token: 0x060244D3 RID: 148691 RVA: 0x0035BE93 File Offset: 0x0035A093
		// (set) Token: 0x060244D4 RID: 148692 RVA: 0x0035BEA3 File Offset: 0x0035A0A3
		public unsafe int OmmCookSubdivisionLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UOpacityMicromapPluginSettings.__PropertyOffset_OmmCookSubdivisionLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UOpacityMicromapPluginSettings.__PropertyOffset_OmmCookSubdivisionLevel) = value;
			}
		}

		// Token: 0x060244D5 RID: 148693 RVA: 0x0035BEB4 File Offset: 0x0035A0B4
		static UOpacityMicromapPluginSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/OpacityMicroMap.OpacityMicromapPluginSettings");
		}

		// Token: 0x060244D6 RID: 148694 RVA: 0x0035BEC2 File Offset: 0x0035A0C2
		protected UOpacityMicromapPluginSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013789 RID: 79753
		public new const string __ObjectPath = "/Script/OpacityMicroMap.OpacityMicromapPluginSettings";

		// Token: 0x0401378A RID: 79754
		private static IntPtr _ClassPtr;

		// Token: 0x0401378B RID: 79755
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401378C RID: 79756
		internal static int __PropertyOffset_bEnableOpacityMicromaps;

		// Token: 0x0401378D RID: 79757
		internal static int __PropertyOffset_bUseOMMSDKBaker;

		// Token: 0x0401378E RID: 79758
		internal static int __PropertyOffset_bBuildOMMsOnUIChanges;

		// Token: 0x0401378F RID: 79759
		internal static int __PropertyOffset_bBuildOMMsOnLevelSaved;

		// Token: 0x04013790 RID: 79760
		internal static int __PropertyOffset_OpacityMaskTextureParams;

		// Token: 0x04013791 RID: 79761
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FOpacityMaskTextureDesc> _OpacityMaskTextureParams;

		// Token: 0x04013792 RID: 79762
		internal static int __PropertyOffset_OmmCookMaxLod;

		// Token: 0x04013793 RID: 79763
		internal static int __PropertyOffset_OmmCookFormat;

		// Token: 0x04013794 RID: 79764
		internal static int __PropertyOffset_OmmCookMaxKBPerLOD;

		// Token: 0x04013795 RID: 79765
		internal static int __PropertyOffset_OmmCookDynamicSubdivisionScale;

		// Token: 0x04013796 RID: 79766
		internal static int __PropertyOffset_OmmCookSubdivisionLevel;
	}
}
