using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200026E RID: 622
	[UnrealObjectPath("/Script/Engine.PrimaryDataAsset")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public abstract class UPrimaryDataAsset : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003DB7 RID: 15799 RVA: 0x00058FB4 File Offset: 0x000571B4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPrimaryDataAsset._ClassPtr;
		}

		// Token: 0x06003DB8 RID: 15800 RVA: 0x00058FC0 File Offset: 0x000571C0
		[SkipLocalsInit]
		public virtual void OnPreSave()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, UPrimaryDataAsset.__OnPreSave_NativeFunctionPtr, null);
		}

		// Token: 0x06003DB9 RID: 15801 RVA: 0x00058FD4 File Offset: 0x000571D4
		[SkipLocalsInit]
		protected virtual void OnPreSave_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UPrimaryDataAsset.__OnPreSave_NativeFunctionPtr, null);
		}

		// Token: 0x06003DBA RID: 15802 RVA: 0x00058FE8 File Offset: 0x000571E8
		static UPrimaryDataAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PrimaryDataAsset");
		}

		// Token: 0x06003DBB RID: 15803 RVA: 0x00058FF8 File Offset: 0x000571F8
		protected UPrimaryDataAsset() : this(BuiltinUtils.AllocNativeUObject(UPrimaryDataAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003DBC RID: 15804 RVA: 0x00059020 File Offset: 0x00057220
		protected UPrimaryDataAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400181B RID: 6171
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.PrimaryDataAsset";

		// Token: 0x0400181C RID: 6172
		private static IntPtr _ClassPtr;

		// Token: 0x0400181D RID: 6173
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400181E RID: 6174
		private static IntPtr __OnPreSave_NativeFunctionPtr;
	}
}
