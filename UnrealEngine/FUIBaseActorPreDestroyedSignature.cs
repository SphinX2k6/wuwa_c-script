using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200212D RID: 8493
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FUIBaseActorPreDestroyedSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601FF5E RID: 130910 RVA: 0x002F87D9 File Offset: 0x002F69D9
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FUIBaseActorPreDestroyedSignature.StaticFunctionPtr();
		}

		// Token: 0x0601FF5F RID: 130911 RVA: 0x002F87E5 File Offset: 0x002F69E5
		private static IntPtr StaticFunctionPtr()
		{
			if (FUIBaseActorPreDestroyedSignature._FunctionPtr == IntPtr.Zero)
			{
				FUIBaseActorPreDestroyedSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.UIBaseActorPreDestroyedSignature__DelegateSignature");
			}
			return FUIBaseActorPreDestroyedSignature._FunctionPtr;
		}

		// Token: 0x17007D96 RID: 32150
		// (get) Token: 0x0601FF60 RID: 130912 RVA: 0x002F8808 File Offset: 0x002F6A08
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnPreDestroyed;
			}
		}

		// Token: 0x0601FF61 RID: 130913 RVA: 0x002F880F File Offset: 0x002F6A0F
		[NullableContext(2)]
		public FUIBaseActorPreDestroyedSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FF62 RID: 130914 RVA: 0x002F8819 File Offset: 0x002F6A19
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<AActor>) ?? ((Action<AActor>)Delegate.CreateDelegate(typeof(Action<AActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601FF63 RID: 130915 RVA: 0x002F884C File Offset: 0x002F6A4C
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<AActor> Callback)
		{
			if (FUIBaseActorPreDestroyedSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FUIBaseActorPreDestroyedSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FUIBaseActorPreDestroyedSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FUIBaseActorPreDestroyedSignature.OnScriptCallback));
				}
				FUIBaseActorPreDestroyedSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FUIBaseActorPreDestroyedSignature.RegisterId);
		}

		// Token: 0x0601FF64 RID: 130916 RVA: 0x002F889C File Offset: 0x002F6A9C
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<AActor> Callback)
		{
			FName delegateName = this.DelegateName;
			base.Remove(delegateName, Callback);
		}

		// Token: 0x0601FF65 RID: 130917 RVA: 0x002F88BC File Offset: 0x002F6ABC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(AActor DestroyedActor)
		{
			FUIBaseActorPreDestroyedSignature.__FUIBaseActorPreDestroyedSignature_DelegateParams* ptr = stackalloc FUIBaseActorPreDestroyedSignature.__FUIBaseActorPreDestroyedSignature_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FUIBaseActorPreDestroyedSignature.__FUIBaseActorPreDestroyedSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FUIBaseActorPreDestroyedSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->DestroyedActor = ((DestroyedActor != null) ? DestroyedActor.NativePtr : IntPtr.Zero);
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x0601FF66 RID: 130918 RVA: 0x002F8918 File Offset: 0x002F6B18
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<AActor> action = target as Action<AActor>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FUIBaseActorPreDestroyedSignature.__FUIBaseActorPreDestroyedSignature_DelegateParams*)__Parameters)->DestroyedActor);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04011361 RID: 70497
		internal static IntPtr _FunctionPtr;

		// Token: 0x04011362 RID: 70498
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.UIBaseActorPreDestroyedSignature__DelegateSignature";

		// Token: 0x04011363 RID: 70499
		private static int RegisterId;

		// Token: 0x020034ED RID: 13549
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FUIBaseActorPreDestroyedSignature_DelegateParams
		{
			// Token: 0x0401750D RID: 95501
			[FieldOffset(0)]
			public IntPtr DestroyedActor;
		}

		// Token: 0x020034EE RID: 13550
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401750E RID: 95502
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
