using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001046 RID: 4166
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PSOConverterConfigShaderPermutation")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FPSOConverterConfigShaderPermutation : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600ED10 RID: 60688 RVA: 0x0015FA07 File Offset: 0x0015DC07
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPSOConverterConfigShaderPermutation._ScriptStructPtr != 0) ? FPSOConverterConfigShaderPermutation._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PSOConverterConfigShaderPermutation", ref FPSOConverterConfigShaderPermutation._ScriptStructPtr);
		}

		// Token: 0x17003968 RID: 14696
		// (get) Token: 0x0600ED11 RID: 60689 RVA: 0x0015FA2B File Offset: 0x0015DC2B
		// (set) Token: 0x0600ED12 RID: 60690 RVA: 0x0015FA3F File Offset: 0x0015DC3F
		public unsafe string PermutationName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FPSOConverterConfigShaderPermutation.__PropertyOffset_PermutationName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FPSOConverterConfigShaderPermutation.__PropertyOffset_PermutationName)), value);
			}
		}

		// Token: 0x17003969 RID: 14697
		// (get) Token: 0x0600ED13 RID: 60691 RVA: 0x0015FA54 File Offset: 0x0015DC54
		// (set) Token: 0x0600ED14 RID: 60692 RVA: 0x0015FA68 File Offset: 0x0015DC68
		public unsafe string PermutationVariableName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FPSOConverterConfigShaderPermutation.__PropertyOffset_PermutationVariableName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FPSOConverterConfigShaderPermutation.__PropertyOffset_PermutationVariableName)), value);
			}
		}

		// Token: 0x0600ED15 RID: 60693 RVA: 0x0015FA7D File Offset: 0x0015DC7D
		public FPSOConverterConfigShaderPermutation()
		{
		}

		// Token: 0x0600ED16 RID: 60694 RVA: 0x0015FA85 File Offset: 0x0015DC85
		public FPSOConverterConfigShaderPermutation(string PermutationName, string PermutationVariableName)
		{
			this.PermutationName = PermutationName;
			this.PermutationVariableName = PermutationVariableName;
		}

		// Token: 0x0600ED17 RID: 60695 RVA: 0x0015FA9B File Offset: 0x0015DC9B
		protected override IntPtr GetUStructPtr()
		{
			return FPSOConverterConfigShaderPermutation.StaticStruct();
		}

		// Token: 0x0600ED18 RID: 60696 RVA: 0x0015FAA7 File Offset: 0x0015DCA7
		[NullableContext(2)]
		public FPSOConverterConfigShaderPermutation(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600ED19 RID: 60697 RVA: 0x0015FAB1 File Offset: 0x0015DCB1
		public FPSOConverterConfigShaderPermutation(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600ED1A RID: 60698 RVA: 0x0015FABC File Offset: 0x0015DCBC
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPSOConverterConfigShaderPermutation(Pointer, false, true);
		}

		// Token: 0x0600ED1B RID: 60699 RVA: 0x0015FAC6 File Offset: 0x0015DCC6
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPSOConverterConfigShaderPermutation(Pointer, MemoryOwner);
		}

		// Token: 0x04008057 RID: 32855
		public const string __ObjectPath = "/Script/Engine.PSOConverterConfigShaderPermutation";

		// Token: 0x04008058 RID: 32856
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008059 RID: 32857
		internal static int __PropertyOffset_PermutationName;

		// Token: 0x0400805A RID: 32858
		internal static int __PropertyOffset_PermutationVariableName;
	}
}
