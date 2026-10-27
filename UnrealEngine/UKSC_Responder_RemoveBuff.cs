using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E23 RID: 7715
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Responder_RemoveBuff")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UKSC_Responder_RemoveBuff : UKSC_EventResponder, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D6A0 RID: 120480 RVA: 0x002B728F File Offset: 0x002B548F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Responder_RemoveBuff._ClassPtr;
		}

		// Token: 0x0601D6A1 RID: 120481 RVA: 0x002B729C File Offset: 0x002B549C
		public UKSC_Responder_RemoveBuff() : this(BuiltinUtils.AllocNativeUObject(UKSC_Responder_RemoveBuff.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D6A2 RID: 120482 RVA: 0x002B72C4 File Offset: 0x002B54C4
		[NullableContext(1)]
		public UKSC_Responder_RemoveBuff(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Responder_RemoveBuff.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007695 RID: 30357
		// (get) Token: 0x0601D6A3 RID: 120483 RVA: 0x002B72F7 File Offset: 0x002B54F7
		// (set) Token: 0x0601D6A4 RID: 120484 RVA: 0x002B730B File Offset: 0x002B550B
		[Nullable(2)]
		public unsafe UKSC_DA_Buff BuffToRemove
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Responder_RemoveBuff.__PropertyOffset_BuffToRemove);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Responder_RemoveBuff.__PropertyOffset_BuffToRemove, value);
			}
		}

		// Token: 0x17007696 RID: 30358
		// (get) Token: 0x0601D6A5 RID: 120485 RVA: 0x002B7320 File Offset: 0x002B5520
		// (set) Token: 0x0601D6A6 RID: 120486 RVA: 0x002B7330 File Offset: 0x002B5530
		public unsafe int StackNumToRemove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_Responder_RemoveBuff.__PropertyOffset_StackNumToRemove);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_Responder_RemoveBuff.__PropertyOffset_StackNumToRemove) = value;
			}
		}

		// Token: 0x0601D6A7 RID: 120487 RVA: 0x002B7341 File Offset: 0x002B5541
		static UKSC_Responder_RemoveBuff()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Responder_RemoveBuff");
		}

		// Token: 0x0601D6A8 RID: 120488 RVA: 0x002B734F File Offset: 0x002B554F
		protected UKSC_Responder_RemoveBuff(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FF31 RID: 65329
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Responder_RemoveBuff";

		// Token: 0x0400FF32 RID: 65330
		private static IntPtr _ClassPtr;

		// Token: 0x0400FF33 RID: 65331
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FF34 RID: 65332
		internal static int __PropertyOffset_BuffToRemove;

		// Token: 0x0400FF35 RID: 65333
		internal static int __PropertyOffset_StackNumToRemove;
	}
}
