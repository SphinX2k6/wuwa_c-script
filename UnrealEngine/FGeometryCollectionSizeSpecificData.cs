using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001431 RID: 5169
	[UnrealObjectPath("/Script/GeometryCollectionEngine.GeometryCollectionSizeSpecificData")]
	[UnrealStructLayout(36, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 36)]
	public class FGeometryCollectionSizeSpecificData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012E93 RID: 77459 RVA: 0x001BCBD8 File Offset: 0x001BADD8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGeometryCollectionSizeSpecificData._ScriptStructPtr != 0) ? FGeometryCollectionSizeSpecificData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GeometryCollectionEngine.GeometryCollectionSizeSpecificData", ref FGeometryCollectionSizeSpecificData._ScriptStructPtr);
		}

		// Token: 0x17004979 RID: 18809
		// (get) Token: 0x06012E94 RID: 77460 RVA: 0x001BCBFC File Offset: 0x001BADFC
		// (set) Token: 0x06012E95 RID: 77461 RVA: 0x001BCC0C File Offset: 0x001BAE0C
		public unsafe float MaxSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGeometryCollectionSizeSpecificData.__PropertyOffset_MaxSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGeometryCollectionSizeSpecificData.__PropertyOffset_MaxSize) = value;
			}
		}

		// Token: 0x1700497A RID: 18810
		// (get) Token: 0x06012E96 RID: 77462 RVA: 0x001BCC1D File Offset: 0x001BAE1D
		// (set) Token: 0x06012E97 RID: 77463 RVA: 0x001BCC2D File Offset: 0x001BAE2D
		public unsafe ECollisionTypeEnum CollisionType
		{
			get
			{
				return (ECollisionTypeEnum)(*(base.NativePtr + (IntPtr)FGeometryCollectionSizeSpecificData.__PropertyOffset_CollisionType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGeometryCollectionSizeSpecificData.__PropertyOffset_CollisionType) = (byte)value;
			}
		}

		// Token: 0x1700497B RID: 18811
		// (get) Token: 0x06012E98 RID: 77464 RVA: 0x001BCC3E File Offset: 0x001BAE3E
		// (set) Token: 0x06012E99 RID: 77465 RVA: 0x001BCC4E File Offset: 0x001BAE4E
		public unsafe EImplicitTypeEnum ImplicitType
		{
			get
			{
				return (EImplicitTypeEnum)(*(base.NativePtr + (IntPtr)FGeometryCollectionSizeSpecificData.__PropertyOffset_ImplicitType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGeometryCollectionSizeSpecificData.__PropertyOffset_ImplicitType) = (byte)value;
			}
		}

		// Token: 0x1700497C RID: 18812
		// (get) Token: 0x06012E9A RID: 77466 RVA: 0x001BCC5F File Offset: 0x001BAE5F
		// (set) Token: 0x06012E9B RID: 77467 RVA: 0x001BCC6F File Offset: 0x001BAE6F
		public unsafe int MinLevelSetResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGeometryCollectionSizeSpecificData.__PropertyOffset_MinLevelSetResolution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGeometryCollectionSizeSpecificData.__PropertyOffset_MinLevelSetResolution) = value;
			}
		}

		// Token: 0x1700497D RID: 18813
		// (get) Token: 0x06012E9C RID: 77468 RVA: 0x001BCC80 File Offset: 0x001BAE80
		// (set) Token: 0x06012E9D RID: 77469 RVA: 0x001BCC90 File Offset: 0x001BAE90
		public unsafe int MaxLevelSetResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGeometryCollectionSizeSpecificData.__PropertyOffset_MaxLevelSetResolution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGeometryCollectionSizeSpecificData.__PropertyOffset_MaxLevelSetResolution) = value;
			}
		}

		// Token: 0x1700497E RID: 18814
		// (get) Token: 0x06012E9E RID: 77470 RVA: 0x001BCCA1 File Offset: 0x001BAEA1
		// (set) Token: 0x06012E9F RID: 77471 RVA: 0x001BCCB1 File Offset: 0x001BAEB1
		public unsafe int MinClusterLevelSetResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGeometryCollectionSizeSpecificData.__PropertyOffset_MinClusterLevelSetResolution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGeometryCollectionSizeSpecificData.__PropertyOffset_MinClusterLevelSetResolution) = value;
			}
		}

		// Token: 0x1700497F RID: 18815
		// (get) Token: 0x06012EA0 RID: 77472 RVA: 0x001BCCC2 File Offset: 0x001BAEC2
		// (set) Token: 0x06012EA1 RID: 77473 RVA: 0x001BCCD2 File Offset: 0x001BAED2
		public unsafe int MaxClusterLevelSetResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGeometryCollectionSizeSpecificData.__PropertyOffset_MaxClusterLevelSetResolution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGeometryCollectionSizeSpecificData.__PropertyOffset_MaxClusterLevelSetResolution) = value;
			}
		}

		// Token: 0x17004980 RID: 18816
		// (get) Token: 0x06012EA2 RID: 77474 RVA: 0x001BCCE3 File Offset: 0x001BAEE3
		// (set) Token: 0x06012EA3 RID: 77475 RVA: 0x001BCCF3 File Offset: 0x001BAEF3
		public unsafe int CollisionObjectReductionPercentage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGeometryCollectionSizeSpecificData.__PropertyOffset_CollisionObjectReductionPercentage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGeometryCollectionSizeSpecificData.__PropertyOffset_CollisionObjectReductionPercentage) = value;
			}
		}

		// Token: 0x17004981 RID: 18817
		// (get) Token: 0x06012EA4 RID: 77476 RVA: 0x001BCD04 File Offset: 0x001BAF04
		// (set) Token: 0x06012EA5 RID: 77477 RVA: 0x001BCD14 File Offset: 0x001BAF14
		public unsafe float CollisionParticlesFraction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGeometryCollectionSizeSpecificData.__PropertyOffset_CollisionParticlesFraction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGeometryCollectionSizeSpecificData.__PropertyOffset_CollisionParticlesFraction) = value;
			}
		}

		// Token: 0x17004982 RID: 18818
		// (get) Token: 0x06012EA6 RID: 77478 RVA: 0x001BCD25 File Offset: 0x001BAF25
		// (set) Token: 0x06012EA7 RID: 77479 RVA: 0x001BCD35 File Offset: 0x001BAF35
		public unsafe int MaximumCollisionParticles
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGeometryCollectionSizeSpecificData.__PropertyOffset_MaximumCollisionParticles);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGeometryCollectionSizeSpecificData.__PropertyOffset_MaximumCollisionParticles) = value;
			}
		}

		// Token: 0x06012EA8 RID: 77480 RVA: 0x001BCD46 File Offset: 0x001BAF46
		public FGeometryCollectionSizeSpecificData()
		{
		}

		// Token: 0x06012EA9 RID: 77481 RVA: 0x001BCD50 File Offset: 0x001BAF50
		public FGeometryCollectionSizeSpecificData(float MaxSize, ECollisionTypeEnum CollisionType, EImplicitTypeEnum ImplicitType, int MinLevelSetResolution, int MaxLevelSetResolution, int MinClusterLevelSetResolution, int MaxClusterLevelSetResolution, int CollisionObjectReductionPercentage, float CollisionParticlesFraction, int MaximumCollisionParticles)
		{
			this.MaxSize = MaxSize;
			this.CollisionType = CollisionType;
			this.ImplicitType = ImplicitType;
			this.MinLevelSetResolution = MinLevelSetResolution;
			this.MaxLevelSetResolution = MaxLevelSetResolution;
			this.MinClusterLevelSetResolution = MinClusterLevelSetResolution;
			this.MaxClusterLevelSetResolution = MaxClusterLevelSetResolution;
			this.CollisionObjectReductionPercentage = CollisionObjectReductionPercentage;
			this.CollisionParticlesFraction = CollisionParticlesFraction;
			this.MaximumCollisionParticles = MaximumCollisionParticles;
		}

		// Token: 0x06012EAA RID: 77482 RVA: 0x001BCDB0 File Offset: 0x001BAFB0
		protected override IntPtr GetUStructPtr()
		{
			return FGeometryCollectionSizeSpecificData.StaticStruct();
		}

		// Token: 0x06012EAB RID: 77483 RVA: 0x001BCDBC File Offset: 0x001BAFBC
		[NullableContext(2)]
		public FGeometryCollectionSizeSpecificData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012EAC RID: 77484 RVA: 0x001BCDC6 File Offset: 0x001BAFC6
		public FGeometryCollectionSizeSpecificData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012EAD RID: 77485 RVA: 0x001BCDD1 File Offset: 0x001BAFD1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGeometryCollectionSizeSpecificData(Pointer, false, true);
		}

		// Token: 0x06012EAE RID: 77486 RVA: 0x001BCDDB File Offset: 0x001BAFDB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGeometryCollectionSizeSpecificData(Pointer, MemoryOwner);
		}

		// Token: 0x0400A1AC RID: 41388
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GeometryCollectionEngine.GeometryCollectionSizeSpecificData";

		// Token: 0x0400A1AD RID: 41389
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400A1AE RID: 41390
		internal static int __PropertyOffset_MaxSize;

		// Token: 0x0400A1AF RID: 41391
		internal static int __PropertyOffset_CollisionType;

		// Token: 0x0400A1B0 RID: 41392
		internal static int __PropertyOffset_ImplicitType;

		// Token: 0x0400A1B1 RID: 41393
		internal static int __PropertyOffset_MinLevelSetResolution;

		// Token: 0x0400A1B2 RID: 41394
		internal static int __PropertyOffset_MaxLevelSetResolution;

		// Token: 0x0400A1B3 RID: 41395
		internal static int __PropertyOffset_MinClusterLevelSetResolution;

		// Token: 0x0400A1B4 RID: 41396
		internal static int __PropertyOffset_MaxClusterLevelSetResolution;

		// Token: 0x0400A1B5 RID: 41397
		internal static int __PropertyOffset_CollisionObjectReductionPercentage;

		// Token: 0x0400A1B6 RID: 41398
		internal static int __PropertyOffset_CollisionParticlesFraction;

		// Token: 0x0400A1B7 RID: 41399
		internal static int __PropertyOffset_MaximumCollisionParticles;
	}
}
