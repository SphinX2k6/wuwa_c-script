using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200121B RID: 4635
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.UserInterfaceSettings")]
	[UnrealStructLayout(728, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 728)]
	public class UUserInterfaceSettings : UDeveloperSettings, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060110EE RID: 69870 RVA: 0x00190798 File Offset: 0x0018E998
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUserInterfaceSettings._ClassPtr;
		}

		// Token: 0x060110EF RID: 69871 RVA: 0x001907A4 File Offset: 0x0018E9A4
		public UUserInterfaceSettings() : this(BuiltinUtils.AllocNativeUObject(UUserInterfaceSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060110F0 RID: 69872 RVA: 0x001907CC File Offset: 0x0018E9CC
		public UUserInterfaceSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUserInterfaceSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004295 RID: 17045
		// (get) Token: 0x060110F1 RID: 69873 RVA: 0x001907FF File Offset: 0x0018E9FF
		// (set) Token: 0x060110F2 RID: 69874 RVA: 0x0019080F File Offset: 0x0018EA0F
		public unsafe ERenderFocusRule RenderFocusRule
		{
			get
			{
				return (ERenderFocusRule)(*(base.NativePtr + (IntPtr)UUserInterfaceSettings.__PropertyOffset_RenderFocusRule));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUserInterfaceSettings.__PropertyOffset_RenderFocusRule) = (byte)value;
			}
		}

		// Token: 0x17004296 RID: 17046
		// (get) Token: 0x060110F3 RID: 69875 RVA: 0x00190820 File Offset: 0x0018EA20
		// (set) Token: 0x060110F4 RID: 69876 RVA: 0x00190859 File Offset: 0x0018EA59
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TMap<TEnumAsByte<EMouseCursor>, FHardwareCursorReference> HardwareCursors
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<EMouseCursor>, FHardwareCursorReference> result;
				if ((result = this._HardwareCursors) == null)
				{
					result = (this._HardwareCursors = new TMap<TEnumAsByte<EMouseCursor>, FHardwareCursorReference>(base.NativePtr + (IntPtr)UUserInterfaceSettings.__PropertyOffset_HardwareCursors, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.HardwareCursors.CopyAssign(value);
			}
		}

		// Token: 0x17004297 RID: 17047
		// (get) Token: 0x060110F5 RID: 69877 RVA: 0x00190868 File Offset: 0x0018EA68
		// (set) Token: 0x060110F6 RID: 69878 RVA: 0x001908A1 File Offset: 0x0018EAA1
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TMap<TEnumAsByte<EMouseCursor>, FSoftClassPath> SoftwareCursors
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<EMouseCursor>, FSoftClassPath> result;
				if ((result = this._SoftwareCursors) == null)
				{
					result = (this._SoftwareCursors = new TMap<TEnumAsByte<EMouseCursor>, FSoftClassPath>(base.NativePtr + (IntPtr)UUserInterfaceSettings.__PropertyOffset_SoftwareCursors, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.SoftwareCursors.CopyAssign(value);
			}
		}

		// Token: 0x17004298 RID: 17048
		// (get) Token: 0x060110F7 RID: 69879 RVA: 0x001908B0 File Offset: 0x0018EAB0
		// (set) Token: 0x060110F8 RID: 69880 RVA: 0x001908E9 File Offset: 0x0018EAE9
		public FSoftClassPath DefaultCursor_DEPRECATED
		{
			get
			{
				base.FastCheckIsValid();
				FSoftClassPath result;
				if ((result = this._DefaultCursor_DEPRECATED) == null)
				{
					result = (this._DefaultCursor_DEPRECATED = new FSoftClassPath(base.NativePtr + (IntPtr)UUserInterfaceSettings.__PropertyOffset_DefaultCursor_DEPRECATED, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), base.NativePtr + (IntPtr)UUserInterfaceSettings.__PropertyOffset_DefaultCursor_DEPRECATED, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004299 RID: 17049
		// (get) Token: 0x060110F9 RID: 69881 RVA: 0x0019090C File Offset: 0x0018EB0C
		// (set) Token: 0x060110FA RID: 69882 RVA: 0x00190945 File Offset: 0x0018EB45
		public FSoftClassPath TextEditBeamCursor_DEPRECATED
		{
			get
			{
				base.FastCheckIsValid();
				FSoftClassPath result;
				if ((result = this._TextEditBeamCursor_DEPRECATED) == null)
				{
					result = (this._TextEditBeamCursor_DEPRECATED = new FSoftClassPath(base.NativePtr + (IntPtr)UUserInterfaceSettings.__PropertyOffset_TextEditBeamCursor_DEPRECATED, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), base.NativePtr + (IntPtr)UUserInterfaceSettings.__PropertyOffset_TextEditBeamCursor_DEPRECATED, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700429A RID: 17050
		// (get) Token: 0x060110FB RID: 69883 RVA: 0x00190968 File Offset: 0x0018EB68
		// (set) Token: 0x060110FC RID: 69884 RVA: 0x001909A1 File Offset: 0x0018EBA1
		public FSoftClassPath CrosshairsCursor_DEPRECATED
		{
			get
			{
				base.FastCheckIsValid();
				FSoftClassPath result;
				if ((result = this._CrosshairsCursor_DEPRECATED) == null)
				{
					result = (this._CrosshairsCursor_DEPRECATED = new FSoftClassPath(base.NativePtr + (IntPtr)UUserInterfaceSettings.__PropertyOffset_CrosshairsCursor_DEPRECATED, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), base.NativePtr + (IntPtr)UUserInterfaceSettings.__PropertyOffset_CrosshairsCursor_DEPRECATED, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700429B RID: 17051
		// (get) Token: 0x060110FD RID: 69885 RVA: 0x001909C4 File Offset: 0x0018EBC4
		// (set) Token: 0x060110FE RID: 69886 RVA: 0x001909FD File Offset: 0x0018EBFD
		public FSoftClassPath HandCursor_DEPRECATED
		{
			get
			{
				base.FastCheckIsValid();
				FSoftClassPath result;
				if ((result = this._HandCursor_DEPRECATED) == null)
				{
					result = (this._HandCursor_DEPRECATED = new FSoftClassPath(base.NativePtr + (IntPtr)UUserInterfaceSettings.__PropertyOffset_HandCursor_DEPRECATED, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), base.NativePtr + (IntPtr)UUserInterfaceSettings.__PropertyOffset_HandCursor_DEPRECATED, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700429C RID: 17052
		// (get) Token: 0x060110FF RID: 69887 RVA: 0x00190A20 File Offset: 0x0018EC20
		// (set) Token: 0x06011100 RID: 69888 RVA: 0x00190A59 File Offset: 0x0018EC59
		public FSoftClassPath GrabHandCursor_DEPRECATED
		{
			get
			{
				base.FastCheckIsValid();
				FSoftClassPath result;
				if ((result = this._GrabHandCursor_DEPRECATED) == null)
				{
					result = (this._GrabHandCursor_DEPRECATED = new FSoftClassPath(base.NativePtr + (IntPtr)UUserInterfaceSettings.__PropertyOffset_GrabHandCursor_DEPRECATED, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), base.NativePtr + (IntPtr)UUserInterfaceSettings.__PropertyOffset_GrabHandCursor_DEPRECATED, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700429D RID: 17053
		// (get) Token: 0x06011101 RID: 69889 RVA: 0x00190A7C File Offset: 0x0018EC7C
		// (set) Token: 0x06011102 RID: 69890 RVA: 0x00190AB5 File Offset: 0x0018ECB5
		public FSoftClassPath GrabHandClosedCursor_DEPRECATED
		{
			get
			{
				base.FastCheckIsValid();
				FSoftClassPath result;
				if ((result = this._GrabHandClosedCursor_DEPRECATED) == null)
				{
					result = (this._GrabHandClosedCursor_DEPRECATED = new FSoftClassPath(base.NativePtr + (IntPtr)UUserInterfaceSettings.__PropertyOffset_GrabHandClosedCursor_DEPRECATED, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), base.NativePtr + (IntPtr)UUserInterfaceSettings.__PropertyOffset_GrabHandClosedCursor_DEPRECATED, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700429E RID: 17054
		// (get) Token: 0x06011103 RID: 69891 RVA: 0x00190AD8 File Offset: 0x0018ECD8
		// (set) Token: 0x06011104 RID: 69892 RVA: 0x00190B11 File Offset: 0x0018ED11
		public FSoftClassPath SlashedCircleCursor_DEPRECATED
		{
			get
			{
				base.FastCheckIsValid();
				FSoftClassPath result;
				if ((result = this._SlashedCircleCursor_DEPRECATED) == null)
				{
					result = (this._SlashedCircleCursor_DEPRECATED = new FSoftClassPath(base.NativePtr + (IntPtr)UUserInterfaceSettings.__PropertyOffset_SlashedCircleCursor_DEPRECATED, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), base.NativePtr + (IntPtr)UUserInterfaceSettings.__PropertyOffset_SlashedCircleCursor_DEPRECATED, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700429F RID: 17055
		// (get) Token: 0x06011105 RID: 69893 RVA: 0x00190B32 File Offset: 0x0018ED32
		// (set) Token: 0x06011106 RID: 69894 RVA: 0x00190B42 File Offset: 0x0018ED42
		public unsafe float ApplicationScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUserInterfaceSettings.__PropertyOffset_ApplicationScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUserInterfaceSettings.__PropertyOffset_ApplicationScale) = value;
			}
		}

		// Token: 0x170042A0 RID: 17056
		// (get) Token: 0x06011107 RID: 69895 RVA: 0x00190B53 File Offset: 0x0018ED53
		// (set) Token: 0x06011108 RID: 69896 RVA: 0x00190B63 File Offset: 0x0018ED63
		public unsafe EUIScalingRule UIScaleRule
		{
			get
			{
				return (EUIScalingRule)(*(base.NativePtr + (IntPtr)UUserInterfaceSettings.__PropertyOffset_UIScaleRule));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUserInterfaceSettings.__PropertyOffset_UIScaleRule) = (byte)value;
			}
		}

		// Token: 0x170042A1 RID: 17057
		// (get) Token: 0x06011109 RID: 69897 RVA: 0x00190B74 File Offset: 0x0018ED74
		// (set) Token: 0x0601110A RID: 69898 RVA: 0x00190BAD File Offset: 0x0018EDAD
		public FSoftClassPath CustomScalingRuleClass
		{
			get
			{
				base.FastCheckIsValid();
				FSoftClassPath result;
				if ((result = this._CustomScalingRuleClass) == null)
				{
					result = (this._CustomScalingRuleClass = new FSoftClassPath(base.NativePtr + (IntPtr)UUserInterfaceSettings.__PropertyOffset_CustomScalingRuleClass, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), base.NativePtr + (IntPtr)UUserInterfaceSettings.__PropertyOffset_CustomScalingRuleClass, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170042A2 RID: 17058
		// (get) Token: 0x0601110B RID: 69899 RVA: 0x00190BD0 File Offset: 0x0018EDD0
		// (set) Token: 0x0601110C RID: 69900 RVA: 0x00190C09 File Offset: 0x0018EE09
		public FRuntimeFloatCurve UIScaleCurve
		{
			get
			{
				base.FastCheckIsValid();
				FRuntimeFloatCurve result;
				if ((result = this._UIScaleCurve) == null)
				{
					result = (this._UIScaleCurve = new FRuntimeFloatCurve(base.NativePtr + (IntPtr)UUserInterfaceSettings.__PropertyOffset_UIScaleCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRuntimeFloatCurve.StaticStruct(), base.NativePtr + (IntPtr)UUserInterfaceSettings.__PropertyOffset_UIScaleCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170042A3 RID: 17059
		// (get) Token: 0x0601110D RID: 69901 RVA: 0x00190C2A File Offset: 0x0018EE2A
		// (set) Token: 0x0601110E RID: 69902 RVA: 0x00190C3A File Offset: 0x0018EE3A
		public unsafe bool bAllowHighDPIInGameMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUserInterfaceSettings.__PropertyOffset_bAllowHighDPIInGameMode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUserInterfaceSettings.__PropertyOffset_bAllowHighDPIInGameMode) = (value ? 1 : 0);
			}
		}

		// Token: 0x170042A4 RID: 17060
		// (get) Token: 0x0601110F RID: 69903 RVA: 0x00190C4B File Offset: 0x0018EE4B
		// (set) Token: 0x06011110 RID: 69904 RVA: 0x00190C5F File Offset: 0x0018EE5F
		public unsafe FIntPoint DesignScreenSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUserInterfaceSettings.__PropertyOffset_DesignScreenSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUserInterfaceSettings.__PropertyOffset_DesignScreenSize) = value;
			}
		}

		// Token: 0x170042A5 RID: 17061
		// (get) Token: 0x06011111 RID: 69905 RVA: 0x00190C74 File Offset: 0x0018EE74
		// (set) Token: 0x06011112 RID: 69906 RVA: 0x00190C84 File Offset: 0x0018EE84
		public unsafe bool bLoadWidgetsOnDedicatedServer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUserInterfaceSettings.__PropertyOffset_bLoadWidgetsOnDedicatedServer) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUserInterfaceSettings.__PropertyOffset_bLoadWidgetsOnDedicatedServer) = (value ? 1 : 0);
			}
		}

		// Token: 0x170042A6 RID: 17062
		// (get) Token: 0x06011113 RID: 69907 RVA: 0x00190C98 File Offset: 0x0018EE98
		// (set) Token: 0x06011114 RID: 69908 RVA: 0x00190CD1 File Offset: 0x0018EED1
		public TArray<UObject> CursorClasses
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UObject> result;
				if ((result = this._CursorClasses) == null)
				{
					result = (this._CursorClasses = new TArray<UObject>(base.NativePtr + (IntPtr)UUserInterfaceSettings.__PropertyOffset_CursorClasses, this));
				}
				return result;
			}
			set
			{
				this.CursorClasses.CopyAssign(value);
			}
		}

		// Token: 0x170042A7 RID: 17063
		// (get) Token: 0x06011115 RID: 69909 RVA: 0x00190CDF File Offset: 0x0018EEDF
		// (set) Token: 0x06011116 RID: 69910 RVA: 0x00190CF3 File Offset: 0x0018EEF3
		public unsafe UClassStackOnlyPtr CustomScalingRuleClassInstance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUserInterfaceSettings.__PropertyOffset_CustomScalingRuleClassInstance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUserInterfaceSettings.__PropertyOffset_CustomScalingRuleClassInstance) = value;
			}
		}

		// Token: 0x170042A8 RID: 17064
		// (get) Token: 0x06011117 RID: 69911 RVA: 0x00190D08 File Offset: 0x0018EF08
		// (set) Token: 0x06011118 RID: 69912 RVA: 0x00190D1C File Offset: 0x0018EF1C
		[Nullable(2)]
		public unsafe UDPICustomScalingRule CustomScalingRule
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDPICustomScalingRule>(base.NativePtr / (IntPtr)sizeof(void*) + UUserInterfaceSettings.__PropertyOffset_CustomScalingRule);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUserInterfaceSettings.__PropertyOffset_CustomScalingRule, value);
			}
		}

		// Token: 0x06011119 RID: 69913 RVA: 0x00190D31 File Offset: 0x0018EF31
		static UUserInterfaceSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.UserInterfaceSettings");
		}

		// Token: 0x0601111A RID: 69914 RVA: 0x00190D3F File Offset: 0x0018EF3F
		protected UUserInterfaceSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009218 RID: 37400
		public new const string __ObjectPath = "/Script/Engine.UserInterfaceSettings";

		// Token: 0x04009219 RID: 37401
		private static IntPtr _ClassPtr;

		// Token: 0x0400921A RID: 37402
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400921B RID: 37403
		internal static int __PropertyOffset_RenderFocusRule;

		// Token: 0x0400921C RID: 37404
		internal static int __PropertyOffset_HardwareCursors;

		// Token: 0x0400921D RID: 37405
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EMouseCursor>, FHardwareCursorReference> _HardwareCursors;

		// Token: 0x0400921E RID: 37406
		internal static int __PropertyOffset_SoftwareCursors;

		// Token: 0x0400921F RID: 37407
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EMouseCursor>, FSoftClassPath> _SoftwareCursors;

		// Token: 0x04009220 RID: 37408
		internal static int __PropertyOffset_DefaultCursor_DEPRECATED;

		// Token: 0x04009221 RID: 37409
		[Nullable(2)]
		private FSoftClassPath _DefaultCursor_DEPRECATED;

		// Token: 0x04009222 RID: 37410
		internal static int __PropertyOffset_TextEditBeamCursor_DEPRECATED;

		// Token: 0x04009223 RID: 37411
		[Nullable(2)]
		private FSoftClassPath _TextEditBeamCursor_DEPRECATED;

		// Token: 0x04009224 RID: 37412
		internal static int __PropertyOffset_CrosshairsCursor_DEPRECATED;

		// Token: 0x04009225 RID: 37413
		[Nullable(2)]
		private FSoftClassPath _CrosshairsCursor_DEPRECATED;

		// Token: 0x04009226 RID: 37414
		internal static int __PropertyOffset_HandCursor_DEPRECATED;

		// Token: 0x04009227 RID: 37415
		[Nullable(2)]
		private FSoftClassPath _HandCursor_DEPRECATED;

		// Token: 0x04009228 RID: 37416
		internal static int __PropertyOffset_GrabHandCursor_DEPRECATED;

		// Token: 0x04009229 RID: 37417
		[Nullable(2)]
		private FSoftClassPath _GrabHandCursor_DEPRECATED;

		// Token: 0x0400922A RID: 37418
		internal static int __PropertyOffset_GrabHandClosedCursor_DEPRECATED;

		// Token: 0x0400922B RID: 37419
		[Nullable(2)]
		private FSoftClassPath _GrabHandClosedCursor_DEPRECATED;

		// Token: 0x0400922C RID: 37420
		internal static int __PropertyOffset_SlashedCircleCursor_DEPRECATED;

		// Token: 0x0400922D RID: 37421
		[Nullable(2)]
		private FSoftClassPath _SlashedCircleCursor_DEPRECATED;

		// Token: 0x0400922E RID: 37422
		internal static int __PropertyOffset_ApplicationScale;

		// Token: 0x0400922F RID: 37423
		internal static int __PropertyOffset_UIScaleRule;

		// Token: 0x04009230 RID: 37424
		internal static int __PropertyOffset_CustomScalingRuleClass;

		// Token: 0x04009231 RID: 37425
		[Nullable(2)]
		private FSoftClassPath _CustomScalingRuleClass;

		// Token: 0x04009232 RID: 37426
		internal static int __PropertyOffset_UIScaleCurve;

		// Token: 0x04009233 RID: 37427
		[Nullable(2)]
		private FRuntimeFloatCurve _UIScaleCurve;

		// Token: 0x04009234 RID: 37428
		internal static int __PropertyOffset_bAllowHighDPIInGameMode;

		// Token: 0x04009235 RID: 37429
		internal static int __PropertyOffset_DesignScreenSize;

		// Token: 0x04009236 RID: 37430
		internal static int __PropertyOffset_bLoadWidgetsOnDedicatedServer;

		// Token: 0x04009237 RID: 37431
		internal static int __PropertyOffset_CursorClasses;

		// Token: 0x04009238 RID: 37432
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _CursorClasses;

		// Token: 0x04009239 RID: 37433
		internal static int __PropertyOffset_CustomScalingRuleClassInstance;

		// Token: 0x0400923A RID: 37434
		internal static int __PropertyOffset_CustomScalingRule;
	}
}
