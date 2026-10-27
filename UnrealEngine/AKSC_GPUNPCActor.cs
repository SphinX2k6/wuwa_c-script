using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DE8 RID: 7656
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_GPUNPCActor")]
	[UnrealStructLayout(2576, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2576)]
	public class AKSC_GPUNPCActor : ABakedBoneMeshActor, IUnrealUObject, IUnrealObject, IKSC_RenderEntityInterface, IUnrealNativeInterface, IUnrealInterface, IKSC_RenderEntityAnimInterface, IKSC_RenderEntityMaterialInterface
	{
		// Token: 0x0601D419 RID: 119833 RVA: 0x002B33B9 File Offset: 0x002B15B9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKSC_GPUNPCActor._ClassPtr;
		}

		// Token: 0x0601D41A RID: 119834 RVA: 0x002B33C5 File Offset: 0x002B15C5
		int IKSC_RenderEntityInterface.InterfaceOffset()
		{
			return AKSC_GPUNPCActor.__InterfaceOffset_IKSC_RenderEntityInterface;
		}

		// Token: 0x0601D41B RID: 119835 RVA: 0x002B33CC File Offset: 0x002B15CC
		int IKSC_RenderEntityAnimInterface.InterfaceOffset()
		{
			return AKSC_GPUNPCActor.__InterfaceOffset_IKSC_RenderEntityAnimInterface;
		}

		// Token: 0x0601D41C RID: 119836 RVA: 0x002B33D3 File Offset: 0x002B15D3
		int IKSC_RenderEntityMaterialInterface.InterfaceOffset()
		{
			return AKSC_GPUNPCActor.__InterfaceOffset_IKSC_RenderEntityMaterialInterface;
		}

		// Token: 0x0601D41D RID: 119837 RVA: 0x002B33DC File Offset: 0x002B15DC
		public AKSC_GPUNPCActor() : this(BuiltinUtils.AllocNativeUObject(AKSC_GPUNPCActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D41E RID: 119838 RVA: 0x002B3404 File Offset: 0x002B1604
		public AKSC_GPUNPCActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKSC_GPUNPCActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700761F RID: 30239
		// (get) Token: 0x0601D41F RID: 119839 RVA: 0x002B3437 File Offset: 0x002B1637
		// (set) Token: 0x0601D420 RID: 119840 RVA: 0x002B344B File Offset: 0x002B164B
		[Nullable(2)]
		public unsafe UKSC_DA_EntityRender DA_EntityRender
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_EntityRender>(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_GPUNPCActor.__PropertyOffset_DA_EntityRender);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_GPUNPCActor.__PropertyOffset_DA_EntityRender, value);
			}
		}

		// Token: 0x17007620 RID: 30240
		// (get) Token: 0x0601D421 RID: 119841 RVA: 0x002B3460 File Offset: 0x002B1660
		// (set) Token: 0x0601D422 RID: 119842 RVA: 0x002B3499 File Offset: 0x002B1699
		public TArray<int> RemovedIndices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._RemovedIndices) == null)
				{
					result = (this._RemovedIndices = new TArray<int>(base.NativePtr + (IntPtr)AKSC_GPUNPCActor.__PropertyOffset_RemovedIndices, this));
				}
				return result;
			}
			set
			{
				this.RemovedIndices.CopyAssign(value);
			}
		}

		// Token: 0x17007621 RID: 30241
		// (get) Token: 0x0601D423 RID: 119843 RVA: 0x002B34A8 File Offset: 0x002B16A8
		// (set) Token: 0x0601D424 RID: 119844 RVA: 0x002B34E1 File Offset: 0x002B16E1
		public TMap<int, float> DelayRemovedIndices
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, float> result;
				if ((result = this._DelayRemovedIndices) == null)
				{
					result = (this._DelayRemovedIndices = new TMap<int, float>(base.NativePtr + (IntPtr)AKSC_GPUNPCActor.__PropertyOffset_DelayRemovedIndices, this));
				}
				return result;
			}
			set
			{
				this.DelayRemovedIndices.CopyAssign(value);
			}
		}

		// Token: 0x17007622 RID: 30242
		// (get) Token: 0x0601D425 RID: 119845 RVA: 0x002B34F0 File Offset: 0x002B16F0
		// (set) Token: 0x0601D426 RID: 119846 RVA: 0x002B3529 File Offset: 0x002B1729
		public TArray<int> InstanceAnim
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._InstanceAnim) == null)
				{
					result = (this._InstanceAnim = new TArray<int>(base.NativePtr + (IntPtr)AKSC_GPUNPCActor.__PropertyOffset_InstanceAnim, this));
				}
				return result;
			}
			set
			{
				this.InstanceAnim.CopyAssign(value);
			}
		}

		// Token: 0x17007623 RID: 30243
		// (get) Token: 0x0601D427 RID: 119847 RVA: 0x002B3538 File Offset: 0x002B1738
		// (set) Token: 0x0601D428 RID: 119848 RVA: 0x002B3571 File Offset: 0x002B1771
		public TArray<FTransform> InstanceTransform
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._InstanceTransform) == null)
				{
					result = (this._InstanceTransform = new TArray<FTransform>(base.NativePtr + (IntPtr)AKSC_GPUNPCActor.__PropertyOffset_InstanceTransform, this));
				}
				return result;
			}
			set
			{
				this.InstanceTransform.CopyAssign(value);
			}
		}

		// Token: 0x17007624 RID: 30244
		// (get) Token: 0x0601D429 RID: 119849 RVA: 0x002B3580 File Offset: 0x002B1780
		// (set) Token: 0x0601D42A RID: 119850 RVA: 0x002B35B9 File Offset: 0x002B17B9
		public TMap<int, int> EntityToInstanceMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, int> result;
				if ((result = this._EntityToInstanceMap) == null)
				{
					result = (this._EntityToInstanceMap = new TMap<int, int>(base.NativePtr + (IntPtr)AKSC_GPUNPCActor.__PropertyOffset_EntityToInstanceMap, this));
				}
				return result;
			}
			set
			{
				this.EntityToInstanceMap.CopyAssign(value);
			}
		}

		// Token: 0x17007625 RID: 30245
		// (get) Token: 0x0601D42B RID: 119851 RVA: 0x002B35C7 File Offset: 0x002B17C7
		// (set) Token: 0x0601D42C RID: 119852 RVA: 0x002B35DB File Offset: 0x002B17DB
		[Nullable(2)]
		public unsafe UBakedBoneMeshComponent MeshComp
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBakedBoneMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_GPUNPCActor.__PropertyOffset_MeshComp);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_GPUNPCActor.__PropertyOffset_MeshComp, value);
			}
		}

		// Token: 0x17007626 RID: 30246
		// (get) Token: 0x0601D42D RID: 119853 RVA: 0x002B35F0 File Offset: 0x002B17F0
		// (set) Token: 0x0601D42E RID: 119854 RVA: 0x002B3604 File Offset: 0x002B1804
		[Nullable(2)]
		public unsafe UKuroMaterialControllerComponent MaterialComp
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroMaterialControllerComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_GPUNPCActor.__PropertyOffset_MaterialComp);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_GPUNPCActor.__PropertyOffset_MaterialComp, value);
			}
		}

		// Token: 0x17007627 RID: 30247
		// (get) Token: 0x0601D42F RID: 119855 RVA: 0x002B361C File Offset: 0x002B181C
		// (set) Token: 0x0601D430 RID: 119856 RVA: 0x002B3655 File Offset: 0x002B1855
		public TMap<int, float> DelayAddMatIndices
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, float> result;
				if ((result = this._DelayAddMatIndices) == null)
				{
					result = (this._DelayAddMatIndices = new TMap<int, float>(base.NativePtr + (IntPtr)AKSC_GPUNPCActor.__PropertyOffset_DelayAddMatIndices, this));
				}
				return result;
			}
			set
			{
				this.DelayAddMatIndices.CopyAssign(value);
			}
		}

		// Token: 0x17007628 RID: 30248
		// (get) Token: 0x0601D431 RID: 119857 RVA: 0x002B3664 File Offset: 0x002B1864
		// (set) Token: 0x0601D432 RID: 119858 RVA: 0x002B369D File Offset: 0x002B189D
		public TMap<int, UKuroMaterialControllerDataAsset> DelayAddMatMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, UKuroMaterialControllerDataAsset> result;
				if ((result = this._DelayAddMatMap) == null)
				{
					result = (this._DelayAddMatMap = new TMap<int, UKuroMaterialControllerDataAsset>(base.NativePtr + (IntPtr)AKSC_GPUNPCActor.__PropertyOffset_DelayAddMatMap, this));
				}
				return result;
			}
			set
			{
				this.DelayAddMatMap.CopyAssign(value);
			}
		}

		// Token: 0x17007629 RID: 30249
		// (get) Token: 0x0601D433 RID: 119859 RVA: 0x002B36AC File Offset: 0x002B18AC
		// (set) Token: 0x0601D434 RID: 119860 RVA: 0x002B36E5 File Offset: 0x002B18E5
		public TMap<int, FVector2D> CurTimeLineData
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, FVector2D> result;
				if ((result = this._CurTimeLineData) == null)
				{
					result = (this._CurTimeLineData = new TMap<int, FVector2D>(base.NativePtr + (IntPtr)AKSC_GPUNPCActor.__PropertyOffset_CurTimeLineData, this));
				}
				return result;
			}
			set
			{
				this.CurTimeLineData.CopyAssign(value);
			}
		}

		// Token: 0x1700762A RID: 30250
		// (get) Token: 0x0601D435 RID: 119861 RVA: 0x002B36F3 File Offset: 0x002B18F3
		// (set) Token: 0x0601D436 RID: 119862 RVA: 0x002B3707 File Offset: 0x002B1907
		public unsafe FTransform RelativeTrans
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKSC_GPUNPCActor.__PropertyOffset_RelativeTrans);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKSC_GPUNPCActor.__PropertyOffset_RelativeTrans) = value;
			}
		}

		// Token: 0x1700762B RID: 30251
		// (get) Token: 0x0601D437 RID: 119863 RVA: 0x002B371C File Offset: 0x002B191C
		// (set) Token: 0x0601D438 RID: 119864 RVA: 0x002B3755 File Offset: 0x002B1955
		public TMap<EKSC_GPUNPCAnimState, int> AnimMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EKSC_GPUNPCAnimState, int> result;
				if ((result = this._AnimMap) == null)
				{
					result = (this._AnimMap = new TMap<EKSC_GPUNPCAnimState, int>(base.NativePtr + (IntPtr)AKSC_GPUNPCActor.__PropertyOffset_AnimMap, this));
				}
				return result;
			}
			set
			{
				this.AnimMap.CopyAssign(value);
			}
		}

		// Token: 0x1700762C RID: 30252
		// (get) Token: 0x0601D439 RID: 119865 RVA: 0x002B3764 File Offset: 0x002B1964
		// (set) Token: 0x0601D43A RID: 119866 RVA: 0x002B379D File Offset: 0x002B199D
		public TSet<EKSC_GPUNPCAnimState> DisableAnimLoopSet
		{
			get
			{
				base.FastCheckIsValid();
				TSet<EKSC_GPUNPCAnimState> result;
				if ((result = this._DisableAnimLoopSet) == null)
				{
					result = (this._DisableAnimLoopSet = new TSet<EKSC_GPUNPCAnimState>(base.NativePtr + (IntPtr)AKSC_GPUNPCActor.__PropertyOffset_DisableAnimLoopSet, this));
				}
				return result;
			}
			set
			{
				this.DisableAnimLoopSet.CopyAssign(value);
			}
		}

		// Token: 0x1700762D RID: 30253
		// (get) Token: 0x0601D43B RID: 119867 RVA: 0x002B37AC File Offset: 0x002B19AC
		// (set) Token: 0x0601D43C RID: 119868 RVA: 0x002B37E5 File Offset: 0x002B19E5
		public TMap<UKuroMaterialControllerDataAsset, int> MaterialMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UKuroMaterialControllerDataAsset, int> result;
				if ((result = this._MaterialMap) == null)
				{
					result = (this._MaterialMap = new TMap<UKuroMaterialControllerDataAsset, int>(base.NativePtr + (IntPtr)AKSC_GPUNPCActor.__PropertyOffset_MaterialMap, this));
				}
				return result;
			}
			set
			{
				this.MaterialMap.CopyAssign(value);
			}
		}

		// Token: 0x1700762E RID: 30254
		// (get) Token: 0x0601D43D RID: 119869 RVA: 0x002B37F3 File Offset: 0x002B19F3
		// (set) Token: 0x0601D43E RID: 119870 RVA: 0x002B3807 File Offset: 0x002B1A07
		[Nullable(2)]
		public unsafe UKuroMaterialControllerDataAsset BeHitMaterialDataAsset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroMaterialControllerDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_GPUNPCActor.__PropertyOffset_BeHitMaterialDataAsset);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_GPUNPCActor.__PropertyOffset_BeHitMaterialDataAsset, value);
			}
		}

		// Token: 0x0601D43F RID: 119871 RVA: 0x002B381C File Offset: 0x002B1A1C
		public virtual void InitGPUNPC()
		{
			AKSC_GPUNPCActor.__InitGPUNPC_Internal(base.NativePtr);
		}

		// Token: 0x0601D440 RID: 119872
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitGPUNPC_Internal(IntPtr @this);

		// Token: 0x0601D441 RID: 119873 RVA: 0x002B3829 File Offset: 0x002B1A29
		static AKSC_GPUNPCActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_GPUNPCActor");
		}

		// Token: 0x0601D442 RID: 119874 RVA: 0x002B3837 File Offset: 0x002B1A37
		protected AKSC_GPUNPCActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FDFF RID: 65023
		internal static int __InterfaceOffset_IKSC_RenderEntityInterface;

		// Token: 0x0400FE00 RID: 65024
		internal static int __InterfaceOffset_IKSC_RenderEntityAnimInterface;

		// Token: 0x0400FE01 RID: 65025
		internal static int __InterfaceOffset_IKSC_RenderEntityMaterialInterface;

		// Token: 0x0400FE02 RID: 65026
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_GPUNPCActor";

		// Token: 0x0400FE03 RID: 65027
		private static IntPtr _ClassPtr;

		// Token: 0x0400FE04 RID: 65028
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FE05 RID: 65029
		internal static int __PropertyOffset_DA_EntityRender;

		// Token: 0x0400FE06 RID: 65030
		internal static int __PropertyOffset_RemovedIndices;

		// Token: 0x0400FE07 RID: 65031
		[Nullable(2)]
		private TArray<int> _RemovedIndices;

		// Token: 0x0400FE08 RID: 65032
		internal static int __PropertyOffset_DelayRemovedIndices;

		// Token: 0x0400FE09 RID: 65033
		[Nullable(2)]
		private TMap<int, float> _DelayRemovedIndices;

		// Token: 0x0400FE0A RID: 65034
		internal static int __PropertyOffset_InstanceAnim;

		// Token: 0x0400FE0B RID: 65035
		[Nullable(2)]
		private TArray<int> _InstanceAnim;

		// Token: 0x0400FE0C RID: 65036
		internal static int __PropertyOffset_InstanceTransform;

		// Token: 0x0400FE0D RID: 65037
		[Nullable(2)]
		private TArray<FTransform> _InstanceTransform;

		// Token: 0x0400FE0E RID: 65038
		internal static int __PropertyOffset_EntityToInstanceMap;

		// Token: 0x0400FE0F RID: 65039
		[Nullable(2)]
		private TMap<int, int> _EntityToInstanceMap;

		// Token: 0x0400FE10 RID: 65040
		internal static int __PropertyOffset_MeshComp;

		// Token: 0x0400FE11 RID: 65041
		internal static int __PropertyOffset_MaterialComp;

		// Token: 0x0400FE12 RID: 65042
		internal static int __PropertyOffset_DelayAddMatIndices;

		// Token: 0x0400FE13 RID: 65043
		[Nullable(2)]
		private TMap<int, float> _DelayAddMatIndices;

		// Token: 0x0400FE14 RID: 65044
		internal static int __PropertyOffset_DelayAddMatMap;

		// Token: 0x0400FE15 RID: 65045
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, UKuroMaterialControllerDataAsset> _DelayAddMatMap;

		// Token: 0x0400FE16 RID: 65046
		internal static int __PropertyOffset_CurTimeLineData;

		// Token: 0x0400FE17 RID: 65047
		[Nullable(2)]
		private TMap<int, FVector2D> _CurTimeLineData;

		// Token: 0x0400FE18 RID: 65048
		internal static int __PropertyOffset_RelativeTrans;

		// Token: 0x0400FE19 RID: 65049
		internal static int __PropertyOffset_AnimMap;

		// Token: 0x0400FE1A RID: 65050
		[Nullable(2)]
		private TMap<EKSC_GPUNPCAnimState, int> _AnimMap;

		// Token: 0x0400FE1B RID: 65051
		internal static int __PropertyOffset_DisableAnimLoopSet;

		// Token: 0x0400FE1C RID: 65052
		[Nullable(2)]
		private TSet<EKSC_GPUNPCAnimState> _DisableAnimLoopSet;

		// Token: 0x0400FE1D RID: 65053
		internal static int __PropertyOffset_MaterialMap;

		// Token: 0x0400FE1E RID: 65054
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<UKuroMaterialControllerDataAsset, int> _MaterialMap;

		// Token: 0x0400FE1F RID: 65055
		internal static int __PropertyOffset_BeHitMaterialDataAsset;
	}
}
