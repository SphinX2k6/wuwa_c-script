using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000839 RID: 2105
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSpineAnimationDisposeDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600B79A RID: 47002 RVA: 0x00126431 File Offset: 0x00124631
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSpineAnimationDisposeDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600B79B RID: 47003 RVA: 0x0012643D File Offset: 0x0012463D
		private static IntPtr StaticFunctionPtr()
		{
			if (FSpineAnimationDisposeDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSpineAnimationDisposeDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SpinePlugin.SpineAnimationDisposeDelegate__DelegateSignature");
			}
			return FSpineAnimationDisposeDelegate._FunctionPtr;
		}

		// Token: 0x0600B79C RID: 47004 RVA: 0x00126460 File Offset: 0x00124660
		public FSpineAnimationDisposeDelegate()
		{
		}

		// Token: 0x0600B79D RID: 47005 RVA: 0x00126468 File Offset: 0x00124668
		[NullableContext(2)]
		public FSpineAnimationDisposeDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B79E RID: 47006 RVA: 0x00126472 File Offset: 0x00124672
		public FSpineAnimationDisposeDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B79F RID: 47007 RVA: 0x0012647D File Offset: 0x0012467D
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UTrackEntry>) ?? ((Action<UTrackEntry>)Delegate.CreateDelegate(typeof(Action<UTrackEntry>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600B7A0 RID: 47008 RVA: 0x001264AF File Offset: 0x001246AF
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

		// Token: 0x0600B7A1 RID: 47009 RVA: 0x001264E9 File Offset: 0x001246E9
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UTrackEntry> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600B7A2 RID: 47010 RVA: 0x001264F4 File Offset: 0x001246F4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(UTrackEntry entry)
		{
			FSpineAnimationDisposeDelegate.__FSpineAnimationDisposeDelegate_DelegateParams* ptr = stackalloc FSpineAnimationDisposeDelegate.__FSpineAnimationDisposeDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FSpineAnimationDisposeDelegate.__FSpineAnimationDisposeDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSpineAnimationDisposeDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->entry = ((entry != null) ? entry.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600B7A3 RID: 47011 RVA: 0x00126540 File Offset: 0x00124740
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04005371 RID: 21361
		internal static IntPtr _FunctionPtr;

		// Token: 0x04005372 RID: 21362
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SpinePlugin.SpineAnimationDisposeDelegate__DelegateSignature";

		// Token: 0x04005373 RID: 21363
		private static int RegisterId;

		// Token: 0x020013CE RID: 5070
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FSpineAnimationDisposeDelegate_DelegateParams
		{
			// Token: 0x04006839 RID: 26681
			[FieldOffset(0)]
			public IntPtr entry;
		}

		// Token: 0x020013CF RID: 5071
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400683A RID: 26682
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
