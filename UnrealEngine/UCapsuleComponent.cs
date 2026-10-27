using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200091D RID: 2333
	[UnrealObjectPath("/Script/Engine.CapsuleComponent")]
	[UnrealStructLayout(1600, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1600)]
	public class UCapsuleComponent : UShapeComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008096 RID: 32918 RVA: 0x000B8740 File Offset: 0x000B6940
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCapsuleComponent._ClassPtr;
		}

		// Token: 0x06008097 RID: 32919 RVA: 0x000B874C File Offset: 0x000B694C
		public UCapsuleComponent() : this(BuiltinUtils.AllocNativeUObject(UCapsuleComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008098 RID: 32920 RVA: 0x000B8774 File Offset: 0x000B6974
		[NullableContext(1)]
		public UCapsuleComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCapsuleComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001E39 RID: 7737
		// (get) Token: 0x06008099 RID: 32921 RVA: 0x000B87A7 File Offset: 0x000B69A7
		// (set) Token: 0x0600809A RID: 32922 RVA: 0x000B87B7 File Offset: 0x000B69B7
		public unsafe float CapsuleHalfHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCapsuleComponent.__PropertyOffset_CapsuleHalfHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCapsuleComponent.__PropertyOffset_CapsuleHalfHeight) = value;
			}
		}

		// Token: 0x17001E3A RID: 7738
		// (get) Token: 0x0600809B RID: 32923 RVA: 0x000B87C8 File Offset: 0x000B69C8
		// (set) Token: 0x0600809C RID: 32924 RVA: 0x000B87D8 File Offset: 0x000B69D8
		public unsafe float CapsuleRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCapsuleComponent.__PropertyOffset_CapsuleRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCapsuleComponent.__PropertyOffset_CapsuleRadius) = value;
			}
		}

		// Token: 0x0600809D RID: 32925 RVA: 0x000B87E9 File Offset: 0x000B69E9
		public void SetCapsuleSize(float InRadius, float InHalfHeight, bool bUpdateOverlaps = true)
		{
			UCapsuleComponent.__SetCapsuleSize_Internal(base.NativePtr, InRadius, InHalfHeight, bUpdateOverlaps);
		}

		// Token: 0x0600809E RID: 32926 RVA: 0x000B87F9 File Offset: 0x000B69F9
		public void SetCapsuleRadius(float Radius, bool bUpdateOverlaps = true)
		{
			UCapsuleComponent.__SetCapsuleRadius_Internal(base.NativePtr, Radius, bUpdateOverlaps);
		}

		// Token: 0x0600809F RID: 32927 RVA: 0x000B8808 File Offset: 0x000B6A08
		public void SetCapsuleHalfHeight(float HalfHeight, bool bUpdateOverlaps = true)
		{
			UCapsuleComponent.__SetCapsuleHalfHeight_Internal(base.NativePtr, HalfHeight, bUpdateOverlaps);
		}

		// Token: 0x060080A0 RID: 32928 RVA: 0x000B8818 File Offset: 0x000B6A18
		public unsafe void GetUnscaledCapsuleSize_WithoutHemisphere(ref float OutRadius, ref float OutHalfHeightWithoutHemisphere)
		{
			fixed (float* ptr = &OutRadius)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &OutHalfHeightWithoutHemisphere)
				{
					void* ptr4 = (void*)ptr3;
					UCapsuleComponent.__GetUnscaledCapsuleSize_WithoutHemisphere_Internal(base.NativePtr, ref OutRadius, ref OutHalfHeightWithoutHemisphere);
					ptr = null;
				}
			}
		}

		// Token: 0x060080A1 RID: 32929 RVA: 0x000B8844 File Offset: 0x000B6A44
		public unsafe void GetUnscaledCapsuleSize(ref float OutRadius, ref float OutHalfHeight)
		{
			fixed (float* ptr = &OutRadius)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &OutHalfHeight)
				{
					void* ptr4 = (void*)ptr3;
					UCapsuleComponent.__GetUnscaledCapsuleSize_Internal(base.NativePtr, ref OutRadius, ref OutHalfHeight);
					ptr = null;
				}
			}
		}

		// Token: 0x060080A2 RID: 32930 RVA: 0x000B886E File Offset: 0x000B6A6E
		public float GetUnscaledCapsuleRadius()
		{
			return UCapsuleComponent.__GetUnscaledCapsuleRadius_Internal(base.NativePtr);
		}

		// Token: 0x060080A3 RID: 32931 RVA: 0x000B887B File Offset: 0x000B6A7B
		public float GetUnscaledCapsuleHalfHeight_WithoutHemisphere()
		{
			return UCapsuleComponent.__GetUnscaledCapsuleHalfHeight_WithoutHemisphere_Internal(base.NativePtr);
		}

		// Token: 0x060080A4 RID: 32932 RVA: 0x000B8888 File Offset: 0x000B6A88
		public float GetUnscaledCapsuleHalfHeight()
		{
			return UCapsuleComponent.__GetUnscaledCapsuleHalfHeight_Internal(base.NativePtr);
		}

		// Token: 0x060080A5 RID: 32933 RVA: 0x000B8895 File Offset: 0x000B6A95
		public float GetShapeScale()
		{
			return UCapsuleComponent.__GetShapeScale_Internal(base.NativePtr);
		}

		// Token: 0x060080A6 RID: 32934 RVA: 0x000B88A4 File Offset: 0x000B6AA4
		public unsafe void GetScaledCapsuleSize_WithoutHemisphere(ref float OutRadius, ref float OutHalfHeightWithoutHemisphere)
		{
			fixed (float* ptr = &OutRadius)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &OutHalfHeightWithoutHemisphere)
				{
					void* ptr4 = (void*)ptr3;
					UCapsuleComponent.__GetScaledCapsuleSize_WithoutHemisphere_Internal(base.NativePtr, ref OutRadius, ref OutHalfHeightWithoutHemisphere);
					ptr = null;
				}
			}
		}

		// Token: 0x060080A7 RID: 32935 RVA: 0x000B88D0 File Offset: 0x000B6AD0
		public unsafe void GetScaledCapsuleSize(ref float OutRadius, ref float OutHalfHeight)
		{
			fixed (float* ptr = &OutRadius)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &OutHalfHeight)
				{
					void* ptr4 = (void*)ptr3;
					UCapsuleComponent.__GetScaledCapsuleSize_Internal(base.NativePtr, ref OutRadius, ref OutHalfHeight);
					ptr = null;
				}
			}
		}

		// Token: 0x060080A8 RID: 32936 RVA: 0x000B88FA File Offset: 0x000B6AFA
		public float GetScaledCapsuleRadius()
		{
			return UCapsuleComponent.__GetScaledCapsuleRadius_Internal(base.NativePtr);
		}

		// Token: 0x060080A9 RID: 32937 RVA: 0x000B8907 File Offset: 0x000B6B07
		public float GetScaledCapsuleHalfHeight_WithoutHemisphere()
		{
			return UCapsuleComponent.__GetScaledCapsuleHalfHeight_WithoutHemisphere_Internal(base.NativePtr);
		}

		// Token: 0x060080AA RID: 32938 RVA: 0x000B8914 File Offset: 0x000B6B14
		public float GetScaledCapsuleHalfHeight()
		{
			return UCapsuleComponent.__GetScaledCapsuleHalfHeight_Internal(base.NativePtr);
		}

		// Token: 0x060080AB RID: 32939 RVA: 0x000B8921 File Offset: 0x000B6B21
		public double D_GetScaledCapsuleHalfHeight()
		{
			return UCapsuleComponent.__D_GetScaledCapsuleHalfHeight_Internal(base.NativePtr);
		}

		// Token: 0x060080AC RID: 32940
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCapsuleSize_Internal(IntPtr @this, float InRadius, float InHalfHeight, bool bUpdateOverlaps);

		// Token: 0x060080AD RID: 32941
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCapsuleRadius_Internal(IntPtr @this, float Radius, bool bUpdateOverlaps);

		// Token: 0x060080AE RID: 32942
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCapsuleHalfHeight_Internal(IntPtr @this, float HalfHeight, bool bUpdateOverlaps);

		// Token: 0x060080AF RID: 32943
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetUnscaledCapsuleSize_WithoutHemisphere_Internal(IntPtr @this, ref float OutRadius, ref float OutHalfHeightWithoutHemisphere);

		// Token: 0x060080B0 RID: 32944
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetUnscaledCapsuleSize_Internal(IntPtr @this, ref float OutRadius, ref float OutHalfHeight);

		// Token: 0x060080B1 RID: 32945
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetUnscaledCapsuleRadius_Internal(IntPtr @this);

		// Token: 0x060080B2 RID: 32946
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetUnscaledCapsuleHalfHeight_WithoutHemisphere_Internal(IntPtr @this);

		// Token: 0x060080B3 RID: 32947
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetUnscaledCapsuleHalfHeight_Internal(IntPtr @this);

		// Token: 0x060080B4 RID: 32948
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetShapeScale_Internal(IntPtr @this);

		// Token: 0x060080B5 RID: 32949
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetScaledCapsuleSize_WithoutHemisphere_Internal(IntPtr @this, ref float OutRadius, ref float OutHalfHeightWithoutHemisphere);

		// Token: 0x060080B6 RID: 32950
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetScaledCapsuleSize_Internal(IntPtr @this, ref float OutRadius, ref float OutHalfHeight);

		// Token: 0x060080B7 RID: 32951
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetScaledCapsuleRadius_Internal(IntPtr @this);

		// Token: 0x060080B8 RID: 32952
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetScaledCapsuleHalfHeight_WithoutHemisphere_Internal(IntPtr @this);

		// Token: 0x060080B9 RID: 32953
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetScaledCapsuleHalfHeight_Internal(IntPtr @this);

		// Token: 0x060080BA RID: 32954
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double __D_GetScaledCapsuleHalfHeight_Internal(IntPtr @this);

		// Token: 0x060080BB RID: 32955 RVA: 0x000B892E File Offset: 0x000B6B2E
		static UCapsuleComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.CapsuleComponent");
		}

		// Token: 0x060080BC RID: 32956 RVA: 0x000B893C File Offset: 0x000B6B3C
		protected UCapsuleComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003D8F RID: 15759
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.CapsuleComponent";

		// Token: 0x04003D90 RID: 15760
		private static IntPtr _ClassPtr;

		// Token: 0x04003D91 RID: 15761
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003D92 RID: 15762
		internal static int __PropertyOffset_CapsuleHalfHeight;

		// Token: 0x04003D93 RID: 15763
		internal static int __PropertyOffset_CapsuleRadius;
	}
}
