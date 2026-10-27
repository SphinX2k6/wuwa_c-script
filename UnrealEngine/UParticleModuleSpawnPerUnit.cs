using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FA6 RID: 4006
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleSpawnPerUnit")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UParticleModuleSpawnPerUnit : UParticleModuleSpawnBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D784 RID: 55172 RVA: 0x0013DBA9 File Offset: 0x0013BDA9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleSpawnPerUnit._ClassPtr;
		}

		// Token: 0x0600D785 RID: 55173 RVA: 0x0013DBB8 File Offset: 0x0013BDB8
		public UParticleModuleSpawnPerUnit() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleSpawnPerUnit.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D786 RID: 55174 RVA: 0x0013DBE0 File Offset: 0x0013BDE0
		public UParticleModuleSpawnPerUnit(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleSpawnPerUnit.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170032AB RID: 12971
		// (get) Token: 0x0600D787 RID: 55175 RVA: 0x0013DC13 File Offset: 0x0013BE13
		// (set) Token: 0x0600D788 RID: 55176 RVA: 0x0013DC23 File Offset: 0x0013BE23
		public unsafe float UnitScalar
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleSpawnPerUnit.__PropertyOffset_UnitScalar);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleSpawnPerUnit.__PropertyOffset_UnitScalar) = value;
			}
		}

		// Token: 0x170032AC RID: 12972
		// (get) Token: 0x0600D789 RID: 55177 RVA: 0x0013DC34 File Offset: 0x0013BE34
		// (set) Token: 0x0600D78A RID: 55178 RVA: 0x0013DC44 File Offset: 0x0013BE44
		public unsafe float MovementTolerance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleSpawnPerUnit.__PropertyOffset_MovementTolerance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleSpawnPerUnit.__PropertyOffset_MovementTolerance) = value;
			}
		}

		// Token: 0x170032AD RID: 12973
		// (get) Token: 0x0600D78B RID: 55179 RVA: 0x0013DC58 File Offset: 0x0013BE58
		// (set) Token: 0x0600D78C RID: 55180 RVA: 0x0013DC91 File Offset: 0x0013BE91
		public FRawDistributionFloat SpawnPerUnit
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._SpawnPerUnit) == null)
				{
					result = (this._SpawnPerUnit = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleSpawnPerUnit.__PropertyOffset_SpawnPerUnit, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleSpawnPerUnit.__PropertyOffset_SpawnPerUnit, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170032AE RID: 12974
		// (get) Token: 0x0600D78D RID: 55181 RVA: 0x0013DCB2 File Offset: 0x0013BEB2
		// (set) Token: 0x0600D78E RID: 55182 RVA: 0x0013DCC2 File Offset: 0x0013BEC2
		public unsafe float MaxFrameDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleSpawnPerUnit.__PropertyOffset_MaxFrameDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleSpawnPerUnit.__PropertyOffset_MaxFrameDistance) = value;
			}
		}

		// Token: 0x170032AF RID: 12975
		// (get) Token: 0x0600D78F RID: 55183 RVA: 0x0013DCD3 File Offset: 0x0013BED3
		// (set) Token: 0x0600D790 RID: 55184 RVA: 0x0013DCEC File Offset: 0x0013BEEC
		public unsafe bool bIgnoreSpawnRateWhenMoving
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleSpawnPerUnit.__PropertyOffset_bIgnoreSpawnRateWhenMoving) & UParticleModuleSpawnPerUnit.__PropertyMask_bIgnoreSpawnRateWhenMoving) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleSpawnPerUnit.__PropertyOffset_bIgnoreSpawnRateWhenMoving) = ((*(base.NativePtr + (IntPtr)UParticleModuleSpawnPerUnit.__PropertyOffset_bIgnoreSpawnRateWhenMoving) & ~UParticleModuleSpawnPerUnit.__PropertyMask_bIgnoreSpawnRateWhenMoving) | (value ? UParticleModuleSpawnPerUnit.__PropertyMask_bIgnoreSpawnRateWhenMoving : 0));
			}
		}

		// Token: 0x170032B0 RID: 12976
		// (get) Token: 0x0600D791 RID: 55185 RVA: 0x0013DD1C File Offset: 0x0013BF1C
		// (set) Token: 0x0600D792 RID: 55186 RVA: 0x0013DD35 File Offset: 0x0013BF35
		public unsafe bool bIgnoreMovementAlongX
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleSpawnPerUnit.__PropertyOffset_bIgnoreMovementAlongX) & UParticleModuleSpawnPerUnit.__PropertyMask_bIgnoreMovementAlongX) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleSpawnPerUnit.__PropertyOffset_bIgnoreMovementAlongX) = ((*(base.NativePtr + (IntPtr)UParticleModuleSpawnPerUnit.__PropertyOffset_bIgnoreMovementAlongX) & ~UParticleModuleSpawnPerUnit.__PropertyMask_bIgnoreMovementAlongX) | (value ? UParticleModuleSpawnPerUnit.__PropertyMask_bIgnoreMovementAlongX : 0));
			}
		}

		// Token: 0x170032B1 RID: 12977
		// (get) Token: 0x0600D793 RID: 55187 RVA: 0x0013DD65 File Offset: 0x0013BF65
		// (set) Token: 0x0600D794 RID: 55188 RVA: 0x0013DD7E File Offset: 0x0013BF7E
		public unsafe bool bIgnoreMovementAlongY
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleSpawnPerUnit.__PropertyOffset_bIgnoreMovementAlongY) & UParticleModuleSpawnPerUnit.__PropertyMask_bIgnoreMovementAlongY) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleSpawnPerUnit.__PropertyOffset_bIgnoreMovementAlongY) = ((*(base.NativePtr + (IntPtr)UParticleModuleSpawnPerUnit.__PropertyOffset_bIgnoreMovementAlongY) & ~UParticleModuleSpawnPerUnit.__PropertyMask_bIgnoreMovementAlongY) | (value ? UParticleModuleSpawnPerUnit.__PropertyMask_bIgnoreMovementAlongY : 0));
			}
		}

		// Token: 0x170032B2 RID: 12978
		// (get) Token: 0x0600D795 RID: 55189 RVA: 0x0013DDAE File Offset: 0x0013BFAE
		// (set) Token: 0x0600D796 RID: 55190 RVA: 0x0013DDC7 File Offset: 0x0013BFC7
		public unsafe bool bIgnoreMovementAlongZ
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleSpawnPerUnit.__PropertyOffset_bIgnoreMovementAlongZ) & UParticleModuleSpawnPerUnit.__PropertyMask_bIgnoreMovementAlongZ) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleSpawnPerUnit.__PropertyOffset_bIgnoreMovementAlongZ) = ((*(base.NativePtr + (IntPtr)UParticleModuleSpawnPerUnit.__PropertyOffset_bIgnoreMovementAlongZ) & ~UParticleModuleSpawnPerUnit.__PropertyMask_bIgnoreMovementAlongZ) | (value ? UParticleModuleSpawnPerUnit.__PropertyMask_bIgnoreMovementAlongZ : 0));
			}
		}

		// Token: 0x0600D797 RID: 55191 RVA: 0x0013DDF7 File Offset: 0x0013BFF7
		static UParticleModuleSpawnPerUnit()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleSpawnPerUnit");
		}

		// Token: 0x0600D798 RID: 55192 RVA: 0x0013DE05 File Offset: 0x0013C005
		protected UParticleModuleSpawnPerUnit(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400749B RID: 29851
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleSpawnPerUnit";

		// Token: 0x0400749C RID: 29852
		private static IntPtr _ClassPtr;

		// Token: 0x0400749D RID: 29853
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400749E RID: 29854
		internal static int __PropertyOffset_UnitScalar;

		// Token: 0x0400749F RID: 29855
		internal static int __PropertyOffset_MovementTolerance;

		// Token: 0x040074A0 RID: 29856
		internal static int __PropertyOffset_SpawnPerUnit;

		// Token: 0x040074A1 RID: 29857
		[Nullable(2)]
		private FRawDistributionFloat _SpawnPerUnit;

		// Token: 0x040074A2 RID: 29858
		internal static int __PropertyOffset_MaxFrameDistance;

		// Token: 0x040074A3 RID: 29859
		internal static int __PropertyOffset_bIgnoreSpawnRateWhenMoving;

		// Token: 0x040074A4 RID: 29860
		internal static byte __PropertyMask_bIgnoreSpawnRateWhenMoving;

		// Token: 0x040074A5 RID: 29861
		internal static int __PropertyOffset_bIgnoreMovementAlongX;

		// Token: 0x040074A6 RID: 29862
		internal static byte __PropertyMask_bIgnoreMovementAlongX;

		// Token: 0x040074A7 RID: 29863
		internal static int __PropertyOffset_bIgnoreMovementAlongY;

		// Token: 0x040074A8 RID: 29864
		internal static byte __PropertyMask_bIgnoreMovementAlongY;

		// Token: 0x040074A9 RID: 29865
		internal static int __PropertyOffset_bIgnoreMovementAlongZ;

		// Token: 0x040074AA RID: 29866
		internal static byte __PropertyMask_bIgnoreMovementAlongZ;
	}
}
