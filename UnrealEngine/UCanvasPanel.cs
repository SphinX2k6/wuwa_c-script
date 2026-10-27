using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002941 RID: 10561
	[UnrealObjectPath("/Script/UMG.CanvasPanel")]
	[UnrealStructLayout(696, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 696)]
	public class UCanvasPanel : UPanelWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027145 RID: 160069 RVA: 0x003B9959 File Offset: 0x003B7B59
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCanvasPanel._ClassPtr;
		}

		// Token: 0x06027146 RID: 160070 RVA: 0x003B9968 File Offset: 0x003B7B68
		public UCanvasPanel() : this(BuiltinUtils.AllocNativeUObject(UCanvasPanel.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027147 RID: 160071 RVA: 0x003B9990 File Offset: 0x003B7B90
		[NullableContext(1)]
		public UCanvasPanel(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCanvasPanel.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06027148 RID: 160072 RVA: 0x003B99C3 File Offset: 0x003B7BC3
		[NullableContext(2)]
		public UCanvasPanelSlot AddChildToCanvas(UWidget Content)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UCanvasPanelSlot>(UCanvasPanel.__AddChildToCanvas_Internal(base.NativePtr, (Content != null) ? Content.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06027149 RID: 160073
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AddChildToCanvas_Internal(IntPtr @this, IntPtr Content);

		// Token: 0x0602714A RID: 160074 RVA: 0x003B99E5 File Offset: 0x003B7BE5
		static UCanvasPanel()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.CanvasPanel");
		}

		// Token: 0x0602714B RID: 160075 RVA: 0x003B99F3 File Offset: 0x003B7BF3
		protected UCanvasPanel(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015784 RID: 87940
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.CanvasPanel";

		// Token: 0x04015785 RID: 87941
		private static IntPtr _ClassPtr;

		// Token: 0x04015786 RID: 87942
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
