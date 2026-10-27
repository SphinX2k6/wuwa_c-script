using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000AF6 RID: 2806
	[UnrealObjectPath("/Script/Engine.EngineSubsystem")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class UEngineSubsystem : UDynamicSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600927A RID: 37498 RVA: 0x000D2265 File Offset: 0x000D0465
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEngineSubsystem._ClassPtr;
		}

		// Token: 0x0600927B RID: 37499 RVA: 0x000D2271 File Offset: 0x000D0471
		static UEngineSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.EngineSubsystem");
		}

		// Token: 0x0600927C RID: 37500 RVA: 0x000D2280 File Offset: 0x000D0480
		protected UEngineSubsystem() : this(BuiltinUtils.AllocNativeUObject(UEngineSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600927D RID: 37501 RVA: 0x000D22A8 File Offset: 0x000D04A8
		protected UEngineSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004CE6 RID: 19686
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.EngineSubsystem";

		// Token: 0x04004CE7 RID: 19687
		private static IntPtr _ClassPtr;

		// Token: 0x04004CE8 RID: 19688
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
