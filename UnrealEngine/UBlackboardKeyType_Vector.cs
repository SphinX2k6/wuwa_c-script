using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000130 RID: 304
	[UnrealObjectPath("/Script/AIModule.BlackboardKeyType_Vector")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UBlackboardKeyType_Vector : UBlackboardKeyType, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060015A6 RID: 5542 RVA: 0x0001FD47 File Offset: 0x0001DF47
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBlackboardKeyType_Vector._ClassPtr;
		}

		// Token: 0x060015A7 RID: 5543 RVA: 0x0001FD54 File Offset: 0x0001DF54
		public UBlackboardKeyType_Vector() : this(BuiltinUtils.AllocNativeUObject(UBlackboardKeyType_Vector.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060015A8 RID: 5544 RVA: 0x0001FD7C File Offset: 0x0001DF7C
		[NullableContext(1)]
		public UBlackboardKeyType_Vector(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBlackboardKeyType_Vector.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060015A9 RID: 5545 RVA: 0x0001FDAF File Offset: 0x0001DFAF
		static UBlackboardKeyType_Vector()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BlackboardKeyType_Vector");
		}

		// Token: 0x060015AA RID: 5546 RVA: 0x0001FDBD File Offset: 0x0001DFBD
		protected UBlackboardKeyType_Vector(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040004AA RID: 1194
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BlackboardKeyType_Vector";

		// Token: 0x040004AB RID: 1195
		private static IntPtr _ClassPtr;

		// Token: 0x040004AC RID: 1196
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
