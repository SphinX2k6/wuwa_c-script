using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020016B3 RID: 5811
	public sealed class FKuroBuildingGridIntersectingCellDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06015130 RID: 86320 RVA: 0x001EF874 File Offset: 0x001EDA74
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroBuildingGridIntersectingCellDelegate.StaticFunctionPtr();
		}

		// Token: 0x06015131 RID: 86321 RVA: 0x001EF880 File Offset: 0x001EDA80
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroBuildingGridIntersectingCellDelegate._FunctionPtr == IntPtr.Zero)
			{
				FKuroBuildingGridIntersectingCellDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroBuildingGridSystem.KuroBuildingGridIntersectingCellDelegate__DelegateSignature");
			}
			return FKuroBuildingGridIntersectingCellDelegate._FunctionPtr;
		}

		// Token: 0x06015132 RID: 86322 RVA: 0x001EF8A3 File Offset: 0x001EDAA3
		public FKuroBuildingGridIntersectingCellDelegate()
		{
		}

		// Token: 0x06015133 RID: 86323 RVA: 0x001EF8AB File Offset: 0x001EDAAB
		[NullableContext(2)]
		public FKuroBuildingGridIntersectingCellDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06015134 RID: 86324 RVA: 0x001EF8B5 File Offset: 0x001EDAB5
		public FKuroBuildingGridIntersectingCellDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015135 RID: 86325 RVA: 0x001EF8C0 File Offset: 0x001EDAC0
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<string, FKuroBuildingGridCellVector, int>) ?? ((Action<string, FKuroBuildingGridCellVector, int>)Delegate.CreateDelegate(typeof(Action<string, FKuroBuildingGridCellVector, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06015136 RID: 86326 RVA: 0x001EF8F2 File Offset: 0x001EDAF2
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<string, FKuroBuildingGridCellVector, int> Callback)
		{
			if (FKuroBuildingGridIntersectingCellDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroBuildingGridIntersectingCellDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroBuildingGridIntersectingCellDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroBuildingGridIntersectingCellDelegate.OnScriptCallback));
				}
				FKuroBuildingGridIntersectingCellDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FKuroBuildingGridIntersectingCellDelegate.RegisterId);
		}

		// Token: 0x06015137 RID: 86327 RVA: 0x001EF92C File Offset: 0x001EDB2C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(string GridGuid, in FKuroBuildingGridCellVector Coords, int CellIndex)
		{
			FKuroBuildingGridIntersectingCellDelegate.__FKuroBuildingGridIntersectingCellDelegate_DelegateParams* ptr = stackalloc FKuroBuildingGridIntersectingCellDelegate.__FKuroBuildingGridIntersectingCellDelegate_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FKuroBuildingGridIntersectingCellDelegate.__FKuroBuildingGridIntersectingCellDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroBuildingGridIntersectingCellDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->GridGuid), GridGuid);
			ptr->Coords = Coords;
			ptr->CellIndex = CellIndex;
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FKuroBuildingGridIntersectingCellDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06015138 RID: 86328 RVA: 0x001EF994 File Offset: 0x001EDB94
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string, FKuroBuildingGridCellVector, int> action = target as Action<string, FKuroBuildingGridCellVector, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FKuroBuildingGridIntersectingCellDelegate.__FKuroBuildingGridIntersectingCellDelegate_DelegateParams*)__Parameters)->GridGuid));
			action(arg, ((FKuroBuildingGridIntersectingCellDelegate.__FKuroBuildingGridIntersectingCellDelegate_DelegateParams*)__Parameters)->Coords, ((FKuroBuildingGridIntersectingCellDelegate.__FKuroBuildingGridIntersectingCellDelegate_DelegateParams*)__Parameters)->CellIndex);
		}

		// Token: 0x0400B783 RID: 46979
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400B784 RID: 46980
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroBuildingGridSystem.KuroBuildingGridIntersectingCellDelegate__DelegateSignature";

		// Token: 0x0400B785 RID: 46981
		private static int RegisterId;

		// Token: 0x02002EE7 RID: 12007
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __FKuroBuildingGridIntersectingCellDelegate_DelegateParams
		{
			// Token: 0x04016A08 RID: 92680
			[FieldOffset(0)]
			public FString GridGuid;

			// Token: 0x04016A09 RID: 92681
			[FieldOffset(16)]
			public FKuroBuildingGridCellVector Coords;

			// Token: 0x04016A0A RID: 92682
			[FieldOffset(24)]
			public int CellIndex;
		}

		// Token: 0x02002EE8 RID: 12008
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016A0B RID: 92683
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
