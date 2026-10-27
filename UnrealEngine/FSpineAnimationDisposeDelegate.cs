using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028A5 RID: 10405
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSpineAnimationDisposeDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0602695C RID: 158044 RVA: 0x003ADFD9 File Offset: 0x003AC1D9
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSpineAnimationDisposeDelegate.StaticFunctionPtr();
		}

		// Token: 0x0602695D RID: 158045 RVA: 0x003ADFE5 File Offset: 0x003AC1E5
		private static IntPtr StaticFunctionPtr()
		{
			if (FSpineAnimationDisposeDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSpineAnimationDisposeDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SpinePlugin.SpineAnimationDisposeDelegate__DelegateSignature");
			}
			return FSpineAnimationDisposeDelegate._FunctionPtr;
		}

		// Token: 0x0602695E RID: 158046 RVA: 0x003AE008 File Offset: 0x003AC208
		public FSpineAnimationDisposeDelegate()
		{
		}

		// Token: 0x0602695F RID: 158047 RVA: 0x003AE010 File Offset: 0x003AC210
		[NullableContext(2)]
		public FSpineAnimationDisposeDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026960 RID: 158048 RVA: 0x003AE01A File Offset: 0x003AC21A
		public FSpineAnimationDisposeDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026961 RID: 158049 RVA: 0x003AE025 File Offset: 0x003AC225
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UTrackEntry>) ?? ((Action<UTrackEntry>)Delegate.CreateDelegate(typeof(Action<UTrackEntry>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06026962 RID: 158050 RVA: 0x003AE057 File Offset: 0x003AC257
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UTrackEntry> Callback)
		{
			if (FSpineAnimationDisposeDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSpineAnimationDisposeDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSpineAnimationDisposeDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSpineAnimationDisposeDelegate.OnScriptCallback));
				}
				FSpineAnimationDisposeDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSpineAnimationDisposeDelegate.RegisterId);
		}

		// Token: 0x06026963 RID: 158051 RVA: 0x003AE091 File Offset: 0x003AC291
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UTrackEntry> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06026964 RID: 158052 RVA: 0x003AE09C File Offset: 0x003AC29C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UTrackEntry entry)
		{
			FSpineAnimationDisposeDelegate.__FSpineAnimationDisposeDelegate_DelegateParams* ptr = stackalloc FSpineAnimationDisposeDelegate.__FSpineAnimationDisposeDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FSpineAnimationDisposeDelegate.__FSpineAnimationDisposeDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSpineAnimationDisposeDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->entry = ((entry != null) ? entry.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06026965 RID: 158053 RVA: 0x003AE0E8 File Offset: 0x003AC2E8
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
			UTrackEntry orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UTrackEntry>(((FSpineAnimationDisposeDelegate.__FSpineAnimationDisposeDelegate_DelegateParams*)__Parameters)->entry);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04015324 RID: 86820
		internal static IntPtr _FunctionPtr;

		// Token: 0x04015325 RID: 86821
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SpinePlugin.SpineAnimationDisposeDelegate__DelegateSignature";

		// Token: 0x04015326 RID: 86822
		private static int RegisterId;

		// Token: 0x02003B3C RID: 15164
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FSpineAnimationDisposeDelegate_DelegateParams
		{
			// Token: 0x04017CE0 RID: 97504
			[FieldOffset(0)]
			public IntPtr entry;
		}

		// Token: 0x02003B3D RID: 15165
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017CE1 RID: 97505
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
