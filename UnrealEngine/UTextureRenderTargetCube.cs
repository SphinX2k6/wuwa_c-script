using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020011E1 RID: 4577
	[UnrealObjectPath("/Script/Engine.TextureRenderTargetCube")]
	[UnrealStructLayout(3952, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3952)]
	public class UTextureRenderTargetCube : UTextureRenderTarget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010DBF RID: 69055 RVA: 0x0018C2D1 File Offset: 0x0018A4D1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTextureRenderTargetCube._ClassPtr;
		}

		// Token: 0x06010DC0 RID: 69056 RVA: 0x0018C2E0 File Offset: 0x0018A4E0
		public UTextureRenderTargetCube() : this(BuiltinUtils.AllocNativeUObject(UTextureRenderTargetCube.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010DC1 RID: 69057 RVA: 0x0018C308 File Offset: 0x0018A508
		[NullableContext(1)]
		public UTextureRenderTargetCube(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTextureRenderTargetCube.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170041E7 RID: 16871
		// (get) Token: 0x06010DC2 RID: 69058 RVA: 0x0018C33B File Offset: 0x0018A53B
		// (set) Token: 0x06010DC3 RID: 69059 RVA: 0x0018C34B File Offset: 0x0018A54B
		public unsafe int SizeX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextureRenderTargetCube.__PropertyOffset_SizeX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextureRenderTargetCube.__PropertyOffset_SizeX) = value;
			}
		}

		// Token: 0x170041E8 RID: 16872
		// (get) Token: 0x06010DC4 RID: 69060 RVA: 0x0018C35C File Offset: 0x0018A55C
		// (set) Token: 0x06010DC5 RID: 69061 RVA: 0x0018C370 File Offset: 0x0018A570
		public unsafe FLinearColor ClearColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextureRenderTargetCube.__PropertyOffset_ClearColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextureRenderTargetCube.__PropertyOffset_ClearColor) = value;
			}
		}

		// Token: 0x170041E9 RID: 16873
		// (get) Token: 0x06010DC6 RID: 69062 RVA: 0x0018C385 File Offset: 0x0018A585
		// (set) Token: 0x06010DC7 RID: 69063 RVA: 0x0018C399 File Offset: 0x0018A599
		public unsafe TEnumAsByte<EPixelFormat> OverrideFormat
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextureRenderTargetCube.__PropertyOffset_OverrideFormat);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextureRenderTargetCube.__PropertyOffset_OverrideFormat) = value;
			}
		}

		// Token: 0x170041EA RID: 16874
		// (get) Token: 0x06010DC8 RID: 69064 RVA: 0x0018C3AE File Offset: 0x0018A5AE
		// (set) Token: 0x06010DC9 RID: 69065 RVA: 0x0018C3C7 File Offset: 0x0018A5C7
		public unsafe bool bHDR
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UTextureRenderTargetCube.__PropertyOffset_bHDR) & UTextureRenderTargetCube.__PropertyMask_bHDR) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UTextureRenderTargetCube.__PropertyOffset_bHDR) = ((*(base.NativePtr + (IntPtr)UTextureRenderTargetCube.__PropertyOffset_bHDR) & ~UTextureRenderTargetCube.__PropertyMask_bHDR) | (value ? UTextureRenderTargetCube.__PropertyMask_bHDR : 0));
			}
		}

		// Token: 0x170041EB RID: 16875
		// (get) Token: 0x06010DCA RID: 69066 RVA: 0x0018C3F7 File Offset: 0x0018A5F7
		// (set) Token: 0x06010DCB RID: 69067 RVA: 0x0018C410 File Offset: 0x0018A610
		public unsafe bool bForceLinearGamma
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UTextureRenderTargetCube.__PropertyOffset_bForceLinearGamma) & UTextureRenderTargetCube.__PropertyMask_bForceLinearGamma) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UTextureRenderTargetCube.__PropertyOffset_bForceLinearGamma) = ((*(base.NativePtr + (IntPtr)UTextureRenderTargetCube.__PropertyOffset_bForceLinearGamma) & ~UTextureRenderTargetCube.__PropertyMask_bForceLinearGamma) | (value ? UTextureRenderTargetCube.__PropertyMask_bForceLinearGamma : 0));
			}
		}

		// Token: 0x06010DCC RID: 69068 RVA: 0x0018C440 File Offset: 0x0018A640
		static UTextureRenderTargetCube()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.TextureRenderTargetCube");
		}

		// Token: 0x06010DCD RID: 69069 RVA: 0x0018C44E File Offset: 0x0018A64E
		protected UTextureRenderTargetCube(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009098 RID: 37016
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.TextureRenderTargetCube";

		// Token: 0x04009099 RID: 37017
		private static IntPtr _ClassPtr;

		// Token: 0x0400909A RID: 37018
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400909B RID: 37019
		internal static int __PropertyOffset_SizeX;

		// Token: 0x0400909C RID: 37020
		internal static int __PropertyOffset_ClearColor;

		// Token: 0x0400909D RID: 37021
		internal static int __PropertyOffset_OverrideFormat;

		// Token: 0x0400909E RID: 37022
		internal static int __PropertyOffset_bHDR;

		// Token: 0x0400909F RID: 37023
		internal static byte __PropertyMask_bHDR;

		// Token: 0x040090A0 RID: 37024
		internal static int __PropertyOffset_bForceLinearGamma;

		// Token: 0x040090A1 RID: 37025
		internal static byte __PropertyMask_bForceLinearGamma;
	}
}
