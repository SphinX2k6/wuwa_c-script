using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FA4 RID: 4004
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleSpawn")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UParticleModuleSpawn : UParticleModuleSpawnBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D76B RID: 55147 RVA: 0x0013D87D File Offset: 0x0013BA7D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleSpawn._ClassPtr;
		}

		// Token: 0x0600D76C RID: 55148 RVA: 0x0013D88C File Offset: 0x0013BA8C
		public UParticleModuleSpawn() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleSpawn.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D76D RID: 55149 RVA: 0x0013D8B4 File Offset: 0x0013BAB4
		public UParticleModuleSpawn(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleSpawn.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170032A3 RID: 12963
		// (get) Token: 0x0600D76E RID: 55150 RVA: 0x0013D8E8 File Offset: 0x0013BAE8
		// (set) Token: 0x0600D76F RID: 55151 RVA: 0x0013D921 File Offset: 0x0013BB21
		public FRawDistributionFloat Rate
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._Rate) == null)
				{
					result = (this._Rate = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleSpawn.__PropertyOffset_Rate, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleSpawn.__PropertyOffset_Rate, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170032A4 RID: 12964
		// (get) Token: 0x0600D770 RID: 55152 RVA: 0x0013D944 File Offset: 0x0013BB44
		// (set) Token: 0x0600D771 RID: 55153 RVA: 0x0013D97D File Offset: 0x0013BB7D
		public FRawDistributionFloat RateScale
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._RateScale) == null)
				{
					result = (this._RateScale = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleSpawn.__PropertyOffset_RateScale, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleSpawn.__PropertyOffset_RateScale, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170032A5 RID: 12965
		// (get) Token: 0x0600D772 RID: 55154 RVA: 0x0013D99E File Offset: 0x0013BB9E
		// (set) Token: 0x0600D773 RID: 55155 RVA: 0x0013D9B2 File Offset: 0x0013BBB2
		[Nullable(0)]
		public unsafe TEnumAsByte<EParticleBurstMethod> ParticleBurstMethod
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleSpawn.__PropertyOffset_ParticleBurstMethod);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleSpawn.__PropertyOffset_ParticleBurstMethod) = value;
			}
		}

		// Token: 0x170032A6 RID: 12966
		// (get) Token: 0x0600D774 RID: 55156 RVA: 0x0013D9C8 File Offset: 0x0013BBC8
		// (set) Token: 0x0600D775 RID: 55157 RVA: 0x0013DA01 File Offset: 0x0013BC01
		public TArray<FParticleBurst> BurstList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FParticleBurst> result;
				if ((result = this._BurstList) == null)
				{
					result = (this._BurstList = new TArray<FParticleBurst>(base.NativePtr + (IntPtr)UParticleModuleSpawn.__PropertyOffset_BurstList, this));
				}
				return result;
			}
			set
			{
				this.BurstList.CopyAssign(value);
			}
		}

		// Token: 0x170032A7 RID: 12967
		// (get) Token: 0x0600D776 RID: 55158 RVA: 0x0013DA10 File Offset: 0x0013BC10
		// (set) Token: 0x0600D777 RID: 55159 RVA: 0x0013DA49 File Offset: 0x0013BC49
		public FRawDistributionFloat BurstScale
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._BurstScale) == null)
				{
					result = (this._BurstScale = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleSpawn.__PropertyOffset_BurstScale, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleSpawn.__PropertyOffset_BurstScale, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170032A8 RID: 12968
		// (get) Token: 0x0600D778 RID: 55160 RVA: 0x0013DA6A File Offset: 0x0013BC6A
		// (set) Token: 0x0600D779 RID: 55161 RVA: 0x0013DA83 File Offset: 0x0013BC83
		public unsafe bool bApplyGlobalSpawnRateScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleSpawn.__PropertyOffset_bApplyGlobalSpawnRateScale) & UParticleModuleSpawn.__PropertyMask_bApplyGlobalSpawnRateScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleSpawn.__PropertyOffset_bApplyGlobalSpawnRateScale) = ((*(base.NativePtr + (IntPtr)UParticleModuleSpawn.__PropertyOffset_bApplyGlobalSpawnRateScale) & ~UParticleModuleSpawn.__PropertyMask_bApplyGlobalSpawnRateScale) | (value ? UParticleModuleSpawn.__PropertyMask_bApplyGlobalSpawnRateScale : 0));
			}
		}

		// Token: 0x0600D77A RID: 55162 RVA: 0x0013DAB3 File Offset: 0x0013BCB3
		static UParticleModuleSpawn()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleSpawn");
		}

		// Token: 0x0600D77B RID: 55163 RVA: 0x0013DAC1 File Offset: 0x0013BCC1
		protected UParticleModuleSpawn(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007486 RID: 29830
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleSpawn";

		// Token: 0x04007487 RID: 29831
		private static IntPtr _ClassPtr;

		// Token: 0x04007488 RID: 29832
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007489 RID: 29833
		internal static int __PropertyOffset_Rate;

		// Token: 0x0400748A RID: 29834
		[Nullable(2)]
		private FRawDistributionFloat _Rate;

		// Token: 0x0400748B RID: 29835
		internal static int __PropertyOffset_RateScale;

		// Token: 0x0400748C RID: 29836
		[Nullable(2)]
		private FRawDistributionFloat _RateScale;

		// Token: 0x0400748D RID: 29837
		internal static int __PropertyOffset_ParticleBurstMethod;

		// Token: 0x0400748E RID: 29838
		internal static int __PropertyOffset_BurstList;

		// Token: 0x0400748F RID: 29839
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FParticleBurst> _BurstList;

		// Token: 0x04007490 RID: 29840
		internal static int __PropertyOffset_BurstScale;

		// Token: 0x04007491 RID: 29841
		[Nullable(2)]
		private FRawDistributionFloat _BurstScale;

		// Token: 0x04007492 RID: 29842
		internal static int __PropertyOffset_bApplyGlobalSpawnRateScale;

		// Token: 0x04007493 RID: 29843
		internal static byte __PropertyMask_bApplyGlobalSpawnRateScale;
	}
}
