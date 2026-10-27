using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D36 RID: 7478
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff_Stack_ModifyAttr")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UKSC_Buff_Stack_ModifyAttr : UKSC_Buff_Stack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CA9B RID: 117403 RVA: 0x002A5F6F File Offset: 0x002A416F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_Stack_ModifyAttr._ClassPtr;
		}

		// Token: 0x0601CA9C RID: 117404 RVA: 0x002A5F7C File Offset: 0x002A417C
		public UKSC_Buff_Stack_ModifyAttr() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_Stack_ModifyAttr.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CA9D RID: 117405 RVA: 0x002A5FA4 File Offset: 0x002A41A4
		[NullableContext(1)]
		public UKSC_Buff_Stack_ModifyAttr(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_Stack_ModifyAttr.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007350 RID: 29520
		// (get) Token: 0x0601CA9E RID: 117406 RVA: 0x002A5FD7 File Offset: 0x002A41D7
		// (set) Token: 0x0601CA9F RID: 117407 RVA: 0x002A5FEB File Offset: 0x002A41EB
		[Nullable(2)]
		public unsafe UKSC_DA_Buff_Stack_ModifyAttr DaBuffStackModifyAttr_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff_Stack_ModifyAttr>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_Stack_ModifyAttr.__PropertyOffset_DaBuffStackModifyAttr_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_Stack_ModifyAttr.__PropertyOffset_DaBuffStackModifyAttr_, value);
			}
		}

		// Token: 0x0601CAA0 RID: 117408 RVA: 0x002A6000 File Offset: 0x002A4200
		static UKSC_Buff_Stack_ModifyAttr()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff_Stack_ModifyAttr");
		}

		// Token: 0x0601CAA1 RID: 117409 RVA: 0x002A600E File Offset: 0x002A420E
		protected UKSC_Buff_Stack_ModifyAttr(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F8A0 RID: 63648
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff_Stack_ModifyAttr";

		// Token: 0x0400F8A1 RID: 63649
		private static IntPtr _ClassPtr;

		// Token: 0x0400F8A2 RID: 63650
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F8A3 RID: 63651
		internal static int __PropertyOffset_DaBuffStackModifyAttr_;
	}
}
