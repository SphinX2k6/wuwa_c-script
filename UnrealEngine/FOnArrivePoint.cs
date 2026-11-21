using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200034E RID: 846
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnArrivePoint : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060056BF RID: 22207 RVA: 0x0007A387 File Offset: 0x00078587
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnArrivePoint.StaticFunctionPtr();
		}

		// Token: 0x060056C0 RID: 22208 RVA: 0x0007A393 File Offset: 0x00078593
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnArrivePoint._FunctionPtr == IntPtr.Zero)
			{
				FOnArrivePoint._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroComponent.OnArrivePoint__DelegateSignature");
			}
			return FOnArrivePoint._FunctionPtr;
		}

		// Token: 0x060056C1 RID: 22209 RVA: 0x0007A3B6 File Offset: 0x000785B6
		public FOnArrivePoint()
		{
		}

		// Token: 0x060056C2 RID: 22210 RVA: 0x0007A3BE File Offset: 0x000785BE
		[NullableContext(2)]
		public FOnArrivePoint(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060056C3 RID: 22211 RVA: 0x0007A3C8 File Offset: 0x000785C8
		public FOnArrivePoint(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060056C4 RID: 22212 RVA: 0x0007A3D3 File Offset: 0x000785D3
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060056C5 RID: 22213 RVA: 0x0007A405 File Offset: 0x00078605
		[NullableContext(1)]
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

		// Token: 0x060056C6 RID: 22214 RVA: 0x0007A43F File Offset: 0x0007863F
		[NullableContext(1)]
		public void Remove(Action<int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060056C7 RID: 22215 RVA: 0x0007A448 File Offset: 0x00078648
		[SkipLocalsInit]
		public unsafe void Broadcast(int Index)
		{
			FOnArrivePoint.__FOnArrivePoint_DelegateParams* ptr = stackalloc FOnArrivePoint.__FOnArrivePoint_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FOnArrivePoint.__FOnArrivePoint_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnArrivePoint.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Index = Index;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060056C8 RID: 22216 RVA: 0x0007A484 File Offset: 0x00078684
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnArrivePoint.__FOnArrivePoint_DelegateParams*)__Parameters)->Index);
		}

		// Token: 0x040023B3 RID: 9139
		internal static IntPtr _FunctionPtr;

		// Token: 0x040023B4 RID: 9140
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComponent.OnArrivePoint__DelegateSignature";

		// Token: 0x040023B5 RID: 9141
		private static int RegisterId;

		// Token: 0x02000A5F RID: 2655
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __FOnArrivePoint_DelegateParams
		{
			// Token: 0x04005A79 RID: 23161
			[FieldOffset(0)]
			public int Index;
		}

		// Token: 0x02000A60 RID: 2656
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005A7A RID: 23162
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
