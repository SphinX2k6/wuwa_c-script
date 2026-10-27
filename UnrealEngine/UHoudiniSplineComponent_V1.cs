using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001503 RID: 5379
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniSplineComponent_V1")]
	[UnrealStructLayout(816, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 816)]
	public class UHoudiniSplineComponent_V1 : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601389F RID: 80031 RVA: 0x001CB828 File Offset: 0x001C9A28
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniSplineComponent_V1._ClassPtr;
		}

		// Token: 0x060138A0 RID: 80032 RVA: 0x001CB834 File Offset: 0x001C9A34
		public UHoudiniSplineComponent_V1() : this(BuiltinUtils.AllocNativeUObject(UHoudiniSplineComponent_V1.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060138A1 RID: 80033 RVA: 0x001CB85C File Offset: 0x001C9A5C
		[NullableContext(1)]
		public UHoudiniSplineComponent_V1(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniSplineComponent_V1.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060138A2 RID: 80034 RVA: 0x001CB88F File Offset: 0x001C9A8F
		static UHoudiniSplineComponent_V1()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniSplineComponent_V1");
		}

		// Token: 0x060138A3 RID: 80035 RVA: 0x001CB89D File Offset: 0x001C9A9D
		protected UHoudiniSplineComponent_V1(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A909 RID: 43273
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniSplineComponent_V1";

		// Token: 0x0400A90A RID: 43274
		private static IntPtr _ClassPtr;

		// Token: 0x0400A90B RID: 43275
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
