using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E01 RID: 7681
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Move")]
	[UnrealStructLayout(488, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 488)]
	public abstract class UKSC_Move : UKSC_BaseObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D572 RID: 120178 RVA: 0x002B506E File Offset: 0x002B326E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Move._ClassPtr;
		}

		// Token: 0x17007671 RID: 30321
		// (get) Token: 0x0601D573 RID: 120179 RVA: 0x002B507A File Offset: 0x002B327A
		// (set) Token: 0x0601D574 RID: 120180 RVA: 0x002B508E File Offset: 0x002B328E
		public unsafe AKSC_Entity Owner_
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AKSC_Entity>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Move.__PropertyOffset_Owner_);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Move.__PropertyOffset_Owner_, value);
			}
		}

		// Token: 0x17007672 RID: 30322
		// (get) Token: 0x0601D575 RID: 120181 RVA: 0x002B50A3 File Offset: 0x002B32A3
		// (set) Token: 0x0601D576 RID: 120182 RVA: 0x002B50B7 File Offset: 0x002B32B7
		public unsafe UKSC_DA_Move Move_
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Move>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Move.__PropertyOffset_Move_);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Move.__PropertyOffset_Move_, value);
			}
		}

		// Token: 0x0601D577 RID: 120183 RVA: 0x002B50CC File Offset: 0x002B32CC
		static UKSC_Move()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Move");
		}

		// Token: 0x0601D578 RID: 120184 RVA: 0x002B50DC File Offset: 0x002B32DC
		protected UKSC_Move() : this(BuiltinUtils.AllocNativeUObject(UKSC_Move.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D579 RID: 120185 RVA: 0x002B5104 File Offset: 0x002B3304
		protected UKSC_Move(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FEA8 RID: 65192
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Move";

		// Token: 0x0400FEA9 RID: 65193
		private static IntPtr _ClassPtr;

		// Token: 0x0400FEAA RID: 65194
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FEAB RID: 65195
		internal static int __PropertyOffset_Owner_;

		// Token: 0x0400FEAC RID: 65196
		internal static int __PropertyOffset_Move_;
	}
}
