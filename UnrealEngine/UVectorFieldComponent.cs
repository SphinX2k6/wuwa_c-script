using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001222 RID: 4642
	[UnrealObjectPath("/Script/Engine.VectorFieldComponent")]
	[UnrealStructLayout(1600, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1600)]
	public class UVectorFieldComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011169 RID: 69993 RVA: 0x00191373 File Offset: 0x0018F573
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UVectorFieldComponent._ClassPtr;
		}

		// Token: 0x0601116A RID: 69994 RVA: 0x00191380 File Offset: 0x0018F580
		public UVectorFieldComponent() : this(BuiltinUtils.AllocNativeUObject(UVectorFieldComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601116B RID: 69995 RVA: 0x001913A8 File Offset: 0x0018F5A8
		[NullableContext(1)]
		public UVectorFieldComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UVectorFieldComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170042BB RID: 17083
		// (get) Token: 0x0601116C RID: 69996 RVA: 0x001913DB File Offset: 0x0018F5DB
		// (set) Token: 0x0601116D RID: 69997 RVA: 0x001913EF File Offset: 0x0018F5EF
		[Nullable(2)]
		public unsafe UVectorField VectorField
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UVectorField>(base.NativePtr / (IntPtr)sizeof(void*) + UVectorFieldComponent.__PropertyOffset_VectorField);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UVectorFieldComponent.__PropertyOffset_VectorField, value);
			}
		}

		// Token: 0x170042BC RID: 17084
		// (get) Token: 0x0601116E RID: 69998 RVA: 0x00191404 File Offset: 0x0018F604
		// (set) Token: 0x0601116F RID: 69999 RVA: 0x00191414 File Offset: 0x0018F614
		public unsafe float Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UVectorFieldComponent.__PropertyOffset_Intensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UVectorFieldComponent.__PropertyOffset_Intensity) = value;
			}
		}

		// Token: 0x170042BD RID: 17085
		// (get) Token: 0x06011170 RID: 70000 RVA: 0x00191425 File Offset: 0x0018F625
		// (set) Token: 0x06011171 RID: 70001 RVA: 0x00191435 File Offset: 0x0018F635
		public unsafe float Tightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UVectorFieldComponent.__PropertyOffset_Tightness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UVectorFieldComponent.__PropertyOffset_Tightness) = value;
			}
		}

		// Token: 0x170042BE RID: 17086
		// (get) Token: 0x06011172 RID: 70002 RVA: 0x00191446 File Offset: 0x0018F646
		// (set) Token: 0x06011173 RID: 70003 RVA: 0x0019145F File Offset: 0x0018F65F
		public unsafe bool bPreviewVectorField
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UVectorFieldComponent.__PropertyOffset_bPreviewVectorField) & UVectorFieldComponent.__PropertyMask_bPreviewVectorField) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UVectorFieldComponent.__PropertyOffset_bPreviewVectorField) = ((*(base.NativePtr + (IntPtr)UVectorFieldComponent.__PropertyOffset_bPreviewVectorField) & ~UVectorFieldComponent.__PropertyMask_bPreviewVectorField) | (value ? UVectorFieldComponent.__PropertyMask_bPreviewVectorField : 0));
			}
		}

		// Token: 0x06011174 RID: 70004 RVA: 0x00191490 File Offset: 0x0018F690
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetIntensity(float NewIntensity)
		{
			UVectorFieldComponent.__SetIntensity_FunctionParams* ptr = stackalloc UVectorFieldComponent.__SetIntensity_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UVectorFieldComponent.__SetIntensity_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UVectorFieldComponent.__SetIntensity_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NewIntensity = NewIntensity;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UVectorFieldComponent.__SetIntensity_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06011175 RID: 70005 RVA: 0x001914D7 File Offset: 0x0018F6D7
		static UVectorFieldComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.VectorFieldComponent");
		}

		// Token: 0x06011176 RID: 70006 RVA: 0x001914E5 File Offset: 0x0018F6E5
		protected UVectorFieldComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400925F RID: 37471
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.VectorFieldComponent";

		// Token: 0x04009260 RID: 37472
		private static IntPtr _ClassPtr;

		// Token: 0x04009261 RID: 37473
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009262 RID: 37474
		internal static int __PropertyOffset_VectorField;

		// Token: 0x04009263 RID: 37475
		internal static int __PropertyOffset_Intensity;

		// Token: 0x04009264 RID: 37476
		internal static int __PropertyOffset_Tightness;

		// Token: 0x04009265 RID: 37477
		internal static int __PropertyOffset_bPreviewVectorField;

		// Token: 0x04009266 RID: 37478
		internal static byte __PropertyMask_bPreviewVectorField;

		// Token: 0x04009267 RID: 37479
		private static IntPtr __SetIntensity_NativeFunctionPtr;

		// Token: 0x02002E02 RID: 11778
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetIntensity_FunctionParams
		{
			// Token: 0x0401686B RID: 92267
			[FieldOffset(0)]
			public float NewIntensity;
		}
	}
}
