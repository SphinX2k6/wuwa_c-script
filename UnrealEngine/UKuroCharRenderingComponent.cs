using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AC4 RID: 6852
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroCharRenderingComponent")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class UKuroCharRenderingComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601973A RID: 104250 RVA: 0x00259F9A File Offset: 0x0025819A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCharRenderingComponent._ClassPtr;
		}

		// Token: 0x0601973B RID: 104251 RVA: 0x00259FA8 File Offset: 0x002581A8
		public UKuroCharRenderingComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroCharRenderingComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601973C RID: 104252 RVA: 0x00259FD0 File Offset: 0x002581D0
		[NullableContext(1)]
		public UKuroCharRenderingComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCharRenderingComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700657F RID: 25983
		// (get) Token: 0x0601973D RID: 104253 RVA: 0x0025A003 File Offset: 0x00258203
		// (set) Token: 0x0601973E RID: 104254 RVA: 0x0025A017 File Offset: 0x00258217
		public unsafe UKuroMaterialControllerComponent MaterialController
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroMaterialControllerComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroCharRenderingComponent.__PropertyOffset_MaterialController);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroCharRenderingComponent.__PropertyOffset_MaterialController, value);
			}
		}

		// Token: 0x0601973F RID: 104255 RVA: 0x0025A02C File Offset: 0x0025822C
		public void UpdateHitMesh(float DeltaTime)
		{
			UKuroCharRenderingComponent.__UpdateHitMesh_Internal(base.NativePtr, DeltaTime);
		}

		// Token: 0x06019740 RID: 104256
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UnbindCharacterShadowConfigChangedCallback();

		// Token: 0x06019741 RID: 104257 RVA: 0x0025A03A File Offset: 0x0025823A
		public void PostComponentsVisibilityChanged()
		{
			UKuroCharRenderingComponent.__PostComponentsVisibilityChanged_Internal(base.NativePtr);
		}

		// Token: 0x06019742 RID: 104258 RVA: 0x0025A047 File Offset: 0x00258247
		public UKuroMaterialControllerComponent GetSureMaterialController()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroMaterialControllerComponent>(UKuroCharRenderingComponent.__GetSureMaterialController_Internal(base.NativePtr));
		}

		// Token: 0x06019743 RID: 104259 RVA: 0x0025A059 File Offset: 0x00258259
		public void ClearAllHitMesh()
		{
			UKuroCharRenderingComponent.__ClearAllHitMesh_Internal(base.NativePtr);
		}

		// Token: 0x06019744 RID: 104260 RVA: 0x0025A066 File Offset: 0x00258266
		public static void BindCharacterShadowConfigChangedCallback(FOnCharacterShadowConfigChanged Callback)
		{
			UKuroCharRenderingComponent.__BindCharacterShadowConfigChangedCallback_Internal((Callback != null) ? Callback.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06019745 RID: 104261 RVA: 0x0025A07C File Offset: 0x0025827C
		public unsafe void AddHitMeshOnSocket(USkeletalMesh SkeletalMesh, in FTransformDouble WorldTransform, FName Socket, float LastTime, in FTransform MeshTransform)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = WorldTransform;
			ref FTransform ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr2 = MeshTransform;
			UKuroCharRenderingComponent.__AddHitMeshOnSocket_Internal(base.NativePtr, (SkeletalMesh != null) ? SkeletalMesh.NativePtr : IntPtr.Zero, ptr, Socket, LastTime, ptr2);
		}

		// Token: 0x06019746 RID: 104262
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateHitMesh_Internal(IntPtr @this, float DeltaTime);

		// Token: 0x06019747 RID: 104263
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PostComponentsVisibilityChanged_Internal(IntPtr @this);

		// Token: 0x06019748 RID: 104264
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSureMaterialController_Internal(IntPtr @this);

		// Token: 0x06019749 RID: 104265
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearAllHitMesh_Internal(IntPtr @this);

		// Token: 0x0601974A RID: 104266
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BindCharacterShadowConfigChangedCallback_Internal(IntPtr Callback);

		// Token: 0x0601974B RID: 104267
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddHitMeshOnSocket_Internal(IntPtr @this, IntPtr SkeletalMesh, in FTransformDouble WorldTransform, FName Socket, float LastTime, in FTransform MeshTransform);

		// Token: 0x0601974C RID: 104268 RVA: 0x0025A0E2 File Offset: 0x002582E2
		static UKuroCharRenderingComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroCharRenderingComponent");
		}

		// Token: 0x0601974D RID: 104269 RVA: 0x0025A0F0 File Offset: 0x002582F0
		protected UKuroCharRenderingComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400DDBF RID: 56767
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroCharRenderingComponent";

		// Token: 0x0400DDC0 RID: 56768
		private static IntPtr _ClassPtr;

		// Token: 0x0400DDC1 RID: 56769
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400DDC2 RID: 56770
		internal static int __PropertyOffset_MaterialController;
	}
}
