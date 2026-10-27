using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001051 RID: 4177
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PSOGeneratorConfigShaderPermutation")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FPSOGeneratorConfigShaderPermutation : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600EDAD RID: 60845 RVA: 0x00160CCD File Offset: 0x0015EECD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPSOGeneratorConfigShaderPermutation._ScriptStructPtr != 0) ? FPSOGeneratorConfigShaderPermutation._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PSOGeneratorConfigShaderPermutation", ref FPSOGeneratorConfigShaderPermutation._ScriptStructPtr);
		}

		// Token: 0x1700398C RID: 14732
		// (get) Token: 0x0600EDAE RID: 60846 RVA: 0x00160CF1 File Offset: 0x0015EEF1
		// (set) Token: 0x0600EDAF RID: 60847 RVA: 0x00160D05 File Offset: 0x0015EF05
		public unsafe string PermutationName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FPSOGeneratorConfigShaderPermutation.__PropertyOffset_PermutationName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FPSOGeneratorConfigShaderPermutation.__PropertyOffset_PermutationName)), value);
			}
		}

		// Token: 0x1700398D RID: 14733
		// (get) Token: 0x0600EDB0 RID: 60848 RVA: 0x00160D1C File Offset: 0x0015EF1C
		// (set) Token: 0x0600EDB1 RID: 60849 RVA: 0x00160D5F File Offset: 0x0015EF5F
		public TArray<string> PermutationValues
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._PermutationValues) == null)
				{
					result = (this._PermutationValues = new TArray<string>(base.NativePtr + (IntPtr)FPSOGeneratorConfigShaderPermutation.__PropertyOffset_PermutationValues, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PermutationValues.CopyAssign(value);
			}
		}

		// Token: 0x0600EDB2 RID: 60850 RVA: 0x00160D6D File Offset: 0x0015EF6D
		public FPSOGeneratorConfigShaderPermutation()
		{
		}

		// Token: 0x0600EDB3 RID: 60851 RVA: 0x00160D75 File Offset: 0x0015EF75
		public FPSOGeneratorConfigShaderPermutation(string PermutationName, TArray<string> PermutationValues)
		{
			this.PermutationName = PermutationName;
			this.PermutationValues = PermutationValues;
		}

		// Token: 0x0600EDB4 RID: 60852 RVA: 0x00160D8B File Offset: 0x0015EF8B
		protected override IntPtr GetUStructPtr()
		{
			return FPSOGeneratorConfigShaderPermutation.StaticStruct();
		}

		// Token: 0x0600EDB5 RID: 60853 RVA: 0x00160D97 File Offset: 0x0015EF97
		[NullableContext(2)]
		public FPSOGeneratorConfigShaderPermutation(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600EDB6 RID: 60854 RVA: 0x00160DA1 File Offset: 0x0015EFA1
		public FPSOGeneratorConfigShaderPermutation(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600EDB7 RID: 60855 RVA: 0x00160DAC File Offset: 0x0015EFAC
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPSOGeneratorConfigShaderPermutation(Pointer, false, true);
		}

		// Token: 0x0600EDB8 RID: 60856 RVA: 0x00160DB6 File Offset: 0x0015EFB6
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPSOGeneratorConfigShaderPermutation(Pointer, MemoryOwner);
		}

		// Token: 0x040080BF RID: 32959
		public const string __ObjectPath = "/Script/Engine.PSOGeneratorConfigShaderPermutation";

		// Token: 0x040080C0 RID: 32960
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040080C1 RID: 32961
		internal static int __PropertyOffset_PermutationName;

		// Token: 0x040080C2 RID: 32962
		internal static int __PropertyOffset_PermutationValues;

		// Token: 0x040080C3 RID: 32963
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _PermutationValues;
	}
}
