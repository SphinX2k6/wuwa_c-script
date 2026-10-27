using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001444 RID: 5188
	[UnrealObjectPath("/Script/GLTFExporter.GLTFCameraActor")]
	[UnrealStructLayout(3776, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3776)]
	public class AGLTFCameraActor : ACameraActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06012F58 RID: 77656 RVA: 0x001BDFB6 File Offset: 0x001BC1B6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AGLTFCameraActor._ClassPtr;
		}

		// Token: 0x06012F59 RID: 77657 RVA: 0x001BDFC4 File Offset: 0x001BC1C4
		public AGLTFCameraActor() : this(BuiltinUtils.AllocNativeUObject(AGLTFCameraActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012F5A RID: 77658 RVA: 0x001BDFEC File Offset: 0x001BC1EC
		[NullableContext(1)]
		public AGLTFCameraActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AGLTFCameraActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170049AA RID: 18858
		// (get) Token: 0x06012F5B RID: 77659 RVA: 0x001BE01F File Offset: 0x001BC21F
		// (set) Token: 0x06012F5C RID: 77660 RVA: 0x001BE02F File Offset: 0x001BC22F
		public unsafe EGLTFCameraControlMode Mode
		{
			get
			{
				return (EGLTFCameraControlMode)(*(base.NativePtr + (IntPtr)AGLTFCameraActor.__PropertyOffset_Mode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGLTFCameraActor.__PropertyOffset_Mode) = (byte)value;
			}
		}

		// Token: 0x170049AB RID: 18859
		// (get) Token: 0x06012F5D RID: 77661 RVA: 0x001BE040 File Offset: 0x001BC240
		// (set) Token: 0x06012F5E RID: 77662 RVA: 0x001BE054 File Offset: 0x001BC254
		[Nullable(2)]
		public unsafe AActor Target
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + AGLTFCameraActor.__PropertyOffset_Target);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AGLTFCameraActor.__PropertyOffset_Target, value);
			}
		}

		// Token: 0x170049AC RID: 18860
		// (get) Token: 0x06012F5F RID: 77663 RVA: 0x001BE069 File Offset: 0x001BC269
		// (set) Token: 0x06012F60 RID: 77664 RVA: 0x001BE079 File Offset: 0x001BC279
		public unsafe float PitchAngleMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGLTFCameraActor.__PropertyOffset_PitchAngleMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGLTFCameraActor.__PropertyOffset_PitchAngleMin) = value;
			}
		}

		// Token: 0x170049AD RID: 18861
		// (get) Token: 0x06012F61 RID: 77665 RVA: 0x001BE08A File Offset: 0x001BC28A
		// (set) Token: 0x06012F62 RID: 77666 RVA: 0x001BE09A File Offset: 0x001BC29A
		public unsafe float PitchAngleMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGLTFCameraActor.__PropertyOffset_PitchAngleMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGLTFCameraActor.__PropertyOffset_PitchAngleMax) = value;
			}
		}

		// Token: 0x170049AE RID: 18862
		// (get) Token: 0x06012F63 RID: 77667 RVA: 0x001BE0AB File Offset: 0x001BC2AB
		// (set) Token: 0x06012F64 RID: 77668 RVA: 0x001BE0BB File Offset: 0x001BC2BB
		public unsafe float YawAngleMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGLTFCameraActor.__PropertyOffset_YawAngleMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGLTFCameraActor.__PropertyOffset_YawAngleMin) = value;
			}
		}

		// Token: 0x170049AF RID: 18863
		// (get) Token: 0x06012F65 RID: 77669 RVA: 0x001BE0CC File Offset: 0x001BC2CC
		// (set) Token: 0x06012F66 RID: 77670 RVA: 0x001BE0DC File Offset: 0x001BC2DC
		public unsafe float YawAngleMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGLTFCameraActor.__PropertyOffset_YawAngleMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGLTFCameraActor.__PropertyOffset_YawAngleMax) = value;
			}
		}

		// Token: 0x170049B0 RID: 18864
		// (get) Token: 0x06012F67 RID: 77671 RVA: 0x001BE0ED File Offset: 0x001BC2ED
		// (set) Token: 0x06012F68 RID: 77672 RVA: 0x001BE0FD File Offset: 0x001BC2FD
		public unsafe float DistanceMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGLTFCameraActor.__PropertyOffset_DistanceMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGLTFCameraActor.__PropertyOffset_DistanceMin) = value;
			}
		}

		// Token: 0x170049B1 RID: 18865
		// (get) Token: 0x06012F69 RID: 77673 RVA: 0x001BE10E File Offset: 0x001BC30E
		// (set) Token: 0x06012F6A RID: 77674 RVA: 0x001BE11E File Offset: 0x001BC31E
		public unsafe float DistanceMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGLTFCameraActor.__PropertyOffset_DistanceMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGLTFCameraActor.__PropertyOffset_DistanceMax) = value;
			}
		}

		// Token: 0x170049B2 RID: 18866
		// (get) Token: 0x06012F6B RID: 77675 RVA: 0x001BE12F File Offset: 0x001BC32F
		// (set) Token: 0x06012F6C RID: 77676 RVA: 0x001BE13F File Offset: 0x001BC33F
		public unsafe float DollyDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGLTFCameraActor.__PropertyOffset_DollyDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGLTFCameraActor.__PropertyOffset_DollyDuration) = value;
			}
		}

		// Token: 0x170049B3 RID: 18867
		// (get) Token: 0x06012F6D RID: 77677 RVA: 0x001BE150 File Offset: 0x001BC350
		// (set) Token: 0x06012F6E RID: 77678 RVA: 0x001BE160 File Offset: 0x001BC360
		public unsafe float DollySensitivity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGLTFCameraActor.__PropertyOffset_DollySensitivity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGLTFCameraActor.__PropertyOffset_DollySensitivity) = value;
			}
		}

		// Token: 0x170049B4 RID: 18868
		// (get) Token: 0x06012F6F RID: 77679 RVA: 0x001BE171 File Offset: 0x001BC371
		// (set) Token: 0x06012F70 RID: 77680 RVA: 0x001BE181 File Offset: 0x001BC381
		public unsafe float RotationInertia
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGLTFCameraActor.__PropertyOffset_RotationInertia);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGLTFCameraActor.__PropertyOffset_RotationInertia) = value;
			}
		}

		// Token: 0x170049B5 RID: 18869
		// (get) Token: 0x06012F71 RID: 77681 RVA: 0x001BE192 File Offset: 0x001BC392
		// (set) Token: 0x06012F72 RID: 77682 RVA: 0x001BE1A2 File Offset: 0x001BC3A2
		public unsafe float RotationSensitivity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGLTFCameraActor.__PropertyOffset_RotationSensitivity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGLTFCameraActor.__PropertyOffset_RotationSensitivity) = value;
			}
		}

		// Token: 0x06012F73 RID: 77683 RVA: 0x001BE1B4 File Offset: 0x001BC3B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OnMouseY(float AxisValue)
		{
			AGLTFCameraActor.__OnMouseY_FunctionParams* ptr = stackalloc AGLTFCameraActor.__OnMouseY_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(AGLTFCameraActor.__OnMouseY_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AGLTFCameraActor.__OnMouseY_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AxisValue = AxisValue;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AGLTFCameraActor.__OnMouseY_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06012F74 RID: 77684 RVA: 0x001BE1FC File Offset: 0x001BC3FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OnMouseX(float AxisValue)
		{
			AGLTFCameraActor.__OnMouseX_FunctionParams* ptr = stackalloc AGLTFCameraActor.__OnMouseX_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(AGLTFCameraActor.__OnMouseX_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AGLTFCameraActor.__OnMouseX_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AxisValue = AxisValue;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AGLTFCameraActor.__OnMouseX_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06012F75 RID: 77685 RVA: 0x001BE244 File Offset: 0x001BC444
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OnMouseWheelAxis(float AxisValue)
		{
			AGLTFCameraActor.__OnMouseWheelAxis_FunctionParams* ptr = stackalloc AGLTFCameraActor.__OnMouseWheelAxis_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(AGLTFCameraActor.__OnMouseWheelAxis_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AGLTFCameraActor.__OnMouseWheelAxis_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AxisValue = AxisValue;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AGLTFCameraActor.__OnMouseWheelAxis_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06012F76 RID: 77686 RVA: 0x001BE28B File Offset: 0x001BC48B
		static AGLTFCameraActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GLTFExporter.GLTFCameraActor");
		}

		// Token: 0x06012F77 RID: 77687 RVA: 0x001BE299 File Offset: 0x001BC499
		protected AGLTFCameraActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A237 RID: 41527
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GLTFExporter.GLTFCameraActor";

		// Token: 0x0400A238 RID: 41528
		private static IntPtr _ClassPtr;

		// Token: 0x0400A239 RID: 41529
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A23A RID: 41530
		internal static int __PropertyOffset_Mode;

		// Token: 0x0400A23B RID: 41531
		internal static int __PropertyOffset_Target;

		// Token: 0x0400A23C RID: 41532
		internal static int __PropertyOffset_PitchAngleMin;

		// Token: 0x0400A23D RID: 41533
		internal static int __PropertyOffset_PitchAngleMax;

		// Token: 0x0400A23E RID: 41534
		internal static int __PropertyOffset_YawAngleMin;

		// Token: 0x0400A23F RID: 41535
		internal static int __PropertyOffset_YawAngleMax;

		// Token: 0x0400A240 RID: 41536
		internal static int __PropertyOffset_DistanceMin;

		// Token: 0x0400A241 RID: 41537
		internal static int __PropertyOffset_DistanceMax;

		// Token: 0x0400A242 RID: 41538
		internal static int __PropertyOffset_DollyDuration;

		// Token: 0x0400A243 RID: 41539
		internal static int __PropertyOffset_DollySensitivity;

		// Token: 0x0400A244 RID: 41540
		internal static int __PropertyOffset_RotationInertia;

		// Token: 0x0400A245 RID: 41541
		internal static int __PropertyOffset_RotationSensitivity;

		// Token: 0x0400A246 RID: 41542
		private static IntPtr __OnMouseY_NativeFunctionPtr;

		// Token: 0x0400A247 RID: 41543
		private static IntPtr __OnMouseX_NativeFunctionPtr;

		// Token: 0x0400A248 RID: 41544
		private static IntPtr __OnMouseWheelAxis_NativeFunctionPtr;

		// Token: 0x02002E91 RID: 11921
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __OnMouseY_FunctionParams
		{
			// Token: 0x04016962 RID: 92514
			[FieldOffset(0)]
			public float AxisValue;
		}

		// Token: 0x02002E92 RID: 11922
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __OnMouseX_FunctionParams
		{
			// Token: 0x04016963 RID: 92515
			[FieldOffset(0)]
			public float AxisValue;
		}

		// Token: 0x02002E93 RID: 11923
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __OnMouseWheelAxis_FunctionParams
		{
			// Token: 0x04016964 RID: 92516
			[FieldOffset(0)]
			public float AxisValue;
		}
	}
}
