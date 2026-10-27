using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020011B8 RID: 4536
	[UnrealObjectPath("/Script/Engine.Subsystem")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class USubsystem : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010BA5 RID: 68517 RVA: 0x00188EA0 File Offset: 0x001870A0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USubsystem._ClassPtr;
		}

		// Token: 0x06010BA6 RID: 68518 RVA: 0x00188EAC File Offset: 0x001870AC
		static USubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.Subsystem");
		}

		// Token: 0x06010BA7 RID: 68519 RVA: 0x00188EBC File Offset: 0x001870BC
		protected USubsystem() : this(BuiltinUtils.AllocNativeUObject(USubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010BA8 RID: 68520 RVA: 0x00188EE4 File Offset: 0x001870E4
		protected USubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008F15 RID: 36629
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.Subsystem";

		// Token: 0x04008F16 RID: 36630
		private static IntPtr _ClassPtr;

		// Token: 0x04008F17 RID: 36631
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
