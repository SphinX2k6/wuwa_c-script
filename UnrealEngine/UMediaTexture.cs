using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200229C RID: 8860
	[UnrealObjectPath("/Script/MediaAssets.MediaTexture")]
	[UnrealStructLayout(4128, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 4128)]
	public class UMediaTexture : UTexture, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021B49 RID: 138057 RVA: 0x0031D589 File Offset: 0x0031B789
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMediaTexture._ClassPtr;
		}

		// Token: 0x06021B4A RID: 138058 RVA: 0x0031D598 File Offset: 0x0031B798
		public UMediaTexture() : this(BuiltinUtils.AllocNativeUObject(UMediaTexture.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021B4B RID: 138059 RVA: 0x0031D5C0 File Offset: 0x0031B7C0
		[NullableContext(1)]
		public UMediaTexture(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMediaTexture.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170082C5 RID: 33477
		// (get) Token: 0x06021B4C RID: 138060 RVA: 0x0031D5F3 File Offset: 0x0031B7F3
		// (set) Token: 0x06021B4D RID: 138061 RVA: 0x0031D607 File Offset: 0x0031B807
		public unsafe TEnumAsByte<TextureAddress> AddressX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMediaTexture.__PropertyOffset_AddressX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMediaTexture.__PropertyOffset_AddressX) = value;
			}
		}

		// Token: 0x170082C6 RID: 33478
		// (get) Token: 0x06021B4E RID: 138062 RVA: 0x0031D61C File Offset: 0x0031B81C
		// (set) Token: 0x06021B4F RID: 138063 RVA: 0x0031D630 File Offset: 0x0031B830
		public unsafe TEnumAsByte<TextureAddress> AddressY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMediaTexture.__PropertyOffset_AddressY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMediaTexture.__PropertyOffset_AddressY) = value;
			}
		}

		// Token: 0x170082C7 RID: 33479
		// (get) Token: 0x06021B50 RID: 138064 RVA: 0x0031D645 File Offset: 0x0031B845
		// (set) Token: 0x06021B51 RID: 138065 RVA: 0x0031D655 File Offset: 0x0031B855
		public unsafe bool AutoClear
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMediaTexture.__PropertyOffset_AutoClear) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMediaTexture.__PropertyOffset_AutoClear) = (value ? 1 : 0);
			}
		}

		// Token: 0x170082C8 RID: 33480
		// (get) Token: 0x06021B52 RID: 138066 RVA: 0x0031D666 File Offset: 0x0031B866
		// (set) Token: 0x06021B53 RID: 138067 RVA: 0x0031D67A File Offset: 0x0031B87A
		public unsafe FLinearColor ClearColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMediaTexture.__PropertyOffset_ClearColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMediaTexture.__PropertyOffset_ClearColor) = value;
			}
		}

		// Token: 0x170082C9 RID: 33481
		// (get) Token: 0x06021B54 RID: 138068 RVA: 0x0031D68F File Offset: 0x0031B88F
		// (set) Token: 0x06021B55 RID: 138069 RVA: 0x0031D69F File Offset: 0x0031B89F
		public unsafe bool EnableGenMips
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMediaTexture.__PropertyOffset_EnableGenMips) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMediaTexture.__PropertyOffset_EnableGenMips) = (value ? 1 : 0);
			}
		}

		// Token: 0x170082CA RID: 33482
		// (get) Token: 0x06021B56 RID: 138070 RVA: 0x0031D6B0 File Offset: 0x0031B8B0
		// (set) Token: 0x06021B57 RID: 138071 RVA: 0x0031D6C0 File Offset: 0x0031B8C0
		public unsafe byte NumMips
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMediaTexture.__PropertyOffset_NumMips);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMediaTexture.__PropertyOffset_NumMips) = value;
			}
		}

		// Token: 0x170082CB RID: 33483
		// (get) Token: 0x06021B58 RID: 138072 RVA: 0x0031D6D1 File Offset: 0x0031B8D1
		// (set) Token: 0x06021B59 RID: 138073 RVA: 0x0031D6E1 File Offset: 0x0031B8E1
		public unsafe bool NewStyleOutput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMediaTexture.__PropertyOffset_NewStyleOutput) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMediaTexture.__PropertyOffset_NewStyleOutput) = (value ? 1 : 0);
			}
		}

		// Token: 0x170082CC RID: 33484
		// (get) Token: 0x06021B5A RID: 138074 RVA: 0x0031D6F2 File Offset: 0x0031B8F2
		// (set) Token: 0x06021B5B RID: 138075 RVA: 0x0031D706 File Offset: 0x0031B906
		public unsafe TEnumAsByte<MediaTextureOutputFormat> OutputFormat
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMediaTexture.__PropertyOffset_OutputFormat);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMediaTexture.__PropertyOffset_OutputFormat) = value;
			}
		}

		// Token: 0x170082CD RID: 33485
		// (get) Token: 0x06021B5C RID: 138076 RVA: 0x0031D71B File Offset: 0x0031B91B
		// (set) Token: 0x06021B5D RID: 138077 RVA: 0x0031D72B File Offset: 0x0031B92B
		public unsafe float CurrentAspectRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMediaTexture.__PropertyOffset_CurrentAspectRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMediaTexture.__PropertyOffset_CurrentAspectRatio) = value;
			}
		}

		// Token: 0x170082CE RID: 33486
		// (get) Token: 0x06021B5E RID: 138078 RVA: 0x0031D73C File Offset: 0x0031B93C
		// (set) Token: 0x06021B5F RID: 138079 RVA: 0x0031D750 File Offset: 0x0031B950
		public unsafe TEnumAsByte<MediaTextureOrientation> CurrentOrientation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMediaTexture.__PropertyOffset_CurrentOrientation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMediaTexture.__PropertyOffset_CurrentOrientation) = value;
			}
		}

		// Token: 0x170082CF RID: 33487
		// (get) Token: 0x06021B60 RID: 138080 RVA: 0x0031D765 File Offset: 0x0031B965
		// (set) Token: 0x06021B61 RID: 138081 RVA: 0x0031D779 File Offset: 0x0031B979
		[Nullable(2)]
		public unsafe UMediaPlayer MediaPlayer
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaPlayer>(base.NativePtr / (IntPtr)sizeof(void*) + UMediaTexture.__PropertyOffset_MediaPlayer);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMediaTexture.__PropertyOffset_MediaPlayer, value);
			}
		}

		// Token: 0x06021B62 RID: 138082 RVA: 0x0031D78E File Offset: 0x0031B98E
		[NullableContext(2)]
		public void SetMediaPlayer(UMediaPlayer NewMediaPlayer)
		{
			UMediaTexture.__SetMediaPlayer_Internal(base.NativePtr, (NewMediaPlayer != null) ? NewMediaPlayer.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06021B63 RID: 138083 RVA: 0x0031D7AB File Offset: 0x0031B9AB
		public int GetWidth()
		{
			return UMediaTexture.__GetWidth_Internal(base.NativePtr);
		}

		// Token: 0x06021B64 RID: 138084 RVA: 0x0031D7B8 File Offset: 0x0031B9B8
		[NullableContext(2)]
		public UMediaPlayer GetMediaPlayer()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMediaPlayer>(UMediaTexture.__GetMediaPlayer_Internal(base.NativePtr));
		}

		// Token: 0x06021B65 RID: 138085 RVA: 0x0031D7CA File Offset: 0x0031B9CA
		public int GetHeight()
		{
			return UMediaTexture.__GetHeight_Internal(base.NativePtr);
		}

		// Token: 0x06021B66 RID: 138086 RVA: 0x0031D7D7 File Offset: 0x0031B9D7
		public float GetAspectRatio()
		{
			return UMediaTexture.__GetAspectRatio_Internal(base.NativePtr);
		}

		// Token: 0x06021B67 RID: 138087
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMediaPlayer_Internal(IntPtr @this, IntPtr NewMediaPlayer);

		// Token: 0x06021B68 RID: 138088
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetWidth_Internal(IntPtr @this);

		// Token: 0x06021B69 RID: 138089
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetMediaPlayer_Internal(IntPtr @this);

		// Token: 0x06021B6A RID: 138090
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetHeight_Internal(IntPtr @this);

		// Token: 0x06021B6B RID: 138091
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAspectRatio_Internal(IntPtr @this);

		// Token: 0x06021B6C RID: 138092 RVA: 0x0031D7E4 File Offset: 0x0031B9E4
		static UMediaTexture()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MediaAssets.MediaTexture");
		}

		// Token: 0x06021B6D RID: 138093 RVA: 0x0031D7F2 File Offset: 0x0031B9F2
		protected UMediaTexture(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011FB0 RID: 73648
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MediaAssets.MediaTexture";

		// Token: 0x04011FB1 RID: 73649
		private static IntPtr _ClassPtr;

		// Token: 0x04011FB2 RID: 73650
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011FB3 RID: 73651
		internal static int __PropertyOffset_AddressX;

		// Token: 0x04011FB4 RID: 73652
		internal static int __PropertyOffset_AddressY;

		// Token: 0x04011FB5 RID: 73653
		internal static int __PropertyOffset_AutoClear;

		// Token: 0x04011FB6 RID: 73654
		internal static int __PropertyOffset_ClearColor;

		// Token: 0x04011FB7 RID: 73655
		internal static int __PropertyOffset_EnableGenMips;

		// Token: 0x04011FB8 RID: 73656
		internal static int __PropertyOffset_NumMips;

		// Token: 0x04011FB9 RID: 73657
		internal static int __PropertyOffset_NewStyleOutput;

		// Token: 0x04011FBA RID: 73658
		internal static int __PropertyOffset_OutputFormat;

		// Token: 0x04011FBB RID: 73659
		internal static int __PropertyOffset_CurrentAspectRatio;

		// Token: 0x04011FBC RID: 73660
		internal static int __PropertyOffset_CurrentOrientation;

		// Token: 0x04011FBD RID: 73661
		internal static int __PropertyOffset_MediaPlayer;
	}
}
