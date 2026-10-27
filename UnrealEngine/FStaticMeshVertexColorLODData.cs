using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001199 RID: 4505
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.StaticMeshVertexColorLODData")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FStaticMeshVertexColorLODData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010991 RID: 67985 RVA: 0x0018603A File Offset: 0x0018423A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FStaticMeshVertexColorLODData._ScriptStructPtr != 0) ? FStaticMeshVertexColorLODData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.StaticMeshVertexColorLODData", ref FStaticMeshVertexColorLODData._ScriptStructPtr);
		}

		// Token: 0x170040CD RID: 16589
		// (get) Token: 0x06010992 RID: 67986 RVA: 0x00186060 File Offset: 0x00184260
		// (set) Token: 0x06010993 RID: 67987 RVA: 0x001860A3 File Offset: 0x001842A3
		public TArray<FPaintedVertex> PaintedVertices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPaintedVertex> result;
				if ((result = this._PaintedVertices) == null)
				{
					result = (this._PaintedVertices = new TArray<FPaintedVertex>(base.NativePtr + (IntPtr)FStaticMeshVertexColorLODData.__PropertyOffset_PaintedVertices, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PaintedVertices.CopyAssign(value);
			}
		}

		// Token: 0x170040CE RID: 16590
		// (get) Token: 0x06010994 RID: 67988 RVA: 0x001860B4 File Offset: 0x001842B4
		// (set) Token: 0x06010995 RID: 67989 RVA: 0x001860F7 File Offset: 0x001842F7
		public TArray<FColor> VertexBufferColors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FColor> result;
				if ((result = this._VertexBufferColors) == null)
				{
					result = (this._VertexBufferColors = new TArray<FColor>(base.NativePtr + (IntPtr)FStaticMeshVertexColorLODData.__PropertyOffset_VertexBufferColors, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.VertexBufferColors.CopyAssign(value);
			}
		}

		// Token: 0x170040CF RID: 16591
		// (get) Token: 0x06010996 RID: 67990 RVA: 0x00186105 File Offset: 0x00184305
		// (set) Token: 0x06010997 RID: 67991 RVA: 0x00186115 File Offset: 0x00184315
		public unsafe uint LODIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStaticMeshVertexColorLODData.__PropertyOffset_LODIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStaticMeshVertexColorLODData.__PropertyOffset_LODIndex) = (int)value;
			}
		}

		// Token: 0x06010998 RID: 67992 RVA: 0x00186126 File Offset: 0x00184326
		public FStaticMeshVertexColorLODData()
		{
		}

		// Token: 0x06010999 RID: 67993 RVA: 0x0018612E File Offset: 0x0018432E
		public FStaticMeshVertexColorLODData(TArray<FPaintedVertex> PaintedVertices, TArray<FColor> VertexBufferColors, uint LODIndex)
		{
			this.PaintedVertices = PaintedVertices;
			this.VertexBufferColors = VertexBufferColors;
			this.LODIndex = LODIndex;
		}

		// Token: 0x0601099A RID: 67994 RVA: 0x0018614B File Offset: 0x0018434B
		protected override IntPtr GetUStructPtr()
		{
			return FStaticMeshVertexColorLODData.StaticStruct();
		}

		// Token: 0x0601099B RID: 67995 RVA: 0x00186157 File Offset: 0x00184357
		[NullableContext(2)]
		public FStaticMeshVertexColorLODData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601099C RID: 67996 RVA: 0x00186161 File Offset: 0x00184361
		public FStaticMeshVertexColorLODData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601099D RID: 67997 RVA: 0x0018616C File Offset: 0x0018436C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FStaticMeshVertexColorLODData(Pointer, false, true);
		}

		// Token: 0x0601099E RID: 67998 RVA: 0x00186176 File Offset: 0x00184376
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FStaticMeshVertexColorLODData(Pointer, MemoryOwner);
		}

		// Token: 0x04008E0F RID: 36367
		public const string __ObjectPath = "/Script/Engine.StaticMeshVertexColorLODData";

		// Token: 0x04008E10 RID: 36368
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008E11 RID: 36369
		internal static int __PropertyOffset_PaintedVertices;

		// Token: 0x04008E12 RID: 36370
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPaintedVertex> _PaintedVertices;

		// Token: 0x04008E13 RID: 36371
		internal static int __PropertyOffset_VertexBufferColors;

		// Token: 0x04008E14 RID: 36372
		[Nullable(2)]
		private TArray<FColor> _VertexBufferColors;

		// Token: 0x04008E15 RID: 36373
		internal static int __PropertyOffset_LODIndex;
	}
}
