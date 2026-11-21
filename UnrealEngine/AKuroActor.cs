using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005C9 RID: 1481
	[UnrealObjectPath("/Script/KuroUtility.KuroActor")]
	[UnrealStructLayout(1040, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1040)]
	public class AKuroActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060083B2 RID: 33714 RVA: 0x000C308D File Offset: 0x000C128D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroActor._ClassPtr;
		}

		// Token: 0x060083B3 RID: 33715 RVA: 0x000C309C File Offset: 0x000C129C
		public AKuroActor() : this(BuiltinUtils.AllocNativeUObject(AKuroActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060083B4 RID: 33716 RVA: 0x000C30C4 File Offset: 0x000C12C4
		[NullableContext(1)]
		public AKuroActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060083B5 RID: 33717 RVA: 0x000C30F7 File Offset: 0x000C12F7
		public virtual void ReceiveKuroActorGet()
		{
			AKuroActor.__ReceiveKuroActorGet_Internal(base.NativePtr);
		}

		// Token: 0x060083B6 RID: 33718 RVA: 0x000C3104 File Offset: 0x000C1304
		public virtual void ReceiveKuroActorBack()
		{
			AKuroActor.__ReceiveKuroActorBack_Internal(base.NativePtr);
		}

		// Token: 0x060083B7 RID: 33719
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveKuroActorGet_Internal(IntPtr @this);

		// Token: 0x060083B8 RID: 33720
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveKuroActorBack_Internal(IntPtr @this);

		// Token: 0x060083B9 RID: 33721 RVA: 0x000C3111 File Offset: 0x000C1311
		static AKuroActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroActor");
		}

		// Token: 0x060083BA RID: 33722 RVA: 0x000C311F File Offset: 0x000C131F
		protected AKuroActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400397C RID: 14716
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroActor";

		// Token: 0x0400397D RID: 14717
		private static IntPtr _ClassPtr;

		// Token: 0x0400397E RID: 14718
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
