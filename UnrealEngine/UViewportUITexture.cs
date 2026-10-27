using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021E3 RID: 8675
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.ViewportUITexture")]
	[UnrealStructLayout(2544, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2544)]
	public class UViewportUITexture : UUITexture, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602115C RID: 135516 RVA: 0x0030C8F8 File Offset: 0x0030AAF8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UViewportUITexture._ClassPtr;
		}

		// Token: 0x0602115D RID: 135517 RVA: 0x0030C904 File Offset: 0x0030AB04
		public UViewportUITexture() : this(BuiltinUtils.AllocNativeUObject(UViewportUITexture.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602115E RID: 135518 RVA: 0x0030C92C File Offset: 0x0030AB2C
		[NullableContext(1)]
		public UViewportUITexture(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UViewportUITexture.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008127 RID: 33063
		// (get) Token: 0x0602115F RID: 135519 RVA: 0x0030C95F File Offset: 0x0030AB5F
		// (set) Token: 0x06021160 RID: 135520 RVA: 0x0030C973 File Offset: 0x0030AB73
		public unsafe ASceneCapture2D SceneCaptureActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ASceneCapture2D>(base.NativePtr / (IntPtr)sizeof(void*) + UViewportUITexture.__PropertyOffset_SceneCaptureActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UViewportUITexture.__PropertyOffset_SceneCaptureActor, value);
			}
		}

		// Token: 0x17008128 RID: 33064
		// (get) Token: 0x06021161 RID: 135521 RVA: 0x0030C988 File Offset: 0x0030AB88
		// (set) Token: 0x06021162 RID: 135522 RVA: 0x0030C998 File Offset: 0x0030AB98
		public unsafe bool bSyncSizeToRT
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UViewportUITexture.__PropertyOffset_bSyncSizeToRT) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UViewportUITexture.__PropertyOffset_bSyncSizeToRT) = (value ? 1 : 0);
			}
		}

		// Token: 0x06021163 RID: 135523 RVA: 0x0030C9AC File Offset: 0x0030ABAC
		public unsafe bool WorldToViewPoint(in FVector InWorldLocation, ref FVector2D OutViewPoint)
		{
			fixed (FVector2D* ptr = &OutViewPoint)
			{
				void* ptr2 = (void*)ptr;
				return UViewportUITexture.__WorldToViewPoint_Internal(base.NativePtr, InWorldLocation, ref OutViewPoint);
			}
		}

		// Token: 0x06021164 RID: 135524 RVA: 0x0030C9CC File Offset: 0x0030ABCC
		public unsafe void ViewPointToWorld(in FVector2D InViewPoint, ref FVector OutWorldLocation, ref FVector OutWorldDirection)
		{
			fixed (FVector* ptr = &OutWorldLocation)
			{
				void* ptr2 = (void*)ptr;
				fixed (FVector* ptr3 = &OutWorldDirection)
				{
					void* ptr4 = (void*)ptr3;
					UViewportUITexture.__ViewPointToWorld_Internal(base.NativePtr, InViewPoint, ref OutWorldLocation, ref OutWorldDirection);
					ptr = null;
				}
			}
		}

		// Token: 0x06021165 RID: 135525 RVA: 0x0030C9F7 File Offset: 0x0030ABF7
		public USceneCaptureComponent2D GetSceneCapture()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USceneCaptureComponent2D>(UViewportUITexture.__GetSceneCapture_Internal(base.NativePtr));
		}

		// Token: 0x06021166 RID: 135526
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __WorldToViewPoint_Internal(IntPtr @this, in FVector InWorldLocation, ref FVector2D OutViewPoint);

		// Token: 0x06021167 RID: 135527
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ViewPointToWorld_Internal(IntPtr @this, in FVector2D InViewPoint, ref FVector OutWorldLocation, ref FVector OutWorldDirection);

		// Token: 0x06021168 RID: 135528
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSceneCapture_Internal(IntPtr @this);

		// Token: 0x06021169 RID: 135529 RVA: 0x0030CA09 File Offset: 0x0030AC09
		static UViewportUITexture()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.ViewportUITexture");
		}

		// Token: 0x0602116A RID: 135530 RVA: 0x0030CA17 File Offset: 0x0030AC17
		protected UViewportUITexture(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011A5F RID: 72287
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.ViewportUITexture";

		// Token: 0x04011A60 RID: 72288
		private static IntPtr _ClassPtr;

		// Token: 0x04011A61 RID: 72289
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011A62 RID: 72290
		internal static int __PropertyOffset_SceneCaptureActor;

		// Token: 0x04011A63 RID: 72291
		internal static int __PropertyOffset_bSyncSizeToRT;
	}
}
