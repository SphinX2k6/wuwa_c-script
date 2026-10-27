using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001765 RID: 5989
	[UnrealObjectPath("/Script/KuroComponent.KuroSplineChainComponent")]
	[UnrealStructLayout(1936, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1936)]
	public class UKuroSplineChainComponent : UKuroChainComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060158B0 RID: 88240 RVA: 0x001FB228 File Offset: 0x001F9428
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSplineChainComponent._ClassPtr;
		}

		// Token: 0x060158B1 RID: 88241 RVA: 0x001FB234 File Offset: 0x001F9434
		public UKuroSplineChainComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroSplineChainComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060158B2 RID: 88242 RVA: 0x001FB25C File Offset: 0x001F945C
		[NullableContext(1)]
		public UKuroSplineChainComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroSplineChainComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700550D RID: 21773
		// (get) Token: 0x060158B3 RID: 88243 RVA: 0x001FB28F File Offset: 0x001F948F
		// (set) Token: 0x060158B4 RID: 88244 RVA: 0x001FB29F File Offset: 0x001F949F
		public unsafe float SplineMaxLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSplineChainComponent.__PropertyOffset_SplineMaxLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSplineChainComponent.__PropertyOffset_SplineMaxLength) = value;
			}
		}

		// Token: 0x1700550E RID: 21774
		// (get) Token: 0x060158B5 RID: 88245 RVA: 0x001FB2B0 File Offset: 0x001F94B0
		// (set) Token: 0x060158B6 RID: 88246 RVA: 0x001FB2C0 File Offset: 0x001F94C0
		public unsafe float MeshMinScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSplineChainComponent.__PropertyOffset_MeshMinScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSplineChainComponent.__PropertyOffset_MeshMinScale) = value;
			}
		}

		// Token: 0x1700550F RID: 21775
		// (get) Token: 0x060158B7 RID: 88247 RVA: 0x001FB2D1 File Offset: 0x001F94D1
		// (set) Token: 0x060158B8 RID: 88248 RVA: 0x001FB2E1 File Offset: 0x001F94E1
		public unsafe float MeshMaxScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSplineChainComponent.__PropertyOffset_MeshMaxScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSplineChainComponent.__PropertyOffset_MeshMaxScale) = value;
			}
		}

		// Token: 0x17005510 RID: 21776
		// (get) Token: 0x060158B9 RID: 88249 RVA: 0x001FB2F2 File Offset: 0x001F94F2
		// (set) Token: 0x060158BA RID: 88250 RVA: 0x001FB302 File Offset: 0x001F9502
		public unsafe float MeshXYScaleRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSplineChainComponent.__PropertyOffset_MeshXYScaleRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSplineChainComponent.__PropertyOffset_MeshXYScaleRatio) = value;
			}
		}

		// Token: 0x17005511 RID: 21777
		// (get) Token: 0x060158BB RID: 88251 RVA: 0x001FB313 File Offset: 0x001F9513
		// (set) Token: 0x060158BC RID: 88252 RVA: 0x001FB323 File Offset: 0x001F9523
		public unsafe float SegmentLengthMinScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSplineChainComponent.__PropertyOffset_SegmentLengthMinScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSplineChainComponent.__PropertyOffset_SegmentLengthMinScale) = value;
			}
		}

		// Token: 0x17005512 RID: 21778
		// (get) Token: 0x060158BD RID: 88253 RVA: 0x001FB334 File Offset: 0x001F9534
		// (set) Token: 0x060158BE RID: 88254 RVA: 0x001FB344 File Offset: 0x001F9544
		public unsafe float SegmentLengthMaxScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSplineChainComponent.__PropertyOffset_SegmentLengthMaxScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSplineChainComponent.__PropertyOffset_SegmentLengthMaxScale) = value;
			}
		}

		// Token: 0x17005513 RID: 21779
		// (get) Token: 0x060158BF RID: 88255 RVA: 0x001FB355 File Offset: 0x001F9555
		// (set) Token: 0x060158C0 RID: 88256 RVA: 0x001FB369 File Offset: 0x001F9569
		[Nullable(2)]
		public unsafe USplineComponent SplineComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroSplineChainComponent.__PropertyOffset_SplineComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroSplineChainComponent.__PropertyOffset_SplineComponent, value);
			}
		}

		// Token: 0x060158C1 RID: 88257 RVA: 0x001FB37E File Offset: 0x001F957E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void UpdateSplineChainIndex()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSplineChainComponent.__UpdateSplineChainIndex_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060158C2 RID: 88258 RVA: 0x001FB393 File Offset: 0x001F9593
		static UKuroSplineChainComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComponent.KuroSplineChainComponent");
		}

		// Token: 0x060158C3 RID: 88259 RVA: 0x001FB3A1 File Offset: 0x001F95A1
		protected UKuroSplineChainComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BC20 RID: 48160
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroComponent.KuroSplineChainComponent";

		// Token: 0x0400BC21 RID: 48161
		private static IntPtr _ClassPtr;

		// Token: 0x0400BC22 RID: 48162
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400BC23 RID: 48163
		internal static int __PropertyOffset_SplineMaxLength;

		// Token: 0x0400BC24 RID: 48164
		internal static int __PropertyOffset_MeshMinScale;

		// Token: 0x0400BC25 RID: 48165
		internal static int __PropertyOffset_MeshMaxScale;

		// Token: 0x0400BC26 RID: 48166
		internal static int __PropertyOffset_MeshXYScaleRatio;

		// Token: 0x0400BC27 RID: 48167
		internal static int __PropertyOffset_SegmentLengthMinScale;

		// Token: 0x0400BC28 RID: 48168
		internal static int __PropertyOffset_SegmentLengthMaxScale;

		// Token: 0x0400BC29 RID: 48169
		internal static int __PropertyOffset_SplineComponent;

		// Token: 0x0400BC2A RID: 48170
		private static IntPtr __UpdateSplineChainIndex_NativeFunctionPtr;
	}
}
