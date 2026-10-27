using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D43 RID: 7491
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DamageHandler")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKSC_DamageHandler : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CB0D RID: 117517 RVA: 0x002A69B1 File Offset: 0x002A4BB1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DamageHandler._ClassPtr;
		}

		// Token: 0x0601CB0E RID: 117518 RVA: 0x002A69C0 File Offset: 0x002A4BC0
		public UKSC_DamageHandler() : this(BuiltinUtils.AllocNativeUObject(UKSC_DamageHandler.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CB0F RID: 117519 RVA: 0x002A69E8 File Offset: 0x002A4BE8
		[NullableContext(1)]
		public UKSC_DamageHandler(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DamageHandler.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601CB10 RID: 117520 RVA: 0x002A6A1B File Offset: 0x002A4C1B
		static UKSC_DamageHandler()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DamageHandler");
		}

		// Token: 0x0601CB11 RID: 117521 RVA: 0x002A6A29 File Offset: 0x002A4C29
		protected UKSC_DamageHandler(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F8E2 RID: 63714
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DamageHandler";

		// Token: 0x0400F8E3 RID: 63715
		private static IntPtr _ClassPtr;

		// Token: 0x0400F8E4 RID: 63716
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
