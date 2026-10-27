using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002944 RID: 10564
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.CheckBoxGroup")]
	[UnrealStructLayout(792, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 792)]
	public class UCheckBoxGroup : UNamedSlot, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060271BA RID: 160186 RVA: 0x003BA145 File Offset: 0x003B8345
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCheckBoxGroup._ClassPtr;
		}

		// Token: 0x060271BB RID: 160187 RVA: 0x003BA154 File Offset: 0x003B8354
		public UCheckBoxGroup() : this(BuiltinUtils.AllocNativeUObject(UCheckBoxGroup.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060271BC RID: 160188 RVA: 0x003BA17C File Offset: 0x003B837C
		public UCheckBoxGroup(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCheckBoxGroup.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009675 RID: 38517
		// (get) Token: 0x060271BD RID: 160189 RVA: 0x003BA1B0 File Offset: 0x003B83B0
		// (set) Token: 0x060271BE RID: 160190 RVA: 0x003BA1E9 File Offset: 0x003B83E9
		public FSelectionChangedHandler SelectionChangedHandler
		{
			get
			{
				base.FastCheckIsValid();
				FSelectionChangedHandler result;
				if ((result = this._SelectionChangedHandler) == null)
				{
					result = (this._SelectionChangedHandler = new FSelectionChangedHandler(base.NativePtr + (IntPtr)UCheckBoxGroup.__PropertyOffset_SelectionChangedHandler, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UCheckBoxGroup.__PropertyOffset_SelectionChangedHandler, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17009676 RID: 38518
		// (get) Token: 0x060271BF RID: 160191 RVA: 0x003BA20A File Offset: 0x003B840A
		// (set) Token: 0x060271C0 RID: 160192 RVA: 0x003BA21E File Offset: 0x003B841E
		[Nullable(2)]
		public unsafe UWidgetSwitcher Switcher
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UWidgetSwitcher>(base.NativePtr / (IntPtr)sizeof(void*) + UCheckBoxGroup.__PropertyOffset_Switcher);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UCheckBoxGroup.__PropertyOffset_Switcher, value);
			}
		}

		// Token: 0x17009677 RID: 38519
		// (get) Token: 0x060271C1 RID: 160193 RVA: 0x003BA233 File Offset: 0x003B8433
		// (set) Token: 0x060271C2 RID: 160194 RVA: 0x003BA243 File Offset: 0x003B8443
		public unsafe int CurrentSelectIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCheckBoxGroup.__PropertyOffset_CurrentSelectIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCheckBoxGroup.__PropertyOffset_CurrentSelectIndex) = value;
			}
		}

		// Token: 0x060271C3 RID: 160195 RVA: 0x003BA254 File Offset: 0x003B8454
		public void SetSelectIndex(int Index, bool ForceSelect = false)
		{
			UCheckBoxGroup.__SetSelectIndex_Internal(base.NativePtr, Index, ForceSelect);
		}

		// Token: 0x060271C4 RID: 160196 RVA: 0x003BA263 File Offset: 0x003B8463
		public void OnStateChanged(bool bIsChecked)
		{
			UCheckBoxGroup.__OnStateChanged_Internal(base.NativePtr, bIsChecked);
		}

		// Token: 0x060271C5 RID: 160197
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSelectIndex_Internal(IntPtr @this, int Index, bool ForceSelect);

		// Token: 0x060271C6 RID: 160198
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnStateChanged_Internal(IntPtr @this, bool bIsChecked);

		// Token: 0x060271C7 RID: 160199 RVA: 0x003BA271 File Offset: 0x003B8471
		static UCheckBoxGroup()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.CheckBoxGroup");
		}

		// Token: 0x060271C8 RID: 160200 RVA: 0x003BA27F File Offset: 0x003B847F
		protected UCheckBoxGroup(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040157AA RID: 87978
		public new const string __ObjectPath = "/Script/UMG.CheckBoxGroup";

		// Token: 0x040157AB RID: 87979
		private static IntPtr _ClassPtr;

		// Token: 0x040157AC RID: 87980
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040157AD RID: 87981
		internal static int __PropertyOffset_SelectionChangedHandler;

		// Token: 0x040157AE RID: 87982
		[Nullable(2)]
		private FSelectionChangedHandler _SelectionChangedHandler;

		// Token: 0x040157AF RID: 87983
		internal static int __PropertyOffset_Switcher;

		// Token: 0x040157B0 RID: 87984
		internal static int __PropertyOffset_CurrentSelectIndex;
	}
}
