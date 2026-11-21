using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000186 RID: 390
	[UnrealObjectPath("/Script/Engine.AssetImportData")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UAssetImportData : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001922 RID: 6434 RVA: 0x00026176 File Offset: 0x00024376
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAssetImportData._ClassPtr;
		}

		// Token: 0x06001923 RID: 6435 RVA: 0x00026184 File Offset: 0x00024384
		public UAssetImportData() : this(BuiltinUtils.AllocNativeUObject(UAssetImportData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001924 RID: 6436 RVA: 0x000261AC File Offset: 0x000243AC
		[NullableContext(1)]
		public UAssetImportData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAssetImportData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001925 RID: 6437 RVA: 0x000261DF File Offset: 0x000243DF
		static UAssetImportData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AssetImportData");
		}

		// Token: 0x06001926 RID: 6438 RVA: 0x000261ED File Offset: 0x000243ED
		protected UAssetImportData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000812 RID: 2066
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AssetImportData";

		// Token: 0x04000813 RID: 2067
		private static IntPtr _ClassPtr;

		// Token: 0x04000814 RID: 2068
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
