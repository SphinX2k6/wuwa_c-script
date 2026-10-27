using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020016EF RID: 5871
	[UnrealObjectPath("/Script/KuroBulletCore.KuroBulletBpDataAsset")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public abstract class UKuroBulletBpDataAsset : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015329 RID: 86825 RVA: 0x001F284A File Offset: 0x001F0A4A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroBulletBpDataAsset._ClassPtr;
		}

		// Token: 0x0601532A RID: 86826 RVA: 0x001F2856 File Offset: 0x001F0A56
		static UKuroBulletBpDataAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBulletCore.KuroBulletBpDataAsset");
		}

		// Token: 0x0601532B RID: 86827 RVA: 0x001F2864 File Offset: 0x001F0A64
		protected UKuroBulletBpDataAsset() : this(BuiltinUtils.AllocNativeUObject(UKuroBulletBpDataAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601532C RID: 86828 RVA: 0x001F288C File Offset: 0x001F0A8C
		protected UKuroBulletBpDataAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B8F6 RID: 47350
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBulletCore.KuroBulletBpDataAsset";

		// Token: 0x0400B8F7 RID: 47351
		private static IntPtr _ClassPtr;

		// Token: 0x0400B8F8 RID: 47352
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
