using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B34 RID: 6964
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroLightDebugHudSubsystem")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UKuroLightDebugHudSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601A496 RID: 107670 RVA: 0x0026C9A7 File Offset: 0x0026ABA7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroLightDebugHudSubsystem._ClassPtr;
		}

		// Token: 0x0601A497 RID: 107671 RVA: 0x0026C9B4 File Offset: 0x0026ABB4
		public UKuroLightDebugHudSubsystem() : this(BuiltinUtils.AllocNativeUObject(UKuroLightDebugHudSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601A498 RID: 107672 RVA: 0x0026C9DC File Offset: 0x0026ABDC
		[NullableContext(1)]
		public UKuroLightDebugHudSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroLightDebugHudSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601A499 RID: 107673 RVA: 0x0026CA0F File Offset: 0x0026AC0F
		static UKuroLightDebugHudSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroLightDebugHudSubsystem");
		}

		// Token: 0x0601A49A RID: 107674 RVA: 0x0026CA1D File Offset: 0x0026AC1D
		protected UKuroLightDebugHudSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E43D RID: 58429
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroLightDebugHudSubsystem";

		// Token: 0x0400E43E RID: 58430
		private static IntPtr _ClassPtr;

		// Token: 0x0400E43F RID: 58431
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
