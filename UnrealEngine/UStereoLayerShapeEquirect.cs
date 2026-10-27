using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020011A4 RID: 4516
	[UnrealObjectPath("/Script/Engine.StereoLayerShapeEquirect")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UStereoLayerShapeEquirect : UStereoLayerShape, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010A39 RID: 68153 RVA: 0x00186DCB File Offset: 0x00184FCB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UStereoLayerShapeEquirect._ClassPtr;
		}

		// Token: 0x06010A3A RID: 68154 RVA: 0x00186DD8 File Offset: 0x00184FD8
		public UStereoLayerShapeEquirect() : this(BuiltinUtils.AllocNativeUObject(UStereoLayerShapeEquirect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010A3B RID: 68155 RVA: 0x00186E00 File Offset: 0x00185000
		[NullableContext(1)]
		public UStereoLayerShapeEquirect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UStereoLayerShapeEquirect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170040ED RID: 16621
		// (get) Token: 0x06010A3C RID: 68156 RVA: 0x00186E33 File Offset: 0x00185033
		// (set) Token: 0x06010A3D RID: 68157 RVA: 0x00186E47 File Offset: 0x00185047
		public unsafe FBox2D LeftUVRect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStereoLayerShapeEquirect.__PropertyOffset_LeftUVRect);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStereoLayerShapeEquirect.__PropertyOffset_LeftUVRect) = value;
			}
		}

		// Token: 0x170040EE RID: 16622
		// (get) Token: 0x06010A3E RID: 68158 RVA: 0x00186E5C File Offset: 0x0018505C
		// (set) Token: 0x06010A3F RID: 68159 RVA: 0x00186E70 File Offset: 0x00185070
		public unsafe FBox2D RightUVRect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStereoLayerShapeEquirect.__PropertyOffset_RightUVRect);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStereoLayerShapeEquirect.__PropertyOffset_RightUVRect) = value;
			}
		}

		// Token: 0x170040EF RID: 16623
		// (get) Token: 0x06010A40 RID: 68160 RVA: 0x00186E85 File Offset: 0x00185085
		// (set) Token: 0x06010A41 RID: 68161 RVA: 0x00186E99 File Offset: 0x00185099
		public unsafe FVector2D LeftScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStereoLayerShapeEquirect.__PropertyOffset_LeftScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStereoLayerShapeEquirect.__PropertyOffset_LeftScale) = value;
			}
		}

		// Token: 0x170040F0 RID: 16624
		// (get) Token: 0x06010A42 RID: 68162 RVA: 0x00186EAE File Offset: 0x001850AE
		// (set) Token: 0x06010A43 RID: 68163 RVA: 0x00186EC2 File Offset: 0x001850C2
		public unsafe FVector2D RightScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStereoLayerShapeEquirect.__PropertyOffset_RightScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStereoLayerShapeEquirect.__PropertyOffset_RightScale) = value;
			}
		}

		// Token: 0x170040F1 RID: 16625
		// (get) Token: 0x06010A44 RID: 68164 RVA: 0x00186ED7 File Offset: 0x001850D7
		// (set) Token: 0x06010A45 RID: 68165 RVA: 0x00186EEB File Offset: 0x001850EB
		public unsafe FVector2D LeftBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStereoLayerShapeEquirect.__PropertyOffset_LeftBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStereoLayerShapeEquirect.__PropertyOffset_LeftBias) = value;
			}
		}

		// Token: 0x170040F2 RID: 16626
		// (get) Token: 0x06010A46 RID: 68166 RVA: 0x00186F00 File Offset: 0x00185100
		// (set) Token: 0x06010A47 RID: 68167 RVA: 0x00186F14 File Offset: 0x00185114
		public unsafe FVector2D RightBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStereoLayerShapeEquirect.__PropertyOffset_RightBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStereoLayerShapeEquirect.__PropertyOffset_RightBias) = value;
			}
		}

		// Token: 0x06010A48 RID: 68168 RVA: 0x00186F29 File Offset: 0x00185129
		[NullableContext(2)]
		public void SetEquirectProps(FEquirectProps InScaleBiases)
		{
			UStereoLayerShapeEquirect.__SetEquirectProps_Internal(base.NativePtr, (InScaleBiases ?? new FEquirectProps()).NativePtr);
		}

		// Token: 0x06010A49 RID: 68169
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEquirectProps_Internal(IntPtr @this, IntPtr InScaleBiases);

		// Token: 0x06010A4A RID: 68170 RVA: 0x00186F45 File Offset: 0x00185145
		static UStereoLayerShapeEquirect()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.StereoLayerShapeEquirect");
		}

		// Token: 0x06010A4B RID: 68171 RVA: 0x00186F53 File Offset: 0x00185153
		protected UStereoLayerShapeEquirect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008E57 RID: 36439
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.StereoLayerShapeEquirect";

		// Token: 0x04008E58 RID: 36440
		private static IntPtr _ClassPtr;

		// Token: 0x04008E59 RID: 36441
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008E5A RID: 36442
		internal static int __PropertyOffset_LeftUVRect;

		// Token: 0x04008E5B RID: 36443
		internal static int __PropertyOffset_RightUVRect;

		// Token: 0x04008E5C RID: 36444
		internal static int __PropertyOffset_LeftScale;

		// Token: 0x04008E5D RID: 36445
		internal static int __PropertyOffset_RightScale;

		// Token: 0x04008E5E RID: 36446
		internal static int __PropertyOffset_LeftBias;

		// Token: 0x04008E5F RID: 36447
		internal static int __PropertyOffset_RightBias;
	}
}
