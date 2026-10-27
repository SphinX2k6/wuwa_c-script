using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DE0 RID: 7648
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Entity_Player")]
	[UnrealStructLayout(1272, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1272)]
	public class AKSC_Entity_Player : AKSC_Entity, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D3A0 RID: 119712 RVA: 0x002B2A1D File Offset: 0x002B0C1D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKSC_Entity_Player._ClassPtr;
		}

		// Token: 0x0601D3A1 RID: 119713 RVA: 0x002B2A2C File Offset: 0x002B0C2C
		public AKSC_Entity_Player() : this(BuiltinUtils.AllocNativeUObject(AKSC_Entity_Player.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D3A2 RID: 119714 RVA: 0x002B2A54 File Offset: 0x002B0C54
		[NullableContext(1)]
		public AKSC_Entity_Player(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKSC_Entity_Player.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601D3A3 RID: 119715 RVA: 0x002B2A87 File Offset: 0x002B0C87
		static AKSC_Entity_Player()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Entity_Player");
		}

		// Token: 0x0601D3A4 RID: 119716 RVA: 0x002B2A95 File Offset: 0x002B0C95
		protected AKSC_Entity_Player(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FDC6 RID: 64966
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Entity_Player";

		// Token: 0x0400FDC7 RID: 64967
		private static IntPtr _ClassPtr;

		// Token: 0x0400FDC8 RID: 64968
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
