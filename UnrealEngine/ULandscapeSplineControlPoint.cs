using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F8A RID: 8074
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Landscape.LandscapeSplineControlPoint")]
	[UnrealStructLayout(808, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 808)]
	public class ULandscapeSplineControlPoint : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EA82 RID: 125570 RVA: 0x002D923F File Offset: 0x002D743F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULandscapeSplineControlPoint._ClassPtr;
		}

		// Token: 0x0601EA83 RID: 125571 RVA: 0x002D924C File Offset: 0x002D744C
		public ULandscapeSplineControlPoint() : this(BuiltinUtils.AllocNativeUObject(ULandscapeSplineControlPoint.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EA84 RID: 125572 RVA: 0x002D9274 File Offset: 0x002D7474
		public ULandscapeSplineControlPoint(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULandscapeSplineControlPoint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007A14 RID: 31252
		// (get) Token: 0x0601EA85 RID: 125573 RVA: 0x002D92A7 File Offset: 0x002D74A7
		// (set) Token: 0x0601EA86 RID: 125574 RVA: 0x002D92BB File Offset: 0x002D74BB
		public unsafe FVector Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeSplineControlPoint.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeSplineControlPoint.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x17007A15 RID: 31253
		// (get) Token: 0x0601EA87 RID: 125575 RVA: 0x002D92D0 File Offset: 0x002D74D0
		// (set) Token: 0x0601EA88 RID: 125576 RVA: 0x002D92E4 File Offset: 0x002D74E4
		public unsafe FRotator Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeSplineControlPoint.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeSplineControlPoint.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x17007A16 RID: 31254
		// (get) Token: 0x0601EA89 RID: 125577 RVA: 0x002D92F9 File Offset: 0x002D74F9
		// (set) Token: 0x0601EA8A RID: 125578 RVA: 0x002D9309 File Offset: 0x002D7509
		public unsafe float Width
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeSplineControlPoint.__PropertyOffset_Width);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeSplineControlPoint.__PropertyOffset_Width) = value;
			}
		}

		// Token: 0x17007A17 RID: 31255
		// (get) Token: 0x0601EA8B RID: 125579 RVA: 0x002D931A File Offset: 0x002D751A
		// (set) Token: 0x0601EA8C RID: 125580 RVA: 0x002D932A File Offset: 0x002D752A
		public unsafe float LayerWidthRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeSplineControlPoint.__PropertyOffset_LayerWidthRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeSplineControlPoint.__PropertyOffset_LayerWidthRatio) = value;
			}
		}

		// Token: 0x17007A18 RID: 31256
		// (get) Token: 0x0601EA8D RID: 125581 RVA: 0x002D933B File Offset: 0x002D753B
		// (set) Token: 0x0601EA8E RID: 125582 RVA: 0x002D934B File Offset: 0x002D754B
		public unsafe float SideFalloff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeSplineControlPoint.__PropertyOffset_SideFalloff);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeSplineControlPoint.__PropertyOffset_SideFalloff) = value;
			}
		}

		// Token: 0x17007A19 RID: 31257
		// (get) Token: 0x0601EA8F RID: 125583 RVA: 0x002D935C File Offset: 0x002D755C
		// (set) Token: 0x0601EA90 RID: 125584 RVA: 0x002D936C File Offset: 0x002D756C
		public unsafe float LeftSideFalloffFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeSplineControlPoint.__PropertyOffset_LeftSideFalloffFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeSplineControlPoint.__PropertyOffset_LeftSideFalloffFactor) = value;
			}
		}

		// Token: 0x17007A1A RID: 31258
		// (get) Token: 0x0601EA91 RID: 125585 RVA: 0x002D937D File Offset: 0x002D757D
		// (set) Token: 0x0601EA92 RID: 125586 RVA: 0x002D938D File Offset: 0x002D758D
		public unsafe float RightSideFalloffFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeSplineControlPoint.__PropertyOffset_RightSideFalloffFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeSplineControlPoint.__PropertyOffset_RightSideFalloffFactor) = value;
			}
		}

		// Token: 0x17007A1B RID: 31259
		// (get) Token: 0x0601EA93 RID: 125587 RVA: 0x002D939E File Offset: 0x002D759E
		// (set) Token: 0x0601EA94 RID: 125588 RVA: 0x002D93AE File Offset: 0x002D75AE
		public unsafe float LeftSideLayerFalloffFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeSplineControlPoint.__PropertyOffset_LeftSideLayerFalloffFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeSplineControlPoint.__PropertyOffset_LeftSideLayerFalloffFactor) = value;
			}
		}

		// Token: 0x17007A1C RID: 31260
		// (get) Token: 0x0601EA95 RID: 125589 RVA: 0x002D93BF File Offset: 0x002D75BF
		// (set) Token: 0x0601EA96 RID: 125590 RVA: 0x002D93CF File Offset: 0x002D75CF
		public unsafe float RightSideLayerFalloffFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeSplineControlPoint.__PropertyOffset_RightSideLayerFalloffFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeSplineControlPoint.__PropertyOffset_RightSideLayerFalloffFactor) = value;
			}
		}

		// Token: 0x17007A1D RID: 31261
		// (get) Token: 0x0601EA97 RID: 125591 RVA: 0x002D93E0 File Offset: 0x002D75E0
		// (set) Token: 0x0601EA98 RID: 125592 RVA: 0x002D93F0 File Offset: 0x002D75F0
		public unsafe float EndFalloff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeSplineControlPoint.__PropertyOffset_EndFalloff);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeSplineControlPoint.__PropertyOffset_EndFalloff) = value;
			}
		}

		// Token: 0x17007A1E RID: 31262
		// (get) Token: 0x0601EA99 RID: 125593 RVA: 0x002D9404 File Offset: 0x002D7604
		// (set) Token: 0x0601EA9A RID: 125594 RVA: 0x002D943D File Offset: 0x002D763D
		public TArray<FLandscapeSplineConnection> ConnectedSegments
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FLandscapeSplineConnection> result;
				if ((result = this._ConnectedSegments) == null)
				{
					result = (this._ConnectedSegments = new TArray<FLandscapeSplineConnection>(base.NativePtr + (IntPtr)ULandscapeSplineControlPoint.__PropertyOffset_ConnectedSegments, this));
				}
				return result;
			}
			set
			{
				this.ConnectedSegments.CopyAssign(value);
			}
		}

		// Token: 0x17007A1F RID: 31263
		// (get) Token: 0x0601EA9B RID: 125595 RVA: 0x002D944C File Offset: 0x002D764C
		// (set) Token: 0x0601EA9C RID: 125596 RVA: 0x002D9485 File Offset: 0x002D7685
		public TArray<FLandscapeSplineInterpPoint> Points
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FLandscapeSplineInterpPoint> result;
				if ((result = this._Points) == null)
				{
					result = (this._Points = new TArray<FLandscapeSplineInterpPoint>(base.NativePtr + (IntPtr)ULandscapeSplineControlPoint.__PropertyOffset_Points, this));
				}
				return result;
			}
			set
			{
				this.Points.CopyAssign(value);
			}
		}

		// Token: 0x17007A20 RID: 31264
		// (get) Token: 0x0601EA9D RID: 125597 RVA: 0x002D9493 File Offset: 0x002D7693
		// (set) Token: 0x0601EA9E RID: 125598 RVA: 0x002D94A7 File Offset: 0x002D76A7
		public unsafe FBox Bounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeSplineControlPoint.__PropertyOffset_Bounds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeSplineControlPoint.__PropertyOffset_Bounds) = value;
			}
		}

		// Token: 0x17007A21 RID: 31265
		// (get) Token: 0x0601EA9F RID: 125599 RVA: 0x002D94BC File Offset: 0x002D76BC
		// (set) Token: 0x0601EAA0 RID: 125600 RVA: 0x002D94D0 File Offset: 0x002D76D0
		[Nullable(2)]
		public unsafe UControlPointMeshComponent LocalMeshComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UControlPointMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ULandscapeSplineControlPoint.__PropertyOffset_LocalMeshComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULandscapeSplineControlPoint.__PropertyOffset_LocalMeshComponent, value);
			}
		}

		// Token: 0x0601EAA1 RID: 125601 RVA: 0x002D94E5 File Offset: 0x002D76E5
		static ULandscapeSplineControlPoint()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Landscape.LandscapeSplineControlPoint");
		}

		// Token: 0x0601EAA2 RID: 125602 RVA: 0x002D94F3 File Offset: 0x002D76F3
		protected ULandscapeSplineControlPoint(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010927 RID: 67879
		public new const string __ObjectPath = "/Script/Landscape.LandscapeSplineControlPoint";

		// Token: 0x04010928 RID: 67880
		private static IntPtr _ClassPtr;

		// Token: 0x04010929 RID: 67881
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401092A RID: 67882
		internal static int __PropertyOffset_Location;

		// Token: 0x0401092B RID: 67883
		internal static int __PropertyOffset_Rotation;

		// Token: 0x0401092C RID: 67884
		internal static int __PropertyOffset_Width;

		// Token: 0x0401092D RID: 67885
		internal static int __PropertyOffset_LayerWidthRatio;

		// Token: 0x0401092E RID: 67886
		internal static int __PropertyOffset_SideFalloff;

		// Token: 0x0401092F RID: 67887
		internal static int __PropertyOffset_LeftSideFalloffFactor;

		// Token: 0x04010930 RID: 67888
		internal static int __PropertyOffset_RightSideFalloffFactor;

		// Token: 0x04010931 RID: 67889
		internal static int __PropertyOffset_LeftSideLayerFalloffFactor;

		// Token: 0x04010932 RID: 67890
		internal static int __PropertyOffset_RightSideLayerFalloffFactor;

		// Token: 0x04010933 RID: 67891
		internal static int __PropertyOffset_EndFalloff;

		// Token: 0x04010934 RID: 67892
		internal static int __PropertyOffset_ConnectedSegments;

		// Token: 0x04010935 RID: 67893
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FLandscapeSplineConnection> _ConnectedSegments;

		// Token: 0x04010936 RID: 67894
		internal static int __PropertyOffset_Points;

		// Token: 0x04010937 RID: 67895
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FLandscapeSplineInterpPoint> _Points;

		// Token: 0x04010938 RID: 67896
		internal static int __PropertyOffset_Bounds;

		// Token: 0x04010939 RID: 67897
		internal static int __PropertyOffset_LocalMeshComponent;
	}
}
