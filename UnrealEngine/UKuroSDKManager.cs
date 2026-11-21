using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000529 RID: 1321
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSDK.KuroSDKManager")]
	[UnrealStructLayout(616, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 616)]
	public class UKuroSDKManager : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007B2D RID: 31533 RVA: 0x000B4C16 File Offset: 0x000B2E16
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSDKManager._ClassPtr;
		}

		// Token: 0x06007B2E RID: 31534 RVA: 0x000B4C24 File Offset: 0x000B2E24
		public UKuroSDKManager() : this(BuiltinUtils.AllocNativeUObject(UKuroSDKManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007B2F RID: 31535 RVA: 0x000B4C4C File Offset: 0x000B2E4C
		public UKuroSDKManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroSDKManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170017F2 RID: 6130
		// (get) Token: 0x06007B30 RID: 31536 RVA: 0x000B4C80 File Offset: 0x000B2E80
		// (set) Token: 0x06007B31 RID: 31537 RVA: 0x000B4CB9 File Offset: 0x000B2EB9
		public FSDKSdkInitDelegate InitDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FSDKSdkInitDelegate result;
				if ((result = this._InitDelegate) == null)
				{
					result = (this._InitDelegate = new FSDKSdkInitDelegate(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_InitDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_InitDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170017F3 RID: 6131
		// (get) Token: 0x06007B32 RID: 31538 RVA: 0x000B4CDC File Offset: 0x000B2EDC
		// (set) Token: 0x06007B33 RID: 31539 RVA: 0x000B4D15 File Offset: 0x000B2F15
		public FSDKLoginSuccessType LoginSuccessDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FSDKLoginSuccessType result;
				if ((result = this._LoginSuccessDelegate) == null)
				{
					result = (this._LoginSuccessDelegate = new FSDKLoginSuccessType(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_LoginSuccessDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_LoginSuccessDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170017F4 RID: 6132
		// (get) Token: 0x06007B34 RID: 31540 RVA: 0x000B4D38 File Offset: 0x000B2F38
		// (set) Token: 0x06007B35 RID: 31541 RVA: 0x000B4D71 File Offset: 0x000B2F71
		public FSDKLoginDelegate LoginDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FSDKLoginDelegate result;
				if ((result = this._LoginDelegate) == null)
				{
					result = (this._LoginDelegate = new FSDKLoginDelegate(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_LoginDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_LoginDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170017F5 RID: 6133
		// (get) Token: 0x06007B36 RID: 31542 RVA: 0x000B4D94 File Offset: 0x000B2F94
		// (set) Token: 0x06007B37 RID: 31543 RVA: 0x000B4DCD File Offset: 0x000B2FCD
		public FSDKKickDelegate KickDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FSDKKickDelegate result;
				if ((result = this._KickDelegate) == null)
				{
					result = (this._KickDelegate = new FSDKKickDelegate(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_KickDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_KickDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170017F6 RID: 6134
		// (get) Token: 0x06007B38 RID: 31544 RVA: 0x000B4DF0 File Offset: 0x000B2FF0
		// (set) Token: 0x06007B39 RID: 31545 RVA: 0x000B4E29 File Offset: 0x000B3029
		public FSDKLogoutDelegate LogoutDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FSDKLogoutDelegate result;
				if ((result = this._LogoutDelegate) == null)
				{
					result = (this._LogoutDelegate = new FSDKLogoutDelegate(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_LogoutDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_LogoutDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170017F7 RID: 6135
		// (get) Token: 0x06007B3A RID: 31546 RVA: 0x000B4E4C File Offset: 0x000B304C
		// (set) Token: 0x06007B3B RID: 31547 RVA: 0x000B4E85 File Offset: 0x000B3085
		public FSDKExitDelegate ExitDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FSDKExitDelegate result;
				if ((result = this._ExitDelegate) == null)
				{
					result = (this._ExitDelegate = new FSDKExitDelegate(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_ExitDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_ExitDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170017F8 RID: 6136
		// (get) Token: 0x06007B3C RID: 31548 RVA: 0x000B4EA8 File Offset: 0x000B30A8
		// (set) Token: 0x06007B3D RID: 31549 RVA: 0x000B4EE1 File Offset: 0x000B30E1
		public FSDKHasExitDelegate HasExitDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FSDKHasExitDelegate result;
				if ((result = this._HasExitDelegate) == null)
				{
					result = (this._HasExitDelegate = new FSDKHasExitDelegate(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_HasExitDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_HasExitDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170017F9 RID: 6137
		// (get) Token: 0x06007B3E RID: 31550 RVA: 0x000B4F04 File Offset: 0x000B3104
		// (set) Token: 0x06007B3F RID: 31551 RVA: 0x000B4F3D File Offset: 0x000B313D
		public FSDKPaymentDelegate PaymentDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FSDKPaymentDelegate result;
				if ((result = this._PaymentDelegate) == null)
				{
					result = (this._PaymentDelegate = new FSDKPaymentDelegate(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_PaymentDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_PaymentDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170017FA RID: 6138
		// (get) Token: 0x06007B40 RID: 31552 RVA: 0x000B4F60 File Offset: 0x000B3160
		// (set) Token: 0x06007B41 RID: 31553 RVA: 0x000B4F99 File Offset: 0x000B3199
		public FSDKPostRedPointDelegate PostRedPointDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FSDKPostRedPointDelegate result;
				if ((result = this._PostRedPointDelegate) == null)
				{
					result = (this._PostRedPointDelegate = new FSDKPostRedPointDelegate(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_PostRedPointDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_PostRedPointDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170017FB RID: 6139
		// (get) Token: 0x06007B42 RID: 31554 RVA: 0x000B4FBC File Offset: 0x000B31BC
		// (set) Token: 0x06007B43 RID: 31555 RVA: 0x000B4FF5 File Offset: 0x000B31F5
		public FSDKProductDelegate PostProductDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FSDKProductDelegate result;
				if ((result = this._PostProductDelegate) == null)
				{
					result = (this._PostProductDelegate = new FSDKProductDelegate(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_PostProductDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_PostProductDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170017FC RID: 6140
		// (get) Token: 0x06007B44 RID: 31556 RVA: 0x000B5018 File Offset: 0x000B3218
		// (set) Token: 0x06007B45 RID: 31557 RVA: 0x000B5051 File Offset: 0x000B3251
		public FSDKProtocolDelegate ProtocolCallBack
		{
			get
			{
				base.FastCheckIsValid();
				FSDKProtocolDelegate result;
				if ((result = this._ProtocolCallBack) == null)
				{
					result = (this._ProtocolCallBack = new FSDKProtocolDelegate(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_ProtocolCallBack, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_ProtocolCallBack, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170017FD RID: 6141
		// (get) Token: 0x06007B46 RID: 31558 RVA: 0x000B5074 File Offset: 0x000B3274
		// (set) Token: 0x06007B47 RID: 31559 RVA: 0x000B50AD File Offset: 0x000B32AD
		public FSDKGameStateChangeDelegate GameStateChangeCallBack
		{
			get
			{
				base.FastCheckIsValid();
				FSDKGameStateChangeDelegate result;
				if ((result = this._GameStateChangeCallBack) == null)
				{
					result = (this._GameStateChangeCallBack = new FSDKGameStateChangeDelegate(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_GameStateChangeCallBack, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_GameStateChangeCallBack, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170017FE RID: 6142
		// (get) Token: 0x06007B48 RID: 31560 RVA: 0x000B50D0 File Offset: 0x000B32D0
		// (set) Token: 0x06007B49 RID: 31561 RVA: 0x000B5109 File Offset: 0x000B3309
		public FSDKRequestPermissionResultDelagate RequestPhotoPermissionDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FSDKRequestPermissionResultDelagate result;
				if ((result = this._RequestPhotoPermissionDelegate) == null)
				{
					result = (this._RequestPhotoPermissionDelegate = new FSDKRequestPermissionResultDelagate(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_RequestPhotoPermissionDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_RequestPhotoPermissionDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170017FF RID: 6143
		// (get) Token: 0x06007B4A RID: 31562 RVA: 0x000B512C File Offset: 0x000B332C
		// (set) Token: 0x06007B4B RID: 31563 RVA: 0x000B5165 File Offset: 0x000B3365
		public FSDKAnnounceInitDelegate AnnounceInitDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FSDKAnnounceInitDelegate result;
				if ((result = this._AnnounceInitDelegate) == null)
				{
					result = (this._AnnounceInitDelegate = new FSDKAnnounceInitDelegate(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_AnnounceInitDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_AnnounceInitDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001800 RID: 6144
		// (get) Token: 0x06007B4C RID: 31564 RVA: 0x000B5188 File Offset: 0x000B3388
		// (set) Token: 0x06007B4D RID: 31565 RVA: 0x000B51C1 File Offset: 0x000B33C1
		public FSDKAnnounceOpenDelegate AnnounceOpenDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FSDKAnnounceOpenDelegate result;
				if ((result = this._AnnounceOpenDelegate) == null)
				{
					result = (this._AnnounceOpenDelegate = new FSDKAnnounceOpenDelegate(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_AnnounceOpenDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_AnnounceOpenDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001801 RID: 6145
		// (get) Token: 0x06007B4E RID: 31566 RVA: 0x000B51E4 File Offset: 0x000B33E4
		// (set) Token: 0x06007B4F RID: 31567 RVA: 0x000B521D File Offset: 0x000B341D
		public FSDKAnnounceRedPointDelegate AnnounceRedPointDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FSDKAnnounceRedPointDelegate result;
				if ((result = this._AnnounceRedPointDelegate) == null)
				{
					result = (this._AnnounceRedPointDelegate = new FSDKAnnounceRedPointDelegate(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_AnnounceRedPointDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_AnnounceRedPointDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001802 RID: 6146
		// (get) Token: 0x06007B50 RID: 31568 RVA: 0x000B5240 File Offset: 0x000B3440
		// (set) Token: 0x06007B51 RID: 31569 RVA: 0x000B5279 File Offset: 0x000B3479
		public FSDKCustomerServiceResultDelegate CustomerServiceResultDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FSDKCustomerServiceResultDelegate result;
				if ((result = this._CustomerServiceResultDelegate) == null)
				{
					result = (this._CustomerServiceResultDelegate = new FSDKCustomerServiceResultDelegate(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_CustomerServiceResultDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_CustomerServiceResultDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001803 RID: 6147
		// (get) Token: 0x06007B52 RID: 31570 RVA: 0x000B529C File Offset: 0x000B349C
		// (set) Token: 0x06007B53 RID: 31571 RVA: 0x000B52D5 File Offset: 0x000B34D5
		public FSDKGetParamsDelegate GetParamsDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FSDKGetParamsDelegate result;
				if ((result = this._GetParamsDelegate) == null)
				{
					result = (this._GetParamsDelegate = new FSDKGetParamsDelegate(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_GetParamsDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_GetParamsDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001804 RID: 6148
		// (get) Token: 0x06007B54 RID: 31572 RVA: 0x000B52F8 File Offset: 0x000B34F8
		// (set) Token: 0x06007B55 RID: 31573 RVA: 0x000B5331 File Offset: 0x000B3531
		public FSDKOnLoginDelegate OnLoginDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FSDKOnLoginDelegate result;
				if ((result = this._OnLoginDelegate) == null)
				{
					result = (this._OnLoginDelegate = new FSDKOnLoginDelegate(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_OnLoginDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_OnLoginDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001805 RID: 6149
		// (get) Token: 0x06007B56 RID: 31574 RVA: 0x000B5354 File Offset: 0x000B3554
		// (set) Token: 0x06007B57 RID: 31575 RVA: 0x000B538D File Offset: 0x000B358D
		public FSDKDeepLinkDelegate DeepLinkDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FSDKDeepLinkDelegate result;
				if ((result = this._DeepLinkDelegate) == null)
				{
					result = (this._DeepLinkDelegate = new FSDKDeepLinkDelegate(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_DeepLinkDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_DeepLinkDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001806 RID: 6150
		// (get) Token: 0x06007B58 RID: 31576 RVA: 0x000B53B0 File Offset: 0x000B35B0
		// (set) Token: 0x06007B59 RID: 31577 RVA: 0x000B53E9 File Offset: 0x000B35E9
		public FSDKGetAdsValueDelegate GetAdsValueDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FSDKGetAdsValueDelegate result;
				if ((result = this._GetAdsValueDelegate) == null)
				{
					result = (this._GetAdsValueDelegate = new FSDKGetAdsValueDelegate(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_GetAdsValueDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_GetAdsValueDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001807 RID: 6151
		// (get) Token: 0x06007B5A RID: 31578 RVA: 0x000B540C File Offset: 0x000B360C
		// (set) Token: 0x06007B5B RID: 31579 RVA: 0x000B5445 File Offset: 0x000B3645
		public FSDKGetSharePlatformDelegate GetSharePlatformDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FSDKGetSharePlatformDelegate result;
				if ((result = this._GetSharePlatformDelegate) == null)
				{
					result = (this._GetSharePlatformDelegate = new FSDKGetSharePlatformDelegate(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_GetSharePlatformDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_GetSharePlatformDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001808 RID: 6152
		// (get) Token: 0x06007B5C RID: 31580 RVA: 0x000B5468 File Offset: 0x000B3668
		// (set) Token: 0x06007B5D RID: 31581 RVA: 0x000B54A1 File Offset: 0x000B36A1
		public FSDKShareResultDelegate ShareResultDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FSDKShareResultDelegate result;
				if ((result = this._ShareResultDelegate) == null)
				{
					result = (this._ShareResultDelegate = new FSDKShareResultDelegate(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_ShareResultDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_ShareResultDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001809 RID: 6153
		// (get) Token: 0x06007B5E RID: 31582 RVA: 0x000B54C4 File Offset: 0x000B36C4
		// (set) Token: 0x06007B5F RID: 31583 RVA: 0x000B54FD File Offset: 0x000B36FD
		public FSDKLogDelegate LogDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FSDKLogDelegate result;
				if ((result = this._LogDelegate) == null)
				{
					result = (this._LogDelegate = new FSDKLogDelegate(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_LogDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_LogDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700180A RID: 6154
		// (get) Token: 0x06007B60 RID: 31584 RVA: 0x000B5520 File Offset: 0x000B3720
		// (set) Token: 0x06007B61 RID: 31585 RVA: 0x000B5559 File Offset: 0x000B3759
		public FSDKWebViewCloseDelegate WebViewCloseDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FSDKWebViewCloseDelegate result;
				if ((result = this._WebViewCloseDelegate) == null)
				{
					result = (this._WebViewCloseDelegate = new FSDKWebViewCloseDelegate(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_WebViewCloseDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_WebViewCloseDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700180B RID: 6155
		// (get) Token: 0x06007B62 RID: 31586 RVA: 0x000B557C File Offset: 0x000B377C
		// (set) Token: 0x06007B63 RID: 31587 RVA: 0x000B55B5 File Offset: 0x000B37B5
		public FSDKExternalLoginDelegate ExternalLoginCallBack
		{
			get
			{
				base.FastCheckIsValid();
				FSDKExternalLoginDelegate result;
				if ((result = this._ExternalLoginCallBack) == null)
				{
					result = (this._ExternalLoginCallBack = new FSDKExternalLoginDelegate(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_ExternalLoginCallBack, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_ExternalLoginCallBack, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700180C RID: 6156
		// (get) Token: 0x06007B64 RID: 31588 RVA: 0x000B55D8 File Offset: 0x000B37D8
		// (set) Token: 0x06007B65 RID: 31589 RVA: 0x000B5611 File Offset: 0x000B3811
		public FSDKExternalQueryAchievementsDelegate ExternalQueryAchievementsDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FSDKExternalQueryAchievementsDelegate result;
				if ((result = this._ExternalQueryAchievementsDelegate) == null)
				{
					result = (this._ExternalQueryAchievementsDelegate = new FSDKExternalQueryAchievementsDelegate(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_ExternalQueryAchievementsDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_ExternalQueryAchievementsDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700180D RID: 6157
		// (get) Token: 0x06007B66 RID: 31590 RVA: 0x000B5634 File Offset: 0x000B3834
		// (set) Token: 0x06007B67 RID: 31591 RVA: 0x000B566D File Offset: 0x000B386D
		public FSDKExternalWriteAchievementsDelegate ExternalWriteAchievementsDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FSDKExternalWriteAchievementsDelegate result;
				if ((result = this._ExternalWriteAchievementsDelegate) == null)
				{
					result = (this._ExternalWriteAchievementsDelegate = new FSDKExternalWriteAchievementsDelegate(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_ExternalWriteAchievementsDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_ExternalWriteAchievementsDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700180E RID: 6158
		// (get) Token: 0x06007B68 RID: 31592 RVA: 0x000B5690 File Offset: 0x000B3890
		// (set) Token: 0x06007B69 RID: 31593 RVA: 0x000B56C9 File Offset: 0x000B38C9
		public FSDKOnActivatedByApplinks OnActivatedByApplinksDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FSDKOnActivatedByApplinks result;
				if ((result = this._OnActivatedByApplinksDelegate) == null)
				{
					result = (this._OnActivatedByApplinksDelegate = new FSDKOnActivatedByApplinks(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_OnActivatedByApplinksDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroSDKManager.__PropertyOffset_OnActivatedByApplinksDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06007B6A RID: 31594 RVA: 0x000B56EC File Offset: 0x000B38EC
		[SkipLocalsInit]
		public unsafe static void WriteExternalAchievements(string data)
		{
			UKuroSDKManager.__WriteExternalAchievements_FunctionParams* ptr = stackalloc UKuroSDKManager.__WriteExternalAchievements_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSDKManager.__WriteExternalAchievements_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__WriteExternalAchievements_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->data), data);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__WriteExternalAchievements_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__WriteExternalAchievements_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007B6B RID: 31595 RVA: 0x000B5748 File Offset: 0x000B3948
		[SkipLocalsInit]
		public unsafe static void UpdateChannelEvent(string data)
		{
			UKuroSDKManager.__UpdateChannelEvent_FunctionParams* ptr = stackalloc UKuroSDKManager.__UpdateChannelEvent_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSDKManager.__UpdateChannelEvent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__UpdateChannelEvent_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->data), data);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__UpdateChannelEvent_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__UpdateChannelEvent_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007B6C RID: 31596 RVA: 0x000B57A4 File Offset: 0x000B39A4
		[SkipLocalsInit]
		public static void Start()
		{
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__Start_NativeFunctionPtr, null);
		}

		// Token: 0x06007B6D RID: 31597 RVA: 0x000B57B8 File Offset: 0x000B39B8
		[SkipLocalsInit]
		public unsafe static void ShowVirtualKeyboard(bool state)
		{
			UKuroSDKManager.__ShowVirtualKeyboard_FunctionParams* ptr = stackalloc UKuroSDKManager.__ShowVirtualKeyboard_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroSDKManager.__ShowVirtualKeyboard_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__ShowVirtualKeyboard_NativeFunctionPtr, (void*)ptr, 1);
			ptr->state = state;
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__ShowVirtualKeyboard_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06007B6E RID: 31598 RVA: 0x000B57FD File Offset: 0x000B39FD
		[SkipLocalsInit]
		public static void ShowExternalLogin()
		{
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__ShowExternalLogin_NativeFunctionPtr, null);
		}

		// Token: 0x06007B6F RID: 31599 RVA: 0x000B5810 File Offset: 0x000B3A10
		[SkipLocalsInit]
		public static void ShowExitGameDialog()
		{
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__ShowExitGameDialog_NativeFunctionPtr, null);
		}

		// Token: 0x06007B70 RID: 31600 RVA: 0x000B5824 File Offset: 0x000B3A24
		[SkipLocalsInit]
		public unsafe static void Share([Nullable(2)] in TArray<byte> imageData, string sKuroSDKEventParameter)
		{
			UKuroSDKManager.__Share_FunctionParams* ptr = stackalloc UKuroSDKManager.__Share_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroSDKManager.__Share_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__Share_NativeFunctionPtr, (void*)ptr, 1);
			TArray<byte> tarray = imageData;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->imageData);
			}
			FString.CopyFrom((void*)(&ptr->sKuroSDKEventParameter), sKuroSDKEventParameter);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__Share_NativeFunctionPtr, (void*)ptr);
			TArray<byte> tarray2 = imageData;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->imageData);
			}
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__Share_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007B71 RID: 31601 RVA: 0x000B58A8 File Offset: 0x000B3AA8
		[SkipLocalsInit]
		public unsafe static void SetWindowsMode(bool mode)
		{
			UKuroSDKManager.__SetWindowsMode_FunctionParams* ptr = stackalloc UKuroSDKManager.__SetWindowsMode_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroSDKManager.__SetWindowsMode_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__SetWindowsMode_NativeFunctionPtr, (void*)ptr, 1);
			ptr->mode = mode;
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__SetWindowsMode_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06007B72 RID: 31602 RVA: 0x000B58F0 File Offset: 0x000B3AF0
		[SkipLocalsInit]
		public unsafe static void SetIfGlobalSdk(bool ifGlobal)
		{
			UKuroSDKManager.__SetIfGlobalSdk_FunctionParams* ptr = stackalloc UKuroSDKManager.__SetIfGlobalSdk_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroSDKManager.__SetIfGlobalSdk_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__SetIfGlobalSdk_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ifGlobal = ifGlobal;
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__SetIfGlobalSdk_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06007B73 RID: 31603 RVA: 0x000B5938 File Offset: 0x000B3B38
		[SkipLocalsInit]
		public unsafe static void SetGamePadMode(bool mode)
		{
			UKuroSDKManager.__SetGamePadMode_FunctionParams* ptr = stackalloc UKuroSDKManager.__SetGamePadMode_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroSDKManager.__SetGamePadMode_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__SetGamePadMode_NativeFunctionPtr, (void*)ptr, 1);
			ptr->mode = mode;
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__SetGamePadMode_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06007B74 RID: 31604 RVA: 0x000B5980 File Offset: 0x000B3B80
		[SkipLocalsInit]
		public unsafe static void SetFont(string data)
		{
			UKuroSDKManager.__SetFont_FunctionParams* ptr = stackalloc UKuroSDKManager.__SetFont_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSDKManager.__SetFont_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__SetFont_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->data), data);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__SetFont_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__SetFont_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007B75 RID: 31605 RVA: 0x000B59DC File Offset: 0x000B3BDC
		[SkipLocalsInit]
		public unsafe static void SetCursor(string data)
		{
			UKuroSDKManager.__SetCursor_FunctionParams* ptr = stackalloc UKuroSDKManager.__SetCursor_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSDKManager.__SetCursor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__SetCursor_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->data), data);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__SetCursor_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__SetCursor_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007B76 RID: 31606 RVA: 0x000B5A38 File Offset: 0x000B3C38
		[SkipLocalsInit]
		public unsafe static void RequestReviewApp(string data)
		{
			UKuroSDKManager.__RequestReviewApp_FunctionParams* ptr = stackalloc UKuroSDKManager.__RequestReviewApp_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSDKManager.__RequestReviewApp_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__RequestReviewApp_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->data), data);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__RequestReviewApp_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__RequestReviewApp_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007B77 RID: 31607 RVA: 0x000B5A94 File Offset: 0x000B3C94
		[SkipLocalsInit]
		public static void RequestPhotoPermission()
		{
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__RequestPhotoPermission_NativeFunctionPtr, null);
		}

		// Token: 0x06007B78 RID: 31608 RVA: 0x000B5AA8 File Offset: 0x000B3CA8
		[SkipLocalsInit]
		public unsafe static void QueryProductInfo(string data)
		{
			UKuroSDKManager.__QueryProductInfo_FunctionParams* ptr = stackalloc UKuroSDKManager.__QueryProductInfo_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSDKManager.__QueryProductInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__QueryProductInfo_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->data), data);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__QueryProductInfo_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__QueryProductInfo_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007B79 RID: 31609 RVA: 0x000B5B04 File Offset: 0x000B3D04
		[SkipLocalsInit]
		public static void QueryExternalAchievements()
		{
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__QueryExternalAchievements_NativeFunctionPtr, null);
		}

		// Token: 0x06007B7A RID: 31610 RVA: 0x000B5B17 File Offset: 0x000B3D17
		[SkipLocalsInit]
		public static void PostSplashScreenEndSuccess()
		{
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__PostSplashScreenEndSuccess_NativeFunctionPtr, null);
		}

		// Token: 0x06007B7B RID: 31611 RVA: 0x000B5B2C File Offset: 0x000B3D2C
		[SkipLocalsInit]
		public unsafe static void OpenWebView(string title, string url, bool isLandscape, bool transparent, bool webAccelerated, string identifier, string data)
		{
			UKuroSDKManager.__OpenWebView_FunctionParams* ptr = stackalloc UKuroSDKManager.__OpenWebView_FunctionParams[(UIntPtr)87] + 15L / (long)sizeof(UKuroSDKManager.__OpenWebView_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__OpenWebView_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->title), title);
			FString.CopyFrom((void*)(&ptr->url), url);
			ptr->isLandscape = isLandscape;
			ptr->transparent = transparent;
			ptr->webAccelerated = webAccelerated;
			FString.CopyFrom((void*)(&ptr->identifier), identifier);
			FString.CopyFrom((void*)(&ptr->data), data);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__OpenWebView_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__OpenWebView_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007B7C RID: 31612 RVA: 0x000B5BC7 File Offset: 0x000B3DC7
		[SkipLocalsInit]
		public static void OpenSdkQRScan()
		{
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__OpenSdkQRScan_NativeFunctionPtr, null);
		}

		// Token: 0x06007B7D RID: 31613 RVA: 0x000B5BDC File Offset: 0x000B3DDC
		[SkipLocalsInit]
		public unsafe static void OpenDefaultWebView(string url)
		{
			UKuroSDKManager.__OpenDefaultWebView_FunctionParams* ptr = stackalloc UKuroSDKManager.__OpenDefaultWebView_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSDKManager.__OpenDefaultWebView_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__OpenDefaultWebView_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->url), url);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__OpenDefaultWebView_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__OpenDefaultWebView_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007B7E RID: 31614 RVA: 0x000B5C38 File Offset: 0x000B3E38
		[SkipLocalsInit]
		public unsafe static void OpenCustomerService(string data)
		{
			UKuroSDKManager.__OpenCustomerService_FunctionParams* ptr = stackalloc UKuroSDKManager.__OpenCustomerService_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSDKManager.__OpenCustomerService_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__OpenCustomerService_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->data), data);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__OpenCustomerService_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__OpenCustomerService_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007B7F RID: 31615 RVA: 0x000B5C94 File Offset: 0x000B3E94
		[SkipLocalsInit]
		public unsafe static void LogMarketingEvent(string data)
		{
			UKuroSDKManager.__LogMarketingEvent_FunctionParams* ptr = stackalloc UKuroSDKManager.__LogMarketingEvent_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSDKManager.__LogMarketingEvent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__LogMarketingEvent_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->data), data);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__LogMarketingEvent_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__LogMarketingEvent_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007B80 RID: 31616 RVA: 0x000B5CF0 File Offset: 0x000B3EF0
		[SkipLocalsInit]
		public unsafe static void KuroSDKEvent(in UKuroSDKEventType iKuroSDKEvent, string sKuroSDKEventParameter)
		{
			UKuroSDKManager.__KuroSDKEvent_FunctionParams* ptr = stackalloc UKuroSDKManager.__KuroSDKEvent_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroSDKManager.__KuroSDKEvent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__KuroSDKEvent_NativeFunctionPtr, (void*)ptr, 1);
			ptr->iKuroSDKEvent = iKuroSDKEvent;
			FString.CopyFrom((void*)(&ptr->sKuroSDKEventParameter), sKuroSDKEventParameter);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__KuroSDKEvent_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__KuroSDKEvent_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007B81 RID: 31617 RVA: 0x000B5D54 File Offset: 0x000B3F54
		[SkipLocalsInit]
		public unsafe static bool IsUserCenterEnable()
		{
			UKuroSDKManager.__IsUserCenterEnable_FunctionParams* ptr = stackalloc UKuroSDKManager.__IsUserCenterEnable_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroSDKManager.__IsUserCenterEnable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__IsUserCenterEnable_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__IsUserCenterEnable_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06007B82 RID: 31618 RVA: 0x000B5D98 File Offset: 0x000B3F98
		[SkipLocalsInit]
		public unsafe static bool IsLogin()
		{
			UKuroSDKManager.__IsLogin_FunctionParams* ptr = stackalloc UKuroSDKManager.__IsLogin_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroSDKManager.__IsLogin_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__IsLogin_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__IsLogin_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06007B83 RID: 31619 RVA: 0x000B5DDC File Offset: 0x000B3FDC
		[SkipLocalsInit]
		public unsafe static bool IsCustomerServiceEnable()
		{
			UKuroSDKManager.__IsCustomerServiceEnable_FunctionParams* ptr = stackalloc UKuroSDKManager.__IsCustomerServiceEnable_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroSDKManager.__IsCustomerServiceEnable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__IsCustomerServiceEnable_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__IsCustomerServiceEnable_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06007B84 RID: 31620 RVA: 0x000B5E20 File Offset: 0x000B4020
		[SkipLocalsInit]
		public static void Initialize()
		{
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__Initialize_NativeFunctionPtr, null);
		}

		// Token: 0x06007B85 RID: 31621 RVA: 0x000B5E33 File Offset: 0x000B4033
		[SkipLocalsInit]
		public static void GetSharePlatform()
		{
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__GetSharePlatform_NativeFunctionPtr, null);
		}

		// Token: 0x06007B86 RID: 31622 RVA: 0x000B5E48 File Offset: 0x000B4048
		[SkipLocalsInit]
		public unsafe static string GetSdkParams(string data)
		{
			UKuroSDKManager.__GetSdkParams_FunctionParams* ptr = stackalloc UKuroSDKManager.__GetSdkParams_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroSDKManager.__GetSdkParams_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__GetSdkParams_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->data), data);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__GetSdkParams_NativeFunctionPtr, (void*)ptr);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__GetSdkParams_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06007B87 RID: 31623 RVA: 0x000B5EB0 File Offset: 0x000B40B0
		[SkipLocalsInit]
		public unsafe static string GetSdkLoginInfo()
		{
			UKuroSDKManager.__GetSdkLoginInfo_FunctionParams* ptr = stackalloc UKuroSDKManager.__GetSdkLoginInfo_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSDKManager.__GetSdkLoginInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__GetSdkLoginInfo_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__GetSdkLoginInfo_NativeFunctionPtr, (void*)ptr);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__GetSdkLoginInfo_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06007B88 RID: 31624 RVA: 0x000B5F0C File Offset: 0x000B410C
		[SkipLocalsInit]
		public unsafe static bool GetSdkIsShowQuitTips()
		{
			UKuroSDKManager.__GetSdkIsShowQuitTips_FunctionParams* ptr = stackalloc UKuroSDKManager.__GetSdkIsShowQuitTips_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroSDKManager.__GetSdkIsShowQuitTips_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__GetSdkIsShowQuitTips_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__GetSdkIsShowQuitTips_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06007B89 RID: 31625 RVA: 0x000B5F50 File Offset: 0x000B4150
		[SkipLocalsInit]
		public unsafe static bool GetSdkIsQRScan()
		{
			UKuroSDKManager.__GetSdkIsQRScan_FunctionParams* ptr = stackalloc UKuroSDKManager.__GetSdkIsQRScan_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroSDKManager.__GetSdkIsQRScan_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__GetSdkIsQRScan_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__GetSdkIsQRScan_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06007B8A RID: 31626 RVA: 0x000B5F94 File Offset: 0x000B4194
		[SkipLocalsInit]
		public unsafe static bool GetSdkInitState()
		{
			UKuroSDKManager.__GetSdkInitState_FunctionParams* ptr = stackalloc UKuroSDKManager.__GetSdkInitState_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroSDKManager.__GetSdkInitState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__GetSdkInitState_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__GetSdkInitState_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06007B8B RID: 31627 RVA: 0x000B5FD8 File Offset: 0x000B41D8
		[SkipLocalsInit]
		public unsafe static string GetProjectId()
		{
			UKuroSDKManager.__GetProjectId_FunctionParams* ptr = stackalloc UKuroSDKManager.__GetProjectId_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSDKManager.__GetProjectId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__GetProjectId_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__GetProjectId_NativeFunctionPtr, (void*)ptr);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__GetProjectId_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06007B8C RID: 31628 RVA: 0x000B6034 File Offset: 0x000B4234
		[SkipLocalsInit]
		public unsafe static bool GetPostWebViewInitState()
		{
			UKuroSDKManager.__GetPostWebViewInitState_FunctionParams* ptr = stackalloc UKuroSDKManager.__GetPostWebViewInitState_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroSDKManager.__GetPostWebViewInitState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__GetPostWebViewInitState_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__GetPostWebViewInitState_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06007B8D RID: 31629 RVA: 0x000B6078 File Offset: 0x000B4278
		[SkipLocalsInit]
		public unsafe static string GetPackageId()
		{
			UKuroSDKManager.__GetPackageId_FunctionParams* ptr = stackalloc UKuroSDKManager.__GetPackageId_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSDKManager.__GetPackageId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__GetPackageId_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__GetPackageId_NativeFunctionPtr, (void*)ptr);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__GetPackageId_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06007B8E RID: 31630 RVA: 0x000B60D4 File Offset: 0x000B42D4
		[SkipLocalsInit]
		public unsafe static bool GetIsAgreeProtocol()
		{
			UKuroSDKManager.__GetIsAgreeProtocol_FunctionParams* ptr = stackalloc UKuroSDKManager.__GetIsAgreeProtocol_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroSDKManager.__GetIsAgreeProtocol_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__GetIsAgreeProtocol_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__GetIsAgreeProtocol_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06007B8F RID: 31631 RVA: 0x000B6118 File Offset: 0x000B4318
		[SkipLocalsInit]
		public unsafe static string GetDeepLinkStr()
		{
			UKuroSDKManager.__GetDeepLinkStr_FunctionParams* ptr = stackalloc UKuroSDKManager.__GetDeepLinkStr_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSDKManager.__GetDeepLinkStr_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__GetDeepLinkStr_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__GetDeepLinkStr_NativeFunctionPtr, (void*)ptr);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__GetDeepLinkStr_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06007B90 RID: 31632 RVA: 0x000B6174 File Offset: 0x000B4374
		[SkipLocalsInit]
		public unsafe static FLoginStruct GetCurrentLoginInfo()
		{
			UKuroSDKManager.__GetCurrentLoginInfo_FunctionParams* ptr = stackalloc UKuroSDKManager.__GetCurrentLoginInfo_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(UKuroSDKManager.__GetCurrentLoginInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__GetCurrentLoginInfo_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__GetCurrentLoginInfo_NativeFunctionPtr, (void*)ptr);
			FLoginStruct result = new FLoginStruct(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__GetCurrentLoginInfo_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06007B91 RID: 31633 RVA: 0x000B61D4 File Offset: 0x000B43D4
		[SkipLocalsInit]
		public unsafe static string GetChannelName()
		{
			UKuroSDKManager.__GetChannelName_FunctionParams* ptr = stackalloc UKuroSDKManager.__GetChannelName_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSDKManager.__GetChannelName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__GetChannelName_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__GetChannelName_NativeFunctionPtr, (void*)ptr);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__GetChannelName_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06007B92 RID: 31634 RVA: 0x000B6230 File Offset: 0x000B4430
		[SkipLocalsInit]
		public unsafe static string GetChannelId()
		{
			UKuroSDKManager.__GetChannelId_FunctionParams* ptr = stackalloc UKuroSDKManager.__GetChannelId_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSDKManager.__GetChannelId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__GetChannelId_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__GetChannelId_NativeFunctionPtr, (void*)ptr);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__GetChannelId_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06007B93 RID: 31635 RVA: 0x000B628C File Offset: 0x000B448C
		[SkipLocalsInit]
		public unsafe static FBasicInfo GetBasicInfo()
		{
			UKuroSDKManager.__GetBasicInfo_FunctionParams* ptr = stackalloc UKuroSDKManager.__GetBasicInfo_FunctionParams[(UIntPtr)87] + 15L / (long)sizeof(UKuroSDKManager.__GetBasicInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__GetBasicInfo_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__GetBasicInfo_NativeFunctionPtr, (void*)ptr);
			FBasicInfo result = new FBasicInfo(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__GetBasicInfo_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06007B94 RID: 31636 RVA: 0x000B62EC File Offset: 0x000B44EC
		[SkipLocalsInit]
		public unsafe static string GetAppChannelId()
		{
			UKuroSDKManager.__GetAppChannelId_FunctionParams* ptr = stackalloc UKuroSDKManager.__GetAppChannelId_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSDKManager.__GetAppChannelId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__GetAppChannelId_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__GetAppChannelId_NativeFunctionPtr, (void*)ptr);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__GetAppChannelId_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06007B95 RID: 31637 RVA: 0x000B6348 File Offset: 0x000B4548
		[SkipLocalsInit]
		public unsafe static string GetAgreementUrl()
		{
			UKuroSDKManager.__GetAgreementUrl_FunctionParams* ptr = stackalloc UKuroSDKManager.__GetAgreementUrl_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSDKManager.__GetAgreementUrl_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__GetAgreementUrl_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__GetAgreementUrl_NativeFunctionPtr, (void*)ptr);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__GetAgreementUrl_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06007B96 RID: 31638 RVA: 0x000B63A4 File Offset: 0x000B45A4
		[SkipLocalsInit]
		public unsafe static void GetAdsValue(string income, string data)
		{
			UKuroSDKManager.__GetAdsValue_FunctionParams* ptr = stackalloc UKuroSDKManager.__GetAdsValue_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroSDKManager.__GetAdsValue_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__GetAdsValue_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->income), income);
			FString.CopyFrom((void*)(&ptr->data), data);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__GetAdsValue_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__GetAdsValue_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007B97 RID: 31639 RVA: 0x000B6410 File Offset: 0x000B4610
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static UKuroSDKManager Get()
		{
			UKuroSDKManager.__Get_FunctionParams* ptr = stackalloc UKuroSDKManager.__Get_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroSDKManager.__Get_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__Get_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__Get_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroSDKManager>(ptr->__Result);
		}

		// Token: 0x06007B98 RID: 31640 RVA: 0x000B645C File Offset: 0x000B465C
		[SkipLocalsInit]
		public unsafe static void FreePlugin(string data)
		{
			UKuroSDKManager.__FreePlugin_FunctionParams* ptr = stackalloc UKuroSDKManager.__FreePlugin_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSDKManager.__FreePlugin_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__FreePlugin_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->data), data);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__FreePlugin_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__FreePlugin_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007B99 RID: 31641 RVA: 0x000B64B8 File Offset: 0x000B46B8
		[SkipLocalsInit]
		public static void ExitGame()
		{
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__ExitGame_NativeFunctionPtr, null);
		}

		// Token: 0x06007B9A RID: 31642 RVA: 0x000B64CC File Offset: 0x000B46CC
		[SkipLocalsInit]
		public unsafe static bool DoInitSdkProcedure()
		{
			UKuroSDKManager.__DoInitSdkProcedure_FunctionParams* ptr = stackalloc UKuroSDKManager.__DoInitSdkProcedure_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroSDKManager.__DoInitSdkProcedure_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__DoInitSdkProcedure_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__DoInitSdkProcedure_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06007B9B RID: 31643 RVA: 0x000B6510 File Offset: 0x000B4710
		[SkipLocalsInit]
		public static void DoEngineExit()
		{
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__DoEngineExit_NativeFunctionPtr, null);
		}

		// Token: 0x06007B9C RID: 31644 RVA: 0x000B6524 File Offset: 0x000B4724
		[SkipLocalsInit]
		public unsafe static void CloseWebView(string identifier)
		{
			UKuroSDKManager.__CloseWebView_FunctionParams* ptr = stackalloc UKuroSDKManager.__CloseWebView_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSDKManager.__CloseWebView_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__CloseWebView_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->identifier), identifier);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__CloseWebView_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__CloseWebView_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007B9D RID: 31645 RVA: 0x000B6580 File Offset: 0x000B4780
		[SkipLocalsInit]
		public static void ClosePostWebView()
		{
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__ClosePostWebView_NativeFunctionPtr, null);
		}

		// Token: 0x06007B9E RID: 31646 RVA: 0x000B6593 File Offset: 0x000B4793
		[SkipLocalsInit]
		public static void ClearLoginInfo()
		{
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__ClearLoginInfo_NativeFunctionPtr, null);
		}

		// Token: 0x06007B9F RID: 31647 RVA: 0x000B65A8 File Offset: 0x000B47A8
		[SkipLocalsInit]
		public unsafe static bool CheckPhotoPermission()
		{
			UKuroSDKManager.__CheckPhotoPermission_FunctionParams* ptr = stackalloc UKuroSDKManager.__CheckPhotoPermission_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroSDKManager.__CheckPhotoPermission_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__CheckPhotoPermission_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__CheckPhotoPermission_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06007BA0 RID: 31648 RVA: 0x000B65EC File Offset: 0x000B47EC
		[SkipLocalsInit]
		public static void CheckApplinksActivation()
		{
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__CheckApplinksActivation_NativeFunctionPtr, null);
		}

		// Token: 0x06007BA1 RID: 31649 RVA: 0x000B6600 File Offset: 0x000B4800
		[SkipLocalsInit]
		public unsafe static bool CallPluginAsync(string data, [Nullable(2)] in FPluginCallback callback)
		{
			UKuroSDKManager.__CallPluginAsync_FunctionParams* ptr = stackalloc UKuroSDKManager.__CallPluginAsync_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(UKuroSDKManager.__CallPluginAsync_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__CallPluginAsync_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->data), data);
			IntPtr dest = &ptr->callback;
			FPluginCallback fpluginCallback = callback;
			FScriptDelegate.NativeCopy(dest, (fpluginCallback != null) ? fpluginCallback.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__CallPluginAsync_NativeFunctionPtr, (void*)ptr);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__CallPluginAsync_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06007BA2 RID: 31650 RVA: 0x000B6680 File Offset: 0x000B4880
		[SkipLocalsInit]
		public unsafe static string CallPlugin(string data)
		{
			UKuroSDKManager.__CallPlugin_FunctionParams* ptr = stackalloc UKuroSDKManager.__CallPlugin_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroSDKManager.__CallPlugin_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__CallPlugin_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->data), data);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__CallPlugin_NativeFunctionPtr, (void*)ptr);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__CallPlugin_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06007BA3 RID: 31651 RVA: 0x000B66E8 File Offset: 0x000B48E8
		[SkipLocalsInit]
		public static void BindAccount()
		{
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__BindAccount_NativeFunctionPtr, null);
		}

		// Token: 0x06007BA4 RID: 31652 RVA: 0x000B66FB File Offset: 0x000B48FB
		static UKuroSDKManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSDK.KuroSDKManager");
		}

		// Token: 0x06007BA5 RID: 31653 RVA: 0x000B6709 File Offset: 0x000B4909
		protected UKuroSDKManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003462 RID: 13410
		public new const string __ObjectPath = "/Script/KuroSDK.KuroSDKManager";

		// Token: 0x04003463 RID: 13411
		private static IntPtr _ClassPtr;

		// Token: 0x04003464 RID: 13412
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003465 RID: 13413
		internal static int __PropertyOffset_InitDelegate;

		// Token: 0x04003466 RID: 13414
		[Nullable(2)]
		private FSDKSdkInitDelegate _InitDelegate;

		// Token: 0x04003467 RID: 13415
		internal static int __PropertyOffset_LoginSuccessDelegate;

		// Token: 0x04003468 RID: 13416
		[Nullable(2)]
		private FSDKLoginSuccessType _LoginSuccessDelegate;

		// Token: 0x04003469 RID: 13417
		internal static int __PropertyOffset_LoginDelegate;

		// Token: 0x0400346A RID: 13418
		[Nullable(2)]
		private FSDKLoginDelegate _LoginDelegate;

		// Token: 0x0400346B RID: 13419
		internal static int __PropertyOffset_KickDelegate;

		// Token: 0x0400346C RID: 13420
		[Nullable(2)]
		private FSDKKickDelegate _KickDelegate;

		// Token: 0x0400346D RID: 13421
		internal static int __PropertyOffset_LogoutDelegate;

		// Token: 0x0400346E RID: 13422
		[Nullable(2)]
		private FSDKLogoutDelegate _LogoutDelegate;

		// Token: 0x0400346F RID: 13423
		internal static int __PropertyOffset_ExitDelegate;

		// Token: 0x04003470 RID: 13424
		[Nullable(2)]
		private FSDKExitDelegate _ExitDelegate;

		// Token: 0x04003471 RID: 13425
		internal static int __PropertyOffset_HasExitDelegate;

		// Token: 0x04003472 RID: 13426
		[Nullable(2)]
		private FSDKHasExitDelegate _HasExitDelegate;

		// Token: 0x04003473 RID: 13427
		internal static int __PropertyOffset_PaymentDelegate;

		// Token: 0x04003474 RID: 13428
		[Nullable(2)]
		private FSDKPaymentDelegate _PaymentDelegate;

		// Token: 0x04003475 RID: 13429
		internal static int __PropertyOffset_PostRedPointDelegate;

		// Token: 0x04003476 RID: 13430
		[Nullable(2)]
		private FSDKPostRedPointDelegate _PostRedPointDelegate;

		// Token: 0x04003477 RID: 13431
		internal static int __PropertyOffset_PostProductDelegate;

		// Token: 0x04003478 RID: 13432
		[Nullable(2)]
		private FSDKProductDelegate _PostProductDelegate;

		// Token: 0x04003479 RID: 13433
		internal static int __PropertyOffset_ProtocolCallBack;

		// Token: 0x0400347A RID: 13434
		[Nullable(2)]
		private FSDKProtocolDelegate _ProtocolCallBack;

		// Token: 0x0400347B RID: 13435
		internal static int __PropertyOffset_GameStateChangeCallBack;

		// Token: 0x0400347C RID: 13436
		[Nullable(2)]
		private FSDKGameStateChangeDelegate _GameStateChangeCallBack;

		// Token: 0x0400347D RID: 13437
		internal static int __PropertyOffset_RequestPhotoPermissionDelegate;

		// Token: 0x0400347E RID: 13438
		[Nullable(2)]
		private FSDKRequestPermissionResultDelagate _RequestPhotoPermissionDelegate;

		// Token: 0x0400347F RID: 13439
		internal static int __PropertyOffset_AnnounceInitDelegate;

		// Token: 0x04003480 RID: 13440
		[Nullable(2)]
		private FSDKAnnounceInitDelegate _AnnounceInitDelegate;

		// Token: 0x04003481 RID: 13441
		internal static int __PropertyOffset_AnnounceOpenDelegate;

		// Token: 0x04003482 RID: 13442
		[Nullable(2)]
		private FSDKAnnounceOpenDelegate _AnnounceOpenDelegate;

		// Token: 0x04003483 RID: 13443
		internal static int __PropertyOffset_AnnounceRedPointDelegate;

		// Token: 0x04003484 RID: 13444
		[Nullable(2)]
		private FSDKAnnounceRedPointDelegate _AnnounceRedPointDelegate;

		// Token: 0x04003485 RID: 13445
		internal static int __PropertyOffset_CustomerServiceResultDelegate;

		// Token: 0x04003486 RID: 13446
		[Nullable(2)]
		private FSDKCustomerServiceResultDelegate _CustomerServiceResultDelegate;

		// Token: 0x04003487 RID: 13447
		internal static int __PropertyOffset_GetParamsDelegate;

		// Token: 0x04003488 RID: 13448
		[Nullable(2)]
		private FSDKGetParamsDelegate _GetParamsDelegate;

		// Token: 0x04003489 RID: 13449
		internal static int __PropertyOffset_OnLoginDelegate;

		// Token: 0x0400348A RID: 13450
		[Nullable(2)]
		private FSDKOnLoginDelegate _OnLoginDelegate;

		// Token: 0x0400348B RID: 13451
		internal static int __PropertyOffset_DeepLinkDelegate;

		// Token: 0x0400348C RID: 13452
		[Nullable(2)]
		private FSDKDeepLinkDelegate _DeepLinkDelegate;

		// Token: 0x0400348D RID: 13453
		internal static int __PropertyOffset_GetAdsValueDelegate;

		// Token: 0x0400348E RID: 13454
		[Nullable(2)]
		private FSDKGetAdsValueDelegate _GetAdsValueDelegate;

		// Token: 0x0400348F RID: 13455
		internal static int __PropertyOffset_GetSharePlatformDelegate;

		// Token: 0x04003490 RID: 13456
		[Nullable(2)]
		private FSDKGetSharePlatformDelegate _GetSharePlatformDelegate;

		// Token: 0x04003491 RID: 13457
		internal static int __PropertyOffset_ShareResultDelegate;

		// Token: 0x04003492 RID: 13458
		[Nullable(2)]
		private FSDKShareResultDelegate _ShareResultDelegate;

		// Token: 0x04003493 RID: 13459
		internal static int __PropertyOffset_LogDelegate;

		// Token: 0x04003494 RID: 13460
		[Nullable(2)]
		private FSDKLogDelegate _LogDelegate;

		// Token: 0x04003495 RID: 13461
		internal static int __PropertyOffset_WebViewCloseDelegate;

		// Token: 0x04003496 RID: 13462
		[Nullable(2)]
		private FSDKWebViewCloseDelegate _WebViewCloseDelegate;

		// Token: 0x04003497 RID: 13463
		internal static int __PropertyOffset_ExternalLoginCallBack;

		// Token: 0x04003498 RID: 13464
		[Nullable(2)]
		private FSDKExternalLoginDelegate _ExternalLoginCallBack;

		// Token: 0x04003499 RID: 13465
		internal static int __PropertyOffset_ExternalQueryAchievementsDelegate;

		// Token: 0x0400349A RID: 13466
		[Nullable(2)]
		private FSDKExternalQueryAchievementsDelegate _ExternalQueryAchievementsDelegate;

		// Token: 0x0400349B RID: 13467
		internal static int __PropertyOffset_ExternalWriteAchievementsDelegate;

		// Token: 0x0400349C RID: 13468
		[Nullable(2)]
		private FSDKExternalWriteAchievementsDelegate _ExternalWriteAchievementsDelegate;

		// Token: 0x0400349D RID: 13469
		internal static int __PropertyOffset_OnActivatedByApplinksDelegate;

		// Token: 0x0400349E RID: 13470
		[Nullable(2)]
		private FSDKOnActivatedByApplinks _OnActivatedByApplinksDelegate;

		// Token: 0x0400349F RID: 13471
		private static IntPtr __WriteExternalAchievements_NativeFunctionPtr;

		// Token: 0x040034A0 RID: 13472
		private static IntPtr __UpdateChannelEvent_NativeFunctionPtr;

		// Token: 0x040034A1 RID: 13473
		private static IntPtr __Start_NativeFunctionPtr;

		// Token: 0x040034A2 RID: 13474
		private static IntPtr __ShowVirtualKeyboard_NativeFunctionPtr;

		// Token: 0x040034A3 RID: 13475
		private static IntPtr __ShowExternalLogin_NativeFunctionPtr;

		// Token: 0x040034A4 RID: 13476
		private static IntPtr __ShowExitGameDialog_NativeFunctionPtr;

		// Token: 0x040034A5 RID: 13477
		private static IntPtr __Share_NativeFunctionPtr;

		// Token: 0x040034A6 RID: 13478
		private static IntPtr __SetWindowsMode_NativeFunctionPtr;

		// Token: 0x040034A7 RID: 13479
		private static IntPtr __SetIfGlobalSdk_NativeFunctionPtr;

		// Token: 0x040034A8 RID: 13480
		private static IntPtr __SetGamePadMode_NativeFunctionPtr;

		// Token: 0x040034A9 RID: 13481
		private static IntPtr __SetFont_NativeFunctionPtr;

		// Token: 0x040034AA RID: 13482
		private static IntPtr __SetCursor_NativeFunctionPtr;

		// Token: 0x040034AB RID: 13483
		private static IntPtr __RequestReviewApp_NativeFunctionPtr;

		// Token: 0x040034AC RID: 13484
		private static IntPtr __RequestPhotoPermission_NativeFunctionPtr;

		// Token: 0x040034AD RID: 13485
		private static IntPtr __QueryProductInfo_NativeFunctionPtr;

		// Token: 0x040034AE RID: 13486
		private static IntPtr __QueryExternalAchievements_NativeFunctionPtr;

		// Token: 0x040034AF RID: 13487
		private static IntPtr __PostSplashScreenEndSuccess_NativeFunctionPtr;

		// Token: 0x040034B0 RID: 13488
		private static IntPtr __OpenWebView_NativeFunctionPtr;

		// Token: 0x040034B1 RID: 13489
		private static IntPtr __OpenSdkQRScan_NativeFunctionPtr;

		// Token: 0x040034B2 RID: 13490
		private static IntPtr __OpenDefaultWebView_NativeFunctionPtr;

		// Token: 0x040034B3 RID: 13491
		private static IntPtr __OpenCustomerService_NativeFunctionPtr;

		// Token: 0x040034B4 RID: 13492
		private static IntPtr __LogMarketingEvent_NativeFunctionPtr;

		// Token: 0x040034B5 RID: 13493
		private static IntPtr __KuroSDKEvent_NativeFunctionPtr;

		// Token: 0x040034B6 RID: 13494
		private static IntPtr __IsUserCenterEnable_NativeFunctionPtr;

		// Token: 0x040034B7 RID: 13495
		private static IntPtr __IsLogin_NativeFunctionPtr;

		// Token: 0x040034B8 RID: 13496
		private static IntPtr __IsCustomerServiceEnable_NativeFunctionPtr;

		// Token: 0x040034B9 RID: 13497
		private static IntPtr __Initialize_NativeFunctionPtr;

		// Token: 0x040034BA RID: 13498
		private static IntPtr __GetSharePlatform_NativeFunctionPtr;

		// Token: 0x040034BB RID: 13499
		private static IntPtr __GetSdkParams_NativeFunctionPtr;

		// Token: 0x040034BC RID: 13500
		private static IntPtr __GetSdkLoginInfo_NativeFunctionPtr;

		// Token: 0x040034BD RID: 13501
		private static IntPtr __GetSdkIsShowQuitTips_NativeFunctionPtr;

		// Token: 0x040034BE RID: 13502
		private static IntPtr __GetSdkIsQRScan_NativeFunctionPtr;

		// Token: 0x040034BF RID: 13503
		private static IntPtr __GetSdkInitState_NativeFunctionPtr;

		// Token: 0x040034C0 RID: 13504
		private static IntPtr __GetProjectId_NativeFunctionPtr;

		// Token: 0x040034C1 RID: 13505
		private static IntPtr __GetPostWebViewInitState_NativeFunctionPtr;

		// Token: 0x040034C2 RID: 13506
		private static IntPtr __GetPackageId_NativeFunctionPtr;

		// Token: 0x040034C3 RID: 13507
		private static IntPtr __GetIsAgreeProtocol_NativeFunctionPtr;

		// Token: 0x040034C4 RID: 13508
		private static IntPtr __GetDeepLinkStr_NativeFunctionPtr;

		// Token: 0x040034C5 RID: 13509
		private static IntPtr __GetCurrentLoginInfo_NativeFunctionPtr;

		// Token: 0x040034C6 RID: 13510
		private static IntPtr __GetChannelName_NativeFunctionPtr;

		// Token: 0x040034C7 RID: 13511
		private static IntPtr __GetChannelId_NativeFunctionPtr;

		// Token: 0x040034C8 RID: 13512
		private static IntPtr __GetBasicInfo_NativeFunctionPtr;

		// Token: 0x040034C9 RID: 13513
		private static IntPtr __GetAppChannelId_NativeFunctionPtr;

		// Token: 0x040034CA RID: 13514
		private static IntPtr __GetAgreementUrl_NativeFunctionPtr;

		// Token: 0x040034CB RID: 13515
		private static IntPtr __GetAdsValue_NativeFunctionPtr;

		// Token: 0x040034CC RID: 13516
		private static IntPtr __Get_NativeFunctionPtr;

		// Token: 0x040034CD RID: 13517
		private static IntPtr __FreePlugin_NativeFunctionPtr;

		// Token: 0x040034CE RID: 13518
		private static IntPtr __ExitGame_NativeFunctionPtr;

		// Token: 0x040034CF RID: 13519
		private static IntPtr __DoInitSdkProcedure_NativeFunctionPtr;

		// Token: 0x040034D0 RID: 13520
		private static IntPtr __DoEngineExit_NativeFunctionPtr;

		// Token: 0x040034D1 RID: 13521
		private static IntPtr __CloseWebView_NativeFunctionPtr;

		// Token: 0x040034D2 RID: 13522
		private static IntPtr __ClosePostWebView_NativeFunctionPtr;

		// Token: 0x040034D3 RID: 13523
		private static IntPtr __ClearLoginInfo_NativeFunctionPtr;

		// Token: 0x040034D4 RID: 13524
		private static IntPtr __CheckPhotoPermission_NativeFunctionPtr;

		// Token: 0x040034D5 RID: 13525
		private static IntPtr __CheckApplinksActivation_NativeFunctionPtr;

		// Token: 0x040034D6 RID: 13526
		private static IntPtr __CallPluginAsync_NativeFunctionPtr;

		// Token: 0x040034D7 RID: 13527
		private static IntPtr __CallPlugin_NativeFunctionPtr;

		// Token: 0x040034D8 RID: 13528
		private static IntPtr __BindAccount_NativeFunctionPtr;

		// Token: 0x02000C95 RID: 3221
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __WriteExternalAchievements_FunctionParams
		{
			// Token: 0x04005EFE RID: 24318
			[FieldOffset(0)]
			public FString data;
		}

		// Token: 0x02000C96 RID: 3222
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __UpdateChannelEvent_FunctionParams
		{
			// Token: 0x04005EFF RID: 24319
			[FieldOffset(0)]
			public FString data;
		}

		// Token: 0x02000C97 RID: 3223
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __ShowVirtualKeyboard_FunctionParams
		{
			// Token: 0x04005F00 RID: 24320
			[FieldOffset(0)]
			public bool state;
		}

		// Token: 0x02000C98 RID: 3224
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __Share_FunctionParams
		{
			// Token: 0x04005F01 RID: 24321
			[FieldOffset(0)]
			public byte imageData;

			// Token: 0x04005F02 RID: 24322
			[FieldOffset(16)]
			public FString sKuroSDKEventParameter;
		}

		// Token: 0x02000C99 RID: 3225
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetWindowsMode_FunctionParams
		{
			// Token: 0x04005F03 RID: 24323
			[FieldOffset(0)]
			public bool mode;
		}

		// Token: 0x02000C9A RID: 3226
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetIfGlobalSdk_FunctionParams
		{
			// Token: 0x04005F04 RID: 24324
			[FieldOffset(0)]
			public bool ifGlobal;
		}

		// Token: 0x02000C9B RID: 3227
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetGamePadMode_FunctionParams
		{
			// Token: 0x04005F05 RID: 24325
			[FieldOffset(0)]
			public bool mode;
		}

		// Token: 0x02000C9C RID: 3228
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetFont_FunctionParams
		{
			// Token: 0x04005F06 RID: 24326
			[FieldOffset(0)]
			public FString data;
		}

		// Token: 0x02000C9D RID: 3229
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetCursor_FunctionParams
		{
			// Token: 0x04005F07 RID: 24327
			[FieldOffset(0)]
			public FString data;
		}

		// Token: 0x02000C9E RID: 3230
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __RequestReviewApp_FunctionParams
		{
			// Token: 0x04005F08 RID: 24328
			[FieldOffset(0)]
			public FString data;
		}

		// Token: 0x02000C9F RID: 3231
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __QueryProductInfo_FunctionParams
		{
			// Token: 0x04005F09 RID: 24329
			[FieldOffset(0)]
			public FString data;
		}

		// Token: 0x02000CA0 RID: 3232
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __OpenWebView_FunctionParams
		{
			// Token: 0x04005F0A RID: 24330
			[FieldOffset(0)]
			public FString title;

			// Token: 0x04005F0B RID: 24331
			[FieldOffset(16)]
			public FString url;

			// Token: 0x04005F0C RID: 24332
			[FieldOffset(32)]
			public bool isLandscape;

			// Token: 0x04005F0D RID: 24333
			[FieldOffset(33)]
			public bool transparent;

			// Token: 0x04005F0E RID: 24334
			[FieldOffset(34)]
			public bool webAccelerated;

			// Token: 0x04005F0F RID: 24335
			[FieldOffset(40)]
			public FString identifier;

			// Token: 0x04005F10 RID: 24336
			[FieldOffset(56)]
			public FString data;
		}

		// Token: 0x02000CA1 RID: 3233
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OpenDefaultWebView_FunctionParams
		{
			// Token: 0x04005F11 RID: 24337
			[FieldOffset(0)]
			public FString url;
		}

		// Token: 0x02000CA2 RID: 3234
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OpenCustomerService_FunctionParams
		{
			// Token: 0x04005F12 RID: 24338
			[FieldOffset(0)]
			public FString data;
		}

		// Token: 0x02000CA3 RID: 3235
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __LogMarketingEvent_FunctionParams
		{
			// Token: 0x04005F13 RID: 24339
			[FieldOffset(0)]
			public FString data;
		}

		// Token: 0x02000CA4 RID: 3236
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __KuroSDKEvent_FunctionParams
		{
			// Token: 0x04005F14 RID: 24340
			[FieldOffset(0)]
			public UKuroSDKEventType iKuroSDKEvent;

			// Token: 0x04005F15 RID: 24341
			[FieldOffset(8)]
			public FString sKuroSDKEventParameter;
		}

		// Token: 0x02000CA5 RID: 3237
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsUserCenterEnable_FunctionParams
		{
			// Token: 0x04005F16 RID: 24342
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02000CA6 RID: 3238
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsLogin_FunctionParams
		{
			// Token: 0x04005F17 RID: 24343
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02000CA7 RID: 3239
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsCustomerServiceEnable_FunctionParams
		{
			// Token: 0x04005F18 RID: 24344
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02000CA8 RID: 3240
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetSdkParams_FunctionParams
		{
			// Token: 0x04005F19 RID: 24345
			[FieldOffset(0)]
			public FString data;

			// Token: 0x04005F1A RID: 24346
			[FieldOffset(16)]
			public FString __Result;
		}

		// Token: 0x02000CA9 RID: 3241
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetSdkLoginInfo_FunctionParams
		{
			// Token: 0x04005F1B RID: 24347
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x02000CAA RID: 3242
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetSdkIsShowQuitTips_FunctionParams
		{
			// Token: 0x04005F1C RID: 24348
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02000CAB RID: 3243
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetSdkIsQRScan_FunctionParams
		{
			// Token: 0x04005F1D RID: 24349
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02000CAC RID: 3244
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetSdkInitState_FunctionParams
		{
			// Token: 0x04005F1E RID: 24350
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02000CAD RID: 3245
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetProjectId_FunctionParams
		{
			// Token: 0x04005F1F RID: 24351
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x02000CAE RID: 3246
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetPostWebViewInitState_FunctionParams
		{
			// Token: 0x04005F20 RID: 24352
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02000CAF RID: 3247
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetPackageId_FunctionParams
		{
			// Token: 0x04005F21 RID: 24353
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x02000CB0 RID: 3248
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetIsAgreeProtocol_FunctionParams
		{
			// Token: 0x04005F22 RID: 24354
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02000CB1 RID: 3249
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetDeepLinkStr_FunctionParams
		{
			// Token: 0x04005F23 RID: 24355
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x02000CB2 RID: 3250
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __GetCurrentLoginInfo_FunctionParams
		{
			// Token: 0x04005F24 RID: 24356
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02000CB3 RID: 3251
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetChannelName_FunctionParams
		{
			// Token: 0x04005F25 RID: 24357
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x02000CB4 RID: 3252
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetChannelId_FunctionParams
		{
			// Token: 0x04005F26 RID: 24358
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x02000CB5 RID: 3253
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __GetBasicInfo_FunctionParams
		{
			// Token: 0x04005F27 RID: 24359
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02000CB6 RID: 3254
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetAppChannelId_FunctionParams
		{
			// Token: 0x04005F28 RID: 24360
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x02000CB7 RID: 3255
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetAgreementUrl_FunctionParams
		{
			// Token: 0x04005F29 RID: 24361
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x02000CB8 RID: 3256
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetAdsValue_FunctionParams
		{
			// Token: 0x04005F2A RID: 24362
			[FieldOffset(0)]
			public FString income;

			// Token: 0x04005F2B RID: 24363
			[FieldOffset(16)]
			public FString data;
		}

		// Token: 0x02000CB9 RID: 3257
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __Get_FunctionParams
		{
			// Token: 0x04005F2C RID: 24364
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x02000CBA RID: 3258
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FreePlugin_FunctionParams
		{
			// Token: 0x04005F2D RID: 24365
			[FieldOffset(0)]
			public FString data;
		}

		// Token: 0x02000CBB RID: 3259
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __DoInitSdkProcedure_FunctionParams
		{
			// Token: 0x04005F2E RID: 24366
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02000CBC RID: 3260
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __CloseWebView_FunctionParams
		{
			// Token: 0x04005F2F RID: 24367
			[FieldOffset(0)]
			public FString identifier;
		}

		// Token: 0x02000CBD RID: 3261
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __CheckPhotoPermission_FunctionParams
		{
			// Token: 0x04005F30 RID: 24368
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02000CBE RID: 3262
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __CallPluginAsync_FunctionParams
		{
			// Token: 0x04005F31 RID: 24369
			[FieldOffset(0)]
			public FString data;

			// Token: 0x04005F32 RID: 24370
			[FieldOffset(16)]
			public byte callback;

			// Token: 0x04005F33 RID: 24371
			[FieldOffset(56)]
			public bool __Result;
		}

		// Token: 0x02000CBF RID: 3263
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __CallPlugin_FunctionParams
		{
			// Token: 0x04005F34 RID: 24372
			[FieldOffset(0)]
			public FString data;

			// Token: 0x04005F35 RID: 24373
			[FieldOffset(16)]
			public FString __Result;
		}
	}
}
