using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002A5 RID: 677
	[UnrealObjectPath("/Script/AnalyticsBlueprintLibrary.AnalyticsBlueprintLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UAnalyticsBlueprintLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002553 RID: 9555 RVA: 0x00037CA3 File Offset: 0x00035EA3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnalyticsBlueprintLibrary._ClassPtr;
		}

		// Token: 0x06002554 RID: 9556 RVA: 0x00037CB0 File Offset: 0x00035EB0
		public UAnalyticsBlueprintLibrary() : this(BuiltinUtils.AllocNativeUObject(UAnalyticsBlueprintLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002555 RID: 9557 RVA: 0x00037CD8 File Offset: 0x00035ED8
		[NullableContext(1)]
		public UAnalyticsBlueprintLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnalyticsBlueprintLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06002556 RID: 9558 RVA: 0x00037D0C File Offset: 0x00035F0C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool StartSessionWithAttributes([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FAnalyticsEventAttr> Attributes)
		{
			UAnalyticsBlueprintLibrary.__StartSessionWithAttributes_FunctionParams* ptr = stackalloc UAnalyticsBlueprintLibrary.__StartSessionWithAttributes_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UAnalyticsBlueprintLibrary.__StartSessionWithAttributes_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAnalyticsBlueprintLibrary.__StartSessionWithAttributes_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FAnalyticsEventAttr> tarray = Attributes;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Attributes);
			}
			UnrealReflectionUtils.CallUFunction(UAnalyticsBlueprintLibrary._ClassDefaultObjectPtr, UAnalyticsBlueprintLibrary.__StartSessionWithAttributes_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FAnalyticsEventAttr> tarray2 = Attributes;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Attributes);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UAnalyticsBlueprintLibrary.__StartSessionWithAttributes_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06002557 RID: 9559 RVA: 0x00037D8C File Offset: 0x00035F8C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool StartSession()
		{
			UAnalyticsBlueprintLibrary.__StartSession_FunctionParams* ptr = stackalloc UAnalyticsBlueprintLibrary.__StartSession_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UAnalyticsBlueprintLibrary.__StartSession_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAnalyticsBlueprintLibrary.__StartSession_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UAnalyticsBlueprintLibrary._ClassDefaultObjectPtr, UAnalyticsBlueprintLibrary.__StartSession_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06002558 RID: 9560 RVA: 0x00037DD4 File Offset: 0x00035FD4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetUserId(string UserId)
		{
			UAnalyticsBlueprintLibrary.__SetUserId_FunctionParams* ptr = stackalloc UAnalyticsBlueprintLibrary.__SetUserId_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UAnalyticsBlueprintLibrary.__SetUserId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAnalyticsBlueprintLibrary.__SetUserId_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->UserId), UserId);
			UnrealReflectionUtils.CallUFunction(UAnalyticsBlueprintLibrary._ClassDefaultObjectPtr, UAnalyticsBlueprintLibrary.__SetUserId_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UAnalyticsBlueprintLibrary.__SetUserId_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06002559 RID: 9561 RVA: 0x00037E34 File Offset: 0x00036034
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetSessionId(string SessionId)
		{
			UAnalyticsBlueprintLibrary.__SetSessionId_FunctionParams* ptr = stackalloc UAnalyticsBlueprintLibrary.__SetSessionId_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UAnalyticsBlueprintLibrary.__SetSessionId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAnalyticsBlueprintLibrary.__SetSessionId_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->SessionId), SessionId);
			UnrealReflectionUtils.CallUFunction(UAnalyticsBlueprintLibrary._ClassDefaultObjectPtr, UAnalyticsBlueprintLibrary.__SetSessionId_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UAnalyticsBlueprintLibrary.__SetSessionId_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600255A RID: 9562 RVA: 0x00037E94 File Offset: 0x00036094
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetLocation(string Location)
		{
			UAnalyticsBlueprintLibrary.__SetLocation_FunctionParams* ptr = stackalloc UAnalyticsBlueprintLibrary.__SetLocation_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UAnalyticsBlueprintLibrary.__SetLocation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAnalyticsBlueprintLibrary.__SetLocation_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Location), Location);
			UnrealReflectionUtils.CallUFunction(UAnalyticsBlueprintLibrary._ClassDefaultObjectPtr, UAnalyticsBlueprintLibrary.__SetLocation_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UAnalyticsBlueprintLibrary.__SetLocation_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600255B RID: 9563 RVA: 0x00037EF4 File Offset: 0x000360F4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetGender(string Gender)
		{
			UAnalyticsBlueprintLibrary.__SetGender_FunctionParams* ptr = stackalloc UAnalyticsBlueprintLibrary.__SetGender_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UAnalyticsBlueprintLibrary.__SetGender_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAnalyticsBlueprintLibrary.__SetGender_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Gender), Gender);
			UnrealReflectionUtils.CallUFunction(UAnalyticsBlueprintLibrary._ClassDefaultObjectPtr, UAnalyticsBlueprintLibrary.__SetGender_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UAnalyticsBlueprintLibrary.__SetGender_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600255C RID: 9564 RVA: 0x00037F54 File Offset: 0x00036154
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetBuildInfo(string BuildInfo)
		{
			UAnalyticsBlueprintLibrary.__SetBuildInfo_FunctionParams* ptr = stackalloc UAnalyticsBlueprintLibrary.__SetBuildInfo_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UAnalyticsBlueprintLibrary.__SetBuildInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAnalyticsBlueprintLibrary.__SetBuildInfo_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->BuildInfo), BuildInfo);
			UnrealReflectionUtils.CallUFunction(UAnalyticsBlueprintLibrary._ClassDefaultObjectPtr, UAnalyticsBlueprintLibrary.__SetBuildInfo_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UAnalyticsBlueprintLibrary.__SetBuildInfo_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600255D RID: 9565 RVA: 0x00037FB4 File Offset: 0x000361B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetAge(int Age)
		{
			UAnalyticsBlueprintLibrary.__SetAge_FunctionParams* ptr = stackalloc UAnalyticsBlueprintLibrary.__SetAge_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UAnalyticsBlueprintLibrary.__SetAge_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAnalyticsBlueprintLibrary.__SetAge_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Age = Age;
			UnrealReflectionUtils.CallUFunction(UAnalyticsBlueprintLibrary._ClassDefaultObjectPtr, UAnalyticsBlueprintLibrary.__SetAge_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0600255E RID: 9566 RVA: 0x00037FFC File Offset: 0x000361FC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void RecordSimpleItemPurchaseWithAttributes(string ItemId, int ItemQuantity, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FAnalyticsEventAttr> Attributes)
		{
			UAnalyticsBlueprintLibrary.__RecordSimpleItemPurchaseWithAttributes_FunctionParams* ptr = stackalloc UAnalyticsBlueprintLibrary.__RecordSimpleItemPurchaseWithAttributes_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UAnalyticsBlueprintLibrary.__RecordSimpleItemPurchaseWithAttributes_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAnalyticsBlueprintLibrary.__RecordSimpleItemPurchaseWithAttributes_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->ItemId), ItemId);
			ptr->ItemQuantity = ItemQuantity;
			TArray<FAnalyticsEventAttr> tarray = Attributes;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Attributes);
			}
			UnrealReflectionUtils.CallUFunction(UAnalyticsBlueprintLibrary._ClassDefaultObjectPtr, UAnalyticsBlueprintLibrary.__RecordSimpleItemPurchaseWithAttributes_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FAnalyticsEventAttr> tarray2 = Attributes;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Attributes);
			}
			UnrealReflectionUtils.DestroyStruct(UAnalyticsBlueprintLibrary.__RecordSimpleItemPurchaseWithAttributes_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600255F RID: 9567 RVA: 0x00038088 File Offset: 0x00036288
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void RecordSimpleItemPurchase(string ItemId, int ItemQuantity)
		{
			UAnalyticsBlueprintLibrary.__RecordSimpleItemPurchase_FunctionParams* ptr = stackalloc UAnalyticsBlueprintLibrary.__RecordSimpleItemPurchase_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UAnalyticsBlueprintLibrary.__RecordSimpleItemPurchase_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAnalyticsBlueprintLibrary.__RecordSimpleItemPurchase_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->ItemId), ItemId);
			ptr->ItemQuantity = ItemQuantity;
			UnrealReflectionUtils.CallUFunction(UAnalyticsBlueprintLibrary._ClassDefaultObjectPtr, UAnalyticsBlueprintLibrary.__RecordSimpleItemPurchase_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UAnalyticsBlueprintLibrary.__RecordSimpleItemPurchase_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06002560 RID: 9568 RVA: 0x000380EC File Offset: 0x000362EC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void RecordSimpleCurrencyPurchaseWithAttributes(string GameCurrencyType, int GameCurrencyAmount, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FAnalyticsEventAttr> Attributes)
		{
			UAnalyticsBlueprintLibrary.__RecordSimpleCurrencyPurchaseWithAttributes_FunctionParams* ptr = stackalloc UAnalyticsBlueprintLibrary.__RecordSimpleCurrencyPurchaseWithAttributes_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UAnalyticsBlueprintLibrary.__RecordSimpleCurrencyPurchaseWithAttributes_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAnalyticsBlueprintLibrary.__RecordSimpleCurrencyPurchaseWithAttributes_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->GameCurrencyType), GameCurrencyType);
			ptr->GameCurrencyAmount = GameCurrencyAmount;
			TArray<FAnalyticsEventAttr> tarray = Attributes;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Attributes);
			}
			UnrealReflectionUtils.CallUFunction(UAnalyticsBlueprintLibrary._ClassDefaultObjectPtr, UAnalyticsBlueprintLibrary.__RecordSimpleCurrencyPurchaseWithAttributes_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FAnalyticsEventAttr> tarray2 = Attributes;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Attributes);
			}
			UnrealReflectionUtils.DestroyStruct(UAnalyticsBlueprintLibrary.__RecordSimpleCurrencyPurchaseWithAttributes_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06002561 RID: 9569 RVA: 0x00038178 File Offset: 0x00036378
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void RecordSimpleCurrencyPurchase(string GameCurrencyType, int GameCurrencyAmount)
		{
			UAnalyticsBlueprintLibrary.__RecordSimpleCurrencyPurchase_FunctionParams* ptr = stackalloc UAnalyticsBlueprintLibrary.__RecordSimpleCurrencyPurchase_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UAnalyticsBlueprintLibrary.__RecordSimpleCurrencyPurchase_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAnalyticsBlueprintLibrary.__RecordSimpleCurrencyPurchase_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->GameCurrencyType), GameCurrencyType);
			ptr->GameCurrencyAmount = GameCurrencyAmount;
			UnrealReflectionUtils.CallUFunction(UAnalyticsBlueprintLibrary._ClassDefaultObjectPtr, UAnalyticsBlueprintLibrary.__RecordSimpleCurrencyPurchase_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UAnalyticsBlueprintLibrary.__RecordSimpleCurrencyPurchase_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06002562 RID: 9570 RVA: 0x000381DC File Offset: 0x000363DC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void RecordProgressWithFullHierarchyAndAttributes(string ProgressType, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> ProgressNames, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FAnalyticsEventAttr> Attributes)
		{
			UAnalyticsBlueprintLibrary.__RecordProgressWithFullHierarchyAndAttributes_FunctionParams* ptr = stackalloc UAnalyticsBlueprintLibrary.__RecordProgressWithFullHierarchyAndAttributes_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UAnalyticsBlueprintLibrary.__RecordProgressWithFullHierarchyAndAttributes_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAnalyticsBlueprintLibrary.__RecordProgressWithFullHierarchyAndAttributes_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->ProgressType), ProgressType);
			TArray<string> tarray = ProgressNames;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->ProgressNames);
			}
			TArray<FAnalyticsEventAttr> tarray2 = Attributes;
			if (tarray2 != null)
			{
				tarray2.MoveTo(&ptr->Attributes);
			}
			UnrealReflectionUtils.CallUFunction(UAnalyticsBlueprintLibrary._ClassDefaultObjectPtr, UAnalyticsBlueprintLibrary.__RecordProgressWithFullHierarchyAndAttributes_NativeFunctionPtr, (void*)ptr, 0);
			TArray<string> tarray3 = ProgressNames;
			if (tarray3 != null)
			{
				tarray3.MoveAssign(&ptr->ProgressNames);
			}
			TArray<FAnalyticsEventAttr> tarray4 = Attributes;
			if (tarray4 != null)
			{
				tarray4.MoveAssign(&ptr->Attributes);
			}
			UnrealReflectionUtils.DestroyStruct(UAnalyticsBlueprintLibrary.__RecordProgressWithFullHierarchyAndAttributes_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06002563 RID: 9571 RVA: 0x0003828C File Offset: 0x0003648C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void RecordProgressWithAttributes(string ProgressType, string ProgressName, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FAnalyticsEventAttr> Attributes)
		{
			UAnalyticsBlueprintLibrary.__RecordProgressWithAttributes_FunctionParams* ptr = stackalloc UAnalyticsBlueprintLibrary.__RecordProgressWithAttributes_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UAnalyticsBlueprintLibrary.__RecordProgressWithAttributes_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAnalyticsBlueprintLibrary.__RecordProgressWithAttributes_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->ProgressType), ProgressType);
			FString.CopyFrom((void*)(&ptr->ProgressName), ProgressName);
			TArray<FAnalyticsEventAttr> tarray = Attributes;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Attributes);
			}
			UnrealReflectionUtils.CallUFunction(UAnalyticsBlueprintLibrary._ClassDefaultObjectPtr, UAnalyticsBlueprintLibrary.__RecordProgressWithAttributes_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FAnalyticsEventAttr> tarray2 = Attributes;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Attributes);
			}
			UnrealReflectionUtils.DestroyStruct(UAnalyticsBlueprintLibrary.__RecordProgressWithAttributes_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06002564 RID: 9572 RVA: 0x00038320 File Offset: 0x00036520
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void RecordProgress(string ProgressType, string ProgressName)
		{
			UAnalyticsBlueprintLibrary.__RecordProgress_FunctionParams* ptr = stackalloc UAnalyticsBlueprintLibrary.__RecordProgress_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UAnalyticsBlueprintLibrary.__RecordProgress_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAnalyticsBlueprintLibrary.__RecordProgress_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->ProgressType), ProgressType);
			FString.CopyFrom((void*)(&ptr->ProgressName), ProgressName);
			UnrealReflectionUtils.CallUFunction(UAnalyticsBlueprintLibrary._ClassDefaultObjectPtr, UAnalyticsBlueprintLibrary.__RecordProgress_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UAnalyticsBlueprintLibrary.__RecordProgress_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06002565 RID: 9573 RVA: 0x0003838C File Offset: 0x0003658C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void RecordItemPurchase(string ItemId, string Currency, int PerItemCost, int ItemQuantity)
		{
			UAnalyticsBlueprintLibrary.__RecordItemPurchase_FunctionParams* ptr = stackalloc UAnalyticsBlueprintLibrary.__RecordItemPurchase_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UAnalyticsBlueprintLibrary.__RecordItemPurchase_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAnalyticsBlueprintLibrary.__RecordItemPurchase_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->ItemId), ItemId);
			FString.CopyFrom((void*)(&ptr->Currency), Currency);
			ptr->PerItemCost = PerItemCost;
			ptr->ItemQuantity = ItemQuantity;
			UnrealReflectionUtils.CallUFunction(UAnalyticsBlueprintLibrary._ClassDefaultObjectPtr, UAnalyticsBlueprintLibrary.__RecordItemPurchase_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UAnalyticsBlueprintLibrary.__RecordItemPurchase_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06002566 RID: 9574 RVA: 0x00038404 File Offset: 0x00036604
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void RecordEventWithAttributes(string EventName, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FAnalyticsEventAttr> Attributes)
		{
			UAnalyticsBlueprintLibrary.__RecordEventWithAttributes_FunctionParams* ptr = stackalloc UAnalyticsBlueprintLibrary.__RecordEventWithAttributes_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UAnalyticsBlueprintLibrary.__RecordEventWithAttributes_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAnalyticsBlueprintLibrary.__RecordEventWithAttributes_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->EventName), EventName);
			TArray<FAnalyticsEventAttr> tarray = Attributes;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Attributes);
			}
			UnrealReflectionUtils.CallUFunction(UAnalyticsBlueprintLibrary._ClassDefaultObjectPtr, UAnalyticsBlueprintLibrary.__RecordEventWithAttributes_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FAnalyticsEventAttr> tarray2 = Attributes;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Attributes);
			}
			UnrealReflectionUtils.DestroyStruct(UAnalyticsBlueprintLibrary.__RecordEventWithAttributes_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06002567 RID: 9575 RVA: 0x0003848C File Offset: 0x0003668C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void RecordEventWithAttribute(string EventName, string AttributeName, string AttributeValue)
		{
			UAnalyticsBlueprintLibrary.__RecordEventWithAttribute_FunctionParams* ptr = stackalloc UAnalyticsBlueprintLibrary.__RecordEventWithAttribute_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UAnalyticsBlueprintLibrary.__RecordEventWithAttribute_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAnalyticsBlueprintLibrary.__RecordEventWithAttribute_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->EventName), EventName);
			FString.CopyFrom((void*)(&ptr->AttributeName), AttributeName);
			FString.CopyFrom((void*)(&ptr->AttributeValue), AttributeValue);
			UnrealReflectionUtils.CallUFunction(UAnalyticsBlueprintLibrary._ClassDefaultObjectPtr, UAnalyticsBlueprintLibrary.__RecordEventWithAttribute_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UAnalyticsBlueprintLibrary.__RecordEventWithAttribute_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06002568 RID: 9576 RVA: 0x00038504 File Offset: 0x00036704
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void RecordEvent(string EventName)
		{
			UAnalyticsBlueprintLibrary.__RecordEvent_FunctionParams* ptr = stackalloc UAnalyticsBlueprintLibrary.__RecordEvent_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UAnalyticsBlueprintLibrary.__RecordEvent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAnalyticsBlueprintLibrary.__RecordEvent_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->EventName), EventName);
			UnrealReflectionUtils.CallUFunction(UAnalyticsBlueprintLibrary._ClassDefaultObjectPtr, UAnalyticsBlueprintLibrary.__RecordEvent_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UAnalyticsBlueprintLibrary.__RecordEvent_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06002569 RID: 9577 RVA: 0x00038564 File Offset: 0x00036764
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void RecordErrorWithAttributes(string Error, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FAnalyticsEventAttr> Attributes)
		{
			UAnalyticsBlueprintLibrary.__RecordErrorWithAttributes_FunctionParams* ptr = stackalloc UAnalyticsBlueprintLibrary.__RecordErrorWithAttributes_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UAnalyticsBlueprintLibrary.__RecordErrorWithAttributes_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAnalyticsBlueprintLibrary.__RecordErrorWithAttributes_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Error), Error);
			TArray<FAnalyticsEventAttr> tarray = Attributes;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Attributes);
			}
			UnrealReflectionUtils.CallUFunction(UAnalyticsBlueprintLibrary._ClassDefaultObjectPtr, UAnalyticsBlueprintLibrary.__RecordErrorWithAttributes_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FAnalyticsEventAttr> tarray2 = Attributes;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Attributes);
			}
			UnrealReflectionUtils.DestroyStruct(UAnalyticsBlueprintLibrary.__RecordErrorWithAttributes_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600256A RID: 9578 RVA: 0x000385EC File Offset: 0x000367EC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void RecordError(string Error)
		{
			UAnalyticsBlueprintLibrary.__RecordError_FunctionParams* ptr = stackalloc UAnalyticsBlueprintLibrary.__RecordError_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UAnalyticsBlueprintLibrary.__RecordError_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAnalyticsBlueprintLibrary.__RecordError_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Error), Error);
			UnrealReflectionUtils.CallUFunction(UAnalyticsBlueprintLibrary._ClassDefaultObjectPtr, UAnalyticsBlueprintLibrary.__RecordError_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UAnalyticsBlueprintLibrary.__RecordError_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600256B RID: 9579 RVA: 0x0003864C File Offset: 0x0003684C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void RecordCurrencyPurchase(string GameCurrencyType, int GameCurrencyAmount, string RealCurrencyType, float RealMoneyCost, string PaymentProvider)
		{
			UAnalyticsBlueprintLibrary.__RecordCurrencyPurchase_FunctionParams* ptr = stackalloc UAnalyticsBlueprintLibrary.__RecordCurrencyPurchase_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(UAnalyticsBlueprintLibrary.__RecordCurrencyPurchase_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAnalyticsBlueprintLibrary.__RecordCurrencyPurchase_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->GameCurrencyType), GameCurrencyType);
			ptr->GameCurrencyAmount = GameCurrencyAmount;
			FString.CopyFrom((void*)(&ptr->RealCurrencyType), RealCurrencyType);
			ptr->RealMoneyCost = RealMoneyCost;
			FString.CopyFrom((void*)(&ptr->PaymentProvider), PaymentProvider);
			UnrealReflectionUtils.CallUFunction(UAnalyticsBlueprintLibrary._ClassDefaultObjectPtr, UAnalyticsBlueprintLibrary.__RecordCurrencyPurchase_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UAnalyticsBlueprintLibrary.__RecordCurrencyPurchase_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600256C RID: 9580 RVA: 0x000386D4 File Offset: 0x000368D4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void RecordCurrencyGivenWithAttributes(string GameCurrencyType, int GameCurrencyAmount, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FAnalyticsEventAttr> Attributes)
		{
			UAnalyticsBlueprintLibrary.__RecordCurrencyGivenWithAttributes_FunctionParams* ptr = stackalloc UAnalyticsBlueprintLibrary.__RecordCurrencyGivenWithAttributes_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UAnalyticsBlueprintLibrary.__RecordCurrencyGivenWithAttributes_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAnalyticsBlueprintLibrary.__RecordCurrencyGivenWithAttributes_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->GameCurrencyType), GameCurrencyType);
			ptr->GameCurrencyAmount = GameCurrencyAmount;
			TArray<FAnalyticsEventAttr> tarray = Attributes;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Attributes);
			}
			UnrealReflectionUtils.CallUFunction(UAnalyticsBlueprintLibrary._ClassDefaultObjectPtr, UAnalyticsBlueprintLibrary.__RecordCurrencyGivenWithAttributes_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FAnalyticsEventAttr> tarray2 = Attributes;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Attributes);
			}
			UnrealReflectionUtils.DestroyStruct(UAnalyticsBlueprintLibrary.__RecordCurrencyGivenWithAttributes_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600256D RID: 9581 RVA: 0x00038760 File Offset: 0x00036960
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void RecordCurrencyGiven(string GameCurrencyType, int GameCurrencyAmount)
		{
			UAnalyticsBlueprintLibrary.__RecordCurrencyGiven_FunctionParams* ptr = stackalloc UAnalyticsBlueprintLibrary.__RecordCurrencyGiven_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UAnalyticsBlueprintLibrary.__RecordCurrencyGiven_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAnalyticsBlueprintLibrary.__RecordCurrencyGiven_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->GameCurrencyType), GameCurrencyType);
			ptr->GameCurrencyAmount = GameCurrencyAmount;
			UnrealReflectionUtils.CallUFunction(UAnalyticsBlueprintLibrary._ClassDefaultObjectPtr, UAnalyticsBlueprintLibrary.__RecordCurrencyGiven_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UAnalyticsBlueprintLibrary.__RecordCurrencyGiven_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600256E RID: 9582 RVA: 0x000387C4 File Offset: 0x000369C4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static FAnalyticsEventAttr MakeEventAttribute(string AttributeName, string AttributeValue)
		{
			UAnalyticsBlueprintLibrary.__MakeEventAttribute_FunctionParams* ptr = stackalloc UAnalyticsBlueprintLibrary.__MakeEventAttribute_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(UAnalyticsBlueprintLibrary.__MakeEventAttribute_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAnalyticsBlueprintLibrary.__MakeEventAttribute_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->AttributeName), AttributeName);
			FString.CopyFrom((void*)(&ptr->AttributeValue), AttributeValue);
			UnrealReflectionUtils.CallUFunction(UAnalyticsBlueprintLibrary._ClassDefaultObjectPtr, UAnalyticsBlueprintLibrary.__MakeEventAttribute_NativeFunctionPtr, (void*)ptr, 0);
			FAnalyticsEventAttr result = new FAnalyticsEventAttr(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UAnalyticsBlueprintLibrary.__MakeEventAttribute_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600256F RID: 9583 RVA: 0x0003883C File Offset: 0x00036A3C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static string GetUserId()
		{
			UAnalyticsBlueprintLibrary.__GetUserId_FunctionParams* ptr = stackalloc UAnalyticsBlueprintLibrary.__GetUserId_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UAnalyticsBlueprintLibrary.__GetUserId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAnalyticsBlueprintLibrary.__GetUserId_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UAnalyticsBlueprintLibrary._ClassDefaultObjectPtr, UAnalyticsBlueprintLibrary.__GetUserId_NativeFunctionPtr, (void*)ptr, 0);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UAnalyticsBlueprintLibrary.__GetUserId_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06002570 RID: 9584 RVA: 0x00038898 File Offset: 0x00036A98
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static string GetSessionId()
		{
			UAnalyticsBlueprintLibrary.__GetSessionId_FunctionParams* ptr = stackalloc UAnalyticsBlueprintLibrary.__GetSessionId_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UAnalyticsBlueprintLibrary.__GetSessionId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAnalyticsBlueprintLibrary.__GetSessionId_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UAnalyticsBlueprintLibrary._ClassDefaultObjectPtr, UAnalyticsBlueprintLibrary.__GetSessionId_NativeFunctionPtr, (void*)ptr, 0);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UAnalyticsBlueprintLibrary.__GetSessionId_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06002571 RID: 9585 RVA: 0x000388F4 File Offset: 0x00036AF4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void FlushEvents()
		{
			UnrealReflectionUtils.CallUFunction(UAnalyticsBlueprintLibrary._ClassDefaultObjectPtr, UAnalyticsBlueprintLibrary.__FlushEvents_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06002572 RID: 9586 RVA: 0x00038908 File Offset: 0x00036B08
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void EndSession()
		{
			UnrealReflectionUtils.CallUFunction(UAnalyticsBlueprintLibrary._ClassDefaultObjectPtr, UAnalyticsBlueprintLibrary.__EndSession_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06002573 RID: 9587 RVA: 0x0003891C File Offset: 0x00036B1C
		static UAnalyticsBlueprintLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AnalyticsBlueprintLibrary.AnalyticsBlueprintLibrary");
		}

		// Token: 0x06002574 RID: 9588 RVA: 0x0003892A File Offset: 0x00036B2A
		protected UAnalyticsBlueprintLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000E49 RID: 3657
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AnalyticsBlueprintLibrary.AnalyticsBlueprintLibrary";

		// Token: 0x04000E4A RID: 3658
		private static IntPtr _ClassPtr;

		// Token: 0x04000E4B RID: 3659
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000E4C RID: 3660
		private static IntPtr __StartSessionWithAttributes_NativeFunctionPtr;

		// Token: 0x04000E4D RID: 3661
		private static IntPtr __StartSession_NativeFunctionPtr;

		// Token: 0x04000E4E RID: 3662
		private static IntPtr __SetUserId_NativeFunctionPtr;

		// Token: 0x04000E4F RID: 3663
		private static IntPtr __SetSessionId_NativeFunctionPtr;

		// Token: 0x04000E50 RID: 3664
		private static IntPtr __SetLocation_NativeFunctionPtr;

		// Token: 0x04000E51 RID: 3665
		private static IntPtr __SetGender_NativeFunctionPtr;

		// Token: 0x04000E52 RID: 3666
		private static IntPtr __SetBuildInfo_NativeFunctionPtr;

		// Token: 0x04000E53 RID: 3667
		private static IntPtr __SetAge_NativeFunctionPtr;

		// Token: 0x04000E54 RID: 3668
		private static IntPtr __RecordSimpleItemPurchaseWithAttributes_NativeFunctionPtr;

		// Token: 0x04000E55 RID: 3669
		private static IntPtr __RecordSimpleItemPurchase_NativeFunctionPtr;

		// Token: 0x04000E56 RID: 3670
		private static IntPtr __RecordSimpleCurrencyPurchaseWithAttributes_NativeFunctionPtr;

		// Token: 0x04000E57 RID: 3671
		private static IntPtr __RecordSimpleCurrencyPurchase_NativeFunctionPtr;

		// Token: 0x04000E58 RID: 3672
		private static IntPtr __RecordProgressWithFullHierarchyAndAttributes_NativeFunctionPtr;

		// Token: 0x04000E59 RID: 3673
		private static IntPtr __RecordProgressWithAttributes_NativeFunctionPtr;

		// Token: 0x04000E5A RID: 3674
		private static IntPtr __RecordProgress_NativeFunctionPtr;

		// Token: 0x04000E5B RID: 3675
		private static IntPtr __RecordItemPurchase_NativeFunctionPtr;

		// Token: 0x04000E5C RID: 3676
		private static IntPtr __RecordEventWithAttributes_NativeFunctionPtr;

		// Token: 0x04000E5D RID: 3677
		private static IntPtr __RecordEventWithAttribute_NativeFunctionPtr;

		// Token: 0x04000E5E RID: 3678
		private static IntPtr __RecordEvent_NativeFunctionPtr;

		// Token: 0x04000E5F RID: 3679
		private static IntPtr __RecordErrorWithAttributes_NativeFunctionPtr;

		// Token: 0x04000E60 RID: 3680
		private static IntPtr __RecordError_NativeFunctionPtr;

		// Token: 0x04000E61 RID: 3681
		private static IntPtr __RecordCurrencyPurchase_NativeFunctionPtr;

		// Token: 0x04000E62 RID: 3682
		private static IntPtr __RecordCurrencyGivenWithAttributes_NativeFunctionPtr;

		// Token: 0x04000E63 RID: 3683
		private static IntPtr __RecordCurrencyGiven_NativeFunctionPtr;

		// Token: 0x04000E64 RID: 3684
		private static IntPtr __MakeEventAttribute_NativeFunctionPtr;

		// Token: 0x04000E65 RID: 3685
		private static IntPtr __GetUserId_NativeFunctionPtr;

		// Token: 0x04000E66 RID: 3686
		private static IntPtr __GetSessionId_NativeFunctionPtr;

		// Token: 0x04000E67 RID: 3687
		private static IntPtr __FlushEvents_NativeFunctionPtr;

		// Token: 0x04000E68 RID: 3688
		private static IntPtr __EndSession_NativeFunctionPtr;

		// Token: 0x02002BAB RID: 11179
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __StartSessionWithAttributes_FunctionParams
		{
			// Token: 0x04016441 RID: 91201
			[FieldOffset(0)]
			public byte Attributes;

			// Token: 0x04016442 RID: 91202
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x02002BAC RID: 11180
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __StartSession_FunctionParams
		{
			// Token: 0x04016443 RID: 91203
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02002BAD RID: 11181
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetUserId_FunctionParams
		{
			// Token: 0x04016444 RID: 91204
			[FieldOffset(0)]
			public FString UserId;
		}

		// Token: 0x02002BAE RID: 11182
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetSessionId_FunctionParams
		{
			// Token: 0x04016445 RID: 91205
			[FieldOffset(0)]
			public FString SessionId;
		}

		// Token: 0x02002BAF RID: 11183
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetLocation_FunctionParams
		{
			// Token: 0x04016446 RID: 91206
			[FieldOffset(0)]
			public FString Location;
		}

		// Token: 0x02002BB0 RID: 11184
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetGender_FunctionParams
		{
			// Token: 0x04016447 RID: 91207
			[FieldOffset(0)]
			public FString Gender;
		}

		// Token: 0x02002BB1 RID: 11185
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetBuildInfo_FunctionParams
		{
			// Token: 0x04016448 RID: 91208
			[FieldOffset(0)]
			public FString BuildInfo;
		}

		// Token: 0x02002BB2 RID: 11186
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetAge_FunctionParams
		{
			// Token: 0x04016449 RID: 91209
			[FieldOffset(0)]
			public int Age;
		}

		// Token: 0x02002BB3 RID: 11187
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __RecordSimpleItemPurchaseWithAttributes_FunctionParams
		{
			// Token: 0x0401644A RID: 91210
			[FieldOffset(0)]
			public FString ItemId;

			// Token: 0x0401644B RID: 91211
			[FieldOffset(16)]
			public int ItemQuantity;

			// Token: 0x0401644C RID: 91212
			[FieldOffset(24)]
			public byte Attributes;
		}

		// Token: 0x02002BB4 RID: 11188
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __RecordSimpleItemPurchase_FunctionParams
		{
			// Token: 0x0401644D RID: 91213
			[FieldOffset(0)]
			public FString ItemId;

			// Token: 0x0401644E RID: 91214
			[FieldOffset(16)]
			public int ItemQuantity;
		}

		// Token: 0x02002BB5 RID: 11189
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __RecordSimpleCurrencyPurchaseWithAttributes_FunctionParams
		{
			// Token: 0x0401644F RID: 91215
			[FieldOffset(0)]
			public FString GameCurrencyType;

			// Token: 0x04016450 RID: 91216
			[FieldOffset(16)]
			public int GameCurrencyAmount;

			// Token: 0x04016451 RID: 91217
			[FieldOffset(24)]
			public byte Attributes;
		}

		// Token: 0x02002BB6 RID: 11190
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __RecordSimpleCurrencyPurchase_FunctionParams
		{
			// Token: 0x04016452 RID: 91218
			[FieldOffset(0)]
			public FString GameCurrencyType;

			// Token: 0x04016453 RID: 91219
			[FieldOffset(16)]
			public int GameCurrencyAmount;
		}

		// Token: 0x02002BB7 RID: 11191
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __RecordProgressWithFullHierarchyAndAttributes_FunctionParams
		{
			// Token: 0x04016454 RID: 91220
			[FieldOffset(0)]
			public FString ProgressType;

			// Token: 0x04016455 RID: 91221
			[FieldOffset(16)]
			public byte ProgressNames;

			// Token: 0x04016456 RID: 91222
			[FieldOffset(32)]
			public byte Attributes;
		}

		// Token: 0x02002BB8 RID: 11192
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __RecordProgressWithAttributes_FunctionParams
		{
			// Token: 0x04016457 RID: 91223
			[FieldOffset(0)]
			public FString ProgressType;

			// Token: 0x04016458 RID: 91224
			[FieldOffset(16)]
			public FString ProgressName;

			// Token: 0x04016459 RID: 91225
			[FieldOffset(32)]
			public byte Attributes;
		}

		// Token: 0x02002BB9 RID: 11193
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __RecordProgress_FunctionParams
		{
			// Token: 0x0401645A RID: 91226
			[FieldOffset(0)]
			public FString ProgressType;

			// Token: 0x0401645B RID: 91227
			[FieldOffset(16)]
			public FString ProgressName;
		}

		// Token: 0x02002BBA RID: 11194
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __RecordItemPurchase_FunctionParams
		{
			// Token: 0x0401645C RID: 91228
			[FieldOffset(0)]
			public FString ItemId;

			// Token: 0x0401645D RID: 91229
			[FieldOffset(16)]
			public FString Currency;

			// Token: 0x0401645E RID: 91230
			[FieldOffset(32)]
			public int PerItemCost;

			// Token: 0x0401645F RID: 91231
			[FieldOffset(36)]
			public int ItemQuantity;
		}

		// Token: 0x02002BBB RID: 11195
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __RecordEventWithAttributes_FunctionParams
		{
			// Token: 0x04016460 RID: 91232
			[FieldOffset(0)]
			public FString EventName;

			// Token: 0x04016461 RID: 91233
			[FieldOffset(16)]
			public byte Attributes;
		}

		// Token: 0x02002BBC RID: 11196
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __RecordEventWithAttribute_FunctionParams
		{
			// Token: 0x04016462 RID: 91234
			[FieldOffset(0)]
			public FString EventName;

			// Token: 0x04016463 RID: 91235
			[FieldOffset(16)]
			public FString AttributeName;

			// Token: 0x04016464 RID: 91236
			[FieldOffset(32)]
			public FString AttributeValue;
		}

		// Token: 0x02002BBD RID: 11197
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __RecordEvent_FunctionParams
		{
			// Token: 0x04016465 RID: 91237
			[FieldOffset(0)]
			public FString EventName;
		}

		// Token: 0x02002BBE RID: 11198
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __RecordErrorWithAttributes_FunctionParams
		{
			// Token: 0x04016466 RID: 91238
			[FieldOffset(0)]
			public FString Error;

			// Token: 0x04016467 RID: 91239
			[FieldOffset(16)]
			public byte Attributes;
		}

		// Token: 0x02002BBF RID: 11199
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __RecordError_FunctionParams
		{
			// Token: 0x04016468 RID: 91240
			[FieldOffset(0)]
			public FString Error;
		}

		// Token: 0x02002BC0 RID: 11200
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __RecordCurrencyPurchase_FunctionParams
		{
			// Token: 0x04016469 RID: 91241
			[FieldOffset(0)]
			public FString GameCurrencyType;

			// Token: 0x0401646A RID: 91242
			[FieldOffset(16)]
			public int GameCurrencyAmount;

			// Token: 0x0401646B RID: 91243
			[FieldOffset(24)]
			public FString RealCurrencyType;

			// Token: 0x0401646C RID: 91244
			[FieldOffset(40)]
			public float RealMoneyCost;

			// Token: 0x0401646D RID: 91245
			[FieldOffset(48)]
			public FString PaymentProvider;
		}

		// Token: 0x02002BC1 RID: 11201
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __RecordCurrencyGivenWithAttributes_FunctionParams
		{
			// Token: 0x0401646E RID: 91246
			[FieldOffset(0)]
			public FString GameCurrencyType;

			// Token: 0x0401646F RID: 91247
			[FieldOffset(16)]
			public int GameCurrencyAmount;

			// Token: 0x04016470 RID: 91248
			[FieldOffset(24)]
			public byte Attributes;
		}

		// Token: 0x02002BC2 RID: 11202
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __RecordCurrencyGiven_FunctionParams
		{
			// Token: 0x04016471 RID: 91249
			[FieldOffset(0)]
			public FString GameCurrencyType;

			// Token: 0x04016472 RID: 91250
			[FieldOffset(16)]
			public int GameCurrencyAmount;
		}

		// Token: 0x02002BC3 RID: 11203
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __MakeEventAttribute_FunctionParams
		{
			// Token: 0x04016473 RID: 91251
			[FieldOffset(0)]
			public FString AttributeName;

			// Token: 0x04016474 RID: 91252
			[FieldOffset(16)]
			public FString AttributeValue;

			// Token: 0x04016475 RID: 91253
			[FieldOffset(32)]
			public byte __Result;
		}

		// Token: 0x02002BC4 RID: 11204
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetUserId_FunctionParams
		{
			// Token: 0x04016476 RID: 91254
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x02002BC5 RID: 11205
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetSessionId_FunctionParams
		{
			// Token: 0x04016477 RID: 91255
			[FieldOffset(0)]
			public FString __Result;
		}
	}
}
