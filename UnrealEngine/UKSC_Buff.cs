using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001CFF RID: 7423
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UKSC_Buff : UKSC_BaseObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C8F4 RID: 116980 RVA: 0x002A3892 File Offset: 0x002A1A92
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff._ClassPtr;
		}

		// Token: 0x0601C8F5 RID: 116981 RVA: 0x002A38A0 File Offset: 0x002A1AA0
		public UKSC_Buff() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C8F6 RID: 116982 RVA: 0x002A38C8 File Offset: 0x002A1AC8
		[NullableContext(1)]
		public UKSC_Buff(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700730E RID: 29454
		// (get) Token: 0x0601C8F7 RID: 116983 RVA: 0x002A38FB File Offset: 0x002A1AFB
		// (set) Token: 0x0601C8F8 RID: 116984 RVA: 0x002A390F File Offset: 0x002A1B0F
		public unsafe UKSC_SkillComp Caster_
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_SkillComp>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff.__PropertyOffset_Caster_);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff.__PropertyOffset_Caster_, value);
			}
		}

		// Token: 0x1700730F RID: 29455
		// (get) Token: 0x0601C8F9 RID: 116985 RVA: 0x002A3924 File Offset: 0x002A1B24
		// (set) Token: 0x0601C8FA RID: 116986 RVA: 0x002A3938 File Offset: 0x002A1B38
		public unsafe UKSC_SkillComp Owner_
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_SkillComp>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff.__PropertyOffset_Owner_);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff.__PropertyOffset_Owner_, value);
			}
		}

		// Token: 0x17007310 RID: 29456
		// (get) Token: 0x0601C8FB RID: 116987 RVA: 0x002A394D File Offset: 0x002A1B4D
		// (set) Token: 0x0601C8FC RID: 116988 RVA: 0x002A3961 File Offset: 0x002A1B61
		public unsafe UKSC_DA_Buff DaBuff_
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff.__PropertyOffset_DaBuff_);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff.__PropertyOffset_DaBuff_, value);
			}
		}

		// Token: 0x0601C8FD RID: 116989 RVA: 0x002A3976 File Offset: 0x002A1B76
		[NullableContext(1)]
		public string Debug_GetInfo()
		{
			return FString.ToStringAndDeleteNativePtr(UKSC_Buff.__Debug_GetInfo_Internal(base.NativePtr));
		}

		// Token: 0x0601C8FE RID: 116990
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Debug_GetInfo_Internal(IntPtr @this);

		// Token: 0x0601C8FF RID: 116991 RVA: 0x002A3988 File Offset: 0x002A1B88
		static UKSC_Buff()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff");
		}

		// Token: 0x0601C900 RID: 116992 RVA: 0x002A3996 File Offset: 0x002A1B96
		protected UKSC_Buff(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F7B3 RID: 63411
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff";

		// Token: 0x0400F7B4 RID: 63412
		private static IntPtr _ClassPtr;

		// Token: 0x0400F7B5 RID: 63413
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F7B6 RID: 63414
		internal static int __PropertyOffset_Caster_;

		// Token: 0x0400F7B7 RID: 63415
		internal static int __PropertyOffset_Owner_;

		// Token: 0x0400F7B8 RID: 63416
		internal static int __PropertyOffset_DaBuff_;
	}
}
