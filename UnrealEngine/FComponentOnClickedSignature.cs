using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001B4 RID: 436
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FComponentOnClickedSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06002033 RID: 8243 RVA: 0x0002F262 File Offset: 0x0002D462
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FComponentOnClickedSignature.StaticFunctionPtr();
		}

		// Token: 0x06002034 RID: 8244 RVA: 0x0002F26E File Offset: 0x0002D46E
		private static IntPtr StaticFunctionPtr()
		{
			if (FComponentOnClickedSignature._FunctionPtr == IntPtr.Zero)
			{
				FComponentOnClickedSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ComponentOnClickedSignature__DelegateSignature");
			}
			return FComponentOnClickedSignature._FunctionPtr;
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06002035 RID: 8245 RVA: 0x0002F291 File Offset: 0x0002D491
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnClicked;
			}
		}

		// Token: 0x06002036 RID: 8246 RVA: 0x0002F298 File Offset: 0x0002D498
		[NullableContext(2)]
		public FComponentOnClickedSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002037 RID: 8247 RVA: 0x0002F2A2 File Offset: 0x0002D4A2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UPrimitiveComponent, FKey>) ?? ((Action<UPrimitiveComponent, FKey>)Delegate.CreateDelegate(typeof(Action<UPrimitiveComponent, FKey>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06002038 RID: 8248 RVA: 0x0002F2D4 File Offset: 0x0002D4D4
		public void Add([Nullable(new byte[]
		{
			1,
			2,
			1
		})] Action<UPrimitiveComponent, FKey> Callback)
		{
			if (FComponentOnClickedSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FComponentOnClickedSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FComponentOnClickedSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FComponentOnClickedSignature.OnScriptCallback));
				}
				FComponentOnClickedSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FComponentOnClickedSignature.RegisterId);
		}

		// Token: 0x06002039 RID: 8249 RVA: 0x0002F324 File Offset: 0x0002D524
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			1
		})] Action<UPrimitiveComponent, FKey> Callback)
		{
			FName delegateName = this.DelegateName;
			base.Remove(delegateName, Callback);
		}

		// Token: 0x0600203A RID: 8250 RVA: 0x0002F344 File Offset: 0x0002D544
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(UPrimitiveComponent TouchedComponent, FKey ButtonPressed)
		{
			FComponentOnClickedSignature.__FComponentOnClickedSignature_DelegateParams* ptr = stackalloc FComponentOnClickedSignature.__FComponentOnClickedSignature_DelegateParams[(UIntPtr)55] + 15L / (long)sizeof(FComponentOnClickedSignature.__FComponentOnClickedSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FComponentOnClickedSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->TouchedComponent = ((TouchedComponent != null) ? TouchedComponent.NativePtr : IntPtr.Zero);
			if (ButtonPressed != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->ButtonPressed, ButtonPressed.NativePtr, 1, false);
			}
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FComponentOnClickedSignature._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600203B RID: 8251 RVA: 0x0002F3D4 File Offset: 0x0002D5D4
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UPrimitiveComponent, FKey> action = target as Action<UPrimitiveComponent, FKey>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UPrimitiveComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UPrimitiveComponent>(((FComponentOnClickedSignature.__FComponentOnClickedSignature_DelegateParams*)__Parameters)->TouchedComponent);
			FKey arg = new FKey(&((FComponentOnClickedSignature.__FComponentOnClickedSignature_DelegateParams*)__Parameters)->ButtonPressed, true, true);
			action(orCreateUObjectByNativePointer, arg);
		}

		// Token: 0x04000AB5 RID: 2741
		internal static IntPtr _FunctionPtr;

		// Token: 0x04000AB6 RID: 2742
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ComponentOnClickedSignature__DelegateSignature";

		// Token: 0x04000AB7 RID: 2743
		private static int RegisterId;

		// Token: 0x0200098F RID: 2447
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		private ref struct __FComponentOnClickedSignature_DelegateParams
		{
			// Token: 0x040058F0 RID: 22768
			[FieldOffset(0)]
			public IntPtr TouchedComponent;

			// Token: 0x040058F1 RID: 22769
			[FieldOffset(8)]
			public byte ButtonPressed;
		}

		// Token: 0x02000990 RID: 2448
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040058F2 RID: 22770
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
