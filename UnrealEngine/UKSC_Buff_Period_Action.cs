using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D2A RID: 7466
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff_Period_Action")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public class UKSC_Buff_Period_Action : UKSC_Buff_Period, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CA47 RID: 117319 RVA: 0x002A578E File Offset: 0x002A398E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_Period_Action._ClassPtr;
		}

		// Token: 0x0601CA48 RID: 117320 RVA: 0x002A579C File Offset: 0x002A399C
		public UKSC_Buff_Period_Action() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_Period_Action.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CA49 RID: 117321 RVA: 0x002A57C4 File Offset: 0x002A39C4
		[NullableContext(1)]
		public UKSC_Buff_Period_Action(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_Period_Action.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007344 RID: 29508
		// (get) Token: 0x0601CA4A RID: 117322 RVA: 0x002A57F7 File Offset: 0x002A39F7
		// (set) Token: 0x0601CA4B RID: 117323 RVA: 0x002A580B File Offset: 0x002A3A0B
		[Nullable(2)]
		public unsafe UKSC_DA_Buff_Period_Action DaBuffPeriodAction_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff_Period_Action>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_Period_Action.__PropertyOffset_DaBuffPeriodAction_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_Period_Action.__PropertyOffset_DaBuffPeriodAction_, value);
			}
		}

		// Token: 0x0601CA4C RID: 117324 RVA: 0x002A5820 File Offset: 0x002A3A20
		static UKSC_Buff_Period_Action()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff_Period_Action");
		}

		// Token: 0x0601CA4D RID: 117325 RVA: 0x002A582E File Offset: 0x002A3A2E
		protected UKSC_Buff_Period_Action(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F870 RID: 63600
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff_Period_Action";

		// Token: 0x0400F871 RID: 63601
		private static IntPtr _ClassPtr;

		// Token: 0x0400F872 RID: 63602
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F873 RID: 63603
		internal static int __PropertyOffset_DaBuffPeriodAction_;
	}
}
