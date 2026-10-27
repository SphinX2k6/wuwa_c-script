using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002249 RID: 8777
	[UnrealObjectPath("/Script/LTween.LTweenerQuaternion")]
	[UnrealStructLayout(384, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 384)]
	public class ULTweenerQuaternion : ULTweener, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602164D RID: 136781 RVA: 0x0031351A File Offset: 0x0031171A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULTweenerQuaternion._ClassPtr;
		}

		// Token: 0x0602164E RID: 136782 RVA: 0x00313528 File Offset: 0x00311728
		public ULTweenerQuaternion() : this(BuiltinUtils.AllocNativeUObject(ULTweenerQuaternion.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602164F RID: 136783 RVA: 0x00313550 File Offset: 0x00311750
		[NullableContext(1)]
		public ULTweenerQuaternion(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULTweenerQuaternion.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06021650 RID: 136784 RVA: 0x00313583 File Offset: 0x00311783
		static ULTweenerQuaternion()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LTween.LTweenerQuaternion");
		}

		// Token: 0x06021651 RID: 136785 RVA: 0x00313591 File Offset: 0x00311791
		protected ULTweenerQuaternion(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011CC0 RID: 72896
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LTween.LTweenerQuaternion";

		// Token: 0x04011CC1 RID: 72897
		private static IntPtr _ClassPtr;

		// Token: 0x04011CC2 RID: 72898
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
