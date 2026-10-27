using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E37 RID: 7735
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Shape2D_Entity_Machine")]
	[UnrealStructLayout(1656, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1656)]
	public class AKSC_Shape2D_Entity_Machine : AKSC_Shape2D_Entity, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D78A RID: 120714 RVA: 0x002B8572 File Offset: 0x002B6772
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKSC_Shape2D_Entity_Machine._ClassPtr;
		}

		// Token: 0x0601D78B RID: 120715 RVA: 0x002B8580 File Offset: 0x002B6780
		public AKSC_Shape2D_Entity_Machine() : this(BuiltinUtils.AllocNativeUObject(AKSC_Shape2D_Entity_Machine.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D78C RID: 120716 RVA: 0x002B85A8 File Offset: 0x002B67A8
		[NullableContext(1)]
		public AKSC_Shape2D_Entity_Machine(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKSC_Shape2D_Entity_Machine.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601D78D RID: 120717 RVA: 0x002B85DB File Offset: 0x002B67DB
		static AKSC_Shape2D_Entity_Machine()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Shape2D_Entity_Machine");
		}

		// Token: 0x0601D78E RID: 120718 RVA: 0x002B85E9 File Offset: 0x002B67E9
		protected AKSC_Shape2D_Entity_Machine(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FFA7 RID: 65447
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Shape2D_Entity_Machine";

		// Token: 0x0400FFA8 RID: 65448
		private static IntPtr _ClassPtr;

		// Token: 0x0400FFA9 RID: 65449
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
