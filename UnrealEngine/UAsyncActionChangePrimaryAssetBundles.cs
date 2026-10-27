using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200085B RID: 2139
	[UnrealObjectPath("/Script/Engine.AsyncActionChangePrimaryAssetBundles")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UAsyncActionChangePrimaryAssetBundles : UAsyncActionLoadPrimaryAssetBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600736B RID: 29547 RVA: 0x000A559D File Offset: 0x000A379D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAsyncActionChangePrimaryAssetBundles._ClassPtr;
		}

		// Token: 0x0600736C RID: 29548 RVA: 0x000A55AC File Offset: 0x000A37AC
		public UAsyncActionChangePrimaryAssetBundles() : this(BuiltinUtils.AllocNativeUObject(UAsyncActionChangePrimaryAssetBundles.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600736D RID: 29549 RVA: 0x000A55D4 File Offset: 0x000A37D4
		[NullableContext(1)]
		public UAsyncActionChangePrimaryAssetBundles(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAsyncActionChangePrimaryAssetBundles.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001B39 RID: 6969
		// (get) Token: 0x0600736E RID: 29550 RVA: 0x000A5608 File Offset: 0x000A3808
		// (set) Token: 0x0600736F RID: 29551 RVA: 0x000A5641 File Offset: 0x000A3841
		[Nullable(1)]
		public FOnPrimaryAssetBundlesChanged Completed
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FOnPrimaryAssetBundlesChanged result;
				if ((result = this._Completed) == null)
				{
					result = (this._Completed = new FOnPrimaryAssetBundlesChanged(base.NativePtr + (IntPtr)UAsyncActionChangePrimaryAssetBundles.__PropertyOffset_Completed, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAsyncActionChangePrimaryAssetBundles.__PropertyOffset_Completed, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06007370 RID: 29552 RVA: 0x000A5664 File Offset: 0x000A3864
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static UAsyncActionChangePrimaryAssetBundles AsyncChangeBundleStateForPrimaryAssetList(UObject WorldContextObject, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FPrimaryAssetId> PrimaryAssetList, in TArray<FName> AddBundles, in TArray<FName> RemoveBundles)
		{
			UAsyncActionChangePrimaryAssetBundles.__AsyncChangeBundleStateForPrimaryAssetList_FunctionParams* ptr = stackalloc UAsyncActionChangePrimaryAssetBundles.__AsyncChangeBundleStateForPrimaryAssetList_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(UAsyncActionChangePrimaryAssetBundles.__AsyncChangeBundleStateForPrimaryAssetList_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAsyncActionChangePrimaryAssetBundles.__AsyncChangeBundleStateForPrimaryAssetList_NativeFunctionPtr, (void*)ptr, 1);
			ptr->WorldContextObject = ((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
			TArray<FPrimaryAssetId> tarray = PrimaryAssetList;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->PrimaryAssetList);
			}
			TArray<FName> tarray2 = AddBundles;
			if (tarray2 != null)
			{
				tarray2.MoveTo(&ptr->AddBundles);
			}
			TArray<FName> tarray3 = RemoveBundles;
			if (tarray3 != null)
			{
				tarray3.MoveTo(&ptr->RemoveBundles);
			}
			UnrealReflectionUtils.CallUFunction(UAsyncActionChangePrimaryAssetBundles._ClassDefaultObjectPtr, UAsyncActionChangePrimaryAssetBundles.__AsyncChangeBundleStateForPrimaryAssetList_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FPrimaryAssetId> tarray4 = PrimaryAssetList;
			if (tarray4 != null)
			{
				tarray4.MoveAssign(&ptr->PrimaryAssetList);
			}
			TArray<FName> tarray5 = AddBundles;
			if (tarray5 != null)
			{
				tarray5.MoveAssign(&ptr->AddBundles);
			}
			TArray<FName> tarray6 = RemoveBundles;
			if (tarray6 != null)
			{
				tarray6.MoveAssign(&ptr->RemoveBundles);
			}
			UAsyncActionChangePrimaryAssetBundles orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAsyncActionChangePrimaryAssetBundles>(ptr->__Result);
			UnrealReflectionUtils.DestroyStruct(UAsyncActionChangePrimaryAssetBundles.__AsyncChangeBundleStateForPrimaryAssetList_NativeFunctionPtr, (void*)ptr, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x06007371 RID: 29553 RVA: 0x000A5750 File Offset: 0x000A3950
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static UAsyncActionChangePrimaryAssetBundles AsyncChangeBundleStateForMatchingPrimaryAssets(UObject WorldContextObject, in TArray<FName> NewBundles, in TArray<FName> OldBundles)
		{
			UAsyncActionChangePrimaryAssetBundles.__AsyncChangeBundleStateForMatchingPrimaryAssets_FunctionParams* ptr = stackalloc UAsyncActionChangePrimaryAssetBundles.__AsyncChangeBundleStateForMatchingPrimaryAssets_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UAsyncActionChangePrimaryAssetBundles.__AsyncChangeBundleStateForMatchingPrimaryAssets_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAsyncActionChangePrimaryAssetBundles.__AsyncChangeBundleStateForMatchingPrimaryAssets_NativeFunctionPtr, (void*)ptr, 1);
			ptr->WorldContextObject = ((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
			TArray<FName> tarray = NewBundles;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->NewBundles);
			}
			TArray<FName> tarray2 = OldBundles;
			if (tarray2 != null)
			{
				tarray2.MoveTo(&ptr->OldBundles);
			}
			UnrealReflectionUtils.CallUFunction(UAsyncActionChangePrimaryAssetBundles._ClassDefaultObjectPtr, UAsyncActionChangePrimaryAssetBundles.__AsyncChangeBundleStateForMatchingPrimaryAssets_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FName> tarray3 = NewBundles;
			if (tarray3 != null)
			{
				tarray3.MoveAssign(&ptr->NewBundles);
			}
			TArray<FName> tarray4 = OldBundles;
			if (tarray4 != null)
			{
				tarray4.MoveAssign(&ptr->OldBundles);
			}
			UAsyncActionChangePrimaryAssetBundles orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAsyncActionChangePrimaryAssetBundles>(ptr->__Result);
			UnrealReflectionUtils.DestroyStruct(UAsyncActionChangePrimaryAssetBundles.__AsyncChangeBundleStateForMatchingPrimaryAssets_NativeFunctionPtr, (void*)ptr, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x06007372 RID: 29554 RVA: 0x000A5811 File Offset: 0x000A3A11
		static UAsyncActionChangePrimaryAssetBundles()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AsyncActionChangePrimaryAssetBundles");
		}

		// Token: 0x06007373 RID: 29555 RVA: 0x000A581F File Offset: 0x000A3A1F
		protected UAsyncActionChangePrimaryAssetBundles(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003784 RID: 14212
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AsyncActionChangePrimaryAssetBundles";

		// Token: 0x04003785 RID: 14213
		private static IntPtr _ClassPtr;

		// Token: 0x04003786 RID: 14214
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003787 RID: 14215
		internal static int __PropertyOffset_Completed;

		// Token: 0x04003788 RID: 14216
		[Nullable(2)]
		private FOnPrimaryAssetBundlesChanged _Completed;

		// Token: 0x04003789 RID: 14217
		private static IntPtr __AsyncChangeBundleStateForPrimaryAssetList_NativeFunctionPtr;

		// Token: 0x0400378A RID: 14218
		private static IntPtr __AsyncChangeBundleStateForMatchingPrimaryAssets_NativeFunctionPtr;

		// Token: 0x02002C90 RID: 11408
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __AsyncChangeBundleStateForPrimaryAssetList_FunctionParams
		{
			// Token: 0x040165D4 RID: 91604
			[FieldOffset(0)]
			public IntPtr WorldContextObject;

			// Token: 0x040165D5 RID: 91605
			[FieldOffset(8)]
			public byte PrimaryAssetList;

			// Token: 0x040165D6 RID: 91606
			[FieldOffset(24)]
			public byte AddBundles;

			// Token: 0x040165D7 RID: 91607
			[FieldOffset(40)]
			public byte RemoveBundles;

			// Token: 0x040165D8 RID: 91608
			[FieldOffset(56)]
			public IntPtr __Result;
		}

		// Token: 0x02002C91 RID: 11409
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __AsyncChangeBundleStateForMatchingPrimaryAssets_FunctionParams
		{
			// Token: 0x040165D9 RID: 91609
			[FieldOffset(0)]
			public IntPtr WorldContextObject;

			// Token: 0x040165DA RID: 91610
			[FieldOffset(8)]
			public byte NewBundles;

			// Token: 0x040165DB RID: 91611
			[FieldOffset(24)]
			public byte OldBundles;

			// Token: 0x040165DC RID: 91612
			[FieldOffset(40)]
			public IntPtr __Result;
		}
	}
}
