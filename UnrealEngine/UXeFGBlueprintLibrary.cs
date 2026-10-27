using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002A9E RID: 10910
	[UnrealObjectPath("/Script/XeFGBlueprint.XeFGBlueprintLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UXeFGBlueprintLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028369 RID: 164713 RVA: 0x003D2C3D File Offset: 0x003D0E3D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UXeFGBlueprintLibrary._ClassPtr;
		}

		// Token: 0x0602836A RID: 164714 RVA: 0x003D2C4C File Offset: 0x003D0E4C
		public UXeFGBlueprintLibrary() : this(BuiltinUtils.AllocNativeUObject(UXeFGBlueprintLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602836B RID: 164715 RVA: 0x003D2C74 File Offset: 0x003D0E74
		[NullableContext(1)]
		public UXeFGBlueprintLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UXeFGBlueprintLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602836C RID: 164716
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetXeFGUICompositionState(EXeFGUICompositionState State);

		// Token: 0x0602836D RID: 164717
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetXeFGMode(EXeFGMode Mode);

		// Token: 0x0602836E RID: 164718
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsXeFGSupported();

		// Token: 0x0602836F RID: 164719
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IfRelaunchRequiredByXeFG();

		// Token: 0x06028370 RID: 164720
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern EXeFGUICompositionState GetXeFGUICompositionState();

		// Token: 0x06028371 RID: 164721
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern EXeFGMode GetXeFGMode();

		// Token: 0x06028372 RID: 164722 RVA: 0x003D2CA7 File Offset: 0x003D0EA7
		[NullableContext(1)]
		public static TArray<EXeFGMode> GetSupportedXeFGModes()
		{
			return new TArray<EXeFGMode>(UXeFGBlueprintLibrary.__GetSupportedXeFGModes_Internal(), null);
		}

		// Token: 0x06028373 RID: 164723
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSupportedXeFGModes_Internal();

		// Token: 0x06028374 RID: 164724 RVA: 0x003D2CB4 File Offset: 0x003D0EB4
		static UXeFGBlueprintLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/XeFGBlueprint.XeFGBlueprintLibrary");
		}

		// Token: 0x06028375 RID: 164725 RVA: 0x003D2CC2 File Offset: 0x003D0EC2
		protected UXeFGBlueprintLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040160DB RID: 90331
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/XeFGBlueprint.XeFGBlueprintLibrary";

		// Token: 0x040160DC RID: 90332
		private static IntPtr _ClassPtr;

		// Token: 0x040160DD RID: 90333
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
