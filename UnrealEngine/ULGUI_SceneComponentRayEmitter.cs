using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020E5 RID: 8421
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUI_SceneComponentRayEmitter")]
	[UnrealStructLayout(272, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 272)]
	public class ULGUI_SceneComponentRayEmitter : ULGUIBaseRayEmitter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FB6B RID: 129899 RVA: 0x002F27B0 File Offset: 0x002F09B0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUI_SceneComponentRayEmitter._ClassPtr;
		}

		// Token: 0x0601FB6C RID: 129900 RVA: 0x002F27BC File Offset: 0x002F09BC
		public ULGUI_SceneComponentRayEmitter() : this(BuiltinUtils.AllocNativeUObject(ULGUI_SceneComponentRayEmitter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FB6D RID: 129901 RVA: 0x002F27E4 File Offset: 0x002F09E4
		[NullableContext(1)]
		public ULGUI_SceneComponentRayEmitter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUI_SceneComponentRayEmitter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007CE9 RID: 31977
		// (get) Token: 0x0601FB6E RID: 129902 RVA: 0x002F2817 File Offset: 0x002F0A17
		// (set) Token: 0x0601FB6F RID: 129903 RVA: 0x002F282B File Offset: 0x002F0A2B
		public unsafe AActor TargetActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + ULGUI_SceneComponentRayEmitter.__PropertyOffset_TargetActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULGUI_SceneComponentRayEmitter.__PropertyOffset_TargetActor, value);
			}
		}

		// Token: 0x17007CEA RID: 31978
		// (get) Token: 0x0601FB70 RID: 129904 RVA: 0x002F2840 File Offset: 0x002F0A40
		// (set) Token: 0x0601FB71 RID: 129905 RVA: 0x002F2850 File Offset: 0x002F0A50
		public unsafe ESceneComponentRayDirection RayDirectionType
		{
			get
			{
				return (ESceneComponentRayDirection)(*(base.NativePtr + (IntPtr)ULGUI_SceneComponentRayEmitter.__PropertyOffset_RayDirectionType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUI_SceneComponentRayEmitter.__PropertyOffset_RayDirectionType) = (byte)value;
			}
		}

		// Token: 0x17007CEB RID: 31979
		// (get) Token: 0x0601FB72 RID: 129906 RVA: 0x002F2861 File Offset: 0x002F0A61
		// (set) Token: 0x0601FB73 RID: 129907 RVA: 0x002F2871 File Offset: 0x002F0A71
		public unsafe bool clickThresholdRelateToRayDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUI_SceneComponentRayEmitter.__PropertyOffset_clickThresholdRelateToRayDistance) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUI_SceneComponentRayEmitter.__PropertyOffset_clickThresholdRelateToRayDistance) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007CEC RID: 31980
		// (get) Token: 0x0601FB74 RID: 129908 RVA: 0x002F2882 File Offset: 0x002F0A82
		// (set) Token: 0x0601FB75 RID: 129909 RVA: 0x002F2896 File Offset: 0x002F0A96
		public unsafe USceneComponent CacheTargetSceneComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ULGUI_SceneComponentRayEmitter.__PropertyOffset_CacheTargetSceneComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULGUI_SceneComponentRayEmitter.__PropertyOffset_CacheTargetSceneComponent, value);
			}
		}

		// Token: 0x0601FB76 RID: 129910 RVA: 0x002F28AB File Offset: 0x002F0AAB
		public void SetTargetSceneComponent(USceneComponent InSceneComp)
		{
			ULGUI_SceneComponentRayEmitter.__SetTargetSceneComponent_Internal(base.NativePtr, (InSceneComp != null) ? InSceneComp.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601FB77 RID: 129911 RVA: 0x002F28C8 File Offset: 0x002F0AC8
		public void SetTargetActor(AActor InActor)
		{
			ULGUI_SceneComponentRayEmitter.__SetTargetActor_Internal(base.NativePtr, (InActor != null) ? InActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601FB78 RID: 129912 RVA: 0x002F28E5 File Offset: 0x002F0AE5
		public USceneComponent GetTargetSceneComponent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USceneComponent>(ULGUI_SceneComponentRayEmitter.__GetTargetSceneComponent_Internal(base.NativePtr));
		}

		// Token: 0x0601FB79 RID: 129913 RVA: 0x002F28F7 File Offset: 0x002F0AF7
		public AActor GetTargetActor()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(ULGUI_SceneComponentRayEmitter.__GetTargetActor_Internal(base.NativePtr));
		}

		// Token: 0x0601FB7A RID: 129914
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTargetSceneComponent_Internal(IntPtr @this, IntPtr InSceneComp);

		// Token: 0x0601FB7B RID: 129915
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTargetActor_Internal(IntPtr @this, IntPtr InActor);

		// Token: 0x0601FB7C RID: 129916
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetTargetSceneComponent_Internal(IntPtr @this);

		// Token: 0x0601FB7D RID: 129917
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetTargetActor_Internal(IntPtr @this);

		// Token: 0x0601FB7E RID: 129918 RVA: 0x002F2909 File Offset: 0x002F0B09
		static ULGUI_SceneComponentRayEmitter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUI_SceneComponentRayEmitter");
		}

		// Token: 0x0601FB7F RID: 129919 RVA: 0x002F2917 File Offset: 0x002F0B17
		protected ULGUI_SceneComponentRayEmitter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401119F RID: 70047
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUI_SceneComponentRayEmitter";

		// Token: 0x040111A0 RID: 70048
		private static IntPtr _ClassPtr;

		// Token: 0x040111A1 RID: 70049
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040111A2 RID: 70050
		internal static int __PropertyOffset_TargetActor;

		// Token: 0x040111A3 RID: 70051
		internal static int __PropertyOffset_RayDirectionType;

		// Token: 0x040111A4 RID: 70052
		internal static int __PropertyOffset_clickThresholdRelateToRayDistance;

		// Token: 0x040111A5 RID: 70053
		internal static int __PropertyOffset_CacheTargetSceneComponent;
	}
}
