using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000CF5 RID: 3317
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KuroMaterialVariationCollection")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UKuroMaterialVariationCollection : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B01C RID: 45084 RVA: 0x000F9CD8 File Offset: 0x000F7ED8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroMaterialVariationCollection._ClassPtr;
		}

		// Token: 0x0600B01D RID: 45085 RVA: 0x000F9CE4 File Offset: 0x000F7EE4
		public UKuroMaterialVariationCollection() : this(BuiltinUtils.AllocNativeUObject(UKuroMaterialVariationCollection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B01E RID: 45086 RVA: 0x000F9D0C File Offset: 0x000F7F0C
		public UKuroMaterialVariationCollection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroMaterialVariationCollection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170027D2 RID: 10194
		// (get) Token: 0x0600B01F RID: 45087 RVA: 0x000F9D3F File Offset: 0x000F7F3F
		// (set) Token: 0x0600B020 RID: 45088 RVA: 0x000F9D53 File Offset: 0x000F7F53
		[Nullable(2)]
		public unsafe UMaterialInstance OriginalMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroMaterialVariationCollection.__PropertyOffset_OriginalMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroMaterialVariationCollection.__PropertyOffset_OriginalMaterial, value);
			}
		}

		// Token: 0x170027D3 RID: 10195
		// (get) Token: 0x0600B021 RID: 45089 RVA: 0x000F9D68 File Offset: 0x000F7F68
		// (set) Token: 0x0600B022 RID: 45090 RVA: 0x000F9DA1 File Offset: 0x000F7FA1
		public TArray<FKuroMaterialVariantsInfo> MaterialVariants
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroMaterialVariantsInfo> result;
				if ((result = this._MaterialVariants) == null)
				{
					result = (this._MaterialVariants = new TArray<FKuroMaterialVariantsInfo>(base.NativePtr + (IntPtr)UKuroMaterialVariationCollection.__PropertyOffset_MaterialVariants, this));
				}
				return result;
			}
			set
			{
				this.MaterialVariants.CopyAssign(value);
			}
		}

		// Token: 0x0600B023 RID: 45091 RVA: 0x000F9DAF File Offset: 0x000F7FAF
		static UKuroMaterialVariationCollection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.KuroMaterialVariationCollection");
		}

		// Token: 0x0600B024 RID: 45092 RVA: 0x000F9DBD File Offset: 0x000F7FBD
		protected UKuroMaterialVariationCollection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005C32 RID: 23602
		public new const string __ObjectPath = "/Script/Engine.KuroMaterialVariationCollection";

		// Token: 0x04005C33 RID: 23603
		private static IntPtr _ClassPtr;

		// Token: 0x04005C34 RID: 23604
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005C35 RID: 23605
		internal static int __PropertyOffset_OriginalMaterial;

		// Token: 0x04005C36 RID: 23606
		internal static int __PropertyOffset_MaterialVariants;

		// Token: 0x04005C37 RID: 23607
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroMaterialVariantsInfo> _MaterialVariants;
	}
}
