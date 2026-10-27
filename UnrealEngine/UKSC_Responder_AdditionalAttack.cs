using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E1C RID: 7708
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Responder_AdditionalAttack")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UKSC_Responder_AdditionalAttack : UKSC_EventResponder, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D66B RID: 120427 RVA: 0x002B6D33 File Offset: 0x002B4F33
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Responder_AdditionalAttack._ClassPtr;
		}

		// Token: 0x0601D66C RID: 120428 RVA: 0x002B6D40 File Offset: 0x002B4F40
		public UKSC_Responder_AdditionalAttack() : this(BuiltinUtils.AllocNativeUObject(UKSC_Responder_AdditionalAttack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D66D RID: 120429 RVA: 0x002B6D68 File Offset: 0x002B4F68
		[NullableContext(1)]
		public UKSC_Responder_AdditionalAttack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Responder_AdditionalAttack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700768C RID: 30348
		// (get) Token: 0x0601D66E RID: 120430 RVA: 0x002B6D9B File Offset: 0x002B4F9B
		// (set) Token: 0x0601D66F RID: 120431 RVA: 0x002B6DAF File Offset: 0x002B4FAF
		[Nullable(2)]
		public unsafe UKSC_DA_AdditionalAttack AdditionalAttackConfig
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_AdditionalAttack>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Responder_AdditionalAttack.__PropertyOffset_AdditionalAttackConfig);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Responder_AdditionalAttack.__PropertyOffset_AdditionalAttackConfig, value);
			}
		}

		// Token: 0x0601D670 RID: 120432 RVA: 0x002B6DC4 File Offset: 0x002B4FC4
		static UKSC_Responder_AdditionalAttack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Responder_AdditionalAttack");
		}

		// Token: 0x0601D671 RID: 120433 RVA: 0x002B6DD2 File Offset: 0x002B4FD2
		protected UKSC_Responder_AdditionalAttack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FF10 RID: 65296
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Responder_AdditionalAttack";

		// Token: 0x0400FF11 RID: 65297
		private static IntPtr _ClassPtr;

		// Token: 0x0400FF12 RID: 65298
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FF13 RID: 65299
		internal static int __PropertyOffset_AdditionalAttackConfig;
	}
}
