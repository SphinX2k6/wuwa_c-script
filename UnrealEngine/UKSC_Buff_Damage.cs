using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D11 RID: 7441
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff_Damage")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UKSC_Buff_Damage : UKSC_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C97E RID: 117118 RVA: 0x002A44E3 File Offset: 0x002A26E3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_Damage._ClassPtr;
		}

		// Token: 0x0601C97F RID: 117119 RVA: 0x002A44F0 File Offset: 0x002A26F0
		public UKSC_Buff_Damage() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_Damage.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C980 RID: 117120 RVA: 0x002A4518 File Offset: 0x002A2718
		[NullableContext(1)]
		public UKSC_Buff_Damage(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_Damage.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007321 RID: 29473
		// (get) Token: 0x0601C981 RID: 117121 RVA: 0x002A454B File Offset: 0x002A274B
		// (set) Token: 0x0601C982 RID: 117122 RVA: 0x002A455F File Offset: 0x002A275F
		[Nullable(2)]
		public unsafe UKSC_DA_Buff_Damage DaBuffDamage_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff_Damage>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_Damage.__PropertyOffset_DaBuffDamage_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_Damage.__PropertyOffset_DaBuffDamage_, value);
			}
		}

		// Token: 0x0601C983 RID: 117123 RVA: 0x002A4574 File Offset: 0x002A2774
		static UKSC_Buff_Damage()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff_Damage");
		}

		// Token: 0x0601C984 RID: 117124 RVA: 0x002A4582 File Offset: 0x002A2782
		protected UKSC_Buff_Damage(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F7FE RID: 63486
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff_Damage";

		// Token: 0x0400F7FF RID: 63487
		private static IntPtr _ClassPtr;

		// Token: 0x0400F800 RID: 63488
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F801 RID: 63489
		internal static int __PropertyOffset_DaBuffDamage_;
	}
}
