using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000565 RID: 1381
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DamageHandler")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKSC_DamageHandler : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007DCE RID: 32206 RVA: 0x000BA87D File Offset: 0x000B8A7D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DamageHandler._ClassPtr;
		}

		// Token: 0x06007DCF RID: 32207 RVA: 0x000BA88C File Offset: 0x000B8A8C
		public UKSC_DamageHandler() : this(BuiltinUtils.AllocNativeUObject(UKSC_DamageHandler.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007DD0 RID: 32208 RVA: 0x000BA8B4 File Offset: 0x000B8AB4
		[NullableContext(1)]
		public UKSC_DamageHandler(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DamageHandler.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06007DD1 RID: 32209 RVA: 0x000BA8E7 File Offset: 0x000B8AE7
		static UKSC_DamageHandler()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DamageHandler");
		}

		// Token: 0x06007DD2 RID: 32210 RVA: 0x000BA8F5 File Offset: 0x000B8AF5
		protected UKSC_DamageHandler(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040036D6 RID: 14038
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DamageHandler";

		// Token: 0x040036D7 RID: 14039
		private static IntPtr _ClassPtr;

		// Token: 0x040036D8 RID: 14040
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
