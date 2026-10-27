using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D6F RID: 7535
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff_ModifyHitDamage")]
	[UnrealStructLayout(432, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 432)]
	public class UKSC_DA_Buff_ModifyHitDamage : UKSC_DA_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CDDC RID: 118236 RVA: 0x002AAB3B File Offset: 0x002A8D3B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_ModifyHitDamage._ClassPtr;
		}

		// Token: 0x0601CDDD RID: 118237 RVA: 0x002AAB48 File Offset: 0x002A8D48
		public UKSC_DA_Buff_ModifyHitDamage() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_ModifyHitDamage.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CDDE RID: 118238 RVA: 0x002AAB70 File Offset: 0x002A8D70
		[NullableContext(1)]
		public UKSC_DA_Buff_ModifyHitDamage(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_ModifyHitDamage.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700745C RID: 29788
		// (get) Token: 0x0601CDDF RID: 118239 RVA: 0x002AABA3 File Offset: 0x002A8DA3
		// (set) Token: 0x0601CDE0 RID: 118240 RVA: 0x002AABB3 File Offset: 0x002A8DB3
		public unsafe int ModifyValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_ModifyHitDamage.__PropertyOffset_ModifyValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ModifyHitDamage.__PropertyOffset_ModifyValue) = value;
			}
		}

		// Token: 0x0601CDE1 RID: 118241 RVA: 0x002AABC4 File Offset: 0x002A8DC4
		static UKSC_DA_Buff_ModifyHitDamage()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff_ModifyHitDamage");
		}

		// Token: 0x0601CDE2 RID: 118242 RVA: 0x002AABD2 File Offset: 0x002A8DD2
		protected UKSC_DA_Buff_ModifyHitDamage(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FA91 RID: 64145
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff_ModifyHitDamage";

		// Token: 0x0400FA92 RID: 64146
		private static IntPtr _ClassPtr;

		// Token: 0x0400FA93 RID: 64147
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FA94 RID: 64148
		internal static int __PropertyOffset_ModifyValue;
	}
}
