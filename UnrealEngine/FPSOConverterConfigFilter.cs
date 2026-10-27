using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001044 RID: 4164
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PSOConverterConfigFilter")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 120)]
	public class FPSOConverterConfigFilter : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600ECF2 RID: 60658 RVA: 0x0015F746 File Offset: 0x0015D946
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPSOConverterConfigFilter._ScriptStructPtr != 0) ? FPSOConverterConfigFilter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PSOConverterConfigFilter", ref FPSOConverterConfigFilter._ScriptStructPtr);
		}

		// Token: 0x17003961 RID: 14689
		// (get) Token: 0x0600ECF3 RID: 60659 RVA: 0x0015F76A File Offset: 0x0015D96A
		// (set) Token: 0x0600ECF4 RID: 60660 RVA: 0x0015F77E File Offset: 0x0015D97E
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FPSOConverterConfigFilter.__PropertyOffset_Name)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FPSOConverterConfigFilter.__PropertyOffset_Name)), value);
			}
		}

		// Token: 0x17003962 RID: 14690
		// (get) Token: 0x0600ECF5 RID: 60661 RVA: 0x0015F793 File Offset: 0x0015D993
		// (set) Token: 0x0600ECF6 RID: 60662 RVA: 0x0015F7A3 File Offset: 0x0015D9A3
		public unsafe bool bEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPSOConverterConfigFilter.__PropertyOffset_bEnable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPSOConverterConfigFilter.__PropertyOffset_bEnable) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003963 RID: 14691
		// (get) Token: 0x0600ECF7 RID: 60663 RVA: 0x0015F7B4 File Offset: 0x0015D9B4
		// (set) Token: 0x0600ECF8 RID: 60664 RVA: 0x0015F7F7 File Offset: 0x0015D9F7
		public TArray<string> MaterialPathRegex
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._MaterialPathRegex) == null)
				{
					result = (this._MaterialPathRegex = new TArray<string>(base.NativePtr + (IntPtr)FPSOConverterConfigFilter.__PropertyOffset_MaterialPathRegex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MaterialPathRegex.CopyAssign(value);
			}
		}

		// Token: 0x17003964 RID: 14692
		// (get) Token: 0x0600ECF9 RID: 60665 RVA: 0x0015F808 File Offset: 0x0015DA08
		// (set) Token: 0x0600ECFA RID: 60666 RVA: 0x0015F84B File Offset: 0x0015DA4B
		public TArray<string> ShaderTypesRegex
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._ShaderTypesRegex) == null)
				{
					result = (this._ShaderTypesRegex = new TArray<string>(base.NativePtr + (IntPtr)FPSOConverterConfigFilter.__PropertyOffset_ShaderTypesRegex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ShaderTypesRegex.CopyAssign(value);
			}
		}

		// Token: 0x17003965 RID: 14693
		// (get) Token: 0x0600ECFB RID: 60667 RVA: 0x0015F85C File Offset: 0x0015DA5C
		// (set) Token: 0x0600ECFC RID: 60668 RVA: 0x0015F89F File Offset: 0x0015DA9F
		public TArray<string> VertexFactoriesRegex
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._VertexFactoriesRegex) == null)
				{
					result = (this._VertexFactoriesRegex = new TArray<string>(base.NativePtr + (IntPtr)FPSOConverterConfigFilter.__PropertyOffset_VertexFactoriesRegex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.VertexFactoriesRegex.CopyAssign(value);
			}
		}

		// Token: 0x0600ECFD RID: 60669 RVA: 0x0015F8AD File Offset: 0x0015DAAD
		public FPSOConverterConfigFilter()
		{
		}

		// Token: 0x0600ECFE RID: 60670 RVA: 0x0015F8B5 File Offset: 0x0015DAB5
		public FPSOConverterConfigFilter(string Name, bool bEnable, TArray<string> MaterialPathRegex, TArray<string> ShaderTypesRegex, TArray<string> VertexFactoriesRegex)
		{
			this.Name = Name;
			this.bEnable = bEnable;
			this.MaterialPathRegex = MaterialPathRegex;
			this.ShaderTypesRegex = ShaderTypesRegex;
			this.VertexFactoriesRegex = VertexFactoriesRegex;
		}

		// Token: 0x0600ECFF RID: 60671 RVA: 0x0015F8E2 File Offset: 0x0015DAE2
		protected override IntPtr GetUStructPtr()
		{
			return FPSOConverterConfigFilter.StaticStruct();
		}

		// Token: 0x0600ED00 RID: 60672 RVA: 0x0015F8EE File Offset: 0x0015DAEE
		[NullableContext(2)]
		public FPSOConverterConfigFilter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600ED01 RID: 60673 RVA: 0x0015F8F8 File Offset: 0x0015DAF8
		public FPSOConverterConfigFilter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600ED02 RID: 60674 RVA: 0x0015F903 File Offset: 0x0015DB03
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPSOConverterConfigFilter(Pointer, false, true);
		}

		// Token: 0x0600ED03 RID: 60675 RVA: 0x0015F90D File Offset: 0x0015DB0D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPSOConverterConfigFilter(Pointer, MemoryOwner);
		}

		// Token: 0x04008048 RID: 32840
		public const string __ObjectPath = "/Script/Engine.PSOConverterConfigFilter";

		// Token: 0x04008049 RID: 32841
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400804A RID: 32842
		internal static int __PropertyOffset_Name;

		// Token: 0x0400804B RID: 32843
		internal static int __PropertyOffset_bEnable;

		// Token: 0x0400804C RID: 32844
		internal static int __PropertyOffset_MaterialPathRegex;

		// Token: 0x0400804D RID: 32845
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _MaterialPathRegex;

		// Token: 0x0400804E RID: 32846
		internal static int __PropertyOffset_ShaderTypesRegex;

		// Token: 0x0400804F RID: 32847
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _ShaderTypesRegex;

		// Token: 0x04008050 RID: 32848
		internal static int __PropertyOffset_VertexFactoriesRegex;

		// Token: 0x04008051 RID: 32849
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _VertexFactoriesRegex;
	}
}
