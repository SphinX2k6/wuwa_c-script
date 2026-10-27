using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020009D4 RID: 2516
	[UnrealObjectPath("/Script/Engine.DistributionVectorParticleParameter")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UDistributionVectorParticleParameter : UDistributionVectorParameterBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008E46 RID: 36422 RVA: 0x000CB679 File Offset: 0x000C9879
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDistributionVectorParticleParameter._ClassPtr;
		}

		// Token: 0x06008E47 RID: 36423 RVA: 0x000CB688 File Offset: 0x000C9888
		public UDistributionVectorParticleParameter() : this(BuiltinUtils.AllocNativeUObject(UDistributionVectorParticleParameter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008E48 RID: 36424 RVA: 0x000CB6B0 File Offset: 0x000C98B0
		[NullableContext(1)]
		public UDistributionVectorParticleParameter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDistributionVectorParticleParameter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06008E49 RID: 36425 RVA: 0x000CB6E3 File Offset: 0x000C98E3
		static UDistributionVectorParticleParameter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DistributionVectorParticleParameter");
		}

		// Token: 0x06008E4A RID: 36426 RVA: 0x000CB6F1 File Offset: 0x000C98F1
		protected UDistributionVectorParticleParameter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040043A0 RID: 17312
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.DistributionVectorParticleParameter";

		// Token: 0x040043A1 RID: 17313
		private static IntPtr _ClassPtr;

		// Token: 0x040043A2 RID: 17314
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
