using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FF6 RID: 4086
	[UnrealObjectPath("/Script/Engine.PlannedRuntimePartitionHLODSetup")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FPlannedRuntimePartitionHLODSetup : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600DD47 RID: 56647 RVA: 0x00145CE2 File Offset: 0x00143EE2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPlannedRuntimePartitionHLODSetup._ScriptStructPtr != 0) ? FPlannedRuntimePartitionHLODSetup._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PlannedRuntimePartitionHLODSetup", ref FPlannedRuntimePartitionHLODSetup._ScriptStructPtr);
		}

		// Token: 0x17003433 RID: 13363
		// (get) Token: 0x0600DD48 RID: 56648 RVA: 0x00145D06 File Offset: 0x00143F06
		// (set) Token: 0x0600DD49 RID: 56649 RVA: 0x00145D1A File Offset: 0x00143F1A
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPlannedRuntimePartitionHLODSetup.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPlannedRuntimePartitionHLODSetup.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17003434 RID: 13364
		// (get) Token: 0x0600DD4A RID: 56650 RVA: 0x00145D2F File Offset: 0x00143F2F
		// (set) Token: 0x0600DD4B RID: 56651 RVA: 0x00145D43 File Offset: 0x00143F43
		[Nullable(2)]
		public unsafe URuntimePartitionTemplate PartitionLayer
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<URuntimePartitionTemplate>(base.NativePtr / (IntPtr)sizeof(void*) + FPlannedRuntimePartitionHLODSetup.__PropertyOffset_PartitionLayer);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FPlannedRuntimePartitionHLODSetup.__PropertyOffset_PartitionLayer, value);
			}
		}

		// Token: 0x17003435 RID: 13365
		// (get) Token: 0x0600DD4C RID: 56652 RVA: 0x00145D58 File Offset: 0x00143F58
		// (set) Token: 0x0600DD4D RID: 56653 RVA: 0x00145D68 File Offset: 0x00143F68
		public unsafe bool bIsSpatiallyLoaded
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPlannedRuntimePartitionHLODSetup.__PropertyOffset_bIsSpatiallyLoaded) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPlannedRuntimePartitionHLODSetup.__PropertyOffset_bIsSpatiallyLoaded) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600DD4E RID: 56654 RVA: 0x00145D79 File Offset: 0x00143F79
		public FPlannedRuntimePartitionHLODSetup()
		{
		}

		// Token: 0x0600DD4F RID: 56655 RVA: 0x00145D81 File Offset: 0x00143F81
		[NullableContext(1)]
		public FPlannedRuntimePartitionHLODSetup(FName Name, TArray<UHLODLayer> HLODLayers, FName RowDisplayName, URuntimePartitionTemplate PartitionLayer, bool bIsSpatiallyLoaded)
		{
			this.Name = Name;
			this.PartitionLayer = PartitionLayer;
			this.bIsSpatiallyLoaded = bIsSpatiallyLoaded;
		}

		// Token: 0x0600DD50 RID: 56656 RVA: 0x00145DA0 File Offset: 0x00143FA0
		protected override IntPtr GetUStructPtr()
		{
			return FPlannedRuntimePartitionHLODSetup.StaticStruct();
		}

		// Token: 0x0600DD51 RID: 56657 RVA: 0x00145DAC File Offset: 0x00143FAC
		[NullableContext(2)]
		public FPlannedRuntimePartitionHLODSetup(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600DD52 RID: 56658 RVA: 0x00145DB6 File Offset: 0x00143FB6
		public FPlannedRuntimePartitionHLODSetup(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600DD53 RID: 56659 RVA: 0x00145DC1 File Offset: 0x00143FC1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPlannedRuntimePartitionHLODSetup(Pointer, false, true);
		}

		// Token: 0x0600DD54 RID: 56660 RVA: 0x00145DCB File Offset: 0x00143FCB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPlannedRuntimePartitionHLODSetup(Pointer, MemoryOwner);
		}

		// Token: 0x0400779D RID: 30621
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.PlannedRuntimePartitionHLODSetup";

		// Token: 0x0400779E RID: 30622
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400779F RID: 30623
		internal static int __PropertyOffset_Name;

		// Token: 0x040077A0 RID: 30624
		internal static int __PropertyOffset_PartitionLayer;

		// Token: 0x040077A1 RID: 30625
		internal static int __PropertyOffset_bIsSpatiallyLoaded;
	}
}
