using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D63 RID: 3427
	[UnrealObjectPath("/Script/Engine.LocalPlayerSubsystem")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class ULocalPlayerSubsystem : USubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B92B RID: 47403 RVA: 0x001077C7 File Offset: 0x001059C7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULocalPlayerSubsystem._ClassPtr;
		}

		// Token: 0x0600B92C RID: 47404 RVA: 0x001077D3 File Offset: 0x001059D3
		static ULocalPlayerSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.LocalPlayerSubsystem");
		}

		// Token: 0x0600B92D RID: 47405 RVA: 0x001077E4 File Offset: 0x001059E4
		protected ULocalPlayerSubsystem() : this(BuiltinUtils.AllocNativeUObject(ULocalPlayerSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B92E RID: 47406 RVA: 0x0010780C File Offset: 0x00105A0C
		protected ULocalPlayerSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006105 RID: 24837
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.LocalPlayerSubsystem";

		// Token: 0x04006106 RID: 24838
		private static IntPtr _ClassPtr;

		// Token: 0x04006107 RID: 24839
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
