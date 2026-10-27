using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020011E2 RID: 4578
	[UnrealObjectPath("/Script/Engine.TextureRenderTargetVolume")]
	[UnrealStructLayout(3952, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3952)]
	public class UTextureRenderTargetVolume : UTextureRenderTarget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010DCE RID: 69070 RVA: 0x0018C457 File Offset: 0x0018A657
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTextureRenderTargetVolume._ClassPtr;
		}

		// Token: 0x06010DCF RID: 69071 RVA: 0x0018C464 File Offset: 0x0018A664
		public UTextureRenderTargetVolume() : this(BuiltinUtils.AllocNativeUObject(UTextureRenderTargetVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010DD0 RID: 69072 RVA: 0x0018C48C File Offset: 0x0018A68C
		[NullableContext(1)]
		public UTextureRenderTargetVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTextureRenderTargetVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170041EC RID: 16876
		// (get) Token: 0x06010DD1 RID: 69073 RVA: 0x0018C4BF File Offset: 0x0018A6BF
		// (set) Token: 0x06010DD2 RID: 69074 RVA: 0x0018C4CF File Offset: 0x0018A6CF
		public unsafe int SizeX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextureRenderTargetVolume.__PropertyOffset_SizeX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextureRenderTargetVolume.__PropertyOffset_SizeX) = value;
			}
		}

		// Token: 0x170041ED RID: 16877
		// (get) Token: 0x06010DD3 RID: 69075 RVA: 0x0018C4E0 File Offset: 0x0018A6E0
		// (set) Token: 0x06010DD4 RID: 69076 RVA: 0x0018C4F0 File Offset: 0x0018A6F0
		public unsafe int SizeY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextureRenderTargetVolume.__PropertyOffset_SizeY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextureRenderTargetVolume.__PropertyOffset_SizeY) = value;
			}
		}

		// Token: 0x170041EE RID: 16878
		// (get) Token: 0x06010DD5 RID: 69077 RVA: 0x0018C501 File Offset: 0x0018A701
		// (set) Token: 0x06010DD6 RID: 69078 RVA: 0x0018C511 File Offset: 0x0018A711
		public unsafe int SizeZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextureRenderTargetVolume.__PropertyOffset_SizeZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextureRenderTargetVolume.__PropertyOffset_SizeZ) = value;
			}
		}

		// Token: 0x170041EF RID: 16879
		// (get) Token: 0x06010DD7 RID: 69079 RVA: 0x0018C522 File Offset: 0x0018A722
		// (set) Token: 0x06010DD8 RID: 69080 RVA: 0x0018C536 File Offset: 0x0018A736
		public unsafe FLinearColor ClearColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextureRenderTargetVolume.__PropertyOffset_ClearColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextureRenderTargetVolume.__PropertyOffset_ClearColor) = value;
			}
		}

		// Token: 0x170041F0 RID: 16880
		// (get) Token: 0x06010DD9 RID: 69081 RVA: 0x0018C54B File Offset: 0x0018A74B
		// (set) Token: 0x06010DDA RID: 69082 RVA: 0x0018C55F File Offset: 0x0018A75F
		public unsafe TEnumAsByte<EPixelFormat> OverrideFormat
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTextureRenderTargetVolume.__PropertyOffset_OverrideFormat);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTextureRenderTargetVolume.__PropertyOffset_OverrideFormat) = value;
			}
		}

		// Token: 0x170041F1 RID: 16881
		// (get) Token: 0x06010DDB RID: 69083 RVA: 0x0018C574 File Offset: 0x0018A774
		// (set) Token: 0x06010DDC RID: 69084 RVA: 0x0018C58D File Offset: 0x0018A78D
		public unsafe bool bHDR
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UTextureRenderTargetVolume.__PropertyOffset_bHDR) & UTextureRenderTargetVolume.__PropertyMask_bHDR) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UTextureRenderTargetVolume.__PropertyOffset_bHDR) = ((*(base.NativePtr + (IntPtr)UTextureRenderTargetVolume.__PropertyOffset_bHDR) & ~UTextureRenderTargetVolume.__PropertyMask_bHDR) | (value ? UTextureRenderTargetVolume.__PropertyMask_bHDR : 0));
			}
		}

		// Token: 0x170041F2 RID: 16882
		// (get) Token: 0x06010DDD RID: 69085 RVA: 0x0018C5BD File Offset: 0x0018A7BD
		// (set) Token: 0x06010DDE RID: 69086 RVA: 0x0018C5D6 File Offset: 0x0018A7D6
		public unsafe bool bForceLinearGamma
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UTextureRenderTargetVolume.__PropertyOffset_bForceLinearGamma) & UTextureRenderTargetVolume.__PropertyMask_bForceLinearGamma) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UTextureRenderTargetVolume.__PropertyOffset_bForceLinearGamma) = ((*(base.NativePtr + (IntPtr)UTextureRenderTargetVolume.__PropertyOffset_bForceLinearGamma) & ~UTextureRenderTargetVolume.__PropertyMask_bForceLinearGamma) | (value ? UTextureRenderTargetVolume.__PropertyMask_bForceLinearGamma : 0));
			}
		}

		// Token: 0x06010DDF RID: 69087 RVA: 0x0018C606 File Offset: 0x0018A806
		static UTextureRenderTargetVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.TextureRenderTargetVolume");
		}

		// Token: 0x06010DE0 RID: 69088 RVA: 0x0018C614 File Offset: 0x0018A814
		protected UTextureRenderTargetVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040090A2 RID: 37026
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.TextureRenderTargetVolume";

		// Token: 0x040090A3 RID: 37027
		private static IntPtr _ClassPtr;

		// Token: 0x040090A4 RID: 37028
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040090A5 RID: 37029
		internal static int __PropertyOffset_SizeX;

		// Token: 0x040090A6 RID: 37030
		internal static int __PropertyOffset_SizeY;

		// Token: 0x040090A7 RID: 37031
		internal static int __PropertyOffset_SizeZ;

		// Token: 0x040090A8 RID: 37032
		internal static int __PropertyOffset_ClearColor;

		// Token: 0x040090A9 RID: 37033
		internal static int __PropertyOffset_OverrideFormat;

		// Token: 0x040090AA RID: 37034
		internal static int __PropertyOffset_bHDR;

		// Token: 0x040090AB RID: 37035
		internal static byte __PropertyMask_bHDR;

		// Token: 0x040090AC RID: 37036
		internal static int __PropertyOffset_bForceLinearGamma;

		// Token: 0x040090AD RID: 37037
		internal static byte __PropertyMask_bForceLinearGamma;
	}
}
