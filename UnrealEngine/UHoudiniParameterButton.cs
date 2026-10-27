using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014E9 RID: 5353
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniParameterButton")]
	[UnrealStructLayout(272, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 272)]
	public class UHoudiniParameterButton : UHoudiniParameter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601365A RID: 79450 RVA: 0x001C84BB File Offset: 0x001C66BB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniParameterButton._ClassPtr;
		}

		// Token: 0x0601365B RID: 79451 RVA: 0x001C84C8 File Offset: 0x001C66C8
		public UHoudiniParameterButton() : this(BuiltinUtils.AllocNativeUObject(UHoudiniParameterButton.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601365C RID: 79452 RVA: 0x001C84F0 File Offset: 0x001C66F0
		[NullableContext(1)]
		public UHoudiniParameterButton(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniParameterButton.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601365D RID: 79453 RVA: 0x001C8523 File Offset: 0x001C6723
		static UHoudiniParameterButton()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniParameterButton");
		}

		// Token: 0x0601365E RID: 79454 RVA: 0x001C8531 File Offset: 0x001C6731
		protected UHoudiniParameterButton(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A7AC RID: 42924
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniParameterButton";

		// Token: 0x0400A7AD RID: 42925
		private static IntPtr _ClassPtr;

		// Token: 0x0400A7AE RID: 42926
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
