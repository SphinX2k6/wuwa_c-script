using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200124D RID: 4685
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.WorldPartition")]
	[UnrealStructLayout(1200, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1200)]
	public class UWorldPartition : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060113CF RID: 70607 RVA: 0x00194B2A File Offset: 0x00192D2A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWorldPartition._ClassPtr;
		}

		// Token: 0x060113D0 RID: 70608 RVA: 0x00194B38 File Offset: 0x00192D38
		public UWorldPartition() : this(BuiltinUtils.AllocNativeUObject(UWorldPartition.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060113D1 RID: 70609 RVA: 0x00194B60 File Offset: 0x00192D60
		[NullableContext(1)]
		public UWorldPartition(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWorldPartition.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004341 RID: 17217
		// (get) Token: 0x060113D2 RID: 70610 RVA: 0x00194B94 File Offset: 0x00192D94
		// (set) Token: 0x060113D3 RID: 70611 RVA: 0x00194BCD File Offset: 0x00192DCD
		[Nullable(1)]
		public TArray<FName> CellLayerExcludeGrid
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._CellLayerExcludeGrid) == null)
				{
					result = (this._CellLayerExcludeGrid = new TArray<FName>(base.NativePtr + (IntPtr)UWorldPartition.__PropertyOffset_CellLayerExcludeGrid, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CellLayerExcludeGrid.CopyAssign(value);
			}
		}

		// Token: 0x17004342 RID: 17218
		// (get) Token: 0x060113D4 RID: 70612 RVA: 0x00194BDB File Offset: 0x00192DDB
		// (set) Token: 0x060113D5 RID: 70613 RVA: 0x00194BEF File Offset: 0x00192DEF
		public unsafe UWorldPartitionRuntimeHash RuntimeHash
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UWorldPartitionRuntimeHash>(base.NativePtr / (IntPtr)sizeof(void*) + UWorldPartition.__PropertyOffset_RuntimeHash);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWorldPartition.__PropertyOffset_RuntimeHash, value);
			}
		}

		// Token: 0x17004343 RID: 17219
		// (get) Token: 0x060113D6 RID: 70614 RVA: 0x00194C04 File Offset: 0x00192E04
		// (set) Token: 0x060113D7 RID: 70615 RVA: 0x00194C14 File Offset: 0x00192E14
		public unsafe bool bEnableStreaming
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWorldPartition.__PropertyOffset_bEnableStreaming) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWorldPartition.__PropertyOffset_bEnableStreaming) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004344 RID: 17220
		// (get) Token: 0x060113D8 RID: 70616 RVA: 0x00194C25 File Offset: 0x00192E25
		// (set) Token: 0x060113D9 RID: 70617 RVA: 0x00194C39 File Offset: 0x00192E39
		public unsafe UWorld World
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UWorld>(base.NativePtr / (IntPtr)sizeof(void*) + UWorldPartition.__PropertyOffset_World);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWorldPartition.__PropertyOffset_World, value);
			}
		}

		// Token: 0x17004345 RID: 17221
		// (get) Token: 0x060113DA RID: 70618 RVA: 0x00194C4E File Offset: 0x00192E4E
		// (set) Token: 0x060113DB RID: 70619 RVA: 0x00194C67 File Offset: 0x00192E67
		public unsafe bool bHasStandaloneHLOD
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UWorldPartition.__PropertyOffset_bHasStandaloneHLOD) & UWorldPartition.__PropertyMask_bHasStandaloneHLOD) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UWorldPartition.__PropertyOffset_bHasStandaloneHLOD) = ((*(base.NativePtr + (IntPtr)UWorldPartition.__PropertyOffset_bHasStandaloneHLOD) & ~UWorldPartition.__PropertyMask_bHasStandaloneHLOD) | (value ? UWorldPartition.__PropertyMask_bHasStandaloneHLOD : 0));
			}
		}

		// Token: 0x17004346 RID: 17222
		// (get) Token: 0x060113DC RID: 70620 RVA: 0x00194C97 File Offset: 0x00192E97
		// (set) Token: 0x060113DD RID: 70621 RVA: 0x00194CB0 File Offset: 0x00192EB0
		public unsafe bool bHasExtSoloHLOD
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UWorldPartition.__PropertyOffset_bHasExtSoloHLOD) & UWorldPartition.__PropertyMask_bHasExtSoloHLOD) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UWorldPartition.__PropertyOffset_bHasExtSoloHLOD) = ((*(base.NativePtr + (IntPtr)UWorldPartition.__PropertyOffset_bHasExtSoloHLOD) & ~UWorldPartition.__PropertyMask_bHasExtSoloHLOD) | (value ? UWorldPartition.__PropertyMask_bHasExtSoloHLOD : 0));
			}
		}

		// Token: 0x17004347 RID: 17223
		// (get) Token: 0x060113DE RID: 70622 RVA: 0x00194CE0 File Offset: 0x00192EE0
		// (set) Token: 0x060113DF RID: 70623 RVA: 0x00194CF9 File Offset: 0x00192EF9
		public unsafe bool bExternalizeHLODAssets
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UWorldPartition.__PropertyOffset_bExternalizeHLODAssets) & UWorldPartition.__PropertyMask_bExternalizeHLODAssets) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UWorldPartition.__PropertyOffset_bExternalizeHLODAssets) = ((*(base.NativePtr + (IntPtr)UWorldPartition.__PropertyOffset_bExternalizeHLODAssets) & ~UWorldPartition.__PropertyMask_bExternalizeHLODAssets) | (value ? UWorldPartition.__PropertyMask_bExternalizeHLODAssets : 0));
			}
		}

		// Token: 0x17004348 RID: 17224
		// (get) Token: 0x060113E0 RID: 70624 RVA: 0x00194D29 File Offset: 0x00192F29
		// (set) Token: 0x060113E1 RID: 70625 RVA: 0x00194D42 File Offset: 0x00192F42
		public unsafe bool bIsStandaloneHLODWorld
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UWorldPartition.__PropertyOffset_bIsStandaloneHLODWorld) & UWorldPartition.__PropertyMask_bIsStandaloneHLODWorld) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UWorldPartition.__PropertyOffset_bIsStandaloneHLODWorld) = ((*(base.NativePtr + (IntPtr)UWorldPartition.__PropertyOffset_bIsStandaloneHLODWorld) & ~UWorldPartition.__PropertyMask_bIsStandaloneHLODWorld) | (value ? UWorldPartition.__PropertyMask_bIsStandaloneHLODWorld : 0));
			}
		}

		// Token: 0x17004349 RID: 17225
		// (get) Token: 0x060113E2 RID: 70626 RVA: 0x00194D72 File Offset: 0x00192F72
		// (set) Token: 0x060113E3 RID: 70627 RVA: 0x00194D82 File Offset: 0x00192F82
		public unsafe EWorldPartitionDataLayersLogicOperator DataLayersLogicOperator
		{
			get
			{
				return (EWorldPartitionDataLayersLogicOperator)(*(base.NativePtr + (IntPtr)UWorldPartition.__PropertyOffset_DataLayersLogicOperator));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWorldPartition.__PropertyOffset_DataLayersLogicOperator) = (byte)value;
			}
		}

		// Token: 0x1700434A RID: 17226
		// (get) Token: 0x060113E4 RID: 70628 RVA: 0x00194D93 File Offset: 0x00192F93
		// (set) Token: 0x060113E5 RID: 70629 RVA: 0x00194DA7 File Offset: 0x00192FA7
		public unsafe UDataLayerManager DataLayerManager
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataLayerManager>(base.NativePtr / (IntPtr)sizeof(void*) + UWorldPartition.__PropertyOffset_DataLayerManager);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWorldPartition.__PropertyOffset_DataLayerManager, value);
			}
		}

		// Token: 0x1700434B RID: 17227
		// (get) Token: 0x060113E6 RID: 70630 RVA: 0x00194DBC File Offset: 0x00192FBC
		// (set) Token: 0x060113E7 RID: 70631 RVA: 0x00194DD0 File Offset: 0x00192FD0
		public unsafe UWorldPartitionStreamingPolicy StreamingPolicy
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UWorldPartitionStreamingPolicy>(base.NativePtr / (IntPtr)sizeof(void*) + UWorldPartition.__PropertyOffset_StreamingPolicy);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWorldPartition.__PropertyOffset_StreamingPolicy, value);
			}
		}

		// Token: 0x060113E8 RID: 70632 RVA: 0x00194DE5 File Offset: 0x00192FE5
		static UWorldPartition()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WorldPartition");
		}

		// Token: 0x060113E9 RID: 70633 RVA: 0x00194DF3 File Offset: 0x00192FF3
		protected UWorldPartition(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009384 RID: 37764
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.WorldPartition";

		// Token: 0x04009385 RID: 37765
		private static IntPtr _ClassPtr;

		// Token: 0x04009386 RID: 37766
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009387 RID: 37767
		internal static int __PropertyOffset_CellLayerExcludeGrid;

		// Token: 0x04009388 RID: 37768
		private TArray<FName> _CellLayerExcludeGrid;

		// Token: 0x04009389 RID: 37769
		internal static int __PropertyOffset_RuntimeHash;

		// Token: 0x0400938A RID: 37770
		internal static int __PropertyOffset_bEnableStreaming;

		// Token: 0x0400938B RID: 37771
		internal static int __PropertyOffset_World;

		// Token: 0x0400938C RID: 37772
		internal static int __PropertyOffset_bHasStandaloneHLOD;

		// Token: 0x0400938D RID: 37773
		internal static byte __PropertyMask_bHasStandaloneHLOD;

		// Token: 0x0400938E RID: 37774
		internal static int __PropertyOffset_bHasExtSoloHLOD;

		// Token: 0x0400938F RID: 37775
		internal static byte __PropertyMask_bHasExtSoloHLOD;

		// Token: 0x04009390 RID: 37776
		internal static int __PropertyOffset_bExternalizeHLODAssets;

		// Token: 0x04009391 RID: 37777
		internal static byte __PropertyMask_bExternalizeHLODAssets;

		// Token: 0x04009392 RID: 37778
		internal static int __PropertyOffset_bIsStandaloneHLODWorld;

		// Token: 0x04009393 RID: 37779
		internal static byte __PropertyMask_bIsStandaloneHLODWorld;

		// Token: 0x04009394 RID: 37780
		internal static int __PropertyOffset_DataLayersLogicOperator;

		// Token: 0x04009395 RID: 37781
		internal static int __PropertyOffset_DataLayerManager;

		// Token: 0x04009396 RID: 37782
		internal static int __PropertyOffset_StreamingPolicy;
	}
}
