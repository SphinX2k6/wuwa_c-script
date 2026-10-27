using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002835 RID: 10293
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SlateCore.SplitterStyle")]
	[UnrealStructLayout(328, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 328)]
	public class FSplitterStyle : FSlateWidgetStyle, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060263E5 RID: 156645 RVA: 0x003A0D1E File Offset: 0x0039EF1E
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSplitterStyle._ScriptStructPtr != 0) ? FSplitterStyle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SlateCore.SplitterStyle", ref FSplitterStyle._ScriptStructPtr);
		}

		// Token: 0x1700939F RID: 37791
		// (get) Token: 0x060263E6 RID: 156646 RVA: 0x003A0D44 File Offset: 0x0039EF44
		// (set) Token: 0x060263E7 RID: 156647 RVA: 0x003A0D87 File Offset: 0x0039EF87
		public FSlateBrush HandleNormalBrush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._HandleNormalBrush) == null)
				{
					result = (this._HandleNormalBrush = new FSlateBrush(base.NativePtr + (IntPtr)FSplitterStyle.__PropertyOffset_HandleNormalBrush, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FSplitterStyle.__PropertyOffset_HandleNormalBrush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170093A0 RID: 37792
		// (get) Token: 0x060263E8 RID: 156648 RVA: 0x003A0DA8 File Offset: 0x0039EFA8
		// (set) Token: 0x060263E9 RID: 156649 RVA: 0x003A0DEB File Offset: 0x0039EFEB
		public FSlateBrush HandleHighlightBrush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._HandleHighlightBrush) == null)
				{
					result = (this._HandleHighlightBrush = new FSlateBrush(base.NativePtr + (IntPtr)FSplitterStyle.__PropertyOffset_HandleHighlightBrush, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FSplitterStyle.__PropertyOffset_HandleHighlightBrush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060263EA RID: 156650 RVA: 0x003A0E0C File Offset: 0x0039F00C
		public FSplitterStyle()
		{
		}

		// Token: 0x060263EB RID: 156651 RVA: 0x003A0E14 File Offset: 0x0039F014
		public FSplitterStyle(FSlateBrush HandleNormalBrush, FSlateBrush HandleHighlightBrush)
		{
			this.HandleNormalBrush = HandleNormalBrush;
			this.HandleHighlightBrush = HandleHighlightBrush;
		}

		// Token: 0x060263EC RID: 156652 RVA: 0x003A0E2A File Offset: 0x0039F02A
		protected override IntPtr GetUStructPtr()
		{
			return FSplitterStyle.StaticStruct();
		}

		// Token: 0x060263ED RID: 156653 RVA: 0x003A0E36 File Offset: 0x0039F036
		[NullableContext(2)]
		public FSplitterStyle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060263EE RID: 156654 RVA: 0x003A0E40 File Offset: 0x0039F040
		public FSplitterStyle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060263EF RID: 156655 RVA: 0x003A0E4B File Offset: 0x0039F04B
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSplitterStyle(Pointer, false, true);
		}

		// Token: 0x060263F0 RID: 156656 RVA: 0x003A0E55 File Offset: 0x0039F055
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSplitterStyle(Pointer, MemoryOwner);
		}

		// Token: 0x04014EED RID: 85741
		public new const string __ObjectPath = "/Script/SlateCore.SplitterStyle";

		// Token: 0x04014EEE RID: 85742
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014EEF RID: 85743
		internal static int __PropertyOffset_HandleNormalBrush;

		// Token: 0x04014EF0 RID: 85744
		[Nullable(2)]
		private FSlateBrush _HandleNormalBrush;

		// Token: 0x04014EF1 RID: 85745
		internal static int __PropertyOffset_HandleHighlightBrush;

		// Token: 0x04014EF2 RID: 85746
		[Nullable(2)]
		private FSlateBrush _HandleHighlightBrush;
	}
}
