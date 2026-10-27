using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D0B RID: 7435
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff_AttrLockLowerBound")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UKSC_Buff_AttrLockLowerBound : UKSC_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C952 RID: 117074 RVA: 0x002A40E2 File Offset: 0x002A22E2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_AttrLockLowerBound._ClassPtr;
		}

		// Token: 0x0601C953 RID: 117075 RVA: 0x002A40F0 File Offset: 0x002A22F0
		public UKSC_Buff_AttrLockLowerBound() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_AttrLockLowerBound.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C954 RID: 117076 RVA: 0x002A4118 File Offset: 0x002A2318
		[NullableContext(1)]
		public UKSC_Buff_AttrLockLowerBound(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_AttrLockLowerBound.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700731B RID: 29467
		// (get) Token: 0x0601C955 RID: 117077 RVA: 0x002A414B File Offset: 0x002A234B
		// (set) Token: 0x0601C956 RID: 117078 RVA: 0x002A415F File Offset: 0x002A235F
		[Nullable(2)]
		public unsafe UKSC_DA_Buff_AttrLockLowerBound DaBuffAttrLockLowerBound_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff_AttrLockLowerBound>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_AttrLockLowerBound.__PropertyOffset_DaBuffAttrLockLowerBound_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_AttrLockLowerBound.__PropertyOffset_DaBuffAttrLockLowerBound_, value);
			}
		}

		// Token: 0x0601C957 RID: 117079 RVA: 0x002A4174 File Offset: 0x002A2374
		static UKSC_Buff_AttrLockLowerBound()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff_AttrLockLowerBound");
		}

		// Token: 0x0601C958 RID: 117080 RVA: 0x002A4182 File Offset: 0x002A2382
		protected UKSC_Buff_AttrLockLowerBound(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F7E6 RID: 63462
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff_AttrLockLowerBound";

		// Token: 0x0400F7E7 RID: 63463
		private static IntPtr _ClassPtr;

		// Token: 0x0400F7E8 RID: 63464
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F7E9 RID: 63465
		internal static int __PropertyOffset_DaBuffAttrLockLowerBound_;
	}
}
