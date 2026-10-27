using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001427 RID: 5159
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GeometryCollectionEngine.GeometryCollection")]
	[UnrealStructLayout(280, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 280)]
	public class UGeometryCollection : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06012D47 RID: 77127 RVA: 0x001BB16C File Offset: 0x001B936C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGeometryCollection._ClassPtr;
		}

		// Token: 0x06012D48 RID: 77128 RVA: 0x001BB178 File Offset: 0x001B9378
		public UGeometryCollection() : this(BuiltinUtils.AllocNativeUObject(UGeometryCollection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012D49 RID: 77129 RVA: 0x001BB1A0 File Offset: 0x001B93A0
		public UGeometryCollection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGeometryCollection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170048F7 RID: 18679
		// (get) Token: 0x06012D4A RID: 77130 RVA: 0x001BB1D4 File Offset: 0x001B93D4
		// (set) Token: 0x06012D4B RID: 77131 RVA: 0x001BB20D File Offset: 0x001B940D
		public TArray<FGeometryCollectionSource> GeometrySource
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGeometryCollectionSource> result;
				if ((result = this._GeometrySource) == null)
				{
					result = (this._GeometrySource = new TArray<FGeometryCollectionSource>(base.NativePtr + (IntPtr)UGeometryCollection.__PropertyOffset_GeometrySource, this));
				}
				return result;
			}
			set
			{
				this.GeometrySource.CopyAssign(value);
			}
		}

		// Token: 0x170048F8 RID: 18680
		// (get) Token: 0x06012D4C RID: 77132 RVA: 0x001BB21C File Offset: 0x001B941C
		// (set) Token: 0x06012D4D RID: 77133 RVA: 0x001BB255 File Offset: 0x001B9455
		public TArray<UMaterialInterface> Materials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._Materials) == null)
				{
					result = (this._Materials = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)UGeometryCollection.__PropertyOffset_Materials, this));
				}
				return result;
			}
			set
			{
				this.Materials.CopyAssign(value);
			}
		}

		// Token: 0x170048F9 RID: 18681
		// (get) Token: 0x06012D4E RID: 77134 RVA: 0x001BB263 File Offset: 0x001B9463
		// (set) Token: 0x06012D4F RID: 77135 RVA: 0x001BB273 File Offset: 0x001B9473
		public unsafe ECollisionTypeEnum CollisionType
		{
			get
			{
				return (ECollisionTypeEnum)(*(base.NativePtr + (IntPtr)UGeometryCollection.__PropertyOffset_CollisionType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeometryCollection.__PropertyOffset_CollisionType) = (byte)value;
			}
		}

		// Token: 0x170048FA RID: 18682
		// (get) Token: 0x06012D50 RID: 77136 RVA: 0x001BB284 File Offset: 0x001B9484
		// (set) Token: 0x06012D51 RID: 77137 RVA: 0x001BB294 File Offset: 0x001B9494
		public unsafe EImplicitTypeEnum ImplicitType
		{
			get
			{
				return (EImplicitTypeEnum)(*(base.NativePtr + (IntPtr)UGeometryCollection.__PropertyOffset_ImplicitType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeometryCollection.__PropertyOffset_ImplicitType) = (byte)value;
			}
		}

		// Token: 0x170048FB RID: 18683
		// (get) Token: 0x06012D52 RID: 77138 RVA: 0x001BB2A5 File Offset: 0x001B94A5
		// (set) Token: 0x06012D53 RID: 77139 RVA: 0x001BB2B5 File Offset: 0x001B94B5
		public unsafe int MinLevelSetResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeometryCollection.__PropertyOffset_MinLevelSetResolution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeometryCollection.__PropertyOffset_MinLevelSetResolution) = value;
			}
		}

		// Token: 0x170048FC RID: 18684
		// (get) Token: 0x06012D54 RID: 77140 RVA: 0x001BB2C6 File Offset: 0x001B94C6
		// (set) Token: 0x06012D55 RID: 77141 RVA: 0x001BB2D6 File Offset: 0x001B94D6
		public unsafe int MaxLevelSetResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeometryCollection.__PropertyOffset_MaxLevelSetResolution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeometryCollection.__PropertyOffset_MaxLevelSetResolution) = value;
			}
		}

		// Token: 0x170048FD RID: 18685
		// (get) Token: 0x06012D56 RID: 77142 RVA: 0x001BB2E7 File Offset: 0x001B94E7
		// (set) Token: 0x06012D57 RID: 77143 RVA: 0x001BB2F7 File Offset: 0x001B94F7
		public unsafe int MinClusterLevelSetResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeometryCollection.__PropertyOffset_MinClusterLevelSetResolution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeometryCollection.__PropertyOffset_MinClusterLevelSetResolution) = value;
			}
		}

		// Token: 0x170048FE RID: 18686
		// (get) Token: 0x06012D58 RID: 77144 RVA: 0x001BB308 File Offset: 0x001B9508
		// (set) Token: 0x06012D59 RID: 77145 RVA: 0x001BB318 File Offset: 0x001B9518
		public unsafe int MaxClusterLevelSetResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeometryCollection.__PropertyOffset_MaxClusterLevelSetResolution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeometryCollection.__PropertyOffset_MaxClusterLevelSetResolution) = value;
			}
		}

		// Token: 0x170048FF RID: 18687
		// (get) Token: 0x06012D5A RID: 77146 RVA: 0x001BB329 File Offset: 0x001B9529
		// (set) Token: 0x06012D5B RID: 77147 RVA: 0x001BB339 File Offset: 0x001B9539
		public unsafe float CollisionObjectReductionPercentage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeometryCollection.__PropertyOffset_CollisionObjectReductionPercentage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeometryCollection.__PropertyOffset_CollisionObjectReductionPercentage) = value;
			}
		}

		// Token: 0x17004900 RID: 18688
		// (get) Token: 0x06012D5C RID: 77148 RVA: 0x001BB34A File Offset: 0x001B954A
		// (set) Token: 0x06012D5D RID: 77149 RVA: 0x001BB35A File Offset: 0x001B955A
		public unsafe bool bMassAsDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeometryCollection.__PropertyOffset_bMassAsDensity) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeometryCollection.__PropertyOffset_bMassAsDensity) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004901 RID: 18689
		// (get) Token: 0x06012D5E RID: 77150 RVA: 0x001BB36B File Offset: 0x001B956B
		// (set) Token: 0x06012D5F RID: 77151 RVA: 0x001BB37B File Offset: 0x001B957B
		public unsafe float Mass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeometryCollection.__PropertyOffset_Mass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeometryCollection.__PropertyOffset_Mass) = value;
			}
		}

		// Token: 0x17004902 RID: 18690
		// (get) Token: 0x06012D60 RID: 77152 RVA: 0x001BB38C File Offset: 0x001B958C
		// (set) Token: 0x06012D61 RID: 77153 RVA: 0x001BB39C File Offset: 0x001B959C
		public unsafe float MinimumMassClamp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeometryCollection.__PropertyOffset_MinimumMassClamp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeometryCollection.__PropertyOffset_MinimumMassClamp) = value;
			}
		}

		// Token: 0x17004903 RID: 18691
		// (get) Token: 0x06012D62 RID: 77154 RVA: 0x001BB3AD File Offset: 0x001B95AD
		// (set) Token: 0x06012D63 RID: 77155 RVA: 0x001BB3BD File Offset: 0x001B95BD
		public unsafe float CollisionParticlesFraction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeometryCollection.__PropertyOffset_CollisionParticlesFraction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeometryCollection.__PropertyOffset_CollisionParticlesFraction) = value;
			}
		}

		// Token: 0x17004904 RID: 18692
		// (get) Token: 0x06012D64 RID: 77156 RVA: 0x001BB3CE File Offset: 0x001B95CE
		// (set) Token: 0x06012D65 RID: 77157 RVA: 0x001BB3DE File Offset: 0x001B95DE
		public unsafe int MaximumCollisionParticles
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeometryCollection.__PropertyOffset_MaximumCollisionParticles);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeometryCollection.__PropertyOffset_MaximumCollisionParticles) = value;
			}
		}

		// Token: 0x17004905 RID: 18693
		// (get) Token: 0x06012D66 RID: 77158 RVA: 0x001BB3F0 File Offset: 0x001B95F0
		// (set) Token: 0x06012D67 RID: 77159 RVA: 0x001BB429 File Offset: 0x001B9629
		public TArray<FGeometryCollectionSizeSpecificData> SizeSpecificData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGeometryCollectionSizeSpecificData> result;
				if ((result = this._SizeSpecificData) == null)
				{
					result = (this._SizeSpecificData = new TArray<FGeometryCollectionSizeSpecificData>(base.NativePtr + (IntPtr)UGeometryCollection.__PropertyOffset_SizeSpecificData, this));
				}
				return result;
			}
			set
			{
				this.SizeSpecificData.CopyAssign(value);
			}
		}

		// Token: 0x17004906 RID: 18694
		// (get) Token: 0x06012D68 RID: 77160 RVA: 0x001BB437 File Offset: 0x001B9637
		// (set) Token: 0x06012D69 RID: 77161 RVA: 0x001BB447 File Offset: 0x001B9647
		public unsafe bool EnableRemovePiecesOnFracture
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeometryCollection.__PropertyOffset_EnableRemovePiecesOnFracture) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeometryCollection.__PropertyOffset_EnableRemovePiecesOnFracture) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004907 RID: 18695
		// (get) Token: 0x06012D6A RID: 77162 RVA: 0x001BB458 File Offset: 0x001B9658
		// (set) Token: 0x06012D6B RID: 77163 RVA: 0x001BB491 File Offset: 0x001B9691
		public TArray<UMaterialInterface> RemoveOnFractureMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._RemoveOnFractureMaterials) == null)
				{
					result = (this._RemoveOnFractureMaterials = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)UGeometryCollection.__PropertyOffset_RemoveOnFractureMaterials, this));
				}
				return result;
			}
			set
			{
				this.RemoveOnFractureMaterials.CopyAssign(value);
			}
		}

		// Token: 0x17004908 RID: 18696
		// (get) Token: 0x06012D6C RID: 77164 RVA: 0x001BB49F File Offset: 0x001B969F
		// (set) Token: 0x06012D6D RID: 77165 RVA: 0x001BB4B3 File Offset: 0x001B96B3
		public unsafe FGuid PersistentGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeometryCollection.__PropertyOffset_PersistentGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeometryCollection.__PropertyOffset_PersistentGuid) = value;
			}
		}

		// Token: 0x17004909 RID: 18697
		// (get) Token: 0x06012D6E RID: 77166 RVA: 0x001BB4C8 File Offset: 0x001B96C8
		// (set) Token: 0x06012D6F RID: 77167 RVA: 0x001BB4DC File Offset: 0x001B96DC
		public unsafe FGuid StateGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeometryCollection.__PropertyOffset_StateGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeometryCollection.__PropertyOffset_StateGuid) = value;
			}
		}

		// Token: 0x1700490A RID: 18698
		// (get) Token: 0x06012D70 RID: 77168 RVA: 0x001BB4F1 File Offset: 0x001B96F1
		// (set) Token: 0x06012D71 RID: 77169 RVA: 0x001BB501 File Offset: 0x001B9701
		public unsafe int BoneSelectedMaterialIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeometryCollection.__PropertyOffset_BoneSelectedMaterialIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeometryCollection.__PropertyOffset_BoneSelectedMaterialIndex) = value;
			}
		}

		// Token: 0x06012D72 RID: 77170 RVA: 0x001BB512 File Offset: 0x001B9712
		static UGeometryCollection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GeometryCollectionEngine.GeometryCollection");
		}

		// Token: 0x06012D73 RID: 77171 RVA: 0x001BB520 File Offset: 0x001B9720
		protected UGeometryCollection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A0FE RID: 41214
		public new const string __ObjectPath = "/Script/GeometryCollectionEngine.GeometryCollection";

		// Token: 0x0400A0FF RID: 41215
		private static IntPtr _ClassPtr;

		// Token: 0x0400A100 RID: 41216
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A101 RID: 41217
		internal static int __PropertyOffset_GeometrySource;

		// Token: 0x0400A102 RID: 41218
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FGeometryCollectionSource> _GeometrySource;

		// Token: 0x0400A103 RID: 41219
		internal static int __PropertyOffset_Materials;

		// Token: 0x0400A104 RID: 41220
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _Materials;

		// Token: 0x0400A105 RID: 41221
		internal static int __PropertyOffset_CollisionType;

		// Token: 0x0400A106 RID: 41222
		internal static int __PropertyOffset_ImplicitType;

		// Token: 0x0400A107 RID: 41223
		internal static int __PropertyOffset_MinLevelSetResolution;

		// Token: 0x0400A108 RID: 41224
		internal static int __PropertyOffset_MaxLevelSetResolution;

		// Token: 0x0400A109 RID: 41225
		internal static int __PropertyOffset_MinClusterLevelSetResolution;

		// Token: 0x0400A10A RID: 41226
		internal static int __PropertyOffset_MaxClusterLevelSetResolution;

		// Token: 0x0400A10B RID: 41227
		internal static int __PropertyOffset_CollisionObjectReductionPercentage;

		// Token: 0x0400A10C RID: 41228
		internal static int __PropertyOffset_bMassAsDensity;

		// Token: 0x0400A10D RID: 41229
		internal static int __PropertyOffset_Mass;

		// Token: 0x0400A10E RID: 41230
		internal static int __PropertyOffset_MinimumMassClamp;

		// Token: 0x0400A10F RID: 41231
		internal static int __PropertyOffset_CollisionParticlesFraction;

		// Token: 0x0400A110 RID: 41232
		internal static int __PropertyOffset_MaximumCollisionParticles;

		// Token: 0x0400A111 RID: 41233
		internal static int __PropertyOffset_SizeSpecificData;

		// Token: 0x0400A112 RID: 41234
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FGeometryCollectionSizeSpecificData> _SizeSpecificData;

		// Token: 0x0400A113 RID: 41235
		internal static int __PropertyOffset_EnableRemovePiecesOnFracture;

		// Token: 0x0400A114 RID: 41236
		internal static int __PropertyOffset_RemoveOnFractureMaterials;

		// Token: 0x0400A115 RID: 41237
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _RemoveOnFractureMaterials;

		// Token: 0x0400A116 RID: 41238
		internal static int __PropertyOffset_PersistentGuid;

		// Token: 0x0400A117 RID: 41239
		internal static int __PropertyOffset_StateGuid;

		// Token: 0x0400A118 RID: 41240
		internal static int __PropertyOffset_BoneSelectedMaterialIndex;
	}
}
