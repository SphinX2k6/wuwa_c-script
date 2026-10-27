using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021A1 RID: 8609
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UISceneView")]
	[UnrealStructLayout(2544, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2544)]
	public class UUISceneView : UUITexture, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020A74 RID: 133748 RVA: 0x00305265 File Offset: 0x00303465
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUISceneView._ClassPtr;
		}

		// Token: 0x06020A75 RID: 133749 RVA: 0x00305274 File Offset: 0x00303474
		public UUISceneView() : this(BuiltinUtils.AllocNativeUObject(UUISceneView.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020A76 RID: 133750 RVA: 0x0030529C File Offset: 0x0030349C
		[NullableContext(1)]
		public UUISceneView(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUISceneView.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007FA4 RID: 32676
		// (get) Token: 0x06020A77 RID: 133751 RVA: 0x003052CF File Offset: 0x003034CF
		// (set) Token: 0x06020A78 RID: 133752 RVA: 0x003052E3 File Offset: 0x003034E3
		public unsafe ASceneCapture2D SceneCaptureActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ASceneCapture2D>(base.NativePtr / (IntPtr)sizeof(void*) + UUISceneView.__PropertyOffset_SceneCaptureActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUISceneView.__PropertyOffset_SceneCaptureActor, value);
			}
		}

		// Token: 0x17007FA5 RID: 32677
		// (get) Token: 0x06020A79 RID: 133753 RVA: 0x003052F8 File Offset: 0x003034F8
		// (set) Token: 0x06020A7A RID: 133754 RVA: 0x00305308 File Offset: 0x00303508
		public unsafe bool bSyncSizeToRT
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISceneView.__PropertyOffset_bSyncSizeToRT) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISceneView.__PropertyOffset_bSyncSizeToRT) = (value ? 1 : 0);
			}
		}

		// Token: 0x06020A7B RID: 133755 RVA: 0x0030531C File Offset: 0x0030351C
		public unsafe bool WorldToViewPoint(in FVector InWorldLocation, ref FVector2D OutViewPoint)
		{
			fixed (FVector2D* ptr = &OutViewPoint)
			{
				void* ptr2 = (void*)ptr;
				return UUISceneView.__WorldToViewPoint_Internal(base.NativePtr, InWorldLocation, ref OutViewPoint);
			}
		}

		// Token: 0x06020A7C RID: 133756 RVA: 0x0030533C File Offset: 0x0030353C
		public unsafe void ViewPointToWorld(in FVector2D InViewPoint, ref FVector OutWorldLocation, ref FVector OutWorldDirection)
		{
			fixed (FVector* ptr = &OutWorldLocation)
			{
				void* ptr2 = (void*)ptr;
				fixed (FVector* ptr3 = &OutWorldDirection)
				{
					void* ptr4 = (void*)ptr3;
					UUISceneView.__ViewPointToWorld_Internal(base.NativePtr, InViewPoint, ref OutWorldLocation, ref OutWorldDirection);
					ptr = null;
				}
			}
		}

		// Token: 0x06020A7D RID: 133757 RVA: 0x00305367 File Offset: 0x00303567
		public USceneCaptureComponent2D GetSceneCapture()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USceneCaptureComponent2D>(UUISceneView.__GetSceneCapture_Internal(base.NativePtr));
		}

		// Token: 0x06020A7E RID: 133758
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __WorldToViewPoint_Internal(IntPtr @this, in FVector InWorldLocation, ref FVector2D OutViewPoint);

		// Token: 0x06020A7F RID: 133759
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ViewPointToWorld_Internal(IntPtr @this, in FVector2D InViewPoint, ref FVector OutWorldLocation, ref FVector OutWorldDirection);

		// Token: 0x06020A80 RID: 133760
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSceneCapture_Internal(IntPtr @this);

		// Token: 0x06020A81 RID: 133761 RVA: 0x00305379 File Offset: 0x00303579
		static UUISceneView()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UISceneView");
		}

		// Token: 0x06020A82 RID: 133762 RVA: 0x00305387 File Offset: 0x00303587
		protected UUISceneView(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401178F RID: 71567
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UISceneView";

		// Token: 0x04011790 RID: 71568
		private static IntPtr _ClassPtr;

		// Token: 0x04011791 RID: 71569
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011792 RID: 71570
		internal static int __PropertyOffset_SceneCaptureActor;

		// Token: 0x04011793 RID: 71571
		internal static int __PropertyOffset_bSyncSizeToRT;
	}
}
