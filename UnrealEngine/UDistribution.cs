using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020009C6 RID: 2502
	[UnrealObjectPath("/Script/Engine.Distribution")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class UDistribution : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008DBF RID: 36287 RVA: 0x000CA9AF File Offset: 0x000C8BAF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDistribution._ClassPtr;
		}

		// Token: 0x06008DC0 RID: 36288 RVA: 0x000CA9BB File Offset: 0x000C8BBB
		static UDistribution()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.Distribution");
		}

		// Token: 0x06008DC1 RID: 36289 RVA: 0x000CA9CC File Offset: 0x000C8BCC
		protected UDistribution() : this(BuiltinUtils.AllocNativeUObject(UDistribution.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008DC2 RID: 36290 RVA: 0x000CA9F4 File Offset: 0x000C8BF4
		protected UDistribution(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004345 RID: 17221
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.Distribution";

		// Token: 0x04004346 RID: 17222
		private static IntPtr _ClassPtr;

		// Token: 0x04004347 RID: 17223
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
