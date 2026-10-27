using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000859 RID: 2137
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AssetMappingTable")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UAssetMappingTable : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007360 RID: 29536 RVA: 0x000A548A File Offset: 0x000A368A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAssetMappingTable._ClassPtr;
		}

		// Token: 0x06007361 RID: 29537 RVA: 0x000A5498 File Offset: 0x000A3698
		public UAssetMappingTable() : this(BuiltinUtils.AllocNativeUObject(UAssetMappingTable.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007362 RID: 29538 RVA: 0x000A54C0 File Offset: 0x000A36C0
		public UAssetMappingTable(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAssetMappingTable.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001B38 RID: 6968
		// (get) Token: 0x06007363 RID: 29539 RVA: 0x000A54F4 File Offset: 0x000A36F4
		// (set) Token: 0x06007364 RID: 29540 RVA: 0x000A552D File Offset: 0x000A372D
		public TArray<FAssetMapping> MappedAssets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAssetMapping> result;
				if ((result = this._MappedAssets) == null)
				{
					result = (this._MappedAssets = new TArray<FAssetMapping>(base.NativePtr + (IntPtr)UAssetMappingTable.__PropertyOffset_MappedAssets, this));
				}
				return result;
			}
			set
			{
				this.MappedAssets.CopyAssign(value);
			}
		}

		// Token: 0x06007365 RID: 29541 RVA: 0x000A553B File Offset: 0x000A373B
		static UAssetMappingTable()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AssetMappingTable");
		}

		// Token: 0x06007366 RID: 29542 RVA: 0x000A5549 File Offset: 0x000A3749
		protected UAssetMappingTable(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400377C RID: 14204
		public new const string __ObjectPath = "/Script/Engine.AssetMappingTable";

		// Token: 0x0400377D RID: 14205
		private static IntPtr _ClassPtr;

		// Token: 0x0400377E RID: 14206
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400377F RID: 14207
		internal static int __PropertyOffset_MappedAssets;

		// Token: 0x04003780 RID: 14208
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAssetMapping> _MappedAssets;
	}
}
