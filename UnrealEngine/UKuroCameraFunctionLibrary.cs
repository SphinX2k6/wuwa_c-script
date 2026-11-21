using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005D0 RID: 1488
	[UnrealObjectPath("/Script/KuroUtility.KuroCameraFunctionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroCameraFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008402 RID: 33794 RVA: 0x000C4176 File Offset: 0x000C2376
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCameraFunctionLibrary._ClassPtr;
		}

		// Token: 0x06008403 RID: 33795 RVA: 0x000C4184 File Offset: 0x000C2384
		public UKuroCameraFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroCameraFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008404 RID: 33796 RVA: 0x000C41AC File Offset: 0x000C23AC
		[NullableContext(1)]
		public UKuroCameraFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCameraFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06008405 RID: 33797
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetNearClipPlane();

		// Token: 0x06008406 RID: 33798
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DelaySetNearClipPlane(float distance);

		// Token: 0x06008407 RID: 33799 RVA: 0x000C41DF File Offset: 0x000C23DF
		static UKuroCameraFunctionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroCameraFunctionLibrary");
		}

		// Token: 0x06008408 RID: 33800 RVA: 0x000C41ED File Offset: 0x000C23ED
		protected UKuroCameraFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040039BB RID: 14779
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroCameraFunctionLibrary";

		// Token: 0x040039BC RID: 14780
		private static IntPtr _ClassPtr;

		// Token: 0x040039BD RID: 14781
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
