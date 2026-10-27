using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200216F RID: 8559
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIFlyoutMenuItem")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UUIFlyoutMenuItem : UActorComponent, IUnrealUObject, IUnrealObject, ILGUIPointerClickInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x060204EB RID: 132331 RVA: 0x002FFB6A File Offset: 0x002FDD6A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIFlyoutMenuItem._ClassPtr;
		}

		// Token: 0x060204EC RID: 132332 RVA: 0x002FFB76 File Offset: 0x002FDD76
		int ILGUIPointerClickInterface.InterfaceOffset()
		{
			return UUIFlyoutMenuItem.__InterfaceOffset_ILGUIPointerClickInterface;
		}

		// Token: 0x060204ED RID: 132333 RVA: 0x002FFB80 File Offset: 0x002FDD80
		public UUIFlyoutMenuItem() : this(BuiltinUtils.AllocNativeUObject(UUIFlyoutMenuItem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060204EE RID: 132334 RVA: 0x002FFBA8 File Offset: 0x002FDDA8
		[NullableContext(1)]
		public UUIFlyoutMenuItem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIFlyoutMenuItem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007EA1 RID: 32417
		// (get) Token: 0x060204EF RID: 132335 RVA: 0x002FFBDB File Offset: 0x002FDDDB
		// (set) Token: 0x060204F0 RID: 132336 RVA: 0x002FFBEF File Offset: 0x002FDDEF
		public unsafe AUIBaseActor _RootUIActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AUIBaseActor>(base.NativePtr / (IntPtr)sizeof(void*) + UUIFlyoutMenuItem.__PropertyOffset__RootUIActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUIFlyoutMenuItem.__PropertyOffset__RootUIActor, value);
			}
		}

		// Token: 0x17007EA2 RID: 32418
		// (get) Token: 0x060204F1 RID: 132337 RVA: 0x002FFC04 File Offset: 0x002FDE04
		// (set) Token: 0x060204F2 RID: 132338 RVA: 0x002FFC18 File Offset: 0x002FDE18
		public unsafe AUITextActor _TextActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AUITextActor>(base.NativePtr / (IntPtr)sizeof(void*) + UUIFlyoutMenuItem.__PropertyOffset__TextActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUIFlyoutMenuItem.__PropertyOffset__TextActor, value);
			}
		}

		// Token: 0x17007EA3 RID: 32419
		// (get) Token: 0x060204F3 RID: 132339 RVA: 0x002FFC2D File Offset: 0x002FDE2D
		// (set) Token: 0x060204F4 RID: 132340 RVA: 0x002FFC41 File Offset: 0x002FDE41
		public unsafe AUISpriteActor _HighlightSpriteActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AUISpriteActor>(base.NativePtr / (IntPtr)sizeof(void*) + UUIFlyoutMenuItem.__PropertyOffset__HighlightSpriteActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUIFlyoutMenuItem.__PropertyOffset__HighlightSpriteActor, value);
			}
		}

		// Token: 0x060204F5 RID: 132341 RVA: 0x002FFC56 File Offset: 0x002FDE56
		static UUIFlyoutMenuItem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIFlyoutMenuItem");
		}

		// Token: 0x060204F6 RID: 132342 RVA: 0x002FFC64 File Offset: 0x002FDE64
		protected UUIFlyoutMenuItem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040115BC RID: 71100
		internal static int __InterfaceOffset_ILGUIPointerClickInterface;

		// Token: 0x040115BD RID: 71101
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIFlyoutMenuItem";

		// Token: 0x040115BE RID: 71102
		private static IntPtr _ClassPtr;

		// Token: 0x040115BF RID: 71103
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040115C0 RID: 71104
		internal static int __PropertyOffset__RootUIActor;

		// Token: 0x040115C1 RID: 71105
		internal static int __PropertyOffset__TextActor;

		// Token: 0x040115C2 RID: 71106
		internal static int __PropertyOffset__HighlightSpriteActor;
	}
}
