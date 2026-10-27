using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D20 RID: 7456
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff_ModifyAttrRatio")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 184)]
	public class UKSC_Buff_ModifyAttrRatio : UKSC_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C9ED RID: 117229 RVA: 0x002A4F23 File Offset: 0x002A3123
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_ModifyAttrRatio._ClassPtr;
		}

		// Token: 0x0601C9EE RID: 117230 RVA: 0x002A4F30 File Offset: 0x002A3130
		public UKSC_Buff_ModifyAttrRatio() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_ModifyAttrRatio.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C9EF RID: 117231 RVA: 0x002A4F58 File Offset: 0x002A3158
		[NullableContext(1)]
		public UKSC_Buff_ModifyAttrRatio(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_ModifyAttrRatio.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007331 RID: 29489
		// (get) Token: 0x0601C9F0 RID: 117232 RVA: 0x002A4F8B File Offset: 0x002A318B
		// (set) Token: 0x0601C9F1 RID: 117233 RVA: 0x002A4F9F File Offset: 0x002A319F
		[Nullable(2)]
		public unsafe UKSC_DA_Buff_ModifyAttrRatio DaBuffModifyAttrRatio_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff_ModifyAttrRatio>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_ModifyAttrRatio.__PropertyOffset_DaBuffModifyAttrRatio_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_ModifyAttrRatio.__PropertyOffset_DaBuffModifyAttrRatio_, value);
			}
		}

		// Token: 0x0601C9F2 RID: 117234 RVA: 0x002A4FB4 File Offset: 0x002A31B4
		static UKSC_Buff_ModifyAttrRatio()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff_ModifyAttrRatio");
		}

		// Token: 0x0601C9F3 RID: 117235 RVA: 0x002A4FC2 File Offset: 0x002A31C2
		protected UKSC_Buff_ModifyAttrRatio(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F83C RID: 63548
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff_ModifyAttrRatio";

		// Token: 0x0400F83D RID: 63549
		private static IntPtr _ClassPtr;

		// Token: 0x0400F83E RID: 63550
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F83F RID: 63551
		internal static int __PropertyOffset_DaBuffModifyAttrRatio_;
	}
}
