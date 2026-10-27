using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D23 RID: 7459
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff_ModifyAttr_ByWorldAttr")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UKSC_Buff_ModifyAttr_ByWorldAttr : UKSC_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CA14 RID: 117268 RVA: 0x002A52E7 File Offset: 0x002A34E7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_ModifyAttr_ByWorldAttr._ClassPtr;
		}

		// Token: 0x0601CA15 RID: 117269 RVA: 0x002A52F4 File Offset: 0x002A34F4
		public UKSC_Buff_ModifyAttr_ByWorldAttr() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_ModifyAttr_ByWorldAttr.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CA16 RID: 117270 RVA: 0x002A531C File Offset: 0x002A351C
		[NullableContext(1)]
		public UKSC_Buff_ModifyAttr_ByWorldAttr(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_ModifyAttr_ByWorldAttr.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700733D RID: 29501
		// (get) Token: 0x0601CA17 RID: 117271 RVA: 0x002A534F File Offset: 0x002A354F
		// (set) Token: 0x0601CA18 RID: 117272 RVA: 0x002A5363 File Offset: 0x002A3563
		[Nullable(2)]
		public unsafe UKSC_DA_Buff_ModifyAttr_ByWorldAttr DaBuffModifyAttr_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff_ModifyAttr_ByWorldAttr>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_ModifyAttr_ByWorldAttr.__PropertyOffset_DaBuffModifyAttr_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_ModifyAttr_ByWorldAttr.__PropertyOffset_DaBuffModifyAttr_, value);
			}
		}

		// Token: 0x0601CA19 RID: 117273 RVA: 0x002A5378 File Offset: 0x002A3578
		static UKSC_Buff_ModifyAttr_ByWorldAttr()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff_ModifyAttr_ByWorldAttr");
		}

		// Token: 0x0601CA1A RID: 117274 RVA: 0x002A5386 File Offset: 0x002A3586
		protected UKSC_Buff_ModifyAttr_ByWorldAttr(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F854 RID: 63572
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff_ModifyAttr_ByWorldAttr";

		// Token: 0x0400F855 RID: 63573
		private static IntPtr _ClassPtr;

		// Token: 0x0400F856 RID: 63574
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F857 RID: 63575
		internal static int __PropertyOffset_DaBuffModifyAttr_;
	}
}
