using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D00 RID: 7424
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_BuffEffectBase")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public abstract class UKSC_BuffEffectBase : UKSC_BaseObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C901 RID: 116993 RVA: 0x002A399F File Offset: 0x002A1B9F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_BuffEffectBase._ClassPtr;
		}

		// Token: 0x17007311 RID: 29457
		// (get) Token: 0x0601C902 RID: 116994 RVA: 0x002A39AB File Offset: 0x002A1BAB
		// (set) Token: 0x0601C903 RID: 116995 RVA: 0x002A39BF File Offset: 0x002A1BBF
		[Nullable(2)]
		public unsafe UKSC_Buff_WithEffect OwnerBuff
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_Buff_WithEffect>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_BuffEffectBase.__PropertyOffset_OwnerBuff);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_BuffEffectBase.__PropertyOffset_OwnerBuff, value);
			}
		}

		// Token: 0x0601C904 RID: 116996 RVA: 0x002A39D4 File Offset: 0x002A1BD4
		static UKSC_BuffEffectBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_BuffEffectBase");
		}

		// Token: 0x0601C905 RID: 116997 RVA: 0x002A39E4 File Offset: 0x002A1BE4
		protected UKSC_BuffEffectBase() : this(BuiltinUtils.AllocNativeUObject(UKSC_BuffEffectBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C906 RID: 116998 RVA: 0x002A3A0C File Offset: 0x002A1C0C
		protected UKSC_BuffEffectBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F7B9 RID: 63417
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_BuffEffectBase";

		// Token: 0x0400F7BA RID: 63418
		private static IntPtr _ClassPtr;

		// Token: 0x0400F7BB RID: 63419
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F7BC RID: 63420
		internal static int __PropertyOffset_OwnerBuff;
	}
}
