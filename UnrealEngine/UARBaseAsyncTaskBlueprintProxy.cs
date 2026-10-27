using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000395 RID: 917
	[UnrealObjectPath("/Script/AugmentedReality.ARBaseAsyncTaskBlueprintProxy")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public abstract class UARBaseAsyncTaskBlueprintProxy : UBlueprintAsyncActionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003262 RID: 12898 RVA: 0x0004DB37 File Offset: 0x0004BD37
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UARBaseAsyncTaskBlueprintProxy._ClassPtr;
		}

		// Token: 0x06003263 RID: 12899 RVA: 0x0004DB43 File Offset: 0x0004BD43
		static UARBaseAsyncTaskBlueprintProxy()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AugmentedReality.ARBaseAsyncTaskBlueprintProxy");
		}

		// Token: 0x06003264 RID: 12900 RVA: 0x0004DB54 File Offset: 0x0004BD54
		protected UARBaseAsyncTaskBlueprintProxy() : this(BuiltinUtils.AllocNativeUObject(UARBaseAsyncTaskBlueprintProxy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003265 RID: 12901 RVA: 0x0004DB7C File Offset: 0x0004BD7C
		protected UARBaseAsyncTaskBlueprintProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400161B RID: 5659
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AugmentedReality.ARBaseAsyncTaskBlueprintProxy";

		// Token: 0x0400161C RID: 5660
		private static IntPtr _ClassPtr;

		// Token: 0x0400161D RID: 5661
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
