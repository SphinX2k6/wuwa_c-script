using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A59 RID: 6745
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.CircleStampConsumer")]
	[UnrealStructLayout(1584, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1584)]
	public class ACircleStampConsumer : AKuroBPActor, IUnrealUObject, IUnrealObject, IKuroRenderingStampConsumer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06018F4D RID: 102221 RVA: 0x0024E530 File Offset: 0x0024C730
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ACircleStampConsumer._ClassPtr;
		}

		// Token: 0x06018F4E RID: 102222 RVA: 0x0024E53C File Offset: 0x0024C73C
		int IKuroRenderingStampConsumer.InterfaceOffset()
		{
			return ACircleStampConsumer.__InterfaceOffset_IKuroRenderingStampConsumer;
		}

		// Token: 0x06018F4F RID: 102223 RVA: 0x0024E544 File Offset: 0x0024C744
		public ACircleStampConsumer() : this(BuiltinUtils.AllocNativeUObject(ACircleStampConsumer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018F50 RID: 102224 RVA: 0x0024E56C File Offset: 0x0024C76C
		[NullableContext(1)]
		public ACircleStampConsumer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ACircleStampConsumer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170062E4 RID: 25316
		// (get) Token: 0x06018F51 RID: 102225 RVA: 0x0024E59F File Offset: 0x0024C79F
		// (set) Token: 0x06018F52 RID: 102226 RVA: 0x0024E5B3 File Offset: 0x0024C7B3
		public unsafe FVectorDouble RTWorldCenter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACircleStampConsumer.__PropertyOffset_RTWorldCenter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACircleStampConsumer.__PropertyOffset_RTWorldCenter) = value;
			}
		}

		// Token: 0x170062E5 RID: 25317
		// (get) Token: 0x06018F53 RID: 102227 RVA: 0x0024E5C8 File Offset: 0x0024C7C8
		// (set) Token: 0x06018F54 RID: 102228 RVA: 0x0024E5D8 File Offset: 0x0024C7D8
		public unsafe float RTWorldRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACircleStampConsumer.__PropertyOffset_RTWorldRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACircleStampConsumer.__PropertyOffset_RTWorldRadius) = value;
			}
		}

		// Token: 0x170062E6 RID: 25318
		// (get) Token: 0x06018F55 RID: 102229 RVA: 0x0024E5E9 File Offset: 0x0024C7E9
		// (set) Token: 0x06018F56 RID: 102230 RVA: 0x0024E5FD File Offset: 0x0024C7FD
		public unsafe UTextureRenderTarget2D RenderTarget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + ACircleStampConsumer.__PropertyOffset_RenderTarget);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ACircleStampConsumer.__PropertyOffset_RenderTarget, value);
			}
		}

		// Token: 0x170062E7 RID: 25319
		// (get) Token: 0x06018F57 RID: 102231 RVA: 0x0024E612 File Offset: 0x0024C812
		// (set) Token: 0x06018F58 RID: 102232 RVA: 0x0024E622 File Offset: 0x0024C822
		public unsafe int RenderTargetSizeX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACircleStampConsumer.__PropertyOffset_RenderTargetSizeX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACircleStampConsumer.__PropertyOffset_RenderTargetSizeX) = value;
			}
		}

		// Token: 0x170062E8 RID: 25320
		// (get) Token: 0x06018F59 RID: 102233 RVA: 0x0024E633 File Offset: 0x0024C833
		// (set) Token: 0x06018F5A RID: 102234 RVA: 0x0024E643 File Offset: 0x0024C843
		public unsafe int RenderTargetSizeY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACircleStampConsumer.__PropertyOffset_RenderTargetSizeY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACircleStampConsumer.__PropertyOffset_RenderTargetSizeY) = value;
			}
		}

		// Token: 0x170062E9 RID: 25321
		// (get) Token: 0x06018F5B RID: 102235 RVA: 0x0024E654 File Offset: 0x0024C854
		// (set) Token: 0x06018F5C RID: 102236 RVA: 0x0024E68D File Offset: 0x0024C88D
		[Nullable(1)]
		public TArray<FCircleStampWorld2D> Circles
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FCircleStampWorld2D> result;
				if ((result = this._Circles) == null)
				{
					result = (this._Circles = new TArray<FCircleStampWorld2D>(base.NativePtr + (IntPtr)ACircleStampConsumer.__PropertyOffset_Circles, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Circles.CopyAssign(value);
			}
		}

		// Token: 0x170062EA RID: 25322
		// (get) Token: 0x06018F5D RID: 102237 RVA: 0x0024E69B File Offset: 0x0024C89B
		// (set) Token: 0x06018F5E RID: 102238 RVA: 0x0024E6AF File Offset: 0x0024C8AF
		public unsafe FLinearColor ClearColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACircleStampConsumer.__PropertyOffset_ClearColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACircleStampConsumer.__PropertyOffset_ClearColor) = value;
			}
		}

		// Token: 0x170062EB RID: 25323
		// (get) Token: 0x06018F5F RID: 102239 RVA: 0x0024E6C4 File Offset: 0x0024C8C4
		// (set) Token: 0x06018F60 RID: 102240 RVA: 0x0024E6D4 File Offset: 0x0024C8D4
		public unsafe bool bAutoFadeOnValueChange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACircleStampConsumer.__PropertyOffset_bAutoFadeOnValueChange) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACircleStampConsumer.__PropertyOffset_bAutoFadeOnValueChange) = (value ? 1 : 0);
			}
		}

		// Token: 0x170062EC RID: 25324
		// (get) Token: 0x06018F61 RID: 102241 RVA: 0x0024E6E5 File Offset: 0x0024C8E5
		// (set) Token: 0x06018F62 RID: 102242 RVA: 0x0024E6F5 File Offset: 0x0024C8F5
		public unsafe float DefaultFadeDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACircleStampConsumer.__PropertyOffset_DefaultFadeDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACircleStampConsumer.__PropertyOffset_DefaultFadeDuration) = value;
			}
		}

		// Token: 0x170062ED RID: 25325
		// (get) Token: 0x06018F63 RID: 102243 RVA: 0x0024E706 File Offset: 0x0024C906
		// (set) Token: 0x06018F64 RID: 102244 RVA: 0x0024E71A File Offset: 0x0024C91A
		public unsafe USceneComponent Root
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ACircleStampConsumer.__PropertyOffset_Root);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ACircleStampConsumer.__PropertyOffset_Root, value);
			}
		}

		// Token: 0x06018F65 RID: 102245 RVA: 0x0024E72F File Offset: 0x0024C92F
		public void SetRenderTargetWorldRadius(float InRadius)
		{
			ACircleStampConsumer.__SetRenderTargetWorldRadius_Internal(base.NativePtr, InRadius);
		}

		// Token: 0x06018F66 RID: 102246 RVA: 0x0024E73D File Offset: 0x0024C93D
		public void SetRenderTargetWorldCenter(in FVectorDouble InCenter)
		{
			ACircleStampConsumer.__SetRenderTargetWorldCenter_Internal(base.NativePtr, InCenter);
		}

		// Token: 0x06018F67 RID: 102247 RVA: 0x0024E74B File Offset: 0x0024C94B
		public void SetRenderTargetSize(int InSizeX, int InSizeY)
		{
			ACircleStampConsumer.__SetRenderTargetSize_Internal(base.NativePtr, InSizeX, InSizeY);
		}

		// Token: 0x06018F68 RID: 102248 RVA: 0x0024E75A File Offset: 0x0024C95A
		public void SetRenderTarget(UTextureRenderTarget2D InRenderTarget)
		{
			ACircleStampConsumer.__SetRenderTarget_Internal(base.NativePtr, (InRenderTarget != null) ? InRenderTarget.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06018F69 RID: 102249 RVA: 0x0024E777 File Offset: 0x0024C977
		public void SetClearColor(in FLinearColor InClearColor)
		{
			ACircleStampConsumer.__SetClearColor_Internal(base.NativePtr, InClearColor);
		}

		// Token: 0x06018F6A RID: 102250
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRenderTargetWorldRadius_Internal(IntPtr @this, float InRadius);

		// Token: 0x06018F6B RID: 102251
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRenderTargetWorldCenter_Internal(IntPtr @this, in FVectorDouble InCenter);

		// Token: 0x06018F6C RID: 102252
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRenderTargetSize_Internal(IntPtr @this, int InSizeX, int InSizeY);

		// Token: 0x06018F6D RID: 102253
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRenderTarget_Internal(IntPtr @this, IntPtr InRenderTarget);

		// Token: 0x06018F6E RID: 102254
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetClearColor_Internal(IntPtr @this, in FLinearColor InClearColor);

		// Token: 0x06018F6F RID: 102255 RVA: 0x0024E785 File Offset: 0x0024C985
		static ACircleStampConsumer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.CircleStampConsumer");
		}

		// Token: 0x06018F70 RID: 102256 RVA: 0x0024E793 File Offset: 0x0024C993
		protected ACircleStampConsumer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x06018F71 RID: 102257 RVA: 0x0024E79C File Offset: 0x0024C99C
		void IKuroRenderingStampConsumer.SetRenderTargetWorldCenter(in FVectorDouble InCenter)
		{
			this.SetRenderTargetWorldCenter(InCenter);
		}

		// Token: 0x06018F72 RID: 102258 RVA: 0x0024E7A5 File Offset: 0x0024C9A5
		void IKuroRenderingStampConsumer.SetClearColor(in FLinearColor InClearColor)
		{
			this.SetClearColor(InClearColor);
		}

		// Token: 0x0400D813 RID: 55315
		internal static int __InterfaceOffset_IKuroRenderingStampConsumer;

		// Token: 0x0400D814 RID: 55316
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.CircleStampConsumer";

		// Token: 0x0400D815 RID: 55317
		private static IntPtr _ClassPtr;

		// Token: 0x0400D816 RID: 55318
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D817 RID: 55319
		internal static int __PropertyOffset_RTWorldCenter;

		// Token: 0x0400D818 RID: 55320
		internal static int __PropertyOffset_RTWorldRadius;

		// Token: 0x0400D819 RID: 55321
		internal static int __PropertyOffset_RenderTarget;

		// Token: 0x0400D81A RID: 55322
		internal static int __PropertyOffset_RenderTargetSizeX;

		// Token: 0x0400D81B RID: 55323
		internal static int __PropertyOffset_RenderTargetSizeY;

		// Token: 0x0400D81C RID: 55324
		internal static int __PropertyOffset_Circles;

		// Token: 0x0400D81D RID: 55325
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCircleStampWorld2D> _Circles;

		// Token: 0x0400D81E RID: 55326
		internal static int __PropertyOffset_ClearColor;

		// Token: 0x0400D81F RID: 55327
		internal static int __PropertyOffset_bAutoFadeOnValueChange;

		// Token: 0x0400D820 RID: 55328
		internal static int __PropertyOffset_DefaultFadeDuration;

		// Token: 0x0400D821 RID: 55329
		internal static int __PropertyOffset_Root;
	}
}
