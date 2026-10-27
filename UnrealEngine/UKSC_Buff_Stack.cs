using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D35 RID: 7477
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff_Stack")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class UKSC_Buff_Stack : UKSC_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CA94 RID: 117396 RVA: 0x002A5EC7 File Offset: 0x002A40C7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_Stack._ClassPtr;
		}

		// Token: 0x0601CA95 RID: 117397 RVA: 0x002A5ED4 File Offset: 0x002A40D4
		public UKSC_Buff_Stack() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_Stack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CA96 RID: 117398 RVA: 0x002A5EFC File Offset: 0x002A40FC
		[NullableContext(1)]
		public UKSC_Buff_Stack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_Stack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700734F RID: 29519
		// (get) Token: 0x0601CA97 RID: 117399 RVA: 0x002A5F2F File Offset: 0x002A412F
		// (set) Token: 0x0601CA98 RID: 117400 RVA: 0x002A5F43 File Offset: 0x002A4143
		[Nullable(2)]
		public unsafe UKSC_DA_Buff_Stack DaBuffStack_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff_Stack>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_Stack.__PropertyOffset_DaBuffStack_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_Stack.__PropertyOffset_DaBuffStack_, value);
			}
		}

		// Token: 0x0601CA99 RID: 117401 RVA: 0x002A5F58 File Offset: 0x002A4158
		static UKSC_Buff_Stack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff_Stack");
		}

		// Token: 0x0601CA9A RID: 117402 RVA: 0x002A5F66 File Offset: 0x002A4166
		protected UKSC_Buff_Stack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F89C RID: 63644
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff_Stack";

		// Token: 0x0400F89D RID: 63645
		private static IntPtr _ClassPtr;

		// Token: 0x0400F89E RID: 63646
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F89F RID: 63647
		internal static int __PropertyOffset_DaBuffStack_;
	}
}
