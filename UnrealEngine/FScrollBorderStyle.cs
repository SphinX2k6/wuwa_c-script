using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002827 RID: 10279
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SlateCore.ScrollBorderStyle")]
	[UnrealStructLayout(328, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 328)]
	public class FScrollBorderStyle : FSlateWidgetStyle, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026321 RID: 156449 RVA: 0x0039F7D8 File Offset: 0x0039D9D8
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FScrollBorderStyle._ScriptStructPtr != 0) ? FScrollBorderStyle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SlateCore.ScrollBorderStyle", ref FScrollBorderStyle._ScriptStructPtr);
		}

		// Token: 0x1700936D RID: 37741
		// (get) Token: 0x06026322 RID: 156450 RVA: 0x0039F7FC File Offset: 0x0039D9FC
		// (set) Token: 0x06026323 RID: 156451 RVA: 0x0039F83F File Offset: 0x0039DA3F
		public FSlateBrush TopShadowBrush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._TopShadowBrush) == null)
				{
					result = (this._TopShadowBrush = new FSlateBrush(base.NativePtr + (IntPtr)FScrollBorderStyle.__PropertyOffset_TopShadowBrush, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FScrollBorderStyle.__PropertyOffset_TopShadowBrush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700936E RID: 37742
		// (get) Token: 0x06026324 RID: 156452 RVA: 0x0039F860 File Offset: 0x0039DA60
		// (set) Token: 0x06026325 RID: 156453 RVA: 0x0039F8A3 File Offset: 0x0039DAA3
		public FSlateBrush BottomShadowBrush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._BottomShadowBrush) == null)
				{
					result = (this._BottomShadowBrush = new FSlateBrush(base.NativePtr + (IntPtr)FScrollBorderStyle.__PropertyOffset_BottomShadowBrush, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FScrollBorderStyle.__PropertyOffset_BottomShadowBrush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06026326 RID: 156454 RVA: 0x0039F8C4 File Offset: 0x0039DAC4
		public FScrollBorderStyle()
		{
		}

		// Token: 0x06026327 RID: 156455 RVA: 0x0039F8CC File Offset: 0x0039DACC
		public FScrollBorderStyle(FSlateBrush TopShadowBrush, FSlateBrush BottomShadowBrush)
		{
			this.TopShadowBrush = TopShadowBrush;
			this.BottomShadowBrush = BottomShadowBrush;
		}

		// Token: 0x06026328 RID: 156456 RVA: 0x0039F8E2 File Offset: 0x0039DAE2
		protected override IntPtr GetUStructPtr()
		{
			return FScrollBorderStyle.StaticStruct();
		}

		// Token: 0x06026329 RID: 156457 RVA: 0x0039F8EE File Offset: 0x0039DAEE
		[NullableContext(2)]
		public FScrollBorderStyle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602632A RID: 156458 RVA: 0x0039F8F8 File Offset: 0x0039DAF8
		public FScrollBorderStyle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602632B RID: 156459 RVA: 0x0039F903 File Offset: 0x0039DB03
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FScrollBorderStyle(Pointer, false, true);
		}

		// Token: 0x0602632C RID: 156460 RVA: 0x0039F90D File Offset: 0x0039DB0D
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FScrollBorderStyle(Pointer, MemoryOwner);
		}

		// Token: 0x04014E80 RID: 85632
		public new const string __ObjectPath = "/Script/SlateCore.ScrollBorderStyle";

		// Token: 0x04014E81 RID: 85633
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014E82 RID: 85634
		internal static int __PropertyOffset_TopShadowBrush;

		// Token: 0x04014E83 RID: 85635
		[Nullable(2)]
		private FSlateBrush _TopShadowBrush;

		// Token: 0x04014E84 RID: 85636
		internal static int __PropertyOffset_BottomShadowBrush;

		// Token: 0x04014E85 RID: 85637
		[Nullable(2)]
		private FSlateBrush _BottomShadowBrush;
	}
}
