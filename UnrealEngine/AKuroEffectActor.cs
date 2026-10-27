using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AEB RID: 6891
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroEffectActor")]
	[UnrealStructLayout(1048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1048)]
	public class AKuroEffectActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06019B3A RID: 105274 RVA: 0x0025F8C6 File Offset: 0x0025DAC6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroEffectActor._ClassPtr;
		}

		// Token: 0x06019B3B RID: 105275 RVA: 0x0025F8D4 File Offset: 0x0025DAD4
		public AKuroEffectActor() : this(BuiltinUtils.AllocNativeUObject(AKuroEffectActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06019B3C RID: 105276 RVA: 0x0025F8FC File Offset: 0x0025DAFC
		[NullableContext(1)]
		public AKuroEffectActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroEffectActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170066AC RID: 26284
		// (get) Token: 0x06019B3D RID: 105277 RVA: 0x0025F92F File Offset: 0x0025DB2F
		// (set) Token: 0x06019B3E RID: 105278 RVA: 0x0025F93F File Offset: 0x0025DB3F
		public unsafe bool bEditorTickBySelected
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroEffectActor.__PropertyOffset_bEditorTickBySelected) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroEffectActor.__PropertyOffset_bEditorTickBySelected) = (value ? 1 : 0);
			}
		}

		// Token: 0x170066AD RID: 26285
		// (get) Token: 0x06019B3F RID: 105279 RVA: 0x0025F950 File Offset: 0x0025DB50
		// (set) Token: 0x06019B40 RID: 105280 RVA: 0x0025F960 File Offset: 0x0025DB60
		public unsafe bool bSetActorComponentTickEnabledByFocus
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroEffectActor.__PropertyOffset_bSetActorComponentTickEnabledByFocus) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroEffectActor.__PropertyOffset_bSetActorComponentTickEnabledByFocus) = (value ? 1 : 0);
			}
		}

		// Token: 0x06019B41 RID: 105281 RVA: 0x0025F971 File Offset: 0x0025DB71
		public virtual FBox GetStreamingBoundsEx()
		{
			return AKuroEffectActor.__GetStreamingBoundsEx_Internal(base.NativePtr);
		}

		// Token: 0x06019B42 RID: 105282 RVA: 0x0025F97E File Offset: 0x0025DB7E
		protected virtual FBox GetStreamingBoundsEx_Implementation()
		{
			return AKuroEffectActor.__GetStreamingBoundsEx_Implementation_Internal(base.NativePtr);
		}

		// Token: 0x06019B43 RID: 105283 RVA: 0x0025F98B File Offset: 0x0025DB8B
		public virtual FBox GetStreamingBoundsEditor()
		{
			return AKuroEffectActor.__GetStreamingBoundsEditor_Internal(base.NativePtr);
		}

		// Token: 0x06019B44 RID: 105284 RVA: 0x0025F998 File Offset: 0x0025DB98
		protected virtual FBox GetStreamingBoundsEditor_Implementation()
		{
			return AKuroEffectActor.__GetStreamingBoundsEditor_Implementation_Internal(base.NativePtr);
		}

		// Token: 0x06019B45 RID: 105285 RVA: 0x0025F9A5 File Offset: 0x0025DBA5
		public virtual void EditorTick(float DeltaSeconds)
		{
			AKuroEffectActor.__EditorTick_Internal(base.NativePtr, DeltaSeconds);
		}

		// Token: 0x06019B46 RID: 105286 RVA: 0x0025F9B3 File Offset: 0x0025DBB3
		public void EditorSetActorComponentsTickEnabled(bool bValue)
		{
			AKuroEffectActor.__EditorSetActorComponentsTickEnabled_Internal(base.NativePtr, bValue);
		}

		// Token: 0x06019B47 RID: 105287 RVA: 0x0025F9C1 File Offset: 0x0025DBC1
		public virtual void EditorInit()
		{
			AKuroEffectActor.__EditorInit_Internal(base.NativePtr);
		}

		// Token: 0x06019B48 RID: 105288 RVA: 0x0025F9CE File Offset: 0x0025DBCE
		public virtual void EditorFocusOut()
		{
			AKuroEffectActor.__EditorFocusOut_Internal(base.NativePtr);
		}

		// Token: 0x06019B49 RID: 105289 RVA: 0x0025F9DB File Offset: 0x0025DBDB
		public virtual void EditorFocusIn()
		{
			AKuroEffectActor.__EditorFocusIn_Internal(base.NativePtr);
		}

		// Token: 0x06019B4A RID: 105290 RVA: 0x0025F9E8 File Offset: 0x0025DBE8
		public virtual void EditorDestroy()
		{
			AKuroEffectActor.__EditorDestroy_Internal(base.NativePtr);
		}

		// Token: 0x06019B4B RID: 105291 RVA: 0x0025F9F5 File Offset: 0x0025DBF5
		public virtual void DoHiddenInGame(bool bValue)
		{
			AKuroEffectActor.__DoHiddenInGame_Internal(base.NativePtr, bValue);
		}

		// Token: 0x06019B4C RID: 105292
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox __GetStreamingBoundsEx_Internal(IntPtr @this);

		// Token: 0x06019B4D RID: 105293
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox __GetStreamingBoundsEx_Implementation_Internal(IntPtr @this);

		// Token: 0x06019B4E RID: 105294
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox __GetStreamingBoundsEditor_Internal(IntPtr @this);

		// Token: 0x06019B4F RID: 105295
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox __GetStreamingBoundsEditor_Implementation_Internal(IntPtr @this);

		// Token: 0x06019B50 RID: 105296
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EditorTick_Internal(IntPtr @this, float DeltaSeconds);

		// Token: 0x06019B51 RID: 105297
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EditorSetActorComponentsTickEnabled_Internal(IntPtr @this, bool bValue);

		// Token: 0x06019B52 RID: 105298
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EditorInit_Internal(IntPtr @this);

		// Token: 0x06019B53 RID: 105299
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EditorFocusOut_Internal(IntPtr @this);

		// Token: 0x06019B54 RID: 105300
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EditorFocusIn_Internal(IntPtr @this);

		// Token: 0x06019B55 RID: 105301
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EditorDestroy_Internal(IntPtr @this);

		// Token: 0x06019B56 RID: 105302
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DoHiddenInGame_Internal(IntPtr @this, bool bValue);

		// Token: 0x06019B57 RID: 105303 RVA: 0x0025FA03 File Offset: 0x0025DC03
		static AKuroEffectActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroEffectActor");
		}

		// Token: 0x06019B58 RID: 105304 RVA: 0x0025FA11 File Offset: 0x0025DC11
		protected AKuroEffectActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400DFA6 RID: 57254
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroEffectActor";

		// Token: 0x0400DFA7 RID: 57255
		private static IntPtr _ClassPtr;

		// Token: 0x0400DFA8 RID: 57256
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400DFA9 RID: 57257
		internal static int __PropertyOffset_bEditorTickBySelected;

		// Token: 0x0400DFAA RID: 57258
		internal static int __PropertyOffset_bSetActorComponentTickEnabledByFocus;

		// Token: 0x0200313C RID: 12604
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 28)]
		protected ref struct __GetStreamingBoundsEx_FunctionParams
		{
			// Token: 0x04016F4C RID: 94028
			[FieldOffset(0)]
			public FBox __Result;
		}

		// Token: 0x0200313D RID: 12605
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 28)]
		protected ref struct __GetStreamingBoundsEditor_FunctionParams
		{
			// Token: 0x04016F4D RID: 94029
			[FieldOffset(0)]
			public FBox __Result;
		}

		// Token: 0x0200313E RID: 12606
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04016F4E RID: 94030
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200313F RID: 12607
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __DoHiddenInGame_FunctionParams
		{
			// Token: 0x04016F4F RID: 94031
			[FieldOffset(0)]
			public bool bValue;
		}
	}
}
