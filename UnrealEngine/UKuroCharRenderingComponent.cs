using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004B9 RID: 1209
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroCharRenderingComponent")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class UKuroCharRenderingComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006F4B RID: 28491 RVA: 0x000A4B3A File Offset: 0x000A2D3A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCharRenderingComponent._ClassPtr;
		}

		// Token: 0x06006F4C RID: 28492 RVA: 0x000A4B48 File Offset: 0x000A2D48
		public UKuroCharRenderingComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroCharRenderingComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006F4D RID: 28493 RVA: 0x000A4B70 File Offset: 0x000A2D70
		[NullableContext(1)]
		public UKuroCharRenderingComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCharRenderingComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170015B5 RID: 5557
		// (get) Token: 0x06006F4E RID: 28494 RVA: 0x000A4BA3 File Offset: 0x000A2DA3
		// (set) Token: 0x06006F4F RID: 28495 RVA: 0x000A4BB7 File Offset: 0x000A2DB7
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

		// Token: 0x06006F50 RID: 28496 RVA: 0x000A4BCC File Offset: 0x000A2DCC
		public void UpdateHitMesh(float DeltaTime)
		{
			UKuroCharRenderingComponent.__UpdateHitMesh_Internal(base.NativePtr, DeltaTime);
		}

		// Token: 0x06006F51 RID: 28497
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UnbindCharacterShadowConfigChangedCallback();

		// Token: 0x06006F52 RID: 28498 RVA: 0x000A4BDA File Offset: 0x000A2DDA
		public void PostComponentsVisibilityChanged()
		{
			UKuroCharRenderingComponent.__PostComponentsVisibilityChanged_Internal(base.NativePtr);
		}

		// Token: 0x06006F53 RID: 28499 RVA: 0x000A4BE7 File Offset: 0x000A2DE7
		public UKuroMaterialControllerComponent GetSureMaterialController()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroMaterialControllerComponent>(UKuroCharRenderingComponent.__GetSureMaterialController_Internal(base.NativePtr));
		}

		// Token: 0x06006F54 RID: 28500 RVA: 0x000A4BF9 File Offset: 0x000A2DF9
		public void ClearAllHitMesh()
		{
			UKuroCharRenderingComponent.__ClearAllHitMesh_Internal(base.NativePtr);
		}

		// Token: 0x06006F55 RID: 28501 RVA: 0x000A4C06 File Offset: 0x000A2E06
		public static void BindCharacterShadowConfigChangedCallback(FOnCharacterShadowConfigChanged Callback)
		{
			UKuroCharRenderingComponent.__BindCharacterShadowConfigChangedCallback_Internal((Callback != null) ? Callback.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06006F56 RID: 28502 RVA: 0x000A4C1C File Offset: 0x000A2E1C
		public unsafe void AddHitMeshOnSocket(USkeletalMesh SkeletalMesh, in FTransformDouble WorldTransform, FName Socket, float LastTime, in FTransform MeshTransform)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = WorldTransform;
			ref FTransform ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr2 = MeshTransform;
			UKuroCharRenderingComponent.__AddHitMeshOnSocket_Internal(base.NativePtr, (SkeletalMesh != null) ? SkeletalMesh.NativePtr : IntPtr.Zero, ptr, Socket, LastTime, ptr2);
		}

		// Token: 0x06006F57 RID: 28503
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateHitMesh_Internal(IntPtr @this, float DeltaTime);

		// Token: 0x06006F58 RID: 28504
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PostComponentsVisibilityChanged_Internal(IntPtr @this);

		// Token: 0x06006F59 RID: 28505
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSureMaterialController_Internal(IntPtr @this);

		// Token: 0x06006F5A RID: 28506
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearAllHitMesh_Internal(IntPtr @this);

		// Token: 0x06006F5B RID: 28507
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BindCharacterShadowConfigChangedCallback_Internal(IntPtr Callback);

		// Token: 0x06006F5C RID: 28508
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddHitMeshOnSocket_Internal(IntPtr @this, IntPtr SkeletalMesh, in FTransformDouble WorldTransform, FName Socket, float LastTime, in FTransform MeshTransform);

		// Token: 0x06006F5D RID: 28509 RVA: 0x000A4C82 File Offset: 0x000A2E82
		static UKuroCharRenderingComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroCharRenderingComponent");
		}

		// Token: 0x06006F5E RID: 28510 RVA: 0x000A4C90 File Offset: 0x000A2E90
		protected UKuroCharRenderingComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003024 RID: 12324
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroCharRenderingComponent";

		// Token: 0x04003025 RID: 12325
		private static IntPtr _ClassPtr;

		// Token: 0x04003026 RID: 12326
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003027 RID: 12327
		internal static int __PropertyOffset_MaterialController;
	}
}
