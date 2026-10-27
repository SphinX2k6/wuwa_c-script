using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D39 RID: 7481
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff_Summon")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UKSC_Buff_Summon : UKSC_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CAB0 RID: 117424 RVA: 0x002A6167 File Offset: 0x002A4367
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_Summon._ClassPtr;
		}

		// Token: 0x0601CAB1 RID: 117425 RVA: 0x002A6174 File Offset: 0x002A4374
		public UKSC_Buff_Summon() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_Summon.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CAB2 RID: 117426 RVA: 0x002A619C File Offset: 0x002A439C
		[NullableContext(1)]
		public UKSC_Buff_Summon(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_Summon.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007353 RID: 29523
		// (get) Token: 0x0601CAB3 RID: 117427 RVA: 0x002A61CF File Offset: 0x002A43CF
		// (set) Token: 0x0601CAB4 RID: 117428 RVA: 0x002A61E3 File Offset: 0x002A43E3
		[Nullable(2)]
		public unsafe UKSC_DA_Buff_Summon DaBuffSummon_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff_Summon>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_Summon.__PropertyOffset_DaBuffSummon_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_Summon.__PropertyOffset_DaBuffSummon_, value);
			}
		}

		// Token: 0x0601CAB5 RID: 117429 RVA: 0x002A61F8 File Offset: 0x002A43F8
		static UKSC_Buff_Summon()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff_Summon");
		}

		// Token: 0x0601CAB6 RID: 117430 RVA: 0x002A6206 File Offset: 0x002A4406
		protected UKSC_Buff_Summon(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F8AC RID: 63660
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff_Summon";

		// Token: 0x0400F8AD RID: 63661
		private static IntPtr _ClassPtr;

		// Token: 0x0400F8AE RID: 63662
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F8AF RID: 63663
		internal static int __PropertyOffset_DaBuffSummon_;
	}
}
