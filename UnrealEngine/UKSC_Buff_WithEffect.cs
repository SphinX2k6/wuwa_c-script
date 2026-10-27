using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D3D RID: 7485
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff_WithEffect")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UKSC_Buff_WithEffect : UKSC_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CACE RID: 117454 RVA: 0x002A6417 File Offset: 0x002A4617
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_WithEffect._ClassPtr;
		}

		// Token: 0x0601CACF RID: 117455 RVA: 0x002A6424 File Offset: 0x002A4624
		public UKSC_Buff_WithEffect() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_WithEffect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CAD0 RID: 117456 RVA: 0x002A644C File Offset: 0x002A464C
		public UKSC_Buff_WithEffect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_WithEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007357 RID: 29527
		// (get) Token: 0x0601CAD1 RID: 117457 RVA: 0x002A647F File Offset: 0x002A467F
		// (set) Token: 0x0601CAD2 RID: 117458 RVA: 0x002A6493 File Offset: 0x002A4693
		[Nullable(2)]
		public unsafe UKSC_DA_Buff_WithEffect DaBuffWithEffect
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff_WithEffect>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_WithEffect.__PropertyOffset_DaBuffWithEffect);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_WithEffect.__PropertyOffset_DaBuffWithEffect, value);
			}
		}

		// Token: 0x17007358 RID: 29528
		// (get) Token: 0x0601CAD3 RID: 117459 RVA: 0x002A64A8 File Offset: 0x002A46A8
		// (set) Token: 0x0601CAD4 RID: 117460 RVA: 0x002A64E1 File Offset: 0x002A46E1
		public TArray<UKSC_BuffEffectBase> BuffEffectInstances
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UKSC_BuffEffectBase> result;
				if ((result = this._BuffEffectInstances) == null)
				{
					result = (this._BuffEffectInstances = new TArray<UKSC_BuffEffectBase>(base.NativePtr + (IntPtr)UKSC_Buff_WithEffect.__PropertyOffset_BuffEffectInstances, this));
				}
				return result;
			}
			set
			{
				this.BuffEffectInstances.CopyAssign(value);
			}
		}

		// Token: 0x0601CAD5 RID: 117461 RVA: 0x002A64EF File Offset: 0x002A46EF
		static UKSC_Buff_WithEffect()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff_WithEffect");
		}

		// Token: 0x0601CAD6 RID: 117462 RVA: 0x002A64FD File Offset: 0x002A46FD
		protected UKSC_Buff_WithEffect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F8BC RID: 63676
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff_WithEffect";

		// Token: 0x0400F8BD RID: 63677
		private static IntPtr _ClassPtr;

		// Token: 0x0400F8BE RID: 63678
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F8BF RID: 63679
		internal static int __PropertyOffset_DaBuffWithEffect;

		// Token: 0x0400F8C0 RID: 63680
		internal static int __PropertyOffset_BuffEffectInstances;

		// Token: 0x0400F8C1 RID: 63681
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKSC_BuffEffectBase> _BuffEffectInstances;
	}
}
