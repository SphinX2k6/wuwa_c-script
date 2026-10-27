using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200270D RID: 9997
	[UnrealObjectPath("/Script/SequenceDialogue.SeqAnimDataInterface")]
	public interface ISeqAnimDataInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06025115 RID: 151829
		int InterfaceOffset();

		// Token: 0x06025116 RID: 151830 RVA: 0x0036DD08 File Offset: 0x0036BF08
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool SetAnimDataVector(in TMap<FName, FVector> VectorCurveData)
		{
			ISeqAnimDataInterface.__SetAnimDataVector_FunctionParams* ptr = stackalloc ISeqAnimDataInterface.__SetAnimDataVector_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(ISeqAnimDataInterface.__SetAnimDataVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ISeqAnimDataInterface_ReflectionImplementationFields.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			object obj = VectorCurveData;
			if (obj != null)
			{
				obj.MoveTo(&ptr->VectorCurveData);
			}
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, ISeqAnimDataInterface_ReflectionImplementationFields.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr);
			object obj2 = VectorCurveData;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->VectorCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(ISeqAnimDataInterface_ReflectionImplementationFields.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06025117 RID: 151831 RVA: 0x0036DD88 File Offset: 0x0036BF88
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool SetAnimDataVector_Implementation(in TMap<FName, FVector> VectorCurveData)
		{
			ISeqAnimDataInterface.__SetAnimDataVector_FunctionParams* ptr = stackalloc ISeqAnimDataInterface.__SetAnimDataVector_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(ISeqAnimDataInterface.__SetAnimDataVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ISeqAnimDataInterface_ReflectionImplementationFields.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			object obj = VectorCurveData;
			if (obj != null)
			{
				obj.MoveTo(&ptr->VectorCurveData);
			}
			UnrealReflectionUtils.CallUFunction(this.NativePtr, ISeqAnimDataInterface_ReflectionImplementationFields.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr, 0);
			object obj2 = VectorCurveData;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->VectorCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(ISeqAnimDataInterface_ReflectionImplementationFields.__SetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06025118 RID: 151832 RVA: 0x0036DE08 File Offset: 0x0036C008
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool SetAnimDataTransform(in TMap<FName, FTransform> FloatCurveData)
		{
			ISeqAnimDataInterface.__SetAnimDataTransform_FunctionParams* ptr = stackalloc ISeqAnimDataInterface.__SetAnimDataTransform_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(ISeqAnimDataInterface.__SetAnimDataTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ISeqAnimDataInterface_ReflectionImplementationFields.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			object obj = FloatCurveData;
			if (obj != null)
			{
				obj.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, ISeqAnimDataInterface_ReflectionImplementationFields.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr);
			object obj2 = FloatCurveData;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(ISeqAnimDataInterface_ReflectionImplementationFields.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06025119 RID: 151833 RVA: 0x0036DE88 File Offset: 0x0036C088
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool SetAnimDataTransform_Implementation(in TMap<FName, FTransform> FloatCurveData)
		{
			ISeqAnimDataInterface.__SetAnimDataTransform_FunctionParams* ptr = stackalloc ISeqAnimDataInterface.__SetAnimDataTransform_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(ISeqAnimDataInterface.__SetAnimDataTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ISeqAnimDataInterface_ReflectionImplementationFields.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			object obj = FloatCurveData;
			if (obj != null)
			{
				obj.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallUFunction(this.NativePtr, ISeqAnimDataInterface_ReflectionImplementationFields.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 0);
			object obj2 = FloatCurveData;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(ISeqAnimDataInterface_ReflectionImplementationFields.__SetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0602511A RID: 151834 RVA: 0x0036DF08 File Offset: 0x0036C108
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool SetAnimDataFloat([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FNamedCurveValue> FloatCurveData)
		{
			ISeqAnimDataInterface.__SetAnimDataFloat_FunctionParams* ptr = stackalloc ISeqAnimDataInterface.__SetAnimDataFloat_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ISeqAnimDataInterface.__SetAnimDataFloat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ISeqAnimDataInterface_ReflectionImplementationFields.__SetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 1);
			object obj = FloatCurveData;
			if (obj != null)
			{
				obj.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, ISeqAnimDataInterface_ReflectionImplementationFields.__SetAnimDataFloat_NativeFunctionPtr, (void*)ptr);
			object obj2 = FloatCurveData;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(ISeqAnimDataInterface_ReflectionImplementationFields.__SetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0602511B RID: 151835 RVA: 0x0036DF88 File Offset: 0x0036C188
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool SetAnimDataFloat_Implementation([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FNamedCurveValue> FloatCurveData)
		{
			ISeqAnimDataInterface.__SetAnimDataFloat_FunctionParams* ptr = stackalloc ISeqAnimDataInterface.__SetAnimDataFloat_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ISeqAnimDataInterface.__SetAnimDataFloat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ISeqAnimDataInterface_ReflectionImplementationFields.__SetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 1);
			object obj = FloatCurveData;
			if (obj != null)
			{
				obj.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallUFunction(this.NativePtr, ISeqAnimDataInterface_ReflectionImplementationFields.__SetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 0);
			object obj2 = FloatCurveData;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(ISeqAnimDataInterface_ReflectionImplementationFields.__SetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0602511C RID: 151836 RVA: 0x0036E008 File Offset: 0x0036C208
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool IsCustomSupport()
		{
			ISeqAnimDataInterface.__IsCustomSupport_FunctionParams* ptr = stackalloc ISeqAnimDataInterface.__IsCustomSupport_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(ISeqAnimDataInterface.__IsCustomSupport_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ISeqAnimDataInterface_ReflectionImplementationFields.__IsCustomSupport_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, ISeqAnimDataInterface_ReflectionImplementationFields.__IsCustomSupport_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0602511D RID: 151837 RVA: 0x0036E050 File Offset: 0x0036C250
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool IsCustomSupport_Implementation()
		{
			ISeqAnimDataInterface.__IsCustomSupport_FunctionParams* ptr = stackalloc ISeqAnimDataInterface.__IsCustomSupport_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(ISeqAnimDataInterface.__IsCustomSupport_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ISeqAnimDataInterface_ReflectionImplementationFields.__IsCustomSupport_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, ISeqAnimDataInterface_ReflectionImplementationFields.__IsCustomSupport_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602511E RID: 151838 RVA: 0x0036E098 File Offset: 0x0036C298
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe TArray<FName> GetSupportGroupNames()
		{
			ISeqAnimDataInterface.__GetSupportGroupNames_FunctionParams* ptr = stackalloc ISeqAnimDataInterface.__GetSupportGroupNames_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ISeqAnimDataInterface.__GetSupportGroupNames_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ISeqAnimDataInterface_ReflectionImplementationFields.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, ISeqAnimDataInterface_ReflectionImplementationFields.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr);
			TArray<FName> result = new TArray<FName>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(ISeqAnimDataInterface_ReflectionImplementationFields.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0602511F RID: 151839 RVA: 0x0036E0F8 File Offset: 0x0036C2F8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe TArray<FName> GetSupportGroupNames_Implementation()
		{
			ISeqAnimDataInterface.__GetSupportGroupNames_FunctionParams* ptr = stackalloc ISeqAnimDataInterface.__GetSupportGroupNames_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(ISeqAnimDataInterface.__GetSupportGroupNames_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ISeqAnimDataInterface_ReflectionImplementationFields.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, ISeqAnimDataInterface_ReflectionImplementationFields.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FName> result = new TArray<FName>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(ISeqAnimDataInterface_ReflectionImplementationFields.__GetSupportGroupNames_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025120 RID: 151840 RVA: 0x0036E158 File Offset: 0x0036C358
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool GetAnimDataVector(ref TMap<FName, FVector> VectorCurveData)
		{
			ISeqAnimDataInterface.__GetAnimDataVector_FunctionParams* ptr = stackalloc ISeqAnimDataInterface.__GetAnimDataVector_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(ISeqAnimDataInterface.__GetAnimDataVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ISeqAnimDataInterface_ReflectionImplementationFields.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FName, FVector> tmap = VectorCurveData;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->VectorCurveData);
			}
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, ISeqAnimDataInterface_ReflectionImplementationFields.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr);
			TMap<FName, FVector> tmap2 = VectorCurveData;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->VectorCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(ISeqAnimDataInterface_ReflectionImplementationFields.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06025121 RID: 151841 RVA: 0x0036E1D8 File Offset: 0x0036C3D8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool GetAnimDataVector_Implementation(ref TMap<FName, FVector> VectorCurveData)
		{
			ISeqAnimDataInterface.__GetAnimDataVector_FunctionParams* ptr = stackalloc ISeqAnimDataInterface.__GetAnimDataVector_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(ISeqAnimDataInterface.__GetAnimDataVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ISeqAnimDataInterface_ReflectionImplementationFields.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FName, FVector> tmap = VectorCurveData;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->VectorCurveData);
			}
			UnrealReflectionUtils.CallUFunction(this.NativePtr, ISeqAnimDataInterface_ReflectionImplementationFields.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr, 0);
			TMap<FName, FVector> tmap2 = VectorCurveData;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->VectorCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(ISeqAnimDataInterface_ReflectionImplementationFields.__GetAnimDataVector_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06025122 RID: 151842 RVA: 0x0036E258 File Offset: 0x0036C458
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool GetAnimDataTransform(ref TMap<FName, FTransform> FloatCurveData)
		{
			ISeqAnimDataInterface.__GetAnimDataTransform_FunctionParams* ptr = stackalloc ISeqAnimDataInterface.__GetAnimDataTransform_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(ISeqAnimDataInterface.__GetAnimDataTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ISeqAnimDataInterface_ReflectionImplementationFields.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FName, FTransform> tmap = FloatCurveData;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, ISeqAnimDataInterface_ReflectionImplementationFields.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr);
			TMap<FName, FTransform> tmap2 = FloatCurveData;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(ISeqAnimDataInterface_ReflectionImplementationFields.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06025123 RID: 151843 RVA: 0x0036E2D8 File Offset: 0x0036C4D8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool GetAnimDataTransform_Implementation(ref TMap<FName, FTransform> FloatCurveData)
		{
			ISeqAnimDataInterface.__GetAnimDataTransform_FunctionParams* ptr = stackalloc ISeqAnimDataInterface.__GetAnimDataTransform_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(ISeqAnimDataInterface.__GetAnimDataTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ISeqAnimDataInterface_ReflectionImplementationFields.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FName, FTransform> tmap = FloatCurveData;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallUFunction(this.NativePtr, ISeqAnimDataInterface_ReflectionImplementationFields.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 0);
			TMap<FName, FTransform> tmap2 = FloatCurveData;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(ISeqAnimDataInterface_ReflectionImplementationFields.__GetAnimDataTransform_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06025124 RID: 151844 RVA: 0x0036E358 File Offset: 0x0036C558
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool GetAnimDataFloat([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FNamedCurveValue> FloatCurveData)
		{
			ISeqAnimDataInterface.__GetAnimDataFloat_FunctionParams* ptr = stackalloc ISeqAnimDataInterface.__GetAnimDataFloat_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ISeqAnimDataInterface.__GetAnimDataFloat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ISeqAnimDataInterface_ReflectionImplementationFields.__GetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FNamedCurveValue> tarray = FloatCurveData;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, ISeqAnimDataInterface_ReflectionImplementationFields.__GetAnimDataFloat_NativeFunctionPtr, (void*)ptr);
			TArray<FNamedCurveValue> tarray2 = FloatCurveData;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(ISeqAnimDataInterface_ReflectionImplementationFields.__GetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06025125 RID: 151845 RVA: 0x0036E3D8 File Offset: 0x0036C5D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool GetAnimDataFloat_Implementation([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FNamedCurveValue> FloatCurveData)
		{
			ISeqAnimDataInterface.__GetAnimDataFloat_FunctionParams* ptr = stackalloc ISeqAnimDataInterface.__GetAnimDataFloat_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ISeqAnimDataInterface.__GetAnimDataFloat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ISeqAnimDataInterface_ReflectionImplementationFields.__GetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FNamedCurveValue> tarray = FloatCurveData;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->FloatCurveData);
			}
			UnrealReflectionUtils.CallUFunction(this.NativePtr, ISeqAnimDataInterface_ReflectionImplementationFields.__GetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FNamedCurveValue> tarray2 = FloatCurveData;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->FloatCurveData);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(ISeqAnimDataInterface_ReflectionImplementationFields.__GetAnimDataFloat_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x04013F7B RID: 81787
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SequenceDialogue.SeqAnimDataInterface";

		// Token: 0x020036AE RID: 13998
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __SetAnimDataVector_FunctionParams
		{
			// Token: 0x040177C3 RID: 96195
			[FieldOffset(0)]
			public byte VectorCurveData;

			// Token: 0x040177C4 RID: 96196
			[FieldOffset(80)]
			public bool __Result;
		}

		// Token: 0x020036AF RID: 13999
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __SetAnimDataTransform_FunctionParams
		{
			// Token: 0x040177C5 RID: 96197
			[FieldOffset(0)]
			public byte FloatCurveData;

			// Token: 0x040177C6 RID: 96198
			[FieldOffset(80)]
			public bool __Result;
		}

		// Token: 0x020036B0 RID: 14000
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __SetAnimDataFloat_FunctionParams
		{
			// Token: 0x040177C7 RID: 96199
			[FieldOffset(0)]
			public byte FloatCurveData;

			// Token: 0x040177C8 RID: 96200
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x020036B1 RID: 14001
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsCustomSupport_FunctionParams
		{
			// Token: 0x040177C9 RID: 96201
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x020036B2 RID: 14002
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetSupportGroupNames_FunctionParams
		{
			// Token: 0x040177CA RID: 96202
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020036B3 RID: 14003
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __GetAnimDataVector_FunctionParams
		{
			// Token: 0x040177CB RID: 96203
			[FieldOffset(0)]
			public byte VectorCurveData;

			// Token: 0x040177CC RID: 96204
			[FieldOffset(80)]
			public bool __Result;
		}

		// Token: 0x020036B4 RID: 14004
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __GetAnimDataTransform_FunctionParams
		{
			// Token: 0x040177CD RID: 96205
			[FieldOffset(0)]
			public byte FloatCurveData;

			// Token: 0x040177CE RID: 96206
			[FieldOffset(80)]
			public bool __Result;
		}

		// Token: 0x020036B5 RID: 14005
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetAnimDataFloat_FunctionParams
		{
			// Token: 0x040177CF RID: 96207
			[FieldOffset(0)]
			public byte FloatCurveData;

			// Token: 0x040177D0 RID: 96208
			[FieldOffset(16)]
			public bool __Result;
		}
	}
}
