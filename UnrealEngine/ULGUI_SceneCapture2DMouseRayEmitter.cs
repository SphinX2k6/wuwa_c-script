using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020E4 RID: 8420
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUI_SceneCapture2DMouseRayEmitter")]
	[UnrealStructLayout(272, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 272)]
	public class ULGUI_SceneCapture2DMouseRayEmitter : ULGUIBaseRayEmitter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FB5A RID: 129882 RVA: 0x002F264D File Offset: 0x002F084D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUI_SceneCapture2DMouseRayEmitter._ClassPtr;
		}

		// Token: 0x0601FB5B RID: 129883 RVA: 0x002F265C File Offset: 0x002F085C
		public ULGUI_SceneCapture2DMouseRayEmitter() : this(BuiltinUtils.AllocNativeUObject(ULGUI_SceneCapture2DMouseRayEmitter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FB5C RID: 129884 RVA: 0x002F2684 File Offset: 0x002F0884
		[NullableContext(1)]
		public ULGUI_SceneCapture2DMouseRayEmitter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUI_SceneCapture2DMouseRayEmitter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007CE7 RID: 31975
		// (get) Token: 0x0601FB5D RID: 129885 RVA: 0x002F26B7 File Offset: 0x002F08B7
		// (set) Token: 0x0601FB5E RID: 129886 RVA: 0x002F26CB File Offset: 0x002F08CB
		public unsafe ASceneCapture2D SceneCaptureActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ASceneCapture2D>(base.NativePtr / (IntPtr)sizeof(void*) + ULGUI_SceneCapture2DMouseRayEmitter.__PropertyOffset_SceneCaptureActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULGUI_SceneCapture2DMouseRayEmitter.__PropertyOffset_SceneCaptureActor, value);
			}
		}

		// Token: 0x17007CE8 RID: 31976
		// (get) Token: 0x0601FB5F RID: 129887 RVA: 0x002F26E0 File Offset: 0x002F08E0
		// (set) Token: 0x0601FB60 RID: 129888 RVA: 0x002F26F4 File Offset: 0x002F08F4
		public unsafe USceneCaptureComponent2D sceneCaptureComp
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneCaptureComponent2D>(base.NativePtr / (IntPtr)sizeof(void*) + ULGUI_SceneCapture2DMouseRayEmitter.__PropertyOffset_sceneCaptureComp);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULGUI_SceneCapture2DMouseRayEmitter.__PropertyOffset_sceneCaptureComp, value);
			}
		}

		// Token: 0x0601FB61 RID: 129889 RVA: 0x002F2709 File Offset: 0x002F0909
		public void SetSceneCapture2DComponent(USceneCaptureComponent2D InComp)
		{
			ULGUI_SceneCapture2DMouseRayEmitter.__SetSceneCapture2DComponent_Internal(base.NativePtr, (InComp != null) ? InComp.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601FB62 RID: 129890 RVA: 0x002F2728 File Offset: 0x002F0928
		public unsafe static bool ProjectWorldToViewPointForSceneCapture2D(USceneCaptureComponent2D InSceneCapture2D, in FVector InWorldPosition, ref FVector2D OutViewPoint)
		{
			fixed (FVector2D* ptr = &OutViewPoint)
			{
				void* ptr2 = (void*)ptr;
				return ULGUI_SceneCapture2DMouseRayEmitter.__ProjectWorldToViewPointForSceneCapture2D_Internal((InSceneCapture2D != null) ? InSceneCapture2D.NativePtr : IntPtr.Zero, InWorldPosition, ref OutViewPoint);
			}
		}

		// Token: 0x0601FB63 RID: 129891 RVA: 0x002F2751 File Offset: 0x002F0951
		public USceneCaptureComponent2D GetSceneCapture2DComponent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USceneCaptureComponent2D>(ULGUI_SceneCapture2DMouseRayEmitter.__GetSceneCapture2DComponent_Internal(base.NativePtr));
		}

		// Token: 0x0601FB64 RID: 129892 RVA: 0x002F2764 File Offset: 0x002F0964
		public unsafe static void DeprojectViewPointToWorldForSceneCapture2D(USceneCaptureComponent2D InSceneCapture2D, in FVector2D InViewPoint01, ref FVector OutRayOrigin, ref FVector OutRayDirection)
		{
			fixed (FVector* ptr = &OutRayOrigin)
			{
				void* ptr2 = (void*)ptr;
				fixed (FVector* ptr3 = &OutRayDirection)
				{
					void* ptr4 = (void*)ptr3;
					ULGUI_SceneCapture2DMouseRayEmitter.__DeprojectViewPointToWorldForSceneCapture2D_Internal((InSceneCapture2D != null) ? InSceneCapture2D.NativePtr : IntPtr.Zero, InViewPoint01, ref OutRayOrigin, ref OutRayDirection);
					ptr = null;
				}
			}
		}

		// Token: 0x0601FB65 RID: 129893
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSceneCapture2DComponent_Internal(IntPtr @this, IntPtr InComp);

		// Token: 0x0601FB66 RID: 129894
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ProjectWorldToViewPointForSceneCapture2D_Internal(IntPtr InSceneCapture2D, in FVector InWorldPosition, ref FVector2D OutViewPoint);

		// Token: 0x0601FB67 RID: 129895
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSceneCapture2DComponent_Internal(IntPtr @this);

		// Token: 0x0601FB68 RID: 129896
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DeprojectViewPointToWorldForSceneCapture2D_Internal(IntPtr InSceneCapture2D, in FVector2D InViewPoint01, ref FVector OutRayOrigin, ref FVector OutRayDirection);

		// Token: 0x0601FB69 RID: 129897 RVA: 0x002F2799 File Offset: 0x002F0999
		static ULGUI_SceneCapture2DMouseRayEmitter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUI_SceneCapture2DMouseRayEmitter");
		}

		// Token: 0x0601FB6A RID: 129898 RVA: 0x002F27A7 File Offset: 0x002F09A7
		protected ULGUI_SceneCapture2DMouseRayEmitter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401119A RID: 70042
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUI_SceneCapture2DMouseRayEmitter";

		// Token: 0x0401119B RID: 70043
		private static IntPtr _ClassPtr;

		// Token: 0x0401119C RID: 70044
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401119D RID: 70045
		internal static int __PropertyOffset_SceneCaptureActor;

		// Token: 0x0401119E RID: 70046
		internal static int __PropertyOffset_sceneCaptureComp;
	}
}
