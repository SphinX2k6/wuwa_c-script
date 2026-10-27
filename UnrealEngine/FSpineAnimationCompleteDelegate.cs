using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028A4 RID: 10404
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSpineAnimationCompleteDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06026952 RID: 158034 RVA: 0x003ADE79 File Offset: 0x003AC079
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSpineAnimationCompleteDelegate.StaticFunctionPtr();
		}

		// Token: 0x06026953 RID: 158035 RVA: 0x003ADE85 File Offset: 0x003AC085
		private static IntPtr StaticFunctionPtr()
		{
			if (FSpineAnimationCompleteDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSpineAnimationCompleteDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SpinePlugin.SpineAnimationCompleteDelegate__DelegateSignature");
			}
			return FSpineAnimationCompleteDelegate._FunctionPtr;
		}

		// Token: 0x06026954 RID: 158036 RVA: 0x003ADEA8 File Offset: 0x003AC0A8
		public FSpineAnimationCompleteDelegate()
		{
		}

		// Token: 0x06026955 RID: 158037 RVA: 0x003ADEB0 File Offset: 0x003AC0B0
		[NullableContext(2)]
		public FSpineAnimationCompleteDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026956 RID: 158038 RVA: 0x003ADEBA File Offset: 0x003AC0BA
		public FSpineAnimationCompleteDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026957 RID: 158039 RVA: 0x003ADEC5 File Offset: 0x003AC0C5
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UTrackEntry>) ?? ((Action<UTrackEntry>)Delegate.CreateDelegate(typeof(Action<UTrackEntry>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06026958 RID: 158040 RVA: 0x003ADEF7 File Offset: 0x003AC0F7
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UTrackEntry> Callback)
		{
			if (FSpineAnimationCompleteDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSpineAnimationCompleteDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSpineAnimationCompleteDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSpineAnimationCompleteDelegate.OnScriptCallback));
				}
				FSpineAnimationCompleteDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSpineAnimationCompleteDelegate.RegisterId);
		}

		// Token: 0x06026959 RID: 158041 RVA: 0x003ADF31 File Offset: 0x003AC131
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UTrackEntry> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0602695A RID: 158042 RVA: 0x003ADF3C File Offset: 0x003AC13C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UTrackEntry entry)
		{
			FSpineAnimationCompleteDelegate.__FSpineAnimationCompleteDelegate_DelegateParams* ptr = stackalloc FSpineAnimationCompleteDelegate.__FSpineAnimationCompleteDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FSpineAnimationCompleteDelegate.__FSpineAnimationCompleteDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSpineAnimationCompleteDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->entry = ((entry != null) ? entry.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0602695B RID: 158043 RVA: 0x003ADF88 File Offset: 0x003AC188
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
			UTrackEntry orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UTrackEntry>(((FSpineAnimationCompleteDelegate.__FSpineAnimationCompleteDelegate_DelegateParams*)__Parameters)->entry);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04015321 RID: 86817
		internal static IntPtr _FunctionPtr;

		// Token: 0x04015322 RID: 86818
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SpinePlugin.SpineAnimationCompleteDelegate__DelegateSignature";

		// Token: 0x04015323 RID: 86819
		private static int RegisterId;

		// Token: 0x02003B3A RID: 15162
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FSpineAnimationCompleteDelegate_DelegateParams
		{
			// Token: 0x04017CDE RID: 97502
			[FieldOffset(0)]
			public IntPtr entry;
		}

		// Token: 0x02003B3B RID: 15163
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017CDF RID: 97503
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
