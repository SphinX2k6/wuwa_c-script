using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004A0 RID: 1184
	[UnrealObjectPath("/Script/KuroPushSdk.KuroPushSdkStaticLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroPushSdkStaticLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006E37 RID: 28215 RVA: 0x000A2425 File Offset: 0x000A0625
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroPushSdkStaticLibrary._ClassPtr;
		}

		// Token: 0x06006E38 RID: 28216 RVA: 0x000A2434 File Offset: 0x000A0634
		public UKuroPushSdkStaticLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroPushSdkStaticLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006E39 RID: 28217 RVA: 0x000A245C File Offset: 0x000A065C
		[NullableContext(1)]
		public UKuroPushSdkStaticLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroPushSdkStaticLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006E3A RID: 28218 RVA: 0x000A248F File Offset: 0x000A068F
		[SkipLocalsInit]
		public static void VoipRegistration()
		{
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__VoipRegistration_NativeFunctionPtr, null);
		}

		// Token: 0x06006E3B RID: 28219 RVA: 0x000A24A4 File Offset: 0x000A06A4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void UnBindAlias(string alias, string sn, bool isSelf)
		{
			UKuroPushSdkStaticLibrary.__UnBindAlias_FunctionParams* ptr = stackalloc UKuroPushSdkStaticLibrary.__UnBindAlias_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UKuroPushSdkStaticLibrary.__UnBindAlias_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPushSdkStaticLibrary.__UnBindAlias_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->alias), alias);
			FString.CopyFrom((void*)(&ptr->sn), sn);
			ptr->isSelf = isSelf;
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__UnBindAlias_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroPushSdkStaticLibrary.__UnBindAlias_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06006E3C RID: 28220 RVA: 0x000A2514 File Offset: 0x000A0714
		[SkipLocalsInit]
		public static void TurnOnPush()
		{
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__TurnOnPush_NativeFunctionPtr, null);
		}

		// Token: 0x06006E3D RID: 28221 RVA: 0x000A2527 File Offset: 0x000A0727
		[SkipLocalsInit]
		public static void TurnOffPush()
		{
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__TurnOffPush_NativeFunctionPtr, null);
		}

		// Token: 0x06006E3E RID: 28222 RVA: 0x000A253C File Offset: 0x000A073C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void StartPushSdk(string appId, string appKey, string appSecret)
		{
			UKuroPushSdkStaticLibrary.__StartPushSdk_FunctionParams* ptr = stackalloc UKuroPushSdkStaticLibrary.__StartPushSdk_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UKuroPushSdkStaticLibrary.__StartPushSdk_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPushSdkStaticLibrary.__StartPushSdk_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->appId), appId);
			FString.CopyFrom((void*)(&ptr->appKey), appKey);
			FString.CopyFrom((void*)(&ptr->appSecret), appSecret);
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__StartPushSdk_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroPushSdkStaticLibrary.__StartPushSdk_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06006E3F RID: 28223 RVA: 0x000A25B4 File Offset: 0x000A07B4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static bool SetTag(string tags, string sn)
		{
			UKuroPushSdkStaticLibrary.__SetTag_FunctionParams* ptr = stackalloc UKuroPushSdkStaticLibrary.__SetTag_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UKuroPushSdkStaticLibrary.__SetTag_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPushSdkStaticLibrary.__SetTag_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->tags), tags);
			FString.CopyFrom((void*)(&ptr->sn), sn);
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__SetTag_NativeFunctionPtr, (void*)ptr);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroPushSdkStaticLibrary.__SetTag_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06006E40 RID: 28224 RVA: 0x000A2624 File Offset: 0x000A0824
		[SkipLocalsInit]
		public unsafe static void SetRunInBackGround(bool state)
		{
			UKuroPushSdkStaticLibrary.__SetRunInBackGround_FunctionParams* ptr = stackalloc UKuroPushSdkStaticLibrary.__SetRunInBackGround_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroPushSdkStaticLibrary.__SetRunInBackGround_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPushSdkStaticLibrary.__SetRunInBackGround_NativeFunctionPtr, (void*)ptr, 1);
			ptr->state = state;
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__SetRunInBackGround_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06006E41 RID: 28225 RVA: 0x000A266C File Offset: 0x000A086C
		[SkipLocalsInit]
		public unsafe static void SetPushMode(bool turnOn)
		{
			UKuroPushSdkStaticLibrary.__SetPushMode_FunctionParams* ptr = stackalloc UKuroPushSdkStaticLibrary.__SetPushMode_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroPushSdkStaticLibrary.__SetPushMode_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPushSdkStaticLibrary.__SetPushMode_NativeFunctionPtr, (void*)ptr, 1);
			ptr->turnOn = turnOn;
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__SetPushMode_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06006E42 RID: 28226 RVA: 0x000A26B4 File Offset: 0x000A08B4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void SetNotificationIcon(ref string smallIcon, ref string largeIcon)
		{
			UKuroPushSdkStaticLibrary.__SetNotificationIcon_FunctionParams* ptr = stackalloc UKuroPushSdkStaticLibrary.__SetNotificationIcon_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroPushSdkStaticLibrary.__SetNotificationIcon_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPushSdkStaticLibrary.__SetNotificationIcon_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->smallIcon), smallIcon);
			FString.CopyFrom((void*)(&ptr->largeIcon), largeIcon);
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__SetNotificationIcon_NativeFunctionPtr, (void*)ptr);
			smallIcon = FString.ToString((void*)(&ptr->smallIcon));
			largeIcon = FString.ToString((void*)(&ptr->largeIcon));
			UnrealReflectionUtils.DestroyStruct(UKuroPushSdkStaticLibrary.__SetNotificationIcon_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06006E43 RID: 28227 RVA: 0x000A273C File Offset: 0x000A093C
		[SkipLocalsInit]
		public unsafe static void SetLocationEnable(bool isEnable, bool isVerify)
		{
			UKuroPushSdkStaticLibrary.__SetLocationEnable_FunctionParams* ptr = stackalloc UKuroPushSdkStaticLibrary.__SetLocationEnable_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UKuroPushSdkStaticLibrary.__SetLocationEnable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPushSdkStaticLibrary.__SetLocationEnable_NativeFunctionPtr, (void*)ptr, 1);
			ptr->isEnable = isEnable;
			ptr->isVerify = isVerify;
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__SetLocationEnable_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06006E44 RID: 28228 RVA: 0x000A2788 File Offset: 0x000A0988
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void SetLocalSetNotificationIcon(ref string smallIcon, ref string largeIcon)
		{
			UKuroPushSdkStaticLibrary.__SetLocalSetNotificationIcon_FunctionParams* ptr = stackalloc UKuroPushSdkStaticLibrary.__SetLocalSetNotificationIcon_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroPushSdkStaticLibrary.__SetLocalSetNotificationIcon_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPushSdkStaticLibrary.__SetLocalSetNotificationIcon_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->smallIcon), smallIcon);
			FString.CopyFrom((void*)(&ptr->largeIcon), largeIcon);
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__SetLocalSetNotificationIcon_NativeFunctionPtr, (void*)ptr);
			smallIcon = FString.ToString((void*)(&ptr->smallIcon));
			largeIcon = FString.ToString((void*)(&ptr->largeIcon));
			UnrealReflectionUtils.DestroyStruct(UKuroPushSdkStaticLibrary.__SetLocalSetNotificationIcon_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06006E45 RID: 28229 RVA: 0x000A2810 File Offset: 0x000A0A10
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void SetLocalChannelIdAndName(ref string channelId, ref string channelName)
		{
			UKuroPushSdkStaticLibrary.__SetLocalChannelIdAndName_FunctionParams* ptr = stackalloc UKuroPushSdkStaticLibrary.__SetLocalChannelIdAndName_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroPushSdkStaticLibrary.__SetLocalChannelIdAndName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPushSdkStaticLibrary.__SetLocalChannelIdAndName_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->channelId), channelId);
			FString.CopyFrom((void*)(&ptr->channelName), channelName);
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__SetLocalChannelIdAndName_NativeFunctionPtr, (void*)ptr);
			channelId = FString.ToString((void*)(&ptr->channelId));
			channelName = FString.ToString((void*)(&ptr->channelName));
			UnrealReflectionUtils.DestroyStruct(UKuroPushSdkStaticLibrary.__SetLocalChannelIdAndName_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06006E46 RID: 28230 RVA: 0x000A2898 File Offset: 0x000A0A98
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void SetLocalChannelId(ref string channelId)
		{
			UKuroPushSdkStaticLibrary.__SetLocalChannelId_FunctionParams* ptr = stackalloc UKuroPushSdkStaticLibrary.__SetLocalChannelId_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroPushSdkStaticLibrary.__SetLocalChannelId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPushSdkStaticLibrary.__SetLocalChannelId_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->channelId), channelId);
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__SetLocalChannelId_NativeFunctionPtr, (void*)ptr);
			channelId = FString.ToString((void*)(&ptr->channelId));
			UnrealReflectionUtils.DestroyStruct(UKuroPushSdkStaticLibrary.__SetLocalChannelId_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06006E47 RID: 28231 RVA: 0x000A2903 File Offset: 0x000A0B03
		[SkipLocalsInit]
		public static void SetDebug()
		{
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__SetDebug_NativeFunctionPtr, null);
		}

		// Token: 0x06006E48 RID: 28232 RVA: 0x000A2918 File Offset: 0x000A0B18
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void SetChannel(string channelId)
		{
			UKuroPushSdkStaticLibrary.__SetChannel_FunctionParams* ptr = stackalloc UKuroPushSdkStaticLibrary.__SetChannel_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroPushSdkStaticLibrary.__SetChannel_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPushSdkStaticLibrary.__SetChannel_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->channelId), channelId);
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__SetChannel_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroPushSdkStaticLibrary.__SetChannel_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06006E49 RID: 28233 RVA: 0x000A2974 File Offset: 0x000A0B74
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void SetBudge(string budge)
		{
			UKuroPushSdkStaticLibrary.__SetBudge_FunctionParams* ptr = stackalloc UKuroPushSdkStaticLibrary.__SetBudge_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroPushSdkStaticLibrary.__SetBudge_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPushSdkStaticLibrary.__SetBudge_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->budge), budge);
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__SetBudge_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroPushSdkStaticLibrary.__SetBudge_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06006E4A RID: 28234 RVA: 0x000A29D0 File Offset: 0x000A0BD0
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void SetApplicationGroupIdentify(string identify)
		{
			UKuroPushSdkStaticLibrary.__SetApplicationGroupIdentify_FunctionParams* ptr = stackalloc UKuroPushSdkStaticLibrary.__SetApplicationGroupIdentify_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroPushSdkStaticLibrary.__SetApplicationGroupIdentify_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPushSdkStaticLibrary.__SetApplicationGroupIdentify_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->identify), identify);
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__SetApplicationGroupIdentify_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroPushSdkStaticLibrary.__SetApplicationGroupIdentify_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06006E4B RID: 28235 RVA: 0x000A2A2C File Offset: 0x000A0C2C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void SendFeedBackMessage(string actionId, string taskId, string msgId)
		{
			UKuroPushSdkStaticLibrary.__SendFeedBackMessage_FunctionParams* ptr = stackalloc UKuroPushSdkStaticLibrary.__SendFeedBackMessage_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UKuroPushSdkStaticLibrary.__SendFeedBackMessage_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPushSdkStaticLibrary.__SendFeedBackMessage_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->actionId), actionId);
			FString.CopyFrom((void*)(&ptr->taskId), taskId);
			FString.CopyFrom((void*)(&ptr->msgId), msgId);
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__SendFeedBackMessage_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroPushSdkStaticLibrary.__SendFeedBackMessage_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06006E4C RID: 28236 RVA: 0x000A2AA2 File Offset: 0x000A0CA2
		[SkipLocalsInit]
		public static void Resume()
		{
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__Resume_NativeFunctionPtr, null);
		}

		// Token: 0x06006E4D RID: 28237 RVA: 0x000A2AB5 File Offset: 0x000A0CB5
		[SkipLocalsInit]
		public static void ResetBudge()
		{
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__ResetBudge_NativeFunctionPtr, null);
		}

		// Token: 0x06006E4E RID: 28238 RVA: 0x000A2AC8 File Offset: 0x000A0CC8
		[SkipLocalsInit]
		public static void RegistRemoteNotification()
		{
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__RegistRemoteNotification_NativeFunctionPtr, null);
		}

		// Token: 0x06006E4F RID: 28239 RVA: 0x000A2ADC File Offset: 0x000A0CDC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void PushLocalNotification(string title, string body, string exData)
		{
			UKuroPushSdkStaticLibrary.__PushLocalNotification_FunctionParams* ptr = stackalloc UKuroPushSdkStaticLibrary.__PushLocalNotification_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UKuroPushSdkStaticLibrary.__PushLocalNotification_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPushSdkStaticLibrary.__PushLocalNotification_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->title), title);
			FString.CopyFrom((void*)(&ptr->body), body);
			FString.CopyFrom((void*)(&ptr->exData), exData);
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__PushLocalNotification_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroPushSdkStaticLibrary.__PushLocalNotification_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06006E50 RID: 28240 RVA: 0x000A2B52 File Offset: 0x000A0D52
		[SkipLocalsInit]
		public static void OpenNotification()
		{
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__OpenNotification_NativeFunctionPtr, null);
		}

		// Token: 0x06006E51 RID: 28241 RVA: 0x000A2B68 File Offset: 0x000A0D68
		[SkipLocalsInit]
		public unsafe static bool IsPushTurnOn()
		{
			UKuroPushSdkStaticLibrary.__IsPushTurnOn_FunctionParams* ptr = stackalloc UKuroPushSdkStaticLibrary.__IsPushTurnOn_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroPushSdkStaticLibrary.__IsPushTurnOn_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPushSdkStaticLibrary.__IsPushTurnOn_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__IsPushTurnOn_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06006E52 RID: 28242 RVA: 0x000A2BAC File Offset: 0x000A0DAC
		[SkipLocalsInit]
		public static void Init()
		{
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__Init_NativeFunctionPtr, null);
		}

		// Token: 0x06006E53 RID: 28243 RVA: 0x000A2BC0 File Offset: 0x000A0DC0
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static string GetVersion()
		{
			UKuroPushSdkStaticLibrary.__GetVersion_FunctionParams* ptr = stackalloc UKuroPushSdkStaticLibrary.__GetVersion_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroPushSdkStaticLibrary.__GetVersion_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPushSdkStaticLibrary.__GetVersion_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__GetVersion_NativeFunctionPtr, (void*)ptr);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroPushSdkStaticLibrary.__GetVersion_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06006E54 RID: 28244 RVA: 0x000A2C1C File Offset: 0x000A0E1C
		[SkipLocalsInit]
		public unsafe static int GetStatus()
		{
			UKuroPushSdkStaticLibrary.__GetStatus_FunctionParams* ptr = stackalloc UKuroPushSdkStaticLibrary.__GetStatus_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroPushSdkStaticLibrary.__GetStatus_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPushSdkStaticLibrary.__GetStatus_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__GetStatus_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06006E55 RID: 28245 RVA: 0x000A2C60 File Offset: 0x000A0E60
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static UKuroPushObject GetPushObject()
		{
			UKuroPushSdkStaticLibrary.__GetPushObject_FunctionParams* ptr = stackalloc UKuroPushSdkStaticLibrary.__GetPushObject_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroPushSdkStaticLibrary.__GetPushObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPushSdkStaticLibrary.__GetPushObject_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__GetPushObject_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroPushObject>(ptr->__Result);
		}

		// Token: 0x06006E56 RID: 28246 RVA: 0x000A2CAC File Offset: 0x000A0EAC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static string GetClientId()
		{
			UKuroPushSdkStaticLibrary.__GetClientId_FunctionParams* ptr = stackalloc UKuroPushSdkStaticLibrary.__GetClientId_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroPushSdkStaticLibrary.__GetClientId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPushSdkStaticLibrary.__GetClientId_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__GetClientId_NativeFunctionPtr, (void*)ptr);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroPushSdkStaticLibrary.__GetClientId_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06006E57 RID: 28247 RVA: 0x000A2D07 File Offset: 0x000A0F07
		[SkipLocalsInit]
		public static void Destroy()
		{
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__Destroy_NativeFunctionPtr, null);
		}

		// Token: 0x06006E58 RID: 28248 RVA: 0x000A2D1A File Offset: 0x000A0F1A
		[SkipLocalsInit]
		public static void ClearNotificationForNotificationBar()
		{
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__ClearNotificationForNotificationBar_NativeFunctionPtr, null);
		}

		// Token: 0x06006E59 RID: 28249 RVA: 0x000A2D2D File Offset: 0x000A0F2D
		[SkipLocalsInit]
		public static void CheckManifest()
		{
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__CheckManifest_NativeFunctionPtr, null);
		}

		// Token: 0x06006E5A RID: 28250 RVA: 0x000A2D40 File Offset: 0x000A0F40
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void BindAlias(string alias, string sn)
		{
			UKuroPushSdkStaticLibrary.__BindAlias_FunctionParams* ptr = stackalloc UKuroPushSdkStaticLibrary.__BindAlias_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroPushSdkStaticLibrary.__BindAlias_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPushSdkStaticLibrary.__BindAlias_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->alias), alias);
			FString.CopyFrom((void*)(&ptr->sn), sn);
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__BindAlias_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroPushSdkStaticLibrary.__BindAlias_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06006E5B RID: 28251 RVA: 0x000A2DA9 File Offset: 0x000A0FA9
		[SkipLocalsInit]
		public static void AreNotificationEnable()
		{
			UnrealReflectionUtils.CallUFunction(UKuroPushSdkStaticLibrary._ClassDefaultObjectPtr, UKuroPushSdkStaticLibrary.__AreNotificationEnable_NativeFunctionPtr, null);
		}

		// Token: 0x06006E5C RID: 28252 RVA: 0x000A2DBC File Offset: 0x000A0FBC
		static UKuroPushSdkStaticLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroPushSdk.KuroPushSdkStaticLibrary");
		}

		// Token: 0x06006E5D RID: 28253 RVA: 0x000A2DCA File Offset: 0x000A0FCA
		protected UKuroPushSdkStaticLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002F37 RID: 12087
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroPushSdk.KuroPushSdkStaticLibrary";

		// Token: 0x04002F38 RID: 12088
		private static IntPtr _ClassPtr;

		// Token: 0x04002F39 RID: 12089
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002F3A RID: 12090
		private static IntPtr __VoipRegistration_NativeFunctionPtr;

		// Token: 0x04002F3B RID: 12091
		private static IntPtr __UnBindAlias_NativeFunctionPtr;

		// Token: 0x04002F3C RID: 12092
		private static IntPtr __TurnOnPush_NativeFunctionPtr;

		// Token: 0x04002F3D RID: 12093
		private static IntPtr __TurnOffPush_NativeFunctionPtr;

		// Token: 0x04002F3E RID: 12094
		private static IntPtr __StartPushSdk_NativeFunctionPtr;

		// Token: 0x04002F3F RID: 12095
		private static IntPtr __SetTag_NativeFunctionPtr;

		// Token: 0x04002F40 RID: 12096
		private static IntPtr __SetRunInBackGround_NativeFunctionPtr;

		// Token: 0x04002F41 RID: 12097
		private static IntPtr __SetPushMode_NativeFunctionPtr;

		// Token: 0x04002F42 RID: 12098
		private static IntPtr __SetNotificationIcon_NativeFunctionPtr;

		// Token: 0x04002F43 RID: 12099
		private static IntPtr __SetLocationEnable_NativeFunctionPtr;

		// Token: 0x04002F44 RID: 12100
		private static IntPtr __SetLocalSetNotificationIcon_NativeFunctionPtr;

		// Token: 0x04002F45 RID: 12101
		private static IntPtr __SetLocalChannelIdAndName_NativeFunctionPtr;

		// Token: 0x04002F46 RID: 12102
		private static IntPtr __SetLocalChannelId_NativeFunctionPtr;

		// Token: 0x04002F47 RID: 12103
		private static IntPtr __SetDebug_NativeFunctionPtr;

		// Token: 0x04002F48 RID: 12104
		private static IntPtr __SetChannel_NativeFunctionPtr;

		// Token: 0x04002F49 RID: 12105
		private static IntPtr __SetBudge_NativeFunctionPtr;

		// Token: 0x04002F4A RID: 12106
		private static IntPtr __SetApplicationGroupIdentify_NativeFunctionPtr;

		// Token: 0x04002F4B RID: 12107
		private static IntPtr __SendFeedBackMessage_NativeFunctionPtr;

		// Token: 0x04002F4C RID: 12108
		private static IntPtr __Resume_NativeFunctionPtr;

		// Token: 0x04002F4D RID: 12109
		private static IntPtr __ResetBudge_NativeFunctionPtr;

		// Token: 0x04002F4E RID: 12110
		private static IntPtr __RegistRemoteNotification_NativeFunctionPtr;

		// Token: 0x04002F4F RID: 12111
		private static IntPtr __PushLocalNotification_NativeFunctionPtr;

		// Token: 0x04002F50 RID: 12112
		private static IntPtr __OpenNotification_NativeFunctionPtr;

		// Token: 0x04002F51 RID: 12113
		private static IntPtr __IsPushTurnOn_NativeFunctionPtr;

		// Token: 0x04002F52 RID: 12114
		private static IntPtr __Init_NativeFunctionPtr;

		// Token: 0x04002F53 RID: 12115
		private static IntPtr __GetVersion_NativeFunctionPtr;

		// Token: 0x04002F54 RID: 12116
		private static IntPtr __GetStatus_NativeFunctionPtr;

		// Token: 0x04002F55 RID: 12117
		private static IntPtr __GetPushObject_NativeFunctionPtr;

		// Token: 0x04002F56 RID: 12118
		private static IntPtr __GetClientId_NativeFunctionPtr;

		// Token: 0x04002F57 RID: 12119
		private static IntPtr __Destroy_NativeFunctionPtr;

		// Token: 0x04002F58 RID: 12120
		private static IntPtr __ClearNotificationForNotificationBar_NativeFunctionPtr;

		// Token: 0x04002F59 RID: 12121
		private static IntPtr __CheckManifest_NativeFunctionPtr;

		// Token: 0x04002F5A RID: 12122
		private static IntPtr __BindAlias_NativeFunctionPtr;

		// Token: 0x04002F5B RID: 12123
		private static IntPtr __AreNotificationEnable_NativeFunctionPtr;

		// Token: 0x02000BD7 RID: 3031
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __UnBindAlias_FunctionParams
		{
			// Token: 0x04005D82 RID: 23938
			[FieldOffset(0)]
			public FString alias;

			// Token: 0x04005D83 RID: 23939
			[FieldOffset(16)]
			public FString sn;

			// Token: 0x04005D84 RID: 23940
			[FieldOffset(32)]
			public bool isSelf;
		}

		// Token: 0x02000BD8 RID: 3032
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __StartPushSdk_FunctionParams
		{
			// Token: 0x04005D85 RID: 23941
			[FieldOffset(0)]
			public FString appId;

			// Token: 0x04005D86 RID: 23942
			[FieldOffset(16)]
			public FString appKey;

			// Token: 0x04005D87 RID: 23943
			[FieldOffset(32)]
			public FString appSecret;
		}

		// Token: 0x02000BD9 RID: 3033
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __SetTag_FunctionParams
		{
			// Token: 0x04005D88 RID: 23944
			[FieldOffset(0)]
			public FString tags;

			// Token: 0x04005D89 RID: 23945
			[FieldOffset(16)]
			public FString sn;

			// Token: 0x04005D8A RID: 23946
			[FieldOffset(32)]
			public bool __Result;
		}

		// Token: 0x02000BDA RID: 3034
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetRunInBackGround_FunctionParams
		{
			// Token: 0x04005D8B RID: 23947
			[FieldOffset(0)]
			public bool state;
		}

		// Token: 0x02000BDB RID: 3035
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetPushMode_FunctionParams
		{
			// Token: 0x04005D8C RID: 23948
			[FieldOffset(0)]
			public bool turnOn;
		}

		// Token: 0x02000BDC RID: 3036
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SetNotificationIcon_FunctionParams
		{
			// Token: 0x04005D8D RID: 23949
			[FieldOffset(0)]
			public FString smallIcon;

			// Token: 0x04005D8E RID: 23950
			[FieldOffset(16)]
			public FString largeIcon;
		}

		// Token: 0x02000BDD RID: 3037
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __SetLocationEnable_FunctionParams
		{
			// Token: 0x04005D8F RID: 23951
			[FieldOffset(0)]
			public bool isEnable;

			// Token: 0x04005D90 RID: 23952
			[FieldOffset(1)]
			public bool isVerify;
		}

		// Token: 0x02000BDE RID: 3038
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SetLocalSetNotificationIcon_FunctionParams
		{
			// Token: 0x04005D91 RID: 23953
			[FieldOffset(0)]
			public FString smallIcon;

			// Token: 0x04005D92 RID: 23954
			[FieldOffset(16)]
			public FString largeIcon;
		}

		// Token: 0x02000BDF RID: 3039
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SetLocalChannelIdAndName_FunctionParams
		{
			// Token: 0x04005D93 RID: 23955
			[FieldOffset(0)]
			public FString channelId;

			// Token: 0x04005D94 RID: 23956
			[FieldOffset(16)]
			public FString channelName;
		}

		// Token: 0x02000BE0 RID: 3040
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetLocalChannelId_FunctionParams
		{
			// Token: 0x04005D95 RID: 23957
			[FieldOffset(0)]
			public FString channelId;
		}

		// Token: 0x02000BE1 RID: 3041
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetChannel_FunctionParams
		{
			// Token: 0x04005D96 RID: 23958
			[FieldOffset(0)]
			public FString channelId;
		}

		// Token: 0x02000BE2 RID: 3042
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetBudge_FunctionParams
		{
			// Token: 0x04005D97 RID: 23959
			[FieldOffset(0)]
			public FString budge;
		}

		// Token: 0x02000BE3 RID: 3043
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetApplicationGroupIdentify_FunctionParams
		{
			// Token: 0x04005D98 RID: 23960
			[FieldOffset(0)]
			public FString identify;
		}

		// Token: 0x02000BE4 RID: 3044
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __SendFeedBackMessage_FunctionParams
		{
			// Token: 0x04005D99 RID: 23961
			[FieldOffset(0)]
			public FString actionId;

			// Token: 0x04005D9A RID: 23962
			[FieldOffset(16)]
			public FString taskId;

			// Token: 0x04005D9B RID: 23963
			[FieldOffset(32)]
			public FString msgId;
		}

		// Token: 0x02000BE5 RID: 3045
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __PushLocalNotification_FunctionParams
		{
			// Token: 0x04005D9C RID: 23964
			[FieldOffset(0)]
			public FString title;

			// Token: 0x04005D9D RID: 23965
			[FieldOffset(16)]
			public FString body;

			// Token: 0x04005D9E RID: 23966
			[FieldOffset(32)]
			public FString exData;
		}

		// Token: 0x02000BE6 RID: 3046
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsPushTurnOn_FunctionParams
		{
			// Token: 0x04005D9F RID: 23967
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02000BE7 RID: 3047
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetVersion_FunctionParams
		{
			// Token: 0x04005DA0 RID: 23968
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x02000BE8 RID: 3048
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetStatus_FunctionParams
		{
			// Token: 0x04005DA1 RID: 23969
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02000BE9 RID: 3049
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetPushObject_FunctionParams
		{
			// Token: 0x04005DA2 RID: 23970
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x02000BEA RID: 3050
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetClientId_FunctionParams
		{
			// Token: 0x04005DA3 RID: 23971
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x02000BEB RID: 3051
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BindAlias_FunctionParams
		{
			// Token: 0x04005DA4 RID: 23972
			[FieldOffset(0)]
			public FString alias;

			// Token: 0x04005DA5 RID: 23973
			[FieldOffset(16)]
			public FString sn;
		}
	}
}
