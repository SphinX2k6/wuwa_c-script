using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001E1 RID: 481
	[UnrealObjectPath("/Script/AIModule.VisualLoggerExtension")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UVisualLoggerExtension : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001C68 RID: 7272 RVA: 0x0002A6C3 File Offset: 0x000288C3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UVisualLoggerExtension._ClassPtr;
		}

		// Token: 0x06001C69 RID: 7273 RVA: 0x0002A6CF File Offset: 0x000288CF
		static UVisualLoggerExtension()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.VisualLoggerExtension");
		}

		// Token: 0x06001C6A RID: 7274 RVA: 0x0002A6E0 File Offset: 0x000288E0
		protected UVisualLoggerExtension() : this(BuiltinUtils.AllocNativeUObject(UVisualLoggerExtension.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001C6B RID: 7275 RVA: 0x0002A708 File Offset: 0x00028908
		protected UVisualLoggerExtension(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000940 RID: 2368
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.VisualLoggerExtension";

		// Token: 0x04000941 RID: 2369
		private static IntPtr _ClassPtr;

		// Token: 0x04000942 RID: 2370
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
