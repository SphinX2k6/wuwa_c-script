using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000517 RID: 1303
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnArcRopeInitialized : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060079D6 RID: 31190 RVA: 0x000B2BA4 File Offset: 0x000B0DA4
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnArcRopeInitialized.StaticFunctionPtr();
		}

		// Token: 0x060079D7 RID: 31191 RVA: 0x000B2BB0 File Offset: 0x000B0DB0
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnArcRopeInitialized._FunctionPtr == IntPtr.Zero)
			{
				FOnArcRopeInitialized._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRopeEffect.OnArcRopeInitialized__DelegateSignature");
			}
			return FOnArcRopeInitialized._FunctionPtr;
		}

		// Token: 0x060079D8 RID: 31192 RVA: 0x000B2BD3 File Offset: 0x000B0DD3
		public FOnArcRopeInitialized()
		{
		}

		// Token: 0x060079D9 RID: 31193 RVA: 0x000B2BDB File Offset: 0x000B0DDB
		[NullableContext(2)]
		public FOnArcRopeInitialized(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060079DA RID: 31194 RVA: 0x000B2BE5 File Offset: 0x000B0DE5
		public FOnArcRopeInitialized(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060079DB RID: 31195 RVA: 0x000B2BF0 File Offset: 0x000B0DF0
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x060079DC RID: 31196 RVA: 0x000B2C22 File Offset: 0x000B0E22
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (FOnArcRopeInitialized.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnArcRopeInitialized.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnArcRopeInitialized.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnArcRopeInitialized.OnScriptCallback));
				}
				FOnArcRopeInitialized.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnArcRopeInitialized.RegisterId);
		}

		// Token: 0x060079DD RID: 31197 RVA: 0x000B2C5C File Offset: 0x000B0E5C
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060079DE RID: 31198 RVA: 0x000B2C65 File Offset: 0x000B0E65
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x060079DF RID: 31199 RVA: 0x000B2C70 File Offset: 0x000B0E70
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action action = target as Action;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action();
		}

		// Token: 0x040033C3 RID: 13251
		internal static IntPtr _FunctionPtr;

		// Token: 0x040033C4 RID: 13252
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRopeEffect.OnArcRopeInitialized__DelegateSignature";

		// Token: 0x040033C5 RID: 13253
		private static int RegisterId;

		// Token: 0x02000C80 RID: 3200
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005EE2 RID: 24290
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
