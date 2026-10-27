using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000BFB RID: 3067
	[UnrealObjectPath("/Script/Engine.GameInstanceSubsystem")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class UGameInstanceSubsystem : USubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600976B RID: 38763 RVA: 0x000D7D5A File Offset: 0x000D5F5A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGameInstanceSubsystem._ClassPtr;
		}

		// Token: 0x0600976C RID: 38764 RVA: 0x000D7D66 File Offset: 0x000D5F66
		static UGameInstanceSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.GameInstanceSubsystem");
		}

		// Token: 0x0600976D RID: 38765 RVA: 0x000D7D74 File Offset: 0x000D5F74
		protected UGameInstanceSubsystem() : this(BuiltinUtils.AllocNativeUObject(UGameInstanceSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600976E RID: 38766 RVA: 0x000D7D9C File Offset: 0x000D5F9C
		protected UGameInstanceSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040054D4 RID: 21716
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.GameInstanceSubsystem";

		// Token: 0x040054D5 RID: 21717
		private static IntPtr _ClassPtr;

		// Token: 0x040054D6 RID: 21718
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
