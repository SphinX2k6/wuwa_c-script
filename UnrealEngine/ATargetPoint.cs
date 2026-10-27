using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020011C4 RID: 4548
	[UnrealObjectPath("/Script/Engine.TargetPoint")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public class ATargetPoint : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010C2E RID: 68654 RVA: 0x00189E43 File Offset: 0x00188043
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ATargetPoint._ClassPtr;
		}

		// Token: 0x06010C2F RID: 68655 RVA: 0x00189E50 File Offset: 0x00188050
		public ATargetPoint() : this(BuiltinUtils.AllocNativeUObject(ATargetPoint.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010C30 RID: 68656 RVA: 0x00189E78 File Offset: 0x00188078
		[NullableContext(1)]
		public ATargetPoint(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ATargetPoint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06010C31 RID: 68657 RVA: 0x00189EAB File Offset: 0x001880AB
		static ATargetPoint()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.TargetPoint");
		}

		// Token: 0x06010C32 RID: 68658 RVA: 0x00189EB9 File Offset: 0x001880B9
		protected ATargetPoint(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008F50 RID: 36688
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.TargetPoint";

		// Token: 0x04008F51 RID: 36689
		private static IntPtr _ClassPtr;

		// Token: 0x04008F52 RID: 36690
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
