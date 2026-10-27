using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F2D RID: 3885
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnSystemFinished : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600D19E RID: 53662 RVA: 0x0013313F File Offset: 0x0013133F
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnSystemFinished.StaticFunctionPtr();
		}

		// Token: 0x0600D19F RID: 53663 RVA: 0x0013314B File Offset: 0x0013134B
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnSystemFinished._FunctionPtr == IntPtr.Zero)
			{
				FOnSystemFinished._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.OnSystemFinished__DelegateSignature");
			}
			return FOnSystemFinished._FunctionPtr;
		}

		// Token: 0x0600D1A0 RID: 53664 RVA: 0x0013316E File Offset: 0x0013136E
		public FOnSystemFinished()
		{
		}

		// Token: 0x0600D1A1 RID: 53665 RVA: 0x00133176 File Offset: 0x00131376
		[NullableContext(2)]
		public FOnSystemFinished(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D1A2 RID: 53666 RVA: 0x00133180 File Offset: 0x00131380
		public FOnSystemFinished(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D1A3 RID: 53667 RVA: 0x0013318B File Offset: 0x0013138B
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UParticleSystemComponent>) ?? ((Action<UParticleSystemComponent>)Delegate.CreateDelegate(typeof(Action<UParticleSystemComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600D1A4 RID: 53668 RVA: 0x001331BD File Offset: 0x001313BD
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UParticleSystemComponent> Callback)
		{
			if (FOnSystemFinished.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnSystemFinished.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnSystemFinished.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnSystemFinished.OnScriptCallback));
				}
				FOnSystemFinished.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnSystemFinished.RegisterId);
		}

		// Token: 0x0600D1A5 RID: 53669 RVA: 0x001331F7 File Offset: 0x001313F7
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UParticleSystemComponent> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600D1A6 RID: 53670 RVA: 0x00133200 File Offset: 0x00131400
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UParticleSystemComponent PSystem)
		{
			FOnSystemFinished.__FOnSystemFinished_DelegateParams* ptr = stackalloc FOnSystemFinished.__FOnSystemFinished_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnSystemFinished.__FOnSystemFinished_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnSystemFinished.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->PSystem = ((PSystem != null) ? PSystem.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600D1A7 RID: 53671 RVA: 0x0013324C File Offset: 0x0013144C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UParticleSystemComponent> action = target as Action<UParticleSystemComponent>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UParticleSystemComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UParticleSystemComponent>(((FOnSystemFinished.__FOnSystemFinished_DelegateParams*)__Parameters)->PSystem);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04007093 RID: 28819
		internal static IntPtr _FunctionPtr;

		// Token: 0x04007094 RID: 28820
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.OnSystemFinished__DelegateSignature";

		// Token: 0x04007095 RID: 28821
		private static int RegisterId;

		// Token: 0x02002DA7 RID: 11687
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FOnSystemFinished_DelegateParams
		{
			// Token: 0x040167CC RID: 92108
			[FieldOffset(0)]
			public IntPtr PSystem;
		}

		// Token: 0x02002DA8 RID: 11688
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040167CD RID: 92109
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
