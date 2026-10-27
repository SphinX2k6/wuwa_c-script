using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200142B RID: 5163
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GeometryCollectionEngine.GeometryCollectionDebugDrawActor")]
	[UnrealStructLayout(1272, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1272)]
	public class AGeometryCollectionDebugDrawActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06012DE0 RID: 77280 RVA: 0x001BBE9C File Offset: 0x001BA09C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AGeometryCollectionDebugDrawActor._ClassPtr;
		}

		// Token: 0x06012DE1 RID: 77281 RVA: 0x001BBEA8 File Offset: 0x001BA0A8
		public AGeometryCollectionDebugDrawActor() : this(BuiltinUtils.AllocNativeUObject(AGeometryCollectionDebugDrawActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012DE2 RID: 77282 RVA: 0x001BBED0 File Offset: 0x001BA0D0
		public AGeometryCollectionDebugDrawActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AGeometryCollectionDebugDrawActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004931 RID: 18737
		// (get) Token: 0x06012DE3 RID: 77283 RVA: 0x001BBF03 File Offset: 0x001BA103
		// (set) Token: 0x06012DE4 RID: 77284 RVA: 0x001BBF17 File Offset: 0x001BA117
		public unsafe FGeometryCollectionDebugDrawWarningMessage WarningMessage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_WarningMessage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_WarningMessage) = value;
			}
		}

		// Token: 0x17004932 RID: 18738
		// (get) Token: 0x06012DE5 RID: 77285 RVA: 0x001BBF2C File Offset: 0x001BA12C
		// (set) Token: 0x06012DE6 RID: 77286 RVA: 0x001BBF65 File Offset: 0x001BA165
		public FGeometryCollectionDebugDrawActorSelectedRigidBody SelectedRigidBody
		{
			get
			{
				base.FastCheckIsValid();
				FGeometryCollectionDebugDrawActorSelectedRigidBody result;
				if ((result = this._SelectedRigidBody) == null)
				{
					result = (this._SelectedRigidBody = new FGeometryCollectionDebugDrawActorSelectedRigidBody(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_SelectedRigidBody, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGeometryCollectionDebugDrawActorSelectedRigidBody.StaticStruct(), base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_SelectedRigidBody, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004933 RID: 18739
		// (get) Token: 0x06012DE7 RID: 77287 RVA: 0x001BBF86 File Offset: 0x001BA186
		// (set) Token: 0x06012DE8 RID: 77288 RVA: 0x001BBF96 File Offset: 0x001BA196
		public unsafe bool bDebugDrawWholeCollection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bDebugDrawWholeCollection) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bDebugDrawWholeCollection) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004934 RID: 18740
		// (get) Token: 0x06012DE9 RID: 77289 RVA: 0x001BBFA7 File Offset: 0x001BA1A7
		// (set) Token: 0x06012DEA RID: 77290 RVA: 0x001BBFB7 File Offset: 0x001BA1B7
		public unsafe bool bDebugDrawHierarchy
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bDebugDrawHierarchy) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bDebugDrawHierarchy) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004935 RID: 18741
		// (get) Token: 0x06012DEB RID: 77291 RVA: 0x001BBFC8 File Offset: 0x001BA1C8
		// (set) Token: 0x06012DEC RID: 77292 RVA: 0x001BBFD8 File Offset: 0x001BA1D8
		public unsafe bool bDebugDrawClustering
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bDebugDrawClustering) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bDebugDrawClustering) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004936 RID: 18742
		// (get) Token: 0x06012DED RID: 77293 RVA: 0x001BBFE9 File Offset: 0x001BA1E9
		// (set) Token: 0x06012DEE RID: 77294 RVA: 0x001BBFF9 File Offset: 0x001BA1F9
		public unsafe EGeometryCollectionDebugDrawActorHideGeometry HideGeometry
		{
			get
			{
				return (EGeometryCollectionDebugDrawActorHideGeometry)(*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_HideGeometry));
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_HideGeometry) = (byte)value;
			}
		}

		// Token: 0x17004937 RID: 18743
		// (get) Token: 0x06012DEF RID: 77295 RVA: 0x001BC00A File Offset: 0x001BA20A
		// (set) Token: 0x06012DF0 RID: 77296 RVA: 0x001BC01A File Offset: 0x001BA21A
		public unsafe bool bShowRigidBodyId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bShowRigidBodyId) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bShowRigidBodyId) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004938 RID: 18744
		// (get) Token: 0x06012DF1 RID: 77297 RVA: 0x001BC02B File Offset: 0x001BA22B
		// (set) Token: 0x06012DF2 RID: 77298 RVA: 0x001BC03B File Offset: 0x001BA23B
		public unsafe bool bShowRigidBodyCollision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bShowRigidBodyCollision) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bShowRigidBodyCollision) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004939 RID: 18745
		// (get) Token: 0x06012DF3 RID: 77299 RVA: 0x001BC04C File Offset: 0x001BA24C
		// (set) Token: 0x06012DF4 RID: 77300 RVA: 0x001BC05C File Offset: 0x001BA25C
		public unsafe bool bCollisionAtOrigin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bCollisionAtOrigin) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bCollisionAtOrigin) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700493A RID: 18746
		// (get) Token: 0x06012DF5 RID: 77301 RVA: 0x001BC06D File Offset: 0x001BA26D
		// (set) Token: 0x06012DF6 RID: 77302 RVA: 0x001BC07D File Offset: 0x001BA27D
		public unsafe bool bShowRigidBodyTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bShowRigidBodyTransform) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bShowRigidBodyTransform) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700493B RID: 18747
		// (get) Token: 0x06012DF7 RID: 77303 RVA: 0x001BC08E File Offset: 0x001BA28E
		// (set) Token: 0x06012DF8 RID: 77304 RVA: 0x001BC09E File Offset: 0x001BA29E
		public unsafe bool bShowRigidBodyInertia
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bShowRigidBodyInertia) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bShowRigidBodyInertia) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700493C RID: 18748
		// (get) Token: 0x06012DF9 RID: 77305 RVA: 0x001BC0AF File Offset: 0x001BA2AF
		// (set) Token: 0x06012DFA RID: 77306 RVA: 0x001BC0BF File Offset: 0x001BA2BF
		public unsafe bool bShowRigidBodyVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bShowRigidBodyVelocity) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bShowRigidBodyVelocity) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700493D RID: 18749
		// (get) Token: 0x06012DFB RID: 77307 RVA: 0x001BC0D0 File Offset: 0x001BA2D0
		// (set) Token: 0x06012DFC RID: 77308 RVA: 0x001BC0E0 File Offset: 0x001BA2E0
		public unsafe bool bShowRigidBodyForce
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bShowRigidBodyForce) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bShowRigidBodyForce) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700493E RID: 18750
		// (get) Token: 0x06012DFD RID: 77309 RVA: 0x001BC0F1 File Offset: 0x001BA2F1
		// (set) Token: 0x06012DFE RID: 77310 RVA: 0x001BC101 File Offset: 0x001BA301
		public unsafe bool bShowRigidBodyInfos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bShowRigidBodyInfos) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bShowRigidBodyInfos) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700493F RID: 18751
		// (get) Token: 0x06012DFF RID: 77311 RVA: 0x001BC112 File Offset: 0x001BA312
		// (set) Token: 0x06012E00 RID: 77312 RVA: 0x001BC122 File Offset: 0x001BA322
		public unsafe bool bShowTransformIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bShowTransformIndex) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bShowTransformIndex) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004940 RID: 18752
		// (get) Token: 0x06012E01 RID: 77313 RVA: 0x001BC133 File Offset: 0x001BA333
		// (set) Token: 0x06012E02 RID: 77314 RVA: 0x001BC143 File Offset: 0x001BA343
		public unsafe bool bShowTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bShowTransform) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bShowTransform) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004941 RID: 18753
		// (get) Token: 0x06012E03 RID: 77315 RVA: 0x001BC154 File Offset: 0x001BA354
		// (set) Token: 0x06012E04 RID: 77316 RVA: 0x001BC164 File Offset: 0x001BA364
		public unsafe bool bShowParent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bShowParent) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bShowParent) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004942 RID: 18754
		// (get) Token: 0x06012E05 RID: 77317 RVA: 0x001BC175 File Offset: 0x001BA375
		// (set) Token: 0x06012E06 RID: 77318 RVA: 0x001BC185 File Offset: 0x001BA385
		public unsafe bool bShowLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bShowLevel) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bShowLevel) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004943 RID: 18755
		// (get) Token: 0x06012E07 RID: 77319 RVA: 0x001BC196 File Offset: 0x001BA396
		// (set) Token: 0x06012E08 RID: 77320 RVA: 0x001BC1A6 File Offset: 0x001BA3A6
		public unsafe bool bShowConnectivityEdges
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bShowConnectivityEdges) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bShowConnectivityEdges) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004944 RID: 18756
		// (get) Token: 0x06012E09 RID: 77321 RVA: 0x001BC1B7 File Offset: 0x001BA3B7
		// (set) Token: 0x06012E0A RID: 77322 RVA: 0x001BC1C7 File Offset: 0x001BA3C7
		public unsafe bool bShowGeometryIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bShowGeometryIndex) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bShowGeometryIndex) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004945 RID: 18757
		// (get) Token: 0x06012E0B RID: 77323 RVA: 0x001BC1D8 File Offset: 0x001BA3D8
		// (set) Token: 0x06012E0C RID: 77324 RVA: 0x001BC1E8 File Offset: 0x001BA3E8
		public unsafe bool bShowGeometryTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bShowGeometryTransform) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bShowGeometryTransform) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004946 RID: 18758
		// (get) Token: 0x06012E0D RID: 77325 RVA: 0x001BC1F9 File Offset: 0x001BA3F9
		// (set) Token: 0x06012E0E RID: 77326 RVA: 0x001BC209 File Offset: 0x001BA409
		public unsafe bool bShowBoundingBox
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bShowBoundingBox) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bShowBoundingBox) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004947 RID: 18759
		// (get) Token: 0x06012E0F RID: 77327 RVA: 0x001BC21A File Offset: 0x001BA41A
		// (set) Token: 0x06012E10 RID: 77328 RVA: 0x001BC22A File Offset: 0x001BA42A
		public unsafe bool bShowFaces
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bShowFaces) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bShowFaces) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004948 RID: 18760
		// (get) Token: 0x06012E11 RID: 77329 RVA: 0x001BC23B File Offset: 0x001BA43B
		// (set) Token: 0x06012E12 RID: 77330 RVA: 0x001BC24B File Offset: 0x001BA44B
		public unsafe bool bShowFaceIndices
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bShowFaceIndices) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bShowFaceIndices) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004949 RID: 18761
		// (get) Token: 0x06012E13 RID: 77331 RVA: 0x001BC25C File Offset: 0x001BA45C
		// (set) Token: 0x06012E14 RID: 77332 RVA: 0x001BC26C File Offset: 0x001BA46C
		public unsafe bool bShowFaceNormals
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bShowFaceNormals) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bShowFaceNormals) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700494A RID: 18762
		// (get) Token: 0x06012E15 RID: 77333 RVA: 0x001BC27D File Offset: 0x001BA47D
		// (set) Token: 0x06012E16 RID: 77334 RVA: 0x001BC28D File Offset: 0x001BA48D
		public unsafe bool bShowSingleFace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bShowSingleFace) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bShowSingleFace) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700494B RID: 18763
		// (get) Token: 0x06012E17 RID: 77335 RVA: 0x001BC29E File Offset: 0x001BA49E
		// (set) Token: 0x06012E18 RID: 77336 RVA: 0x001BC2AE File Offset: 0x001BA4AE
		public unsafe int SingleFaceIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_SingleFaceIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_SingleFaceIndex) = value;
			}
		}

		// Token: 0x1700494C RID: 18764
		// (get) Token: 0x06012E19 RID: 77337 RVA: 0x001BC2BF File Offset: 0x001BA4BF
		// (set) Token: 0x06012E1A RID: 77338 RVA: 0x001BC2CF File Offset: 0x001BA4CF
		public unsafe bool bShowVertices
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bShowVertices) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bShowVertices) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700494D RID: 18765
		// (get) Token: 0x06012E1B RID: 77339 RVA: 0x001BC2E0 File Offset: 0x001BA4E0
		// (set) Token: 0x06012E1C RID: 77340 RVA: 0x001BC2F0 File Offset: 0x001BA4F0
		public unsafe bool bShowVertexIndices
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bShowVertexIndices) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bShowVertexIndices) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700494E RID: 18766
		// (get) Token: 0x06012E1D RID: 77341 RVA: 0x001BC301 File Offset: 0x001BA501
		// (set) Token: 0x06012E1E RID: 77342 RVA: 0x001BC311 File Offset: 0x001BA511
		public unsafe bool bShowVertexNormals
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bShowVertexNormals) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bShowVertexNormals) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700494F RID: 18767
		// (get) Token: 0x06012E1F RID: 77343 RVA: 0x001BC322 File Offset: 0x001BA522
		// (set) Token: 0x06012E20 RID: 77344 RVA: 0x001BC332 File Offset: 0x001BA532
		public unsafe bool bUseActiveVisualization
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bUseActiveVisualization) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bUseActiveVisualization) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004950 RID: 18768
		// (get) Token: 0x06012E21 RID: 77345 RVA: 0x001BC343 File Offset: 0x001BA543
		// (set) Token: 0x06012E22 RID: 77346 RVA: 0x001BC353 File Offset: 0x001BA553
		public unsafe float PointThickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_PointThickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_PointThickness) = value;
			}
		}

		// Token: 0x17004951 RID: 18769
		// (get) Token: 0x06012E23 RID: 77347 RVA: 0x001BC364 File Offset: 0x001BA564
		// (set) Token: 0x06012E24 RID: 77348 RVA: 0x001BC374 File Offset: 0x001BA574
		public unsafe float LineThickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_LineThickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_LineThickness) = value;
			}
		}

		// Token: 0x17004952 RID: 18770
		// (get) Token: 0x06012E25 RID: 77349 RVA: 0x001BC385 File Offset: 0x001BA585
		// (set) Token: 0x06012E26 RID: 77350 RVA: 0x001BC395 File Offset: 0x001BA595
		public unsafe bool bTextShadow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bTextShadow) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_bTextShadow) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004953 RID: 18771
		// (get) Token: 0x06012E27 RID: 77351 RVA: 0x001BC3A6 File Offset: 0x001BA5A6
		// (set) Token: 0x06012E28 RID: 77352 RVA: 0x001BC3B6 File Offset: 0x001BA5B6
		public unsafe float TextScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_TextScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_TextScale) = value;
			}
		}

		// Token: 0x17004954 RID: 18772
		// (get) Token: 0x06012E29 RID: 77353 RVA: 0x001BC3C7 File Offset: 0x001BA5C7
		// (set) Token: 0x06012E2A RID: 77354 RVA: 0x001BC3D7 File Offset: 0x001BA5D7
		public unsafe float NormalScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_NormalScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_NormalScale) = value;
			}
		}

		// Token: 0x17004955 RID: 18773
		// (get) Token: 0x06012E2B RID: 77355 RVA: 0x001BC3E8 File Offset: 0x001BA5E8
		// (set) Token: 0x06012E2C RID: 77356 RVA: 0x001BC3F8 File Offset: 0x001BA5F8
		public unsafe float AxisScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_AxisScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_AxisScale) = value;
			}
		}

		// Token: 0x17004956 RID: 18774
		// (get) Token: 0x06012E2D RID: 77357 RVA: 0x001BC409 File Offset: 0x001BA609
		// (set) Token: 0x06012E2E RID: 77358 RVA: 0x001BC419 File Offset: 0x001BA619
		public unsafe float ArrowScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_ArrowScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_ArrowScale) = value;
			}
		}

		// Token: 0x17004957 RID: 18775
		// (get) Token: 0x06012E2F RID: 77359 RVA: 0x001BC42A File Offset: 0x001BA62A
		// (set) Token: 0x06012E30 RID: 77360 RVA: 0x001BC43E File Offset: 0x001BA63E
		public unsafe FColor RigidBodyIdColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_RigidBodyIdColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_RigidBodyIdColor) = value;
			}
		}

		// Token: 0x17004958 RID: 18776
		// (get) Token: 0x06012E31 RID: 77361 RVA: 0x001BC453 File Offset: 0x001BA653
		// (set) Token: 0x06012E32 RID: 77362 RVA: 0x001BC463 File Offset: 0x001BA663
		public unsafe float RigidBodyTransformScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_RigidBodyTransformScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_RigidBodyTransformScale) = value;
			}
		}

		// Token: 0x17004959 RID: 18777
		// (get) Token: 0x06012E33 RID: 77363 RVA: 0x001BC474 File Offset: 0x001BA674
		// (set) Token: 0x06012E34 RID: 77364 RVA: 0x001BC488 File Offset: 0x001BA688
		public unsafe FColor RigidBodyCollisionColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_RigidBodyCollisionColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_RigidBodyCollisionColor) = value;
			}
		}

		// Token: 0x1700495A RID: 18778
		// (get) Token: 0x06012E35 RID: 77365 RVA: 0x001BC49D File Offset: 0x001BA69D
		// (set) Token: 0x06012E36 RID: 77366 RVA: 0x001BC4B1 File Offset: 0x001BA6B1
		public unsafe FColor RigidBodyInertiaColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_RigidBodyInertiaColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_RigidBodyInertiaColor) = value;
			}
		}

		// Token: 0x1700495B RID: 18779
		// (get) Token: 0x06012E37 RID: 77367 RVA: 0x001BC4C6 File Offset: 0x001BA6C6
		// (set) Token: 0x06012E38 RID: 77368 RVA: 0x001BC4DA File Offset: 0x001BA6DA
		public unsafe FColor RigidBodyVelocityColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_RigidBodyVelocityColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_RigidBodyVelocityColor) = value;
			}
		}

		// Token: 0x1700495C RID: 18780
		// (get) Token: 0x06012E39 RID: 77369 RVA: 0x001BC4EF File Offset: 0x001BA6EF
		// (set) Token: 0x06012E3A RID: 77370 RVA: 0x001BC503 File Offset: 0x001BA703
		public unsafe FColor RigidBodyForceColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_RigidBodyForceColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_RigidBodyForceColor) = value;
			}
		}

		// Token: 0x1700495D RID: 18781
		// (get) Token: 0x06012E3B RID: 77371 RVA: 0x001BC518 File Offset: 0x001BA718
		// (set) Token: 0x06012E3C RID: 77372 RVA: 0x001BC52C File Offset: 0x001BA72C
		public unsafe FColor RigidBodyInfoColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_RigidBodyInfoColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_RigidBodyInfoColor) = value;
			}
		}

		// Token: 0x1700495E RID: 18782
		// (get) Token: 0x06012E3D RID: 77373 RVA: 0x001BC541 File Offset: 0x001BA741
		// (set) Token: 0x06012E3E RID: 77374 RVA: 0x001BC555 File Offset: 0x001BA755
		public unsafe FColor TransformIndexColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_TransformIndexColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_TransformIndexColor) = value;
			}
		}

		// Token: 0x1700495F RID: 18783
		// (get) Token: 0x06012E3F RID: 77375 RVA: 0x001BC56A File Offset: 0x001BA76A
		// (set) Token: 0x06012E40 RID: 77376 RVA: 0x001BC57A File Offset: 0x001BA77A
		public unsafe float TransformScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_TransformScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_TransformScale) = value;
			}
		}

		// Token: 0x17004960 RID: 18784
		// (get) Token: 0x06012E41 RID: 77377 RVA: 0x001BC58B File Offset: 0x001BA78B
		// (set) Token: 0x06012E42 RID: 77378 RVA: 0x001BC59F File Offset: 0x001BA79F
		public unsafe FColor LevelColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_LevelColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_LevelColor) = value;
			}
		}

		// Token: 0x17004961 RID: 18785
		// (get) Token: 0x06012E43 RID: 77379 RVA: 0x001BC5B4 File Offset: 0x001BA7B4
		// (set) Token: 0x06012E44 RID: 77380 RVA: 0x001BC5C8 File Offset: 0x001BA7C8
		public unsafe FColor ParentColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_ParentColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_ParentColor) = value;
			}
		}

		// Token: 0x17004962 RID: 18786
		// (get) Token: 0x06012E45 RID: 77381 RVA: 0x001BC5DD File Offset: 0x001BA7DD
		// (set) Token: 0x06012E46 RID: 77382 RVA: 0x001BC5ED File Offset: 0x001BA7ED
		public unsafe float ConnectivityEdgeThickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_ConnectivityEdgeThickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_ConnectivityEdgeThickness) = value;
			}
		}

		// Token: 0x17004963 RID: 18787
		// (get) Token: 0x06012E47 RID: 77383 RVA: 0x001BC5FE File Offset: 0x001BA7FE
		// (set) Token: 0x06012E48 RID: 77384 RVA: 0x001BC612 File Offset: 0x001BA812
		public unsafe FColor GeometryIndexColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_GeometryIndexColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_GeometryIndexColor) = value;
			}
		}

		// Token: 0x17004964 RID: 18788
		// (get) Token: 0x06012E49 RID: 77385 RVA: 0x001BC627 File Offset: 0x001BA827
		// (set) Token: 0x06012E4A RID: 77386 RVA: 0x001BC637 File Offset: 0x001BA837
		public unsafe float GeometryTransformScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_GeometryTransformScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_GeometryTransformScale) = value;
			}
		}

		// Token: 0x17004965 RID: 18789
		// (get) Token: 0x06012E4B RID: 77387 RVA: 0x001BC648 File Offset: 0x001BA848
		// (set) Token: 0x06012E4C RID: 77388 RVA: 0x001BC65C File Offset: 0x001BA85C
		public unsafe FColor BoundingBoxColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_BoundingBoxColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_BoundingBoxColor) = value;
			}
		}

		// Token: 0x17004966 RID: 18790
		// (get) Token: 0x06012E4D RID: 77389 RVA: 0x001BC671 File Offset: 0x001BA871
		// (set) Token: 0x06012E4E RID: 77390 RVA: 0x001BC685 File Offset: 0x001BA885
		public unsafe FColor FaceColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_FaceColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_FaceColor) = value;
			}
		}

		// Token: 0x17004967 RID: 18791
		// (get) Token: 0x06012E4F RID: 77391 RVA: 0x001BC69A File Offset: 0x001BA89A
		// (set) Token: 0x06012E50 RID: 77392 RVA: 0x001BC6AE File Offset: 0x001BA8AE
		public unsafe FColor FaceIndexColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_FaceIndexColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_FaceIndexColor) = value;
			}
		}

		// Token: 0x17004968 RID: 18792
		// (get) Token: 0x06012E51 RID: 77393 RVA: 0x001BC6C3 File Offset: 0x001BA8C3
		// (set) Token: 0x06012E52 RID: 77394 RVA: 0x001BC6D7 File Offset: 0x001BA8D7
		public unsafe FColor FaceNormalColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_FaceNormalColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_FaceNormalColor) = value;
			}
		}

		// Token: 0x17004969 RID: 18793
		// (get) Token: 0x06012E53 RID: 77395 RVA: 0x001BC6EC File Offset: 0x001BA8EC
		// (set) Token: 0x06012E54 RID: 77396 RVA: 0x001BC700 File Offset: 0x001BA900
		public unsafe FColor SingleFaceColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_SingleFaceColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_SingleFaceColor) = value;
			}
		}

		// Token: 0x1700496A RID: 18794
		// (get) Token: 0x06012E55 RID: 77397 RVA: 0x001BC715 File Offset: 0x001BA915
		// (set) Token: 0x06012E56 RID: 77398 RVA: 0x001BC729 File Offset: 0x001BA929
		public unsafe FColor VertexColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_VertexColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_VertexColor) = value;
			}
		}

		// Token: 0x1700496B RID: 18795
		// (get) Token: 0x06012E57 RID: 77399 RVA: 0x001BC73E File Offset: 0x001BA93E
		// (set) Token: 0x06012E58 RID: 77400 RVA: 0x001BC752 File Offset: 0x001BA952
		public unsafe FColor VertexIndexColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_VertexIndexColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_VertexIndexColor) = value;
			}
		}

		// Token: 0x1700496C RID: 18796
		// (get) Token: 0x06012E59 RID: 77401 RVA: 0x001BC767 File Offset: 0x001BA967
		// (set) Token: 0x06012E5A RID: 77402 RVA: 0x001BC77B File Offset: 0x001BA97B
		public unsafe FColor VertexNormalColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_VertexNormalColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGeometryCollectionDebugDrawActor.__PropertyOffset_VertexNormalColor) = value;
			}
		}

		// Token: 0x1700496D RID: 18797
		// (get) Token: 0x06012E5B RID: 77403 RVA: 0x001BC790 File Offset: 0x001BA990
		// (set) Token: 0x06012E5C RID: 77404 RVA: 0x001BC7A4 File Offset: 0x001BA9A4
		[Nullable(2)]
		public unsafe UBillboardComponent SpriteComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBillboardComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AGeometryCollectionDebugDrawActor.__PropertyOffset_SpriteComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AGeometryCollectionDebugDrawActor.__PropertyOffset_SpriteComponent, value);
			}
		}

		// Token: 0x06012E5D RID: 77405 RVA: 0x001BC7B9 File Offset: 0x001BA9B9
		static AGeometryCollectionDebugDrawActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GeometryCollectionEngine.GeometryCollectionDebugDrawActor");
		}

		// Token: 0x06012E5E RID: 77406 RVA: 0x001BC7C7 File Offset: 0x001BA9C7
		protected AGeometryCollectionDebugDrawActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A154 RID: 41300
		public new const string __ObjectPath = "/Script/GeometryCollectionEngine.GeometryCollectionDebugDrawActor";

		// Token: 0x0400A155 RID: 41301
		private static IntPtr _ClassPtr;

		// Token: 0x0400A156 RID: 41302
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A157 RID: 41303
		internal static int __PropertyOffset_WarningMessage;

		// Token: 0x0400A158 RID: 41304
		internal static int __PropertyOffset_SelectedRigidBody;

		// Token: 0x0400A159 RID: 41305
		[Nullable(2)]
		private FGeometryCollectionDebugDrawActorSelectedRigidBody _SelectedRigidBody;

		// Token: 0x0400A15A RID: 41306
		internal static int __PropertyOffset_bDebugDrawWholeCollection;

		// Token: 0x0400A15B RID: 41307
		internal static int __PropertyOffset_bDebugDrawHierarchy;

		// Token: 0x0400A15C RID: 41308
		internal static int __PropertyOffset_bDebugDrawClustering;

		// Token: 0x0400A15D RID: 41309
		internal static int __PropertyOffset_HideGeometry;

		// Token: 0x0400A15E RID: 41310
		internal static int __PropertyOffset_bShowRigidBodyId;

		// Token: 0x0400A15F RID: 41311
		internal static int __PropertyOffset_bShowRigidBodyCollision;

		// Token: 0x0400A160 RID: 41312
		internal static int __PropertyOffset_bCollisionAtOrigin;

		// Token: 0x0400A161 RID: 41313
		internal static int __PropertyOffset_bShowRigidBodyTransform;

		// Token: 0x0400A162 RID: 41314
		internal static int __PropertyOffset_bShowRigidBodyInertia;

		// Token: 0x0400A163 RID: 41315
		internal static int __PropertyOffset_bShowRigidBodyVelocity;

		// Token: 0x0400A164 RID: 41316
		internal static int __PropertyOffset_bShowRigidBodyForce;

		// Token: 0x0400A165 RID: 41317
		internal static int __PropertyOffset_bShowRigidBodyInfos;

		// Token: 0x0400A166 RID: 41318
		internal static int __PropertyOffset_bShowTransformIndex;

		// Token: 0x0400A167 RID: 41319
		internal static int __PropertyOffset_bShowTransform;

		// Token: 0x0400A168 RID: 41320
		internal static int __PropertyOffset_bShowParent;

		// Token: 0x0400A169 RID: 41321
		internal static int __PropertyOffset_bShowLevel;

		// Token: 0x0400A16A RID: 41322
		internal static int __PropertyOffset_bShowConnectivityEdges;

		// Token: 0x0400A16B RID: 41323
		internal static int __PropertyOffset_bShowGeometryIndex;

		// Token: 0x0400A16C RID: 41324
		internal static int __PropertyOffset_bShowGeometryTransform;

		// Token: 0x0400A16D RID: 41325
		internal static int __PropertyOffset_bShowBoundingBox;

		// Token: 0x0400A16E RID: 41326
		internal static int __PropertyOffset_bShowFaces;

		// Token: 0x0400A16F RID: 41327
		internal static int __PropertyOffset_bShowFaceIndices;

		// Token: 0x0400A170 RID: 41328
		internal static int __PropertyOffset_bShowFaceNormals;

		// Token: 0x0400A171 RID: 41329
		internal static int __PropertyOffset_bShowSingleFace;

		// Token: 0x0400A172 RID: 41330
		internal static int __PropertyOffset_SingleFaceIndex;

		// Token: 0x0400A173 RID: 41331
		internal static int __PropertyOffset_bShowVertices;

		// Token: 0x0400A174 RID: 41332
		internal static int __PropertyOffset_bShowVertexIndices;

		// Token: 0x0400A175 RID: 41333
		internal static int __PropertyOffset_bShowVertexNormals;

		// Token: 0x0400A176 RID: 41334
		internal static int __PropertyOffset_bUseActiveVisualization;

		// Token: 0x0400A177 RID: 41335
		internal static int __PropertyOffset_PointThickness;

		// Token: 0x0400A178 RID: 41336
		internal static int __PropertyOffset_LineThickness;

		// Token: 0x0400A179 RID: 41337
		internal static int __PropertyOffset_bTextShadow;

		// Token: 0x0400A17A RID: 41338
		internal static int __PropertyOffset_TextScale;

		// Token: 0x0400A17B RID: 41339
		internal static int __PropertyOffset_NormalScale;

		// Token: 0x0400A17C RID: 41340
		internal static int __PropertyOffset_AxisScale;

		// Token: 0x0400A17D RID: 41341
		internal static int __PropertyOffset_ArrowScale;

		// Token: 0x0400A17E RID: 41342
		internal static int __PropertyOffset_RigidBodyIdColor;

		// Token: 0x0400A17F RID: 41343
		internal static int __PropertyOffset_RigidBodyTransformScale;

		// Token: 0x0400A180 RID: 41344
		internal static int __PropertyOffset_RigidBodyCollisionColor;

		// Token: 0x0400A181 RID: 41345
		internal static int __PropertyOffset_RigidBodyInertiaColor;

		// Token: 0x0400A182 RID: 41346
		internal static int __PropertyOffset_RigidBodyVelocityColor;

		// Token: 0x0400A183 RID: 41347
		internal static int __PropertyOffset_RigidBodyForceColor;

		// Token: 0x0400A184 RID: 41348
		internal static int __PropertyOffset_RigidBodyInfoColor;

		// Token: 0x0400A185 RID: 41349
		internal static int __PropertyOffset_TransformIndexColor;

		// Token: 0x0400A186 RID: 41350
		internal static int __PropertyOffset_TransformScale;

		// Token: 0x0400A187 RID: 41351
		internal static int __PropertyOffset_LevelColor;

		// Token: 0x0400A188 RID: 41352
		internal static int __PropertyOffset_ParentColor;

		// Token: 0x0400A189 RID: 41353
		internal static int __PropertyOffset_ConnectivityEdgeThickness;

		// Token: 0x0400A18A RID: 41354
		internal static int __PropertyOffset_GeometryIndexColor;

		// Token: 0x0400A18B RID: 41355
		internal static int __PropertyOffset_GeometryTransformScale;

		// Token: 0x0400A18C RID: 41356
		internal static int __PropertyOffset_BoundingBoxColor;

		// Token: 0x0400A18D RID: 41357
		internal static int __PropertyOffset_FaceColor;

		// Token: 0x0400A18E RID: 41358
		internal static int __PropertyOffset_FaceIndexColor;

		// Token: 0x0400A18F RID: 41359
		internal static int __PropertyOffset_FaceNormalColor;

		// Token: 0x0400A190 RID: 41360
		internal static int __PropertyOffset_SingleFaceColor;

		// Token: 0x0400A191 RID: 41361
		internal static int __PropertyOffset_VertexColor;

		// Token: 0x0400A192 RID: 41362
		internal static int __PropertyOffset_VertexIndexColor;

		// Token: 0x0400A193 RID: 41363
		internal static int __PropertyOffset_VertexNormalColor;

		// Token: 0x0400A194 RID: 41364
		internal static int __PropertyOffset_SpriteComponent;
	}
}
