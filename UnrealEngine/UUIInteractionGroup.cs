using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002179 RID: 8569
	[UnrealObjectPath("/Script/LGUI.UIInteractionGroup")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 216)]
	public class UUIInteractionGroup : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602060A RID: 132618 RVA: 0x00300CF0 File Offset: 0x002FEEF0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIInteractionGroup._ClassPtr;
		}

		// Token: 0x0602060B RID: 132619 RVA: 0x00300CFC File Offset: 0x002FEEFC
		public UUIInteractionGroup() : this(BuiltinUtils.AllocNativeUObject(UUIInteractionGroup.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602060C RID: 132620 RVA: 0x00300D24 File Offset: 0x002FEF24
		[NullableContext(1)]
		public UUIInteractionGroup(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIInteractionGroup.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007EE0 RID: 32480
		// (get) Token: 0x0602060D RID: 132621 RVA: 0x00300D57 File Offset: 0x002FEF57
		// (set) Token: 0x0602060E RID: 132622 RVA: 0x00300D67 File Offset: 0x002FEF67
		public unsafe bool bInteractable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIInteractionGroup.__PropertyOffset_bInteractable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIInteractionGroup.__PropertyOffset_bInteractable) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007EE1 RID: 32481
		// (get) Token: 0x0602060F RID: 132623 RVA: 0x00300D78 File Offset: 0x002FEF78
		// (set) Token: 0x06020610 RID: 132624 RVA: 0x00300D88 File Offset: 0x002FEF88
		public unsafe bool bIgnoreParentGroup
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIInteractionGroup.__PropertyOffset_bIgnoreParentGroup) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIInteractionGroup.__PropertyOffset_bIgnoreParentGroup) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007EE2 RID: 32482
		// (get) Token: 0x06020611 RID: 132625 RVA: 0x00300D99 File Offset: 0x002FEF99
		// (set) Token: 0x06020612 RID: 132626 RVA: 0x00300DA9 File Offset: 0x002FEFA9
		public unsafe bool bGroupEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIInteractionGroup.__PropertyOffset_bGroupEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIInteractionGroup.__PropertyOffset_bGroupEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007EE3 RID: 32483
		// (get) Token: 0x06020613 RID: 132627 RVA: 0x00300DBA File Offset: 0x002FEFBA
		// (set) Token: 0x06020614 RID: 132628 RVA: 0x00300DCE File Offset: 0x002FEFCE
		[Nullable(2)]
		public unsafe UUIItem CacheUIItem
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUIItem>(base.NativePtr / (IntPtr)sizeof(void*) + UUIInteractionGroup.__PropertyOffset_CacheUIItem);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUIInteractionGroup.__PropertyOffset_CacheUIItem, value);
			}
		}

		// Token: 0x06020615 RID: 132629 RVA: 0x00300DE3 File Offset: 0x002FEFE3
		public void SetInteractable(bool value)
		{
			UUIInteractionGroup.__SetInteractable_Internal(base.NativePtr, value);
		}

		// Token: 0x06020616 RID: 132630 RVA: 0x00300DF1 File Offset: 0x002FEFF1
		public void SetIgnoreParentGroup(bool value)
		{
			UUIInteractionGroup.__SetIgnoreParentGroup_Internal(base.NativePtr, value);
		}

		// Token: 0x06020617 RID: 132631 RVA: 0x00300DFF File Offset: 0x002FEFFF
		public bool IsGroupEnabled()
		{
			return UUIInteractionGroup.__IsGroupEnabled_Internal(base.NativePtr);
		}

		// Token: 0x06020618 RID: 132632 RVA: 0x00300E0C File Offset: 0x002FF00C
		public bool GetInteractable()
		{
			return UUIInteractionGroup.__GetInteractable_Internal(base.NativePtr);
		}

		// Token: 0x06020619 RID: 132633 RVA: 0x00300E19 File Offset: 0x002FF019
		public bool GetIgnoreParentGroup()
		{
			return UUIInteractionGroup.__GetIgnoreParentGroup_Internal(base.NativePtr);
		}

		// Token: 0x0602061A RID: 132634
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInteractable_Internal(IntPtr @this, bool value);

		// Token: 0x0602061B RID: 132635
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIgnoreParentGroup_Internal(IntPtr @this, bool value);

		// Token: 0x0602061C RID: 132636
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsGroupEnabled_Internal(IntPtr @this);

		// Token: 0x0602061D RID: 132637
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetInteractable_Internal(IntPtr @this);

		// Token: 0x0602061E RID: 132638
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetIgnoreParentGroup_Internal(IntPtr @this);

		// Token: 0x0602061F RID: 132639 RVA: 0x00300E26 File Offset: 0x002FF026
		static UUIInteractionGroup()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIInteractionGroup");
		}

		// Token: 0x06020620 RID: 132640 RVA: 0x00300E34 File Offset: 0x002FF034
		protected UUIInteractionGroup(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401161B RID: 71195
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIInteractionGroup";

		// Token: 0x0401161C RID: 71196
		private static IntPtr _ClassPtr;

		// Token: 0x0401161D RID: 71197
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401161E RID: 71198
		internal static int __PropertyOffset_bInteractable;

		// Token: 0x0401161F RID: 71199
		internal static int __PropertyOffset_bIgnoreParentGroup;

		// Token: 0x04011620 RID: 71200
		internal static int __PropertyOffset_bGroupEnabled;

		// Token: 0x04011621 RID: 71201
		internal static int __PropertyOffset_CacheUIItem;
	}
}
