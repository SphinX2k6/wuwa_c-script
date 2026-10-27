using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019C4 RID: 6596
	[UnrealObjectPath("/Script/KuroMath.KuroEasingLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroEasingLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018822 RID: 100386 RVA: 0x00241C33 File Offset: 0x0023FE33
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroEasingLibrary._ClassPtr;
		}

		// Token: 0x06018823 RID: 100387 RVA: 0x00241C40 File Offset: 0x0023FE40
		public UKuroEasingLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroEasingLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018824 RID: 100388 RVA: 0x00241C68 File Offset: 0x0023FE68
		[NullableContext(1)]
		public UKuroEasingLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroEasingLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06018825 RID: 100389
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetEasedValue(EEasingType EaseType, float X);

		// Token: 0x06018826 RID: 100390
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float EaseOutSine(float X);

		// Token: 0x06018827 RID: 100391
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float EaseOutQuint(float X);

		// Token: 0x06018828 RID: 100392
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float EaseOutQuart(float X);

		// Token: 0x06018829 RID: 100393
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float EaseOutQuad(float X);

		// Token: 0x0601882A RID: 100394
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float EaseOutExpo(float X);

		// Token: 0x0601882B RID: 100395
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float EaseOutElastic(float X);

		// Token: 0x0601882C RID: 100396
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float EaseOutCubic(float X);

		// Token: 0x0601882D RID: 100397
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float EaseOutCirc(float X);

		// Token: 0x0601882E RID: 100398
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float EaseOutBounce(float X);

		// Token: 0x0601882F RID: 100399
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float EaseOutBack(float X);

		// Token: 0x06018830 RID: 100400
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float EaseInSine(float X);

		// Token: 0x06018831 RID: 100401
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float EaseInQuint(float X);

		// Token: 0x06018832 RID: 100402
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float EaseInQuart(float X);

		// Token: 0x06018833 RID: 100403
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float EaseInQuad(float X);

		// Token: 0x06018834 RID: 100404
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float EaseInOutSine(float X);

		// Token: 0x06018835 RID: 100405
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float EaseInOutQuint(float X);

		// Token: 0x06018836 RID: 100406
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float EaseInOutQuart(float X);

		// Token: 0x06018837 RID: 100407
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float EaseInOutQuad(float X);

		// Token: 0x06018838 RID: 100408
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float EaseInOutExpo(float X);

		// Token: 0x06018839 RID: 100409
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float EaseInOutElastic(float X);

		// Token: 0x0601883A RID: 100410
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float EaseInOutCubic(float X);

		// Token: 0x0601883B RID: 100411
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float EaseInOutCirc(float X);

		// Token: 0x0601883C RID: 100412
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float EaseInOutBounce(float X);

		// Token: 0x0601883D RID: 100413
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float EaseInOutBack(float X);

		// Token: 0x0601883E RID: 100414
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float EaseInExpo(float X);

		// Token: 0x0601883F RID: 100415
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float EaseInElastic(float X);

		// Token: 0x06018840 RID: 100416
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float EaseInCubic(float X);

		// Token: 0x06018841 RID: 100417
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float EaseInCirc(float X);

		// Token: 0x06018842 RID: 100418
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float EaseInBounce(float X);

		// Token: 0x06018843 RID: 100419
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float EaseInBack(float X);

		// Token: 0x06018844 RID: 100420 RVA: 0x00241C9B File Offset: 0x0023FE9B
		static UKuroEasingLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroMath.KuroEasingLibrary");
		}

		// Token: 0x06018845 RID: 100421 RVA: 0x00241CA9 File Offset: 0x0023FEA9
		protected UKuroEasingLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D403 RID: 54275
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroMath.KuroEasingLibrary";

		// Token: 0x0400D404 RID: 54276
		private static IntPtr _ClassPtr;

		// Token: 0x0400D405 RID: 54277
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
