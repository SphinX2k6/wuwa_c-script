using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200178D RID: 6029
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComputeShader.JacobiChainPrebuiltData")]
	[UnrealStructLayout(384, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 384)]
	public class UJacobiChainPrebuiltData : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015B15 RID: 88853 RVA: 0x001FE103 File Offset: 0x001FC303
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UJacobiChainPrebuiltData._ClassPtr;
		}

		// Token: 0x06015B16 RID: 88854 RVA: 0x001FE110 File Offset: 0x001FC310
		public UJacobiChainPrebuiltData() : this(BuiltinUtils.AllocNativeUObject(UJacobiChainPrebuiltData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015B17 RID: 88855 RVA: 0x001FE138 File Offset: 0x001FC338
		public UJacobiChainPrebuiltData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UJacobiChainPrebuiltData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170055C4 RID: 21956
		// (get) Token: 0x06015B18 RID: 88856 RVA: 0x001FE16B File Offset: 0x001FC36B
		// (set) Token: 0x06015B19 RID: 88857 RVA: 0x001FE17F File Offset: 0x001FC37F
		[Nullable(2)]
		public unsafe UStaticMesh SourceMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + UJacobiChainPrebuiltData.__PropertyOffset_SourceMesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UJacobiChainPrebuiltData.__PropertyOffset_SourceMesh, value);
			}
		}

		// Token: 0x170055C5 RID: 21957
		// (get) Token: 0x06015B1A RID: 88858 RVA: 0x001FE194 File Offset: 0x001FC394
		// (set) Token: 0x06015B1B RID: 88859 RVA: 0x001FE1A8 File Offset: 0x001FC3A8
		[Nullable(2)]
		public unsafe UJacobiChainAsset SimulationProfile
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UJacobiChainAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UJacobiChainPrebuiltData.__PropertyOffset_SimulationProfile);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UJacobiChainPrebuiltData.__PropertyOffset_SimulationProfile, value);
			}
		}

		// Token: 0x170055C6 RID: 21958
		// (get) Token: 0x06015B1C RID: 88860 RVA: 0x001FE1BD File Offset: 0x001FC3BD
		// (set) Token: 0x06015B1D RID: 88861 RVA: 0x001FE1CD File Offset: 0x001FC3CD
		public unsafe float VertexMatchTolerance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainPrebuiltData.__PropertyOffset_VertexMatchTolerance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainPrebuiltData.__PropertyOffset_VertexMatchTolerance) = value;
			}
		}

		// Token: 0x170055C7 RID: 21959
		// (get) Token: 0x06015B1E RID: 88862 RVA: 0x001FE1DE File Offset: 0x001FC3DE
		// (set) Token: 0x06015B1F RID: 88863 RVA: 0x001FE1EE File Offset: 0x001FC3EE
		public unsafe int DataVersion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainPrebuiltData.__PropertyOffset_DataVersion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainPrebuiltData.__PropertyOffset_DataVersion) = value;
			}
		}

		// Token: 0x170055C8 RID: 21960
		// (get) Token: 0x06015B20 RID: 88864 RVA: 0x001FE1FF File Offset: 0x001FC3FF
		// (set) Token: 0x06015B21 RID: 88865 RVA: 0x001FE20F File Offset: 0x001FC40F
		public unsafe int VertexCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainPrebuiltData.__PropertyOffset_VertexCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainPrebuiltData.__PropertyOffset_VertexCount) = value;
			}
		}

		// Token: 0x170055C9 RID: 21961
		// (get) Token: 0x06015B22 RID: 88866 RVA: 0x001FE220 File Offset: 0x001FC420
		// (set) Token: 0x06015B23 RID: 88867 RVA: 0x001FE230 File Offset: 0x001FC430
		public unsafe int ParticleCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainPrebuiltData.__PropertyOffset_ParticleCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainPrebuiltData.__PropertyOffset_ParticleCount) = value;
			}
		}

		// Token: 0x170055CA RID: 21962
		// (get) Token: 0x06015B24 RID: 88868 RVA: 0x001FE241 File Offset: 0x001FC441
		// (set) Token: 0x06015B25 RID: 88869 RVA: 0x001FE251 File Offset: 0x001FC451
		public unsafe int IndexCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainPrebuiltData.__PropertyOffset_IndexCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainPrebuiltData.__PropertyOffset_IndexCount) = value;
			}
		}

		// Token: 0x170055CB RID: 21963
		// (get) Token: 0x06015B26 RID: 88870 RVA: 0x001FE262 File Offset: 0x001FC462
		// (set) Token: 0x06015B27 RID: 88871 RVA: 0x001FE272 File Offset: 0x001FC472
		public unsafe int SectionCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainPrebuiltData.__PropertyOffset_SectionCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainPrebuiltData.__PropertyOffset_SectionCount) = value;
			}
		}

		// Token: 0x170055CC RID: 21964
		// (get) Token: 0x06015B28 RID: 88872 RVA: 0x001FE283 File Offset: 0x001FC483
		// (set) Token: 0x06015B29 RID: 88873 RVA: 0x001FE293 File Offset: 0x001FC493
		public unsafe int ConstraintCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainPrebuiltData.__PropertyOffset_ConstraintCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainPrebuiltData.__PropertyOffset_ConstraintCount) = value;
			}
		}

		// Token: 0x170055CD RID: 21965
		// (get) Token: 0x06015B2A RID: 88874 RVA: 0x001FE2A4 File Offset: 0x001FC4A4
		// (set) Token: 0x06015B2B RID: 88875 RVA: 0x001FE2B4 File Offset: 0x001FC4B4
		public unsafe long PayloadByteCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainPrebuiltData.__PropertyOffset_PayloadByteCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainPrebuiltData.__PropertyOffset_PayloadByteCount) = value;
			}
		}

		// Token: 0x170055CE RID: 21966
		// (get) Token: 0x06015B2C RID: 88876 RVA: 0x001FE2C5 File Offset: 0x001FC4C5
		// (set) Token: 0x06015B2D RID: 88877 RVA: 0x001FE2D5 File Offset: 0x001FC4D5
		public unsafe int NumTexCoords
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainPrebuiltData.__PropertyOffset_NumTexCoords);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainPrebuiltData.__PropertyOffset_NumTexCoords) = value;
			}
		}

		// Token: 0x170055CF RID: 21967
		// (get) Token: 0x06015B2E RID: 88878 RVA: 0x001FE2E8 File Offset: 0x001FC4E8
		// (set) Token: 0x06015B2F RID: 88879 RVA: 0x001FE321 File Offset: 0x001FC521
		public TArray<FJacobiChainRenderVertex> Vertices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FJacobiChainRenderVertex> result;
				if ((result = this._Vertices) == null)
				{
					result = (this._Vertices = new TArray<FJacobiChainRenderVertex>(base.NativePtr + (IntPtr)UJacobiChainPrebuiltData.__PropertyOffset_Vertices, this));
				}
				return result;
			}
			set
			{
				this.Vertices.CopyAssign(value);
			}
		}

		// Token: 0x170055D0 RID: 21968
		// (get) Token: 0x06015B30 RID: 88880 RVA: 0x001FE330 File Offset: 0x001FC530
		// (set) Token: 0x06015B31 RID: 88881 RVA: 0x001FE369 File Offset: 0x001FC569
		public TArray<uint> Indices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<uint> result;
				if ((result = this._Indices) == null)
				{
					result = (this._Indices = new TArray<uint>(base.NativePtr + (IntPtr)UJacobiChainPrebuiltData.__PropertyOffset_Indices, this));
				}
				return result;
			}
			set
			{
				this.Indices.CopyAssign(value);
			}
		}

		// Token: 0x170055D1 RID: 21969
		// (get) Token: 0x06015B32 RID: 88882 RVA: 0x001FE378 File Offset: 0x001FC578
		// (set) Token: 0x06015B33 RID: 88883 RVA: 0x001FE3B1 File Offset: 0x001FC5B1
		public TArray<FJacobiChainRenderSection> Sections
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FJacobiChainRenderSection> result;
				if ((result = this._Sections) == null)
				{
					result = (this._Sections = new TArray<FJacobiChainRenderSection>(base.NativePtr + (IntPtr)UJacobiChainPrebuiltData.__PropertyOffset_Sections, this));
				}
				return result;
			}
			set
			{
				this.Sections.CopyAssign(value);
			}
		}

		// Token: 0x170055D2 RID: 21970
		// (get) Token: 0x06015B34 RID: 88884 RVA: 0x001FE3C0 File Offset: 0x001FC5C0
		// (set) Token: 0x06015B35 RID: 88885 RVA: 0x001FE3F9 File Offset: 0x001FC5F9
		public TArray<FJacobiChainParticleGpu> Particles
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FJacobiChainParticleGpu> result;
				if ((result = this._Particles) == null)
				{
					result = (this._Particles = new TArray<FJacobiChainParticleGpu>(base.NativePtr + (IntPtr)UJacobiChainPrebuiltData.__PropertyOffset_Particles, this));
				}
				return result;
			}
			set
			{
				this.Particles.CopyAssign(value);
			}
		}

		// Token: 0x170055D3 RID: 21971
		// (get) Token: 0x06015B36 RID: 88886 RVA: 0x001FE408 File Offset: 0x001FC608
		// (set) Token: 0x06015B37 RID: 88887 RVA: 0x001FE441 File Offset: 0x001FC641
		public TArray<FJacobiChainConstraintGpu> Constraints
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FJacobiChainConstraintGpu> result;
				if ((result = this._Constraints) == null)
				{
					result = (this._Constraints = new TArray<FJacobiChainConstraintGpu>(base.NativePtr + (IntPtr)UJacobiChainPrebuiltData.__PropertyOffset_Constraints, this));
				}
				return result;
			}
			set
			{
				this.Constraints.CopyAssign(value);
			}
		}

		// Token: 0x170055D4 RID: 21972
		// (get) Token: 0x06015B38 RID: 88888 RVA: 0x001FE450 File Offset: 0x001FC650
		// (set) Token: 0x06015B39 RID: 88889 RVA: 0x001FE489 File Offset: 0x001FC689
		public TArray<FJacobiChainAttachmentGpu> Attachments
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FJacobiChainAttachmentGpu> result;
				if ((result = this._Attachments) == null)
				{
					result = (this._Attachments = new TArray<FJacobiChainAttachmentGpu>(base.NativePtr + (IntPtr)UJacobiChainPrebuiltData.__PropertyOffset_Attachments, this));
				}
				return result;
			}
			set
			{
				this.Attachments.CopyAssign(value);
			}
		}

		// Token: 0x170055D5 RID: 21973
		// (get) Token: 0x06015B3A RID: 88890 RVA: 0x001FE498 File Offset: 0x001FC698
		// (set) Token: 0x06015B3B RID: 88891 RVA: 0x001FE4D1 File Offset: 0x001FC6D1
		public TArray<FJacobiChainRigidBodyGpu> RigidBodies
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FJacobiChainRigidBodyGpu> result;
				if ((result = this._RigidBodies) == null)
				{
					result = (this._RigidBodies = new TArray<FJacobiChainRigidBodyGpu>(base.NativePtr + (IntPtr)UJacobiChainPrebuiltData.__PropertyOffset_RigidBodies, this));
				}
				return result;
			}
			set
			{
				this.RigidBodies.CopyAssign(value);
			}
		}

		// Token: 0x170055D6 RID: 21974
		// (get) Token: 0x06015B3C RID: 88892 RVA: 0x001FE4E0 File Offset: 0x001FC6E0
		// (set) Token: 0x06015B3D RID: 88893 RVA: 0x001FE519 File Offset: 0x001FC719
		public TArray<FJacobiChainStaticColliderGpu> StaticColliders
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FJacobiChainStaticColliderGpu> result;
				if ((result = this._StaticColliders) == null)
				{
					result = (this._StaticColliders = new TArray<FJacobiChainStaticColliderGpu>(base.NativePtr + (IntPtr)UJacobiChainPrebuiltData.__PropertyOffset_StaticColliders, this));
				}
				return result;
			}
			set
			{
				this.StaticColliders.CopyAssign(value);
			}
		}

		// Token: 0x170055D7 RID: 21975
		// (get) Token: 0x06015B3E RID: 88894 RVA: 0x001FE528 File Offset: 0x001FC728
		// (set) Token: 0x06015B3F RID: 88895 RVA: 0x001FE561 File Offset: 0x001FC761
		public TArray<FJacobiChainVertexBindingGpu> Bindings
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FJacobiChainVertexBindingGpu> result;
				if ((result = this._Bindings) == null)
				{
					result = (this._Bindings = new TArray<FJacobiChainVertexBindingGpu>(base.NativePtr + (IntPtr)UJacobiChainPrebuiltData.__PropertyOffset_Bindings, this));
				}
				return result;
			}
			set
			{
				this.Bindings.CopyAssign(value);
			}
		}

		// Token: 0x170055D8 RID: 21976
		// (get) Token: 0x06015B40 RID: 88896 RVA: 0x001FE570 File Offset: 0x001FC770
		// (set) Token: 0x06015B41 RID: 88897 RVA: 0x001FE5A9 File Offset: 0x001FC7A9
		public TArray<FVector4> OfflineWindParticleOffsets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector4> result;
				if ((result = this._OfflineWindParticleOffsets) == null)
				{
					result = (this._OfflineWindParticleOffsets = new TArray<FVector4>(base.NativePtr + (IntPtr)UJacobiChainPrebuiltData.__PropertyOffset_OfflineWindParticleOffsets, this));
				}
				return result;
			}
			set
			{
				this.OfflineWindParticleOffsets.CopyAssign(value);
			}
		}

		// Token: 0x170055D9 RID: 21977
		// (get) Token: 0x06015B42 RID: 88898 RVA: 0x001FE5B8 File Offset: 0x001FC7B8
		// (set) Token: 0x06015B43 RID: 88899 RVA: 0x001FE5F1 File Offset: 0x001FC7F1
		public TArray<FVector4> OfflineWindRigidRotations
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector4> result;
				if ((result = this._OfflineWindRigidRotations) == null)
				{
					result = (this._OfflineWindRigidRotations = new TArray<FVector4>(base.NativePtr + (IntPtr)UJacobiChainPrebuiltData.__PropertyOffset_OfflineWindRigidRotations, this));
				}
				return result;
			}
			set
			{
				this.OfflineWindRigidRotations.CopyAssign(value);
			}
		}

		// Token: 0x170055DA RID: 21978
		// (get) Token: 0x06015B44 RID: 88900 RVA: 0x001FE600 File Offset: 0x001FC800
		// (set) Token: 0x06015B45 RID: 88901 RVA: 0x001FE639 File Offset: 0x001FC839
		public TArray<FVector> RestPositions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._RestPositions) == null)
				{
					result = (this._RestPositions = new TArray<FVector>(base.NativePtr + (IntPtr)UJacobiChainPrebuiltData.__PropertyOffset_RestPositions, this));
				}
				return result;
			}
			set
			{
				this.RestPositions.CopyAssign(value);
			}
		}

		// Token: 0x170055DB RID: 21979
		// (get) Token: 0x06015B46 RID: 88902 RVA: 0x001FE648 File Offset: 0x001FC848
		// (set) Token: 0x06015B47 RID: 88903 RVA: 0x001FE681 File Offset: 0x001FC881
		public TArray<FVector4> RestTangents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector4> result;
				if ((result = this._RestTangents) == null)
				{
					result = (this._RestTangents = new TArray<FVector4>(base.NativePtr + (IntPtr)UJacobiChainPrebuiltData.__PropertyOffset_RestTangents, this));
				}
				return result;
			}
			set
			{
				this.RestTangents.CopyAssign(value);
			}
		}

		// Token: 0x170055DC RID: 21980
		// (get) Token: 0x06015B48 RID: 88904 RVA: 0x001FE68F File Offset: 0x001FC88F
		// (set) Token: 0x06015B49 RID: 88905 RVA: 0x001FE6A3 File Offset: 0x001FC8A3
		public unsafe FBoxSphereBounds LocalBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainPrebuiltData.__PropertyOffset_LocalBounds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainPrebuiltData.__PropertyOffset_LocalBounds) = value;
			}
		}

		// Token: 0x170055DD RID: 21981
		// (get) Token: 0x06015B4A RID: 88906 RVA: 0x001FE6B8 File Offset: 0x001FC8B8
		// (set) Token: 0x06015B4B RID: 88907 RVA: 0x001FE6C8 File Offset: 0x001FC8C8
		public unsafe int MatchedVertexCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainPrebuiltData.__PropertyOffset_MatchedVertexCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainPrebuiltData.__PropertyOffset_MatchedVertexCount) = value;
			}
		}

		// Token: 0x170055DE RID: 21982
		// (get) Token: 0x06015B4C RID: 88908 RVA: 0x001FE6D9 File Offset: 0x001FC8D9
		// (set) Token: 0x06015B4D RID: 88909 RVA: 0x001FE6E9 File Offset: 0x001FC8E9
		public unsafe float ProfileToMeshScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainPrebuiltData.__PropertyOffset_ProfileToMeshScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainPrebuiltData.__PropertyOffset_ProfileToMeshScale) = value;
			}
		}

		// Token: 0x170055DF RID: 21983
		// (get) Token: 0x06015B4E RID: 88910 RVA: 0x001FE6FA File Offset: 0x001FC8FA
		// (set) Token: 0x06015B4F RID: 88911 RVA: 0x001FE70A File Offset: 0x001FC90A
		public unsafe int AxisTransformMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainPrebuiltData.__PropertyOffset_AxisTransformMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainPrebuiltData.__PropertyOffset_AxisTransformMode) = value;
			}
		}

		// Token: 0x170055E0 RID: 21984
		// (get) Token: 0x06015B50 RID: 88912 RVA: 0x001FE71B File Offset: 0x001FC91B
		// (set) Token: 0x06015B51 RID: 88913 RVA: 0x001FE72B File Offset: 0x001FC92B
		public unsafe int OfflineWindFrameCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJacobiChainPrebuiltData.__PropertyOffset_OfflineWindFrameCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJacobiChainPrebuiltData.__PropertyOffset_OfflineWindFrameCount) = value;
			}
		}

		// Token: 0x170055E1 RID: 21985
		// (get) Token: 0x06015B52 RID: 88914 RVA: 0x001FE73C File Offset: 0x001FC93C
		// (set) Token: 0x06015B53 RID: 88915 RVA: 0x001FE775 File Offset: 0x001FC975
		public TArray<byte> PackedData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._PackedData) == null)
				{
					result = (this._PackedData = new TArray<byte>(base.NativePtr + (IntPtr)UJacobiChainPrebuiltData.__PropertyOffset_PackedData, this));
				}
				return result;
			}
			set
			{
				this.PackedData.CopyAssign(value);
			}
		}

		// Token: 0x06015B54 RID: 88916 RVA: 0x001FE783 File Offset: 0x001FC983
		static UJacobiChainPrebuiltData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComputeShader.JacobiChainPrebuiltData");
		}

		// Token: 0x06015B55 RID: 88917 RVA: 0x001FE791 File Offset: 0x001FC991
		protected UJacobiChainPrebuiltData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BD76 RID: 48502
		public new const string __ObjectPath = "/Script/KuroComputeShader.JacobiChainPrebuiltData";

		// Token: 0x0400BD77 RID: 48503
		private static IntPtr _ClassPtr;

		// Token: 0x0400BD78 RID: 48504
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400BD79 RID: 48505
		internal static int __PropertyOffset_SourceMesh;

		// Token: 0x0400BD7A RID: 48506
		internal static int __PropertyOffset_SimulationProfile;

		// Token: 0x0400BD7B RID: 48507
		internal static int __PropertyOffset_VertexMatchTolerance;

		// Token: 0x0400BD7C RID: 48508
		internal static int __PropertyOffset_DataVersion;

		// Token: 0x0400BD7D RID: 48509
		internal static int __PropertyOffset_VertexCount;

		// Token: 0x0400BD7E RID: 48510
		internal static int __PropertyOffset_ParticleCount;

		// Token: 0x0400BD7F RID: 48511
		internal static int __PropertyOffset_IndexCount;

		// Token: 0x0400BD80 RID: 48512
		internal static int __PropertyOffset_SectionCount;

		// Token: 0x0400BD81 RID: 48513
		internal static int __PropertyOffset_ConstraintCount;

		// Token: 0x0400BD82 RID: 48514
		internal static int __PropertyOffset_PayloadByteCount;

		// Token: 0x0400BD83 RID: 48515
		internal static int __PropertyOffset_NumTexCoords;

		// Token: 0x0400BD84 RID: 48516
		internal static int __PropertyOffset_Vertices;

		// Token: 0x0400BD85 RID: 48517
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FJacobiChainRenderVertex> _Vertices;

		// Token: 0x0400BD86 RID: 48518
		internal static int __PropertyOffset_Indices;

		// Token: 0x0400BD87 RID: 48519
		[Nullable(2)]
		private TArray<uint> _Indices;

		// Token: 0x0400BD88 RID: 48520
		internal static int __PropertyOffset_Sections;

		// Token: 0x0400BD89 RID: 48521
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FJacobiChainRenderSection> _Sections;

		// Token: 0x0400BD8A RID: 48522
		internal static int __PropertyOffset_Particles;

		// Token: 0x0400BD8B RID: 48523
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FJacobiChainParticleGpu> _Particles;

		// Token: 0x0400BD8C RID: 48524
		internal static int __PropertyOffset_Constraints;

		// Token: 0x0400BD8D RID: 48525
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FJacobiChainConstraintGpu> _Constraints;

		// Token: 0x0400BD8E RID: 48526
		internal static int __PropertyOffset_Attachments;

		// Token: 0x0400BD8F RID: 48527
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FJacobiChainAttachmentGpu> _Attachments;

		// Token: 0x0400BD90 RID: 48528
		internal static int __PropertyOffset_RigidBodies;

		// Token: 0x0400BD91 RID: 48529
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FJacobiChainRigidBodyGpu> _RigidBodies;

		// Token: 0x0400BD92 RID: 48530
		internal static int __PropertyOffset_StaticColliders;

		// Token: 0x0400BD93 RID: 48531
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FJacobiChainStaticColliderGpu> _StaticColliders;

		// Token: 0x0400BD94 RID: 48532
		internal static int __PropertyOffset_Bindings;

		// Token: 0x0400BD95 RID: 48533
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FJacobiChainVertexBindingGpu> _Bindings;

		// Token: 0x0400BD96 RID: 48534
		internal static int __PropertyOffset_OfflineWindParticleOffsets;

		// Token: 0x0400BD97 RID: 48535
		[Nullable(2)]
		private TArray<FVector4> _OfflineWindParticleOffsets;

		// Token: 0x0400BD98 RID: 48536
		internal static int __PropertyOffset_OfflineWindRigidRotations;

		// Token: 0x0400BD99 RID: 48537
		[Nullable(2)]
		private TArray<FVector4> _OfflineWindRigidRotations;

		// Token: 0x0400BD9A RID: 48538
		internal static int __PropertyOffset_RestPositions;

		// Token: 0x0400BD9B RID: 48539
		[Nullable(2)]
		private TArray<FVector> _RestPositions;

		// Token: 0x0400BD9C RID: 48540
		internal static int __PropertyOffset_RestTangents;

		// Token: 0x0400BD9D RID: 48541
		[Nullable(2)]
		private TArray<FVector4> _RestTangents;

		// Token: 0x0400BD9E RID: 48542
		internal static int __PropertyOffset_LocalBounds;

		// Token: 0x0400BD9F RID: 48543
		internal static int __PropertyOffset_MatchedVertexCount;

		// Token: 0x0400BDA0 RID: 48544
		internal static int __PropertyOffset_ProfileToMeshScale;

		// Token: 0x0400BDA1 RID: 48545
		internal static int __PropertyOffset_AxisTransformMode;

		// Token: 0x0400BDA2 RID: 48546
		internal static int __PropertyOffset_OfflineWindFrameCount;

		// Token: 0x0400BDA3 RID: 48547
		internal static int __PropertyOffset_PackedData;

		// Token: 0x0400BDA4 RID: 48548
		[Nullable(2)]
		private TArray<byte> _PackedData;
	}
}
