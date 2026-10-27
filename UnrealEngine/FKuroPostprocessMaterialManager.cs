using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B90 RID: 7056
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroPostprocessMaterialManager")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FKuroPostprocessMaterialManager : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601AC66 RID: 109670 RVA: 0x00277493 File Offset: 0x00275693
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroPostprocessMaterialManager._ScriptStructPtr != 0) ? FKuroPostprocessMaterialManager._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroPostprocessMaterialManager", ref FKuroPostprocessMaterialManager._ScriptStructPtr);
		}

		// Token: 0x17006BAA RID: 27562
		// (get) Token: 0x0601AC67 RID: 109671 RVA: 0x002774B8 File Offset: 0x002756B8
		// (set) Token: 0x0601AC68 RID: 109672 RVA: 0x002774FB File Offset: 0x002756FB
		[Nullable(1)]
		public TArray<FMaterialStackElement> MaterialStack
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FMaterialStackElement> result;
				if ((result = this._MaterialStack) == null)
				{
					result = (this._MaterialStack = new TArray<FMaterialStackElement>(base.NativePtr + (IntPtr)FKuroPostprocessMaterialManager.__PropertyOffset_MaterialStack, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.MaterialStack.CopyAssign(value);
			}
		}

		// Token: 0x17006BAB RID: 27563
		// (get) Token: 0x0601AC69 RID: 109673 RVA: 0x00277509 File Offset: 0x00275709
		// (set) Token: 0x0601AC6A RID: 109674 RVA: 0x0027751D File Offset: 0x0027571D
		public unsafe UPostProcessComponent PostprocessComponentDisableRadialBlur
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroPostprocessMaterialManager.__PropertyOffset_PostprocessComponentDisableRadialBlur);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroPostprocessMaterialManager.__PropertyOffset_PostprocessComponentDisableRadialBlur, value);
			}
		}

		// Token: 0x17006BAC RID: 27564
		// (get) Token: 0x0601AC6B RID: 109675 RVA: 0x00277532 File Offset: 0x00275732
		// (set) Token: 0x0601AC6C RID: 109676 RVA: 0x00277546 File Offset: 0x00275746
		public unsafe UPostProcessComponent PostprocessComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroPostprocessMaterialManager.__PropertyOffset_PostprocessComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroPostprocessMaterialManager.__PropertyOffset_PostprocessComponent, value);
			}
		}

		// Token: 0x17006BAD RID: 27565
		// (get) Token: 0x0601AC6D RID: 109677 RVA: 0x0027755B File Offset: 0x0027575B
		// (set) Token: 0x0601AC6E RID: 109678 RVA: 0x0027756F File Offset: 0x0027576F
		public unsafe UKuroGISystem ParentGISystem
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroGISystem>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroPostprocessMaterialManager.__PropertyOffset_ParentGISystem);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroPostprocessMaterialManager.__PropertyOffset_ParentGISystem, value);
			}
		}

		// Token: 0x0601AC6F RID: 109679 RVA: 0x00277584 File Offset: 0x00275784
		public FKuroPostprocessMaterialManager()
		{
		}

		// Token: 0x0601AC70 RID: 109680 RVA: 0x0027758C File Offset: 0x0027578C
		[NullableContext(1)]
		public FKuroPostprocessMaterialManager(TArray<FMaterialStackElement> MaterialStack, UPostProcessComponent PostprocessComponentDisableRadialBlur, UPostProcessComponent PostprocessComponent, UKuroGISystem ParentGISystem)
		{
			this.MaterialStack = MaterialStack;
			this.PostprocessComponentDisableRadialBlur = PostprocessComponentDisableRadialBlur;
			this.PostprocessComponent = PostprocessComponent;
			this.ParentGISystem = ParentGISystem;
		}

		// Token: 0x0601AC71 RID: 109681 RVA: 0x002775B1 File Offset: 0x002757B1
		protected override IntPtr GetUStructPtr()
		{
			return FKuroPostprocessMaterialManager.StaticStruct();
		}

		// Token: 0x0601AC72 RID: 109682 RVA: 0x002775BD File Offset: 0x002757BD
		public FKuroPostprocessMaterialManager(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601AC73 RID: 109683 RVA: 0x002775C7 File Offset: 0x002757C7
		public FKuroPostprocessMaterialManager(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601AC74 RID: 109684 RVA: 0x002775D2 File Offset: 0x002757D2
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroPostprocessMaterialManager(Pointer, false, true);
		}

		// Token: 0x0601AC75 RID: 109685 RVA: 0x002775DC File Offset: 0x002757DC
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroPostprocessMaterialManager(Pointer, MemoryOwner);
		}

		// Token: 0x0400E7B6 RID: 59318
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroPostprocessMaterialManager";

		// Token: 0x0400E7B7 RID: 59319
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E7B8 RID: 59320
		internal static int __PropertyOffset_MaterialStack;

		// Token: 0x0400E7B9 RID: 59321
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMaterialStackElement> _MaterialStack;

		// Token: 0x0400E7BA RID: 59322
		internal static int __PropertyOffset_PostprocessComponentDisableRadialBlur;

		// Token: 0x0400E7BB RID: 59323
		internal static int __PropertyOffset_PostprocessComponent;

		// Token: 0x0400E7BC RID: 59324
		internal static int __PropertyOffset_ParentGISystem;
	}
}
