using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000838 RID: 2104
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSpineAnimationCompleteDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600B790 RID: 46992 RVA: 0x001262D1 File Offset: 0x001244D1
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSpineAnimationCompleteDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600B791 RID: 46993 RVA: 0x001262DD File Offset: 0x001244DD
		private static IntPtr StaticFunctionPtr()
		{
			if (FSpineAnimationCompleteDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSpineAnimationCompleteDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SpinePlugin.SpineAnimationCompleteDelegate__DelegateSignature");
			}
			return FSpineAnimationCompleteDelegate._FunctionPtr;
		}

		// Token: 0x0600B792 RID: 46994 RVA: 0x00126300 File Offset: 0x00124500
		public FSpineAnimationCompleteDelegate()
		{
		}

		// Token: 0x0600B793 RID: 46995 RVA: 0x00126308 File Offset: 0x00124508
		[NullableContext(2)]
		public FSpineAnimationCompleteDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B794 RID: 46996 RVA: 0x00126312 File Offset: 0x00124512
		public FSpineAnimationCompleteDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B795 RID: 46997 RVA: 0x0012631D File Offset: 0x0012451D
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UTrackEntry>) ?? ((Action<UTrackEntry>)Delegate.CreateDelegate(typeof(Action<UTrackEntry>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600B796 RID: 46998 RVA: 0x0012634F File Offset: 0x0012454F
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

		// Token: 0x0600B797 RID: 46999 RVA: 0x00126389 File Offset: 0x00124589
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UTrackEntry> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600B798 RID: 47000 RVA: 0x00126394 File Offset: 0x00124594
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(UTrackEntry entry)
		{
			FSpineAnimationCompleteDelegate.__FSpineAnimationCompleteDelegate_DelegateParams* ptr = stackalloc FSpineAnimationCompleteDelegate.__FSpineAnimationCompleteDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FSpineAnimationCompleteDelegate.__FSpineAnimationCompleteDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSpineAnimationCompleteDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->entry = ((entry != null) ? entry.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600B799 RID: 47001 RVA: 0x001263E0 File Offset: 0x001245E0
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x0400536E RID: 21358
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400536F RID: 21359
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SpinePlugin.SpineAnimationCompleteDelegate__DelegateSignature";

		// Token: 0x04005370 RID: 21360
		private static int RegisterId;

		// Token: 0x020013CC RID: 5068
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FSpineAnimationCompleteDelegate_DelegateParams
		{
			// Token: 0x04006837 RID: 26679
			[FieldOffset(0)]
			public IntPtr entry;
		}

		// Token: 0x020013CD RID: 5069
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006838 RID: 26680
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
