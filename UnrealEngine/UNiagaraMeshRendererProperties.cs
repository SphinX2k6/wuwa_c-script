using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020025BB RID: 9659
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraMeshRendererProperties")]
	[UnrealStructLayout(4376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 4376)]
	public class UNiagaraMeshRendererProperties : UNiagaraRendererProperties, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023E4F RID: 147023 RVA: 0x0035134E File Offset: 0x0034F54E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraMeshRendererProperties._ClassPtr;
		}

		// Token: 0x06023E50 RID: 147024 RVA: 0x0035135C File Offset: 0x0034F55C
		public UNiagaraMeshRendererProperties() : this(BuiltinUtils.AllocNativeUObject(UNiagaraMeshRendererProperties.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023E51 RID: 147025 RVA: 0x00351384 File Offset: 0x0034F584
		public UNiagaraMeshRendererProperties(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraMeshRendererProperties.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008A02 RID: 35330
		// (get) Token: 0x06023E52 RID: 147026 RVA: 0x003513B7 File Offset: 0x0034F5B7
		// (set) Token: 0x06023E53 RID: 147027 RVA: 0x003513CB File Offset: 0x0034F5CB
		[Nullable(2)]
		public unsafe UStaticMesh ParticleMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraMeshRendererProperties.__PropertyOffset_ParticleMesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraMeshRendererProperties.__PropertyOffset_ParticleMesh, value);
			}
		}

		// Token: 0x17008A03 RID: 35331
		// (get) Token: 0x06023E54 RID: 147028 RVA: 0x003513E0 File Offset: 0x0034F5E0
		// (set) Token: 0x06023E55 RID: 147029 RVA: 0x003513F0 File Offset: 0x0034F5F0
		public unsafe ENiagaraMeshLODMode LODMode
		{
			get
			{
				return (ENiagaraMeshLODMode)(*(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_LODMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_LODMode) = (byte)value;
			}
		}

		// Token: 0x17008A04 RID: 35332
		// (get) Token: 0x06023E56 RID: 147030 RVA: 0x00351401 File Offset: 0x0034F601
		// (set) Token: 0x06023E57 RID: 147031 RVA: 0x00351411 File Offset: 0x0034F611
		public unsafe int LODLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_LODLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_LODLevel) = value;
			}
		}

		// Token: 0x17008A05 RID: 35333
		// (get) Token: 0x06023E58 RID: 147032 RVA: 0x00351422 File Offset: 0x0034F622
		// (set) Token: 0x06023E59 RID: 147033 RVA: 0x00351432 File Offset: 0x0034F632
		public unsafe float LODDistanceScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_LODDistanceScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_LODDistanceScale) = value;
			}
		}

		// Token: 0x17008A06 RID: 35334
		// (get) Token: 0x06023E5A RID: 147034 RVA: 0x00351443 File Offset: 0x0034F643
		// (set) Token: 0x06023E5B RID: 147035 RVA: 0x00351453 File Offset: 0x0034F653
		public unsafe ENiagaraRendererSourceDataMode SourceMode
		{
			get
			{
				return (ENiagaraRendererSourceDataMode)(*(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_SourceMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_SourceMode) = (byte)value;
			}
		}

		// Token: 0x17008A07 RID: 35335
		// (get) Token: 0x06023E5C RID: 147036 RVA: 0x00351464 File Offset: 0x0034F664
		// (set) Token: 0x06023E5D RID: 147037 RVA: 0x00351474 File Offset: 0x0034F674
		public unsafe ENiagaraSortMode SortMode
		{
			get
			{
				return (ENiagaraSortMode)(*(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_SortMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_SortMode) = (byte)value;
			}
		}

		// Token: 0x17008A08 RID: 35336
		// (get) Token: 0x06023E5E RID: 147038 RVA: 0x00351485 File Offset: 0x0034F685
		// (set) Token: 0x06023E5F RID: 147039 RVA: 0x0035149E File Offset: 0x0034F69E
		public unsafe bool bOverrideMaterials
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_bOverrideMaterials) & UNiagaraMeshRendererProperties.__PropertyMask_bOverrideMaterials) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_bOverrideMaterials) = ((*(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_bOverrideMaterials) & ~UNiagaraMeshRendererProperties.__PropertyMask_bOverrideMaterials) | (value ? UNiagaraMeshRendererProperties.__PropertyMask_bOverrideMaterials : 0));
			}
		}

		// Token: 0x17008A09 RID: 35337
		// (get) Token: 0x06023E60 RID: 147040 RVA: 0x003514CE File Offset: 0x0034F6CE
		// (set) Token: 0x06023E61 RID: 147041 RVA: 0x003514E7 File Offset: 0x0034F6E7
		public unsafe bool bSortOnlyWhenTranslucent
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_bSortOnlyWhenTranslucent) & UNiagaraMeshRendererProperties.__PropertyMask_bSortOnlyWhenTranslucent) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_bSortOnlyWhenTranslucent) = ((*(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_bSortOnlyWhenTranslucent) & ~UNiagaraMeshRendererProperties.__PropertyMask_bSortOnlyWhenTranslucent) | (value ? UNiagaraMeshRendererProperties.__PropertyMask_bSortOnlyWhenTranslucent : 0));
			}
		}

		// Token: 0x17008A0A RID: 35338
		// (get) Token: 0x06023E62 RID: 147042 RVA: 0x00351518 File Offset: 0x0034F718
		// (set) Token: 0x06023E63 RID: 147043 RVA: 0x00351551 File Offset: 0x0034F751
		public TArray<FNiagaraMeshMaterialOverride> OverrideMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNiagaraMeshMaterialOverride> result;
				if ((result = this._OverrideMaterials) == null)
				{
					result = (this._OverrideMaterials = new TArray<FNiagaraMeshMaterialOverride>(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_OverrideMaterials, this));
				}
				return result;
			}
			set
			{
				this.OverrideMaterials.CopyAssign(value);
			}
		}

		// Token: 0x17008A0B RID: 35339
		// (get) Token: 0x06023E64 RID: 147044 RVA: 0x0035155F File Offset: 0x0034F75F
		// (set) Token: 0x06023E65 RID: 147045 RVA: 0x00351573 File Offset: 0x0034F773
		public unsafe FVector2D SubImageSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_SubImageSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_SubImageSize) = value;
			}
		}

		// Token: 0x17008A0C RID: 35340
		// (get) Token: 0x06023E66 RID: 147046 RVA: 0x00351588 File Offset: 0x0034F788
		// (set) Token: 0x06023E67 RID: 147047 RVA: 0x003515A1 File Offset: 0x0034F7A1
		public unsafe bool bSubImageBlend
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_bSubImageBlend) & UNiagaraMeshRendererProperties.__PropertyMask_bSubImageBlend) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_bSubImageBlend) = ((*(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_bSubImageBlend) & ~UNiagaraMeshRendererProperties.__PropertyMask_bSubImageBlend) | (value ? UNiagaraMeshRendererProperties.__PropertyMask_bSubImageBlend : 0));
			}
		}

		// Token: 0x17008A0D RID: 35341
		// (get) Token: 0x06023E68 RID: 147048 RVA: 0x003515D1 File Offset: 0x0034F7D1
		// (set) Token: 0x06023E69 RID: 147049 RVA: 0x003515E1 File Offset: 0x0034F7E1
		public unsafe ENiagaraMeshFacingMode FacingMode
		{
			get
			{
				return (ENiagaraMeshFacingMode)(*(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_FacingMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_FacingMode) = (byte)value;
			}
		}

		// Token: 0x17008A0E RID: 35342
		// (get) Token: 0x06023E6A RID: 147050 RVA: 0x003515F2 File Offset: 0x0034F7F2
		// (set) Token: 0x06023E6B RID: 147051 RVA: 0x0035160B File Offset: 0x0034F80B
		public unsafe bool bLockedAxisEnable
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_bLockedAxisEnable) & UNiagaraMeshRendererProperties.__PropertyMask_bLockedAxisEnable) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_bLockedAxisEnable) = ((*(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_bLockedAxisEnable) & ~UNiagaraMeshRendererProperties.__PropertyMask_bLockedAxisEnable) | (value ? UNiagaraMeshRendererProperties.__PropertyMask_bLockedAxisEnable : 0));
			}
		}

		// Token: 0x17008A0F RID: 35343
		// (get) Token: 0x06023E6C RID: 147052 RVA: 0x0035163B File Offset: 0x0034F83B
		// (set) Token: 0x06023E6D RID: 147053 RVA: 0x0035164F File Offset: 0x0034F84F
		public unsafe FVector LockedAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_LockedAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_LockedAxis) = value;
			}
		}

		// Token: 0x17008A10 RID: 35344
		// (get) Token: 0x06023E6E RID: 147054 RVA: 0x00351664 File Offset: 0x0034F864
		// (set) Token: 0x06023E6F RID: 147055 RVA: 0x00351674 File Offset: 0x0034F874
		public unsafe ENiagaraMeshLockedAxisSpace LockedAxisSpace
		{
			get
			{
				return (ENiagaraMeshLockedAxisSpace)(*(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_LockedAxisSpace));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_LockedAxisSpace) = (byte)value;
			}
		}

		// Token: 0x17008A11 RID: 35345
		// (get) Token: 0x06023E70 RID: 147056 RVA: 0x00351685 File Offset: 0x0034F885
		// (set) Token: 0x06023E71 RID: 147057 RVA: 0x00351699 File Offset: 0x0034F899
		public unsafe FVector PivotOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_PivotOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_PivotOffset) = value;
			}
		}

		// Token: 0x17008A12 RID: 35346
		// (get) Token: 0x06023E72 RID: 147058 RVA: 0x003516AE File Offset: 0x0034F8AE
		// (set) Token: 0x06023E73 RID: 147059 RVA: 0x003516BE File Offset: 0x0034F8BE
		public unsafe ENiagaraMeshPivotOffsetSpace PivotOffsetSpace
		{
			get
			{
				return (ENiagaraMeshPivotOffsetSpace)(*(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_PivotOffsetSpace));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_PivotOffsetSpace) = (byte)value;
			}
		}

		// Token: 0x17008A13 RID: 35347
		// (get) Token: 0x06023E74 RID: 147060 RVA: 0x003516CF File Offset: 0x0034F8CF
		// (set) Token: 0x06023E75 RID: 147061 RVA: 0x003516E8 File Offset: 0x0034F8E8
		public unsafe bool bEnableFrustumCulling
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_bEnableFrustumCulling) & UNiagaraMeshRendererProperties.__PropertyMask_bEnableFrustumCulling) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_bEnableFrustumCulling) = ((*(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_bEnableFrustumCulling) & ~UNiagaraMeshRendererProperties.__PropertyMask_bEnableFrustumCulling) | (value ? UNiagaraMeshRendererProperties.__PropertyMask_bEnableFrustumCulling : 0));
			}
		}

		// Token: 0x17008A14 RID: 35348
		// (get) Token: 0x06023E76 RID: 147062 RVA: 0x00351718 File Offset: 0x0034F918
		// (set) Token: 0x06023E77 RID: 147063 RVA: 0x00351731 File Offset: 0x0034F931
		public unsafe bool bEnableCameraDistanceCulling
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_bEnableCameraDistanceCulling) & UNiagaraMeshRendererProperties.__PropertyMask_bEnableCameraDistanceCulling) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_bEnableCameraDistanceCulling) = ((*(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_bEnableCameraDistanceCulling) & ~UNiagaraMeshRendererProperties.__PropertyMask_bEnableCameraDistanceCulling) | (value ? UNiagaraMeshRendererProperties.__PropertyMask_bEnableCameraDistanceCulling : 0));
			}
		}

		// Token: 0x17008A15 RID: 35349
		// (get) Token: 0x06023E78 RID: 147064 RVA: 0x00351761 File Offset: 0x0034F961
		// (set) Token: 0x06023E79 RID: 147065 RVA: 0x00351771 File Offset: 0x0034F971
		public unsafe float MinCameraDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_MinCameraDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_MinCameraDistance) = value;
			}
		}

		// Token: 0x17008A16 RID: 35350
		// (get) Token: 0x06023E7A RID: 147066 RVA: 0x00351782 File Offset: 0x0034F982
		// (set) Token: 0x06023E7B RID: 147067 RVA: 0x00351792 File Offset: 0x0034F992
		public unsafe float MaxCameraDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_MaxCameraDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_MaxCameraDistance) = value;
			}
		}

		// Token: 0x17008A17 RID: 35351
		// (get) Token: 0x06023E7C RID: 147068 RVA: 0x003517A3 File Offset: 0x0034F9A3
		// (set) Token: 0x06023E7D RID: 147069 RVA: 0x003517B3 File Offset: 0x0034F9B3
		public unsafe uint RendererVisibility
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_RendererVisibility);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_RendererVisibility) = (int)value;
			}
		}

		// Token: 0x17008A18 RID: 35352
		// (get) Token: 0x06023E7E RID: 147070 RVA: 0x003517C4 File Offset: 0x0034F9C4
		// (set) Token: 0x06023E7F RID: 147071 RVA: 0x003517FD File Offset: 0x0034F9FD
		public FNiagaraVariableAttributeBinding PositionBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._PositionBinding) == null)
				{
					result = (this._PositionBinding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_PositionBinding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_PositionBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008A19 RID: 35353
		// (get) Token: 0x06023E80 RID: 147072 RVA: 0x00351820 File Offset: 0x0034FA20
		// (set) Token: 0x06023E81 RID: 147073 RVA: 0x00351859 File Offset: 0x0034FA59
		public FNiagaraVariableAttributeBinding ColorBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._ColorBinding) == null)
				{
					result = (this._ColorBinding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_ColorBinding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_ColorBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008A1A RID: 35354
		// (get) Token: 0x06023E82 RID: 147074 RVA: 0x0035187C File Offset: 0x0034FA7C
		// (set) Token: 0x06023E83 RID: 147075 RVA: 0x003518B5 File Offset: 0x0034FAB5
		public FNiagaraVariableAttributeBinding VelocityBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._VelocityBinding) == null)
				{
					result = (this._VelocityBinding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_VelocityBinding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_VelocityBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008A1B RID: 35355
		// (get) Token: 0x06023E84 RID: 147076 RVA: 0x003518D8 File Offset: 0x0034FAD8
		// (set) Token: 0x06023E85 RID: 147077 RVA: 0x00351911 File Offset: 0x0034FB11
		public FNiagaraVariableAttributeBinding MeshOrientationBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._MeshOrientationBinding) == null)
				{
					result = (this._MeshOrientationBinding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_MeshOrientationBinding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_MeshOrientationBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008A1C RID: 35356
		// (get) Token: 0x06023E86 RID: 147078 RVA: 0x00351934 File Offset: 0x0034FB34
		// (set) Token: 0x06023E87 RID: 147079 RVA: 0x0035196D File Offset: 0x0034FB6D
		public FNiagaraVariableAttributeBinding ScaleBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._ScaleBinding) == null)
				{
					result = (this._ScaleBinding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_ScaleBinding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_ScaleBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008A1D RID: 35357
		// (get) Token: 0x06023E88 RID: 147080 RVA: 0x00351990 File Offset: 0x0034FB90
		// (set) Token: 0x06023E89 RID: 147081 RVA: 0x003519C9 File Offset: 0x0034FBC9
		public FNiagaraVariableAttributeBinding SubImageIndexBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._SubImageIndexBinding) == null)
				{
					result = (this._SubImageIndexBinding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_SubImageIndexBinding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_SubImageIndexBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008A1E RID: 35358
		// (get) Token: 0x06023E8A RID: 147082 RVA: 0x003519EC File Offset: 0x0034FBEC
		// (set) Token: 0x06023E8B RID: 147083 RVA: 0x00351A25 File Offset: 0x0034FC25
		public FNiagaraVariableAttributeBinding DynamicMaterialBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._DynamicMaterialBinding) == null)
				{
					result = (this._DynamicMaterialBinding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_DynamicMaterialBinding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_DynamicMaterialBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008A1F RID: 35359
		// (get) Token: 0x06023E8C RID: 147084 RVA: 0x00351A48 File Offset: 0x0034FC48
		// (set) Token: 0x06023E8D RID: 147085 RVA: 0x00351A81 File Offset: 0x0034FC81
		public FNiagaraVariableAttributeBinding DynamicMaterial1Binding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._DynamicMaterial1Binding) == null)
				{
					result = (this._DynamicMaterial1Binding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_DynamicMaterial1Binding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_DynamicMaterial1Binding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008A20 RID: 35360
		// (get) Token: 0x06023E8E RID: 147086 RVA: 0x00351AA4 File Offset: 0x0034FCA4
		// (set) Token: 0x06023E8F RID: 147087 RVA: 0x00351ADD File Offset: 0x0034FCDD
		public FNiagaraVariableAttributeBinding DynamicMaterial2Binding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._DynamicMaterial2Binding) == null)
				{
					result = (this._DynamicMaterial2Binding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_DynamicMaterial2Binding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_DynamicMaterial2Binding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008A21 RID: 35361
		// (get) Token: 0x06023E90 RID: 147088 RVA: 0x00351B00 File Offset: 0x0034FD00
		// (set) Token: 0x06023E91 RID: 147089 RVA: 0x00351B39 File Offset: 0x0034FD39
		public FNiagaraVariableAttributeBinding DynamicMaterial3Binding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._DynamicMaterial3Binding) == null)
				{
					result = (this._DynamicMaterial3Binding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_DynamicMaterial3Binding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_DynamicMaterial3Binding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008A22 RID: 35362
		// (get) Token: 0x06023E92 RID: 147090 RVA: 0x00351B5C File Offset: 0x0034FD5C
		// (set) Token: 0x06023E93 RID: 147091 RVA: 0x00351B95 File Offset: 0x0034FD95
		public FNiagaraVariableAttributeBinding MaterialRandomBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._MaterialRandomBinding) == null)
				{
					result = (this._MaterialRandomBinding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_MaterialRandomBinding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_MaterialRandomBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008A23 RID: 35363
		// (get) Token: 0x06023E94 RID: 147092 RVA: 0x00351BB8 File Offset: 0x0034FDB8
		// (set) Token: 0x06023E95 RID: 147093 RVA: 0x00351BF1 File Offset: 0x0034FDF1
		public FNiagaraVariableAttributeBinding CustomSortingBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._CustomSortingBinding) == null)
				{
					result = (this._CustomSortingBinding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_CustomSortingBinding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_CustomSortingBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008A24 RID: 35364
		// (get) Token: 0x06023E96 RID: 147094 RVA: 0x00351C14 File Offset: 0x0034FE14
		// (set) Token: 0x06023E97 RID: 147095 RVA: 0x00351C4D File Offset: 0x0034FE4D
		public FNiagaraVariableAttributeBinding NormalizedAgeBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._NormalizedAgeBinding) == null)
				{
					result = (this._NormalizedAgeBinding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_NormalizedAgeBinding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_NormalizedAgeBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008A25 RID: 35365
		// (get) Token: 0x06023E98 RID: 147096 RVA: 0x00351C70 File Offset: 0x0034FE70
		// (set) Token: 0x06023E99 RID: 147097 RVA: 0x00351CA9 File Offset: 0x0034FEA9
		public FNiagaraVariableAttributeBinding CameraOffsetBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._CameraOffsetBinding) == null)
				{
					result = (this._CameraOffsetBinding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_CameraOffsetBinding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_CameraOffsetBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008A26 RID: 35366
		// (get) Token: 0x06023E9A RID: 147098 RVA: 0x00351CCC File Offset: 0x0034FECC
		// (set) Token: 0x06023E9B RID: 147099 RVA: 0x00351D05 File Offset: 0x0034FF05
		public FNiagaraVariableAttributeBinding RendererVisibilityTagBinding
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableAttributeBinding result;
				if ((result = this._RendererVisibilityTagBinding) == null)
				{
					result = (this._RendererVisibilityTagBinding = new FNiagaraVariableAttributeBinding(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_RendererVisibilityTagBinding, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableAttributeBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_RendererVisibilityTagBinding, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008A27 RID: 35367
		// (get) Token: 0x06023E9C RID: 147100 RVA: 0x00351D28 File Offset: 0x0034FF28
		// (set) Token: 0x06023E9D RID: 147101 RVA: 0x00351D61 File Offset: 0x0034FF61
		public TArray<FNiagaraMaterialAttributeBinding> MaterialParameterBindings
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNiagaraMaterialAttributeBinding> result;
				if ((result = this._MaterialParameterBindings) == null)
				{
					result = (this._MaterialParameterBindings = new TArray<FNiagaraMaterialAttributeBinding>(base.NativePtr + (IntPtr)UNiagaraMeshRendererProperties.__PropertyOffset_MaterialParameterBindings, this));
				}
				return result;
			}
			set
			{
				this.MaterialParameterBindings.CopyAssign(value);
			}
		}

		// Token: 0x06023E9E RID: 147102 RVA: 0x00351D6F File Offset: 0x0034FF6F
		static UNiagaraMeshRendererProperties()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraMeshRendererProperties");
		}

		// Token: 0x06023E9F RID: 147103 RVA: 0x00351D7D File Offset: 0x0034FF7D
		protected UNiagaraMeshRendererProperties(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040133E9 RID: 78825
		public new const string __ObjectPath = "/Script/Niagara.NiagaraMeshRendererProperties";

		// Token: 0x040133EA RID: 78826
		private static IntPtr _ClassPtr;

		// Token: 0x040133EB RID: 78827
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040133EC RID: 78828
		internal static int __PropertyOffset_ParticleMesh;

		// Token: 0x040133ED RID: 78829
		internal static int __PropertyOffset_LODMode;

		// Token: 0x040133EE RID: 78830
		internal static int __PropertyOffset_LODLevel;

		// Token: 0x040133EF RID: 78831
		internal static int __PropertyOffset_LODDistanceScale;

		// Token: 0x040133F0 RID: 78832
		internal static int __PropertyOffset_SourceMode;

		// Token: 0x040133F1 RID: 78833
		internal static int __PropertyOffset_SortMode;

		// Token: 0x040133F2 RID: 78834
		internal static int __PropertyOffset_bOverrideMaterials;

		// Token: 0x040133F3 RID: 78835
		internal static byte __PropertyMask_bOverrideMaterials;

		// Token: 0x040133F4 RID: 78836
		internal static int __PropertyOffset_bSortOnlyWhenTranslucent;

		// Token: 0x040133F5 RID: 78837
		internal static byte __PropertyMask_bSortOnlyWhenTranslucent;

		// Token: 0x040133F6 RID: 78838
		internal static int __PropertyOffset_OverrideMaterials;

		// Token: 0x040133F7 RID: 78839
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNiagaraMeshMaterialOverride> _OverrideMaterials;

		// Token: 0x040133F8 RID: 78840
		internal static int __PropertyOffset_SubImageSize;

		// Token: 0x040133F9 RID: 78841
		internal static int __PropertyOffset_bSubImageBlend;

		// Token: 0x040133FA RID: 78842
		internal static byte __PropertyMask_bSubImageBlend;

		// Token: 0x040133FB RID: 78843
		internal static int __PropertyOffset_FacingMode;

		// Token: 0x040133FC RID: 78844
		internal static int __PropertyOffset_bLockedAxisEnable;

		// Token: 0x040133FD RID: 78845
		internal static byte __PropertyMask_bLockedAxisEnable;

		// Token: 0x040133FE RID: 78846
		internal static int __PropertyOffset_LockedAxis;

		// Token: 0x040133FF RID: 78847
		internal static int __PropertyOffset_LockedAxisSpace;

		// Token: 0x04013400 RID: 78848
		internal static int __PropertyOffset_PivotOffset;

		// Token: 0x04013401 RID: 78849
		internal static int __PropertyOffset_PivotOffsetSpace;

		// Token: 0x04013402 RID: 78850
		internal static int __PropertyOffset_bEnableFrustumCulling;

		// Token: 0x04013403 RID: 78851
		internal static byte __PropertyMask_bEnableFrustumCulling;

		// Token: 0x04013404 RID: 78852
		internal static int __PropertyOffset_bEnableCameraDistanceCulling;

		// Token: 0x04013405 RID: 78853
		internal static byte __PropertyMask_bEnableCameraDistanceCulling;

		// Token: 0x04013406 RID: 78854
		internal static int __PropertyOffset_MinCameraDistance;

		// Token: 0x04013407 RID: 78855
		internal static int __PropertyOffset_MaxCameraDistance;

		// Token: 0x04013408 RID: 78856
		internal static int __PropertyOffset_RendererVisibility;

		// Token: 0x04013409 RID: 78857
		internal static int __PropertyOffset_PositionBinding;

		// Token: 0x0401340A RID: 78858
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _PositionBinding;

		// Token: 0x0401340B RID: 78859
		internal static int __PropertyOffset_ColorBinding;

		// Token: 0x0401340C RID: 78860
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _ColorBinding;

		// Token: 0x0401340D RID: 78861
		internal static int __PropertyOffset_VelocityBinding;

		// Token: 0x0401340E RID: 78862
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _VelocityBinding;

		// Token: 0x0401340F RID: 78863
		internal static int __PropertyOffset_MeshOrientationBinding;

		// Token: 0x04013410 RID: 78864
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _MeshOrientationBinding;

		// Token: 0x04013411 RID: 78865
		internal static int __PropertyOffset_ScaleBinding;

		// Token: 0x04013412 RID: 78866
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _ScaleBinding;

		// Token: 0x04013413 RID: 78867
		internal static int __PropertyOffset_SubImageIndexBinding;

		// Token: 0x04013414 RID: 78868
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _SubImageIndexBinding;

		// Token: 0x04013415 RID: 78869
		internal static int __PropertyOffset_DynamicMaterialBinding;

		// Token: 0x04013416 RID: 78870
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _DynamicMaterialBinding;

		// Token: 0x04013417 RID: 78871
		internal static int __PropertyOffset_DynamicMaterial1Binding;

		// Token: 0x04013418 RID: 78872
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _DynamicMaterial1Binding;

		// Token: 0x04013419 RID: 78873
		internal static int __PropertyOffset_DynamicMaterial2Binding;

		// Token: 0x0401341A RID: 78874
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _DynamicMaterial2Binding;

		// Token: 0x0401341B RID: 78875
		internal static int __PropertyOffset_DynamicMaterial3Binding;

		// Token: 0x0401341C RID: 78876
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _DynamicMaterial3Binding;

		// Token: 0x0401341D RID: 78877
		internal static int __PropertyOffset_MaterialRandomBinding;

		// Token: 0x0401341E RID: 78878
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _MaterialRandomBinding;

		// Token: 0x0401341F RID: 78879
		internal static int __PropertyOffset_CustomSortingBinding;

		// Token: 0x04013420 RID: 78880
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _CustomSortingBinding;

		// Token: 0x04013421 RID: 78881
		internal static int __PropertyOffset_NormalizedAgeBinding;

		// Token: 0x04013422 RID: 78882
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _NormalizedAgeBinding;

		// Token: 0x04013423 RID: 78883
		internal static int __PropertyOffset_CameraOffsetBinding;

		// Token: 0x04013424 RID: 78884
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _CameraOffsetBinding;

		// Token: 0x04013425 RID: 78885
		internal static int __PropertyOffset_RendererVisibilityTagBinding;

		// Token: 0x04013426 RID: 78886
		[Nullable(2)]
		private FNiagaraVariableAttributeBinding _RendererVisibilityTagBinding;

		// Token: 0x04013427 RID: 78887
		internal static int __PropertyOffset_MaterialParameterBindings;

		// Token: 0x04013428 RID: 78888
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNiagaraMaterialAttributeBinding> _MaterialParameterBindings;
	}
}
