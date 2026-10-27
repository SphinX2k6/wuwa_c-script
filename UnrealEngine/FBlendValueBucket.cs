using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020022B5 RID: 8885
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MeshBlend.BlendValueBucket")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FBlendValueBucket : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021C40 RID: 138304 RVA: 0x0031EBFB File Offset: 0x0031CDFB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBlendValueBucket._ScriptStructPtr != 0) ? FBlendValueBucket._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MeshBlend.BlendValueBucket", ref FBlendValueBucket._ScriptStructPtr);
		}

		// Token: 0x170082FB RID: 33531
		// (get) Token: 0x06021C41 RID: 138305 RVA: 0x0031EC20 File Offset: 0x0031CE20
		// (set) Token: 0x06021C42 RID: 138306 RVA: 0x0031EC63 File Offset: 0x0031CE63
		public TMap<FIntPoint, FGridCell> GridCells
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FIntPoint, FGridCell> result;
				if ((result = this._GridCells) == null)
				{
					result = (this._GridCells = new TMap<FIntPoint, FGridCell>(base.NativePtr + (IntPtr)FBlendValueBucket.__PropertyOffset_GridCells, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.GridCells.CopyAssign(value);
			}
		}

		// Token: 0x06021C43 RID: 138307 RVA: 0x0031EC71 File Offset: 0x0031CE71
		public FBlendValueBucket()
		{
		}

		// Token: 0x06021C44 RID: 138308 RVA: 0x0031EC79 File Offset: 0x0031CE79
		public FBlendValueBucket(TMap<FIntPoint, FGridCell> GridCells)
		{
			this.GridCells = GridCells;
		}

		// Token: 0x06021C45 RID: 138309 RVA: 0x0031EC88 File Offset: 0x0031CE88
		protected override IntPtr GetUStructPtr()
		{
			return FBlendValueBucket.StaticStruct();
		}

		// Token: 0x06021C46 RID: 138310 RVA: 0x0031EC94 File Offset: 0x0031CE94
		[NullableContext(2)]
		public FBlendValueBucket(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021C47 RID: 138311 RVA: 0x0031EC9E File Offset: 0x0031CE9E
		public FBlendValueBucket(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021C48 RID: 138312 RVA: 0x0031ECA9 File Offset: 0x0031CEA9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBlendValueBucket(Pointer, false, true);
		}

		// Token: 0x06021C49 RID: 138313 RVA: 0x0031ECB3 File Offset: 0x0031CEB3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBlendValueBucket(Pointer, MemoryOwner);
		}

		// Token: 0x04012043 RID: 73795
		public const string __ObjectPath = "/Script/MeshBlend.BlendValueBucket";

		// Token: 0x04012044 RID: 73796
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012045 RID: 73797
		internal static int __PropertyOffset_GridCells;

		// Token: 0x04012046 RID: 73798
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FIntPoint, FGridCell> _GridCells;
	}
}
