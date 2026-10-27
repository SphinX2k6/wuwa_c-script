using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DF6 RID: 7670
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Listener_OnDead")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UKSC_Listener_OnDead : UKSC_EventListener, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D4F0 RID: 120048 RVA: 0x002B45BB File Offset: 0x002B27BB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Listener_OnDead._ClassPtr;
		}

		// Token: 0x0601D4F1 RID: 120049 RVA: 0x002B45C8 File Offset: 0x002B27C8
		public UKSC_Listener_OnDead() : this(BuiltinUtils.AllocNativeUObject(UKSC_Listener_OnDead.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D4F2 RID: 120050 RVA: 0x002B45F0 File Offset: 0x002B27F0
		[NullableContext(1)]
		public UKSC_Listener_OnDead(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Listener_OnDead.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601D4F3 RID: 120051 RVA: 0x002B4623 File Offset: 0x002B2823
		[NullableContext(2)]
		public void OnDeadCallback(UKSC_SkillComp FromComp, UKSC_SkillComp DeadComp)
		{
			UKSC_Listener_OnDead.__OnDeadCallback_Internal(base.NativePtr, (FromComp != null) ? FromComp.NativePtr : IntPtr.Zero, (DeadComp != null) ? DeadComp.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601D4F4 RID: 120052
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnDeadCallback_Internal(IntPtr @this, IntPtr FromComp, IntPtr DeadComp);

		// Token: 0x0601D4F5 RID: 120053 RVA: 0x002B4650 File Offset: 0x002B2850
		static UKSC_Listener_OnDead()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Listener_OnDead");
		}

		// Token: 0x0601D4F6 RID: 120054 RVA: 0x002B465E File Offset: 0x002B285E
		protected UKSC_Listener_OnDead(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FE6D RID: 65133
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Listener_OnDead";

		// Token: 0x0400FE6E RID: 65134
		private static IntPtr _ClassPtr;

		// Token: 0x0400FE6F RID: 65135
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
