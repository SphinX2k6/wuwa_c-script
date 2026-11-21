using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200040C RID: 1036
	public sealed class FMaterialSpecDestroyRenderingComponent : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600652D RID: 25901 RVA: 0x00090711 File Offset: 0x0008E911
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FMaterialSpecDestroyRenderingComponent.StaticFunctionPtr();
		}

		// Token: 0x0600652E RID: 25902 RVA: 0x0009071D File Offset: 0x0008E91D
		private static IntPtr StaticFunctionPtr()
		{
			if (FMaterialSpecDestroyRenderingComponent._FunctionPtr == IntPtr.Zero)
			{
				FMaterialSpecDestroyRenderingComponent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.MaterialSpecDestroyRenderingComponent__DelegateSignature");
			}
			return FMaterialSpecDestroyRenderingComponent._FunctionPtr;
		}

		// Token: 0x0600652F RID: 25903 RVA: 0x00090740 File Offset: 0x0008E940
		public FMaterialSpecDestroyRenderingComponent()
		{
		}

		// Token: 0x06006530 RID: 25904 RVA: 0x00090748 File Offset: 0x0008E948
		[NullableContext(2)]
		public FMaterialSpecDestroyRenderingComponent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006531 RID: 25905 RVA: 0x00090752 File Offset: 0x0008E952
		public FMaterialSpecDestroyRenderingComponent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006532 RID: 25906 RVA: 0x0009075D File Offset: 0x0008E95D
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<UKuroCharRenderingComponent>) ?? ((Action<UKuroCharRenderingComponent>)Delegate.CreateDelegate(typeof(Action<UKuroCharRenderingComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006533 RID: 25907 RVA: 0x0009078F File Offset: 0x0008E98F
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<UKuroCharRenderingComponent> Callback)
		{
			if (FMaterialSpecDestroyRenderingComponent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FMaterialSpecDestroyRenderingComponent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FMaterialSpecDestroyRenderingComponent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FMaterialSpecDestroyRenderingComponent.OnScriptCallback));
				}
				FMaterialSpecDestroyRenderingComponent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FMaterialSpecDestroyRenderingComponent.RegisterId);
		}

		// Token: 0x06006534 RID: 25908 RVA: 0x000907CC File Offset: 0x0008E9CC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Execute(UKuroCharRenderingComponent RenderComponent)
		{
			FMaterialSpecDestroyRenderingComponent.__FMaterialSpecDestroyRenderingComponent_DelegateParams* ptr = stackalloc FMaterialSpecDestroyRenderingComponent.__FMaterialSpecDestroyRenderingComponent_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FMaterialSpecDestroyRenderingComponent.__FMaterialSpecDestroyRenderingComponent_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FMaterialSpecDestroyRenderingComponent.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->RenderComponent = ((RenderComponent != null) ? RenderComponent.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06006535 RID: 25909 RVA: 0x00090818 File Offset: 0x0008EA18
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UKuroCharRenderingComponent> action = target as Action<UKuroCharRenderingComponent>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UKuroCharRenderingComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroCharRenderingComponent>(((FMaterialSpecDestroyRenderingComponent.__FMaterialSpecDestroyRenderingComponent_DelegateParams*)__Parameters)->RenderComponent);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04002A90 RID: 10896
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002A91 RID: 10897
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.MaterialSpecDestroyRenderingComponent__DelegateSignature";

		// Token: 0x04002A92 RID: 10898
		private static int RegisterId;

		// Token: 0x02000AF9 RID: 2809
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FMaterialSpecDestroyRenderingComponent_DelegateParams
		{
			// Token: 0x04005B8A RID: 23434
			[FieldOffset(0)]
			public IntPtr RenderComponent;
		}

		// Token: 0x02000AFA RID: 2810
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005B8B RID: 23435
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
