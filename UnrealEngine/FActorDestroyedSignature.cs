using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007BF RID: 1983
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FActorDestroyedSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006A05 RID: 27141 RVA: 0x000983CA File Offset: 0x000965CA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FActorDestroyedSignature.StaticFunctionPtr();
		}

		// Token: 0x06006A06 RID: 27142 RVA: 0x000983D6 File Offset: 0x000965D6
		private static IntPtr StaticFunctionPtr()
		{
			if (FActorDestroyedSignature._FunctionPtr == IntPtr.Zero)
			{
				FActorDestroyedSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ActorDestroyedSignature__DelegateSignature");
			}
			return FActorDestroyedSignature._FunctionPtr;
		}

		// Token: 0x17001911 RID: 6417
		// (get) Token: 0x06006A07 RID: 27143 RVA: 0x000983F9 File Offset: 0x000965F9
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnDestroyed;
			}
		}

		// Token: 0x06006A08 RID: 27144 RVA: 0x00098400 File Offset: 0x00096600
		[NullableContext(2)]
		public FActorDestroyedSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006A09 RID: 27145 RVA: 0x0009840A File Offset: 0x0009660A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<AActor>) ?? ((Action<AActor>)Delegate.CreateDelegate(typeof(Action<AActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006A0A RID: 27146 RVA: 0x0009843C File Offset: 0x0009663C
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<AActor> Callback)
		{
			if (FActorDestroyedSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FActorDestroyedSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FActorDestroyedSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FActorDestroyedSignature.OnScriptCallback));
				}
				FActorDestroyedSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FActorDestroyedSignature.RegisterId);
		}

		// Token: 0x06006A0B RID: 27147 RVA: 0x0009848C File Offset: 0x0009668C
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

		// Token: 0x06006A0C RID: 27148 RVA: 0x000984AC File Offset: 0x000966AC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(AActor DestroyedActor)
		{
			FActorDestroyedSignature.__FActorDestroyedSignature_DelegateParams* ptr = stackalloc FActorDestroyedSignature.__FActorDestroyedSignature_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FActorDestroyedSignature.__FActorDestroyedSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FActorDestroyedSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->DestroyedActor = ((DestroyedActor != null) ? DestroyedActor.NativePtr : IntPtr.Zero);
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x06006A0D RID: 27149 RVA: 0x00098508 File Offset: 0x00096708
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
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FActorDestroyedSignature.__FActorDestroyedSignature_DelegateParams*)__Parameters)->DestroyedActor);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x0400331C RID: 13084
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400331D RID: 13085
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ActorDestroyedSignature__DelegateSignature";

		// Token: 0x0400331E RID: 13086
		private static int RegisterId;

		// Token: 0x02002C6D RID: 11373
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FActorDestroyedSignature_DelegateParams
		{
			// Token: 0x0401659C RID: 91548
			[FieldOffset(0)]
			public IntPtr DestroyedActor;
		}

		// Token: 0x02002C6E RID: 11374
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401659D RID: 91549
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
