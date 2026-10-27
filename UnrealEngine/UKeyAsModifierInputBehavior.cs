using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001586 RID: 5510
	[UnrealObjectPath("/Script/InteractiveToolsFramework.KeyAsModifierInputBehavior")]
	[UnrealStructLayout(320, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 320)]
	public class UKeyAsModifierInputBehavior : UInputBehavior, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013E62 RID: 81506 RVA: 0x001D37E2 File Offset: 0x001D19E2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKeyAsModifierInputBehavior._ClassPtr;
		}

		// Token: 0x06013E63 RID: 81507 RVA: 0x001D37F0 File Offset: 0x001D19F0
		public UKeyAsModifierInputBehavior() : this(BuiltinUtils.AllocNativeUObject(UKeyAsModifierInputBehavior.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013E64 RID: 81508 RVA: 0x001D3818 File Offset: 0x001D1A18
		[NullableContext(1)]
		public UKeyAsModifierInputBehavior(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKeyAsModifierInputBehavior.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06013E65 RID: 81509 RVA: 0x001D384B File Offset: 0x001D1A4B
		static UKeyAsModifierInputBehavior()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.KeyAsModifierInputBehavior");
		}

		// Token: 0x06013E66 RID: 81510 RVA: 0x001D3859 File Offset: 0x001D1A59
		protected UKeyAsModifierInputBehavior(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AC4C RID: 44108
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.KeyAsModifierInputBehavior";

		// Token: 0x0400AC4D RID: 44109
		private static IntPtr _ClassPtr;

		// Token: 0x0400AC4E RID: 44110
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
