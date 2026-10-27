using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029E5 RID: 10725
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.TreeView")]
	[UnrealStructLayout(1384, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1384)]
	public class UTreeView : UListView, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027BBA RID: 162746 RVA: 0x003C91B0 File Offset: 0x003C73B0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTreeView._ClassPtr;
		}

		// Token: 0x06027BBB RID: 162747 RVA: 0x003C91BC File Offset: 0x003C73BC
		public UTreeView() : this(BuiltinUtils.AllocNativeUObject(UTreeView.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027BBC RID: 162748 RVA: 0x003C91E4 File Offset: 0x003C73E4
		public UTreeView(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTreeView.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700983A RID: 38970
		// (get) Token: 0x06027BBD RID: 162749 RVA: 0x003C9218 File Offset: 0x003C7418
		// (set) Token: 0x06027BBE RID: 162750 RVA: 0x003C9251 File Offset: 0x003C7451
		public FOnGetItemChildrenDynamic BP_OnGetItemChildren
		{
			get
			{
				base.FastCheckIsValid();
				FOnGetItemChildrenDynamic result;
				if ((result = this._BP_OnGetItemChildren) == null)
				{
					result = (this._BP_OnGetItemChildren = new FOnGetItemChildrenDynamic(base.NativePtr + (IntPtr)UTreeView.__PropertyOffset_BP_OnGetItemChildren, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UTreeView.__PropertyOffset_BP_OnGetItemChildren, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700983B RID: 38971
		// (get) Token: 0x06027BBF RID: 162751 RVA: 0x003C9274 File Offset: 0x003C7474
		// (set) Token: 0x06027BC0 RID: 162752 RVA: 0x003C92AD File Offset: 0x003C74AD
		public FOnItemExpansionChangedDynamic BP_OnItemExpansionChanged
		{
			get
			{
				base.FastCheckIsValid();
				FOnItemExpansionChangedDynamic result;
				if ((result = this._BP_OnItemExpansionChanged) == null)
				{
					result = (this._BP_OnItemExpansionChanged = new FOnItemExpansionChangedDynamic(base.NativePtr + (IntPtr)UTreeView.__PropertyOffset_BP_OnItemExpansionChanged, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UTreeView.__PropertyOffset_BP_OnItemExpansionChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06027BC1 RID: 162753 RVA: 0x003C92CE File Offset: 0x003C74CE
		[NullableContext(2)]
		public void SetItemExpansion(UObject Item, bool bExpandItem)
		{
			UTreeView.__SetItemExpansion_Internal(base.NativePtr, (Item != null) ? Item.NativePtr : IntPtr.Zero, bExpandItem);
		}

		// Token: 0x06027BC2 RID: 162754 RVA: 0x003C92EC File Offset: 0x003C74EC
		public void ExpandAll()
		{
			UTreeView.__ExpandAll_Internal(base.NativePtr);
		}

		// Token: 0x06027BC3 RID: 162755 RVA: 0x003C92F9 File Offset: 0x003C74F9
		public void CollapseAll()
		{
			UTreeView.__CollapseAll_Internal(base.NativePtr);
		}

		// Token: 0x06027BC4 RID: 162756
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetItemExpansion_Internal(IntPtr @this, IntPtr Item, bool bExpandItem);

		// Token: 0x06027BC5 RID: 162757
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ExpandAll_Internal(IntPtr @this);

		// Token: 0x06027BC6 RID: 162758
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CollapseAll_Internal(IntPtr @this);

		// Token: 0x06027BC7 RID: 162759 RVA: 0x003C9306 File Offset: 0x003C7506
		static UTreeView()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.TreeView");
		}

		// Token: 0x06027BC8 RID: 162760 RVA: 0x003C9314 File Offset: 0x003C7514
		protected UTreeView(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015C11 RID: 89105
		public new const string __ObjectPath = "/Script/UMG.TreeView";

		// Token: 0x04015C12 RID: 89106
		private static IntPtr _ClassPtr;

		// Token: 0x04015C13 RID: 89107
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015C14 RID: 89108
		internal static int __PropertyOffset_BP_OnGetItemChildren;

		// Token: 0x04015C15 RID: 89109
		[Nullable(2)]
		private FOnGetItemChildrenDynamic _BP_OnGetItemChildren;

		// Token: 0x04015C16 RID: 89110
		internal static int __PropertyOffset_BP_OnItemExpansionChanged;

		// Token: 0x04015C17 RID: 89111
		[Nullable(2)]
		private FOnItemExpansionChangedDynamic _BP_OnItemExpansionChanged;
	}
}
