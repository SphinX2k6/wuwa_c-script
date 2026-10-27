using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C37 RID: 3127
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.HLODLayer")]
	[UnrealStructLayout(1968, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1968)]
	public class UHLODLayer : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009E77 RID: 40567 RVA: 0x000E13D4 File Offset: 0x000DF5D4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHLODLayer._ClassPtr;
		}

		// Token: 0x06009E78 RID: 40568 RVA: 0x000E13E0 File Offset: 0x000DF5E0
		public UHLODLayer() : this(BuiltinUtils.AllocNativeUObject(UHLODLayer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009E79 RID: 40569 RVA: 0x000E1408 File Offset: 0x000DF608
		[NullableContext(1)]
		public UHLODLayer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHLODLayer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170025D9 RID: 9689
		// (get) Token: 0x06009E7A RID: 40570 RVA: 0x000E143B File Offset: 0x000DF63B
		// (set) Token: 0x06009E7B RID: 40571 RVA: 0x000E144B File Offset: 0x000DF64B
		public unsafe EHLODLayerType LayerType
		{
			get
			{
				return (EHLODLayerType)(*(base.NativePtr + (IntPtr)UHLODLayer.__PropertyOffset_LayerType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHLODLayer.__PropertyOffset_LayerType) = (byte)value;
			}
		}

		// Token: 0x170025DA RID: 9690
		// (get) Token: 0x06009E7C RID: 40572 RVA: 0x000E145C File Offset: 0x000DF65C
		// (set) Token: 0x06009E7D RID: 40573 RVA: 0x000E1470 File Offset: 0x000DF670
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UHLODBuilder> HLODBuilderClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UHLODLayer.__PropertyOffset_HLODBuilderClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UHLODLayer.__PropertyOffset_HLODBuilderClass) = value;
			}
		}

		// Token: 0x170025DB RID: 9691
		// (get) Token: 0x06009E7E RID: 40574 RVA: 0x000E1485 File Offset: 0x000DF685
		// (set) Token: 0x06009E7F RID: 40575 RVA: 0x000E1499 File Offset: 0x000DF699
		public unsafe UHLODBuilderSettings HLODBuilderSettings
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UHLODBuilderSettings>(base.NativePtr / (IntPtr)sizeof(void*) + UHLODLayer.__PropertyOffset_HLODBuilderSettings);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UHLODLayer.__PropertyOffset_HLODBuilderSettings, value);
			}
		}

		// Token: 0x170025DC RID: 9692
		// (get) Token: 0x06009E80 RID: 40576 RVA: 0x000E14AE File Offset: 0x000DF6AE
		// (set) Token: 0x06009E81 RID: 40577 RVA: 0x000E14C7 File Offset: 0x000DF6C7
		public unsafe bool bIsSpatiallyLoaded
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UHLODLayer.__PropertyOffset_bIsSpatiallyLoaded) & UHLODLayer.__PropertyMask_bIsSpatiallyLoaded) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UHLODLayer.__PropertyOffset_bIsSpatiallyLoaded) = ((*(base.NativePtr + (IntPtr)UHLODLayer.__PropertyOffset_bIsSpatiallyLoaded) & ~UHLODLayer.__PropertyMask_bIsSpatiallyLoaded) | (value ? UHLODLayer.__PropertyMask_bIsSpatiallyLoaded : 0));
			}
		}

		// Token: 0x170025DD RID: 9693
		// (get) Token: 0x06009E82 RID: 40578 RVA: 0x000E14F7 File Offset: 0x000DF6F7
		// (set) Token: 0x06009E83 RID: 40579 RVA: 0x000E1507 File Offset: 0x000DF707
		public unsafe int CellSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHLODLayer.__PropertyOffset_CellSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHLODLayer.__PropertyOffset_CellSize) = value;
			}
		}

		// Token: 0x170025DE RID: 9694
		// (get) Token: 0x06009E84 RID: 40580 RVA: 0x000E1518 File Offset: 0x000DF718
		// (set) Token: 0x06009E85 RID: 40581 RVA: 0x000E1528 File Offset: 0x000DF728
		public unsafe double LoadingRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHLODLayer.__PropertyOffset_LoadingRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHLODLayer.__PropertyOffset_LoadingRange) = value;
			}
		}

		// Token: 0x170025DF RID: 9695
		// (get) Token: 0x06009E86 RID: 40582 RVA: 0x000E1539 File Offset: 0x000DF739
		// (set) Token: 0x06009E87 RID: 40583 RVA: 0x000E154D File Offset: 0x000DF74D
		public unsafe UHLODLayer ParentLayer
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UHLODLayer>(base.NativePtr / (IntPtr)sizeof(void*) + UHLODLayer.__PropertyOffset_ParentLayer);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UHLODLayer.__PropertyOffset_ParentLayer, value);
			}
		}

		// Token: 0x170025E0 RID: 9696
		// (get) Token: 0x06009E88 RID: 40584 RVA: 0x000E1562 File Offset: 0x000DF762
		// (set) Token: 0x06009E89 RID: 40585 RVA: 0x000E1576 File Offset: 0x000DF776
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<AWorldPartitionHLOD> HLODActorClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UHLODLayer.__PropertyOffset_HLODActorClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UHLODLayer.__PropertyOffset_HLODActorClass) = value;
			}
		}

		// Token: 0x170025E1 RID: 9697
		// (get) Token: 0x06009E8A RID: 40586 RVA: 0x000E158B File Offset: 0x000DF78B
		// (set) Token: 0x06009E8B RID: 40587 RVA: 0x000E159F File Offset: 0x000DF79F
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UWorldPartitionHLODModifier> HLODModifierClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UHLODLayer.__PropertyOffset_HLODModifierClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UHLODLayer.__PropertyOffset_HLODModifierClass) = value;
			}
		}

		// Token: 0x06009E8C RID: 40588 RVA: 0x000E15B4 File Offset: 0x000DF7B4
		static UHLODLayer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.HLODLayer");
		}

		// Token: 0x06009E8D RID: 40589 RVA: 0x000E15C2 File Offset: 0x000DF7C2
		protected UHLODLayer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400575B RID: 22363
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.HLODLayer";

		// Token: 0x0400575C RID: 22364
		private static IntPtr _ClassPtr;

		// Token: 0x0400575D RID: 22365
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400575E RID: 22366
		internal static int __PropertyOffset_LayerType;

		// Token: 0x0400575F RID: 22367
		internal static int __PropertyOffset_HLODBuilderClass;

		// Token: 0x04005760 RID: 22368
		internal static int __PropertyOffset_HLODBuilderSettings;

		// Token: 0x04005761 RID: 22369
		internal static int __PropertyOffset_bIsSpatiallyLoaded;

		// Token: 0x04005762 RID: 22370
		internal static byte __PropertyMask_bIsSpatiallyLoaded;

		// Token: 0x04005763 RID: 22371
		internal static int __PropertyOffset_CellSize;

		// Token: 0x04005764 RID: 22372
		internal static int __PropertyOffset_LoadingRange;

		// Token: 0x04005765 RID: 22373
		internal static int __PropertyOffset_ParentLayer;

		// Token: 0x04005766 RID: 22374
		internal static int __PropertyOffset_HLODActorClass;

		// Token: 0x04005767 RID: 22375
		internal static int __PropertyOffset_HLODModifierClass;
	}
}
