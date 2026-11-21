using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002A0 RID: 672
	[UnrealObjectPath("/Script/Engine.TextureRenderTarget2D")]
	[UnrealStructLayout(4688, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 4688)]
	public class UTextureRenderTarget2D : UTextureRenderTarget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06004994 RID: 18836 RVA: 0x00067289 File Offset: 0x00065489
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTextureRenderTarget2D._ClassPtr;
		}

		// Token: 0x06004995 RID: 18837 RVA: 0x00067298 File Offset: 0x00065498
		public UTextureRenderTarget2D() : this(BuiltinUtils.AllocNativeUObject(UTextureRenderTarget2D.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004996 RID: 18838 RVA: 0x000672C0 File Offset: 0x000654C0
		[NullableContext(1)]
		public UTextureRenderTarget2D(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTextureRenderTarget2D.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000DCD RID: 3533
		// (get) Token: 0x06004997 RID: 18839 RVA: 0x000672F3 File Offset: 0x000654F3
		// (set) Token: 0x06004998 RID: 18840 RVA: 0x00067303 File Offset: 0x00065503
		public unsafe int SizeX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_SizeX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_SizeX) = value;
			}
		}

		// Token: 0x17000DCE RID: 3534
		// (get) Token: 0x06004999 RID: 18841 RVA: 0x00067314 File Offset: 0x00065514
		// (set) Token: 0x0600499A RID: 18842 RVA: 0x00067324 File Offset: 0x00065524
		public unsafe int SizeY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_SizeY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_SizeY) = value;
			}
		}

		// Token: 0x17000DCF RID: 3535
		// (get) Token: 0x0600499B RID: 18843 RVA: 0x00067335 File Offset: 0x00065535
		// (set) Token: 0x0600499C RID: 18844 RVA: 0x00067349 File Offset: 0x00065549
		public unsafe FLinearColor ClearColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_ClearColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_ClearColor) = value;
			}
		}

		// Token: 0x17000DD0 RID: 3536
		// (get) Token: 0x0600499D RID: 18845 RVA: 0x0006735E File Offset: 0x0006555E
		// (set) Token: 0x0600499E RID: 18846 RVA: 0x00067377 File Offset: 0x00065577
		public unsafe bool bForceLinearGamma
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_bForceLinearGamma) & UTextureRenderTarget2D.__PropertyMask_bForceLinearGamma) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_bForceLinearGamma) = ((*(base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_bForceLinearGamma) & ~UTextureRenderTarget2D.__PropertyMask_bForceLinearGamma) | (value ? UTextureRenderTarget2D.__PropertyMask_bForceLinearGamma : 0));
			}
		}

		// Token: 0x17000DD1 RID: 3537
		// (get) Token: 0x0600499F RID: 18847 RVA: 0x000673A7 File Offset: 0x000655A7
		// (set) Token: 0x060049A0 RID: 18848 RVA: 0x000673C0 File Offset: 0x000655C0
		public unsafe bool bHDR_DEPRECATED
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_bHDR_DEPRECATED) & UTextureRenderTarget2D.__PropertyMask_bHDR_DEPRECATED) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_bHDR_DEPRECATED) = ((*(base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_bHDR_DEPRECATED) & ~UTextureRenderTarget2D.__PropertyMask_bHDR_DEPRECATED) | (value ? UTextureRenderTarget2D.__PropertyMask_bHDR_DEPRECATED : 0));
			}
		}

		// Token: 0x17000DD2 RID: 3538
		// (get) Token: 0x060049A1 RID: 18849 RVA: 0x000673F0 File Offset: 0x000655F0
		// (set) Token: 0x060049A2 RID: 18850 RVA: 0x00067409 File Offset: 0x00065609
		public unsafe bool bGPUSharedFlag
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_bGPUSharedFlag) & UTextureRenderTarget2D.__PropertyMask_bGPUSharedFlag) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_bGPUSharedFlag) = ((*(base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_bGPUSharedFlag) & ~UTextureRenderTarget2D.__PropertyMask_bGPUSharedFlag) | (value ? UTextureRenderTarget2D.__PropertyMask_bGPUSharedFlag : 0));
			}
		}

		// Token: 0x17000DD3 RID: 3539
		// (get) Token: 0x060049A3 RID: 18851 RVA: 0x00067439 File Offset: 0x00065639
		// (set) Token: 0x060049A4 RID: 18852 RVA: 0x0006744D File Offset: 0x0006564D
		public unsafe TEnumAsByte<ETextureRenderTargetFormat> RenderTargetFormat
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_RenderTargetFormat);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_RenderTargetFormat) = value;
			}
		}

		// Token: 0x17000DD4 RID: 3540
		// (get) Token: 0x060049A5 RID: 18853 RVA: 0x00067462 File Offset: 0x00065662
		// (set) Token: 0x060049A6 RID: 18854 RVA: 0x0006747B File Offset: 0x0006567B
		public unsafe bool bAutoGenerateMips
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_bAutoGenerateMips) & UTextureRenderTarget2D.__PropertyMask_bAutoGenerateMips) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_bAutoGenerateMips) = ((*(base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_bAutoGenerateMips) & ~UTextureRenderTarget2D.__PropertyMask_bAutoGenerateMips) | (value ? UTextureRenderTarget2D.__PropertyMask_bAutoGenerateMips : 0));
			}
		}

		// Token: 0x17000DD5 RID: 3541
		// (get) Token: 0x060049A7 RID: 18855 RVA: 0x000674AB File Offset: 0x000656AB
		// (set) Token: 0x060049A8 RID: 18856 RVA: 0x000674BF File Offset: 0x000656BF
		public unsafe TEnumAsByte<EPixelFormat> OverrideFormat
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_OverrideFormat);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextureRenderTarget2D.__PropertyOffset_OverrideFormat) = value;
			}
		}

		// Token: 0x060049A9 RID: 18857 RVA: 0x000674D4 File Offset: 0x000656D4
		static UTextureRenderTarget2D()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.TextureRenderTarget2D");
		}

		// Token: 0x060049AA RID: 18858 RVA: 0x000674E2 File Offset: 0x000656E2
		protected UTextureRenderTarget2D(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001CF4 RID: 7412
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.TextureRenderTarget2D";

		// Token: 0x04001CF5 RID: 7413
		private static IntPtr _ClassPtr;

		// Token: 0x04001CF6 RID: 7414
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001CF7 RID: 7415
		internal static int __PropertyOffset_SizeX;

		// Token: 0x04001CF8 RID: 7416
		internal static int __PropertyOffset_SizeY;

		// Token: 0x04001CF9 RID: 7417
		internal static int __PropertyOffset_ClearColor;

		// Token: 0x04001CFA RID: 7418
		internal static int __PropertyOffset_bForceLinearGamma;

		// Token: 0x04001CFB RID: 7419
		internal static byte __PropertyMask_bForceLinearGamma;

		// Token: 0x04001CFC RID: 7420
		internal static int __PropertyOffset_bHDR_DEPRECATED;

		// Token: 0x04001CFD RID: 7421
		internal static byte __PropertyMask_bHDR_DEPRECATED;

		// Token: 0x04001CFE RID: 7422
		internal static int __PropertyOffset_bGPUSharedFlag;

		// Token: 0x04001CFF RID: 7423
		internal static byte __PropertyMask_bGPUSharedFlag;

		// Token: 0x04001D00 RID: 7424
		internal static int __PropertyOffset_RenderTargetFormat;

		// Token: 0x04001D01 RID: 7425
		internal static int __PropertyOffset_bAutoGenerateMips;

		// Token: 0x04001D02 RID: 7426
		internal static byte __PropertyMask_bAutoGenerateMips;

		// Token: 0x04001D03 RID: 7427
		internal static int __PropertyOffset_OverrideFormat;
	}
}
