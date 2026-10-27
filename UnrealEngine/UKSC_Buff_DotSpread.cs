using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D14 RID: 7444
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff_DotSpread")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UKSC_Buff_DotSpread : UKSC_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C995 RID: 117141 RVA: 0x002A46EA File Offset: 0x002A28EA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_DotSpread._ClassPtr;
		}

		// Token: 0x0601C996 RID: 117142 RVA: 0x002A46F8 File Offset: 0x002A28F8
		public UKSC_Buff_DotSpread() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_DotSpread.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C997 RID: 117143 RVA: 0x002A4720 File Offset: 0x002A2920
		[NullableContext(1)]
		public UKSC_Buff_DotSpread(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_DotSpread.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007324 RID: 29476
		// (get) Token: 0x0601C998 RID: 117144 RVA: 0x002A4753 File Offset: 0x002A2953
		// (set) Token: 0x0601C999 RID: 117145 RVA: 0x002A4767 File Offset: 0x002A2967
		[Nullable(2)]
		public unsafe UKSC_DA_Buff_DotSpread DaBuffDotSpread_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff_DotSpread>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_DotSpread.__PropertyOffset_DaBuffDotSpread_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_DotSpread.__PropertyOffset_DaBuffDotSpread_, value);
			}
		}

		// Token: 0x0601C99A RID: 117146 RVA: 0x002A477C File Offset: 0x002A297C
		static UKSC_Buff_DotSpread()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff_DotSpread");
		}

		// Token: 0x0601C99B RID: 117147 RVA: 0x002A478A File Offset: 0x002A298A
		protected UKSC_Buff_DotSpread(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F80A RID: 63498
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff_DotSpread";

		// Token: 0x0400F80B RID: 63499
		private static IntPtr _ClassPtr;

		// Token: 0x0400F80C RID: 63500
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F80D RID: 63501
		internal static int __PropertyOffset_DaBuffDotSpread_;
	}
}
