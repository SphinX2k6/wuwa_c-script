using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020008F9 RID: 2297
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BuilderPoly")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FBuilderPoly : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007E06 RID: 32262 RVA: 0x000B4A1A File Offset: 0x000B2C1A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBuilderPoly._ScriptStructPtr != 0) ? FBuilderPoly._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BuilderPoly", ref FBuilderPoly._ScriptStructPtr);
		}

		// Token: 0x17001D9E RID: 7582
		// (get) Token: 0x06007E07 RID: 32263 RVA: 0x000B4A40 File Offset: 0x000B2C40
		// (set) Token: 0x06007E08 RID: 32264 RVA: 0x000B4A83 File Offset: 0x000B2C83
		public TArray<int> VertexIndices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._VertexIndices) == null)
				{
					result = (this._VertexIndices = new TArray<int>(base.NativePtr + (IntPtr)FBuilderPoly.__PropertyOffset_VertexIndices, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.VertexIndices.CopyAssign(value);
			}
		}

		// Token: 0x17001D9F RID: 7583
		// (get) Token: 0x06007E09 RID: 32265 RVA: 0x000B4A91 File Offset: 0x000B2C91
		// (set) Token: 0x06007E0A RID: 32266 RVA: 0x000B4AA1 File Offset: 0x000B2CA1
		public unsafe int Direction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBuilderPoly.__PropertyOffset_Direction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBuilderPoly.__PropertyOffset_Direction) = value;
			}
		}

		// Token: 0x17001DA0 RID: 7584
		// (get) Token: 0x06007E0B RID: 32267 RVA: 0x000B4AB2 File Offset: 0x000B2CB2
		// (set) Token: 0x06007E0C RID: 32268 RVA: 0x000B4AC6 File Offset: 0x000B2CC6
		public unsafe FName ItemName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBuilderPoly.__PropertyOffset_ItemName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBuilderPoly.__PropertyOffset_ItemName) = value;
			}
		}

		// Token: 0x17001DA1 RID: 7585
		// (get) Token: 0x06007E0D RID: 32269 RVA: 0x000B4ADB File Offset: 0x000B2CDB
		// (set) Token: 0x06007E0E RID: 32270 RVA: 0x000B4AEB File Offset: 0x000B2CEB
		public unsafe int PolyFlags
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBuilderPoly.__PropertyOffset_PolyFlags);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBuilderPoly.__PropertyOffset_PolyFlags) = value;
			}
		}

		// Token: 0x06007E0F RID: 32271 RVA: 0x000B4AFC File Offset: 0x000B2CFC
		public FBuilderPoly()
		{
		}

		// Token: 0x06007E10 RID: 32272 RVA: 0x000B4B04 File Offset: 0x000B2D04
		public FBuilderPoly(TArray<int> VertexIndices, int Direction, FName ItemName, int PolyFlags)
		{
			this.VertexIndices = VertexIndices;
			this.Direction = Direction;
			this.ItemName = ItemName;
			this.PolyFlags = PolyFlags;
		}

		// Token: 0x06007E11 RID: 32273 RVA: 0x000B4B29 File Offset: 0x000B2D29
		protected override IntPtr GetUStructPtr()
		{
			return FBuilderPoly.StaticStruct();
		}

		// Token: 0x06007E12 RID: 32274 RVA: 0x000B4B35 File Offset: 0x000B2D35
		[NullableContext(2)]
		public FBuilderPoly(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007E13 RID: 32275 RVA: 0x000B4B3F File Offset: 0x000B2D3F
		public FBuilderPoly(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007E14 RID: 32276 RVA: 0x000B4B4A File Offset: 0x000B2D4A
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBuilderPoly(Pointer, false, true);
		}

		// Token: 0x06007E15 RID: 32277 RVA: 0x000B4B54 File Offset: 0x000B2D54
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBuilderPoly(Pointer, MemoryOwner);
		}

		// Token: 0x04003C6D RID: 15469
		public const string __ObjectPath = "/Script/Engine.BuilderPoly";

		// Token: 0x04003C6E RID: 15470
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003C6F RID: 15471
		internal static int __PropertyOffset_VertexIndices;

		// Token: 0x04003C70 RID: 15472
		[Nullable(2)]
		private TArray<int> _VertexIndices;

		// Token: 0x04003C71 RID: 15473
		internal static int __PropertyOffset_Direction;

		// Token: 0x04003C72 RID: 15474
		internal static int __PropertyOffset_ItemName;

		// Token: 0x04003C73 RID: 15475
		internal static int __PropertyOffset_PolyFlags;
	}
}
