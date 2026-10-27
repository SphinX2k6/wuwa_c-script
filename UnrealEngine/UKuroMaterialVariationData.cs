using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000CF6 RID: 3318
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KuroMaterialVariationData")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UKuroMaterialVariationData : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B025 RID: 45093 RVA: 0x000F9DC6 File Offset: 0x000F7FC6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroMaterialVariationData._ClassPtr;
		}

		// Token: 0x0600B026 RID: 45094 RVA: 0x000F9DD4 File Offset: 0x000F7FD4
		public UKuroMaterialVariationData() : this(BuiltinUtils.AllocNativeUObject(UKuroMaterialVariationData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B027 RID: 45095 RVA: 0x000F9DFC File Offset: 0x000F7FFC
		public UKuroMaterialVariationData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroMaterialVariationData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170027D4 RID: 10196
		// (get) Token: 0x0600B028 RID: 45096 RVA: 0x000F9E30 File Offset: 0x000F8030
		// (set) Token: 0x0600B029 RID: 45097 RVA: 0x000F9E69 File Offset: 0x000F8069
		public TArray<UKuroMaterialVariationCollection> VariationData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UKuroMaterialVariationCollection> result;
				if ((result = this._VariationData) == null)
				{
					result = (this._VariationData = new TArray<UKuroMaterialVariationCollection>(base.NativePtr + (IntPtr)UKuroMaterialVariationData.__PropertyOffset_VariationData, this));
				}
				return result;
			}
			set
			{
				this.VariationData.CopyAssign(value);
			}
		}

		// Token: 0x0600B02A RID: 45098 RVA: 0x000F9E77 File Offset: 0x000F8077
		static UKuroMaterialVariationData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.KuroMaterialVariationData");
		}

		// Token: 0x0600B02B RID: 45099 RVA: 0x000F9E85 File Offset: 0x000F8085
		protected UKuroMaterialVariationData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005C38 RID: 23608
		public new const string __ObjectPath = "/Script/Engine.KuroMaterialVariationData";

		// Token: 0x04005C39 RID: 23609
		private static IntPtr _ClassPtr;

		// Token: 0x04005C3A RID: 23610
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005C3B RID: 23611
		internal static int __PropertyOffset_VariationData;

		// Token: 0x04005C3C RID: 23612
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKuroMaterialVariationCollection> _VariationData;
	}
}
