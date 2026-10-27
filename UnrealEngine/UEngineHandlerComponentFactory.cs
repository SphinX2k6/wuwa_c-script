using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000AF3 RID: 2803
	[UnrealObjectPath("/Script/Engine.EngineHandlerComponentFactory")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UEngineHandlerComponentFactory : UHandlerComponentFactory, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009255 RID: 37461 RVA: 0x000D1F91 File Offset: 0x000D0191
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEngineHandlerComponentFactory._ClassPtr;
		}

		// Token: 0x06009256 RID: 37462 RVA: 0x000D1FA0 File Offset: 0x000D01A0
		public UEngineHandlerComponentFactory() : this(BuiltinUtils.AllocNativeUObject(UEngineHandlerComponentFactory.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009257 RID: 37463 RVA: 0x000D1FC8 File Offset: 0x000D01C8
		[NullableContext(1)]
		public UEngineHandlerComponentFactory(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEngineHandlerComponentFactory.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06009258 RID: 37464 RVA: 0x000D1FFB File Offset: 0x000D01FB
		static UEngineHandlerComponentFactory()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.EngineHandlerComponentFactory");
		}

		// Token: 0x06009259 RID: 37465 RVA: 0x000D2009 File Offset: 0x000D0209
		protected UEngineHandlerComponentFactory(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004CD4 RID: 19668
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.EngineHandlerComponentFactory";

		// Token: 0x04004CD5 RID: 19669
		private static IntPtr _ClassPtr;

		// Token: 0x04004CD6 RID: 19670
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
