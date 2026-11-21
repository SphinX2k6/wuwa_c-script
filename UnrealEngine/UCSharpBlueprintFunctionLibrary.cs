using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000809 RID: 2057
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Sharphereal.CSharpBlueprintFunctionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UCSharpBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B523 RID: 46371 RVA: 0x00120145 File Offset: 0x0011E345
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCSharpBlueprintFunctionLibrary._ClassPtr;
		}

		// Token: 0x0600B524 RID: 46372 RVA: 0x00120154 File Offset: 0x0011E354
		public UCSharpBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(UCSharpBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B525 RID: 46373 RVA: 0x0012017C File Offset: 0x0011E37C
		public UCSharpBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCSharpBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600B526 RID: 46374
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void LoadDeferredRuntimeAssemblies();

		// Token: 0x0600B527 RID: 46375
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsPak1RestartPending();

		// Token: 0x0600B528 RID: 46376
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void InitializeMonoEnvironment();

		// Token: 0x0600B529 RID: 46377
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool HasSharpherealModuleStartup();

		// Token: 0x0600B52A RID: 46378
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool HasSharpherealModuleGreyBoxHit();

		// Token: 0x0600B52B RID: 46379
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool HasEnableCSharpEnv();

		// Token: 0x0600B52C RID: 46380
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool HasCSharpEnvironmentInitialized();

		// Token: 0x0600B52D RID: 46381 RVA: 0x001201B0 File Offset: 0x0011E3B0
		public unsafe static void CSharpTestSceneLogin(string LevelName)
		{
			FString fstring = FString.AllocTemp(LevelName);
			UCSharpBlueprintFunctionLibrary.__CSharpTestSceneLogin_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600B52E RID: 46382 RVA: 0x001201D4 File Offset: 0x0011E3D4
		[NullableContext(2)]
		public static void CSharpDoMain(UGameInstance GameInstance)
		{
			UCSharpBlueprintFunctionLibrary.__CSharpDoMain_Internal((GameInstance != null) ? GameInstance.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600B52F RID: 46383 RVA: 0x001201EC File Offset: 0x0011E3EC
		public unsafe static void CallCSharpFunction(string ImageName, string NameSpaceName, string ClassName, string MethodName, int ParamsCount, [Nullable(2)] UGameInstance GameInstance)
		{
			FString fstring = FString.AllocTemp(ImageName);
			FString fstring2 = FString.AllocTemp(NameSpaceName);
			FString fstring3 = FString.AllocTemp(ClassName);
			FString fstring4 = FString.AllocTemp(MethodName);
			UCSharpBlueprintFunctionLibrary.__CallCSharpFunction_Internal(fstring, fstring2, fstring3, fstring4, ParamsCount, (GameInstance != null) ? GameInstance.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			FString.NativeDestruct(&fstring3, 1);
			FString.NativeDestruct(&fstring4, 1);
		}

		// Token: 0x0600B530 RID: 46384
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CSharpTestSceneLogin_Internal(in FString LevelName);

		// Token: 0x0600B531 RID: 46385
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CSharpDoMain_Internal(IntPtr GameInstance);

		// Token: 0x0600B532 RID: 46386
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CallCSharpFunction_Internal(in FString ImageName, in FString NameSpaceName, in FString ClassName, in FString MethodName, int ParamsCount, IntPtr GameInstance);

		// Token: 0x0600B533 RID: 46387 RVA: 0x0012025A File Offset: 0x0011E45A
		static UCSharpBlueprintFunctionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Sharphereal.CSharpBlueprintFunctionLibrary");
		}

		// Token: 0x0600B534 RID: 46388 RVA: 0x00120268 File Offset: 0x0011E468
		protected UCSharpBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400519E RID: 20894
		public new const string __ObjectPath = "/Script/Sharphereal.CSharpBlueprintFunctionLibrary";

		// Token: 0x0400519F RID: 20895
		private static IntPtr _ClassPtr;

		// Token: 0x040051A0 RID: 20896
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
