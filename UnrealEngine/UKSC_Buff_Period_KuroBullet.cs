using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200172D RID: 5933
	[UnrealObjectPath("/Script/KuroBullet.KSC_Buff_Period_KuroBullet")]
	[UnrealStructLayout(256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UKSC_Buff_Period_KuroBullet : UKSC_Buff_Period, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060155BB RID: 87483 RVA: 0x001F623F File Offset: 0x001F443F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_Period_KuroBullet._ClassPtr;
		}

		// Token: 0x060155BC RID: 87484 RVA: 0x001F624C File Offset: 0x001F444C
		public UKSC_Buff_Period_KuroBullet() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_Period_KuroBullet.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060155BD RID: 87485 RVA: 0x001F6274 File Offset: 0x001F4474
		[NullableContext(1)]
		public UKSC_Buff_Period_KuroBullet(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_Period_KuroBullet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700545B RID: 21595
		// (get) Token: 0x060155BE RID: 87486 RVA: 0x001F62A7 File Offset: 0x001F44A7
		// (set) Token: 0x060155BF RID: 87487 RVA: 0x001F62BB File Offset: 0x001F44BB
		[Nullable(2)]
		public unsafe UKSC_DA_Buff_Period_KuroBullet DaBuffPeriodKuroBullet_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff_Period_KuroBullet>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_Period_KuroBullet.__PropertyOffset_DaBuffPeriodKuroBullet_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_Period_KuroBullet.__PropertyOffset_DaBuffPeriodKuroBullet_, value);
			}
		}

		// Token: 0x060155C0 RID: 87488 RVA: 0x001F62D0 File Offset: 0x001F44D0
		static UKSC_Buff_Period_KuroBullet()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBullet.KSC_Buff_Period_KuroBullet");
		}

		// Token: 0x060155C1 RID: 87489 RVA: 0x001F62DE File Offset: 0x001F44DE
		protected UKSC_Buff_Period_KuroBullet(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BA59 RID: 47705
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBullet.KSC_Buff_Period_KuroBullet";

		// Token: 0x0400BA5A RID: 47706
		private static IntPtr _ClassPtr;

		// Token: 0x0400BA5B RID: 47707
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400BA5C RID: 47708
		internal static int __PropertyOffset_DaBuffPeriodKuroBullet_;
	}
}
