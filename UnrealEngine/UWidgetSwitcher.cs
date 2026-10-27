using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002A05 RID: 10757
	[UnrealObjectPath("/Script/UMG.WidgetSwitcher")]
	[UnrealStructLayout(704, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 704)]
	public class UWidgetSwitcher : UPanelWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027FEE RID: 163822 RVA: 0x003CE459 File Offset: 0x003CC659
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWidgetSwitcher._ClassPtr;
		}

		// Token: 0x06027FEF RID: 163823 RVA: 0x003CE468 File Offset: 0x003CC668
		public UWidgetSwitcher() : this(BuiltinUtils.AllocNativeUObject(UWidgetSwitcher.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027FF0 RID: 163824 RVA: 0x003CE490 File Offset: 0x003CC690
		[NullableContext(1)]
		public UWidgetSwitcher(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWidgetSwitcher.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170098CB RID: 39115
		// (get) Token: 0x06027FF1 RID: 163825 RVA: 0x003CE4C3 File Offset: 0x003CC6C3
		// (set) Token: 0x06027FF2 RID: 163826 RVA: 0x003CE4D3 File Offset: 0x003CC6D3
		public unsafe int ActiveWidgetIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetSwitcher.__PropertyOffset_ActiveWidgetIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetSwitcher.__PropertyOffset_ActiveWidgetIndex) = value;
			}
		}

		// Token: 0x06027FF3 RID: 163827 RVA: 0x003CE4E4 File Offset: 0x003CC6E4
		public void SetActiveWidgetIndex(int Index)
		{
			UWidgetSwitcher.__SetActiveWidgetIndex_Internal(base.NativePtr, Index);
		}

		// Token: 0x06027FF4 RID: 163828 RVA: 0x003CE4F2 File Offset: 0x003CC6F2
		[NullableContext(2)]
		public void SetActiveWidget(UWidget Widget)
		{
			UWidgetSwitcher.__SetActiveWidget_Internal(base.NativePtr, (Widget != null) ? Widget.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06027FF5 RID: 163829 RVA: 0x003CE50F File Offset: 0x003CC70F
		[NullableContext(2)]
		public UWidget GetWidgetAtIndex(int Index)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UWidget>(UWidgetSwitcher.__GetWidgetAtIndex_Internal(base.NativePtr, Index));
		}

		// Token: 0x06027FF6 RID: 163830 RVA: 0x003CE522 File Offset: 0x003CC722
		public int GetNumWidgets()
		{
			return UWidgetSwitcher.__GetNumWidgets_Internal(base.NativePtr);
		}

		// Token: 0x06027FF7 RID: 163831 RVA: 0x003CE52F File Offset: 0x003CC72F
		public int GetActiveWidgetIndex()
		{
			return UWidgetSwitcher.__GetActiveWidgetIndex_Internal(base.NativePtr);
		}

		// Token: 0x06027FF8 RID: 163832 RVA: 0x003CE53C File Offset: 0x003CC73C
		[NullableContext(2)]
		public UWidget GetActiveWidget()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UWidget>(UWidgetSwitcher.__GetActiveWidget_Internal(base.NativePtr));
		}

		// Token: 0x06027FF9 RID: 163833
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetActiveWidgetIndex_Internal(IntPtr @this, int Index);

		// Token: 0x06027FFA RID: 163834
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetActiveWidget_Internal(IntPtr @this, IntPtr Widget);

		// Token: 0x06027FFB RID: 163835
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetWidgetAtIndex_Internal(IntPtr @this, int Index);

		// Token: 0x06027FFC RID: 163836
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumWidgets_Internal(IntPtr @this);

		// Token: 0x06027FFD RID: 163837
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetActiveWidgetIndex_Internal(IntPtr @this);

		// Token: 0x06027FFE RID: 163838
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetActiveWidget_Internal(IntPtr @this);

		// Token: 0x06027FFF RID: 163839 RVA: 0x003CE54E File Offset: 0x003CC74E
		static UWidgetSwitcher()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.WidgetSwitcher");
		}

		// Token: 0x06028000 RID: 163840 RVA: 0x003CE55C File Offset: 0x003CC75C
		protected UWidgetSwitcher(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015D44 RID: 89412
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.WidgetSwitcher";

		// Token: 0x04015D45 RID: 89413
		private static IntPtr _ClassPtr;

		// Token: 0x04015D46 RID: 89414
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015D47 RID: 89415
		internal static int __PropertyOffset_ActiveWidgetIndex;
	}
}
