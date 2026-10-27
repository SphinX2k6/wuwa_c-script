using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000833 RID: 2099
	[UnrealObjectPath("/Script/Engine.AnimNotify_ResetDynamics")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UAnimNotify_ResetDynamics : UAnimNotify, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060070FB RID: 28923 RVA: 0x000A1FAE File Offset: 0x000A01AE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimNotify_ResetDynamics._ClassPtr;
		}

		// Token: 0x060070FC RID: 28924 RVA: 0x000A1FBC File Offset: 0x000A01BC
		public UAnimNotify_ResetDynamics() : this(BuiltinUtils.AllocNativeUObject(UAnimNotify_ResetDynamics.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060070FD RID: 28925 RVA: 0x000A1FE4 File Offset: 0x000A01E4
		[NullableContext(1)]
		public UAnimNotify_ResetDynamics(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnimNotify_ResetDynamics.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060070FE RID: 28926 RVA: 0x000A2017 File Offset: 0x000A0217
		static UAnimNotify_ResetDynamics()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimNotify_ResetDynamics");
		}

		// Token: 0x060070FF RID: 28927 RVA: 0x000A2025 File Offset: 0x000A0225
		protected UAnimNotify_ResetDynamics(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400363E RID: 13886
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AnimNotify_ResetDynamics";

		// Token: 0x0400363F RID: 13887
		private static IntPtr _ClassPtr;

		// Token: 0x04003640 RID: 13888
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
