using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001053 RID: 4179
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PSOGeneratorConfigSingleShader")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FPSOGeneratorConfigSingleShader : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600EDC0 RID: 60864 RVA: 0x00160E6C File Offset: 0x0015F06C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPSOGeneratorConfigSingleShader._ScriptStructPtr != 0) ? FPSOGeneratorConfigSingleShader._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PSOGeneratorConfigSingleShader", ref FPSOGeneratorConfigSingleShader._ScriptStructPtr);
		}

		// Token: 0x1700398E RID: 14734
		// (get) Token: 0x0600EDC1 RID: 60865 RVA: 0x00160E90 File Offset: 0x0015F090
		// (set) Token: 0x0600EDC2 RID: 60866 RVA: 0x00160EA4 File Offset: 0x0015F0A4
		public unsafe string ShaderName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FPSOGeneratorConfigSingleShader.__PropertyOffset_ShaderName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FPSOGeneratorConfigSingleShader.__PropertyOffset_ShaderName)), value);
			}
		}

		// Token: 0x1700398F RID: 14735
		// (get) Token: 0x0600EDC3 RID: 60867 RVA: 0x00160EB9 File Offset: 0x0015F0B9
		// (set) Token: 0x0600EDC4 RID: 60868 RVA: 0x00160ECD File Offset: 0x0015F0CD
		public unsafe string ShaderClass
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FPSOGeneratorConfigSingleShader.__PropertyOffset_ShaderClass)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FPSOGeneratorConfigSingleShader.__PropertyOffset_ShaderClass)), value);
			}
		}

		// Token: 0x17003990 RID: 14736
		// (get) Token: 0x0600EDC5 RID: 60869 RVA: 0x00160EE4 File Offset: 0x0015F0E4
		// (set) Token: 0x0600EDC6 RID: 60870 RVA: 0x00160F27 File Offset: 0x0015F127
		public TArray<FPSOGeneratorConfigShaderPermutation> Permutations
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPSOGeneratorConfigShaderPermutation> result;
				if ((result = this._Permutations) == null)
				{
					result = (this._Permutations = new TArray<FPSOGeneratorConfigShaderPermutation>(base.NativePtr + (IntPtr)FPSOGeneratorConfigSingleShader.__PropertyOffset_Permutations, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Permutations.CopyAssign(value);
			}
		}

		// Token: 0x0600EDC7 RID: 60871 RVA: 0x00160F35 File Offset: 0x0015F135
		public FPSOGeneratorConfigSingleShader()
		{
		}

		// Token: 0x0600EDC8 RID: 60872 RVA: 0x00160F3D File Offset: 0x0015F13D
		public FPSOGeneratorConfigSingleShader(string ShaderName, string ShaderClass, TArray<FPSOGeneratorConfigShaderPermutation> Permutations)
		{
			this.ShaderName = ShaderName;
			this.ShaderClass = ShaderClass;
			this.Permutations = Permutations;
		}

		// Token: 0x0600EDC9 RID: 60873 RVA: 0x00160F5A File Offset: 0x0015F15A
		protected override IntPtr GetUStructPtr()
		{
			return FPSOGeneratorConfigSingleShader.StaticStruct();
		}

		// Token: 0x0600EDCA RID: 60874 RVA: 0x00160F66 File Offset: 0x0015F166
		[NullableContext(2)]
		public FPSOGeneratorConfigSingleShader(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600EDCB RID: 60875 RVA: 0x00160F70 File Offset: 0x0015F170
		public FPSOGeneratorConfigSingleShader(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600EDCC RID: 60876 RVA: 0x00160F7B File Offset: 0x0015F17B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPSOGeneratorConfigSingleShader(Pointer, false, true);
		}

		// Token: 0x0600EDCD RID: 60877 RVA: 0x00160F85 File Offset: 0x0015F185
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPSOGeneratorConfigSingleShader(Pointer, MemoryOwner);
		}

		// Token: 0x040080C8 RID: 32968
		public const string __ObjectPath = "/Script/Engine.PSOGeneratorConfigSingleShader";

		// Token: 0x040080C9 RID: 32969
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040080CA RID: 32970
		internal static int __PropertyOffset_ShaderName;

		// Token: 0x040080CB RID: 32971
		internal static int __PropertyOffset_ShaderClass;

		// Token: 0x040080CC RID: 32972
		internal static int __PropertyOffset_Permutations;

		// Token: 0x040080CD RID: 32973
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPSOGeneratorConfigShaderPermutation> _Permutations;
	}
}
