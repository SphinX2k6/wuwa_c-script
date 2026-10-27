using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200294A RID: 10570
	[UnrealObjectPath("/Script/UMG.ContentWidget")]
	[UnrealStructLayout(680, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 680)]
	public abstract class UContentWidget : UPanelWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027236 RID: 160310 RVA: 0x003BABF1 File Offset: 0x003B8DF1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UContentWidget._ClassPtr;
		}

		// Token: 0x06027237 RID: 160311 RVA: 0x003BABFD File Offset: 0x003B8DFD
		[NullableContext(2)]
		public UPanelSlot SetContent(UWidget Content)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UPanelSlot>(UContentWidget.__SetContent_Internal(base.NativePtr, (Content != null) ? Content.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06027238 RID: 160312 RVA: 0x003BAC1F File Offset: 0x003B8E1F
		[NullableContext(2)]
		public UPanelSlot GetContentSlot()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UPanelSlot>(UContentWidget.__GetContentSlot_Internal(base.NativePtr));
		}

		// Token: 0x06027239 RID: 160313 RVA: 0x003BAC31 File Offset: 0x003B8E31
		[NullableContext(2)]
		public UWidget GetContent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UWidget>(UContentWidget.__GetContent_Internal(base.NativePtr));
		}

		// Token: 0x0602723A RID: 160314
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetContent_Internal(IntPtr @this, IntPtr Content);

		// Token: 0x0602723B RID: 160315
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetContentSlot_Internal(IntPtr @this);

		// Token: 0x0602723C RID: 160316
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetContent_Internal(IntPtr @this);

		// Token: 0x0602723D RID: 160317 RVA: 0x003BAC43 File Offset: 0x003B8E43
		static UContentWidget()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.ContentWidget");
		}

		// Token: 0x0602723E RID: 160318 RVA: 0x003BAC54 File Offset: 0x003B8E54
		protected UContentWidget() : this(BuiltinUtils.AllocNativeUObject(UContentWidget.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602723F RID: 160319 RVA: 0x003BAC7C File Offset: 0x003B8E7C
		protected UContentWidget(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040157E4 RID: 88036
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.ContentWidget";

		// Token: 0x040157E5 RID: 88037
		private static IntPtr _ClassPtr;

		// Token: 0x040157E6 RID: 88038
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
