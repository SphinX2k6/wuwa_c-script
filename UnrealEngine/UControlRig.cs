using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004B7 RID: 1207
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.ControlRig")]
	[UnrealStructLayout(2064, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2064)]
	public abstract class UControlRig : UObject, IUnrealUObject, IUnrealObject, INodeMappingProviderInterface, IUnrealNativeInterface, IUnrealInterface, IInterface_AssetUserData
	{
		// Token: 0x06004046 RID: 16454 RVA: 0x000609BD File Offset: 0x0005EBBD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UControlRig._ClassPtr;
		}

		// Token: 0x06004047 RID: 16455 RVA: 0x000609C9 File Offset: 0x0005EBC9
		int INodeMappingProviderInterface.InterfaceOffset()
		{
			return UControlRig.__InterfaceOffset_INodeMappingProviderInterface;
		}

		// Token: 0x06004048 RID: 16456 RVA: 0x000609D0 File Offset: 0x0005EBD0
		int IInterface_AssetUserData.InterfaceOffset()
		{
			return UControlRig.__InterfaceOffset_IInterface_AssetUserData;
		}

		// Token: 0x17000FB8 RID: 4024
		// (get) Token: 0x06004049 RID: 16457 RVA: 0x000609D7 File Offset: 0x0005EBD7
		// (set) Token: 0x0600404A RID: 16458 RVA: 0x000609E7 File Offset: 0x0005EBE7
		public unsafe ERigExecutionType ExecutionType
		{
			get
			{
				return (ERigExecutionType)(*(base.NativePtr + (IntPtr)UControlRig.__PropertyOffset_ExecutionType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UControlRig.__PropertyOffset_ExecutionType) = (byte)value;
			}
		}

		// Token: 0x17000FB9 RID: 4025
		// (get) Token: 0x0600404B RID: 16459 RVA: 0x000609F8 File Offset: 0x0005EBF8
		// (set) Token: 0x0600404C RID: 16460 RVA: 0x00060A0C File Offset: 0x0005EC0C
		[Nullable(2)]
		public unsafe URigVM VM
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<URigVM>(base.NativePtr / (IntPtr)sizeof(void*) + UControlRig.__PropertyOffset_VM);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UControlRig.__PropertyOffset_VM, value);
			}
		}

		// Token: 0x17000FBA RID: 4026
		// (get) Token: 0x0600404D RID: 16461 RVA: 0x00060A24 File Offset: 0x0005EC24
		// (set) Token: 0x0600404E RID: 16462 RVA: 0x00060A5D File Offset: 0x0005EC5D
		public FRigHierarchyContainer Hierarchy
		{
			get
			{
				base.FastCheckIsValid();
				FRigHierarchyContainer result;
				if ((result = this._Hierarchy) == null)
				{
					result = (this._Hierarchy = new FRigHierarchyContainer(base.NativePtr + (IntPtr)UControlRig.__PropertyOffset_Hierarchy, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigHierarchyContainer.StaticStruct(), base.NativePtr + (IntPtr)UControlRig.__PropertyOffset_Hierarchy, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000FBB RID: 4027
		// (get) Token: 0x0600404F RID: 16463 RVA: 0x00060A7E File Offset: 0x0005EC7E
		// (set) Token: 0x06004050 RID: 16464 RVA: 0x00060A93 File Offset: 0x0005EC93
		public TSoftObjectPtr<UControlRigGizmoLibrary> GizmoLibrary
		{
			get
			{
				return new TSoftObjectPtr<UControlRigGizmoLibrary>(base.NativePtr + (IntPtr)UControlRig.__PropertyOffset_GizmoLibrary, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)UControlRig.__PropertyOffset_GizmoLibrary, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17000FBC RID: 4028
		// (get) Token: 0x06004051 RID: 16465 RVA: 0x00060AB8 File Offset: 0x0005ECB8
		// (set) Token: 0x06004052 RID: 16466 RVA: 0x00060AF1 File Offset: 0x0005ECF1
		public TMap<FName, FCachedPropertyPath> InputProperties_DEPRECATED
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FCachedPropertyPath> result;
				if ((result = this._InputProperties_DEPRECATED) == null)
				{
					result = (this._InputProperties_DEPRECATED = new TMap<FName, FCachedPropertyPath>(base.NativePtr + (IntPtr)UControlRig.__PropertyOffset_InputProperties_DEPRECATED, this));
				}
				return result;
			}
			set
			{
				this.InputProperties_DEPRECATED.CopyAssign(value);
			}
		}

		// Token: 0x17000FBD RID: 4029
		// (get) Token: 0x06004053 RID: 16467 RVA: 0x00060B00 File Offset: 0x0005ED00
		// (set) Token: 0x06004054 RID: 16468 RVA: 0x00060B39 File Offset: 0x0005ED39
		public TMap<FName, FCachedPropertyPath> OutputProperties_DEPRECATED
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FCachedPropertyPath> result;
				if ((result = this._OutputProperties_DEPRECATED) == null)
				{
					result = (this._OutputProperties_DEPRECATED = new TMap<FName, FCachedPropertyPath>(base.NativePtr + (IntPtr)UControlRig.__PropertyOffset_OutputProperties_DEPRECATED, this));
				}
				return result;
			}
			set
			{
				this.OutputProperties_DEPRECATED.CopyAssign(value);
			}
		}

		// Token: 0x17000FBE RID: 4030
		// (get) Token: 0x06004055 RID: 16469 RVA: 0x00060B48 File Offset: 0x0005ED48
		// (set) Token: 0x06004056 RID: 16470 RVA: 0x00060B81 File Offset: 0x0005ED81
		public FControlRigDrawContainer DrawContainer
		{
			get
			{
				base.FastCheckIsValid();
				FControlRigDrawContainer result;
				if ((result = this._DrawContainer) == null)
				{
					result = (this._DrawContainer = new FControlRigDrawContainer(base.NativePtr + (IntPtr)UControlRig.__PropertyOffset_DrawContainer, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FControlRigDrawContainer.StaticStruct(), base.NativePtr + (IntPtr)UControlRig.__PropertyOffset_DrawContainer, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000FBF RID: 4031
		// (get) Token: 0x06004057 RID: 16471 RVA: 0x00060BA2 File Offset: 0x0005EDA2
		// (set) Token: 0x06004058 RID: 16472 RVA: 0x00060BB6 File Offset: 0x0005EDB6
		[Nullable(2)]
		public unsafe UAnimationDataSourceRegistry DataSourceRegistry
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimationDataSourceRegistry>(base.NativePtr / (IntPtr)sizeof(void*) + UControlRig.__PropertyOffset_DataSourceRegistry);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UControlRig.__PropertyOffset_DataSourceRegistry, value);
			}
		}

		// Token: 0x17000FC0 RID: 4032
		// (get) Token: 0x06004059 RID: 16473 RVA: 0x00060BCC File Offset: 0x0005EDCC
		// (set) Token: 0x0600405A RID: 16474 RVA: 0x00060C05 File Offset: 0x0005EE05
		public TArray<FName> EventQueue
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._EventQueue) == null)
				{
					result = (this._EventQueue = new TArray<FName>(base.NativePtr + (IntPtr)UControlRig.__PropertyOffset_EventQueue, this));
				}
				return result;
			}
			set
			{
				this.EventQueue.CopyAssign(value);
			}
		}

		// Token: 0x17000FC1 RID: 4033
		// (get) Token: 0x0600405B RID: 16475 RVA: 0x00060C14 File Offset: 0x0005EE14
		// (set) Token: 0x0600405C RID: 16476 RVA: 0x00060C4D File Offset: 0x0005EE4D
		public FRigInfluenceMapPerEvent Influences
		{
			get
			{
				base.FastCheckIsValid();
				FRigInfluenceMapPerEvent result;
				if ((result = this._Influences) == null)
				{
					result = (this._Influences = new FRigInfluenceMapPerEvent(base.NativePtr + (IntPtr)UControlRig.__PropertyOffset_Influences, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigInfluenceMapPerEvent.StaticStruct(), base.NativePtr + (IntPtr)UControlRig.__PropertyOffset_Influences, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000FC2 RID: 4034
		// (get) Token: 0x0600405D RID: 16477 RVA: 0x00060C6E File Offset: 0x0005EE6E
		// (set) Token: 0x0600405E RID: 16478 RVA: 0x00060C82 File Offset: 0x0005EE82
		[Nullable(2)]
		public unsafe UControlRig InteractionRig
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UControlRig>(base.NativePtr / (IntPtr)sizeof(void*) + UControlRig.__PropertyOffset_InteractionRig);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UControlRig.__PropertyOffset_InteractionRig, value);
			}
		}

		// Token: 0x17000FC3 RID: 4035
		// (get) Token: 0x0600405F RID: 16479 RVA: 0x00060C97 File Offset: 0x0005EE97
		// (set) Token: 0x06004060 RID: 16480 RVA: 0x00060CAB File Offset: 0x0005EEAB
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UControlRig> InteractionRigClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UControlRig.__PropertyOffset_InteractionRigClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UControlRig.__PropertyOffset_InteractionRigClass) = value;
			}
		}

		// Token: 0x17000FC4 RID: 4036
		// (get) Token: 0x06004061 RID: 16481 RVA: 0x00060CC0 File Offset: 0x0005EEC0
		// (set) Token: 0x06004062 RID: 16482 RVA: 0x00060CF9 File Offset: 0x0005EEF9
		public TArray<UAssetUserData> AssetUserData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UAssetUserData> result;
				if ((result = this._AssetUserData) == null)
				{
					result = (this._AssetUserData = new TArray<UAssetUserData>(base.NativePtr + (IntPtr)UControlRig.__PropertyOffset_AssetUserData, this));
				}
				return result;
			}
			set
			{
				this.AssetUserData.CopyAssign(value);
			}
		}

		// Token: 0x06004063 RID: 16483 RVA: 0x00060D07 File Offset: 0x0005EF07
		public void SetInteractionRigClass([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UControlRig> InInteractionRigClass)
		{
			UControlRig.__SetInteractionRigClass_Internal(base.NativePtr, InInteractionRigClass._NativePtr);
		}

		// Token: 0x06004064 RID: 16484 RVA: 0x00060D1A File Offset: 0x0005EF1A
		[NullableContext(2)]
		public void SetInteractionRig(UControlRig InInteractionRig)
		{
			UControlRig.__SetInteractionRig_Internal(base.NativePtr, (InInteractionRig != null) ? InInteractionRig.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06004065 RID: 16485 RVA: 0x00060D37 File Offset: 0x0005EF37
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public TSubclassOf<UControlRig> GetInteractionRigClass()
		{
			return UControlRig.__GetInteractionRigClass_Internal(base.NativePtr);
		}

		// Token: 0x06004066 RID: 16486 RVA: 0x00060D49 File Offset: 0x0005EF49
		[NullableContext(2)]
		public UControlRig GetInteractionRig()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UControlRig>(UControlRig.__GetInteractionRig_Internal(base.NativePtr));
		}

		// Token: 0x06004067 RID: 16487
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInteractionRigClass_Internal(IntPtr @this, IntPtr InInteractionRigClass);

		// Token: 0x06004068 RID: 16488
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInteractionRig_Internal(IntPtr @this, IntPtr InInteractionRig);

		// Token: 0x06004069 RID: 16489
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetInteractionRigClass_Internal(IntPtr @this);

		// Token: 0x0600406A RID: 16490
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetInteractionRig_Internal(IntPtr @this);

		// Token: 0x0600406B RID: 16491 RVA: 0x00060D5B File Offset: 0x0005EF5B
		static UControlRig()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ControlRig.ControlRig");
		}

		// Token: 0x0600406C RID: 16492 RVA: 0x00060D6C File Offset: 0x0005EF6C
		protected UControlRig() : this(BuiltinUtils.AllocNativeUObject(UControlRig.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600406D RID: 16493 RVA: 0x00060D94 File Offset: 0x0005EF94
		protected UControlRig(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001EBB RID: 7867
		internal static int __InterfaceOffset_INodeMappingProviderInterface;

		// Token: 0x04001EBC RID: 7868
		internal static int __InterfaceOffset_IInterface_AssetUserData;

		// Token: 0x04001EBD RID: 7869
		public new const string __ObjectPath = "/Script/ControlRig.ControlRig";

		// Token: 0x04001EBE RID: 7870
		private static IntPtr _ClassPtr;

		// Token: 0x04001EBF RID: 7871
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001EC0 RID: 7872
		internal static int __PropertyOffset_ExecutionType;

		// Token: 0x04001EC1 RID: 7873
		internal static int __PropertyOffset_VM;

		// Token: 0x04001EC2 RID: 7874
		internal static int __PropertyOffset_Hierarchy;

		// Token: 0x04001EC3 RID: 7875
		[Nullable(2)]
		private FRigHierarchyContainer _Hierarchy;

		// Token: 0x04001EC4 RID: 7876
		internal static int __PropertyOffset_GizmoLibrary;

		// Token: 0x04001EC5 RID: 7877
		internal static int __PropertyOffset_InputProperties_DEPRECATED;

		// Token: 0x04001EC6 RID: 7878
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FCachedPropertyPath> _InputProperties_DEPRECATED;

		// Token: 0x04001EC7 RID: 7879
		internal static int __PropertyOffset_OutputProperties_DEPRECATED;

		// Token: 0x04001EC8 RID: 7880
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FCachedPropertyPath> _OutputProperties_DEPRECATED;

		// Token: 0x04001EC9 RID: 7881
		internal static int __PropertyOffset_DrawContainer;

		// Token: 0x04001ECA RID: 7882
		[Nullable(2)]
		private FControlRigDrawContainer _DrawContainer;

		// Token: 0x04001ECB RID: 7883
		internal static int __PropertyOffset_DataSourceRegistry;

		// Token: 0x04001ECC RID: 7884
		internal static int __PropertyOffset_EventQueue;

		// Token: 0x04001ECD RID: 7885
		[Nullable(2)]
		private TArray<FName> _EventQueue;

		// Token: 0x04001ECE RID: 7886
		internal static int __PropertyOffset_Influences;

		// Token: 0x04001ECF RID: 7887
		[Nullable(2)]
		private FRigInfluenceMapPerEvent _Influences;

		// Token: 0x04001ED0 RID: 7888
		internal static int __PropertyOffset_InteractionRig;

		// Token: 0x04001ED1 RID: 7889
		internal static int __PropertyOffset_InteractionRigClass;

		// Token: 0x04001ED2 RID: 7890
		internal static int __PropertyOffset_AssetUserData;

		// Token: 0x04001ED3 RID: 7891
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UAssetUserData> _AssetUserData;
	}
}
