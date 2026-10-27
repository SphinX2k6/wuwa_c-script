using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D25 RID: 7461
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff_ModifyHitDamage")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UKSC_Buff_ModifyHitDamage : UKSC_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CA22 RID: 117282 RVA: 0x002A5437 File Offset: 0x002A3637
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_ModifyHitDamage._ClassPtr;
		}

		// Token: 0x0601CA23 RID: 117283 RVA: 0x002A5444 File Offset: 0x002A3644
		public UKSC_Buff_ModifyHitDamage() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_ModifyHitDamage.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CA24 RID: 117284 RVA: 0x002A546C File Offset: 0x002A366C
		[NullableContext(1)]
		public UKSC_Buff_ModifyHitDamage(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_ModifyHitDamage.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700733F RID: 29503
		// (get) Token: 0x0601CA25 RID: 117285 RVA: 0x002A549F File Offset: 0x002A369F
		// (set) Token: 0x0601CA26 RID: 117286 RVA: 0x002A54B3 File Offset: 0x002A36B3
		[Nullable(2)]
		public unsafe UKSC_DA_Buff_ModifyHitDamage DaBuffModifyHitDamage_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff_ModifyHitDamage>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_ModifyHitDamage.__PropertyOffset_DaBuffModifyHitDamage_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_ModifyHitDamage.__PropertyOffset_DaBuffModifyHitDamage_, value);
			}
		}

		// Token: 0x0601CA27 RID: 117287 RVA: 0x002A54C8 File Offset: 0x002A36C8
		static UKSC_Buff_ModifyHitDamage()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff_ModifyHitDamage");
		}

		// Token: 0x0601CA28 RID: 117288 RVA: 0x002A54D6 File Offset: 0x002A36D6
		protected UKSC_Buff_ModifyHitDamage(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F85C RID: 63580
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff_ModifyHitDamage";

		// Token: 0x0400F85D RID: 63581
		private static IntPtr _ClassPtr;

		// Token: 0x0400F85E RID: 63582
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F85F RID: 63583
		internal static int __PropertyOffset_DaBuffModifyHitDamage_;
	}
}
