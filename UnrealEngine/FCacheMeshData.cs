using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001FCD RID: 8141
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.CacheMeshData")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FCacheMeshData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601EE1E RID: 126494 RVA: 0x002DE482 File Offset: 0x002DC682
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCacheMeshData._ScriptStructPtr != 0) ? FCacheMeshData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.CacheMeshData", ref FCacheMeshData._ScriptStructPtr);
		}

		// Token: 0x17007AE3 RID: 31459
		// (get) Token: 0x0601EE1F RID: 126495 RVA: 0x002DE4A8 File Offset: 0x002DC6A8
		// (set) Token: 0x0601EE20 RID: 126496 RVA: 0x002DE4EB File Offset: 0x002DC6EB
		public TArray<FCacheVertex> Vertices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCacheVertex> result;
				if ((result = this._Vertices) == null)
				{
					result = (this._Vertices = new TArray<FCacheVertex>(base.NativePtr + (IntPtr)FCacheMeshData.__PropertyOffset_Vertices, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Vertices.CopyAssign(value);
			}
		}

		// Token: 0x17007AE4 RID: 31460
		// (get) Token: 0x0601EE21 RID: 126497 RVA: 0x002DE4FC File Offset: 0x002DC6FC
		// (set) Token: 0x0601EE22 RID: 126498 RVA: 0x002DE53F File Offset: 0x002DC73F
		public TArray<FVector> Positions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._Positions) == null)
				{
					result = (this._Positions = new TArray<FVector>(base.NativePtr + (IntPtr)FCacheMeshData.__PropertyOffset_Positions, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Positions.CopyAssign(value);
			}
		}

		// Token: 0x17007AE5 RID: 31461
		// (get) Token: 0x0601EE23 RID: 126499 RVA: 0x002DE550 File Offset: 0x002DC750
		// (set) Token: 0x0601EE24 RID: 126500 RVA: 0x002DE593 File Offset: 0x002DC793
		public TArray<FColor> Colors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FColor> result;
				if ((result = this._Colors) == null)
				{
					result = (this._Colors = new TArray<FColor>(base.NativePtr + (IntPtr)FCacheMeshData.__PropertyOffset_Colors, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Colors.CopyAssign(value);
			}
		}

		// Token: 0x17007AE6 RID: 31462
		// (get) Token: 0x0601EE25 RID: 126501 RVA: 0x002DE5A4 File Offset: 0x002DC7A4
		// (set) Token: 0x0601EE26 RID: 126502 RVA: 0x002DE5E7 File Offset: 0x002DC7E7
		public TArray<uint> Indices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<uint> result;
				if ((result = this._Indices) == null)
				{
					result = (this._Indices = new TArray<uint>(base.NativePtr + (IntPtr)FCacheMeshData.__PropertyOffset_Indices, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Indices.CopyAssign(value);
			}
		}

		// Token: 0x17007AE7 RID: 31463
		// (get) Token: 0x0601EE27 RID: 126503 RVA: 0x002DE5F5 File Offset: 0x002DC7F5
		// (set) Token: 0x0601EE28 RID: 126504 RVA: 0x002DE605 File Offset: 0x002DC805
		public unsafe int NumVertices
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCacheMeshData.__PropertyOffset_NumVertices);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCacheMeshData.__PropertyOffset_NumVertices) = value;
			}
		}

		// Token: 0x17007AE8 RID: 31464
		// (get) Token: 0x0601EE29 RID: 126505 RVA: 0x002DE616 File Offset: 0x002DC816
		// (set) Token: 0x0601EE2A RID: 126506 RVA: 0x002DE626 File Offset: 0x002DC826
		public unsafe int NumTriangles
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCacheMeshData.__PropertyOffset_NumTriangles);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCacheMeshData.__PropertyOffset_NumTriangles) = value;
			}
		}

		// Token: 0x17007AE9 RID: 31465
		// (get) Token: 0x0601EE2B RID: 126507 RVA: 0x002DE637 File Offset: 0x002DC837
		// (set) Token: 0x0601EE2C RID: 126508 RVA: 0x002DE647 File Offset: 0x002DC847
		public unsafe int NumTexCoords
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCacheMeshData.__PropertyOffset_NumTexCoords);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCacheMeshData.__PropertyOffset_NumTexCoords) = value;
			}
		}

		// Token: 0x17007AEA RID: 31466
		// (get) Token: 0x0601EE2D RID: 126509 RVA: 0x002DE658 File Offset: 0x002DC858
		// (set) Token: 0x0601EE2E RID: 126510 RVA: 0x002DE668 File Offset: 0x002DC868
		public unsafe int ColorBufferNumVertices
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCacheMeshData.__PropertyOffset_ColorBufferNumVertices);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCacheMeshData.__PropertyOffset_ColorBufferNumVertices) = value;
			}
		}

		// Token: 0x17007AEB RID: 31467
		// (get) Token: 0x0601EE2F RID: 126511 RVA: 0x002DE679 File Offset: 0x002DC879
		// (set) Token: 0x0601EE30 RID: 126512 RVA: 0x002DE689 File Offset: 0x002DC889
		public unsafe bool bHasColors
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCacheMeshData.__PropertyOffset_bHasColors) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCacheMeshData.__PropertyOffset_bHasColors) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007AEC RID: 31468
		// (get) Token: 0x0601EE31 RID: 126513 RVA: 0x002DE69A File Offset: 0x002DC89A
		// (set) Token: 0x0601EE32 RID: 126514 RVA: 0x002DE6AA File Offset: 0x002DC8AA
		public unsafe bool bHasTexCoords
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCacheMeshData.__PropertyOffset_bHasTexCoords) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCacheMeshData.__PropertyOffset_bHasTexCoords) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601EE33 RID: 126515 RVA: 0x002DE6BB File Offset: 0x002DC8BB
		public FCacheMeshData()
		{
		}

		// Token: 0x0601EE34 RID: 126516 RVA: 0x002DE6C4 File Offset: 0x002DC8C4
		public FCacheMeshData(TArray<FCacheVertex> Vertices, TArray<FVector> Positions, TArray<FColor> Colors, TArray<uint> Indices, int NumVertices, int NumTriangles, int NumTexCoords, int ColorBufferNumVertices, bool bHasColors, bool bHasTexCoords)
		{
			this.Vertices = Vertices;
			this.Positions = Positions;
			this.Colors = Colors;
			this.Indices = Indices;
			this.NumVertices = NumVertices;
			this.NumTriangles = NumTriangles;
			this.NumTexCoords = NumTexCoords;
			this.ColorBufferNumVertices = ColorBufferNumVertices;
			this.bHasColors = bHasColors;
			this.bHasTexCoords = bHasTexCoords;
		}

		// Token: 0x0601EE35 RID: 126517 RVA: 0x002DE724 File Offset: 0x002DC924
		protected override IntPtr GetUStructPtr()
		{
			return FCacheMeshData.StaticStruct();
		}

		// Token: 0x0601EE36 RID: 126518 RVA: 0x002DE730 File Offset: 0x002DC930
		[NullableContext(2)]
		public FCacheMeshData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EE37 RID: 126519 RVA: 0x002DE73A File Offset: 0x002DC93A
		public FCacheMeshData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EE38 RID: 126520 RVA: 0x002DE745 File Offset: 0x002DC945
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCacheMeshData(Pointer, false, true);
		}

		// Token: 0x0601EE39 RID: 126521 RVA: 0x002DE74F File Offset: 0x002DC94F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCacheMeshData(Pointer, MemoryOwner);
		}

		// Token: 0x04010AEB RID: 68331
		public const string __ObjectPath = "/Script/LGUI.CacheMeshData";

		// Token: 0x04010AEC RID: 68332
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010AED RID: 68333
		internal static int __PropertyOffset_Vertices;

		// Token: 0x04010AEE RID: 68334
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCacheVertex> _Vertices;

		// Token: 0x04010AEF RID: 68335
		internal static int __PropertyOffset_Positions;

		// Token: 0x04010AF0 RID: 68336
		[Nullable(2)]
		private TArray<FVector> _Positions;

		// Token: 0x04010AF1 RID: 68337
		internal static int __PropertyOffset_Colors;

		// Token: 0x04010AF2 RID: 68338
		[Nullable(2)]
		private TArray<FColor> _Colors;

		// Token: 0x04010AF3 RID: 68339
		internal static int __PropertyOffset_Indices;

		// Token: 0x04010AF4 RID: 68340
		[Nullable(2)]
		private TArray<uint> _Indices;

		// Token: 0x04010AF5 RID: 68341
		internal static int __PropertyOffset_NumVertices;

		// Token: 0x04010AF6 RID: 68342
		internal static int __PropertyOffset_NumTriangles;

		// Token: 0x04010AF7 RID: 68343
		internal static int __PropertyOffset_NumTexCoords;

		// Token: 0x04010AF8 RID: 68344
		internal static int __PropertyOffset_ColorBufferNumVertices;

		// Token: 0x04010AF9 RID: 68345
		internal static int __PropertyOffset_bHasColors;

		// Token: 0x04010AFA RID: 68346
		internal static int __PropertyOffset_bHasTexCoords;
	}
}
