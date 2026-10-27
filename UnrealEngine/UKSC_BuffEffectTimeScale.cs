using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D03 RID: 7427
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_BuffEffectTimeScale")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UKSC_BuffEffectTimeScale : UKSC_BuffEffectBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C915 RID: 117013 RVA: 0x002A3B67 File Offset: 0x002A1D67
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_BuffEffectTimeScale._ClassPtr;
		}

		// Token: 0x0601C916 RID: 117014 RVA: 0x002A3B74 File Offset: 0x002A1D74
		public UKSC_BuffEffectTimeScale() : this(BuiltinUtils.AllocNativeUObject(UKSC_BuffEffectTimeScale.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C917 RID: 117015 RVA: 0x002A3B9C File Offset: 0x002A1D9C
		[NullableContext(1)]
		public UKSC_BuffEffectTimeScale(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_BuffEffectTimeScale.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007314 RID: 29460
		// (get) Token: 0x0601C918 RID: 117016 RVA: 0x002A3BCF File Offset: 0x002A1DCF
		// (set) Token: 0x0601C919 RID: 117017 RVA: 0x002A3BE3 File Offset: 0x002A1DE3
		[Nullable(2)]
		public unsafe UKSC_DA_BuffEffectTimeScale DaBuffEffect
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_BuffEffectTimeScale>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_BuffEffectTimeScale.__PropertyOffset_DaBuffEffect);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_BuffEffectTimeScale.__PropertyOffset_DaBuffEffect, value);
			}
		}

		// Token: 0x0601C91A RID: 117018 RVA: 0x002A3BF8 File Offset: 0x002A1DF8
		static UKSC_BuffEffectTimeScale()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_BuffEffectTimeScale");
		}

		// Token: 0x0601C91B RID: 117019 RVA: 0x002A3C06 File Offset: 0x002A1E06
		protected UKSC_BuffEffectTimeScale(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F7C5 RID: 63429
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_BuffEffectTimeScale";

		// Token: 0x0400F7C6 RID: 63430
		private static IntPtr _ClassPtr;

		// Token: 0x0400F7C7 RID: 63431
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F7C8 RID: 63432
		internal static int __PropertyOffset_DaBuffEffect;
	}
}
