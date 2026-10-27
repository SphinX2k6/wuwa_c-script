using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010C6 RID: 4294
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.RuntimeVirtualTextureComponent")]
	[UnrealStructLayout(704, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 704)]
	public class URuntimeVirtualTextureComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F51F RID: 62751 RVA: 0x0016B59E File Offset: 0x0016979E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URuntimeVirtualTextureComponent._ClassPtr;
		}

		// Token: 0x0600F520 RID: 62752 RVA: 0x0016B5AC File Offset: 0x001697AC
		public URuntimeVirtualTextureComponent() : this(BuiltinUtils.AllocNativeUObject(URuntimeVirtualTextureComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F521 RID: 62753 RVA: 0x0016B5D4 File Offset: 0x001697D4
		[NullableContext(1)]
		public URuntimeVirtualTextureComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URuntimeVirtualTextureComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003BB1 RID: 15281
		// (get) Token: 0x0600F522 RID: 62754 RVA: 0x0016B607 File Offset: 0x00169807
		// (set) Token: 0x0600F523 RID: 62755 RVA: 0x0016B61C File Offset: 0x0016981C
		[Nullable(1)]
		public TSoftObjectPtr<AActor> BoundsAlignActor
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<AActor>(base.NativePtr + (IntPtr)URuntimeVirtualTextureComponent.__PropertyOffset_BoundsAlignActor, this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)URuntimeVirtualTextureComponent.__PropertyOffset_BoundsAlignActor, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003BB2 RID: 15282
		// (get) Token: 0x0600F524 RID: 62756 RVA: 0x0016B641 File Offset: 0x00169841
		// (set) Token: 0x0600F525 RID: 62757 RVA: 0x0016B651 File Offset: 0x00169851
		public unsafe bool bSetBoundsButton
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URuntimeVirtualTextureComponent.__PropertyOffset_bSetBoundsButton) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)URuntimeVirtualTextureComponent.__PropertyOffset_bSetBoundsButton) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003BB3 RID: 15283
		// (get) Token: 0x0600F526 RID: 62758 RVA: 0x0016B662 File Offset: 0x00169862
		// (set) Token: 0x0600F527 RID: 62759 RVA: 0x0016B672 File Offset: 0x00169872
		public unsafe bool bSnapBoundsToLandscape
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URuntimeVirtualTextureComponent.__PropertyOffset_bSnapBoundsToLandscape) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)URuntimeVirtualTextureComponent.__PropertyOffset_bSnapBoundsToLandscape) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003BB4 RID: 15284
		// (get) Token: 0x0600F528 RID: 62760 RVA: 0x0016B683 File Offset: 0x00169883
		// (set) Token: 0x0600F529 RID: 62761 RVA: 0x0016B697 File Offset: 0x00169897
		public unsafe URuntimeVirtualTexture VirtualTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<URuntimeVirtualTexture>(base.NativePtr / (IntPtr)sizeof(void*) + URuntimeVirtualTextureComponent.__PropertyOffset_VirtualTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + URuntimeVirtualTextureComponent.__PropertyOffset_VirtualTexture, value);
			}
		}

		// Token: 0x17003BB5 RID: 15285
		// (get) Token: 0x0600F52A RID: 62762 RVA: 0x0016B6AC File Offset: 0x001698AC
		// (set) Token: 0x0600F52B RID: 62763 RVA: 0x0016B6BC File Offset: 0x001698BC
		public unsafe bool bEnableScalability
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URuntimeVirtualTextureComponent.__PropertyOffset_bEnableScalability) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)URuntimeVirtualTextureComponent.__PropertyOffset_bEnableScalability) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003BB6 RID: 15286
		// (get) Token: 0x0600F52C RID: 62764 RVA: 0x0016B6CD File Offset: 0x001698CD
		// (set) Token: 0x0600F52D RID: 62765 RVA: 0x0016B6DD File Offset: 0x001698DD
		public unsafe uint ScalabilityGroup
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URuntimeVirtualTextureComponent.__PropertyOffset_ScalabilityGroup);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URuntimeVirtualTextureComponent.__PropertyOffset_ScalabilityGroup) = (int)value;
			}
		}

		// Token: 0x17003BB7 RID: 15287
		// (get) Token: 0x0600F52E RID: 62766 RVA: 0x0016B6EE File Offset: 0x001698EE
		// (set) Token: 0x0600F52F RID: 62767 RVA: 0x0016B6FE File Offset: 0x001698FE
		public unsafe bool bHidePrimitives
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URuntimeVirtualTextureComponent.__PropertyOffset_bHidePrimitives) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)URuntimeVirtualTextureComponent.__PropertyOffset_bHidePrimitives) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003BB8 RID: 15288
		// (get) Token: 0x0600F530 RID: 62768 RVA: 0x0016B70F File Offset: 0x0016990F
		// (set) Token: 0x0600F531 RID: 62769 RVA: 0x0016B723 File Offset: 0x00169923
		public unsafe UVirtualTextureBuilder StreamingTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UVirtualTextureBuilder>(base.NativePtr / (IntPtr)sizeof(void*) + URuntimeVirtualTextureComponent.__PropertyOffset_StreamingTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + URuntimeVirtualTextureComponent.__PropertyOffset_StreamingTexture, value);
			}
		}

		// Token: 0x17003BB9 RID: 15289
		// (get) Token: 0x0600F532 RID: 62770 RVA: 0x0016B738 File Offset: 0x00169938
		// (set) Token: 0x0600F533 RID: 62771 RVA: 0x0016B748 File Offset: 0x00169948
		public unsafe int StreamLowMips
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URuntimeVirtualTextureComponent.__PropertyOffset_StreamLowMips);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URuntimeVirtualTextureComponent.__PropertyOffset_StreamLowMips) = value;
			}
		}

		// Token: 0x17003BBA RID: 15290
		// (get) Token: 0x0600F534 RID: 62772 RVA: 0x0016B759 File Offset: 0x00169959
		// (set) Token: 0x0600F535 RID: 62773 RVA: 0x0016B769 File Offset: 0x00169969
		public unsafe bool bBuildStreamingMipsButton
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URuntimeVirtualTextureComponent.__PropertyOffset_bBuildStreamingMipsButton) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)URuntimeVirtualTextureComponent.__PropertyOffset_bBuildStreamingMipsButton) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003BBB RID: 15291
		// (get) Token: 0x0600F536 RID: 62774 RVA: 0x0016B77A File Offset: 0x0016997A
		// (set) Token: 0x0600F537 RID: 62775 RVA: 0x0016B78A File Offset: 0x0016998A
		public unsafe bool bEnableCompressCrunch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URuntimeVirtualTextureComponent.__PropertyOffset_bEnableCompressCrunch) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)URuntimeVirtualTextureComponent.__PropertyOffset_bEnableCompressCrunch) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003BBC RID: 15292
		// (get) Token: 0x0600F538 RID: 62776 RVA: 0x0016B79B File Offset: 0x0016999B
		// (set) Token: 0x0600F539 RID: 62777 RVA: 0x0016B7AB File Offset: 0x001699AB
		public unsafe bool bUseStreamingLowMipsInEditor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URuntimeVirtualTextureComponent.__PropertyOffset_bUseStreamingLowMipsInEditor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)URuntimeVirtualTextureComponent.__PropertyOffset_bUseStreamingLowMipsInEditor) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003BBD RID: 15293
		// (get) Token: 0x0600F53A RID: 62778 RVA: 0x0016B7BC File Offset: 0x001699BC
		// (set) Token: 0x0600F53B RID: 62779 RVA: 0x0016B7CC File Offset: 0x001699CC
		public unsafe bool bBuildDebugStreamingMips
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URuntimeVirtualTextureComponent.__PropertyOffset_bBuildDebugStreamingMips) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)URuntimeVirtualTextureComponent.__PropertyOffset_bBuildDebugStreamingMips) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600F53C RID: 62780 RVA: 0x0016B7DD File Offset: 0x001699DD
		public void Invalidate(in FBoxSphereBounds WorldBounds)
		{
			URuntimeVirtualTextureComponent.__Invalidate_Internal(base.NativePtr, WorldBounds);
		}

		// Token: 0x0600F53D RID: 62781
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Invalidate_Internal(IntPtr @this, in FBoxSphereBounds WorldBounds);

		// Token: 0x0600F53E RID: 62782 RVA: 0x0016B7EB File Offset: 0x001699EB
		static URuntimeVirtualTextureComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.RuntimeVirtualTextureComponent");
		}

		// Token: 0x0600F53F RID: 62783 RVA: 0x0016B7F9 File Offset: 0x001699F9
		protected URuntimeVirtualTextureComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040084D2 RID: 34002
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.RuntimeVirtualTextureComponent";

		// Token: 0x040084D3 RID: 34003
		private static IntPtr _ClassPtr;

		// Token: 0x040084D4 RID: 34004
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040084D5 RID: 34005
		internal static int __PropertyOffset_BoundsAlignActor;

		// Token: 0x040084D6 RID: 34006
		internal static int __PropertyOffset_bSetBoundsButton;

		// Token: 0x040084D7 RID: 34007
		internal static int __PropertyOffset_bSnapBoundsToLandscape;

		// Token: 0x040084D8 RID: 34008
		internal static int __PropertyOffset_VirtualTexture;

		// Token: 0x040084D9 RID: 34009
		internal static int __PropertyOffset_bEnableScalability;

		// Token: 0x040084DA RID: 34010
		internal static int __PropertyOffset_ScalabilityGroup;

		// Token: 0x040084DB RID: 34011
		internal static int __PropertyOffset_bHidePrimitives;

		// Token: 0x040084DC RID: 34012
		internal static int __PropertyOffset_StreamingTexture;

		// Token: 0x040084DD RID: 34013
		internal static int __PropertyOffset_StreamLowMips;

		// Token: 0x040084DE RID: 34014
		internal static int __PropertyOffset_bBuildStreamingMipsButton;

		// Token: 0x040084DF RID: 34015
		internal static int __PropertyOffset_bEnableCompressCrunch;

		// Token: 0x040084E0 RID: 34016
		internal static int __PropertyOffset_bUseStreamingLowMipsInEditor;

		// Token: 0x040084E1 RID: 34017
		internal static int __PropertyOffset_bBuildDebugStreamingMips;
	}
}
