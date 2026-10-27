using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000861 RID: 2145
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AsyncActionLoadPrimaryAssetList")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UAsyncActionLoadPrimaryAssetList : UAsyncActionLoadPrimaryAssetBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600739D RID: 29597 RVA: 0x000A5ECC File Offset: 0x000A40CC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAsyncActionLoadPrimaryAssetList._ClassPtr;
		}

		// Token: 0x0600739E RID: 29598 RVA: 0x000A5ED8 File Offset: 0x000A40D8
		public UAsyncActionLoadPrimaryAssetList() : this(BuiltinUtils.AllocNativeUObject(UAsyncActionLoadPrimaryAssetList.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600739F RID: 29599 RVA: 0x000A5F00 File Offset: 0x000A4100
		public UAsyncActionLoadPrimaryAssetList(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAsyncActionLoadPrimaryAssetList.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001B3F RID: 6975
		// (get) Token: 0x060073A0 RID: 29600 RVA: 0x000A5F34 File Offset: 0x000A4134
		// (set) Token: 0x060073A1 RID: 29601 RVA: 0x000A5F6D File Offset: 0x000A416D
		public FOnPrimaryAssetListLoaded Completed
		{
			get
			{
				base.FastCheckIsValid();
				FOnPrimaryAssetListLoaded result;
				if ((result = this._Completed) == null)
				{
					result = (this._Completed = new FOnPrimaryAssetListLoaded(base.NativePtr + (IntPtr)UAsyncActionLoadPrimaryAssetList.__PropertyOffset_Completed, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAsyncActionLoadPrimaryAssetList.__PropertyOffset_Completed, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x060073A2 RID: 29602 RVA: 0x000A5F90 File Offset: 0x000A4190
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static UAsyncActionLoadPrimaryAssetList AsyncLoadPrimaryAssetList(UObject WorldContextObject, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FPrimaryAssetId> PrimaryAssetList, in TArray<FName> LoadBundles)
		{
			UAsyncActionLoadPrimaryAssetList.__AsyncLoadPrimaryAssetList_FunctionParams* ptr = stackalloc UAsyncActionLoadPrimaryAssetList.__AsyncLoadPrimaryAssetList_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UAsyncActionLoadPrimaryAssetList.__AsyncLoadPrimaryAssetList_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAsyncActionLoadPrimaryAssetList.__AsyncLoadPrimaryAssetList_NativeFunctionPtr, (void*)ptr, 1);
			ptr->WorldContextObject = ((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
			TArray<FPrimaryAssetId> tarray = PrimaryAssetList;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->PrimaryAssetList);
			}
			TArray<FName> tarray2 = LoadBundles;
			if (tarray2 != null)
			{
				tarray2.MoveTo(&ptr->LoadBundles);
			}
			UnrealReflectionUtils.CallUFunction(UAsyncActionLoadPrimaryAssetList._ClassDefaultObjectPtr, UAsyncActionLoadPrimaryAssetList.__AsyncLoadPrimaryAssetList_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FPrimaryAssetId> tarray3 = PrimaryAssetList;
			if (tarray3 != null)
			{
				tarray3.MoveAssign(&ptr->PrimaryAssetList);
			}
			TArray<FName> tarray4 = LoadBundles;
			if (tarray4 != null)
			{
				tarray4.MoveAssign(&ptr->LoadBundles);
			}
			UAsyncActionLoadPrimaryAssetList orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAsyncActionLoadPrimaryAssetList>(ptr->__Result);
			UnrealReflectionUtils.DestroyStruct(UAsyncActionLoadPrimaryAssetList.__AsyncLoadPrimaryAssetList_NativeFunctionPtr, (void*)ptr, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x060073A3 RID: 29603 RVA: 0x000A6051 File Offset: 0x000A4251
		static UAsyncActionLoadPrimaryAssetList()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AsyncActionLoadPrimaryAssetList");
		}

		// Token: 0x060073A4 RID: 29604 RVA: 0x000A605F File Offset: 0x000A425F
		protected UAsyncActionLoadPrimaryAssetList(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040037A6 RID: 14246
		public new const string __ObjectPath = "/Script/Engine.AsyncActionLoadPrimaryAssetList";

		// Token: 0x040037A7 RID: 14247
		private static IntPtr _ClassPtr;

		// Token: 0x040037A8 RID: 14248
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040037A9 RID: 14249
		internal static int __PropertyOffset_Completed;

		// Token: 0x040037AA RID: 14250
		[Nullable(2)]
		private FOnPrimaryAssetListLoaded _Completed;

		// Token: 0x040037AB RID: 14251
		private static IntPtr __AsyncLoadPrimaryAssetList_NativeFunctionPtr;

		// Token: 0x02002C95 RID: 11413
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __AsyncLoadPrimaryAssetList_FunctionParams
		{
			// Token: 0x040165E9 RID: 91625
			[FieldOffset(0)]
			public IntPtr WorldContextObject;

			// Token: 0x040165EA RID: 91626
			[FieldOffset(8)]
			public byte PrimaryAssetList;

			// Token: 0x040165EB RID: 91627
			[FieldOffset(24)]
			public byte LoadBundles;

			// Token: 0x040165EC RID: 91628
			[FieldOffset(40)]
			public IntPtr __Result;
		}
	}
}
