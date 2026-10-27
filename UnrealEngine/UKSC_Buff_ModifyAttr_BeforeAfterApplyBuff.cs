using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D21 RID: 7457
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff_ModifyAttr_BeforeAfterApplyBuff")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UKSC_Buff_ModifyAttr_BeforeAfterApplyBuff : UKSC_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C9F4 RID: 117236 RVA: 0x002A4FCB File Offset: 0x002A31CB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_ModifyAttr_BeforeAfterApplyBuff._ClassPtr;
		}

		// Token: 0x0601C9F5 RID: 117237 RVA: 0x002A4FD8 File Offset: 0x002A31D8
		public UKSC_Buff_ModifyAttr_BeforeAfterApplyBuff() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_ModifyAttr_BeforeAfterApplyBuff.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C9F6 RID: 117238 RVA: 0x002A5000 File Offset: 0x002A3200
		[NullableContext(1)]
		public UKSC_Buff_ModifyAttr_BeforeAfterApplyBuff(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_ModifyAttr_BeforeAfterApplyBuff.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007332 RID: 29490
		// (get) Token: 0x0601C9F7 RID: 117239 RVA: 0x002A5033 File Offset: 0x002A3233
		// (set) Token: 0x0601C9F8 RID: 117240 RVA: 0x002A5047 File Offset: 0x002A3247
		[Nullable(2)]
		public unsafe UKSC_DA_Buff_ModifyAttr_BeforeAfterApplyBuff DaBuffModifyAttr_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff_ModifyAttr_BeforeAfterApplyBuff>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_ModifyAttr_BeforeAfterApplyBuff.__PropertyOffset_DaBuffModifyAttr_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_ModifyAttr_BeforeAfterApplyBuff.__PropertyOffset_DaBuffModifyAttr_, value);
			}
		}

		// Token: 0x0601C9F9 RID: 117241 RVA: 0x002A505C File Offset: 0x002A325C
		static UKSC_Buff_ModifyAttr_BeforeAfterApplyBuff()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff_ModifyAttr_BeforeAfterApplyBuff");
		}

		// Token: 0x0601C9FA RID: 117242 RVA: 0x002A506A File Offset: 0x002A326A
		protected UKSC_Buff_ModifyAttr_BeforeAfterApplyBuff(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F840 RID: 63552
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff_ModifyAttr_BeforeAfterApplyBuff";

		// Token: 0x0400F841 RID: 63553
		private static IntPtr _ClassPtr;

		// Token: 0x0400F842 RID: 63554
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F843 RID: 63555
		internal static int __PropertyOffset_DaBuffModifyAttr_;
	}
}
