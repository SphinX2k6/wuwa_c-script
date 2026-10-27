using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F45 RID: 3909
	[UnrealObjectPath("/Script/Engine.ParticleEmitter")]
	[UnrealStructLayout(488, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 488)]
	public abstract class UParticleEmitter : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D2C9 RID: 53961 RVA: 0x00134F87 File Offset: 0x00133187
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleEmitter._ClassPtr;
		}

		// Token: 0x17003137 RID: 12599
		// (get) Token: 0x0600D2CA RID: 53962 RVA: 0x00134F93 File Offset: 0x00133193
		// (set) Token: 0x0600D2CB RID: 53963 RVA: 0x00134FA7 File Offset: 0x001331A7
		public unsafe FName EmitterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleEmitter.__PropertyOffset_EmitterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleEmitter.__PropertyOffset_EmitterName) = value;
			}
		}

		// Token: 0x17003138 RID: 12600
		// (get) Token: 0x0600D2CC RID: 53964 RVA: 0x00134FBC File Offset: 0x001331BC
		// (set) Token: 0x0600D2CD RID: 53965 RVA: 0x00134FCC File Offset: 0x001331CC
		public unsafe int SubUVDataOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleEmitter.__PropertyOffset_SubUVDataOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleEmitter.__PropertyOffset_SubUVDataOffset) = value;
			}
		}

		// Token: 0x17003139 RID: 12601
		// (get) Token: 0x0600D2CE RID: 53966 RVA: 0x00134FDD File Offset: 0x001331DD
		// (set) Token: 0x0600D2CF RID: 53967 RVA: 0x00134FF1 File Offset: 0x001331F1
		public unsafe TEnumAsByte<EEmitterRenderMode> EmitterRenderMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleEmitter.__PropertyOffset_EmitterRenderMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleEmitter.__PropertyOffset_EmitterRenderMode) = value;
			}
		}

		// Token: 0x1700313A RID: 12602
		// (get) Token: 0x0600D2D0 RID: 53968 RVA: 0x00135006 File Offset: 0x00133206
		// (set) Token: 0x0600D2D1 RID: 53969 RVA: 0x00135016 File Offset: 0x00133216
		public unsafe EParticleSignificanceLevel SignificanceLevel
		{
			get
			{
				return (EParticleSignificanceLevel)(*(base.NativePtr + (IntPtr)UParticleEmitter.__PropertyOffset_SignificanceLevel));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleEmitter.__PropertyOffset_SignificanceLevel) = (byte)value;
			}
		}

		// Token: 0x1700313B RID: 12603
		// (get) Token: 0x0600D2D2 RID: 53970 RVA: 0x00135027 File Offset: 0x00133227
		// (set) Token: 0x0600D2D3 RID: 53971 RVA: 0x00135040 File Offset: 0x00133240
		public unsafe bool bUseLegacySpawningBehavior
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleEmitter.__PropertyOffset_bUseLegacySpawningBehavior) & UParticleEmitter.__PropertyMask_bUseLegacySpawningBehavior) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleEmitter.__PropertyOffset_bUseLegacySpawningBehavior) = ((*(base.NativePtr + (IntPtr)UParticleEmitter.__PropertyOffset_bUseLegacySpawningBehavior) & ~UParticleEmitter.__PropertyMask_bUseLegacySpawningBehavior) | (value ? UParticleEmitter.__PropertyMask_bUseLegacySpawningBehavior : 0));
			}
		}

		// Token: 0x1700313C RID: 12604
		// (get) Token: 0x0600D2D4 RID: 53972 RVA: 0x00135070 File Offset: 0x00133270
		// (set) Token: 0x0600D2D5 RID: 53973 RVA: 0x00135089 File Offset: 0x00133289
		public unsafe bool ConvertedModules
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleEmitter.__PropertyOffset_ConvertedModules) & UParticleEmitter.__PropertyMask_ConvertedModules) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleEmitter.__PropertyOffset_ConvertedModules) = ((*(base.NativePtr + (IntPtr)UParticleEmitter.__PropertyOffset_ConvertedModules) & ~UParticleEmitter.__PropertyMask_ConvertedModules) | (value ? UParticleEmitter.__PropertyMask_ConvertedModules : 0));
			}
		}

		// Token: 0x1700313D RID: 12605
		// (get) Token: 0x0600D2D6 RID: 53974 RVA: 0x001350B9 File Offset: 0x001332B9
		// (set) Token: 0x0600D2D7 RID: 53975 RVA: 0x001350D2 File Offset: 0x001332D2
		public unsafe bool bIsSoloing
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleEmitter.__PropertyOffset_bIsSoloing) & UParticleEmitter.__PropertyMask_bIsSoloing) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleEmitter.__PropertyOffset_bIsSoloing) = ((*(base.NativePtr + (IntPtr)UParticleEmitter.__PropertyOffset_bIsSoloing) & ~UParticleEmitter.__PropertyMask_bIsSoloing) | (value ? UParticleEmitter.__PropertyMask_bIsSoloing : 0));
			}
		}

		// Token: 0x1700313E RID: 12606
		// (get) Token: 0x0600D2D8 RID: 53976 RVA: 0x00135102 File Offset: 0x00133302
		// (set) Token: 0x0600D2D9 RID: 53977 RVA: 0x0013511B File Offset: 0x0013331B
		public unsafe bool bCookedOut
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleEmitter.__PropertyOffset_bCookedOut) & UParticleEmitter.__PropertyMask_bCookedOut) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleEmitter.__PropertyOffset_bCookedOut) = ((*(base.NativePtr + (IntPtr)UParticleEmitter.__PropertyOffset_bCookedOut) & ~UParticleEmitter.__PropertyMask_bCookedOut) | (value ? UParticleEmitter.__PropertyMask_bCookedOut : 0));
			}
		}

		// Token: 0x1700313F RID: 12607
		// (get) Token: 0x0600D2DA RID: 53978 RVA: 0x0013514B File Offset: 0x0013334B
		// (set) Token: 0x0600D2DB RID: 53979 RVA: 0x00135164 File Offset: 0x00133364
		public unsafe bool bDisabledLODsKeepEmitterAlive
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleEmitter.__PropertyOffset_bDisabledLODsKeepEmitterAlive) & UParticleEmitter.__PropertyMask_bDisabledLODsKeepEmitterAlive) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleEmitter.__PropertyOffset_bDisabledLODsKeepEmitterAlive) = ((*(base.NativePtr + (IntPtr)UParticleEmitter.__PropertyOffset_bDisabledLODsKeepEmitterAlive) & ~UParticleEmitter.__PropertyMask_bDisabledLODsKeepEmitterAlive) | (value ? UParticleEmitter.__PropertyMask_bDisabledLODsKeepEmitterAlive : 0));
			}
		}

		// Token: 0x17003140 RID: 12608
		// (get) Token: 0x0600D2DC RID: 53980 RVA: 0x00135194 File Offset: 0x00133394
		// (set) Token: 0x0600D2DD RID: 53981 RVA: 0x001351AD File Offset: 0x001333AD
		public unsafe bool bDisableWhenInsignficant
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleEmitter.__PropertyOffset_bDisableWhenInsignficant) & UParticleEmitter.__PropertyMask_bDisableWhenInsignficant) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleEmitter.__PropertyOffset_bDisableWhenInsignficant) = ((*(base.NativePtr + (IntPtr)UParticleEmitter.__PropertyOffset_bDisableWhenInsignficant) & ~UParticleEmitter.__PropertyMask_bDisableWhenInsignficant) | (value ? UParticleEmitter.__PropertyMask_bDisableWhenInsignficant : 0));
			}
		}

		// Token: 0x17003141 RID: 12609
		// (get) Token: 0x0600D2DE RID: 53982 RVA: 0x001351E0 File Offset: 0x001333E0
		// (set) Token: 0x0600D2DF RID: 53983 RVA: 0x00135219 File Offset: 0x00133419
		[Nullable(1)]
		public TArray<UParticleLODLevel> LODLevels
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UParticleLODLevel> result;
				if ((result = this._LODLevels) == null)
				{
					result = (this._LODLevels = new TArray<UParticleLODLevel>(base.NativePtr + (IntPtr)UParticleEmitter.__PropertyOffset_LODLevels, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.LODLevels.CopyAssign(value);
			}
		}

		// Token: 0x17003142 RID: 12610
		// (get) Token: 0x0600D2E0 RID: 53984 RVA: 0x00135227 File Offset: 0x00133427
		// (set) Token: 0x0600D2E1 RID: 53985 RVA: 0x00135237 File Offset: 0x00133437
		public unsafe int PeakActiveParticles
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleEmitter.__PropertyOffset_PeakActiveParticles);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleEmitter.__PropertyOffset_PeakActiveParticles) = value;
			}
		}

		// Token: 0x17003143 RID: 12611
		// (get) Token: 0x0600D2E2 RID: 53986 RVA: 0x00135248 File Offset: 0x00133448
		// (set) Token: 0x0600D2E3 RID: 53987 RVA: 0x00135258 File Offset: 0x00133458
		public unsafe int InitialAllocationCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleEmitter.__PropertyOffset_InitialAllocationCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleEmitter.__PropertyOffset_InitialAllocationCount) = value;
			}
		}

		// Token: 0x17003144 RID: 12612
		// (get) Token: 0x0600D2E4 RID: 53988 RVA: 0x00135269 File Offset: 0x00133469
		// (set) Token: 0x0600D2E5 RID: 53989 RVA: 0x00135279 File Offset: 0x00133479
		public unsafe float QualityLevelSpawnRateScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleEmitter.__PropertyOffset_QualityLevelSpawnRateScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleEmitter.__PropertyOffset_QualityLevelSpawnRateScale) = value;
			}
		}

		// Token: 0x17003145 RID: 12613
		// (get) Token: 0x0600D2E6 RID: 53990 RVA: 0x0013528A File Offset: 0x0013348A
		// (set) Token: 0x0600D2E7 RID: 53991 RVA: 0x0013529A File Offset: 0x0013349A
		public unsafe uint DetailModeBitmask
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleEmitter.__PropertyOffset_DetailModeBitmask);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleEmitter.__PropertyOffset_DetailModeBitmask) = (int)value;
			}
		}

		// Token: 0x0600D2E8 RID: 53992 RVA: 0x001352AB File Offset: 0x001334AB
		static UParticleEmitter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleEmitter");
		}

		// Token: 0x0600D2E9 RID: 53993 RVA: 0x001352BC File Offset: 0x001334BC
		protected UParticleEmitter() : this(BuiltinUtils.AllocNativeUObject(UParticleEmitter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D2EA RID: 53994 RVA: 0x001352E4 File Offset: 0x001334E4
		protected UParticleEmitter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400710E RID: 28942
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ParticleEmitter";

		// Token: 0x0400710F RID: 28943
		private static IntPtr _ClassPtr;

		// Token: 0x04007110 RID: 28944
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007111 RID: 28945
		internal static int __PropertyOffset_EmitterName;

		// Token: 0x04007112 RID: 28946
		internal static int __PropertyOffset_SubUVDataOffset;

		// Token: 0x04007113 RID: 28947
		internal static int __PropertyOffset_EmitterRenderMode;

		// Token: 0x04007114 RID: 28948
		internal static int __PropertyOffset_SignificanceLevel;

		// Token: 0x04007115 RID: 28949
		internal static int __PropertyOffset_bUseLegacySpawningBehavior;

		// Token: 0x04007116 RID: 28950
		internal static byte __PropertyMask_bUseLegacySpawningBehavior;

		// Token: 0x04007117 RID: 28951
		internal static int __PropertyOffset_ConvertedModules;

		// Token: 0x04007118 RID: 28952
		internal static byte __PropertyMask_ConvertedModules;

		// Token: 0x04007119 RID: 28953
		internal static int __PropertyOffset_bIsSoloing;

		// Token: 0x0400711A RID: 28954
		internal static byte __PropertyMask_bIsSoloing;

		// Token: 0x0400711B RID: 28955
		internal static int __PropertyOffset_bCookedOut;

		// Token: 0x0400711C RID: 28956
		internal static byte __PropertyMask_bCookedOut;

		// Token: 0x0400711D RID: 28957
		internal static int __PropertyOffset_bDisabledLODsKeepEmitterAlive;

		// Token: 0x0400711E RID: 28958
		internal static byte __PropertyMask_bDisabledLODsKeepEmitterAlive;

		// Token: 0x0400711F RID: 28959
		internal static int __PropertyOffset_bDisableWhenInsignficant;

		// Token: 0x04007120 RID: 28960
		internal static byte __PropertyMask_bDisableWhenInsignficant;

		// Token: 0x04007121 RID: 28961
		internal static int __PropertyOffset_LODLevels;

		// Token: 0x04007122 RID: 28962
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UParticleLODLevel> _LODLevels;

		// Token: 0x04007123 RID: 28963
		internal static int __PropertyOffset_PeakActiveParticles;

		// Token: 0x04007124 RID: 28964
		internal static int __PropertyOffset_InitialAllocationCount;

		// Token: 0x04007125 RID: 28965
		internal static int __PropertyOffset_QualityLevelSpawnRateScale;

		// Token: 0x04007126 RID: 28966
		internal static int __PropertyOffset_DetailModeBitmask;
	}
}
