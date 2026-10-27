using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002813 RID: 10259
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SlateCore.ExpandableAreaStyle")]
	[UnrealStructLayout(336, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 336)]
	public class FExpandableAreaStyle : FSlateWidgetStyle, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602624E RID: 156238 RVA: 0x0039E369 File Offset: 0x0039C569
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FExpandableAreaStyle._ScriptStructPtr != 0) ? FExpandableAreaStyle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SlateCore.ExpandableAreaStyle", ref FExpandableAreaStyle._ScriptStructPtr);
		}

		// Token: 0x17009347 RID: 37703
		// (get) Token: 0x0602624F RID: 156239 RVA: 0x0039E390 File Offset: 0x0039C590
		// (set) Token: 0x06026250 RID: 156240 RVA: 0x0039E3D3 File Offset: 0x0039C5D3
		public FSlateBrush CollapsedImage
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._CollapsedImage) == null)
				{
					result = (this._CollapsedImage = new FSlateBrush(base.NativePtr + (IntPtr)FExpandableAreaStyle.__PropertyOffset_CollapsedImage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FExpandableAreaStyle.__PropertyOffset_CollapsedImage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009348 RID: 37704
		// (get) Token: 0x06026251 RID: 156241 RVA: 0x0039E3F4 File Offset: 0x0039C5F4
		// (set) Token: 0x06026252 RID: 156242 RVA: 0x0039E437 File Offset: 0x0039C637
		public FSlateBrush ExpandedImage
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._ExpandedImage) == null)
				{
					result = (this._ExpandedImage = new FSlateBrush(base.NativePtr + (IntPtr)FExpandableAreaStyle.__PropertyOffset_ExpandedImage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FExpandableAreaStyle.__PropertyOffset_ExpandedImage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009349 RID: 37705
		// (get) Token: 0x06026253 RID: 156243 RVA: 0x0039E458 File Offset: 0x0039C658
		// (set) Token: 0x06026254 RID: 156244 RVA: 0x0039E468 File Offset: 0x0039C668
		public unsafe float RolloutAnimationSeconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FExpandableAreaStyle.__PropertyOffset_RolloutAnimationSeconds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FExpandableAreaStyle.__PropertyOffset_RolloutAnimationSeconds) = value;
			}
		}

		// Token: 0x06026255 RID: 156245 RVA: 0x0039E479 File Offset: 0x0039C679
		public FExpandableAreaStyle()
		{
		}

		// Token: 0x06026256 RID: 156246 RVA: 0x0039E481 File Offset: 0x0039C681
		public FExpandableAreaStyle(FSlateBrush CollapsedImage, FSlateBrush ExpandedImage, float RolloutAnimationSeconds)
		{
			this.CollapsedImage = CollapsedImage;
			this.ExpandedImage = ExpandedImage;
			this.RolloutAnimationSeconds = RolloutAnimationSeconds;
		}

		// Token: 0x06026257 RID: 156247 RVA: 0x0039E49E File Offset: 0x0039C69E
		protected override IntPtr GetUStructPtr()
		{
			return FExpandableAreaStyle.StaticStruct();
		}

		// Token: 0x06026258 RID: 156248 RVA: 0x0039E4AA File Offset: 0x0039C6AA
		[NullableContext(2)]
		public FExpandableAreaStyle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026259 RID: 156249 RVA: 0x0039E4B4 File Offset: 0x0039C6B4
		public FExpandableAreaStyle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602625A RID: 156250 RVA: 0x0039E4BF File Offset: 0x0039C6BF
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FExpandableAreaStyle(Pointer, false, true);
		}

		// Token: 0x0602625B RID: 156251 RVA: 0x0039E4C9 File Offset: 0x0039C6C9
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FExpandableAreaStyle(Pointer, MemoryOwner);
		}

		// Token: 0x04014E16 RID: 85526
		public new const string __ObjectPath = "/Script/SlateCore.ExpandableAreaStyle";

		// Token: 0x04014E17 RID: 85527
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014E18 RID: 85528
		internal static int __PropertyOffset_CollapsedImage;

		// Token: 0x04014E19 RID: 85529
		[Nullable(2)]
		private FSlateBrush _CollapsedImage;

		// Token: 0x04014E1A RID: 85530
		internal static int __PropertyOffset_ExpandedImage;

		// Token: 0x04014E1B RID: 85531
		[Nullable(2)]
		private FSlateBrush _ExpandedImage;

		// Token: 0x04014E1C RID: 85532
		internal static int __PropertyOffset_RolloutAnimationSeconds;
	}
}
