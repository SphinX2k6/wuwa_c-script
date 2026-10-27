using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200085A RID: 2138
	[UnrealObjectPath("/Script/Engine.AssetUserData")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UAssetUserData : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007367 RID: 29543 RVA: 0x000A5552 File Offset: 0x000A3752
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAssetUserData._ClassPtr;
		}

		// Token: 0x06007368 RID: 29544 RVA: 0x000A555E File Offset: 0x000A375E
		static UAssetUserData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AssetUserData");
		}

		// Token: 0x06007369 RID: 29545 RVA: 0x000A556C File Offset: 0x000A376C
		protected UAssetUserData() : this(BuiltinUtils.AllocNativeUObject(UAssetUserData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600736A RID: 29546 RVA: 0x000A5594 File Offset: 0x000A3794
		protected UAssetUserData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003781 RID: 14209
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AssetUserData";

		// Token: 0x04003782 RID: 14210
		private static IntPtr _ClassPtr;

		// Token: 0x04003783 RID: 14211
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
