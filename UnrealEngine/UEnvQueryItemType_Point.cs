using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001A3 RID: 419
	[UnrealObjectPath("/Script/AIModule.EnvQueryItemType_Point")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UEnvQueryItemType_Point : UEnvQueryItemType_VectorBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060019C2 RID: 6594 RVA: 0x00026336 File Offset: 0x00024536
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEnvQueryItemType_Point._ClassPtr;
		}

		// Token: 0x060019C3 RID: 6595 RVA: 0x00026344 File Offset: 0x00024544
		public UEnvQueryItemType_Point() : this(BuiltinUtils.AllocNativeUObject(UEnvQueryItemType_Point.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060019C4 RID: 6596 RVA: 0x0002636C File Offset: 0x0002456C
		[NullableContext(1)]
		public UEnvQueryItemType_Point(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEnvQueryItemType_Point.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060019C5 RID: 6597 RVA: 0x0002639F File Offset: 0x0002459F
		static UEnvQueryItemType_Point()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.EnvQueryItemType_Point");
		}

		// Token: 0x060019C6 RID: 6598 RVA: 0x000263AD File Offset: 0x000245AD
		protected UEnvQueryItemType_Point(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000794 RID: 1940
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.EnvQueryItemType_Point";

		// Token: 0x04000795 RID: 1941
		private static IntPtr _ClassPtr;

		// Token: 0x04000796 RID: 1942
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
