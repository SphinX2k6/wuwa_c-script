using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A40 RID: 6720
	[UnrealObjectPath("/Script/KuroPushSdk.KuroPushSdkStaticLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroPushSdkStaticLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018DF2 RID: 101874 RVA: 0x0024BF8D File Offset: 0x0024A18D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroPushSdkStaticLibrary._ClassPtr;
		}

		// Token: 0x06018DF3 RID: 101875 RVA: 0x0024BF9C File Offset: 0x0024A19C
		public UKuroPushSdkStaticLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroPushSdkStaticLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018DF4 RID: 101876 RVA: 0x0024BFC4 File Offset: 0x0024A1C4
		[NullableContext(1)]
		public UKuroPushSdkStaticLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroPushSdkStaticLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06018DF5 RID: 101877 RVA: 0x0024BFF7 File Offset: 0x0024A1F7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void VoipRegistration()
		{
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__VoipRegistration_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06018DF6 RID: 101878 RVA: 0x0024C00C File Offset: 0x0024A20C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void UnBindAlias(string alias, string sn, bool isSelf)
		{
			UKuroPushSdkStaticLibrary.__UnBindAlias_FunctionParams* ptr = stackalloc UKuroPushSdkStaticLibrary.__UnBindAlias_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UKuroPushSdkStaticLibrary.__UnBindAlias_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPushSdkStaticLibrary.__UnBindAlias_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->alias), alias);
			FString.CopyFrom((void*)(&ptr->sn), sn);
			ptr->isSelf = isSelf;
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__UnBindAlias_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroPushSdkStaticLibrary.__UnBindAlias_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06018DF7 RID: 101879 RVA: 0x0024C07D File Offset: 0x0024A27D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void TurnOnPush()
		{
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__TurnOnPush_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06018DF8 RID: 101880 RVA: 0x0024C091 File Offset: 0x0024A291
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void TurnOffPush()
		{
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__TurnOffPush_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06018DF9 RID: 101881 RVA: 0x0024C0A8 File Offset: 0x0024A2A8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void StartPushSdk(string appId, string appKey, string appSecret)
		{
			UKuroPushSdkStaticLibrary.__StartPushSdk_FunctionParams* ptr = stackalloc UKuroPushSdkStaticLibrary.__StartPushSdk_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UKuroPushSdkStaticLibrary.__StartPushSdk_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPushSdkStaticLibrary.__StartPushSdk_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->appId), appId);
			FString.CopyFrom((void*)(&ptr->appKey), appKey);
			FString.CopyFrom((void*)(&ptr->appSecret), appSecret);
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__StartPushSdk_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroPushSdkStaticLibrary.__StartPushSdk_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06018DFA RID: 101882 RVA: 0x0024C120 File Offset: 0x0024A320
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool SetTag(string tags, string sn)
		{
			UKuroPushSdkStaticLibrary.__SetTag_FunctionParams* ptr = stackalloc UKuroPushSdkStaticLibrary.__SetTag_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UKuroPushSdkStaticLibrary.__SetTag_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPushSdkStaticLibrary.__SetTag_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->tags), tags);
			FString.CopyFrom((void*)(&ptr->sn), sn);
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__SetTag_NativeFunctionPtr, (void*)ptr, 0);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroPushSdkStaticLibrary.__SetTag_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06018DFB RID: 101883 RVA: 0x0024C190 File Offset: 0x0024A390
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetRunInBackGround(bool state)
		{
			UKuroPushSdkStaticLibrary.__SetRunInBackGround_FunctionParams* ptr = stackalloc UKuroPushSdkStaticLibrary.__SetRunInBackGround_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroPushSdkStaticLibrary.__SetRunInBackGround_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPushSdkStaticLibrary.__SetRunInBackGround_NativeFunctionPtr, (void*)ptr, 1);
			ptr->state = state;
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__SetRunInBackGround_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06018DFC RID: 101884 RVA: 0x0024C1D8 File Offset: 0x0024A3D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetPushMode(bool turnOn)
		{
			UKuroPushSdkStaticLibrary.__SetPushMode_FunctionParams* ptr = stackalloc UKuroPushSdkStaticLibrary.__SetPushMode_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroPushSdkStaticLibrary.__SetPushMode_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPushSdkStaticLibrary.__SetPushMode_NativeFunctionPtr, (void*)ptr, 1);
			ptr->turnOn = turnOn;
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__SetPushMode_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06018DFD RID: 101885 RVA: 0x0024C220 File Offset: 0x0024A420
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetNotificationIcon(ref string smallIcon, ref string largeIcon)
		{
			UKuroPushSdkStaticLibrary.__SetNotificationIcon_FunctionParams* ptr = stackalloc UKuroPushSdkStaticLibrary.__SetNotificationIcon_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroPushSdkStaticLibrary.__SetNotificationIcon_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPushSdkStaticLibrary.__SetNotificationIcon_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->smallIcon), smallIcon);
			FString.CopyFrom((void*)(&ptr->largeIcon), largeIcon);
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__SetNotificationIcon_NativeFunctionPtr, (void*)ptr, 0);
			smallIcon = FString.ToString((void*)(&ptr->smallIcon));
			largeIcon = FString.ToString((void*)(&ptr->largeIcon));
			UnrealReflectionUtils.DestroyStruct(UKuroPushSdkStaticLibrary.__SetNotificationIcon_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06018DFE RID: 101886 RVA: 0x0024C2A8 File Offset: 0x0024A4A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetLocationEnable(bool isEnable, bool isVerify)
		{
			UKuroPushSdkStaticLibrary.__SetLocationEnable_FunctionParams* ptr = stackalloc UKuroPushSdkStaticLibrary.__SetLocationEnable_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UKuroPushSdkStaticLibrary.__SetLocationEnable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPushSdkStaticLibrary.__SetLocationEnable_NativeFunctionPtr, (void*)ptr, 1);
			ptr->isEnable = isEnable;
			ptr->isVerify = isVerify;
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__SetLocationEnable_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06018DFF RID: 101887 RVA: 0x0024C2F8 File Offset: 0x0024A4F8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetLocalSetNotificationIcon(ref string smallIcon, ref string largeIcon)
		{
			UKuroPushSdkStaticLibrary.__SetLocalSetNotificationIcon_FunctionParams* ptr = stackalloc UKuroPushSdkStaticLibrary.__SetLocalSetNotificationIcon_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroPushSdkStaticLibrary.__SetLocalSetNotificationIcon_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPushSdkStaticLibrary.__SetLocalSetNotificationIcon_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->smallIcon), smallIcon);
			FString.CopyFrom((void*)(&ptr->largeIcon), largeIcon);
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__SetLocalSetNotificationIcon_NativeFunctionPtr, (void*)ptr, 0);
			smallIcon = FString.ToString((void*)(&ptr->smallIcon));
			largeIcon = FString.ToString((void*)(&ptr->largeIcon));
			UnrealReflectionUtils.DestroyStruct(UKuroPushSdkStaticLibrary.__SetLocalSetNotificationIcon_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06018E00 RID: 101888 RVA: 0x0024C380 File Offset: 0x0024A580
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetLocalChannelIdAndName(ref string channelId, ref string channelName)
		{
			UKuroPushSdkStaticLibrary.__SetLocalChannelIdAndName_FunctionParams* ptr = stackalloc UKuroPushSdkStaticLibrary.__SetLocalChannelIdAndName_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroPushSdkStaticLibrary.__SetLocalChannelIdAndName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPushSdkStaticLibrary.__SetLocalChannelIdAndName_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->channelId), channelId);
			FString.CopyFrom((void*)(&ptr->channelName), channelName);
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__SetLocalChannelIdAndName_NativeFunctionPtr, (void*)ptr, 0);
			channelId = FString.ToString((void*)(&ptr->channelId));
			channelName = FString.ToString((void*)(&ptr->channelName));
			UnrealReflectionUtils.DestroyStruct(UKuroPushSdkStaticLibrary.__SetLocalChannelIdAndName_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06018E01 RID: 101889 RVA: 0x0024C408 File Offset: 0x0024A608
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetLocalChannelId(ref string channelId)
		{
			UKuroPushSdkStaticLibrary.__SetLocalChannelId_FunctionParams* ptr = stackalloc UKuroPushSdkStaticLibrary.__SetLocalChannelId_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroPushSdkStaticLibrary.__SetLocalChannelId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPushSdkStaticLibrary.__SetLocalChannelId_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->channelId), channelId);
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__SetLocalChannelId_NativeFunctionPtr, (void*)ptr, 0);
			channelId = FString.ToString((void*)(&ptr->channelId));
			UnrealReflectionUtils.DestroyStruct(UKuroPushSdkStaticLibrary.__SetLocalChannelId_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06018E02 RID: 101890 RVA: 0x0024C474 File Offset: 0x0024A674
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void SetDebug()
		{
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__SetDebug_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06018E03 RID: 101891 RVA: 0x0024C488 File Offset: 0x0024A688
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetChannel(string channelId)
		{
			UKuroPushSdkStaticLibrary.__SetChannel_FunctionParams* ptr = stackalloc UKuroPushSdkStaticLibrary.__SetChannel_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroPushSdkStaticLibrary.__SetChannel_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPushSdkStaticLibrary.__SetChannel_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->channelId), channelId);
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__SetChannel_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroPushSdkStaticLibrary.__SetChannel_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06018E04 RID: 101892 RVA: 0x0024C4E8 File Offset: 0x0024A6E8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetBudge(string budge)
		{
			UKuroPushSdkStaticLibrary.__SetBudge_FunctionParams* ptr = stackalloc UKuroPushSdkStaticLibrary.__SetBudge_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroPushSdkStaticLibrary.__SetBudge_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPushSdkStaticLibrary.__SetBudge_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->budge), budge);
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__SetBudge_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroPushSdkStaticLibrary.__SetBudge_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06018E05 RID: 101893 RVA: 0x0024C548 File Offset: 0x0024A748
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetApplicationGroupIdentify(string identify)
		{
			UKuroPushSdkStaticLibrary.__SetApplicationGroupIdentify_FunctionParams* ptr = stackalloc UKuroPushSdkStaticLibrary.__SetApplicationGroupIdentify_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroPushSdkStaticLibrary.__SetApplicationGroupIdentify_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPushSdkStaticLibrary.__SetApplicationGroupIdentify_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->identify), identify);
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__SetApplicationGroupIdentify_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroPushSdkStaticLibrary.__SetApplicationGroupIdentify_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06018E06 RID: 101894 RVA: 0x0024C5A8 File Offset: 0x0024A7A8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SendFeedBackMessage(string actionId, string taskId, string msgId)
		{
			UKuroPushSdkStaticLibrary.__SendFeedBackMessage_FunctionParams* ptr = stackalloc UKuroPushSdkStaticLibrary.__SendFeedBackMessage_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UKuroPushSdkStaticLibrary.__SendFeedBackMessage_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPushSdkStaticLibrary.__SendFeedBackMessage_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->actionId), actionId);
			FString.CopyFrom((void*)(&ptr->taskId), taskId);
			FString.CopyFrom((void*)(&ptr->msgId), msgId);
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__SendFeedBackMessage_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroPushSdkStaticLibrary.__SendFeedBackMessage_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06018E07 RID: 101895 RVA: 0x0024C61F File Offset: 0x0024A81F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void Resume()
		{
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__Resume_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06018E08 RID: 101896 RVA: 0x0024C633 File Offset: 0x0024A833
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void ResetBudge()
		{
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__ResetBudge_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06018E09 RID: 101897 RVA: 0x0024C647 File Offset: 0x0024A847
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void RegistRemoteNotification()
		{
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__RegistRemoteNotification_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06018E0A RID: 101898 RVA: 0x0024C65C File Offset: 0x0024A85C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void PushLocalNotification(string title, string body, string exData)
		{
			UKuroPushSdkStaticLibrary.__PushLocalNotification_FunctionParams* ptr = stackalloc UKuroPushSdkStaticLibrary.__PushLocalNotification_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UKuroPushSdkStaticLibrary.__PushLocalNotification_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPushSdkStaticLibrary.__PushLocalNotification_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->title), title);
			FString.CopyFrom((void*)(&ptr->body), body);
			FString.CopyFrom((void*)(&ptr->exData), exData);
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__PushLocalNotification_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroPushSdkStaticLibrary.__PushLocalNotification_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06018E0B RID: 101899 RVA: 0x0024C6D3 File Offset: 0x0024A8D3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void OpenNotification()
		{
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__OpenNotification_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06018E0C RID: 101900 RVA: 0x0024C6E8 File Offset: 0x0024A8E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool IsPushTurnOn()
		{
			UKuroPushSdkStaticLibrary.__IsPushTurnOn_FunctionParams* ptr = stackalloc UKuroPushSdkStaticLibrary.__IsPushTurnOn_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroPushSdkStaticLibrary.__IsPushTurnOn_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPushSdkStaticLibrary.__IsPushTurnOn_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__IsPushTurnOn_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06018E0D RID: 101901 RVA: 0x0024C72D File Offset: 0x0024A92D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void Init()
		{
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__Init_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06018E0E RID: 101902 RVA: 0x0024C744 File Offset: 0x0024A944
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static string GetVersion()
		{
			UKuroPushSdkStaticLibrary.__GetVersion_FunctionParams* ptr = stackalloc UKuroPushSdkStaticLibrary.__GetVersion_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroPushSdkStaticLibrary.__GetVersion_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPushSdkStaticLibrary.__GetVersion_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__GetVersion_NativeFunctionPtr, (void*)ptr, 0);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroPushSdkStaticLibrary.__GetVersion_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06018E0F RID: 101903 RVA: 0x0024C7A0 File Offset: 0x0024A9A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int GetStatus()
		{
			UKuroPushSdkStaticLibrary.__GetStatus_FunctionParams* ptr = stackalloc UKuroPushSdkStaticLibrary.__GetStatus_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroPushSdkStaticLibrary.__GetStatus_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPushSdkStaticLibrary.__GetStatus_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__GetStatus_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06018E10 RID: 101904 RVA: 0x0024C7E8 File Offset: 0x0024A9E8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static UKuroPushObject GetPushObject()
		{
			UKuroPushSdkStaticLibrary.__GetPushObject_FunctionParams* ptr = stackalloc UKuroPushSdkStaticLibrary.__GetPushObject_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroPushSdkStaticLibrary.__GetPushObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPushSdkStaticLibrary.__GetPushObject_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__GetPushObject_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroPushObject>(ptr->__Result);
		}

		// Token: 0x06018E11 RID: 101905 RVA: 0x0024C834 File Offset: 0x0024AA34
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static string GetClientId()
		{
			UKuroPushSdkStaticLibrary.__GetClientId_FunctionParams* ptr = stackalloc UKuroPushSdkStaticLibrary.__GetClientId_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroPushSdkStaticLibrary.__GetClientId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPushSdkStaticLibrary.__GetClientId_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__GetClientId_NativeFunctionPtr, (void*)ptr, 0);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroPushSdkStaticLibrary.__GetClientId_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06018E12 RID: 101906 RVA: 0x0024C890 File Offset: 0x0024AA90
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void Destroy()
		{
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__Destroy_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06018E13 RID: 101907 RVA: 0x0024C8A4 File Offset: 0x0024AAA4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void ClearNotificationForNotificationBar()
		{
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__ClearNotificationForNotificationBar_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06018E14 RID: 101908 RVA: 0x0024C8B8 File Offset: 0x0024AAB8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void CheckManifest()
		{
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__CheckManifest_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06018E15 RID: 101909 RVA: 0x0024C8CC File Offset: 0x0024AACC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void BindAlias(string alias, string sn)
		{
			UKuroPushSdkStaticLibrary.__BindAlias_FunctionParams* ptr = stackalloc UKuroPushSdkStaticLibrary.__BindAlias_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroPushSdkStaticLibrary.__BindAlias_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPushSdkStaticLibrary.__BindAlias_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->alias), alias);
			FString.CopyFrom((void*)(&ptr->sn), sn);
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__BindAlias_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroPushSdkStaticLibrary.__BindAlias_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06018E16 RID: 101910 RVA: 0x0024C936 File Offset: 0x0024AB36
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void AreNotificationEnable()
		{
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__AreNotificationEnable_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06018E17 RID: 101911 RVA: 0x0024C94A File Offset: 0x0024AB4A
		static UKuroPushSdkStaticLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroPushSdk.KuroPushSdkStaticLibrary");
		}

		// Token: 0x06018E18 RID: 101912 RVA: 0x0024C958 File Offset: 0x0024AB58
		protected UKuroPushSdkStaticLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D6F7 RID: 55031
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroPushSdk.KuroPushSdkStaticLibrary";

		// Token: 0x0400D6F8 RID: 55032
		private static IntPtr _ClassPtr;

		// Token: 0x0400D6F9 RID: 55033
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D6FA RID: 55034
		private static IntPtr __VoipRegistration_NativeFunctionPtr;

		// Token: 0x0400D6FB RID: 55035
		private static IntPtr __UnBindAlias_NativeFunctionPtr;

		// Token: 0x0400D6FC RID: 55036
		private static IntPtr __TurnOnPush_NativeFunctionPtr;

		// Token: 0x0400D6FD RID: 55037
		private static IntPtr __TurnOffPush_NativeFunctionPtr;

		// Token: 0x0400D6FE RID: 55038
		private static IntPtr __StartPushSdk_NativeFunctionPtr;

		// Token: 0x0400D6FF RID: 55039
		private static IntPtr __SetTag_NativeFunctionPtr;

		// Token: 0x0400D700 RID: 55040
		private static IntPtr __SetRunInBackGround_NativeFunctionPtr;

		// Token: 0x0400D701 RID: 55041
		private static IntPtr __SetPushMode_NativeFunctionPtr;

		// Token: 0x0400D702 RID: 55042
		private static IntPtr __SetNotificationIcon_NativeFunctionPtr;

		// Token: 0x0400D703 RID: 55043
		private static IntPtr __SetLocationEnable_NativeFunctionPtr;

		// Token: 0x0400D704 RID: 55044
		private static IntPtr __SetLocalSetNotificationIcon_NativeFunctionPtr;

		// Token: 0x0400D705 RID: 55045
		private static IntPtr __SetLocalChannelIdAndName_NativeFunctionPtr;

		// Token: 0x0400D706 RID: 55046
		private static IntPtr __SetLocalChannelId_NativeFunctionPtr;

		// Token: 0x0400D707 RID: 55047
		private static IntPtr __SetDebug_NativeFunctionPtr;

		// Token: 0x0400D708 RID: 55048
		private static IntPtr __SetChannel_NativeFunctionPtr;

		// Token: 0x0400D709 RID: 55049
		private static IntPtr __SetBudge_NativeFunctionPtr;

		// Token: 0x0400D70A RID: 55050
		private static IntPtr __SetApplicationGroupIdentify_NativeFunctionPtr;

		// Token: 0x0400D70B RID: 55051
		private static IntPtr __SendFeedBackMessage_NativeFunctionPtr;

		// Token: 0x0400D70C RID: 55052
		private static IntPtr __Resume_NativeFunctionPtr;

		// Token: 0x0400D70D RID: 55053
		private static IntPtr __ResetBudge_NativeFunctionPtr;

		// Token: 0x0400D70E RID: 55054
		private static IntPtr __RegistRemoteNotification_NativeFunctionPtr;

		// Token: 0x0400D70F RID: 55055
		private static IntPtr __PushLocalNotification_NativeFunctionPtr;

		// Token: 0x0400D710 RID: 55056
		private static IntPtr __OpenNotification_NativeFunctionPtr;

		// Token: 0x0400D711 RID: 55057
		private static IntPtr __IsPushTurnOn_NativeFunctionPtr;

		// Token: 0x0400D712 RID: 55058
		private static IntPtr __Init_NativeFunctionPtr;

		// Token: 0x0400D713 RID: 55059
		private static IntPtr __GetVersion_NativeFunctionPtr;

		// Token: 0x0400D714 RID: 55060
		private static IntPtr __GetStatus_NativeFunctionPtr;

		// Token: 0x0400D715 RID: 55061
		private static IntPtr __GetPushObject_NativeFunctionPtr;

		// Token: 0x0400D716 RID: 55062
		private static IntPtr __GetClientId_NativeFunctionPtr;

		// Token: 0x0400D717 RID: 55063
		private static IntPtr __Destroy_NativeFunctionPtr;

		// Token: 0x0400D718 RID: 55064
		private static IntPtr __ClearNotificationForNotificationBar_NativeFunctionPtr;

		// Token: 0x0400D719 RID: 55065
		private static IntPtr __CheckManifest_NativeFunctionPtr;

		// Token: 0x0400D71A RID: 55066
		private static IntPtr __BindAlias_NativeFunctionPtr;

		// Token: 0x0400D71B RID: 55067
		private static IntPtr __AreNotificationEnable_NativeFunctionPtr;

		// Token: 0x02003102 RID: 12546
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __UnBindAlias_FunctionParams
		{
			// Token: 0x04016E88 RID: 93832
			[FieldOffset(0)]
			public FString alias;

			// Token: 0x04016E89 RID: 93833
			[FieldOffset(16)]
			public FString sn;

			// Token: 0x04016E8A RID: 93834
			[FieldOffset(32)]
			public bool isSelf;
		}

		// Token: 0x02003103 RID: 12547
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __StartPushSdk_FunctionParams
		{
			// Token: 0x04016E8B RID: 93835
			[FieldOffset(0)]
			public FString appId;

			// Token: 0x04016E8C RID: 93836
			[FieldOffset(16)]
			public FString appKey;

			// Token: 0x04016E8D RID: 93837
			[FieldOffset(32)]
			public FString appSecret;
		}

		// Token: 0x02003104 RID: 12548
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __SetTag_FunctionParams
		{
			// Token: 0x04016E8E RID: 93838
			[FieldOffset(0)]
			public FString tags;

			// Token: 0x04016E8F RID: 93839
			[FieldOffset(16)]
			public FString sn;

			// Token: 0x04016E90 RID: 93840
			[FieldOffset(32)]
			public bool __Result;
		}

		// Token: 0x02003105 RID: 12549
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRunInBackGround_FunctionParams
		{
			// Token: 0x04016E91 RID: 93841
			[FieldOffset(0)]
			public bool state;
		}

		// Token: 0x02003106 RID: 12550
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetPushMode_FunctionParams
		{
			// Token: 0x04016E92 RID: 93842
			[FieldOffset(0)]
			public bool turnOn;
		}

		// Token: 0x02003107 RID: 12551
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SetNotificationIcon_FunctionParams
		{
			// Token: 0x04016E93 RID: 93843
			[FieldOffset(0)]
			public FString smallIcon;

			// Token: 0x04016E94 RID: 93844
			[FieldOffset(16)]
			public FString largeIcon;
		}

		// Token: 0x02003108 RID: 12552
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __SetLocationEnable_FunctionParams
		{
			// Token: 0x04016E95 RID: 93845
			[FieldOffset(0)]
			public bool isEnable;

			// Token: 0x04016E96 RID: 93846
			[FieldOffset(1)]
			public bool isVerify;
		}

		// Token: 0x02003109 RID: 12553
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SetLocalSetNotificationIcon_FunctionParams
		{
			// Token: 0x04016E97 RID: 93847
			[FieldOffset(0)]
			public FString smallIcon;

			// Token: 0x04016E98 RID: 93848
			[FieldOffset(16)]
			public FString largeIcon;
		}

		// Token: 0x0200310A RID: 12554
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SetLocalChannelIdAndName_FunctionParams
		{
			// Token: 0x04016E99 RID: 93849
			[FieldOffset(0)]
			public FString channelId;

			// Token: 0x04016E9A RID: 93850
			[FieldOffset(16)]
			public FString channelName;
		}

		// Token: 0x0200310B RID: 12555
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetLocalChannelId_FunctionParams
		{
			// Token: 0x04016E9B RID: 93851
			[FieldOffset(0)]
			public FString channelId;
		}

		// Token: 0x0200310C RID: 12556
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetChannel_FunctionParams
		{
			// Token: 0x04016E9C RID: 93852
			[FieldOffset(0)]
			public FString channelId;
		}

		// Token: 0x0200310D RID: 12557
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetBudge_FunctionParams
		{
			// Token: 0x04016E9D RID: 93853
			[FieldOffset(0)]
			public FString budge;
		}

		// Token: 0x0200310E RID: 12558
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetApplicationGroupIdentify_FunctionParams
		{
			// Token: 0x04016E9E RID: 93854
			[FieldOffset(0)]
			public FString identify;
		}

		// Token: 0x0200310F RID: 12559
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __SendFeedBackMessage_FunctionParams
		{
			// Token: 0x04016E9F RID: 93855
			[FieldOffset(0)]
			public FString actionId;

			// Token: 0x04016EA0 RID: 93856
			[FieldOffset(16)]
			public FString taskId;

			// Token: 0x04016EA1 RID: 93857
			[FieldOffset(32)]
			public FString msgId;
		}

		// Token: 0x02003110 RID: 12560
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __PushLocalNotification_FunctionParams
		{
			// Token: 0x04016EA2 RID: 93858
			[FieldOffset(0)]
			public FString title;

			// Token: 0x04016EA3 RID: 93859
			[FieldOffset(16)]
			public FString body;

			// Token: 0x04016EA4 RID: 93860
			[FieldOffset(32)]
			public FString exData;
		}

		// Token: 0x02003111 RID: 12561
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsPushTurnOn_FunctionParams
		{
			// Token: 0x04016EA5 RID: 93861
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003112 RID: 12562
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetVersion_FunctionParams
		{
			// Token: 0x04016EA6 RID: 93862
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x02003113 RID: 12563
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetStatus_FunctionParams
		{
			// Token: 0x04016EA7 RID: 93863
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02003114 RID: 12564
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetPushObject_FunctionParams
		{
			// Token: 0x04016EA8 RID: 93864
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x02003115 RID: 12565
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetClientId_FunctionParams
		{
			// Token: 0x04016EA9 RID: 93865
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x02003116 RID: 12566
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BindAlias_FunctionParams
		{
			// Token: 0x04016EAA RID: 93866
			[FieldOffset(0)]
			public FString alias;

			// Token: 0x04016EAB RID: 93867
			[FieldOffset(16)]
			public FString sn;
		}
	}
}
