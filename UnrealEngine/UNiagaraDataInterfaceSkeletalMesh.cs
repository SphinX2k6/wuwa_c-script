using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002586 RID: 9606
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraDataInterfaceSkeletalMesh")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 312)]
	public class UNiagaraDataInterfaceSkeletalMesh : UNiagaraDataInterface, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023A5D RID: 146013 RVA: 0x0034B3E2 File Offset: 0x003495E2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceSkeletalMesh._ClassPtr;
		}

		// Token: 0x06023A5E RID: 146014 RVA: 0x0034B3F0 File Offset: 0x003495F0
		public UNiagaraDataInterfaceSkeletalMesh() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceSkeletalMesh.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023A5F RID: 146015 RVA: 0x0034B418 File Offset: 0x00349618
		public UNiagaraDataInterfaceSkeletalMesh(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceSkeletalMesh.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170088D1 RID: 35025
		// (get) Token: 0x06023A60 RID: 146016 RVA: 0x0034B44B File Offset: 0x0034964B
		// (set) Token: 0x06023A61 RID: 146017 RVA: 0x0034B45B File Offset: 0x0034965B
		public unsafe ENDISkeletalMesh_SourceMode SourceMode
		{
			get
			{
				return (ENDISkeletalMesh_SourceMode)(*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceSkeletalMesh.__PropertyOffset_SourceMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceSkeletalMesh.__PropertyOffset_SourceMode) = (byte)value;
			}
		}

		// Token: 0x170088D2 RID: 35026
		// (get) Token: 0x06023A62 RID: 146018 RVA: 0x0034B46C File Offset: 0x0034966C
		// (set) Token: 0x06023A63 RID: 146019 RVA: 0x0034B480 File Offset: 0x00349680
		[Nullable(2)]
		public unsafe AActor Source
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataInterfaceSkeletalMesh.__PropertyOffset_Source);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataInterfaceSkeletalMesh.__PropertyOffset_Source, value);
			}
		}

		// Token: 0x170088D3 RID: 35027
		// (get) Token: 0x06023A64 RID: 146020 RVA: 0x0034B498 File Offset: 0x00349698
		// (set) Token: 0x06023A65 RID: 146021 RVA: 0x0034B4D1 File Offset: 0x003496D1
		public FNiagaraUserParameterBinding MeshUserParameter
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraUserParameterBinding result;
				if ((result = this._MeshUserParameter) == null)
				{
					result = (this._MeshUserParameter = new FNiagaraUserParameterBinding(base.NativePtr + (IntPtr)UNiagaraDataInterfaceSkeletalMesh.__PropertyOffset_MeshUserParameter, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraUserParameterBinding.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraDataInterfaceSkeletalMesh.__PropertyOffset_MeshUserParameter, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170088D4 RID: 35028
		// (get) Token: 0x06023A66 RID: 146022 RVA: 0x0034B4F2 File Offset: 0x003496F2
		// (set) Token: 0x06023A67 RID: 146023 RVA: 0x0034B506 File Offset: 0x00349706
		[Nullable(2)]
		public unsafe USkeletalMeshComponent SourceComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataInterfaceSkeletalMesh.__PropertyOffset_SourceComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataInterfaceSkeletalMesh.__PropertyOffset_SourceComponent, value);
			}
		}

		// Token: 0x170088D5 RID: 35029
		// (get) Token: 0x06023A68 RID: 146024 RVA: 0x0034B51B File Offset: 0x0034971B
		// (set) Token: 0x06023A69 RID: 146025 RVA: 0x0034B52B File Offset: 0x0034972B
		public unsafe ENDISkeletalMesh_SkinningMode SkinningMode
		{
			get
			{
				return (ENDISkeletalMesh_SkinningMode)(*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceSkeletalMesh.__PropertyOffset_SkinningMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceSkeletalMesh.__PropertyOffset_SkinningMode) = (byte)value;
			}
		}

		// Token: 0x170088D6 RID: 35030
		// (get) Token: 0x06023A6A RID: 146026 RVA: 0x0034B53C File Offset: 0x0034973C
		// (set) Token: 0x06023A6B RID: 146027 RVA: 0x0034B575 File Offset: 0x00349775
		public TArray<FName> SamplingRegions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._SamplingRegions) == null)
				{
					result = (this._SamplingRegions = new TArray<FName>(base.NativePtr + (IntPtr)UNiagaraDataInterfaceSkeletalMesh.__PropertyOffset_SamplingRegions, this));
				}
				return result;
			}
			set
			{
				this.SamplingRegions.CopyAssign(value);
			}
		}

		// Token: 0x170088D7 RID: 35031
		// (get) Token: 0x06023A6C RID: 146028 RVA: 0x0034B583 File Offset: 0x00349783
		// (set) Token: 0x06023A6D RID: 146029 RVA: 0x0034B593 File Offset: 0x00349793
		public unsafe int WholeMeshLOD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceSkeletalMesh.__PropertyOffset_WholeMeshLOD);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceSkeletalMesh.__PropertyOffset_WholeMeshLOD) = value;
			}
		}

		// Token: 0x170088D8 RID: 35032
		// (get) Token: 0x06023A6E RID: 146030 RVA: 0x0034B5A4 File Offset: 0x003497A4
		// (set) Token: 0x06023A6F RID: 146031 RVA: 0x0034B5DD File Offset: 0x003497DD
		public TArray<FName> FilteredBones
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._FilteredBones) == null)
				{
					result = (this._FilteredBones = new TArray<FName>(base.NativePtr + (IntPtr)UNiagaraDataInterfaceSkeletalMesh.__PropertyOffset_FilteredBones, this));
				}
				return result;
			}
			set
			{
				this.FilteredBones.CopyAssign(value);
			}
		}

		// Token: 0x170088D9 RID: 35033
		// (get) Token: 0x06023A70 RID: 146032 RVA: 0x0034B5EC File Offset: 0x003497EC
		// (set) Token: 0x06023A71 RID: 146033 RVA: 0x0034B625 File Offset: 0x00349825
		public TArray<FName> FilteredSockets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._FilteredSockets) == null)
				{
					result = (this._FilteredSockets = new TArray<FName>(base.NativePtr + (IntPtr)UNiagaraDataInterfaceSkeletalMesh.__PropertyOffset_FilteredSockets, this));
				}
				return result;
			}
			set
			{
				this.FilteredSockets.CopyAssign(value);
			}
		}

		// Token: 0x170088DA RID: 35034
		// (get) Token: 0x06023A72 RID: 146034 RVA: 0x0034B633 File Offset: 0x00349833
		// (set) Token: 0x06023A73 RID: 146035 RVA: 0x0034B647 File Offset: 0x00349847
		public unsafe FName ExcludeBoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceSkeletalMesh.__PropertyOffset_ExcludeBoneName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceSkeletalMesh.__PropertyOffset_ExcludeBoneName) = value;
			}
		}

		// Token: 0x170088DB RID: 35035
		// (get) Token: 0x06023A74 RID: 146036 RVA: 0x0034B65C File Offset: 0x0034985C
		// (set) Token: 0x06023A75 RID: 146037 RVA: 0x0034B675 File Offset: 0x00349875
		public unsafe bool bExcludeBone
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceSkeletalMesh.__PropertyOffset_bExcludeBone) & UNiagaraDataInterfaceSkeletalMesh.__PropertyMask_bExcludeBone) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraDataInterfaceSkeletalMesh.__PropertyOffset_bExcludeBone) = ((*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceSkeletalMesh.__PropertyOffset_bExcludeBone) & ~UNiagaraDataInterfaceSkeletalMesh.__PropertyMask_bExcludeBone) | (value ? UNiagaraDataInterfaceSkeletalMesh.__PropertyMask_bExcludeBone : 0));
			}
		}

		// Token: 0x170088DC RID: 35036
		// (get) Token: 0x06023A76 RID: 146038 RVA: 0x0034B6A5 File Offset: 0x003498A5
		// (set) Token: 0x06023A77 RID: 146039 RVA: 0x0034B6B5 File Offset: 0x003498B5
		public unsafe bool bRequireCurrentFrameData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceSkeletalMesh.__PropertyOffset_bRequireCurrentFrameData) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceSkeletalMesh.__PropertyOffset_bRequireCurrentFrameData) = (value ? 1 : 0);
			}
		}

		// Token: 0x06023A78 RID: 146040 RVA: 0x0034B6C6 File Offset: 0x003498C6
		static UNiagaraDataInterfaceSkeletalMesh()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataInterfaceSkeletalMesh");
		}

		// Token: 0x06023A79 RID: 146041 RVA: 0x0034B6D4 File Offset: 0x003498D4
		protected UNiagaraDataInterfaceSkeletalMesh(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040131CF RID: 78287
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataInterfaceSkeletalMesh";

		// Token: 0x040131D0 RID: 78288
		private static IntPtr _ClassPtr;

		// Token: 0x040131D1 RID: 78289
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040131D2 RID: 78290
		internal static int __PropertyOffset_SourceMode;

		// Token: 0x040131D3 RID: 78291
		internal static int __PropertyOffset_Source;

		// Token: 0x040131D4 RID: 78292
		internal static int __PropertyOffset_MeshUserParameter;

		// Token: 0x040131D5 RID: 78293
		[Nullable(2)]
		private FNiagaraUserParameterBinding _MeshUserParameter;

		// Token: 0x040131D6 RID: 78294
		internal static int __PropertyOffset_SourceComponent;

		// Token: 0x040131D7 RID: 78295
		internal static int __PropertyOffset_SkinningMode;

		// Token: 0x040131D8 RID: 78296
		internal static int __PropertyOffset_SamplingRegions;

		// Token: 0x040131D9 RID: 78297
		[Nullable(2)]
		private TArray<FName> _SamplingRegions;

		// Token: 0x040131DA RID: 78298
		internal static int __PropertyOffset_WholeMeshLOD;

		// Token: 0x040131DB RID: 78299
		internal static int __PropertyOffset_FilteredBones;

		// Token: 0x040131DC RID: 78300
		[Nullable(2)]
		private TArray<FName> _FilteredBones;

		// Token: 0x040131DD RID: 78301
		internal static int __PropertyOffset_FilteredSockets;

		// Token: 0x040131DE RID: 78302
		[Nullable(2)]
		private TArray<FName> _FilteredSockets;

		// Token: 0x040131DF RID: 78303
		internal static int __PropertyOffset_ExcludeBoneName;

		// Token: 0x040131E0 RID: 78304
		internal static int __PropertyOffset_bExcludeBone;

		// Token: 0x040131E1 RID: 78305
		internal static byte __PropertyMask_bExcludeBone;

		// Token: 0x040131E2 RID: 78306
		internal static int __PropertyOffset_bRequireCurrentFrameData;
	}
}
