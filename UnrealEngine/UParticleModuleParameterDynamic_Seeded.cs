using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F92 RID: 3986
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleParameterDynamic_Seeded")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UParticleModuleParameterDynamic_Seeded : UParticleModuleParameterDynamic, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D68E RID: 54926 RVA: 0x0013C08C File Offset: 0x0013A28C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleParameterDynamic_Seeded._ClassPtr;
		}

		// Token: 0x0600D68F RID: 54927 RVA: 0x0013C098 File Offset: 0x0013A298
		public UParticleModuleParameterDynamic_Seeded() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleParameterDynamic_Seeded.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D690 RID: 54928 RVA: 0x0013C0C0 File Offset: 0x0013A2C0
		public UParticleModuleParameterDynamic_Seeded(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleParameterDynamic_Seeded.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003260 RID: 12896
		// (get) Token: 0x0600D691 RID: 54929 RVA: 0x0013C0F4 File Offset: 0x0013A2F4
		// (set) Token: 0x0600D692 RID: 54930 RVA: 0x0013C12D File Offset: 0x0013A32D
		public FParticleRandomSeedInfo RandomSeedInfo
		{
			get
			{
				base.FastCheckIsValid();
				FParticleRandomSeedInfo result;
				if ((result = this._RandomSeedInfo) == null)
				{
					result = (this._RandomSeedInfo = new FParticleRandomSeedInfo(base.NativePtr + (IntPtr)UParticleModuleParameterDynamic_Seeded.__PropertyOffset_RandomSeedInfo, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FParticleRandomSeedInfo.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleParameterDynamic_Seeded.__PropertyOffset_RandomSeedInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600D693 RID: 54931 RVA: 0x0013C14E File Offset: 0x0013A34E
		static UParticleModuleParameterDynamic_Seeded()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleParameterDynamic_Seeded");
		}

		// Token: 0x0600D694 RID: 54932 RVA: 0x0013C15C File Offset: 0x0013A35C
		protected UParticleModuleParameterDynamic_Seeded(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040073EA RID: 29674
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleParameterDynamic_Seeded";

		// Token: 0x040073EB RID: 29675
		private static IntPtr _ClassPtr;

		// Token: 0x040073EC RID: 29676
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040073ED RID: 29677
		internal static int __PropertyOffset_RandomSeedInfo;

		// Token: 0x040073EE RID: 29678
		[Nullable(2)]
		private FParticleRandomSeedInfo _RandomSeedInfo;
	}
}
