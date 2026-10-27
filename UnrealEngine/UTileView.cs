using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029E4 RID: 10724
	[UnrealObjectPath("/Script/UMG.TileView")]
	[UnrealStructLayout(1304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1304)]
	public class UTileView : UListView, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027BA5 RID: 162725 RVA: 0x003C9075 File Offset: 0x003C7275
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTileView._ClassPtr;
		}

		// Token: 0x06027BA6 RID: 162726 RVA: 0x003C9084 File Offset: 0x003C7284
		public UTileView() : this(BuiltinUtils.AllocNativeUObject(UTileView.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027BA7 RID: 162727 RVA: 0x003C90AC File Offset: 0x003C72AC
		[NullableContext(1)]
		public UTileView(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTileView.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009836 RID: 38966
		// (get) Token: 0x06027BA8 RID: 162728 RVA: 0x003C90DF File Offset: 0x003C72DF
		// (set) Token: 0x06027BA9 RID: 162729 RVA: 0x003C90EF File Offset: 0x003C72EF
		public unsafe float EntryHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTileView.__PropertyOffset_EntryHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTileView.__PropertyOffset_EntryHeight) = value;
			}
		}

		// Token: 0x17009837 RID: 38967
		// (get) Token: 0x06027BAA RID: 162730 RVA: 0x003C9100 File Offset: 0x003C7300
		// (set) Token: 0x06027BAB RID: 162731 RVA: 0x003C9110 File Offset: 0x003C7310
		public unsafe float EntryWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTileView.__PropertyOffset_EntryWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTileView.__PropertyOffset_EntryWidth) = value;
			}
		}

		// Token: 0x17009838 RID: 38968
		// (get) Token: 0x06027BAC RID: 162732 RVA: 0x003C9121 File Offset: 0x003C7321
		// (set) Token: 0x06027BAD RID: 162733 RVA: 0x003C9131 File Offset: 0x003C7331
		public unsafe EListItemAlignment TileAlignment
		{
			get
			{
				return (EListItemAlignment)(*(base.NativePtr + (IntPtr)UTileView.__PropertyOffset_TileAlignment));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTileView.__PropertyOffset_TileAlignment) = (byte)value;
			}
		}

		// Token: 0x17009839 RID: 38969
		// (get) Token: 0x06027BAE RID: 162734 RVA: 0x003C9142 File Offset: 0x003C7342
		// (set) Token: 0x06027BAF RID: 162735 RVA: 0x003C9152 File Offset: 0x003C7352
		public unsafe bool bWrapHorizontalNavigation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTileView.__PropertyOffset_bWrapHorizontalNavigation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTileView.__PropertyOffset_bWrapHorizontalNavigation) = (value ? 1 : 0);
			}
		}

		// Token: 0x06027BB0 RID: 162736 RVA: 0x003C9163 File Offset: 0x003C7363
		public void SetEntryWidth(float NewWidth)
		{
			UTileView.__SetEntryWidth_Internal(base.NativePtr, NewWidth);
		}

		// Token: 0x06027BB1 RID: 162737 RVA: 0x003C9171 File Offset: 0x003C7371
		public void SetEntryHeight(float NewHeight)
		{
			UTileView.__SetEntryHeight_Internal(base.NativePtr, NewHeight);
		}

		// Token: 0x06027BB2 RID: 162738 RVA: 0x003C917F File Offset: 0x003C737F
		public float GetEntryWidth()
		{
			return UTileView.__GetEntryWidth_Internal(base.NativePtr);
		}

		// Token: 0x06027BB3 RID: 162739 RVA: 0x003C918C File Offset: 0x003C738C
		public float GetEntryHeight()
		{
			return UTileView.__GetEntryHeight_Internal(base.NativePtr);
		}

		// Token: 0x06027BB4 RID: 162740
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEntryWidth_Internal(IntPtr @this, float NewWidth);

		// Token: 0x06027BB5 RID: 162741
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEntryHeight_Internal(IntPtr @this, float NewHeight);

		// Token: 0x06027BB6 RID: 162742
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetEntryWidth_Internal(IntPtr @this);

		// Token: 0x06027BB7 RID: 162743
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetEntryHeight_Internal(IntPtr @this);

		// Token: 0x06027BB8 RID: 162744 RVA: 0x003C9199 File Offset: 0x003C7399
		static UTileView()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.TileView");
		}

		// Token: 0x06027BB9 RID: 162745 RVA: 0x003C91A7 File Offset: 0x003C73A7
		protected UTileView(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015C0A RID: 89098
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.TileView";

		// Token: 0x04015C0B RID: 89099
		private static IntPtr _ClassPtr;

		// Token: 0x04015C0C RID: 89100
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015C0D RID: 89101
		internal static int __PropertyOffset_EntryHeight;

		// Token: 0x04015C0E RID: 89102
		internal static int __PropertyOffset_EntryWidth;

		// Token: 0x04015C0F RID: 89103
		internal static int __PropertyOffset_TileAlignment;

		// Token: 0x04015C10 RID: 89104
		internal static int __PropertyOffset_bWrapHorizontalNavigation;
	}
}
