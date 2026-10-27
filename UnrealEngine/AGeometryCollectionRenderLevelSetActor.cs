using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200142F RID: 5167
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GeometryCollectionEngine.GeometryCollectionRenderLevelSetActor")]
	[UnrealStructLayout(1200, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1200)]
	public class AGeometryCollectionRenderLevelSetActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06012E7B RID: 77435 RVA: 0x001BCA21 File Offset: 0x001BAC21
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AGeometryCollectionRenderLevelSetActor._ClassPtr;
		}

		// Token: 0x06012E7C RID: 77436 RVA: 0x001BCA30 File Offset: 0x001BAC30
		public AGeometryCollectionRenderLevelSetActor() : this(BuiltinUtils.AllocNativeUObject(AGeometryCollectionRenderLevelSetActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012E7D RID: 77437 RVA: 0x001BCA58 File Offset: 0x001BAC58
		[NullableContext(1)]
		public AGeometryCollectionRenderLevelSetActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AGeometryCollectionRenderLevelSetActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004973 RID: 18803
		// (get) Token: 0x06012E7E RID: 77438 RVA: 0x001BCA8B File Offset: 0x001BAC8B
		// (set) Token: 0x06012E7F RID: 77439 RVA: 0x001BCA9F File Offset: 0x001BAC9F
		public unsafe UVolumeTexture TargetVolumeTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UVolumeTexture>(base.NativePtr / (IntPtr)sizeof(void*) + AGeometryCollectionRenderLevelSetActor.__PropertyOffset_TargetVolumeTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AGeometryCollectionRenderLevelSetActor.__PropertyOffset_TargetVolumeTexture, value);
			}
		}

		// Token: 0x17004974 RID: 18804
		// (get) Token: 0x06012E80 RID: 77440 RVA: 0x001BCAB4 File Offset: 0x001BACB4
		// (set) Token: 0x06012E81 RID: 77441 RVA: 0x001BCAC8 File Offset: 0x001BACC8
		public unsafe UMaterial RayMarchMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + AGeometryCollectionRenderLevelSetActor.__PropertyOffset_RayMarchMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AGeometryCollectionRenderLevelSetActor.__PropertyOffset_RayMarchMaterial, value);
			}
		}

		// Token: 0x17004975 RID: 18805
		// (get) Token: 0x06012E82 RID: 77442 RVA: 0x001BCADD File Offset: 0x001BACDD
		// (set) Token: 0x06012E83 RID: 77443 RVA: 0x001BCAED File Offset: 0x001BACED
		public unsafe float SurfaceTolerance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionRenderLevelSetActor.__PropertyOffset_SurfaceTolerance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionRenderLevelSetActor.__PropertyOffset_SurfaceTolerance) = value;
			}
		}

		// Token: 0x17004976 RID: 18806
		// (get) Token: 0x06012E84 RID: 77444 RVA: 0x001BCAFE File Offset: 0x001BACFE
		// (set) Token: 0x06012E85 RID: 77445 RVA: 0x001BCB0E File Offset: 0x001BAD0E
		public unsafe float Isovalue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionRenderLevelSetActor.__PropertyOffset_Isovalue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionRenderLevelSetActor.__PropertyOffset_Isovalue) = value;
			}
		}

		// Token: 0x17004977 RID: 18807
		// (get) Token: 0x06012E86 RID: 77446 RVA: 0x001BCB1F File Offset: 0x001BAD1F
		// (set) Token: 0x06012E87 RID: 77447 RVA: 0x001BCB2F File Offset: 0x001BAD2F
		public unsafe bool Enabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionRenderLevelSetActor.__PropertyOffset_Enabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionRenderLevelSetActor.__PropertyOffset_Enabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004978 RID: 18808
		// (get) Token: 0x06012E88 RID: 77448 RVA: 0x001BCB40 File Offset: 0x001BAD40
		// (set) Token: 0x06012E89 RID: 77449 RVA: 0x001BCB50 File Offset: 0x001BAD50
		public unsafe bool RenderVolumeBoundingBox
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionRenderLevelSetActor.__PropertyOffset_RenderVolumeBoundingBox) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionRenderLevelSetActor.__PropertyOffset_RenderVolumeBoundingBox) = (value ? 1 : 0);
			}
		}

		// Token: 0x06012E8A RID: 77450 RVA: 0x001BCB61 File Offset: 0x001BAD61
		static AGeometryCollectionRenderLevelSetActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GeometryCollectionEngine.GeometryCollectionRenderLevelSetActor");
		}

		// Token: 0x06012E8B RID: 77451 RVA: 0x001BCB6F File Offset: 0x001BAD6F
		protected AGeometryCollectionRenderLevelSetActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A1A1 RID: 41377
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GeometryCollectionEngine.GeometryCollectionRenderLevelSetActor";

		// Token: 0x0400A1A2 RID: 41378
		private static IntPtr _ClassPtr;

		// Token: 0x0400A1A3 RID: 41379
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A1A4 RID: 41380
		internal static int __PropertyOffset_TargetVolumeTexture;

		// Token: 0x0400A1A5 RID: 41381
		internal static int __PropertyOffset_RayMarchMaterial;

		// Token: 0x0400A1A6 RID: 41382
		internal static int __PropertyOffset_SurfaceTolerance;

		// Token: 0x0400A1A7 RID: 41383
		internal static int __PropertyOffset_Isovalue;

		// Token: 0x0400A1A8 RID: 41384
		internal static int __PropertyOffset_Enabled;

		// Token: 0x0400A1A9 RID: 41385
		internal static int __PropertyOffset_RenderVolumeBoundingBox;
	}
}
