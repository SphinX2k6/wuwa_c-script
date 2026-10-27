using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AE9 RID: 6889
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroEditorTickActor")]
	[UnrealStructLayout(1440, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1440)]
	public class AKuroEditorTickActor : AKuroGameBudgetBlueprintActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06019B1E RID: 105246 RVA: 0x0025F700 File Offset: 0x0025D900
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroEditorTickActor._ClassPtr;
		}

		// Token: 0x06019B1F RID: 105247 RVA: 0x0025F70C File Offset: 0x0025D90C
		public AKuroEditorTickActor() : this(BuiltinUtils.AllocNativeUObject(AKuroEditorTickActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06019B20 RID: 105248 RVA: 0x0025F734 File Offset: 0x0025D934
		[NullableContext(1)]
		public AKuroEditorTickActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroEditorTickActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170066A8 RID: 26280
		// (get) Token: 0x06019B21 RID: 105249 RVA: 0x0025F767 File Offset: 0x0025D967
		// (set) Token: 0x06019B22 RID: 105250 RVA: 0x0025F777 File Offset: 0x0025D977
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

		// Token: 0x170066A9 RID: 26281
		// (get) Token: 0x06019B23 RID: 105251 RVA: 0x0025F788 File Offset: 0x0025D988
		// (set) Token: 0x06019B24 RID: 105252 RVA: 0x0025F798 File Offset: 0x0025D998
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

		// Token: 0x170066AA RID: 26282
		// (get) Token: 0x06019B25 RID: 105253 RVA: 0x0025F7A9 File Offset: 0x0025D9A9
		// (set) Token: 0x06019B26 RID: 105254 RVA: 0x0025F7B9 File Offset: 0x0025D9B9
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

		// Token: 0x170066AB RID: 26283
		// (get) Token: 0x06019B27 RID: 105255 RVA: 0x0025F7CA File Offset: 0x0025D9CA
		// (set) Token: 0x06019B28 RID: 105256 RVA: 0x0025F7DA File Offset: 0x0025D9DA
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

		// Token: 0x06019B29 RID: 105257 RVA: 0x0025F7EB File Offset: 0x0025D9EB
		public virtual void EditorTick(float DeltaSeconds)
		{
			AKuroEditorTickActor.__EditorTick_Internal(base.NativePtr, DeltaSeconds);
		}

		// Token: 0x06019B2A RID: 105258 RVA: 0x0025F7F9 File Offset: 0x0025D9F9
		public void EditorSetActorComponentsTickEnabled(bool bValue)
		{
			AKuroEditorTickActor.__EditorSetActorComponentsTickEnabled_Internal(base.NativePtr, bValue);
		}

		// Token: 0x06019B2B RID: 105259 RVA: 0x0025F807 File Offset: 0x0025DA07
		public virtual void EditorInit()
		{
			AKuroEditorTickActor.__EditorInit_Internal(base.NativePtr);
		}

		// Token: 0x06019B2C RID: 105260 RVA: 0x0025F814 File Offset: 0x0025DA14
		public virtual void EditorFocusOut()
		{
			AKuroEditorTickActor.__EditorFocusOut_Internal(base.NativePtr);
		}

		// Token: 0x06019B2D RID: 105261 RVA: 0x0025F821 File Offset: 0x0025DA21
		public virtual void EditorFocusIn()
		{
			AKuroEditorTickActor.__EditorFocusIn_Internal(base.NativePtr);
		}

		// Token: 0x06019B2E RID: 105262
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EditorTick_Internal(IntPtr @this, float DeltaSeconds);

		// Token: 0x06019B2F RID: 105263
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EditorSetActorComponentsTickEnabled_Internal(IntPtr @this, bool bValue);

		// Token: 0x06019B30 RID: 105264
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EditorInit_Internal(IntPtr @this);

		// Token: 0x06019B31 RID: 105265
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EditorFocusOut_Internal(IntPtr @this);

		// Token: 0x06019B32 RID: 105266
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EditorFocusIn_Internal(IntPtr @this);

		// Token: 0x06019B33 RID: 105267 RVA: 0x0025F82E File Offset: 0x0025DA2E
		static AKuroEditorTickActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroEditorTickActor");
		}

		// Token: 0x06019B34 RID: 105268 RVA: 0x0025F83C File Offset: 0x0025DA3C
		protected AKuroEditorTickActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400DF9C RID: 57244
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroEditorTickActor";

		// Token: 0x0400DF9D RID: 57245
		private static IntPtr _ClassPtr;

		// Token: 0x0400DF9E RID: 57246
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400DF9F RID: 57247
		internal static int __PropertyOffset_bEditorTickBySelected;

		// Token: 0x0400DFA0 RID: 57248
		internal static int __PropertyOffset_bSetActorComponentTickEnabledByFocus;

		// Token: 0x0400DFA1 RID: 57249
		internal static int __PropertyOffset_KuroEditorTickActorId;

		// Token: 0x0400DFA2 RID: 57250
		internal static int __PropertyOffset_bSyncFolderPathToAttachChildren;

		// Token: 0x0200313B RID: 12603
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04016F4B RID: 94027
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
