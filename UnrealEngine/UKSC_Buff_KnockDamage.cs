using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D19 RID: 7449
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff_KnockDamage")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UKSC_Buff_KnockDamage : UKSC_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C9B8 RID: 117176 RVA: 0x002A4A33 File Offset: 0x002A2C33
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_KnockDamage._ClassPtr;
		}

		// Token: 0x0601C9B9 RID: 117177 RVA: 0x002A4A40 File Offset: 0x002A2C40
		public UKSC_Buff_KnockDamage() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_KnockDamage.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C9BA RID: 117178 RVA: 0x002A4A68 File Offset: 0x002A2C68
		public UKSC_Buff_KnockDamage(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_KnockDamage.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007329 RID: 29481
		// (get) Token: 0x0601C9BB RID: 117179 RVA: 0x002A4A9B File Offset: 0x002A2C9B
		// (set) Token: 0x0601C9BC RID: 117180 RVA: 0x002A4AAF File Offset: 0x002A2CAF
		[Nullable(2)]
		public unsafe UKSC_DA_Buff_KnockDamage DaBuffKnockDamage_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff_KnockDamage>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_KnockDamage.__PropertyOffset_DaBuffKnockDamage_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_KnockDamage.__PropertyOffset_DaBuffKnockDamage_, value);
			}
		}

		// Token: 0x1700732A RID: 29482
		// (get) Token: 0x0601C9BD RID: 117181 RVA: 0x002A4AC4 File Offset: 0x002A2CC4
		// (set) Token: 0x0601C9BE RID: 117182 RVA: 0x002A4AFD File Offset: 0x002A2CFD
		public TArray<UKSC_DelayKnockDamage> DelayKnockDamageList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UKSC_DelayKnockDamage> result;
				if ((result = this._DelayKnockDamageList) == null)
				{
					result = (this._DelayKnockDamageList = new TArray<UKSC_DelayKnockDamage>(base.NativePtr + (IntPtr)UKSC_Buff_KnockDamage.__PropertyOffset_DelayKnockDamageList, this));
				}
				return result;
			}
			set
			{
				this.DelayKnockDamageList.CopyAssign(value);
			}
		}

		// Token: 0x0601C9BF RID: 117183 RVA: 0x002A4B0B File Offset: 0x002A2D0B
		static UKSC_Buff_KnockDamage()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff_KnockDamage");
		}

		// Token: 0x0601C9C0 RID: 117184 RVA: 0x002A4B19 File Offset: 0x002A2D19
		protected UKSC_Buff_KnockDamage(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F81E RID: 63518
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff_KnockDamage";

		// Token: 0x0400F81F RID: 63519
		private static IntPtr _ClassPtr;

		// Token: 0x0400F820 RID: 63520
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F821 RID: 63521
		internal static int __PropertyOffset_DaBuffKnockDamage_;

		// Token: 0x0400F822 RID: 63522
		internal static int __PropertyOffset_DelayKnockDamageList;

		// Token: 0x0400F823 RID: 63523
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKSC_DelayKnockDamage> _DelayKnockDamageList;
	}
}
