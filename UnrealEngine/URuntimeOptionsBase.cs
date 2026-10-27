using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010B0 RID: 4272
	[UnrealObjectPath("/Script/Engine.RuntimeOptionsBase")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public abstract class URuntimeOptionsBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F428 RID: 62504 RVA: 0x0016A1F6 File Offset: 0x001683F6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URuntimeOptionsBase._ClassPtr;
		}

		// Token: 0x0600F429 RID: 62505 RVA: 0x0016A202 File Offset: 0x00168402
		static URuntimeOptionsBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.RuntimeOptionsBase");
		}

		// Token: 0x0600F42A RID: 62506 RVA: 0x0016A210 File Offset: 0x00168410
		protected URuntimeOptionsBase() : this(BuiltinUtils.AllocNativeUObject(URuntimeOptionsBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F42B RID: 62507 RVA: 0x0016A238 File Offset: 0x00168438
		protected URuntimeOptionsBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008456 RID: 33878
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.RuntimeOptionsBase";

		// Token: 0x04008457 RID: 33879
		private static IntPtr _ClassPtr;

		// Token: 0x04008458 RID: 33880
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
