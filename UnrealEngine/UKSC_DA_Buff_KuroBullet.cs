using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200172E RID: 5934
	[UnrealObjectPath("/Script/KuroBullet.KSC_DA_Buff_KuroBullet")]
	[UnrealStructLayout(448, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 448)]
	public class UKSC_DA_Buff_KuroBullet : UKSC_DA_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060155C2 RID: 87490 RVA: 0x001F62E7 File Offset: 0x001F44E7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_KuroBullet._ClassPtr;
		}

		// Token: 0x060155C3 RID: 87491 RVA: 0x001F62F4 File Offset: 0x001F44F4
		public UKSC_DA_Buff_KuroBullet() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_KuroBullet.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060155C4 RID: 87492 RVA: 0x001F631C File Offset: 0x001F451C
		[NullableContext(1)]
		public UKSC_DA_Buff_KuroBullet(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_KuroBullet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700545C RID: 21596
		// (get) Token: 0x060155C5 RID: 87493 RVA: 0x001F634F File Offset: 0x001F454F
		// (set) Token: 0x060155C6 RID: 87494 RVA: 0x001F635F File Offset: 0x001F455F
		public unsafe long BulletId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_KuroBullet.__PropertyOffset_BulletId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_KuroBullet.__PropertyOffset_BulletId) = value;
			}
		}

		// Token: 0x1700545D RID: 21597
		// (get) Token: 0x060155C7 RID: 87495 RVA: 0x001F6370 File Offset: 0x001F4570
		// (set) Token: 0x060155C8 RID: 87496 RVA: 0x001F6380 File Offset: 0x001F4580
		public unsafe bool DestroyBulletOnBuffEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_KuroBullet.__PropertyOffset_DestroyBulletOnBuffEnd) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_KuroBullet.__PropertyOffset_DestroyBulletOnBuffEnd) = (value ? 1 : 0);
			}
		}

		// Token: 0x060155C9 RID: 87497 RVA: 0x001F6391 File Offset: 0x001F4591
		static UKSC_DA_Buff_KuroBullet()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBullet.KSC_DA_Buff_KuroBullet");
		}

		// Token: 0x060155CA RID: 87498 RVA: 0x001F639F File Offset: 0x001F459F
		protected UKSC_DA_Buff_KuroBullet(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BA5D RID: 47709
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBullet.KSC_DA_Buff_KuroBullet";

		// Token: 0x0400BA5E RID: 47710
		private static IntPtr _ClassPtr;

		// Token: 0x0400BA5F RID: 47711
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400BA60 RID: 47712
		internal static int __PropertyOffset_BulletId;

		// Token: 0x0400BA61 RID: 47713
		internal static int __PropertyOffset_DestroyBulletOnBuffEnd;
	}
}
