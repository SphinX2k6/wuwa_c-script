using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020019A7 RID: 6567
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroInteractionEffect.KuroInteractionEffectTraceStaticMesh")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 104)]
	public class FKuroInteractionEffectTraceStaticMesh : FKuroInteractionEffectNDCConfigBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06018707 RID: 100103 RVA: 0x002404B4 File Offset: 0x0023E6B4
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroInteractionEffectTraceStaticMesh._ScriptStructPtr != 0) ? FKuroInteractionEffectTraceStaticMesh._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroInteractionEffect.KuroInteractionEffectTraceStaticMesh", ref FKuroInteractionEffectTraceStaticMesh._ScriptStructPtr);
		}

		// Token: 0x1700619E RID: 24990
		// (get) Token: 0x06018708 RID: 100104 RVA: 0x002404D8 File Offset: 0x0023E6D8
		// (set) Token: 0x06018709 RID: 100105 RVA: 0x002404F7 File Offset: 0x0023E6F7
		public TSoftObjectPtr<UStaticMesh> StaticMesh
		{
			get
			{
				return new TSoftObjectPtr<UStaticMesh>(base.NativePtr + (IntPtr)FKuroInteractionEffectTraceStaticMesh.__PropertyOffset_StaticMesh, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)FKuroInteractionEffectTraceStaticMesh.__PropertyOffset_StaticMesh, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x0601870A RID: 100106 RVA: 0x0024051C File Offset: 0x0023E71C
		public FKuroInteractionEffectTraceStaticMesh()
		{
		}

		// Token: 0x0601870B RID: 100107 RVA: 0x00240524 File Offset: 0x0023E724
		public FKuroInteractionEffectTraceStaticMesh(TSoftObjectPtr<UStaticMesh> StaticMesh, bool bEnableNDC, float SpawnNum, float HeightClamp, float Weight, float MoveSpawn, float WeaponSpawn, int EffectIndex, float TypeIndex, FVector PlayerSpawnOffset)
		{
			this.StaticMesh = StaticMesh;
			base.bEnableNDC = bEnableNDC;
			base.SpawnNum = SpawnNum;
			base.HeightClamp = HeightClamp;
			base.Weight = Weight;
			base.MoveSpawn = MoveSpawn;
			base.WeaponSpawn = WeaponSpawn;
			base.EffectIndex = EffectIndex;
			base.TypeIndex = TypeIndex;
			base.PlayerSpawnOffset = PlayerSpawnOffset;
		}

		// Token: 0x0601870C RID: 100108 RVA: 0x00240584 File Offset: 0x0023E784
		protected override IntPtr GetUStructPtr()
		{
			return FKuroInteractionEffectTraceStaticMesh.StaticStruct();
		}

		// Token: 0x0601870D RID: 100109 RVA: 0x00240590 File Offset: 0x0023E790
		[NullableContext(2)]
		public FKuroInteractionEffectTraceStaticMesh(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601870E RID: 100110 RVA: 0x0024059A File Offset: 0x0023E79A
		public FKuroInteractionEffectTraceStaticMesh(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601870F RID: 100111 RVA: 0x002405A5 File Offset: 0x0023E7A5
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroInteractionEffectTraceStaticMesh(Pointer, false, true);
		}

		// Token: 0x06018710 RID: 100112 RVA: 0x002405AF File Offset: 0x0023E7AF
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroInteractionEffectTraceStaticMesh(Pointer, MemoryOwner);
		}

		// Token: 0x0400D349 RID: 54089
		public new const string __ObjectPath = "/Script/KuroInteractionEffect.KuroInteractionEffectTraceStaticMesh";

		// Token: 0x0400D34A RID: 54090
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D34B RID: 54091
		internal static int __PropertyOffset_StaticMesh;
	}
}
