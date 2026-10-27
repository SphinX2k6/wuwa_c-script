using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200085D RID: 2141
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AsyncActionLoadPrimaryAsset")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UAsyncActionLoadPrimaryAsset : UAsyncActionLoadPrimaryAssetBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007381 RID: 29569 RVA: 0x000A59B1 File Offset: 0x000A3BB1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAsyncActionLoadPrimaryAsset._ClassPtr;
		}

		// Token: 0x06007382 RID: 29570 RVA: 0x000A59C0 File Offset: 0x000A3BC0
		public UAsyncActionLoadPrimaryAsset() : this(BuiltinUtils.AllocNativeUObject(UAsyncActionLoadPrimaryAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007383 RID: 29571 RVA: 0x000A59E8 File Offset: 0x000A3BE8
		public UAsyncActionLoadPrimaryAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAsyncActionLoadPrimaryAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001B3C RID: 6972
		// (get) Token: 0x06007384 RID: 29572 RVA: 0x000A5A1C File Offset: 0x000A3C1C
		// (set) Token: 0x06007385 RID: 29573 RVA: 0x000A5A55 File Offset: 0x000A3C55
		public FOnPrimaryAssetLoaded Completed
		{
			get
			{
				base.FastCheckIsValid();
				FOnPrimaryAssetLoaded result;
				if ((result = this._Completed) == null)
				{
					result = (this._Completed = new FOnPrimaryAssetLoaded(base.NativePtr + (IntPtr)UAsyncActionLoadPrimaryAsset.__PropertyOffset_Completed, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAsyncActionLoadPrimaryAsset.__PropertyOffset_Completed, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06007386 RID: 29574 RVA: 0x000A5A78 File Offset: 0x000A3C78
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static UAsyncActionLoadPrimaryAsset AsyncLoadPrimaryAsset(UObject WorldContextObject, FPrimaryAssetId PrimaryAsset, in TArray<FName> LoadBundles)
		{
			UAsyncActionLoadPrimaryAsset.__AsyncLoadPrimaryAsset_FunctionParams* ptr = stackalloc UAsyncActionLoadPrimaryAsset.__AsyncLoadPrimaryAsset_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(UAsyncActionLoadPrimaryAsset.__AsyncLoadPrimaryAsset_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAsyncActionLoadPrimaryAsset.__AsyncLoadPrimaryAsset_NativeFunctionPtr, (void*)ptr, 1);
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
			UnrealReflectionUtils.CallUFunction(UAsyncActionLoadPrimaryAsset._ClassDefaultObjectPtr, UAsyncActionLoadPrimaryAsset.__AsyncLoadPrimaryAsset_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FName> tarray2 = LoadBundles;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->LoadBundles);
			}
			UAsyncActionLoadPrimaryAsset orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAsyncActionLoadPrimaryAsset>(ptr->__Result);
			UnrealReflectionUtils.DestroyStruct(UAsyncActionLoadPrimaryAsset.__AsyncLoadPrimaryAsset_NativeFunctionPtr, (void*)ptr, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x06007387 RID: 29575 RVA: 0x000A5B33 File Offset: 0x000A3D33
		static UAsyncActionLoadPrimaryAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AsyncActionLoadPrimaryAsset");
		}

		// Token: 0x06007388 RID: 29576 RVA: 0x000A5B41 File Offset: 0x000A3D41
		protected UAsyncActionLoadPrimaryAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003791 RID: 14225
		public new const string __ObjectPath = "/Script/Engine.AsyncActionLoadPrimaryAsset";

		// Token: 0x04003792 RID: 14226
		private static IntPtr _ClassPtr;

		// Token: 0x04003793 RID: 14227
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003794 RID: 14228
		internal static int __PropertyOffset_Completed;

		// Token: 0x04003795 RID: 14229
		[Nullable(2)]
		private FOnPrimaryAssetLoaded _Completed;

		// Token: 0x04003796 RID: 14230
		private static IntPtr __AsyncLoadPrimaryAsset_NativeFunctionPtr;

		// Token: 0x02002C92 RID: 11410
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __AsyncLoadPrimaryAsset_FunctionParams
		{
			// Token: 0x040165DD RID: 91613
			[FieldOffset(0)]
			public IntPtr WorldContextObject;

			// Token: 0x040165DE RID: 91614
			[FieldOffset(8)]
			public byte PrimaryAsset;

			// Token: 0x040165DF RID: 91615
			[FieldOffset(32)]
			public byte LoadBundles;

			// Token: 0x040165E0 RID: 91616
			[FieldOffset(48)]
			public IntPtr __Result;
		}
	}
}
