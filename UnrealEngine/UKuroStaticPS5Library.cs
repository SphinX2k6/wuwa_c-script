using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005E8 RID: 1512
	[UnrealObjectPath("/Script/KuroUtility.KuroStaticPS5Library")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroStaticPS5Library : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008652 RID: 34386 RVA: 0x000C6E4D File Offset: 0x000C504D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroStaticPS5Library._ClassPtr;
		}

		// Token: 0x06008653 RID: 34387 RVA: 0x000C6E5C File Offset: 0x000C505C
		public UKuroStaticPS5Library() : this(BuiltinUtils.AllocNativeUObject(UKuroStaticPS5Library.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008654 RID: 34388 RVA: 0x000C6E84 File Offset: 0x000C5084
		[NullableContext(1)]
		public UKuroStaticPS5Library(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroStaticPS5Library.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06008655 RID: 34389 RVA: 0x000C6EB8 File Offset: 0x000C50B8
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void UpdateTrophyProgressWithContextIdAndHandleIdAsync(int context, int handle, int trophyId, int progress, in FPlayStationUpdateTrophyCallBack callback)
		{
			UKuroStaticPS5Library.__UpdateTrophyProgressWithContextIdAndHandleIdAsync_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__UpdateTrophyProgressWithContextIdAndHandleIdAsync_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(UKuroStaticPS5Library.__UpdateTrophyProgressWithContextIdAndHandleIdAsync_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__UpdateTrophyProgressWithContextIdAndHandleIdAsync_NativeFunctionPtr, (void*)ptr, 1);
			ptr->context = context;
			ptr->handle = handle;
			ptr->trophyId = trophyId;
			ptr->progress = progress;
			IntPtr dest = &ptr->callback;
			FPlayStationUpdateTrophyCallBack fplayStationUpdateTrophyCallBack = callback;
			FScriptDelegate.NativeCopy(dest, (fplayStationUpdateTrophyCallBack != null) ? fplayStationUpdateTrophyCallBack.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__UpdateTrophyProgressWithContextIdAndHandleIdAsync_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__UpdateTrophyProgressWithContextIdAndHandleIdAsync_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06008656 RID: 34390 RVA: 0x000C6F40 File Offset: 0x000C5140
		[SkipLocalsInit]
		public unsafe static int UpdateTrophyProgressWithContextIdAndHandleId(int context, int handle, int trophyId, int progress)
		{
			UKuroStaticPS5Library.__UpdateTrophyProgressWithContextIdAndHandleId_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__UpdateTrophyProgressWithContextIdAndHandleId_FunctionParams[(UIntPtr)35] + 15L / (long)sizeof(UKuroStaticPS5Library.__UpdateTrophyProgressWithContextIdAndHandleId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__UpdateTrophyProgressWithContextIdAndHandleId_NativeFunctionPtr, (void*)ptr, 1);
			ptr->context = context;
			ptr->handle = handle;
			ptr->trophyId = trophyId;
			ptr->progress = progress;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__UpdateTrophyProgressWithContextIdAndHandleId_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06008657 RID: 34391 RVA: 0x000C6FA0 File Offset: 0x000C51A0
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static int UpdateTrophyProgress(ref string userId, int trophyId, int progress)
		{
			UKuroStaticPS5Library.__UpdateTrophyProgress_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__UpdateTrophyProgress_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroStaticPS5Library.__UpdateTrophyProgress_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__UpdateTrophyProgress_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->userId), userId);
			ptr->trophyId = trophyId;
			ptr->progress = progress;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__UpdateTrophyProgress_NativeFunctionPtr, (void*)ptr);
			userId = FString.ToString((void*)(&ptr->userId));
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__UpdateTrophyProgress_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06008658 RID: 34392 RVA: 0x000C7020 File Offset: 0x000C5220
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void UnlockTrophyWithContextIdAndHandleIdAsync(int contextId, int handle, int trophyId, in FPlayStationUnlockTrophyCallBack callback)
		{
			UKuroStaticPS5Library.__UnlockTrophyWithContextIdAndHandleIdAsync_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__UnlockTrophyWithContextIdAndHandleIdAsync_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(UKuroStaticPS5Library.__UnlockTrophyWithContextIdAndHandleIdAsync_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__UnlockTrophyWithContextIdAndHandleIdAsync_NativeFunctionPtr, (void*)ptr, 1);
			ptr->contextId = contextId;
			ptr->handle = handle;
			ptr->trophyId = trophyId;
			IntPtr dest = &ptr->callback;
			FPlayStationUnlockTrophyCallBack fplayStationUnlockTrophyCallBack = callback;
			FScriptDelegate.NativeCopy(dest, (fplayStationUnlockTrophyCallBack != null) ? fplayStationUnlockTrophyCallBack.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__UnlockTrophyWithContextIdAndHandleIdAsync_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__UnlockTrophyWithContextIdAndHandleIdAsync_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06008659 RID: 34393 RVA: 0x000C70A0 File Offset: 0x000C52A0
		[SkipLocalsInit]
		public unsafe static int UnlockTrophyWithContextIdAndHandleId(int contextId, int handle, int trophyId)
		{
			UKuroStaticPS5Library.__UnlockTrophyWithContextIdAndHandleId_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__UnlockTrophyWithContextIdAndHandleId_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroStaticPS5Library.__UnlockTrophyWithContextIdAndHandleId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__UnlockTrophyWithContextIdAndHandleId_NativeFunctionPtr, (void*)ptr, 1);
			ptr->contextId = contextId;
			ptr->handle = handle;
			ptr->trophyId = trophyId;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__UnlockTrophyWithContextIdAndHandleId_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600865A RID: 34394 RVA: 0x000C70FC File Offset: 0x000C52FC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static int UnlockTrophy(ref string userId, int trophyId)
		{
			UKuroStaticPS5Library.__UnlockTrophy_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__UnlockTrophy_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroStaticPS5Library.__UnlockTrophy_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__UnlockTrophy_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->userId), userId);
			ptr->trophyId = trophyId;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__UnlockTrophy_NativeFunctionPtr, (void*)ptr);
			userId = FString.ToString((void*)(&ptr->userId));
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__UnlockTrophy_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0600865B RID: 34395 RVA: 0x000C7174 File Offset: 0x000C5374
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static int UdsEventPropertyObjectSetUInt64(long proPtr, ref string key, long value)
		{
			UKuroStaticPS5Library.__UdsEventPropertyObjectSetUInt64_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__UdsEventPropertyObjectSetUInt64_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UKuroStaticPS5Library.__UdsEventPropertyObjectSetUInt64_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__UdsEventPropertyObjectSetUInt64_NativeFunctionPtr, (void*)ptr, 1);
			ptr->proPtr = proPtr;
			FString.CopyFrom((void*)(&ptr->key), key);
			ptr->value = value;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__UdsEventPropertyObjectSetUInt64_NativeFunctionPtr, (void*)ptr);
			key = FString.ToString((void*)(&ptr->key));
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__UdsEventPropertyObjectSetUInt64_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0600865C RID: 34396 RVA: 0x000C71F4 File Offset: 0x000C53F4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static int UdsEventPropertyObjectSetUInt32(long proPtr, ref string key, int value)
		{
			UKuroStaticPS5Library.__UdsEventPropertyObjectSetUInt32_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__UdsEventPropertyObjectSetUInt32_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroStaticPS5Library.__UdsEventPropertyObjectSetUInt32_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__UdsEventPropertyObjectSetUInt32_NativeFunctionPtr, (void*)ptr, 1);
			ptr->proPtr = proPtr;
			FString.CopyFrom((void*)(&ptr->key), key);
			ptr->value = value;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__UdsEventPropertyObjectSetUInt32_NativeFunctionPtr, (void*)ptr);
			key = FString.ToString((void*)(&ptr->key));
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__UdsEventPropertyObjectSetUInt32_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0600865D RID: 34397 RVA: 0x000C7274 File Offset: 0x000C5474
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static int UdsEventPropertyObjectSetString(long proPtr, ref string key, ref string value)
		{
			UKuroStaticPS5Library.__UdsEventPropertyObjectSetString_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__UdsEventPropertyObjectSetString_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UKuroStaticPS5Library.__UdsEventPropertyObjectSetString_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__UdsEventPropertyObjectSetString_NativeFunctionPtr, (void*)ptr, 1);
			ptr->proPtr = proPtr;
			FString.CopyFrom((void*)(&ptr->key), key);
			FString.CopyFrom((void*)(&ptr->value), value);
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__UdsEventPropertyObjectSetString_NativeFunctionPtr, (void*)ptr);
			key = FString.ToString((void*)(&ptr->key));
			value = FString.ToString((void*)(&ptr->value));
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__UdsEventPropertyObjectSetString_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0600865E RID: 34398 RVA: 0x000C7308 File Offset: 0x000C5508
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static int UdsEventPropertyObjectSetInt64(long proPtr, ref string key, long value)
		{
			UKuroStaticPS5Library.__UdsEventPropertyObjectSetInt64_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__UdsEventPropertyObjectSetInt64_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UKuroStaticPS5Library.__UdsEventPropertyObjectSetInt64_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__UdsEventPropertyObjectSetInt64_NativeFunctionPtr, (void*)ptr, 1);
			ptr->proPtr = proPtr;
			FString.CopyFrom((void*)(&ptr->key), key);
			ptr->value = value;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__UdsEventPropertyObjectSetInt64_NativeFunctionPtr, (void*)ptr);
			key = FString.ToString((void*)(&ptr->key));
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__UdsEventPropertyObjectSetInt64_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0600865F RID: 34399 RVA: 0x000C7388 File Offset: 0x000C5588
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static int UdsEventPropertyObjectSetInt32(long proPtr, ref string key, int value)
		{
			UKuroStaticPS5Library.__UdsEventPropertyObjectSetInt32_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__UdsEventPropertyObjectSetInt32_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroStaticPS5Library.__UdsEventPropertyObjectSetInt32_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__UdsEventPropertyObjectSetInt32_NativeFunctionPtr, (void*)ptr, 1);
			ptr->proPtr = proPtr;
			FString.CopyFrom((void*)(&ptr->key), key);
			ptr->value = value;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__UdsEventPropertyObjectSetInt32_NativeFunctionPtr, (void*)ptr);
			key = FString.ToString((void*)(&ptr->key));
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__UdsEventPropertyObjectSetInt32_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06008660 RID: 34400 RVA: 0x000C7408 File Offset: 0x000C5608
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static int UdsEventPropertyObjectSetFloat64(long proPtr, ref string key, double value)
		{
			UKuroStaticPS5Library.__UdsEventPropertyObjectSetFloat64_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__UdsEventPropertyObjectSetFloat64_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UKuroStaticPS5Library.__UdsEventPropertyObjectSetFloat64_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__UdsEventPropertyObjectSetFloat64_NativeFunctionPtr, (void*)ptr, 1);
			ptr->proPtr = proPtr;
			FString.CopyFrom((void*)(&ptr->key), key);
			ptr->value = value;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__UdsEventPropertyObjectSetFloat64_NativeFunctionPtr, (void*)ptr);
			key = FString.ToString((void*)(&ptr->key));
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__UdsEventPropertyObjectSetFloat64_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06008661 RID: 34401 RVA: 0x000C7488 File Offset: 0x000C5688
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static int UdsEventPropertyObjectSetFloat32(long proPtr, ref string key, float value)
		{
			UKuroStaticPS5Library.__UdsEventPropertyObjectSetFloat32_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__UdsEventPropertyObjectSetFloat32_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroStaticPS5Library.__UdsEventPropertyObjectSetFloat32_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__UdsEventPropertyObjectSetFloat32_NativeFunctionPtr, (void*)ptr, 1);
			ptr->proPtr = proPtr;
			FString.CopyFrom((void*)(&ptr->key), key);
			ptr->value = value;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__UdsEventPropertyObjectSetFloat32_NativeFunctionPtr, (void*)ptr);
			key = FString.ToString((void*)(&ptr->key));
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__UdsEventPropertyObjectSetFloat32_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06008662 RID: 34402 RVA: 0x000C7508 File Offset: 0x000C5708
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static int UdsEventPropertyObjectSetBool(long proPtr, ref string key, bool value)
		{
			UKuroStaticPS5Library.__UdsEventPropertyObjectSetBool_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__UdsEventPropertyObjectSetBool_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroStaticPS5Library.__UdsEventPropertyObjectSetBool_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__UdsEventPropertyObjectSetBool_NativeFunctionPtr, (void*)ptr, 1);
			ptr->proPtr = proPtr;
			FString.CopyFrom((void*)(&ptr->key), key);
			ptr->value = value;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__UdsEventPropertyObjectSetBool_NativeFunctionPtr, (void*)ptr);
			key = FString.ToString((void*)(&ptr->key));
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__UdsEventPropertyObjectSetBool_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06008663 RID: 34403 RVA: 0x000C7588 File Offset: 0x000C5788
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static int UdsEventPropertyArraySetString(long proPtr, ref string key, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<string> value)
		{
			UKuroStaticPS5Library.__UdsEventPropertyArraySetString_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__UdsEventPropertyArraySetString_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UKuroStaticPS5Library.__UdsEventPropertyArraySetString_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__UdsEventPropertyArraySetString_NativeFunctionPtr, (void*)ptr, 1);
			ptr->proPtr = proPtr;
			FString.CopyFrom((void*)(&ptr->key), key);
			TArray<string> tarray = value;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->value);
			}
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__UdsEventPropertyArraySetString_NativeFunctionPtr, (void*)ptr);
			key = FString.ToString((void*)(&ptr->key));
			TArray<string> tarray2 = value;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->value);
			}
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__UdsEventPropertyArraySetString_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06008664 RID: 34404 RVA: 0x000C7628 File Offset: 0x000C5828
		[SkipLocalsInit]
		public unsafe static int TerminateWebBrowser()
		{
			UKuroStaticPS5Library.__TerminateWebBrowser_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__TerminateWebBrowser_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroStaticPS5Library.__TerminateWebBrowser_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__TerminateWebBrowser_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__TerminateWebBrowser_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06008665 RID: 34405 RVA: 0x000C766C File Offset: 0x000C586C
		[SkipLocalsInit]
		public static void TerminateMessageDialog()
		{
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__TerminateMessageDialog_NativeFunctionPtr, null);
		}

		// Token: 0x06008666 RID: 34406 RVA: 0x000C7680 File Offset: 0x000C5880
		[SkipLocalsInit]
		public unsafe static int ShowPsStoreIcon(int position)
		{
			UKuroStaticPS5Library.__ShowPsStoreIcon_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__ShowPsStoreIcon_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroStaticPS5Library.__ShowPsStoreIcon_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__ShowPsStoreIcon_NativeFunctionPtr, (void*)ptr, 1);
			ptr->position = position;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__ShowPsStoreIcon_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06008667 RID: 34407 RVA: 0x000C76CC File Offset: 0x000C58CC
		[SkipLocalsInit]
		public unsafe static void SetPlayerSessionJoinableUserType(int joinableUserType)
		{
			UKuroStaticPS5Library.__SetPlayerSessionJoinableUserType_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__SetPlayerSessionJoinableUserType_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroStaticPS5Library.__SetPlayerSessionJoinableUserType_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__SetPlayerSessionJoinableUserType_NativeFunctionPtr, (void*)ptr, 1);
			ptr->joinableUserType = joinableUserType;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__SetPlayerSessionJoinableUserType_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06008668 RID: 34408 RVA: 0x000C7714 File Offset: 0x000C5914
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static int SceNpGetNpReachabilityState(ref string userId, ref int outState)
		{
			UKuroStaticPS5Library.__SceNpGetNpReachabilityState_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__SceNpGetNpReachabilityState_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroStaticPS5Library.__SceNpGetNpReachabilityState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__SceNpGetNpReachabilityState_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->userId), userId);
			ptr->outState = outState;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__SceNpGetNpReachabilityState_NativeFunctionPtr, (void*)ptr);
			userId = FString.ToString((void*)(&ptr->userId));
			outState = ptr->outState;
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__SceNpGetNpReachabilityState_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06008669 RID: 34409 RVA: 0x000C7798 File Offset: 0x000C5998
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void RemoveCacheElement(string key)
		{
			UKuroStaticPS5Library.__RemoveCacheElement_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__RemoveCacheElement_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroStaticPS5Library.__RemoveCacheElement_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__RemoveCacheElement_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->key), key);
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__RemoveCacheElement_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__RemoveCacheElement_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600866A RID: 34410 RVA: 0x000C77F4 File Offset: 0x000C59F4
		[SkipLocalsInit]
		public unsafe static int RegisterUdsContext(int context, int handle)
		{
			UKuroStaticPS5Library.__RegisterUdsContext_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__RegisterUdsContext_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UKuroStaticPS5Library.__RegisterUdsContext_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__RegisterUdsContext_NativeFunctionPtr, (void*)ptr, 1);
			ptr->context = context;
			ptr->handle = handle;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__RegisterUdsContext_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600866B RID: 34411 RVA: 0x000C7848 File Offset: 0x000C5A48
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void RegisterTrophyContextAsync(ref int context, ref int handle, string optionsLong, [Nullable(2)] in FPlayStationRegisterContextCallBack callback)
		{
			UKuroStaticPS5Library.__RegisterTrophyContextAsync_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__RegisterTrophyContextAsync_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(UKuroStaticPS5Library.__RegisterTrophyContextAsync_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__RegisterTrophyContextAsync_NativeFunctionPtr, (void*)ptr, 1);
			ptr->context = context;
			ptr->handle = handle;
			FString.CopyFrom((void*)(&ptr->optionsLong), optionsLong);
			IntPtr dest = &ptr->callback;
			FPlayStationRegisterContextCallBack fplayStationRegisterContextCallBack = callback;
			FScriptDelegate.NativeCopy(dest, (fplayStationRegisterContextCallBack != null) ? fplayStationRegisterContextCallBack.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__RegisterTrophyContextAsync_NativeFunctionPtr, (void*)ptr);
			context = ptr->context;
			handle = ptr->handle;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__RegisterTrophyContextAsync_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600866C RID: 34412 RVA: 0x000C78E0 File Offset: 0x000C5AE0
		[SkipLocalsInit]
		public unsafe static int PostUdsEvent(int context, int handle, long eventPtr)
		{
			UKuroStaticPS5Library.__PostUdsEvent_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__PostUdsEvent_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroStaticPS5Library.__PostUdsEvent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__PostUdsEvent_NativeFunctionPtr, (void*)ptr, 1);
			ptr->context = context;
			ptr->handle = handle;
			ptr->eventPtr = eventPtr;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__PostUdsEvent_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600866D RID: 34413 RVA: 0x000C793C File Offset: 0x000C5B3C
		[SkipLocalsInit]
		public unsafe static bool PollWebBrowser()
		{
			UKuroStaticPS5Library.__PollWebBrowser_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__PollWebBrowser_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroStaticPS5Library.__PollWebBrowser_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__PollWebBrowser_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__PollWebBrowser_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600866E RID: 34414 RVA: 0x000C7980 File Offset: 0x000C5B80
		[SkipLocalsInit]
		public unsafe static int PollCheckoutDialogResult()
		{
			UKuroStaticPS5Library.__PollCheckoutDialogResult_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__PollCheckoutDialogResult_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroStaticPS5Library.__PollCheckoutDialogResult_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__PollCheckoutDialogResult_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__PollCheckoutDialogResult_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600866F RID: 34415 RVA: 0x000C79C4 File Offset: 0x000C5BC4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static int OpenWebView(ref string Url)
		{
			UKuroStaticPS5Library.__OpenWebView_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__OpenWebView_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroStaticPS5Library.__OpenWebView_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__OpenWebView_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Url), Url);
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__OpenWebView_NativeFunctionPtr, (void*)ptr);
			Url = FString.ToString((void*)(&ptr->Url));
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__OpenWebView_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06008670 RID: 34416 RVA: 0x000C7A38 File Offset: 0x000C5C38
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void OpenWebBrowser(ref string Url)
		{
			UKuroStaticPS5Library.__OpenWebBrowser_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__OpenWebBrowser_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroStaticPS5Library.__OpenWebBrowser_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__OpenWebBrowser_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Url), Url);
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__OpenWebBrowser_NativeFunctionPtr, (void*)ptr);
			Url = FString.ToString((void*)(&ptr->Url));
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__OpenWebBrowser_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06008671 RID: 34417 RVA: 0x000C7AA4 File Offset: 0x000C5CA4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void OpenMessageDialog(ref string userId, int openMode, int msgType, [Nullable(2)] in FPlayStationOpenDialogCallBack callback)
		{
			UKuroStaticPS5Library.__OpenMessageDialog_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__OpenMessageDialog_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(UKuroStaticPS5Library.__OpenMessageDialog_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__OpenMessageDialog_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->userId), userId);
			ptr->openMode = openMode;
			ptr->msgType = msgType;
			IntPtr dest = &ptr->callback;
			FPlayStationOpenDialogCallBack fplayStationOpenDialogCallBack = callback;
			FScriptDelegate.NativeCopy(dest, (fplayStationOpenDialogCallBack != null) ? fplayStationOpenDialogCallBack.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__OpenMessageDialog_NativeFunctionPtr, (void*)ptr);
			userId = FString.ToString((void*)(&ptr->userId));
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__OpenMessageDialog_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06008672 RID: 34418 RVA: 0x000C7B38 File Offset: 0x000C5D38
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static int OpenCheckoutDialog(ref string ProductLabel)
		{
			UKuroStaticPS5Library.__OpenCheckoutDialog_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__OpenCheckoutDialog_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroStaticPS5Library.__OpenCheckoutDialog_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__OpenCheckoutDialog_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->ProductLabel), ProductLabel);
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__OpenCheckoutDialog_NativeFunctionPtr, (void*)ptr);
			ProductLabel = FString.ToString((void*)(&ptr->ProductLabel));
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__OpenCheckoutDialog_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06008673 RID: 34419 RVA: 0x000C7BAC File Offset: 0x000C5DAC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void NotifyPremiumFeature(ref string userId, bool isPlayStationOnly)
		{
			UKuroStaticPS5Library.__NotifyPremiumFeature_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__NotifyPremiumFeature_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroStaticPS5Library.__NotifyPremiumFeature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__NotifyPremiumFeature_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->userId), userId);
			ptr->isPlayStationOnly = isPlayStationOnly;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__NotifyPremiumFeature_NativeFunctionPtr, (void*)ptr);
			userId = FString.ToString((void*)(&ptr->userId));
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__NotifyPremiumFeature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06008674 RID: 34420 RVA: 0x000C7C20 File Offset: 0x000C5E20
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void NotifyPremium(ref string userId)
		{
			UKuroStaticPS5Library.__NotifyPremium_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__NotifyPremium_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroStaticPS5Library.__NotifyPremium_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__NotifyPremium_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->userId), userId);
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__NotifyPremium_NativeFunctionPtr, (void*)ptr);
			userId = FString.ToString((void*)(&ptr->userId));
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__NotifyPremium_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06008675 RID: 34421 RVA: 0x000C7C8B File Offset: 0x000C5E8B
		[SkipLocalsInit]
		public static void LeavePlayerSession()
		{
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__LeavePlayerSession_NativeFunctionPtr, null);
		}

		// Token: 0x06008676 RID: 34422 RVA: 0x000C7CA0 File Offset: 0x000C5EA0
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void JoinPlayerSession(ref string playerSessionId)
		{
			UKuroStaticPS5Library.__JoinPlayerSession_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__JoinPlayerSession_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroStaticPS5Library.__JoinPlayerSession_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__JoinPlayerSession_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->playerSessionId), playerSessionId);
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__JoinPlayerSession_NativeFunctionPtr, (void*)ptr);
			playerSessionId = FString.ToString((void*)(&ptr->playerSessionId));
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__JoinPlayerSession_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06008677 RID: 34423 RVA: 0x000C7D0C File Offset: 0x000C5F0C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static int InitWebApi(ref string userId)
		{
			UKuroStaticPS5Library.__InitWebApi_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__InitWebApi_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroStaticPS5Library.__InitWebApi_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__InitWebApi_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->userId), userId);
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__InitWebApi_NativeFunctionPtr, (void*)ptr);
			userId = FString.ToString((void*)(&ptr->userId));
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__InitWebApi_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06008678 RID: 34424 RVA: 0x000C7D80 File Offset: 0x000C5F80
		[SkipLocalsInit]
		public unsafe static int InitNpUniversalDataSystem(int poolSize)
		{
			UKuroStaticPS5Library.__InitNpUniversalDataSystem_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__InitNpUniversalDataSystem_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroStaticPS5Library.__InitNpUniversalDataSystem_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__InitNpUniversalDataSystem_NativeFunctionPtr, (void*)ptr, 1);
			ptr->poolSize = poolSize;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__InitNpUniversalDataSystem_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06008679 RID: 34425 RVA: 0x000C7DCC File Offset: 0x000C5FCC
		[SkipLocalsInit]
		public unsafe static int HidePsStoreIcon()
		{
			UKuroStaticPS5Library.__HidePsStoreIcon_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__HidePsStoreIcon_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroStaticPS5Library.__HidePsStoreIcon_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__HidePsStoreIcon_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__HidePsStoreIcon_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600867A RID: 34426 RVA: 0x000C7E10 File Offset: 0x000C6010
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static string GetUserIdByAccountId(ref string accountId)
		{
			UKuroStaticPS5Library.__GetUserIdByAccountId_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__GetUserIdByAccountId_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroStaticPS5Library.__GetUserIdByAccountId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__GetUserIdByAccountId_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->accountId), accountId);
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__GetUserIdByAccountId_NativeFunctionPtr, (void*)ptr);
			accountId = FString.ToString((void*)(&ptr->accountId));
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__GetUserIdByAccountId_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600867B RID: 34427 RVA: 0x000C7E88 File Offset: 0x000C6088
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static string GetUserId()
		{
			UKuroStaticPS5Library.__GetUserId_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__GetUserId_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroStaticPS5Library.__GetUserId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__GetUserId_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__GetUserId_NativeFunctionPtr, (void*)ptr);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__GetUserId_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600867C RID: 34428 RVA: 0x000C7EE4 File Offset: 0x000C60E4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void GetTrophyListWithContextIdAndHandleIdAsync(ref int inputOffset, int length, int context, int handle, in FGetTrophyCallBack callback)
		{
			UKuroStaticPS5Library.__GetTrophyListWithContextIdAndHandleIdAsync_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__GetTrophyListWithContextIdAndHandleIdAsync_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(UKuroStaticPS5Library.__GetTrophyListWithContextIdAndHandleIdAsync_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__GetTrophyListWithContextIdAndHandleIdAsync_NativeFunctionPtr, (void*)ptr, 1);
			ptr->inputOffset = inputOffset;
			ptr->length = length;
			ptr->context = context;
			ptr->handle = handle;
			IntPtr dest = &ptr->callback;
			FGetTrophyCallBack fgetTrophyCallBack = callback;
			FScriptDelegate.NativeCopy(dest, (fgetTrophyCallBack != null) ? fgetTrophyCallBack.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__GetTrophyListWithContextIdAndHandleIdAsync_NativeFunctionPtr, (void*)ptr);
			inputOffset = ptr->inputOffset;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__GetTrophyListWithContextIdAndHandleIdAsync_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600867D RID: 34429 RVA: 0x000C7F74 File Offset: 0x000C6174
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static FTrophyInfoData GetTrophyListWithContextIdAndHandleId(int context, int handle, ref int inputOffset, int length)
		{
			UKuroStaticPS5Library.__GetTrophyListWithContextIdAndHandleId_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__GetTrophyListWithContextIdAndHandleId_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(UKuroStaticPS5Library.__GetTrophyListWithContextIdAndHandleId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__GetTrophyListWithContextIdAndHandleId_NativeFunctionPtr, (void*)ptr, 1);
			ptr->context = context;
			ptr->handle = handle;
			ptr->inputOffset = inputOffset;
			ptr->length = length;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__GetTrophyListWithContextIdAndHandleId_NativeFunctionPtr, (void*)ptr);
			inputOffset = ptr->inputOffset;
			FTrophyInfoData result = new FTrophyInfoData(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__GetTrophyListWithContextIdAndHandleId_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600867E RID: 34430 RVA: 0x000C7FF8 File Offset: 0x000C61F8
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static FTrophyInfoData GetTrophyList(ref string userId, ref int inputOffset, int length)
		{
			UKuroStaticPS5Library.__GetTrophyList_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__GetTrophyList_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(UKuroStaticPS5Library.__GetTrophyList_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__GetTrophyList_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->userId), userId);
			ptr->inputOffset = inputOffset;
			ptr->length = length;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__GetTrophyList_NativeFunctionPtr, (void*)ptr);
			userId = FString.ToString((void*)(&ptr->userId));
			inputOffset = ptr->inputOffset;
			FTrophyInfoData result = new FTrophyInfoData(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__GetTrophyList_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600867F RID: 34431 RVA: 0x000C8088 File Offset: 0x000C6288
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static TArray<FProductData> GetStoreProductsWithParams(int ServiceLabel, int Offset, int Limit)
		{
			UKuroStaticPS5Library.__GetStoreProductsWithParams_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__GetStoreProductsWithParams_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroStaticPS5Library.__GetStoreProductsWithParams_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__GetStoreProductsWithParams_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ServiceLabel = ServiceLabel;
			ptr->Offset = Offset;
			ptr->Limit = Limit;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__GetStoreProductsWithParams_NativeFunctionPtr, (void*)ptr);
			TArray<FProductData> result = new TArray<FProductData>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__GetStoreProductsWithParams_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06008680 RID: 34432 RVA: 0x000C80FC File Offset: 0x000C62FC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static TArray<FProductData> GetStoreProducts()
		{
			UKuroStaticPS5Library.__GetStoreProducts_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__GetStoreProducts_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroStaticPS5Library.__GetStoreProducts_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__GetStoreProducts_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__GetStoreProducts_NativeFunctionPtr, (void*)ptr);
			TArray<FProductData> result = new TArray<FProductData>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__GetStoreProducts_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06008681 RID: 34433 RVA: 0x000C815C File Offset: 0x000C635C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static string GetPlayerIdByPlayerSessionId(ref string playerSessionId)
		{
			UKuroStaticPS5Library.__GetPlayerIdByPlayerSessionId_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__GetPlayerIdByPlayerSessionId_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroStaticPS5Library.__GetPlayerIdByPlayerSessionId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__GetPlayerIdByPlayerSessionId_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->playerSessionId), playerSessionId);
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__GetPlayerIdByPlayerSessionId_NativeFunctionPtr, (void*)ptr);
			playerSessionId = FString.ToString((void*)(&ptr->playerSessionId));
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__GetPlayerIdByPlayerSessionId_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06008682 RID: 34434 RVA: 0x000C81D4 File Offset: 0x000C63D4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static string GetOnlineIdByUserId(ref string userId)
		{
			UKuroStaticPS5Library.__GetOnlineIdByUserId_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__GetOnlineIdByUserId_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroStaticPS5Library.__GetOnlineIdByUserId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__GetOnlineIdByUserId_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->userId), userId);
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__GetOnlineIdByUserId_NativeFunctionPtr, (void*)ptr);
			userId = FString.ToString((void*)(&ptr->userId));
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__GetOnlineIdByUserId_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06008683 RID: 34435 RVA: 0x000C824C File Offset: 0x000C644C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void GetMessageDialogStateAsync(in FPlayStationGetDialogStatusCallBack callback)
		{
			UKuroStaticPS5Library.__GetMessageDialogStateAsync_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__GetMessageDialogStateAsync_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UKuroStaticPS5Library.__GetMessageDialogStateAsync_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__GetMessageDialogStateAsync_NativeFunctionPtr, (void*)ptr, 1);
			IntPtr dest = &ptr->callback;
			FPlayStationGetDialogStatusCallBack fplayStationGetDialogStatusCallBack = callback;
			FScriptDelegate.NativeCopy(dest, (fplayStationGetDialogStatusCallBack != null) ? fplayStationGetDialogStatusCallBack.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__GetMessageDialogStateAsync_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__GetMessageDialogStateAsync_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06008684 RID: 34436 RVA: 0x000C82B8 File Offset: 0x000C64B8
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static int GetIdToken(ref string ClientId, ref string ClientSecret, ref string Scope, ref string IdToken)
		{
			UKuroStaticPS5Library.__GetIdToken_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__GetIdToken_FunctionParams[(UIntPtr)87] + 15L / (long)sizeof(UKuroStaticPS5Library.__GetIdToken_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__GetIdToken_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->ClientId), ClientId);
			FString.CopyFrom((void*)(&ptr->ClientSecret), ClientSecret);
			FString.CopyFrom((void*)(&ptr->Scope), Scope);
			FString.CopyFrom((void*)(&ptr->IdToken), IdToken);
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__GetIdToken_NativeFunctionPtr, (void*)ptr);
			ClientId = FString.ToString((void*)(&ptr->ClientId));
			ClientSecret = FString.ToString((void*)(&ptr->ClientSecret));
			Scope = FString.ToString((void*)(&ptr->Scope));
			IdToken = FString.ToString((void*)(&ptr->IdToken));
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__GetIdToken_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06008685 RID: 34437 RVA: 0x000C8380 File Offset: 0x000C6580
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static string GetCountryCodeByUserId(ref string userId)
		{
			UKuroStaticPS5Library.__GetCountryCodeByUserId_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__GetCountryCodeByUserId_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroStaticPS5Library.__GetCountryCodeByUserId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__GetCountryCodeByUserId_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->userId), userId);
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__GetCountryCodeByUserId_NativeFunctionPtr, (void*)ptr);
			userId = FString.ToString((void*)(&ptr->userId));
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__GetCountryCodeByUserId_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06008686 RID: 34438 RVA: 0x000C83F8 File Offset: 0x000C65F8
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void GetCommunicationRestrictionStatusAsync(ref string accountId, [Nullable(2)] in FPlayStationGetCommunicationStatusCallBack callback)
		{
			UKuroStaticPS5Library.__GetCommunicationRestrictionStatusAsync_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__GetCommunicationRestrictionStatusAsync_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(UKuroStaticPS5Library.__GetCommunicationRestrictionStatusAsync_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__GetCommunicationRestrictionStatusAsync_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->accountId), accountId);
			IntPtr dest = &ptr->callback;
			FPlayStationGetCommunicationStatusCallBack fplayStationGetCommunicationStatusCallBack = callback;
			FScriptDelegate.NativeCopy(dest, (fplayStationGetCommunicationStatusCallBack != null) ? fplayStationGetCommunicationStatusCallBack.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__GetCommunicationRestrictionStatusAsync_NativeFunctionPtr, (void*)ptr);
			accountId = FString.ToString((void*)(&ptr->accountId));
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__GetCommunicationRestrictionStatusAsync_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06008687 RID: 34439 RVA: 0x000C8480 File Offset: 0x000C6680
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static string GetCacheMapElement(string key)
		{
			UKuroStaticPS5Library.__GetCacheMapElement_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__GetCacheMapElement_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroStaticPS5Library.__GetCacheMapElement_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__GetCacheMapElement_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->key), key);
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__GetCacheMapElement_NativeFunctionPtr, (void*)ptr);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__GetCacheMapElement_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06008688 RID: 34440 RVA: 0x000C84E8 File Offset: 0x000C66E8
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void GetBlockUserListAsync(ref int offset, ref int limit, in FPlayStationGetBlockResult Delegate)
		{
			UKuroStaticPS5Library.__GetBlockUserListAsync_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__GetBlockUserListAsync_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UKuroStaticPS5Library.__GetBlockUserListAsync_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__GetBlockUserListAsync_NativeFunctionPtr, (void*)ptr, 1);
			ptr->offset = offset;
			ptr->limit = limit;
			IntPtr dest = &ptr->Delegate;
			FPlayStationGetBlockResult fplayStationGetBlockResult = Delegate;
			FScriptDelegate.NativeCopy(dest, (fplayStationGetBlockResult != null) ? fplayStationGetBlockResult.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__GetBlockUserListAsync_NativeFunctionPtr, (void*)ptr);
			offset = ptr->offset;
			limit = ptr->limit;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__GetBlockUserListAsync_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06008689 RID: 34441 RVA: 0x000C8574 File Offset: 0x000C6774
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static FBlockUserData GetBlockUserList(ref int offset, ref int limit)
		{
			UKuroStaticPS5Library.__GetBlockUserList_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__GetBlockUserList_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroStaticPS5Library.__GetBlockUserList_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__GetBlockUserList_NativeFunctionPtr, (void*)ptr, 1);
			ptr->offset = offset;
			ptr->limit = limit;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__GetBlockUserList_NativeFunctionPtr, (void*)ptr);
			offset = ptr->offset;
			limit = ptr->limit;
			FBlockUserData result = new FBlockUserData(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__GetBlockUserList_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600868A RID: 34442 RVA: 0x000C85F4 File Offset: 0x000C67F4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static int GetAuthCode(ref string ClientId, ref string Scope, ref string AuthCode, ref int IssuerId)
		{
			UKuroStaticPS5Library.__GetAuthCode_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__GetAuthCode_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(UKuroStaticPS5Library.__GetAuthCode_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__GetAuthCode_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->ClientId), ClientId);
			FString.CopyFrom((void*)(&ptr->Scope), Scope);
			FString.CopyFrom((void*)(&ptr->AuthCode), AuthCode);
			ptr->IssuerId = IssuerId;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__GetAuthCode_NativeFunctionPtr, (void*)ptr);
			ClientId = FString.ToString((void*)(&ptr->ClientId));
			Scope = FString.ToString((void*)(&ptr->Scope));
			AuthCode = FString.ToString((void*)(&ptr->AuthCode));
			IssuerId = ptr->IssuerId;
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__GetAuthCode_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0600868B RID: 34443 RVA: 0x000C86B0 File Offset: 0x000C68B0
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static string GetAccountIdByUserId(ref string userId)
		{
			UKuroStaticPS5Library.__GetAccountIdByUserId_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__GetAccountIdByUserId_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroStaticPS5Library.__GetAccountIdByUserId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__GetAccountIdByUserId_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->userId), userId);
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__GetAccountIdByUserId_NativeFunctionPtr, (void*)ptr);
			userId = FString.ToString((void*)(&ptr->userId));
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__GetAccountIdByUserId_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600868C RID: 34444 RVA: 0x000C8728 File Offset: 0x000C6928
		[SkipLocalsInit]
		public unsafe static int DestroyUdsHandle(int handle)
		{
			UKuroStaticPS5Library.__DestroyUdsHandle_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__DestroyUdsHandle_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroStaticPS5Library.__DestroyUdsHandle_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__DestroyUdsHandle_NativeFunctionPtr, (void*)ptr, 1);
			ptr->handle = handle;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__DestroyUdsHandle_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600868D RID: 34445 RVA: 0x000C8774 File Offset: 0x000C6974
		[SkipLocalsInit]
		public unsafe static int DestroyUdsEvent(long eventPtr)
		{
			UKuroStaticPS5Library.__DestroyUdsEvent_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__DestroyUdsEvent_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroStaticPS5Library.__DestroyUdsEvent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__DestroyUdsEvent_NativeFunctionPtr, (void*)ptr, 1);
			ptr->eventPtr = eventPtr;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__DestroyUdsEvent_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600868E RID: 34446 RVA: 0x000C87C0 File Offset: 0x000C69C0
		[SkipLocalsInit]
		public unsafe static int DestroyUdsContext(int context)
		{
			UKuroStaticPS5Library.__DestroyUdsContext_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__DestroyUdsContext_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroStaticPS5Library.__DestroyUdsContext_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__DestroyUdsContext_NativeFunctionPtr, (void*)ptr, 1);
			ptr->context = context;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__DestroyUdsContext_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600868F RID: 34447 RVA: 0x000C880C File Offset: 0x000C6A0C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void DestroyTrophyHandleAsync(ref int handle, in FPlayStationDestroyHandleCallBack callback)
		{
			UKuroStaticPS5Library.__DestroyTrophyHandleAsync_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__DestroyTrophyHandleAsync_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UKuroStaticPS5Library.__DestroyTrophyHandleAsync_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__DestroyTrophyHandleAsync_NativeFunctionPtr, (void*)ptr, 1);
			ptr->handle = handle;
			IntPtr dest = &ptr->callback;
			FPlayStationDestroyHandleCallBack fplayStationDestroyHandleCallBack = callback;
			FScriptDelegate.NativeCopy(dest, (fplayStationDestroyHandleCallBack != null) ? fplayStationDestroyHandleCallBack.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__DestroyTrophyHandleAsync_NativeFunctionPtr, (void*)ptr);
			handle = ptr->handle;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__DestroyTrophyHandleAsync_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06008690 RID: 34448 RVA: 0x000C8888 File Offset: 0x000C6A88
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void DestroyTrophyContextAsync(ref int context, in FPlayStationDestroyContextCallBack callback)
		{
			UKuroStaticPS5Library.__DestroyTrophyContextAsync_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__DestroyTrophyContextAsync_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UKuroStaticPS5Library.__DestroyTrophyContextAsync_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__DestroyTrophyContextAsync_NativeFunctionPtr, (void*)ptr, 1);
			ptr->context = context;
			IntPtr dest = &ptr->callback;
			FPlayStationDestroyContextCallBack fplayStationDestroyContextCallBack = callback;
			FScriptDelegate.NativeCopy(dest, (fplayStationDestroyContextCallBack != null) ? fplayStationDestroyContextCallBack.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__DestroyTrophyContextAsync_NativeFunctionPtr, (void*)ptr);
			context = ptr->context;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__DestroyTrophyContextAsync_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06008691 RID: 34449 RVA: 0x000C8904 File Offset: 0x000C6B04
		[SkipLocalsInit]
		public unsafe static int CreateUdsHandle(ref int handle)
		{
			UKuroStaticPS5Library.__CreateUdsHandle_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__CreateUdsHandle_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroStaticPS5Library.__CreateUdsHandle_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__CreateUdsHandle_NativeFunctionPtr, (void*)ptr, 1);
			ptr->handle = handle;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__CreateUdsHandle_NativeFunctionPtr, (void*)ptr);
			handle = ptr->handle;
			return ptr->__Result;
		}

		// Token: 0x06008692 RID: 34450 RVA: 0x000C8958 File Offset: 0x000C6B58
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static int CreateUdsEvent(ref string eventName, ref long outEventPtr, ref long outProPtr)
		{
			UKuroStaticPS5Library.__CreateUdsEvent_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__CreateUdsEvent_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UKuroStaticPS5Library.__CreateUdsEvent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__CreateUdsEvent_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->eventName), eventName);
			ptr->outEventPtr = outEventPtr;
			ptr->outProPtr = outProPtr;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__CreateUdsEvent_NativeFunctionPtr, (void*)ptr);
			eventName = FString.ToString((void*)(&ptr->eventName));
			outEventPtr = ptr->outEventPtr;
			outProPtr = ptr->outProPtr;
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__CreateUdsEvent_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06008693 RID: 34451 RVA: 0x000C89EC File Offset: 0x000C6BEC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static int CreateUdsContext(ref string userId, ref int context)
		{
			UKuroStaticPS5Library.__CreateUdsContext_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__CreateUdsContext_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroStaticPS5Library.__CreateUdsContext_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__CreateUdsContext_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->userId), userId);
			ptr->context = context;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__CreateUdsContext_NativeFunctionPtr, (void*)ptr);
			userId = FString.ToString((void*)(&ptr->userId));
			context = ptr->context;
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__CreateUdsContext_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06008694 RID: 34452 RVA: 0x000C8A70 File Offset: 0x000C6C70
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void CreateTrophyHandleAsync(in FPlayStationCreateHandleCallBack callback)
		{
			UKuroStaticPS5Library.__CreateTrophyHandleAsync_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__CreateTrophyHandleAsync_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UKuroStaticPS5Library.__CreateTrophyHandleAsync_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__CreateTrophyHandleAsync_NativeFunctionPtr, (void*)ptr, 1);
			IntPtr dest = &ptr->callback;
			FPlayStationCreateHandleCallBack fplayStationCreateHandleCallBack = callback;
			FScriptDelegate.NativeCopy(dest, (fplayStationCreateHandleCallBack != null) ? fplayStationCreateHandleCallBack.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__CreateTrophyHandleAsync_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__CreateTrophyHandleAsync_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06008695 RID: 34453 RVA: 0x000C8ADC File Offset: 0x000C6CDC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void CreateTrophyContextAsync(string userId, int serviceLabel, string optionsLong, [Nullable(2)] in FPlayStationCreateContextCallBack callback)
		{
			UKuroStaticPS5Library.__CreateTrophyContextAsync_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__CreateTrophyContextAsync_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UKuroStaticPS5Library.__CreateTrophyContextAsync_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__CreateTrophyContextAsync_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->userId), userId);
			ptr->serviceLabel = serviceLabel;
			FString.CopyFrom((void*)(&ptr->optionsLong), optionsLong);
			IntPtr dest = &ptr->callback;
			FPlayStationCreateContextCallBack fplayStationCreateContextCallBack = callback;
			FScriptDelegate.NativeCopy(dest, (fplayStationCreateContextCallBack != null) ? fplayStationCreateContextCallBack.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__CreateTrophyContextAsync_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__CreateTrophyContextAsync_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06008696 RID: 34454 RVA: 0x000C8B68 File Offset: 0x000C6D68
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static string CreatePlayerSession(int joinableUserType, ref string playerId)
		{
			UKuroStaticPS5Library.__CreatePlayerSession_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__CreatePlayerSession_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UKuroStaticPS5Library.__CreatePlayerSession_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__CreatePlayerSession_NativeFunctionPtr, (void*)ptr, 1);
			ptr->joinableUserType = joinableUserType;
			FString.CopyFrom((void*)(&ptr->playerId), playerId);
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__CreatePlayerSession_NativeFunctionPtr, (void*)ptr);
			playerId = FString.ToString((void*)(&ptr->playerId));
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__CreatePlayerSession_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06008697 RID: 34455 RVA: 0x000C8BE8 File Offset: 0x000C6DE8
		[SkipLocalsInit]
		public unsafe static int CloseWebBrowser()
		{
			UKuroStaticPS5Library.__CloseWebBrowser_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__CloseWebBrowser_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroStaticPS5Library.__CloseWebBrowser_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__CloseWebBrowser_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__CloseWebBrowser_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06008698 RID: 34456 RVA: 0x000C8C2C File Offset: 0x000C6E2C
		[SkipLocalsInit]
		public static void ClearJoinSessionHandle()
		{
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__ClearJoinSessionHandle_NativeFunctionPtr, null);
		}

		// Token: 0x06008699 RID: 34457 RVA: 0x000C8C3F File Offset: 0x000C6E3F
		[SkipLocalsInit]
		public static void ClearJoinSessionDelegate()
		{
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__ClearJoinSessionDelegate_NativeFunctionPtr, null);
		}

		// Token: 0x0600869A RID: 34458 RVA: 0x000C8C54 File Offset: 0x000C6E54
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static int CheckUserPremium(ref string userId)
		{
			UKuroStaticPS5Library.__CheckUserPremium_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__CheckUserPremium_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroStaticPS5Library.__CheckUserPremium_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__CheckUserPremium_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->userId), userId);
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__CheckUserPremium_NativeFunctionPtr, (void*)ptr);
			userId = FString.ToString((void*)(&ptr->userId));
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__CheckUserPremium_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0600869B RID: 34459 RVA: 0x000C8CC8 File Offset: 0x000C6EC8
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static string CheckJoinSession()
		{
			UKuroStaticPS5Library.__CheckJoinSession_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__CheckJoinSession_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroStaticPS5Library.__CheckJoinSession_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__CheckJoinSession_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__CheckJoinSession_NativeFunctionPtr, (void*)ptr);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__CheckJoinSession_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600869C RID: 34460 RVA: 0x000C8D24 File Offset: 0x000C6F24
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void AddJoinSessionDelegate(in FJoinSessionCallBack InDelegate)
		{
			UKuroStaticPS5Library.__AddJoinSessionDelegate_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__AddJoinSessionDelegate_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UKuroStaticPS5Library.__AddJoinSessionDelegate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__AddJoinSessionDelegate_NativeFunctionPtr, (void*)ptr, 1);
			IntPtr dest = &ptr->InDelegate;
			FJoinSessionCallBack fjoinSessionCallBack = InDelegate;
			FScriptDelegate.NativeCopy(dest, (fjoinSessionCallBack != null) ? fjoinSessionCallBack.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__AddJoinSessionDelegate_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__AddJoinSessionDelegate_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600869D RID: 34461 RVA: 0x000C8D90 File Offset: 0x000C6F90
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void AddCacheMapElement(string key, string value)
		{
			UKuroStaticPS5Library.__AddCacheMapElement_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__AddCacheMapElement_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroStaticPS5Library.__AddCacheMapElement_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__AddCacheMapElement_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->key), key);
			FString.CopyFrom((void*)(&ptr->value), value);
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__AddCacheMapElement_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__AddCacheMapElement_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600869E RID: 34462 RVA: 0x000C8DFC File Offset: 0x000C6FFC
		[SkipLocalsInit]
		public unsafe static int AbortUdsHandle(int handle)
		{
			UKuroStaticPS5Library.__AbortUdsHandle_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__AbortUdsHandle_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroStaticPS5Library.__AbortUdsHandle_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__AbortUdsHandle_NativeFunctionPtr, (void*)ptr, 1);
			ptr->handle = handle;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__AbortUdsHandle_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600869F RID: 34463 RVA: 0x000C8E48 File Offset: 0x000C7048
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void AbortTrophyHandleAsync(ref int handle, in FPlayStationAbortHandleCallBack callback)
		{
			UKuroStaticPS5Library.__AbortTrophyHandleAsync_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__AbortTrophyHandleAsync_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UKuroStaticPS5Library.__AbortTrophyHandleAsync_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__AbortTrophyHandleAsync_NativeFunctionPtr, (void*)ptr, 1);
			ptr->handle = handle;
			IntPtr dest = &ptr->callback;
			FPlayStationAbortHandleCallBack fplayStationAbortHandleCallBack = callback;
			FScriptDelegate.NativeCopy(dest, (fplayStationAbortHandleCallBack != null) ? fplayStationAbortHandleCallBack.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__AbortTrophyHandleAsync_NativeFunctionPtr, (void*)ptr);
			handle = ptr->handle;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__AbortTrophyHandleAsync_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060086A0 RID: 34464 RVA: 0x000C8EC2 File Offset: 0x000C70C2
		static UKuroStaticPS5Library()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroStaticPS5Library");
		}

		// Token: 0x060086A1 RID: 34465 RVA: 0x000C8ED0 File Offset: 0x000C70D0
		protected UKuroStaticPS5Library(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003A36 RID: 14902
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroStaticPS5Library";

		// Token: 0x04003A37 RID: 14903
		private static IntPtr _ClassPtr;

		// Token: 0x04003A38 RID: 14904
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003A39 RID: 14905
		private static IntPtr __UpdateTrophyProgressWithContextIdAndHandleIdAsync_NativeFunctionPtr;

		// Token: 0x04003A3A RID: 14906
		private static IntPtr __UpdateTrophyProgressWithContextIdAndHandleId_NativeFunctionPtr;

		// Token: 0x04003A3B RID: 14907
		private static IntPtr __UpdateTrophyProgress_NativeFunctionPtr;

		// Token: 0x04003A3C RID: 14908
		private static IntPtr __UnlockTrophyWithContextIdAndHandleIdAsync_NativeFunctionPtr;

		// Token: 0x04003A3D RID: 14909
		private static IntPtr __UnlockTrophyWithContextIdAndHandleId_NativeFunctionPtr;

		// Token: 0x04003A3E RID: 14910
		private static IntPtr __UnlockTrophy_NativeFunctionPtr;

		// Token: 0x04003A3F RID: 14911
		private static IntPtr __UdsEventPropertyObjectSetUInt64_NativeFunctionPtr;

		// Token: 0x04003A40 RID: 14912
		private static IntPtr __UdsEventPropertyObjectSetUInt32_NativeFunctionPtr;

		// Token: 0x04003A41 RID: 14913
		private static IntPtr __UdsEventPropertyObjectSetString_NativeFunctionPtr;

		// Token: 0x04003A42 RID: 14914
		private static IntPtr __UdsEventPropertyObjectSetInt64_NativeFunctionPtr;

		// Token: 0x04003A43 RID: 14915
		private static IntPtr __UdsEventPropertyObjectSetInt32_NativeFunctionPtr;

		// Token: 0x04003A44 RID: 14916
		private static IntPtr __UdsEventPropertyObjectSetFloat64_NativeFunctionPtr;

		// Token: 0x04003A45 RID: 14917
		private static IntPtr __UdsEventPropertyObjectSetFloat32_NativeFunctionPtr;

		// Token: 0x04003A46 RID: 14918
		private static IntPtr __UdsEventPropertyObjectSetBool_NativeFunctionPtr;

		// Token: 0x04003A47 RID: 14919
		private static IntPtr __UdsEventPropertyArraySetString_NativeFunctionPtr;

		// Token: 0x04003A48 RID: 14920
		private static IntPtr __TerminateWebBrowser_NativeFunctionPtr;

		// Token: 0x04003A49 RID: 14921
		private static IntPtr __TerminateMessageDialog_NativeFunctionPtr;

		// Token: 0x04003A4A RID: 14922
		private static IntPtr __ShowPsStoreIcon_NativeFunctionPtr;

		// Token: 0x04003A4B RID: 14923
		private static IntPtr __SetPlayerSessionJoinableUserType_NativeFunctionPtr;

		// Token: 0x04003A4C RID: 14924
		private static IntPtr __SceNpGetNpReachabilityState_NativeFunctionPtr;

		// Token: 0x04003A4D RID: 14925
		private static IntPtr __RemoveCacheElement_NativeFunctionPtr;

		// Token: 0x04003A4E RID: 14926
		private static IntPtr __RegisterUdsContext_NativeFunctionPtr;

		// Token: 0x04003A4F RID: 14927
		private static IntPtr __RegisterTrophyContextAsync_NativeFunctionPtr;

		// Token: 0x04003A50 RID: 14928
		private static IntPtr __PostUdsEvent_NativeFunctionPtr;

		// Token: 0x04003A51 RID: 14929
		private static IntPtr __PollWebBrowser_NativeFunctionPtr;

		// Token: 0x04003A52 RID: 14930
		private static IntPtr __PollCheckoutDialogResult_NativeFunctionPtr;

		// Token: 0x04003A53 RID: 14931
		private static IntPtr __OpenWebView_NativeFunctionPtr;

		// Token: 0x04003A54 RID: 14932
		private static IntPtr __OpenWebBrowser_NativeFunctionPtr;

		// Token: 0x04003A55 RID: 14933
		private static IntPtr __OpenMessageDialog_NativeFunctionPtr;

		// Token: 0x04003A56 RID: 14934
		private static IntPtr __OpenCheckoutDialog_NativeFunctionPtr;

		// Token: 0x04003A57 RID: 14935
		private static IntPtr __NotifyPremiumFeature_NativeFunctionPtr;

		// Token: 0x04003A58 RID: 14936
		private static IntPtr __NotifyPremium_NativeFunctionPtr;

		// Token: 0x04003A59 RID: 14937
		private static IntPtr __LeavePlayerSession_NativeFunctionPtr;

		// Token: 0x04003A5A RID: 14938
		private static IntPtr __JoinPlayerSession_NativeFunctionPtr;

		// Token: 0x04003A5B RID: 14939
		private static IntPtr __InitWebApi_NativeFunctionPtr;

		// Token: 0x04003A5C RID: 14940
		private static IntPtr __InitNpUniversalDataSystem_NativeFunctionPtr;

		// Token: 0x04003A5D RID: 14941
		private static IntPtr __HidePsStoreIcon_NativeFunctionPtr;

		// Token: 0x04003A5E RID: 14942
		private static IntPtr __GetUserIdByAccountId_NativeFunctionPtr;

		// Token: 0x04003A5F RID: 14943
		private static IntPtr __GetUserId_NativeFunctionPtr;

		// Token: 0x04003A60 RID: 14944
		private static IntPtr __GetTrophyListWithContextIdAndHandleIdAsync_NativeFunctionPtr;

		// Token: 0x04003A61 RID: 14945
		private static IntPtr __GetTrophyListWithContextIdAndHandleId_NativeFunctionPtr;

		// Token: 0x04003A62 RID: 14946
		private static IntPtr __GetTrophyList_NativeFunctionPtr;

		// Token: 0x04003A63 RID: 14947
		private static IntPtr __GetStoreProductsWithParams_NativeFunctionPtr;

		// Token: 0x04003A64 RID: 14948
		private static IntPtr __GetStoreProducts_NativeFunctionPtr;

		// Token: 0x04003A65 RID: 14949
		private static IntPtr __GetPlayerIdByPlayerSessionId_NativeFunctionPtr;

		// Token: 0x04003A66 RID: 14950
		private static IntPtr __GetOnlineIdByUserId_NativeFunctionPtr;

		// Token: 0x04003A67 RID: 14951
		private static IntPtr __GetMessageDialogStateAsync_NativeFunctionPtr;

		// Token: 0x04003A68 RID: 14952
		private static IntPtr __GetIdToken_NativeFunctionPtr;

		// Token: 0x04003A69 RID: 14953
		private static IntPtr __GetCountryCodeByUserId_NativeFunctionPtr;

		// Token: 0x04003A6A RID: 14954
		private static IntPtr __GetCommunicationRestrictionStatusAsync_NativeFunctionPtr;

		// Token: 0x04003A6B RID: 14955
		private static IntPtr __GetCacheMapElement_NativeFunctionPtr;

		// Token: 0x04003A6C RID: 14956
		private static IntPtr __GetBlockUserListAsync_NativeFunctionPtr;

		// Token: 0x04003A6D RID: 14957
		private static IntPtr __GetBlockUserList_NativeFunctionPtr;

		// Token: 0x04003A6E RID: 14958
		private static IntPtr __GetAuthCode_NativeFunctionPtr;

		// Token: 0x04003A6F RID: 14959
		private static IntPtr __GetAccountIdByUserId_NativeFunctionPtr;

		// Token: 0x04003A70 RID: 14960
		private static IntPtr __DestroyUdsHandle_NativeFunctionPtr;

		// Token: 0x04003A71 RID: 14961
		private static IntPtr __DestroyUdsEvent_NativeFunctionPtr;

		// Token: 0x04003A72 RID: 14962
		private static IntPtr __DestroyUdsContext_NativeFunctionPtr;

		// Token: 0x04003A73 RID: 14963
		private static IntPtr __DestroyTrophyHandleAsync_NativeFunctionPtr;

		// Token: 0x04003A74 RID: 14964
		private static IntPtr __DestroyTrophyContextAsync_NativeFunctionPtr;

		// Token: 0x04003A75 RID: 14965
		private static IntPtr __CreateUdsHandle_NativeFunctionPtr;

		// Token: 0x04003A76 RID: 14966
		private static IntPtr __CreateUdsEvent_NativeFunctionPtr;

		// Token: 0x04003A77 RID: 14967
		private static IntPtr __CreateUdsContext_NativeFunctionPtr;

		// Token: 0x04003A78 RID: 14968
		private static IntPtr __CreateTrophyHandleAsync_NativeFunctionPtr;

		// Token: 0x04003A79 RID: 14969
		private static IntPtr __CreateTrophyContextAsync_NativeFunctionPtr;

		// Token: 0x04003A7A RID: 14970
		private static IntPtr __CreatePlayerSession_NativeFunctionPtr;

		// Token: 0x04003A7B RID: 14971
		private static IntPtr __CloseWebBrowser_NativeFunctionPtr;

		// Token: 0x04003A7C RID: 14972
		private static IntPtr __ClearJoinSessionHandle_NativeFunctionPtr;

		// Token: 0x04003A7D RID: 14973
		private static IntPtr __ClearJoinSessionDelegate_NativeFunctionPtr;

		// Token: 0x04003A7E RID: 14974
		private static IntPtr __CheckUserPremium_NativeFunctionPtr;

		// Token: 0x04003A7F RID: 14975
		private static IntPtr __CheckJoinSession_NativeFunctionPtr;

		// Token: 0x04003A80 RID: 14976
		private static IntPtr __AddJoinSessionDelegate_NativeFunctionPtr;

		// Token: 0x04003A81 RID: 14977
		private static IntPtr __AddCacheMapElement_NativeFunctionPtr;

		// Token: 0x04003A82 RID: 14978
		private static IntPtr __AbortUdsHandle_NativeFunctionPtr;

		// Token: 0x04003A83 RID: 14979
		private static IntPtr __AbortTrophyHandleAsync_NativeFunctionPtr;

		// Token: 0x02000D7C RID: 3452
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __UpdateTrophyProgressWithContextIdAndHandleIdAsync_FunctionParams
		{
			// Token: 0x0400603A RID: 24634
			[FieldOffset(0)]
			public int context;

			// Token: 0x0400603B RID: 24635
			[FieldOffset(4)]
			public int handle;

			// Token: 0x0400603C RID: 24636
			[FieldOffset(8)]
			public int trophyId;

			// Token: 0x0400603D RID: 24637
			[FieldOffset(12)]
			public int progress;

			// Token: 0x0400603E RID: 24638
			[FieldOffset(16)]
			public byte callback;
		}

		// Token: 0x02000D7D RID: 3453
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 20)]
		protected ref struct __UpdateTrophyProgressWithContextIdAndHandleId_FunctionParams
		{
			// Token: 0x0400603F RID: 24639
			[FieldOffset(0)]
			public int context;

			// Token: 0x04006040 RID: 24640
			[FieldOffset(4)]
			public int handle;

			// Token: 0x04006041 RID: 24641
			[FieldOffset(8)]
			public int trophyId;

			// Token: 0x04006042 RID: 24642
			[FieldOffset(12)]
			public int progress;

			// Token: 0x04006043 RID: 24643
			[FieldOffset(16)]
			public int __Result;
		}

		// Token: 0x02000D7E RID: 3454
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __UpdateTrophyProgress_FunctionParams
		{
			// Token: 0x04006044 RID: 24644
			[FieldOffset(0)]
			public FString userId;

			// Token: 0x04006045 RID: 24645
			[FieldOffset(16)]
			public int trophyId;

			// Token: 0x04006046 RID: 24646
			[FieldOffset(20)]
			public int progress;

			// Token: 0x04006047 RID: 24647
			[FieldOffset(24)]
			public int __Result;
		}

		// Token: 0x02000D7F RID: 3455
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __UnlockTrophyWithContextIdAndHandleIdAsync_FunctionParams
		{
			// Token: 0x04006048 RID: 24648
			[FieldOffset(0)]
			public int contextId;

			// Token: 0x04006049 RID: 24649
			[FieldOffset(4)]
			public int handle;

			// Token: 0x0400604A RID: 24650
			[FieldOffset(8)]
			public int trophyId;

			// Token: 0x0400604B RID: 24651
			[FieldOffset(16)]
			public byte callback;
		}

		// Token: 0x02000D80 RID: 3456
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __UnlockTrophyWithContextIdAndHandleId_FunctionParams
		{
			// Token: 0x0400604C RID: 24652
			[FieldOffset(0)]
			public int contextId;

			// Token: 0x0400604D RID: 24653
			[FieldOffset(4)]
			public int handle;

			// Token: 0x0400604E RID: 24654
			[FieldOffset(8)]
			public int trophyId;

			// Token: 0x0400604F RID: 24655
			[FieldOffset(12)]
			public int __Result;
		}

		// Token: 0x02000D81 RID: 3457
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __UnlockTrophy_FunctionParams
		{
			// Token: 0x04006050 RID: 24656
			[FieldOffset(0)]
			public FString userId;

			// Token: 0x04006051 RID: 24657
			[FieldOffset(16)]
			public int trophyId;

			// Token: 0x04006052 RID: 24658
			[FieldOffset(20)]
			public int __Result;
		}

		// Token: 0x02000D82 RID: 3458
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __UdsEventPropertyObjectSetUInt64_FunctionParams
		{
			// Token: 0x04006053 RID: 24659
			[FieldOffset(0)]
			public long proPtr;

			// Token: 0x04006054 RID: 24660
			[FieldOffset(8)]
			public FString key;

			// Token: 0x04006055 RID: 24661
			[FieldOffset(24)]
			public long value;

			// Token: 0x04006056 RID: 24662
			[FieldOffset(32)]
			public int __Result;
		}

		// Token: 0x02000D83 RID: 3459
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __UdsEventPropertyObjectSetUInt32_FunctionParams
		{
			// Token: 0x04006057 RID: 24663
			[FieldOffset(0)]
			public long proPtr;

			// Token: 0x04006058 RID: 24664
			[FieldOffset(8)]
			public FString key;

			// Token: 0x04006059 RID: 24665
			[FieldOffset(24)]
			public int value;

			// Token: 0x0400605A RID: 24666
			[FieldOffset(28)]
			public int __Result;
		}

		// Token: 0x02000D84 RID: 3460
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __UdsEventPropertyObjectSetString_FunctionParams
		{
			// Token: 0x0400605B RID: 24667
			[FieldOffset(0)]
			public long proPtr;

			// Token: 0x0400605C RID: 24668
			[FieldOffset(8)]
			public FString key;

			// Token: 0x0400605D RID: 24669
			[FieldOffset(24)]
			public FString value;

			// Token: 0x0400605E RID: 24670
			[FieldOffset(40)]
			public int __Result;
		}

		// Token: 0x02000D85 RID: 3461
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __UdsEventPropertyObjectSetInt64_FunctionParams
		{
			// Token: 0x0400605F RID: 24671
			[FieldOffset(0)]
			public long proPtr;

			// Token: 0x04006060 RID: 24672
			[FieldOffset(8)]
			public FString key;

			// Token: 0x04006061 RID: 24673
			[FieldOffset(24)]
			public long value;

			// Token: 0x04006062 RID: 24674
			[FieldOffset(32)]
			public int __Result;
		}

		// Token: 0x02000D86 RID: 3462
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __UdsEventPropertyObjectSetInt32_FunctionParams
		{
			// Token: 0x04006063 RID: 24675
			[FieldOffset(0)]
			public long proPtr;

			// Token: 0x04006064 RID: 24676
			[FieldOffset(8)]
			public FString key;

			// Token: 0x04006065 RID: 24677
			[FieldOffset(24)]
			public int value;

			// Token: 0x04006066 RID: 24678
			[FieldOffset(28)]
			public int __Result;
		}

		// Token: 0x02000D87 RID: 3463
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __UdsEventPropertyObjectSetFloat64_FunctionParams
		{
			// Token: 0x04006067 RID: 24679
			[FieldOffset(0)]
			public long proPtr;

			// Token: 0x04006068 RID: 24680
			[FieldOffset(8)]
			public FString key;

			// Token: 0x04006069 RID: 24681
			[FieldOffset(24)]
			public double value;

			// Token: 0x0400606A RID: 24682
			[FieldOffset(32)]
			public int __Result;
		}

		// Token: 0x02000D88 RID: 3464
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __UdsEventPropertyObjectSetFloat32_FunctionParams
		{
			// Token: 0x0400606B RID: 24683
			[FieldOffset(0)]
			public long proPtr;

			// Token: 0x0400606C RID: 24684
			[FieldOffset(8)]
			public FString key;

			// Token: 0x0400606D RID: 24685
			[FieldOffset(24)]
			public float value;

			// Token: 0x0400606E RID: 24686
			[FieldOffset(28)]
			public int __Result;
		}

		// Token: 0x02000D89 RID: 3465
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __UdsEventPropertyObjectSetBool_FunctionParams
		{
			// Token: 0x0400606F RID: 24687
			[FieldOffset(0)]
			public long proPtr;

			// Token: 0x04006070 RID: 24688
			[FieldOffset(8)]
			public FString key;

			// Token: 0x04006071 RID: 24689
			[FieldOffset(24)]
			public bool value;

			// Token: 0x04006072 RID: 24690
			[FieldOffset(28)]
			public int __Result;
		}

		// Token: 0x02000D8A RID: 3466
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __UdsEventPropertyArraySetString_FunctionParams
		{
			// Token: 0x04006073 RID: 24691
			[FieldOffset(0)]
			public long proPtr;

			// Token: 0x04006074 RID: 24692
			[FieldOffset(8)]
			public FString key;

			// Token: 0x04006075 RID: 24693
			[FieldOffset(24)]
			public byte value;

			// Token: 0x04006076 RID: 24694
			[FieldOffset(40)]
			public int __Result;
		}

		// Token: 0x02000D8B RID: 3467
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __TerminateWebBrowser_FunctionParams
		{
			// Token: 0x04006077 RID: 24695
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02000D8C RID: 3468
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ShowPsStoreIcon_FunctionParams
		{
			// Token: 0x04006078 RID: 24696
			[FieldOffset(0)]
			public int position;

			// Token: 0x04006079 RID: 24697
			[FieldOffset(4)]
			public int __Result;
		}

		// Token: 0x02000D8D RID: 3469
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetPlayerSessionJoinableUserType_FunctionParams
		{
			// Token: 0x0400607A RID: 24698
			[FieldOffset(0)]
			public int joinableUserType;
		}

		// Token: 0x02000D8E RID: 3470
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __SceNpGetNpReachabilityState_FunctionParams
		{
			// Token: 0x0400607B RID: 24699
			[FieldOffset(0)]
			public FString userId;

			// Token: 0x0400607C RID: 24700
			[FieldOffset(16)]
			public int outState;

			// Token: 0x0400607D RID: 24701
			[FieldOffset(20)]
			public int __Result;
		}

		// Token: 0x02000D8F RID: 3471
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __RemoveCacheElement_FunctionParams
		{
			// Token: 0x0400607E RID: 24702
			[FieldOffset(0)]
			public FString key;
		}

		// Token: 0x02000D90 RID: 3472
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __RegisterUdsContext_FunctionParams
		{
			// Token: 0x0400607F RID: 24703
			[FieldOffset(0)]
			public int context;

			// Token: 0x04006080 RID: 24704
			[FieldOffset(4)]
			public int handle;

			// Token: 0x04006081 RID: 24705
			[FieldOffset(8)]
			public int __Result;
		}

		// Token: 0x02000D91 RID: 3473
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __RegisterTrophyContextAsync_FunctionParams
		{
			// Token: 0x04006082 RID: 24706
			[FieldOffset(0)]
			public int context;

			// Token: 0x04006083 RID: 24707
			[FieldOffset(4)]
			public int handle;

			// Token: 0x04006084 RID: 24708
			[FieldOffset(8)]
			public FString optionsLong;

			// Token: 0x04006085 RID: 24709
			[FieldOffset(24)]
			public byte callback;
		}

		// Token: 0x02000D92 RID: 3474
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __PostUdsEvent_FunctionParams
		{
			// Token: 0x04006086 RID: 24710
			[FieldOffset(0)]
			public int context;

			// Token: 0x04006087 RID: 24711
			[FieldOffset(4)]
			public int handle;

			// Token: 0x04006088 RID: 24712
			[FieldOffset(8)]
			public long eventPtr;

			// Token: 0x04006089 RID: 24713
			[FieldOffset(16)]
			public int __Result;
		}

		// Token: 0x02000D93 RID: 3475
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __PollWebBrowser_FunctionParams
		{
			// Token: 0x0400608A RID: 24714
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02000D94 RID: 3476
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __PollCheckoutDialogResult_FunctionParams
		{
			// Token: 0x0400608B RID: 24715
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02000D95 RID: 3477
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __OpenWebView_FunctionParams
		{
			// Token: 0x0400608C RID: 24716
			[FieldOffset(0)]
			public FString Url;

			// Token: 0x0400608D RID: 24717
			[FieldOffset(16)]
			public int __Result;
		}

		// Token: 0x02000D96 RID: 3478
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OpenWebBrowser_FunctionParams
		{
			// Token: 0x0400608E RID: 24718
			[FieldOffset(0)]
			public FString Url;
		}

		// Token: 0x02000D97 RID: 3479
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __OpenMessageDialog_FunctionParams
		{
			// Token: 0x0400608F RID: 24719
			[FieldOffset(0)]
			public FString userId;

			// Token: 0x04006090 RID: 24720
			[FieldOffset(16)]
			public int openMode;

			// Token: 0x04006091 RID: 24721
			[FieldOffset(20)]
			public int msgType;

			// Token: 0x04006092 RID: 24722
			[FieldOffset(24)]
			public byte callback;
		}

		// Token: 0x02000D98 RID: 3480
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __OpenCheckoutDialog_FunctionParams
		{
			// Token: 0x04006093 RID: 24723
			[FieldOffset(0)]
			public FString ProductLabel;

			// Token: 0x04006094 RID: 24724
			[FieldOffset(16)]
			public int __Result;
		}

		// Token: 0x02000D99 RID: 3481
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __NotifyPremiumFeature_FunctionParams
		{
			// Token: 0x04006095 RID: 24725
			[FieldOffset(0)]
			public FString userId;

			// Token: 0x04006096 RID: 24726
			[FieldOffset(16)]
			public bool isPlayStationOnly;
		}

		// Token: 0x02000D9A RID: 3482
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __NotifyPremium_FunctionParams
		{
			// Token: 0x04006097 RID: 24727
			[FieldOffset(0)]
			public FString userId;
		}

		// Token: 0x02000D9B RID: 3483
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __JoinPlayerSession_FunctionParams
		{
			// Token: 0x04006098 RID: 24728
			[FieldOffset(0)]
			public FString playerSessionId;
		}

		// Token: 0x02000D9C RID: 3484
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __InitWebApi_FunctionParams
		{
			// Token: 0x04006099 RID: 24729
			[FieldOffset(0)]
			public FString userId;

			// Token: 0x0400609A RID: 24730
			[FieldOffset(16)]
			public int __Result;
		}

		// Token: 0x02000D9D RID: 3485
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __InitNpUniversalDataSystem_FunctionParams
		{
			// Token: 0x0400609B RID: 24731
			[FieldOffset(0)]
			public int poolSize;

			// Token: 0x0400609C RID: 24732
			[FieldOffset(4)]
			public int __Result;
		}

		// Token: 0x02000D9E RID: 3486
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __HidePsStoreIcon_FunctionParams
		{
			// Token: 0x0400609D RID: 24733
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02000D9F RID: 3487
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetUserIdByAccountId_FunctionParams
		{
			// Token: 0x0400609E RID: 24734
			[FieldOffset(0)]
			public FString accountId;

			// Token: 0x0400609F RID: 24735
			[FieldOffset(16)]
			public FString __Result;
		}

		// Token: 0x02000DA0 RID: 3488
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetUserId_FunctionParams
		{
			// Token: 0x040060A0 RID: 24736
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x02000DA1 RID: 3489
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __GetTrophyListWithContextIdAndHandleIdAsync_FunctionParams
		{
			// Token: 0x040060A1 RID: 24737
			[FieldOffset(0)]
			public int inputOffset;

			// Token: 0x040060A2 RID: 24738
			[FieldOffset(4)]
			public int length;

			// Token: 0x040060A3 RID: 24739
			[FieldOffset(8)]
			public int context;

			// Token: 0x040060A4 RID: 24740
			[FieldOffset(12)]
			public int handle;

			// Token: 0x040060A5 RID: 24741
			[FieldOffset(16)]
			public byte callback;
		}

		// Token: 0x02000DA2 RID: 3490
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __GetTrophyListWithContextIdAndHandleId_FunctionParams
		{
			// Token: 0x040060A6 RID: 24742
			[FieldOffset(0)]
			public int context;

			// Token: 0x040060A7 RID: 24743
			[FieldOffset(4)]
			public int handle;

			// Token: 0x040060A8 RID: 24744
			[FieldOffset(8)]
			public int inputOffset;

			// Token: 0x040060A9 RID: 24745
			[FieldOffset(12)]
			public int length;

			// Token: 0x040060AA RID: 24746
			[FieldOffset(16)]
			public byte __Result;
		}

		// Token: 0x02000DA3 RID: 3491
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __GetTrophyList_FunctionParams
		{
			// Token: 0x040060AB RID: 24747
			[FieldOffset(0)]
			public FString userId;

			// Token: 0x040060AC RID: 24748
			[FieldOffset(16)]
			public int inputOffset;

			// Token: 0x040060AD RID: 24749
			[FieldOffset(20)]
			public int length;

			// Token: 0x040060AE RID: 24750
			[FieldOffset(24)]
			public byte __Result;
		}

		// Token: 0x02000DA4 RID: 3492
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetStoreProductsWithParams_FunctionParams
		{
			// Token: 0x040060AF RID: 24751
			[FieldOffset(0)]
			public int ServiceLabel;

			// Token: 0x040060B0 RID: 24752
			[FieldOffset(4)]
			public int Offset;

			// Token: 0x040060B1 RID: 24753
			[FieldOffset(8)]
			public int Limit;

			// Token: 0x040060B2 RID: 24754
			[FieldOffset(16)]
			public byte __Result;
		}

		// Token: 0x02000DA5 RID: 3493
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetStoreProducts_FunctionParams
		{
			// Token: 0x040060B3 RID: 24755
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02000DA6 RID: 3494
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetPlayerIdByPlayerSessionId_FunctionParams
		{
			// Token: 0x040060B4 RID: 24756
			[FieldOffset(0)]
			public FString playerSessionId;

			// Token: 0x040060B5 RID: 24757
			[FieldOffset(16)]
			public FString __Result;
		}

		// Token: 0x02000DA7 RID: 3495
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetOnlineIdByUserId_FunctionParams
		{
			// Token: 0x040060B6 RID: 24758
			[FieldOffset(0)]
			public FString userId;

			// Token: 0x040060B7 RID: 24759
			[FieldOffset(16)]
			public FString __Result;
		}

		// Token: 0x02000DA8 RID: 3496
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __GetMessageDialogStateAsync_FunctionParams
		{
			// Token: 0x040060B8 RID: 24760
			[FieldOffset(0)]
			public byte callback;
		}

		// Token: 0x02000DA9 RID: 3497
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __GetIdToken_FunctionParams
		{
			// Token: 0x040060B9 RID: 24761
			[FieldOffset(0)]
			public FString ClientId;

			// Token: 0x040060BA RID: 24762
			[FieldOffset(16)]
			public FString ClientSecret;

			// Token: 0x040060BB RID: 24763
			[FieldOffset(32)]
			public FString Scope;

			// Token: 0x040060BC RID: 24764
			[FieldOffset(48)]
			public FString IdToken;

			// Token: 0x040060BD RID: 24765
			[FieldOffset(64)]
			public int __Result;
		}

		// Token: 0x02000DAA RID: 3498
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetCountryCodeByUserId_FunctionParams
		{
			// Token: 0x040060BE RID: 24766
			[FieldOffset(0)]
			public FString userId;

			// Token: 0x040060BF RID: 24767
			[FieldOffset(16)]
			public FString __Result;
		}

		// Token: 0x02000DAB RID: 3499
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __GetCommunicationRestrictionStatusAsync_FunctionParams
		{
			// Token: 0x040060C0 RID: 24768
			[FieldOffset(0)]
			public FString accountId;

			// Token: 0x040060C1 RID: 24769
			[FieldOffset(16)]
			public byte callback;
		}

		// Token: 0x02000DAC RID: 3500
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetCacheMapElement_FunctionParams
		{
			// Token: 0x040060C2 RID: 24770
			[FieldOffset(0)]
			public FString key;

			// Token: 0x040060C3 RID: 24771
			[FieldOffset(16)]
			public FString __Result;
		}

		// Token: 0x02000DAD RID: 3501
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __GetBlockUserListAsync_FunctionParams
		{
			// Token: 0x040060C4 RID: 24772
			[FieldOffset(0)]
			public int offset;

			// Token: 0x040060C5 RID: 24773
			[FieldOffset(4)]
			public int limit;

			// Token: 0x040060C6 RID: 24774
			[FieldOffset(8)]
			public byte Delegate;
		}

		// Token: 0x02000DAE RID: 3502
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetBlockUserList_FunctionParams
		{
			// Token: 0x040060C7 RID: 24775
			[FieldOffset(0)]
			public int offset;

			// Token: 0x040060C8 RID: 24776
			[FieldOffset(4)]
			public int limit;

			// Token: 0x040060C9 RID: 24777
			[FieldOffset(8)]
			public byte __Result;
		}

		// Token: 0x02000DAF RID: 3503
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __GetAuthCode_FunctionParams
		{
			// Token: 0x040060CA RID: 24778
			[FieldOffset(0)]
			public FString ClientId;

			// Token: 0x040060CB RID: 24779
			[FieldOffset(16)]
			public FString Scope;

			// Token: 0x040060CC RID: 24780
			[FieldOffset(32)]
			public FString AuthCode;

			// Token: 0x040060CD RID: 24781
			[FieldOffset(48)]
			public int IssuerId;

			// Token: 0x040060CE RID: 24782
			[FieldOffset(52)]
			public int __Result;
		}

		// Token: 0x02000DB0 RID: 3504
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetAccountIdByUserId_FunctionParams
		{
			// Token: 0x040060CF RID: 24783
			[FieldOffset(0)]
			public FString userId;

			// Token: 0x040060D0 RID: 24784
			[FieldOffset(16)]
			public FString __Result;
		}

		// Token: 0x02000DB1 RID: 3505
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __DestroyUdsHandle_FunctionParams
		{
			// Token: 0x040060D1 RID: 24785
			[FieldOffset(0)]
			public int handle;

			// Token: 0x040060D2 RID: 24786
			[FieldOffset(4)]
			public int __Result;
		}

		// Token: 0x02000DB2 RID: 3506
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __DestroyUdsEvent_FunctionParams
		{
			// Token: 0x040060D3 RID: 24787
			[FieldOffset(0)]
			public long eventPtr;

			// Token: 0x040060D4 RID: 24788
			[FieldOffset(8)]
			public int __Result;
		}

		// Token: 0x02000DB3 RID: 3507
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __DestroyUdsContext_FunctionParams
		{
			// Token: 0x040060D5 RID: 24789
			[FieldOffset(0)]
			public int context;

			// Token: 0x040060D6 RID: 24790
			[FieldOffset(4)]
			public int __Result;
		}

		// Token: 0x02000DB4 RID: 3508
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __DestroyTrophyHandleAsync_FunctionParams
		{
			// Token: 0x040060D7 RID: 24791
			[FieldOffset(0)]
			public int handle;

			// Token: 0x040060D8 RID: 24792
			[FieldOffset(8)]
			public byte callback;
		}

		// Token: 0x02000DB5 RID: 3509
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __DestroyTrophyContextAsync_FunctionParams
		{
			// Token: 0x040060D9 RID: 24793
			[FieldOffset(0)]
			public int context;

			// Token: 0x040060DA RID: 24794
			[FieldOffset(8)]
			public byte callback;
		}

		// Token: 0x02000DB6 RID: 3510
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __CreateUdsHandle_FunctionParams
		{
			// Token: 0x040060DB RID: 24795
			[FieldOffset(0)]
			public int handle;

			// Token: 0x040060DC RID: 24796
			[FieldOffset(4)]
			public int __Result;
		}

		// Token: 0x02000DB7 RID: 3511
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __CreateUdsEvent_FunctionParams
		{
			// Token: 0x040060DD RID: 24797
			[FieldOffset(0)]
			public FString eventName;

			// Token: 0x040060DE RID: 24798
			[FieldOffset(16)]
			public long outEventPtr;

			// Token: 0x040060DF RID: 24799
			[FieldOffset(24)]
			public long outProPtr;

			// Token: 0x040060E0 RID: 24800
			[FieldOffset(32)]
			public int __Result;
		}

		// Token: 0x02000DB8 RID: 3512
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __CreateUdsContext_FunctionParams
		{
			// Token: 0x040060E1 RID: 24801
			[FieldOffset(0)]
			public FString userId;

			// Token: 0x040060E2 RID: 24802
			[FieldOffset(16)]
			public int context;

			// Token: 0x040060E3 RID: 24803
			[FieldOffset(20)]
			public int __Result;
		}

		// Token: 0x02000DB9 RID: 3513
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __CreateTrophyHandleAsync_FunctionParams
		{
			// Token: 0x040060E4 RID: 24804
			[FieldOffset(0)]
			public byte callback;
		}

		// Token: 0x02000DBA RID: 3514
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __CreateTrophyContextAsync_FunctionParams
		{
			// Token: 0x040060E5 RID: 24805
			[FieldOffset(0)]
			public FString userId;

			// Token: 0x040060E6 RID: 24806
			[FieldOffset(16)]
			public int serviceLabel;

			// Token: 0x040060E7 RID: 24807
			[FieldOffset(24)]
			public FString optionsLong;

			// Token: 0x040060E8 RID: 24808
			[FieldOffset(40)]
			public byte callback;
		}

		// Token: 0x02000DBB RID: 3515
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __CreatePlayerSession_FunctionParams
		{
			// Token: 0x040060E9 RID: 24809
			[FieldOffset(0)]
			public int joinableUserType;

			// Token: 0x040060EA RID: 24810
			[FieldOffset(8)]
			public FString playerId;

			// Token: 0x040060EB RID: 24811
			[FieldOffset(24)]
			public FString __Result;
		}

		// Token: 0x02000DBC RID: 3516
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __CloseWebBrowser_FunctionParams
		{
			// Token: 0x040060EC RID: 24812
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02000DBD RID: 3517
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __CheckUserPremium_FunctionParams
		{
			// Token: 0x040060ED RID: 24813
			[FieldOffset(0)]
			public FString userId;

			// Token: 0x040060EE RID: 24814
			[FieldOffset(16)]
			public int __Result;
		}

		// Token: 0x02000DBE RID: 3518
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __CheckJoinSession_FunctionParams
		{
			// Token: 0x040060EF RID: 24815
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x02000DBF RID: 3519
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __AddJoinSessionDelegate_FunctionParams
		{
			// Token: 0x040060F0 RID: 24816
			[FieldOffset(0)]
			public byte InDelegate;
		}

		// Token: 0x02000DC0 RID: 3520
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __AddCacheMapElement_FunctionParams
		{
			// Token: 0x040060F1 RID: 24817
			[FieldOffset(0)]
			public FString key;

			// Token: 0x040060F2 RID: 24818
			[FieldOffset(16)]
			public FString value;
		}

		// Token: 0x02000DC1 RID: 3521
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __AbortUdsHandle_FunctionParams
		{
			// Token: 0x040060F3 RID: 24819
			[FieldOffset(0)]
			public int handle;

			// Token: 0x040060F4 RID: 24820
			[FieldOffset(4)]
			public int __Result;
		}

		// Token: 0x02000DC2 RID: 3522
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __AbortTrophyHandleAsync_FunctionParams
		{
			// Token: 0x040060F5 RID: 24821
			[FieldOffset(0)]
			public int handle;

			// Token: 0x040060F6 RID: 24822
			[FieldOffset(8)]
			public byte callback;
		}
	}
}
