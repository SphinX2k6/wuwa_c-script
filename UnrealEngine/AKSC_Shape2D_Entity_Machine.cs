using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200058D RID: 1421
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Shape2D_Entity_Machine")]
	[UnrealStructLayout(1656, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1656)]
	public class AKSC_Shape2D_Entity_Machine : AKSC_Shape2D_Entity, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060080A7 RID: 32935 RVA: 0x000BE066 File Offset: 0x000BC266
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKSC_Shape2D_Entity_Machine._ClassPtr;
		}

		// Token: 0x060080A8 RID: 32936 RVA: 0x000BE074 File Offset: 0x000BC274
		public AKSC_Shape2D_Entity_Machine() : this(BuiltinUtils.AllocNativeUObject(AKSC_Shape2D_Entity_Machine.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060080A9 RID: 32937 RVA: 0x000BE09C File Offset: 0x000BC29C
		[NullableContext(1)]
		public AKSC_Shape2D_Entity_Machine(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKSC_Shape2D_Entity_Machine.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060080AA RID: 32938 RVA: 0x000BE0CF File Offset: 0x000BC2CF
		static AKSC_Shape2D_Entity_Machine()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Shape2D_Entity_Machine");
		}

		// Token: 0x060080AB RID: 32939 RVA: 0x000BE0DD File Offset: 0x000BC2DD
		protected AKSC_Shape2D_Entity_Machine(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400382F RID: 14383
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Shape2D_Entity_Machine";

		// Token: 0x04003830 RID: 14384
		private static IntPtr _ClassPtr;

		// Token: 0x04003831 RID: 14385
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
