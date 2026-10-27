using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D0C RID: 7436
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff_AttrLockUpperBound")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UKSC_Buff_AttrLockUpperBound : UKSC_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C959 RID: 117081 RVA: 0x002A418B File Offset: 0x002A238B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_AttrLockUpperBound._ClassPtr;
		}

		// Token: 0x0601C95A RID: 117082 RVA: 0x002A4198 File Offset: 0x002A2398
		public UKSC_Buff_AttrLockUpperBound() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_AttrLockUpperBound.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C95B RID: 117083 RVA: 0x002A41C0 File Offset: 0x002A23C0
		[NullableContext(1)]
		public UKSC_Buff_AttrLockUpperBound(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_AttrLockUpperBound.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700731C RID: 29468
		// (get) Token: 0x0601C95C RID: 117084 RVA: 0x002A41F3 File Offset: 0x002A23F3
		// (set) Token: 0x0601C95D RID: 117085 RVA: 0x002A4207 File Offset: 0x002A2407
		[Nullable(2)]
		public unsafe UKSC_DA_Buff_AttrLockUpperBound DaBuffAttrLockUpperBound_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff_AttrLockUpperBound>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_AttrLockUpperBound.__PropertyOffset_DaBuffAttrLockUpperBound_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_AttrLockUpperBound.__PropertyOffset_DaBuffAttrLockUpperBound_, value);
			}
		}

		// Token: 0x0601C95E RID: 117086 RVA: 0x002A421C File Offset: 0x002A241C
		static UKSC_Buff_AttrLockUpperBound()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff_AttrLockUpperBound");
		}

		// Token: 0x0601C95F RID: 117087 RVA: 0x002A422A File Offset: 0x002A242A
		protected UKSC_Buff_AttrLockUpperBound(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F7EA RID: 63466
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff_AttrLockUpperBound";

		// Token: 0x0400F7EB RID: 63467
		private static IntPtr _ClassPtr;

		// Token: 0x0400F7EC RID: 63468
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F7ED RID: 63469
		internal static int __PropertyOffset_DaBuffAttrLockUpperBound_;
	}
}
