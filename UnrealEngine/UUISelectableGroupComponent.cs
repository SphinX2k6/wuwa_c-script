using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021AA RID: 8618
	[UnrealObjectPath("/Script/LGUI.UISelectableGroupComponent")]
	[UnrealStructLayout(320, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 320)]
	public class UUISelectableGroupComponent : ULGUIBehaviour, IUnrealUObject, IUnrealObject, ILGUIPointerEnterExitInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06020C57 RID: 134231 RVA: 0x003070C9 File Offset: 0x003052C9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUISelectableGroupComponent._ClassPtr;
		}

		// Token: 0x06020C58 RID: 134232 RVA: 0x003070D5 File Offset: 0x003052D5
		int ILGUIPointerEnterExitInterface.InterfaceOffset()
		{
			return UUISelectableGroupComponent.__InterfaceOffset_ILGUIPointerEnterExitInterface;
		}

		// Token: 0x06020C59 RID: 134233 RVA: 0x003070DC File Offset: 0x003052DC
		public UUISelectableGroupComponent() : this(BuiltinUtils.AllocNativeUObject(UUISelectableGroupComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020C5A RID: 134234 RVA: 0x00307104 File Offset: 0x00305304
		[NullableContext(1)]
		public UUISelectableGroupComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUISelectableGroupComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008003 RID: 32771
		// (get) Token: 0x06020C5B RID: 134235 RVA: 0x00307137 File Offset: 0x00305337
		// (set) Token: 0x06020C5C RID: 134236 RVA: 0x00307147 File Offset: 0x00305347
		public unsafe bool AllowEventBubbleUp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISelectableGroupComponent.__PropertyOffset_AllowEventBubbleUp) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISelectableGroupComponent.__PropertyOffset_AllowEventBubbleUp) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008004 RID: 32772
		// (get) Token: 0x06020C5D RID: 134237 RVA: 0x00307158 File Offset: 0x00305358
		// (set) Token: 0x06020C5E RID: 134238 RVA: 0x0030716C File Offset: 0x0030536C
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UUISelectableComponent> Selected
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUISelectableGroupComponent.__PropertyOffset_Selected);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUISelectableGroupComponent.__PropertyOffset_Selected) = value;
			}
		}

		// Token: 0x17008005 RID: 32773
		// (get) Token: 0x06020C5F RID: 134239 RVA: 0x00307181 File Offset: 0x00305381
		// (set) Token: 0x06020C60 RID: 134240 RVA: 0x00307195 File Offset: 0x00305395
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UUISelectableComponent> Highlighted
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUISelectableGroupComponent.__PropertyOffset_Highlighted);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUISelectableGroupComponent.__PropertyOffset_Highlighted) = value;
			}
		}

		// Token: 0x17008006 RID: 32774
		// (get) Token: 0x06020C61 RID: 134241 RVA: 0x003071AC File Offset: 0x003053AC
		// (set) Token: 0x06020C62 RID: 134242 RVA: 0x003071E5 File Offset: 0x003053E5
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TWeakObjectPtr<UUISelectableComponent>> SelectableComponents
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
				TArray<TWeakObjectPtr<UUISelectableComponent>> result;
				if ((result = this._SelectableComponents) == null)
				{
					result = (this._SelectableComponents = new TArray<TWeakObjectPtr<UUISelectableComponent>>(base.NativePtr + (IntPtr)UUISelectableGroupComponent.__PropertyOffset_SelectableComponents, this));
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
				this.SelectableComponents.CopyAssign(value);
			}
		}

		// Token: 0x06020C63 RID: 134243 RVA: 0x003071F3 File Offset: 0x003053F3
		public void OnComponentUnselected()
		{
			UUISelectableGroupComponent.__OnComponentUnselected_Internal(base.NativePtr);
		}

		// Token: 0x06020C64 RID: 134244 RVA: 0x00307200 File Offset: 0x00305400
		public void OnComponentUnhighlighted()
		{
			UUISelectableGroupComponent.__OnComponentUnhighlighted_Internal(base.NativePtr);
		}

		// Token: 0x06020C65 RID: 134245 RVA: 0x0030720D File Offset: 0x0030540D
		[NullableContext(2)]
		public void OnComponentSelected(UUISelectableComponent Component)
		{
			UUISelectableGroupComponent.__OnComponentSelected_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06020C66 RID: 134246 RVA: 0x0030722A File Offset: 0x0030542A
		[NullableContext(2)]
		public void OnComponentHighlighted(UUISelectableComponent Component)
		{
			UUISelectableGroupComponent.__OnComponentHighlighted_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06020C67 RID: 134247
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnComponentUnselected_Internal(IntPtr @this);

		// Token: 0x06020C68 RID: 134248
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnComponentUnhighlighted_Internal(IntPtr @this);

		// Token: 0x06020C69 RID: 134249
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnComponentSelected_Internal(IntPtr @this, IntPtr Component);

		// Token: 0x06020C6A RID: 134250
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnComponentHighlighted_Internal(IntPtr @this, IntPtr Component);

		// Token: 0x06020C6B RID: 134251 RVA: 0x00307247 File Offset: 0x00305447
		static UUISelectableGroupComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UISelectableGroupComponent");
		}

		// Token: 0x06020C6C RID: 134252 RVA: 0x00307255 File Offset: 0x00305455
		protected UUISelectableGroupComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011825 RID: 71717
		internal static int __InterfaceOffset_ILGUIPointerEnterExitInterface;

		// Token: 0x04011826 RID: 71718
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UISelectableGroupComponent";

		// Token: 0x04011827 RID: 71719
		private static IntPtr _ClassPtr;

		// Token: 0x04011828 RID: 71720
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011829 RID: 71721
		internal static int __PropertyOffset_AllowEventBubbleUp;

		// Token: 0x0401182A RID: 71722
		internal static int __PropertyOffset_Selected;

		// Token: 0x0401182B RID: 71723
		internal static int __PropertyOffset_Highlighted;

		// Token: 0x0401182C RID: 71724
		internal static int __PropertyOffset_SelectableComponents;

		// Token: 0x0401182D RID: 71725
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<UUISelectableComponent>> _SelectableComponents;
	}
}
