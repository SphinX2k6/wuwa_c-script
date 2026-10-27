using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EB1 RID: 7857
	[UnrealObjectPath("/Script/KuroUtility.KuroCameraFunctionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroCameraFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DD2E RID: 122158 RVA: 0x002C1EA6 File Offset: 0x002C00A6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCameraFunctionLibrary._ClassPtr;
		}

		// Token: 0x0601DD2F RID: 122159 RVA: 0x002C1EB4 File Offset: 0x002C00B4
		public UKuroCameraFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroCameraFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DD30 RID: 122160 RVA: 0x002C1EDC File Offset: 0x002C00DC
		[NullableContext(1)]
		public UKuroCameraFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCameraFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601DD31 RID: 122161
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetNearClipPlane();

		// Token: 0x0601DD32 RID: 122162
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DelaySetNearClipPlane(float distance);

		// Token: 0x0601DD33 RID: 122163 RVA: 0x002C1F0F File Offset: 0x002C010F
		static UKuroCameraFunctionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroCameraFunctionLibrary");
		}

		// Token: 0x0601DD34 RID: 122164 RVA: 0x002C1F1D File Offset: 0x002C011D
		protected UKuroCameraFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040102A0 RID: 66208
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroCameraFunctionLibrary";

		// Token: 0x040102A1 RID: 66209
		private static IntPtr _ClassPtr;

		// Token: 0x040102A2 RID: 66210
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
