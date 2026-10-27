using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FBE RID: 4030
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleVelocity_Seeded")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 216)]
	public class UParticleModuleVelocity_Seeded : UParticleModuleVelocity, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D8E5 RID: 55525 RVA: 0x0014024E File Offset: 0x0013E44E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleVelocity_Seeded._ClassPtr;
		}

		// Token: 0x0600D8E6 RID: 55526 RVA: 0x0014025C File Offset: 0x0013E45C
		public UParticleModuleVelocity_Seeded() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleVelocity_Seeded.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D8E7 RID: 55527 RVA: 0x00140284 File Offset: 0x0013E484
		public UParticleModuleVelocity_Seeded(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleVelocity_Seeded.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003322 RID: 13090
		// (get) Token: 0x0600D8E8 RID: 55528 RVA: 0x001402B8 File Offset: 0x0013E4B8
		// (set) Token: 0x0600D8E9 RID: 55529 RVA: 0x001402F1 File Offset: 0x0013E4F1
		public FParticleRandomSeedInfo RandomSeedInfo
		{
			get
			{
				base.FastCheckIsValid();
				FParticleRandomSeedInfo result;
				if ((result = this._RandomSeedInfo) == null)
				{
					result = (this._RandomSeedInfo = new FParticleRandomSeedInfo(base.NativePtr + (IntPtr)UParticleModuleVelocity_Seeded.__PropertyOffset_RandomSeedInfo, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FParticleRandomSeedInfo.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleVelocity_Seeded.__PropertyOffset_RandomSeedInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600D8EA RID: 55530 RVA: 0x00140312 File Offset: 0x0013E512
		static UParticleModuleVelocity_Seeded()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleVelocity_Seeded");
		}

		// Token: 0x0600D8EB RID: 55531 RVA: 0x00140320 File Offset: 0x0013E520
		protected UParticleModuleVelocity_Seeded(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400759C RID: 30108
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleVelocity_Seeded";

		// Token: 0x0400759D RID: 30109
		private static IntPtr _ClassPtr;

		// Token: 0x0400759E RID: 30110
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400759F RID: 30111
		internal static int __PropertyOffset_RandomSeedInfo;

		// Token: 0x040075A0 RID: 30112
		[Nullable(2)]
		private FParticleRandomSeedInfo _RandomSeedInfo;
	}
}
