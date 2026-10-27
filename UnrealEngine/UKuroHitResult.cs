using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020017F8 RID: 6136
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroData.KuroHitResult")]
	[UnrealStructLayout(584, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 584)]
	public class UKuroHitResult : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06016B12 RID: 92946 RVA: 0x00211D86 File Offset: 0x0020FF86
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroHitResult._ClassPtr;
		}

		// Token: 0x06016B13 RID: 92947 RVA: 0x00211D94 File Offset: 0x0020FF94
		public UKuroHitResult() : this(BuiltinUtils.AllocNativeUObject(UKuroHitResult.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06016B14 RID: 92948 RVA: 0x00211DBC File Offset: 0x0020FFBC
		public UKuroHitResult(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroHitResult.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005BB5 RID: 23477
		// (get) Token: 0x06016B15 RID: 92949 RVA: 0x00211DEF File Offset: 0x0020FFEF
		// (set) Token: 0x06016B16 RID: 92950 RVA: 0x00211DFF File Offset: 0x0020FFFF
		public unsafe bool bBlockingHit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroHitResult.__PropertyOffset_bBlockingHit) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroHitResult.__PropertyOffset_bBlockingHit) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005BB6 RID: 23478
		// (get) Token: 0x06016B17 RID: 92951 RVA: 0x00211E10 File Offset: 0x00210010
		// (set) Token: 0x06016B18 RID: 92952 RVA: 0x00211E20 File Offset: 0x00210020
		public unsafe bool bStartPenetrating
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroHitResult.__PropertyOffset_bStartPenetrating) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroHitResult.__PropertyOffset_bStartPenetrating) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005BB7 RID: 23479
		// (get) Token: 0x06016B19 RID: 92953 RVA: 0x00211E34 File Offset: 0x00210034
		// (set) Token: 0x06016B1A RID: 92954 RVA: 0x00211E6D File Offset: 0x0021006D
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TWeakObjectPtr<AActor>> Actors
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TWeakObjectPtr<AActor>> result;
				if ((result = this._Actors) == null)
				{
					result = (this._Actors = new TArray<TWeakObjectPtr<AActor>>(base.NativePtr + (IntPtr)UKuroHitResult.__PropertyOffset_Actors, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.Actors.CopyAssign(value);
			}
		}

		// Token: 0x17005BB8 RID: 23480
		// (get) Token: 0x06016B1B RID: 92955 RVA: 0x00211E7C File Offset: 0x0021007C
		// (set) Token: 0x06016B1C RID: 92956 RVA: 0x00211EB5 File Offset: 0x002100B5
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TWeakObjectPtr<UPrimitiveComponent>> Components
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TWeakObjectPtr<UPrimitiveComponent>> result;
				if ((result = this._Components) == null)
				{
					result = (this._Components = new TArray<TWeakObjectPtr<UPrimitiveComponent>>(base.NativePtr + (IntPtr)UKuroHitResult.__PropertyOffset_Components, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.Components.CopyAssign(value);
			}
		}

		// Token: 0x17005BB9 RID: 23481
		// (get) Token: 0x06016B1D RID: 92957 RVA: 0x00211EC4 File Offset: 0x002100C4
		// (set) Token: 0x06016B1E RID: 92958 RVA: 0x00211EFD File Offset: 0x002100FD
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TWeakObjectPtr<UPhysicalMaterial>> PhysMaterials
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TWeakObjectPtr<UPhysicalMaterial>> result;
				if ((result = this._PhysMaterials) == null)
				{
					result = (this._PhysMaterials = new TArray<TWeakObjectPtr<UPhysicalMaterial>>(base.NativePtr + (IntPtr)UKuroHitResult.__PropertyOffset_PhysMaterials, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.PhysMaterials.CopyAssign(value);
			}
		}

		// Token: 0x17005BBA RID: 23482
		// (get) Token: 0x06016B1F RID: 92959 RVA: 0x00211F0C File Offset: 0x0021010C
		// (set) Token: 0x06016B20 RID: 92960 RVA: 0x00211F45 File Offset: 0x00210145
		public TArray<string> BoneNameArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._BoneNameArray) == null)
				{
					result = (this._BoneNameArray = new TArray<string>(base.NativePtr + (IntPtr)UKuroHitResult.__PropertyOffset_BoneNameArray, this));
				}
				return result;
			}
			set
			{
				this.BoneNameArray.CopyAssign(value);
			}
		}

		// Token: 0x17005BBB RID: 23483
		// (get) Token: 0x06016B21 RID: 92961 RVA: 0x00211F54 File Offset: 0x00210154
		// (set) Token: 0x06016B22 RID: 92962 RVA: 0x00211F8D File Offset: 0x0021018D
		public TArray<byte> ElementIndexArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._ElementIndexArray) == null)
				{
					result = (this._ElementIndexArray = new TArray<byte>(base.NativePtr + (IntPtr)UKuroHitResult.__PropertyOffset_ElementIndexArray, this));
				}
				return result;
			}
			set
			{
				this.ElementIndexArray.CopyAssign(value);
			}
		}

		// Token: 0x17005BBC RID: 23484
		// (get) Token: 0x06016B23 RID: 92963 RVA: 0x00211F9C File Offset: 0x0021019C
		// (set) Token: 0x06016B24 RID: 92964 RVA: 0x00211FD5 File Offset: 0x002101D5
		public TArray<int> FaceIndexArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._FaceIndexArray) == null)
				{
					result = (this._FaceIndexArray = new TArray<int>(base.NativePtr + (IntPtr)UKuroHitResult.__PropertyOffset_FaceIndexArray, this));
				}
				return result;
			}
			set
			{
				this.FaceIndexArray.CopyAssign(value);
			}
		}

		// Token: 0x17005BBD RID: 23485
		// (get) Token: 0x06016B25 RID: 92965 RVA: 0x00211FE4 File Offset: 0x002101E4
		// (set) Token: 0x06016B26 RID: 92966 RVA: 0x0021201D File Offset: 0x0021021D
		public TArray<int> ItemArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._ItemArray) == null)
				{
					result = (this._ItemArray = new TArray<int>(base.NativePtr + (IntPtr)UKuroHitResult.__PropertyOffset_ItemArray, this));
				}
				return result;
			}
			set
			{
				this.ItemArray.CopyAssign(value);
			}
		}

		// Token: 0x17005BBE RID: 23486
		// (get) Token: 0x06016B27 RID: 92967 RVA: 0x0021202C File Offset: 0x0021022C
		// (set) Token: 0x06016B28 RID: 92968 RVA: 0x00212065 File Offset: 0x00210265
		public TArray<float> DistanceArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._DistanceArray) == null)
				{
					result = (this._DistanceArray = new TArray<float>(base.NativePtr + (IntPtr)UKuroHitResult.__PropertyOffset_DistanceArray, this));
				}
				return result;
			}
			set
			{
				this.DistanceArray.CopyAssign(value);
			}
		}

		// Token: 0x17005BBF RID: 23487
		// (get) Token: 0x06016B29 RID: 92969 RVA: 0x00212074 File Offset: 0x00210274
		// (set) Token: 0x06016B2A RID: 92970 RVA: 0x002120AD File Offset: 0x002102AD
		public TArray<float> PenetrationDepthArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._PenetrationDepthArray) == null)
				{
					result = (this._PenetrationDepthArray = new TArray<float>(base.NativePtr + (IntPtr)UKuroHitResult.__PropertyOffset_PenetrationDepthArray, this));
				}
				return result;
			}
			set
			{
				this.PenetrationDepthArray.CopyAssign(value);
			}
		}

		// Token: 0x17005BC0 RID: 23488
		// (get) Token: 0x06016B2B RID: 92971 RVA: 0x002120BC File Offset: 0x002102BC
		// (set) Token: 0x06016B2C RID: 92972 RVA: 0x002120F5 File Offset: 0x002102F5
		public TArray<float> TimeArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._TimeArray) == null)
				{
					result = (this._TimeArray = new TArray<float>(base.NativePtr + (IntPtr)UKuroHitResult.__PropertyOffset_TimeArray, this));
				}
				return result;
			}
			set
			{
				this.TimeArray.CopyAssign(value);
			}
		}

		// Token: 0x17005BC1 RID: 23489
		// (get) Token: 0x06016B2D RID: 92973 RVA: 0x00212104 File Offset: 0x00210304
		// (set) Token: 0x06016B2E RID: 92974 RVA: 0x0021213D File Offset: 0x0021033D
		public TArray<float> ImpactNormalX_Array
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._ImpactNormalX_Array) == null)
				{
					result = (this._ImpactNormalX_Array = new TArray<float>(base.NativePtr + (IntPtr)UKuroHitResult.__PropertyOffset_ImpactNormalX_Array, this));
				}
				return result;
			}
			set
			{
				this.ImpactNormalX_Array.CopyAssign(value);
			}
		}

		// Token: 0x17005BC2 RID: 23490
		// (get) Token: 0x06016B2F RID: 92975 RVA: 0x0021214C File Offset: 0x0021034C
		// (set) Token: 0x06016B30 RID: 92976 RVA: 0x00212185 File Offset: 0x00210385
		public TArray<float> ImpactNormalY_Array
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._ImpactNormalY_Array) == null)
				{
					result = (this._ImpactNormalY_Array = new TArray<float>(base.NativePtr + (IntPtr)UKuroHitResult.__PropertyOffset_ImpactNormalY_Array, this));
				}
				return result;
			}
			set
			{
				this.ImpactNormalY_Array.CopyAssign(value);
			}
		}

		// Token: 0x17005BC3 RID: 23491
		// (get) Token: 0x06016B31 RID: 92977 RVA: 0x00212194 File Offset: 0x00210394
		// (set) Token: 0x06016B32 RID: 92978 RVA: 0x002121CD File Offset: 0x002103CD
		public TArray<float> ImpactNormalZ_Array
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._ImpactNormalZ_Array) == null)
				{
					result = (this._ImpactNormalZ_Array = new TArray<float>(base.NativePtr + (IntPtr)UKuroHitResult.__PropertyOffset_ImpactNormalZ_Array, this));
				}
				return result;
			}
			set
			{
				this.ImpactNormalZ_Array.CopyAssign(value);
			}
		}

		// Token: 0x17005BC4 RID: 23492
		// (get) Token: 0x06016B33 RID: 92979 RVA: 0x002121DC File Offset: 0x002103DC
		// (set) Token: 0x06016B34 RID: 92980 RVA: 0x00212215 File Offset: 0x00210415
		public TArray<float> ImpactPointX_Array
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._ImpactPointX_Array) == null)
				{
					result = (this._ImpactPointX_Array = new TArray<float>(base.NativePtr + (IntPtr)UKuroHitResult.__PropertyOffset_ImpactPointX_Array, this));
				}
				return result;
			}
			set
			{
				this.ImpactPointX_Array.CopyAssign(value);
			}
		}

		// Token: 0x17005BC5 RID: 23493
		// (get) Token: 0x06016B35 RID: 92981 RVA: 0x00212224 File Offset: 0x00210424
		// (set) Token: 0x06016B36 RID: 92982 RVA: 0x0021225D File Offset: 0x0021045D
		public TArray<float> ImpactPointY_Array
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._ImpactPointY_Array) == null)
				{
					result = (this._ImpactPointY_Array = new TArray<float>(base.NativePtr + (IntPtr)UKuroHitResult.__PropertyOffset_ImpactPointY_Array, this));
				}
				return result;
			}
			set
			{
				this.ImpactPointY_Array.CopyAssign(value);
			}
		}

		// Token: 0x17005BC6 RID: 23494
		// (get) Token: 0x06016B37 RID: 92983 RVA: 0x0021226C File Offset: 0x0021046C
		// (set) Token: 0x06016B38 RID: 92984 RVA: 0x002122A5 File Offset: 0x002104A5
		public TArray<float> ImpactPointZ_Array
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._ImpactPointZ_Array) == null)
				{
					result = (this._ImpactPointZ_Array = new TArray<float>(base.NativePtr + (IntPtr)UKuroHitResult.__PropertyOffset_ImpactPointZ_Array, this));
				}
				return result;
			}
			set
			{
				this.ImpactPointZ_Array.CopyAssign(value);
			}
		}

		// Token: 0x17005BC7 RID: 23495
		// (get) Token: 0x06016B39 RID: 92985 RVA: 0x002122B4 File Offset: 0x002104B4
		// (set) Token: 0x06016B3A RID: 92986 RVA: 0x002122ED File Offset: 0x002104ED
		public TArray<float> LocationX_Array
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._LocationX_Array) == null)
				{
					result = (this._LocationX_Array = new TArray<float>(base.NativePtr + (IntPtr)UKuroHitResult.__PropertyOffset_LocationX_Array, this));
				}
				return result;
			}
			set
			{
				this.LocationX_Array.CopyAssign(value);
			}
		}

		// Token: 0x17005BC8 RID: 23496
		// (get) Token: 0x06016B3B RID: 92987 RVA: 0x002122FC File Offset: 0x002104FC
		// (set) Token: 0x06016B3C RID: 92988 RVA: 0x00212335 File Offset: 0x00210535
		public TArray<float> LocationY_Array
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._LocationY_Array) == null)
				{
					result = (this._LocationY_Array = new TArray<float>(base.NativePtr + (IntPtr)UKuroHitResult.__PropertyOffset_LocationY_Array, this));
				}
				return result;
			}
			set
			{
				this.LocationY_Array.CopyAssign(value);
			}
		}

		// Token: 0x17005BC9 RID: 23497
		// (get) Token: 0x06016B3D RID: 92989 RVA: 0x00212344 File Offset: 0x00210544
		// (set) Token: 0x06016B3E RID: 92990 RVA: 0x0021237D File Offset: 0x0021057D
		public TArray<float> LocationZ_Array
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._LocationZ_Array) == null)
				{
					result = (this._LocationZ_Array = new TArray<float>(base.NativePtr + (IntPtr)UKuroHitResult.__PropertyOffset_LocationZ_Array, this));
				}
				return result;
			}
			set
			{
				this.LocationZ_Array.CopyAssign(value);
			}
		}

		// Token: 0x17005BCA RID: 23498
		// (get) Token: 0x06016B3F RID: 92991 RVA: 0x0021238C File Offset: 0x0021058C
		// (set) Token: 0x06016B40 RID: 92992 RVA: 0x002123C5 File Offset: 0x002105C5
		public TArray<float> NormalX_Array
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._NormalX_Array) == null)
				{
					result = (this._NormalX_Array = new TArray<float>(base.NativePtr + (IntPtr)UKuroHitResult.__PropertyOffset_NormalX_Array, this));
				}
				return result;
			}
			set
			{
				this.NormalX_Array.CopyAssign(value);
			}
		}

		// Token: 0x17005BCB RID: 23499
		// (get) Token: 0x06016B41 RID: 92993 RVA: 0x002123D4 File Offset: 0x002105D4
		// (set) Token: 0x06016B42 RID: 92994 RVA: 0x0021240D File Offset: 0x0021060D
		public TArray<float> NormalY_Array
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._NormalY_Array) == null)
				{
					result = (this._NormalY_Array = new TArray<float>(base.NativePtr + (IntPtr)UKuroHitResult.__PropertyOffset_NormalY_Array, this));
				}
				return result;
			}
			set
			{
				this.NormalY_Array.CopyAssign(value);
			}
		}

		// Token: 0x17005BCC RID: 23500
		// (get) Token: 0x06016B43 RID: 92995 RVA: 0x0021241C File Offset: 0x0021061C
		// (set) Token: 0x06016B44 RID: 92996 RVA: 0x00212455 File Offset: 0x00210655
		public TArray<float> NormalZ_Array
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._NormalZ_Array) == null)
				{
					result = (this._NormalZ_Array = new TArray<float>(base.NativePtr + (IntPtr)UKuroHitResult.__PropertyOffset_NormalZ_Array, this));
				}
				return result;
			}
			set
			{
				this.NormalZ_Array.CopyAssign(value);
			}
		}

		// Token: 0x06016B45 RID: 92997 RVA: 0x00212463 File Offset: 0x00210663
		public int GetHitCount()
		{
			return UKuroHitResult.__GetHitCount_Internal(base.NativePtr);
		}

		// Token: 0x06016B46 RID: 92998 RVA: 0x00212470 File Offset: 0x00210670
		public void Clear()
		{
			UKuroHitResult.__Clear_Internal(base.NativePtr);
		}

		// Token: 0x06016B47 RID: 92999
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetHitCount_Internal(IntPtr @this);

		// Token: 0x06016B48 RID: 93000
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Clear_Internal(IntPtr @this);

		// Token: 0x06016B49 RID: 93001 RVA: 0x0021247D File Offset: 0x0021067D
		static UKuroHitResult()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroData.KuroHitResult");
		}

		// Token: 0x06016B4A RID: 93002 RVA: 0x0021248B File Offset: 0x0021068B
		protected UKuroHitResult(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C517 RID: 50455
		public new const string __ObjectPath = "/Script/KuroData.KuroHitResult";

		// Token: 0x0400C518 RID: 50456
		private static IntPtr _ClassPtr;

		// Token: 0x0400C519 RID: 50457
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C51A RID: 50458
		internal static int __PropertyOffset_bBlockingHit;

		// Token: 0x0400C51B RID: 50459
		internal static int __PropertyOffset_bStartPenetrating;

		// Token: 0x0400C51C RID: 50460
		internal static int __PropertyOffset_Actors;

		// Token: 0x0400C51D RID: 50461
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<AActor>> _Actors;

		// Token: 0x0400C51E RID: 50462
		internal static int __PropertyOffset_Components;

		// Token: 0x0400C51F RID: 50463
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<UPrimitiveComponent>> _Components;

		// Token: 0x0400C520 RID: 50464
		internal static int __PropertyOffset_PhysMaterials;

		// Token: 0x0400C521 RID: 50465
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<UPhysicalMaterial>> _PhysMaterials;

		// Token: 0x0400C522 RID: 50466
		internal static int __PropertyOffset_BoneNameArray;

		// Token: 0x0400C523 RID: 50467
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _BoneNameArray;

		// Token: 0x0400C524 RID: 50468
		internal static int __PropertyOffset_ElementIndexArray;

		// Token: 0x0400C525 RID: 50469
		[Nullable(2)]
		private TArray<byte> _ElementIndexArray;

		// Token: 0x0400C526 RID: 50470
		internal static int __PropertyOffset_FaceIndexArray;

		// Token: 0x0400C527 RID: 50471
		[Nullable(2)]
		private TArray<int> _FaceIndexArray;

		// Token: 0x0400C528 RID: 50472
		internal static int __PropertyOffset_ItemArray;

		// Token: 0x0400C529 RID: 50473
		[Nullable(2)]
		private TArray<int> _ItemArray;

		// Token: 0x0400C52A RID: 50474
		internal static int __PropertyOffset_DistanceArray;

		// Token: 0x0400C52B RID: 50475
		[Nullable(2)]
		private TArray<float> _DistanceArray;

		// Token: 0x0400C52C RID: 50476
		internal static int __PropertyOffset_PenetrationDepthArray;

		// Token: 0x0400C52D RID: 50477
		[Nullable(2)]
		private TArray<float> _PenetrationDepthArray;

		// Token: 0x0400C52E RID: 50478
		internal static int __PropertyOffset_TimeArray;

		// Token: 0x0400C52F RID: 50479
		[Nullable(2)]
		private TArray<float> _TimeArray;

		// Token: 0x0400C530 RID: 50480
		internal static int __PropertyOffset_ImpactNormalX_Array;

		// Token: 0x0400C531 RID: 50481
		[Nullable(2)]
		private TArray<float> _ImpactNormalX_Array;

		// Token: 0x0400C532 RID: 50482
		internal static int __PropertyOffset_ImpactNormalY_Array;

		// Token: 0x0400C533 RID: 50483
		[Nullable(2)]
		private TArray<float> _ImpactNormalY_Array;

		// Token: 0x0400C534 RID: 50484
		internal static int __PropertyOffset_ImpactNormalZ_Array;

		// Token: 0x0400C535 RID: 50485
		[Nullable(2)]
		private TArray<float> _ImpactNormalZ_Array;

		// Token: 0x0400C536 RID: 50486
		internal static int __PropertyOffset_ImpactPointX_Array;

		// Token: 0x0400C537 RID: 50487
		[Nullable(2)]
		private TArray<float> _ImpactPointX_Array;

		// Token: 0x0400C538 RID: 50488
		internal static int __PropertyOffset_ImpactPointY_Array;

		// Token: 0x0400C539 RID: 50489
		[Nullable(2)]
		private TArray<float> _ImpactPointY_Array;

		// Token: 0x0400C53A RID: 50490
		internal static int __PropertyOffset_ImpactPointZ_Array;

		// Token: 0x0400C53B RID: 50491
		[Nullable(2)]
		private TArray<float> _ImpactPointZ_Array;

		// Token: 0x0400C53C RID: 50492
		internal static int __PropertyOffset_LocationX_Array;

		// Token: 0x0400C53D RID: 50493
		[Nullable(2)]
		private TArray<float> _LocationX_Array;

		// Token: 0x0400C53E RID: 50494
		internal static int __PropertyOffset_LocationY_Array;

		// Token: 0x0400C53F RID: 50495
		[Nullable(2)]
		private TArray<float> _LocationY_Array;

		// Token: 0x0400C540 RID: 50496
		internal static int __PropertyOffset_LocationZ_Array;

		// Token: 0x0400C541 RID: 50497
		[Nullable(2)]
		private TArray<float> _LocationZ_Array;

		// Token: 0x0400C542 RID: 50498
		internal static int __PropertyOffset_NormalX_Array;

		// Token: 0x0400C543 RID: 50499
		[Nullable(2)]
		private TArray<float> _NormalX_Array;

		// Token: 0x0400C544 RID: 50500
		internal static int __PropertyOffset_NormalY_Array;

		// Token: 0x0400C545 RID: 50501
		[Nullable(2)]
		private TArray<float> _NormalY_Array;

		// Token: 0x0400C546 RID: 50502
		internal static int __PropertyOffset_NormalZ_Array;

		// Token: 0x0400C547 RID: 50503
		[Nullable(2)]
		private TArray<float> _NormalZ_Array;
	}
}
