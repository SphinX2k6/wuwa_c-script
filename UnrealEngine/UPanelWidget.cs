using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029C2 RID: 10690
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.PanelWidget")]
	[UnrealStructLayout(680, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 680)]
	public abstract class UPanelWidget : UWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602781D RID: 161821 RVA: 0x003C4B2C File Offset: 0x003C2D2C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPanelWidget._ClassPtr;
		}

		// Token: 0x1700976B RID: 38763
		// (get) Token: 0x0602781E RID: 161822 RVA: 0x003C4B38 File Offset: 0x003C2D38
		// (set) Token: 0x0602781F RID: 161823 RVA: 0x003C4B71 File Offset: 0x003C2D71
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

		// Token: 0x06027820 RID: 161824 RVA: 0x003C4B7F File Offset: 0x003C2D7F
		public bool RemoveChildAt(int Index)
		{
			return UPanelWidget.__RemoveChildAt_Internal(base.NativePtr, Index);
		}

		// Token: 0x06027821 RID: 161825 RVA: 0x003C4B8D File Offset: 0x003C2D8D
		[NullableContext(2)]
		public bool RemoveChild(UWidget Content)
		{
			return UPanelWidget.__RemoveChild_Internal(base.NativePtr, (Content != null) ? Content.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06027822 RID: 161826 RVA: 0x003C4BAA File Offset: 0x003C2DAA
		[NullableContext(2)]
		public bool HasChild(UWidget Content)
		{
			return UPanelWidget.__HasChild_Internal(base.NativePtr, (Content != null) ? Content.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06027823 RID: 161827 RVA: 0x003C4BC7 File Offset: 0x003C2DC7
		public bool HasAnyChildren()
		{
			return UPanelWidget.__HasAnyChildren_Internal(base.NativePtr);
		}

		// Token: 0x06027824 RID: 161828 RVA: 0x003C4BD4 File Offset: 0x003C2DD4
		public int GetChildrenCount()
		{
			return UPanelWidget.__GetChildrenCount_Internal(base.NativePtr);
		}

		// Token: 0x06027825 RID: 161829 RVA: 0x003C4BE1 File Offset: 0x003C2DE1
		[NullableContext(2)]
		public int GetChildIndex(UWidget Content)
		{
			return UPanelWidget.__GetChildIndex_Internal(base.NativePtr, (Content != null) ? Content.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06027826 RID: 161830 RVA: 0x003C4BFE File Offset: 0x003C2DFE
		[NullableContext(2)]
		public UWidget GetChildAt(int Index)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UWidget>(UPanelWidget.__GetChildAt_Internal(base.NativePtr, Index));
		}

		// Token: 0x06027827 RID: 161831 RVA: 0x003C4C11 File Offset: 0x003C2E11
		public TArray<UWidget> GetAllChildren()
		{
			return new TArray<UWidget>(UPanelWidget.__GetAllChildren_Internal(base.NativePtr), null);
		}

		// Token: 0x06027828 RID: 161832 RVA: 0x003C4C24 File Offset: 0x003C2E24
		public void ClearChildren()
		{
			UPanelWidget.__ClearChildren_Internal(base.NativePtr);
		}

		// Token: 0x06027829 RID: 161833 RVA: 0x003C4C31 File Offset: 0x003C2E31
		[NullableContext(2)]
		public UPanelSlot AddChild(UWidget Content)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UPanelSlot>(UPanelWidget.__AddChild_Internal(base.NativePtr, (Content != null) ? Content.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0602782A RID: 161834
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RemoveChildAt_Internal(IntPtr @this, int Index);

		// Token: 0x0602782B RID: 161835
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RemoveChild_Internal(IntPtr @this, IntPtr Content);

		// Token: 0x0602782C RID: 161836
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasChild_Internal(IntPtr @this, IntPtr Content);

		// Token: 0x0602782D RID: 161837
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasAnyChildren_Internal(IntPtr @this);

		// Token: 0x0602782E RID: 161838
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetChildrenCount_Internal(IntPtr @this);

		// Token: 0x0602782F RID: 161839
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetChildIndex_Internal(IntPtr @this, IntPtr Content);

		// Token: 0x06027830 RID: 161840
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetChildAt_Internal(IntPtr @this, int Index);

		// Token: 0x06027831 RID: 161841
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAllChildren_Internal(IntPtr @this);

		// Token: 0x06027832 RID: 161842
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearChildren_Internal(IntPtr @this);

		// Token: 0x06027833 RID: 161843
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AddChild_Internal(IntPtr @this, IntPtr Content);

		// Token: 0x06027834 RID: 161844 RVA: 0x003C4C53 File Offset: 0x003C2E53
		static UPanelWidget()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.PanelWidget");
		}

		// Token: 0x06027835 RID: 161845 RVA: 0x003C4C64 File Offset: 0x003C2E64
		protected UPanelWidget() : this(BuiltinUtils.AllocNativeUObject(UPanelWidget.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027836 RID: 161846 RVA: 0x003C4C8C File Offset: 0x003C2E8C
		protected UPanelWidget(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015A9E RID: 88734
		public new const string __ObjectPath = "/Script/UMG.PanelWidget";

		// Token: 0x04015A9F RID: 88735
		private static IntPtr _ClassPtr;

		// Token: 0x04015AA0 RID: 88736
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015AA1 RID: 88737
		internal static int __PropertyOffset_Slots;

		// Token: 0x04015AA2 RID: 88738
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UPanelSlot> _Slots;
	}
}
