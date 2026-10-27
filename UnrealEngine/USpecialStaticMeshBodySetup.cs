using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200116D RID: 4461
	[UnrealObjectPath("/Script/Engine.SpecialStaticMeshBodySetup")]
	[UnrealStructLayout(816, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 816)]
	public class USpecialStaticMeshBodySetup : UBodySetup, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060104E0 RID: 66784 RVA: 0x001804A0 File Offset: 0x0017E6A0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USpecialStaticMeshBodySetup._ClassPtr;
		}

		// Token: 0x060104E1 RID: 66785 RVA: 0x001804AC File Offset: 0x0017E6AC
		public USpecialStaticMeshBodySetup() : this(BuiltinUtils.AllocNativeUObject(USpecialStaticMeshBodySetup.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060104E2 RID: 66786 RVA: 0x001804D4 File Offset: 0x0017E6D4
		[NullableContext(1)]
		public USpecialStaticMeshBodySetup(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USpecialStaticMeshBodySetup.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060104E3 RID: 66787 RVA: 0x00180507 File Offset: 0x0017E707
		static USpecialStaticMeshBodySetup()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SpecialStaticMeshBodySetup");
		}

		// Token: 0x060104E4 RID: 66788 RVA: 0x00180515 File Offset: 0x0017E715
		protected USpecialStaticMeshBodySetup(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008C4F RID: 35919
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SpecialStaticMeshBodySetup";

		// Token: 0x04008C50 RID: 35920
		private static IntPtr _ClassPtr;

		// Token: 0x04008C51 RID: 35921
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
