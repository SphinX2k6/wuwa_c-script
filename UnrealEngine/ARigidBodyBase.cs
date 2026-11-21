using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000273 RID: 627
	[UnrealObjectPath("/Script/Engine.RigidBodyBase")]
	[UnrealStructLayout(1040, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1040)]
	public abstract class ARigidBodyBase : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06004042 RID: 16450 RVA: 0x0005C465 File Offset: 0x0005A665
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ARigidBodyBase._ClassPtr;
		}

		// Token: 0x06004043 RID: 16451 RVA: 0x0005C471 File Offset: 0x0005A671
		static ARigidBodyBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.RigidBodyBase");
		}

		// Token: 0x06004044 RID: 16452 RVA: 0x0005C480 File Offset: 0x0005A680
		protected ARigidBodyBase() : this(BuiltinUtils.AllocNativeUObject(ARigidBodyBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004045 RID: 16453 RVA: 0x0005C4A8 File Offset: 0x0005A6A8
		protected ARigidBodyBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400192B RID: 6443
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.RigidBodyBase";

		// Token: 0x0400192C RID: 6444
		private static IntPtr _ClassPtr;

		// Token: 0x0400192D RID: 6445
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
