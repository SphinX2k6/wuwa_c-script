using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D27 RID: 7463
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff_ModifyWorldAttr")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UKSC_Buff_ModifyWorldAttr : UKSC_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CA30 RID: 117296 RVA: 0x002A5587 File Offset: 0x002A3787
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_ModifyWorldAttr._ClassPtr;
		}

		// Token: 0x0601CA31 RID: 117297 RVA: 0x002A5594 File Offset: 0x002A3794
		public UKSC_Buff_ModifyWorldAttr() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_ModifyWorldAttr.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CA32 RID: 117298 RVA: 0x002A55BC File Offset: 0x002A37BC
		[NullableContext(1)]
		public UKSC_Buff_ModifyWorldAttr(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_ModifyWorldAttr.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007341 RID: 29505
		// (get) Token: 0x0601CA33 RID: 117299 RVA: 0x002A55EF File Offset: 0x002A37EF
		// (set) Token: 0x0601CA34 RID: 117300 RVA: 0x002A5603 File Offset: 0x002A3803
		[Nullable(2)]
		public unsafe UKSC_DA_Buff_ModifyWorldAttr DaBuffModifyAttr_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff_ModifyWorldAttr>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_ModifyWorldAttr.__PropertyOffset_DaBuffModifyAttr_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_ModifyWorldAttr.__PropertyOffset_DaBuffModifyAttr_, value);
			}
		}

		// Token: 0x0601CA35 RID: 117301 RVA: 0x002A5618 File Offset: 0x002A3818
		static UKSC_Buff_ModifyWorldAttr()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff_ModifyWorldAttr");
		}

		// Token: 0x0601CA36 RID: 117302 RVA: 0x002A5626 File Offset: 0x002A3826
		protected UKSC_Buff_ModifyWorldAttr(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F864 RID: 63588
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff_ModifyWorldAttr";

		// Token: 0x0400F865 RID: 63589
		private static IntPtr _ClassPtr;

		// Token: 0x0400F866 RID: 63590
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F867 RID: 63591
		internal static int __PropertyOffset_DaBuffModifyAttr_;
	}
}
