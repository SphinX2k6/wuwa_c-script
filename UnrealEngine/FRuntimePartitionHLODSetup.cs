using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010B3 RID: 4275
	[UnrealObjectPath("/Script/Engine.RuntimePartitionHLODSetup")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRuntimePartitionHLODSetup : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F452 RID: 62546 RVA: 0x0016A516 File Offset: 0x00168716
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRuntimePartitionHLODSetup._ScriptStructPtr != 0) ? FRuntimePartitionHLODSetup._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.RuntimePartitionHLODSetup", ref FRuntimePartitionHLODSetup._ScriptStructPtr);
		}

		// Token: 0x17003B84 RID: 15236
		// (get) Token: 0x0600F453 RID: 62547 RVA: 0x0016A53A File Offset: 0x0016873A
		// (set) Token: 0x0600F454 RID: 62548 RVA: 0x0016A54E File Offset: 0x0016874E
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRuntimePartitionHLODSetup.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRuntimePartitionHLODSetup.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17003B85 RID: 15237
		// (get) Token: 0x0600F455 RID: 62549 RVA: 0x0016A563 File Offset: 0x00168763
		// (set) Token: 0x0600F456 RID: 62550 RVA: 0x0016A573 File Offset: 0x00168773
		public unsafe bool bIsSpatiallyLoaded
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRuntimePartitionHLODSetup.__PropertyOffset_bIsSpatiallyLoaded) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRuntimePartitionHLODSetup.__PropertyOffset_bIsSpatiallyLoaded) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003B86 RID: 15238
		// (get) Token: 0x0600F457 RID: 62551 RVA: 0x0016A584 File Offset: 0x00168784
		// (set) Token: 0x0600F458 RID: 62552 RVA: 0x0016A598 File Offset: 0x00168798
		[Nullable(2)]
		public unsafe URuntimePartition PartitionLayer
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<URuntimePartition>(base.NativePtr / (IntPtr)sizeof(void*) + FRuntimePartitionHLODSetup.__PropertyOffset_PartitionLayer);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FRuntimePartitionHLODSetup.__PropertyOffset_PartitionLayer, value);
			}
		}

		// Token: 0x0600F459 RID: 62553 RVA: 0x0016A5AD File Offset: 0x001687AD
		public FRuntimePartitionHLODSetup()
		{
		}

		// Token: 0x0600F45A RID: 62554 RVA: 0x0016A5B5 File Offset: 0x001687B5
		[NullableContext(1)]
		public FRuntimePartitionHLODSetup(FName Name, TArray<UHLODLayer> HLODLayers, bool bIsSpatiallyLoaded, URuntimePartition PartitionLayer)
		{
			this.Name = Name;
			this.bIsSpatiallyLoaded = bIsSpatiallyLoaded;
			this.PartitionLayer = PartitionLayer;
		}

		// Token: 0x0600F45B RID: 62555 RVA: 0x0016A5D3 File Offset: 0x001687D3
		protected override IntPtr GetUStructPtr()
		{
			return FRuntimePartitionHLODSetup.StaticStruct();
		}

		// Token: 0x0600F45C RID: 62556 RVA: 0x0016A5DF File Offset: 0x001687DF
		[NullableContext(2)]
		public FRuntimePartitionHLODSetup(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F45D RID: 62557 RVA: 0x0016A5E9 File Offset: 0x001687E9
		public FRuntimePartitionHLODSetup(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F45E RID: 62558 RVA: 0x0016A5F4 File Offset: 0x001687F4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRuntimePartitionHLODSetup(Pointer, false, true);
		}

		// Token: 0x0600F45F RID: 62559 RVA: 0x0016A5FE File Offset: 0x001687FE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRuntimePartitionHLODSetup(Pointer, MemoryOwner);
		}

		// Token: 0x0400846C RID: 33900
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.RuntimePartitionHLODSetup";

		// Token: 0x0400846D RID: 33901
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400846E RID: 33902
		internal static int __PropertyOffset_Name;

		// Token: 0x0400846F RID: 33903
		internal static int __PropertyOffset_bIsSpatiallyLoaded;

		// Token: 0x04008470 RID: 33904
		internal static int __PropertyOffset_PartitionLayer;
	}
}
