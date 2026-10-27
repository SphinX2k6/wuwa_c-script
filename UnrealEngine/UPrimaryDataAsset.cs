using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200103C RID: 4156
	[UnrealObjectPath("/Script/Engine.PrimaryDataAsset")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public abstract class UPrimaryDataAsset : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600E9D3 RID: 59859 RVA: 0x0015B69C File Offset: 0x0015989C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPrimaryDataAsset._ClassPtr;
		}

		// Token: 0x0600E9D4 RID: 59860 RVA: 0x0015B6A8 File Offset: 0x001598A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnPreSave()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, UPrimaryDataAsset.__OnPreSave_NativeFunctionPtr, null);
		}

		// Token: 0x0600E9D5 RID: 59861 RVA: 0x0015B6BC File Offset: 0x001598BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnPreSave_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UPrimaryDataAsset.__OnPreSave_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0600E9D6 RID: 59862 RVA: 0x0015B6D1 File Offset: 0x001598D1
		static UPrimaryDataAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PrimaryDataAsset");
		}

		// Token: 0x0600E9D7 RID: 59863 RVA: 0x0015B6E0 File Offset: 0x001598E0
		protected UPrimaryDataAsset() : this(BuiltinUtils.AllocNativeUObject(UPrimaryDataAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600E9D8 RID: 59864 RVA: 0x0015B708 File Offset: 0x00159908
		protected UPrimaryDataAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007EEF RID: 32495
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.PrimaryDataAsset";

		// Token: 0x04007EF0 RID: 32496
		private static IntPtr _ClassPtr;

		// Token: 0x04007EF1 RID: 32497
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007EF2 RID: 32498
		private static IntPtr __OnPreSave_NativeFunctionPtr;
	}
}
