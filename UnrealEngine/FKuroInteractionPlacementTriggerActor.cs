using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020019A8 RID: 6568
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroInteractionEffect.KuroInteractionPlacementTriggerActor")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 104)]
	public class FKuroInteractionPlacementTriggerActor : FTableRowBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06018711 RID: 100113 RVA: 0x002405B8 File Offset: 0x0023E7B8
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroInteractionPlacementTriggerActor._ScriptStructPtr != 0) ? FKuroInteractionPlacementTriggerActor._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroInteractionEffect.KuroInteractionPlacementTriggerActor", ref FKuroInteractionPlacementTriggerActor._ScriptStructPtr);
		}

		// Token: 0x1700619F RID: 24991
		// (get) Token: 0x06018712 RID: 100114 RVA: 0x002405DC File Offset: 0x0023E7DC
		// (set) Token: 0x06018713 RID: 100115 RVA: 0x002405FB File Offset: 0x0023E7FB
		public TSoftObjectPtr<UStaticMesh> PlacementStaticMesh
		{
			get
			{
				return new TSoftObjectPtr<UStaticMesh>(base.NativePtr + (IntPtr)FKuroInteractionPlacementTriggerActor.__PropertyOffset_PlacementStaticMesh, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)FKuroInteractionPlacementTriggerActor.__PropertyOffset_PlacementStaticMesh, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170061A0 RID: 24992
		// (get) Token: 0x06018714 RID: 100116 RVA: 0x00240620 File Offset: 0x0023E820
		// (set) Token: 0x06018715 RID: 100117 RVA: 0x0024063F File Offset: 0x0023E83F
		public TSoftObjectPtr<UStaticMesh> TriggerStaticMesh
		{
			get
			{
				return new TSoftObjectPtr<UStaticMesh>(base.NativePtr + (IntPtr)FKuroInteractionPlacementTriggerActor.__PropertyOffset_TriggerStaticMesh, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)FKuroInteractionPlacementTriggerActor.__PropertyOffset_TriggerStaticMesh, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x06018716 RID: 100118 RVA: 0x00240664 File Offset: 0x0023E864
		public FKuroInteractionPlacementTriggerActor()
		{
		}

		// Token: 0x06018717 RID: 100119 RVA: 0x0024066C File Offset: 0x0023E86C
		public FKuroInteractionPlacementTriggerActor(TSoftObjectPtr<UStaticMesh> PlacementStaticMesh, TSoftObjectPtr<UStaticMesh> TriggerStaticMesh)
		{
			this.PlacementStaticMesh = PlacementStaticMesh;
			this.TriggerStaticMesh = TriggerStaticMesh;
		}

		// Token: 0x06018718 RID: 100120 RVA: 0x00240682 File Offset: 0x0023E882
		protected override IntPtr GetUStructPtr()
		{
			return FKuroInteractionPlacementTriggerActor.StaticStruct();
		}

		// Token: 0x06018719 RID: 100121 RVA: 0x0024068E File Offset: 0x0023E88E
		[NullableContext(2)]
		public FKuroInteractionPlacementTriggerActor(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601871A RID: 100122 RVA: 0x00240698 File Offset: 0x0023E898
		public FKuroInteractionPlacementTriggerActor(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601871B RID: 100123 RVA: 0x002406A3 File Offset: 0x0023E8A3
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroInteractionPlacementTriggerActor(Pointer, false, true);
		}

		// Token: 0x0601871C RID: 100124 RVA: 0x002406AD File Offset: 0x0023E8AD
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroInteractionPlacementTriggerActor(Pointer, MemoryOwner);
		}

		// Token: 0x0400D34C RID: 54092
		public new const string __ObjectPath = "/Script/KuroInteractionEffect.KuroInteractionPlacementTriggerActor";

		// Token: 0x0400D34D RID: 54093
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D34E RID: 54094
		internal static int __PropertyOffset_PlacementStaticMesh;

		// Token: 0x0400D34F RID: 54095
		internal static int __PropertyOffset_TriggerStaticMesh;
	}
}
