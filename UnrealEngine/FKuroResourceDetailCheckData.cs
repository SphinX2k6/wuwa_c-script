using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D09 RID: 3337
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KuroResourceDetailCheckData")]
	[UnrealStructLayout(752, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 752)]
	public class FKuroResourceDetailCheckData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B1C2 RID: 45506 RVA: 0x000FC528 File Offset: 0x000FA728
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroResourceDetailCheckData._ScriptStructPtr != 0) ? FKuroResourceDetailCheckData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KuroResourceDetailCheckData", ref FKuroResourceDetailCheckData._ScriptStructPtr);
		}

		// Token: 0x17002854 RID: 10324
		// (get) Token: 0x0600B1C3 RID: 45507 RVA: 0x000FC54C File Offset: 0x000FA74C
		// (set) Token: 0x0600B1C4 RID: 45508 RVA: 0x000FC58F File Offset: 0x000FA78F
		public TArray<FKuroMaterialDetailCheckData> Material
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroMaterialDetailCheckData> result;
				if ((result = this._Material) == null)
				{
					result = (this._Material = new TArray<FKuroMaterialDetailCheckData>(base.NativePtr + (IntPtr)FKuroResourceDetailCheckData.__PropertyOffset_Material, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Material.CopyAssign(value);
			}
		}

		// Token: 0x17002855 RID: 10325
		// (get) Token: 0x0600B1C5 RID: 45509 RVA: 0x000FC5A0 File Offset: 0x000FA7A0
		// (set) Token: 0x0600B1C6 RID: 45510 RVA: 0x000FC5E3 File Offset: 0x000FA7E3
		public TArray<FKuroFoliageDetailCheckData> Foliage
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroFoliageDetailCheckData> result;
				if ((result = this._Foliage) == null)
				{
					result = (this._Foliage = new TArray<FKuroFoliageDetailCheckData>(base.NativePtr + (IntPtr)FKuroResourceDetailCheckData.__PropertyOffset_Foliage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Foliage.CopyAssign(value);
			}
		}

		// Token: 0x17002856 RID: 10326
		// (get) Token: 0x0600B1C7 RID: 45511 RVA: 0x000FC5F4 File Offset: 0x000FA7F4
		// (set) Token: 0x0600B1C8 RID: 45512 RVA: 0x000FC637 File Offset: 0x000FA837
		public TArray<FKuroModelDetailCheckData> Model
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroModelDetailCheckData> result;
				if ((result = this._Model) == null)
				{
					result = (this._Model = new TArray<FKuroModelDetailCheckData>(base.NativePtr + (IntPtr)FKuroResourceDetailCheckData.__PropertyOffset_Model, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Model.CopyAssign(value);
			}
		}

		// Token: 0x17002857 RID: 10327
		// (get) Token: 0x0600B1C9 RID: 45513 RVA: 0x000FC648 File Offset: 0x000FA848
		// (set) Token: 0x0600B1CA RID: 45514 RVA: 0x000FC68B File Offset: 0x000FA88B
		public TArray<FKuroPrefabDetailCheckData> Prefab
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroPrefabDetailCheckData> result;
				if ((result = this._Prefab) == null)
				{
					result = (this._Prefab = new TArray<FKuroPrefabDetailCheckData>(base.NativePtr + (IntPtr)FKuroResourceDetailCheckData.__PropertyOffset_Prefab, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Prefab.CopyAssign(value);
			}
		}

		// Token: 0x17002858 RID: 10328
		// (get) Token: 0x0600B1CB RID: 45515 RVA: 0x000FC69C File Offset: 0x000FA89C
		// (set) Token: 0x0600B1CC RID: 45516 RVA: 0x000FC6DF File Offset: 0x000FA8DF
		public TArray<FKuroTextureDetailCheckData> Texture
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroTextureDetailCheckData> result;
				if ((result = this._Texture) == null)
				{
					result = (this._Texture = new TArray<FKuroTextureDetailCheckData>(base.NativePtr + (IntPtr)FKuroResourceDetailCheckData.__PropertyOffset_Texture, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Texture.CopyAssign(value);
			}
		}

		// Token: 0x17002859 RID: 10329
		// (get) Token: 0x0600B1CD RID: 45517 RVA: 0x000FC6F0 File Offset: 0x000FA8F0
		// (set) Token: 0x0600B1CE RID: 45518 RVA: 0x000FC733 File Offset: 0x000FA933
		public TArray<FKuroOcclusionDetailCheckData> Occlusion
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroOcclusionDetailCheckData> result;
				if ((result = this._Occlusion) == null)
				{
					result = (this._Occlusion = new TArray<FKuroOcclusionDetailCheckData>(base.NativePtr + (IntPtr)FKuroResourceDetailCheckData.__PropertyOffset_Occlusion, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Occlusion.CopyAssign(value);
			}
		}

		// Token: 0x1700285A RID: 10330
		// (get) Token: 0x0600B1CF RID: 45519 RVA: 0x000FC744 File Offset: 0x000FA944
		// (set) Token: 0x0600B1D0 RID: 45520 RVA: 0x000FC787 File Offset: 0x000FA987
		public TArray<string> DetailCheckFolder
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._DetailCheckFolder) == null)
				{
					result = (this._DetailCheckFolder = new TArray<string>(base.NativePtr + (IntPtr)FKuroResourceDetailCheckData.__PropertyOffset_DetailCheckFolder, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DetailCheckFolder.CopyAssign(value);
			}
		}

		// Token: 0x1700285B RID: 10331
		// (get) Token: 0x0600B1D1 RID: 45521 RVA: 0x000FC798 File Offset: 0x000FA998
		// (set) Token: 0x0600B1D2 RID: 45522 RVA: 0x000FC7DB File Offset: 0x000FA9DB
		public TMap<string, FKuroMaterialDetailCheckData> MaterialDetailCheckDataMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FKuroMaterialDetailCheckData> result;
				if ((result = this._MaterialDetailCheckDataMap) == null)
				{
					result = (this._MaterialDetailCheckDataMap = new TMap<string, FKuroMaterialDetailCheckData>(base.NativePtr + (IntPtr)FKuroResourceDetailCheckData.__PropertyOffset_MaterialDetailCheckDataMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MaterialDetailCheckDataMap.CopyAssign(value);
			}
		}

		// Token: 0x1700285C RID: 10332
		// (get) Token: 0x0600B1D3 RID: 45523 RVA: 0x000FC7EC File Offset: 0x000FA9EC
		// (set) Token: 0x0600B1D4 RID: 45524 RVA: 0x000FC82F File Offset: 0x000FAA2F
		public TMap<string, FKuroFoliageDetailCheckData> FoliageDetailCheckDataMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FKuroFoliageDetailCheckData> result;
				if ((result = this._FoliageDetailCheckDataMap) == null)
				{
					result = (this._FoliageDetailCheckDataMap = new TMap<string, FKuroFoliageDetailCheckData>(base.NativePtr + (IntPtr)FKuroResourceDetailCheckData.__PropertyOffset_FoliageDetailCheckDataMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FoliageDetailCheckDataMap.CopyAssign(value);
			}
		}

		// Token: 0x1700285D RID: 10333
		// (get) Token: 0x0600B1D5 RID: 45525 RVA: 0x000FC840 File Offset: 0x000FAA40
		// (set) Token: 0x0600B1D6 RID: 45526 RVA: 0x000FC883 File Offset: 0x000FAA83
		public TMap<string, FKuroModelDetailCheckData> ModelDetailCheckDataMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FKuroModelDetailCheckData> result;
				if ((result = this._ModelDetailCheckDataMap) == null)
				{
					result = (this._ModelDetailCheckDataMap = new TMap<string, FKuroModelDetailCheckData>(base.NativePtr + (IntPtr)FKuroResourceDetailCheckData.__PropertyOffset_ModelDetailCheckDataMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ModelDetailCheckDataMap.CopyAssign(value);
			}
		}

		// Token: 0x1700285E RID: 10334
		// (get) Token: 0x0600B1D7 RID: 45527 RVA: 0x000FC894 File Offset: 0x000FAA94
		// (set) Token: 0x0600B1D8 RID: 45528 RVA: 0x000FC8D7 File Offset: 0x000FAAD7
		public TMap<string, FKuroModelTypeDetailCheckData> ModelTypeDetailCheckDataMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FKuroModelTypeDetailCheckData> result;
				if ((result = this._ModelTypeDetailCheckDataMap) == null)
				{
					result = (this._ModelTypeDetailCheckDataMap = new TMap<string, FKuroModelTypeDetailCheckData>(base.NativePtr + (IntPtr)FKuroResourceDetailCheckData.__PropertyOffset_ModelTypeDetailCheckDataMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ModelTypeDetailCheckDataMap.CopyAssign(value);
			}
		}

		// Token: 0x1700285F RID: 10335
		// (get) Token: 0x0600B1D9 RID: 45529 RVA: 0x000FC8E8 File Offset: 0x000FAAE8
		// (set) Token: 0x0600B1DA RID: 45530 RVA: 0x000FC92B File Offset: 0x000FAB2B
		public TMap<string, FKuroPrefabDetailCheckData> PrefabDetailCheckDataMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FKuroPrefabDetailCheckData> result;
				if ((result = this._PrefabDetailCheckDataMap) == null)
				{
					result = (this._PrefabDetailCheckDataMap = new TMap<string, FKuroPrefabDetailCheckData>(base.NativePtr + (IntPtr)FKuroResourceDetailCheckData.__PropertyOffset_PrefabDetailCheckDataMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PrefabDetailCheckDataMap.CopyAssign(value);
			}
		}

		// Token: 0x17002860 RID: 10336
		// (get) Token: 0x0600B1DB RID: 45531 RVA: 0x000FC93C File Offset: 0x000FAB3C
		// (set) Token: 0x0600B1DC RID: 45532 RVA: 0x000FC97F File Offset: 0x000FAB7F
		public TMap<string, FKuroTextureDetailCheckData> TextureDetailCheckDataMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FKuroTextureDetailCheckData> result;
				if ((result = this._TextureDetailCheckDataMap) == null)
				{
					result = (this._TextureDetailCheckDataMap = new TMap<string, FKuroTextureDetailCheckData>(base.NativePtr + (IntPtr)FKuroResourceDetailCheckData.__PropertyOffset_TextureDetailCheckDataMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TextureDetailCheckDataMap.CopyAssign(value);
			}
		}

		// Token: 0x17002861 RID: 10337
		// (get) Token: 0x0600B1DD RID: 45533 RVA: 0x000FC990 File Offset: 0x000FAB90
		// (set) Token: 0x0600B1DE RID: 45534 RVA: 0x000FC9D3 File Offset: 0x000FABD3
		public TMap<string, FKuroOcclusionDetailCheckData> OcclusionDetailCheckDataMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FKuroOcclusionDetailCheckData> result;
				if ((result = this._OcclusionDetailCheckDataMap) == null)
				{
					result = (this._OcclusionDetailCheckDataMap = new TMap<string, FKuroOcclusionDetailCheckData>(base.NativePtr + (IntPtr)FKuroResourceDetailCheckData.__PropertyOffset_OcclusionDetailCheckDataMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.OcclusionDetailCheckDataMap.CopyAssign(value);
			}
		}

		// Token: 0x17002862 RID: 10338
		// (get) Token: 0x0600B1DF RID: 45535 RVA: 0x000FC9E4 File Offset: 0x000FABE4
		// (set) Token: 0x0600B1E0 RID: 45536 RVA: 0x000FCA27 File Offset: 0x000FAC27
		public TMap<string, FKuroOcclusionDetailCheckData> OcclusionDetailRecordCheckDataMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FKuroOcclusionDetailCheckData> result;
				if ((result = this._OcclusionDetailRecordCheckDataMap) == null)
				{
					result = (this._OcclusionDetailRecordCheckDataMap = new TMap<string, FKuroOcclusionDetailCheckData>(base.NativePtr + (IntPtr)FKuroResourceDetailCheckData.__PropertyOffset_OcclusionDetailRecordCheckDataMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.OcclusionDetailRecordCheckDataMap.CopyAssign(value);
			}
		}

		// Token: 0x0600B1E1 RID: 45537 RVA: 0x000FCA35 File Offset: 0x000FAC35
		public FKuroResourceDetailCheckData()
		{
		}

		// Token: 0x0600B1E2 RID: 45538 RVA: 0x000FCA40 File Offset: 0x000FAC40
		public FKuroResourceDetailCheckData(TArray<FKuroMaterialDetailCheckData> Material, TArray<FKuroFoliageDetailCheckData> Foliage, TArray<FKuroModelDetailCheckData> Model, TArray<FKuroPrefabDetailCheckData> Prefab, TArray<FKuroTextureDetailCheckData> Texture, TArray<FKuroOcclusionDetailCheckData> Occlusion, TArray<string> DetailCheckFolder, TMap<string, FKuroMaterialDetailCheckData> MaterialDetailCheckDataMap, TMap<string, FKuroFoliageDetailCheckData> FoliageDetailCheckDataMap, TMap<string, FKuroModelDetailCheckData> ModelDetailCheckDataMap, TMap<string, FKuroModelTypeDetailCheckData> ModelTypeDetailCheckDataMap, TMap<string, FKuroPrefabDetailCheckData> PrefabDetailCheckDataMap, TMap<string, FKuroTextureDetailCheckData> TextureDetailCheckDataMap, TMap<string, FKuroOcclusionDetailCheckData> OcclusionDetailCheckDataMap, TMap<string, FKuroOcclusionDetailCheckData> OcclusionDetailRecordCheckDataMap)
		{
			this.Material = Material;
			this.Foliage = Foliage;
			this.Model = Model;
			this.Prefab = Prefab;
			this.Texture = Texture;
			this.Occlusion = Occlusion;
			this.DetailCheckFolder = DetailCheckFolder;
			this.MaterialDetailCheckDataMap = MaterialDetailCheckDataMap;
			this.FoliageDetailCheckDataMap = FoliageDetailCheckDataMap;
			this.ModelDetailCheckDataMap = ModelDetailCheckDataMap;
			this.ModelTypeDetailCheckDataMap = ModelTypeDetailCheckDataMap;
			this.PrefabDetailCheckDataMap = PrefabDetailCheckDataMap;
			this.TextureDetailCheckDataMap = TextureDetailCheckDataMap;
			this.OcclusionDetailCheckDataMap = OcclusionDetailCheckDataMap;
			this.OcclusionDetailRecordCheckDataMap = OcclusionDetailRecordCheckDataMap;
		}

		// Token: 0x0600B1E3 RID: 45539 RVA: 0x000FCAC8 File Offset: 0x000FACC8
		protected override IntPtr GetUStructPtr()
		{
			return FKuroResourceDetailCheckData.StaticStruct();
		}

		// Token: 0x0600B1E4 RID: 45540 RVA: 0x000FCAD4 File Offset: 0x000FACD4
		[NullableContext(2)]
		public FKuroResourceDetailCheckData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B1E5 RID: 45541 RVA: 0x000FCADE File Offset: 0x000FACDE
		public FKuroResourceDetailCheckData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B1E6 RID: 45542 RVA: 0x000FCAE9 File Offset: 0x000FACE9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroResourceDetailCheckData(Pointer, false, true);
		}

		// Token: 0x0600B1E7 RID: 45543 RVA: 0x000FCAF3 File Offset: 0x000FACF3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroResourceDetailCheckData(Pointer, MemoryOwner);
		}

		// Token: 0x04005D12 RID: 23826
		public const string __ObjectPath = "/Script/Engine.KuroResourceDetailCheckData";

		// Token: 0x04005D13 RID: 23827
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005D14 RID: 23828
		internal static int __PropertyOffset_Material;

		// Token: 0x04005D15 RID: 23829
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroMaterialDetailCheckData> _Material;

		// Token: 0x04005D16 RID: 23830
		internal static int __PropertyOffset_Foliage;

		// Token: 0x04005D17 RID: 23831
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroFoliageDetailCheckData> _Foliage;

		// Token: 0x04005D18 RID: 23832
		internal static int __PropertyOffset_Model;

		// Token: 0x04005D19 RID: 23833
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroModelDetailCheckData> _Model;

		// Token: 0x04005D1A RID: 23834
		internal static int __PropertyOffset_Prefab;

		// Token: 0x04005D1B RID: 23835
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroPrefabDetailCheckData> _Prefab;

		// Token: 0x04005D1C RID: 23836
		internal static int __PropertyOffset_Texture;

		// Token: 0x04005D1D RID: 23837
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroTextureDetailCheckData> _Texture;

		// Token: 0x04005D1E RID: 23838
		internal static int __PropertyOffset_Occlusion;

		// Token: 0x04005D1F RID: 23839
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroOcclusionDetailCheckData> _Occlusion;

		// Token: 0x04005D20 RID: 23840
		internal static int __PropertyOffset_DetailCheckFolder;

		// Token: 0x04005D21 RID: 23841
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _DetailCheckFolder;

		// Token: 0x04005D22 RID: 23842
		internal static int __PropertyOffset_MaterialDetailCheckDataMap;

		// Token: 0x04005D23 RID: 23843
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, FKuroMaterialDetailCheckData> _MaterialDetailCheckDataMap;

		// Token: 0x04005D24 RID: 23844
		internal static int __PropertyOffset_FoliageDetailCheckDataMap;

		// Token: 0x04005D25 RID: 23845
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, FKuroFoliageDetailCheckData> _FoliageDetailCheckDataMap;

		// Token: 0x04005D26 RID: 23846
		internal static int __PropertyOffset_ModelDetailCheckDataMap;

		// Token: 0x04005D27 RID: 23847
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, FKuroModelDetailCheckData> _ModelDetailCheckDataMap;

		// Token: 0x04005D28 RID: 23848
		internal static int __PropertyOffset_ModelTypeDetailCheckDataMap;

		// Token: 0x04005D29 RID: 23849
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, FKuroModelTypeDetailCheckData> _ModelTypeDetailCheckDataMap;

		// Token: 0x04005D2A RID: 23850
		internal static int __PropertyOffset_PrefabDetailCheckDataMap;

		// Token: 0x04005D2B RID: 23851
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, FKuroPrefabDetailCheckData> _PrefabDetailCheckDataMap;

		// Token: 0x04005D2C RID: 23852
		internal static int __PropertyOffset_TextureDetailCheckDataMap;

		// Token: 0x04005D2D RID: 23853
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, FKuroTextureDetailCheckData> _TextureDetailCheckDataMap;

		// Token: 0x04005D2E RID: 23854
		internal static int __PropertyOffset_OcclusionDetailCheckDataMap;

		// Token: 0x04005D2F RID: 23855
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, FKuroOcclusionDetailCheckData> _OcclusionDetailCheckDataMap;

		// Token: 0x04005D30 RID: 23856
		internal static int __PropertyOffset_OcclusionDetailRecordCheckDataMap;

		// Token: 0x04005D31 RID: 23857
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, FKuroOcclusionDetailCheckData> _OcclusionDetailRecordCheckDataMap;
	}
}
