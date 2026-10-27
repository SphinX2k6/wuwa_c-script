using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001A2 RID: 418
	[UnrealObjectPath("/Script/AIModule.EnvQueryItemType_Direction")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UEnvQueryItemType_Direction : UEnvQueryItemType_VectorBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060019BD RID: 6589 RVA: 0x000262B5 File Offset: 0x000244B5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEnvQueryItemType_Direction._ClassPtr;
		}

		// Token: 0x060019BE RID: 6590 RVA: 0x000262C4 File Offset: 0x000244C4
		public UEnvQueryItemType_Direction() : this(BuiltinUtils.AllocNativeUObject(UEnvQueryItemType_Direction.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060019BF RID: 6591 RVA: 0x000262EC File Offset: 0x000244EC
		[NullableContext(1)]
		public UEnvQueryItemType_Direction(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEnvQueryItemType_Direction.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060019C0 RID: 6592 RVA: 0x0002631F File Offset: 0x0002451F
		static UEnvQueryItemType_Direction()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.EnvQueryItemType_Direction");
		}

		// Token: 0x060019C1 RID: 6593 RVA: 0x0002632D File Offset: 0x0002452D
		protected UEnvQueryItemType_Direction(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000791 RID: 1937
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.EnvQueryItemType_Direction";

		// Token: 0x04000792 RID: 1938
		private static IntPtr _ClassPtr;

		// Token: 0x04000793 RID: 1939
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
