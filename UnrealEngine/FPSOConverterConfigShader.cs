using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001045 RID: 4165
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PSOConverterConfigShader")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FPSOConverterConfigShader : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600ED04 RID: 60676 RVA: 0x0015F916 File Offset: 0x0015DB16
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPSOConverterConfigShader._ScriptStructPtr != 0) ? FPSOConverterConfigShader._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PSOConverterConfigShader", ref FPSOConverterConfigShader._ScriptStructPtr);
		}

		// Token: 0x17003966 RID: 14694
		// (get) Token: 0x0600ED05 RID: 60677 RVA: 0x0015F93A File Offset: 0x0015DB3A
		// (set) Token: 0x0600ED06 RID: 60678 RVA: 0x0015F94E File Offset: 0x0015DB4E
		public unsafe string NameRegex
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FPSOConverterConfigShader.__PropertyOffset_NameRegex)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FPSOConverterConfigShader.__PropertyOffset_NameRegex)), value);
			}
		}

		// Token: 0x17003967 RID: 14695
		// (get) Token: 0x0600ED07 RID: 60679 RVA: 0x0015F964 File Offset: 0x0015DB64
		// (set) Token: 0x0600ED08 RID: 60680 RVA: 0x0015F9A7 File Offset: 0x0015DBA7
		public TArray<FPSOConverterConfigShaderPermutation> Permutations
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPSOConverterConfigShaderPermutation> result;
				if ((result = this._Permutations) == null)
				{
					result = (this._Permutations = new TArray<FPSOConverterConfigShaderPermutation>(base.NativePtr + (IntPtr)FPSOConverterConfigShader.__PropertyOffset_Permutations, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Permutations.CopyAssign(value);
			}
		}

		// Token: 0x0600ED09 RID: 60681 RVA: 0x0015F9B5 File Offset: 0x0015DBB5
		public FPSOConverterConfigShader()
		{
		}

		// Token: 0x0600ED0A RID: 60682 RVA: 0x0015F9BD File Offset: 0x0015DBBD
		public FPSOConverterConfigShader(string NameRegex, TArray<FPSOConverterConfigShaderPermutation> Permutations)
		{
			this.NameRegex = NameRegex;
			this.Permutations = Permutations;
		}

		// Token: 0x0600ED0B RID: 60683 RVA: 0x0015F9D3 File Offset: 0x0015DBD3
		protected override IntPtr GetUStructPtr()
		{
			return FPSOConverterConfigShader.StaticStruct();
		}

		// Token: 0x0600ED0C RID: 60684 RVA: 0x0015F9DF File Offset: 0x0015DBDF
		[NullableContext(2)]
		public FPSOConverterConfigShader(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600ED0D RID: 60685 RVA: 0x0015F9E9 File Offset: 0x0015DBE9
		public FPSOConverterConfigShader(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600ED0E RID: 60686 RVA: 0x0015F9F4 File Offset: 0x0015DBF4
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPSOConverterConfigShader(Pointer, false, true);
		}

		// Token: 0x0600ED0F RID: 60687 RVA: 0x0015F9FE File Offset: 0x0015DBFE
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPSOConverterConfigShader(Pointer, MemoryOwner);
		}

		// Token: 0x04008052 RID: 32850
		public const string __ObjectPath = "/Script/Engine.PSOConverterConfigShader";

		// Token: 0x04008053 RID: 32851
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008054 RID: 32852
		internal static int __PropertyOffset_NameRegex;

		// Token: 0x04008055 RID: 32853
		internal static int __PropertyOffset_Permutations;

		// Token: 0x04008056 RID: 32854
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPSOConverterConfigShaderPermutation> _Permutations;
	}
}
