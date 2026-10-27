using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000853 RID: 2131
	[UnrealObjectPath("/Script/Engine.AssetImportData")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UAssetImportData : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060072FE RID: 29438 RVA: 0x000A4C62 File Offset: 0x000A2E62
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAssetImportData._ClassPtr;
		}

		// Token: 0x060072FF RID: 29439 RVA: 0x000A4C70 File Offset: 0x000A2E70
		public UAssetImportData() : this(BuiltinUtils.AllocNativeUObject(UAssetImportData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007300 RID: 29440 RVA: 0x000A4C98 File Offset: 0x000A2E98
		[NullableContext(1)]
		public UAssetImportData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAssetImportData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06007301 RID: 29441 RVA: 0x000A4CCB File Offset: 0x000A2ECB
		static UAssetImportData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AssetImportData");
		}

		// Token: 0x06007302 RID: 29442 RVA: 0x000A4CD9 File Offset: 0x000A2ED9
		protected UAssetImportData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003746 RID: 14150
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AssetImportData";

		// Token: 0x04003747 RID: 14151
		private static IntPtr _ClassPtr;

		// Token: 0x04003748 RID: 14152
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
