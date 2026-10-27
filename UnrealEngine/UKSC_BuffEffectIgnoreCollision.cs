using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D01 RID: 7425
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_BuffEffectIgnoreCollision")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UKSC_BuffEffectIgnoreCollision : UKSC_BuffEffectBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C907 RID: 116999 RVA: 0x002A3A15 File Offset: 0x002A1C15
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_BuffEffectIgnoreCollision._ClassPtr;
		}

		// Token: 0x0601C908 RID: 117000 RVA: 0x002A3A24 File Offset: 0x002A1C24
		public UKSC_BuffEffectIgnoreCollision() : this(BuiltinUtils.AllocNativeUObject(UKSC_BuffEffectIgnoreCollision.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C909 RID: 117001 RVA: 0x002A3A4C File Offset: 0x002A1C4C
		[NullableContext(1)]
		public UKSC_BuffEffectIgnoreCollision(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_BuffEffectIgnoreCollision.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007312 RID: 29458
		// (get) Token: 0x0601C90A RID: 117002 RVA: 0x002A3A7F File Offset: 0x002A1C7F
		// (set) Token: 0x0601C90B RID: 117003 RVA: 0x002A3A93 File Offset: 0x002A1C93
		[Nullable(2)]
		public unsafe UKSC_DA_BuffEffectIgnoreCollision DaBuffEffect
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_BuffEffectIgnoreCollision>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_BuffEffectIgnoreCollision.__PropertyOffset_DaBuffEffect);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_BuffEffectIgnoreCollision.__PropertyOffset_DaBuffEffect, value);
			}
		}

		// Token: 0x0601C90C RID: 117004 RVA: 0x002A3AA8 File Offset: 0x002A1CA8
		static UKSC_BuffEffectIgnoreCollision()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_BuffEffectIgnoreCollision");
		}

		// Token: 0x0601C90D RID: 117005 RVA: 0x002A3AB6 File Offset: 0x002A1CB6
		protected UKSC_BuffEffectIgnoreCollision(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F7BD RID: 63421
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_BuffEffectIgnoreCollision";

		// Token: 0x0400F7BE RID: 63422
		private static IntPtr _ClassPtr;

		// Token: 0x0400F7BF RID: 63423
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F7C0 RID: 63424
		internal static int __PropertyOffset_DaBuffEffect;
	}
}
