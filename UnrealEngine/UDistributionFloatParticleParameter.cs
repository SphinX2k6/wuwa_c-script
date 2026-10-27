using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020009CB RID: 2507
	[UnrealObjectPath("/Script/Engine.DistributionFloatParticleParameter")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UDistributionFloatParticleParameter : UDistributionFloatParameterBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008DE9 RID: 36329 RVA: 0x000CAD7D File Offset: 0x000C8F7D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDistributionFloatParticleParameter._ClassPtr;
		}

		// Token: 0x06008DEA RID: 36330 RVA: 0x000CAD8C File Offset: 0x000C8F8C
		public UDistributionFloatParticleParameter() : this(BuiltinUtils.AllocNativeUObject(UDistributionFloatParticleParameter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008DEB RID: 36331 RVA: 0x000CADB4 File Offset: 0x000C8FB4
		[NullableContext(1)]
		public UDistributionFloatParticleParameter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDistributionFloatParticleParameter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06008DEC RID: 36332 RVA: 0x000CADE7 File Offset: 0x000C8FE7
		static UDistributionFloatParticleParameter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DistributionFloatParticleParameter");
		}

		// Token: 0x06008DED RID: 36333 RVA: 0x000CADF5 File Offset: 0x000C8FF5
		protected UDistributionFloatParticleParameter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004361 RID: 17249
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.DistributionFloatParticleParameter";

		// Token: 0x04004362 RID: 17250
		private static IntPtr _ClassPtr;

		// Token: 0x04004363 RID: 17251
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
