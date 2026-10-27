using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002755 RID: 10069
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Sharphereal.CSharpBlueprintFunctionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UCSharpBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025A46 RID: 154182 RVA: 0x00390D76 File Offset: 0x0038EF76
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCSharpBlueprintFunctionLibrary._ClassPtr;
		}

		// Token: 0x06025A47 RID: 154183 RVA: 0x00390D84 File Offset: 0x0038EF84
		public UCSharpBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(UCSharpBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025A48 RID: 154184 RVA: 0x00390DAC File Offset: 0x0038EFAC
		public UCSharpBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCSharpBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06025A49 RID: 154185
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Test2(ETestEnumInt32BlueprintType TestEnumInt32BlueprintType);

		// Token: 0x06025A4A RID: 154186
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void LoadDeferredRuntimeAssemblies();

		// Token: 0x06025A4B RID: 154187
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsPak1RestartPending();

		// Token: 0x06025A4C RID: 154188
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void InitializeMonoEnvironment();

		// Token: 0x06025A4D RID: 154189
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool HasSharpherealModuleStartup();

		// Token: 0x06025A4E RID: 154190
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool HasSharpherealModuleGreyBoxHit();

		// Token: 0x06025A4F RID: 154191
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool HasEnableCSharpEnv();

		// Token: 0x06025A50 RID: 154192
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool HasCSharpEnvironmentInitialized();

		// Token: 0x06025A51 RID: 154193 RVA: 0x00390DE0 File Offset: 0x0038EFE0
		public unsafe static void CSharpTestSceneLogin(string LevelName)
		{
			FString fstring = FString.AllocTemp(LevelName);
			UCSharpBlueprintFunctionLibrary.__CSharpTestSceneLogin_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06025A52 RID: 154194 RVA: 0x00390E04 File Offset: 0x0038F004
		[NullableContext(2)]
		public static void CSharpDoMain(UGameInstance GameInstance)
		{
			UCSharpBlueprintFunctionLibrary.__CSharpDoMain_Internal((GameInstance != null) ? GameInstance.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06025A53 RID: 154195 RVA: 0x00390E1C File Offset: 0x0038F01C
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

		// Token: 0x06025A54 RID: 154196
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CSharpTestSceneLogin_Internal(in FString LevelName);

		// Token: 0x06025A55 RID: 154197
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CSharpDoMain_Internal(IntPtr GameInstance);

		// Token: 0x06025A56 RID: 154198
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CallCSharpFunction_Internal(in FString ImageName, in FString NameSpaceName, in FString ClassName, in FString MethodName, int ParamsCount, IntPtr GameInstance);

		// Token: 0x06025A57 RID: 154199 RVA: 0x00390E8A File Offset: 0x0038F08A
		static UCSharpBlueprintFunctionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Sharphereal.CSharpBlueprintFunctionLibrary");
		}

		// Token: 0x06025A58 RID: 154200 RVA: 0x00390E98 File Offset: 0x0038F098
		protected UCSharpBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401473F RID: 83775
		public new const string __ObjectPath = "/Script/Sharphereal.CSharpBlueprintFunctionLibrary";

		// Token: 0x04014740 RID: 83776
		private static IntPtr _ClassPtr;

		// Token: 0x04014741 RID: 83777
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
