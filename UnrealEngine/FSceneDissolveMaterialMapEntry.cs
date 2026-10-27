using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001936 RID: 6454
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.SceneDissolveMaterialMapEntry")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FSceneDissolveMaterialMapEntry : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06017EDC RID: 98012 RVA: 0x0023106B File Offset: 0x0022F26B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSceneDissolveMaterialMapEntry._ScriptStructPtr != 0) ? FSceneDissolveMaterialMapEntry._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.SceneDissolveMaterialMapEntry", ref FSceneDissolveMaterialMapEntry._ScriptStructPtr);
		}

		// Token: 0x17006000 RID: 24576
		// (get) Token: 0x06017EDD RID: 98013 RVA: 0x0023108F File Offset: 0x0022F28F
		// (set) Token: 0x06017EDE RID: 98014 RVA: 0x002310A3 File Offset: 0x0022F2A3
		[Nullable(2)]
		public unsafe UMaterial ParentMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + FSceneDissolveMaterialMapEntry.__PropertyOffset_ParentMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FSceneDissolveMaterialMapEntry.__PropertyOffset_ParentMaterial, value);
			}
		}

		// Token: 0x17006001 RID: 24577
		// (get) Token: 0x06017EDF RID: 98015 RVA: 0x002310B8 File Offset: 0x0022F2B8
		// (set) Token: 0x06017EE0 RID: 98016 RVA: 0x002310FB File Offset: 0x0022F2FB
		public TArray<UMaterialInterface> ChildMICs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._ChildMICs) == null)
				{
					result = (this._ChildMICs = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)FSceneDissolveMaterialMapEntry.__PropertyOffset_ChildMICs, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ChildMICs.CopyAssign(value);
			}
		}

		// Token: 0x17006002 RID: 24578
		// (get) Token: 0x06017EE1 RID: 98017 RVA: 0x00231109 File Offset: 0x0022F309
		// (set) Token: 0x06017EE2 RID: 98018 RVA: 0x00231119 File Offset: 0x0022F319
		public unsafe int ReferencingComponentCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSceneDissolveMaterialMapEntry.__PropertyOffset_ReferencingComponentCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSceneDissolveMaterialMapEntry.__PropertyOffset_ReferencingComponentCount) = value;
			}
		}

		// Token: 0x06017EE3 RID: 98019 RVA: 0x0023112A File Offset: 0x0022F32A
		public FSceneDissolveMaterialMapEntry()
		{
		}

		// Token: 0x06017EE4 RID: 98020 RVA: 0x00231132 File Offset: 0x0022F332
		public FSceneDissolveMaterialMapEntry(UMaterial ParentMaterial, TArray<UMaterialInterface> ChildMICs, int ReferencingComponentCount)
		{
			this.ParentMaterial = ParentMaterial;
			this.ChildMICs = ChildMICs;
			this.ReferencingComponentCount = ReferencingComponentCount;
		}

		// Token: 0x06017EE5 RID: 98021 RVA: 0x0023114F File Offset: 0x0022F34F
		protected override IntPtr GetUStructPtr()
		{
			return FSceneDissolveMaterialMapEntry.StaticStruct();
		}

		// Token: 0x06017EE6 RID: 98022 RVA: 0x0023115B File Offset: 0x0022F35B
		[NullableContext(2)]
		public FSceneDissolveMaterialMapEntry(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017EE7 RID: 98023 RVA: 0x00231165 File Offset: 0x0022F365
		public FSceneDissolveMaterialMapEntry(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017EE8 RID: 98024 RVA: 0x00231170 File Offset: 0x0022F370
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSceneDissolveMaterialMapEntry(Pointer, false, true);
		}

		// Token: 0x06017EE9 RID: 98025 RVA: 0x0023117A File Offset: 0x0022F37A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSceneDissolveMaterialMapEntry(Pointer, MemoryOwner);
		}

		// Token: 0x0400CF43 RID: 53059
		public const string __ObjectPath = "/Script/KuroGameplay.SceneDissolveMaterialMapEntry";

		// Token: 0x0400CF44 RID: 53060
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400CF45 RID: 53061
		internal static int __PropertyOffset_ParentMaterial;

		// Token: 0x0400CF46 RID: 53062
		internal static int __PropertyOffset_ChildMICs;

		// Token: 0x0400CF47 RID: 53063
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _ChildMICs;

		// Token: 0x0400CF48 RID: 53064
		internal static int __PropertyOffset_ReferencingComponentCount;
	}
}
