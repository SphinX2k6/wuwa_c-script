using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D29 RID: 7465
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff_Period")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 168)]
	public class UKSC_Buff_Period : UKSC_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CA3E RID: 117310 RVA: 0x002A56D7 File Offset: 0x002A38D7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_Period._ClassPtr;
		}

		// Token: 0x0601CA3F RID: 117311 RVA: 0x002A56E4 File Offset: 0x002A38E4
		public UKSC_Buff_Period() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_Period.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CA40 RID: 117312 RVA: 0x002A570C File Offset: 0x002A390C
		[NullableContext(1)]
		public UKSC_Buff_Period(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_Period.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007343 RID: 29507
		// (get) Token: 0x0601CA41 RID: 117313 RVA: 0x002A573F File Offset: 0x002A393F
		// (set) Token: 0x0601CA42 RID: 117314 RVA: 0x002A5753 File Offset: 0x002A3953
		[Nullable(2)]
		public unsafe UKSC_DA_Buff_Period DaBuffPeriod_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff_Period>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_Period.__PropertyOffset_DaBuffPeriod_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_Period.__PropertyOffset_DaBuffPeriod_, value);
			}
		}

		// Token: 0x0601CA43 RID: 117315 RVA: 0x002A5768 File Offset: 0x002A3968
		public void OnAttackSpeedChange(EKSC_AttrType AttrType, int Value)
		{
			UKSC_Buff_Period.__OnAttackSpeedChange_Internal(base.NativePtr, AttrType, Value);
		}

		// Token: 0x0601CA44 RID: 117316
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnAttackSpeedChange_Internal(IntPtr @this, EKSC_AttrType AttrType, int Value);

		// Token: 0x0601CA45 RID: 117317 RVA: 0x002A5777 File Offset: 0x002A3977
		static UKSC_Buff_Period()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff_Period");
		}

		// Token: 0x0601CA46 RID: 117318 RVA: 0x002A5785 File Offset: 0x002A3985
		protected UKSC_Buff_Period(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F86C RID: 63596
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff_Period";

		// Token: 0x0400F86D RID: 63597
		private static IntPtr _ClassPtr;

		// Token: 0x0400F86E RID: 63598
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F86F RID: 63599
		internal static int __PropertyOffset_DaBuffPeriod_;
	}
}
