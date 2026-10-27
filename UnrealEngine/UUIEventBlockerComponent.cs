using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002164 RID: 8548
	[UnrealObjectPath("/Script/LGUI.UIEventBlockerComponent")]
	[UnrealStructLayout(264, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 264)]
	public class UUIEventBlockerComponent : UActorComponent, IUnrealUObject, IUnrealObject, ILGUIPointerEnterExitInterface, IUnrealNativeInterface, IUnrealInterface, ILGUIPointerDownUpInterface, ILGUIPointerClickInterface, ILGUIPointerDragInterface, ILGUIPointerDragDropInterface, ILGUIPointerScrollInterface, ILGUIPointerSelectDeselectInterface
	{
		// Token: 0x060203C5 RID: 132037 RVA: 0x002FDD22 File Offset: 0x002FBF22
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIEventBlockerComponent._ClassPtr;
		}

		// Token: 0x060203C6 RID: 132038 RVA: 0x002FDD2E File Offset: 0x002FBF2E
		int ILGUIPointerEnterExitInterface.InterfaceOffset()
		{
			return UUIEventBlockerComponent.__InterfaceOffset_ILGUIPointerEnterExitInterface;
		}

		// Token: 0x060203C7 RID: 132039 RVA: 0x002FDD35 File Offset: 0x002FBF35
		int ILGUIPointerDownUpInterface.InterfaceOffset()
		{
			return UUIEventBlockerComponent.__InterfaceOffset_ILGUIPointerDownUpInterface;
		}

		// Token: 0x060203C8 RID: 132040 RVA: 0x002FDD3C File Offset: 0x002FBF3C
		int ILGUIPointerClickInterface.InterfaceOffset()
		{
			return UUIEventBlockerComponent.__InterfaceOffset_ILGUIPointerClickInterface;
		}

		// Token: 0x060203C9 RID: 132041 RVA: 0x002FDD43 File Offset: 0x002FBF43
		int ILGUIPointerDragInterface.InterfaceOffset()
		{
			return UUIEventBlockerComponent.__InterfaceOffset_ILGUIPointerDragInterface;
		}

		// Token: 0x060203CA RID: 132042 RVA: 0x002FDD4A File Offset: 0x002FBF4A
		int ILGUIPointerDragDropInterface.InterfaceOffset()
		{
			return UUIEventBlockerComponent.__InterfaceOffset_ILGUIPointerDragDropInterface;
		}

		// Token: 0x060203CB RID: 132043 RVA: 0x002FDD51 File Offset: 0x002FBF51
		int ILGUIPointerScrollInterface.InterfaceOffset()
		{
			return UUIEventBlockerComponent.__InterfaceOffset_ILGUIPointerScrollInterface;
		}

		// Token: 0x060203CC RID: 132044 RVA: 0x002FDD58 File Offset: 0x002FBF58
		int ILGUIPointerSelectDeselectInterface.InterfaceOffset()
		{
			return UUIEventBlockerComponent.__InterfaceOffset_ILGUIPointerSelectDeselectInterface;
		}

		// Token: 0x060203CD RID: 132045 RVA: 0x002FDD60 File Offset: 0x002FBF60
		public UUIEventBlockerComponent() : this(BuiltinUtils.AllocNativeUObject(UUIEventBlockerComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060203CE RID: 132046 RVA: 0x002FDD88 File Offset: 0x002FBF88
		[NullableContext(1)]
		public UUIEventBlockerComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIEventBlockerComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007E61 RID: 32353
		// (get) Token: 0x060203CF RID: 132047 RVA: 0x002FDDBB File Offset: 0x002FBFBB
		// (set) Token: 0x060203D0 RID: 132048 RVA: 0x002FDDCB File Offset: 0x002FBFCB
		public unsafe bool AllowEventBubbleUp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEventBlockerComponent.__PropertyOffset_AllowEventBubbleUp) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEventBlockerComponent.__PropertyOffset_AllowEventBubbleUp) = (value ? 1 : 0);
			}
		}

		// Token: 0x060203D1 RID: 132049 RVA: 0x002FDDDC File Offset: 0x002FBFDC
		static UUIEventBlockerComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIEventBlockerComponent");
		}

		// Token: 0x060203D2 RID: 132050 RVA: 0x002FDDEA File Offset: 0x002FBFEA
		protected UUIEventBlockerComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401151B RID: 70939
		internal static int __InterfaceOffset_ILGUIPointerEnterExitInterface;

		// Token: 0x0401151C RID: 70940
		internal static int __InterfaceOffset_ILGUIPointerDownUpInterface;

		// Token: 0x0401151D RID: 70941
		internal static int __InterfaceOffset_ILGUIPointerClickInterface;

		// Token: 0x0401151E RID: 70942
		internal static int __InterfaceOffset_ILGUIPointerDragInterface;

		// Token: 0x0401151F RID: 70943
		internal static int __InterfaceOffset_ILGUIPointerDragDropInterface;

		// Token: 0x04011520 RID: 70944
		internal static int __InterfaceOffset_ILGUIPointerScrollInterface;

		// Token: 0x04011521 RID: 70945
		internal static int __InterfaceOffset_ILGUIPointerSelectDeselectInterface;

		// Token: 0x04011522 RID: 70946
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIEventBlockerComponent";

		// Token: 0x04011523 RID: 70947
		private static IntPtr _ClassPtr;

		// Token: 0x04011524 RID: 70948
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011525 RID: 70949
		internal static int __PropertyOffset_AllowEventBubbleUp;
	}
}
