using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020027EB RID: 10219
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SlateCore.ButtonStyle")]
	[UnrealStructLayout(768, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 768)]
	public class FButtonStyle : FSlateWidgetStyle, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026166 RID: 156006 RVA: 0x0039C4B4 File Offset: 0x0039A6B4
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FButtonStyle._ScriptStructPtr != 0) ? FButtonStyle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SlateCore.ButtonStyle", ref FButtonStyle._ScriptStructPtr);
		}

		// Token: 0x17009302 RID: 37634
		// (get) Token: 0x06026167 RID: 156007 RVA: 0x0039C4D8 File Offset: 0x0039A6D8
		// (set) Token: 0x06026168 RID: 156008 RVA: 0x0039C51B File Offset: 0x0039A71B
		public FSlateBrush Normal
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._Normal) == null)
				{
					result = (this._Normal = new FSlateBrush(base.NativePtr + (IntPtr)FButtonStyle.__PropertyOffset_Normal, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FButtonStyle.__PropertyOffset_Normal, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009303 RID: 37635
		// (get) Token: 0x06026169 RID: 156009 RVA: 0x0039C53C File Offset: 0x0039A73C
		// (set) Token: 0x0602616A RID: 156010 RVA: 0x0039C57F File Offset: 0x0039A77F
		public FSlateBrush Hovered
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._Hovered) == null)
				{
					result = (this._Hovered = new FSlateBrush(base.NativePtr + (IntPtr)FButtonStyle.__PropertyOffset_Hovered, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FButtonStyle.__PropertyOffset_Hovered, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009304 RID: 37636
		// (get) Token: 0x0602616B RID: 156011 RVA: 0x0039C5A0 File Offset: 0x0039A7A0
		// (set) Token: 0x0602616C RID: 156012 RVA: 0x0039C5E3 File Offset: 0x0039A7E3
		public FSlateBrush Pressed
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._Pressed) == null)
				{
					result = (this._Pressed = new FSlateBrush(base.NativePtr + (IntPtr)FButtonStyle.__PropertyOffset_Pressed, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FButtonStyle.__PropertyOffset_Pressed, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009305 RID: 37637
		// (get) Token: 0x0602616D RID: 156013 RVA: 0x0039C604 File Offset: 0x0039A804
		// (set) Token: 0x0602616E RID: 156014 RVA: 0x0039C647 File Offset: 0x0039A847
		public FSlateBrush Disabled
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._Disabled) == null)
				{
					result = (this._Disabled = new FSlateBrush(base.NativePtr + (IntPtr)FButtonStyle.__PropertyOffset_Disabled, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FButtonStyle.__PropertyOffset_Disabled, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009306 RID: 37638
		// (get) Token: 0x0602616F RID: 156015 RVA: 0x0039C668 File Offset: 0x0039A868
		// (set) Token: 0x06026170 RID: 156016 RVA: 0x0039C67C File Offset: 0x0039A87C
		public unsafe FMargin NormalPadding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FButtonStyle.__PropertyOffset_NormalPadding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FButtonStyle.__PropertyOffset_NormalPadding) = value;
			}
		}

		// Token: 0x17009307 RID: 37639
		// (get) Token: 0x06026171 RID: 156017 RVA: 0x0039C691 File Offset: 0x0039A891
		// (set) Token: 0x06026172 RID: 156018 RVA: 0x0039C6A5 File Offset: 0x0039A8A5
		public unsafe FMargin PressedPadding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FButtonStyle.__PropertyOffset_PressedPadding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FButtonStyle.__PropertyOffset_PressedPadding) = value;
			}
		}

		// Token: 0x17009308 RID: 37640
		// (get) Token: 0x06026173 RID: 156019 RVA: 0x0039C6BC File Offset: 0x0039A8BC
		// (set) Token: 0x06026174 RID: 156020 RVA: 0x0039C6FF File Offset: 0x0039A8FF
		public FSlateSound PressedSlateSound
		{
			get
			{
				base.FastCheckIsValid();
				FSlateSound result;
				if ((result = this._PressedSlateSound) == null)
				{
					result = (this._PressedSlateSound = new FSlateSound(base.NativePtr + (IntPtr)FButtonStyle.__PropertyOffset_PressedSlateSound, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateSound.StaticStruct(), base.NativePtr + (IntPtr)FButtonStyle.__PropertyOffset_PressedSlateSound, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009309 RID: 37641
		// (get) Token: 0x06026175 RID: 156021 RVA: 0x0039C720 File Offset: 0x0039A920
		// (set) Token: 0x06026176 RID: 156022 RVA: 0x0039C763 File Offset: 0x0039A963
		public FSlateSound HoveredSlateSound
		{
			get
			{
				base.FastCheckIsValid();
				FSlateSound result;
				if ((result = this._HoveredSlateSound) == null)
				{
					result = (this._HoveredSlateSound = new FSlateSound(base.NativePtr + (IntPtr)FButtonStyle.__PropertyOffset_HoveredSlateSound, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateSound.StaticStruct(), base.NativePtr + (IntPtr)FButtonStyle.__PropertyOffset_HoveredSlateSound, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06026177 RID: 156023 RVA: 0x0039C784 File Offset: 0x0039A984
		public FButtonStyle()
		{
		}

		// Token: 0x06026178 RID: 156024 RVA: 0x0039C78C File Offset: 0x0039A98C
		public FButtonStyle(FSlateBrush Normal, FSlateBrush Hovered, FSlateBrush Pressed, FSlateBrush Disabled, FMargin NormalPadding, FMargin PressedPadding, FSlateSound PressedSlateSound, FSlateSound HoveredSlateSound, FName PressedSound_DEPRECATED, FName HoveredSound_DEPRECATED)
		{
			this.Normal = Normal;
			this.Hovered = Hovered;
			this.Pressed = Pressed;
			this.Disabled = Disabled;
			this.NormalPadding = NormalPadding;
			this.PressedPadding = PressedPadding;
			this.PressedSlateSound = PressedSlateSound;
			this.HoveredSlateSound = HoveredSlateSound;
		}

		// Token: 0x06026179 RID: 156025 RVA: 0x0039C7DC File Offset: 0x0039A9DC
		protected override IntPtr GetUStructPtr()
		{
			return FButtonStyle.StaticStruct();
		}

		// Token: 0x0602617A RID: 156026 RVA: 0x0039C7E8 File Offset: 0x0039A9E8
		[NullableContext(2)]
		public FButtonStyle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602617B RID: 156027 RVA: 0x0039C7F2 File Offset: 0x0039A9F2
		public FButtonStyle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602617C RID: 156028 RVA: 0x0039C7FD File Offset: 0x0039A9FD
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FButtonStyle(Pointer, false, true);
		}

		// Token: 0x0602617D RID: 156029 RVA: 0x0039C807 File Offset: 0x0039AA07
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FButtonStyle(Pointer, MemoryOwner);
		}

		// Token: 0x04014CD6 RID: 85206
		public new const string __ObjectPath = "/Script/SlateCore.ButtonStyle";

		// Token: 0x04014CD7 RID: 85207
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014CD8 RID: 85208
		internal static int __PropertyOffset_Normal;

		// Token: 0x04014CD9 RID: 85209
		[Nullable(2)]
		private FSlateBrush _Normal;

		// Token: 0x04014CDA RID: 85210
		internal static int __PropertyOffset_Hovered;

		// Token: 0x04014CDB RID: 85211
		[Nullable(2)]
		private FSlateBrush _Hovered;

		// Token: 0x04014CDC RID: 85212
		internal static int __PropertyOffset_Pressed;

		// Token: 0x04014CDD RID: 85213
		[Nullable(2)]
		private FSlateBrush _Pressed;

		// Token: 0x04014CDE RID: 85214
		internal static int __PropertyOffset_Disabled;

		// Token: 0x04014CDF RID: 85215
		[Nullable(2)]
		private FSlateBrush _Disabled;

		// Token: 0x04014CE0 RID: 85216
		internal static int __PropertyOffset_NormalPadding;

		// Token: 0x04014CE1 RID: 85217
		internal static int __PropertyOffset_PressedPadding;

		// Token: 0x04014CE2 RID: 85218
		internal static int __PropertyOffset_PressedSlateSound;

		// Token: 0x04014CE3 RID: 85219
		[Nullable(2)]
		private FSlateSound _PressedSlateSound;

		// Token: 0x04014CE4 RID: 85220
		internal static int __PropertyOffset_HoveredSlateSound;

		// Token: 0x04014CE5 RID: 85221
		[Nullable(2)]
		private FSlateSound _HoveredSlateSound;
	}
}
