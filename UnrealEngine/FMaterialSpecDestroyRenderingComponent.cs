using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200191E RID: 6430
	public sealed class FMaterialSpecDestroyRenderingComponent : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06017DB7 RID: 97719 RVA: 0x0022F111 File Offset: 0x0022D311
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FMaterialSpecDestroyRenderingComponent.StaticFunctionPtr();
		}

		// Token: 0x06017DB8 RID: 97720 RVA: 0x0022F11D File Offset: 0x0022D31D
		private static IntPtr StaticFunctionPtr()
		{
			if (FMaterialSpecDestroyRenderingComponent._FunctionPtr == IntPtr.Zero)
			{
				FMaterialSpecDestroyRenderingComponent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.MaterialSpecDestroyRenderingComponent__DelegateSignature");
			}
			return FMaterialSpecDestroyRenderingComponent._FunctionPtr;
		}

		// Token: 0x06017DB9 RID: 97721 RVA: 0x0022F140 File Offset: 0x0022D340
		public FMaterialSpecDestroyRenderingComponent()
		{
		}

		// Token: 0x06017DBA RID: 97722 RVA: 0x0022F148 File Offset: 0x0022D348
		[NullableContext(2)]
		public FMaterialSpecDestroyRenderingComponent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017DBB RID: 97723 RVA: 0x0022F152 File Offset: 0x0022D352
		public FMaterialSpecDestroyRenderingComponent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017DBC RID: 97724 RVA: 0x0022F15D File Offset: 0x0022D35D
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<UKuroCharRenderingComponent>) ?? ((Action<UKuroCharRenderingComponent>)Delegate.CreateDelegate(typeof(Action<UKuroCharRenderingComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06017DBD RID: 97725 RVA: 0x0022F18F File Offset: 0x0022D38F
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06017DBE RID: 97726 RVA: 0x0022F1CC File Offset: 0x0022D3CC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(UKuroCharRenderingComponent RenderComponent)
		{
			FMaterialSpecDestroyRenderingComponent.__FMaterialSpecDestroyRenderingComponent_DelegateParams* ptr = stackalloc FMaterialSpecDestroyRenderingComponent.__FMaterialSpecDestroyRenderingComponent_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FMaterialSpecDestroyRenderingComponent.__FMaterialSpecDestroyRenderingComponent_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FMaterialSpecDestroyRenderingComponent.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->RenderComponent = ((RenderComponent != null) ? RenderComponent.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06017DBF RID: 97727 RVA: 0x0022F218 File Offset: 0x0022D418
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x0400CECB RID: 52939
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400CECC RID: 52940
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.MaterialSpecDestroyRenderingComponent__DelegateSignature";

		// Token: 0x0400CECD RID: 52941
		private static int RegisterId;

		// Token: 0x02002FE5 RID: 12261
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FMaterialSpecDestroyRenderingComponent_DelegateParams
		{
			// Token: 0x04016BE1 RID: 93153
			[FieldOffset(0)]
			public IntPtr RenderComponent;
		}

		// Token: 0x02002FE6 RID: 12262
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016BE2 RID: 93154
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
