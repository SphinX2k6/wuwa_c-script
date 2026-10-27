using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D61 RID: 3425
	[UnrealObjectPath("/Script/Engine.LocalMessage")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class ULocalMessage : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B918 RID: 47384 RVA: 0x00107615 File Offset: 0x00105815
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULocalMessage._ClassPtr;
		}

		// Token: 0x0600B919 RID: 47385 RVA: 0x00107621 File Offset: 0x00105821
		static ULocalMessage()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.LocalMessage");
		}

		// Token: 0x0600B91A RID: 47386 RVA: 0x00107630 File Offset: 0x00105830
		protected ULocalMessage() : this(BuiltinUtils.AllocNativeUObject(ULocalMessage.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B91B RID: 47387 RVA: 0x00107658 File Offset: 0x00105858
		protected ULocalMessage(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040060F9 RID: 24825
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.LocalMessage";

		// Token: 0x040060FA RID: 24826
		private static IntPtr _ClassPtr;

		// Token: 0x040060FB RID: 24827
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
