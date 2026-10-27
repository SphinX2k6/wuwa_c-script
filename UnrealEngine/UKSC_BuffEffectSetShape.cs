using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D02 RID: 7426
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_BuffEffectSetShape")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UKSC_BuffEffectSetShape : UKSC_BuffEffectBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C90E RID: 117006 RVA: 0x002A3ABF File Offset: 0x002A1CBF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_BuffEffectSetShape._ClassPtr;
		}

		// Token: 0x0601C90F RID: 117007 RVA: 0x002A3ACC File Offset: 0x002A1CCC
		public UKSC_BuffEffectSetShape() : this(BuiltinUtils.AllocNativeUObject(UKSC_BuffEffectSetShape.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C910 RID: 117008 RVA: 0x002A3AF4 File Offset: 0x002A1CF4
		[NullableContext(1)]
		public UKSC_BuffEffectSetShape(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_BuffEffectSetShape.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007313 RID: 29459
		// (get) Token: 0x0601C911 RID: 117009 RVA: 0x002A3B27 File Offset: 0x002A1D27
		// (set) Token: 0x0601C912 RID: 117010 RVA: 0x002A3B3B File Offset: 0x002A1D3B
		[Nullable(2)]
		public unsafe UKSC_DA_BuffEffectSetShape DaBuffEffect
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_BuffEffectSetShape>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_BuffEffectSetShape.__PropertyOffset_DaBuffEffect);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_BuffEffectSetShape.__PropertyOffset_DaBuffEffect, value);
			}
		}

		// Token: 0x0601C913 RID: 117011 RVA: 0x002A3B50 File Offset: 0x002A1D50
		static UKSC_BuffEffectSetShape()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_BuffEffectSetShape");
		}

		// Token: 0x0601C914 RID: 117012 RVA: 0x002A3B5E File Offset: 0x002A1D5E
		protected UKSC_BuffEffectSetShape(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F7C1 RID: 63425
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_BuffEffectSetShape";

		// Token: 0x0400F7C2 RID: 63426
		private static IntPtr _ClassPtr;

		// Token: 0x0400F7C3 RID: 63427
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F7C4 RID: 63428
		internal static int __PropertyOffset_DaBuffEffect;
	}
}
