using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D17 RID: 7447
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff_ImmuneBuff")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UKSC_Buff_ImmuneBuff : UKSC_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C9AA RID: 117162 RVA: 0x002A48E3 File Offset: 0x002A2AE3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_ImmuneBuff._ClassPtr;
		}

		// Token: 0x0601C9AB RID: 117163 RVA: 0x002A48F0 File Offset: 0x002A2AF0
		public UKSC_Buff_ImmuneBuff() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_ImmuneBuff.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C9AC RID: 117164 RVA: 0x002A4918 File Offset: 0x002A2B18
		[NullableContext(1)]
		public UKSC_Buff_ImmuneBuff(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_ImmuneBuff.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007327 RID: 29479
		// (get) Token: 0x0601C9AD RID: 117165 RVA: 0x002A494B File Offset: 0x002A2B4B
		// (set) Token: 0x0601C9AE RID: 117166 RVA: 0x002A495F File Offset: 0x002A2B5F
		[Nullable(2)]
		public unsafe UKSC_DA_Buff_ImmuneBuff DaBuffImmuneBuff_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff_ImmuneBuff>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_ImmuneBuff.__PropertyOffset_DaBuffImmuneBuff_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_ImmuneBuff.__PropertyOffset_DaBuffImmuneBuff_, value);
			}
		}

		// Token: 0x0601C9AF RID: 117167 RVA: 0x002A4974 File Offset: 0x002A2B74
		static UKSC_Buff_ImmuneBuff()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff_ImmuneBuff");
		}

		// Token: 0x0601C9B0 RID: 117168 RVA: 0x002A4982 File Offset: 0x002A2B82
		protected UKSC_Buff_ImmuneBuff(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F816 RID: 63510
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff_ImmuneBuff";

		// Token: 0x0400F817 RID: 63511
		private static IntPtr _ClassPtr;

		// Token: 0x0400F818 RID: 63512
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F819 RID: 63513
		internal static int __PropertyOffset_DaBuffImmuneBuff_;
	}
}
