using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D2B RID: 7467
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff_Period_DotPeriodic")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 184)]
	public class UKSC_Buff_Period_DotPeriodic : UKSC_Buff_Period, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CA4E RID: 117326 RVA: 0x002A5837 File Offset: 0x002A3A37
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_Period_DotPeriodic._ClassPtr;
		}

		// Token: 0x0601CA4F RID: 117327 RVA: 0x002A5844 File Offset: 0x002A3A44
		public UKSC_Buff_Period_DotPeriodic() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_Period_DotPeriodic.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CA50 RID: 117328 RVA: 0x002A586C File Offset: 0x002A3A6C
		[NullableContext(1)]
		public UKSC_Buff_Period_DotPeriodic(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_Period_DotPeriodic.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007345 RID: 29509
		// (get) Token: 0x0601CA51 RID: 117329 RVA: 0x002A589F File Offset: 0x002A3A9F
		// (set) Token: 0x0601CA52 RID: 117330 RVA: 0x002A58B3 File Offset: 0x002A3AB3
		[Nullable(2)]
		public unsafe UKSC_DA_Buff_Period_DotPeriodic DaBuffDotPeriodic_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff_Period_DotPeriodic>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_Period_DotPeriodic.__PropertyOffset_DaBuffDotPeriodic_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_Period_DotPeriodic.__PropertyOffset_DaBuffDotPeriodic_, value);
			}
		}

		// Token: 0x0601CA53 RID: 117331 RVA: 0x002A58C8 File Offset: 0x002A3AC8
		static UKSC_Buff_Period_DotPeriodic()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff_Period_DotPeriodic");
		}

		// Token: 0x0601CA54 RID: 117332 RVA: 0x002A58D6 File Offset: 0x002A3AD6
		protected UKSC_Buff_Period_DotPeriodic(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F874 RID: 63604
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff_Period_DotPeriodic";

		// Token: 0x0400F875 RID: 63605
		private static IntPtr _ClassPtr;

		// Token: 0x0400F876 RID: 63606
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F877 RID: 63607
		internal static int __PropertyOffset_DaBuffDotPeriodic_;
	}
}
