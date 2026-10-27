using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FA2 RID: 4002
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleSize_Seeded")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class UParticleModuleSize_Seeded : UParticleModuleSize, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D75D RID: 55133 RVA: 0x0013D6C8 File Offset: 0x0013B8C8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleSize_Seeded._ClassPtr;
		}

		// Token: 0x0600D75E RID: 55134 RVA: 0x0013D6D4 File Offset: 0x0013B8D4
		public UParticleModuleSize_Seeded() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleSize_Seeded.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D75F RID: 55135 RVA: 0x0013D6FC File Offset: 0x0013B8FC
		public UParticleModuleSize_Seeded(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleSize_Seeded.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170032A1 RID: 12961
		// (get) Token: 0x0600D760 RID: 55136 RVA: 0x0013D730 File Offset: 0x0013B930
		// (set) Token: 0x0600D761 RID: 55137 RVA: 0x0013D769 File Offset: 0x0013B969
		public FParticleRandomSeedInfo RandomSeedInfo
		{
			get
			{
				base.FastCheckIsValid();
				FParticleRandomSeedInfo result;
				if ((result = this._RandomSeedInfo) == null)
				{
					result = (this._RandomSeedInfo = new FParticleRandomSeedInfo(base.NativePtr + (IntPtr)UParticleModuleSize_Seeded.__PropertyOffset_RandomSeedInfo, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FParticleRandomSeedInfo.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleSize_Seeded.__PropertyOffset_RandomSeedInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600D762 RID: 55138 RVA: 0x0013D78A File Offset: 0x0013B98A
		static UParticleModuleSize_Seeded()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleSize_Seeded");
		}

		// Token: 0x0600D763 RID: 55139 RVA: 0x0013D798 File Offset: 0x0013B998
		protected UParticleModuleSize_Seeded(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400747C RID: 29820
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleSize_Seeded";

		// Token: 0x0400747D RID: 29821
		private static IntPtr _ClassPtr;

		// Token: 0x0400747E RID: 29822
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400747F RID: 29823
		internal static int __PropertyOffset_RandomSeedInfo;

		// Token: 0x04007480 RID: 29824
		[Nullable(2)]
		private FParticleRandomSeedInfo _RandomSeedInfo;
	}
}
