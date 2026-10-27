using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001CF9 RID: 7417
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Anim")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UKSC_Anim : UKSC_BaseObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C89F RID: 116895 RVA: 0x002A319A File Offset: 0x002A139A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Anim._ClassPtr;
		}

		// Token: 0x0601C8A0 RID: 116896 RVA: 0x002A31A8 File Offset: 0x002A13A8
		public UKSC_Anim() : this(BuiltinUtils.AllocNativeUObject(UKSC_Anim.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C8A1 RID: 116897 RVA: 0x002A31D0 File Offset: 0x002A13D0
		[NullableContext(1)]
		public UKSC_Anim(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Anim.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007301 RID: 29441
		// (get) Token: 0x0601C8A2 RID: 116898 RVA: 0x002A3203 File Offset: 0x002A1403
		// (set) Token: 0x0601C8A3 RID: 116899 RVA: 0x002A3217 File Offset: 0x002A1417
		[Nullable(2)]
		public unsafe AKSC_Entity Owner_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AKSC_Entity>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Anim.__PropertyOffset_Owner_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Anim.__PropertyOffset_Owner_, value);
			}
		}

		// Token: 0x0601C8A4 RID: 116900 RVA: 0x002A322C File Offset: 0x002A142C
		static UKSC_Anim()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Anim");
		}

		// Token: 0x0601C8A5 RID: 116901 RVA: 0x002A323A File Offset: 0x002A143A
		protected UKSC_Anim(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F78C RID: 63372
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Anim";

		// Token: 0x0400F78D RID: 63373
		private static IntPtr _ClassPtr;

		// Token: 0x0400F78E RID: 63374
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F78F RID: 63375
		internal static int __PropertyOffset_Owner_;
	}
}
