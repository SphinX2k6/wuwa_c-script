using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000854 RID: 2132
	[UnrealObjectPath("/Script/UMG.CanvasPanel")]
	[UnrealStructLayout(696, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 696)]
	public class UCanvasPanel : UPanelWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B9A1 RID: 47521 RVA: 0x00129627 File Offset: 0x00127827
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCanvasPanel._ClassPtr;
		}

		// Token: 0x0600B9A2 RID: 47522 RVA: 0x00129634 File Offset: 0x00127834
		public UCanvasPanel() : this(BuiltinUtils.AllocNativeUObject(UCanvasPanel.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B9A3 RID: 47523 RVA: 0x0012965C File Offset: 0x0012785C
		[NullableContext(1)]
		public UCanvasPanel(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCanvasPanel.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600B9A4 RID: 47524 RVA: 0x0012968F File Offset: 0x0012788F
		[NullableContext(2)]
		public UCanvasPanelSlot AddChildToCanvas(UWidget Content)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UCanvasPanelSlot>(UCanvasPanel.__AddChildToCanvas_Internal(base.NativePtr, (Content != null) ? Content.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0600B9A5 RID: 47525
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AddChildToCanvas_Internal(IntPtr @this, IntPtr Content);

		// Token: 0x0600B9A6 RID: 47526 RVA: 0x001296B1 File Offset: 0x001278B1
		static UCanvasPanel()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.CanvasPanel");
		}

		// Token: 0x0600B9A7 RID: 47527 RVA: 0x001296BF File Offset: 0x001278BF
		protected UCanvasPanel(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005457 RID: 21591
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.CanvasPanel";

		// Token: 0x04005458 RID: 21592
		private static IntPtr _ClassPtr;

		// Token: 0x04005459 RID: 21593
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
