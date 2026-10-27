using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AA9 RID: 6825
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroAsyncMoveDebugComponent")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 200)]
	public class UKuroAsyncMoveDebugComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06019445 RID: 103493 RVA: 0x00255E09 File Offset: 0x00254009
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAsyncMoveDebugComponent._ClassPtr;
		}

		// Token: 0x06019446 RID: 103494 RVA: 0x00255E18 File Offset: 0x00254018
		public UKuroAsyncMoveDebugComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroAsyncMoveDebugComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06019447 RID: 103495 RVA: 0x00255E40 File Offset: 0x00254040
		[NullableContext(1)]
		public UKuroAsyncMoveDebugComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAsyncMoveDebugComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06019448 RID: 103496 RVA: 0x00255E73 File Offset: 0x00254073
		static UKuroAsyncMoveDebugComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroAsyncMoveDebugComponent");
		}

		// Token: 0x06019449 RID: 103497 RVA: 0x00255E81 File Offset: 0x00254081
		protected UKuroAsyncMoveDebugComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400DC76 RID: 56438
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroAsyncMoveDebugComponent";

		// Token: 0x0400DC77 RID: 56439
		private static IntPtr _ClassPtr;

		// Token: 0x0400DC78 RID: 56440
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
