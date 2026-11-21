using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006C2 RID: 1730
	public sealed class FLGUITextClickDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060093F7 RID: 37879 RVA: 0x000DF04E File Offset: 0x000DD24E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUITextClickDelegate.StaticFunctionPtr();
		}

		// Token: 0x060093F8 RID: 37880 RVA: 0x000DF05A File Offset: 0x000DD25A
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUITextClickDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUITextClickDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUITextClickDelegate__DelegateSignature");
			}
			return FLGUITextClickDelegate._FunctionPtr;
		}

		// Token: 0x060093F9 RID: 37881 RVA: 0x000DF07D File Offset: 0x000DD27D
		public FLGUITextClickDelegate()
		{
		}

		// Token: 0x060093FA RID: 37882 RVA: 0x000DF085 File Offset: 0x000DD285
		[NullableContext(2)]
		public FLGUITextClickDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060093FB RID: 37883 RVA: 0x000DF08F File Offset: 0x000DD28F
		public FLGUITextClickDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060093FC RID: 37884 RVA: 0x000DF09A File Offset: 0x000DD29A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<string, bool>) ?? ((Func<string, bool>)Delegate.CreateDelegate(typeof(Func<string, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060093FD RID: 37885 RVA: 0x000DF0CC File Offset: 0x000DD2CC
		[NullableContext(1)]
		public void Bind(Func<string, bool> Callback)
		{
			if (FLGUITextClickDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUITextClickDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUITextClickDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUITextClickDelegate.OnScriptCallback));
				}
				FLGUITextClickDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUITextClickDelegate.RegisterId);
		}

		// Token: 0x060093FE RID: 37886 RVA: 0x000DF108 File Offset: 0x000DD308
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe bool Execute(string HyperLink)
		{
			FLGUITextClickDelegate.__FLGUITextClickDelegate_DelegateParams* ptr = stackalloc FLGUITextClickDelegate.__FLGUITextClickDelegate_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FLGUITextClickDelegate.__FLGUITextClickDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUITextClickDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->HyperLink), HyperLink);
			base.ExecuteInternal((void*)ptr);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(FLGUITextClickDelegate._FunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x060093FF RID: 37887 RVA: 0x000DF164 File Offset: 0x000DD364
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<string, bool> func = target as Func<string, bool>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FLGUITextClickDelegate.__FLGUITextClickDelegate_DelegateParams*)__Parameters)->HyperLink));
			bool _Result = func(arg);
			((FLGUITextClickDelegate.__FLGUITextClickDelegate_DelegateParams*)__Parameters)->__Result = _Result;
		}

		// Token: 0x0400407B RID: 16507
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400407C RID: 16508
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUITextClickDelegate__DelegateSignature";

		// Token: 0x0400407D RID: 16509
		private static int RegisterId;

		// Token: 0x02000EF0 RID: 3824
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		private ref struct __FLGUITextClickDelegate_DelegateParams
		{
			// Token: 0x040062B2 RID: 25266
			[FieldOffset(0)]
			public FString HyperLink;

			// Token: 0x040062B3 RID: 25267
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x02000EF1 RID: 3825
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040062B4 RID: 25268
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
