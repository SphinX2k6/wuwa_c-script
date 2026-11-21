using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004C4 RID: 1220
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroEditorTickActor")]
	[UnrealStructLayout(1440, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1440)]
	public class AKuroEditorTickActor : AKuroGameBudgetBlueprintActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007090 RID: 28816 RVA: 0x000A63F6 File Offset: 0x000A45F6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroEditorTickActor._ClassPtr;
		}

		// Token: 0x06007091 RID: 28817 RVA: 0x000A6404 File Offset: 0x000A4604
		public AKuroEditorTickActor() : this(BuiltinUtils.AllocNativeUObject(AKuroEditorTickActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007092 RID: 28818 RVA: 0x000A642C File Offset: 0x000A462C
		[NullableContext(1)]
		public AKuroEditorTickActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroEditorTickActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001605 RID: 5637
		// (get) Token: 0x06007093 RID: 28819 RVA: 0x000A645F File Offset: 0x000A465F
		// (set) Token: 0x06007094 RID: 28820 RVA: 0x000A646F File Offset: 0x000A466F
		public unsafe bool bEditorTickBySelected
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroEditorTickActor.__PropertyOffset_bEditorTickBySelected) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroEditorTickActor.__PropertyOffset_bEditorTickBySelected) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001606 RID: 5638
		// (get) Token: 0x06007095 RID: 28821 RVA: 0x000A6480 File Offset: 0x000A4680
		// (set) Token: 0x06007096 RID: 28822 RVA: 0x000A6490 File Offset: 0x000A4690
		public unsafe bool bSetActorComponentTickEnabledByFocus
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroEditorTickActor.__PropertyOffset_bSetActorComponentTickEnabledByFocus) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroEditorTickActor.__PropertyOffset_bSetActorComponentTickEnabledByFocus) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001607 RID: 5639
		// (get) Token: 0x06007097 RID: 28823 RVA: 0x000A64A1 File Offset: 0x000A46A1
		// (set) Token: 0x06007098 RID: 28824 RVA: 0x000A64B1 File Offset: 0x000A46B1
		public unsafe int KuroEditorTickActorId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroEditorTickActor.__PropertyOffset_KuroEditorTickActorId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroEditorTickActor.__PropertyOffset_KuroEditorTickActorId) = value;
			}
		}

		// Token: 0x17001608 RID: 5640
		// (get) Token: 0x06007099 RID: 28825 RVA: 0x000A64C2 File Offset: 0x000A46C2
		// (set) Token: 0x0600709A RID: 28826 RVA: 0x000A64D2 File Offset: 0x000A46D2
		public unsafe bool bSyncFolderPathToAttachChildren
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroEditorTickActor.__PropertyOffset_bSyncFolderPathToAttachChildren) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroEditorTickActor.__PropertyOffset_bSyncFolderPathToAttachChildren) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600709B RID: 28827 RVA: 0x000A64E3 File Offset: 0x000A46E3
		public virtual void EditorTick(float DeltaSeconds)
		{
			AKuroEditorTickActor.__EditorTick_Internal(base.NativePtr, DeltaSeconds);
		}

		// Token: 0x0600709C RID: 28828 RVA: 0x000A64F1 File Offset: 0x000A46F1
		public void EditorSetActorComponentsTickEnabled(bool bValue)
		{
			AKuroEditorTickActor.__EditorSetActorComponentsTickEnabled_Internal(base.NativePtr, bValue);
		}

		// Token: 0x0600709D RID: 28829 RVA: 0x000A64FF File Offset: 0x000A46FF
		public virtual void EditorInit()
		{
			AKuroEditorTickActor.__EditorInit_Internal(base.NativePtr);
		}

		// Token: 0x0600709E RID: 28830 RVA: 0x000A650C File Offset: 0x000A470C
		public virtual void EditorFocusOut()
		{
			AKuroEditorTickActor.__EditorFocusOut_Internal(base.NativePtr);
		}

		// Token: 0x0600709F RID: 28831 RVA: 0x000A6519 File Offset: 0x000A4719
		public virtual void EditorFocusIn()
		{
			AKuroEditorTickActor.__EditorFocusIn_Internal(base.NativePtr);
		}

		// Token: 0x060070A0 RID: 28832
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EditorTick_Internal(IntPtr @this, float DeltaSeconds);

		// Token: 0x060070A1 RID: 28833
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EditorSetActorComponentsTickEnabled_Internal(IntPtr @this, bool bValue);

		// Token: 0x060070A2 RID: 28834
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EditorInit_Internal(IntPtr @this);

		// Token: 0x060070A3 RID: 28835
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EditorFocusOut_Internal(IntPtr @this);

		// Token: 0x060070A4 RID: 28836
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EditorFocusIn_Internal(IntPtr @this);

		// Token: 0x060070A5 RID: 28837 RVA: 0x000A6526 File Offset: 0x000A4726
		static AKuroEditorTickActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroEditorTickActor");
		}

		// Token: 0x060070A6 RID: 28838 RVA: 0x000A6534 File Offset: 0x000A4734
		protected AKuroEditorTickActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040030A1 RID: 12449
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroEditorTickActor";

		// Token: 0x040030A2 RID: 12450
		private static IntPtr _ClassPtr;

		// Token: 0x040030A3 RID: 12451
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040030A4 RID: 12452
		internal static int __PropertyOffset_bEditorTickBySelected;

		// Token: 0x040030A5 RID: 12453
		internal static int __PropertyOffset_bSetActorComponentTickEnabledByFocus;

		// Token: 0x040030A6 RID: 12454
		internal static int __PropertyOffset_KuroEditorTickActorId;

		// Token: 0x040030A7 RID: 12455
		internal static int __PropertyOffset_bSyncFolderPathToAttachChildren;

		// Token: 0x02000C09 RID: 3081
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04005E3E RID: 24126
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
