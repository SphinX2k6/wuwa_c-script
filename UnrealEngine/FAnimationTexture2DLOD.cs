using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020007E8 RID: 2024
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AnimationTexture2DLOD")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 120)]
	public class FAnimationTexture2DLOD : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006BE3 RID: 27619 RVA: 0x0009B31A File Offset: 0x0009951A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimationTexture2DLOD._ScriptStructPtr != 0) ? FAnimationTexture2DLOD._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimationTexture2DLOD", ref FAnimationTexture2DLOD._ScriptStructPtr);
		}

		// Token: 0x17001967 RID: 6503
		// (get) Token: 0x06006BE4 RID: 27620 RVA: 0x0009B33E File Offset: 0x0009953E
		// (set) Token: 0x06006BE5 RID: 27621 RVA: 0x0009B34E File Offset: 0x0009954E
		public unsafe int MinVertexIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimationTexture2DLOD.__PropertyOffset_MinVertexIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimationTexture2DLOD.__PropertyOffset_MinVertexIndex) = value;
			}
		}

		// Token: 0x17001968 RID: 6504
		// (get) Token: 0x06006BE6 RID: 27622 RVA: 0x0009B35F File Offset: 0x0009955F
		// (set) Token: 0x06006BE7 RID: 27623 RVA: 0x0009B36F File Offset: 0x0009956F
		public unsafe int MaxVertexIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimationTexture2DLOD.__PropertyOffset_MaxVertexIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimationTexture2DLOD.__PropertyOffset_MaxVertexIndex) = value;
			}
		}

		// Token: 0x17001969 RID: 6505
		// (get) Token: 0x06006BE8 RID: 27624 RVA: 0x0009B380 File Offset: 0x00099580
		// (set) Token: 0x06006BE9 RID: 27625 RVA: 0x0009B394 File Offset: 0x00099594
		public unsafe FVector2D PositionRangeX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimationTexture2DLOD.__PropertyOffset_PositionRangeX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimationTexture2DLOD.__PropertyOffset_PositionRangeX) = value;
			}
		}

		// Token: 0x1700196A RID: 6506
		// (get) Token: 0x06006BEA RID: 27626 RVA: 0x0009B3A9 File Offset: 0x000995A9
		// (set) Token: 0x06006BEB RID: 27627 RVA: 0x0009B3BD File Offset: 0x000995BD
		public unsafe FVector2D PositionRangeY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimationTexture2DLOD.__PropertyOffset_PositionRangeY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimationTexture2DLOD.__PropertyOffset_PositionRangeY) = value;
			}
		}

		// Token: 0x1700196B RID: 6507
		// (get) Token: 0x06006BEC RID: 27628 RVA: 0x0009B3D2 File Offset: 0x000995D2
		// (set) Token: 0x06006BED RID: 27629 RVA: 0x0009B3E6 File Offset: 0x000995E6
		public unsafe FVector2D PositionRangeZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimationTexture2DLOD.__PropertyOffset_PositionRangeZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimationTexture2DLOD.__PropertyOffset_PositionRangeZ) = value;
			}
		}

		// Token: 0x1700196C RID: 6508
		// (get) Token: 0x06006BEE RID: 27630 RVA: 0x0009B3FC File Offset: 0x000995FC
		// (set) Token: 0x06006BEF RID: 27631 RVA: 0x0009B43F File Offset: 0x0009963F
		public TArray<FAnimTextureFrameVertexInfo> VertexInfos
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAnimTextureFrameVertexInfo> result;
				if ((result = this._VertexInfos) == null)
				{
					result = (this._VertexInfos = new TArray<FAnimTextureFrameVertexInfo>(base.NativePtr + (IntPtr)FAnimationTexture2DLOD.__PropertyOffset_VertexInfos, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.VertexInfos.CopyAssign(value);
			}
		}

		// Token: 0x1700196D RID: 6509
		// (get) Token: 0x06006BF0 RID: 27632 RVA: 0x0009B450 File Offset: 0x00099650
		// (set) Token: 0x06006BF1 RID: 27633 RVA: 0x0009B493 File Offset: 0x00099693
		public TArray<FAnimTextureFrameData> FrameData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAnimTextureFrameData> result;
				if ((result = this._FrameData) == null)
				{
					result = (this._FrameData = new TArray<FAnimTextureFrameData>(base.NativePtr + (IntPtr)FAnimationTexture2DLOD.__PropertyOffset_FrameData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FrameData.CopyAssign(value);
			}
		}

		// Token: 0x06006BF2 RID: 27634 RVA: 0x0009B4A1 File Offset: 0x000996A1
		public FAnimationTexture2DLOD()
		{
		}

		// Token: 0x06006BF3 RID: 27635 RVA: 0x0009B4A9 File Offset: 0x000996A9
		public FAnimationTexture2DLOD(int NumVertices, int NumAnimationData, int MinVertexIndex, int MaxVertexIndex, FVector2D PositionRangeX, FVector2D PositionRangeY, FVector2D PositionRangeZ, TArray<FAnimTextureFrameVertexInfo> VertexInfos, TArray<FAnimTextureFrameData> FrameData, TArray<int> RawVertexIndices, TArray<FAnimTextureFrameData> RawFrameData, TArray<FVector> RawVertexPositions)
		{
			this.MinVertexIndex = MinVertexIndex;
			this.MaxVertexIndex = MaxVertexIndex;
			this.PositionRangeX = PositionRangeX;
			this.PositionRangeY = PositionRangeY;
			this.PositionRangeZ = PositionRangeZ;
			this.VertexInfos = VertexInfos;
			this.FrameData = FrameData;
		}

		// Token: 0x06006BF4 RID: 27636 RVA: 0x0009B4E8 File Offset: 0x000996E8
		protected override IntPtr GetUStructPtr()
		{
			return FAnimationTexture2DLOD.StaticStruct();
		}

		// Token: 0x06006BF5 RID: 27637 RVA: 0x0009B4F4 File Offset: 0x000996F4
		[NullableContext(2)]
		public FAnimationTexture2DLOD(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006BF6 RID: 27638 RVA: 0x0009B4FE File Offset: 0x000996FE
		public FAnimationTexture2DLOD(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006BF7 RID: 27639 RVA: 0x0009B509 File Offset: 0x00099709
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimationTexture2DLOD(Pointer, false, true);
		}

		// Token: 0x06006BF8 RID: 27640 RVA: 0x0009B513 File Offset: 0x00099713
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimationTexture2DLOD(Pointer, MemoryOwner);
		}

		// Token: 0x040033EB RID: 13291
		public const string __ObjectPath = "/Script/Engine.AnimationTexture2DLOD";

		// Token: 0x040033EC RID: 13292
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040033ED RID: 13293
		internal static int __PropertyOffset_MinVertexIndex;

		// Token: 0x040033EE RID: 13294
		internal static int __PropertyOffset_MaxVertexIndex;

		// Token: 0x040033EF RID: 13295
		internal static int __PropertyOffset_PositionRangeX;

		// Token: 0x040033F0 RID: 13296
		internal static int __PropertyOffset_PositionRangeY;

		// Token: 0x040033F1 RID: 13297
		internal static int __PropertyOffset_PositionRangeZ;

		// Token: 0x040033F2 RID: 13298
		internal static int __PropertyOffset_VertexInfos;

		// Token: 0x040033F3 RID: 13299
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAnimTextureFrameVertexInfo> _VertexInfos;

		// Token: 0x040033F4 RID: 13300
		internal static int __PropertyOffset_FrameData;

		// Token: 0x040033F5 RID: 13301
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAnimTextureFrameData> _FrameData;
	}
}
