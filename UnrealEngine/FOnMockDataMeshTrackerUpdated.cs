using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200246D RID: 9325
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnMockDataMeshTrackerUpdated : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06022EBD RID: 143037 RVA: 0x00339E8F File Offset: 0x0033808F
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnMockDataMeshTrackerUpdated.StaticFunctionPtr();
		}

		// Token: 0x06022EBE RID: 143038 RVA: 0x00339E9B File Offset: 0x0033809B
		private static IntPtr StaticFunctionPtr()
		{
			if (UMockDataMeshTrackerComponent.__OnMockDataMeshTrackerUpdated__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UMockDataMeshTrackerComponent.__OnMockDataMeshTrackerUpdated__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/MRMesh.MockDataMeshTrackerComponent:OnMockDataMeshTrackerUpdated__DelegateSignature");
			}
			return UMockDataMeshTrackerComponent.__OnMockDataMeshTrackerUpdated__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x06022EBF RID: 143039 RVA: 0x00339EBE File Offset: 0x003380BE
		public FOnMockDataMeshTrackerUpdated()
		{
		}

		// Token: 0x06022EC0 RID: 143040 RVA: 0x00339EC6 File Offset: 0x003380C6
		[NullableContext(2)]
		public FOnMockDataMeshTrackerUpdated(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022EC1 RID: 143041 RVA: 0x00339ED0 File Offset: 0x003380D0
		public FOnMockDataMeshTrackerUpdated(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022EC2 RID: 143042 RVA: 0x00339EDB File Offset: 0x003380DB
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as FOnMockDataMeshTrackerUpdated.FOnMockDataMeshTrackerUpdated_ScriptDelegate) ?? ((FOnMockDataMeshTrackerUpdated.FOnMockDataMeshTrackerUpdated_ScriptDelegate)Delegate.CreateDelegate(typeof(FOnMockDataMeshTrackerUpdated.FOnMockDataMeshTrackerUpdated_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x06022EC3 RID: 143043 RVA: 0x00339F0D File Offset: 0x0033810D
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(FOnMockDataMeshTrackerUpdated.FOnMockDataMeshTrackerUpdated_ScriptDelegate Callback)
		{
			if (FOnMockDataMeshTrackerUpdated.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnMockDataMeshTrackerUpdated.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnMockDataMeshTrackerUpdated.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnMockDataMeshTrackerUpdated.OnScriptCallback));
				}
				FOnMockDataMeshTrackerUpdated.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnMockDataMeshTrackerUpdated.RegisterId);
		}

		// Token: 0x06022EC4 RID: 143044 RVA: 0x00339F47 File Offset: 0x00338147
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(FOnMockDataMeshTrackerUpdated.FOnMockDataMeshTrackerUpdated_ScriptDelegate Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06022EC5 RID: 143045 RVA: 0x00339F50 File Offset: 0x00338150
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int Index, in TArray<FVector> Vertices, in TArray<int> Triangles, in TArray<FVector> Normals, in TArray<float> Confidence)
		{
			FOnMockDataMeshTrackerUpdated.__FOnMockDataMeshTrackerUpdated_DelegateParams* ptr = stackalloc FOnMockDataMeshTrackerUpdated.__FOnMockDataMeshTrackerUpdated_DelegateParams[(UIntPtr)87] + 15L / (long)sizeof(FOnMockDataMeshTrackerUpdated.__FOnMockDataMeshTrackerUpdated_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnMockDataMeshTrackerUpdated.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Index = Index;
			TArray<FVector> tarray = Vertices;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Vertices);
			}
			TArray<int> tarray2 = Triangles;
			if (tarray2 != null)
			{
				tarray2.MoveTo(&ptr->Triangles);
			}
			TArray<FVector> tarray3 = Normals;
			if (tarray3 != null)
			{
				tarray3.MoveTo(&ptr->Normals);
			}
			TArray<float> tarray4 = Confidence;
			if (tarray4 != null)
			{
				tarray4.MoveTo(&ptr->Confidence);
			}
			base.BroadcastInternal((void*)ptr);
			TArray<FVector> tarray5 = Vertices;
			if (tarray5 != null)
			{
				tarray5.MoveAssign(&ptr->Vertices);
			}
			TArray<int> tarray6 = Triangles;
			if (tarray6 != null)
			{
				tarray6.MoveAssign(&ptr->Triangles);
			}
			TArray<FVector> tarray7 = Normals;
			if (tarray7 != null)
			{
				tarray7.MoveAssign(&ptr->Normals);
			}
			TArray<float> tarray8 = Confidence;
			if (tarray8 != null)
			{
				tarray8.MoveAssign(&ptr->Confidence);
			}
			UnrealReflectionUtils.DestroyStruct(UMockDataMeshTrackerComponent.__OnMockDataMeshTrackerUpdated__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06022EC6 RID: 143046 RVA: 0x0033A044 File Offset: 0x00338244
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			FOnMockDataMeshTrackerUpdated.FOnMockDataMeshTrackerUpdated_ScriptDelegate fonMockDataMeshTrackerUpdated_ScriptDelegate = target as FOnMockDataMeshTrackerUpdated.FOnMockDataMeshTrackerUpdated_ScriptDelegate;
			if (fonMockDataMeshTrackerUpdated_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TArray<FVector> tarray = new TArray<FVector>(&((FOnMockDataMeshTrackerUpdated.__FOnMockDataMeshTrackerUpdated_DelegateParams*)__Parameters)->Vertices, true, true);
			TArray<int> tarray2 = new TArray<int>(&((FOnMockDataMeshTrackerUpdated.__FOnMockDataMeshTrackerUpdated_DelegateParams*)__Parameters)->Triangles, true, true);
			TArray<FVector> tarray3 = new TArray<FVector>(&((FOnMockDataMeshTrackerUpdated.__FOnMockDataMeshTrackerUpdated_DelegateParams*)__Parameters)->Normals, true, true);
			TArray<float> tarray4 = new TArray<float>(&((FOnMockDataMeshTrackerUpdated.__FOnMockDataMeshTrackerUpdated_DelegateParams*)__Parameters)->Confidence, true, true);
			fonMockDataMeshTrackerUpdated_ScriptDelegate(((FOnMockDataMeshTrackerUpdated.__FOnMockDataMeshTrackerUpdated_DelegateParams*)__Parameters)->Index, tarray, tarray2, tarray3, tarray4);
			if (tarray != null)
			{
				tarray.CopyTo(&((FOnMockDataMeshTrackerUpdated.__FOnMockDataMeshTrackerUpdated_DelegateParams*)__Parameters)->Vertices, default(UScriptStructStackOnlyPtr));
			}
			if (tarray2 != null)
			{
				tarray2.CopyTo(&((FOnMockDataMeshTrackerUpdated.__FOnMockDataMeshTrackerUpdated_DelegateParams*)__Parameters)->Triangles, default(UScriptStructStackOnlyPtr));
			}
			if (tarray3 != null)
			{
				tarray3.CopyTo(&((FOnMockDataMeshTrackerUpdated.__FOnMockDataMeshTrackerUpdated_DelegateParams*)__Parameters)->Normals, default(UScriptStructStackOnlyPtr));
			}
			if (tarray4 != null)
			{
				tarray4.CopyTo(&((FOnMockDataMeshTrackerUpdated.__FOnMockDataMeshTrackerUpdated_DelegateParams*)__Parameters)->Confidence, default(UScriptStructStackOnlyPtr));
			}
		}

		// Token: 0x04012A38 RID: 76344
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MRMesh.MockDataMeshTrackerComponent:OnMockDataMeshTrackerUpdated__DelegateSignature";

		// Token: 0x04012A39 RID: 76345
		private static int RegisterId;

		// Token: 0x02003664 RID: 13924
		// (Invoke) Token: 0x060285C2 RID: 165314
		[NullableContext(2)]
		[Nullable(0)]
		public delegate void FOnMockDataMeshTrackerUpdated_ScriptDelegate(int Index, in TArray<FVector> Vertices, in TArray<int> Triangles, in TArray<FVector> Normals, in TArray<float> Confidence);

		// Token: 0x02003665 RID: 13925
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __FOnMockDataMeshTrackerUpdated_DelegateParams
		{
			// Token: 0x04017732 RID: 96050
			[FieldOffset(0)]
			public int Index;

			// Token: 0x04017733 RID: 96051
			[FieldOffset(8)]
			public byte Vertices;

			// Token: 0x04017734 RID: 96052
			[FieldOffset(24)]
			public byte Triangles;

			// Token: 0x04017735 RID: 96053
			[FieldOffset(40)]
			public byte Normals;

			// Token: 0x04017736 RID: 96054
			[FieldOffset(56)]
			public byte Confidence;
		}

		// Token: 0x02003666 RID: 13926
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017737 RID: 96055
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
