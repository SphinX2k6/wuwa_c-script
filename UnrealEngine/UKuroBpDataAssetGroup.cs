using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EB0 RID: 7856
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.KuroBpDataAssetGroup")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UKuroBpDataAssetGroup : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DD27 RID: 122151 RVA: 0x002C1DDD File Offset: 0x002BFFDD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroBpDataAssetGroup._ClassPtr;
		}

		// Token: 0x0601DD28 RID: 122152 RVA: 0x002C1DEC File Offset: 0x002BFFEC
		public UKuroBpDataAssetGroup() : this(BuiltinUtils.AllocNativeUObject(UKuroBpDataAssetGroup.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DD29 RID: 122153 RVA: 0x002C1E14 File Offset: 0x002C0014
		public UKuroBpDataAssetGroup(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroBpDataAssetGroup.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700779A RID: 30618
		// (get) Token: 0x0601DD2A RID: 122154 RVA: 0x002C1E48 File Offset: 0x002C0048
		// (set) Token: 0x0601DD2B RID: 122155 RVA: 0x002C1E81 File Offset: 0x002C0081
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

		// Token: 0x0601DD2C RID: 122156 RVA: 0x002C1E8F File Offset: 0x002C008F
		static UKuroBpDataAssetGroup()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroBpDataAssetGroup");
		}

		// Token: 0x0601DD2D RID: 122157 RVA: 0x002C1E9D File Offset: 0x002C009D
		protected UKuroBpDataAssetGroup(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401029B RID: 66203
		public new const string __ObjectPath = "/Script/KuroUtility.KuroBpDataAssetGroup";

		// Token: 0x0401029C RID: 66204
		private static IntPtr _ClassPtr;

		// Token: 0x0401029D RID: 66205
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401029E RID: 66206
		internal static int __PropertyOffset_Data;

		// Token: 0x0401029F RID: 66207
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKuroBpDataAsset> _Data;
	}
}
