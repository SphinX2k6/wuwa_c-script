using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003CB RID: 971
	[UnrealObjectPath("/Script/AugmentedReality.ARTexture")]
	[UnrealStructLayout(3952, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3952)]
	public abstract class UARTexture : UTexture, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003660 RID: 13920 RVA: 0x0005286C File Offset: 0x00050A6C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UARTexture._ClassPtr;
		}

		// Token: 0x17000CEF RID: 3311
		// (get) Token: 0x06003661 RID: 13921 RVA: 0x00052878 File Offset: 0x00050A78
		// (set) Token: 0x06003662 RID: 13922 RVA: 0x00052888 File Offset: 0x00050A88
		public unsafe EARTextureType TextureType
		{
			get
			{
				return (EARTextureType)(*(base.NativePtr + (IntPtr)UARTexture.__PropertyOffset_TextureType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARTexture.__PropertyOffset_TextureType) = (byte)value;
			}
		}

		// Token: 0x17000CF0 RID: 3312
		// (get) Token: 0x06003663 RID: 13923 RVA: 0x00052899 File Offset: 0x00050A99
		// (set) Token: 0x06003664 RID: 13924 RVA: 0x000528A9 File Offset: 0x00050AA9
		public unsafe float Timestamp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UARTexture.__PropertyOffset_Timestamp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARTexture.__PropertyOffset_Timestamp) = value;
			}
		}

		// Token: 0x17000CF1 RID: 3313
		// (get) Token: 0x06003665 RID: 13925 RVA: 0x000528BA File Offset: 0x00050ABA
		// (set) Token: 0x06003666 RID: 13926 RVA: 0x000528CE File Offset: 0x00050ACE
		public unsafe FGuid ExternalTextureGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UARTexture.__PropertyOffset_ExternalTextureGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARTexture.__PropertyOffset_ExternalTextureGuid) = value;
			}
		}

		// Token: 0x17000CF2 RID: 3314
		// (get) Token: 0x06003667 RID: 13927 RVA: 0x000528E3 File Offset: 0x00050AE3
		// (set) Token: 0x06003668 RID: 13928 RVA: 0x000528F7 File Offset: 0x00050AF7
		public unsafe FVector2D Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UARTexture.__PropertyOffset_Size);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARTexture.__PropertyOffset_Size) = value;
			}
		}

		// Token: 0x06003669 RID: 13929 RVA: 0x0005290C File Offset: 0x00050B0C
		static UARTexture()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AugmentedReality.ARTexture");
		}

		// Token: 0x0600366A RID: 13930 RVA: 0x0005291C File Offset: 0x00050B1C
		protected UARTexture() : this(BuiltinUtils.AllocNativeUObject(UARTexture.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600366B RID: 13931 RVA: 0x00052944 File Offset: 0x00050B44
		protected UARTexture(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001781 RID: 6017
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AugmentedReality.ARTexture";

		// Token: 0x04001782 RID: 6018
		private static IntPtr _ClassPtr;

		// Token: 0x04001783 RID: 6019
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001784 RID: 6020
		internal static int __PropertyOffset_TextureType;

		// Token: 0x04001785 RID: 6021
		internal static int __PropertyOffset_Timestamp;

		// Token: 0x04001786 RID: 6022
		internal static int __PropertyOffset_ExternalTextureGuid;

		// Token: 0x04001787 RID: 6023
		internal static int __PropertyOffset_Size;
	}
}
