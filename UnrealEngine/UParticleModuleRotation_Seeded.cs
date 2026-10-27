using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F9C RID: 3996
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleRotation_Seeded")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UParticleModuleRotation_Seeded : UParticleModuleRotation, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D728 RID: 55080 RVA: 0x0013D089 File Offset: 0x0013B289
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleRotation_Seeded._ClassPtr;
		}

		// Token: 0x0600D729 RID: 55081 RVA: 0x0013D098 File Offset: 0x0013B298
		public UParticleModuleRotation_Seeded() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleRotation_Seeded.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D72A RID: 55082 RVA: 0x0013D0C0 File Offset: 0x0013B2C0
		public UParticleModuleRotation_Seeded(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleRotation_Seeded.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003295 RID: 12949
		// (get) Token: 0x0600D72B RID: 55083 RVA: 0x0013D0F4 File Offset: 0x0013B2F4
		// (set) Token: 0x0600D72C RID: 55084 RVA: 0x0013D12D File Offset: 0x0013B32D
		public FParticleRandomSeedInfo RandomSeedInfo
		{
			get
			{
				base.FastCheckIsValid();
				FParticleRandomSeedInfo result;
				if ((result = this._RandomSeedInfo) == null)
				{
					result = (this._RandomSeedInfo = new FParticleRandomSeedInfo(base.NativePtr + (IntPtr)UParticleModuleRotation_Seeded.__PropertyOffset_RandomSeedInfo, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FParticleRandomSeedInfo.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleRotation_Seeded.__PropertyOffset_RandomSeedInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600D72D RID: 55085 RVA: 0x0013D14E File Offset: 0x0013B34E
		static UParticleModuleRotation_Seeded()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleRotation_Seeded");
		}

		// Token: 0x0600D72E RID: 55086 RVA: 0x0013D15C File Offset: 0x0013B35C
		protected UParticleModuleRotation_Seeded(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007454 RID: 29780
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleRotation_Seeded";

		// Token: 0x04007455 RID: 29781
		private static IntPtr _ClassPtr;

		// Token: 0x04007456 RID: 29782
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007457 RID: 29783
		internal static int __PropertyOffset_RandomSeedInfo;

		// Token: 0x04007458 RID: 29784
		[Nullable(2)]
		private FParticleRandomSeedInfo _RandomSeedInfo;
	}
}
