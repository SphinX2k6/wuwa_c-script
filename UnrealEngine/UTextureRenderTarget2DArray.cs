using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020011E0 RID: 4576
	[UnrealObjectPath("/Script/Engine.TextureRenderTarget2DArray")]
	[UnrealStructLayout(3952, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3952)]
	public class UTextureRenderTarget2DArray : UTextureRenderTarget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010DAC RID: 69036 RVA: 0x0018C109 File Offset: 0x0018A309
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTextureRenderTarget2DArray._ClassPtr;
		}

		// Token: 0x06010DAD RID: 69037 RVA: 0x0018C118 File Offset: 0x0018A318
		public UTextureRenderTarget2DArray() : this(BuiltinUtils.AllocNativeUObject(UTextureRenderTarget2DArray.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010DAE RID: 69038 RVA: 0x0018C140 File Offset: 0x0018A340
		[NullableContext(1)]
		public UTextureRenderTarget2DArray(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTextureRenderTarget2DArray.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170041E0 RID: 16864
		// (get) Token: 0x06010DAF RID: 69039 RVA: 0x0018C173 File Offset: 0x0018A373
		// (set) Token: 0x06010DB0 RID: 69040 RVA: 0x0018C183 File Offset: 0x0018A383
		public unsafe int SizeX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextureRenderTarget2DArray.__PropertyOffset_SizeX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextureRenderTarget2DArray.__PropertyOffset_SizeX) = value;
			}
		}

		// Token: 0x170041E1 RID: 16865
		// (get) Token: 0x06010DB1 RID: 69041 RVA: 0x0018C194 File Offset: 0x0018A394
		// (set) Token: 0x06010DB2 RID: 69042 RVA: 0x0018C1A4 File Offset: 0x0018A3A4
		public unsafe int SizeY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextureRenderTarget2DArray.__PropertyOffset_SizeY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextureRenderTarget2DArray.__PropertyOffset_SizeY) = value;
			}
		}

		// Token: 0x170041E2 RID: 16866
		// (get) Token: 0x06010DB3 RID: 69043 RVA: 0x0018C1B5 File Offset: 0x0018A3B5
		// (set) Token: 0x06010DB4 RID: 69044 RVA: 0x0018C1C5 File Offset: 0x0018A3C5
		public unsafe int Slices
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextureRenderTarget2DArray.__PropertyOffset_Slices);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextureRenderTarget2DArray.__PropertyOffset_Slices) = value;
			}
		}

		// Token: 0x170041E3 RID: 16867
		// (get) Token: 0x06010DB5 RID: 69045 RVA: 0x0018C1D6 File Offset: 0x0018A3D6
		// (set) Token: 0x06010DB6 RID: 69046 RVA: 0x0018C1EA File Offset: 0x0018A3EA
		public unsafe FLinearColor ClearColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextureRenderTarget2DArray.__PropertyOffset_ClearColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextureRenderTarget2DArray.__PropertyOffset_ClearColor) = value;
			}
		}

		// Token: 0x170041E4 RID: 16868
		// (get) Token: 0x06010DB7 RID: 69047 RVA: 0x0018C1FF File Offset: 0x0018A3FF
		// (set) Token: 0x06010DB8 RID: 69048 RVA: 0x0018C213 File Offset: 0x0018A413
		public unsafe TEnumAsByte<EPixelFormat> OverrideFormat
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextureRenderTarget2DArray.__PropertyOffset_OverrideFormat);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextureRenderTarget2DArray.__PropertyOffset_OverrideFormat) = value;
			}
		}

		// Token: 0x170041E5 RID: 16869
		// (get) Token: 0x06010DB9 RID: 69049 RVA: 0x0018C228 File Offset: 0x0018A428
		// (set) Token: 0x06010DBA RID: 69050 RVA: 0x0018C241 File Offset: 0x0018A441
		public unsafe bool bHDR
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UTextureRenderTarget2DArray.__PropertyOffset_bHDR) & UTextureRenderTarget2DArray.__PropertyMask_bHDR) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UTextureRenderTarget2DArray.__PropertyOffset_bHDR) = ((*(base.NativePtr + (IntPtr)UTextureRenderTarget2DArray.__PropertyOffset_bHDR) & ~UTextureRenderTarget2DArray.__PropertyMask_bHDR) | (value ? UTextureRenderTarget2DArray.__PropertyMask_bHDR : 0));
			}
		}

		// Token: 0x170041E6 RID: 16870
		// (get) Token: 0x06010DBB RID: 69051 RVA: 0x0018C271 File Offset: 0x0018A471
		// (set) Token: 0x06010DBC RID: 69052 RVA: 0x0018C28A File Offset: 0x0018A48A
		public unsafe bool bForceLinearGamma
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UTextureRenderTarget2DArray.__PropertyOffset_bForceLinearGamma) & UTextureRenderTarget2DArray.__PropertyMask_bForceLinearGamma) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UTextureRenderTarget2DArray.__PropertyOffset_bForceLinearGamma) = ((*(base.NativePtr + (IntPtr)UTextureRenderTarget2DArray.__PropertyOffset_bForceLinearGamma) & ~UTextureRenderTarget2DArray.__PropertyMask_bForceLinearGamma) | (value ? UTextureRenderTarget2DArray.__PropertyMask_bForceLinearGamma : 0));
			}
		}

		// Token: 0x06010DBD RID: 69053 RVA: 0x0018C2BA File Offset: 0x0018A4BA
		static UTextureRenderTarget2DArray()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.TextureRenderTarget2DArray");
		}

		// Token: 0x06010DBE RID: 69054 RVA: 0x0018C2C8 File Offset: 0x0018A4C8
		protected UTextureRenderTarget2DArray(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400908C RID: 37004
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.TextureRenderTarget2DArray";

		// Token: 0x0400908D RID: 37005
		private static IntPtr _ClassPtr;

		// Token: 0x0400908E RID: 37006
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400908F RID: 37007
		internal static int __PropertyOffset_SizeX;

		// Token: 0x04009090 RID: 37008
		internal static int __PropertyOffset_SizeY;

		// Token: 0x04009091 RID: 37009
		internal static int __PropertyOffset_Slices;

		// Token: 0x04009092 RID: 37010
		internal static int __PropertyOffset_ClearColor;

		// Token: 0x04009093 RID: 37011
		internal static int __PropertyOffset_OverrideFormat;

		// Token: 0x04009094 RID: 37012
		internal static int __PropertyOffset_bHDR;

		// Token: 0x04009095 RID: 37013
		internal static byte __PropertyMask_bHDR;

		// Token: 0x04009096 RID: 37014
		internal static int __PropertyOffset_bForceLinearGamma;

		// Token: 0x04009097 RID: 37015
		internal static byte __PropertyMask_bForceLinearGamma;
	}
}
