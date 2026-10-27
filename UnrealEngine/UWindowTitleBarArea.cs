using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002A09 RID: 10761
	[UnrealObjectPath("/Script/UMG.WindowTitleBarArea")]
	[UnrealStructLayout(712, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 712)]
	public class UWindowTitleBarArea : UContentWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028029 RID: 163881 RVA: 0x003CE85F File Offset: 0x003CCA5F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWindowTitleBarArea._ClassPtr;
		}

		// Token: 0x0602802A RID: 163882 RVA: 0x003CE86C File Offset: 0x003CCA6C
		public UWindowTitleBarArea() : this(BuiltinUtils.AllocNativeUObject(UWindowTitleBarArea.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602802B RID: 163883 RVA: 0x003CE894 File Offset: 0x003CCA94
		[NullableContext(1)]
		public UWindowTitleBarArea(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWindowTitleBarArea.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170098D4 RID: 39124
		// (get) Token: 0x0602802C RID: 163884 RVA: 0x003CE8C7 File Offset: 0x003CCAC7
		// (set) Token: 0x0602802D RID: 163885 RVA: 0x003CE8D7 File Offset: 0x003CCAD7
		public unsafe bool bWindowButtonsEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWindowTitleBarArea.__PropertyOffset_bWindowButtonsEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWindowTitleBarArea.__PropertyOffset_bWindowButtonsEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x170098D5 RID: 39125
		// (get) Token: 0x0602802E RID: 163886 RVA: 0x003CE8E8 File Offset: 0x003CCAE8
		// (set) Token: 0x0602802F RID: 163887 RVA: 0x003CE8F8 File Offset: 0x003CCAF8
		public unsafe bool bDoubleClickTogglesFullscreen
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWindowTitleBarArea.__PropertyOffset_bDoubleClickTogglesFullscreen) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWindowTitleBarArea.__PropertyOffset_bDoubleClickTogglesFullscreen) = (value ? 1 : 0);
			}
		}

		// Token: 0x06028030 RID: 163888 RVA: 0x003CE909 File Offset: 0x003CCB09
		public void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment)
		{
			UWindowTitleBarArea.__SetVerticalAlignment_Internal(base.NativePtr, InVerticalAlignment);
		}

		// Token: 0x06028031 RID: 163889 RVA: 0x003CE91C File Offset: 0x003CCB1C
		public void SetPadding(FMargin InPadding)
		{
			UWindowTitleBarArea.__SetPadding_Internal(base.NativePtr, InPadding);
		}

		// Token: 0x06028032 RID: 163890 RVA: 0x003CE92A File Offset: 0x003CCB2A
		public void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment)
		{
			UWindowTitleBarArea.__SetHorizontalAlignment_Internal(base.NativePtr, InHorizontalAlignment);
		}

		// Token: 0x06028033 RID: 163891
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVerticalAlignment_Internal(IntPtr @this, TEnumAsByte<EVerticalAlignment> InVerticalAlignment);

		// Token: 0x06028034 RID: 163892
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPadding_Internal(IntPtr @this, FMargin InPadding);

		// Token: 0x06028035 RID: 163893
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHorizontalAlignment_Internal(IntPtr @this, TEnumAsByte<EHorizontalAlignment> InHorizontalAlignment);

		// Token: 0x06028036 RID: 163894 RVA: 0x003CE93D File Offset: 0x003CCB3D
		static UWindowTitleBarArea()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.WindowTitleBarArea");
		}

		// Token: 0x06028037 RID: 163895 RVA: 0x003CE94B File Offset: 0x003CCB4B
		protected UWindowTitleBarArea(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015D58 RID: 89432
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.WindowTitleBarArea";

		// Token: 0x04015D59 RID: 89433
		private static IntPtr _ClassPtr;

		// Token: 0x04015D5A RID: 89434
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015D5B RID: 89435
		internal static int __PropertyOffset_bWindowButtonsEnabled;

		// Token: 0x04015D5C RID: 89436
		internal static int __PropertyOffset_bDoubleClickTogglesFullscreen;
	}
}
