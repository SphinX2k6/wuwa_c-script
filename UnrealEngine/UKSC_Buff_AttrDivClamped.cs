using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D0A RID: 7434
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff_AttrDivClamped")]
	[UnrealStructLayout(352, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 352)]
	public class UKSC_Buff_AttrDivClamped : UKSC_Buff_Stack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C949 RID: 117065 RVA: 0x002A402B File Offset: 0x002A222B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_AttrDivClamped._ClassPtr;
		}

		// Token: 0x0601C94A RID: 117066 RVA: 0x002A4038 File Offset: 0x002A2238
		public UKSC_Buff_AttrDivClamped() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_AttrDivClamped.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C94B RID: 117067 RVA: 0x002A4060 File Offset: 0x002A2260
		[NullableContext(1)]
		public UKSC_Buff_AttrDivClamped(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_AttrDivClamped.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700731A RID: 29466
		// (get) Token: 0x0601C94C RID: 117068 RVA: 0x002A4093 File Offset: 0x002A2293
		// (set) Token: 0x0601C94D RID: 117069 RVA: 0x002A40A7 File Offset: 0x002A22A7
		[Nullable(2)]
		public unsafe UKSC_DA_Buff_AttrDivClamped DaConfig
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff_AttrDivClamped>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_AttrDivClamped.__PropertyOffset_DaConfig);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_AttrDivClamped.__PropertyOffset_DaConfig, value);
			}
		}

		// Token: 0x0601C94E RID: 117070 RVA: 0x002A40BC File Offset: 0x002A22BC
		public void OnAttrChange(EKSC_AttrType AttrType, int Value)
		{
			UKSC_Buff_AttrDivClamped.__OnAttrChange_Internal(base.NativePtr, AttrType, Value);
		}

		// Token: 0x0601C94F RID: 117071
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnAttrChange_Internal(IntPtr @this, EKSC_AttrType AttrType, int Value);

		// Token: 0x0601C950 RID: 117072 RVA: 0x002A40CB File Offset: 0x002A22CB
		static UKSC_Buff_AttrDivClamped()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff_AttrDivClamped");
		}

		// Token: 0x0601C951 RID: 117073 RVA: 0x002A40D9 File Offset: 0x002A22D9
		protected UKSC_Buff_AttrDivClamped(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F7E2 RID: 63458
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff_AttrDivClamped";

		// Token: 0x0400F7E3 RID: 63459
		private static IntPtr _ClassPtr;

		// Token: 0x0400F7E4 RID: 63460
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F7E5 RID: 63461
		internal static int __PropertyOffset_DaConfig;
	}
}
