using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020024B6 RID: 9398
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/NavigationSystem.WaterBasinTileData")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FWaterBasinTileData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602331B RID: 144155 RVA: 0x00340F22 File Offset: 0x0033F122
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWaterBasinTileData._ScriptStructPtr != 0) ? FWaterBasinTileData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/NavigationSystem.WaterBasinTileData", ref FWaterBasinTileData._ScriptStructPtr);
		}

		// Token: 0x1700875A RID: 34650
		// (get) Token: 0x0602331C RID: 144156 RVA: 0x00340F48 File Offset: 0x0033F148
		// (set) Token: 0x0602331D RID: 144157 RVA: 0x00340F8B File Offset: 0x0033F18B
		public TArray<int> BasinIds
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._BasinIds) == null)
				{
					result = (this._BasinIds = new TArray<int>(base.NativePtr + (IntPtr)FWaterBasinTileData.__PropertyOffset_BasinIds, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BasinIds.CopyAssign(value);
			}
		}

		// Token: 0x1700875B RID: 34651
		// (get) Token: 0x0602331E RID: 144158 RVA: 0x00340F9C File Offset: 0x0033F19C
		// (set) Token: 0x0602331F RID: 144159 RVA: 0x00340FDF File Offset: 0x0033F1DF
		public TArray<FWaterBasinSillEdge> SillEdges
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FWaterBasinSillEdge> result;
				if ((result = this._SillEdges) == null)
				{
					result = (this._SillEdges = new TArray<FWaterBasinSillEdge>(base.NativePtr + (IntPtr)FWaterBasinTileData.__PropertyOffset_SillEdges, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SillEdges.CopyAssign(value);
			}
		}

		// Token: 0x1700875C RID: 34652
		// (get) Token: 0x06023320 RID: 144160 RVA: 0x00340FF0 File Offset: 0x0033F1F0
		// (set) Token: 0x06023321 RID: 144161 RVA: 0x00341033 File Offset: 0x0033F233
		public TArray<FWaterBodyBasinPair> BodyBasins
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FWaterBodyBasinPair> result;
				if ((result = this._BodyBasins) == null)
				{
					result = (this._BodyBasins = new TArray<FWaterBodyBasinPair>(base.NativePtr + (IntPtr)FWaterBasinTileData.__PropertyOffset_BodyBasins, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BodyBasins.CopyAssign(value);
			}
		}

		// Token: 0x1700875D RID: 34653
		// (get) Token: 0x06023322 RID: 144162 RVA: 0x00341044 File Offset: 0x0033F244
		// (set) Token: 0x06023323 RID: 144163 RVA: 0x00341087 File Offset: 0x0033F287
		public TArray<FWaterBasinBoundarySpan> BoundarySpans
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FWaterBasinBoundarySpan> result;
				if ((result = this._BoundarySpans) == null)
				{
					result = (this._BoundarySpans = new TArray<FWaterBasinBoundarySpan>(base.NativePtr + (IntPtr)FWaterBasinTileData.__PropertyOffset_BoundarySpans, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BoundarySpans.CopyAssign(value);
			}
		}

		// Token: 0x06023324 RID: 144164 RVA: 0x00341095 File Offset: 0x0033F295
		public FWaterBasinTileData()
		{
		}

		// Token: 0x06023325 RID: 144165 RVA: 0x0034109D File Offset: 0x0033F29D
		public FWaterBasinTileData(TArray<int> BasinIds, TArray<FWaterBasinSillEdge> SillEdges, TArray<FWaterBodyBasinPair> BodyBasins, TArray<FWaterBasinBoundarySpan> BoundarySpans)
		{
			this.BasinIds = BasinIds;
			this.SillEdges = SillEdges;
			this.BodyBasins = BodyBasins;
			this.BoundarySpans = BoundarySpans;
		}

		// Token: 0x06023326 RID: 144166 RVA: 0x003410C2 File Offset: 0x0033F2C2
		protected override IntPtr GetUStructPtr()
		{
			return FWaterBasinTileData.StaticStruct();
		}

		// Token: 0x06023327 RID: 144167 RVA: 0x003410CE File Offset: 0x0033F2CE
		[NullableContext(2)]
		public FWaterBasinTileData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023328 RID: 144168 RVA: 0x003410D8 File Offset: 0x0033F2D8
		public FWaterBasinTileData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023329 RID: 144169 RVA: 0x003410E3 File Offset: 0x0033F2E3
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWaterBasinTileData(Pointer, false, true);
		}

		// Token: 0x0602332A RID: 144170 RVA: 0x003410ED File Offset: 0x0033F2ED
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWaterBasinTileData(Pointer, MemoryOwner);
		}

		// Token: 0x04012CBD RID: 76989
		public const string __ObjectPath = "/Script/NavigationSystem.WaterBasinTileData";

		// Token: 0x04012CBE RID: 76990
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012CBF RID: 76991
		internal static int __PropertyOffset_BasinIds;

		// Token: 0x04012CC0 RID: 76992
		[Nullable(2)]
		private TArray<int> _BasinIds;

		// Token: 0x04012CC1 RID: 76993
		internal static int __PropertyOffset_SillEdges;

		// Token: 0x04012CC2 RID: 76994
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FWaterBasinSillEdge> _SillEdges;

		// Token: 0x04012CC3 RID: 76995
		internal static int __PropertyOffset_BodyBasins;

		// Token: 0x04012CC4 RID: 76996
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FWaterBodyBasinPair> _BodyBasins;

		// Token: 0x04012CC5 RID: 76997
		internal static int __PropertyOffset_BoundarySpans;

		// Token: 0x04012CC6 RID: 76998
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FWaterBasinBoundarySpan> _BoundarySpans;
	}
}
