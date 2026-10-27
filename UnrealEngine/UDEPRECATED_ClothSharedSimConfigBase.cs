using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000493 RID: 1171
	[UnrealObjectPath("/Script/ClothingSystemRuntimeInterface.ClothSharedSimConfigBase")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UDEPRECATED_ClothSharedSimConfigBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003EE9 RID: 16105 RVA: 0x0005E84E File Offset: 0x0005CA4E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDEPRECATED_ClothSharedSimConfigBase._ClassPtr;
		}

		// Token: 0x06003EEA RID: 16106 RVA: 0x0005E85A File Offset: 0x0005CA5A
		static UDEPRECATED_ClothSharedSimConfigBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ClothingSystemRuntimeInterface.ClothSharedSimConfigBase");
		}

		// Token: 0x06003EEB RID: 16107 RVA: 0x0005E868 File Offset: 0x0005CA68
		protected UDEPRECATED_ClothSharedSimConfigBase() : this(BuiltinUtils.AllocNativeUObject(UDEPRECATED_ClothSharedSimConfigBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003EEC RID: 16108 RVA: 0x0005E890 File Offset: 0x0005CA90
		protected UDEPRECATED_ClothSharedSimConfigBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001DAA RID: 7594
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ClothingSystemRuntimeInterface.ClothSharedSimConfigBase";

		// Token: 0x04001DAB RID: 7595
		private static IntPtr _ClassPtr;

		// Token: 0x04001DAC RID: 7596
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
