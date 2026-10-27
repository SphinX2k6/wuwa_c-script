using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200259F RID: 9631
	[UnrealObjectPath("/Script/Niagara.NiagaraEmitterScalabilityOverride")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FNiagaraEmitterScalabilityOverride : FNiagaraEmitterScalabilitySettings, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023C5F RID: 146527 RVA: 0x0034E71F File Offset: 0x0034C91F
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraEmitterScalabilityOverride._ScriptStructPtr != 0) ? FNiagaraEmitterScalabilityOverride._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraEmitterScalabilityOverride", ref FNiagaraEmitterScalabilityOverride._ScriptStructPtr);
		}

		// Token: 0x17008980 RID: 35200
		// (get) Token: 0x06023C60 RID: 146528 RVA: 0x0034E743 File Offset: 0x0034C943
		// (set) Token: 0x06023C61 RID: 146529 RVA: 0x0034E75C File Offset: 0x0034C95C
		public unsafe bool bOverrideSpawnCountScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNiagaraEmitterScalabilityOverride.__PropertyOffset_bOverrideSpawnCountScale) & FNiagaraEmitterScalabilityOverride.__PropertyMask_bOverrideSpawnCountScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNiagaraEmitterScalabilityOverride.__PropertyOffset_bOverrideSpawnCountScale) = ((*(base.NativePtr + (IntPtr)FNiagaraEmitterScalabilityOverride.__PropertyOffset_bOverrideSpawnCountScale) & ~FNiagaraEmitterScalabilityOverride.__PropertyMask_bOverrideSpawnCountScale) | (value ? FNiagaraEmitterScalabilityOverride.__PropertyMask_bOverrideSpawnCountScale : 0));
			}
		}

		// Token: 0x06023C62 RID: 146530 RVA: 0x0034E78C File Offset: 0x0034C98C
		public FNiagaraEmitterScalabilityOverride()
		{
		}

		// Token: 0x06023C63 RID: 146531 RVA: 0x0034E794 File Offset: 0x0034C994
		[NullableContext(1)]
		public FNiagaraEmitterScalabilityOverride(bool bOverrideSpawnCountScale, FNiagaraPlatformSet Platforms, bool bScaleSpawnCount, float SpawnCountScale, bool bSpawnScaleByLodDistance, TArray<FNiagaraSystemSpawnScaleSettings> SpawnScaleByDistance, bool bCullFarImpotantEmitter, float FarImpotantEmitterCullDistance, bool bCullMiddleImpotantEmitter, float MiddleImpotantEmitterCullDistance, bool bCullNearImpotantEmitter, float NearImpotantEmitterCullDistance)
		{
			this.bOverrideSpawnCountScale = bOverrideSpawnCountScale;
			base.Platforms = Platforms;
			base.bScaleSpawnCount = bScaleSpawnCount;
			base.SpawnCountScale = SpawnCountScale;
			base.bSpawnScaleByLodDistance = bSpawnScaleByLodDistance;
			base.SpawnScaleByDistance = SpawnScaleByDistance;
			base.bCullFarImpotantEmitter = bCullFarImpotantEmitter;
			base.FarImpotantEmitterCullDistance = FarImpotantEmitterCullDistance;
			base.bCullMiddleImpotantEmitter = bCullMiddleImpotantEmitter;
			base.MiddleImpotantEmitterCullDistance = MiddleImpotantEmitterCullDistance;
			base.bCullNearImpotantEmitter = bCullNearImpotantEmitter;
			base.NearImpotantEmitterCullDistance = NearImpotantEmitterCullDistance;
		}

		// Token: 0x06023C64 RID: 146532 RVA: 0x0034E804 File Offset: 0x0034CA04
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraEmitterScalabilityOverride.StaticStruct();
		}

		// Token: 0x06023C65 RID: 146533 RVA: 0x0034E810 File Offset: 0x0034CA10
		[NullableContext(2)]
		public FNiagaraEmitterScalabilityOverride(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023C66 RID: 146534 RVA: 0x0034E81A File Offset: 0x0034CA1A
		public FNiagaraEmitterScalabilityOverride(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023C67 RID: 146535 RVA: 0x0034E825 File Offset: 0x0034CA25
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraEmitterScalabilityOverride(Pointer, false, true);
		}

		// Token: 0x06023C68 RID: 146536 RVA: 0x0034E82F File Offset: 0x0034CA2F
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraEmitterScalabilityOverride(Pointer, MemoryOwner);
		}

		// Token: 0x040132FE RID: 78590
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraEmitterScalabilityOverride";

		// Token: 0x040132FF RID: 78591
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013300 RID: 78592
		internal static int __PropertyOffset_bOverrideSpawnCountScale;

		// Token: 0x04013301 RID: 78593
		internal static byte __PropertyMask_bOverrideSpawnCountScale;
	}
}
