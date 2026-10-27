using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000A54 RID: 2644
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.EditorElement")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FEditorElement : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008F99 RID: 36761 RVA: 0x000CD860 File Offset: 0x000CBA60
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FEditorElement._ScriptStructPtr != 0) ? FEditorElement._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.EditorElement", ref FEditorElement._ScriptStructPtr);
		}

		// Token: 0x170021E8 RID: 8680
		// (get) Token: 0x06008F9A RID: 36762 RVA: 0x000CD884 File Offset: 0x000CBA84
		// (set) Token: 0x06008F9B RID: 36763 RVA: 0x000CD8C8 File Offset: 0x000CBAC8
		public TFixedArray<int> Indices
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<int> result;
				if ((result = this._Indices) == null)
				{
					result = (this._Indices = new TFixedArray<int>(base.NativePtr + (IntPtr)FEditorElement.__PropertyOffset_Indices, 3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Indices.CopyAssign(value);
			}
		}

		// Token: 0x170021E9 RID: 8681
		// (get) Token: 0x06008F9C RID: 36764 RVA: 0x000CD8D8 File Offset: 0x000CBAD8
		// (set) Token: 0x06008F9D RID: 36765 RVA: 0x000CD91C File Offset: 0x000CBB1C
		public TFixedArray<float> Weights
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<float> result;
				if ((result = this._Weights) == null)
				{
					result = (this._Weights = new TFixedArray<float>(base.NativePtr + (IntPtr)FEditorElement.__PropertyOffset_Weights, 3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Weights.CopyAssign(value);
			}
		}

		// Token: 0x06008F9E RID: 36766 RVA: 0x000CD92A File Offset: 0x000CBB2A
		public FEditorElement()
		{
		}

		// Token: 0x06008F9F RID: 36767 RVA: 0x000CD932 File Offset: 0x000CBB32
		public FEditorElement(TFixedArray<int> Indices, TFixedArray<float> Weights)
		{
			this.Indices = Indices;
			this.Weights = Weights;
		}

		// Token: 0x06008FA0 RID: 36768 RVA: 0x000CD948 File Offset: 0x000CBB48
		protected override IntPtr GetUStructPtr()
		{
			return FEditorElement.StaticStruct();
		}

		// Token: 0x06008FA1 RID: 36769 RVA: 0x000CD954 File Offset: 0x000CBB54
		[NullableContext(2)]
		public FEditorElement(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008FA2 RID: 36770 RVA: 0x000CD95E File Offset: 0x000CBB5E
		public FEditorElement(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008FA3 RID: 36771 RVA: 0x000CD969 File Offset: 0x000CBB69
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FEditorElement(Pointer, false, true);
		}

		// Token: 0x06008FA4 RID: 36772 RVA: 0x000CD973 File Offset: 0x000CBB73
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FEditorElement(Pointer, MemoryOwner);
		}

		// Token: 0x040046FB RID: 18171
		public const string __ObjectPath = "/Script/Engine.EditorElement";

		// Token: 0x040046FC RID: 18172
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040046FD RID: 18173
		internal static int __PropertyOffset_Indices;

		// Token: 0x040046FE RID: 18174
		[Nullable(2)]
		private TFixedArray<int> _Indices;

		// Token: 0x040046FF RID: 18175
		internal static int __PropertyOffset_Weights;

		// Token: 0x04004700 RID: 18176
		[Nullable(2)]
		private TFixedArray<float> _Weights;
	}
}
