using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002828 RID: 10280
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SlateCore.ScrollBoxStyle")]
	[UnrealStructLayout(648, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 648)]
	public class FScrollBoxStyle : FSlateWidgetStyle, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602632D RID: 156461 RVA: 0x0039F916 File Offset: 0x0039DB16
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FScrollBoxStyle._ScriptStructPtr != 0) ? FScrollBoxStyle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SlateCore.ScrollBoxStyle", ref FScrollBoxStyle._ScriptStructPtr);
		}

		// Token: 0x1700936F RID: 37743
		// (get) Token: 0x0602632E RID: 156462 RVA: 0x0039F93C File Offset: 0x0039DB3C
		// (set) Token: 0x0602632F RID: 156463 RVA: 0x0039F97F File Offset: 0x0039DB7F
		public FSlateBrush TopShadowBrush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._TopShadowBrush) == null)
				{
					result = (this._TopShadowBrush = new FSlateBrush(base.NativePtr + (IntPtr)FScrollBoxStyle.__PropertyOffset_TopShadowBrush, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FScrollBoxStyle.__PropertyOffset_TopShadowBrush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009370 RID: 37744
		// (get) Token: 0x06026330 RID: 156464 RVA: 0x0039F9A0 File Offset: 0x0039DBA0
		// (set) Token: 0x06026331 RID: 156465 RVA: 0x0039F9E3 File Offset: 0x0039DBE3
		public FSlateBrush BottomShadowBrush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._BottomShadowBrush) == null)
				{
					result = (this._BottomShadowBrush = new FSlateBrush(base.NativePtr + (IntPtr)FScrollBoxStyle.__PropertyOffset_BottomShadowBrush, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FScrollBoxStyle.__PropertyOffset_BottomShadowBrush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009371 RID: 37745
		// (get) Token: 0x06026332 RID: 156466 RVA: 0x0039FA04 File Offset: 0x0039DC04
		// (set) Token: 0x06026333 RID: 156467 RVA: 0x0039FA47 File Offset: 0x0039DC47
		public FSlateBrush LeftShadowBrush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._LeftShadowBrush) == null)
				{
					result = (this._LeftShadowBrush = new FSlateBrush(base.NativePtr + (IntPtr)FScrollBoxStyle.__PropertyOffset_LeftShadowBrush, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FScrollBoxStyle.__PropertyOffset_LeftShadowBrush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009372 RID: 37746
		// (get) Token: 0x06026334 RID: 156468 RVA: 0x0039FA68 File Offset: 0x0039DC68
		// (set) Token: 0x06026335 RID: 156469 RVA: 0x0039FAAB File Offset: 0x0039DCAB
		public FSlateBrush RightShadowBrush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._RightShadowBrush) == null)
				{
					result = (this._RightShadowBrush = new FSlateBrush(base.NativePtr + (IntPtr)FScrollBoxStyle.__PropertyOffset_RightShadowBrush, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FScrollBoxStyle.__PropertyOffset_RightShadowBrush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06026336 RID: 156470 RVA: 0x0039FACC File Offset: 0x0039DCCC
		public FScrollBoxStyle()
		{
		}

		// Token: 0x06026337 RID: 156471 RVA: 0x0039FAD4 File Offset: 0x0039DCD4
		public FScrollBoxStyle(FSlateBrush TopShadowBrush, FSlateBrush BottomShadowBrush, FSlateBrush LeftShadowBrush, FSlateBrush RightShadowBrush)
		{
			this.TopShadowBrush = TopShadowBrush;
			this.BottomShadowBrush = BottomShadowBrush;
			this.LeftShadowBrush = LeftShadowBrush;
			this.RightShadowBrush = RightShadowBrush;
		}

		// Token: 0x06026338 RID: 156472 RVA: 0x0039FAF9 File Offset: 0x0039DCF9
		protected override IntPtr GetUStructPtr()
		{
			return FScrollBoxStyle.StaticStruct();
		}

		// Token: 0x06026339 RID: 156473 RVA: 0x0039FB05 File Offset: 0x0039DD05
		[NullableContext(2)]
		public FScrollBoxStyle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602633A RID: 156474 RVA: 0x0039FB0F File Offset: 0x0039DD0F
		public FScrollBoxStyle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602633B RID: 156475 RVA: 0x0039FB1A File Offset: 0x0039DD1A
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FScrollBoxStyle(Pointer, false, true);
		}

		// Token: 0x0602633C RID: 156476 RVA: 0x0039FB24 File Offset: 0x0039DD24
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FScrollBoxStyle(Pointer, MemoryOwner);
		}

		// Token: 0x04014E86 RID: 85638
		public new const string __ObjectPath = "/Script/SlateCore.ScrollBoxStyle";

		// Token: 0x04014E87 RID: 85639
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014E88 RID: 85640
		internal static int __PropertyOffset_TopShadowBrush;

		// Token: 0x04014E89 RID: 85641
		[Nullable(2)]
		private FSlateBrush _TopShadowBrush;

		// Token: 0x04014E8A RID: 85642
		internal static int __PropertyOffset_BottomShadowBrush;

		// Token: 0x04014E8B RID: 85643
		[Nullable(2)]
		private FSlateBrush _BottomShadowBrush;

		// Token: 0x04014E8C RID: 85644
		internal static int __PropertyOffset_LeftShadowBrush;

		// Token: 0x04014E8D RID: 85645
		[Nullable(2)]
		private FSlateBrush _LeftShadowBrush;

		// Token: 0x04014E8E RID: 85646
		internal static int __PropertyOffset_RightShadowBrush;

		// Token: 0x04014E8F RID: 85647
		[Nullable(2)]
		private FSlateBrush _RightShadowBrush;
	}
}
