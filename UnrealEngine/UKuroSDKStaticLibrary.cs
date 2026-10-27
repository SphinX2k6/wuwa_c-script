using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C91 RID: 7313
	[UnrealObjectPath("/Script/KuroSDK.KuroSDKStaticLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroSDKStaticLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C667 RID: 116327 RVA: 0x0029ECDC File Offset: 0x0029CEDC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSDKStaticLibrary._ClassPtr;
		}

		// Token: 0x0601C668 RID: 116328 RVA: 0x0029ECE8 File Offset: 0x0029CEE8
		public UKuroSDKStaticLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroSDKStaticLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C669 RID: 116329 RVA: 0x0029ED10 File Offset: 0x0029CF10
		[NullableContext(1)]
		public UKuroSDKStaticLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroSDKStaticLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601C66A RID: 116330 RVA: 0x0029ED44 File Offset: 0x0029CF44
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void ShowVirtualKeyboard(bool state)
		{
			UKuroSDKStaticLibrary.__ShowVirtualKeyboard_FunctionParams* ptr = stackalloc UKuroSDKStaticLibrary.__ShowVirtualKeyboard_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroSDKStaticLibrary.__ShowVirtualKeyboard_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKStaticLibrary.__ShowVirtualKeyboard_NativeFunctionPtr, (void*)ptr, 1);
			ptr->state = state;
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__ShowVirtualKeyboard_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601C66B RID: 116331 RVA: 0x0029ED8A File Offset: 0x0029CF8A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void ShowExitGameDialog()
		{
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__ShowExitGameDialog_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601C66C RID: 116332 RVA: 0x0029EDA0 File Offset: 0x0029CFA0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void ShareTexture(string texturePath, string sKuroSDKEventParameter)
		{
			UKuroSDKStaticLibrary.__ShareTexture_FunctionParams* ptr = stackalloc UKuroSDKStaticLibrary.__ShareTexture_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroSDKStaticLibrary.__ShareTexture_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKStaticLibrary.__ShareTexture_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->texturePath), texturePath);
			FString.CopyFrom((void*)(&ptr->sKuroSDKEventParameter), sKuroSDKEventParameter);
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__ShareTexture_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroSDKStaticLibrary.__ShareTexture_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601C66D RID: 116333 RVA: 0x0029EE0C File Offset: 0x0029D00C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void Share(string imagePath, string sKuroSDKEventParameter)
		{
			UKuroSDKStaticLibrary.__Share_FunctionParams* ptr = stackalloc UKuroSDKStaticLibrary.__Share_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroSDKStaticLibrary.__Share_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKStaticLibrary.__Share_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->imagePath), imagePath);
			FString.CopyFrom((void*)(&ptr->sKuroSDKEventParameter), sKuroSDKEventParameter);
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__Share_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroSDKStaticLibrary.__Share_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601C66E RID: 116334 RVA: 0x0029EE78 File Offset: 0x0029D078
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetIfGlobalSdk(bool ifGlobal)
		{
			UKuroSDKStaticLibrary.__SetIfGlobalSdk_FunctionParams* ptr = stackalloc UKuroSDKStaticLibrary.__SetIfGlobalSdk_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroSDKStaticLibrary.__SetIfGlobalSdk_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKStaticLibrary.__SetIfGlobalSdk_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ifGlobal = ifGlobal;
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__SetIfGlobalSdk_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601C66F RID: 116335 RVA: 0x0029EEBE File Offset: 0x0029D0BE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void PostSplashSuccess()
		{
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__PostSplashSuccess_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601C670 RID: 116336 RVA: 0x0029EED4 File Offset: 0x0029D0D4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__OpenWebView_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroSDKStaticLibrary.__OpenWebView_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601C671 RID: 116337 RVA: 0x0029EF70 File Offset: 0x0029D170
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void OpenQRScan()
		{
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__OpenQRScan_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601C672 RID: 116338 RVA: 0x0029EF84 File Offset: 0x0029D184
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void OpenDefaultWebView(string url)
		{
			UKuroSDKStaticLibrary.__OpenDefaultWebView_FunctionParams* ptr = stackalloc UKuroSDKStaticLibrary.__OpenDefaultWebView_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSDKStaticLibrary.__OpenDefaultWebView_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKStaticLibrary.__OpenDefaultWebView_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->url), url);
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__OpenDefaultWebView_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroSDKStaticLibrary.__OpenDefaultWebView_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601C673 RID: 116339 RVA: 0x0029EFE4 File Offset: 0x0029D1E4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void OpenCustomerService(string data)
		{
			UKuroSDKStaticLibrary.__OpenCustomerService_FunctionParams* ptr = stackalloc UKuroSDKStaticLibrary.__OpenCustomerService_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSDKStaticLibrary.__OpenCustomerService_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKStaticLibrary.__OpenCustomerService_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->data), data);
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__OpenCustomerService_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroSDKStaticLibrary.__OpenCustomerService_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601C674 RID: 116340 RVA: 0x0029F044 File Offset: 0x0029D244
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void LogMarketingEvent(string data)
		{
			UKuroSDKStaticLibrary.__LogMarketingEvent_FunctionParams* ptr = stackalloc UKuroSDKStaticLibrary.__LogMarketingEvent_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSDKStaticLibrary.__LogMarketingEvent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKStaticLibrary.__LogMarketingEvent_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->data), data);
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__LogMarketingEvent_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroSDKStaticLibrary.__LogMarketingEvent_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601C675 RID: 116341 RVA: 0x0029F0A4 File Offset: 0x0029D2A4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void KuroSDKEvent(in UKuroSDKEventType iKuroSDKEvent, string sKuroSDKEventParameter)
		{
			UKuroSDKStaticLibrary.__KuroSDKEvent_FunctionParams* ptr = stackalloc UKuroSDKStaticLibrary.__KuroSDKEvent_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroSDKStaticLibrary.__KuroSDKEvent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKStaticLibrary.__KuroSDKEvent_NativeFunctionPtr, (void*)ptr, 1);
			ptr->iKuroSDKEvent = iKuroSDKEvent;
			FString.CopyFrom((void*)(&ptr->sKuroSDKEventParameter), sKuroSDKEventParameter);
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__KuroSDKEvent_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroSDKStaticLibrary.__KuroSDKEvent_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601C676 RID: 116342 RVA: 0x0029F109 File Offset: 0x0029D309
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void IsShowQuitTips()
		{
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__IsShowQuitTips_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601C677 RID: 116343 RVA: 0x0029F11D File Offset: 0x0029D31D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void IsCanQRScan()
		{
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__IsCanQRScan_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601C678 RID: 116344 RVA: 0x0029F131 File Offset: 0x0029D331
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void Initialize()
		{
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__Initialize_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601C679 RID: 116345 RVA: 0x0029F148 File Offset: 0x0029D348
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void GetSdkParams(string data)
		{
			UKuroSDKStaticLibrary.__GetSdkParams_FunctionParams* ptr = stackalloc UKuroSDKStaticLibrary.__GetSdkParams_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSDKStaticLibrary.__GetSdkParams_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKStaticLibrary.__GetSdkParams_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->data), data);
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__GetSdkParams_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroSDKStaticLibrary.__GetSdkParams_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601C67A RID: 116346 RVA: 0x0029F1A5 File Offset: 0x0029D3A5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void GetProjectId()
		{
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__GetProjectId_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601C67B RID: 116347 RVA: 0x0029F1BC File Offset: 0x0029D3BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool GetPostWebViewInitState()
		{
			UKuroSDKStaticLibrary.__GetPostWebViewInitState_FunctionParams* ptr = stackalloc UKuroSDKStaticLibrary.__GetPostWebViewInitState_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroSDKStaticLibrary.__GetPostWebViewInitState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKStaticLibrary.__GetPostWebViewInitState_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__GetPostWebViewInitState_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601C67C RID: 116348 RVA: 0x0029F204 File Offset: 0x0029D404
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool GetIsAgreeProtocol()
		{
			UKuroSDKStaticLibrary.__GetIsAgreeProtocol_FunctionParams* ptr = stackalloc UKuroSDKStaticLibrary.__GetIsAgreeProtocol_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroSDKStaticLibrary.__GetIsAgreeProtocol_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKStaticLibrary.__GetIsAgreeProtocol_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__GetIsAgreeProtocol_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601C67D RID: 116349 RVA: 0x0029F24C File Offset: 0x0029D44C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static FLoginStruct GetCurrentLoginInfo()
		{
			UKuroSDKStaticLibrary.__GetCurrentLoginInfo_FunctionParams* ptr = stackalloc UKuroSDKStaticLibrary.__GetCurrentLoginInfo_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(UKuroSDKStaticLibrary.__GetCurrentLoginInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKStaticLibrary.__GetCurrentLoginInfo_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__GetCurrentLoginInfo_NativeFunctionPtr, (void*)ptr, 0);
			FLoginStruct result = new FLoginStruct(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UKuroSDKStaticLibrary.__GetCurrentLoginInfo_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601C67E RID: 116350 RVA: 0x0029F2AA File Offset: 0x0029D4AA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void GetChannelName()
		{
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__GetChannelName_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601C67F RID: 116351 RVA: 0x0029F2C0 File Offset: 0x0029D4C0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static string GetChannelId()
		{
			UKuroSDKStaticLibrary.__GetChannelId_FunctionParams* ptr = stackalloc UKuroSDKStaticLibrary.__GetChannelId_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSDKStaticLibrary.__GetChannelId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKStaticLibrary.__GetChannelId_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__GetChannelId_NativeFunctionPtr, (void*)ptr, 0);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroSDKStaticLibrary.__GetChannelId_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601C680 RID: 116352 RVA: 0x0029F31C File Offset: 0x0029D51C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void GetBaseDeviceInfo()
		{
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__GetBaseDeviceInfo_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601C681 RID: 116353 RVA: 0x0029F330 File Offset: 0x0029D530
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void GetAppChannelId()
		{
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__GetAppChannelId_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601C682 RID: 116354 RVA: 0x0029F344 File Offset: 0x0029D544
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static string GetAndroidGalleryExternalFilePath()
		{
			UKuroSDKStaticLibrary.__GetAndroidGalleryExternalFilePath_FunctionParams* ptr = stackalloc UKuroSDKStaticLibrary.__GetAndroidGalleryExternalFilePath_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSDKStaticLibrary.__GetAndroidGalleryExternalFilePath_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKStaticLibrary.__GetAndroidGalleryExternalFilePath_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__GetAndroidGalleryExternalFilePath_NativeFunctionPtr, (void*)ptr, 0);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroSDKStaticLibrary.__GetAndroidGalleryExternalFilePath_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601C683 RID: 116355 RVA: 0x0029F3A0 File Offset: 0x0029D5A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void GetAgreementUrl()
		{
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__GetAgreementUrl_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601C684 RID: 116356 RVA: 0x0029F3B4 File Offset: 0x0029D5B4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void GetAdsValue(string income, string data)
		{
			UKuroSDKStaticLibrary.__GetAdsValue_FunctionParams* ptr = stackalloc UKuroSDKStaticLibrary.__GetAdsValue_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroSDKStaticLibrary.__GetAdsValue_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKStaticLibrary.__GetAdsValue_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->income), income);
			FString.CopyFrom((void*)(&ptr->data), data);
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__GetAdsValue_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroSDKStaticLibrary.__GetAdsValue_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601C685 RID: 116357 RVA: 0x0029F420 File Offset: 0x0029D620
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static UKuroSDKManager Get()
		{
			UKuroSDKStaticLibrary.__Get_FunctionParams* ptr = stackalloc UKuroSDKStaticLibrary.__Get_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroSDKStaticLibrary.__Get_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSDKStaticLibrary.__Get_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__Get_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroSDKManager>(ptr->__Result);
		}

		// Token: 0x0601C686 RID: 116358 RVA: 0x0029F46A File Offset: 0x0029D66A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void ClearSdkInstance()
		{
			UnrealReflectionUtils.CallUFunction(UKuroSDKStaticLibrary._ClassDefaultObjectPtr, UKuroSDKStaticLibrary.__ClearSdkInstance_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601C687 RID: 116359 RVA: 0x0029F47E File Offset: 0x0029D67E
		static UKuroSDKStaticLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSDK.KuroSDKStaticLibrary");
		}

		// Token: 0x0601C688 RID: 116360 RVA: 0x0029F48C File Offset: 0x0029D68C
		protected UKuroSDKStaticLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F46F RID: 62575
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSDK.KuroSDKStaticLibrary";

		// Token: 0x0400F470 RID: 62576
		private static IntPtr _ClassPtr;

		// Token: 0x0400F471 RID: 62577
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F472 RID: 62578
		private static IntPtr __ShowVirtualKeyboard_NativeFunctionPtr;

		// Token: 0x0400F473 RID: 62579
		private static IntPtr __ShowExitGameDialog_NativeFunctionPtr;

		// Token: 0x0400F474 RID: 62580
		private static IntPtr __ShareTexture_NativeFunctionPtr;

		// Token: 0x0400F475 RID: 62581
		private static IntPtr __Share_NativeFunctionPtr;

		// Token: 0x0400F476 RID: 62582
		private static IntPtr __SetIfGlobalSdk_NativeFunctionPtr;

		// Token: 0x0400F477 RID: 62583
		private static IntPtr __PostSplashSuccess_NativeFunctionPtr;

		// Token: 0x0400F478 RID: 62584
		private static IntPtr __OpenWebView_NativeFunctionPtr;

		// Token: 0x0400F479 RID: 62585
		private static IntPtr __OpenQRScan_NativeFunctionPtr;

		// Token: 0x0400F47A RID: 62586
		private static IntPtr __OpenDefaultWebView_NativeFunctionPtr;

		// Token: 0x0400F47B RID: 62587
		private static IntPtr __OpenCustomerService_NativeFunctionPtr;

		// Token: 0x0400F47C RID: 62588
		private static IntPtr __LogMarketingEvent_NativeFunctionPtr;

		// Token: 0x0400F47D RID: 62589
		private static IntPtr __KuroSDKEvent_NativeFunctionPtr;

		// Token: 0x0400F47E RID: 62590
		private static IntPtr __IsShowQuitTips_NativeFunctionPtr;

		// Token: 0x0400F47F RID: 62591
		private static IntPtr __IsCanQRScan_NativeFunctionPtr;

		// Token: 0x0400F480 RID: 62592
		private static IntPtr __Initialize_NativeFunctionPtr;

		// Token: 0x0400F481 RID: 62593
		private static IntPtr __GetSdkParams_NativeFunctionPtr;

		// Token: 0x0400F482 RID: 62594
		private static IntPtr __GetProjectId_NativeFunctionPtr;

		// Token: 0x0400F483 RID: 62595
		private static IntPtr __GetPostWebViewInitState_NativeFunctionPtr;

		// Token: 0x0400F484 RID: 62596
		private static IntPtr __GetIsAgreeProtocol_NativeFunctionPtr;

		// Token: 0x0400F485 RID: 62597
		private static IntPtr __GetCurrentLoginInfo_NativeFunctionPtr;

		// Token: 0x0400F486 RID: 62598
		private static IntPtr __GetChannelName_NativeFunctionPtr;

		// Token: 0x0400F487 RID: 62599
		private static IntPtr __GetChannelId_NativeFunctionPtr;

		// Token: 0x0400F488 RID: 62600
		private static IntPtr __GetBaseDeviceInfo_NativeFunctionPtr;

		// Token: 0x0400F489 RID: 62601
		private static IntPtr __GetAppChannelId_NativeFunctionPtr;

		// Token: 0x0400F48A RID: 62602
		private static IntPtr __GetAndroidGalleryExternalFilePath_NativeFunctionPtr;

		// Token: 0x0400F48B RID: 62603
		private static IntPtr __GetAgreementUrl_NativeFunctionPtr;

		// Token: 0x0400F48C RID: 62604
		private static IntPtr __GetAdsValue_NativeFunctionPtr;

		// Token: 0x0400F48D RID: 62605
		private static IntPtr __Get_NativeFunctionPtr;

		// Token: 0x0400F48E RID: 62606
		private static IntPtr __ClearSdkInstance_NativeFunctionPtr;

		// Token: 0x0200324B RID: 12875
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __ShowVirtualKeyboard_FunctionParams
		{
			// Token: 0x040170C2 RID: 94402
			[FieldOffset(0)]
			public bool state;
		}

		// Token: 0x0200324C RID: 12876
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __ShareTexture_FunctionParams
		{
			// Token: 0x040170C3 RID: 94403
			[FieldOffset(0)]
			public FString texturePath;

			// Token: 0x040170C4 RID: 94404
			[FieldOffset(16)]
			public FString sKuroSDKEventParameter;
		}

		// Token: 0x0200324D RID: 12877
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __Share_FunctionParams
		{
			// Token: 0x040170C5 RID: 94405
			[FieldOffset(0)]
			public FString imagePath;

			// Token: 0x040170C6 RID: 94406
			[FieldOffset(16)]
			public FString sKuroSDKEventParameter;
		}

		// Token: 0x0200324E RID: 12878
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetIfGlobalSdk_FunctionParams
		{
			// Token: 0x040170C7 RID: 94407
			[FieldOffset(0)]
			public bool ifGlobal;
		}

		// Token: 0x0200324F RID: 12879
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __OpenWebView_FunctionParams
		{
			// Token: 0x040170C8 RID: 94408
			[FieldOffset(0)]
			public FString title;

			// Token: 0x040170C9 RID: 94409
			[FieldOffset(16)]
			public FString url;

			// Token: 0x040170CA RID: 94410
			[FieldOffset(32)]
			public bool isLandScape;

			// Token: 0x040170CB RID: 94411
			[FieldOffset(33)]
			public bool transparent;

			// Token: 0x040170CC RID: 94412
			[FieldOffset(34)]
			public bool webAccelerated;

			// Token: 0x040170CD RID: 94413
			[FieldOffset(40)]
			public FString identifier;

			// Token: 0x040170CE RID: 94414
			[FieldOffset(56)]
			public FString data;
		}

		// Token: 0x02003250 RID: 12880
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OpenDefaultWebView_FunctionParams
		{
			// Token: 0x040170CF RID: 94415
			[FieldOffset(0)]
			public FString url;
		}

		// Token: 0x02003251 RID: 12881
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OpenCustomerService_FunctionParams
		{
			// Token: 0x040170D0 RID: 94416
			[FieldOffset(0)]
			public FString data;
		}

		// Token: 0x02003252 RID: 12882
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __LogMarketingEvent_FunctionParams
		{
			// Token: 0x040170D1 RID: 94417
			[FieldOffset(0)]
			public FString data;
		}

		// Token: 0x02003253 RID: 12883
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __KuroSDKEvent_FunctionParams
		{
			// Token: 0x040170D2 RID: 94418
			[FieldOffset(0)]
			public UKuroSDKEventType iKuroSDKEvent;

			// Token: 0x040170D3 RID: 94419
			[FieldOffset(8)]
			public FString sKuroSDKEventParameter;
		}

		// Token: 0x02003254 RID: 12884
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetSdkParams_FunctionParams
		{
			// Token: 0x040170D4 RID: 94420
			[FieldOffset(0)]
			public FString data;
		}

		// Token: 0x02003255 RID: 12885
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetPostWebViewInitState_FunctionParams
		{
			// Token: 0x040170D5 RID: 94421
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003256 RID: 12886
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetIsAgreeProtocol_FunctionParams
		{
			// Token: 0x040170D6 RID: 94422
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003257 RID: 12887
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __GetCurrentLoginInfo_FunctionParams
		{
			// Token: 0x040170D7 RID: 94423
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003258 RID: 12888
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetChannelId_FunctionParams
		{
			// Token: 0x040170D8 RID: 94424
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x02003259 RID: 12889
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetAndroidGalleryExternalFilePath_FunctionParams
		{
			// Token: 0x040170D9 RID: 94425
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x0200325A RID: 12890
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetAdsValue_FunctionParams
		{
			// Token: 0x040170DA RID: 94426
			[FieldOffset(0)]
			public FString income;

			// Token: 0x040170DB RID: 94427
			[FieldOffset(16)]
			public FString data;
		}

		// Token: 0x0200325B RID: 12891
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __Get_FunctionParams
		{
			// Token: 0x040170DC RID: 94428
			[FieldOffset(0)]
			public IntPtr __Result;
		}
	}
}
