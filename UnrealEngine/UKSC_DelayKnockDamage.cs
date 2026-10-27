using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DD3 RID: 7635
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DelayKnockDamage")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UKSC_DelayKnockDamage : UKSC_BaseObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D2D6 RID: 119510 RVA: 0x002B1B1A File Offset: 0x002AFD1A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DelayKnockDamage._ClassPtr;
		}

		// Token: 0x0601D2D7 RID: 119511 RVA: 0x002B1B28 File Offset: 0x002AFD28
		public UKSC_DelayKnockDamage() : this(BuiltinUtils.AllocNativeUObject(UKSC_DelayKnockDamage.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D2D8 RID: 119512 RVA: 0x002B1B50 File Offset: 0x002AFD50
		[NullableContext(1)]
		public UKSC_DelayKnockDamage(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DelayKnockDamage.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601D2D9 RID: 119513 RVA: 0x002B1B83 File Offset: 0x002AFD83
		static UKSC_DelayKnockDamage()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DelayKnockDamage");
		}

		// Token: 0x0601D2DA RID: 119514 RVA: 0x002B1B91 File Offset: 0x002AFD91
		protected UKSC_DelayKnockDamage(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FD79 RID: 64889
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DelayKnockDamage";

		// Token: 0x0400FD7A RID: 64890
		private static IntPtr _ClassPtr;

		// Token: 0x0400FD7B RID: 64891
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
