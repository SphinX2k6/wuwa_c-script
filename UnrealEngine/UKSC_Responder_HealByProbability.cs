using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E21 RID: 7713
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Responder_HealByProbability")]
	[UnrealStructLayout(176, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public class UKSC_Responder_HealByProbability : UKSC_EventResponder, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D68E RID: 120462 RVA: 0x002B70F9 File Offset: 0x002B52F9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Responder_HealByProbability._ClassPtr;
		}

		// Token: 0x0601D68F RID: 120463 RVA: 0x002B7108 File Offset: 0x002B5308
		public UKSC_Responder_HealByProbability() : this(BuiltinUtils.AllocNativeUObject(UKSC_Responder_HealByProbability.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D690 RID: 120464 RVA: 0x002B7130 File Offset: 0x002B5330
		[NullableContext(1)]
		public UKSC_Responder_HealByProbability(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Responder_HealByProbability.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007691 RID: 30353
		// (get) Token: 0x0601D691 RID: 120465 RVA: 0x002B7163 File Offset: 0x002B5363
		// (set) Token: 0x0601D692 RID: 120466 RVA: 0x002B7177 File Offset: 0x002B5377
		[Nullable(2)]
		public unsafe UEffectModelBase HealFX
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEffectModelBase>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Responder_HealByProbability.__PropertyOffset_HealFX);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Responder_HealByProbability.__PropertyOffset_HealFX, value);
			}
		}

		// Token: 0x17007692 RID: 30354
		// (get) Token: 0x0601D693 RID: 120467 RVA: 0x002B718C File Offset: 0x002B538C
		// (set) Token: 0x0601D694 RID: 120468 RVA: 0x002B71A0 File Offset: 0x002B53A0
		public unsafe FTransform HealFX_Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_Responder_HealByProbability.__PropertyOffset_HealFX_Offset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_Responder_HealByProbability.__PropertyOffset_HealFX_Offset) = value;
			}
		}

		// Token: 0x17007693 RID: 30355
		// (get) Token: 0x0601D695 RID: 120469 RVA: 0x002B71B5 File Offset: 0x002B53B5
		// (set) Token: 0x0601D696 RID: 120470 RVA: 0x002B71C5 File Offset: 0x002B53C5
		public unsafe int HealFX_MaxNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_Responder_HealByProbability.__PropertyOffset_HealFX_MaxNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_Responder_HealByProbability.__PropertyOffset_HealFX_MaxNum) = value;
			}
		}

		// Token: 0x0601D697 RID: 120471 RVA: 0x002B71D6 File Offset: 0x002B53D6
		static UKSC_Responder_HealByProbability()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Responder_HealByProbability");
		}

		// Token: 0x0601D698 RID: 120472 RVA: 0x002B71E4 File Offset: 0x002B53E4
		protected UKSC_Responder_HealByProbability(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FF27 RID: 65319
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Responder_HealByProbability";

		// Token: 0x0400FF28 RID: 65320
		private static IntPtr _ClassPtr;

		// Token: 0x0400FF29 RID: 65321
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FF2A RID: 65322
		internal static int __PropertyOffset_HealFX;

		// Token: 0x0400FF2B RID: 65323
		internal static int __PropertyOffset_HealFX_Offset;

		// Token: 0x0400FF2C RID: 65324
		internal static int __PropertyOffset_HealFX_MaxNum;
	}
}
