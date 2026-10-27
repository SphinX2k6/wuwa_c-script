using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020016F0 RID: 5872
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroBulletCore.KuroBulletBpDataAssetGroup")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UKuroBulletBpDataAssetGroup : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601532D RID: 86829 RVA: 0x001F2895 File Offset: 0x001F0A95
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroBulletBpDataAssetGroup._ClassPtr;
		}

		// Token: 0x0601532E RID: 86830 RVA: 0x001F28A4 File Offset: 0x001F0AA4
		public UKuroBulletBpDataAssetGroup() : this(BuiltinUtils.AllocNativeUObject(UKuroBulletBpDataAssetGroup.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601532F RID: 86831 RVA: 0x001F28CC File Offset: 0x001F0ACC
		public UKuroBulletBpDataAssetGroup(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroBulletBpDataAssetGroup.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170053CD RID: 21453
		// (get) Token: 0x06015330 RID: 86832 RVA: 0x001F2900 File Offset: 0x001F0B00
		// (set) Token: 0x06015331 RID: 86833 RVA: 0x001F2939 File Offset: 0x001F0B39
		public TArray<UKuroBulletBpDataAsset> Data
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UKuroBulletBpDataAsset> result;
				if ((result = this._Data) == null)
				{
					result = (this._Data = new TArray<UKuroBulletBpDataAsset>(base.NativePtr + (IntPtr)UKuroBulletBpDataAssetGroup.__PropertyOffset_Data, this));
				}
				return result;
			}
			set
			{
				this.Data.CopyAssign(value);
			}
		}

		// Token: 0x06015332 RID: 86834 RVA: 0x001F2947 File Offset: 0x001F0B47
		static UKuroBulletBpDataAssetGroup()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBulletCore.KuroBulletBpDataAssetGroup");
		}

		// Token: 0x06015333 RID: 86835 RVA: 0x001F2955 File Offset: 0x001F0B55
		protected UKuroBulletBpDataAssetGroup(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B8F9 RID: 47353
		public new const string __ObjectPath = "/Script/KuroBulletCore.KuroBulletBpDataAssetGroup";

		// Token: 0x0400B8FA RID: 47354
		private static IntPtr _ClassPtr;

		// Token: 0x0400B8FB RID: 47355
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B8FC RID: 47356
		internal static int __PropertyOffset_Data;

		// Token: 0x0400B8FD RID: 47357
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKuroBulletBpDataAsset> _Data;
	}
}
