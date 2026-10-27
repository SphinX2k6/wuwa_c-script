using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020009DF RID: 2527
	[UnrealObjectPath("/Script/Engine.DynamicSubsystem")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class UDynamicSubsystem : USubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008EAD RID: 36525 RVA: 0x000CC021 File Offset: 0x000CA221
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDynamicSubsystem._ClassPtr;
		}

		// Token: 0x06008EAE RID: 36526 RVA: 0x000CC02D File Offset: 0x000CA22D
		static UDynamicSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DynamicSubsystem");
		}

		// Token: 0x06008EAF RID: 36527 RVA: 0x000CC03C File Offset: 0x000CA23C
		protected UDynamicSubsystem() : this(BuiltinUtils.AllocNativeUObject(UDynamicSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008EB0 RID: 36528 RVA: 0x000CC064 File Offset: 0x000CA264
		protected UDynamicSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040043DD RID: 17373
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.DynamicSubsystem";

		// Token: 0x040043DE RID: 17374
		private static IntPtr _ClassPtr;

		// Token: 0x040043DF RID: 17375
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
