using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D0E RID: 7438
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff_AuraWithStack")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UKSC_Buff_AuraWithStack : UKSC_Buff_Stack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C969 RID: 117097 RVA: 0x002A42EA File Offset: 0x002A24EA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_AuraWithStack._ClassPtr;
		}

		// Token: 0x0601C96A RID: 117098 RVA: 0x002A42F8 File Offset: 0x002A24F8
		public UKSC_Buff_AuraWithStack() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_AuraWithStack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C96B RID: 117099 RVA: 0x002A4320 File Offset: 0x002A2520
		[NullableContext(1)]
		public UKSC_Buff_AuraWithStack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_AuraWithStack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700731E RID: 29470
		// (get) Token: 0x0601C96C RID: 117100 RVA: 0x002A4353 File Offset: 0x002A2553
		// (set) Token: 0x0601C96D RID: 117101 RVA: 0x002A4367 File Offset: 0x002A2567
		[Nullable(2)]
		public unsafe UKSC_DA_Buff_AuraWithStack DaBuffAuraWithStack
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff_AuraWithStack>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_AuraWithStack.__PropertyOffset_DaBuffAuraWithStack);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_AuraWithStack.__PropertyOffset_DaBuffAuraWithStack, value);
			}
		}

		// Token: 0x0601C96E RID: 117102 RVA: 0x002A437C File Offset: 0x002A257C
		static UKSC_Buff_AuraWithStack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff_AuraWithStack");
		}

		// Token: 0x0601C96F RID: 117103 RVA: 0x002A438A File Offset: 0x002A258A
		protected UKSC_Buff_AuraWithStack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F7F2 RID: 63474
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff_AuraWithStack";

		// Token: 0x0400F7F3 RID: 63475
		private static IntPtr _ClassPtr;

		// Token: 0x0400F7F4 RID: 63476
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F7F5 RID: 63477
		internal static int __PropertyOffset_DaBuffAuraWithStack;
	}
}
