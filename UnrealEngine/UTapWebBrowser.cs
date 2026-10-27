using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028EF RID: 10479
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/TapCommon.TapWebBrowser")]
	[UnrealStructLayout(1240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1240)]
	public class UTapWebBrowser : UTapWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026DDF RID: 159199 RVA: 0x003B4A11 File Offset: 0x003B2C11
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTapWebBrowser._ClassPtr;
		}

		// Token: 0x06026DE0 RID: 159200 RVA: 0x003B4A20 File Offset: 0x003B2C20
		public UTapWebBrowser() : this(BuiltinUtils.AllocNativeUObject(UTapWebBrowser.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026DE1 RID: 159201 RVA: 0x003B4A48 File Offset: 0x003B2C48
		[NullableContext(1)]
		public UTapWebBrowser(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTapWebBrowser.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170095BB RID: 38331
		// (get) Token: 0x06026DE2 RID: 159202 RVA: 0x003B4A7B File Offset: 0x003B2C7B
		// (set) Token: 0x06026DE3 RID: 159203 RVA: 0x003B4A8F File Offset: 0x003B2C8F
		public unsafe UNativeWidgetHost WebBrowser
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNativeWidgetHost>(base.NativePtr / (IntPtr)sizeof(void*) + UTapWebBrowser.__PropertyOffset_WebBrowser);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UTapWebBrowser.__PropertyOffset_WebBrowser, value);
			}
		}

		// Token: 0x170095BC RID: 38332
		// (get) Token: 0x06026DE4 RID: 159204 RVA: 0x003B4AA4 File Offset: 0x003B2CA4
		// (set) Token: 0x06026DE5 RID: 159205 RVA: 0x003B4AB8 File Offset: 0x003B2CB8
		public unsafe UTapButton BTN_GoBack
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTapButton>(base.NativePtr / (IntPtr)sizeof(void*) + UTapWebBrowser.__PropertyOffset_BTN_GoBack);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UTapWebBrowser.__PropertyOffset_BTN_GoBack, value);
			}
		}

		// Token: 0x170095BD RID: 38333
		// (get) Token: 0x06026DE6 RID: 159206 RVA: 0x003B4ACD File Offset: 0x003B2CCD
		// (set) Token: 0x06026DE7 RID: 159207 RVA: 0x003B4AE1 File Offset: 0x003B2CE1
		public unsafe UTapButton BTN_Close
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTapButton>(base.NativePtr / (IntPtr)sizeof(void*) + UTapWebBrowser.__PropertyOffset_BTN_Close);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UTapWebBrowser.__PropertyOffset_BTN_Close, value);
			}
		}

		// Token: 0x170095BE RID: 38334
		// (get) Token: 0x06026DE8 RID: 159208 RVA: 0x003B4AF6 File Offset: 0x003B2CF6
		// (set) Token: 0x06026DE9 RID: 159209 RVA: 0x003B4B0A File Offset: 0x003B2D0A
		public unsafe UTapButton BTN_Retry
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTapButton>(base.NativePtr / (IntPtr)sizeof(void*) + UTapWebBrowser.__PropertyOffset_BTN_Retry);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UTapWebBrowser.__PropertyOffset_BTN_Retry, value);
			}
		}

		// Token: 0x170095BF RID: 38335
		// (get) Token: 0x06026DEA RID: 159210 RVA: 0x003B4B1F File Offset: 0x003B2D1F
		// (set) Token: 0x06026DEB RID: 159211 RVA: 0x003B4B33 File Offset: 0x003B2D33
		public unsafe UTextBlock TB_Retry
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextBlock>(base.NativePtr / (IntPtr)sizeof(void*) + UTapWebBrowser.__PropertyOffset_TB_Retry);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UTapWebBrowser.__PropertyOffset_TB_Retry, value);
			}
		}

		// Token: 0x170095C0 RID: 38336
		// (get) Token: 0x06026DEC RID: 159212 RVA: 0x003B4B48 File Offset: 0x003B2D48
		// (set) Token: 0x06026DED RID: 159213 RVA: 0x003B4B5C File Offset: 0x003B2D5C
		public unsafe UTextBlock TB_ErrorTip
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextBlock>(base.NativePtr / (IntPtr)sizeof(void*) + UTapWebBrowser.__PropertyOffset_TB_ErrorTip);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UTapWebBrowser.__PropertyOffset_TB_ErrorTip, value);
			}
		}

		// Token: 0x170095C1 RID: 38337
		// (get) Token: 0x06026DEE RID: 159214 RVA: 0x003B4B71 File Offset: 0x003B2D71
		// (set) Token: 0x06026DEF RID: 159215 RVA: 0x003B4B85 File Offset: 0x003B2D85
		public unsafe UImage ErrorTipIcon
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UImage>(base.NativePtr / (IntPtr)sizeof(void*) + UTapWebBrowser.__PropertyOffset_ErrorTipIcon);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UTapWebBrowser.__PropertyOffset_ErrorTipIcon, value);
			}
		}

		// Token: 0x170095C2 RID: 38338
		// (get) Token: 0x06026DF0 RID: 159216 RVA: 0x003B4B9A File Offset: 0x003B2D9A
		// (set) Token: 0x06026DF1 RID: 159217 RVA: 0x003B4BAE File Offset: 0x003B2DAE
		public unsafe UPanelWidget RetryPanel
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPanelWidget>(base.NativePtr / (IntPtr)sizeof(void*) + UTapWebBrowser.__PropertyOffset_RetryPanel);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UTapWebBrowser.__PropertyOffset_RetryPanel, value);
			}
		}

		// Token: 0x06026DF2 RID: 159218 RVA: 0x003B4BC3 File Offset: 0x003B2DC3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Reload()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTapWebBrowser.__Reload_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06026DF3 RID: 159219 RVA: 0x003B4BD8 File Offset: 0x003B2DD8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void GoBack()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTapWebBrowser.__GoBack_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06026DF4 RID: 159220 RVA: 0x003B4BED File Offset: 0x003B2DED
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Close()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTapWebBrowser.__Close_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06026DF5 RID: 159221 RVA: 0x003B4C02 File Offset: 0x003B2E02
		static UTapWebBrowser()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/TapCommon.TapWebBrowser");
		}

		// Token: 0x06026DF6 RID: 159222 RVA: 0x003B4C10 File Offset: 0x003B2E10
		protected UTapWebBrowser(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401556F RID: 87407
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/TapCommon.TapWebBrowser";

		// Token: 0x04015570 RID: 87408
		private static IntPtr _ClassPtr;

		// Token: 0x04015571 RID: 87409
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015572 RID: 87410
		internal static int __PropertyOffset_WebBrowser;

		// Token: 0x04015573 RID: 87411
		internal static int __PropertyOffset_BTN_GoBack;

		// Token: 0x04015574 RID: 87412
		internal static int __PropertyOffset_BTN_Close;

		// Token: 0x04015575 RID: 87413
		internal static int __PropertyOffset_BTN_Retry;

		// Token: 0x04015576 RID: 87414
		internal static int __PropertyOffset_TB_Retry;

		// Token: 0x04015577 RID: 87415
		internal static int __PropertyOffset_TB_ErrorTip;

		// Token: 0x04015578 RID: 87416
		internal static int __PropertyOffset_ErrorTipIcon;

		// Token: 0x04015579 RID: 87417
		internal static int __PropertyOffset_RetryPanel;

		// Token: 0x0401557A RID: 87418
		private static IntPtr __Reload_NativeFunctionPtr;

		// Token: 0x0401557B RID: 87419
		private static IntPtr __GoBack_NativeFunctionPtr;

		// Token: 0x0401557C RID: 87420
		private static IntPtr __Close_NativeFunctionPtr;
	}
}
