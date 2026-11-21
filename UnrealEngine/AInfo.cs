using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200021C RID: 540
	[UnrealObjectPath("/Script/Engine.Info")]
	[UnrealStructLayout(1048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1048)]
	public abstract class AInfo : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060024A7 RID: 9383 RVA: 0x00034C7E File Offset: 0x00032E7E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AInfo._ClassPtr;
		}

		// Token: 0x060024A8 RID: 9384 RVA: 0x00034C8A File Offset: 0x00032E8A
		static AInfo()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.Info");
		}

		// Token: 0x060024A9 RID: 9385 RVA: 0x00034C98 File Offset: 0x00032E98
		protected AInfo() : this(BuiltinUtils.AllocNativeUObject(AInfo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060024AA RID: 9386 RVA: 0x00034CC0 File Offset: 0x00032EC0
		protected AInfo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000DC4 RID: 3524
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.Info";

		// Token: 0x04000DC5 RID: 3525
		private static IntPtr _ClassPtr;

		// Token: 0x04000DC6 RID: 3526
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
