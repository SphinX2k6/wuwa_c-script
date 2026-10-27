using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F9B RID: 3995
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleRotationRate_Seeded")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UParticleModuleRotationRate_Seeded : UParticleModuleRotationRate, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D721 RID: 55073 RVA: 0x0013CFAD File Offset: 0x0013B1AD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleRotationRate_Seeded._ClassPtr;
		}

		// Token: 0x0600D722 RID: 55074 RVA: 0x0013CFBC File Offset: 0x0013B1BC
		public UParticleModuleRotationRate_Seeded() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleRotationRate_Seeded.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D723 RID: 55075 RVA: 0x0013CFE4 File Offset: 0x0013B1E4
		public UParticleModuleRotationRate_Seeded(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleRotationRate_Seeded.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003294 RID: 12948
		// (get) Token: 0x0600D724 RID: 55076 RVA: 0x0013D018 File Offset: 0x0013B218
		// (set) Token: 0x0600D725 RID: 55077 RVA: 0x0013D051 File Offset: 0x0013B251
		public FParticleRandomSeedInfo RandomSeedInfo
		{
			get
			{
				base.FastCheckIsValid();
				FParticleRandomSeedInfo result;
				if ((result = this._RandomSeedInfo) == null)
				{
					result = (this._RandomSeedInfo = new FParticleRandomSeedInfo(base.NativePtr + (IntPtr)UParticleModuleRotationRate_Seeded.__PropertyOffset_RandomSeedInfo, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FParticleRandomSeedInfo.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleRotationRate_Seeded.__PropertyOffset_RandomSeedInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600D726 RID: 55078 RVA: 0x0013D072 File Offset: 0x0013B272
		static UParticleModuleRotationRate_Seeded()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleRotationRate_Seeded");
		}

		// Token: 0x0600D727 RID: 55079 RVA: 0x0013D080 File Offset: 0x0013B280
		protected UParticleModuleRotationRate_Seeded(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400744F RID: 29775
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleRotationRate_Seeded";

		// Token: 0x04007450 RID: 29776
		private static IntPtr _ClassPtr;

		// Token: 0x04007451 RID: 29777
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007452 RID: 29778
		internal static int __PropertyOffset_RandomSeedInfo;

		// Token: 0x04007453 RID: 29779
		[Nullable(2)]
		private FParticleRandomSeedInfo _RandomSeedInfo;
	}
}
