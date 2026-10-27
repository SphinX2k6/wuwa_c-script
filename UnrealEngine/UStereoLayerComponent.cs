using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200119F RID: 4511
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.StereoLayerComponent")]
	[UnrealStructLayout(800, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 800)]
	public class UStereoLayerComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060109D8 RID: 68056 RVA: 0x00186673 File Offset: 0x00184873
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UStereoLayerComponent._ClassPtr;
		}

		// Token: 0x060109D9 RID: 68057 RVA: 0x00186680 File Offset: 0x00184880
		public UStereoLayerComponent() : this(BuiltinUtils.AllocNativeUObject(UStereoLayerComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060109DA RID: 68058 RVA: 0x001866A8 File Offset: 0x001848A8
		[NullableContext(1)]
		public UStereoLayerComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UStereoLayerComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170040DA RID: 16602
		// (get) Token: 0x060109DB RID: 68059 RVA: 0x001866DB File Offset: 0x001848DB
		// (set) Token: 0x060109DC RID: 68060 RVA: 0x001866F4 File Offset: 0x001848F4
		public unsafe bool bLiveTexture
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStereoLayerComponent.__PropertyOffset_bLiveTexture) & UStereoLayerComponent.__PropertyMask_bLiveTexture) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStereoLayerComponent.__PropertyOffset_bLiveTexture) = ((*(base.NativePtr + (IntPtr)UStereoLayerComponent.__PropertyOffset_bLiveTexture) & ~UStereoLayerComponent.__PropertyMask_bLiveTexture) | (value ? UStereoLayerComponent.__PropertyMask_bLiveTexture : 0));
			}
		}

		// Token: 0x170040DB RID: 16603
		// (get) Token: 0x060109DD RID: 68061 RVA: 0x00186724 File Offset: 0x00184924
		// (set) Token: 0x060109DE RID: 68062 RVA: 0x0018673D File Offset: 0x0018493D
		public unsafe bool bSupportsDepth
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStereoLayerComponent.__PropertyOffset_bSupportsDepth) & UStereoLayerComponent.__PropertyMask_bSupportsDepth) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStereoLayerComponent.__PropertyOffset_bSupportsDepth) = ((*(base.NativePtr + (IntPtr)UStereoLayerComponent.__PropertyOffset_bSupportsDepth) & ~UStereoLayerComponent.__PropertyMask_bSupportsDepth) | (value ? UStereoLayerComponent.__PropertyMask_bSupportsDepth : 0));
			}
		}

		// Token: 0x170040DC RID: 16604
		// (get) Token: 0x060109DF RID: 68063 RVA: 0x0018676D File Offset: 0x0018496D
		// (set) Token: 0x060109E0 RID: 68064 RVA: 0x00186786 File Offset: 0x00184986
		public unsafe bool bNoAlphaChannel
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStereoLayerComponent.__PropertyOffset_bNoAlphaChannel) & UStereoLayerComponent.__PropertyMask_bNoAlphaChannel) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStereoLayerComponent.__PropertyOffset_bNoAlphaChannel) = ((*(base.NativePtr + (IntPtr)UStereoLayerComponent.__PropertyOffset_bNoAlphaChannel) & ~UStereoLayerComponent.__PropertyMask_bNoAlphaChannel) | (value ? UStereoLayerComponent.__PropertyMask_bNoAlphaChannel : 0));
			}
		}

		// Token: 0x170040DD RID: 16605
		// (get) Token: 0x060109E1 RID: 68065 RVA: 0x001867B6 File Offset: 0x001849B6
		// (set) Token: 0x060109E2 RID: 68066 RVA: 0x001867CA File Offset: 0x001849CA
		public unsafe UTexture Texture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + UStereoLayerComponent.__PropertyOffset_Texture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UStereoLayerComponent.__PropertyOffset_Texture, value);
			}
		}

		// Token: 0x170040DE RID: 16606
		// (get) Token: 0x060109E3 RID: 68067 RVA: 0x001867DF File Offset: 0x001849DF
		// (set) Token: 0x060109E4 RID: 68068 RVA: 0x001867F3 File Offset: 0x001849F3
		public unsafe UTexture LeftTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + UStereoLayerComponent.__PropertyOffset_LeftTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UStereoLayerComponent.__PropertyOffset_LeftTexture, value);
			}
		}

		// Token: 0x170040DF RID: 16607
		// (get) Token: 0x060109E5 RID: 68069 RVA: 0x00186808 File Offset: 0x00184A08
		// (set) Token: 0x060109E6 RID: 68070 RVA: 0x00186821 File Offset: 0x00184A21
		public unsafe bool bQuadPreserveTextureRatio
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UStereoLayerComponent.__PropertyOffset_bQuadPreserveTextureRatio) & UStereoLayerComponent.__PropertyMask_bQuadPreserveTextureRatio) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UStereoLayerComponent.__PropertyOffset_bQuadPreserveTextureRatio) = ((*(base.NativePtr + (IntPtr)UStereoLayerComponent.__PropertyOffset_bQuadPreserveTextureRatio) & ~UStereoLayerComponent.__PropertyMask_bQuadPreserveTextureRatio) | (value ? UStereoLayerComponent.__PropertyMask_bQuadPreserveTextureRatio : 0));
			}
		}

		// Token: 0x170040E0 RID: 16608
		// (get) Token: 0x060109E7 RID: 68071 RVA: 0x00186851 File Offset: 0x00184A51
		// (set) Token: 0x060109E8 RID: 68072 RVA: 0x00186865 File Offset: 0x00184A65
		public unsafe FVector2D QuadSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStereoLayerComponent.__PropertyOffset_QuadSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStereoLayerComponent.__PropertyOffset_QuadSize) = value;
			}
		}

		// Token: 0x170040E1 RID: 16609
		// (get) Token: 0x060109E9 RID: 68073 RVA: 0x0018687A File Offset: 0x00184A7A
		// (set) Token: 0x060109EA RID: 68074 RVA: 0x0018688E File Offset: 0x00184A8E
		public unsafe FBox2D UVRect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStereoLayerComponent.__PropertyOffset_UVRect);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStereoLayerComponent.__PropertyOffset_UVRect) = value;
			}
		}

		// Token: 0x170040E2 RID: 16610
		// (get) Token: 0x060109EB RID: 68075 RVA: 0x001868A3 File Offset: 0x00184AA3
		// (set) Token: 0x060109EC RID: 68076 RVA: 0x001868B3 File Offset: 0x00184AB3
		public unsafe float CylinderRadius_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStereoLayerComponent.__PropertyOffset_CylinderRadius_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStereoLayerComponent.__PropertyOffset_CylinderRadius_DEPRECATED) = value;
			}
		}

		// Token: 0x170040E3 RID: 16611
		// (get) Token: 0x060109ED RID: 68077 RVA: 0x001868C4 File Offset: 0x00184AC4
		// (set) Token: 0x060109EE RID: 68078 RVA: 0x001868D4 File Offset: 0x00184AD4
		public unsafe float CylinderOverlayArc_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStereoLayerComponent.__PropertyOffset_CylinderOverlayArc_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStereoLayerComponent.__PropertyOffset_CylinderOverlayArc_DEPRECATED) = value;
			}
		}

		// Token: 0x170040E4 RID: 16612
		// (get) Token: 0x060109EF RID: 68079 RVA: 0x001868E5 File Offset: 0x00184AE5
		// (set) Token: 0x060109F0 RID: 68080 RVA: 0x001868F5 File Offset: 0x00184AF5
		public unsafe int CylinderHeight_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStereoLayerComponent.__PropertyOffset_CylinderHeight_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStereoLayerComponent.__PropertyOffset_CylinderHeight_DEPRECATED) = value;
			}
		}

		// Token: 0x170040E5 RID: 16613
		// (get) Token: 0x060109F1 RID: 68081 RVA: 0x00186908 File Offset: 0x00184B08
		// (set) Token: 0x060109F2 RID: 68082 RVA: 0x00186941 File Offset: 0x00184B41
		[Nullable(1)]
		public FEquirectProps EquirectProps_DEPRECATED
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FEquirectProps result;
				if ((result = this._EquirectProps_DEPRECATED) == null)
				{
					result = (this._EquirectProps_DEPRECATED = new FEquirectProps(base.NativePtr + (IntPtr)UStereoLayerComponent.__PropertyOffset_EquirectProps_DEPRECATED, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FEquirectProps.StaticStruct(), base.NativePtr + (IntPtr)UStereoLayerComponent.__PropertyOffset_EquirectProps_DEPRECATED, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170040E6 RID: 16614
		// (get) Token: 0x060109F3 RID: 68083 RVA: 0x00186962 File Offset: 0x00184B62
		// (set) Token: 0x060109F4 RID: 68084 RVA: 0x00186976 File Offset: 0x00184B76
		[Nullable(0)]
		public unsafe TEnumAsByte<EStereoLayerType> StereoLayerType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UStereoLayerComponent.__PropertyOffset_StereoLayerType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UStereoLayerComponent.__PropertyOffset_StereoLayerType) = value;
			}
		}

		// Token: 0x170040E7 RID: 16615
		// (get) Token: 0x060109F5 RID: 68085 RVA: 0x0018698B File Offset: 0x00184B8B
		// (set) Token: 0x060109F6 RID: 68086 RVA: 0x0018699F File Offset: 0x00184B9F
		[Nullable(0)]
		public unsafe TEnumAsByte<EStereoLayerShape> StereoLayerShape_DEPRECATED
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UStereoLayerComponent.__PropertyOffset_StereoLayerShape_DEPRECATED);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UStereoLayerComponent.__PropertyOffset_StereoLayerShape_DEPRECATED) = value;
			}
		}

		// Token: 0x170040E8 RID: 16616
		// (get) Token: 0x060109F7 RID: 68087 RVA: 0x001869B4 File Offset: 0x00184BB4
		// (set) Token: 0x060109F8 RID: 68088 RVA: 0x001869C8 File Offset: 0x00184BC8
		public unsafe UStereoLayerShape Shape
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStereoLayerShape>(base.NativePtr / (IntPtr)sizeof(void*) + UStereoLayerComponent.__PropertyOffset_Shape);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UStereoLayerComponent.__PropertyOffset_Shape, value);
			}
		}

		// Token: 0x170040E9 RID: 16617
		// (get) Token: 0x060109F9 RID: 68089 RVA: 0x001869DD File Offset: 0x00184BDD
		// (set) Token: 0x060109FA RID: 68090 RVA: 0x001869ED File Offset: 0x00184BED
		public unsafe int Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStereoLayerComponent.__PropertyOffset_Priority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStereoLayerComponent.__PropertyOffset_Priority) = value;
			}
		}

		// Token: 0x060109FB RID: 68091 RVA: 0x001869FE File Offset: 0x00184BFE
		public void SetUVRect(FBox2D InUVRect)
		{
			UStereoLayerComponent.__SetUVRect_Internal(base.NativePtr, InUVRect);
		}

		// Token: 0x060109FC RID: 68092 RVA: 0x00186A0C File Offset: 0x00184C0C
		public void SetTexture(UTexture InTexture)
		{
			UStereoLayerComponent.__SetTexture_Internal(base.NativePtr, (InTexture != null) ? InTexture.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060109FD RID: 68093 RVA: 0x00186A29 File Offset: 0x00184C29
		public void SetQuadSize(FVector2D InQuadSize)
		{
			UStereoLayerComponent.__SetQuadSize_Internal(base.NativePtr, InQuadSize);
		}

		// Token: 0x060109FE RID: 68094 RVA: 0x00186A37 File Offset: 0x00184C37
		public void SetPriority(int InPriority)
		{
			UStereoLayerComponent.__SetPriority_Internal(base.NativePtr, InPriority);
		}

		// Token: 0x060109FF RID: 68095 RVA: 0x00186A45 File Offset: 0x00184C45
		public void SetLeftTexture(UTexture InTexture)
		{
			UStereoLayerComponent.__SetLeftTexture_Internal(base.NativePtr, (InTexture != null) ? InTexture.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06010A00 RID: 68096 RVA: 0x00186A62 File Offset: 0x00184C62
		public void SetEquirectProps(FEquirectProps InScaleBiases)
		{
			UStereoLayerComponent.__SetEquirectProps_Internal(base.NativePtr, (InScaleBiases ?? new FEquirectProps()).NativePtr);
		}

		// Token: 0x06010A01 RID: 68097 RVA: 0x00186A7E File Offset: 0x00184C7E
		public void MarkTextureForUpdate()
		{
			UStereoLayerComponent.__MarkTextureForUpdate_Internal(base.NativePtr);
		}

		// Token: 0x06010A02 RID: 68098 RVA: 0x00186A8B File Offset: 0x00184C8B
		public FBox2D GetUVRect()
		{
			return UStereoLayerComponent.__GetUVRect_Internal(base.NativePtr);
		}

		// Token: 0x06010A03 RID: 68099 RVA: 0x00186A98 File Offset: 0x00184C98
		public UTexture GetTexture()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTexture>(UStereoLayerComponent.__GetTexture_Internal(base.NativePtr));
		}

		// Token: 0x06010A04 RID: 68100 RVA: 0x00186AAA File Offset: 0x00184CAA
		public FVector2D GetQuadSize()
		{
			return UStereoLayerComponent.__GetQuadSize_Internal(base.NativePtr);
		}

		// Token: 0x06010A05 RID: 68101 RVA: 0x00186AB7 File Offset: 0x00184CB7
		public int GetPriority()
		{
			return UStereoLayerComponent.__GetPriority_Internal(base.NativePtr);
		}

		// Token: 0x06010A06 RID: 68102 RVA: 0x00186AC4 File Offset: 0x00184CC4
		public UTexture GetLeftTexture()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTexture>(UStereoLayerComponent.__GetLeftTexture_Internal(base.NativePtr));
		}

		// Token: 0x06010A07 RID: 68103
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUVRect_Internal(IntPtr @this, FBox2D InUVRect);

		// Token: 0x06010A08 RID: 68104
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTexture_Internal(IntPtr @this, IntPtr InTexture);

		// Token: 0x06010A09 RID: 68105
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetQuadSize_Internal(IntPtr @this, FVector2D InQuadSize);

		// Token: 0x06010A0A RID: 68106
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPriority_Internal(IntPtr @this, int InPriority);

		// Token: 0x06010A0B RID: 68107
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLeftTexture_Internal(IntPtr @this, IntPtr InTexture);

		// Token: 0x06010A0C RID: 68108
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEquirectProps_Internal(IntPtr @this, IntPtr InScaleBiases);

		// Token: 0x06010A0D RID: 68109
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MarkTextureForUpdate_Internal(IntPtr @this);

		// Token: 0x06010A0E RID: 68110
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox2D __GetUVRect_Internal(IntPtr @this);

		// Token: 0x06010A0F RID: 68111
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetTexture_Internal(IntPtr @this);

		// Token: 0x06010A10 RID: 68112
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetQuadSize_Internal(IntPtr @this);

		// Token: 0x06010A11 RID: 68113
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetPriority_Internal(IntPtr @this);

		// Token: 0x06010A12 RID: 68114
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetLeftTexture_Internal(IntPtr @this);

		// Token: 0x06010A13 RID: 68115 RVA: 0x00186AD6 File Offset: 0x00184CD6
		static UStereoLayerComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.StereoLayerComponent");
		}

		// Token: 0x06010A14 RID: 68116 RVA: 0x00186AE4 File Offset: 0x00184CE4
		protected UStereoLayerComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008E30 RID: 36400
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.StereoLayerComponent";

		// Token: 0x04008E31 RID: 36401
		private static IntPtr _ClassPtr;

		// Token: 0x04008E32 RID: 36402
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008E33 RID: 36403
		internal static int __PropertyOffset_bLiveTexture;

		// Token: 0x04008E34 RID: 36404
		internal static byte __PropertyMask_bLiveTexture;

		// Token: 0x04008E35 RID: 36405
		internal static int __PropertyOffset_bSupportsDepth;

		// Token: 0x04008E36 RID: 36406
		internal static byte __PropertyMask_bSupportsDepth;

		// Token: 0x04008E37 RID: 36407
		internal static int __PropertyOffset_bNoAlphaChannel;

		// Token: 0x04008E38 RID: 36408
		internal static byte __PropertyMask_bNoAlphaChannel;

		// Token: 0x04008E39 RID: 36409
		internal static int __PropertyOffset_Texture;

		// Token: 0x04008E3A RID: 36410
		internal static int __PropertyOffset_LeftTexture;

		// Token: 0x04008E3B RID: 36411
		internal static int __PropertyOffset_bQuadPreserveTextureRatio;

		// Token: 0x04008E3C RID: 36412
		internal static byte __PropertyMask_bQuadPreserveTextureRatio;

		// Token: 0x04008E3D RID: 36413
		internal static int __PropertyOffset_QuadSize;

		// Token: 0x04008E3E RID: 36414
		internal static int __PropertyOffset_UVRect;

		// Token: 0x04008E3F RID: 36415
		internal static int __PropertyOffset_CylinderRadius_DEPRECATED;

		// Token: 0x04008E40 RID: 36416
		internal static int __PropertyOffset_CylinderOverlayArc_DEPRECATED;

		// Token: 0x04008E41 RID: 36417
		internal static int __PropertyOffset_CylinderHeight_DEPRECATED;

		// Token: 0x04008E42 RID: 36418
		internal static int __PropertyOffset_EquirectProps_DEPRECATED;

		// Token: 0x04008E43 RID: 36419
		private FEquirectProps _EquirectProps_DEPRECATED;

		// Token: 0x04008E44 RID: 36420
		internal static int __PropertyOffset_StereoLayerType;

		// Token: 0x04008E45 RID: 36421
		internal static int __PropertyOffset_StereoLayerShape_DEPRECATED;

		// Token: 0x04008E46 RID: 36422
		internal static int __PropertyOffset_Shape;

		// Token: 0x04008E47 RID: 36423
		internal static int __PropertyOffset_Priority;
	}
}
