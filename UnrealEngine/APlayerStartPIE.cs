using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001010 RID: 4112
	[UnrealObjectPath("/Script/Engine.PlayerStartPIE")]
	[UnrealStructLayout(1104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1104)]
	public class APlayerStartPIE : APlayerStart, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600E0BC RID: 57532 RVA: 0x0014A7CF File Offset: 0x001489CF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return APlayerStartPIE._ClassPtr;
		}

		// Token: 0x0600E0BD RID: 57533 RVA: 0x0014A7DC File Offset: 0x001489DC
		public APlayerStartPIE() : this(BuiltinUtils.AllocNativeUObject(APlayerStartPIE.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600E0BE RID: 57534 RVA: 0x0014A804 File Offset: 0x00148A04
		[NullableContext(1)]
		public APlayerStartPIE(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(APlayerStartPIE.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600E0BF RID: 57535 RVA: 0x0014A837 File Offset: 0x00148A37
		static APlayerStartPIE()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PlayerStartPIE");
		}

		// Token: 0x0600E0C0 RID: 57536 RVA: 0x0014A845 File Offset: 0x00148A45
		protected APlayerStartPIE(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040078BB RID: 30907
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.PlayerStartPIE";

		// Token: 0x040078BC RID: 30908
		private static IntPtr _ClassPtr;

		// Token: 0x040078BD RID: 30909
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
