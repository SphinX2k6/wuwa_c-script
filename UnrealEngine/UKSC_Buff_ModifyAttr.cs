using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D1F RID: 7455
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff_ModifyAttr")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UKSC_Buff_ModifyAttr : UKSC_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C9E6 RID: 117222 RVA: 0x002A4E7A File Offset: 0x002A307A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_ModifyAttr._ClassPtr;
		}

		// Token: 0x0601C9E7 RID: 117223 RVA: 0x002A4E88 File Offset: 0x002A3088
		public UKSC_Buff_ModifyAttr() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_ModifyAttr.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C9E8 RID: 117224 RVA: 0x002A4EB0 File Offset: 0x002A30B0
		[NullableContext(1)]
		public UKSC_Buff_ModifyAttr(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_ModifyAttr.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007330 RID: 29488
		// (get) Token: 0x0601C9E9 RID: 117225 RVA: 0x002A4EE3 File Offset: 0x002A30E3
		// (set) Token: 0x0601C9EA RID: 117226 RVA: 0x002A4EF7 File Offset: 0x002A30F7
		[Nullable(2)]
		public unsafe UKSC_DA_Buff_ModifyAttr DaBuffModifyAttr_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff_ModifyAttr>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_ModifyAttr.__PropertyOffset_DaBuffModifyAttr_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_ModifyAttr.__PropertyOffset_DaBuffModifyAttr_, value);
			}
		}

		// Token: 0x0601C9EB RID: 117227 RVA: 0x002A4F0C File Offset: 0x002A310C
		static UKSC_Buff_ModifyAttr()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff_ModifyAttr");
		}

		// Token: 0x0601C9EC RID: 117228 RVA: 0x002A4F1A File Offset: 0x002A311A
		protected UKSC_Buff_ModifyAttr(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F838 RID: 63544
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff_ModifyAttr";

		// Token: 0x0400F839 RID: 63545
		private static IntPtr _ClassPtr;

		// Token: 0x0400F83A RID: 63546
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F83B RID: 63547
		internal static int __PropertyOffset_DaBuffModifyAttr_;
	}
}
