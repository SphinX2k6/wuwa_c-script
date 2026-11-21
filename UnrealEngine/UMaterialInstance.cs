using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200023A RID: 570
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialInstance")]
	[UnrealStructLayout(1888, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1888)]
	public abstract class UMaterialInstance : UMaterialInterface, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060030EF RID: 12527 RVA: 0x00045AB4 File Offset: 0x00043CB4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialInstance._ClassPtr;
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x060030F0 RID: 12528 RVA: 0x00045AC0 File Offset: 0x00043CC0
		// (set) Token: 0x060030F1 RID: 12529 RVA: 0x00045AD4 File Offset: 0x00043CD4
		[Nullable(2)]
		public unsafe UPhysicalMaterial PhysMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicalMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + UMaterialInstance.__PropertyOffset_PhysMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMaterialInstance.__PropertyOffset_PhysMaterial, value);
			}
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x060030F2 RID: 12530 RVA: 0x00045AEC File Offset: 0x00043CEC
		// (set) Token: 0x060030F3 RID: 12531 RVA: 0x00045B26 File Offset: 0x00043D26
		public TFixedArray<UPhysicalMaterial> PhysicalMaterialMap
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<UPhysicalMaterial> result;
				if ((result = this._PhysicalMaterialMap) == null)
				{
					result = (this._PhysicalMaterialMap = new TFixedArray<UPhysicalMaterial>(base.NativePtr + (IntPtr)UMaterialInstance.__PropertyOffset_PhysicalMaterialMap, 8, this));
				}
				return result;
			}
			set
			{
				this.PhysicalMaterialMap.CopyAssign(value);
			}
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x060030F4 RID: 12532 RVA: 0x00045B34 File Offset: 0x00043D34
		// (set) Token: 0x060030F5 RID: 12533 RVA: 0x00045B48 File Offset: 0x00043D48
		[Nullable(2)]
		public unsafe UMaterialInterface Parent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + UMaterialInstance.__PropertyOffset_Parent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMaterialInstance.__PropertyOffset_Parent, value);
			}
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x060030F6 RID: 12534 RVA: 0x00045B5D File Offset: 0x00043D5D
		// (set) Token: 0x060030F7 RID: 12535 RVA: 0x00045B76 File Offset: 0x00043D76
		public unsafe bool bHasStaticPermutationResource
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterialInstance.__PropertyOffset_bHasStaticPermutationResource) & UMaterialInstance.__PropertyMask_bHasStaticPermutationResource) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterialInstance.__PropertyOffset_bHasStaticPermutationResource) = ((*(base.NativePtr + (IntPtr)UMaterialInstance.__PropertyOffset_bHasStaticPermutationResource) & ~UMaterialInstance.__PropertyMask_bHasStaticPermutationResource) | (value ? UMaterialInstance.__PropertyMask_bHasStaticPermutationResource : 0));
			}
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x060030F8 RID: 12536 RVA: 0x00045BA6 File Offset: 0x00043DA6
		// (set) Token: 0x060030F9 RID: 12537 RVA: 0x00045BBF File Offset: 0x00043DBF
		public unsafe bool bOverrideSubsurfaceProfile
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterialInstance.__PropertyOffset_bOverrideSubsurfaceProfile) & UMaterialInstance.__PropertyMask_bOverrideSubsurfaceProfile) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterialInstance.__PropertyOffset_bOverrideSubsurfaceProfile) = ((*(base.NativePtr + (IntPtr)UMaterialInstance.__PropertyOffset_bOverrideSubsurfaceProfile) & ~UMaterialInstance.__PropertyMask_bOverrideSubsurfaceProfile) | (value ? UMaterialInstance.__PropertyMask_bOverrideSubsurfaceProfile : 0));
			}
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x060030FA RID: 12538 RVA: 0x00045BF0 File Offset: 0x00043DF0
		// (set) Token: 0x060030FB RID: 12539 RVA: 0x00045C29 File Offset: 0x00043E29
		public TArray<FTextureParameterValue> TextureParameterValues
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTextureParameterValue> result;
				if ((result = this._TextureParameterValues) == null)
				{
					result = (this._TextureParameterValues = new TArray<FTextureParameterValue>(base.NativePtr + (IntPtr)UMaterialInstance.__PropertyOffset_TextureParameterValues, this));
				}
				return result;
			}
			set
			{
				this.TextureParameterValues.CopyAssign(value);
			}
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x060030FC RID: 12540 RVA: 0x00045C37 File Offset: 0x00043E37
		// (set) Token: 0x060030FD RID: 12541 RVA: 0x00045C47 File Offset: 0x00043E47
		public unsafe int SubMaterialCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialInstance.__PropertyOffset_SubMaterialCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialInstance.__PropertyOffset_SubMaterialCount) = value;
			}
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x060030FE RID: 12542 RVA: 0x00045C58 File Offset: 0x00043E58
		// (set) Token: 0x060030FF RID: 12543 RVA: 0x00045C6C File Offset: 0x00043E6C
		public unsafe FIntPoint CombineAtlasSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialInstance.__PropertyOffset_CombineAtlasSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialInstance.__PropertyOffset_CombineAtlasSize) = value;
			}
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x06003100 RID: 12544 RVA: 0x00045C84 File Offset: 0x00043E84
		// (set) Token: 0x06003101 RID: 12545 RVA: 0x00045CBD File Offset: 0x00043EBD
		public TArray<int> ScalarParameterOffsets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._ScalarParameterOffsets) == null)
				{
					result = (this._ScalarParameterOffsets = new TArray<int>(base.NativePtr + (IntPtr)UMaterialInstance.__PropertyOffset_ScalarParameterOffsets, this));
				}
				return result;
			}
			set
			{
				this.ScalarParameterOffsets.CopyAssign(value);
			}
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x06003102 RID: 12546 RVA: 0x00045CCC File Offset: 0x00043ECC
		// (set) Token: 0x06003103 RID: 12547 RVA: 0x00045D05 File Offset: 0x00043F05
		public TArray<int> VectorParameterOffsets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._VectorParameterOffsets) == null)
				{
					result = (this._VectorParameterOffsets = new TArray<int>(base.NativePtr + (IntPtr)UMaterialInstance.__PropertyOffset_VectorParameterOffsets, this));
				}
				return result;
			}
			set
			{
				this.VectorParameterOffsets.CopyAssign(value);
			}
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x06003104 RID: 12548 RVA: 0x00045D14 File Offset: 0x00043F14
		// (set) Token: 0x06003105 RID: 12549 RVA: 0x00045D4D File Offset: 0x00043F4D
		public TArray<FVector4> UVScaleOffsetInfos
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector4> result;
				if ((result = this._UVScaleOffsetInfos) == null)
				{
					result = (this._UVScaleOffsetInfos = new TArray<FVector4>(base.NativePtr + (IntPtr)UMaterialInstance.__PropertyOffset_UVScaleOffsetInfos, this));
				}
				return result;
			}
			set
			{
				this.UVScaleOffsetInfos.CopyAssign(value);
			}
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x06003106 RID: 12550 RVA: 0x00045D5B File Offset: 0x00043F5B
		// (set) Token: 0x06003107 RID: 12551 RVA: 0x00045D6B File Offset: 0x00043F6B
		public unsafe uint UsageFlagWarnings
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialInstance.__PropertyOffset_UsageFlagWarnings);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialInstance.__PropertyOffset_UsageFlagWarnings) = (int)value;
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x06003108 RID: 12552 RVA: 0x00045D7C File Offset: 0x00043F7C
		// (set) Token: 0x06003109 RID: 12553 RVA: 0x00045DB5 File Offset: 0x00043FB5
		public TArray<UObject> CachedReferencedTextures
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UObject> result;
				if ((result = this._CachedReferencedTextures) == null)
				{
					result = (this._CachedReferencedTextures = new TArray<UObject>(base.NativePtr + (IntPtr)UMaterialInstance.__PropertyOffset_CachedReferencedTextures, this));
				}
				return result;
			}
			set
			{
				this.CachedReferencedTextures.CopyAssign(value);
			}
		}

		// Token: 0x0600310A RID: 12554 RVA: 0x00045DC3 File Offset: 0x00043FC3
		static UMaterialInstance()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialInstance");
		}

		// Token: 0x0600310B RID: 12555 RVA: 0x00045DD4 File Offset: 0x00043FD4
		protected UMaterialInstance() : this(BuiltinUtils.AllocNativeUObject(UMaterialInstance.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600310C RID: 12556 RVA: 0x00045DFC File Offset: 0x00043FFC
		protected UMaterialInstance(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040010B5 RID: 4277
		public new const string __ObjectPath = "/Script/Engine.MaterialInstance";

		// Token: 0x040010B6 RID: 4278
		private static IntPtr _ClassPtr;

		// Token: 0x040010B7 RID: 4279
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040010B8 RID: 4280
		internal static int __PropertyOffset_PhysMaterial;

		// Token: 0x040010B9 RID: 4281
		internal static int __PropertyOffset_PhysicalMaterialMap;

		// Token: 0x040010BA RID: 4282
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<UPhysicalMaterial> _PhysicalMaterialMap;

		// Token: 0x040010BB RID: 4283
		internal static int __PropertyOffset_Parent;

		// Token: 0x040010BC RID: 4284
		internal static int __PropertyOffset_bHasStaticPermutationResource;

		// Token: 0x040010BD RID: 4285
		internal static byte __PropertyMask_bHasStaticPermutationResource;

		// Token: 0x040010BE RID: 4286
		internal static int __PropertyOffset_bOverrideSubsurfaceProfile;

		// Token: 0x040010BF RID: 4287
		internal static byte __PropertyMask_bOverrideSubsurfaceProfile;

		// Token: 0x040010C0 RID: 4288
		internal static int __PropertyOffset_TextureParameterValues;

		// Token: 0x040010C1 RID: 4289
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FTextureParameterValue> _TextureParameterValues;

		// Token: 0x040010C2 RID: 4290
		internal static int __PropertyOffset_SubMaterialCount;

		// Token: 0x040010C3 RID: 4291
		internal static int __PropertyOffset_CombineAtlasSize;

		// Token: 0x040010C4 RID: 4292
		internal static int __PropertyOffset_ScalarParameterOffsets;

		// Token: 0x040010C5 RID: 4293
		[Nullable(2)]
		private TArray<int> _ScalarParameterOffsets;

		// Token: 0x040010C6 RID: 4294
		internal static int __PropertyOffset_VectorParameterOffsets;

		// Token: 0x040010C7 RID: 4295
		[Nullable(2)]
		private TArray<int> _VectorParameterOffsets;

		// Token: 0x040010C8 RID: 4296
		internal static int __PropertyOffset_UVScaleOffsetInfos;

		// Token: 0x040010C9 RID: 4297
		[Nullable(2)]
		private TArray<FVector4> _UVScaleOffsetInfos;

		// Token: 0x040010CA RID: 4298
		internal static int __PropertyOffset_UsageFlagWarnings;

		// Token: 0x040010CB RID: 4299
		internal static int __PropertyOffset_CachedReferencedTextures;

		// Token: 0x040010CC RID: 4300
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _CachedReferencedTextures;
	}
}
