using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001766 RID: 5990
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnArrivePoint : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060158C4 RID: 88260 RVA: 0x001FB3AA File Offset: 0x001F95AA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnArrivePoint.StaticFunctionPtr();
		}

		// Token: 0x060158C5 RID: 88261 RVA: 0x001FB3B6 File Offset: 0x001F95B6
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnArrivePoint._FunctionPtr == IntPtr.Zero)
			{
				FOnArrivePoint._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroComponent.OnArrivePoint__DelegateSignature");
			}
			return FOnArrivePoint._FunctionPtr;
		}

		// Token: 0x060158C6 RID: 88262 RVA: 0x001FB3D9 File Offset: 0x001F95D9
		public FOnArrivePoint()
		{
		}

		// Token: 0x060158C7 RID: 88263 RVA: 0x001FB3E1 File Offset: 0x001F95E1
		[NullableContext(2)]
		public FOnArrivePoint(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060158C8 RID: 88264 RVA: 0x001FB3EB File Offset: 0x001F95EB
		public FOnArrivePoint(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060158C9 RID: 88265 RVA: 0x001FB3F6 File Offset: 0x001F95F6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060158CA RID: 88266 RVA: 0x001FB428 File Offset: 0x001F9628
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<int> Callback)
		{
			if (FOnArrivePoint.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnArrivePoint.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnArrivePoint.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnArrivePoint.OnScriptCallback));
				}
				FOnArrivePoint.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnArrivePoint.RegisterId);
		}

		// Token: 0x060158CB RID: 88267 RVA: 0x001FB462 File Offset: 0x001F9662
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060158CC RID: 88268 RVA: 0x001FB46C File Offset: 0x001F966C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int Index)
		{
			FOnArrivePoint.__FOnArrivePoint_DelegateParams* ptr = stackalloc FOnArrivePoint.__FOnArrivePoint_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FOnArrivePoint.__FOnArrivePoint_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnArrivePoint.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Index = Index;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060158CD RID: 88269 RVA: 0x001FB4A8 File Offset: 0x001F96A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnArrivePoint.__FOnArrivePoint_DelegateParams*)__Parameters)->Index);
		}

		// Token: 0x0400BC2B RID: 48171
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400BC2C RID: 48172
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComponent.OnArrivePoint__DelegateSignature";

		// Token: 0x0400BC2D RID: 48173
		private static int RegisterId;

		// Token: 0x02002F2A RID: 12074
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FOnArrivePoint_DelegateParams
		{
			// Token: 0x04016AA5 RID: 92837
			[FieldOffset(0)]
			public int Index;
		}

		// Token: 0x02002F2B RID: 12075
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016AA6 RID: 92838
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
