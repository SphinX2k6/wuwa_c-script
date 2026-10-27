using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DF4 RID: 7668
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Listener_OnCast")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UKSC_Listener_OnCast : UKSC_EventListener, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D4DC RID: 120028 RVA: 0x002B43B5 File Offset: 0x002B25B5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Listener_OnCast._ClassPtr;
		}

		// Token: 0x0601D4DD RID: 120029 RVA: 0x002B43C4 File Offset: 0x002B25C4
		public UKSC_Listener_OnCast() : this(BuiltinUtils.AllocNativeUObject(UKSC_Listener_OnCast.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D4DE RID: 120030 RVA: 0x002B43EC File Offset: 0x002B25EC
		[NullableContext(1)]
		public UKSC_Listener_OnCast(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Listener_OnCast.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007656 RID: 30294
		// (get) Token: 0x0601D4DF RID: 120031 RVA: 0x002B441F File Offset: 0x002B261F
		// (set) Token: 0x0601D4E0 RID: 120032 RVA: 0x002B442F File Offset: 0x002B262F
		public unsafe bool bCastBefore
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_Listener_OnCast.__PropertyOffset_bCastBefore) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_Listener_OnCast.__PropertyOffset_bCastBefore) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601D4E1 RID: 120033 RVA: 0x002B4440 File Offset: 0x002B2640
		[NullableContext(2)]
		public void OnCastCallback(UKSC_SkillComp FromComp, UKSC_Skill CastSkill)
		{
			UKSC_Listener_OnCast.__OnCastCallback_Internal(base.NativePtr, (FromComp != null) ? FromComp.NativePtr : IntPtr.Zero, (CastSkill != null) ? CastSkill.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601D4E2 RID: 120034
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnCastCallback_Internal(IntPtr @this, IntPtr FromComp, IntPtr CastSkill);

		// Token: 0x0601D4E3 RID: 120035 RVA: 0x002B446D File Offset: 0x002B266D
		static UKSC_Listener_OnCast()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Listener_OnCast");
		}

		// Token: 0x0601D4E4 RID: 120036 RVA: 0x002B447B File Offset: 0x002B267B
		protected UKSC_Listener_OnCast(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FE63 RID: 65123
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Listener_OnCast";

		// Token: 0x0400FE64 RID: 65124
		private static IntPtr _ClassPtr;

		// Token: 0x0400FE65 RID: 65125
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FE66 RID: 65126
		internal static int __PropertyOffset_bCastBefore;
	}
}
