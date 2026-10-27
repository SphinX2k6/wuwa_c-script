using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200111F RID: 4383
	[UnrealObjectPath("/Script/Engine.SmokeTestCommandlet")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class USmokeTestCommandlet : UCommandlet, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010017 RID: 65559 RVA: 0x0017914A File Offset: 0x0017734A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USmokeTestCommandlet._ClassPtr;
		}

		// Token: 0x06010018 RID: 65560 RVA: 0x00179158 File Offset: 0x00177358
		public USmokeTestCommandlet() : this(BuiltinUtils.AllocNativeUObject(USmokeTestCommandlet.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010019 RID: 65561 RVA: 0x00179180 File Offset: 0x00177380
		[NullableContext(1)]
		public USmokeTestCommandlet(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USmokeTestCommandlet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601001A RID: 65562 RVA: 0x001791B3 File Offset: 0x001773B3
		static USmokeTestCommandlet()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SmokeTestCommandlet");
		}

		// Token: 0x0601001B RID: 65563 RVA: 0x001791C1 File Offset: 0x001773C1
		protected USmokeTestCommandlet(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008994 RID: 35220
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SmokeTestCommandlet";

		// Token: 0x04008995 RID: 35221
		private static IntPtr _ClassPtr;

		// Token: 0x04008996 RID: 35222
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
