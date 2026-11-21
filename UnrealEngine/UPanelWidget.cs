using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200086E RID: 2158
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.PanelWidget")]
	[UnrealStructLayout(680, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 680)]
	public abstract class UPanelWidget : UWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BB41 RID: 47937 RVA: 0x0012BEDC File Offset: 0x0012A0DC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPanelWidget._ClassPtr;
		}

		// Token: 0x170022B4 RID: 8884
		// (get) Token: 0x0600BB42 RID: 47938 RVA: 0x0012BEE8 File Offset: 0x0012A0E8
		// (set) Token: 0x0600BB43 RID: 47939 RVA: 0x0012BF21 File Offset: 0x0012A121
		public TArray<UPanelSlot> Slots
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UPanelSlot> result;
				if ((result = this._Slots) == null)
				{
					result = (this._Slots = new TArray<UPanelSlot>(base.NativePtr + (IntPtr)UPanelWidget.__PropertyOffset_Slots, this));
				}
				return result;
			}
			set
			{
				this.Slots.CopyAssign(value);
			}
		}

		// Token: 0x0600BB44 RID: 47940 RVA: 0x0012BF2F File Offset: 0x0012A12F
		public bool RemoveChildAt(int Index)
		{
			return UPanelWidget.__RemoveChildAt_Internal(base.NativePtr, Index);
		}

		// Token: 0x0600BB45 RID: 47941 RVA: 0x0012BF3D File Offset: 0x0012A13D
		[NullableContext(2)]
		public bool RemoveChild(UWidget Content)
		{
			return UPanelWidget.__RemoveChild_Internal(base.NativePtr, (Content != null) ? Content.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600BB46 RID: 47942 RVA: 0x0012BF5A File Offset: 0x0012A15A
		[NullableContext(2)]
		public bool HasChild(UWidget Content)
		{
			return UPanelWidget.__HasChild_Internal(base.NativePtr, (Content != null) ? Content.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600BB47 RID: 47943 RVA: 0x0012BF77 File Offset: 0x0012A177
		public bool HasAnyChildren()
		{
			return UPanelWidget.__HasAnyChildren_Internal(base.NativePtr);
		}

		// Token: 0x0600BB48 RID: 47944 RVA: 0x0012BF84 File Offset: 0x0012A184
		public int GetChildrenCount()
		{
			return UPanelWidget.__GetChildrenCount_Internal(base.NativePtr);
		}

		// Token: 0x0600BB49 RID: 47945 RVA: 0x0012BF91 File Offset: 0x0012A191
		[NullableContext(2)]
		public int GetChildIndex(UWidget Content)
		{
			return UPanelWidget.__GetChildIndex_Internal(base.NativePtr, (Content != null) ? Content.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600BB4A RID: 47946 RVA: 0x0012BFAE File Offset: 0x0012A1AE
		[NullableContext(2)]
		public UWidget GetChildAt(int Index)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UWidget>(UPanelWidget.__GetChildAt_Internal(base.NativePtr, Index));
		}

		// Token: 0x0600BB4B RID: 47947 RVA: 0x0012BFC1 File Offset: 0x0012A1C1
		public TArray<UWidget> GetAllChildren()
		{
			return new TArray<UWidget>(UPanelWidget.__GetAllChildren_Internal(base.NativePtr), null);
		}

		// Token: 0x0600BB4C RID: 47948 RVA: 0x0012BFD4 File Offset: 0x0012A1D4
		public void ClearChildren()
		{
			UPanelWidget.__ClearChildren_Internal(base.NativePtr);
		}

		// Token: 0x0600BB4D RID: 47949 RVA: 0x0012BFE1 File Offset: 0x0012A1E1
		[NullableContext(2)]
		public UPanelSlot AddChild(UWidget Content)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UPanelSlot>(UPanelWidget.__AddChild_Internal(base.NativePtr, (Content != null) ? Content.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0600BB4E RID: 47950
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RemoveChildAt_Internal(IntPtr @this, int Index);

		// Token: 0x0600BB4F RID: 47951
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RemoveChild_Internal(IntPtr @this, IntPtr Content);

		// Token: 0x0600BB50 RID: 47952
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasChild_Internal(IntPtr @this, IntPtr Content);

		// Token: 0x0600BB51 RID: 47953
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasAnyChildren_Internal(IntPtr @this);

		// Token: 0x0600BB52 RID: 47954
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetChildrenCount_Internal(IntPtr @this);

		// Token: 0x0600BB53 RID: 47955
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetChildIndex_Internal(IntPtr @this, IntPtr Content);

		// Token: 0x0600BB54 RID: 47956
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetChildAt_Internal(IntPtr @this, int Index);

		// Token: 0x0600BB55 RID: 47957
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAllChildren_Internal(IntPtr @this);

		// Token: 0x0600BB56 RID: 47958
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearChildren_Internal(IntPtr @this);

		// Token: 0x0600BB57 RID: 47959
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AddChild_Internal(IntPtr @this, IntPtr Content);

		// Token: 0x0600BB58 RID: 47960 RVA: 0x0012C003 File Offset: 0x0012A203
		static UPanelWidget()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.PanelWidget");
		}

		// Token: 0x0600BB59 RID: 47961 RVA: 0x0012C014 File Offset: 0x0012A214
		protected UPanelWidget() : this(BuiltinUtils.AllocNativeUObject(UPanelWidget.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BB5A RID: 47962 RVA: 0x0012C03C File Offset: 0x0012A23C
		protected UPanelWidget(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040054D5 RID: 21717
		public new const string __ObjectPath = "/Script/UMG.PanelWidget";

		// Token: 0x040054D6 RID: 21718
		private static IntPtr _ClassPtr;

		// Token: 0x040054D7 RID: 21719
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040054D8 RID: 21720
		internal static int __PropertyOffset_Slots;

		// Token: 0x040054D9 RID: 21721
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UPanelSlot> _Slots;
	}
}
