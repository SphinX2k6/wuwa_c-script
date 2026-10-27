using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029A9 RID: 10665
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnListEntryGeneratedDynamic : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06027724 RID: 161572 RVA: 0x003C2BB8 File Offset: 0x003C0DB8
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnListEntryGeneratedDynamic.StaticFunctionPtr();
		}

		// Token: 0x06027725 RID: 161573 RVA: 0x003C2BC4 File Offset: 0x003C0DC4
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnListEntryGeneratedDynamic._FunctionPtr == IntPtr.Zero)
			{
				FOnListEntryGeneratedDynamic._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.OnListEntryGeneratedDynamic__DelegateSignature");
			}
			return FOnListEntryGeneratedDynamic._FunctionPtr;
		}

		// Token: 0x06027726 RID: 161574 RVA: 0x003C2BE7 File Offset: 0x003C0DE7
		public FOnListEntryGeneratedDynamic()
		{
		}

		// Token: 0x06027727 RID: 161575 RVA: 0x003C2BEF File Offset: 0x003C0DEF
		[NullableContext(2)]
		public FOnListEntryGeneratedDynamic(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06027728 RID: 161576 RVA: 0x003C2BF9 File Offset: 0x003C0DF9
		public FOnListEntryGeneratedDynamic(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06027729 RID: 161577 RVA: 0x003C2C04 File Offset: 0x003C0E04
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UUserWidget>) ?? ((Action<UUserWidget>)Delegate.CreateDelegate(typeof(Action<UUserWidget>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0602772A RID: 161578 RVA: 0x003C2C36 File Offset: 0x003C0E36
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UUserWidget> Callback)
		{
			if (FOnListEntryGeneratedDynamic.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnListEntryGeneratedDynamic.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnListEntryGeneratedDynamic.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnListEntryGeneratedDynamic.OnScriptCallback));
				}
				FOnListEntryGeneratedDynamic.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnListEntryGeneratedDynamic.RegisterId);
		}

		// Token: 0x0602772B RID: 161579 RVA: 0x003C2C70 File Offset: 0x003C0E70
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UUserWidget> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0602772C RID: 161580 RVA: 0x003C2C7C File Offset: 0x003C0E7C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UUserWidget Widget)
		{
			FOnListEntryGeneratedDynamic.__FOnListEntryGeneratedDynamic_DelegateParams* ptr = stackalloc FOnListEntryGeneratedDynamic.__FOnListEntryGeneratedDynamic_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnListEntryGeneratedDynamic.__FOnListEntryGeneratedDynamic_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnListEntryGeneratedDynamic.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Widget = ((Widget != null) ? Widget.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0602772D RID: 161581 RVA: 0x003C2CC8 File Offset: 0x003C0EC8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UUserWidget> action = target as Action<UUserWidget>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UUserWidget orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UUserWidget>(((FOnListEntryGeneratedDynamic.__FOnListEntryGeneratedDynamic_DelegateParams*)__Parameters)->Widget);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04015A59 RID: 88665
		internal static IntPtr _FunctionPtr;

		// Token: 0x04015A5A RID: 88666
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.OnListEntryGeneratedDynamic__DelegateSignature";

		// Token: 0x04015A5B RID: 88667
		private static int RegisterId;

		// Token: 0x02003BA9 RID: 15273
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FOnListEntryGeneratedDynamic_DelegateParams
		{
			// Token: 0x04017D89 RID: 97673
			[FieldOffset(0)]
			public IntPtr Widget;
		}

		// Token: 0x02003BAA RID: 15274
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017D8A RID: 97674
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
