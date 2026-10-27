using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020011E6 RID: 4582
	[UnrealObjectPath("/Script/Engine.TickableWorldSubsystem")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public abstract class UTickableWorldSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010E02 RID: 69122 RVA: 0x0018C85E File Offset: 0x0018AA5E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTickableWorldSubsystem._ClassPtr;
		}

		// Token: 0x06010E03 RID: 69123 RVA: 0x0018C86A File Offset: 0x0018AA6A
		static UTickableWorldSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.TickableWorldSubsystem");
		}

		// Token: 0x06010E04 RID: 69124 RVA: 0x0018C878 File Offset: 0x0018AA78
		protected UTickableWorldSubsystem() : this(BuiltinUtils.AllocNativeUObject(UTickableWorldSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010E05 RID: 69125 RVA: 0x0018C8A0 File Offset: 0x0018AAA0
		protected UTickableWorldSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040090BB RID: 37051
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.TickableWorldSubsystem";

		// Token: 0x040090BC RID: 37052
		private static IntPtr _ClassPtr;

		// Token: 0x040090BD RID: 37053
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
