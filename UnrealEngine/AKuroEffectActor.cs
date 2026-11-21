using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004C5 RID: 1221
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroEffectActor")]
	[UnrealStructLayout(1048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1048)]
	public class AKuroEffectActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060070A7 RID: 28839 RVA: 0x000A653D File Offset: 0x000A473D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroEffectActor._ClassPtr;
		}

		// Token: 0x060070A8 RID: 28840 RVA: 0x000A654C File Offset: 0x000A474C
		public AKuroEffectActor() : this(BuiltinUtils.AllocNativeUObject(AKuroEffectActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060070A9 RID: 28841 RVA: 0x000A6574 File Offset: 0x000A4774
		[NullableContext(1)]
		public AKuroEffectActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroEffectActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001609 RID: 5641
		// (get) Token: 0x060070AA RID: 28842 RVA: 0x000A65A7 File Offset: 0x000A47A7
		// (set) Token: 0x060070AB RID: 28843 RVA: 0x000A65B7 File Offset: 0x000A47B7
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

		// Token: 0x1700160A RID: 5642
		// (get) Token: 0x060070AC RID: 28844 RVA: 0x000A65C8 File Offset: 0x000A47C8
		// (set) Token: 0x060070AD RID: 28845 RVA: 0x000A65D8 File Offset: 0x000A47D8
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

		// Token: 0x060070AE RID: 28846 RVA: 0x000A65E9 File Offset: 0x000A47E9
		public virtual FBox GetStreamingBoundsEx()
		{
			return AKuroEffectActor.__GetStreamingBoundsEx_Internal(base.NativePtr);
		}

		// Token: 0x060070AF RID: 28847 RVA: 0x000A65F6 File Offset: 0x000A47F6
		protected virtual FBox GetStreamingBoundsEx_Implementation()
		{
			return AKuroEffectActor.__GetStreamingBoundsEx_Implementation_Internal(base.NativePtr);
		}

		// Token: 0x060070B0 RID: 28848 RVA: 0x000A6603 File Offset: 0x000A4803
		public virtual FBox GetStreamingBoundsEditor()
		{
			return AKuroEffectActor.__GetStreamingBoundsEditor_Internal(base.NativePtr);
		}

		// Token: 0x060070B1 RID: 28849 RVA: 0x000A6610 File Offset: 0x000A4810
		protected virtual FBox GetStreamingBoundsEditor_Implementation()
		{
			return AKuroEffectActor.__GetStreamingBoundsEditor_Implementation_Internal(base.NativePtr);
		}

		// Token: 0x060070B2 RID: 28850 RVA: 0x000A661D File Offset: 0x000A481D
		public virtual void EditorTick(float DeltaSeconds)
		{
			AKuroEffectActor.__EditorTick_Internal(base.NativePtr, DeltaSeconds);
		}

		// Token: 0x060070B3 RID: 28851 RVA: 0x000A662B File Offset: 0x000A482B
		public void EditorSetActorComponentsTickEnabled(bool bValue)
		{
			AKuroEffectActor.__EditorSetActorComponentsTickEnabled_Internal(base.NativePtr, bValue);
		}

		// Token: 0x060070B4 RID: 28852 RVA: 0x000A6639 File Offset: 0x000A4839
		public virtual void EditorInit()
		{
			AKuroEffectActor.__EditorInit_Internal(base.NativePtr);
		}

		// Token: 0x060070B5 RID: 28853 RVA: 0x000A6646 File Offset: 0x000A4846
		public virtual void EditorFocusOut()
		{
			AKuroEffectActor.__EditorFocusOut_Internal(base.NativePtr);
		}

		// Token: 0x060070B6 RID: 28854 RVA: 0x000A6653 File Offset: 0x000A4853
		public virtual void EditorFocusIn()
		{
			AKuroEffectActor.__EditorFocusIn_Internal(base.NativePtr);
		}

		// Token: 0x060070B7 RID: 28855 RVA: 0x000A6660 File Offset: 0x000A4860
		public virtual void EditorDestroy()
		{
			AKuroEffectActor.__EditorDestroy_Internal(base.NativePtr);
		}

		// Token: 0x060070B8 RID: 28856 RVA: 0x000A666D File Offset: 0x000A486D
		public virtual void DoHiddenInGame(bool bValue)
		{
			AKuroEffectActor.__DoHiddenInGame_Internal(base.NativePtr, bValue);
		}

		// Token: 0x060070B9 RID: 28857
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox __GetStreamingBoundsEx_Internal(IntPtr @this);

		// Token: 0x060070BA RID: 28858
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox __GetStreamingBoundsEx_Implementation_Internal(IntPtr @this);

		// Token: 0x060070BB RID: 28859
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox __GetStreamingBoundsEditor_Internal(IntPtr @this);

		// Token: 0x060070BC RID: 28860
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox __GetStreamingBoundsEditor_Implementation_Internal(IntPtr @this);

		// Token: 0x060070BD RID: 28861
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EditorTick_Internal(IntPtr @this, float DeltaSeconds);

		// Token: 0x060070BE RID: 28862
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EditorSetActorComponentsTickEnabled_Internal(IntPtr @this, bool bValue);

		// Token: 0x060070BF RID: 28863
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EditorInit_Internal(IntPtr @this);

		// Token: 0x060070C0 RID: 28864
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EditorFocusOut_Internal(IntPtr @this);

		// Token: 0x060070C1 RID: 28865
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EditorFocusIn_Internal(IntPtr @this);

		// Token: 0x060070C2 RID: 28866
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EditorDestroy_Internal(IntPtr @this);

		// Token: 0x060070C3 RID: 28867
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DoHiddenInGame_Internal(IntPtr @this, bool bValue);

		// Token: 0x060070C4 RID: 28868 RVA: 0x000A667B File Offset: 0x000A487B
		static AKuroEffectActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroEffectActor");
		}

		// Token: 0x060070C5 RID: 28869 RVA: 0x000A6689 File Offset: 0x000A4889
		protected AKuroEffectActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040030A8 RID: 12456
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroEffectActor";

		// Token: 0x040030A9 RID: 12457
		private static IntPtr _ClassPtr;

		// Token: 0x040030AA RID: 12458
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040030AB RID: 12459
		internal static int __PropertyOffset_bEditorTickBySelected;

		// Token: 0x040030AC RID: 12460
		internal static int __PropertyOffset_bSetActorComponentTickEnabledByFocus;

		// Token: 0x02000C0A RID: 3082
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 28)]
		protected ref struct __GetStreamingBoundsEx_FunctionParams
		{
			// Token: 0x04005E3F RID: 24127
			[FieldOffset(0)]
			public FBox __Result;
		}

		// Token: 0x02000C0B RID: 3083
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 28)]
		protected ref struct __GetStreamingBoundsEditor_FunctionParams
		{
			// Token: 0x04005E40 RID: 24128
			[FieldOffset(0)]
			public FBox __Result;
		}

		// Token: 0x02000C0C RID: 3084
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04005E41 RID: 24129
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02000C0D RID: 3085
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __DoHiddenInGame_FunctionParams
		{
			// Token: 0x04005E42 RID: 24130
			[FieldOffset(0)]
			public bool bValue;
		}
	}
}
