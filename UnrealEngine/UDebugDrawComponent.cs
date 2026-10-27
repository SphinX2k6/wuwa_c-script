using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020009A6 RID: 2470
	[UnrealObjectPath("/Script/Engine.DebugDrawComponent")]
	[UnrealStructLayout(1648, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1648)]
	public abstract class UDebugDrawComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008B80 RID: 35712 RVA: 0x000C7DBE File Offset: 0x000C5FBE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDebugDrawComponent._ClassPtr;
		}

		// Token: 0x06008B81 RID: 35713 RVA: 0x000C7DCA File Offset: 0x000C5FCA
		static UDebugDrawComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DebugDrawComponent");
		}

		// Token: 0x06008B82 RID: 35714 RVA: 0x000C7DD8 File Offset: 0x000C5FD8
		protected UDebugDrawComponent() : this(BuiltinUtils.AllocNativeUObject(UDebugDrawComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008B83 RID: 35715 RVA: 0x000C7E00 File Offset: 0x000C6000
		protected UDebugDrawComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004243 RID: 16963
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.DebugDrawComponent";

		// Token: 0x04004244 RID: 16964
		private static IntPtr _ClassPtr;

		// Token: 0x04004245 RID: 16965
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
