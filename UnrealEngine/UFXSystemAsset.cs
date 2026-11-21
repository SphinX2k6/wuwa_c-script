using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000211 RID: 529
	[UnrealObjectPath("/Script/Engine.FXSystemAsset")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public abstract class UFXSystemAsset : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060021F0 RID: 8688 RVA: 0x00031C0F File Offset: 0x0002FE0F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UFXSystemAsset._ClassPtr;
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x060021F1 RID: 8689 RVA: 0x00031C1B File Offset: 0x0002FE1B
		// (set) Token: 0x060021F2 RID: 8690 RVA: 0x00031C2B File Offset: 0x0002FE2B
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

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x060021F3 RID: 8691 RVA: 0x00031C3C File Offset: 0x0002FE3C
		// (set) Token: 0x060021F4 RID: 8692 RVA: 0x00031C4C File Offset: 0x0002FE4C
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

		// Token: 0x060021F5 RID: 8693 RVA: 0x00031C5D File Offset: 0x0002FE5D
		static UFXSystemAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.FXSystemAsset");
		}

		// Token: 0x060021F6 RID: 8694 RVA: 0x00031C6C File Offset: 0x0002FE6C
		protected UFXSystemAsset() : this(BuiltinUtils.AllocNativeUObject(UFXSystemAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060021F7 RID: 8695 RVA: 0x00031C94 File Offset: 0x0002FE94
		protected UFXSystemAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000D4C RID: 3404
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.FXSystemAsset";

		// Token: 0x04000D4D RID: 3405
		private static IntPtr _ClassPtr;

		// Token: 0x04000D4E RID: 3406
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000D4F RID: 3407
		internal static int __PropertyOffset_MaxPoolSize;

		// Token: 0x04000D50 RID: 3408
		internal static int __PropertyOffset_PoolPrimeSize;
	}
}
