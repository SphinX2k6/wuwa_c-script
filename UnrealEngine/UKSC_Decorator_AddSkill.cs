using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DD1 RID: 7633
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Decorator_AddSkill")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UKSC_Decorator_AddSkill : UKSC_Decorator, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D2C9 RID: 119497 RVA: 0x002B19E9 File Offset: 0x002AFBE9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Decorator_AddSkill._ClassPtr;
		}

		// Token: 0x0601D2CA RID: 119498 RVA: 0x002B19F8 File Offset: 0x002AFBF8
		public UKSC_Decorator_AddSkill() : this(BuiltinUtils.AllocNativeUObject(UKSC_Decorator_AddSkill.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D2CB RID: 119499 RVA: 0x002B1A20 File Offset: 0x002AFC20
		[NullableContext(1)]
		public UKSC_Decorator_AddSkill(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Decorator_AddSkill.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170075DF RID: 30175
		// (get) Token: 0x0601D2CC RID: 119500 RVA: 0x002B1A53 File Offset: 0x002AFC53
		// (set) Token: 0x0601D2CD RID: 119501 RVA: 0x002B1A67 File Offset: 0x002AFC67
		[Nullable(2)]
		public unsafe UKSC_DA_Decorator_AddSkill Da_Decorator_AddSkill_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Decorator_AddSkill>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Decorator_AddSkill.__PropertyOffset_Da_Decorator_AddSkill_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Decorator_AddSkill.__PropertyOffset_Da_Decorator_AddSkill_, value);
			}
		}

		// Token: 0x0601D2CE RID: 119502 RVA: 0x002B1A7C File Offset: 0x002AFC7C
		static UKSC_Decorator_AddSkill()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Decorator_AddSkill");
		}

		// Token: 0x0601D2CF RID: 119503 RVA: 0x002B1A8A File Offset: 0x002AFC8A
		protected UKSC_Decorator_AddSkill(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FD71 RID: 64881
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Decorator_AddSkill";

		// Token: 0x0400FD72 RID: 64882
		private static IntPtr _ClassPtr;

		// Token: 0x0400FD73 RID: 64883
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FD74 RID: 64884
		internal static int __PropertyOffset_Da_Decorator_AddSkill_;
	}
}
