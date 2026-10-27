using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002140 RID: 8512
	[UnrealObjectPath("/Script/LGUI.UIDropdownItemComponent")]
	[UnrealStructLayout(280, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 280)]
	public class UUIDropdownItemComponent : UActorComponent, IUnrealUObject, IUnrealObject, ILGUIPointerClickInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x060200F1 RID: 131313 RVA: 0x002FAD62 File Offset: 0x002F8F62
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIDropdownItemComponent._ClassPtr;
		}

		// Token: 0x060200F2 RID: 131314 RVA: 0x002FAD6E File Offset: 0x002F8F6E
		int ILGUIPointerClickInterface.InterfaceOffset()
		{
			return UUIDropdownItemComponent.__InterfaceOffset_ILGUIPointerClickInterface;
		}

		// Token: 0x060200F3 RID: 131315 RVA: 0x002FAD78 File Offset: 0x002F8F78
		public UUIDropdownItemComponent() : this(BuiltinUtils.AllocNativeUObject(UUIDropdownItemComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060200F4 RID: 131316 RVA: 0x002FADA0 File Offset: 0x002F8FA0
		[NullableContext(1)]
		public UUIDropdownItemComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIDropdownItemComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007DE9 RID: 32233
		// (get) Token: 0x060200F5 RID: 131317 RVA: 0x002FADD3 File Offset: 0x002F8FD3
		// (set) Token: 0x060200F6 RID: 131318 RVA: 0x002FADE7 File Offset: 0x002F8FE7
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AUITextActor> TextActor
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUIDropdownItemComponent.__PropertyOffset_TextActor);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUIDropdownItemComponent.__PropertyOffset_TextActor) = value;
			}
		}

		// Token: 0x17007DEA RID: 32234
		// (get) Token: 0x060200F7 RID: 131319 RVA: 0x002FADFC File Offset: 0x002F8FFC
		// (set) Token: 0x060200F8 RID: 131320 RVA: 0x002FAE10 File Offset: 0x002F9010
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AUITextActor> SecondTextActor
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUIDropdownItemComponent.__PropertyOffset_SecondTextActor);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUIDropdownItemComponent.__PropertyOffset_SecondTextActor) = value;
			}
		}

		// Token: 0x17007DEB RID: 32235
		// (get) Token: 0x060200F9 RID: 131321 RVA: 0x002FAE25 File Offset: 0x002F9025
		// (set) Token: 0x060200FA RID: 131322 RVA: 0x002FAE39 File Offset: 0x002F9039
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AUISpriteActor> SpriteActor
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUIDropdownItemComponent.__PropertyOffset_SpriteActor);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUIDropdownItemComponent.__PropertyOffset_SpriteActor) = value;
			}
		}

		// Token: 0x17007DEC RID: 32236
		// (get) Token: 0x060200FB RID: 131323 RVA: 0x002FAE50 File Offset: 0x002F9050
		// (set) Token: 0x060200FC RID: 131324 RVA: 0x002FAE89 File Offset: 0x002F9089
		[Nullable(1)]
		public FLGUIComponentReference Toggle
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FLGUIComponentReference result;
				if ((result = this._Toggle) == null)
				{
					result = (this._Toggle = new FLGUIComponentReference(base.NativePtr + (IntPtr)UUIDropdownItemComponent.__PropertyOffset_Toggle, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLGUIComponentReference.StaticStruct(), base.NativePtr + (IntPtr)UUIDropdownItemComponent.__PropertyOffset_Toggle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060200FD RID: 131325 RVA: 0x002FAEAA File Offset: 0x002F90AA
		static UUIDropdownItemComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIDropdownItemComponent");
		}

		// Token: 0x060200FE RID: 131326 RVA: 0x002FAEB8 File Offset: 0x002F90B8
		protected UUIDropdownItemComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401141E RID: 70686
		internal static int __InterfaceOffset_ILGUIPointerClickInterface;

		// Token: 0x0401141F RID: 70687
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIDropdownItemComponent";

		// Token: 0x04011420 RID: 70688
		private static IntPtr _ClassPtr;

		// Token: 0x04011421 RID: 70689
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011422 RID: 70690
		internal static int __PropertyOffset_TextActor;

		// Token: 0x04011423 RID: 70691
		internal static int __PropertyOffset_SecondTextActor;

		// Token: 0x04011424 RID: 70692
		internal static int __PropertyOffset_SpriteActor;

		// Token: 0x04011425 RID: 70693
		internal static int __PropertyOffset_Toggle;

		// Token: 0x04011426 RID: 70694
		[Nullable(2)]
		private FLGUIComponentReference _Toggle;
	}
}
