using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000BF7 RID: 3063
	[UnrealObjectPath("/Script/Engine.FXSystemAsset")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public abstract class UFXSystemAsset : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009725 RID: 38693 RVA: 0x000D78D9 File Offset: 0x000D5AD9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UFXSystemAsset._ClassPtr;
		}

		// Token: 0x17002440 RID: 9280
		// (get) Token: 0x06009726 RID: 38694 RVA: 0x000D78E5 File Offset: 0x000D5AE5
		// (set) Token: 0x06009727 RID: 38695 RVA: 0x000D78F5 File Offset: 0x000D5AF5
		public unsafe uint MaxPoolSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFXSystemAsset.__PropertyOffset_MaxPoolSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFXSystemAsset.__PropertyOffset_MaxPoolSize) = (int)value;
			}
		}

		// Token: 0x17002441 RID: 9281
		// (get) Token: 0x06009728 RID: 38696 RVA: 0x000D7906 File Offset: 0x000D5B06
		// (set) Token: 0x06009729 RID: 38697 RVA: 0x000D7916 File Offset: 0x000D5B16
		public unsafe uint PoolPrimeSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFXSystemAsset.__PropertyOffset_PoolPrimeSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFXSystemAsset.__PropertyOffset_PoolPrimeSize) = (int)value;
			}
		}

		// Token: 0x0600972A RID: 38698 RVA: 0x000D7927 File Offset: 0x000D5B27
		static UFXSystemAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.FXSystemAsset");
		}

		// Token: 0x0600972B RID: 38699 RVA: 0x000D7938 File Offset: 0x000D5B38
		protected UFXSystemAsset() : this(BuiltinUtils.AllocNativeUObject(UFXSystemAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600972C RID: 38700 RVA: 0x000D7960 File Offset: 0x000D5B60
		protected UFXSystemAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040054BC RID: 21692
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.FXSystemAsset";

		// Token: 0x040054BD RID: 21693
		private static IntPtr _ClassPtr;

		// Token: 0x040054BE RID: 21694
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040054BF RID: 21695
		internal static int __PropertyOffset_MaxPoolSize;

		// Token: 0x040054C0 RID: 21696
		internal static int __PropertyOffset_PoolPrimeSize;
	}
}
