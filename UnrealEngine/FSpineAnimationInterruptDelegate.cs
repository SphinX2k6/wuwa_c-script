using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200083B RID: 2107
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSpineAnimationInterruptDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600B7AE RID: 47022 RVA: 0x001266F1 File Offset: 0x001248F1
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSpineAnimationInterruptDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600B7AF RID: 47023 RVA: 0x001266FD File Offset: 0x001248FD
		private static IntPtr StaticFunctionPtr()
		{
			if (FSpineAnimationInterruptDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSpineAnimationInterruptDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SpinePlugin.SpineAnimationInterruptDelegate__DelegateSignature");
			}
			return FSpineAnimationInterruptDelegate._FunctionPtr;
		}

		// Token: 0x0600B7B0 RID: 47024 RVA: 0x00126720 File Offset: 0x00124920
		public FSpineAnimationInterruptDelegate()
		{
		}

		// Token: 0x0600B7B1 RID: 47025 RVA: 0x00126728 File Offset: 0x00124928
		[NullableContext(2)]
		public FSpineAnimationInterruptDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B7B2 RID: 47026 RVA: 0x00126732 File Offset: 0x00124932
		public FSpineAnimationInterruptDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B7B3 RID: 47027 RVA: 0x0012673D File Offset: 0x0012493D
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UTrackEntry>) ?? ((Action<UTrackEntry>)Delegate.CreateDelegate(typeof(Action<UTrackEntry>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600B7B4 RID: 47028 RVA: 0x0012676F File Offset: 0x0012496F
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

		// Token: 0x0600B7B5 RID: 47029 RVA: 0x001267A9 File Offset: 0x001249A9
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UTrackEntry> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600B7B6 RID: 47030 RVA: 0x001267B4 File Offset: 0x001249B4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(UTrackEntry entry)
		{
			FSpineAnimationInterruptDelegate.__FSpineAnimationInterruptDelegate_DelegateParams* ptr = stackalloc FSpineAnimationInterruptDelegate.__FSpineAnimationInterruptDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FSpineAnimationInterruptDelegate.__FSpineAnimationInterruptDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSpineAnimationInterruptDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->entry = ((entry != null) ? entry.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600B7B7 RID: 47031 RVA: 0x00126800 File Offset: 0x00124A00
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04005377 RID: 21367
		internal static IntPtr _FunctionPtr;

		// Token: 0x04005378 RID: 21368
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SpinePlugin.SpineAnimationInterruptDelegate__DelegateSignature";

		// Token: 0x04005379 RID: 21369
		private static int RegisterId;

		// Token: 0x020013D2 RID: 5074
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FSpineAnimationInterruptDelegate_DelegateParams
		{
			// Token: 0x0400683D RID: 26685
			[FieldOffset(0)]
			public IntPtr entry;
		}

		// Token: 0x020013D3 RID: 5075
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400683E RID: 26686
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
