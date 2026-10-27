using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028A6 RID: 10406
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSpineAnimationEndDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06026966 RID: 158054 RVA: 0x003AE139 File Offset: 0x003AC339
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSpineAnimationEndDelegate.StaticFunctionPtr();
		}

		// Token: 0x06026967 RID: 158055 RVA: 0x003AE145 File Offset: 0x003AC345
		private static IntPtr StaticFunctionPtr()
		{
			if (FSpineAnimationEndDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSpineAnimationEndDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SpinePlugin.SpineAnimationEndDelegate__DelegateSignature");
			}
			return FSpineAnimationEndDelegate._FunctionPtr;
		}

		// Token: 0x06026968 RID: 158056 RVA: 0x003AE168 File Offset: 0x003AC368
		public FSpineAnimationEndDelegate()
		{
		}

		// Token: 0x06026969 RID: 158057 RVA: 0x003AE170 File Offset: 0x003AC370
		[NullableContext(2)]
		public FSpineAnimationEndDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602696A RID: 158058 RVA: 0x003AE17A File Offset: 0x003AC37A
		public FSpineAnimationEndDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602696B RID: 158059 RVA: 0x003AE185 File Offset: 0x003AC385
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UTrackEntry>) ?? ((Action<UTrackEntry>)Delegate.CreateDelegate(typeof(Action<UTrackEntry>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0602696C RID: 158060 RVA: 0x003AE1B7 File Offset: 0x003AC3B7
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UTrackEntry> Callback)
		{
			if (FSpineAnimationEndDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSpineAnimationEndDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSpineAnimationEndDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSpineAnimationEndDelegate.OnScriptCallback));
				}
				FSpineAnimationEndDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSpineAnimationEndDelegate.RegisterId);
		}

		// Token: 0x0602696D RID: 158061 RVA: 0x003AE1F1 File Offset: 0x003AC3F1
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UTrackEntry> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0602696E RID: 158062 RVA: 0x003AE1FC File Offset: 0x003AC3FC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UTrackEntry entry)
		{
			FSpineAnimationEndDelegate.__FSpineAnimationEndDelegate_DelegateParams* ptr = stackalloc FSpineAnimationEndDelegate.__FSpineAnimationEndDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FSpineAnimationEndDelegate.__FSpineAnimationEndDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSpineAnimationEndDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->entry = ((entry != null) ? entry.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0602696F RID: 158063 RVA: 0x003AE248 File Offset: 0x003AC448
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UTrackEntry> action = target as Action<UTrackEntry>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UTrackEntry orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UTrackEntry>(((FSpineAnimationEndDelegate.__FSpineAnimationEndDelegate_DelegateParams*)__Parameters)->entry);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04015327 RID: 86823
		internal static IntPtr _FunctionPtr;

		// Token: 0x04015328 RID: 86824
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SpinePlugin.SpineAnimationEndDelegate__DelegateSignature";

		// Token: 0x04015329 RID: 86825
		private static int RegisterId;

		// Token: 0x02003B3E RID: 15166
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FSpineAnimationEndDelegate_DelegateParams
		{
			// Token: 0x04017CE2 RID: 97506
			[FieldOffset(0)]
			public IntPtr entry;
		}

		// Token: 0x02003B3F RID: 15167
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017CE3 RID: 97507
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
