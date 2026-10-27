using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000CC6 RID: 3270
	[UnrealObjectPath("/Script/Engine.KCClothAssetBase")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UKCClothAssetBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A545 RID: 42309 RVA: 0x000EB142 File Offset: 0x000E9342
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKCClothAssetBase._ClassPtr;
		}

		// Token: 0x0600A546 RID: 42310 RVA: 0x000EB14E File Offset: 0x000E934E
		static UKCClothAssetBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.KCClothAssetBase");
		}

		// Token: 0x0600A547 RID: 42311 RVA: 0x000EB15C File Offset: 0x000E935C
		protected UKCClothAssetBase() : this(BuiltinUtils.AllocNativeUObject(UKCClothAssetBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A548 RID: 42312 RVA: 0x000EB184 File Offset: 0x000E9384
		protected UKCClothAssetBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005AE8 RID: 23272
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.KCClothAssetBase";

		// Token: 0x04005AE9 RID: 23273
		private static IntPtr _ClassPtr;

		// Token: 0x04005AEA RID: 23274
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
