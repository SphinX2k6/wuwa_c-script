using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200104B RID: 4171
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PSOGeneratorConfigCollector")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class FPSOGeneratorConfigCollector : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600ED47 RID: 60743 RVA: 0x0015FEC6 File Offset: 0x0015E0C6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPSOGeneratorConfigCollector._ScriptStructPtr != 0) ? FPSOGeneratorConfigCollector._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PSOGeneratorConfigCollector", ref FPSOGeneratorConfigCollector._ScriptStructPtr);
		}

		// Token: 0x17003970 RID: 14704
		// (get) Token: 0x0600ED48 RID: 60744 RVA: 0x0015FEEC File Offset: 0x0015E0EC
		// (set) Token: 0x0600ED49 RID: 60745 RVA: 0x0015FF2F File Offset: 0x0015E12F
		public TArray<string> Materials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._Materials) == null)
				{
					result = (this._Materials = new TArray<string>(base.NativePtr + (IntPtr)FPSOGeneratorConfigCollector.__PropertyOffset_Materials, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Materials.CopyAssign(value);
			}
		}

		// Token: 0x17003971 RID: 14705
		// (get) Token: 0x0600ED4A RID: 60746 RVA: 0x0015FF40 File Offset: 0x0015E140
		// (set) Token: 0x0600ED4B RID: 60747 RVA: 0x0015FF83 File Offset: 0x0015E183
		public TArray<string> VertexFactories
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._VertexFactories) == null)
				{
					result = (this._VertexFactories = new TArray<string>(base.NativePtr + (IntPtr)FPSOGeneratorConfigCollector.__PropertyOffset_VertexFactories, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.VertexFactories.CopyAssign(value);
			}
		}

		// Token: 0x17003972 RID: 14706
		// (get) Token: 0x0600ED4C RID: 60748 RVA: 0x0015FF94 File Offset: 0x0015E194
		// (set) Token: 0x0600ED4D RID: 60749 RVA: 0x0015FFD7 File Offset: 0x0015E1D7
		public TArray<string> Pipelines
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._Pipelines) == null)
				{
					result = (this._Pipelines = new TArray<string>(base.NativePtr + (IntPtr)FPSOGeneratorConfigCollector.__PropertyOffset_Pipelines, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Pipelines.CopyAssign(value);
			}
		}

		// Token: 0x0600ED4E RID: 60750 RVA: 0x0015FFE5 File Offset: 0x0015E1E5
		public FPSOGeneratorConfigCollector()
		{
		}

		// Token: 0x0600ED4F RID: 60751 RVA: 0x0015FFED File Offset: 0x0015E1ED
		public FPSOGeneratorConfigCollector(TArray<string> Materials, TArray<string> VertexFactories, TArray<string> Pipelines)
		{
			this.Materials = Materials;
			this.VertexFactories = VertexFactories;
			this.Pipelines = Pipelines;
		}

		// Token: 0x0600ED50 RID: 60752 RVA: 0x0016000A File Offset: 0x0015E20A
		protected override IntPtr GetUStructPtr()
		{
			return FPSOGeneratorConfigCollector.StaticStruct();
		}

		// Token: 0x0600ED51 RID: 60753 RVA: 0x00160016 File Offset: 0x0015E216
		[NullableContext(2)]
		public FPSOGeneratorConfigCollector(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600ED52 RID: 60754 RVA: 0x00160020 File Offset: 0x0015E220
		public FPSOGeneratorConfigCollector(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600ED53 RID: 60755 RVA: 0x0016002B File Offset: 0x0015E22B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPSOGeneratorConfigCollector(Pointer, false, true);
		}

		// Token: 0x0600ED54 RID: 60756 RVA: 0x00160035 File Offset: 0x0015E235
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPSOGeneratorConfigCollector(Pointer, MemoryOwner);
		}

		// Token: 0x04008072 RID: 32882
		public const string __ObjectPath = "/Script/Engine.PSOGeneratorConfigCollector";

		// Token: 0x04008073 RID: 32883
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008074 RID: 32884
		internal static int __PropertyOffset_Materials;

		// Token: 0x04008075 RID: 32885
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Materials;

		// Token: 0x04008076 RID: 32886
		internal static int __PropertyOffset_VertexFactories;

		// Token: 0x04008077 RID: 32887
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _VertexFactories;

		// Token: 0x04008078 RID: 32888
		internal static int __PropertyOffset_Pipelines;

		// Token: 0x04008079 RID: 32889
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Pipelines;
	}
}
