using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D06 RID: 7430
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_BuffShieldEffect")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UKSC_BuffShieldEffect : UKSC_BuffEffectBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C92D RID: 117037 RVA: 0x002A3D89 File Offset: 0x002A1F89
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_BuffShieldEffect._ClassPtr;
		}

		// Token: 0x0601C92E RID: 117038 RVA: 0x002A3D98 File Offset: 0x002A1F98
		public UKSC_BuffShieldEffect() : this(BuiltinUtils.AllocNativeUObject(UKSC_BuffShieldEffect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C92F RID: 117039 RVA: 0x002A3DC0 File Offset: 0x002A1FC0
		[NullableContext(1)]
		public UKSC_BuffShieldEffect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_BuffShieldEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007316 RID: 29462
		// (get) Token: 0x0601C930 RID: 117040 RVA: 0x002A3DF3 File Offset: 0x002A1FF3
		// (set) Token: 0x0601C931 RID: 117041 RVA: 0x002A3E07 File Offset: 0x002A2007
		[Nullable(2)]
		public unsafe UKSC_DA_AddShield DaBuffEffect
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_AddShield>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_BuffShieldEffect.__PropertyOffset_DaBuffEffect);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_BuffShieldEffect.__PropertyOffset_DaBuffEffect, value);
			}
		}

		// Token: 0x0601C932 RID: 117042 RVA: 0x002A3E1C File Offset: 0x002A201C
		static UKSC_BuffShieldEffect()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_BuffShieldEffect");
		}

		// Token: 0x0601C933 RID: 117043 RVA: 0x002A3E2A File Offset: 0x002A202A
		protected UKSC_BuffShieldEffect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F7D2 RID: 63442
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_BuffShieldEffect";

		// Token: 0x0400F7D3 RID: 63443
		private static IntPtr _ClassPtr;

		// Token: 0x0400F7D4 RID: 63444
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F7D5 RID: 63445
		internal static int __PropertyOffset_DaBuffEffect;
	}
}
