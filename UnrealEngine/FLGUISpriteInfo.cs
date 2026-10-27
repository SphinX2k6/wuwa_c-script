using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020020CA RID: 8394
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUISpriteInfo")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 144)]
	public class FLGUISpriteInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F9DA RID: 129498 RVA: 0x002F0255 File Offset: 0x002EE455
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLGUISpriteInfo._ScriptStructPtr != 0) ? FLGUISpriteInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.LGUISpriteInfo", ref FLGUISpriteInfo._ScriptStructPtr);
		}

		// Token: 0x17007CA2 RID: 31906
		// (get) Token: 0x0601F9DB RID: 129499 RVA: 0x002F0279 File Offset: 0x002EE479
		// (set) Token: 0x0601F9DC RID: 129500 RVA: 0x002F0289 File Offset: 0x002EE489
		public unsafe ushort width
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_width);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_width) = (short)value;
			}
		}

		// Token: 0x17007CA3 RID: 31907
		// (get) Token: 0x0601F9DD RID: 129501 RVA: 0x002F029A File Offset: 0x002EE49A
		// (set) Token: 0x0601F9DE RID: 129502 RVA: 0x002F02AA File Offset: 0x002EE4AA
		public unsafe ushort height
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_height);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_height) = (short)value;
			}
		}

		// Token: 0x17007CA4 RID: 31908
		// (get) Token: 0x0601F9DF RID: 129503 RVA: 0x002F02BB File Offset: 0x002EE4BB
		// (set) Token: 0x0601F9E0 RID: 129504 RVA: 0x002F02CB File Offset: 0x002EE4CB
		public unsafe ushort borderLeft
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_borderLeft);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_borderLeft) = (short)value;
			}
		}

		// Token: 0x17007CA5 RID: 31909
		// (get) Token: 0x0601F9E1 RID: 129505 RVA: 0x002F02DC File Offset: 0x002EE4DC
		// (set) Token: 0x0601F9E2 RID: 129506 RVA: 0x002F02EC File Offset: 0x002EE4EC
		public unsafe ushort borderRight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_borderRight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_borderRight) = (short)value;
			}
		}

		// Token: 0x17007CA6 RID: 31910
		// (get) Token: 0x0601F9E3 RID: 129507 RVA: 0x002F02FD File Offset: 0x002EE4FD
		// (set) Token: 0x0601F9E4 RID: 129508 RVA: 0x002F030D File Offset: 0x002EE50D
		public unsafe ushort borderTop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_borderTop);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_borderTop) = (short)value;
			}
		}

		// Token: 0x17007CA7 RID: 31911
		// (get) Token: 0x0601F9E5 RID: 129509 RVA: 0x002F031E File Offset: 0x002EE51E
		// (set) Token: 0x0601F9E6 RID: 129510 RVA: 0x002F032E File Offset: 0x002EE52E
		public unsafe ushort borderBottom
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_borderBottom);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_borderBottom) = (short)value;
			}
		}

		// Token: 0x17007CA8 RID: 31912
		// (get) Token: 0x0601F9E7 RID: 129511 RVA: 0x002F033F File Offset: 0x002EE53F
		// (set) Token: 0x0601F9E8 RID: 129512 RVA: 0x002F034F File Offset: 0x002EE54F
		public unsafe ushort startLeft
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_startLeft);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_startLeft) = (short)value;
			}
		}

		// Token: 0x17007CA9 RID: 31913
		// (get) Token: 0x0601F9E9 RID: 129513 RVA: 0x002F0360 File Offset: 0x002EE560
		// (set) Token: 0x0601F9EA RID: 129514 RVA: 0x002F0370 File Offset: 0x002EE570
		public unsafe ushort endRight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_endRight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_endRight) = (short)value;
			}
		}

		// Token: 0x17007CAA RID: 31914
		// (get) Token: 0x0601F9EB RID: 129515 RVA: 0x002F0381 File Offset: 0x002EE581
		// (set) Token: 0x0601F9EC RID: 129516 RVA: 0x002F0391 File Offset: 0x002EE591
		public unsafe ushort endTop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_endTop);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_endTop) = (short)value;
			}
		}

		// Token: 0x17007CAB RID: 31915
		// (get) Token: 0x0601F9ED RID: 129517 RVA: 0x002F03A2 File Offset: 0x002EE5A2
		// (set) Token: 0x0601F9EE RID: 129518 RVA: 0x002F03B2 File Offset: 0x002EE5B2
		public unsafe ushort startBottom
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_startBottom);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_startBottom) = (short)value;
			}
		}

		// Token: 0x17007CAC RID: 31916
		// (get) Token: 0x0601F9EF RID: 129519 RVA: 0x002F03C4 File Offset: 0x002EE5C4
		// (set) Token: 0x0601F9F0 RID: 129520 RVA: 0x002F0407 File Offset: 0x002EE607
		public TArray<ushort> borderHorizontalArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ushort> result;
				if ((result = this._borderHorizontalArray) == null)
				{
					result = (this._borderHorizontalArray = new TArray<ushort>(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_borderHorizontalArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.borderHorizontalArray.CopyAssign(value);
			}
		}

		// Token: 0x17007CAD RID: 31917
		// (get) Token: 0x0601F9F1 RID: 129521 RVA: 0x002F0418 File Offset: 0x002EE618
		// (set) Token: 0x0601F9F2 RID: 129522 RVA: 0x002F045B File Offset: 0x002EE65B
		public TArray<ushort> borderVerticalArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ushort> result;
				if ((result = this._borderVerticalArray) == null)
				{
					result = (this._borderVerticalArray = new TArray<ushort>(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_borderVerticalArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.borderVerticalArray.CopyAssign(value);
			}
		}

		// Token: 0x17007CAE RID: 31918
		// (get) Token: 0x0601F9F3 RID: 129523 RVA: 0x002F0469 File Offset: 0x002EE669
		// (set) Token: 0x0601F9F4 RID: 129524 RVA: 0x002F0479 File Offset: 0x002EE679
		public unsafe short paddingLeft
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_paddingLeft);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_paddingLeft) = value;
			}
		}

		// Token: 0x17007CAF RID: 31919
		// (get) Token: 0x0601F9F5 RID: 129525 RVA: 0x002F048A File Offset: 0x002EE68A
		// (set) Token: 0x0601F9F6 RID: 129526 RVA: 0x002F049A File Offset: 0x002EE69A
		public unsafe short paddingRight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_paddingRight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_paddingRight) = value;
			}
		}

		// Token: 0x17007CB0 RID: 31920
		// (get) Token: 0x0601F9F7 RID: 129527 RVA: 0x002F04AB File Offset: 0x002EE6AB
		// (set) Token: 0x0601F9F8 RID: 129528 RVA: 0x002F04BB File Offset: 0x002EE6BB
		public unsafe short paddingTop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_paddingTop);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_paddingTop) = value;
			}
		}

		// Token: 0x17007CB1 RID: 31921
		// (get) Token: 0x0601F9F9 RID: 129529 RVA: 0x002F04CC File Offset: 0x002EE6CC
		// (set) Token: 0x0601F9FA RID: 129530 RVA: 0x002F04DC File Offset: 0x002EE6DC
		public unsafe short paddingBottom
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_paddingBottom);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_paddingBottom) = value;
			}
		}

		// Token: 0x17007CB2 RID: 31922
		// (get) Token: 0x0601F9FB RID: 129531 RVA: 0x002F04ED File Offset: 0x002EE6ED
		// (set) Token: 0x0601F9FC RID: 129532 RVA: 0x002F04FD File Offset: 0x002EE6FD
		public unsafe float uv0X
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_uv0X);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_uv0X) = value;
			}
		}

		// Token: 0x17007CB3 RID: 31923
		// (get) Token: 0x0601F9FD RID: 129533 RVA: 0x002F050E File Offset: 0x002EE70E
		// (set) Token: 0x0601F9FE RID: 129534 RVA: 0x002F051E File Offset: 0x002EE71E
		public unsafe float uv0Y
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_uv0Y);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_uv0Y) = value;
			}
		}

		// Token: 0x17007CB4 RID: 31924
		// (get) Token: 0x0601F9FF RID: 129535 RVA: 0x002F052F File Offset: 0x002EE72F
		// (set) Token: 0x0601FA00 RID: 129536 RVA: 0x002F053F File Offset: 0x002EE73F
		public unsafe float uv3X
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_uv3X);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_uv3X) = value;
			}
		}

		// Token: 0x17007CB5 RID: 31925
		// (get) Token: 0x0601FA01 RID: 129537 RVA: 0x002F0550 File Offset: 0x002EE750
		// (set) Token: 0x0601FA02 RID: 129538 RVA: 0x002F0560 File Offset: 0x002EE760
		public unsafe float uv3Y
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_uv3Y);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_uv3Y) = value;
			}
		}

		// Token: 0x17007CB6 RID: 31926
		// (get) Token: 0x0601FA03 RID: 129539 RVA: 0x002F0571 File Offset: 0x002EE771
		// (set) Token: 0x0601FA04 RID: 129540 RVA: 0x002F0581 File Offset: 0x002EE781
		public unsafe float uvse0X
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_uvse0X);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_uvse0X) = value;
			}
		}

		// Token: 0x17007CB7 RID: 31927
		// (get) Token: 0x0601FA05 RID: 129541 RVA: 0x002F0592 File Offset: 0x002EE792
		// (set) Token: 0x0601FA06 RID: 129542 RVA: 0x002F05A2 File Offset: 0x002EE7A2
		public unsafe float uvse0Y
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_uvse0Y);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_uvse0Y) = value;
			}
		}

		// Token: 0x17007CB8 RID: 31928
		// (get) Token: 0x0601FA07 RID: 129543 RVA: 0x002F05B3 File Offset: 0x002EE7B3
		// (set) Token: 0x0601FA08 RID: 129544 RVA: 0x002F05C3 File Offset: 0x002EE7C3
		public unsafe float uvse3X
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_uvse3X);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_uvse3X) = value;
			}
		}

		// Token: 0x17007CB9 RID: 31929
		// (get) Token: 0x0601FA09 RID: 129545 RVA: 0x002F05D4 File Offset: 0x002EE7D4
		// (set) Token: 0x0601FA0A RID: 129546 RVA: 0x002F05E4 File Offset: 0x002EE7E4
		public unsafe float uvse3Y
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_uvse3Y);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_uvse3Y) = value;
			}
		}

		// Token: 0x17007CBA RID: 31930
		// (get) Token: 0x0601FA0B RID: 129547 RVA: 0x002F05F5 File Offset: 0x002EE7F5
		// (set) Token: 0x0601FA0C RID: 129548 RVA: 0x002F0605 File Offset: 0x002EE805
		public unsafe float buv0X
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_buv0X);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_buv0X) = value;
			}
		}

		// Token: 0x17007CBB RID: 31931
		// (get) Token: 0x0601FA0D RID: 129549 RVA: 0x002F0616 File Offset: 0x002EE816
		// (set) Token: 0x0601FA0E RID: 129550 RVA: 0x002F0626 File Offset: 0x002EE826
		public unsafe float buv0Y
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_buv0Y);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_buv0Y) = value;
			}
		}

		// Token: 0x17007CBC RID: 31932
		// (get) Token: 0x0601FA0F RID: 129551 RVA: 0x002F0637 File Offset: 0x002EE837
		// (set) Token: 0x0601FA10 RID: 129552 RVA: 0x002F0647 File Offset: 0x002EE847
		public unsafe float buv3X
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_buv3X);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_buv3X) = value;
			}
		}

		// Token: 0x17007CBD RID: 31933
		// (get) Token: 0x0601FA11 RID: 129553 RVA: 0x002F0658 File Offset: 0x002EE858
		// (set) Token: 0x0601FA12 RID: 129554 RVA: 0x002F0668 File Offset: 0x002EE868
		public unsafe float buv3Y
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_buv3Y);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_buv3Y) = value;
			}
		}

		// Token: 0x17007CBE RID: 31934
		// (get) Token: 0x0601FA13 RID: 129555 RVA: 0x002F067C File Offset: 0x002EE87C
		// (set) Token: 0x0601FA14 RID: 129556 RVA: 0x002F06BF File Offset: 0x002EE8BF
		public TArray<float> borderUVArrayX
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._borderUVArrayX) == null)
				{
					result = (this._borderUVArrayX = new TArray<float>(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_borderUVArrayX, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.borderUVArrayX.CopyAssign(value);
			}
		}

		// Token: 0x17007CBF RID: 31935
		// (get) Token: 0x0601FA15 RID: 129557 RVA: 0x002F06D0 File Offset: 0x002EE8D0
		// (set) Token: 0x0601FA16 RID: 129558 RVA: 0x002F0713 File Offset: 0x002EE913
		public TArray<float> borderUVArrayY
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._borderUVArrayY) == null)
				{
					result = (this._borderUVArrayY = new TArray<float>(base.NativePtr + (IntPtr)FLGUISpriteInfo.__PropertyOffset_borderUVArrayY, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.borderUVArrayY.CopyAssign(value);
			}
		}

		// Token: 0x0601FA17 RID: 129559 RVA: 0x002F0721 File Offset: 0x002EE921
		public FLGUISpriteInfo()
		{
		}

		// Token: 0x0601FA18 RID: 129560 RVA: 0x002F072C File Offset: 0x002EE92C
		public FLGUISpriteInfo(ushort width, ushort height, ushort borderLeft, ushort borderRight, ushort borderTop, ushort borderBottom, ushort startLeft, ushort endRight, ushort endTop, ushort startBottom, TArray<ushort> borderHorizontalArray, TArray<ushort> borderVerticalArray, short paddingLeft, short paddingRight, short paddingTop, short paddingBottom, float uv0X, float uv0Y, float uv3X, float uv3Y, float uvse0X, float uvse0Y, float uvse3X, float uvse3Y, float buv0X, float buv0Y, float buv3X, float buv3Y, TArray<float> borderUVArrayX, TArray<float> borderUVArrayY)
		{
			this.width = width;
			this.height = height;
			this.borderLeft = borderLeft;
			this.borderRight = borderRight;
			this.borderTop = borderTop;
			this.borderBottom = borderBottom;
			this.startLeft = startLeft;
			this.endRight = endRight;
			this.endTop = endTop;
			this.startBottom = startBottom;
			this.borderHorizontalArray = borderHorizontalArray;
			this.borderVerticalArray = borderVerticalArray;
			this.paddingLeft = paddingLeft;
			this.paddingRight = paddingRight;
			this.paddingTop = paddingTop;
			this.paddingBottom = paddingBottom;
			this.uv0X = uv0X;
			this.uv0Y = uv0Y;
			this.uv3X = uv3X;
			this.uv3Y = uv3Y;
			this.uvse0X = uvse0X;
			this.uvse0Y = uvse0Y;
			this.uvse3X = uvse3X;
			this.uvse3Y = uvse3Y;
			this.buv0X = buv0X;
			this.buv0Y = buv0Y;
			this.buv3X = buv3X;
			this.buv3Y = buv3Y;
			this.borderUVArrayX = borderUVArrayX;
			this.borderUVArrayY = borderUVArrayY;
		}

		// Token: 0x0601FA19 RID: 129561 RVA: 0x002F082C File Offset: 0x002EEA2C
		protected override IntPtr GetUStructPtr()
		{
			return FLGUISpriteInfo.StaticStruct();
		}

		// Token: 0x0601FA1A RID: 129562 RVA: 0x002F0838 File Offset: 0x002EEA38
		[NullableContext(2)]
		public FLGUISpriteInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FA1B RID: 129563 RVA: 0x002F0842 File Offset: 0x002EEA42
		public FLGUISpriteInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FA1C RID: 129564 RVA: 0x002F084D File Offset: 0x002EEA4D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLGUISpriteInfo(Pointer, false, true);
		}

		// Token: 0x0601FA1D RID: 129565 RVA: 0x002F0857 File Offset: 0x002EEA57
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLGUISpriteInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040110FE RID: 69886
		public const string __ObjectPath = "/Script/LGUI.LGUISpriteInfo";

		// Token: 0x040110FF RID: 69887
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011100 RID: 69888
		internal static int __PropertyOffset_width;

		// Token: 0x04011101 RID: 69889
		internal static int __PropertyOffset_height;

		// Token: 0x04011102 RID: 69890
		internal static int __PropertyOffset_borderLeft;

		// Token: 0x04011103 RID: 69891
		internal static int __PropertyOffset_borderRight;

		// Token: 0x04011104 RID: 69892
		internal static int __PropertyOffset_borderTop;

		// Token: 0x04011105 RID: 69893
		internal static int __PropertyOffset_borderBottom;

		// Token: 0x04011106 RID: 69894
		internal static int __PropertyOffset_startLeft;

		// Token: 0x04011107 RID: 69895
		internal static int __PropertyOffset_endRight;

		// Token: 0x04011108 RID: 69896
		internal static int __PropertyOffset_endTop;

		// Token: 0x04011109 RID: 69897
		internal static int __PropertyOffset_startBottom;

		// Token: 0x0401110A RID: 69898
		internal static int __PropertyOffset_borderHorizontalArray;

		// Token: 0x0401110B RID: 69899
		[Nullable(2)]
		private TArray<ushort> _borderHorizontalArray;

		// Token: 0x0401110C RID: 69900
		internal static int __PropertyOffset_borderVerticalArray;

		// Token: 0x0401110D RID: 69901
		[Nullable(2)]
		private TArray<ushort> _borderVerticalArray;

		// Token: 0x0401110E RID: 69902
		internal static int __PropertyOffset_paddingLeft;

		// Token: 0x0401110F RID: 69903
		internal static int __PropertyOffset_paddingRight;

		// Token: 0x04011110 RID: 69904
		internal static int __PropertyOffset_paddingTop;

		// Token: 0x04011111 RID: 69905
		internal static int __PropertyOffset_paddingBottom;

		// Token: 0x04011112 RID: 69906
		internal static int __PropertyOffset_uv0X;

		// Token: 0x04011113 RID: 69907
		internal static int __PropertyOffset_uv0Y;

		// Token: 0x04011114 RID: 69908
		internal static int __PropertyOffset_uv3X;

		// Token: 0x04011115 RID: 69909
		internal static int __PropertyOffset_uv3Y;

		// Token: 0x04011116 RID: 69910
		internal static int __PropertyOffset_uvse0X;

		// Token: 0x04011117 RID: 69911
		internal static int __PropertyOffset_uvse0Y;

		// Token: 0x04011118 RID: 69912
		internal static int __PropertyOffset_uvse3X;

		// Token: 0x04011119 RID: 69913
		internal static int __PropertyOffset_uvse3Y;

		// Token: 0x0401111A RID: 69914
		internal static int __PropertyOffset_buv0X;

		// Token: 0x0401111B RID: 69915
		internal static int __PropertyOffset_buv0Y;

		// Token: 0x0401111C RID: 69916
		internal static int __PropertyOffset_buv3X;

		// Token: 0x0401111D RID: 69917
		internal static int __PropertyOffset_buv3Y;

		// Token: 0x0401111E RID: 69918
		internal static int __PropertyOffset_borderUVArrayX;

		// Token: 0x0401111F RID: 69919
		[Nullable(2)]
		private TArray<float> _borderUVArrayX;

		// Token: 0x04011120 RID: 69920
		internal static int __PropertyOffset_borderUVArrayY;

		// Token: 0x04011121 RID: 69921
		[Nullable(2)]
		private TArray<float> _borderUVArrayY;
	}
}
