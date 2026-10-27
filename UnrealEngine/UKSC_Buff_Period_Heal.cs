using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D2D RID: 7469
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff_Period_Heal")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 184)]
	public class UKSC_Buff_Period_Heal : UKSC_Buff_Period, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CA5C RID: 117340 RVA: 0x002A5987 File Offset: 0x002A3B87
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_Period_Heal._ClassPtr;
		}

		// Token: 0x0601CA5D RID: 117341 RVA: 0x002A5994 File Offset: 0x002A3B94
		public UKSC_Buff_Period_Heal() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_Period_Heal.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CA5E RID: 117342 RVA: 0x002A59BC File Offset: 0x002A3BBC
		[NullableContext(1)]
		public UKSC_Buff_Period_Heal(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_Period_Heal.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007347 RID: 29511
		// (get) Token: 0x0601CA5F RID: 117343 RVA: 0x002A59EF File Offset: 0x002A3BEF
		// (set) Token: 0x0601CA60 RID: 117344 RVA: 0x002A5A03 File Offset: 0x002A3C03
		[Nullable(2)]
		public unsafe UKSC_DA_Buff_Period_Heal DaBuffPeriodHeal_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff_Period_Heal>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_Period_Heal.__PropertyOffset_DaBuffPeriodHeal_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_Period_Heal.__PropertyOffset_DaBuffPeriodHeal_, value);
			}
		}

		// Token: 0x0601CA61 RID: 117345 RVA: 0x002A5A18 File Offset: 0x002A3C18
		static UKSC_Buff_Period_Heal()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff_Period_Heal");
		}

		// Token: 0x0601CA62 RID: 117346 RVA: 0x002A5A26 File Offset: 0x002A3C26
		protected UKSC_Buff_Period_Heal(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F87C RID: 63612
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff_Period_Heal";

		// Token: 0x0400F87D RID: 63613
		private static IntPtr _ClassPtr;

		// Token: 0x0400F87E RID: 63614
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F87F RID: 63615
		internal static int __PropertyOffset_DaBuffPeriodHeal_;
	}
}
