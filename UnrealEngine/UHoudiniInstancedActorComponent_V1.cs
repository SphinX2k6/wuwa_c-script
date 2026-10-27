using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014DD RID: 5341
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniInstancedActorComponent_V1")]
	[UnrealStructLayout(592, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 592)]
	public class UHoudiniInstancedActorComponent_V1 : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013577 RID: 79223 RVA: 0x001C704A File Offset: 0x001C524A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniInstancedActorComponent_V1._ClassPtr;
		}

		// Token: 0x06013578 RID: 79224 RVA: 0x001C7058 File Offset: 0x001C5258
		public UHoudiniInstancedActorComponent_V1() : this(BuiltinUtils.AllocNativeUObject(UHoudiniInstancedActorComponent_V1.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013579 RID: 79225 RVA: 0x001C7080 File Offset: 0x001C5280
		[NullableContext(1)]
		public UHoudiniInstancedActorComponent_V1(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniInstancedActorComponent_V1.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601357A RID: 79226 RVA: 0x001C70B3 File Offset: 0x001C52B3
		static UHoudiniInstancedActorComponent_V1()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniInstancedActorComponent_V1");
		}

		// Token: 0x0601357B RID: 79227 RVA: 0x001C70C1 File Offset: 0x001C52C1
		protected UHoudiniInstancedActorComponent_V1(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A72D RID: 42797
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniInstancedActorComponent_V1";

		// Token: 0x0400A72E RID: 42798
		private static IntPtr _ClassPtr;

		// Token: 0x0400A72F RID: 42799
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
