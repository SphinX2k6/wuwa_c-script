using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020025A1 RID: 9633
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraEmitterScalabilitySettings")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 104)]
	public class FNiagaraEmitterScalabilitySettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023C73 RID: 146547 RVA: 0x0034E8F8 File Offset: 0x0034CAF8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraEmitterScalabilitySettings._ScriptStructPtr != 0) ? FNiagaraEmitterScalabilitySettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraEmitterScalabilitySettings", ref FNiagaraEmitterScalabilitySettings._ScriptStructPtr);
		}

		// Token: 0x17008982 RID: 35202
		// (get) Token: 0x06023C74 RID: 146548 RVA: 0x0034E91C File Offset: 0x0034CB1C
		// (set) Token: 0x06023C75 RID: 146549 RVA: 0x0034E95F File Offset: 0x0034CB5F
		public FNiagaraPlatformSet Platforms
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraPlatformSet result;
				if ((result = this._Platforms) == null)
				{
					result = (this._Platforms = new FNiagaraPlatformSet(base.NativePtr + (IntPtr)FNiagaraEmitterScalabilitySettings.__PropertyOffset_Platforms, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraPlatformSet.StaticStruct(), base.NativePtr + (IntPtr)FNiagaraEmitterScalabilitySettings.__PropertyOffset_Platforms, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008983 RID: 35203
		// (get) Token: 0x06023C76 RID: 146550 RVA: 0x0034E980 File Offset: 0x0034CB80
		// (set) Token: 0x06023C77 RID: 146551 RVA: 0x0034E999 File Offset: 0x0034CB99
		public unsafe bool bScaleSpawnCount
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNiagaraEmitterScalabilitySettings.__PropertyOffset_bScaleSpawnCount) & FNiagaraEmitterScalabilitySettings.__PropertyMask_bScaleSpawnCount) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNiagaraEmitterScalabilitySettings.__PropertyOffset_bScaleSpawnCount) = ((*(base.NativePtr + (IntPtr)FNiagaraEmitterScalabilitySettings.__PropertyOffset_bScaleSpawnCount) & ~FNiagaraEmitterScalabilitySettings.__PropertyMask_bScaleSpawnCount) | (value ? FNiagaraEmitterScalabilitySettings.__PropertyMask_bScaleSpawnCount : 0));
			}
		}

		// Token: 0x17008984 RID: 35204
		// (get) Token: 0x06023C78 RID: 146552 RVA: 0x0034E9C9 File Offset: 0x0034CBC9
		// (set) Token: 0x06023C79 RID: 146553 RVA: 0x0034E9D9 File Offset: 0x0034CBD9
		public unsafe float SpawnCountScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraEmitterScalabilitySettings.__PropertyOffset_SpawnCountScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraEmitterScalabilitySettings.__PropertyOffset_SpawnCountScale) = value;
			}
		}

		// Token: 0x17008985 RID: 35205
		// (get) Token: 0x06023C7A RID: 146554 RVA: 0x0034E9EA File Offset: 0x0034CBEA
		// (set) Token: 0x06023C7B RID: 146555 RVA: 0x0034EA03 File Offset: 0x0034CC03
		public unsafe bool bSpawnScaleByLodDistance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNiagaraEmitterScalabilitySettings.__PropertyOffset_bSpawnScaleByLodDistance) & FNiagaraEmitterScalabilitySettings.__PropertyMask_bSpawnScaleByLodDistance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNiagaraEmitterScalabilitySettings.__PropertyOffset_bSpawnScaleByLodDistance) = ((*(base.NativePtr + (IntPtr)FNiagaraEmitterScalabilitySettings.__PropertyOffset_bSpawnScaleByLodDistance) & ~FNiagaraEmitterScalabilitySettings.__PropertyMask_bSpawnScaleByLodDistance) | (value ? FNiagaraEmitterScalabilitySettings.__PropertyMask_bSpawnScaleByLodDistance : 0));
			}
		}

		// Token: 0x17008986 RID: 35206
		// (get) Token: 0x06023C7C RID: 146556 RVA: 0x0034EA34 File Offset: 0x0034CC34
		// (set) Token: 0x06023C7D RID: 146557 RVA: 0x0034EA77 File Offset: 0x0034CC77
		public TArray<FNiagaraSystemSpawnScaleSettings> SpawnScaleByDistance
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNiagaraSystemSpawnScaleSettings> result;
				if ((result = this._SpawnScaleByDistance) == null)
				{
					result = (this._SpawnScaleByDistance = new TArray<FNiagaraSystemSpawnScaleSettings>(base.NativePtr + (IntPtr)FNiagaraEmitterScalabilitySettings.__PropertyOffset_SpawnScaleByDistance, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SpawnScaleByDistance.CopyAssign(value);
			}
		}

		// Token: 0x17008987 RID: 35207
		// (get) Token: 0x06023C7E RID: 146558 RVA: 0x0034EA85 File Offset: 0x0034CC85
		// (set) Token: 0x06023C7F RID: 146559 RVA: 0x0034EA9E File Offset: 0x0034CC9E
		public unsafe bool bCullFarImpotantEmitter
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNiagaraEmitterScalabilitySettings.__PropertyOffset_bCullFarImpotantEmitter) & FNiagaraEmitterScalabilitySettings.__PropertyMask_bCullFarImpotantEmitter) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNiagaraEmitterScalabilitySettings.__PropertyOffset_bCullFarImpotantEmitter) = ((*(base.NativePtr + (IntPtr)FNiagaraEmitterScalabilitySettings.__PropertyOffset_bCullFarImpotantEmitter) & ~FNiagaraEmitterScalabilitySettings.__PropertyMask_bCullFarImpotantEmitter) | (value ? FNiagaraEmitterScalabilitySettings.__PropertyMask_bCullFarImpotantEmitter : 0));
			}
		}

		// Token: 0x17008988 RID: 35208
		// (get) Token: 0x06023C80 RID: 146560 RVA: 0x0034EACE File Offset: 0x0034CCCE
		// (set) Token: 0x06023C81 RID: 146561 RVA: 0x0034EADE File Offset: 0x0034CCDE
		public unsafe float FarImpotantEmitterCullDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraEmitterScalabilitySettings.__PropertyOffset_FarImpotantEmitterCullDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraEmitterScalabilitySettings.__PropertyOffset_FarImpotantEmitterCullDistance) = value;
			}
		}

		// Token: 0x17008989 RID: 35209
		// (get) Token: 0x06023C82 RID: 146562 RVA: 0x0034EAEF File Offset: 0x0034CCEF
		// (set) Token: 0x06023C83 RID: 146563 RVA: 0x0034EB08 File Offset: 0x0034CD08
		public unsafe bool bCullMiddleImpotantEmitter
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNiagaraEmitterScalabilitySettings.__PropertyOffset_bCullMiddleImpotantEmitter) & FNiagaraEmitterScalabilitySettings.__PropertyMask_bCullMiddleImpotantEmitter) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNiagaraEmitterScalabilitySettings.__PropertyOffset_bCullMiddleImpotantEmitter) = ((*(base.NativePtr + (IntPtr)FNiagaraEmitterScalabilitySettings.__PropertyOffset_bCullMiddleImpotantEmitter) & ~FNiagaraEmitterScalabilitySettings.__PropertyMask_bCullMiddleImpotantEmitter) | (value ? FNiagaraEmitterScalabilitySettings.__PropertyMask_bCullMiddleImpotantEmitter : 0));
			}
		}

		// Token: 0x1700898A RID: 35210
		// (get) Token: 0x06023C84 RID: 146564 RVA: 0x0034EB38 File Offset: 0x0034CD38
		// (set) Token: 0x06023C85 RID: 146565 RVA: 0x0034EB48 File Offset: 0x0034CD48
		public unsafe float MiddleImpotantEmitterCullDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraEmitterScalabilitySettings.__PropertyOffset_MiddleImpotantEmitterCullDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraEmitterScalabilitySettings.__PropertyOffset_MiddleImpotantEmitterCullDistance) = value;
			}
		}

		// Token: 0x1700898B RID: 35211
		// (get) Token: 0x06023C86 RID: 146566 RVA: 0x0034EB59 File Offset: 0x0034CD59
		// (set) Token: 0x06023C87 RID: 146567 RVA: 0x0034EB72 File Offset: 0x0034CD72
		public unsafe bool bCullNearImpotantEmitter
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNiagaraEmitterScalabilitySettings.__PropertyOffset_bCullNearImpotantEmitter) & FNiagaraEmitterScalabilitySettings.__PropertyMask_bCullNearImpotantEmitter) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNiagaraEmitterScalabilitySettings.__PropertyOffset_bCullNearImpotantEmitter) = ((*(base.NativePtr + (IntPtr)FNiagaraEmitterScalabilitySettings.__PropertyOffset_bCullNearImpotantEmitter) & ~FNiagaraEmitterScalabilitySettings.__PropertyMask_bCullNearImpotantEmitter) | (value ? FNiagaraEmitterScalabilitySettings.__PropertyMask_bCullNearImpotantEmitter : 0));
			}
		}

		// Token: 0x1700898C RID: 35212
		// (get) Token: 0x06023C88 RID: 146568 RVA: 0x0034EBA2 File Offset: 0x0034CDA2
		// (set) Token: 0x06023C89 RID: 146569 RVA: 0x0034EBB2 File Offset: 0x0034CDB2
		public unsafe float NearImpotantEmitterCullDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraEmitterScalabilitySettings.__PropertyOffset_NearImpotantEmitterCullDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraEmitterScalabilitySettings.__PropertyOffset_NearImpotantEmitterCullDistance) = value;
			}
		}

		// Token: 0x06023C8A RID: 146570 RVA: 0x0034EBC3 File Offset: 0x0034CDC3
		public FNiagaraEmitterScalabilitySettings()
		{
		}

		// Token: 0x06023C8B RID: 146571 RVA: 0x0034EBCC File Offset: 0x0034CDCC
		public FNiagaraEmitterScalabilitySettings(FNiagaraPlatformSet Platforms, bool bScaleSpawnCount, float SpawnCountScale, bool bSpawnScaleByLodDistance, TArray<FNiagaraSystemSpawnScaleSettings> SpawnScaleByDistance, bool bCullFarImpotantEmitter, float FarImpotantEmitterCullDistance, bool bCullMiddleImpotantEmitter, float MiddleImpotantEmitterCullDistance, bool bCullNearImpotantEmitter, float NearImpotantEmitterCullDistance)
		{
			this.Platforms = Platforms;
			this.bScaleSpawnCount = bScaleSpawnCount;
			this.SpawnCountScale = SpawnCountScale;
			this.bSpawnScaleByLodDistance = bSpawnScaleByLodDistance;
			this.SpawnScaleByDistance = SpawnScaleByDistance;
			this.bCullFarImpotantEmitter = bCullFarImpotantEmitter;
			this.FarImpotantEmitterCullDistance = FarImpotantEmitterCullDistance;
			this.bCullMiddleImpotantEmitter = bCullMiddleImpotantEmitter;
			this.MiddleImpotantEmitterCullDistance = MiddleImpotantEmitterCullDistance;
			this.bCullNearImpotantEmitter = bCullNearImpotantEmitter;
			this.NearImpotantEmitterCullDistance = NearImpotantEmitterCullDistance;
		}

		// Token: 0x06023C8C RID: 146572 RVA: 0x0034EC34 File Offset: 0x0034CE34
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraEmitterScalabilitySettings.StaticStruct();
		}

		// Token: 0x06023C8D RID: 146573 RVA: 0x0034EC40 File Offset: 0x0034CE40
		[NullableContext(2)]
		public FNiagaraEmitterScalabilitySettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023C8E RID: 146574 RVA: 0x0034EC4A File Offset: 0x0034CE4A
		public FNiagaraEmitterScalabilitySettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023C8F RID: 146575 RVA: 0x0034EC55 File Offset: 0x0034CE55
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraEmitterScalabilitySettings(Pointer, false, true);
		}

		// Token: 0x06023C90 RID: 146576 RVA: 0x0034EC5F File Offset: 0x0034CE5F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraEmitterScalabilitySettings(Pointer, MemoryOwner);
		}

		// Token: 0x04013306 RID: 78598
		public const string __ObjectPath = "/Script/Niagara.NiagaraEmitterScalabilitySettings";

		// Token: 0x04013307 RID: 78599
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013308 RID: 78600
		internal static int __PropertyOffset_Platforms;

		// Token: 0x04013309 RID: 78601
		[Nullable(2)]
		private FNiagaraPlatformSet _Platforms;

		// Token: 0x0401330A RID: 78602
		internal static int __PropertyOffset_bScaleSpawnCount;

		// Token: 0x0401330B RID: 78603
		internal static byte __PropertyMask_bScaleSpawnCount;

		// Token: 0x0401330C RID: 78604
		internal static int __PropertyOffset_SpawnCountScale;

		// Token: 0x0401330D RID: 78605
		internal static int __PropertyOffset_bSpawnScaleByLodDistance;

		// Token: 0x0401330E RID: 78606
		internal static byte __PropertyMask_bSpawnScaleByLodDistance;

		// Token: 0x0401330F RID: 78607
		internal static int __PropertyOffset_SpawnScaleByDistance;

		// Token: 0x04013310 RID: 78608
		[Nullable(2)]
		private TArray<FNiagaraSystemSpawnScaleSettings> _SpawnScaleByDistance;

		// Token: 0x04013311 RID: 78609
		internal static int __PropertyOffset_bCullFarImpotantEmitter;

		// Token: 0x04013312 RID: 78610
		internal static byte __PropertyMask_bCullFarImpotantEmitter;

		// Token: 0x04013313 RID: 78611
		internal static int __PropertyOffset_FarImpotantEmitterCullDistance;

		// Token: 0x04013314 RID: 78612
		internal static int __PropertyOffset_bCullMiddleImpotantEmitter;

		// Token: 0x04013315 RID: 78613
		internal static byte __PropertyMask_bCullMiddleImpotantEmitter;

		// Token: 0x04013316 RID: 78614
		internal static int __PropertyOffset_MiddleImpotantEmitterCullDistance;

		// Token: 0x04013317 RID: 78615
		internal static int __PropertyOffset_bCullNearImpotantEmitter;

		// Token: 0x04013318 RID: 78616
		internal static byte __PropertyMask_bCullNearImpotantEmitter;

		// Token: 0x04013319 RID: 78617
		internal static int __PropertyOffset_NearImpotantEmitterCullDistance;
	}
}
