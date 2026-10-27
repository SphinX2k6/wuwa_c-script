using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D28 RID: 7464
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff_OnDotOwnerDead")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UKSC_Buff_OnDotOwnerDead : UKSC_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CA37 RID: 117303 RVA: 0x002A562F File Offset: 0x002A382F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_OnDotOwnerDead._ClassPtr;
		}

		// Token: 0x0601CA38 RID: 117304 RVA: 0x002A563C File Offset: 0x002A383C
		public UKSC_Buff_OnDotOwnerDead() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_OnDotOwnerDead.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CA39 RID: 117305 RVA: 0x002A5664 File Offset: 0x002A3864
		[NullableContext(1)]
		public UKSC_Buff_OnDotOwnerDead(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_OnDotOwnerDead.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007342 RID: 29506
		// (get) Token: 0x0601CA3A RID: 117306 RVA: 0x002A5697 File Offset: 0x002A3897
		// (set) Token: 0x0601CA3B RID: 117307 RVA: 0x002A56AB File Offset: 0x002A38AB
		[Nullable(2)]
		public unsafe UKSC_DA_Buff_OnDotOwnerDead DaBuff_OnDotOwnerDead_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff_OnDotOwnerDead>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_OnDotOwnerDead.__PropertyOffset_DaBuff_OnDotOwnerDead_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_OnDotOwnerDead.__PropertyOffset_DaBuff_OnDotOwnerDead_, value);
			}
		}

		// Token: 0x0601CA3C RID: 117308 RVA: 0x002A56C0 File Offset: 0x002A38C0
		static UKSC_Buff_OnDotOwnerDead()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff_OnDotOwnerDead");
		}

		// Token: 0x0601CA3D RID: 117309 RVA: 0x002A56CE File Offset: 0x002A38CE
		protected UKSC_Buff_OnDotOwnerDead(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F868 RID: 63592
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff_OnDotOwnerDead";

		// Token: 0x0400F869 RID: 63593
		private static IntPtr _ClassPtr;

		// Token: 0x0400F86A RID: 63594
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F86B RID: 63595
		internal static int __PropertyOffset_DaBuff_OnDotOwnerDead_;
	}
}
