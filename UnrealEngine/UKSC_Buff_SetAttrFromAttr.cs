using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D33 RID: 7475
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff_SetAttrFromAttr")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UKSC_Buff_SetAttrFromAttr : UKSC_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CA86 RID: 117382 RVA: 0x002A5D77 File Offset: 0x002A3F77
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_SetAttrFromAttr._ClassPtr;
		}

		// Token: 0x0601CA87 RID: 117383 RVA: 0x002A5D84 File Offset: 0x002A3F84
		public UKSC_Buff_SetAttrFromAttr() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_SetAttrFromAttr.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CA88 RID: 117384 RVA: 0x002A5DAC File Offset: 0x002A3FAC
		[NullableContext(1)]
		public UKSC_Buff_SetAttrFromAttr(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_SetAttrFromAttr.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700734D RID: 29517
		// (get) Token: 0x0601CA89 RID: 117385 RVA: 0x002A5DDF File Offset: 0x002A3FDF
		// (set) Token: 0x0601CA8A RID: 117386 RVA: 0x002A5DF3 File Offset: 0x002A3FF3
		[Nullable(2)]
		public unsafe UKSC_DA_Buff_SetAttrFromAttr DaBuffSetAttrFromAttr_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff_SetAttrFromAttr>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_SetAttrFromAttr.__PropertyOffset_DaBuffSetAttrFromAttr_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_SetAttrFromAttr.__PropertyOffset_DaBuffSetAttrFromAttr_, value);
			}
		}

		// Token: 0x0601CA8B RID: 117387 RVA: 0x002A5E08 File Offset: 0x002A4008
		static UKSC_Buff_SetAttrFromAttr()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff_SetAttrFromAttr");
		}

		// Token: 0x0601CA8C RID: 117388 RVA: 0x002A5E16 File Offset: 0x002A4016
		protected UKSC_Buff_SetAttrFromAttr(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F894 RID: 63636
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff_SetAttrFromAttr";

		// Token: 0x0400F895 RID: 63637
		private static IntPtr _ClassPtr;

		// Token: 0x0400F896 RID: 63638
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F897 RID: 63639
		internal static int __PropertyOffset_DaBuffSetAttrFromAttr_;
	}
}
