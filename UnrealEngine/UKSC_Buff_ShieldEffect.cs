using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D34 RID: 7476
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff_ShieldEffect")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UKSC_Buff_ShieldEffect : UKSC_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CA8D RID: 117389 RVA: 0x002A5E1F File Offset: 0x002A401F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_ShieldEffect._ClassPtr;
		}

		// Token: 0x0601CA8E RID: 117390 RVA: 0x002A5E2C File Offset: 0x002A402C
		public UKSC_Buff_ShieldEffect() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_ShieldEffect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CA8F RID: 117391 RVA: 0x002A5E54 File Offset: 0x002A4054
		[NullableContext(1)]
		public UKSC_Buff_ShieldEffect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_ShieldEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700734E RID: 29518
		// (get) Token: 0x0601CA90 RID: 117392 RVA: 0x002A5E87 File Offset: 0x002A4087
		// (set) Token: 0x0601CA91 RID: 117393 RVA: 0x002A5E9B File Offset: 0x002A409B
		[Nullable(2)]
		public unsafe UKSC_DA_Buff_ShieldEffect DaBuffShield_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff_ShieldEffect>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_ShieldEffect.__PropertyOffset_DaBuffShield_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_ShieldEffect.__PropertyOffset_DaBuffShield_, value);
			}
		}

		// Token: 0x0601CA92 RID: 117394 RVA: 0x002A5EB0 File Offset: 0x002A40B0
		static UKSC_Buff_ShieldEffect()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff_ShieldEffect");
		}

		// Token: 0x0601CA93 RID: 117395 RVA: 0x002A5EBE File Offset: 0x002A40BE
		protected UKSC_Buff_ShieldEffect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F898 RID: 63640
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff_ShieldEffect";

		// Token: 0x0400F899 RID: 63641
		private static IntPtr _ClassPtr;

		// Token: 0x0400F89A RID: 63642
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F89B RID: 63643
		internal static int __PropertyOffset_DaBuffShield_;
	}
}
