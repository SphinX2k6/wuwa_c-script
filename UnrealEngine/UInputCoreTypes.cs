using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001528 RID: 5416
	[UnrealObjectPath("/Script/InputCore.InputCoreTypes")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UInputCoreTypes : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013B31 RID: 80689 RVA: 0x001CEF04 File Offset: 0x001CD104
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInputCoreTypes._ClassPtr;
		}

		// Token: 0x06013B32 RID: 80690 RVA: 0x001CEF10 File Offset: 0x001CD110
		static UInputCoreTypes()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InputCore.InputCoreTypes");
		}

		// Token: 0x06013B33 RID: 80691 RVA: 0x001CEF20 File Offset: 0x001CD120
		protected UInputCoreTypes() : this(BuiltinUtils.AllocNativeUObject(UInputCoreTypes.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013B34 RID: 80692 RVA: 0x001CEF48 File Offset: 0x001CD148
		protected UInputCoreTypes(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AA5A RID: 43610
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InputCore.InputCoreTypes";

		// Token: 0x0400AA5B RID: 43611
		private static IntPtr _ClassPtr;

		// Token: 0x0400AA5C RID: 43612
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
