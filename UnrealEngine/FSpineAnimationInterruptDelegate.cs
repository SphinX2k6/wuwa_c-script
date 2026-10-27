using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028A8 RID: 10408
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSpineAnimationInterruptDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0602697A RID: 158074 RVA: 0x003AE43E File Offset: 0x003AC63E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSpineAnimationInterruptDelegate.StaticFunctionPtr();
		}

		// Token: 0x0602697B RID: 158075 RVA: 0x003AE44A File Offset: 0x003AC64A
		private static IntPtr StaticFunctionPtr()
		{
			if (FSpineAnimationInterruptDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSpineAnimationInterruptDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SpinePlugin.SpineAnimationInterruptDelegate__DelegateSignature");
			}
			return FSpineAnimationInterruptDelegate._FunctionPtr;
		}

		// Token: 0x0602697C RID: 158076 RVA: 0x003AE46D File Offset: 0x003AC66D
		public FSpineAnimationInterruptDelegate()
		{
		}

		// Token: 0x0602697D RID: 158077 RVA: 0x003AE475 File Offset: 0x003AC675
		[NullableContext(2)]
		public FSpineAnimationInterruptDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602697E RID: 158078 RVA: 0x003AE47F File Offset: 0x003AC67F
		public FSpineAnimationInterruptDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602697F RID: 158079 RVA: 0x003AE48A File Offset: 0x003AC68A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UTrackEntry>) ?? ((Action<UTrackEntry>)Delegate.CreateDelegate(typeof(Action<UTrackEntry>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06026980 RID: 158080 RVA: 0x003AE4BC File Offset: 0x003AC6BC
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UTrackEntry> Callback)
		{
			if (FSpineAnimationInterruptDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSpineAnimationInterruptDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSpineAnimationInterruptDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSpineAnimationInterruptDelegate.OnScriptCallback));
				}
				FSpineAnimationInterruptDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSpineAnimationInterruptDelegate.RegisterId);
		}

		// Token: 0x06026981 RID: 158081 RVA: 0x003AE4F6 File Offset: 0x003AC6F6
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UTrackEntry> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06026982 RID: 158082 RVA: 0x003AE500 File Offset: 0x003AC700
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UTrackEntry entry)
		{
			FSpineAnimationInterruptDelegate.__FSpineAnimationInterruptDelegate_DelegateParams* ptr = stackalloc FSpineAnimationInterruptDelegate.__FSpineAnimationInterruptDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FSpineAnimationInterruptDelegate.__FSpineAnimationInterruptDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSpineAnimationInterruptDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->entry = ((entry != null) ? entry.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06026983 RID: 158083 RVA: 0x003AE54C File Offset: 0x003AC74C
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
			UTrackEntry orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UTrackEntry>(((FSpineAnimationInterruptDelegate.__FSpineAnimationInterruptDelegate_DelegateParams*)__Parameters)->entry);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x0401532D RID: 86829
		internal static IntPtr _FunctionPtr;

		// Token: 0x0401532E RID: 86830
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SpinePlugin.SpineAnimationInterruptDelegate__DelegateSignature";

		// Token: 0x0401532F RID: 86831
		private static int RegisterId;

		// Token: 0x02003B42 RID: 15170
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FSpineAnimationInterruptDelegate_DelegateParams
		{
			// Token: 0x04017CE7 RID: 97511
			[FieldOffset(0)]
			public IntPtr entry;
		}

		// Token: 0x02003B43 RID: 15171
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017CE8 RID: 97512
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
