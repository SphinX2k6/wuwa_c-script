using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005CF RID: 1487
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.KuroBpDataAssetGroup")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UKuroBpDataAssetGroup : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060083FB RID: 33787 RVA: 0x000C40AD File Offset: 0x000C22AD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroBpDataAssetGroup._ClassPtr;
		}

		// Token: 0x060083FC RID: 33788 RVA: 0x000C40BC File Offset: 0x000C22BC
		public UKuroBpDataAssetGroup() : this(BuiltinUtils.AllocNativeUObject(UKuroBpDataAssetGroup.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060083FD RID: 33789 RVA: 0x000C40E4 File Offset: 0x000C22E4
		public UKuroBpDataAssetGroup(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroBpDataAssetGroup.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001959 RID: 6489
		// (get) Token: 0x060083FE RID: 33790 RVA: 0x000C4118 File Offset: 0x000C2318
		// (set) Token: 0x060083FF RID: 33791 RVA: 0x000C4151 File Offset: 0x000C2351
		public TArray<UKuroBpDataAsset> Data
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UKuroBpDataAsset> result;
				if ((result = this._Data) == null)
				{
					result = (this._Data = new TArray<UKuroBpDataAsset>(base.NativePtr + (IntPtr)UKuroBpDataAssetGroup.__PropertyOffset_Data, this));
				}
				return result;
			}
			set
			{
				this.Data.CopyAssign(value);
			}
		}

		// Token: 0x06008400 RID: 33792 RVA: 0x000C415F File Offset: 0x000C235F
		static UKuroBpDataAssetGroup()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroBpDataAssetGroup");
		}

		// Token: 0x06008401 RID: 33793 RVA: 0x000C416D File Offset: 0x000C236D
		protected UKuroBpDataAssetGroup(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040039B6 RID: 14774
		public new const string __ObjectPath = "/Script/KuroUtility.KuroBpDataAssetGroup";

		// Token: 0x040039B7 RID: 14775
		private static IntPtr _ClassPtr;

		// Token: 0x040039B8 RID: 14776
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040039B9 RID: 14777
		internal static int __PropertyOffset_Data;

		// Token: 0x040039BA RID: 14778
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKuroBpDataAsset> _Data;
	}
}
