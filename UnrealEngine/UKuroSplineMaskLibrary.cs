using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BC4 RID: 7108
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroSplineMaskLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroSplineMaskLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B46F RID: 111727 RVA: 0x0028316B File Offset: 0x0028136B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSplineMaskLibrary._ClassPtr;
		}

		// Token: 0x0601B470 RID: 111728 RVA: 0x00283178 File Offset: 0x00281378
		public UKuroSplineMaskLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroSplineMaskLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B471 RID: 111729 RVA: 0x002831A0 File Offset: 0x002813A0
		[NullableContext(1)]
		public UKuroSplineMaskLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroSplineMaskLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601B472 RID: 111730 RVA: 0x002831D4 File Offset: 0x002813D4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int WriteSplineUVsToRT(USplineComponent Spline, UCameraComponent Camera, UTextureRenderTarget2D DataRT, int NumSamples = 128, float AspectRatio = 1.7777f)
		{
			UKuroSplineMaskLibrary.__WriteSplineUVsToRT_FunctionParams* ptr = stackalloc UKuroSplineMaskLibrary.__WriteSplineUVsToRT_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UKuroSplineMaskLibrary.__WriteSplineUVsToRT_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSplineMaskLibrary.__WriteSplineUVsToRT_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Spline = ((Spline != null) ? Spline.NativePtr : IntPtr.Zero);
			ptr->Camera = ((Camera != null) ? Camera.NativePtr : IntPtr.Zero);
			ptr->DataRT = ((DataRT != null) ? DataRT.NativePtr : IntPtr.Zero);
			ptr->NumSamples = NumSamples;
			ptr->AspectRatio = AspectRatio;
			UnrealReflectionUtils.CallUFunction(UKuroSplineMaskLibrary._ClassDefaultObjectPtr, UKuroSplineMaskLibrary.__WriteSplineUVsToRT_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601B473 RID: 111731 RVA: 0x0028326A File Offset: 0x0028146A
		static UKuroSplineMaskLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroSplineMaskLibrary");
		}

		// Token: 0x0601B474 RID: 111732 RVA: 0x00283278 File Offset: 0x00281478
		protected UKuroSplineMaskLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EB09 RID: 60169
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroSplineMaskLibrary";

		// Token: 0x0400EB0A RID: 60170
		private static IntPtr _ClassPtr;

		// Token: 0x0400EB0B RID: 60171
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400EB0C RID: 60172
		private static IntPtr __WriteSplineUVsToRT_NativeFunctionPtr;

		// Token: 0x0200317C RID: 12668
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __WriteSplineUVsToRT_FunctionParams
		{
			// Token: 0x04016FB1 RID: 94129
			[FieldOffset(0)]
			public IntPtr Spline;

			// Token: 0x04016FB2 RID: 94130
			[FieldOffset(8)]
			public IntPtr Camera;

			// Token: 0x04016FB3 RID: 94131
			[FieldOffset(16)]
			public IntPtr DataRT;

			// Token: 0x04016FB4 RID: 94132
			[FieldOffset(24)]
			public int NumSamples;

			// Token: 0x04016FB5 RID: 94133
			[FieldOffset(28)]
			public float AspectRatio;

			// Token: 0x04016FB6 RID: 94134
			[FieldOffset(32)]
			public int __Result;
		}
	}
}
