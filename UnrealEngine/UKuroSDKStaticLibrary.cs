using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200052A RID: 1322
	[UnrealObjectPath("/Script/KuroSDK.KuroSDKStaticLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroSDKStaticLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007BA6 RID: 31654 RVA: 0x000B6712 File Offset: 0x000B4912
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSDKStaticLibrary._ClassPtr;
		}

		// Token: 0x06007BA7 RID: 31655 RVA: 0x000B6720 File Offset: 0x000B4920
		public UKuroSDKStaticLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroSDKStaticLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007BA8 RID: 31656 RVA: 0x000B6748 File Offset: 0x000B4948
		[NullableContext(1)]
		public UKuroSDKStaticLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroSDKStaticLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06007BA9 RID: 31657 RVA: 0x000B677C File Offset: 0x000B497C
		[SkipLocalsInit]
		public unsafe static void ShowVirtualKeyboard(bool state)
		{
			UKuroSDKStaticLibrary.__ShowVirtualKeyboard_FunctionParams* ptr = stackalloc UKuroSDKStaticLibrary.__ShowVirtualKeyboard_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroSDKStaticLibrary.__ShowVirtualKeyboard_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKStaticLibrary.__ShowVirtualKeyboard_NativeFunctionPtr, (void*)ptr, 1);
			ptr->state = state;
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__ShowVirtualKeyboard_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06007BAA RID: 31658 RVA: 0x000B67C1 File Offset: 0x000B49C1
		[SkipLocalsInit]
		public static void ShowExitGameDialog()
		{
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__ShowExitGameDialog_NativeFunctionPtr, null);
		}

		// Token: 0x06007BAB RID: 31659 RVA: 0x000B67D4 File Offset: 0x000B49D4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void ShareTexture(string texturePath, string sKuroSDKEventParameter)
		{
			UKuroSDKStaticLibrary.__ShareTexture_FunctionParams* ptr = stackalloc UKuroSDKStaticLibrary.__ShareTexture_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroSDKStaticLibrary.__ShareTexture_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKStaticLibrary.__ShareTexture_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->texturePath), texturePath);
			FString.CopyFrom((void*)(&ptr->sKuroSDKEventParameter), sKuroSDKEventParameter);
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__ShareTexture_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroSDKStaticLibrary.__ShareTexture_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007BAC RID: 31660 RVA: 0x000B6840 File Offset: 0x000B4A40
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void Share(string imagePath, string sKuroSDKEventParameter)
		{
			UKuroSDKStaticLibrary.__Share_FunctionParams* ptr = stackalloc UKuroSDKStaticLibrary.__Share_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroSDKStaticLibrary.__Share_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKStaticLibrary.__Share_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->imagePath), imagePath);
			FString.CopyFrom((void*)(&ptr->sKuroSDKEventParameter), sKuroSDKEventParameter);
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__Share_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroSDKStaticLibrary.__Share_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007BAD RID: 31661 RVA: 0x000B68AC File Offset: 0x000B4AAC
		[SkipLocalsInit]
		public unsafe static void SetIfGlobalSdk(bool ifGlobal)
		{
			UKuroSDKStaticLibrary.__SetIfGlobalSdk_FunctionParams* ptr = stackalloc UKuroSDKStaticLibrary.__SetIfGlobalSdk_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroSDKStaticLibrary.__SetIfGlobalSdk_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKStaticLibrary.__SetIfGlobalSdk_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ifGlobal = ifGlobal;
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__SetIfGlobalSdk_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06007BAE RID: 31662 RVA: 0x000B68F1 File Offset: 0x000B4AF1
		[SkipLocalsInit]
		public static void PostSplashSuccess()
		{
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__PostSplashSuccess_NativeFunctionPtr, null);
		}

		// Token: 0x06007BAF RID: 31663 RVA: 0x000B6904 File Offset: 0x000B4B04
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void OpenWebView(string title, string url, bool isLandScape, bool transparent, bool webAccelerated, string identifier, string data)
		{
			UKuroSDKStaticLibrary.__OpenWebView_FunctionParams* ptr = stackalloc UKuroSDKStaticLibrary.__OpenWebView_FunctionParams[(UIntPtr)87] + 15L / (long)sizeof(UKuroSDKStaticLibrary.__OpenWebView_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKStaticLibrary.__OpenWebView_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->title), title);
			FString.CopyFrom((void*)(&ptr->url), url);
			ptr->isLandScape = isLandScape;
			ptr->transparent = transparent;
			ptr->webAccelerated = webAccelerated;
			FString.CopyFrom((void*)(&ptr->identifier), identifier);
			FString.CopyFrom((void*)(&ptr->data), data);
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__OpenWebView_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroSDKStaticLibrary.__OpenWebView_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007BB0 RID: 31664 RVA: 0x000B699F File Offset: 0x000B4B9F
		[SkipLocalsInit]
		public static void OpenQRScan()
		{
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__OpenQRScan_NativeFunctionPtr, null);
		}

		// Token: 0x06007BB1 RID: 31665 RVA: 0x000B69B4 File Offset: 0x000B4BB4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void OpenDefaultWebView(string url)
		{
			UKuroSDKStaticLibrary.__OpenDefaultWebView_FunctionParams* ptr = stackalloc UKuroSDKStaticLibrary.__OpenDefaultWebView_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSDKStaticLibrary.__OpenDefaultWebView_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKStaticLibrary.__OpenDefaultWebView_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->url), url);
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__OpenDefaultWebView_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroSDKStaticLibrary.__OpenDefaultWebView_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007BB2 RID: 31666 RVA: 0x000B6A10 File Offset: 0x000B4C10
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void OpenCustomerService(string data)
		{
			UKuroSDKStaticLibrary.__OpenCustomerService_FunctionParams* ptr = stackalloc UKuroSDKStaticLibrary.__OpenCustomerService_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSDKStaticLibrary.__OpenCustomerService_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKStaticLibrary.__OpenCustomerService_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->data), data);
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__OpenCustomerService_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroSDKStaticLibrary.__OpenCustomerService_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007BB3 RID: 31667 RVA: 0x000B6A6C File Offset: 0x000B4C6C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void LogMarketingEvent(string data)
		{
			UKuroSDKStaticLibrary.__LogMarketingEvent_FunctionParams* ptr = stackalloc UKuroSDKStaticLibrary.__LogMarketingEvent_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSDKStaticLibrary.__LogMarketingEvent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKStaticLibrary.__LogMarketingEvent_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->data), data);
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__LogMarketingEvent_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroSDKStaticLibrary.__LogMarketingEvent_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007BB4 RID: 31668 RVA: 0x000B6AC8 File Offset: 0x000B4CC8
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void KuroSDKEvent(in UKuroSDKEventType iKuroSDKEvent, string sKuroSDKEventParameter)
		{
			UKuroSDKStaticLibrary.__KuroSDKEvent_FunctionParams* ptr = stackalloc UKuroSDKStaticLibrary.__KuroSDKEvent_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroSDKStaticLibrary.__KuroSDKEvent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKStaticLibrary.__KuroSDKEvent_NativeFunctionPtr, (void*)ptr, 1);
			ptr->iKuroSDKEvent = iKuroSDKEvent;
			FString.CopyFrom((void*)(&ptr->sKuroSDKEventParameter), sKuroSDKEventParameter);
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__KuroSDKEvent_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroSDKStaticLibrary.__KuroSDKEvent_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007BB5 RID: 31669 RVA: 0x000B6B2C File Offset: 0x000B4D2C
		[SkipLocalsInit]
		public static void IsShowQuitTips()
		{
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__IsShowQuitTips_NativeFunctionPtr, null);
		}

		// Token: 0x06007BB6 RID: 31670 RVA: 0x000B6B3F File Offset: 0x000B4D3F
		[SkipLocalsInit]
		public static void IsCanQRScan()
		{
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__IsCanQRScan_NativeFunctionPtr, null);
		}

		// Token: 0x06007BB7 RID: 31671 RVA: 0x000B6B52 File Offset: 0x000B4D52
		[SkipLocalsInit]
		public static void Initialize()
		{
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__Initialize_NativeFunctionPtr, null);
		}

		// Token: 0x06007BB8 RID: 31672 RVA: 0x000B6B68 File Offset: 0x000B4D68
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void GetSdkParams(string data)
		{
			UKuroSDKStaticLibrary.__GetSdkParams_FunctionParams* ptr = stackalloc UKuroSDKStaticLibrary.__GetSdkParams_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSDKStaticLibrary.__GetSdkParams_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKStaticLibrary.__GetSdkParams_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->data), data);
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__GetSdkParams_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroSDKStaticLibrary.__GetSdkParams_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007BB9 RID: 31673 RVA: 0x000B6BC4 File Offset: 0x000B4DC4
		[SkipLocalsInit]
		public static void GetProjectId()
		{
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__GetProjectId_NativeFunctionPtr, null);
		}

		// Token: 0x06007BBA RID: 31674 RVA: 0x000B6BD8 File Offset: 0x000B4DD8
		[SkipLocalsInit]
		public unsafe static bool GetPostWebViewInitState()
		{
			UKuroSDKStaticLibrary.__GetPostWebViewInitState_FunctionParams* ptr = stackalloc UKuroSDKStaticLibrary.__GetPostWebViewInitState_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroSDKStaticLibrary.__GetPostWebViewInitState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKStaticLibrary.__GetPostWebViewInitState_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__GetPostWebViewInitState_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06007BBB RID: 31675 RVA: 0x000B6C1C File Offset: 0x000B4E1C
		[SkipLocalsInit]
		public unsafe static bool GetIsAgreeProtocol()
		{
			UKuroSDKStaticLibrary.__GetIsAgreeProtocol_FunctionParams* ptr = stackalloc UKuroSDKStaticLibrary.__GetIsAgreeProtocol_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroSDKStaticLibrary.__GetIsAgreeProtocol_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKStaticLibrary.__GetIsAgreeProtocol_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__GetIsAgreeProtocol_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06007BBC RID: 31676 RVA: 0x000B6C60 File Offset: 0x000B4E60
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static FLoginStruct GetCurrentLoginInfo()
		{
			UKuroSDKStaticLibrary.__GetCurrentLoginInfo_FunctionParams* ptr = stackalloc UKuroSDKStaticLibrary.__GetCurrentLoginInfo_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(UKuroSDKStaticLibrary.__GetCurrentLoginInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKStaticLibrary.__GetCurrentLoginInfo_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__GetCurrentLoginInfo_NativeFunctionPtr, (void*)ptr);
			FLoginStruct result = new FLoginStruct(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UKuroSDKStaticLibrary.__GetCurrentLoginInfo_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06007BBD RID: 31677 RVA: 0x000B6CBD File Offset: 0x000B4EBD
		[SkipLocalsInit]
		public static void GetChannelName()
		{
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__GetChannelName_NativeFunctionPtr, null);
		}

		// Token: 0x06007BBE RID: 31678 RVA: 0x000B6CD0 File Offset: 0x000B4ED0
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static string GetChannelId()
		{
			UKuroSDKStaticLibrary.__GetChannelId_FunctionParams* ptr = stackalloc UKuroSDKStaticLibrary.__GetChannelId_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSDKStaticLibrary.__GetChannelId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKStaticLibrary.__GetChannelId_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__GetChannelId_NativeFunctionPtr, (void*)ptr);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroSDKStaticLibrary.__GetChannelId_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06007BBF RID: 31679 RVA: 0x000B6D2B File Offset: 0x000B4F2B
		[SkipLocalsInit]
		public static void GetBaseDeviceInfo()
		{
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__GetBaseDeviceInfo_NativeFunctionPtr, null);
		}

		// Token: 0x06007BC0 RID: 31680 RVA: 0x000B6D3E File Offset: 0x000B4F3E
		[SkipLocalsInit]
		public static void GetAppChannelId()
		{
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__GetAppChannelId_NativeFunctionPtr, null);
		}

		// Token: 0x06007BC1 RID: 31681 RVA: 0x000B6D54 File Offset: 0x000B4F54
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static string GetAndroidGalleryExternalFilePath()
		{
			UKuroSDKStaticLibrary.__GetAndroidGalleryExternalFilePath_FunctionParams* ptr = stackalloc UKuroSDKStaticLibrary.__GetAndroidGalleryExternalFilePath_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSDKStaticLibrary.__GetAndroidGalleryExternalFilePath_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKStaticLibrary.__GetAndroidGalleryExternalFilePath_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__GetAndroidGalleryExternalFilePath_NativeFunctionPtr, (void*)ptr);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroSDKStaticLibrary.__GetAndroidGalleryExternalFilePath_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06007BC2 RID: 31682 RVA: 0x000B6DAF File Offset: 0x000B4FAF
		[SkipLocalsInit]
		public static void GetAgreementUrl()
		{
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__GetAgreementUrl_NativeFunctionPtr, null);
		}

		// Token: 0x06007BC3 RID: 31683 RVA: 0x000B6DC4 File Offset: 0x000B4FC4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void GetAdsValue(string income, string data)
		{
			UKuroSDKStaticLibrary.__GetAdsValue_FunctionParams* ptr = stackalloc UKuroSDKStaticLibrary.__GetAdsValue_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroSDKStaticLibrary.__GetAdsValue_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKStaticLibrary.__GetAdsValue_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->income), income);
			FString.CopyFrom((void*)(&ptr->data), data);
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__GetAdsValue_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroSDKStaticLibrary.__GetAdsValue_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007BC4 RID: 31684 RVA: 0x000B6E30 File Offset: 0x000B5030
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static UKuroSDKManager Get()
		{
			UKuroSDKStaticLibrary.__Get_FunctionParams* ptr = stackalloc UKuroSDKStaticLibrary.__Get_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroSDKStaticLibrary.__Get_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKStaticLibrary.__Get_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__Get_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroSDKManager>(ptr->__Result);
		}

		// Token: 0x06007BC5 RID: 31685 RVA: 0x000B6E79 File Offset: 0x000B5079
		[SkipLocalsInit]
		public static void ClearSdkInstance()
		{
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__ClearSdkInstance_NativeFunctionPtr, null);
		}

		// Token: 0x06007BC6 RID: 31686 RVA: 0x000B6E8C File Offset: 0x000B508C
		static UKuroSDKStaticLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSDK.KuroSDKStaticLibrary");
		}

		// Token: 0x06007BC7 RID: 31687 RVA: 0x000B6E9A File Offset: 0x000B509A
		protected UKuroSDKStaticLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040034D9 RID: 13529
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSDK.KuroSDKStaticLibrary";

		// Token: 0x040034DA RID: 13530
		private static IntPtr _ClassPtr;

		// Token: 0x040034DB RID: 13531
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040034DC RID: 13532
		private static IntPtr __ShowVirtualKeyboard_NativeFunctionPtr;

		// Token: 0x040034DD RID: 13533
		private static IntPtr __ShowExitGameDialog_NativeFunctionPtr;

		// Token: 0x040034DE RID: 13534
		private static IntPtr __ShareTexture_NativeFunctionPtr;

		// Token: 0x040034DF RID: 13535
		private static IntPtr __Share_NativeFunctionPtr;

		// Token: 0x040034E0 RID: 13536
		private static IntPtr __SetIfGlobalSdk_NativeFunctionPtr;

		// Token: 0x040034E1 RID: 13537
		private static IntPtr __PostSplashSuccess_NativeFunctionPtr;

		// Token: 0x040034E2 RID: 13538
		private static IntPtr __OpenWebView_NativeFunctionPtr;

		// Token: 0x040034E3 RID: 13539
		private static IntPtr __OpenQRScan_NativeFunctionPtr;

		// Token: 0x040034E4 RID: 13540
		private static IntPtr __OpenDefaultWebView_NativeFunctionPtr;

		// Token: 0x040034E5 RID: 13541
		private static IntPtr __OpenCustomerService_NativeFunctionPtr;

		// Token: 0x040034E6 RID: 13542
		private static IntPtr __LogMarketingEvent_NativeFunctionPtr;

		// Token: 0x040034E7 RID: 13543
		private static IntPtr __KuroSDKEvent_NativeFunctionPtr;

		// Token: 0x040034E8 RID: 13544
		private static IntPtr __IsShowQuitTips_NativeFunctionPtr;

		// Token: 0x040034E9 RID: 13545
		private static IntPtr __IsCanQRScan_NativeFunctionPtr;

		// Token: 0x040034EA RID: 13546
		private static IntPtr __Initialize_NativeFunctionPtr;

		// Token: 0x040034EB RID: 13547
		private static IntPtr __GetSdkParams_NativeFunctionPtr;

		// Token: 0x040034EC RID: 13548
		private static IntPtr __GetProjectId_NativeFunctionPtr;

		// Token: 0x040034ED RID: 13549
		private static IntPtr __GetPostWebViewInitState_NativeFunctionPtr;

		// Token: 0x040034EE RID: 13550
		private static IntPtr __GetIsAgreeProtocol_NativeFunctionPtr;

		// Token: 0x040034EF RID: 13551
		private static IntPtr __GetCurrentLoginInfo_NativeFunctionPtr;

		// Token: 0x040034F0 RID: 13552
		private static IntPtr __GetChannelName_NativeFunctionPtr;

		// Token: 0x040034F1 RID: 13553
		private static IntPtr __GetChannelId_NativeFunctionPtr;

		// Token: 0x040034F2 RID: 13554
		private static IntPtr __GetBaseDeviceInfo_NativeFunctionPtr;

		// Token: 0x040034F3 RID: 13555
		private static IntPtr __GetAppChannelId_NativeFunctionPtr;

		// Token: 0x040034F4 RID: 13556
		private static IntPtr __GetAndroidGalleryExternalFilePath_NativeFunctionPtr;

		// Token: 0x040034F5 RID: 13557
		private static IntPtr __GetAgreementUrl_NativeFunctionPtr;

		// Token: 0x040034F6 RID: 13558
		private static IntPtr __GetAdsValue_NativeFunctionPtr;

		// Token: 0x040034F7 RID: 13559
		private static IntPtr __Get_NativeFunctionPtr;

		// Token: 0x040034F8 RID: 13560
		private static IntPtr __ClearSdkInstance_NativeFunctionPtr;

		// Token: 0x02000CC0 RID: 3264
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __ShowVirtualKeyboard_FunctionParams
		{
			// Token: 0x04005F36 RID: 24374
			[FieldOffset(0)]
			public bool state;
		}

		// Token: 0x02000CC1 RID: 3265
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __ShareTexture_FunctionParams
		{
			// Token: 0x04005F37 RID: 24375
			[FieldOffset(0)]
			public FString texturePath;

			// Token: 0x04005F38 RID: 24376
			[FieldOffset(16)]
			public FString sKuroSDKEventParameter;
		}

		// Token: 0x02000CC2 RID: 3266
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __Share_FunctionParams
		{
			// Token: 0x04005F39 RID: 24377
			[FieldOffset(0)]
			public FString imagePath;

			// Token: 0x04005F3A RID: 24378
			[FieldOffset(16)]
			public FString sKuroSDKEventParameter;
		}

		// Token: 0x02000CC3 RID: 3267
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetIfGlobalSdk_FunctionParams
		{
			// Token: 0x04005F3B RID: 24379
			[FieldOffset(0)]
			public bool ifGlobal;
		}

		// Token: 0x02000CC4 RID: 3268
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __OpenWebView_FunctionParams
		{
			// Token: 0x04005F3C RID: 24380
			[FieldOffset(0)]
			public FString title;

			// Token: 0x04005F3D RID: 24381
			[FieldOffset(16)]
			public FString url;

			// Token: 0x04005F3E RID: 24382
			[FieldOffset(32)]
			public bool isLandScape;

			// Token: 0x04005F3F RID: 24383
			[FieldOffset(33)]
			public bool transparent;

			// Token: 0x04005F40 RID: 24384
			[FieldOffset(34)]
			public bool webAccelerated;

			// Token: 0x04005F41 RID: 24385
			[FieldOffset(40)]
			public FString identifier;

			// Token: 0x04005F42 RID: 24386
			[FieldOffset(56)]
			public FString data;
		}

		// Token: 0x02000CC5 RID: 3269
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OpenDefaultWebView_FunctionParams
		{
			// Token: 0x04005F43 RID: 24387
			[FieldOffset(0)]
			public FString url;
		}

		// Token: 0x02000CC6 RID: 3270
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OpenCustomerService_FunctionParams
		{
			// Token: 0x04005F44 RID: 24388
			[FieldOffset(0)]
			public FString data;
		}

		// Token: 0x02000CC7 RID: 3271
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __LogMarketingEvent_FunctionParams
		{
			// Token: 0x04005F45 RID: 24389
			[FieldOffset(0)]
			public FString data;
		}

		// Token: 0x02000CC8 RID: 3272
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __KuroSDKEvent_FunctionParams
		{
			// Token: 0x04005F46 RID: 24390
			[FieldOffset(0)]
			public UKuroSDKEventType iKuroSDKEvent;

			// Token: 0x04005F47 RID: 24391
			[FieldOffset(8)]
			public FString sKuroSDKEventParameter;
		}

		// Token: 0x02000CC9 RID: 3273
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetSdkParams_FunctionParams
		{
			// Token: 0x04005F48 RID: 24392
			[FieldOffset(0)]
			public FString data;
		}

		// Token: 0x02000CCA RID: 3274
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetPostWebViewInitState_FunctionParams
		{
			// Token: 0x04005F49 RID: 24393
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02000CCB RID: 3275
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetIsAgreeProtocol_FunctionParams
		{
			// Token: 0x04005F4A RID: 24394
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02000CCC RID: 3276
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __GetCurrentLoginInfo_FunctionParams
		{
			// Token: 0x04005F4B RID: 24395
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02000CCD RID: 3277
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetChannelId_FunctionParams
		{
			// Token: 0x04005F4C RID: 24396
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x02000CCE RID: 3278
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetAndroidGalleryExternalFilePath_FunctionParams
		{
			// Token: 0x04005F4D RID: 24397
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x02000CCF RID: 3279
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetAdsValue_FunctionParams
		{
			// Token: 0x04005F4E RID: 24398
			[FieldOffset(0)]
			public FString income;

			// Token: 0x04005F4F RID: 24399
			[FieldOffset(16)]
			public FString data;
		}

		// Token: 0x02000CD0 RID: 3280
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __Get_FunctionParams
		{
			// Token: 0x04005F50 RID: 24400
			[FieldOffset(0)]
			public IntPtr __Result;
		}
	}
}
