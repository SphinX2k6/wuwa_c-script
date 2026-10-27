using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002AA2 RID: 10914
	[UnrealObjectPath("/Script/XeSSBlueprint.XeSSBlueprintLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UXeSSBlueprintLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602838B RID: 164747 RVA: 0x003D2D57 File Offset: 0x003D0F57
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UXeSSBlueprintLibrary._ClassPtr;
		}

		// Token: 0x0602838C RID: 164748 RVA: 0x003D2D64 File Offset: 0x003D0F64
		public UXeSSBlueprintLibrary() : this(BuiltinUtils.AllocNativeUObject(UXeSSBlueprintLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602838D RID: 164749 RVA: 0x003D2D8C File Offset: 0x003D0F8C
		[NullableContext(1)]
		public UXeSSBlueprintLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UXeSSBlueprintLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602838E RID: 164750
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetXeSSQualityMode(EXeSSQualityMode QualityMode);

		// Token: 0x0602838F RID: 164751
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsXeSSSupported();

		// Token: 0x06028390 RID: 164752
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetXeSSQualityModeInformation(EXeSSQualityMode QualityMode, ref float ScreenPercentage);

		// Token: 0x06028391 RID: 164753
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern EXeSSQualityMode GetXeSSQualityMode();

		// Token: 0x06028392 RID: 164754 RVA: 0x003D2DBF File Offset: 0x003D0FBF
		[NullableContext(1)]
		public static TArray<EXeSSQualityMode> GetSupportedXeSSQualityModes()
		{
			return new TArray<EXeSSQualityMode>(UXeSSBlueprintLibrary.__GetSupportedXeSSQualityModes_Internal(), null);
		}

		// Token: 0x06028393 RID: 164755
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern EXeSSQualityMode GetDefaultXeSSQualityMode(FIntPoint ScreenResolution);

		// Token: 0x06028394 RID: 164756
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSupportedXeSSQualityModes_Internal();

		// Token: 0x06028395 RID: 164757 RVA: 0x003D2DCC File Offset: 0x003D0FCC
		static UXeSSBlueprintLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/XeSSBlueprint.XeSSBlueprintLibrary");
		}

		// Token: 0x06028396 RID: 164758 RVA: 0x003D2DDA File Offset: 0x003D0FDA
		protected UXeSSBlueprintLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040160EF RID: 90351
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/XeSSBlueprint.XeSSBlueprintLibrary";

		// Token: 0x040160F0 RID: 90352
		private static IntPtr _ClassPtr;

		// Token: 0x040160F1 RID: 90353
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
