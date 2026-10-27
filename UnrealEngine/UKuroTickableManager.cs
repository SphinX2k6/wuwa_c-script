using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001ED8 RID: 7896
	[UnrealObjectPath("/Script/KuroUtility.KuroTickableManager")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UKuroTickableManager : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E074 RID: 122996 RVA: 0x002C90C9 File Offset: 0x002C72C9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroTickableManager._ClassPtr;
		}

		// Token: 0x0601E075 RID: 122997 RVA: 0x002C90D8 File Offset: 0x002C72D8
		public UKuroTickableManager() : this(BuiltinUtils.AllocNativeUObject(UKuroTickableManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E076 RID: 122998 RVA: 0x002C9100 File Offset: 0x002C7300
		[NullableContext(1)]
		public UKuroTickableManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroTickableManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601E077 RID: 122999 RVA: 0x002C9133 File Offset: 0x002C7333
		[NullableContext(2)]
		public void RemoveTickableFunc(UObject InOwner)
		{
			UKuroTickableManager.__RemoveTickableFunc_Internal(base.NativePtr, (InOwner != null) ? InOwner.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601E078 RID: 123000 RVA: 0x002C9150 File Offset: 0x002C7350
		[NullableContext(2)]
		public void CreateTickableFunc(UObject InOwner, FTickableHandler TickableHandler)
		{
			UKuroTickableManager.__CreateTickableFunc_Internal(base.NativePtr, (InOwner != null) ? InOwner.NativePtr : IntPtr.Zero, (TickableHandler != null) ? TickableHandler.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0601E079 RID: 123001
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveTickableFunc_Internal(IntPtr @this, IntPtr InOwner);

		// Token: 0x0601E07A RID: 123002
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CreateTickableFunc_Internal(IntPtr @this, IntPtr InOwner, IntPtr TickableHandler);

		// Token: 0x0601E07B RID: 123003 RVA: 0x002C917A File Offset: 0x002C737A
		static UKuroTickableManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroTickableManager");
		}

		// Token: 0x0601E07C RID: 123004 RVA: 0x002C9188 File Offset: 0x002C7388
		protected UKuroTickableManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040103DB RID: 66523
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroTickableManager";

		// Token: 0x040103DC RID: 66524
		private static IntPtr _ClassPtr;

		// Token: 0x040103DD RID: 66525
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
