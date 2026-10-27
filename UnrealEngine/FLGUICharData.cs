using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200202F RID: 8239
	[UnrealObjectPath("/Script/LGUI.LGUICharData")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FLGUICharData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F2AF RID: 127663 RVA: 0x002E4656 File Offset: 0x002E2856
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLGUICharData._ScriptStructPtr != 0) ? FLGUICharData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.LGUICharData", ref FLGUICharData._ScriptStructPtr);
		}

		// Token: 0x17007B96 RID: 31638
		// (get) Token: 0x0601F2B0 RID: 127664 RVA: 0x002E467A File Offset: 0x002E287A
		// (set) Token: 0x0601F2B1 RID: 127665 RVA: 0x002E468A File Offset: 0x002E288A
		public unsafe ushort width
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUICharData.__PropertyOffset_width);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUICharData.__PropertyOffset_width) = (short)value;
			}
		}

		// Token: 0x17007B97 RID: 31639
		// (get) Token: 0x0601F2B2 RID: 127666 RVA: 0x002E469B File Offset: 0x002E289B
		// (set) Token: 0x0601F2B3 RID: 127667 RVA: 0x002E46AB File Offset: 0x002E28AB
		public unsafe ushort height
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUICharData.__PropertyOffset_height);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUICharData.__PropertyOffset_height) = (short)value;
			}
		}

		// Token: 0x17007B98 RID: 31640
		// (get) Token: 0x0601F2B4 RID: 127668 RVA: 0x002E46BC File Offset: 0x002E28BC
		// (set) Token: 0x0601F2B5 RID: 127669 RVA: 0x002E46CC File Offset: 0x002E28CC
		public unsafe float xoffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUICharData.__PropertyOffset_xoffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUICharData.__PropertyOffset_xoffset) = value;
			}
		}

		// Token: 0x17007B99 RID: 31641
		// (get) Token: 0x0601F2B6 RID: 127670 RVA: 0x002E46DD File Offset: 0x002E28DD
		// (set) Token: 0x0601F2B7 RID: 127671 RVA: 0x002E46ED File Offset: 0x002E28ED
		public unsafe float yoffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUICharData.__PropertyOffset_yoffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUICharData.__PropertyOffset_yoffset) = value;
			}
		}

		// Token: 0x17007B9A RID: 31642
		// (get) Token: 0x0601F2B8 RID: 127672 RVA: 0x002E46FE File Offset: 0x002E28FE
		// (set) Token: 0x0601F2B9 RID: 127673 RVA: 0x002E470E File Offset: 0x002E290E
		public unsafe short xadvance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUICharData.__PropertyOffset_xadvance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUICharData.__PropertyOffset_xadvance) = value;
			}
		}

		// Token: 0x17007B9B RID: 31643
		// (get) Token: 0x0601F2BA RID: 127674 RVA: 0x002E471F File Offset: 0x002E291F
		// (set) Token: 0x0601F2BB RID: 127675 RVA: 0x002E472F File Offset: 0x002E292F
		public unsafe float uv0X
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUICharData.__PropertyOffset_uv0X);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUICharData.__PropertyOffset_uv0X) = value;
			}
		}

		// Token: 0x17007B9C RID: 31644
		// (get) Token: 0x0601F2BC RID: 127676 RVA: 0x002E4740 File Offset: 0x002E2940
		// (set) Token: 0x0601F2BD RID: 127677 RVA: 0x002E4750 File Offset: 0x002E2950
		public unsafe float uv0Y
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUICharData.__PropertyOffset_uv0Y);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUICharData.__PropertyOffset_uv0Y) = value;
			}
		}

		// Token: 0x17007B9D RID: 31645
		// (get) Token: 0x0601F2BE RID: 127678 RVA: 0x002E4761 File Offset: 0x002E2961
		// (set) Token: 0x0601F2BF RID: 127679 RVA: 0x002E4771 File Offset: 0x002E2971
		public unsafe float uv3X
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUICharData.__PropertyOffset_uv3X);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUICharData.__PropertyOffset_uv3X) = value;
			}
		}

		// Token: 0x17007B9E RID: 31646
		// (get) Token: 0x0601F2C0 RID: 127680 RVA: 0x002E4782 File Offset: 0x002E2982
		// (set) Token: 0x0601F2C1 RID: 127681 RVA: 0x002E4792 File Offset: 0x002E2992
		public unsafe float uv3Y
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUICharData.__PropertyOffset_uv3Y);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUICharData.__PropertyOffset_uv3Y) = value;
			}
		}

		// Token: 0x17007B9F RID: 31647
		// (get) Token: 0x0601F2C2 RID: 127682 RVA: 0x002E47A3 File Offset: 0x002E29A3
		// (set) Token: 0x0601F2C3 RID: 127683 RVA: 0x002E47B3 File Offset: 0x002E29B3
		public unsafe bool bHasRendered
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUICharData.__PropertyOffset_bHasRendered) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUICharData.__PropertyOffset_bHasRendered) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007BA0 RID: 31648
		// (get) Token: 0x0601F2C4 RID: 127684 RVA: 0x002E47C4 File Offset: 0x002E29C4
		// (set) Token: 0x0601F2C5 RID: 127685 RVA: 0x002E47D4 File Offset: 0x002E29D4
		public unsafe short descender
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUICharData.__PropertyOffset_descender);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUICharData.__PropertyOffset_descender) = value;
			}
		}

		// Token: 0x0601F2C6 RID: 127686 RVA: 0x002E47E5 File Offset: 0x002E29E5
		public FLGUICharData()
		{
		}

		// Token: 0x0601F2C7 RID: 127687 RVA: 0x002E47F0 File Offset: 0x002E29F0
		public FLGUICharData(ushort width, ushort height, float xoffset, float yoffset, short xadvance, float uv0X, float uv0Y, float uv3X, float uv3Y, bool bHasRendered, short descender)
		{
			this.width = width;
			this.height = height;
			this.xoffset = xoffset;
			this.yoffset = yoffset;
			this.xadvance = xadvance;
			this.uv0X = uv0X;
			this.uv0Y = uv0Y;
			this.uv3X = uv3X;
			this.uv3Y = uv3Y;
			this.bHasRendered = bHasRendered;
			this.descender = descender;
		}

		// Token: 0x0601F2C8 RID: 127688 RVA: 0x002E4858 File Offset: 0x002E2A58
		protected override IntPtr GetUStructPtr()
		{
			return FLGUICharData.StaticStruct();
		}

		// Token: 0x0601F2C9 RID: 127689 RVA: 0x002E4864 File Offset: 0x002E2A64
		[NullableContext(2)]
		public FLGUICharData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F2CA RID: 127690 RVA: 0x002E486E File Offset: 0x002E2A6E
		public FLGUICharData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F2CB RID: 127691 RVA: 0x002E4879 File Offset: 0x002E2A79
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLGUICharData(Pointer, false, true);
		}

		// Token: 0x0601F2CC RID: 127692 RVA: 0x002E4883 File Offset: 0x002E2A83
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLGUICharData(Pointer, MemoryOwner);
		}

		// Token: 0x04010DF7 RID: 69111
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUICharData";

		// Token: 0x04010DF8 RID: 69112
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010DF9 RID: 69113
		internal static int __PropertyOffset_width;

		// Token: 0x04010DFA RID: 69114
		internal static int __PropertyOffset_height;

		// Token: 0x04010DFB RID: 69115
		internal static int __PropertyOffset_xoffset;

		// Token: 0x04010DFC RID: 69116
		internal static int __PropertyOffset_yoffset;

		// Token: 0x04010DFD RID: 69117
		internal static int __PropertyOffset_xadvance;

		// Token: 0x04010DFE RID: 69118
		internal static int __PropertyOffset_uv0X;

		// Token: 0x04010DFF RID: 69119
		internal static int __PropertyOffset_uv0Y;

		// Token: 0x04010E00 RID: 69120
		internal static int __PropertyOffset_uv3X;

		// Token: 0x04010E01 RID: 69121
		internal static int __PropertyOffset_uv3Y;

		// Token: 0x04010E02 RID: 69122
		internal static int __PropertyOffset_bHasRendered;

		// Token: 0x04010E03 RID: 69123
		internal static int __PropertyOffset_descender;
	}
}
