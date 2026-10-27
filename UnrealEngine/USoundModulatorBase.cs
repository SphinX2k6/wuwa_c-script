using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200036D RID: 877
	[UnrealObjectPath("/Script/AudioExtensions.SoundModulatorBase")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class USoundModulatorBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003043 RID: 12355 RVA: 0x0004ABF1 File Offset: 0x00048DF1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USoundModulatorBase._ClassPtr;
		}

		// Token: 0x06003044 RID: 12356 RVA: 0x0004ABFD File Offset: 0x00048DFD
		static USoundModulatorBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AudioExtensions.SoundModulatorBase");
		}

		// Token: 0x06003045 RID: 12357 RVA: 0x0004AC0C File Offset: 0x00048E0C
		protected USoundModulatorBase() : this(BuiltinUtils.AllocNativeUObject(USoundModulatorBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003046 RID: 12358 RVA: 0x0004AC34 File Offset: 0x00048E34
		protected USoundModulatorBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001504 RID: 5380
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AudioExtensions.SoundModulatorBase";

		// Token: 0x04001505 RID: 5381
		private static IntPtr _ClassPtr;

		// Token: 0x04001506 RID: 5382
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
