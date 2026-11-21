using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200019F RID: 415
	[UnrealObjectPath("/Script/Engine.CapsuleComponent")]
	[UnrealStructLayout(1600, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1600)]
	public class UCapsuleComponent : UShapeComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001BF8 RID: 7160 RVA: 0x000297E6 File Offset: 0x000279E6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCapsuleComponent._ClassPtr;
		}

		// Token: 0x06001BF9 RID: 7161 RVA: 0x000297F4 File Offset: 0x000279F4
		public UCapsuleComponent() : this(BuiltinUtils.AllocNativeUObject(UCapsuleComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001BFA RID: 7162 RVA: 0x0002981C File Offset: 0x00027A1C
		[NullableContext(1)]
		public UCapsuleComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCapsuleComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06001BFB RID: 7163 RVA: 0x0002984F File Offset: 0x00027A4F
		// (set) Token: 0x06001BFC RID: 7164 RVA: 0x0002985F File Offset: 0x00027A5F
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

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06001BFD RID: 7165 RVA: 0x00029870 File Offset: 0x00027A70
		// (set) Token: 0x06001BFE RID: 7166 RVA: 0x00029880 File Offset: 0x00027A80
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

		// Token: 0x06001BFF RID: 7167 RVA: 0x00029891 File Offset: 0x00027A91
		public void SetCapsuleSize(float InRadius, float InHalfHeight, bool bUpdateOverlaps = true)
		{
			UCapsuleComponent.__SetCapsuleSize_Internal(base.NativePtr, InRadius, InHalfHeight, bUpdateOverlaps);
		}

		// Token: 0x06001C00 RID: 7168 RVA: 0x000298A1 File Offset: 0x00027AA1
		public void SetCapsuleRadius(float Radius, bool bUpdateOverlaps = true)
		{
			UCapsuleComponent.__SetCapsuleRadius_Internal(base.NativePtr, Radius, bUpdateOverlaps);
		}

		// Token: 0x06001C01 RID: 7169 RVA: 0x000298B0 File Offset: 0x00027AB0
		public void SetCapsuleHalfHeight(float HalfHeight, bool bUpdateOverlaps = true)
		{
			UCapsuleComponent.__SetCapsuleHalfHeight_Internal(base.NativePtr, HalfHeight, bUpdateOverlaps);
		}

		// Token: 0x06001C02 RID: 7170 RVA: 0x000298C0 File Offset: 0x00027AC0
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

		// Token: 0x06001C03 RID: 7171 RVA: 0x000298EC File Offset: 0x00027AEC
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

		// Token: 0x06001C04 RID: 7172 RVA: 0x00029916 File Offset: 0x00027B16
		public float GetUnscaledCapsuleRadius()
		{
			return UCapsuleComponent.__GetUnscaledCapsuleRadius_Internal(base.NativePtr);
		}

		// Token: 0x06001C05 RID: 7173 RVA: 0x00029923 File Offset: 0x00027B23
		public float GetUnscaledCapsuleHalfHeight_WithoutHemisphere()
		{
			return UCapsuleComponent.__GetUnscaledCapsuleHalfHeight_WithoutHemisphere_Internal(base.NativePtr);
		}

		// Token: 0x06001C06 RID: 7174 RVA: 0x00029930 File Offset: 0x00027B30
		public float GetUnscaledCapsuleHalfHeight()
		{
			return UCapsuleComponent.__GetUnscaledCapsuleHalfHeight_Internal(base.NativePtr);
		}

		// Token: 0x06001C07 RID: 7175 RVA: 0x0002993D File Offset: 0x00027B3D
		public float GetShapeScale()
		{
			return UCapsuleComponent.__GetShapeScale_Internal(base.NativePtr);
		}

		// Token: 0x06001C08 RID: 7176 RVA: 0x0002994C File Offset: 0x00027B4C
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

		// Token: 0x06001C09 RID: 7177 RVA: 0x00029978 File Offset: 0x00027B78
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

		// Token: 0x06001C0A RID: 7178 RVA: 0x000299A2 File Offset: 0x00027BA2
		public float GetScaledCapsuleRadius()
		{
			return UCapsuleComponent.__GetScaledCapsuleRadius_Internal(base.NativePtr);
		}

		// Token: 0x06001C0B RID: 7179 RVA: 0x000299AF File Offset: 0x00027BAF
		public float GetScaledCapsuleHalfHeight_WithoutHemisphere()
		{
			return UCapsuleComponent.__GetScaledCapsuleHalfHeight_WithoutHemisphere_Internal(base.NativePtr);
		}

		// Token: 0x06001C0C RID: 7180 RVA: 0x000299BC File Offset: 0x00027BBC
		public float GetScaledCapsuleHalfHeight()
		{
			return UCapsuleComponent.__GetScaledCapsuleHalfHeight_Internal(base.NativePtr);
		}

		// Token: 0x06001C0D RID: 7181 RVA: 0x000299C9 File Offset: 0x00027BC9
		public double D_GetScaledCapsuleHalfHeight()
		{
			return UCapsuleComponent.__D_GetScaledCapsuleHalfHeight_Internal(base.NativePtr);
		}

		// Token: 0x06001C0E RID: 7182
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCapsuleSize_Internal(IntPtr @this, float InRadius, float InHalfHeight, bool bUpdateOverlaps);

		// Token: 0x06001C0F RID: 7183
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCapsuleRadius_Internal(IntPtr @this, float Radius, bool bUpdateOverlaps);

		// Token: 0x06001C10 RID: 7184
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCapsuleHalfHeight_Internal(IntPtr @this, float HalfHeight, bool bUpdateOverlaps);

		// Token: 0x06001C11 RID: 7185
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetUnscaledCapsuleSize_WithoutHemisphere_Internal(IntPtr @this, ref float OutRadius, ref float OutHalfHeightWithoutHemisphere);

		// Token: 0x06001C12 RID: 7186
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetUnscaledCapsuleSize_Internal(IntPtr @this, ref float OutRadius, ref float OutHalfHeight);

		// Token: 0x06001C13 RID: 7187
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetUnscaledCapsuleRadius_Internal(IntPtr @this);

		// Token: 0x06001C14 RID: 7188
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetUnscaledCapsuleHalfHeight_WithoutHemisphere_Internal(IntPtr @this);

		// Token: 0x06001C15 RID: 7189
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetUnscaledCapsuleHalfHeight_Internal(IntPtr @this);

		// Token: 0x06001C16 RID: 7190
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetShapeScale_Internal(IntPtr @this);

		// Token: 0x06001C17 RID: 7191
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetScaledCapsuleSize_WithoutHemisphere_Internal(IntPtr @this, ref float OutRadius, ref float OutHalfHeightWithoutHemisphere);

		// Token: 0x06001C18 RID: 7192
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetScaledCapsuleSize_Internal(IntPtr @this, ref float OutRadius, ref float OutHalfHeight);

		// Token: 0x06001C19 RID: 7193
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetScaledCapsuleRadius_Internal(IntPtr @this);

		// Token: 0x06001C1A RID: 7194
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetScaledCapsuleHalfHeight_WithoutHemisphere_Internal(IntPtr @this);

		// Token: 0x06001C1B RID: 7195
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetScaledCapsuleHalfHeight_Internal(IntPtr @this);

		// Token: 0x06001C1C RID: 7196
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double __D_GetScaledCapsuleHalfHeight_Internal(IntPtr @this);

		// Token: 0x06001C1D RID: 7197 RVA: 0x000299D6 File Offset: 0x00027BD6
		static UCapsuleComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.CapsuleComponent");
		}

		// Token: 0x06001C1E RID: 7198 RVA: 0x000299E4 File Offset: 0x00027BE4
		protected UCapsuleComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400091E RID: 2334
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.CapsuleComponent";

		// Token: 0x0400091F RID: 2335
		private static IntPtr _ClassPtr;

		// Token: 0x04000920 RID: 2336
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000921 RID: 2337
		internal static int __PropertyOffset_CapsuleHalfHeight;

		// Token: 0x04000922 RID: 2338
		internal static int __PropertyOffset_CapsuleRadius;
	}
}
