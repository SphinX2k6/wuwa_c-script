using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200085F RID: 2143
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AsyncActionLoadPrimaryAssetClass")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UAsyncActionLoadPrimaryAssetClass : UAsyncActionLoadPrimaryAssetBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600738D RID: 29581 RVA: 0x000A5B95 File Offset: 0x000A3D95
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAsyncActionLoadPrimaryAssetClass._ClassPtr;
		}

		// Token: 0x0600738E RID: 29582 RVA: 0x000A5BA4 File Offset: 0x000A3DA4
		public UAsyncActionLoadPrimaryAssetClass() : this(BuiltinUtils.AllocNativeUObject(UAsyncActionLoadPrimaryAssetClass.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600738F RID: 29583 RVA: 0x000A5BCC File Offset: 0x000A3DCC
		public UAsyncActionLoadPrimaryAssetClass(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAsyncActionLoadPrimaryAssetClass.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001B3D RID: 6973
		// (get) Token: 0x06007390 RID: 29584 RVA: 0x000A5C00 File Offset: 0x000A3E00
		// (set) Token: 0x06007391 RID: 29585 RVA: 0x000A5C39 File Offset: 0x000A3E39
		public FOnPrimaryAssetClassLoaded Completed
		{
			get
			{
				base.FastCheckIsValid();
				FOnPrimaryAssetClassLoaded result;
				if ((result = this._Completed) == null)
				{
					result = (this._Completed = new FOnPrimaryAssetClassLoaded(base.NativePtr + (IntPtr)UAsyncActionLoadPrimaryAssetClass.__PropertyOffset_Completed, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAsyncActionLoadPrimaryAssetClass.__PropertyOffset_Completed, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06007392 RID: 29586 RVA: 0x000A5C5C File Offset: 0x000A3E5C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static UAsyncActionLoadPrimaryAssetClass AsyncLoadPrimaryAssetClass(UObject WorldContextObject, FPrimaryAssetId PrimaryAsset, in TArray<FName> LoadBundles)
		{
			UAsyncActionLoadPrimaryAssetClass.__AsyncLoadPrimaryAssetClass_FunctionParams* ptr = stackalloc UAsyncActionLoadPrimaryAssetClass.__AsyncLoadPrimaryAssetClass_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(UAsyncActionLoadPrimaryAssetClass.__AsyncLoadPrimaryAssetClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAsyncActionLoadPrimaryAssetClass.__AsyncLoadPrimaryAssetClass_NativeFunctionPtr, (void*)ptr, 1);
			ptr->WorldContextObject = ((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
			if (PrimaryAsset != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPrimaryAssetId.StaticStruct(), &ptr->PrimaryAsset, PrimaryAsset.NativePtr, 1, false);
			}
			TArray<FName> tarray = LoadBundles;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->LoadBundles);
			}
			UnrealReflectionUtils.CallUFunction(UAsyncActionLoadPrimaryAssetClass._ClassDefaultObjectPtr, UAsyncActionLoadPrimaryAssetClass.__AsyncLoadPrimaryAssetClass_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FName> tarray2 = LoadBundles;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->LoadBundles);
			}
			UAsyncActionLoadPrimaryAssetClass orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAsyncActionLoadPrimaryAssetClass>(ptr->__Result);
			UnrealReflectionUtils.DestroyStruct(UAsyncActionLoadPrimaryAssetClass.__AsyncLoadPrimaryAssetClass_NativeFunctionPtr, (void*)ptr, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x06007393 RID: 29587 RVA: 0x000A5D17 File Offset: 0x000A3F17
		static UAsyncActionLoadPrimaryAssetClass()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AsyncActionLoadPrimaryAssetClass");
		}

		// Token: 0x06007394 RID: 29588 RVA: 0x000A5D25 File Offset: 0x000A3F25
		protected UAsyncActionLoadPrimaryAssetClass(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400379A RID: 14234
		public new const string __ObjectPath = "/Script/Engine.AsyncActionLoadPrimaryAssetClass";

		// Token: 0x0400379B RID: 14235
		private static IntPtr _ClassPtr;

		// Token: 0x0400379C RID: 14236
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400379D RID: 14237
		internal static int __PropertyOffset_Completed;

		// Token: 0x0400379E RID: 14238
		[Nullable(2)]
		private FOnPrimaryAssetClassLoaded _Completed;

		// Token: 0x0400379F RID: 14239
		private static IntPtr __AsyncLoadPrimaryAssetClass_NativeFunctionPtr;

		// Token: 0x02002C93 RID: 11411
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __AsyncLoadPrimaryAssetClass_FunctionParams
		{
			// Token: 0x040165E1 RID: 91617
			[FieldOffset(0)]
			public IntPtr WorldContextObject;

			// Token: 0x040165E2 RID: 91618
			[FieldOffset(8)]
			public byte PrimaryAsset;

			// Token: 0x040165E3 RID: 91619
			[FieldOffset(32)]
			public byte LoadBundles;

			// Token: 0x040165E4 RID: 91620
			[FieldOffset(48)]
			public IntPtr __Result;
		}
	}
}
