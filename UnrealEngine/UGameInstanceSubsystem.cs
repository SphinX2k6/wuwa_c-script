using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000214 RID: 532
	[UnrealObjectPath("/Script/Engine.GameInstanceSubsystem")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class UGameInstanceSubsystem : USubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002223 RID: 8739 RVA: 0x00031F0B File Offset: 0x0003010B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGameInstanceSubsystem._ClassPtr;
		}

		// Token: 0x06002224 RID: 8740 RVA: 0x00031F17 File Offset: 0x00030117
		static UGameInstanceSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.GameInstanceSubsystem");
		}

		// Token: 0x06002225 RID: 8741 RVA: 0x00031F28 File Offset: 0x00030128
		protected UGameInstanceSubsystem() : this(BuiltinUtils.AllocNativeUObject(UGameInstanceSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002226 RID: 8742 RVA: 0x00031F50 File Offset: 0x00030150
		protected UGameInstanceSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000D5B RID: 3419
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.GameInstanceSubsystem";

		// Token: 0x04000D5C RID: 3420
		private static IntPtr _ClassPtr;

		// Token: 0x04000D5D RID: 3421
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
