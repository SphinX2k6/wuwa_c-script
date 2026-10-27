using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007C8 RID: 1992
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FActorOnInputTouchEndSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006A54 RID: 27220 RVA: 0x000991BF File Offset: 0x000973BF
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FActorOnInputTouchEndSignature.StaticFunctionPtr();
		}

		// Token: 0x06006A55 RID: 27221 RVA: 0x000991CB File Offset: 0x000973CB
		private static IntPtr StaticFunctionPtr()
		{
			if (FActorOnInputTouchEndSignature._FunctionPtr == IntPtr.Zero)
			{
				FActorOnInputTouchEndSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ActorOnInputTouchEndSignature__DelegateSignature");
			}
			return FActorOnInputTouchEndSignature._FunctionPtr;
		}

		// Token: 0x17001919 RID: 6425
		// (get) Token: 0x06006A56 RID: 27222 RVA: 0x000991EE File Offset: 0x000973EE
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnInputTouchEnd;
			}
		}

		// Token: 0x06006A57 RID: 27223 RVA: 0x000991F5 File Offset: 0x000973F5
		[NullableContext(2)]
		public FActorOnInputTouchEndSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006A58 RID: 27224 RVA: 0x000991FF File Offset: 0x000973FF
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<TEnumAsByte<ETouchIndex>, AActor>) ?? ((Action<TEnumAsByte<ETouchIndex>, AActor>)Delegate.CreateDelegate(typeof(Action<TEnumAsByte<ETouchIndex>, AActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006A59 RID: 27225 RVA: 0x00099234 File Offset: 0x00097434
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			0,
			2
		})] Action<TEnumAsByte<ETouchIndex>, AActor> Callback)
		{
			if (FActorOnInputTouchEndSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FActorOnInputTouchEndSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FActorOnInputTouchEndSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FActorOnInputTouchEndSignature.OnScriptCallback));
				}
				FActorOnInputTouchEndSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FActorOnInputTouchEndSignature.RegisterId);
		}

		// Token: 0x06006A5A RID: 27226 RVA: 0x00099284 File Offset: 0x00097484
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			0,
			2
		})] Action<TEnumAsByte<ETouchIndex>, AActor> Callback)
		{
			FName delegateName = this.DelegateName;
			base.Remove(delegateName, Callback);
		}

		// Token: 0x06006A5B RID: 27227 RVA: 0x000992A4 File Offset: 0x000974A4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(ETouchIndex FingerIndex, AActor TouchedActor)
		{
			FActorOnInputTouchEndSignature.__FActorOnInputTouchEndSignature_DelegateParams* ptr = stackalloc FActorOnInputTouchEndSignature.__FActorOnInputTouchEndSignature_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FActorOnInputTouchEndSignature.__FActorOnInputTouchEndSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FActorOnInputTouchEndSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->FingerIndex = FingerIndex;
			ptr->TouchedActor = ((TouchedActor != null) ? TouchedActor.NativePtr : IntPtr.Zero);
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x06006A5C RID: 27228 RVA: 0x0009930C File Offset: 0x0009750C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<TEnumAsByte<ETouchIndex>, AActor> action = target as Action<TEnumAsByte<ETouchIndex>, AActor>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FActorOnInputTouchEndSignature.__FActorOnInputTouchEndSignature_DelegateParams*)__Parameters)->TouchedActor);
			action(((FActorOnInputTouchEndSignature.__FActorOnInputTouchEndSignature_DelegateParams*)__Parameters)->FingerIndex, orCreateUObjectByNativePointer);
		}

		// Token: 0x04003336 RID: 13110
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003337 RID: 13111
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ActorOnInputTouchEndSignature__DelegateSignature";

		// Token: 0x04003338 RID: 13112
		private static int RegisterId;

		// Token: 0x02002C7D RID: 11389
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FActorOnInputTouchEndSignature_DelegateParams
		{
			// Token: 0x040165B4 RID: 91572
			[FieldOffset(0)]
			public TEnumAsByte<ETouchIndex> FingerIndex;

			// Token: 0x040165B5 RID: 91573
			[FieldOffset(8)]
			public IntPtr TouchedActor;
		}

		// Token: 0x02002C7E RID: 11390
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040165B6 RID: 91574
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
