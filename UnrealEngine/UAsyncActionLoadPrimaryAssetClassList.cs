using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000860 RID: 2144
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AsyncActionLoadPrimaryAssetClassList")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UAsyncActionLoadPrimaryAssetClassList : UAsyncActionLoadPrimaryAssetBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007395 RID: 29589 RVA: 0x000A5D2E File Offset: 0x000A3F2E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAsyncActionLoadPrimaryAssetClassList._ClassPtr;
		}

		// Token: 0x06007396 RID: 29590 RVA: 0x000A5D3C File Offset: 0x000A3F3C
		public UAsyncActionLoadPrimaryAssetClassList() : this(BuiltinUtils.AllocNativeUObject(UAsyncActionLoadPrimaryAssetClassList.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007397 RID: 29591 RVA: 0x000A5D64 File Offset: 0x000A3F64
		public UAsyncActionLoadPrimaryAssetClassList(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAsyncActionLoadPrimaryAssetClassList.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001B3E RID: 6974
		// (get) Token: 0x06007398 RID: 29592 RVA: 0x000A5D98 File Offset: 0x000A3F98
		// (set) Token: 0x06007399 RID: 29593 RVA: 0x000A5DD1 File Offset: 0x000A3FD1
		public FOnPrimaryAssetClassListLoaded Completed
		{
			get
			{
				base.FastCheckIsValid();
				FOnPrimaryAssetClassListLoaded result;
				if ((result = this._Completed) == null)
				{
					result = (this._Completed = new FOnPrimaryAssetClassListLoaded(base.NativePtr + (IntPtr)UAsyncActionLoadPrimaryAssetClassList.__PropertyOffset_Completed, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAsyncActionLoadPrimaryAssetClassList.__PropertyOffset_Completed, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x0600739A RID: 29594 RVA: 0x000A5DF4 File Offset: 0x000A3FF4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static UAsyncActionLoadPrimaryAssetClassList AsyncLoadPrimaryAssetClassList(UObject WorldContextObject, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FPrimaryAssetId> PrimaryAssetList, in TArray<FName> LoadBundles)
		{
			UAsyncActionLoadPrimaryAssetClassList.__AsyncLoadPrimaryAssetClassList_FunctionParams* ptr = stackalloc UAsyncActionLoadPrimaryAssetClassList.__AsyncLoadPrimaryAssetClassList_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UAsyncActionLoadPrimaryAssetClassList.__AsyncLoadPrimaryAssetClassList_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAsyncActionLoadPrimaryAssetClassList.__AsyncLoadPrimaryAssetClassList_NativeFunctionPtr, (void*)ptr, 1);
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
			UnrealReflectionUtils.CallUFunction(UAsyncActionLoadPrimaryAssetClassList._ClassDefaultObjectPtr, UAsyncActionLoadPrimaryAssetClassList.__AsyncLoadPrimaryAssetClassList_NativeFunctionPtr, (void*)ptr, 0);
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
			UAsyncActionLoadPrimaryAssetClassList orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAsyncActionLoadPrimaryAssetClassList>(ptr->__Result);
			UnrealReflectionUtils.DestroyStruct(UAsyncActionLoadPrimaryAssetClassList.__AsyncLoadPrimaryAssetClassList_NativeFunctionPtr, (void*)ptr, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x0600739B RID: 29595 RVA: 0x000A5EB5 File Offset: 0x000A40B5
		static UAsyncActionLoadPrimaryAssetClassList()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AsyncActionLoadPrimaryAssetClassList");
		}

		// Token: 0x0600739C RID: 29596 RVA: 0x000A5EC3 File Offset: 0x000A40C3
		protected UAsyncActionLoadPrimaryAssetClassList(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040037A0 RID: 14240
		public new const string __ObjectPath = "/Script/Engine.AsyncActionLoadPrimaryAssetClassList";

		// Token: 0x040037A1 RID: 14241
		private static IntPtr _ClassPtr;

		// Token: 0x040037A2 RID: 14242
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040037A3 RID: 14243
		internal static int __PropertyOffset_Completed;

		// Token: 0x040037A4 RID: 14244
		[Nullable(2)]
		private FOnPrimaryAssetClassListLoaded _Completed;

		// Token: 0x040037A5 RID: 14245
		private static IntPtr __AsyncLoadPrimaryAssetClassList_NativeFunctionPtr;

		// Token: 0x02002C94 RID: 11412
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __AsyncLoadPrimaryAssetClassList_FunctionParams
		{
			// Token: 0x040165E5 RID: 91621
			[FieldOffset(0)]
			public IntPtr WorldContextObject;

			// Token: 0x040165E6 RID: 91622
			[FieldOffset(8)]
			public byte PrimaryAssetList;

			// Token: 0x040165E7 RID: 91623
			[FieldOffset(24)]
			public byte LoadBundles;

			// Token: 0x040165E8 RID: 91624
			[FieldOffset(40)]
			public IntPtr __Result;
		}
	}
}
