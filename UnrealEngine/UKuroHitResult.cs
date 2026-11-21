using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000369 RID: 873
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroData.KuroHitResult")]
	[UnrealStructLayout(584, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 584)]
	public class UKuroHitResult : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060058D9 RID: 22745 RVA: 0x0007D26E File Offset: 0x0007B46E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroHitResult._ClassPtr;
		}

		// Token: 0x060058DA RID: 22746 RVA: 0x0007D27C File Offset: 0x0007B47C
		public UKuroHitResult() : this(BuiltinUtils.AllocNativeUObject(UKuroHitResult.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060058DB RID: 22747 RVA: 0x0007D2A4 File Offset: 0x0007B4A4
		public UKuroHitResult(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroHitResult.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001189 RID: 4489
		// (get) Token: 0x060058DC RID: 22748 RVA: 0x0007D2D7 File Offset: 0x0007B4D7
		// (set) Token: 0x060058DD RID: 22749 RVA: 0x0007D2E7 File Offset: 0x0007B4E7
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

		// Token: 0x1700118A RID: 4490
		// (get) Token: 0x060058DE RID: 22750 RVA: 0x0007D2F8 File Offset: 0x0007B4F8
		// (set) Token: 0x060058DF RID: 22751 RVA: 0x0007D308 File Offset: 0x0007B508
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

		// Token: 0x1700118B RID: 4491
		// (get) Token: 0x060058E0 RID: 22752 RVA: 0x0007D31C File Offset: 0x0007B51C
		// (set) Token: 0x060058E1 RID: 22753 RVA: 0x0007D355 File Offset: 0x0007B555
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

		// Token: 0x1700118C RID: 4492
		// (get) Token: 0x060058E2 RID: 22754 RVA: 0x0007D364 File Offset: 0x0007B564
		// (set) Token: 0x060058E3 RID: 22755 RVA: 0x0007D39D File Offset: 0x0007B59D
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

		// Token: 0x1700118D RID: 4493
		// (get) Token: 0x060058E4 RID: 22756 RVA: 0x0007D3AC File Offset: 0x0007B5AC
		// (set) Token: 0x060058E5 RID: 22757 RVA: 0x0007D3E5 File Offset: 0x0007B5E5
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

		// Token: 0x1700118E RID: 4494
		// (get) Token: 0x060058E6 RID: 22758 RVA: 0x0007D3F4 File Offset: 0x0007B5F4
		// (set) Token: 0x060058E7 RID: 22759 RVA: 0x0007D42D File Offset: 0x0007B62D
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

		// Token: 0x1700118F RID: 4495
		// (get) Token: 0x060058E8 RID: 22760 RVA: 0x0007D43C File Offset: 0x0007B63C
		// (set) Token: 0x060058E9 RID: 22761 RVA: 0x0007D475 File Offset: 0x0007B675
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

		// Token: 0x17001190 RID: 4496
		// (get) Token: 0x060058EA RID: 22762 RVA: 0x0007D484 File Offset: 0x0007B684
		// (set) Token: 0x060058EB RID: 22763 RVA: 0x0007D4BD File Offset: 0x0007B6BD
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

		// Token: 0x17001191 RID: 4497
		// (get) Token: 0x060058EC RID: 22764 RVA: 0x0007D4CC File Offset: 0x0007B6CC
		// (set) Token: 0x060058ED RID: 22765 RVA: 0x0007D505 File Offset: 0x0007B705
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

		// Token: 0x17001192 RID: 4498
		// (get) Token: 0x060058EE RID: 22766 RVA: 0x0007D514 File Offset: 0x0007B714
		// (set) Token: 0x060058EF RID: 22767 RVA: 0x0007D54D File Offset: 0x0007B74D
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

		// Token: 0x17001193 RID: 4499
		// (get) Token: 0x060058F0 RID: 22768 RVA: 0x0007D55C File Offset: 0x0007B75C
		// (set) Token: 0x060058F1 RID: 22769 RVA: 0x0007D595 File Offset: 0x0007B795
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

		// Token: 0x17001194 RID: 4500
		// (get) Token: 0x060058F2 RID: 22770 RVA: 0x0007D5A4 File Offset: 0x0007B7A4
		// (set) Token: 0x060058F3 RID: 22771 RVA: 0x0007D5DD File Offset: 0x0007B7DD
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

		// Token: 0x17001195 RID: 4501
		// (get) Token: 0x060058F4 RID: 22772 RVA: 0x0007D5EC File Offset: 0x0007B7EC
		// (set) Token: 0x060058F5 RID: 22773 RVA: 0x0007D625 File Offset: 0x0007B825
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

		// Token: 0x17001196 RID: 4502
		// (get) Token: 0x060058F6 RID: 22774 RVA: 0x0007D634 File Offset: 0x0007B834
		// (set) Token: 0x060058F7 RID: 22775 RVA: 0x0007D66D File Offset: 0x0007B86D
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

		// Token: 0x17001197 RID: 4503
		// (get) Token: 0x060058F8 RID: 22776 RVA: 0x0007D67C File Offset: 0x0007B87C
		// (set) Token: 0x060058F9 RID: 22777 RVA: 0x0007D6B5 File Offset: 0x0007B8B5
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

		// Token: 0x17001198 RID: 4504
		// (get) Token: 0x060058FA RID: 22778 RVA: 0x0007D6C4 File Offset: 0x0007B8C4
		// (set) Token: 0x060058FB RID: 22779 RVA: 0x0007D6FD File Offset: 0x0007B8FD
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

		// Token: 0x17001199 RID: 4505
		// (get) Token: 0x060058FC RID: 22780 RVA: 0x0007D70C File Offset: 0x0007B90C
		// (set) Token: 0x060058FD RID: 22781 RVA: 0x0007D745 File Offset: 0x0007B945
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

		// Token: 0x1700119A RID: 4506
		// (get) Token: 0x060058FE RID: 22782 RVA: 0x0007D754 File Offset: 0x0007B954
		// (set) Token: 0x060058FF RID: 22783 RVA: 0x0007D78D File Offset: 0x0007B98D
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

		// Token: 0x1700119B RID: 4507
		// (get) Token: 0x06005900 RID: 22784 RVA: 0x0007D79C File Offset: 0x0007B99C
		// (set) Token: 0x06005901 RID: 22785 RVA: 0x0007D7D5 File Offset: 0x0007B9D5
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

		// Token: 0x1700119C RID: 4508
		// (get) Token: 0x06005902 RID: 22786 RVA: 0x0007D7E4 File Offset: 0x0007B9E4
		// (set) Token: 0x06005903 RID: 22787 RVA: 0x0007D81D File Offset: 0x0007BA1D
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

		// Token: 0x1700119D RID: 4509
		// (get) Token: 0x06005904 RID: 22788 RVA: 0x0007D82C File Offset: 0x0007BA2C
		// (set) Token: 0x06005905 RID: 22789 RVA: 0x0007D865 File Offset: 0x0007BA65
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

		// Token: 0x1700119E RID: 4510
		// (get) Token: 0x06005906 RID: 22790 RVA: 0x0007D874 File Offset: 0x0007BA74
		// (set) Token: 0x06005907 RID: 22791 RVA: 0x0007D8AD File Offset: 0x0007BAAD
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

		// Token: 0x1700119F RID: 4511
		// (get) Token: 0x06005908 RID: 22792 RVA: 0x0007D8BC File Offset: 0x0007BABC
		// (set) Token: 0x06005909 RID: 22793 RVA: 0x0007D8F5 File Offset: 0x0007BAF5
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

		// Token: 0x170011A0 RID: 4512
		// (get) Token: 0x0600590A RID: 22794 RVA: 0x0007D904 File Offset: 0x0007BB04
		// (set) Token: 0x0600590B RID: 22795 RVA: 0x0007D93D File Offset: 0x0007BB3D
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

		// Token: 0x0600590C RID: 22796 RVA: 0x0007D94B File Offset: 0x0007BB4B
		public int GetHitCount()
		{
			return UKuroHitResult.__GetHitCount_Internal(base.NativePtr);
		}

		// Token: 0x0600590D RID: 22797 RVA: 0x0007D958 File Offset: 0x0007BB58
		public void Clear()
		{
			UKuroHitResult.__Clear_Internal(base.NativePtr);
		}

		// Token: 0x0600590E RID: 22798
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetHitCount_Internal(IntPtr @this);

		// Token: 0x0600590F RID: 22799
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Clear_Internal(IntPtr @this);

		// Token: 0x06005910 RID: 22800 RVA: 0x0007D965 File Offset: 0x0007BB65
		static UKuroHitResult()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroData.KuroHitResult");
		}

		// Token: 0x06005911 RID: 22801 RVA: 0x0007D973 File Offset: 0x0007BB73
		protected UKuroHitResult(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040024AC RID: 9388
		public new const string __ObjectPath = "/Script/KuroData.KuroHitResult";

		// Token: 0x040024AD RID: 9389
		private static IntPtr _ClassPtr;

		// Token: 0x040024AE RID: 9390
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040024AF RID: 9391
		internal static int __PropertyOffset_bBlockingHit;

		// Token: 0x040024B0 RID: 9392
		internal static int __PropertyOffset_bStartPenetrating;

		// Token: 0x040024B1 RID: 9393
		internal static int __PropertyOffset_Actors;

		// Token: 0x040024B2 RID: 9394
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<AActor>> _Actors;

		// Token: 0x040024B3 RID: 9395
		internal static int __PropertyOffset_Components;

		// Token: 0x040024B4 RID: 9396
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<UPrimitiveComponent>> _Components;

		// Token: 0x040024B5 RID: 9397
		internal static int __PropertyOffset_PhysMaterials;

		// Token: 0x040024B6 RID: 9398
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<UPhysicalMaterial>> _PhysMaterials;

		// Token: 0x040024B7 RID: 9399
		internal static int __PropertyOffset_BoneNameArray;

		// Token: 0x040024B8 RID: 9400
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _BoneNameArray;

		// Token: 0x040024B9 RID: 9401
		internal static int __PropertyOffset_ElementIndexArray;

		// Token: 0x040024BA RID: 9402
		[Nullable(2)]
		private TArray<byte> _ElementIndexArray;

		// Token: 0x040024BB RID: 9403
		internal static int __PropertyOffset_FaceIndexArray;

		// Token: 0x040024BC RID: 9404
		[Nullable(2)]
		private TArray<int> _FaceIndexArray;

		// Token: 0x040024BD RID: 9405
		internal static int __PropertyOffset_ItemArray;

		// Token: 0x040024BE RID: 9406
		[Nullable(2)]
		private TArray<int> _ItemArray;

		// Token: 0x040024BF RID: 9407
		internal static int __PropertyOffset_DistanceArray;

		// Token: 0x040024C0 RID: 9408
		[Nullable(2)]
		private TArray<float> _DistanceArray;

		// Token: 0x040024C1 RID: 9409
		internal static int __PropertyOffset_PenetrationDepthArray;

		// Token: 0x040024C2 RID: 9410
		[Nullable(2)]
		private TArray<float> _PenetrationDepthArray;

		// Token: 0x040024C3 RID: 9411
		internal static int __PropertyOffset_TimeArray;

		// Token: 0x040024C4 RID: 9412
		[Nullable(2)]
		private TArray<float> _TimeArray;

		// Token: 0x040024C5 RID: 9413
		internal static int __PropertyOffset_ImpactNormalX_Array;

		// Token: 0x040024C6 RID: 9414
		[Nullable(2)]
		private TArray<float> _ImpactNormalX_Array;

		// Token: 0x040024C7 RID: 9415
		internal static int __PropertyOffset_ImpactNormalY_Array;

		// Token: 0x040024C8 RID: 9416
		[Nullable(2)]
		private TArray<float> _ImpactNormalY_Array;

		// Token: 0x040024C9 RID: 9417
		internal static int __PropertyOffset_ImpactNormalZ_Array;

		// Token: 0x040024CA RID: 9418
		[Nullable(2)]
		private TArray<float> _ImpactNormalZ_Array;

		// Token: 0x040024CB RID: 9419
		internal static int __PropertyOffset_ImpactPointX_Array;

		// Token: 0x040024CC RID: 9420
		[Nullable(2)]
		private TArray<float> _ImpactPointX_Array;

		// Token: 0x040024CD RID: 9421
		internal static int __PropertyOffset_ImpactPointY_Array;

		// Token: 0x040024CE RID: 9422
		[Nullable(2)]
		private TArray<float> _ImpactPointY_Array;

		// Token: 0x040024CF RID: 9423
		internal static int __PropertyOffset_ImpactPointZ_Array;

		// Token: 0x040024D0 RID: 9424
		[Nullable(2)]
		private TArray<float> _ImpactPointZ_Array;

		// Token: 0x040024D1 RID: 9425
		internal static int __PropertyOffset_LocationX_Array;

		// Token: 0x040024D2 RID: 9426
		[Nullable(2)]
		private TArray<float> _LocationX_Array;

		// Token: 0x040024D3 RID: 9427
		internal static int __PropertyOffset_LocationY_Array;

		// Token: 0x040024D4 RID: 9428
		[Nullable(2)]
		private TArray<float> _LocationY_Array;

		// Token: 0x040024D5 RID: 9429
		internal static int __PropertyOffset_LocationZ_Array;

		// Token: 0x040024D6 RID: 9430
		[Nullable(2)]
		private TArray<float> _LocationZ_Array;

		// Token: 0x040024D7 RID: 9431
		internal static int __PropertyOffset_NormalX_Array;

		// Token: 0x040024D8 RID: 9432
		[Nullable(2)]
		private TArray<float> _NormalX_Array;

		// Token: 0x040024D9 RID: 9433
		internal static int __PropertyOffset_NormalY_Array;

		// Token: 0x040024DA RID: 9434
		[Nullable(2)]
		private TArray<float> _NormalY_Array;

		// Token: 0x040024DB RID: 9435
		internal static int __PropertyOffset_NormalZ_Array;

		// Token: 0x040024DC RID: 9436
		[Nullable(2)]
		private TArray<float> _NormalZ_Array;
	}
}
