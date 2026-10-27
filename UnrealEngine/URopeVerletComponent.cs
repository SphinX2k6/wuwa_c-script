using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C7B RID: 7291
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRopeEffect.RopeVerletComponent")]
	[UnrealStructLayout(2064, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2064)]
	public class URopeVerletComponent : USplineComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C4A0 RID: 115872 RVA: 0x0029B503 File Offset: 0x00299703
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URopeVerletComponent._ClassPtr;
		}

		// Token: 0x0601C4A1 RID: 115873 RVA: 0x0029B510 File Offset: 0x00299710
		public URopeVerletComponent() : this(BuiltinUtils.AllocNativeUObject(URopeVerletComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C4A2 RID: 115874 RVA: 0x0029B538 File Offset: 0x00299738
		public URopeVerletComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URopeVerletComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007259 RID: 29273
		// (get) Token: 0x0601C4A3 RID: 115875 RVA: 0x0029B56B File Offset: 0x0029976B
		// (set) Token: 0x0601C4A4 RID: 115876 RVA: 0x0029B57B File Offset: 0x0029977B
		public unsafe int SegmentCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_SegmentCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_SegmentCount) = value;
			}
		}

		// Token: 0x1700725A RID: 29274
		// (get) Token: 0x0601C4A5 RID: 115877 RVA: 0x0029B58C File Offset: 0x0029978C
		// (set) Token: 0x0601C4A6 RID: 115878 RVA: 0x0029B5A0 File Offset: 0x002997A0
		public unsafe FVector Gravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_Gravity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_Gravity) = value;
			}
		}

		// Token: 0x1700725B RID: 29275
		// (get) Token: 0x0601C4A7 RID: 115879 RVA: 0x0029B5B5 File Offset: 0x002997B5
		// (set) Token: 0x0601C4A8 RID: 115880 RVA: 0x0029B5C5 File Offset: 0x002997C5
		public unsafe float Damping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_Damping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_Damping) = value;
			}
		}

		// Token: 0x1700725C RID: 29276
		// (get) Token: 0x0601C4A9 RID: 115881 RVA: 0x0029B5D6 File Offset: 0x002997D6
		// (set) Token: 0x0601C4AA RID: 115882 RVA: 0x0029B5E6 File Offset: 0x002997E6
		public unsafe int ConstraintIterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_ConstraintIterations);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_ConstraintIterations) = value;
			}
		}

		// Token: 0x1700725D RID: 29277
		// (get) Token: 0x0601C4AB RID: 115883 RVA: 0x0029B5F7 File Offset: 0x002997F7
		// (set) Token: 0x0601C4AC RID: 115884 RVA: 0x0029B607 File Offset: 0x00299807
		public unsafe float Stiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_Stiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_Stiffness) = value;
			}
		}

		// Token: 0x1700725E RID: 29278
		// (get) Token: 0x0601C4AD RID: 115885 RVA: 0x0029B618 File Offset: 0x00299818
		// (set) Token: 0x0601C4AE RID: 115886 RVA: 0x0029B628 File Offset: 0x00299828
		public unsafe bool bPinStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_bPinStart) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_bPinStart) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700725F RID: 29279
		// (get) Token: 0x0601C4AF RID: 115887 RVA: 0x0029B639 File Offset: 0x00299839
		// (set) Token: 0x0601C4B0 RID: 115888 RVA: 0x0029B649 File Offset: 0x00299849
		public unsafe bool bPinEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_bPinEnd) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_bPinEnd) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007260 RID: 29280
		// (get) Token: 0x0601C4B1 RID: 115889 RVA: 0x0029B65A File Offset: 0x0029985A
		// (set) Token: 0x0601C4B2 RID: 115890 RVA: 0x0029B66A File Offset: 0x0029986A
		public unsafe bool bEnablePhysics
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_bEnablePhysics) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_bEnablePhysics) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007261 RID: 29281
		// (get) Token: 0x0601C4B3 RID: 115891 RVA: 0x0029B67B File Offset: 0x0029987B
		// (set) Token: 0x0601C4B4 RID: 115892 RVA: 0x0029B68B File Offset: 0x0029988B
		public unsafe float MaxTimeStep
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_MaxTimeStep);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_MaxTimeStep) = value;
			}
		}

		// Token: 0x17007262 RID: 29282
		// (get) Token: 0x0601C4B5 RID: 115893 RVA: 0x0029B69C File Offset: 0x0029989C
		// (set) Token: 0x0601C4B6 RID: 115894 RVA: 0x0029B6AC File Offset: 0x002998AC
		public unsafe float VelocityAmplification
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_VelocityAmplification);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_VelocityAmplification) = value;
			}
		}

		// Token: 0x17007263 RID: 29283
		// (get) Token: 0x0601C4B7 RID: 115895 RVA: 0x0029B6BD File Offset: 0x002998BD
		// (set) Token: 0x0601C4B8 RID: 115896 RVA: 0x0029B6CD File Offset: 0x002998CD
		public unsafe float QuickStabilizeThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_QuickStabilizeThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_QuickStabilizeThreshold) = value;
			}
		}

		// Token: 0x17007264 RID: 29284
		// (get) Token: 0x0601C4B9 RID: 115897 RVA: 0x0029B6DE File Offset: 0x002998DE
		// (set) Token: 0x0601C4BA RID: 115898 RVA: 0x0029B6EE File Offset: 0x002998EE
		public unsafe float QuickStabilizeDampingMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_QuickStabilizeDampingMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_QuickStabilizeDampingMultiplier) = value;
			}
		}

		// Token: 0x17007265 RID: 29285
		// (get) Token: 0x0601C4BB RID: 115899 RVA: 0x0029B6FF File Offset: 0x002998FF
		// (set) Token: 0x0601C4BC RID: 115900 RVA: 0x0029B70F File Offset: 0x0029990F
		public unsafe float TensionPropagation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_TensionPropagation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_TensionPropagation) = value;
			}
		}

		// Token: 0x17007266 RID: 29286
		// (get) Token: 0x0601C4BD RID: 115901 RVA: 0x0029B720 File Offset: 0x00299920
		// (set) Token: 0x0601C4BE RID: 115902 RVA: 0x0029B730 File Offset: 0x00299930
		public unsafe float TensionStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_TensionStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_TensionStrength) = value;
			}
		}

		// Token: 0x17007267 RID: 29287
		// (get) Token: 0x0601C4BF RID: 115903 RVA: 0x0029B741 File Offset: 0x00299941
		// (set) Token: 0x0601C4C0 RID: 115904 RVA: 0x0029B751 File Offset: 0x00299951
		public unsafe bool bRenderChainLinks
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_bRenderChainLinks) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_bRenderChainLinks) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007268 RID: 29288
		// (get) Token: 0x0601C4C1 RID: 115905 RVA: 0x0029B762 File Offset: 0x00299962
		// (set) Token: 0x0601C4C2 RID: 115906 RVA: 0x0029B776 File Offset: 0x00299976
		[Nullable(2)]
		public unsafe UStaticMesh ChainLinkMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + URopeVerletComponent.__PropertyOffset_ChainLinkMesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + URopeVerletComponent.__PropertyOffset_ChainLinkMesh, value);
			}
		}

		// Token: 0x17007269 RID: 29289
		// (get) Token: 0x0601C4C3 RID: 115907 RVA: 0x0029B78B File Offset: 0x0029998B
		// (set) Token: 0x0601C4C4 RID: 115908 RVA: 0x0029B79B File Offset: 0x0029999B
		public unsafe float ChainLinkSpacing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_ChainLinkSpacing);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_ChainLinkSpacing) = value;
			}
		}

		// Token: 0x1700726A RID: 29290
		// (get) Token: 0x0601C4C5 RID: 115909 RVA: 0x0029B7AC File Offset: 0x002999AC
		// (set) Token: 0x0601C4C6 RID: 115910 RVA: 0x0029B7C0 File Offset: 0x002999C0
		public unsafe FVector ChainLinkScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_ChainLinkScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_ChainLinkScale) = value;
			}
		}

		// Token: 0x1700726B RID: 29291
		// (get) Token: 0x0601C4C7 RID: 115911 RVA: 0x0029B7D5 File Offset: 0x002999D5
		// (set) Token: 0x0601C4C8 RID: 115912 RVA: 0x0029B7E9 File Offset: 0x002999E9
		public unsafe FRotator ChainLinkRotationOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_ChainLinkRotationOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_ChainLinkRotationOffset) = value;
			}
		}

		// Token: 0x1700726C RID: 29292
		// (get) Token: 0x0601C4C9 RID: 115913 RVA: 0x0029B7FE File Offset: 0x002999FE
		// (set) Token: 0x0601C4CA RID: 115914 RVA: 0x0029B812 File Offset: 0x00299A12
		public unsafe FVector ChainLinkPositionOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_ChainLinkPositionOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_ChainLinkPositionOffset) = value;
			}
		}

		// Token: 0x1700726D RID: 29293
		// (get) Token: 0x0601C4CB RID: 115915 RVA: 0x0029B827 File Offset: 0x00299A27
		// (set) Token: 0x0601C4CC RID: 115916 RVA: 0x0029B837 File Offset: 0x00299A37
		public unsafe bool bAlternateLinkRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_bAlternateLinkRotation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_bAlternateLinkRotation) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700726E RID: 29294
		// (get) Token: 0x0601C4CD RID: 115917 RVA: 0x0029B848 File Offset: 0x00299A48
		// (set) Token: 0x0601C4CE RID: 115918 RVA: 0x0029B858 File Offset: 0x00299A58
		public unsafe float AlternateLinkRollDegrees
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_AlternateLinkRollDegrees);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_AlternateLinkRollDegrees) = value;
			}
		}

		// Token: 0x1700726F RID: 29295
		// (get) Token: 0x0601C4CF RID: 115919 RVA: 0x0029B86C File Offset: 0x00299A6C
		// (set) Token: 0x0601C4D0 RID: 115920 RVA: 0x0029B8A5 File Offset: 0x00299AA5
		public TArray<FVerletParticle> Particles
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVerletParticle> result;
				if ((result = this._Particles) == null)
				{
					result = (this._Particles = new TArray<FVerletParticle>(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_Particles, this));
				}
				return result;
			}
			set
			{
				this.Particles.CopyAssign(value);
			}
		}

		// Token: 0x17007270 RID: 29296
		// (get) Token: 0x0601C4D1 RID: 115921 RVA: 0x0029B8B4 File Offset: 0x00299AB4
		// (set) Token: 0x0601C4D2 RID: 115922 RVA: 0x0029B8ED File Offset: 0x00299AED
		public TArray<float> RestLengths
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._RestLengths) == null)
				{
					result = (this._RestLengths = new TArray<float>(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_RestLengths, this));
				}
				return result;
			}
			set
			{
				this.RestLengths.CopyAssign(value);
			}
		}

		// Token: 0x17007271 RID: 29297
		// (get) Token: 0x0601C4D3 RID: 115923 RVA: 0x0029B8FB File Offset: 0x00299AFB
		// (set) Token: 0x0601C4D4 RID: 115924 RVA: 0x0029B90F File Offset: 0x00299B0F
		public unsafe FVector ControlledStartPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_ControlledStartPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_ControlledStartPosition) = value;
			}
		}

		// Token: 0x17007272 RID: 29298
		// (get) Token: 0x0601C4D5 RID: 115925 RVA: 0x0029B924 File Offset: 0x00299B24
		// (set) Token: 0x0601C4D6 RID: 115926 RVA: 0x0029B938 File Offset: 0x00299B38
		public unsafe FVector ControlledEndPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_ControlledEndPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URopeVerletComponent.__PropertyOffset_ControlledEndPosition) = value;
			}
		}

		// Token: 0x17007273 RID: 29299
		// (get) Token: 0x0601C4D7 RID: 115927 RVA: 0x0029B94D File Offset: 0x00299B4D
		// (set) Token: 0x0601C4D8 RID: 115928 RVA: 0x0029B961 File Offset: 0x00299B61
		[Nullable(2)]
		public unsafe UInstancedStaticMeshComponent ChainInstanceComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UInstancedStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + URopeVerletComponent.__PropertyOffset_ChainInstanceComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + URopeVerletComponent.__PropertyOffset_ChainInstanceComponent, value);
			}
		}

		// Token: 0x0601C4D9 RID: 115929 RVA: 0x0029B976 File Offset: 0x00299B76
		public void SimulatePhysics(float DeltaTime)
		{
			URopeVerletComponent.__SimulatePhysics_Internal(base.NativePtr, DeltaTime);
		}

		// Token: 0x0601C4DA RID: 115930 RVA: 0x0029B984 File Offset: 0x00299B84
		public void SetStartPosition(in FVector WorldPosition)
		{
			URopeVerletComponent.__SetStartPosition_Internal(base.NativePtr, WorldPosition);
		}

		// Token: 0x0601C4DB RID: 115931 RVA: 0x0029B992 File Offset: 0x00299B92
		public void SetParticlePosition(int ParticleIndex, in FVector WorldPosition)
		{
			URopeVerletComponent.__SetParticlePosition_Internal(base.NativePtr, ParticleIndex, WorldPosition);
		}

		// Token: 0x0601C4DC RID: 115932 RVA: 0x0029B9A1 File Offset: 0x00299BA1
		public void SetEndPosition(in FVector WorldPosition)
		{
			URopeVerletComponent.__SetEndPosition_Internal(base.NativePtr, WorldPosition);
		}

		// Token: 0x0601C4DD RID: 115933 RVA: 0x0029B9AF File Offset: 0x00299BAF
		public void ResetRope()
		{
			URopeVerletComponent.__ResetRope_Internal(base.NativePtr);
		}

		// Token: 0x0601C4DE RID: 115934 RVA: 0x0029B9BC File Offset: 0x00299BBC
		public void RefreshChainInstances()
		{
			URopeVerletComponent.__RefreshChainInstances_Internal(base.NativePtr);
		}

		// Token: 0x0601C4DF RID: 115935 RVA: 0x0029B9C9 File Offset: 0x00299BC9
		public void PinParticle(int ParticleIndex, bool bPin = true)
		{
			URopeVerletComponent.__PinParticle_Internal(base.NativePtr, ParticleIndex, bPin);
		}

		// Token: 0x0601C4E0 RID: 115936 RVA: 0x0029B9D8 File Offset: 0x00299BD8
		public void InitializeVerlet()
		{
			URopeVerletComponent.__InitializeVerlet_Internal(base.NativePtr);
		}

		// Token: 0x0601C4E1 RID: 115937 RVA: 0x0029B9E5 File Offset: 0x00299BE5
		public FVector GetStartPosition()
		{
			return URopeVerletComponent.__GetStartPosition_Internal(base.NativePtr);
		}

		// Token: 0x0601C4E2 RID: 115938 RVA: 0x0029B9F2 File Offset: 0x00299BF2
		public int GetParticleCount()
		{
			return URopeVerletComponent.__GetParticleCount_Internal(base.NativePtr);
		}

		// Token: 0x0601C4E3 RID: 115939 RVA: 0x0029B9FF File Offset: 0x00299BFF
		public FVector GetEndPosition()
		{
			return URopeVerletComponent.__GetEndPosition_Internal(base.NativePtr);
		}

		// Token: 0x0601C4E4 RID: 115940 RVA: 0x0029BA0C File Offset: 0x00299C0C
		[NullableContext(2)]
		public void ApplyDataAsset(URopeVerletDataAsset DataAsset)
		{
			URopeVerletComponent.__ApplyDataAsset_Internal(base.NativePtr, (DataAsset != null) ? DataAsset.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601C4E5 RID: 115941
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SimulatePhysics_Internal(IntPtr @this, float DeltaTime);

		// Token: 0x0601C4E6 RID: 115942
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStartPosition_Internal(IntPtr @this, in FVector WorldPosition);

		// Token: 0x0601C4E7 RID: 115943
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetParticlePosition_Internal(IntPtr @this, int ParticleIndex, in FVector WorldPosition);

		// Token: 0x0601C4E8 RID: 115944
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEndPosition_Internal(IntPtr @this, in FVector WorldPosition);

		// Token: 0x0601C4E9 RID: 115945
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetRope_Internal(IntPtr @this);

		// Token: 0x0601C4EA RID: 115946
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RefreshChainInstances_Internal(IntPtr @this);

		// Token: 0x0601C4EB RID: 115947
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PinParticle_Internal(IntPtr @this, int ParticleIndex, bool bPin);

		// Token: 0x0601C4EC RID: 115948
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitializeVerlet_Internal(IntPtr @this);

		// Token: 0x0601C4ED RID: 115949
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetStartPosition_Internal(IntPtr @this);

		// Token: 0x0601C4EE RID: 115950
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetParticleCount_Internal(IntPtr @this);

		// Token: 0x0601C4EF RID: 115951
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetEndPosition_Internal(IntPtr @this);

		// Token: 0x0601C4F0 RID: 115952
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyDataAsset_Internal(IntPtr @this, IntPtr DataAsset);

		// Token: 0x0601C4F1 RID: 115953 RVA: 0x0029BA29 File Offset: 0x00299C29
		static URopeVerletComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRopeEffect.RopeVerletComponent");
		}

		// Token: 0x0601C4F2 RID: 115954 RVA: 0x0029BA37 File Offset: 0x00299C37
		protected URopeVerletComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F364 RID: 62308
		public new const string __ObjectPath = "/Script/KuroRopeEffect.RopeVerletComponent";

		// Token: 0x0400F365 RID: 62309
		private static IntPtr _ClassPtr;

		// Token: 0x0400F366 RID: 62310
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F367 RID: 62311
		internal static int __PropertyOffset_SegmentCount;

		// Token: 0x0400F368 RID: 62312
		internal static int __PropertyOffset_Gravity;

		// Token: 0x0400F369 RID: 62313
		internal static int __PropertyOffset_Damping;

		// Token: 0x0400F36A RID: 62314
		internal static int __PropertyOffset_ConstraintIterations;

		// Token: 0x0400F36B RID: 62315
		internal static int __PropertyOffset_Stiffness;

		// Token: 0x0400F36C RID: 62316
		internal static int __PropertyOffset_bPinStart;

		// Token: 0x0400F36D RID: 62317
		internal static int __PropertyOffset_bPinEnd;

		// Token: 0x0400F36E RID: 62318
		internal static int __PropertyOffset_bEnablePhysics;

		// Token: 0x0400F36F RID: 62319
		internal static int __PropertyOffset_MaxTimeStep;

		// Token: 0x0400F370 RID: 62320
		internal static int __PropertyOffset_VelocityAmplification;

		// Token: 0x0400F371 RID: 62321
		internal static int __PropertyOffset_QuickStabilizeThreshold;

		// Token: 0x0400F372 RID: 62322
		internal static int __PropertyOffset_QuickStabilizeDampingMultiplier;

		// Token: 0x0400F373 RID: 62323
		internal static int __PropertyOffset_TensionPropagation;

		// Token: 0x0400F374 RID: 62324
		internal static int __PropertyOffset_TensionStrength;

		// Token: 0x0400F375 RID: 62325
		internal static int __PropertyOffset_bRenderChainLinks;

		// Token: 0x0400F376 RID: 62326
		internal static int __PropertyOffset_ChainLinkMesh;

		// Token: 0x0400F377 RID: 62327
		internal static int __PropertyOffset_ChainLinkSpacing;

		// Token: 0x0400F378 RID: 62328
		internal static int __PropertyOffset_ChainLinkScale;

		// Token: 0x0400F379 RID: 62329
		internal static int __PropertyOffset_ChainLinkRotationOffset;

		// Token: 0x0400F37A RID: 62330
		internal static int __PropertyOffset_ChainLinkPositionOffset;

		// Token: 0x0400F37B RID: 62331
		internal static int __PropertyOffset_bAlternateLinkRotation;

		// Token: 0x0400F37C RID: 62332
		internal static int __PropertyOffset_AlternateLinkRollDegrees;

		// Token: 0x0400F37D RID: 62333
		internal static int __PropertyOffset_Particles;

		// Token: 0x0400F37E RID: 62334
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FVerletParticle> _Particles;

		// Token: 0x0400F37F RID: 62335
		internal static int __PropertyOffset_RestLengths;

		// Token: 0x0400F380 RID: 62336
		[Nullable(2)]
		private TArray<float> _RestLengths;

		// Token: 0x0400F381 RID: 62337
		internal static int __PropertyOffset_ControlledStartPosition;

		// Token: 0x0400F382 RID: 62338
		internal static int __PropertyOffset_ControlledEndPosition;

		// Token: 0x0400F383 RID: 62339
		internal static int __PropertyOffset_ChainInstanceComponent;
	}
}
