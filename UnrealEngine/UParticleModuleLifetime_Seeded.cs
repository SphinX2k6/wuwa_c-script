using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F70 RID: 3952
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleLifetime_Seeded")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UParticleModuleLifetime_Seeded : UParticleModuleLifetime, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D526 RID: 54566 RVA: 0x001396A5 File Offset: 0x001378A5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleLifetime_Seeded._ClassPtr;
		}

		// Token: 0x0600D527 RID: 54567 RVA: 0x001396B4 File Offset: 0x001378B4
		public UParticleModuleLifetime_Seeded() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleLifetime_Seeded.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D528 RID: 54568 RVA: 0x001396DC File Offset: 0x001378DC
		public UParticleModuleLifetime_Seeded(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleLifetime_Seeded.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170031FE RID: 12798
		// (get) Token: 0x0600D529 RID: 54569 RVA: 0x00139710 File Offset: 0x00137910
		// (set) Token: 0x0600D52A RID: 54570 RVA: 0x00139749 File Offset: 0x00137949
		public FParticleRandomSeedInfo RandomSeedInfo
		{
			get
			{
				base.FastCheckIsValid();
				FParticleRandomSeedInfo result;
				if ((result = this._RandomSeedInfo) == null)
				{
					result = (this._RandomSeedInfo = new FParticleRandomSeedInfo(base.NativePtr + (IntPtr)UParticleModuleLifetime_Seeded.__PropertyOffset_RandomSeedInfo, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FParticleRandomSeedInfo.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleLifetime_Seeded.__PropertyOffset_RandomSeedInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600D52B RID: 54571 RVA: 0x0013976A File Offset: 0x0013796A
		static UParticleModuleLifetime_Seeded()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleLifetime_Seeded");
		}

		// Token: 0x0600D52C RID: 54572 RVA: 0x00139778 File Offset: 0x00137978
		protected UParticleModuleLifetime_Seeded(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040072E0 RID: 29408
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleLifetime_Seeded";

		// Token: 0x040072E1 RID: 29409
		private static IntPtr _ClassPtr;

		// Token: 0x040072E2 RID: 29410
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040072E3 RID: 29411
		internal static int __PropertyOffset_RandomSeedInfo;

		// Token: 0x040072E4 RID: 29412
		[Nullable(2)]
		private FParticleRandomSeedInfo _RandomSeedInfo;
	}
}
