using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000264 RID: 612
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkWwiseTree")]
	[UnrealStructLayout(720, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 720)]
	public class UAkWwiseTree : UWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060023C3 RID: 9155 RVA: 0x00034F9B File Offset: 0x0003319B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkWwiseTree._ClassPtr;
		}

		// Token: 0x060023C4 RID: 9156 RVA: 0x00034FA8 File Offset: 0x000331A8
		public UAkWwiseTree() : this(BuiltinUtils.AllocNativeUObject(UAkWwiseTree.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060023C5 RID: 9157 RVA: 0x00034FD0 File Offset: 0x000331D0
		public UAkWwiseTree(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkWwiseTree.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x060023C6 RID: 9158 RVA: 0x00035004 File Offset: 0x00033204
		// (set) Token: 0x060023C7 RID: 9159 RVA: 0x0003503D File Offset: 0x0003323D
		public FOnItemSelectionChanged OnSelectionChanged
		{
			get
			{
				base.FastCheckIsValid();
				FOnItemSelectionChanged result;
				if ((result = this._OnSelectionChanged) == null)
				{
					result = (this._OnSelectionChanged = new FOnItemSelectionChanged(base.NativePtr + (IntPtr)UAkWwiseTree.__PropertyOffset_OnSelectionChanged, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAkWwiseTree.__PropertyOffset_OnSelectionChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x060023C8 RID: 9160 RVA: 0x00035060 File Offset: 0x00033260
		// (set) Token: 0x060023C9 RID: 9161 RVA: 0x00035099 File Offset: 0x00033299
		public FOnItemDragDetected OnItemDragged
		{
			get
			{
				base.FastCheckIsValid();
				FOnItemDragDetected result;
				if ((result = this._OnItemDragged) == null)
				{
					result = (this._OnItemDragged = new FOnItemDragDetected(base.NativePtr + (IntPtr)UAkWwiseTree.__PropertyOffset_OnItemDragged, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAkWwiseTree.__PropertyOffset_OnItemDragged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x060023CA RID: 9162 RVA: 0x000350BC File Offset: 0x000332BC
		public unsafe void SetSearchText(string newText)
		{
			FString fstring = FString.AllocTemp(newText);
			UAkWwiseTree.__SetSearchText_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060023CB RID: 9163 RVA: 0x000350E6 File Offset: 0x000332E6
		public FAkWwiseObjectDetails GetSelectedItem()
		{
			return new FAkWwiseObjectDetails(UAkWwiseTree.__GetSelectedItem_Internal(base.NativePtr), null);
		}

		// Token: 0x060023CC RID: 9164 RVA: 0x000350F9 File Offset: 0x000332F9
		public string GetSearchText()
		{
			return FString.ToStringAndDeleteNativePtr(UAkWwiseTree.__GetSearchText_Internal(base.NativePtr));
		}

		// Token: 0x060023CD RID: 9165
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSearchText_Internal(IntPtr @this, in FString newText);

		// Token: 0x060023CE RID: 9166
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSelectedItem_Internal(IntPtr @this);

		// Token: 0x060023CF RID: 9167
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetSearchText_Internal(IntPtr @this);

		// Token: 0x060023D0 RID: 9168 RVA: 0x0003510B File Offset: 0x0003330B
		static UAkWwiseTree()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkWwiseTree");
		}

		// Token: 0x060023D1 RID: 9169 RVA: 0x00035119 File Offset: 0x00033319
		protected UAkWwiseTree(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000C66 RID: 3174
		public new const string __ObjectPath = "/Script/AkAudio.AkWwiseTree";

		// Token: 0x04000C67 RID: 3175
		private static IntPtr _ClassPtr;

		// Token: 0x04000C68 RID: 3176
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000C69 RID: 3177
		internal static int __PropertyOffset_OnSelectionChanged;

		// Token: 0x04000C6A RID: 3178
		[Nullable(2)]
		private FOnItemSelectionChanged _OnSelectionChanged;

		// Token: 0x04000C6B RID: 3179
		internal static int __PropertyOffset_OnItemDragged;

		// Token: 0x04000C6C RID: 3180
		[Nullable(2)]
		private FOnItemDragDetected _OnItemDragged;
	}
}
