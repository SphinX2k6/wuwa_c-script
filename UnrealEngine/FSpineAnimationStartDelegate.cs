using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028A9 RID: 10409
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSpineAnimationStartDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06026984 RID: 158084 RVA: 0x003AE59D File Offset: 0x003AC79D
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSpineAnimationStartDelegate.StaticFunctionPtr();
		}

		// Token: 0x06026985 RID: 158085 RVA: 0x003AE5A9 File Offset: 0x003AC7A9
		private static IntPtr StaticFunctionPtr()
		{
			if (FSpineAnimationStartDelegate._FunctionPtr == IntPtr.Zero)
			{
				FSpineAnimationStartDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SpinePlugin.SpineAnimationStartDelegate__DelegateSignature");
			}
			return FSpineAnimationStartDelegate._FunctionPtr;
		}

		// Token: 0x06026986 RID: 158086 RVA: 0x003AE5CC File Offset: 0x003AC7CC
		public FSpineAnimationStartDelegate()
		{
		}

		// Token: 0x06026987 RID: 158087 RVA: 0x003AE5D4 File Offset: 0x003AC7D4
		[NullableContext(2)]
		public FSpineAnimationStartDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026988 RID: 158088 RVA: 0x003AE5DE File Offset: 0x003AC7DE
		public FSpineAnimationStartDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026989 RID: 158089 RVA: 0x003AE5E9 File Offset: 0x003AC7E9
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UTrackEntry>) ?? ((Action<UTrackEntry>)Delegate.CreateDelegate(typeof(Action<UTrackEntry>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0602698A RID: 158090 RVA: 0x003AE61B File Offset: 0x003AC81B
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UTrackEntry> Callback)
		{
			if (FSpineAnimationStartDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSpineAnimationStartDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSpineAnimationStartDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSpineAnimationStartDelegate.OnScriptCallback));
				}
				FSpineAnimationStartDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSpineAnimationStartDelegate.RegisterId);
		}

		// Token: 0x0602698B RID: 158091 RVA: 0x003AE655 File Offset: 0x003AC855
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UTrackEntry> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0602698C RID: 158092 RVA: 0x003AE660 File Offset: 0x003AC860
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UTrackEntry entry)
		{
			FSpineAnimationStartDelegate.__FSpineAnimationStartDelegate_DelegateParams* ptr = stackalloc FSpineAnimationStartDelegate.__FSpineAnimationStartDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FSpineAnimationStartDelegate.__FSpineAnimationStartDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSpineAnimationStartDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->entry = ((entry != null) ? entry.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0602698D RID: 158093 RVA: 0x003AE6AC File Offset: 0x003AC8AC
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
			UTrackEntry orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UTrackEntry>(((FSpineAnimationStartDelegate.__FSpineAnimationStartDelegate_DelegateParams*)__Parameters)->entry);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04015330 RID: 86832
		internal static IntPtr _FunctionPtr;

		// Token: 0x04015331 RID: 86833
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SpinePlugin.SpineAnimationStartDelegate__DelegateSignature";

		// Token: 0x04015332 RID: 86834
		private static int RegisterId;

		// Token: 0x02003B44 RID: 15172
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FSpineAnimationStartDelegate_DelegateParams
		{
			// Token: 0x04017CE9 RID: 97513
			[FieldOffset(0)]
			public IntPtr entry;
		}

		// Token: 0x02003B45 RID: 15173
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017CEA RID: 97514
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
