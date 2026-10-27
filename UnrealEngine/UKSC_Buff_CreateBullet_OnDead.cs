using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D10 RID: 7440
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff_CreateBullet_OnDead")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UKSC_Buff_CreateBullet_OnDead : UKSC_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C977 RID: 117111 RVA: 0x002A443B File Offset: 0x002A263B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_CreateBullet_OnDead._ClassPtr;
		}

		// Token: 0x0601C978 RID: 117112 RVA: 0x002A4448 File Offset: 0x002A2648
		public UKSC_Buff_CreateBullet_OnDead() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_CreateBullet_OnDead.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C979 RID: 117113 RVA: 0x002A4470 File Offset: 0x002A2670
		[NullableContext(1)]
		public UKSC_Buff_CreateBullet_OnDead(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_CreateBullet_OnDead.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007320 RID: 29472
		// (get) Token: 0x0601C97A RID: 117114 RVA: 0x002A44A3 File Offset: 0x002A26A3
		// (set) Token: 0x0601C97B RID: 117115 RVA: 0x002A44B7 File Offset: 0x002A26B7
		[Nullable(2)]
		public unsafe UKSC_DA_Buff_CreateBullet_OnDead DaBuff_CreateBullet_OnDead_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff_CreateBullet_OnDead>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_CreateBullet_OnDead.__PropertyOffset_DaBuff_CreateBullet_OnDead_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_CreateBullet_OnDead.__PropertyOffset_DaBuff_CreateBullet_OnDead_, value);
			}
		}

		// Token: 0x0601C97C RID: 117116 RVA: 0x002A44CC File Offset: 0x002A26CC
		static UKSC_Buff_CreateBullet_OnDead()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff_CreateBullet_OnDead");
		}

		// Token: 0x0601C97D RID: 117117 RVA: 0x002A44DA File Offset: 0x002A26DA
		protected UKSC_Buff_CreateBullet_OnDead(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F7FA RID: 63482
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff_CreateBullet_OnDead";

		// Token: 0x0400F7FB RID: 63483
		private static IntPtr _ClassPtr;

		// Token: 0x0400F7FC RID: 63484
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F7FD RID: 63485
		internal static int __PropertyOffset_DaBuff_CreateBullet_OnDead_;
	}
}
