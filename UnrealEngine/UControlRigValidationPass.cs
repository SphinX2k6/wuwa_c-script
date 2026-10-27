using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004D7 RID: 1239
	[UnrealObjectPath("/Script/ControlRig.ControlRigValidationPass")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UControlRigValidationPass : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06004276 RID: 17014 RVA: 0x000634E8 File Offset: 0x000616E8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UControlRigValidationPass._ClassPtr;
		}

		// Token: 0x06004277 RID: 17015 RVA: 0x000634F4 File Offset: 0x000616F4
		static UControlRigValidationPass()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ControlRig.ControlRigValidationPass");
		}

		// Token: 0x06004278 RID: 17016 RVA: 0x00063504 File Offset: 0x00061704
		protected UControlRigValidationPass() : this(BuiltinUtils.AllocNativeUObject(UControlRigValidationPass.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004279 RID: 17017 RVA: 0x0006352C File Offset: 0x0006172C
		protected UControlRigValidationPass(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001F94 RID: 8084
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.ControlRigValidationPass";

		// Token: 0x04001F95 RID: 8085
		private static IntPtr _ClassPtr;

		// Token: 0x04001F96 RID: 8086
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
