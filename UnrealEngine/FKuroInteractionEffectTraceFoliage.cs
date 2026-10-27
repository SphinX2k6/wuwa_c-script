using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020019A6 RID: 6566
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroInteractionEffect.KuroInteractionEffectTraceFoliage")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 104)]
	public class FKuroInteractionEffectTraceFoliage : FKuroInteractionEffectNDCConfigBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060186FD RID: 100093 RVA: 0x002403B0 File Offset: 0x0023E5B0
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroInteractionEffectTraceFoliage._ScriptStructPtr != 0) ? FKuroInteractionEffectTraceFoliage._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroInteractionEffect.KuroInteractionEffectTraceFoliage", ref FKuroInteractionEffectTraceFoliage._ScriptStructPtr);
		}

		// Token: 0x1700619D RID: 24989
		// (get) Token: 0x060186FE RID: 100094 RVA: 0x002403D4 File Offset: 0x0023E5D4
		// (set) Token: 0x060186FF RID: 100095 RVA: 0x002403F3 File Offset: 0x0023E5F3
		public TSoftObjectPtr<UFoliageType_InstancedStaticMesh> FoliageMesh
		{
			get
			{
				return new TSoftObjectPtr<UFoliageType_InstancedStaticMesh>(base.NativePtr + (IntPtr)FKuroInteractionEffectTraceFoliage.__PropertyOffset_FoliageMesh, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)FKuroInteractionEffectTraceFoliage.__PropertyOffset_FoliageMesh, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x06018700 RID: 100096 RVA: 0x00240418 File Offset: 0x0023E618
		public FKuroInteractionEffectTraceFoliage()
		{
		}

		// Token: 0x06018701 RID: 100097 RVA: 0x00240420 File Offset: 0x0023E620
		public FKuroInteractionEffectTraceFoliage(TSoftObjectPtr<UFoliageType_InstancedStaticMesh> FoliageMesh, bool bEnableNDC, float SpawnNum, float HeightClamp, float Weight, float MoveSpawn, float WeaponSpawn, int EffectIndex, float TypeIndex, FVector PlayerSpawnOffset)
		{
			this.FoliageMesh = FoliageMesh;
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

		// Token: 0x06018702 RID: 100098 RVA: 0x00240480 File Offset: 0x0023E680
		protected override IntPtr GetUStructPtr()
		{
			return FKuroInteractionEffectTraceFoliage.StaticStruct();
		}

		// Token: 0x06018703 RID: 100099 RVA: 0x0024048C File Offset: 0x0023E68C
		[NullableContext(2)]
		public FKuroInteractionEffectTraceFoliage(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018704 RID: 100100 RVA: 0x00240496 File Offset: 0x0023E696
		public FKuroInteractionEffectTraceFoliage(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018705 RID: 100101 RVA: 0x002404A1 File Offset: 0x0023E6A1
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroInteractionEffectTraceFoliage(Pointer, false, true);
		}

		// Token: 0x06018706 RID: 100102 RVA: 0x002404AB File Offset: 0x0023E6AB
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroInteractionEffectTraceFoliage(Pointer, MemoryOwner);
		}

		// Token: 0x0400D346 RID: 54086
		public new const string __ObjectPath = "/Script/KuroInteractionEffect.KuroInteractionEffectTraceFoliage";

		// Token: 0x0400D347 RID: 54087
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D348 RID: 54088
		internal static int __PropertyOffset_FoliageMesh;
	}
}
