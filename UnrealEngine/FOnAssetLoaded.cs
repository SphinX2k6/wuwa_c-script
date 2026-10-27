using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F02 RID: 3842
	public sealed class FOnAssetLoaded : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600D005 RID: 53253 RVA: 0x0012F7A6 File Offset: 0x0012D9A6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnAssetLoaded.StaticFunctionPtr();
		}

		// Token: 0x0600D006 RID: 53254 RVA: 0x0012F7B2 File Offset: 0x0012D9B2
		private static IntPtr StaticFunctionPtr()
		{
			if (UKismetSystemLibrary.__OnAssetLoaded__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UKismetSystemLibrary.__OnAssetLoaded__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.KismetSystemLibrary:OnAssetLoaded__DelegateSignature");
			}
			return UKismetSystemLibrary.__OnAssetLoaded__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0600D007 RID: 53255 RVA: 0x0012F7D5 File Offset: 0x0012D9D5
		public FOnAssetLoaded()
		{
		}

		// Token: 0x0600D008 RID: 53256 RVA: 0x0012F7DD File Offset: 0x0012D9DD
		[NullableContext(2)]
		public FOnAssetLoaded(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D009 RID: 53257 RVA: 0x0012F7E7 File Offset: 0x0012D9E7
		public FOnAssetLoaded(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D00A RID: 53258 RVA: 0x0012F7F2 File Offset: 0x0012D9F2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<UObject>) ?? ((Action<UObject>)Delegate.CreateDelegate(typeof(Action<UObject>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600D00B RID: 53259 RVA: 0x0012F824 File Offset: 0x0012DA24
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<UObject> Callback)
		{
			if (FOnAssetLoaded.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnAssetLoaded.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnAssetLoaded.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnAssetLoaded.OnScriptCallback));
				}
				FOnAssetLoaded.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnAssetLoaded.RegisterId);
		}

		// Token: 0x0600D00C RID: 53260 RVA: 0x0012F860 File Offset: 0x0012DA60
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(UObject Loaded)
		{
			FOnAssetLoaded.__FOnAssetLoaded_DelegateParams* ptr = stackalloc FOnAssetLoaded.__FOnAssetLoaded_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnAssetLoaded.__FOnAssetLoaded_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnAssetLoaded.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Loaded = ((Loaded != null) ? Loaded.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0600D00D RID: 53261 RVA: 0x0012F8AC File Offset: 0x0012DAAC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UObject> action = target as Action<UObject>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(((FOnAssetLoaded.__FOnAssetLoaded_DelegateParams*)__Parameters)->Loaded);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x0400701C RID: 28700
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.KismetSystemLibrary:OnAssetLoaded__DelegateSignature";

		// Token: 0x0400701D RID: 28701
		private static int RegisterId;

		// Token: 0x02002D54 RID: 11604
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FOnAssetLoaded_DelegateParams
		{
			// Token: 0x04016766 RID: 92006
			[FieldOffset(0)]
			public IntPtr Loaded;
		}

		// Token: 0x02002D55 RID: 11605
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016767 RID: 92007
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
