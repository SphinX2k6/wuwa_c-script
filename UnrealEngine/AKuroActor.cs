using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EA6 RID: 7846
	[UnrealObjectPath("/Script/KuroUtility.KuroActor")]
	[UnrealStructLayout(1040, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1040)]
	public class AKuroActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DCB1 RID: 122033 RVA: 0x002C08C1 File Offset: 0x002BEAC1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroActor._ClassPtr;
		}

		// Token: 0x0601DCB2 RID: 122034 RVA: 0x002C08D0 File Offset: 0x002BEAD0
		public AKuroActor() : this(BuiltinUtils.AllocNativeUObject(AKuroActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DCB3 RID: 122035 RVA: 0x002C08F8 File Offset: 0x002BEAF8
		[NullableContext(1)]
		public AKuroActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601DCB4 RID: 122036 RVA: 0x002C092B File Offset: 0x002BEB2B
		public virtual void ReceiveKuroActorGet()
		{
			AKuroActor.__ReceiveKuroActorGet_Internal(base.NativePtr);
		}

		// Token: 0x0601DCB5 RID: 122037 RVA: 0x002C0938 File Offset: 0x002BEB38
		public virtual void ReceiveKuroActorBack()
		{
			AKuroActor.__ReceiveKuroActorBack_Internal(base.NativePtr);
		}

		// Token: 0x0601DCB6 RID: 122038
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveKuroActorGet_Internal(IntPtr @this);

		// Token: 0x0601DCB7 RID: 122039
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveKuroActorBack_Internal(IntPtr @this);

		// Token: 0x0601DCB8 RID: 122040 RVA: 0x002C0945 File Offset: 0x002BEB45
		static AKuroActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroActor");
		}

		// Token: 0x0601DCB9 RID: 122041 RVA: 0x002C0953 File Offset: 0x002BEB53
		protected AKuroActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010245 RID: 66117
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroActor";

		// Token: 0x04010246 RID: 66118
		private static IntPtr _ClassPtr;

		// Token: 0x04010247 RID: 66119
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
