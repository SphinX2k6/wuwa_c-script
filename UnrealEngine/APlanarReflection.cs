using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FEE RID: 4078
	[UnrealObjectPath("/Script/Engine.PlanarReflection")]
	[UnrealStructLayout(1080, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1080)]
	public class APlanarReflection : ASceneCapture, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600DCE5 RID: 56549 RVA: 0x0014549E File Offset: 0x0014369E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return APlanarReflection._ClassPtr;
		}

		// Token: 0x0600DCE6 RID: 56550 RVA: 0x001454AC File Offset: 0x001436AC
		public APlanarReflection() : this(BuiltinUtils.AllocNativeUObject(APlanarReflection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600DCE7 RID: 56551 RVA: 0x001454D4 File Offset: 0x001436D4
		[NullableContext(1)]
		public APlanarReflection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(APlanarReflection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003417 RID: 13335
		// (get) Token: 0x0600DCE8 RID: 56552 RVA: 0x00145507 File Offset: 0x00143707
		// (set) Token: 0x0600DCE9 RID: 56553 RVA: 0x0014551B File Offset: 0x0014371B
		[Nullable(2)]
		public unsafe UPlanarReflectionComponent PlanarReflectionComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPlanarReflectionComponent>(base.NativePtr / (IntPtr)sizeof(void*) + APlanarReflection.__PropertyOffset_PlanarReflectionComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + APlanarReflection.__PropertyOffset_PlanarReflectionComponent, value);
			}
		}

		// Token: 0x17003418 RID: 13336
		// (get) Token: 0x0600DCEA RID: 56554 RVA: 0x00145530 File Offset: 0x00143730
		// (set) Token: 0x0600DCEB RID: 56555 RVA: 0x00145540 File Offset: 0x00143740
		public unsafe bool bShowPreviewPlane_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlanarReflection.__PropertyOffset_bShowPreviewPlane_DEPRECATED) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlanarReflection.__PropertyOffset_bShowPreviewPlane_DEPRECATED) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600DCEC RID: 56556 RVA: 0x00145554 File Offset: 0x00143754
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OnInterpToggle(bool bEnable)
		{
			APlanarReflection.__OnInterpToggle_FunctionParams* ptr = stackalloc APlanarReflection.__OnInterpToggle_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(APlanarReflection.__OnInterpToggle_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(APlanarReflection.__OnInterpToggle_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, APlanarReflection.__OnInterpToggle_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0600DCED RID: 56557 RVA: 0x0014559B File Offset: 0x0014379B
		static APlanarReflection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PlanarReflection");
		}

		// Token: 0x0600DCEE RID: 56558 RVA: 0x001455A9 File Offset: 0x001437A9
		protected APlanarReflection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007766 RID: 30566
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.PlanarReflection";

		// Token: 0x04007767 RID: 30567
		private static IntPtr _ClassPtr;

		// Token: 0x04007768 RID: 30568
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007769 RID: 30569
		internal static int __PropertyOffset_PlanarReflectionComponent;

		// Token: 0x0400776A RID: 30570
		internal static int __PropertyOffset_bShowPreviewPlane_DEPRECATED;

		// Token: 0x0400776B RID: 30571
		private static IntPtr __OnInterpToggle_NativeFunctionPtr;

		// Token: 0x02002DC1 RID: 11713
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OnInterpToggle_FunctionParams
		{
			// Token: 0x040167F9 RID: 92153
			[FieldOffset(0)]
			public bool bEnable;
		}
	}
}
