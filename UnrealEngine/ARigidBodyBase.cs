using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001095 RID: 4245
	[UnrealObjectPath("/Script/Engine.RigidBodyBase")]
	[UnrealStructLayout(1040, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1040)]
	public abstract class ARigidBodyBase : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F292 RID: 62098 RVA: 0x00167E7F File Offset: 0x0016607F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ARigidBodyBase._ClassPtr;
		}

		// Token: 0x0600F293 RID: 62099 RVA: 0x00167E8B File Offset: 0x0016608B
		static ARigidBodyBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.RigidBodyBase");
		}

		// Token: 0x0600F294 RID: 62100 RVA: 0x00167E9C File Offset: 0x0016609C
		protected ARigidBodyBase() : this(BuiltinUtils.AllocNativeUObject(ARigidBodyBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F295 RID: 62101 RVA: 0x00167EC4 File Offset: 0x001660C4
		protected ARigidBodyBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400839C RID: 33692
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.RigidBodyBase";

		// Token: 0x0400839D RID: 33693
		private static IntPtr _ClassPtr;

		// Token: 0x0400839E RID: 33694
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
