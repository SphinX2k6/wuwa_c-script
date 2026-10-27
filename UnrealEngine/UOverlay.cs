using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029BE RID: 10686
	[UnrealObjectPath("/Script/UMG.Overlay")]
	[UnrealStructLayout(696, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 696)]
	public class UOverlay : UPanelWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060277F5 RID: 161781 RVA: 0x003C482A File Offset: 0x003C2A2A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UOverlay._ClassPtr;
		}

		// Token: 0x060277F6 RID: 161782 RVA: 0x003C4838 File Offset: 0x003C2A38
		public UOverlay() : this(BuiltinUtils.AllocNativeUObject(UOverlay.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060277F7 RID: 161783 RVA: 0x003C4860 File Offset: 0x003C2A60
		[NullableContext(1)]
		public UOverlay(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UOverlay.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060277F8 RID: 161784 RVA: 0x003C4893 File Offset: 0x003C2A93
		[NullableContext(2)]
		public UOverlaySlot AddChildToOverlay(UWidget Content)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UOverlaySlot>(UOverlay.__AddChildToOverlay_Internal(base.NativePtr, (Content != null) ? Content.NativePtr : IntPtr.Zero));
		}

		// Token: 0x060277F9 RID: 161785
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AddChildToOverlay_Internal(IntPtr @this, IntPtr Content);

		// Token: 0x060277FA RID: 161786 RVA: 0x003C48B5 File Offset: 0x003C2AB5
		static UOverlay()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.Overlay");
		}

		// Token: 0x060277FB RID: 161787 RVA: 0x003C48C3 File Offset: 0x003C2AC3
		protected UOverlay(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015A8E RID: 88718
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.Overlay";

		// Token: 0x04015A8F RID: 88719
		private static IntPtr _ClassPtr;

		// Token: 0x04015A90 RID: 88720
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
