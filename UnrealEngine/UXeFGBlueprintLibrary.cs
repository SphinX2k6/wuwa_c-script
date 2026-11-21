using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200087C RID: 2172
	[UnrealObjectPath("/Script/XeFGBlueprint.XeFGBlueprintLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UXeFGBlueprintLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BD4F RID: 48463 RVA: 0x0012E164 File Offset: 0x0012C364
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UXeFGBlueprintLibrary._ClassPtr;
		}

		// Token: 0x0600BD50 RID: 48464 RVA: 0x0012E170 File Offset: 0x0012C370
		public UXeFGBlueprintLibrary() : this(BuiltinUtils.AllocNativeUObject(UXeFGBlueprintLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BD51 RID: 48465 RVA: 0x0012E198 File Offset: 0x0012C398
		[NullableContext(1)]
		public UXeFGBlueprintLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UXeFGBlueprintLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600BD52 RID: 48466
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsXeFGSupported();

		// Token: 0x0600BD53 RID: 48467
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IfRelaunchRequiredByXeFG();

		// Token: 0x0600BD54 RID: 48468 RVA: 0x0012E1CB File Offset: 0x0012C3CB
		static UXeFGBlueprintLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/XeFGBlueprint.XeFGBlueprintLibrary");
		}

		// Token: 0x0600BD55 RID: 48469 RVA: 0x0012E1D9 File Offset: 0x0012C3D9
		protected UXeFGBlueprintLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400557B RID: 21883
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/XeFGBlueprint.XeFGBlueprintLibrary";

		// Token: 0x0400557C RID: 21884
		private static IntPtr _ClassPtr;

		// Token: 0x0400557D RID: 21885
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
