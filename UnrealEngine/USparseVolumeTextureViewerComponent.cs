using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002698 RID: 9880
	[UnrealObjectPath("/Script/Renderer.SparseVolumeTextureViewerComponent")]
	[UnrealStructLayout(1632, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1632)]
	public class USparseVolumeTextureViewerComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024AE4 RID: 150244 RVA: 0x00364DB7 File Offset: 0x00362FB7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USparseVolumeTextureViewerComponent._ClassPtr;
		}

		// Token: 0x06024AE5 RID: 150245 RVA: 0x00364DC4 File Offset: 0x00362FC4
		public USparseVolumeTextureViewerComponent() : this(BuiltinUtils.AllocNativeUObject(USparseVolumeTextureViewerComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024AE6 RID: 150246 RVA: 0x00364DEC File Offset: 0x00362FEC
		[NullableContext(1)]
		public USparseVolumeTextureViewerComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USparseVolumeTextureViewerComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008D7A RID: 36218
		// (get) Token: 0x06024AE7 RID: 150247 RVA: 0x00364E1F File Offset: 0x0036301F
		// (set) Token: 0x06024AE8 RID: 150248 RVA: 0x00364E33 File Offset: 0x00363033
		[Nullable(2)]
		public unsafe USparseVolumeTexture SparseVolumeTexturePreview
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USparseVolumeTexture>(base.NativePtr / (IntPtr)sizeof(void*) + USparseVolumeTextureViewerComponent.__PropertyOffset_SparseVolumeTexturePreview);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USparseVolumeTextureViewerComponent.__PropertyOffset_SparseVolumeTexturePreview, value);
			}
		}

		// Token: 0x17008D7B RID: 36219
		// (get) Token: 0x06024AE9 RID: 150249 RVA: 0x00364E48 File Offset: 0x00363048
		// (set) Token: 0x06024AEA RID: 150250 RVA: 0x00364E61 File Offset: 0x00363061
		public unsafe bool bAnimate
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USparseVolumeTextureViewerComponent.__PropertyOffset_bAnimate) & USparseVolumeTextureViewerComponent.__PropertyMask_bAnimate) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USparseVolumeTextureViewerComponent.__PropertyOffset_bAnimate) = ((*(base.NativePtr + (IntPtr)USparseVolumeTextureViewerComponent.__PropertyOffset_bAnimate) & ~USparseVolumeTextureViewerComponent.__PropertyMask_bAnimate) | (value ? USparseVolumeTextureViewerComponent.__PropertyMask_bAnimate : 0));
			}
		}

		// Token: 0x17008D7C RID: 36220
		// (get) Token: 0x06024AEB RID: 150251 RVA: 0x00364E91 File Offset: 0x00363091
		// (set) Token: 0x06024AEC RID: 150252 RVA: 0x00364EAA File Offset: 0x003630AA
		public unsafe bool bReversePlayback
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USparseVolumeTextureViewerComponent.__PropertyOffset_bReversePlayback) & USparseVolumeTextureViewerComponent.__PropertyMask_bReversePlayback) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USparseVolumeTextureViewerComponent.__PropertyOffset_bReversePlayback) = ((*(base.NativePtr + (IntPtr)USparseVolumeTextureViewerComponent.__PropertyOffset_bReversePlayback) & ~USparseVolumeTextureViewerComponent.__PropertyMask_bReversePlayback) | (value ? USparseVolumeTextureViewerComponent.__PropertyMask_bReversePlayback : 0));
			}
		}

		// Token: 0x17008D7D RID: 36221
		// (get) Token: 0x06024AED RID: 150253 RVA: 0x00364EDA File Offset: 0x003630DA
		// (set) Token: 0x06024AEE RID: 150254 RVA: 0x00364EF3 File Offset: 0x003630F3
		public unsafe bool bBlockingStreamingRequests
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USparseVolumeTextureViewerComponent.__PropertyOffset_bBlockingStreamingRequests) & USparseVolumeTextureViewerComponent.__PropertyMask_bBlockingStreamingRequests) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USparseVolumeTextureViewerComponent.__PropertyOffset_bBlockingStreamingRequests) = ((*(base.NativePtr + (IntPtr)USparseVolumeTextureViewerComponent.__PropertyOffset_bBlockingStreamingRequests) & ~USparseVolumeTextureViewerComponent.__PropertyMask_bBlockingStreamingRequests) | (value ? USparseVolumeTextureViewerComponent.__PropertyMask_bBlockingStreamingRequests : 0));
			}
		}

		// Token: 0x17008D7E RID: 36222
		// (get) Token: 0x06024AEF RID: 150255 RVA: 0x00364F23 File Offset: 0x00363123
		// (set) Token: 0x06024AF0 RID: 150256 RVA: 0x00364F33 File Offset: 0x00363133
		public unsafe float AnimationFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USparseVolumeTextureViewerComponent.__PropertyOffset_AnimationFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USparseVolumeTextureViewerComponent.__PropertyOffset_AnimationFrame) = value;
			}
		}

		// Token: 0x17008D7F RID: 36223
		// (get) Token: 0x06024AF1 RID: 150257 RVA: 0x00364F44 File Offset: 0x00363144
		// (set) Token: 0x06024AF2 RID: 150258 RVA: 0x00364F54 File Offset: 0x00363154
		public unsafe float FrameRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USparseVolumeTextureViewerComponent.__PropertyOffset_FrameRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USparseVolumeTextureViewerComponent.__PropertyOffset_FrameRate) = value;
			}
		}

		// Token: 0x17008D80 RID: 36224
		// (get) Token: 0x06024AF3 RID: 150259 RVA: 0x00364F65 File Offset: 0x00363165
		// (set) Token: 0x06024AF4 RID: 150260 RVA: 0x00364F75 File Offset: 0x00363175
		public unsafe float AnimationTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USparseVolumeTextureViewerComponent.__PropertyOffset_AnimationTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USparseVolumeTextureViewerComponent.__PropertyOffset_AnimationTime) = value;
			}
		}

		// Token: 0x17008D81 RID: 36225
		// (get) Token: 0x06024AF5 RID: 150261 RVA: 0x00364F86 File Offset: 0x00363186
		// (set) Token: 0x06024AF6 RID: 150262 RVA: 0x00364F96 File Offset: 0x00363196
		public unsafe ESparseVolumeTexturePreviewAttribute PreviewAttribute
		{
			get
			{
				return (ESparseVolumeTexturePreviewAttribute)(*(base.NativePtr + (IntPtr)USparseVolumeTextureViewerComponent.__PropertyOffset_PreviewAttribute));
			}
			set
			{
				*(base.NativePtr + (IntPtr)USparseVolumeTextureViewerComponent.__PropertyOffset_PreviewAttribute) = (byte)value;
			}
		}

		// Token: 0x17008D82 RID: 36226
		// (get) Token: 0x06024AF7 RID: 150263 RVA: 0x00364FA7 File Offset: 0x003631A7
		// (set) Token: 0x06024AF8 RID: 150264 RVA: 0x00364FB7 File Offset: 0x003631B7
		public unsafe int MipLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USparseVolumeTextureViewerComponent.__PropertyOffset_MipLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USparseVolumeTextureViewerComponent.__PropertyOffset_MipLevel) = value;
			}
		}

		// Token: 0x17008D83 RID: 36227
		// (get) Token: 0x06024AF9 RID: 150265 RVA: 0x00364FC8 File Offset: 0x003631C8
		// (set) Token: 0x06024AFA RID: 150266 RVA: 0x00364FD8 File Offset: 0x003631D8
		public unsafe float Extinction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USparseVolumeTextureViewerComponent.__PropertyOffset_Extinction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USparseVolumeTextureViewerComponent.__PropertyOffset_Extinction) = value;
			}
		}

		// Token: 0x06024AFB RID: 150267 RVA: 0x00364FE9 File Offset: 0x003631E9
		static USparseVolumeTextureViewerComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Renderer.SparseVolumeTextureViewerComponent");
		}

		// Token: 0x06024AFC RID: 150268 RVA: 0x00364FF7 File Offset: 0x003631F7
		protected USparseVolumeTextureViewerComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013B86 RID: 80774
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Renderer.SparseVolumeTextureViewerComponent";

		// Token: 0x04013B87 RID: 80775
		private static IntPtr _ClassPtr;

		// Token: 0x04013B88 RID: 80776
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013B89 RID: 80777
		internal static int __PropertyOffset_SparseVolumeTexturePreview;

		// Token: 0x04013B8A RID: 80778
		internal static int __PropertyOffset_bAnimate;

		// Token: 0x04013B8B RID: 80779
		internal static byte __PropertyMask_bAnimate;

		// Token: 0x04013B8C RID: 80780
		internal static int __PropertyOffset_bReversePlayback;

		// Token: 0x04013B8D RID: 80781
		internal static byte __PropertyMask_bReversePlayback;

		// Token: 0x04013B8E RID: 80782
		internal static int __PropertyOffset_bBlockingStreamingRequests;

		// Token: 0x04013B8F RID: 80783
		internal static byte __PropertyMask_bBlockingStreamingRequests;

		// Token: 0x04013B90 RID: 80784
		internal static int __PropertyOffset_AnimationFrame;

		// Token: 0x04013B91 RID: 80785
		internal static int __PropertyOffset_FrameRate;

		// Token: 0x04013B92 RID: 80786
		internal static int __PropertyOffset_AnimationTime;

		// Token: 0x04013B93 RID: 80787
		internal static int __PropertyOffset_PreviewAttribute;

		// Token: 0x04013B94 RID: 80788
		internal static int __PropertyOffset_MipLevel;

		// Token: 0x04013B95 RID: 80789
		internal static int __PropertyOffset_Extinction;
	}
}
