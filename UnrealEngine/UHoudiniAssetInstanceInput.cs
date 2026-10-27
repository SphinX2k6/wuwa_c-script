using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014A8 RID: 5288
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniAssetInstanceInput")]
	[UnrealStructLayout(368, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 368)]
	public class UHoudiniAssetInstanceInput : UHoudiniAssetParameter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060132EA RID: 78570 RVA: 0x001C36C6 File Offset: 0x001C18C6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniAssetInstanceInput._ClassPtr;
		}

		// Token: 0x060132EB RID: 78571 RVA: 0x001C36D4 File Offset: 0x001C18D4
		public UHoudiniAssetInstanceInput() : this(BuiltinUtils.AllocNativeUObject(UHoudiniAssetInstanceInput.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060132EC RID: 78572 RVA: 0x001C36FC File Offset: 0x001C18FC
		[NullableContext(1)]
		public UHoudiniAssetInstanceInput(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniAssetInstanceInput.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060132ED RID: 78573 RVA: 0x001C372F File Offset: 0x001C192F
		static UHoudiniAssetInstanceInput()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniAssetInstanceInput");
		}

		// Token: 0x060132EE RID: 78574 RVA: 0x001C373D File Offset: 0x001C193D
		protected UHoudiniAssetInstanceInput(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A5BF RID: 42431
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniAssetInstanceInput";

		// Token: 0x0400A5C0 RID: 42432
		private static IntPtr _ClassPtr;

		// Token: 0x0400A5C1 RID: 42433
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
