using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002826 RID: 10278
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SlateCore.ScrollBarStyle")]
	[UnrealStructLayout(1448, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1448)]
	public class FScrollBarStyle : FSlateWidgetStyle, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026307 RID: 156423 RVA: 0x0039F399 File Offset: 0x0039D599
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FScrollBarStyle._ScriptStructPtr != 0) ? FScrollBarStyle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SlateCore.ScrollBarStyle", ref FScrollBarStyle._ScriptStructPtr);
		}

		// Token: 0x17009364 RID: 37732
		// (get) Token: 0x06026308 RID: 156424 RVA: 0x0039F3C0 File Offset: 0x0039D5C0
		// (set) Token: 0x06026309 RID: 156425 RVA: 0x0039F403 File Offset: 0x0039D603
		public FSlateBrush HorizontalBackgroundImage
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._HorizontalBackgroundImage) == null)
				{
					result = (this._HorizontalBackgroundImage = new FSlateBrush(base.NativePtr + (IntPtr)FScrollBarStyle.__PropertyOffset_HorizontalBackgroundImage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FScrollBarStyle.__PropertyOffset_HorizontalBackgroundImage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009365 RID: 37733
		// (get) Token: 0x0602630A RID: 156426 RVA: 0x0039F424 File Offset: 0x0039D624
		// (set) Token: 0x0602630B RID: 156427 RVA: 0x0039F467 File Offset: 0x0039D667
		public FSlateBrush VerticalBackgroundImage
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._VerticalBackgroundImage) == null)
				{
					result = (this._VerticalBackgroundImage = new FSlateBrush(base.NativePtr + (IntPtr)FScrollBarStyle.__PropertyOffset_VerticalBackgroundImage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FScrollBarStyle.__PropertyOffset_VerticalBackgroundImage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009366 RID: 37734
		// (get) Token: 0x0602630C RID: 156428 RVA: 0x0039F488 File Offset: 0x0039D688
		// (set) Token: 0x0602630D RID: 156429 RVA: 0x0039F4CB File Offset: 0x0039D6CB
		public FSlateBrush VerticalTopSlotImage
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._VerticalTopSlotImage) == null)
				{
					result = (this._VerticalTopSlotImage = new FSlateBrush(base.NativePtr + (IntPtr)FScrollBarStyle.__PropertyOffset_VerticalTopSlotImage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FScrollBarStyle.__PropertyOffset_VerticalTopSlotImage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009367 RID: 37735
		// (get) Token: 0x0602630E RID: 156430 RVA: 0x0039F4EC File Offset: 0x0039D6EC
		// (set) Token: 0x0602630F RID: 156431 RVA: 0x0039F52F File Offset: 0x0039D72F
		public FSlateBrush HorizontalTopSlotImage
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._HorizontalTopSlotImage) == null)
				{
					result = (this._HorizontalTopSlotImage = new FSlateBrush(base.NativePtr + (IntPtr)FScrollBarStyle.__PropertyOffset_HorizontalTopSlotImage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FScrollBarStyle.__PropertyOffset_HorizontalTopSlotImage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009368 RID: 37736
		// (get) Token: 0x06026310 RID: 156432 RVA: 0x0039F550 File Offset: 0x0039D750
		// (set) Token: 0x06026311 RID: 156433 RVA: 0x0039F593 File Offset: 0x0039D793
		public FSlateBrush VerticalBottomSlotImage
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._VerticalBottomSlotImage) == null)
				{
					result = (this._VerticalBottomSlotImage = new FSlateBrush(base.NativePtr + (IntPtr)FScrollBarStyle.__PropertyOffset_VerticalBottomSlotImage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FScrollBarStyle.__PropertyOffset_VerticalBottomSlotImage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009369 RID: 37737
		// (get) Token: 0x06026312 RID: 156434 RVA: 0x0039F5B4 File Offset: 0x0039D7B4
		// (set) Token: 0x06026313 RID: 156435 RVA: 0x0039F5F7 File Offset: 0x0039D7F7
		public FSlateBrush HorizontalBottomSlotImage
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._HorizontalBottomSlotImage) == null)
				{
					result = (this._HorizontalBottomSlotImage = new FSlateBrush(base.NativePtr + (IntPtr)FScrollBarStyle.__PropertyOffset_HorizontalBottomSlotImage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FScrollBarStyle.__PropertyOffset_HorizontalBottomSlotImage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700936A RID: 37738
		// (get) Token: 0x06026314 RID: 156436 RVA: 0x0039F618 File Offset: 0x0039D818
		// (set) Token: 0x06026315 RID: 156437 RVA: 0x0039F65B File Offset: 0x0039D85B
		public FSlateBrush NormalThumbImage
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._NormalThumbImage) == null)
				{
					result = (this._NormalThumbImage = new FSlateBrush(base.NativePtr + (IntPtr)FScrollBarStyle.__PropertyOffset_NormalThumbImage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FScrollBarStyle.__PropertyOffset_NormalThumbImage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700936B RID: 37739
		// (get) Token: 0x06026316 RID: 156438 RVA: 0x0039F67C File Offset: 0x0039D87C
		// (set) Token: 0x06026317 RID: 156439 RVA: 0x0039F6BF File Offset: 0x0039D8BF
		public FSlateBrush HoveredThumbImage
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._HoveredThumbImage) == null)
				{
					result = (this._HoveredThumbImage = new FSlateBrush(base.NativePtr + (IntPtr)FScrollBarStyle.__PropertyOffset_HoveredThumbImage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FScrollBarStyle.__PropertyOffset_HoveredThumbImage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700936C RID: 37740
		// (get) Token: 0x06026318 RID: 156440 RVA: 0x0039F6E0 File Offset: 0x0039D8E0
		// (set) Token: 0x06026319 RID: 156441 RVA: 0x0039F723 File Offset: 0x0039D923
		public FSlateBrush DraggedThumbImage
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._DraggedThumbImage) == null)
				{
					result = (this._DraggedThumbImage = new FSlateBrush(base.NativePtr + (IntPtr)FScrollBarStyle.__PropertyOffset_DraggedThumbImage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FScrollBarStyle.__PropertyOffset_DraggedThumbImage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602631A RID: 156442 RVA: 0x0039F744 File Offset: 0x0039D944
		public FScrollBarStyle()
		{
		}

		// Token: 0x0602631B RID: 156443 RVA: 0x0039F74C File Offset: 0x0039D94C
		public FScrollBarStyle(FSlateBrush HorizontalBackgroundImage, FSlateBrush VerticalBackgroundImage, FSlateBrush VerticalTopSlotImage, FSlateBrush HorizontalTopSlotImage, FSlateBrush VerticalBottomSlotImage, FSlateBrush HorizontalBottomSlotImage, FSlateBrush NormalThumbImage, FSlateBrush HoveredThumbImage, FSlateBrush DraggedThumbImage)
		{
			this.HorizontalBackgroundImage = HorizontalBackgroundImage;
			this.VerticalBackgroundImage = VerticalBackgroundImage;
			this.VerticalTopSlotImage = VerticalTopSlotImage;
			this.HorizontalTopSlotImage = HorizontalTopSlotImage;
			this.VerticalBottomSlotImage = VerticalBottomSlotImage;
			this.HorizontalBottomSlotImage = HorizontalBottomSlotImage;
			this.NormalThumbImage = NormalThumbImage;
			this.HoveredThumbImage = HoveredThumbImage;
			this.DraggedThumbImage = DraggedThumbImage;
		}

		// Token: 0x0602631C RID: 156444 RVA: 0x0039F7A4 File Offset: 0x0039D9A4
		protected override IntPtr GetUStructPtr()
		{
			return FScrollBarStyle.StaticStruct();
		}

		// Token: 0x0602631D RID: 156445 RVA: 0x0039F7B0 File Offset: 0x0039D9B0
		[NullableContext(2)]
		public FScrollBarStyle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602631E RID: 156446 RVA: 0x0039F7BA File Offset: 0x0039D9BA
		public FScrollBarStyle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602631F RID: 156447 RVA: 0x0039F7C5 File Offset: 0x0039D9C5
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FScrollBarStyle(Pointer, false, true);
		}

		// Token: 0x06026320 RID: 156448 RVA: 0x0039F7CF File Offset: 0x0039D9CF
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FScrollBarStyle(Pointer, MemoryOwner);
		}

		// Token: 0x04014E6C RID: 85612
		public new const string __ObjectPath = "/Script/SlateCore.ScrollBarStyle";

		// Token: 0x04014E6D RID: 85613
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014E6E RID: 85614
		internal static int __PropertyOffset_HorizontalBackgroundImage;

		// Token: 0x04014E6F RID: 85615
		[Nullable(2)]
		private FSlateBrush _HorizontalBackgroundImage;

		// Token: 0x04014E70 RID: 85616
		internal static int __PropertyOffset_VerticalBackgroundImage;

		// Token: 0x04014E71 RID: 85617
		[Nullable(2)]
		private FSlateBrush _VerticalBackgroundImage;

		// Token: 0x04014E72 RID: 85618
		internal static int __PropertyOffset_VerticalTopSlotImage;

		// Token: 0x04014E73 RID: 85619
		[Nullable(2)]
		private FSlateBrush _VerticalTopSlotImage;

		// Token: 0x04014E74 RID: 85620
		internal static int __PropertyOffset_HorizontalTopSlotImage;

		// Token: 0x04014E75 RID: 85621
		[Nullable(2)]
		private FSlateBrush _HorizontalTopSlotImage;

		// Token: 0x04014E76 RID: 85622
		internal static int __PropertyOffset_VerticalBottomSlotImage;

		// Token: 0x04014E77 RID: 85623
		[Nullable(2)]
		private FSlateBrush _VerticalBottomSlotImage;

		// Token: 0x04014E78 RID: 85624
		internal static int __PropertyOffset_HorizontalBottomSlotImage;

		// Token: 0x04014E79 RID: 85625
		[Nullable(2)]
		private FSlateBrush _HorizontalBottomSlotImage;

		// Token: 0x04014E7A RID: 85626
		internal static int __PropertyOffset_NormalThumbImage;

		// Token: 0x04014E7B RID: 85627
		[Nullable(2)]
		private FSlateBrush _NormalThumbImage;

		// Token: 0x04014E7C RID: 85628
		internal static int __PropertyOffset_HoveredThumbImage;

		// Token: 0x04014E7D RID: 85629
		[Nullable(2)]
		private FSlateBrush _HoveredThumbImage;

		// Token: 0x04014E7E RID: 85630
		internal static int __PropertyOffset_DraggedThumbImage;

		// Token: 0x04014E7F RID: 85631
		[Nullable(2)]
		private FSlateBrush _DraggedThumbImage;
	}
}
