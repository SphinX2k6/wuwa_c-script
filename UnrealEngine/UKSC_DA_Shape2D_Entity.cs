using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DB0 RID: 7600
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Shape2D_Entity")]
	[UnrealStructLayout(400, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 400)]
	public class UKSC_DA_Shape2D_Entity : UKSC_DA_Entity, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D0C3 RID: 118979 RVA: 0x002AEE53 File Offset: 0x002AD053
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Shape2D_Entity._ClassPtr;
		}

		// Token: 0x0601D0C4 RID: 118980 RVA: 0x002AEE60 File Offset: 0x002AD060
		public UKSC_DA_Shape2D_Entity() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Shape2D_Entity.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D0C5 RID: 118981 RVA: 0x002AEE88 File Offset: 0x002AD088
		[NullableContext(1)]
		public UKSC_DA_Shape2D_Entity(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Shape2D_Entity.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601D0C6 RID: 118982 RVA: 0x002AEEBB File Offset: 0x002AD0BB
		static UKSC_DA_Shape2D_Entity()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Shape2D_Entity");
		}

		// Token: 0x0601D0C7 RID: 118983 RVA: 0x002AEEC9 File Offset: 0x002AD0C9
		protected UKSC_DA_Shape2D_Entity(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FC4F RID: 64591
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Shape2D_Entity";

		// Token: 0x0400FC50 RID: 64592
		private static IntPtr _ClassPtr;

		// Token: 0x0400FC51 RID: 64593
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
