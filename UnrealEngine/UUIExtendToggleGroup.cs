using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002168 RID: 8552
	[UnrealObjectPath("/Script/LGUI.UIExtendToggleGroup")]
	[UnrealStructLayout(272, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 272)]
	public class UUIExtendToggleGroup : UActorComponent, IUnrealUObject, IUnrealObject, ILGUIPointerEnterExitInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06020488 RID: 132232 RVA: 0x002FF1A4 File Offset: 0x002FD3A4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIExtendToggleGroup._ClassPtr;
		}

		// Token: 0x06020489 RID: 132233 RVA: 0x002FF1B0 File Offset: 0x002FD3B0
		int ILGUIPointerEnterExitInterface.InterfaceOffset()
		{
			return UUIExtendToggleGroup.__InterfaceOffset_ILGUIPointerEnterExitInterface;
		}

		// Token: 0x0602048A RID: 132234 RVA: 0x002FF1B8 File Offset: 0x002FD3B8
		public UUIExtendToggleGroup() : this(BuiltinUtils.AllocNativeUObject(UUIExtendToggleGroup.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602048B RID: 132235 RVA: 0x002FF1E0 File Offset: 0x002FD3E0
		[NullableContext(1)]
		public UUIExtendToggleGroup(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIExtendToggleGroup.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007E8E RID: 32398
		// (get) Token: 0x0602048C RID: 132236 RVA: 0x002FF214 File Offset: 0x002FD414
		// (set) Token: 0x0602048D RID: 132237 RVA: 0x002FF24D File Offset: 0x002FD44D
		[Nullable(1)]
		public FOnToggleGroupActivationChanged OnToggleGroupActivationChanged
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FOnToggleGroupActivationChanged result;
				if ((result = this._OnToggleGroupActivationChanged) == null)
				{
					result = (this._OnToggleGroupActivationChanged = new FOnToggleGroupActivationChanged(base.NativePtr + (IntPtr)UUIExtendToggleGroup.__PropertyOffset_OnToggleGroupActivationChanged, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIExtendToggleGroup.__PropertyOffset_OnToggleGroupActivationChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17007E8F RID: 32399
		// (get) Token: 0x0602048E RID: 132238 RVA: 0x002FF26E File Offset: 0x002FD46E
		// (set) Token: 0x0602048F RID: 132239 RVA: 0x002FF27E File Offset: 0x002FD47E
		public unsafe bool bGroupToggleOnSelect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIExtendToggleGroup.__PropertyOffset_bGroupToggleOnSelect) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIExtendToggleGroup.__PropertyOffset_bGroupToggleOnSelect) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007E90 RID: 32400
		// (get) Token: 0x06020490 RID: 132240 RVA: 0x002FF290 File Offset: 0x002FD490
		// (set) Token: 0x06020491 RID: 132241 RVA: 0x002FF2C9 File Offset: 0x002FD4C9
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TWeakObjectPtr<UUIExtendToggle>> ToggleCollection
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TWeakObjectPtr<UUIExtendToggle>> result;
				if ((result = this._ToggleCollection) == null)
				{
					result = (this._ToggleCollection = new TArray<TWeakObjectPtr<UUIExtendToggle>>(base.NativePtr + (IntPtr)UUIExtendToggleGroup.__PropertyOffset_ToggleCollection, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.ToggleCollection.CopyAssign(value);
			}
		}

		// Token: 0x17007E91 RID: 32401
		// (get) Token: 0x06020492 RID: 132242 RVA: 0x002FF2D7 File Offset: 0x002FD4D7
		// (set) Token: 0x06020493 RID: 132243 RVA: 0x002FF2E7 File Offset: 0x002FD4E7
		public unsafe bool bAllowNoneSelect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIExtendToggleGroup.__PropertyOffset_bAllowNoneSelect) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIExtendToggleGroup.__PropertyOffset_bAllowNoneSelect) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007E92 RID: 32402
		// (get) Token: 0x06020494 RID: 132244 RVA: 0x002FF2F8 File Offset: 0x002FD4F8
		// (set) Token: 0x06020495 RID: 132245 RVA: 0x002FF308 File Offset: 0x002FD508
		public unsafe bool bEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIExtendToggleGroup.__PropertyOffset_bEnable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIExtendToggleGroup.__PropertyOffset_bEnable) = (value ? 1 : 0);
			}
		}

		// Token: 0x06020496 RID: 132246
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UnBindOnExtendToggleGroupActive();

		// Token: 0x06020497 RID: 132247 RVA: 0x002FF319 File Offset: 0x002FD519
		public void SetGroupEnable(bool bInEnable)
		{
			UUIExtendToggleGroup.__SetGroupEnable_Internal(base.NativePtr, bInEnable);
		}

		// Token: 0x06020498 RID: 132248 RVA: 0x002FF327 File Offset: 0x002FD527
		public void SetAllowNoneSelect(bool bAllowNoneSelection)
		{
			UUIExtendToggleGroup.__SetAllowNoneSelect_Internal(base.NativePtr, bAllowNoneSelection);
		}

		// Token: 0x06020499 RID: 132249 RVA: 0x002FF335 File Offset: 0x002FD535
		[NullableContext(2)]
		public UUIExtendToggle GetCurSelection()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUIExtendToggle>(UUIExtendToggleGroup.__GetCurSelection_Internal(base.NativePtr));
		}

		// Token: 0x0602049A RID: 132250 RVA: 0x002FF347 File Offset: 0x002FD547
		public bool GetAllowNoneSelect()
		{
			return UUIExtendToggleGroup.__GetAllowNoneSelect_Internal(base.NativePtr);
		}

		// Token: 0x0602049B RID: 132251 RVA: 0x002FF354 File Offset: 0x002FD554
		[NullableContext(2)]
		public static void BindOnExtendToggleGroupActive(in FUIExtendToggleGroupActive Delegate)
		{
			FUIExtendToggleGroupActive fuiextendToggleGroupActive = Delegate;
			UUIExtendToggleGroup.__BindOnExtendToggleGroupActive_Internal((fuiextendToggleGroupActive != null) ? fuiextendToggleGroupActive.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0602049C RID: 132252
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGroupEnable_Internal(IntPtr @this, bool bInEnable);

		// Token: 0x0602049D RID: 132253
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllowNoneSelect_Internal(IntPtr @this, bool bAllowNoneSelection);

		// Token: 0x0602049E RID: 132254
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCurSelection_Internal(IntPtr @this);

		// Token: 0x0602049F RID: 132255
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetAllowNoneSelect_Internal(IntPtr @this);

		// Token: 0x060204A0 RID: 132256
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BindOnExtendToggleGroupActive_Internal(IntPtr Delegate);

		// Token: 0x060204A1 RID: 132257 RVA: 0x002FF36A File Offset: 0x002FD56A
		static UUIExtendToggleGroup()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIExtendToggleGroup");
		}

		// Token: 0x060204A2 RID: 132258 RVA: 0x002FF378 File Offset: 0x002FD578
		protected UUIExtendToggleGroup(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011589 RID: 71049
		internal static int __InterfaceOffset_ILGUIPointerEnterExitInterface;

		// Token: 0x0401158A RID: 71050
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIExtendToggleGroup";

		// Token: 0x0401158B RID: 71051
		private static IntPtr _ClassPtr;

		// Token: 0x0401158C RID: 71052
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401158D RID: 71053
		internal static int __PropertyOffset_OnToggleGroupActivationChanged;

		// Token: 0x0401158E RID: 71054
		[Nullable(2)]
		private FOnToggleGroupActivationChanged _OnToggleGroupActivationChanged;

		// Token: 0x0401158F RID: 71055
		internal static int __PropertyOffset_bGroupToggleOnSelect;

		// Token: 0x04011590 RID: 71056
		internal static int __PropertyOffset_ToggleCollection;

		// Token: 0x04011591 RID: 71057
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<UUIExtendToggle>> _ToggleCollection;

		// Token: 0x04011592 RID: 71058
		internal static int __PropertyOffset_bAllowNoneSelect;

		// Token: 0x04011593 RID: 71059
		internal static int __PropertyOffset_bEnable;
	}
}
