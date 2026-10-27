using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B72 RID: 7026
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialVariationRuntimeInfo")]
	[UnrealStructLayout(592, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 592)]
	public class FKuroMaterialVariationRuntimeInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A993 RID: 108947 RVA: 0x00273523 File Offset: 0x00271723
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMaterialVariationRuntimeInfo._ScriptStructPtr != 0) ? FKuroMaterialVariationRuntimeInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialVariationRuntimeInfo", ref FKuroMaterialVariationRuntimeInfo._ScriptStructPtr);
		}

		// Token: 0x17006AD1 RID: 27345
		// (get) Token: 0x0601A994 RID: 108948 RVA: 0x00273548 File Offset: 0x00271748
		// (set) Token: 0x0601A995 RID: 108949 RVA: 0x0027358B File Offset: 0x0027178B
		public TArray<FName> ActiveKeyword
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._ActiveKeyword) == null)
				{
					result = (this._ActiveKeyword = new TArray<FName>(base.NativePtr + (IntPtr)FKuroMaterialVariationRuntimeInfo.__PropertyOffset_ActiveKeyword, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ActiveKeyword.CopyAssign(value);
			}
		}

		// Token: 0x17006AD2 RID: 27346
		// (get) Token: 0x0601A996 RID: 108950 RVA: 0x00273599 File Offset: 0x00271799
		// (set) Token: 0x0601A997 RID: 108951 RVA: 0x002735AD File Offset: 0x002717AD
		[Nullable(2)]
		public unsafe UKuroMaterialVariationCollection MaterialVariationData
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroMaterialVariationCollection>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMaterialVariationRuntimeInfo.__PropertyOffset_MaterialVariationData);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMaterialVariationRuntimeInfo.__PropertyOffset_MaterialVariationData, value);
			}
		}

		// Token: 0x17006AD3 RID: 27347
		// (get) Token: 0x0601A998 RID: 108952 RVA: 0x002735C4 File Offset: 0x002717C4
		// (set) Token: 0x0601A999 RID: 108953 RVA: 0x00273607 File Offset: 0x00271807
		public TArray<FKuroDynamicMaterialCache> DynamicMaterialCache
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroDynamicMaterialCache> result;
				if ((result = this._DynamicMaterialCache) == null)
				{
					result = (this._DynamicMaterialCache = new TArray<FKuroDynamicMaterialCache>(base.NativePtr + (IntPtr)FKuroMaterialVariationRuntimeInfo.__PropertyOffset_DynamicMaterialCache, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DynamicMaterialCache.CopyAssign(value);
			}
		}

		// Token: 0x17006AD4 RID: 27348
		// (get) Token: 0x0601A99A RID: 108954 RVA: 0x00273618 File Offset: 0x00271818
		// (set) Token: 0x0601A99B RID: 108955 RVA: 0x0027365B File Offset: 0x0027185B
		public TMap<FName, float> FloatPropertyCache
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._FloatPropertyCache) == null)
				{
					result = (this._FloatPropertyCache = new TMap<FName, float>(base.NativePtr + (IntPtr)FKuroMaterialVariationRuntimeInfo.__PropertyOffset_FloatPropertyCache, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FloatPropertyCache.CopyAssign(value);
			}
		}

		// Token: 0x17006AD5 RID: 27349
		// (get) Token: 0x0601A99C RID: 108956 RVA: 0x0027366C File Offset: 0x0027186C
		// (set) Token: 0x0601A99D RID: 108957 RVA: 0x002736AF File Offset: 0x002718AF
		public TMap<FName, FLinearColor> LinearColorPropertyCache
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLinearColor> result;
				if ((result = this._LinearColorPropertyCache) == null)
				{
					result = (this._LinearColorPropertyCache = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)FKuroMaterialVariationRuntimeInfo.__PropertyOffset_LinearColorPropertyCache, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.LinearColorPropertyCache.CopyAssign(value);
			}
		}

		// Token: 0x17006AD6 RID: 27350
		// (get) Token: 0x0601A99E RID: 108958 RVA: 0x002736C0 File Offset: 0x002718C0
		// (set) Token: 0x0601A99F RID: 108959 RVA: 0x00273703 File Offset: 0x00271903
		public TMap<FName, UTexture> TexturePropertyCache
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, UTexture> result;
				if ((result = this._TexturePropertyCache) == null)
				{
					result = (this._TexturePropertyCache = new TMap<FName, UTexture>(base.NativePtr + (IntPtr)FKuroMaterialVariationRuntimeInfo.__PropertyOffset_TexturePropertyCache, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TexturePropertyCache.CopyAssign(value);
			}
		}

		// Token: 0x17006AD7 RID: 27351
		// (get) Token: 0x0601A9A0 RID: 108960 RVA: 0x00273714 File Offset: 0x00271914
		// (set) Token: 0x0601A9A1 RID: 108961 RVA: 0x00273757 File Offset: 0x00271957
		public TMap<FName, float> OriginalFloatPropertyCache
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._OriginalFloatPropertyCache) == null)
				{
					result = (this._OriginalFloatPropertyCache = new TMap<FName, float>(base.NativePtr + (IntPtr)FKuroMaterialVariationRuntimeInfo.__PropertyOffset_OriginalFloatPropertyCache, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.OriginalFloatPropertyCache.CopyAssign(value);
			}
		}

		// Token: 0x17006AD8 RID: 27352
		// (get) Token: 0x0601A9A2 RID: 108962 RVA: 0x00273768 File Offset: 0x00271968
		// (set) Token: 0x0601A9A3 RID: 108963 RVA: 0x002737AB File Offset: 0x002719AB
		public TMap<FName, FLinearColor> OriginalLinearColorPropertyCache
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLinearColor> result;
				if ((result = this._OriginalLinearColorPropertyCache) == null)
				{
					result = (this._OriginalLinearColorPropertyCache = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)FKuroMaterialVariationRuntimeInfo.__PropertyOffset_OriginalLinearColorPropertyCache, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.OriginalLinearColorPropertyCache.CopyAssign(value);
			}
		}

		// Token: 0x17006AD9 RID: 27353
		// (get) Token: 0x0601A9A4 RID: 108964 RVA: 0x002737BC File Offset: 0x002719BC
		// (set) Token: 0x0601A9A5 RID: 108965 RVA: 0x002737FF File Offset: 0x002719FF
		public TMap<FName, UTexture> OriginalTexturePropertyCache
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, UTexture> result;
				if ((result = this._OriginalTexturePropertyCache) == null)
				{
					result = (this._OriginalTexturePropertyCache = new TMap<FName, UTexture>(base.NativePtr + (IntPtr)FKuroMaterialVariationRuntimeInfo.__PropertyOffset_OriginalTexturePropertyCache, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.OriginalTexturePropertyCache.CopyAssign(value);
			}
		}

		// Token: 0x17006ADA RID: 27354
		// (get) Token: 0x0601A9A6 RID: 108966 RVA: 0x0027380D File Offset: 0x00271A0D
		// (set) Token: 0x0601A9A7 RID: 108967 RVA: 0x00273821 File Offset: 0x00271A21
		[Nullable(2)]
		public unsafe UMaterialInterface CurrentUseMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMaterialVariationRuntimeInfo.__PropertyOffset_CurrentUseMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMaterialVariationRuntimeInfo.__PropertyOffset_CurrentUseMaterial, value);
			}
		}

		// Token: 0x17006ADB RID: 27355
		// (get) Token: 0x0601A9A8 RID: 108968 RVA: 0x00273836 File Offset: 0x00271A36
		// (set) Token: 0x0601A9A9 RID: 108969 RVA: 0x0027384A File Offset: 0x00271A4A
		[Nullable(2)]
		public unsafe UMaterialInterface CurrentReplaceMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMaterialVariationRuntimeInfo.__PropertyOffset_CurrentReplaceMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMaterialVariationRuntimeInfo.__PropertyOffset_CurrentReplaceMaterial, value);
			}
		}

		// Token: 0x17006ADC RID: 27356
		// (get) Token: 0x0601A9AA RID: 108970 RVA: 0x0027385F File Offset: 0x00271A5F
		// (set) Token: 0x0601A9AB RID: 108971 RVA: 0x00273873 File Offset: 0x00271A73
		[Nullable(2)]
		public unsafe USkeletalMeshComponent SkelComp
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMaterialVariationRuntimeInfo.__PropertyOffset_SkelComp);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMaterialVariationRuntimeInfo.__PropertyOffset_SkelComp, value);
			}
		}

		// Token: 0x17006ADD RID: 27357
		// (get) Token: 0x0601A9AC RID: 108972 RVA: 0x00273888 File Offset: 0x00271A88
		// (set) Token: 0x0601A9AD RID: 108973 RVA: 0x0027389C File Offset: 0x00271A9C
		[Nullable(2)]
		public unsafe UStaticMeshComponent StaticComp
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMaterialVariationRuntimeInfo.__PropertyOffset_StaticComp);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMaterialVariationRuntimeInfo.__PropertyOffset_StaticComp, value);
			}
		}

		// Token: 0x17006ADE RID: 27358
		// (get) Token: 0x0601A9AE RID: 108974 RVA: 0x002738B1 File Offset: 0x00271AB1
		// (set) Token: 0x0601A9AF RID: 108975 RVA: 0x002738C1 File Offset: 0x00271AC1
		public unsafe int MaterialSlotIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialVariationRuntimeInfo.__PropertyOffset_MaterialSlotIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialVariationRuntimeInfo.__PropertyOffset_MaterialSlotIndex) = value;
			}
		}

		// Token: 0x0601A9B0 RID: 108976 RVA: 0x002738D2 File Offset: 0x00271AD2
		public FKuroMaterialVariationRuntimeInfo()
		{
		}

		// Token: 0x0601A9B1 RID: 108977 RVA: 0x002738DC File Offset: 0x00271ADC
		public FKuroMaterialVariationRuntimeInfo(TArray<FName> ActiveKeyword, UKuroMaterialVariationCollection MaterialVariationData, TArray<FKuroDynamicMaterialCache> DynamicMaterialCache, TMap<FName, float> FloatPropertyCache, TMap<FName, FLinearColor> LinearColorPropertyCache, TMap<FName, UTexture> TexturePropertyCache, TMap<FName, float> OriginalFloatPropertyCache, TMap<FName, FLinearColor> OriginalLinearColorPropertyCache, TMap<FName, UTexture> OriginalTexturePropertyCache, UMaterialInterface CurrentUseMaterial, UMaterialInterface CurrentReplaceMaterial, USkeletalMeshComponent SkelComp, UStaticMeshComponent StaticComp, int MaterialSlotIndex)
		{
			this.ActiveKeyword = ActiveKeyword;
			this.MaterialVariationData = MaterialVariationData;
			this.DynamicMaterialCache = DynamicMaterialCache;
			this.FloatPropertyCache = FloatPropertyCache;
			this.LinearColorPropertyCache = LinearColorPropertyCache;
			this.TexturePropertyCache = TexturePropertyCache;
			this.OriginalFloatPropertyCache = OriginalFloatPropertyCache;
			this.OriginalLinearColorPropertyCache = OriginalLinearColorPropertyCache;
			this.OriginalTexturePropertyCache = OriginalTexturePropertyCache;
			this.CurrentUseMaterial = CurrentUseMaterial;
			this.CurrentReplaceMaterial = CurrentReplaceMaterial;
			this.SkelComp = SkelComp;
			this.StaticComp = StaticComp;
			this.MaterialSlotIndex = MaterialSlotIndex;
		}

		// Token: 0x0601A9B2 RID: 108978 RVA: 0x0027395C File Offset: 0x00271B5C
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMaterialVariationRuntimeInfo.StaticStruct();
		}

		// Token: 0x0601A9B3 RID: 108979 RVA: 0x00273968 File Offset: 0x00271B68
		[NullableContext(2)]
		public FKuroMaterialVariationRuntimeInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A9B4 RID: 108980 RVA: 0x00273972 File Offset: 0x00271B72
		public FKuroMaterialVariationRuntimeInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A9B5 RID: 108981 RVA: 0x0027397D File Offset: 0x00271B7D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMaterialVariationRuntimeInfo(Pointer, false, true);
		}

		// Token: 0x0601A9B6 RID: 108982 RVA: 0x00273987 File Offset: 0x00271B87
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMaterialVariationRuntimeInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400E64F RID: 58959
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialVariationRuntimeInfo";

		// Token: 0x0400E650 RID: 58960
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E651 RID: 58961
		internal static int __PropertyOffset_ActiveKeyword;

		// Token: 0x0400E652 RID: 58962
		[Nullable(2)]
		private TArray<FName> _ActiveKeyword;

		// Token: 0x0400E653 RID: 58963
		internal static int __PropertyOffset_MaterialVariationData;

		// Token: 0x0400E654 RID: 58964
		internal static int __PropertyOffset_DynamicMaterialCache;

		// Token: 0x0400E655 RID: 58965
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroDynamicMaterialCache> _DynamicMaterialCache;

		// Token: 0x0400E656 RID: 58966
		internal static int __PropertyOffset_FloatPropertyCache;

		// Token: 0x0400E657 RID: 58967
		[Nullable(2)]
		private TMap<FName, float> _FloatPropertyCache;

		// Token: 0x0400E658 RID: 58968
		internal static int __PropertyOffset_LinearColorPropertyCache;

		// Token: 0x0400E659 RID: 58969
		[Nullable(2)]
		private TMap<FName, FLinearColor> _LinearColorPropertyCache;

		// Token: 0x0400E65A RID: 58970
		internal static int __PropertyOffset_TexturePropertyCache;

		// Token: 0x0400E65B RID: 58971
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UTexture> _TexturePropertyCache;

		// Token: 0x0400E65C RID: 58972
		internal static int __PropertyOffset_OriginalFloatPropertyCache;

		// Token: 0x0400E65D RID: 58973
		[Nullable(2)]
		private TMap<FName, float> _OriginalFloatPropertyCache;

		// Token: 0x0400E65E RID: 58974
		internal static int __PropertyOffset_OriginalLinearColorPropertyCache;

		// Token: 0x0400E65F RID: 58975
		[Nullable(2)]
		private TMap<FName, FLinearColor> _OriginalLinearColorPropertyCache;

		// Token: 0x0400E660 RID: 58976
		internal static int __PropertyOffset_OriginalTexturePropertyCache;

		// Token: 0x0400E661 RID: 58977
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UTexture> _OriginalTexturePropertyCache;

		// Token: 0x0400E662 RID: 58978
		internal static int __PropertyOffset_CurrentUseMaterial;

		// Token: 0x0400E663 RID: 58979
		internal static int __PropertyOffset_CurrentReplaceMaterial;

		// Token: 0x0400E664 RID: 58980
		internal static int __PropertyOffset_SkelComp;

		// Token: 0x0400E665 RID: 58981
		internal static int __PropertyOffset_StaticComp;

		// Token: 0x0400E666 RID: 58982
		internal static int __PropertyOffset_MaterialSlotIndex;
	}
}
