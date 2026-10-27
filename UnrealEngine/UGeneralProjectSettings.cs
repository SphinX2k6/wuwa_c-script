using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200079E RID: 1950
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/EngineSettings.GeneralProjectSettings")]
	[UnrealStructLayout(280, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 280)]
	public class UGeneralProjectSettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006593 RID: 26003 RVA: 0x00091A6E File Offset: 0x0008FC6E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGeneralProjectSettings._ClassPtr;
		}

		// Token: 0x06006594 RID: 26004 RVA: 0x00091A7C File Offset: 0x0008FC7C
		public UGeneralProjectSettings() : this(BuiltinUtils.AllocNativeUObject(UGeneralProjectSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006595 RID: 26005 RVA: 0x00091AA4 File Offset: 0x0008FCA4
		public UGeneralProjectSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGeneralProjectSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001827 RID: 6183
		// (get) Token: 0x06006596 RID: 26006 RVA: 0x00091AD7 File Offset: 0x0008FCD7
		// (set) Token: 0x06006597 RID: 26007 RVA: 0x00091AEB File Offset: 0x0008FCEB
		public unsafe string CompanyName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UGeneralProjectSettings.__PropertyOffset_CompanyName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UGeneralProjectSettings.__PropertyOffset_CompanyName)), value);
			}
		}

		// Token: 0x17001828 RID: 6184
		// (get) Token: 0x06006598 RID: 26008 RVA: 0x00091B00 File Offset: 0x0008FD00
		// (set) Token: 0x06006599 RID: 26009 RVA: 0x00091B14 File Offset: 0x0008FD14
		public unsafe string CompanyDistinguishedName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UGeneralProjectSettings.__PropertyOffset_CompanyDistinguishedName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UGeneralProjectSettings.__PropertyOffset_CompanyDistinguishedName)), value);
			}
		}

		// Token: 0x17001829 RID: 6185
		// (get) Token: 0x0600659A RID: 26010 RVA: 0x00091B29 File Offset: 0x0008FD29
		// (set) Token: 0x0600659B RID: 26011 RVA: 0x00091B3D File Offset: 0x0008FD3D
		public unsafe string CopyrightNotice
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UGeneralProjectSettings.__PropertyOffset_CopyrightNotice)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UGeneralProjectSettings.__PropertyOffset_CopyrightNotice)), value);
			}
		}

		// Token: 0x1700182A RID: 6186
		// (get) Token: 0x0600659C RID: 26012 RVA: 0x00091B52 File Offset: 0x0008FD52
		// (set) Token: 0x0600659D RID: 26013 RVA: 0x00091B66 File Offset: 0x0008FD66
		public unsafe string Description
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UGeneralProjectSettings.__PropertyOffset_Description)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UGeneralProjectSettings.__PropertyOffset_Description)), value);
			}
		}

		// Token: 0x1700182B RID: 6187
		// (get) Token: 0x0600659E RID: 26014 RVA: 0x00091B7B File Offset: 0x0008FD7B
		// (set) Token: 0x0600659F RID: 26015 RVA: 0x00091B8F File Offset: 0x0008FD8F
		public unsafe string Homepage
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UGeneralProjectSettings.__PropertyOffset_Homepage)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UGeneralProjectSettings.__PropertyOffset_Homepage)), value);
			}
		}

		// Token: 0x1700182C RID: 6188
		// (get) Token: 0x060065A0 RID: 26016 RVA: 0x00091BA4 File Offset: 0x0008FDA4
		// (set) Token: 0x060065A1 RID: 26017 RVA: 0x00091BB8 File Offset: 0x0008FDB8
		public unsafe string LicensingTerms
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UGeneralProjectSettings.__PropertyOffset_LicensingTerms)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UGeneralProjectSettings.__PropertyOffset_LicensingTerms)), value);
			}
		}

		// Token: 0x1700182D RID: 6189
		// (get) Token: 0x060065A2 RID: 26018 RVA: 0x00091BCD File Offset: 0x0008FDCD
		// (set) Token: 0x060065A3 RID: 26019 RVA: 0x00091BE1 File Offset: 0x0008FDE1
		public unsafe string PrivacyPolicy
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UGeneralProjectSettings.__PropertyOffset_PrivacyPolicy)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UGeneralProjectSettings.__PropertyOffset_PrivacyPolicy)), value);
			}
		}

		// Token: 0x1700182E RID: 6190
		// (get) Token: 0x060065A4 RID: 26020 RVA: 0x00091BF6 File Offset: 0x0008FDF6
		// (set) Token: 0x060065A5 RID: 26021 RVA: 0x00091C0A File Offset: 0x0008FE0A
		public unsafe FGuid ProjectID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeneralProjectSettings.__PropertyOffset_ProjectID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeneralProjectSettings.__PropertyOffset_ProjectID) = value;
			}
		}

		// Token: 0x1700182F RID: 6191
		// (get) Token: 0x060065A6 RID: 26022 RVA: 0x00091C1F File Offset: 0x0008FE1F
		// (set) Token: 0x060065A7 RID: 26023 RVA: 0x00091C33 File Offset: 0x0008FE33
		public unsafe string ProjectName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UGeneralProjectSettings.__PropertyOffset_ProjectName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UGeneralProjectSettings.__PropertyOffset_ProjectName)), value);
			}
		}

		// Token: 0x17001830 RID: 6192
		// (get) Token: 0x060065A8 RID: 26024 RVA: 0x00091C48 File Offset: 0x0008FE48
		// (set) Token: 0x060065A9 RID: 26025 RVA: 0x00091C5C File Offset: 0x0008FE5C
		public unsafe string ProjectVersion
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UGeneralProjectSettings.__PropertyOffset_ProjectVersion)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UGeneralProjectSettings.__PropertyOffset_ProjectVersion)), value);
			}
		}

		// Token: 0x17001831 RID: 6193
		// (get) Token: 0x060065AA RID: 26026 RVA: 0x00091C71 File Offset: 0x0008FE71
		// (set) Token: 0x060065AB RID: 26027 RVA: 0x00091C85 File Offset: 0x0008FE85
		public unsafe string SupportContact
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UGeneralProjectSettings.__PropertyOffset_SupportContact)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UGeneralProjectSettings.__PropertyOffset_SupportContact)), value);
			}
		}

		// Token: 0x17001832 RID: 6194
		// (get) Token: 0x060065AC RID: 26028 RVA: 0x00091C9C File Offset: 0x0008FE9C
		// (set) Token: 0x060065AD RID: 26029 RVA: 0x00091CD5 File Offset: 0x0008FED5
		public unsafe FText ProjectDisplayedTitle
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._ProjectDisplayedTitle) == null)
				{
					result = (this._ProjectDisplayedTitle = new FText(base.NativePtr + (IntPtr)UGeneralProjectSettings.__PropertyOffset_ProjectDisplayedTitle, this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)UGeneralProjectSettings.__PropertyOffset_ProjectDisplayedTitle)), value.NativePtr, 1);
			}
		}

		// Token: 0x17001833 RID: 6195
		// (get) Token: 0x060065AE RID: 26030 RVA: 0x00091CF0 File Offset: 0x0008FEF0
		// (set) Token: 0x060065AF RID: 26031 RVA: 0x00091D29 File Offset: 0x0008FF29
		public unsafe FText ProjectDebugTitleInfo
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._ProjectDebugTitleInfo) == null)
				{
					result = (this._ProjectDebugTitleInfo = new FText(base.NativePtr + (IntPtr)UGeneralProjectSettings.__PropertyOffset_ProjectDebugTitleInfo, this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)UGeneralProjectSettings.__PropertyOffset_ProjectDebugTitleInfo)), value.NativePtr, 1);
			}
		}

		// Token: 0x17001834 RID: 6196
		// (get) Token: 0x060065B0 RID: 26032 RVA: 0x00091D44 File Offset: 0x0008FF44
		// (set) Token: 0x060065B1 RID: 26033 RVA: 0x00091D54 File Offset: 0x0008FF54
		public unsafe bool bShouldWindowPreserveAspectRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeneralProjectSettings.__PropertyOffset_bShouldWindowPreserveAspectRatio) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeneralProjectSettings.__PropertyOffset_bShouldWindowPreserveAspectRatio) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001835 RID: 6197
		// (get) Token: 0x060065B2 RID: 26034 RVA: 0x00091D65 File Offset: 0x0008FF65
		// (set) Token: 0x060065B3 RID: 26035 RVA: 0x00091D75 File Offset: 0x0008FF75
		public unsafe bool bUseBorderlessWindow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeneralProjectSettings.__PropertyOffset_bUseBorderlessWindow) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeneralProjectSettings.__PropertyOffset_bUseBorderlessWindow) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001836 RID: 6198
		// (get) Token: 0x060065B4 RID: 26036 RVA: 0x00091D86 File Offset: 0x0008FF86
		// (set) Token: 0x060065B5 RID: 26037 RVA: 0x00091D96 File Offset: 0x0008FF96
		public unsafe bool bStartInVR
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeneralProjectSettings.__PropertyOffset_bStartInVR) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeneralProjectSettings.__PropertyOffset_bStartInVR) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001837 RID: 6199
		// (get) Token: 0x060065B6 RID: 26038 RVA: 0x00091DA7 File Offset: 0x0008FFA7
		// (set) Token: 0x060065B7 RID: 26039 RVA: 0x00091DB7 File Offset: 0x0008FFB7
		public unsafe bool bAllowWindowResize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeneralProjectSettings.__PropertyOffset_bAllowWindowResize) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeneralProjectSettings.__PropertyOffset_bAllowWindowResize) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001838 RID: 6200
		// (get) Token: 0x060065B8 RID: 26040 RVA: 0x00091DC8 File Offset: 0x0008FFC8
		// (set) Token: 0x060065B9 RID: 26041 RVA: 0x00091DD8 File Offset: 0x0008FFD8
		public unsafe bool bAllowClose
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeneralProjectSettings.__PropertyOffset_bAllowClose) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeneralProjectSettings.__PropertyOffset_bAllowClose) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001839 RID: 6201
		// (get) Token: 0x060065BA RID: 26042 RVA: 0x00091DE9 File Offset: 0x0008FFE9
		// (set) Token: 0x060065BB RID: 26043 RVA: 0x00091DF9 File Offset: 0x0008FFF9
		public unsafe bool bAllowMaximize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeneralProjectSettings.__PropertyOffset_bAllowMaximize) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeneralProjectSettings.__PropertyOffset_bAllowMaximize) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700183A RID: 6202
		// (get) Token: 0x060065BC RID: 26044 RVA: 0x00091E0A File Offset: 0x0009000A
		// (set) Token: 0x060065BD RID: 26045 RVA: 0x00091E1A File Offset: 0x0009001A
		public unsafe bool bAllowMinimize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeneralProjectSettings.__PropertyOffset_bAllowMinimize) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeneralProjectSettings.__PropertyOffset_bAllowMinimize) = (value ? 1 : 0);
			}
		}

		// Token: 0x060065BE RID: 26046 RVA: 0x00091E2B File Offset: 0x0009002B
		static UGeneralProjectSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/EngineSettings.GeneralProjectSettings");
		}

		// Token: 0x060065BF RID: 26047 RVA: 0x00091E39 File Offset: 0x00090039
		protected UGeneralProjectSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400314D RID: 12621
		public new const string __ObjectPath = "/Script/EngineSettings.GeneralProjectSettings";

		// Token: 0x0400314E RID: 12622
		private static IntPtr _ClassPtr;

		// Token: 0x0400314F RID: 12623
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003150 RID: 12624
		internal static int __PropertyOffset_CompanyName;

		// Token: 0x04003151 RID: 12625
		internal static int __PropertyOffset_CompanyDistinguishedName;

		// Token: 0x04003152 RID: 12626
		internal static int __PropertyOffset_CopyrightNotice;

		// Token: 0x04003153 RID: 12627
		internal static int __PropertyOffset_Description;

		// Token: 0x04003154 RID: 12628
		internal static int __PropertyOffset_Homepage;

		// Token: 0x04003155 RID: 12629
		internal static int __PropertyOffset_LicensingTerms;

		// Token: 0x04003156 RID: 12630
		internal static int __PropertyOffset_PrivacyPolicy;

		// Token: 0x04003157 RID: 12631
		internal static int __PropertyOffset_ProjectID;

		// Token: 0x04003158 RID: 12632
		internal static int __PropertyOffset_ProjectName;

		// Token: 0x04003159 RID: 12633
		internal static int __PropertyOffset_ProjectVersion;

		// Token: 0x0400315A RID: 12634
		internal static int __PropertyOffset_SupportContact;

		// Token: 0x0400315B RID: 12635
		internal static int __PropertyOffset_ProjectDisplayedTitle;

		// Token: 0x0400315C RID: 12636
		[Nullable(2)]
		private FText _ProjectDisplayedTitle;

		// Token: 0x0400315D RID: 12637
		internal static int __PropertyOffset_ProjectDebugTitleInfo;

		// Token: 0x0400315E RID: 12638
		[Nullable(2)]
		private FText _ProjectDebugTitleInfo;

		// Token: 0x0400315F RID: 12639
		internal static int __PropertyOffset_bShouldWindowPreserveAspectRatio;

		// Token: 0x04003160 RID: 12640
		internal static int __PropertyOffset_bUseBorderlessWindow;

		// Token: 0x04003161 RID: 12641
		internal static int __PropertyOffset_bStartInVR;

		// Token: 0x04003162 RID: 12642
		internal static int __PropertyOffset_bAllowWindowResize;

		// Token: 0x04003163 RID: 12643
		internal static int __PropertyOffset_bAllowClose;

		// Token: 0x04003164 RID: 12644
		internal static int __PropertyOffset_bAllowMaximize;

		// Token: 0x04003165 RID: 12645
		internal static int __PropertyOffset_bAllowMinimize;
	}
}
