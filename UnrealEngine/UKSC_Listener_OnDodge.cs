using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DF7 RID: 7671
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Listener_OnDodge")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UKSC_Listener_OnDodge : UKSC_EventListener, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D4F7 RID: 120055 RVA: 0x002B4667 File Offset: 0x002B2867
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Listener_OnDodge._ClassPtr;
		}

		// Token: 0x0601D4F8 RID: 120056 RVA: 0x002B4674 File Offset: 0x002B2874
		public UKSC_Listener_OnDodge() : this(BuiltinUtils.AllocNativeUObject(UKSC_Listener_OnDodge.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D4F9 RID: 120057 RVA: 0x002B469C File Offset: 0x002B289C
		[NullableContext(1)]
		public UKSC_Listener_OnDodge(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Listener_OnDodge.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007659 RID: 30297
		// (get) Token: 0x0601D4FA RID: 120058 RVA: 0x002B46CF File Offset: 0x002B28CF
		// (set) Token: 0x0601D4FB RID: 120059 RVA: 0x002B46DF File Offset: 0x002B28DF
		public unsafe EKSC_Event_HitTarget CheckTarget
		{
			get
			{
				return (EKSC_Event_HitTarget)(*(base.NativePtr + (IntPtr)UKSC_Listener_OnDodge.__PropertyOffset_CheckTarget));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_Listener_OnDodge.__PropertyOffset_CheckTarget) = (byte)value;
			}
		}

		// Token: 0x0601D4FC RID: 120060 RVA: 0x002B46F0 File Offset: 0x002B28F0
		[NullableContext(2)]
		public void OnDodgeCallback(UKSC_SkillComp Attacker, UKSC_SkillComp DodgeComp)
		{
			UKSC_Listener_OnDodge.__OnDodgeCallback_Internal(base.NativePtr, (Attacker != null) ? Attacker.NativePtr : IntPtr.Zero, (DodgeComp != null) ? DodgeComp.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601D4FD RID: 120061
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnDodgeCallback_Internal(IntPtr @this, IntPtr Attacker, IntPtr DodgeComp);

		// Token: 0x0601D4FE RID: 120062 RVA: 0x002B471D File Offset: 0x002B291D
		static UKSC_Listener_OnDodge()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Listener_OnDodge");
		}

		// Token: 0x0601D4FF RID: 120063 RVA: 0x002B472B File Offset: 0x002B292B
		protected UKSC_Listener_OnDodge(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FE70 RID: 65136
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Listener_OnDodge";

		// Token: 0x0400FE71 RID: 65137
		private static IntPtr _ClassPtr;

		// Token: 0x0400FE72 RID: 65138
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FE73 RID: 65139
		internal static int __PropertyOffset_CheckTarget;
	}
}
