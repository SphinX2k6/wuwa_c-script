using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C90 RID: 7312
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSDK.KuroSDKManager")]
	[UnrealStructLayout(616, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 616)]
	public class UKuroSDKManager : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C5EE RID: 116206 RVA: 0x0029D17C File Offset: 0x0029B37C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSDKManager._ClassPtr;
		}

		// Token: 0x0601C5EF RID: 116207 RVA: 0x0029D188 File Offset: 0x0029B388
		public UKuroSDKManager() : this(BuiltinUtils.AllocNativeUObject(UKuroSDKManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C5F0 RID: 116208 RVA: 0x0029D1B0 File Offset: 0x0029B3B0
		public UKuroSDKManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroSDKManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170072A2 RID: 29346
		// (get) Token: 0x0601C5F1 RID: 116209 RVA: 0x0029D1E4 File Offset: 0x0029B3E4
		// (set) Token: 0x0601C5F2 RID: 116210 RVA: 0x0029D21D File Offset: 0x0029B41D
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

		// Token: 0x170072A3 RID: 29347
		// (get) Token: 0x0601C5F3 RID: 116211 RVA: 0x0029D240 File Offset: 0x0029B440
		// (set) Token: 0x0601C5F4 RID: 116212 RVA: 0x0029D279 File Offset: 0x0029B479
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

		// Token: 0x170072A4 RID: 29348
		// (get) Token: 0x0601C5F5 RID: 116213 RVA: 0x0029D29C File Offset: 0x0029B49C
		// (set) Token: 0x0601C5F6 RID: 116214 RVA: 0x0029D2D5 File Offset: 0x0029B4D5
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

		// Token: 0x170072A5 RID: 29349
		// (get) Token: 0x0601C5F7 RID: 116215 RVA: 0x0029D2F8 File Offset: 0x0029B4F8
		// (set) Token: 0x0601C5F8 RID: 116216 RVA: 0x0029D331 File Offset: 0x0029B531
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

		// Token: 0x170072A6 RID: 29350
		// (get) Token: 0x0601C5F9 RID: 116217 RVA: 0x0029D354 File Offset: 0x0029B554
		// (set) Token: 0x0601C5FA RID: 116218 RVA: 0x0029D38D File Offset: 0x0029B58D
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

		// Token: 0x170072A7 RID: 29351
		// (get) Token: 0x0601C5FB RID: 116219 RVA: 0x0029D3B0 File Offset: 0x0029B5B0
		// (set) Token: 0x0601C5FC RID: 116220 RVA: 0x0029D3E9 File Offset: 0x0029B5E9
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

		// Token: 0x170072A8 RID: 29352
		// (get) Token: 0x0601C5FD RID: 116221 RVA: 0x0029D40C File Offset: 0x0029B60C
		// (set) Token: 0x0601C5FE RID: 116222 RVA: 0x0029D445 File Offset: 0x0029B645
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

		// Token: 0x170072A9 RID: 29353
		// (get) Token: 0x0601C5FF RID: 116223 RVA: 0x0029D468 File Offset: 0x0029B668
		// (set) Token: 0x0601C600 RID: 116224 RVA: 0x0029D4A1 File Offset: 0x0029B6A1
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

		// Token: 0x170072AA RID: 29354
		// (get) Token: 0x0601C601 RID: 116225 RVA: 0x0029D4C4 File Offset: 0x0029B6C4
		// (set) Token: 0x0601C602 RID: 116226 RVA: 0x0029D4FD File Offset: 0x0029B6FD
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

		// Token: 0x170072AB RID: 29355
		// (get) Token: 0x0601C603 RID: 116227 RVA: 0x0029D520 File Offset: 0x0029B720
		// (set) Token: 0x0601C604 RID: 116228 RVA: 0x0029D559 File Offset: 0x0029B759
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

		// Token: 0x170072AC RID: 29356
		// (get) Token: 0x0601C605 RID: 116229 RVA: 0x0029D57C File Offset: 0x0029B77C
		// (set) Token: 0x0601C606 RID: 116230 RVA: 0x0029D5B5 File Offset: 0x0029B7B5
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

		// Token: 0x170072AD RID: 29357
		// (get) Token: 0x0601C607 RID: 116231 RVA: 0x0029D5D8 File Offset: 0x0029B7D8
		// (set) Token: 0x0601C608 RID: 116232 RVA: 0x0029D611 File Offset: 0x0029B811
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

		// Token: 0x170072AE RID: 29358
		// (get) Token: 0x0601C609 RID: 116233 RVA: 0x0029D634 File Offset: 0x0029B834
		// (set) Token: 0x0601C60A RID: 116234 RVA: 0x0029D66D File Offset: 0x0029B86D
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

		// Token: 0x170072AF RID: 29359
		// (get) Token: 0x0601C60B RID: 116235 RVA: 0x0029D690 File Offset: 0x0029B890
		// (set) Token: 0x0601C60C RID: 116236 RVA: 0x0029D6C9 File Offset: 0x0029B8C9
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

		// Token: 0x170072B0 RID: 29360
		// (get) Token: 0x0601C60D RID: 116237 RVA: 0x0029D6EC File Offset: 0x0029B8EC
		// (set) Token: 0x0601C60E RID: 116238 RVA: 0x0029D725 File Offset: 0x0029B925
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

		// Token: 0x170072B1 RID: 29361
		// (get) Token: 0x0601C60F RID: 116239 RVA: 0x0029D748 File Offset: 0x0029B948
		// (set) Token: 0x0601C610 RID: 116240 RVA: 0x0029D781 File Offset: 0x0029B981
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

		// Token: 0x170072B2 RID: 29362
		// (get) Token: 0x0601C611 RID: 116241 RVA: 0x0029D7A4 File Offset: 0x0029B9A4
		// (set) Token: 0x0601C612 RID: 116242 RVA: 0x0029D7DD File Offset: 0x0029B9DD
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

		// Token: 0x170072B3 RID: 29363
		// (get) Token: 0x0601C613 RID: 116243 RVA: 0x0029D800 File Offset: 0x0029BA00
		// (set) Token: 0x0601C614 RID: 116244 RVA: 0x0029D839 File Offset: 0x0029BA39
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

		// Token: 0x170072B4 RID: 29364
		// (get) Token: 0x0601C615 RID: 116245 RVA: 0x0029D85C File Offset: 0x0029BA5C
		// (set) Token: 0x0601C616 RID: 116246 RVA: 0x0029D895 File Offset: 0x0029BA95
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

		// Token: 0x170072B5 RID: 29365
		// (get) Token: 0x0601C617 RID: 116247 RVA: 0x0029D8B8 File Offset: 0x0029BAB8
		// (set) Token: 0x0601C618 RID: 116248 RVA: 0x0029D8F1 File Offset: 0x0029BAF1
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

		// Token: 0x170072B6 RID: 29366
		// (get) Token: 0x0601C619 RID: 116249 RVA: 0x0029D914 File Offset: 0x0029BB14
		// (set) Token: 0x0601C61A RID: 116250 RVA: 0x0029D94D File Offset: 0x0029BB4D
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

		// Token: 0x170072B7 RID: 29367
		// (get) Token: 0x0601C61B RID: 116251 RVA: 0x0029D970 File Offset: 0x0029BB70
		// (set) Token: 0x0601C61C RID: 116252 RVA: 0x0029D9A9 File Offset: 0x0029BBA9
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

		// Token: 0x170072B8 RID: 29368
		// (get) Token: 0x0601C61D RID: 116253 RVA: 0x0029D9CC File Offset: 0x0029BBCC
		// (set) Token: 0x0601C61E RID: 116254 RVA: 0x0029DA05 File Offset: 0x0029BC05
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

		// Token: 0x170072B9 RID: 29369
		// (get) Token: 0x0601C61F RID: 116255 RVA: 0x0029DA28 File Offset: 0x0029BC28
		// (set) Token: 0x0601C620 RID: 116256 RVA: 0x0029DA61 File Offset: 0x0029BC61
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

		// Token: 0x170072BA RID: 29370
		// (get) Token: 0x0601C621 RID: 116257 RVA: 0x0029DA84 File Offset: 0x0029BC84
		// (set) Token: 0x0601C622 RID: 116258 RVA: 0x0029DABD File Offset: 0x0029BCBD
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

		// Token: 0x170072BB RID: 29371
		// (get) Token: 0x0601C623 RID: 116259 RVA: 0x0029DAE0 File Offset: 0x0029BCE0
		// (set) Token: 0x0601C624 RID: 116260 RVA: 0x0029DB19 File Offset: 0x0029BD19
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

		// Token: 0x170072BC RID: 29372
		// (get) Token: 0x0601C625 RID: 116261 RVA: 0x0029DB3C File Offset: 0x0029BD3C
		// (set) Token: 0x0601C626 RID: 116262 RVA: 0x0029DB75 File Offset: 0x0029BD75
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

		// Token: 0x170072BD RID: 29373
		// (get) Token: 0x0601C627 RID: 116263 RVA: 0x0029DB98 File Offset: 0x0029BD98
		// (set) Token: 0x0601C628 RID: 116264 RVA: 0x0029DBD1 File Offset: 0x0029BDD1
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

		// Token: 0x170072BE RID: 29374
		// (get) Token: 0x0601C629 RID: 116265 RVA: 0x0029DBF4 File Offset: 0x0029BDF4
		// (set) Token: 0x0601C62A RID: 116266 RVA: 0x0029DC2D File Offset: 0x0029BE2D
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

		// Token: 0x0601C62B RID: 116267 RVA: 0x0029DC50 File Offset: 0x0029BE50
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void WriteExternalAchievements(string data)
		{
			UKuroSDKManager.__WriteExternalAchievements_FunctionParams* ptr = stackalloc UKuroSDKManager.__WriteExternalAchievements_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSDKManager.__WriteExternalAchievements_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__WriteExternalAchievements_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->data), data);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__WriteExternalAchievements_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__WriteExternalAchievements_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601C62C RID: 116268 RVA: 0x0029DCB0 File Offset: 0x0029BEB0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void UpdateChannelEvent(string data)
		{
			UKuroSDKManager.__UpdateChannelEvent_FunctionParams* ptr = stackalloc UKuroSDKManager.__UpdateChannelEvent_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSDKManager.__UpdateChannelEvent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__UpdateChannelEvent_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->data), data);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__UpdateChannelEvent_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__UpdateChannelEvent_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601C62D RID: 116269 RVA: 0x0029DD0D File Offset: 0x0029BF0D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void Start()
		{
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__Start_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601C62E RID: 116270 RVA: 0x0029DD24 File Offset: 0x0029BF24
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void ShowVirtualKeyboard(bool state)
		{
			UKuroSDKManager.__ShowVirtualKeyboard_FunctionParams* ptr = stackalloc UKuroSDKManager.__ShowVirtualKeyboard_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroSDKManager.__ShowVirtualKeyboard_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__ShowVirtualKeyboard_NativeFunctionPtr, (void*)ptr, 1);
			ptr->state = state;
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__ShowVirtualKeyboard_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601C62F RID: 116271 RVA: 0x0029DD6A File Offset: 0x0029BF6A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void ShowExternalLogin()
		{
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__ShowExternalLogin_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601C630 RID: 116272 RVA: 0x0029DD7E File Offset: 0x0029BF7E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void ShowExitGameDialog()
		{
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__ShowExitGameDialog_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601C631 RID: 116273 RVA: 0x0029DD94 File Offset: 0x0029BF94
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__Share_NativeFunctionPtr, (void*)ptr, 0);
			TArray<byte> tarray2 = imageData;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->imageData);
			}
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__Share_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601C632 RID: 116274 RVA: 0x0029DE1C File Offset: 0x0029C01C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetWindowsMode(bool mode)
		{
			UKuroSDKManager.__SetWindowsMode_FunctionParams* ptr = stackalloc UKuroSDKManager.__SetWindowsMode_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroSDKManager.__SetWindowsMode_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__SetWindowsMode_NativeFunctionPtr, (void*)ptr, 1);
			ptr->mode = mode;
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__SetWindowsMode_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601C633 RID: 116275 RVA: 0x0029DE64 File Offset: 0x0029C064
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetIfGlobalSdk(bool ifGlobal)
		{
			UKuroSDKManager.__SetIfGlobalSdk_FunctionParams* ptr = stackalloc UKuroSDKManager.__SetIfGlobalSdk_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroSDKManager.__SetIfGlobalSdk_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__SetIfGlobalSdk_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ifGlobal = ifGlobal;
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__SetIfGlobalSdk_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601C634 RID: 116276 RVA: 0x0029DEAC File Offset: 0x0029C0AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetGamePadMode(bool mode)
		{
			UKuroSDKManager.__SetGamePadMode_FunctionParams* ptr = stackalloc UKuroSDKManager.__SetGamePadMode_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroSDKManager.__SetGamePadMode_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__SetGamePadMode_NativeFunctionPtr, (void*)ptr, 1);
			ptr->mode = mode;
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__SetGamePadMode_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601C635 RID: 116277 RVA: 0x0029DEF4 File Offset: 0x0029C0F4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetFont(string data)
		{
			UKuroSDKManager.__SetFont_FunctionParams* ptr = stackalloc UKuroSDKManager.__SetFont_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSDKManager.__SetFont_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__SetFont_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->data), data);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__SetFont_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__SetFont_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601C636 RID: 116278 RVA: 0x0029DF54 File Offset: 0x0029C154
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetCursor(string data)
		{
			UKuroSDKManager.__SetCursor_FunctionParams* ptr = stackalloc UKuroSDKManager.__SetCursor_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSDKManager.__SetCursor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__SetCursor_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->data), data);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__SetCursor_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__SetCursor_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601C637 RID: 116279 RVA: 0x0029DFB4 File Offset: 0x0029C1B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void RequestReviewApp(string data)
		{
			UKuroSDKManager.__RequestReviewApp_FunctionParams* ptr = stackalloc UKuroSDKManager.__RequestReviewApp_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSDKManager.__RequestReviewApp_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__RequestReviewApp_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->data), data);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__RequestReviewApp_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__RequestReviewApp_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601C638 RID: 116280 RVA: 0x0029E011 File Offset: 0x0029C211
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void RequestPhotoPermission()
		{
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__RequestPhotoPermission_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601C639 RID: 116281 RVA: 0x0029E028 File Offset: 0x0029C228
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void QueryProductInfo(string data)
		{
			UKuroSDKManager.__QueryProductInfo_FunctionParams* ptr = stackalloc UKuroSDKManager.__QueryProductInfo_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSDKManager.__QueryProductInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__QueryProductInfo_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->data), data);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__QueryProductInfo_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__QueryProductInfo_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601C63A RID: 116282 RVA: 0x0029E085 File Offset: 0x0029C285
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void QueryExternalAchievements()
		{
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__QueryExternalAchievements_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601C63B RID: 116283 RVA: 0x0029E099 File Offset: 0x0029C299
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void PostSplashScreenEndSuccess()
		{
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__PostSplashScreenEndSuccess_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601C63C RID: 116284 RVA: 0x0029E0B0 File Offset: 0x0029C2B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__OpenWebView_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__OpenWebView_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601C63D RID: 116285 RVA: 0x0029E14C File Offset: 0x0029C34C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void OpenSdkQRScan()
		{
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__OpenSdkQRScan_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601C63E RID: 116286 RVA: 0x0029E160 File Offset: 0x0029C360
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void OpenDefaultWebView(string url)
		{
			UKuroSDKManager.__OpenDefaultWebView_FunctionParams* ptr = stackalloc UKuroSDKManager.__OpenDefaultWebView_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSDKManager.__OpenDefaultWebView_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__OpenDefaultWebView_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->url), url);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__OpenDefaultWebView_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__OpenDefaultWebView_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601C63F RID: 116287 RVA: 0x0029E1C0 File Offset: 0x0029C3C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void OpenCustomerService(string data)
		{
			UKuroSDKManager.__OpenCustomerService_FunctionParams* ptr = stackalloc UKuroSDKManager.__OpenCustomerService_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSDKManager.__OpenCustomerService_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__OpenCustomerService_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->data), data);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__OpenCustomerService_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__OpenCustomerService_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601C640 RID: 116288 RVA: 0x0029E220 File Offset: 0x0029C420
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void LogMarketingEvent(string data)
		{
			UKuroSDKManager.__LogMarketingEvent_FunctionParams* ptr = stackalloc UKuroSDKManager.__LogMarketingEvent_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSDKManager.__LogMarketingEvent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__LogMarketingEvent_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->data), data);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__LogMarketingEvent_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__LogMarketingEvent_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601C641 RID: 116289 RVA: 0x0029E280 File Offset: 0x0029C480
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void KuroSDKEvent(in UKuroSDKEventType iKuroSDKEvent, string sKuroSDKEventParameter)
		{
			UKuroSDKManager.__KuroSDKEvent_FunctionParams* ptr = stackalloc UKuroSDKManager.__KuroSDKEvent_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroSDKManager.__KuroSDKEvent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__KuroSDKEvent_NativeFunctionPtr, (void*)ptr, 1);
			ptr->iKuroSDKEvent = iKuroSDKEvent;
			FString.CopyFrom((void*)(&ptr->sKuroSDKEventParameter), sKuroSDKEventParameter);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__KuroSDKEvent_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__KuroSDKEvent_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601C642 RID: 116290 RVA: 0x0029E2E8 File Offset: 0x0029C4E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool IsUserCenterEnable()
		{
			UKuroSDKManager.__IsUserCenterEnable_FunctionParams* ptr = stackalloc UKuroSDKManager.__IsUserCenterEnable_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroSDKManager.__IsUserCenterEnable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__IsUserCenterEnable_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__IsUserCenterEnable_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601C643 RID: 116291 RVA: 0x0029E330 File Offset: 0x0029C530
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool IsLogin()
		{
			UKuroSDKManager.__IsLogin_FunctionParams* ptr = stackalloc UKuroSDKManager.__IsLogin_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroSDKManager.__IsLogin_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__IsLogin_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__IsLogin_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601C644 RID: 116292 RVA: 0x0029E378 File Offset: 0x0029C578
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool IsCustomerServiceEnable()
		{
			UKuroSDKManager.__IsCustomerServiceEnable_FunctionParams* ptr = stackalloc UKuroSDKManager.__IsCustomerServiceEnable_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroSDKManager.__IsCustomerServiceEnable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__IsCustomerServiceEnable_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__IsCustomerServiceEnable_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601C645 RID: 116293 RVA: 0x0029E3BD File Offset: 0x0029C5BD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void Initialize()
		{
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__Initialize_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601C646 RID: 116294 RVA: 0x0029E3D1 File Offset: 0x0029C5D1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void GetSharePlatform()
		{
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__GetSharePlatform_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601C647 RID: 116295 RVA: 0x0029E3E8 File Offset: 0x0029C5E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static string GetSdkParams(string data)
		{
			UKuroSDKManager.__GetSdkParams_FunctionParams* ptr = stackalloc UKuroSDKManager.__GetSdkParams_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroSDKManager.__GetSdkParams_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__GetSdkParams_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->data), data);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__GetSdkParams_NativeFunctionPtr, (void*)ptr, 0);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__GetSdkParams_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601C648 RID: 116296 RVA: 0x0029E454 File Offset: 0x0029C654
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static string GetSdkLoginInfo()
		{
			UKuroSDKManager.__GetSdkLoginInfo_FunctionParams* ptr = stackalloc UKuroSDKManager.__GetSdkLoginInfo_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSDKManager.__GetSdkLoginInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__GetSdkLoginInfo_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__GetSdkLoginInfo_NativeFunctionPtr, (void*)ptr, 0);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__GetSdkLoginInfo_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601C649 RID: 116297 RVA: 0x0029E4B0 File Offset: 0x0029C6B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool GetSdkIsShowQuitTips()
		{
			UKuroSDKManager.__GetSdkIsShowQuitTips_FunctionParams* ptr = stackalloc UKuroSDKManager.__GetSdkIsShowQuitTips_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroSDKManager.__GetSdkIsShowQuitTips_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__GetSdkIsShowQuitTips_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__GetSdkIsShowQuitTips_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601C64A RID: 116298 RVA: 0x0029E4F8 File Offset: 0x0029C6F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool GetSdkIsQRScan()
		{
			UKuroSDKManager.__GetSdkIsQRScan_FunctionParams* ptr = stackalloc UKuroSDKManager.__GetSdkIsQRScan_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroSDKManager.__GetSdkIsQRScan_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__GetSdkIsQRScan_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__GetSdkIsQRScan_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601C64B RID: 116299 RVA: 0x0029E540 File Offset: 0x0029C740
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool GetSdkInitState()
		{
			UKuroSDKManager.__GetSdkInitState_FunctionParams* ptr = stackalloc UKuroSDKManager.__GetSdkInitState_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroSDKManager.__GetSdkInitState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__GetSdkInitState_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__GetSdkInitState_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601C64C RID: 116300 RVA: 0x0029E588 File Offset: 0x0029C788
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static string GetProjectId()
		{
			UKuroSDKManager.__GetProjectId_FunctionParams* ptr = stackalloc UKuroSDKManager.__GetProjectId_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSDKManager.__GetProjectId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__GetProjectId_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__GetProjectId_NativeFunctionPtr, (void*)ptr, 0);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__GetProjectId_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601C64D RID: 116301 RVA: 0x0029E5E4 File Offset: 0x0029C7E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool GetPostWebViewInitState()
		{
			UKuroSDKManager.__GetPostWebViewInitState_FunctionParams* ptr = stackalloc UKuroSDKManager.__GetPostWebViewInitState_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroSDKManager.__GetPostWebViewInitState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__GetPostWebViewInitState_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__GetPostWebViewInitState_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601C64E RID: 116302 RVA: 0x0029E62C File Offset: 0x0029C82C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static string GetPackageId()
		{
			UKuroSDKManager.__GetPackageId_FunctionParams* ptr = stackalloc UKuroSDKManager.__GetPackageId_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSDKManager.__GetPackageId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__GetPackageId_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__GetPackageId_NativeFunctionPtr, (void*)ptr, 0);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__GetPackageId_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601C64F RID: 116303 RVA: 0x0029E688 File Offset: 0x0029C888
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool GetIsAgreeProtocol()
		{
			UKuroSDKManager.__GetIsAgreeProtocol_FunctionParams* ptr = stackalloc UKuroSDKManager.__GetIsAgreeProtocol_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroSDKManager.__GetIsAgreeProtocol_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__GetIsAgreeProtocol_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__GetIsAgreeProtocol_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601C650 RID: 116304 RVA: 0x0029E6D0 File Offset: 0x0029C8D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static string GetDeepLinkStr()
		{
			UKuroSDKManager.__GetDeepLinkStr_FunctionParams* ptr = stackalloc UKuroSDKManager.__GetDeepLinkStr_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSDKManager.__GetDeepLinkStr_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__GetDeepLinkStr_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__GetDeepLinkStr_NativeFunctionPtr, (void*)ptr, 0);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__GetDeepLinkStr_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601C651 RID: 116305 RVA: 0x0029E72C File Offset: 0x0029C92C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static FLoginStruct GetCurrentLoginInfo()
		{
			UKuroSDKManager.__GetCurrentLoginInfo_FunctionParams* ptr = stackalloc UKuroSDKManager.__GetCurrentLoginInfo_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(UKuroSDKManager.__GetCurrentLoginInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__GetCurrentLoginInfo_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__GetCurrentLoginInfo_NativeFunctionPtr, (void*)ptr, 0);
			FLoginStruct result = new FLoginStruct(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__GetCurrentLoginInfo_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601C652 RID: 116306 RVA: 0x0029E78C File Offset: 0x0029C98C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static string GetChannelName()
		{
			UKuroSDKManager.__GetChannelName_FunctionParams* ptr = stackalloc UKuroSDKManager.__GetChannelName_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSDKManager.__GetChannelName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__GetChannelName_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__GetChannelName_NativeFunctionPtr, (void*)ptr, 0);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__GetChannelName_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601C653 RID: 116307 RVA: 0x0029E7E8 File Offset: 0x0029C9E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static string GetChannelId()
		{
			UKuroSDKManager.__GetChannelId_FunctionParams* ptr = stackalloc UKuroSDKManager.__GetChannelId_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSDKManager.__GetChannelId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__GetChannelId_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__GetChannelId_NativeFunctionPtr, (void*)ptr, 0);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__GetChannelId_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601C654 RID: 116308 RVA: 0x0029E844 File Offset: 0x0029CA44
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static FBasicInfo GetBasicInfo()
		{
			UKuroSDKManager.__GetBasicInfo_FunctionParams* ptr = stackalloc UKuroSDKManager.__GetBasicInfo_FunctionParams[(UIntPtr)87] + 15L / (long)sizeof(UKuroSDKManager.__GetBasicInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__GetBasicInfo_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__GetBasicInfo_NativeFunctionPtr, (void*)ptr, 0);
			FBasicInfo result = new FBasicInfo(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__GetBasicInfo_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601C655 RID: 116309 RVA: 0x0029E8A4 File Offset: 0x0029CAA4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static string GetAppChannelId()
		{
			UKuroSDKManager.__GetAppChannelId_FunctionParams* ptr = stackalloc UKuroSDKManager.__GetAppChannelId_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSDKManager.__GetAppChannelId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__GetAppChannelId_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__GetAppChannelId_NativeFunctionPtr, (void*)ptr, 0);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__GetAppChannelId_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601C656 RID: 116310 RVA: 0x0029E900 File Offset: 0x0029CB00
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static string GetAgreementUrl()
		{
			UKuroSDKManager.__GetAgreementUrl_FunctionParams* ptr = stackalloc UKuroSDKManager.__GetAgreementUrl_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSDKManager.__GetAgreementUrl_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__GetAgreementUrl_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__GetAgreementUrl_NativeFunctionPtr, (void*)ptr, 0);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__GetAgreementUrl_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601C657 RID: 116311 RVA: 0x0029E95C File Offset: 0x0029CB5C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void GetAdsValue(string income, string data)
		{
			UKuroSDKManager.__GetAdsValue_FunctionParams* ptr = stackalloc UKuroSDKManager.__GetAdsValue_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroSDKManager.__GetAdsValue_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__GetAdsValue_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->income), income);
			FString.CopyFrom((void*)(&ptr->data), data);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__GetAdsValue_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__GetAdsValue_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601C658 RID: 116312 RVA: 0x0029E9C8 File Offset: 0x0029CBC8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static UKuroSDKManager Get()
		{
			UKuroSDKManager.__Get_FunctionParams* ptr = stackalloc UKuroSDKManager.__Get_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroSDKManager.__Get_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__Get_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__Get_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroSDKManager>(ptr->__Result);
		}

		// Token: 0x0601C659 RID: 116313 RVA: 0x0029EA14 File Offset: 0x0029CC14
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void FreePlugin(string data)
		{
			UKuroSDKManager.__FreePlugin_FunctionParams* ptr = stackalloc UKuroSDKManager.__FreePlugin_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSDKManager.__FreePlugin_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__FreePlugin_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->data), data);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__FreePlugin_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__FreePlugin_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601C65A RID: 116314 RVA: 0x0029EA71 File Offset: 0x0029CC71
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void ExitGame()
		{
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__ExitGame_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601C65B RID: 116315 RVA: 0x0029EA88 File Offset: 0x0029CC88
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool DoInitSdkProcedure()
		{
			UKuroSDKManager.__DoInitSdkProcedure_FunctionParams* ptr = stackalloc UKuroSDKManager.__DoInitSdkProcedure_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroSDKManager.__DoInitSdkProcedure_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__DoInitSdkProcedure_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__DoInitSdkProcedure_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601C65C RID: 116316 RVA: 0x0029EACD File Offset: 0x0029CCCD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void DoEngineExit()
		{
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__DoEngineExit_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601C65D RID: 116317 RVA: 0x0029EAE4 File Offset: 0x0029CCE4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void CloseWebView(string identifier)
		{
			UKuroSDKManager.__CloseWebView_FunctionParams* ptr = stackalloc UKuroSDKManager.__CloseWebView_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSDKManager.__CloseWebView_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__CloseWebView_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->identifier), identifier);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__CloseWebView_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__CloseWebView_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601C65E RID: 116318 RVA: 0x0029EB41 File Offset: 0x0029CD41
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void ClosePostWebView()
		{
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__ClosePostWebView_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601C65F RID: 116319 RVA: 0x0029EB55 File Offset: 0x0029CD55
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void ClearLoginInfo()
		{
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__ClearLoginInfo_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601C660 RID: 116320 RVA: 0x0029EB6C File Offset: 0x0029CD6C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool CheckPhotoPermission()
		{
			UKuroSDKManager.__CheckPhotoPermission_FunctionParams* ptr = stackalloc UKuroSDKManager.__CheckPhotoPermission_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroSDKManager.__CheckPhotoPermission_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__CheckPhotoPermission_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__CheckPhotoPermission_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601C661 RID: 116321 RVA: 0x0029EBB1 File Offset: 0x0029CDB1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void CheckApplinksActivation()
		{
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__CheckApplinksActivation_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601C662 RID: 116322 RVA: 0x0029EBC8 File Offset: 0x0029CDC8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool CallPluginAsync(string data, [Nullable(2)] in FPluginCallback callback)
		{
			UKuroSDKManager.__CallPluginAsync_FunctionParams* ptr = stackalloc UKuroSDKManager.__CallPluginAsync_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(UKuroSDKManager.__CallPluginAsync_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__CallPluginAsync_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->data), data);
			IntPtr dest = &ptr->callback;
			FPluginCallback fpluginCallback = callback;
			FScriptDelegate.NativeCopy(dest, (fpluginCallback != null) ? fpluginCallback.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__CallPluginAsync_NativeFunctionPtr, (void*)ptr, 0);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__CallPluginAsync_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601C663 RID: 116323 RVA: 0x0029EC48 File Offset: 0x0029CE48
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static string CallPlugin(string data)
		{
			UKuroSDKManager.__CallPlugin_FunctionParams* ptr = stackalloc UKuroSDKManager.__CallPlugin_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroSDKManager.__CallPlugin_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKManager.__CallPlugin_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->data), data);
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__CallPlugin_NativeFunctionPtr, (void*)ptr, 0);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroSDKManager.__CallPlugin_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601C664 RID: 116324 RVA: 0x0029ECB1 File Offset: 0x0029CEB1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void BindAccount()
		{
			UnrealReflectionUtils.CallUFunction(UKuroSDKManager._ClassDefaultObjectPtr, UKuroSDKManager.__BindAccount_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601C665 RID: 116325 RVA: 0x0029ECC5 File Offset: 0x0029CEC5
		static UKuroSDKManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSDK.KuroSDKManager");
		}

		// Token: 0x0601C666 RID: 116326 RVA: 0x0029ECD3 File Offset: 0x0029CED3
		protected UKuroSDKManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F3F8 RID: 62456
		public new const string __ObjectPath = "/Script/KuroSDK.KuroSDKManager";

		// Token: 0x0400F3F9 RID: 62457
		private static IntPtr _ClassPtr;

		// Token: 0x0400F3FA RID: 62458
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F3FB RID: 62459
		internal static int __PropertyOffset_InitDelegate;

		// Token: 0x0400F3FC RID: 62460
		[Nullable(2)]
		private FSDKSdkInitDelegate _InitDelegate;

		// Token: 0x0400F3FD RID: 62461
		internal static int __PropertyOffset_LoginSuccessDelegate;

		// Token: 0x0400F3FE RID: 62462
		[Nullable(2)]
		private FSDKLoginSuccessType _LoginSuccessDelegate;

		// Token: 0x0400F3FF RID: 62463
		internal static int __PropertyOffset_LoginDelegate;

		// Token: 0x0400F400 RID: 62464
		[Nullable(2)]
		private FSDKLoginDelegate _LoginDelegate;

		// Token: 0x0400F401 RID: 62465
		internal static int __PropertyOffset_KickDelegate;

		// Token: 0x0400F402 RID: 62466
		[Nullable(2)]
		private FSDKKickDelegate _KickDelegate;

		// Token: 0x0400F403 RID: 62467
		internal static int __PropertyOffset_LogoutDelegate;

		// Token: 0x0400F404 RID: 62468
		[Nullable(2)]
		private FSDKLogoutDelegate _LogoutDelegate;

		// Token: 0x0400F405 RID: 62469
		internal static int __PropertyOffset_ExitDelegate;

		// Token: 0x0400F406 RID: 62470
		[Nullable(2)]
		private FSDKExitDelegate _ExitDelegate;

		// Token: 0x0400F407 RID: 62471
		internal static int __PropertyOffset_HasExitDelegate;

		// Token: 0x0400F408 RID: 62472
		[Nullable(2)]
		private FSDKHasExitDelegate _HasExitDelegate;

		// Token: 0x0400F409 RID: 62473
		internal static int __PropertyOffset_PaymentDelegate;

		// Token: 0x0400F40A RID: 62474
		[Nullable(2)]
		private FSDKPaymentDelegate _PaymentDelegate;

		// Token: 0x0400F40B RID: 62475
		internal static int __PropertyOffset_PostRedPointDelegate;

		// Token: 0x0400F40C RID: 62476
		[Nullable(2)]
		private FSDKPostRedPointDelegate _PostRedPointDelegate;

		// Token: 0x0400F40D RID: 62477
		internal static int __PropertyOffset_PostProductDelegate;

		// Token: 0x0400F40E RID: 62478
		[Nullable(2)]
		private FSDKProductDelegate _PostProductDelegate;

		// Token: 0x0400F40F RID: 62479
		internal static int __PropertyOffset_ProtocolCallBack;

		// Token: 0x0400F410 RID: 62480
		[Nullable(2)]
		private FSDKProtocolDelegate _ProtocolCallBack;

		// Token: 0x0400F411 RID: 62481
		internal static int __PropertyOffset_GameStateChangeCallBack;

		// Token: 0x0400F412 RID: 62482
		[Nullable(2)]
		private FSDKGameStateChangeDelegate _GameStateChangeCallBack;

		// Token: 0x0400F413 RID: 62483
		internal static int __PropertyOffset_RequestPhotoPermissionDelegate;

		// Token: 0x0400F414 RID: 62484
		[Nullable(2)]
		private FSDKRequestPermissionResultDelagate _RequestPhotoPermissionDelegate;

		// Token: 0x0400F415 RID: 62485
		internal static int __PropertyOffset_AnnounceInitDelegate;

		// Token: 0x0400F416 RID: 62486
		[Nullable(2)]
		private FSDKAnnounceInitDelegate _AnnounceInitDelegate;

		// Token: 0x0400F417 RID: 62487
		internal static int __PropertyOffset_AnnounceOpenDelegate;

		// Token: 0x0400F418 RID: 62488
		[Nullable(2)]
		private FSDKAnnounceOpenDelegate _AnnounceOpenDelegate;

		// Token: 0x0400F419 RID: 62489
		internal static int __PropertyOffset_AnnounceRedPointDelegate;

		// Token: 0x0400F41A RID: 62490
		[Nullable(2)]
		private FSDKAnnounceRedPointDelegate _AnnounceRedPointDelegate;

		// Token: 0x0400F41B RID: 62491
		internal static int __PropertyOffset_CustomerServiceResultDelegate;

		// Token: 0x0400F41C RID: 62492
		[Nullable(2)]
		private FSDKCustomerServiceResultDelegate _CustomerServiceResultDelegate;

		// Token: 0x0400F41D RID: 62493
		internal static int __PropertyOffset_GetParamsDelegate;

		// Token: 0x0400F41E RID: 62494
		[Nullable(2)]
		private FSDKGetParamsDelegate _GetParamsDelegate;

		// Token: 0x0400F41F RID: 62495
		internal static int __PropertyOffset_OnLoginDelegate;

		// Token: 0x0400F420 RID: 62496
		[Nullable(2)]
		private FSDKOnLoginDelegate _OnLoginDelegate;

		// Token: 0x0400F421 RID: 62497
		internal static int __PropertyOffset_DeepLinkDelegate;

		// Token: 0x0400F422 RID: 62498
		[Nullable(2)]
		private FSDKDeepLinkDelegate _DeepLinkDelegate;

		// Token: 0x0400F423 RID: 62499
		internal static int __PropertyOffset_GetAdsValueDelegate;

		// Token: 0x0400F424 RID: 62500
		[Nullable(2)]
		private FSDKGetAdsValueDelegate _GetAdsValueDelegate;

		// Token: 0x0400F425 RID: 62501
		internal static int __PropertyOffset_GetSharePlatformDelegate;

		// Token: 0x0400F426 RID: 62502
		[Nullable(2)]
		private FSDKGetSharePlatformDelegate _GetSharePlatformDelegate;

		// Token: 0x0400F427 RID: 62503
		internal static int __PropertyOffset_ShareResultDelegate;

		// Token: 0x0400F428 RID: 62504
		[Nullable(2)]
		private FSDKShareResultDelegate _ShareResultDelegate;

		// Token: 0x0400F429 RID: 62505
		internal static int __PropertyOffset_LogDelegate;

		// Token: 0x0400F42A RID: 62506
		[Nullable(2)]
		private FSDKLogDelegate _LogDelegate;

		// Token: 0x0400F42B RID: 62507
		internal static int __PropertyOffset_WebViewCloseDelegate;

		// Token: 0x0400F42C RID: 62508
		[Nullable(2)]
		private FSDKWebViewCloseDelegate _WebViewCloseDelegate;

		// Token: 0x0400F42D RID: 62509
		internal static int __PropertyOffset_ExternalLoginCallBack;

		// Token: 0x0400F42E RID: 62510
		[Nullable(2)]
		private FSDKExternalLoginDelegate _ExternalLoginCallBack;

		// Token: 0x0400F42F RID: 62511
		internal static int __PropertyOffset_ExternalQueryAchievementsDelegate;

		// Token: 0x0400F430 RID: 62512
		[Nullable(2)]
		private FSDKExternalQueryAchievementsDelegate _ExternalQueryAchievementsDelegate;

		// Token: 0x0400F431 RID: 62513
		internal static int __PropertyOffset_ExternalWriteAchievementsDelegate;

		// Token: 0x0400F432 RID: 62514
		[Nullable(2)]
		private FSDKExternalWriteAchievementsDelegate _ExternalWriteAchievementsDelegate;

		// Token: 0x0400F433 RID: 62515
		internal static int __PropertyOffset_OnActivatedByApplinksDelegate;

		// Token: 0x0400F434 RID: 62516
		[Nullable(2)]
		private FSDKOnActivatedByApplinks _OnActivatedByApplinksDelegate;

		// Token: 0x0400F435 RID: 62517
		private static IntPtr __WriteExternalAchievements_NativeFunctionPtr;

		// Token: 0x0400F436 RID: 62518
		private static IntPtr __UpdateChannelEvent_NativeFunctionPtr;

		// Token: 0x0400F437 RID: 62519
		private static IntPtr __Start_NativeFunctionPtr;

		// Token: 0x0400F438 RID: 62520
		private static IntPtr __ShowVirtualKeyboard_NativeFunctionPtr;

		// Token: 0x0400F439 RID: 62521
		private static IntPtr __ShowExternalLogin_NativeFunctionPtr;

		// Token: 0x0400F43A RID: 62522
		private static IntPtr __ShowExitGameDialog_NativeFunctionPtr;

		// Token: 0x0400F43B RID: 62523
		private static IntPtr __Share_NativeFunctionPtr;

		// Token: 0x0400F43C RID: 62524
		private static IntPtr __SetWindowsMode_NativeFunctionPtr;

		// Token: 0x0400F43D RID: 62525
		private static IntPtr __SetIfGlobalSdk_NativeFunctionPtr;

		// Token: 0x0400F43E RID: 62526
		private static IntPtr __SetGamePadMode_NativeFunctionPtr;

		// Token: 0x0400F43F RID: 62527
		private static IntPtr __SetFont_NativeFunctionPtr;

		// Token: 0x0400F440 RID: 62528
		private static IntPtr __SetCursor_NativeFunctionPtr;

		// Token: 0x0400F441 RID: 62529
		private static IntPtr __RequestReviewApp_NativeFunctionPtr;

		// Token: 0x0400F442 RID: 62530
		private static IntPtr __RequestPhotoPermission_NativeFunctionPtr;

		// Token: 0x0400F443 RID: 62531
		private static IntPtr __QueryProductInfo_NativeFunctionPtr;

		// Token: 0x0400F444 RID: 62532
		private static IntPtr __QueryExternalAchievements_NativeFunctionPtr;

		// Token: 0x0400F445 RID: 62533
		private static IntPtr __PostSplashScreenEndSuccess_NativeFunctionPtr;

		// Token: 0x0400F446 RID: 62534
		private static IntPtr __OpenWebView_NativeFunctionPtr;

		// Token: 0x0400F447 RID: 62535
		private static IntPtr __OpenSdkQRScan_NativeFunctionPtr;

		// Token: 0x0400F448 RID: 62536
		private static IntPtr __OpenDefaultWebView_NativeFunctionPtr;

		// Token: 0x0400F449 RID: 62537
		private static IntPtr __OpenCustomerService_NativeFunctionPtr;

		// Token: 0x0400F44A RID: 62538
		private static IntPtr __LogMarketingEvent_NativeFunctionPtr;

		// Token: 0x0400F44B RID: 62539
		private static IntPtr __KuroSDKEvent_NativeFunctionPtr;

		// Token: 0x0400F44C RID: 62540
		private static IntPtr __IsUserCenterEnable_NativeFunctionPtr;

		// Token: 0x0400F44D RID: 62541
		private static IntPtr __IsLogin_NativeFunctionPtr;

		// Token: 0x0400F44E RID: 62542
		private static IntPtr __IsCustomerServiceEnable_NativeFunctionPtr;

		// Token: 0x0400F44F RID: 62543
		private static IntPtr __Initialize_NativeFunctionPtr;

		// Token: 0x0400F450 RID: 62544
		private static IntPtr __GetSharePlatform_NativeFunctionPtr;

		// Token: 0x0400F451 RID: 62545
		private static IntPtr __GetSdkParams_NativeFunctionPtr;

		// Token: 0x0400F452 RID: 62546
		private static IntPtr __GetSdkLoginInfo_NativeFunctionPtr;

		// Token: 0x0400F453 RID: 62547
		private static IntPtr __GetSdkIsShowQuitTips_NativeFunctionPtr;

		// Token: 0x0400F454 RID: 62548
		private static IntPtr __GetSdkIsQRScan_NativeFunctionPtr;

		// Token: 0x0400F455 RID: 62549
		private static IntPtr __GetSdkInitState_NativeFunctionPtr;

		// Token: 0x0400F456 RID: 62550
		private static IntPtr __GetProjectId_NativeFunctionPtr;

		// Token: 0x0400F457 RID: 62551
		private static IntPtr __GetPostWebViewInitState_NativeFunctionPtr;

		// Token: 0x0400F458 RID: 62552
		private static IntPtr __GetPackageId_NativeFunctionPtr;

		// Token: 0x0400F459 RID: 62553
		private static IntPtr __GetIsAgreeProtocol_NativeFunctionPtr;

		// Token: 0x0400F45A RID: 62554
		private static IntPtr __GetDeepLinkStr_NativeFunctionPtr;

		// Token: 0x0400F45B RID: 62555
		private static IntPtr __GetCurrentLoginInfo_NativeFunctionPtr;

		// Token: 0x0400F45C RID: 62556
		private static IntPtr __GetChannelName_NativeFunctionPtr;

		// Token: 0x0400F45D RID: 62557
		private static IntPtr __GetChannelId_NativeFunctionPtr;

		// Token: 0x0400F45E RID: 62558
		private static IntPtr __GetBasicInfo_NativeFunctionPtr;

		// Token: 0x0400F45F RID: 62559
		private static IntPtr __GetAppChannelId_NativeFunctionPtr;

		// Token: 0x0400F460 RID: 62560
		private static IntPtr __GetAgreementUrl_NativeFunctionPtr;

		// Token: 0x0400F461 RID: 62561
		private static IntPtr __GetAdsValue_NativeFunctionPtr;

		// Token: 0x0400F462 RID: 62562
		private static IntPtr __Get_NativeFunctionPtr;

		// Token: 0x0400F463 RID: 62563
		private static IntPtr __FreePlugin_NativeFunctionPtr;

		// Token: 0x0400F464 RID: 62564
		private static IntPtr __ExitGame_NativeFunctionPtr;

		// Token: 0x0400F465 RID: 62565
		private static IntPtr __DoInitSdkProcedure_NativeFunctionPtr;

		// Token: 0x0400F466 RID: 62566
		private static IntPtr __DoEngineExit_NativeFunctionPtr;

		// Token: 0x0400F467 RID: 62567
		private static IntPtr __CloseWebView_NativeFunctionPtr;

		// Token: 0x0400F468 RID: 62568
		private static IntPtr __ClosePostWebView_NativeFunctionPtr;

		// Token: 0x0400F469 RID: 62569
		private static IntPtr __ClearLoginInfo_NativeFunctionPtr;

		// Token: 0x0400F46A RID: 62570
		private static IntPtr __CheckPhotoPermission_NativeFunctionPtr;

		// Token: 0x0400F46B RID: 62571
		private static IntPtr __CheckApplinksActivation_NativeFunctionPtr;

		// Token: 0x0400F46C RID: 62572
		private static IntPtr __CallPluginAsync_NativeFunctionPtr;

		// Token: 0x0400F46D RID: 62573
		private static IntPtr __CallPlugin_NativeFunctionPtr;

		// Token: 0x0400F46E RID: 62574
		private static IntPtr __BindAccount_NativeFunctionPtr;

		// Token: 0x02003220 RID: 12832
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __WriteExternalAchievements_FunctionParams
		{
			// Token: 0x0401708A RID: 94346
			[FieldOffset(0)]
			public FString data;
		}

		// Token: 0x02003221 RID: 12833
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __UpdateChannelEvent_FunctionParams
		{
			// Token: 0x0401708B RID: 94347
			[FieldOffset(0)]
			public FString data;
		}

		// Token: 0x02003222 RID: 12834
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __ShowVirtualKeyboard_FunctionParams
		{
			// Token: 0x0401708C RID: 94348
			[FieldOffset(0)]
			public bool state;
		}

		// Token: 0x02003223 RID: 12835
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __Share_FunctionParams
		{
			// Token: 0x0401708D RID: 94349
			[FieldOffset(0)]
			public byte imageData;

			// Token: 0x0401708E RID: 94350
			[FieldOffset(16)]
			public FString sKuroSDKEventParameter;
		}

		// Token: 0x02003224 RID: 12836
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetWindowsMode_FunctionParams
		{
			// Token: 0x0401708F RID: 94351
			[FieldOffset(0)]
			public bool mode;
		}

		// Token: 0x02003225 RID: 12837
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetIfGlobalSdk_FunctionParams
		{
			// Token: 0x04017090 RID: 94352
			[FieldOffset(0)]
			public bool ifGlobal;
		}

		// Token: 0x02003226 RID: 12838
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetGamePadMode_FunctionParams
		{
			// Token: 0x04017091 RID: 94353
			[FieldOffset(0)]
			public bool mode;
		}

		// Token: 0x02003227 RID: 12839
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetFont_FunctionParams
		{
			// Token: 0x04017092 RID: 94354
			[FieldOffset(0)]
			public FString data;
		}

		// Token: 0x02003228 RID: 12840
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetCursor_FunctionParams
		{
			// Token: 0x04017093 RID: 94355
			[FieldOffset(0)]
			public FString data;
		}

		// Token: 0x02003229 RID: 12841
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __RequestReviewApp_FunctionParams
		{
			// Token: 0x04017094 RID: 94356
			[FieldOffset(0)]
			public FString data;
		}

		// Token: 0x0200322A RID: 12842
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __QueryProductInfo_FunctionParams
		{
			// Token: 0x04017095 RID: 94357
			[FieldOffset(0)]
			public FString data;
		}

		// Token: 0x0200322B RID: 12843
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __OpenWebView_FunctionParams
		{
			// Token: 0x04017096 RID: 94358
			[FieldOffset(0)]
			public FString title;

			// Token: 0x04017097 RID: 94359
			[FieldOffset(16)]
			public FString url;

			// Token: 0x04017098 RID: 94360
			[FieldOffset(32)]
			public bool isLandscape;

			// Token: 0x04017099 RID: 94361
			[FieldOffset(33)]
			public bool transparent;

			// Token: 0x0401709A RID: 94362
			[FieldOffset(34)]
			public bool webAccelerated;

			// Token: 0x0401709B RID: 94363
			[FieldOffset(40)]
			public FString identifier;

			// Token: 0x0401709C RID: 94364
			[FieldOffset(56)]
			public FString data;
		}

		// Token: 0x0200322C RID: 12844
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OpenDefaultWebView_FunctionParams
		{
			// Token: 0x0401709D RID: 94365
			[FieldOffset(0)]
			public FString url;
		}

		// Token: 0x0200322D RID: 12845
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OpenCustomerService_FunctionParams
		{
			// Token: 0x0401709E RID: 94366
			[FieldOffset(0)]
			public FString data;
		}

		// Token: 0x0200322E RID: 12846
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __LogMarketingEvent_FunctionParams
		{
			// Token: 0x0401709F RID: 94367
			[FieldOffset(0)]
			public FString data;
		}

		// Token: 0x0200322F RID: 12847
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __KuroSDKEvent_FunctionParams
		{
			// Token: 0x040170A0 RID: 94368
			[FieldOffset(0)]
			public UKuroSDKEventType iKuroSDKEvent;

			// Token: 0x040170A1 RID: 94369
			[FieldOffset(8)]
			public FString sKuroSDKEventParameter;
		}

		// Token: 0x02003230 RID: 12848
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsUserCenterEnable_FunctionParams
		{
			// Token: 0x040170A2 RID: 94370
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003231 RID: 12849
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsLogin_FunctionParams
		{
			// Token: 0x040170A3 RID: 94371
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003232 RID: 12850
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsCustomerServiceEnable_FunctionParams
		{
			// Token: 0x040170A4 RID: 94372
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003233 RID: 12851
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetSdkParams_FunctionParams
		{
			// Token: 0x040170A5 RID: 94373
			[FieldOffset(0)]
			public FString data;

			// Token: 0x040170A6 RID: 94374
			[FieldOffset(16)]
			public FString __Result;
		}

		// Token: 0x02003234 RID: 12852
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetSdkLoginInfo_FunctionParams
		{
			// Token: 0x040170A7 RID: 94375
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x02003235 RID: 12853
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetSdkIsShowQuitTips_FunctionParams
		{
			// Token: 0x040170A8 RID: 94376
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003236 RID: 12854
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetSdkIsQRScan_FunctionParams
		{
			// Token: 0x040170A9 RID: 94377
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003237 RID: 12855
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetSdkInitState_FunctionParams
		{
			// Token: 0x040170AA RID: 94378
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003238 RID: 12856
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetProjectId_FunctionParams
		{
			// Token: 0x040170AB RID: 94379
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x02003239 RID: 12857
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetPostWebViewInitState_FunctionParams
		{
			// Token: 0x040170AC RID: 94380
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x0200323A RID: 12858
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetPackageId_FunctionParams
		{
			// Token: 0x040170AD RID: 94381
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x0200323B RID: 12859
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetIsAgreeProtocol_FunctionParams
		{
			// Token: 0x040170AE RID: 94382
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x0200323C RID: 12860
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetDeepLinkStr_FunctionParams
		{
			// Token: 0x040170AF RID: 94383
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x0200323D RID: 12861
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __GetCurrentLoginInfo_FunctionParams
		{
			// Token: 0x040170B0 RID: 94384
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200323E RID: 12862
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetChannelName_FunctionParams
		{
			// Token: 0x040170B1 RID: 94385
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x0200323F RID: 12863
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetChannelId_FunctionParams
		{
			// Token: 0x040170B2 RID: 94386
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x02003240 RID: 12864
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __GetBasicInfo_FunctionParams
		{
			// Token: 0x040170B3 RID: 94387
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003241 RID: 12865
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetAppChannelId_FunctionParams
		{
			// Token: 0x040170B4 RID: 94388
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x02003242 RID: 12866
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetAgreementUrl_FunctionParams
		{
			// Token: 0x040170B5 RID: 94389
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x02003243 RID: 12867
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetAdsValue_FunctionParams
		{
			// Token: 0x040170B6 RID: 94390
			[FieldOffset(0)]
			public FString income;

			// Token: 0x040170B7 RID: 94391
			[FieldOffset(16)]
			public FString data;
		}

		// Token: 0x02003244 RID: 12868
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __Get_FunctionParams
		{
			// Token: 0x040170B8 RID: 94392
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x02003245 RID: 12869
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FreePlugin_FunctionParams
		{
			// Token: 0x040170B9 RID: 94393
			[FieldOffset(0)]
			public FString data;
		}

		// Token: 0x02003246 RID: 12870
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __DoInitSdkProcedure_FunctionParams
		{
			// Token: 0x040170BA RID: 94394
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003247 RID: 12871
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __CloseWebView_FunctionParams
		{
			// Token: 0x040170BB RID: 94395
			[FieldOffset(0)]
			public FString identifier;
		}

		// Token: 0x02003248 RID: 12872
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __CheckPhotoPermission_FunctionParams
		{
			// Token: 0x040170BC RID: 94396
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003249 RID: 12873
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __CallPluginAsync_FunctionParams
		{
			// Token: 0x040170BD RID: 94397
			[FieldOffset(0)]
			public FString data;

			// Token: 0x040170BE RID: 94398
			[FieldOffset(16)]
			public byte callback;

			// Token: 0x040170BF RID: 94399
			[FieldOffset(56)]
			public bool __Result;
		}

		// Token: 0x0200324A RID: 12874
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __CallPlugin_FunctionParams
		{
			// Token: 0x040170C0 RID: 94400
			[FieldOffset(0)]
			public FString data;

			// Token: 0x040170C1 RID: 94401
			[FieldOffset(16)]
			public FString __Result;
		}
	}
}
