using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AA5 RID: 6821
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroActorCullingLocalVolume")]
	[UnrealStructLayout(1128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1128)]
	public class AKuroActorCullingLocalVolume : AVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06019407 RID: 103431 RVA: 0x002558F2 File Offset: 0x00253AF2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroActorCullingLocalVolume._ClassPtr;
		}

		// Token: 0x06019408 RID: 103432 RVA: 0x00255900 File Offset: 0x00253B00
		public AKuroActorCullingLocalVolume() : this(BuiltinUtils.AllocNativeUObject(AKuroActorCullingLocalVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06019409 RID: 103433 RVA: 0x00255928 File Offset: 0x00253B28
		[NullableContext(1)]
		public AKuroActorCullingLocalVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroActorCullingLocalVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601940A RID: 103434 RVA: 0x0025595B File Offset: 0x00253B5B
		static AKuroActorCullingLocalVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroActorCullingLocalVolume");
		}

		// Token: 0x0601940B RID: 103435 RVA: 0x00255969 File Offset: 0x00253B69
		protected AKuroActorCullingLocalVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400DC65 RID: 56421
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroActorCullingLocalVolume";

		// Token: 0x0400DC66 RID: 56422
		private static IntPtr _ClassPtr;

		// Token: 0x0400DC67 RID: 56423
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
