using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004B8 RID: 1208
	[UnrealObjectPath("/Script/ControlRig.ControlRigAnimInstance")]
	[UnrealStructLayout(2160, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2160)]
	public class UControlRigAnimInstance : UAnimInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600406E RID: 16494 RVA: 0x00060D9D File Offset: 0x0005EF9D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UControlRigAnimInstance._ClassPtr;
		}

		// Token: 0x0600406F RID: 16495 RVA: 0x00060DAC File Offset: 0x0005EFAC
		public UControlRigAnimInstance() : this(BuiltinUtils.AllocNativeUObject(UControlRigAnimInstance.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004070 RID: 16496 RVA: 0x00060DD4 File Offset: 0x0005EFD4
		[NullableContext(1)]
		public UControlRigAnimInstance(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UControlRigAnimInstance.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06004071 RID: 16497 RVA: 0x00060E07 File Offset: 0x0005F007
		static UControlRigAnimInstance()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ControlRig.ControlRigAnimInstance");
		}

		// Token: 0x06004072 RID: 16498 RVA: 0x00060E15 File Offset: 0x0005F015
		protected UControlRigAnimInstance(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001ED4 RID: 7892
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.ControlRigAnimInstance";

		// Token: 0x04001ED5 RID: 7893
		private static IntPtr _ClassPtr;

		// Token: 0x04001ED6 RID: 7894
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
