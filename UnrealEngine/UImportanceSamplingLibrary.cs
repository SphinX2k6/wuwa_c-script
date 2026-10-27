using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C40 RID: 3136
	[UnrealObjectPath("/Script/Engine.ImportanceSamplingLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UImportanceSamplingLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009F2B RID: 40747 RVA: 0x000E23E8 File Offset: 0x000E05E8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UImportanceSamplingLibrary._ClassPtr;
		}

		// Token: 0x06009F2C RID: 40748 RVA: 0x000E23F4 File Offset: 0x000E05F4
		public UImportanceSamplingLibrary() : this(BuiltinUtils.AllocNativeUObject(UImportanceSamplingLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009F2D RID: 40749 RVA: 0x000E241C File Offset: 0x000E061C
		[NullableContext(1)]
		public UImportanceSamplingLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UImportanceSamplingLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06009F2E RID: 40750
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float RandomSobolFloat(int Index, int Dimension, float Seed);

		// Token: 0x06009F2F RID: 40751
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector RandomSobolCell3D(int Index, int NumCells = 1, FVector? Cell = null, FVector? Seed = null);

		// Token: 0x06009F30 RID: 40752
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D RandomSobolCell2D(int Index, int NumCells = 1, FVector2D? Cell = null, FVector2D? Seed = null);

		// Token: 0x06009F31 RID: 40753
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float NextSobolFloat(int Index, int Dimension, float PreviousValue);

		// Token: 0x06009F32 RID: 40754
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector NextSobolCell3D(int Index, int NumCells = 1, FVector? PreviousValue = null);

		// Token: 0x06009F33 RID: 40755
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D NextSobolCell2D(int Index, int NumCells = 1, FVector2D? PreviousValue = null);

		// Token: 0x06009F34 RID: 40756 RVA: 0x000E244F File Offset: 0x000E064F
		[NullableContext(1)]
		public static FImportanceTexture MakeImportanceTexture([Nullable(2)] UTexture2D Texture, EImportanceWeight WeightingFunc)
		{
			return new FImportanceTexture(UImportanceSamplingLibrary.__MakeImportanceTexture_Internal((Texture != null) ? Texture.NativePtr : IntPtr.Zero, WeightingFunc), null);
		}

		// Token: 0x06009F35 RID: 40757 RVA: 0x000E2474 File Offset: 0x000E0674
		[NullableContext(2)]
		public unsafe static void ImportanceSample(in FImportanceTexture Texture, in FVector2D Rand, int Samples, float Intensity, ref FVector2D SamplePosition, ref FLinearColor SampleColor, ref float SampleIntensity, ref float SampleSize)
		{
			fixed (FVector2D* ptr = &SamplePosition)
			{
				void* ptr2 = (void*)ptr;
				fixed (FLinearColor* ptr3 = &SampleColor)
				{
					void* ptr4 = (void*)ptr3;
					fixed (float* ptr5 = &SampleIntensity)
					{
						void* ptr6 = (void*)ptr5;
						fixed (float* ptr7 = &SampleSize)
						{
							void* ptr8 = (void*)ptr7;
							UImportanceSamplingLibrary.__ImportanceSample_Internal((Texture ?? new FImportanceTexture()).NativePtr, Rand, Samples, Intensity, ref SamplePosition, ref SampleColor, ref SampleIntensity, ref SampleSize);
							ptr = null;
							ptr3 = null;
							ptr5 = null;
						}
					}
				}
			}
		}

		// Token: 0x06009F36 RID: 40758 RVA: 0x000E24D4 File Offset: 0x000E06D4
		[NullableContext(2)]
		public static void BreakImportanceTexture(in FImportanceTexture ImportanceTexture, ref UTexture2D Texture, ref EImportanceWeight WeightingFunc)
		{
			UTexture2D utexture2D = Texture;
			IntPtr nativeObjectPtr = (utexture2D != null) ? utexture2D.NativePtr : IntPtr.Zero;
			TEnumAsByte<EImportanceWeight> value = WeightingFunc;
			UImportanceSamplingLibrary.__BreakImportanceTexture_Internal((ImportanceTexture ?? new FImportanceTexture()).NativePtr, ref nativeObjectPtr, ref value);
			Texture = BuiltinUtils.GetOrCreateUObjectByNativePointer<UTexture2D>(nativeObjectPtr);
			WeightingFunc = value;
		}

		// Token: 0x06009F37 RID: 40759
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MakeImportanceTexture_Internal(IntPtr Texture, TEnumAsByte<EImportanceWeight> WeightingFunc);

		// Token: 0x06009F38 RID: 40760
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ImportanceSample_Internal(IntPtr Texture, in FVector2D Rand, int Samples, float Intensity, ref FVector2D SamplePosition, ref FLinearColor SampleColor, ref float SampleIntensity, ref float SampleSize);

		// Token: 0x06009F39 RID: 40761
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BreakImportanceTexture_Internal(IntPtr ImportanceTexture, ref IntPtr Texture, ref TEnumAsByte<EImportanceWeight> WeightingFunc);

		// Token: 0x06009F3A RID: 40762 RVA: 0x000E2525 File Offset: 0x000E0725
		static UImportanceSamplingLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ImportanceSamplingLibrary");
		}

		// Token: 0x06009F3B RID: 40763 RVA: 0x000E2533 File Offset: 0x000E0733
		protected UImportanceSamplingLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040057A5 RID: 22437
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ImportanceSamplingLibrary";

		// Token: 0x040057A6 RID: 22438
		private static IntPtr _ClassPtr;

		// Token: 0x040057A7 RID: 22439
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
