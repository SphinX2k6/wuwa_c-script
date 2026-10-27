using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E1B RID: 7707
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Responder_AddBuff")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UKSC_Responder_AddBuff : UKSC_EventResponder, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D664 RID: 120420 RVA: 0x002B6C8B File Offset: 0x002B4E8B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Responder_AddBuff._ClassPtr;
		}

		// Token: 0x0601D665 RID: 120421 RVA: 0x002B6C98 File Offset: 0x002B4E98
		public UKSC_Responder_AddBuff() : this(BuiltinUtils.AllocNativeUObject(UKSC_Responder_AddBuff.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D666 RID: 120422 RVA: 0x002B6CC0 File Offset: 0x002B4EC0
		[NullableContext(1)]
		public UKSC_Responder_AddBuff(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Responder_AddBuff.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700768B RID: 30347
		// (get) Token: 0x0601D667 RID: 120423 RVA: 0x002B6CF3 File Offset: 0x002B4EF3
		// (set) Token: 0x0601D668 RID: 120424 RVA: 0x002B6D07 File Offset: 0x002B4F07
		[Nullable(2)]
		public unsafe UKSC_DA_Buff BuffToAdd
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Responder_AddBuff.__PropertyOffset_BuffToAdd);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Responder_AddBuff.__PropertyOffset_BuffToAdd, value);
			}
		}

		// Token: 0x0601D669 RID: 120425 RVA: 0x002B6D1C File Offset: 0x002B4F1C
		static UKSC_Responder_AddBuff()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Responder_AddBuff");
		}

		// Token: 0x0601D66A RID: 120426 RVA: 0x002B6D2A File Offset: 0x002B4F2A
		protected UKSC_Responder_AddBuff(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FF0C RID: 65292
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Responder_AddBuff";

		// Token: 0x0400FF0D RID: 65293
		private static IntPtr _ClassPtr;

		// Token: 0x0400FF0E RID: 65294
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FF0F RID: 65295
		internal static int __PropertyOffset_BuffToAdd;
	}
}
