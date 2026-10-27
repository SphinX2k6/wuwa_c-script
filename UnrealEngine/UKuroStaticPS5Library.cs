using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001ED4 RID: 7892
	[UnrealObjectPath("/Script/KuroUtility.KuroStaticPS5Library")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroStaticPS5Library : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DFCC RID: 122828 RVA: 0x002C5541 File Offset: 0x002C3741
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroStaticPS5Library._ClassPtr;
		}

		// Token: 0x0601DFCD RID: 122829 RVA: 0x002C5550 File Offset: 0x002C3750
		public UKuroStaticPS5Library() : this(BuiltinUtils.AllocNativeUObject(UKuroStaticPS5Library.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DFCE RID: 122830 RVA: 0x002C5578 File Offset: 0x002C3778
		[NullableContext(1)]
		public UKuroStaticPS5Library(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroStaticPS5Library.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601DFCF RID: 122831 RVA: 0x002C55AC File Offset: 0x002C37AC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__UpdateTrophyProgressWithContextIdAndHandleIdAsync_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__UpdateTrophyProgressWithContextIdAndHandleIdAsync_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601DFD0 RID: 122832 RVA: 0x002C5634 File Offset: 0x002C3834
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int UpdateTrophyProgressWithContextIdAndHandleId(int context, int handle, int trophyId, int progress)
		{
			UKuroStaticPS5Library.__UpdateTrophyProgressWithContextIdAndHandleId_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__UpdateTrophyProgressWithContextIdAndHandleId_FunctionParams[(UIntPtr)35] + 15L / (long)sizeof(UKuroStaticPS5Library.__UpdateTrophyProgressWithContextIdAndHandleId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__UpdateTrophyProgressWithContextIdAndHandleId_NativeFunctionPtr, (void*)ptr, 1);
			ptr->context = context;
			ptr->handle = handle;
			ptr->trophyId = trophyId;
			ptr->progress = progress;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__UpdateTrophyProgressWithContextIdAndHandleId_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601DFD1 RID: 122833 RVA: 0x002C5698 File Offset: 0x002C3898
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int UpdateTrophyProgress(ref string userId, int trophyId, int progress)
		{
			UKuroStaticPS5Library.__UpdateTrophyProgress_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__UpdateTrophyProgress_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroStaticPS5Library.__UpdateTrophyProgress_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__UpdateTrophyProgress_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->userId), userId);
			ptr->trophyId = trophyId;
			ptr->progress = progress;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__UpdateTrophyProgress_NativeFunctionPtr, (void*)ptr, 0);
			userId = FString.ToString((void*)(&ptr->userId));
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__UpdateTrophyProgress_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601DFD2 RID: 122834 RVA: 0x002C5718 File Offset: 0x002C3918
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__UnlockTrophyWithContextIdAndHandleIdAsync_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__UnlockTrophyWithContextIdAndHandleIdAsync_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601DFD3 RID: 122835 RVA: 0x002C5798 File Offset: 0x002C3998
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int UnlockTrophyWithContextIdAndHandleId(int contextId, int handle, int trophyId)
		{
			UKuroStaticPS5Library.__UnlockTrophyWithContextIdAndHandleId_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__UnlockTrophyWithContextIdAndHandleId_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroStaticPS5Library.__UnlockTrophyWithContextIdAndHandleId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__UnlockTrophyWithContextIdAndHandleId_NativeFunctionPtr, (void*)ptr, 1);
			ptr->contextId = contextId;
			ptr->handle = handle;
			ptr->trophyId = trophyId;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__UnlockTrophyWithContextIdAndHandleId_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601DFD4 RID: 122836 RVA: 0x002C57F4 File Offset: 0x002C39F4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int UnlockTrophy(ref string userId, int trophyId)
		{
			UKuroStaticPS5Library.__UnlockTrophy_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__UnlockTrophy_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroStaticPS5Library.__UnlockTrophy_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__UnlockTrophy_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->userId), userId);
			ptr->trophyId = trophyId;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__UnlockTrophy_NativeFunctionPtr, (void*)ptr, 0);
			userId = FString.ToString((void*)(&ptr->userId));
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__UnlockTrophy_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601DFD5 RID: 122837 RVA: 0x002C5870 File Offset: 0x002C3A70
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int UdsEventPropertyObjectSetUInt64(long proPtr, ref string key, long value)
		{
			UKuroStaticPS5Library.__UdsEventPropertyObjectSetUInt64_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__UdsEventPropertyObjectSetUInt64_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UKuroStaticPS5Library.__UdsEventPropertyObjectSetUInt64_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__UdsEventPropertyObjectSetUInt64_NativeFunctionPtr, (void*)ptr, 1);
			ptr->proPtr = proPtr;
			FString.CopyFrom((void*)(&ptr->key), key);
			ptr->value = value;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__UdsEventPropertyObjectSetUInt64_NativeFunctionPtr, (void*)ptr, 0);
			key = FString.ToString((void*)(&ptr->key));
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__UdsEventPropertyObjectSetUInt64_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601DFD6 RID: 122838 RVA: 0x002C58F0 File Offset: 0x002C3AF0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int UdsEventPropertyObjectSetUInt32(long proPtr, ref string key, int value)
		{
			UKuroStaticPS5Library.__UdsEventPropertyObjectSetUInt32_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__UdsEventPropertyObjectSetUInt32_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroStaticPS5Library.__UdsEventPropertyObjectSetUInt32_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__UdsEventPropertyObjectSetUInt32_NativeFunctionPtr, (void*)ptr, 1);
			ptr->proPtr = proPtr;
			FString.CopyFrom((void*)(&ptr->key), key);
			ptr->value = value;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__UdsEventPropertyObjectSetUInt32_NativeFunctionPtr, (void*)ptr, 0);
			key = FString.ToString((void*)(&ptr->key));
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__UdsEventPropertyObjectSetUInt32_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601DFD7 RID: 122839 RVA: 0x002C5970 File Offset: 0x002C3B70
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int UdsEventPropertyObjectSetString(long proPtr, ref string key, ref string value)
		{
			UKuroStaticPS5Library.__UdsEventPropertyObjectSetString_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__UdsEventPropertyObjectSetString_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UKuroStaticPS5Library.__UdsEventPropertyObjectSetString_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__UdsEventPropertyObjectSetString_NativeFunctionPtr, (void*)ptr, 1);
			ptr->proPtr = proPtr;
			FString.CopyFrom((void*)(&ptr->key), key);
			FString.CopyFrom((void*)(&ptr->value), value);
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__UdsEventPropertyObjectSetString_NativeFunctionPtr, (void*)ptr, 0);
			key = FString.ToString((void*)(&ptr->key));
			value = FString.ToString((void*)(&ptr->value));
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__UdsEventPropertyObjectSetString_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601DFD8 RID: 122840 RVA: 0x002C5A08 File Offset: 0x002C3C08
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int UdsEventPropertyObjectSetInt64(long proPtr, ref string key, long value)
		{
			UKuroStaticPS5Library.__UdsEventPropertyObjectSetInt64_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__UdsEventPropertyObjectSetInt64_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UKuroStaticPS5Library.__UdsEventPropertyObjectSetInt64_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__UdsEventPropertyObjectSetInt64_NativeFunctionPtr, (void*)ptr, 1);
			ptr->proPtr = proPtr;
			FString.CopyFrom((void*)(&ptr->key), key);
			ptr->value = value;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__UdsEventPropertyObjectSetInt64_NativeFunctionPtr, (void*)ptr, 0);
			key = FString.ToString((void*)(&ptr->key));
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__UdsEventPropertyObjectSetInt64_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601DFD9 RID: 122841 RVA: 0x002C5A88 File Offset: 0x002C3C88
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int UdsEventPropertyObjectSetInt32(long proPtr, ref string key, int value)
		{
			UKuroStaticPS5Library.__UdsEventPropertyObjectSetInt32_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__UdsEventPropertyObjectSetInt32_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroStaticPS5Library.__UdsEventPropertyObjectSetInt32_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__UdsEventPropertyObjectSetInt32_NativeFunctionPtr, (void*)ptr, 1);
			ptr->proPtr = proPtr;
			FString.CopyFrom((void*)(&ptr->key), key);
			ptr->value = value;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__UdsEventPropertyObjectSetInt32_NativeFunctionPtr, (void*)ptr, 0);
			key = FString.ToString((void*)(&ptr->key));
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__UdsEventPropertyObjectSetInt32_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601DFDA RID: 122842 RVA: 0x002C5B08 File Offset: 0x002C3D08
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int UdsEventPropertyObjectSetFloat64(long proPtr, ref string key, double value)
		{
			UKuroStaticPS5Library.__UdsEventPropertyObjectSetFloat64_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__UdsEventPropertyObjectSetFloat64_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UKuroStaticPS5Library.__UdsEventPropertyObjectSetFloat64_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__UdsEventPropertyObjectSetFloat64_NativeFunctionPtr, (void*)ptr, 1);
			ptr->proPtr = proPtr;
			FString.CopyFrom((void*)(&ptr->key), key);
			ptr->value = value;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__UdsEventPropertyObjectSetFloat64_NativeFunctionPtr, (void*)ptr, 0);
			key = FString.ToString((void*)(&ptr->key));
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__UdsEventPropertyObjectSetFloat64_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601DFDB RID: 122843 RVA: 0x002C5B88 File Offset: 0x002C3D88
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int UdsEventPropertyObjectSetFloat32(long proPtr, ref string key, float value)
		{
			UKuroStaticPS5Library.__UdsEventPropertyObjectSetFloat32_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__UdsEventPropertyObjectSetFloat32_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroStaticPS5Library.__UdsEventPropertyObjectSetFloat32_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__UdsEventPropertyObjectSetFloat32_NativeFunctionPtr, (void*)ptr, 1);
			ptr->proPtr = proPtr;
			FString.CopyFrom((void*)(&ptr->key), key);
			ptr->value = value;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__UdsEventPropertyObjectSetFloat32_NativeFunctionPtr, (void*)ptr, 0);
			key = FString.ToString((void*)(&ptr->key));
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__UdsEventPropertyObjectSetFloat32_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601DFDC RID: 122844 RVA: 0x002C5C08 File Offset: 0x002C3E08
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int UdsEventPropertyObjectSetBool(long proPtr, ref string key, bool value)
		{
			UKuroStaticPS5Library.__UdsEventPropertyObjectSetBool_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__UdsEventPropertyObjectSetBool_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroStaticPS5Library.__UdsEventPropertyObjectSetBool_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__UdsEventPropertyObjectSetBool_NativeFunctionPtr, (void*)ptr, 1);
			ptr->proPtr = proPtr;
			FString.CopyFrom((void*)(&ptr->key), key);
			ptr->value = value;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__UdsEventPropertyObjectSetBool_NativeFunctionPtr, (void*)ptr, 0);
			key = FString.ToString((void*)(&ptr->key));
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__UdsEventPropertyObjectSetBool_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601DFDD RID: 122845 RVA: 0x002C5C88 File Offset: 0x002C3E88
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__UdsEventPropertyArraySetString_NativeFunctionPtr, (void*)ptr, 0);
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

		// Token: 0x0601DFDE RID: 122846 RVA: 0x002C5D2C File Offset: 0x002C3F2C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int TerminateWebBrowser()
		{
			UKuroStaticPS5Library.__TerminateWebBrowser_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__TerminateWebBrowser_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroStaticPS5Library.__TerminateWebBrowser_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__TerminateWebBrowser_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__TerminateWebBrowser_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601DFDF RID: 122847 RVA: 0x002C5D71 File Offset: 0x002C3F71
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void TerminateMessageDialog()
		{
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__TerminateMessageDialog_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601DFE0 RID: 122848 RVA: 0x002C5D88 File Offset: 0x002C3F88
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int ShowPsStoreIcon(int position)
		{
			UKuroStaticPS5Library.__ShowPsStoreIcon_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__ShowPsStoreIcon_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroStaticPS5Library.__ShowPsStoreIcon_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__ShowPsStoreIcon_NativeFunctionPtr, (void*)ptr, 1);
			ptr->position = position;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__ShowPsStoreIcon_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601DFE1 RID: 122849 RVA: 0x002C5DD4 File Offset: 0x002C3FD4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetPlayerSessionJoinableUserType(int joinableUserType)
		{
			UKuroStaticPS5Library.__SetPlayerSessionJoinableUserType_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__SetPlayerSessionJoinableUserType_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroStaticPS5Library.__SetPlayerSessionJoinableUserType_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__SetPlayerSessionJoinableUserType_NativeFunctionPtr, (void*)ptr, 1);
			ptr->joinableUserType = joinableUserType;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__SetPlayerSessionJoinableUserType_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601DFE2 RID: 122850 RVA: 0x002C5E1C File Offset: 0x002C401C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int SceNpGetNpReachabilityState(ref string userId, ref int outState)
		{
			UKuroStaticPS5Library.__SceNpGetNpReachabilityState_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__SceNpGetNpReachabilityState_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroStaticPS5Library.__SceNpGetNpReachabilityState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__SceNpGetNpReachabilityState_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->userId), userId);
			ptr->outState = outState;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__SceNpGetNpReachabilityState_NativeFunctionPtr, (void*)ptr, 0);
			userId = FString.ToString((void*)(&ptr->userId));
			outState = ptr->outState;
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__SceNpGetNpReachabilityState_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601DFE3 RID: 122851 RVA: 0x002C5EA0 File Offset: 0x002C40A0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void RemoveCacheElement(string key)
		{
			UKuroStaticPS5Library.__RemoveCacheElement_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__RemoveCacheElement_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroStaticPS5Library.__RemoveCacheElement_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__RemoveCacheElement_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->key), key);
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__RemoveCacheElement_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__RemoveCacheElement_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601DFE4 RID: 122852 RVA: 0x002C5F00 File Offset: 0x002C4100
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int RegisterUdsContext(int context, int handle)
		{
			UKuroStaticPS5Library.__RegisterUdsContext_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__RegisterUdsContext_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UKuroStaticPS5Library.__RegisterUdsContext_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__RegisterUdsContext_NativeFunctionPtr, (void*)ptr, 1);
			ptr->context = context;
			ptr->handle = handle;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__RegisterUdsContext_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601DFE5 RID: 122853 RVA: 0x002C5F54 File Offset: 0x002C4154
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__RegisterTrophyContextAsync_NativeFunctionPtr, (void*)ptr, 0);
			context = ptr->context;
			handle = ptr->handle;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__RegisterTrophyContextAsync_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601DFE6 RID: 122854 RVA: 0x002C5FEC File Offset: 0x002C41EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int PostUdsEvent(int context, int handle, long eventPtr)
		{
			UKuroStaticPS5Library.__PostUdsEvent_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__PostUdsEvent_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroStaticPS5Library.__PostUdsEvent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__PostUdsEvent_NativeFunctionPtr, (void*)ptr, 1);
			ptr->context = context;
			ptr->handle = handle;
			ptr->eventPtr = eventPtr;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__PostUdsEvent_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601DFE7 RID: 122855 RVA: 0x002C6048 File Offset: 0x002C4248
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool PollWebBrowser()
		{
			UKuroStaticPS5Library.__PollWebBrowser_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__PollWebBrowser_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroStaticPS5Library.__PollWebBrowser_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__PollWebBrowser_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__PollWebBrowser_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601DFE8 RID: 122856 RVA: 0x002C6090 File Offset: 0x002C4290
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int PollCheckoutDialogResult()
		{
			UKuroStaticPS5Library.__PollCheckoutDialogResult_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__PollCheckoutDialogResult_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroStaticPS5Library.__PollCheckoutDialogResult_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__PollCheckoutDialogResult_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__PollCheckoutDialogResult_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601DFE9 RID: 122857 RVA: 0x002C60D8 File Offset: 0x002C42D8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int OpenWebView(ref string Url)
		{
			UKuroStaticPS5Library.__OpenWebView_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__OpenWebView_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroStaticPS5Library.__OpenWebView_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__OpenWebView_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Url), Url);
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__OpenWebView_NativeFunctionPtr, (void*)ptr, 0);
			Url = FString.ToString((void*)(&ptr->Url));
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__OpenWebView_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601DFEA RID: 122858 RVA: 0x002C614C File Offset: 0x002C434C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void OpenWebBrowser(ref string Url)
		{
			UKuroStaticPS5Library.__OpenWebBrowser_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__OpenWebBrowser_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroStaticPS5Library.__OpenWebBrowser_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__OpenWebBrowser_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Url), Url);
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__OpenWebBrowser_NativeFunctionPtr, (void*)ptr, 0);
			Url = FString.ToString((void*)(&ptr->Url));
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__OpenWebBrowser_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601DFEB RID: 122859 RVA: 0x002C61B8 File Offset: 0x002C43B8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__OpenMessageDialog_NativeFunctionPtr, (void*)ptr, 0);
			userId = FString.ToString((void*)(&ptr->userId));
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__OpenMessageDialog_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601DFEC RID: 122860 RVA: 0x002C6250 File Offset: 0x002C4450
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int OpenCheckoutDialog(ref string ProductLabel)
		{
			UKuroStaticPS5Library.__OpenCheckoutDialog_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__OpenCheckoutDialog_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroStaticPS5Library.__OpenCheckoutDialog_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__OpenCheckoutDialog_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->ProductLabel), ProductLabel);
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__OpenCheckoutDialog_NativeFunctionPtr, (void*)ptr, 0);
			ProductLabel = FString.ToString((void*)(&ptr->ProductLabel));
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__OpenCheckoutDialog_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601DFED RID: 122861 RVA: 0x002C62C4 File Offset: 0x002C44C4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void NotifyPremiumFeature(ref string userId, bool isPlayStationOnly)
		{
			UKuroStaticPS5Library.__NotifyPremiumFeature_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__NotifyPremiumFeature_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroStaticPS5Library.__NotifyPremiumFeature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__NotifyPremiumFeature_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->userId), userId);
			ptr->isPlayStationOnly = isPlayStationOnly;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__NotifyPremiumFeature_NativeFunctionPtr, (void*)ptr, 0);
			userId = FString.ToString((void*)(&ptr->userId));
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__NotifyPremiumFeature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601DFEE RID: 122862 RVA: 0x002C6338 File Offset: 0x002C4538
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void NotifyPremium(ref string userId)
		{
			UKuroStaticPS5Library.__NotifyPremium_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__NotifyPremium_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroStaticPS5Library.__NotifyPremium_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__NotifyPremium_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->userId), userId);
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__NotifyPremium_NativeFunctionPtr, (void*)ptr, 0);
			userId = FString.ToString((void*)(&ptr->userId));
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__NotifyPremium_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601DFEF RID: 122863 RVA: 0x002C63A4 File Offset: 0x002C45A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void LeavePlayerSession()
		{
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__LeavePlayerSession_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601DFF0 RID: 122864 RVA: 0x002C63B8 File Offset: 0x002C45B8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void JoinPlayerSession(ref string playerSessionId)
		{
			UKuroStaticPS5Library.__JoinPlayerSession_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__JoinPlayerSession_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroStaticPS5Library.__JoinPlayerSession_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__JoinPlayerSession_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->playerSessionId), playerSessionId);
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__JoinPlayerSession_NativeFunctionPtr, (void*)ptr, 0);
			playerSessionId = FString.ToString((void*)(&ptr->playerSessionId));
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__JoinPlayerSession_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601DFF1 RID: 122865 RVA: 0x002C6424 File Offset: 0x002C4624
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int InitWebApi(ref string userId)
		{
			UKuroStaticPS5Library.__InitWebApi_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__InitWebApi_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroStaticPS5Library.__InitWebApi_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__InitWebApi_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->userId), userId);
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__InitWebApi_NativeFunctionPtr, (void*)ptr, 0);
			userId = FString.ToString((void*)(&ptr->userId));
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__InitWebApi_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601DFF2 RID: 122866 RVA: 0x002C6498 File Offset: 0x002C4698
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int InitNpUniversalDataSystem(int poolSize)
		{
			UKuroStaticPS5Library.__InitNpUniversalDataSystem_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__InitNpUniversalDataSystem_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroStaticPS5Library.__InitNpUniversalDataSystem_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__InitNpUniversalDataSystem_NativeFunctionPtr, (void*)ptr, 1);
			ptr->poolSize = poolSize;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__InitNpUniversalDataSystem_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601DFF3 RID: 122867 RVA: 0x002C64E4 File Offset: 0x002C46E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int HidePsStoreIcon()
		{
			UKuroStaticPS5Library.__HidePsStoreIcon_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__HidePsStoreIcon_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroStaticPS5Library.__HidePsStoreIcon_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__HidePsStoreIcon_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__HidePsStoreIcon_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601DFF4 RID: 122868 RVA: 0x002C652C File Offset: 0x002C472C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static string GetUserIdByAccountId(ref string accountId)
		{
			UKuroStaticPS5Library.__GetUserIdByAccountId_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__GetUserIdByAccountId_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroStaticPS5Library.__GetUserIdByAccountId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__GetUserIdByAccountId_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->accountId), accountId);
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__GetUserIdByAccountId_NativeFunctionPtr, (void*)ptr, 0);
			accountId = FString.ToString((void*)(&ptr->accountId));
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__GetUserIdByAccountId_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601DFF5 RID: 122869 RVA: 0x002C65A4 File Offset: 0x002C47A4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static string GetUserId()
		{
			UKuroStaticPS5Library.__GetUserId_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__GetUserId_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroStaticPS5Library.__GetUserId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__GetUserId_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__GetUserId_NativeFunctionPtr, (void*)ptr, 0);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__GetUserId_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601DFF6 RID: 122870 RVA: 0x002C6600 File Offset: 0x002C4800
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__GetTrophyListWithContextIdAndHandleIdAsync_NativeFunctionPtr, (void*)ptr, 0);
			inputOffset = ptr->inputOffset;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__GetTrophyListWithContextIdAndHandleIdAsync_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601DFF7 RID: 122871 RVA: 0x002C6694 File Offset: 0x002C4894
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static FTrophyInfoData GetTrophyListWithContextIdAndHandleId(int context, int handle, ref int inputOffset, int length)
		{
			UKuroStaticPS5Library.__GetTrophyListWithContextIdAndHandleId_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__GetTrophyListWithContextIdAndHandleId_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(UKuroStaticPS5Library.__GetTrophyListWithContextIdAndHandleId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__GetTrophyListWithContextIdAndHandleId_NativeFunctionPtr, (void*)ptr, 1);
			ptr->context = context;
			ptr->handle = handle;
			ptr->inputOffset = inputOffset;
			ptr->length = length;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__GetTrophyListWithContextIdAndHandleId_NativeFunctionPtr, (void*)ptr, 0);
			inputOffset = ptr->inputOffset;
			FTrophyInfoData result = new FTrophyInfoData(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__GetTrophyListWithContextIdAndHandleId_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601DFF8 RID: 122872 RVA: 0x002C6718 File Offset: 0x002C4918
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static FTrophyInfoData GetTrophyList(ref string userId, ref int inputOffset, int length)
		{
			UKuroStaticPS5Library.__GetTrophyList_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__GetTrophyList_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(UKuroStaticPS5Library.__GetTrophyList_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__GetTrophyList_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->userId), userId);
			ptr->inputOffset = inputOffset;
			ptr->length = length;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__GetTrophyList_NativeFunctionPtr, (void*)ptr, 0);
			userId = FString.ToString((void*)(&ptr->userId));
			inputOffset = ptr->inputOffset;
			FTrophyInfoData result = new FTrophyInfoData(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__GetTrophyList_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601DFF9 RID: 122873 RVA: 0x002C67AC File Offset: 0x002C49AC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static TArray<FProductData> GetStoreProductsWithParams(int ServiceLabel, int Offset, int Limit)
		{
			UKuroStaticPS5Library.__GetStoreProductsWithParams_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__GetStoreProductsWithParams_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroStaticPS5Library.__GetStoreProductsWithParams_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__GetStoreProductsWithParams_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ServiceLabel = ServiceLabel;
			ptr->Offset = Offset;
			ptr->Limit = Limit;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__GetStoreProductsWithParams_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FProductData> result = new TArray<FProductData>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__GetStoreProductsWithParams_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601DFFA RID: 122874 RVA: 0x002C6820 File Offset: 0x002C4A20
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static TArray<FProductData> GetStoreProducts()
		{
			UKuroStaticPS5Library.__GetStoreProducts_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__GetStoreProducts_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroStaticPS5Library.__GetStoreProducts_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__GetStoreProducts_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__GetStoreProducts_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FProductData> result = new TArray<FProductData>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__GetStoreProducts_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601DFFB RID: 122875 RVA: 0x002C6880 File Offset: 0x002C4A80
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static string GetPlayerIdByPlayerSessionId(ref string playerSessionId)
		{
			UKuroStaticPS5Library.__GetPlayerIdByPlayerSessionId_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__GetPlayerIdByPlayerSessionId_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroStaticPS5Library.__GetPlayerIdByPlayerSessionId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__GetPlayerIdByPlayerSessionId_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->playerSessionId), playerSessionId);
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__GetPlayerIdByPlayerSessionId_NativeFunctionPtr, (void*)ptr, 0);
			playerSessionId = FString.ToString((void*)(&ptr->playerSessionId));
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__GetPlayerIdByPlayerSessionId_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601DFFC RID: 122876 RVA: 0x002C68F8 File Offset: 0x002C4AF8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static string GetOnlineIdByUserId(ref string userId)
		{
			UKuroStaticPS5Library.__GetOnlineIdByUserId_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__GetOnlineIdByUserId_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroStaticPS5Library.__GetOnlineIdByUserId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__GetOnlineIdByUserId_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->userId), userId);
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__GetOnlineIdByUserId_NativeFunctionPtr, (void*)ptr, 0);
			userId = FString.ToString((void*)(&ptr->userId));
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__GetOnlineIdByUserId_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601DFFD RID: 122877 RVA: 0x002C6970 File Offset: 0x002C4B70
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void GetMessageDialogStateAsync(in FPlayStationGetDialogStatusCallBack callback)
		{
			UKuroStaticPS5Library.__GetMessageDialogStateAsync_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__GetMessageDialogStateAsync_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UKuroStaticPS5Library.__GetMessageDialogStateAsync_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__GetMessageDialogStateAsync_NativeFunctionPtr, (void*)ptr, 1);
			IntPtr dest = &ptr->callback;
			FPlayStationGetDialogStatusCallBack fplayStationGetDialogStatusCallBack = callback;
			FScriptDelegate.NativeCopy(dest, (fplayStationGetDialogStatusCallBack != null) ? fplayStationGetDialogStatusCallBack.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__GetMessageDialogStateAsync_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__GetMessageDialogStateAsync_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601DFFE RID: 122878 RVA: 0x002C69DC File Offset: 0x002C4BDC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int GetIdToken(ref string ClientId, ref string ClientSecret, ref string Scope, ref string IdToken)
		{
			UKuroStaticPS5Library.__GetIdToken_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__GetIdToken_FunctionParams[(UIntPtr)87] + 15L / (long)sizeof(UKuroStaticPS5Library.__GetIdToken_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__GetIdToken_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->ClientId), ClientId);
			FString.CopyFrom((void*)(&ptr->ClientSecret), ClientSecret);
			FString.CopyFrom((void*)(&ptr->Scope), Scope);
			FString.CopyFrom((void*)(&ptr->IdToken), IdToken);
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__GetIdToken_NativeFunctionPtr, (void*)ptr, 0);
			ClientId = FString.ToString((void*)(&ptr->ClientId));
			ClientSecret = FString.ToString((void*)(&ptr->ClientSecret));
			Scope = FString.ToString((void*)(&ptr->Scope));
			IdToken = FString.ToString((void*)(&ptr->IdToken));
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__GetIdToken_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601DFFF RID: 122879 RVA: 0x002C6AA4 File Offset: 0x002C4CA4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static string GetCountryCodeByUserId(ref string userId)
		{
			UKuroStaticPS5Library.__GetCountryCodeByUserId_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__GetCountryCodeByUserId_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroStaticPS5Library.__GetCountryCodeByUserId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__GetCountryCodeByUserId_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->userId), userId);
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__GetCountryCodeByUserId_NativeFunctionPtr, (void*)ptr, 0);
			userId = FString.ToString((void*)(&ptr->userId));
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__GetCountryCodeByUserId_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601E000 RID: 122880 RVA: 0x002C6B1C File Offset: 0x002C4D1C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void GetCommunicationRestrictionStatusAsync(ref string accountId, [Nullable(2)] in FPlayStationGetCommunicationStatusCallBack callback)
		{
			UKuroStaticPS5Library.__GetCommunicationRestrictionStatusAsync_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__GetCommunicationRestrictionStatusAsync_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(UKuroStaticPS5Library.__GetCommunicationRestrictionStatusAsync_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__GetCommunicationRestrictionStatusAsync_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->accountId), accountId);
			IntPtr dest = &ptr->callback;
			FPlayStationGetCommunicationStatusCallBack fplayStationGetCommunicationStatusCallBack = callback;
			FScriptDelegate.NativeCopy(dest, (fplayStationGetCommunicationStatusCallBack != null) ? fplayStationGetCommunicationStatusCallBack.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__GetCommunicationRestrictionStatusAsync_NativeFunctionPtr, (void*)ptr, 0);
			accountId = FString.ToString((void*)(&ptr->accountId));
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__GetCommunicationRestrictionStatusAsync_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601E001 RID: 122881 RVA: 0x002C6BA4 File Offset: 0x002C4DA4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static string GetCacheMapElement(string key)
		{
			UKuroStaticPS5Library.__GetCacheMapElement_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__GetCacheMapElement_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroStaticPS5Library.__GetCacheMapElement_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__GetCacheMapElement_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->key), key);
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__GetCacheMapElement_NativeFunctionPtr, (void*)ptr, 0);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__GetCacheMapElement_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601E002 RID: 122882 RVA: 0x002C6C10 File Offset: 0x002C4E10
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void GetBlockUserListAsync(ref int offset, ref int limit, in FPlayStationGetBlockResult Delegate)
		{
			UKuroStaticPS5Library.__GetBlockUserListAsync_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__GetBlockUserListAsync_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UKuroStaticPS5Library.__GetBlockUserListAsync_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__GetBlockUserListAsync_NativeFunctionPtr, (void*)ptr, 1);
			ptr->offset = offset;
			ptr->limit = limit;
			IntPtr dest = &ptr->Delegate;
			FPlayStationGetBlockResult fplayStationGetBlockResult = Delegate;
			FScriptDelegate.NativeCopy(dest, (fplayStationGetBlockResult != null) ? fplayStationGetBlockResult.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__GetBlockUserListAsync_NativeFunctionPtr, (void*)ptr, 0);
			offset = ptr->offset;
			limit = ptr->limit;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__GetBlockUserListAsync_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601E003 RID: 122883 RVA: 0x002C6C9C File Offset: 0x002C4E9C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static FBlockUserData GetBlockUserList(ref int offset, ref int limit)
		{
			UKuroStaticPS5Library.__GetBlockUserList_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__GetBlockUserList_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroStaticPS5Library.__GetBlockUserList_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__GetBlockUserList_NativeFunctionPtr, (void*)ptr, 1);
			ptr->offset = offset;
			ptr->limit = limit;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__GetBlockUserList_NativeFunctionPtr, (void*)ptr, 0);
			offset = ptr->offset;
			limit = ptr->limit;
			FBlockUserData result = new FBlockUserData(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__GetBlockUserList_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601E004 RID: 122884 RVA: 0x002C6D1C File Offset: 0x002C4F1C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static TArray<FBasicPresenceData> GetBasicPresence(ref string accountId)
		{
			UKuroStaticPS5Library.__GetBasicPresence_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__GetBasicPresence_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroStaticPS5Library.__GetBasicPresence_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__GetBasicPresence_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->accountId), accountId);
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__GetBasicPresence_NativeFunctionPtr, (void*)ptr, 0);
			accountId = FString.ToString((void*)(&ptr->accountId));
			TArray<FBasicPresenceData> result = new TArray<FBasicPresenceData>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__GetBasicPresence_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601E005 RID: 122885 RVA: 0x002C6D98 File Offset: 0x002C4F98
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int GetAuthCode(ref string ClientId, ref string Scope, ref string AuthCode, ref int IssuerId)
		{
			UKuroStaticPS5Library.__GetAuthCode_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__GetAuthCode_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(UKuroStaticPS5Library.__GetAuthCode_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__GetAuthCode_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->ClientId), ClientId);
			FString.CopyFrom((void*)(&ptr->Scope), Scope);
			FString.CopyFrom((void*)(&ptr->AuthCode), AuthCode);
			ptr->IssuerId = IssuerId;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__GetAuthCode_NativeFunctionPtr, (void*)ptr, 0);
			ClientId = FString.ToString((void*)(&ptr->ClientId));
			Scope = FString.ToString((void*)(&ptr->Scope));
			AuthCode = FString.ToString((void*)(&ptr->AuthCode));
			IssuerId = ptr->IssuerId;
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__GetAuthCode_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601E006 RID: 122886 RVA: 0x002C6E54 File Offset: 0x002C5054
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static string GetAccountIdByUserId(ref string userId)
		{
			UKuroStaticPS5Library.__GetAccountIdByUserId_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__GetAccountIdByUserId_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroStaticPS5Library.__GetAccountIdByUserId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__GetAccountIdByUserId_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->userId), userId);
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__GetAccountIdByUserId_NativeFunctionPtr, (void*)ptr, 0);
			userId = FString.ToString((void*)(&ptr->userId));
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__GetAccountIdByUserId_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601E007 RID: 122887 RVA: 0x002C6ECC File Offset: 0x002C50CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int DestroyUdsHandle(int handle)
		{
			UKuroStaticPS5Library.__DestroyUdsHandle_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__DestroyUdsHandle_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroStaticPS5Library.__DestroyUdsHandle_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__DestroyUdsHandle_NativeFunctionPtr, (void*)ptr, 1);
			ptr->handle = handle;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__DestroyUdsHandle_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601E008 RID: 122888 RVA: 0x002C6F18 File Offset: 0x002C5118
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int DestroyUdsEvent(long eventPtr)
		{
			UKuroStaticPS5Library.__DestroyUdsEvent_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__DestroyUdsEvent_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroStaticPS5Library.__DestroyUdsEvent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__DestroyUdsEvent_NativeFunctionPtr, (void*)ptr, 1);
			ptr->eventPtr = eventPtr;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__DestroyUdsEvent_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601E009 RID: 122889 RVA: 0x002C6F64 File Offset: 0x002C5164
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int DestroyUdsContext(int context)
		{
			UKuroStaticPS5Library.__DestroyUdsContext_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__DestroyUdsContext_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroStaticPS5Library.__DestroyUdsContext_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__DestroyUdsContext_NativeFunctionPtr, (void*)ptr, 1);
			ptr->context = context;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__DestroyUdsContext_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601E00A RID: 122890 RVA: 0x002C6FB0 File Offset: 0x002C51B0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void DestroyTrophyHandleAsync(ref int handle, in FPlayStationDestroyHandleCallBack callback)
		{
			UKuroStaticPS5Library.__DestroyTrophyHandleAsync_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__DestroyTrophyHandleAsync_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UKuroStaticPS5Library.__DestroyTrophyHandleAsync_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__DestroyTrophyHandleAsync_NativeFunctionPtr, (void*)ptr, 1);
			ptr->handle = handle;
			IntPtr dest = &ptr->callback;
			FPlayStationDestroyHandleCallBack fplayStationDestroyHandleCallBack = callback;
			FScriptDelegate.NativeCopy(dest, (fplayStationDestroyHandleCallBack != null) ? fplayStationDestroyHandleCallBack.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__DestroyTrophyHandleAsync_NativeFunctionPtr, (void*)ptr, 0);
			handle = ptr->handle;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__DestroyTrophyHandleAsync_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601E00B RID: 122891 RVA: 0x002C702C File Offset: 0x002C522C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void DestroyTrophyContextAsync(ref int context, in FPlayStationDestroyContextCallBack callback)
		{
			UKuroStaticPS5Library.__DestroyTrophyContextAsync_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__DestroyTrophyContextAsync_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UKuroStaticPS5Library.__DestroyTrophyContextAsync_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__DestroyTrophyContextAsync_NativeFunctionPtr, (void*)ptr, 1);
			ptr->context = context;
			IntPtr dest = &ptr->callback;
			FPlayStationDestroyContextCallBack fplayStationDestroyContextCallBack = callback;
			FScriptDelegate.NativeCopy(dest, (fplayStationDestroyContextCallBack != null) ? fplayStationDestroyContextCallBack.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__DestroyTrophyContextAsync_NativeFunctionPtr, (void*)ptr, 0);
			context = ptr->context;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__DestroyTrophyContextAsync_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601E00C RID: 122892 RVA: 0x002C70A8 File Offset: 0x002C52A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int CreateUdsHandle(ref int handle)
		{
			UKuroStaticPS5Library.__CreateUdsHandle_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__CreateUdsHandle_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroStaticPS5Library.__CreateUdsHandle_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__CreateUdsHandle_NativeFunctionPtr, (void*)ptr, 1);
			ptr->handle = handle;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__CreateUdsHandle_NativeFunctionPtr, (void*)ptr, 0);
			handle = ptr->handle;
			return ptr->__Result;
		}

		// Token: 0x0601E00D RID: 122893 RVA: 0x002C7100 File Offset: 0x002C5300
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int CreateUdsEvent(ref string eventName, ref long outEventPtr, ref long outProPtr)
		{
			UKuroStaticPS5Library.__CreateUdsEvent_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__CreateUdsEvent_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UKuroStaticPS5Library.__CreateUdsEvent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__CreateUdsEvent_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->eventName), eventName);
			ptr->outEventPtr = outEventPtr;
			ptr->outProPtr = outProPtr;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__CreateUdsEvent_NativeFunctionPtr, (void*)ptr, 0);
			eventName = FString.ToString((void*)(&ptr->eventName));
			outEventPtr = ptr->outEventPtr;
			outProPtr = ptr->outProPtr;
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__CreateUdsEvent_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601E00E RID: 122894 RVA: 0x002C7194 File Offset: 0x002C5394
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int CreateUdsContext(ref string userId, ref int context)
		{
			UKuroStaticPS5Library.__CreateUdsContext_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__CreateUdsContext_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroStaticPS5Library.__CreateUdsContext_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__CreateUdsContext_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->userId), userId);
			ptr->context = context;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__CreateUdsContext_NativeFunctionPtr, (void*)ptr, 0);
			userId = FString.ToString((void*)(&ptr->userId));
			context = ptr->context;
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__CreateUdsContext_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601E00F RID: 122895 RVA: 0x002C7218 File Offset: 0x002C5418
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void CreateTrophyHandleAsync(in FPlayStationCreateHandleCallBack callback)
		{
			UKuroStaticPS5Library.__CreateTrophyHandleAsync_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__CreateTrophyHandleAsync_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UKuroStaticPS5Library.__CreateTrophyHandleAsync_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__CreateTrophyHandleAsync_NativeFunctionPtr, (void*)ptr, 1);
			IntPtr dest = &ptr->callback;
			FPlayStationCreateHandleCallBack fplayStationCreateHandleCallBack = callback;
			FScriptDelegate.NativeCopy(dest, (fplayStationCreateHandleCallBack != null) ? fplayStationCreateHandleCallBack.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__CreateTrophyHandleAsync_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__CreateTrophyHandleAsync_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601E010 RID: 122896 RVA: 0x002C7284 File Offset: 0x002C5484
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__CreateTrophyContextAsync_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__CreateTrophyContextAsync_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601E011 RID: 122897 RVA: 0x002C7310 File Offset: 0x002C5510
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static string CreatePlayerSession(int joinableUserType, ref string playerId)
		{
			UKuroStaticPS5Library.__CreatePlayerSession_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__CreatePlayerSession_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UKuroStaticPS5Library.__CreatePlayerSession_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__CreatePlayerSession_NativeFunctionPtr, (void*)ptr, 1);
			ptr->joinableUserType = joinableUserType;
			FString.CopyFrom((void*)(&ptr->playerId), playerId);
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__CreatePlayerSession_NativeFunctionPtr, (void*)ptr, 0);
			playerId = FString.ToString((void*)(&ptr->playerId));
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__CreatePlayerSession_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601E012 RID: 122898 RVA: 0x002C7390 File Offset: 0x002C5590
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int CloseWebBrowser()
		{
			UKuroStaticPS5Library.__CloseWebBrowser_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__CloseWebBrowser_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroStaticPS5Library.__CloseWebBrowser_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__CloseWebBrowser_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__CloseWebBrowser_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601E013 RID: 122899 RVA: 0x002C73D5 File Offset: 0x002C55D5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void ClearJoinSessionHandle()
		{
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__ClearJoinSessionHandle_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601E014 RID: 122900 RVA: 0x002C73E9 File Offset: 0x002C55E9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void ClearJoinSessionDelegate()
		{
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__ClearJoinSessionDelegate_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601E015 RID: 122901 RVA: 0x002C7400 File Offset: 0x002C5600
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int CheckUserPremium(ref string userId)
		{
			UKuroStaticPS5Library.__CheckUserPremium_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__CheckUserPremium_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroStaticPS5Library.__CheckUserPremium_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__CheckUserPremium_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->userId), userId);
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__CheckUserPremium_NativeFunctionPtr, (void*)ptr, 0);
			userId = FString.ToString((void*)(&ptr->userId));
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__CheckUserPremium_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601E016 RID: 122902 RVA: 0x002C7474 File Offset: 0x002C5674
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static string CheckJoinSession()
		{
			UKuroStaticPS5Library.__CheckJoinSession_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__CheckJoinSession_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroStaticPS5Library.__CheckJoinSession_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__CheckJoinSession_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__CheckJoinSession_NativeFunctionPtr, (void*)ptr, 0);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__CheckJoinSession_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601E017 RID: 122903 RVA: 0x002C74D0 File Offset: 0x002C56D0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void AddJoinSessionDelegate(in FJoinSessionCallBack InDelegate)
		{
			UKuroStaticPS5Library.__AddJoinSessionDelegate_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__AddJoinSessionDelegate_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UKuroStaticPS5Library.__AddJoinSessionDelegate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__AddJoinSessionDelegate_NativeFunctionPtr, (void*)ptr, 1);
			IntPtr dest = &ptr->InDelegate;
			FJoinSessionCallBack fjoinSessionCallBack = InDelegate;
			FScriptDelegate.NativeCopy(dest, (fjoinSessionCallBack != null) ? fjoinSessionCallBack.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__AddJoinSessionDelegate_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__AddJoinSessionDelegate_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601E018 RID: 122904 RVA: 0x002C753C File Offset: 0x002C573C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void AddCacheMapElement(string key, string value)
		{
			UKuroStaticPS5Library.__AddCacheMapElement_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__AddCacheMapElement_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroStaticPS5Library.__AddCacheMapElement_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__AddCacheMapElement_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->key), key);
			FString.CopyFrom((void*)(&ptr->value), value);
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__AddCacheMapElement_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__AddCacheMapElement_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601E019 RID: 122905 RVA: 0x002C75A8 File Offset: 0x002C57A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int AbortUdsHandle(int handle)
		{
			UKuroStaticPS5Library.__AbortUdsHandle_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__AbortUdsHandle_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroStaticPS5Library.__AbortUdsHandle_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__AbortUdsHandle_NativeFunctionPtr, (void*)ptr, 1);
			ptr->handle = handle;
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__AbortUdsHandle_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601E01A RID: 122906 RVA: 0x002C75F4 File Offset: 0x002C57F4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void AbortTrophyHandleAsync(ref int handle, in FPlayStationAbortHandleCallBack callback)
		{
			UKuroStaticPS5Library.__AbortTrophyHandleAsync_FunctionParams* ptr = stackalloc UKuroStaticPS5Library.__AbortTrophyHandleAsync_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UKuroStaticPS5Library.__AbortTrophyHandleAsync_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroStaticPS5Library.__AbortTrophyHandleAsync_NativeFunctionPtr, (void*)ptr, 1);
			ptr->handle = handle;
			IntPtr dest = &ptr->callback;
			FPlayStationAbortHandleCallBack fplayStationAbortHandleCallBack = callback;
			FScriptDelegate.NativeCopy(dest, (fplayStationAbortHandleCallBack != null) ? fplayStationAbortHandleCallBack.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroStaticPS5Library._ClassDefaultObjectPtr, UKuroStaticPS5Library.__AbortTrophyHandleAsync_NativeFunctionPtr, (void*)ptr, 0);
			handle = ptr->handle;
			UnrealReflectionUtils.DestroyStruct(UKuroStaticPS5Library.__AbortTrophyHandleAsync_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601E01B RID: 122907 RVA: 0x002C766F File Offset: 0x002C586F
		static UKuroStaticPS5Library()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroStaticPS5Library");
		}

		// Token: 0x0601E01C RID: 122908 RVA: 0x002C767D File Offset: 0x002C587D
		protected UKuroStaticPS5Library(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010345 RID: 66373
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroStaticPS5Library";

		// Token: 0x04010346 RID: 66374
		private static IntPtr _ClassPtr;

		// Token: 0x04010347 RID: 66375
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010348 RID: 66376
		private static IntPtr __UpdateTrophyProgressWithContextIdAndHandleIdAsync_NativeFunctionPtr;

		// Token: 0x04010349 RID: 66377
		private static IntPtr __UpdateTrophyProgressWithContextIdAndHandleId_NativeFunctionPtr;

		// Token: 0x0401034A RID: 66378
		private static IntPtr __UpdateTrophyProgress_NativeFunctionPtr;

		// Token: 0x0401034B RID: 66379
		private static IntPtr __UnlockTrophyWithContextIdAndHandleIdAsync_NativeFunctionPtr;

		// Token: 0x0401034C RID: 66380
		private static IntPtr __UnlockTrophyWithContextIdAndHandleId_NativeFunctionPtr;

		// Token: 0x0401034D RID: 66381
		private static IntPtr __UnlockTrophy_NativeFunctionPtr;

		// Token: 0x0401034E RID: 66382
		private static IntPtr __UdsEventPropertyObjectSetUInt64_NativeFunctionPtr;

		// Token: 0x0401034F RID: 66383
		private static IntPtr __UdsEventPropertyObjectSetUInt32_NativeFunctionPtr;

		// Token: 0x04010350 RID: 66384
		private static IntPtr __UdsEventPropertyObjectSetString_NativeFunctionPtr;

		// Token: 0x04010351 RID: 66385
		private static IntPtr __UdsEventPropertyObjectSetInt64_NativeFunctionPtr;

		// Token: 0x04010352 RID: 66386
		private static IntPtr __UdsEventPropertyObjectSetInt32_NativeFunctionPtr;

		// Token: 0x04010353 RID: 66387
		private static IntPtr __UdsEventPropertyObjectSetFloat64_NativeFunctionPtr;

		// Token: 0x04010354 RID: 66388
		private static IntPtr __UdsEventPropertyObjectSetFloat32_NativeFunctionPtr;

		// Token: 0x04010355 RID: 66389
		private static IntPtr __UdsEventPropertyObjectSetBool_NativeFunctionPtr;

		// Token: 0x04010356 RID: 66390
		private static IntPtr __UdsEventPropertyArraySetString_NativeFunctionPtr;

		// Token: 0x04010357 RID: 66391
		private static IntPtr __TerminateWebBrowser_NativeFunctionPtr;

		// Token: 0x04010358 RID: 66392
		private static IntPtr __TerminateMessageDialog_NativeFunctionPtr;

		// Token: 0x04010359 RID: 66393
		private static IntPtr __ShowPsStoreIcon_NativeFunctionPtr;

		// Token: 0x0401035A RID: 66394
		private static IntPtr __SetPlayerSessionJoinableUserType_NativeFunctionPtr;

		// Token: 0x0401035B RID: 66395
		private static IntPtr __SceNpGetNpReachabilityState_NativeFunctionPtr;

		// Token: 0x0401035C RID: 66396
		private static IntPtr __RemoveCacheElement_NativeFunctionPtr;

		// Token: 0x0401035D RID: 66397
		private static IntPtr __RegisterUdsContext_NativeFunctionPtr;

		// Token: 0x0401035E RID: 66398
		private static IntPtr __RegisterTrophyContextAsync_NativeFunctionPtr;

		// Token: 0x0401035F RID: 66399
		private static IntPtr __PostUdsEvent_NativeFunctionPtr;

		// Token: 0x04010360 RID: 66400
		private static IntPtr __PollWebBrowser_NativeFunctionPtr;

		// Token: 0x04010361 RID: 66401
		private static IntPtr __PollCheckoutDialogResult_NativeFunctionPtr;

		// Token: 0x04010362 RID: 66402
		private static IntPtr __OpenWebView_NativeFunctionPtr;

		// Token: 0x04010363 RID: 66403
		private static IntPtr __OpenWebBrowser_NativeFunctionPtr;

		// Token: 0x04010364 RID: 66404
		private static IntPtr __OpenMessageDialog_NativeFunctionPtr;

		// Token: 0x04010365 RID: 66405
		private static IntPtr __OpenCheckoutDialog_NativeFunctionPtr;

		// Token: 0x04010366 RID: 66406
		private static IntPtr __NotifyPremiumFeature_NativeFunctionPtr;

		// Token: 0x04010367 RID: 66407
		private static IntPtr __NotifyPremium_NativeFunctionPtr;

		// Token: 0x04010368 RID: 66408
		private static IntPtr __LeavePlayerSession_NativeFunctionPtr;

		// Token: 0x04010369 RID: 66409
		private static IntPtr __JoinPlayerSession_NativeFunctionPtr;

		// Token: 0x0401036A RID: 66410
		private static IntPtr __InitWebApi_NativeFunctionPtr;

		// Token: 0x0401036B RID: 66411
		private static IntPtr __InitNpUniversalDataSystem_NativeFunctionPtr;

		// Token: 0x0401036C RID: 66412
		private static IntPtr __HidePsStoreIcon_NativeFunctionPtr;

		// Token: 0x0401036D RID: 66413
		private static IntPtr __GetUserIdByAccountId_NativeFunctionPtr;

		// Token: 0x0401036E RID: 66414
		private static IntPtr __GetUserId_NativeFunctionPtr;

		// Token: 0x0401036F RID: 66415
		private static IntPtr __GetTrophyListWithContextIdAndHandleIdAsync_NativeFunctionPtr;

		// Token: 0x04010370 RID: 66416
		private static IntPtr __GetTrophyListWithContextIdAndHandleId_NativeFunctionPtr;

		// Token: 0x04010371 RID: 66417
		private static IntPtr __GetTrophyList_NativeFunctionPtr;

		// Token: 0x04010372 RID: 66418
		private static IntPtr __GetStoreProductsWithParams_NativeFunctionPtr;

		// Token: 0x04010373 RID: 66419
		private static IntPtr __GetStoreProducts_NativeFunctionPtr;

		// Token: 0x04010374 RID: 66420
		private static IntPtr __GetPlayerIdByPlayerSessionId_NativeFunctionPtr;

		// Token: 0x04010375 RID: 66421
		private static IntPtr __GetOnlineIdByUserId_NativeFunctionPtr;

		// Token: 0x04010376 RID: 66422
		private static IntPtr __GetMessageDialogStateAsync_NativeFunctionPtr;

		// Token: 0x04010377 RID: 66423
		private static IntPtr __GetIdToken_NativeFunctionPtr;

		// Token: 0x04010378 RID: 66424
		private static IntPtr __GetCountryCodeByUserId_NativeFunctionPtr;

		// Token: 0x04010379 RID: 66425
		private static IntPtr __GetCommunicationRestrictionStatusAsync_NativeFunctionPtr;

		// Token: 0x0401037A RID: 66426
		private static IntPtr __GetCacheMapElement_NativeFunctionPtr;

		// Token: 0x0401037B RID: 66427
		private static IntPtr __GetBlockUserListAsync_NativeFunctionPtr;

		// Token: 0x0401037C RID: 66428
		private static IntPtr __GetBlockUserList_NativeFunctionPtr;

		// Token: 0x0401037D RID: 66429
		private static IntPtr __GetBasicPresence_NativeFunctionPtr;

		// Token: 0x0401037E RID: 66430
		private static IntPtr __GetAuthCode_NativeFunctionPtr;

		// Token: 0x0401037F RID: 66431
		private static IntPtr __GetAccountIdByUserId_NativeFunctionPtr;

		// Token: 0x04010380 RID: 66432
		private static IntPtr __DestroyUdsHandle_NativeFunctionPtr;

		// Token: 0x04010381 RID: 66433
		private static IntPtr __DestroyUdsEvent_NativeFunctionPtr;

		// Token: 0x04010382 RID: 66434
		private static IntPtr __DestroyUdsContext_NativeFunctionPtr;

		// Token: 0x04010383 RID: 66435
		private static IntPtr __DestroyTrophyHandleAsync_NativeFunctionPtr;

		// Token: 0x04010384 RID: 66436
		private static IntPtr __DestroyTrophyContextAsync_NativeFunctionPtr;

		// Token: 0x04010385 RID: 66437
		private static IntPtr __CreateUdsHandle_NativeFunctionPtr;

		// Token: 0x04010386 RID: 66438
		private static IntPtr __CreateUdsEvent_NativeFunctionPtr;

		// Token: 0x04010387 RID: 66439
		private static IntPtr __CreateUdsContext_NativeFunctionPtr;

		// Token: 0x04010388 RID: 66440
		private static IntPtr __CreateTrophyHandleAsync_NativeFunctionPtr;

		// Token: 0x04010389 RID: 66441
		private static IntPtr __CreateTrophyContextAsync_NativeFunctionPtr;

		// Token: 0x0401038A RID: 66442
		private static IntPtr __CreatePlayerSession_NativeFunctionPtr;

		// Token: 0x0401038B RID: 66443
		private static IntPtr __CloseWebBrowser_NativeFunctionPtr;

		// Token: 0x0401038C RID: 66444
		private static IntPtr __ClearJoinSessionHandle_NativeFunctionPtr;

		// Token: 0x0401038D RID: 66445
		private static IntPtr __ClearJoinSessionDelegate_NativeFunctionPtr;

		// Token: 0x0401038E RID: 66446
		private static IntPtr __CheckUserPremium_NativeFunctionPtr;

		// Token: 0x0401038F RID: 66447
		private static IntPtr __CheckJoinSession_NativeFunctionPtr;

		// Token: 0x04010390 RID: 66448
		private static IntPtr __AddJoinSessionDelegate_NativeFunctionPtr;

		// Token: 0x04010391 RID: 66449
		private static IntPtr __AddCacheMapElement_NativeFunctionPtr;

		// Token: 0x04010392 RID: 66450
		private static IntPtr __AbortUdsHandle_NativeFunctionPtr;

		// Token: 0x04010393 RID: 66451
		private static IntPtr __AbortTrophyHandleAsync_NativeFunctionPtr;

		// Token: 0x02003324 RID: 13092
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __UpdateTrophyProgressWithContextIdAndHandleIdAsync_FunctionParams
		{
			// Token: 0x04017201 RID: 94721
			[FieldOffset(0)]
			public int context;

			// Token: 0x04017202 RID: 94722
			[FieldOffset(4)]
			public int handle;

			// Token: 0x04017203 RID: 94723
			[FieldOffset(8)]
			public int trophyId;

			// Token: 0x04017204 RID: 94724
			[FieldOffset(12)]
			public int progress;

			// Token: 0x04017205 RID: 94725
			[FieldOffset(16)]
			public byte callback;
		}

		// Token: 0x02003325 RID: 13093
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 20)]
		protected ref struct __UpdateTrophyProgressWithContextIdAndHandleId_FunctionParams
		{
			// Token: 0x04017206 RID: 94726
			[FieldOffset(0)]
			public int context;

			// Token: 0x04017207 RID: 94727
			[FieldOffset(4)]
			public int handle;

			// Token: 0x04017208 RID: 94728
			[FieldOffset(8)]
			public int trophyId;

			// Token: 0x04017209 RID: 94729
			[FieldOffset(12)]
			public int progress;

			// Token: 0x0401720A RID: 94730
			[FieldOffset(16)]
			public int __Result;
		}

		// Token: 0x02003326 RID: 13094
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __UpdateTrophyProgress_FunctionParams
		{
			// Token: 0x0401720B RID: 94731
			[FieldOffset(0)]
			public FString userId;

			// Token: 0x0401720C RID: 94732
			[FieldOffset(16)]
			public int trophyId;

			// Token: 0x0401720D RID: 94733
			[FieldOffset(20)]
			public int progress;

			// Token: 0x0401720E RID: 94734
			[FieldOffset(24)]
			public int __Result;
		}

		// Token: 0x02003327 RID: 13095
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __UnlockTrophyWithContextIdAndHandleIdAsync_FunctionParams
		{
			// Token: 0x0401720F RID: 94735
			[FieldOffset(0)]
			public int contextId;

			// Token: 0x04017210 RID: 94736
			[FieldOffset(4)]
			public int handle;

			// Token: 0x04017211 RID: 94737
			[FieldOffset(8)]
			public int trophyId;

			// Token: 0x04017212 RID: 94738
			[FieldOffset(16)]
			public byte callback;
		}

		// Token: 0x02003328 RID: 13096
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __UnlockTrophyWithContextIdAndHandleId_FunctionParams
		{
			// Token: 0x04017213 RID: 94739
			[FieldOffset(0)]
			public int contextId;

			// Token: 0x04017214 RID: 94740
			[FieldOffset(4)]
			public int handle;

			// Token: 0x04017215 RID: 94741
			[FieldOffset(8)]
			public int trophyId;

			// Token: 0x04017216 RID: 94742
			[FieldOffset(12)]
			public int __Result;
		}

		// Token: 0x02003329 RID: 13097
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __UnlockTrophy_FunctionParams
		{
			// Token: 0x04017217 RID: 94743
			[FieldOffset(0)]
			public FString userId;

			// Token: 0x04017218 RID: 94744
			[FieldOffset(16)]
			public int trophyId;

			// Token: 0x04017219 RID: 94745
			[FieldOffset(20)]
			public int __Result;
		}

		// Token: 0x0200332A RID: 13098
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __UdsEventPropertyObjectSetUInt64_FunctionParams
		{
			// Token: 0x0401721A RID: 94746
			[FieldOffset(0)]
			public long proPtr;

			// Token: 0x0401721B RID: 94747
			[FieldOffset(8)]
			public FString key;

			// Token: 0x0401721C RID: 94748
			[FieldOffset(24)]
			public long value;

			// Token: 0x0401721D RID: 94749
			[FieldOffset(32)]
			public int __Result;
		}

		// Token: 0x0200332B RID: 13099
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __UdsEventPropertyObjectSetUInt32_FunctionParams
		{
			// Token: 0x0401721E RID: 94750
			[FieldOffset(0)]
			public long proPtr;

			// Token: 0x0401721F RID: 94751
			[FieldOffset(8)]
			public FString key;

			// Token: 0x04017220 RID: 94752
			[FieldOffset(24)]
			public int value;

			// Token: 0x04017221 RID: 94753
			[FieldOffset(28)]
			public int __Result;
		}

		// Token: 0x0200332C RID: 13100
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __UdsEventPropertyObjectSetString_FunctionParams
		{
			// Token: 0x04017222 RID: 94754
			[FieldOffset(0)]
			public long proPtr;

			// Token: 0x04017223 RID: 94755
			[FieldOffset(8)]
			public FString key;

			// Token: 0x04017224 RID: 94756
			[FieldOffset(24)]
			public FString value;

			// Token: 0x04017225 RID: 94757
			[FieldOffset(40)]
			public int __Result;
		}

		// Token: 0x0200332D RID: 13101
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __UdsEventPropertyObjectSetInt64_FunctionParams
		{
			// Token: 0x04017226 RID: 94758
			[FieldOffset(0)]
			public long proPtr;

			// Token: 0x04017227 RID: 94759
			[FieldOffset(8)]
			public FString key;

			// Token: 0x04017228 RID: 94760
			[FieldOffset(24)]
			public long value;

			// Token: 0x04017229 RID: 94761
			[FieldOffset(32)]
			public int __Result;
		}

		// Token: 0x0200332E RID: 13102
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __UdsEventPropertyObjectSetInt32_FunctionParams
		{
			// Token: 0x0401722A RID: 94762
			[FieldOffset(0)]
			public long proPtr;

			// Token: 0x0401722B RID: 94763
			[FieldOffset(8)]
			public FString key;

			// Token: 0x0401722C RID: 94764
			[FieldOffset(24)]
			public int value;

			// Token: 0x0401722D RID: 94765
			[FieldOffset(28)]
			public int __Result;
		}

		// Token: 0x0200332F RID: 13103
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __UdsEventPropertyObjectSetFloat64_FunctionParams
		{
			// Token: 0x0401722E RID: 94766
			[FieldOffset(0)]
			public long proPtr;

			// Token: 0x0401722F RID: 94767
			[FieldOffset(8)]
			public FString key;

			// Token: 0x04017230 RID: 94768
			[FieldOffset(24)]
			public double value;

			// Token: 0x04017231 RID: 94769
			[FieldOffset(32)]
			public int __Result;
		}

		// Token: 0x02003330 RID: 13104
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __UdsEventPropertyObjectSetFloat32_FunctionParams
		{
			// Token: 0x04017232 RID: 94770
			[FieldOffset(0)]
			public long proPtr;

			// Token: 0x04017233 RID: 94771
			[FieldOffset(8)]
			public FString key;

			// Token: 0x04017234 RID: 94772
			[FieldOffset(24)]
			public float value;

			// Token: 0x04017235 RID: 94773
			[FieldOffset(28)]
			public int __Result;
		}

		// Token: 0x02003331 RID: 13105
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __UdsEventPropertyObjectSetBool_FunctionParams
		{
			// Token: 0x04017236 RID: 94774
			[FieldOffset(0)]
			public long proPtr;

			// Token: 0x04017237 RID: 94775
			[FieldOffset(8)]
			public FString key;

			// Token: 0x04017238 RID: 94776
			[FieldOffset(24)]
			public bool value;

			// Token: 0x04017239 RID: 94777
			[FieldOffset(28)]
			public int __Result;
		}

		// Token: 0x02003332 RID: 13106
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __UdsEventPropertyArraySetString_FunctionParams
		{
			// Token: 0x0401723A RID: 94778
			[FieldOffset(0)]
			public long proPtr;

			// Token: 0x0401723B RID: 94779
			[FieldOffset(8)]
			public FString key;

			// Token: 0x0401723C RID: 94780
			[FieldOffset(24)]
			public byte value;

			// Token: 0x0401723D RID: 94781
			[FieldOffset(40)]
			public int __Result;
		}

		// Token: 0x02003333 RID: 13107
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __TerminateWebBrowser_FunctionParams
		{
			// Token: 0x0401723E RID: 94782
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02003334 RID: 13108
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ShowPsStoreIcon_FunctionParams
		{
			// Token: 0x0401723F RID: 94783
			[FieldOffset(0)]
			public int position;

			// Token: 0x04017240 RID: 94784
			[FieldOffset(4)]
			public int __Result;
		}

		// Token: 0x02003335 RID: 13109
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetPlayerSessionJoinableUserType_FunctionParams
		{
			// Token: 0x04017241 RID: 94785
			[FieldOffset(0)]
			public int joinableUserType;
		}

		// Token: 0x02003336 RID: 13110
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __SceNpGetNpReachabilityState_FunctionParams
		{
			// Token: 0x04017242 RID: 94786
			[FieldOffset(0)]
			public FString userId;

			// Token: 0x04017243 RID: 94787
			[FieldOffset(16)]
			public int outState;

			// Token: 0x04017244 RID: 94788
			[FieldOffset(20)]
			public int __Result;
		}

		// Token: 0x02003337 RID: 13111
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __RemoveCacheElement_FunctionParams
		{
			// Token: 0x04017245 RID: 94789
			[FieldOffset(0)]
			public FString key;
		}

		// Token: 0x02003338 RID: 13112
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __RegisterUdsContext_FunctionParams
		{
			// Token: 0x04017246 RID: 94790
			[FieldOffset(0)]
			public int context;

			// Token: 0x04017247 RID: 94791
			[FieldOffset(4)]
			public int handle;

			// Token: 0x04017248 RID: 94792
			[FieldOffset(8)]
			public int __Result;
		}

		// Token: 0x02003339 RID: 13113
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __RegisterTrophyContextAsync_FunctionParams
		{
			// Token: 0x04017249 RID: 94793
			[FieldOffset(0)]
			public int context;

			// Token: 0x0401724A RID: 94794
			[FieldOffset(4)]
			public int handle;

			// Token: 0x0401724B RID: 94795
			[FieldOffset(8)]
			public FString optionsLong;

			// Token: 0x0401724C RID: 94796
			[FieldOffset(24)]
			public byte callback;
		}

		// Token: 0x0200333A RID: 13114
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __PostUdsEvent_FunctionParams
		{
			// Token: 0x0401724D RID: 94797
			[FieldOffset(0)]
			public int context;

			// Token: 0x0401724E RID: 94798
			[FieldOffset(4)]
			public int handle;

			// Token: 0x0401724F RID: 94799
			[FieldOffset(8)]
			public long eventPtr;

			// Token: 0x04017250 RID: 94800
			[FieldOffset(16)]
			public int __Result;
		}

		// Token: 0x0200333B RID: 13115
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __PollWebBrowser_FunctionParams
		{
			// Token: 0x04017251 RID: 94801
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x0200333C RID: 13116
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __PollCheckoutDialogResult_FunctionParams
		{
			// Token: 0x04017252 RID: 94802
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x0200333D RID: 13117
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __OpenWebView_FunctionParams
		{
			// Token: 0x04017253 RID: 94803
			[FieldOffset(0)]
			public FString Url;

			// Token: 0x04017254 RID: 94804
			[FieldOffset(16)]
			public int __Result;
		}

		// Token: 0x0200333E RID: 13118
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OpenWebBrowser_FunctionParams
		{
			// Token: 0x04017255 RID: 94805
			[FieldOffset(0)]
			public FString Url;
		}

		// Token: 0x0200333F RID: 13119
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __OpenMessageDialog_FunctionParams
		{
			// Token: 0x04017256 RID: 94806
			[FieldOffset(0)]
			public FString userId;

			// Token: 0x04017257 RID: 94807
			[FieldOffset(16)]
			public int openMode;

			// Token: 0x04017258 RID: 94808
			[FieldOffset(20)]
			public int msgType;

			// Token: 0x04017259 RID: 94809
			[FieldOffset(24)]
			public byte callback;
		}

		// Token: 0x02003340 RID: 13120
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __OpenCheckoutDialog_FunctionParams
		{
			// Token: 0x0401725A RID: 94810
			[FieldOffset(0)]
			public FString ProductLabel;

			// Token: 0x0401725B RID: 94811
			[FieldOffset(16)]
			public int __Result;
		}

		// Token: 0x02003341 RID: 13121
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __NotifyPremiumFeature_FunctionParams
		{
			// Token: 0x0401725C RID: 94812
			[FieldOffset(0)]
			public FString userId;

			// Token: 0x0401725D RID: 94813
			[FieldOffset(16)]
			public bool isPlayStationOnly;
		}

		// Token: 0x02003342 RID: 13122
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __NotifyPremium_FunctionParams
		{
			// Token: 0x0401725E RID: 94814
			[FieldOffset(0)]
			public FString userId;
		}

		// Token: 0x02003343 RID: 13123
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __JoinPlayerSession_FunctionParams
		{
			// Token: 0x0401725F RID: 94815
			[FieldOffset(0)]
			public FString playerSessionId;
		}

		// Token: 0x02003344 RID: 13124
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __InitWebApi_FunctionParams
		{
			// Token: 0x04017260 RID: 94816
			[FieldOffset(0)]
			public FString userId;

			// Token: 0x04017261 RID: 94817
			[FieldOffset(16)]
			public int __Result;
		}

		// Token: 0x02003345 RID: 13125
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __InitNpUniversalDataSystem_FunctionParams
		{
			// Token: 0x04017262 RID: 94818
			[FieldOffset(0)]
			public int poolSize;

			// Token: 0x04017263 RID: 94819
			[FieldOffset(4)]
			public int __Result;
		}

		// Token: 0x02003346 RID: 13126
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __HidePsStoreIcon_FunctionParams
		{
			// Token: 0x04017264 RID: 94820
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02003347 RID: 13127
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetUserIdByAccountId_FunctionParams
		{
			// Token: 0x04017265 RID: 94821
			[FieldOffset(0)]
			public FString accountId;

			// Token: 0x04017266 RID: 94822
			[FieldOffset(16)]
			public FString __Result;
		}

		// Token: 0x02003348 RID: 13128
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetUserId_FunctionParams
		{
			// Token: 0x04017267 RID: 94823
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x02003349 RID: 13129
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __GetTrophyListWithContextIdAndHandleIdAsync_FunctionParams
		{
			// Token: 0x04017268 RID: 94824
			[FieldOffset(0)]
			public int inputOffset;

			// Token: 0x04017269 RID: 94825
			[FieldOffset(4)]
			public int length;

			// Token: 0x0401726A RID: 94826
			[FieldOffset(8)]
			public int context;

			// Token: 0x0401726B RID: 94827
			[FieldOffset(12)]
			public int handle;

			// Token: 0x0401726C RID: 94828
			[FieldOffset(16)]
			public byte callback;
		}

		// Token: 0x0200334A RID: 13130
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __GetTrophyListWithContextIdAndHandleId_FunctionParams
		{
			// Token: 0x0401726D RID: 94829
			[FieldOffset(0)]
			public int context;

			// Token: 0x0401726E RID: 94830
			[FieldOffset(4)]
			public int handle;

			// Token: 0x0401726F RID: 94831
			[FieldOffset(8)]
			public int inputOffset;

			// Token: 0x04017270 RID: 94832
			[FieldOffset(12)]
			public int length;

			// Token: 0x04017271 RID: 94833
			[FieldOffset(16)]
			public byte __Result;
		}

		// Token: 0x0200334B RID: 13131
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __GetTrophyList_FunctionParams
		{
			// Token: 0x04017272 RID: 94834
			[FieldOffset(0)]
			public FString userId;

			// Token: 0x04017273 RID: 94835
			[FieldOffset(16)]
			public int inputOffset;

			// Token: 0x04017274 RID: 94836
			[FieldOffset(20)]
			public int length;

			// Token: 0x04017275 RID: 94837
			[FieldOffset(24)]
			public byte __Result;
		}

		// Token: 0x0200334C RID: 13132
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetStoreProductsWithParams_FunctionParams
		{
			// Token: 0x04017276 RID: 94838
			[FieldOffset(0)]
			public int ServiceLabel;

			// Token: 0x04017277 RID: 94839
			[FieldOffset(4)]
			public int Offset;

			// Token: 0x04017278 RID: 94840
			[FieldOffset(8)]
			public int Limit;

			// Token: 0x04017279 RID: 94841
			[FieldOffset(16)]
			public byte __Result;
		}

		// Token: 0x0200334D RID: 13133
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetStoreProducts_FunctionParams
		{
			// Token: 0x0401727A RID: 94842
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200334E RID: 13134
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetPlayerIdByPlayerSessionId_FunctionParams
		{
			// Token: 0x0401727B RID: 94843
			[FieldOffset(0)]
			public FString playerSessionId;

			// Token: 0x0401727C RID: 94844
			[FieldOffset(16)]
			public FString __Result;
		}

		// Token: 0x0200334F RID: 13135
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetOnlineIdByUserId_FunctionParams
		{
			// Token: 0x0401727D RID: 94845
			[FieldOffset(0)]
			public FString userId;

			// Token: 0x0401727E RID: 94846
			[FieldOffset(16)]
			public FString __Result;
		}

		// Token: 0x02003350 RID: 13136
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __GetMessageDialogStateAsync_FunctionParams
		{
			// Token: 0x0401727F RID: 94847
			[FieldOffset(0)]
			public byte callback;
		}

		// Token: 0x02003351 RID: 13137
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __GetIdToken_FunctionParams
		{
			// Token: 0x04017280 RID: 94848
			[FieldOffset(0)]
			public FString ClientId;

			// Token: 0x04017281 RID: 94849
			[FieldOffset(16)]
			public FString ClientSecret;

			// Token: 0x04017282 RID: 94850
			[FieldOffset(32)]
			public FString Scope;

			// Token: 0x04017283 RID: 94851
			[FieldOffset(48)]
			public FString IdToken;

			// Token: 0x04017284 RID: 94852
			[FieldOffset(64)]
			public int __Result;
		}

		// Token: 0x02003352 RID: 13138
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetCountryCodeByUserId_FunctionParams
		{
			// Token: 0x04017285 RID: 94853
			[FieldOffset(0)]
			public FString userId;

			// Token: 0x04017286 RID: 94854
			[FieldOffset(16)]
			public FString __Result;
		}

		// Token: 0x02003353 RID: 13139
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __GetCommunicationRestrictionStatusAsync_FunctionParams
		{
			// Token: 0x04017287 RID: 94855
			[FieldOffset(0)]
			public FString accountId;

			// Token: 0x04017288 RID: 94856
			[FieldOffset(16)]
			public byte callback;
		}

		// Token: 0x02003354 RID: 13140
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetCacheMapElement_FunctionParams
		{
			// Token: 0x04017289 RID: 94857
			[FieldOffset(0)]
			public FString key;

			// Token: 0x0401728A RID: 94858
			[FieldOffset(16)]
			public FString __Result;
		}

		// Token: 0x02003355 RID: 13141
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __GetBlockUserListAsync_FunctionParams
		{
			// Token: 0x0401728B RID: 94859
			[FieldOffset(0)]
			public int offset;

			// Token: 0x0401728C RID: 94860
			[FieldOffset(4)]
			public int limit;

			// Token: 0x0401728D RID: 94861
			[FieldOffset(8)]
			public byte Delegate;
		}

		// Token: 0x02003356 RID: 13142
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetBlockUserList_FunctionParams
		{
			// Token: 0x0401728E RID: 94862
			[FieldOffset(0)]
			public int offset;

			// Token: 0x0401728F RID: 94863
			[FieldOffset(4)]
			public int limit;

			// Token: 0x04017290 RID: 94864
			[FieldOffset(8)]
			public byte __Result;
		}

		// Token: 0x02003357 RID: 13143
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetBasicPresence_FunctionParams
		{
			// Token: 0x04017291 RID: 94865
			[FieldOffset(0)]
			public FString accountId;

			// Token: 0x04017292 RID: 94866
			[FieldOffset(16)]
			public byte __Result;
		}

		// Token: 0x02003358 RID: 13144
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __GetAuthCode_FunctionParams
		{
			// Token: 0x04017293 RID: 94867
			[FieldOffset(0)]
			public FString ClientId;

			// Token: 0x04017294 RID: 94868
			[FieldOffset(16)]
			public FString Scope;

			// Token: 0x04017295 RID: 94869
			[FieldOffset(32)]
			public FString AuthCode;

			// Token: 0x04017296 RID: 94870
			[FieldOffset(48)]
			public int IssuerId;

			// Token: 0x04017297 RID: 94871
			[FieldOffset(52)]
			public int __Result;
		}

		// Token: 0x02003359 RID: 13145
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetAccountIdByUserId_FunctionParams
		{
			// Token: 0x04017298 RID: 94872
			[FieldOffset(0)]
			public FString userId;

			// Token: 0x04017299 RID: 94873
			[FieldOffset(16)]
			public FString __Result;
		}

		// Token: 0x0200335A RID: 13146
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __DestroyUdsHandle_FunctionParams
		{
			// Token: 0x0401729A RID: 94874
			[FieldOffset(0)]
			public int handle;

			// Token: 0x0401729B RID: 94875
			[FieldOffset(4)]
			public int __Result;
		}

		// Token: 0x0200335B RID: 13147
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __DestroyUdsEvent_FunctionParams
		{
			// Token: 0x0401729C RID: 94876
			[FieldOffset(0)]
			public long eventPtr;

			// Token: 0x0401729D RID: 94877
			[FieldOffset(8)]
			public int __Result;
		}

		// Token: 0x0200335C RID: 13148
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __DestroyUdsContext_FunctionParams
		{
			// Token: 0x0401729E RID: 94878
			[FieldOffset(0)]
			public int context;

			// Token: 0x0401729F RID: 94879
			[FieldOffset(4)]
			public int __Result;
		}

		// Token: 0x0200335D RID: 13149
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __DestroyTrophyHandleAsync_FunctionParams
		{
			// Token: 0x040172A0 RID: 94880
			[FieldOffset(0)]
			public int handle;

			// Token: 0x040172A1 RID: 94881
			[FieldOffset(8)]
			public byte callback;
		}

		// Token: 0x0200335E RID: 13150
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __DestroyTrophyContextAsync_FunctionParams
		{
			// Token: 0x040172A2 RID: 94882
			[FieldOffset(0)]
			public int context;

			// Token: 0x040172A3 RID: 94883
			[FieldOffset(8)]
			public byte callback;
		}

		// Token: 0x0200335F RID: 13151
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __CreateUdsHandle_FunctionParams
		{
			// Token: 0x040172A4 RID: 94884
			[FieldOffset(0)]
			public int handle;

			// Token: 0x040172A5 RID: 94885
			[FieldOffset(4)]
			public int __Result;
		}

		// Token: 0x02003360 RID: 13152
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __CreateUdsEvent_FunctionParams
		{
			// Token: 0x040172A6 RID: 94886
			[FieldOffset(0)]
			public FString eventName;

			// Token: 0x040172A7 RID: 94887
			[FieldOffset(16)]
			public long outEventPtr;

			// Token: 0x040172A8 RID: 94888
			[FieldOffset(24)]
			public long outProPtr;

			// Token: 0x040172A9 RID: 94889
			[FieldOffset(32)]
			public int __Result;
		}

		// Token: 0x02003361 RID: 13153
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __CreateUdsContext_FunctionParams
		{
			// Token: 0x040172AA RID: 94890
			[FieldOffset(0)]
			public FString userId;

			// Token: 0x040172AB RID: 94891
			[FieldOffset(16)]
			public int context;

			// Token: 0x040172AC RID: 94892
			[FieldOffset(20)]
			public int __Result;
		}

		// Token: 0x02003362 RID: 13154
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __CreateTrophyHandleAsync_FunctionParams
		{
			// Token: 0x040172AD RID: 94893
			[FieldOffset(0)]
			public byte callback;
		}

		// Token: 0x02003363 RID: 13155
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __CreateTrophyContextAsync_FunctionParams
		{
			// Token: 0x040172AE RID: 94894
			[FieldOffset(0)]
			public FString userId;

			// Token: 0x040172AF RID: 94895
			[FieldOffset(16)]
			public int serviceLabel;

			// Token: 0x040172B0 RID: 94896
			[FieldOffset(24)]
			public FString optionsLong;

			// Token: 0x040172B1 RID: 94897
			[FieldOffset(40)]
			public byte callback;
		}

		// Token: 0x02003364 RID: 13156
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __CreatePlayerSession_FunctionParams
		{
			// Token: 0x040172B2 RID: 94898
			[FieldOffset(0)]
			public int joinableUserType;

			// Token: 0x040172B3 RID: 94899
			[FieldOffset(8)]
			public FString playerId;

			// Token: 0x040172B4 RID: 94900
			[FieldOffset(24)]
			public FString __Result;
		}

		// Token: 0x02003365 RID: 13157
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __CloseWebBrowser_FunctionParams
		{
			// Token: 0x040172B5 RID: 94901
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02003366 RID: 13158
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __CheckUserPremium_FunctionParams
		{
			// Token: 0x040172B6 RID: 94902
			[FieldOffset(0)]
			public FString userId;

			// Token: 0x040172B7 RID: 94903
			[FieldOffset(16)]
			public int __Result;
		}

		// Token: 0x02003367 RID: 13159
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __CheckJoinSession_FunctionParams
		{
			// Token: 0x040172B8 RID: 94904
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x02003368 RID: 13160
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __AddJoinSessionDelegate_FunctionParams
		{
			// Token: 0x040172B9 RID: 94905
			[FieldOffset(0)]
			public byte InDelegate;
		}

		// Token: 0x02003369 RID: 13161
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __AddCacheMapElement_FunctionParams
		{
			// Token: 0x040172BA RID: 94906
			[FieldOffset(0)]
			public FString key;

			// Token: 0x040172BB RID: 94907
			[FieldOffset(16)]
			public FString value;
		}

		// Token: 0x0200336A RID: 13162
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __AbortUdsHandle_FunctionParams
		{
			// Token: 0x040172BC RID: 94908
			[FieldOffset(0)]
			public int handle;

			// Token: 0x040172BD RID: 94909
			[FieldOffset(4)]
			public int __Result;
		}

		// Token: 0x0200336B RID: 13163
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __AbortTrophyHandleAsync_FunctionParams
		{
			// Token: 0x040172BE RID: 94910
			[FieldOffset(0)]
			public int handle;

			// Token: 0x040172BF RID: 94911
			[FieldOffset(8)]
			public byte callback;
		}
	}
}
