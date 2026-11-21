using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000700 RID: 1792
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIExtendToggleGroup")]
	[UnrealStructLayout(272, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 272)]
	public class UUIExtendToggleGroup : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060098BD RID: 39101 RVA: 0x000E60F8 File Offset: 0x000E42F8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIExtendToggleGroup._ClassPtr;
		}

		// Token: 0x060098BE RID: 39102 RVA: 0x000E6104 File Offset: 0x000E4304
		public UUIExtendToggleGroup() : this(BuiltinUtils.AllocNativeUObject(UUIExtendToggleGroup.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060098BF RID: 39103 RVA: 0x000E612C File Offset: 0x000E432C
		public UUIExtendToggleGroup(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIExtendToggleGroup.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001C66 RID: 7270
		// (get) Token: 0x060098C0 RID: 39104 RVA: 0x000E6160 File Offset: 0x000E4360
		// (set) Token: 0x060098C1 RID: 39105 RVA: 0x000E6199 File Offset: 0x000E4399
		public FOnToggleGroupActivationChanged OnToggleGroupActivationChanged
		{
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
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIExtendToggleGroup.__PropertyOffset_OnToggleGroupActivationChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001C67 RID: 7271
		// (get) Token: 0x060098C2 RID: 39106 RVA: 0x000E61BA File Offset: 0x000E43BA
		// (set) Token: 0x060098C3 RID: 39107 RVA: 0x000E61CA File Offset: 0x000E43CA
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

		// Token: 0x17001C68 RID: 7272
		// (get) Token: 0x060098C4 RID: 39108 RVA: 0x000E61DC File Offset: 0x000E43DC
		// (set) Token: 0x060098C5 RID: 39109 RVA: 0x000E6215 File Offset: 0x000E4415
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

		// Token: 0x17001C69 RID: 7273
		// (get) Token: 0x060098C6 RID: 39110 RVA: 0x000E6223 File Offset: 0x000E4423
		// (set) Token: 0x060098C7 RID: 39111 RVA: 0x000E6233 File Offset: 0x000E4433
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

		// Token: 0x17001C6A RID: 7274
		// (get) Token: 0x060098C8 RID: 39112 RVA: 0x000E6244 File Offset: 0x000E4444
		// (set) Token: 0x060098C9 RID: 39113 RVA: 0x000E6254 File Offset: 0x000E4454
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

		// Token: 0x060098CA RID: 39114
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UnBindOnExtendToggleGroupActive();

		// Token: 0x060098CB RID: 39115 RVA: 0x000E6265 File Offset: 0x000E4465
		public void SetGroupEnable(bool bInEnable)
		{
			UUIExtendToggleGroup.__SetGroupEnable_Internal(base.NativePtr, bInEnable);
		}

		// Token: 0x060098CC RID: 39116 RVA: 0x000E6273 File Offset: 0x000E4473
		public void SetAllowNoneSelect(bool bAllowNoneSelection)
		{
			UUIExtendToggleGroup.__SetAllowNoneSelect_Internal(base.NativePtr, bAllowNoneSelection);
		}

		// Token: 0x060098CD RID: 39117 RVA: 0x000E6281 File Offset: 0x000E4481
		[NullableContext(2)]
		public UUIExtendToggle GetCurSelection()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUIExtendToggle>(UUIExtendToggleGroup.__GetCurSelection_Internal(base.NativePtr));
		}

		// Token: 0x060098CE RID: 39118 RVA: 0x000E6293 File Offset: 0x000E4493
		public bool GetAllowNoneSelect()
		{
			return UUIExtendToggleGroup.__GetAllowNoneSelect_Internal(base.NativePtr);
		}

		// Token: 0x060098CF RID: 39119 RVA: 0x000E62A0 File Offset: 0x000E44A0
		[NullableContext(2)]
		public static void BindOnExtendToggleGroupActive(in FUIExtendToggleGroupActive Delegate)
		{
			FUIExtendToggleGroupActive fuiextendToggleGroupActive = Delegate;
			UUIExtendToggleGroup.__BindOnExtendToggleGroupActive_Internal((fuiextendToggleGroupActive != null) ? fuiextendToggleGroupActive.NativePtr : ((IntPtr)0));
		}

		// Token: 0x060098D0 RID: 39120
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGroupEnable_Internal(IntPtr @this, bool bInEnable);

		// Token: 0x060098D1 RID: 39121
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllowNoneSelect_Internal(IntPtr @this, bool bAllowNoneSelection);

		// Token: 0x060098D2 RID: 39122
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCurSelection_Internal(IntPtr @this);

		// Token: 0x060098D3 RID: 39123
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetAllowNoneSelect_Internal(IntPtr @this);

		// Token: 0x060098D4 RID: 39124
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BindOnExtendToggleGroupActive_Internal(IntPtr Delegate);

		// Token: 0x060098D5 RID: 39125 RVA: 0x000E62B6 File Offset: 0x000E44B6
		static UUIExtendToggleGroup()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIExtendToggleGroup");
		}

		// Token: 0x060098D6 RID: 39126 RVA: 0x000E62C4 File Offset: 0x000E44C4
		protected UUIExtendToggleGroup(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004267 RID: 16999
		public new const string __ObjectPath = "/Script/LGUI.UIExtendToggleGroup";

		// Token: 0x04004268 RID: 17000
		private static IntPtr _ClassPtr;

		// Token: 0x04004269 RID: 17001
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400426A RID: 17002
		internal static int __PropertyOffset_OnToggleGroupActivationChanged;

		// Token: 0x0400426B RID: 17003
		[Nullable(2)]
		private FOnToggleGroupActivationChanged _OnToggleGroupActivationChanged;

		// Token: 0x0400426C RID: 17004
		internal static int __PropertyOffset_bGroupToggleOnSelect;

		// Token: 0x0400426D RID: 17005
		internal static int __PropertyOffset_ToggleCollection;

		// Token: 0x0400426E RID: 17006
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<UUIExtendToggle>> _ToggleCollection;

		// Token: 0x0400426F RID: 17007
		internal static int __PropertyOffset_bAllowNoneSelect;

		// Token: 0x04004270 RID: 17008
		internal static int __PropertyOffset_bEnable;
	}
}
