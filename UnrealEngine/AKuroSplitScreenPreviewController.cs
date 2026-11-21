using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004E5 RID: 1253
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroSplitScreenPreviewController")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1520)]
	public class AKuroSplitScreenPreviewController : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600764E RID: 30286 RVA: 0x000ACB78 File Offset: 0x000AAD78
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroSplitScreenPreviewController._ClassPtr;
		}

		// Token: 0x0600764F RID: 30287 RVA: 0x000ACB84 File Offset: 0x000AAD84
		public AKuroSplitScreenPreviewController() : this(BuiltinUtils.AllocNativeUObject(AKuroSplitScreenPreviewController.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007650 RID: 30288 RVA: 0x000ACBAC File Offset: 0x000AADAC
		public AKuroSplitScreenPreviewController(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroSplitScreenPreviewController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170016CC RID: 5836
		// (get) Token: 0x06007651 RID: 30289 RVA: 0x000ACBDF File Offset: 0x000AADDF
		// (set) Token: 0x06007652 RID: 30290 RVA: 0x000ACBF3 File Offset: 0x000AADF3
		public unsafe FName MainCameraName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroSplitScreenPreviewController.__PropertyOffset_MainCameraName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroSplitScreenPreviewController.__PropertyOffset_MainCameraName) = value;
			}
		}

		// Token: 0x170016CD RID: 5837
		// (get) Token: 0x06007653 RID: 30291 RVA: 0x000ACC08 File Offset: 0x000AAE08
		// (set) Token: 0x06007654 RID: 30292 RVA: 0x000ACC1C File Offset: 0x000AAE1C
		public unsafe FName MainCameraBindingTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroSplitScreenPreviewController.__PropertyOffset_MainCameraBindingTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroSplitScreenPreviewController.__PropertyOffset_MainCameraBindingTag) = value;
			}
		}

		// Token: 0x170016CE RID: 5838
		// (get) Token: 0x06007655 RID: 30293 RVA: 0x000ACC34 File Offset: 0x000AAE34
		// (set) Token: 0x06007656 RID: 30294 RVA: 0x000ACC6D File Offset: 0x000AAE6D
		public FKuroSeparateCameraData MainLayout
		{
			get
			{
				base.FastCheckIsValid();
				FKuroSeparateCameraData result;
				if ((result = this._MainLayout) == null)
				{
					result = (this._MainLayout = new FKuroSeparateCameraData(base.NativePtr + (IntPtr)AKuroSplitScreenPreviewController.__PropertyOffset_MainLayout, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroSeparateCameraData.StaticStruct(), base.NativePtr + (IntPtr)AKuroSplitScreenPreviewController.__PropertyOffset_MainLayout, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170016CF RID: 5839
		// (get) Token: 0x06007657 RID: 30295 RVA: 0x000ACC8E File Offset: 0x000AAE8E
		// (set) Token: 0x06007658 RID: 30296 RVA: 0x000ACCA2 File Offset: 0x000AAEA2
		public unsafe string ActivePreviewOwner
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)AKuroSplitScreenPreviewController.__PropertyOffset_ActivePreviewOwner)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)AKuroSplitScreenPreviewController.__PropertyOffset_ActivePreviewOwner)), value);
			}
		}

		// Token: 0x06007659 RID: 30297 RVA: 0x000ACCB8 File Offset: 0x000AAEB8
		public unsafe void StopSplitScreenPreview(string PreviewOwner, bool bDeferCameraModelDestruction = false)
		{
			FString fstring = FString.AllocTemp(PreviewOwner);
			AKuroSplitScreenPreviewController.__StopSplitScreenPreview_Internal(base.NativePtr, fstring, bDeferCameraModelDestruction);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600765A RID: 30298 RVA: 0x000ACCE4 File Offset: 0x000AAEE4
		public unsafe static void RequestRuntimeTakeover(string Reason)
		{
			FString fstring = FString.AllocTemp(Reason);
			AKuroSplitScreenPreviewController.__RequestRuntimeTakeover_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600765B RID: 30299 RVA: 0x000ACD08 File Offset: 0x000AAF08
		public unsafe virtual void OnStopSplitScreenPreview(string PreviewOwner, bool bDeferCameraModelDestruction)
		{
			FString fstring = FString.AllocTemp(PreviewOwner);
			AKuroSplitScreenPreviewController.__OnStopSplitScreenPreview_Internal(base.NativePtr, fstring, bDeferCameraModelDestruction);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600765C RID: 30300
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopSplitScreenPreview_Internal(IntPtr @this, in FString PreviewOwner, bool bDeferCameraModelDestruction);

		// Token: 0x0600765D RID: 30301
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RequestRuntimeTakeover_Internal(in FString Reason);

		// Token: 0x0600765E RID: 30302
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnStopSplitScreenPreview_Internal(IntPtr @this, in FString PreviewOwner, bool bDeferCameraModelDestruction);

		// Token: 0x0600765F RID: 30303 RVA: 0x000ACD33 File Offset: 0x000AAF33
		static AKuroSplitScreenPreviewController()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroSplitScreenPreviewController");
		}

		// Token: 0x06007660 RID: 30304 RVA: 0x000ACD41 File Offset: 0x000AAF41
		protected AKuroSplitScreenPreviewController(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040031DB RID: 12763
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroSplitScreenPreviewController";

		// Token: 0x040031DC RID: 12764
		private static IntPtr _ClassPtr;

		// Token: 0x040031DD RID: 12765
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040031DE RID: 12766
		internal static int __PropertyOffset_MainCameraName;

		// Token: 0x040031DF RID: 12767
		internal static int __PropertyOffset_MainCameraBindingTag;

		// Token: 0x040031E0 RID: 12768
		internal static int __PropertyOffset_MainLayout;

		// Token: 0x040031E1 RID: 12769
		[Nullable(2)]
		private FKuroSeparateCameraData _MainLayout;

		// Token: 0x040031E2 RID: 12770
		internal static int __PropertyOffset_ActivePreviewOwner;

		// Token: 0x02000C22 RID: 3106
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __OnStopSplitScreenPreview_FunctionParams
		{
			// Token: 0x04005E6A RID: 24170
			[FieldOffset(0)]
			public FString PreviewOwner;

			// Token: 0x04005E6B RID: 24171
			[FieldOffset(16)]
			public bool bDeferCameraModelDestruction;
		}
	}
}
