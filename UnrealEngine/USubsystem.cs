using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000294 RID: 660
	[UnrealObjectPath("/Script/Engine.Subsystem")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class USubsystem : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060048FD RID: 18685 RVA: 0x00066658 File Offset: 0x00064858
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USubsystem._ClassPtr;
		}

		// Token: 0x060048FE RID: 18686 RVA: 0x00066664 File Offset: 0x00064864
		static USubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.Subsystem");
		}

		// Token: 0x060048FF RID: 18687 RVA: 0x00066674 File Offset: 0x00064874
		protected USubsystem() : this(BuiltinUtils.AllocNativeUObject(USubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004900 RID: 18688 RVA: 0x0006669C File Offset: 0x0006489C
		protected USubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001C5F RID: 7263
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.Subsystem";

		// Token: 0x04001C60 RID: 7264
		private static IntPtr _ClassPtr;

		// Token: 0x04001C61 RID: 7265
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
