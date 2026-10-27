using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D07 RID: 7431
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff_AddMaterial")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UKSC_Buff_AddMaterial : UKSC_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C934 RID: 117044 RVA: 0x002A3E33 File Offset: 0x002A2033
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_AddMaterial._ClassPtr;
		}

		// Token: 0x0601C935 RID: 117045 RVA: 0x002A3E40 File Offset: 0x002A2040
		public UKSC_Buff_AddMaterial() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_AddMaterial.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C936 RID: 117046 RVA: 0x002A3E68 File Offset: 0x002A2068
		[NullableContext(1)]
		public UKSC_Buff_AddMaterial(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_AddMaterial.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007317 RID: 29463
		// (get) Token: 0x0601C937 RID: 117047 RVA: 0x002A3E9B File Offset: 0x002A209B
		// (set) Token: 0x0601C938 RID: 117048 RVA: 0x002A3EAF File Offset: 0x002A20AF
		[Nullable(2)]
		public unsafe UKSC_DA_Buff_AddMaterial DaBuffAddMaterial_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff_AddMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_AddMaterial.__PropertyOffset_DaBuffAddMaterial_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_AddMaterial.__PropertyOffset_DaBuffAddMaterial_, value);
			}
		}

		// Token: 0x0601C939 RID: 117049 RVA: 0x002A3EC4 File Offset: 0x002A20C4
		static UKSC_Buff_AddMaterial()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff_AddMaterial");
		}

		// Token: 0x0601C93A RID: 117050 RVA: 0x002A3ED2 File Offset: 0x002A20D2
		protected UKSC_Buff_AddMaterial(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F7D6 RID: 63446
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff_AddMaterial";

		// Token: 0x0400F7D7 RID: 63447
		private static IntPtr _ClassPtr;

		// Token: 0x0400F7D8 RID: 63448
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F7D9 RID: 63449
		internal static int __PropertyOffset_DaBuffAddMaterial_;
	}
}
