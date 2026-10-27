using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F82 RID: 3970
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleLocationWorldOffset_Seeded")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 168)]
	public class UParticleModuleLocationWorldOffset_Seeded : UParticleModuleLocationWorldOffset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D614 RID: 54804 RVA: 0x0013B22E File Offset: 0x0013942E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleLocationWorldOffset_Seeded._ClassPtr;
		}

		// Token: 0x0600D615 RID: 54805 RVA: 0x0013B23C File Offset: 0x0013943C
		public UParticleModuleLocationWorldOffset_Seeded() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleLocationWorldOffset_Seeded.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D616 RID: 54806 RVA: 0x0013B264 File Offset: 0x00139464
		public UParticleModuleLocationWorldOffset_Seeded(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleLocationWorldOffset_Seeded.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003249 RID: 12873
		// (get) Token: 0x0600D617 RID: 54807 RVA: 0x0013B298 File Offset: 0x00139498
		// (set) Token: 0x0600D618 RID: 54808 RVA: 0x0013B2D1 File Offset: 0x001394D1
		public FParticleRandomSeedInfo RandomSeedInfo
		{
			get
			{
				base.FastCheckIsValid();
				FParticleRandomSeedInfo result;
				if ((result = this._RandomSeedInfo) == null)
				{
					result = (this._RandomSeedInfo = new FParticleRandomSeedInfo(base.NativePtr + (IntPtr)UParticleModuleLocationWorldOffset_Seeded.__PropertyOffset_RandomSeedInfo, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FParticleRandomSeedInfo.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleLocationWorldOffset_Seeded.__PropertyOffset_RandomSeedInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600D619 RID: 54809 RVA: 0x0013B2F2 File Offset: 0x001394F2
		static UParticleModuleLocationWorldOffset_Seeded()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleLocationWorldOffset_Seeded");
		}

		// Token: 0x0600D61A RID: 54810 RVA: 0x0013B300 File Offset: 0x00139500
		protected UParticleModuleLocationWorldOffset_Seeded(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400738F RID: 29583
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleLocationWorldOffset_Seeded";

		// Token: 0x04007390 RID: 29584
		private static IntPtr _ClassPtr;

		// Token: 0x04007391 RID: 29585
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007392 RID: 29586
		internal static int __PropertyOffset_RandomSeedInfo;

		// Token: 0x04007393 RID: 29587
		[Nullable(2)]
		private FParticleRandomSeedInfo _RandomSeedInfo;
	}
}
