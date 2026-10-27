using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001572 RID: 5490
	[UnrealObjectPath("/Script/InteractiveToolsFramework.InteractionMechanic")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UInteractionMechanic : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013DE3 RID: 81379 RVA: 0x001D2C9D File Offset: 0x001D0E9D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInteractionMechanic._ClassPtr;
		}

		// Token: 0x06013DE4 RID: 81380 RVA: 0x001D2CAC File Offset: 0x001D0EAC
		public UInteractionMechanic() : this(BuiltinUtils.AllocNativeUObject(UInteractionMechanic.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013DE5 RID: 81381 RVA: 0x001D2CD4 File Offset: 0x001D0ED4
		[NullableContext(1)]
		public UInteractionMechanic(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInteractionMechanic.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06013DE6 RID: 81382 RVA: 0x001D2D07 File Offset: 0x001D0F07
		static UInteractionMechanic()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.InteractionMechanic");
		}

		// Token: 0x06013DE7 RID: 81383 RVA: 0x001D2D15 File Offset: 0x001D0F15
		protected UInteractionMechanic(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400ABF9 RID: 44025
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.InteractionMechanic";

		// Token: 0x0400ABFA RID: 44026
		private static IntPtr _ClassPtr;

		// Token: 0x0400ABFB RID: 44027
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
