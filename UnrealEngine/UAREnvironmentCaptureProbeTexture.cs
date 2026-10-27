using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200039E RID: 926
	[UnrealObjectPath("/Script/AugmentedReality.AREnvironmentCaptureProbeTexture")]
	[UnrealStructLayout(4032, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 4032)]
	public abstract class UAREnvironmentCaptureProbeTexture : UTextureCube, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003354 RID: 13140 RVA: 0x0004EA0F File Offset: 0x0004CC0F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAREnvironmentCaptureProbeTexture._ClassPtr;
		}

		// Token: 0x17000C5F RID: 3167
		// (get) Token: 0x06003355 RID: 13141 RVA: 0x0004EA1B File Offset: 0x0004CC1B
		// (set) Token: 0x06003356 RID: 13142 RVA: 0x0004EA2B File Offset: 0x0004CC2B
		public unsafe EARTextureType TextureType
		{
			get
			{
				return (EARTextureType)(*(base.NativePtr + (IntPtr)UAREnvironmentCaptureProbeTexture.__PropertyOffset_TextureType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAREnvironmentCaptureProbeTexture.__PropertyOffset_TextureType) = (byte)value;
			}
		}

		// Token: 0x17000C60 RID: 3168
		// (get) Token: 0x06003357 RID: 13143 RVA: 0x0004EA3C File Offset: 0x0004CC3C
		// (set) Token: 0x06003358 RID: 13144 RVA: 0x0004EA4C File Offset: 0x0004CC4C
		public unsafe float Timestamp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAREnvironmentCaptureProbeTexture.__PropertyOffset_Timestamp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAREnvironmentCaptureProbeTexture.__PropertyOffset_Timestamp) = value;
			}
		}

		// Token: 0x17000C61 RID: 3169
		// (get) Token: 0x06003359 RID: 13145 RVA: 0x0004EA5D File Offset: 0x0004CC5D
		// (set) Token: 0x0600335A RID: 13146 RVA: 0x0004EA71 File Offset: 0x0004CC71
		public unsafe FGuid ExternalTextureGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAREnvironmentCaptureProbeTexture.__PropertyOffset_ExternalTextureGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAREnvironmentCaptureProbeTexture.__PropertyOffset_ExternalTextureGuid) = value;
			}
		}

		// Token: 0x17000C62 RID: 3170
		// (get) Token: 0x0600335B RID: 13147 RVA: 0x0004EA86 File Offset: 0x0004CC86
		// (set) Token: 0x0600335C RID: 13148 RVA: 0x0004EA9A File Offset: 0x0004CC9A
		public unsafe FVector2D Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAREnvironmentCaptureProbeTexture.__PropertyOffset_Size);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAREnvironmentCaptureProbeTexture.__PropertyOffset_Size) = value;
			}
		}

		// Token: 0x0600335D RID: 13149 RVA: 0x0004EAAF File Offset: 0x0004CCAF
		static UAREnvironmentCaptureProbeTexture()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AugmentedReality.AREnvironmentCaptureProbeTexture");
		}

		// Token: 0x0600335E RID: 13150 RVA: 0x0004EAC0 File Offset: 0x0004CCC0
		protected UAREnvironmentCaptureProbeTexture() : this(BuiltinUtils.AllocNativeUObject(UAREnvironmentCaptureProbeTexture.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600335F RID: 13151 RVA: 0x0004EAE8 File Offset: 0x0004CCE8
		protected UAREnvironmentCaptureProbeTexture(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400164C RID: 5708
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AugmentedReality.AREnvironmentCaptureProbeTexture";

		// Token: 0x0400164D RID: 5709
		private static IntPtr _ClassPtr;

		// Token: 0x0400164E RID: 5710
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400164F RID: 5711
		internal static int __PropertyOffset_TextureType;

		// Token: 0x04001650 RID: 5712
		internal static int __PropertyOffset_Timestamp;

		// Token: 0x04001651 RID: 5713
		internal static int __PropertyOffset_ExternalTextureGuid;

		// Token: 0x04001652 RID: 5714
		internal static int __PropertyOffset_Size;
	}
}
