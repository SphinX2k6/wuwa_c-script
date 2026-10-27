using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003B6 RID: 950
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AugmentedReality.ARPlaneGeometry")]
	[UnrealStructLayout(320, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 320)]
	public class UARPlaneGeometry : UARTrackedGeometry, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060034A8 RID: 13480 RVA: 0x0005068C File Offset: 0x0004E88C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UARPlaneGeometry._ClassPtr;
		}

		// Token: 0x060034A9 RID: 13481 RVA: 0x00050698 File Offset: 0x0004E898
		public UARPlaneGeometry() : this(BuiltinUtils.AllocNativeUObject(UARPlaneGeometry.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060034AA RID: 13482 RVA: 0x000506C0 File Offset: 0x0004E8C0
		public UARPlaneGeometry(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UARPlaneGeometry.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000C91 RID: 3217
		// (get) Token: 0x060034AB RID: 13483 RVA: 0x000506F3 File Offset: 0x0004E8F3
		// (set) Token: 0x060034AC RID: 13484 RVA: 0x00050703 File Offset: 0x0004E903
		public unsafe EARPlaneOrientation Orientation
		{
			get
			{
				return (EARPlaneOrientation)(*(base.NativePtr + (IntPtr)UARPlaneGeometry.__PropertyOffset_Orientation));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARPlaneGeometry.__PropertyOffset_Orientation) = (byte)value;
			}
		}

		// Token: 0x17000C92 RID: 3218
		// (get) Token: 0x060034AD RID: 13485 RVA: 0x00050714 File Offset: 0x0004E914
		// (set) Token: 0x060034AE RID: 13486 RVA: 0x00050728 File Offset: 0x0004E928
		public unsafe FVector Center
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UARPlaneGeometry.__PropertyOffset_Center);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARPlaneGeometry.__PropertyOffset_Center) = value;
			}
		}

		// Token: 0x17000C93 RID: 3219
		// (get) Token: 0x060034AF RID: 13487 RVA: 0x0005073D File Offset: 0x0004E93D
		// (set) Token: 0x060034B0 RID: 13488 RVA: 0x00050751 File Offset: 0x0004E951
		public unsafe FVector Extent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UARPlaneGeometry.__PropertyOffset_Extent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARPlaneGeometry.__PropertyOffset_Extent) = value;
			}
		}

		// Token: 0x17000C94 RID: 3220
		// (get) Token: 0x060034B1 RID: 13489 RVA: 0x00050768 File Offset: 0x0004E968
		// (set) Token: 0x060034B2 RID: 13490 RVA: 0x000507A1 File Offset: 0x0004E9A1
		public TArray<FVector> BoundaryPolygon
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._BoundaryPolygon) == null)
				{
					result = (this._BoundaryPolygon = new TArray<FVector>(base.NativePtr + (IntPtr)UARPlaneGeometry.__PropertyOffset_BoundaryPolygon, this));
				}
				return result;
			}
			set
			{
				this.BoundaryPolygon.CopyAssign(value);
			}
		}

		// Token: 0x17000C95 RID: 3221
		// (get) Token: 0x060034B3 RID: 13491 RVA: 0x000507AF File Offset: 0x0004E9AF
		// (set) Token: 0x060034B4 RID: 13492 RVA: 0x000507C3 File Offset: 0x0004E9C3
		[Nullable(2)]
		public unsafe UARPlaneGeometry SubsumedBy
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UARPlaneGeometry>(base.NativePtr / (IntPtr)sizeof(void*) + UARPlaneGeometry.__PropertyOffset_SubsumedBy);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UARPlaneGeometry.__PropertyOffset_SubsumedBy, value);
			}
		}

		// Token: 0x060034B5 RID: 13493 RVA: 0x000507D8 File Offset: 0x0004E9D8
		[NullableContext(2)]
		public UARPlaneGeometry GetSubsumedBy()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UARPlaneGeometry>(UARPlaneGeometry.__GetSubsumedBy_Internal(base.NativePtr));
		}

		// Token: 0x060034B6 RID: 13494 RVA: 0x000507EA File Offset: 0x0004E9EA
		public EARPlaneOrientation GetOrientation()
		{
			return UARPlaneGeometry.__GetOrientation_Internal(base.NativePtr);
		}

		// Token: 0x060034B7 RID: 13495 RVA: 0x000507F7 File Offset: 0x0004E9F7
		public FVector GetExtent()
		{
			return UARPlaneGeometry.__GetExtent_Internal(base.NativePtr);
		}

		// Token: 0x060034B8 RID: 13496 RVA: 0x00050804 File Offset: 0x0004EA04
		public FVector GetCenter()
		{
			return UARPlaneGeometry.__GetCenter_Internal(base.NativePtr);
		}

		// Token: 0x060034B9 RID: 13497 RVA: 0x00050811 File Offset: 0x0004EA11
		public TArray<FVector> GetBoundaryPolygonInLocalSpace()
		{
			return new TArray<FVector>(UARPlaneGeometry.__GetBoundaryPolygonInLocalSpace_Internal(base.NativePtr), null);
		}

		// Token: 0x060034BA RID: 13498
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSubsumedBy_Internal(IntPtr @this);

		// Token: 0x060034BB RID: 13499
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EARPlaneOrientation __GetOrientation_Internal(IntPtr @this);

		// Token: 0x060034BC RID: 13500
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetExtent_Internal(IntPtr @this);

		// Token: 0x060034BD RID: 13501
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetCenter_Internal(IntPtr @this);

		// Token: 0x060034BE RID: 13502
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetBoundaryPolygonInLocalSpace_Internal(IntPtr @this);

		// Token: 0x060034BF RID: 13503 RVA: 0x00050824 File Offset: 0x0004EA24
		static UARPlaneGeometry()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AugmentedReality.ARPlaneGeometry");
		}

		// Token: 0x060034C0 RID: 13504 RVA: 0x00050832 File Offset: 0x0004EA32
		protected UARPlaneGeometry(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040016D5 RID: 5845
		public new const string __ObjectPath = "/Script/AugmentedReality.ARPlaneGeometry";

		// Token: 0x040016D6 RID: 5846
		private static IntPtr _ClassPtr;

		// Token: 0x040016D7 RID: 5847
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040016D8 RID: 5848
		internal static int __PropertyOffset_Orientation;

		// Token: 0x040016D9 RID: 5849
		internal static int __PropertyOffset_Center;

		// Token: 0x040016DA RID: 5850
		internal static int __PropertyOffset_Extent;

		// Token: 0x040016DB RID: 5851
		internal static int __PropertyOffset_BoundaryPolygon;

		// Token: 0x040016DC RID: 5852
		[Nullable(2)]
		private TArray<FVector> _BoundaryPolygon;

		// Token: 0x040016DD RID: 5853
		internal static int __PropertyOffset_SubsumedBy;
	}
}
