using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200087C RID: 2172
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BakedBoneInstanceDataAsset")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UBakedBoneInstanceDataAsset : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007645 RID: 30277 RVA: 0x000A9B28 File Offset: 0x000A7D28
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBakedBoneInstanceDataAsset._ClassPtr;
		}

		// Token: 0x06007646 RID: 30278 RVA: 0x000A9B34 File Offset: 0x000A7D34
		public UBakedBoneInstanceDataAsset() : this(BuiltinUtils.AllocNativeUObject(UBakedBoneInstanceDataAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007647 RID: 30279 RVA: 0x000A9B5C File Offset: 0x000A7D5C
		public UBakedBoneInstanceDataAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBakedBoneInstanceDataAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001BFE RID: 7166
		// (get) Token: 0x06007648 RID: 30280 RVA: 0x000A9B90 File Offset: 0x000A7D90
		// (set) Token: 0x06007649 RID: 30281 RVA: 0x000A9BC9 File Offset: 0x000A7DC9
		public TArray<FBakedBoneMeshInstanceGroupLODData> InstanceGroupLODData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBakedBoneMeshInstanceGroupLODData> result;
				if ((result = this._InstanceGroupLODData) == null)
				{
					result = (this._InstanceGroupLODData = new TArray<FBakedBoneMeshInstanceGroupLODData>(base.NativePtr + (IntPtr)UBakedBoneInstanceDataAsset.__PropertyOffset_InstanceGroupLODData, this));
				}
				return result;
			}
			set
			{
				this.InstanceGroupLODData.CopyAssign(value);
			}
		}

		// Token: 0x0600764A RID: 30282 RVA: 0x000A9BD7 File Offset: 0x000A7DD7
		static UBakedBoneInstanceDataAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BakedBoneInstanceDataAsset");
		}

		// Token: 0x0600764B RID: 30283 RVA: 0x000A9BE5 File Offset: 0x000A7DE5
		protected UBakedBoneInstanceDataAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040038F4 RID: 14580
		public new const string __ObjectPath = "/Script/Engine.BakedBoneInstanceDataAsset";

		// Token: 0x040038F5 RID: 14581
		private static IntPtr _ClassPtr;

		// Token: 0x040038F6 RID: 14582
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040038F7 RID: 14583
		internal static int __PropertyOffset_InstanceGroupLODData;

		// Token: 0x040038F8 RID: 14584
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBakedBoneMeshInstanceGroupLODData> _InstanceGroupLODData;
	}
}
