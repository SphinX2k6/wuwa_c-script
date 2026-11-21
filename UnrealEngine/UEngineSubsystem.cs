using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001EF RID: 495
	[UnrealObjectPath("/Script/Engine.EngineSubsystem")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class UEngineSubsystem : UDynamicSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060021A5 RID: 8613 RVA: 0x0003150C File Offset: 0x0002F70C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEngineSubsystem._ClassPtr;
		}

		// Token: 0x060021A6 RID: 8614 RVA: 0x00031518 File Offset: 0x0002F718
		static UEngineSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.EngineSubsystem");
		}

		// Token: 0x060021A7 RID: 8615 RVA: 0x00031528 File Offset: 0x0002F728
		protected UEngineSubsystem() : this(BuiltinUtils.AllocNativeUObject(UEngineSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060021A8 RID: 8616 RVA: 0x00031550 File Offset: 0x0002F750
		protected UEngineSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000C3B RID: 3131
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.EngineSubsystem";

		// Token: 0x04000C3C RID: 3132
		private static IntPtr _ClassPtr;

		// Token: 0x04000C3D RID: 3133
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
