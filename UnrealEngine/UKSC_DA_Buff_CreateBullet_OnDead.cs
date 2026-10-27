using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D5A RID: 7514
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff_CreateBullet_OnDead")]
	[UnrealStructLayout(432, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 432)]
	public class UKSC_DA_Buff_CreateBullet_OnDead : UKSC_DA_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CC95 RID: 117909 RVA: 0x002A8BCB File Offset: 0x002A6DCB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_CreateBullet_OnDead._ClassPtr;
		}

		// Token: 0x0601CC96 RID: 117910 RVA: 0x002A8BD8 File Offset: 0x002A6DD8
		public UKSC_DA_Buff_CreateBullet_OnDead() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_CreateBullet_OnDead.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CC97 RID: 117911 RVA: 0x002A8C00 File Offset: 0x002A6E00
		[NullableContext(1)]
		public UKSC_DA_Buff_CreateBullet_OnDead(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_CreateBullet_OnDead.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170073ED RID: 29677
		// (get) Token: 0x0601CC98 RID: 117912 RVA: 0x002A8C33 File Offset: 0x002A6E33
		// (set) Token: 0x0601CC99 RID: 117913 RVA: 0x002A8C43 File Offset: 0x002A6E43
		public unsafe long BulletID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_CreateBullet_OnDead.__PropertyOffset_BulletID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_CreateBullet_OnDead.__PropertyOffset_BulletID) = value;
			}
		}

		// Token: 0x0601CC9A RID: 117914 RVA: 0x002A8C54 File Offset: 0x002A6E54
		static UKSC_DA_Buff_CreateBullet_OnDead()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff_CreateBullet_OnDead");
		}

		// Token: 0x0601CC9B RID: 117915 RVA: 0x002A8C62 File Offset: 0x002A6E62
		protected UKSC_DA_Buff_CreateBullet_OnDead(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F9C3 RID: 63939
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff_CreateBullet_OnDead";

		// Token: 0x0400F9C4 RID: 63940
		private static IntPtr _ClassPtr;

		// Token: 0x0400F9C5 RID: 63941
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F9C6 RID: 63942
		internal static int __PropertyOffset_BulletID;
	}
}
