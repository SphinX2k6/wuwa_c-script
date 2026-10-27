using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200095F RID: 2399
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ComponentOverrideRecord")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 136)]
	public class FComponentOverrideRecord : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008791 RID: 34705 RVA: 0x000C2212 File Offset: 0x000C0412
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FComponentOverrideRecord._ScriptStructPtr != 0) ? FComponentOverrideRecord._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ComponentOverrideRecord", ref FComponentOverrideRecord._ScriptStructPtr);
		}

		// Token: 0x17002006 RID: 8198
		// (get) Token: 0x06008792 RID: 34706 RVA: 0x000C2236 File Offset: 0x000C0436
		// (set) Token: 0x06008793 RID: 34707 RVA: 0x000C224A File Offset: 0x000C044A
		public unsafe UClassStackOnlyPtr ComponentClass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FComponentOverrideRecord.__PropertyOffset_ComponentClass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FComponentOverrideRecord.__PropertyOffset_ComponentClass) = value;
			}
		}

		// Token: 0x17002007 RID: 8199
		// (get) Token: 0x06008794 RID: 34708 RVA: 0x000C225F File Offset: 0x000C045F
		// (set) Token: 0x06008795 RID: 34709 RVA: 0x000C2273 File Offset: 0x000C0473
		[Nullable(2)]
		public unsafe UActorComponent ComponentTemplate
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + FComponentOverrideRecord.__PropertyOffset_ComponentTemplate);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FComponentOverrideRecord.__PropertyOffset_ComponentTemplate, value);
			}
		}

		// Token: 0x17002008 RID: 8200
		// (get) Token: 0x06008796 RID: 34710 RVA: 0x000C2288 File Offset: 0x000C0488
		// (set) Token: 0x06008797 RID: 34711 RVA: 0x000C22CB File Offset: 0x000C04CB
		public FComponentKey ComponentKey
		{
			get
			{
				base.FastCheckIsValid();
				FComponentKey result;
				if ((result = this._ComponentKey) == null)
				{
					result = (this._ComponentKey = new FComponentKey(base.NativePtr + (IntPtr)FComponentOverrideRecord.__PropertyOffset_ComponentKey, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FComponentKey.StaticStruct(), base.NativePtr + (IntPtr)FComponentOverrideRecord.__PropertyOffset_ComponentKey, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002009 RID: 8201
		// (get) Token: 0x06008798 RID: 34712 RVA: 0x000C22EC File Offset: 0x000C04EC
		// (set) Token: 0x06008799 RID: 34713 RVA: 0x000C232F File Offset: 0x000C052F
		public FBlueprintCookedComponentInstancingData CookedComponentInstancingData
		{
			get
			{
				base.FastCheckIsValid();
				FBlueprintCookedComponentInstancingData result;
				if ((result = this._CookedComponentInstancingData) == null)
				{
					result = (this._CookedComponentInstancingData = new FBlueprintCookedComponentInstancingData(base.NativePtr + (IntPtr)FComponentOverrideRecord.__PropertyOffset_CookedComponentInstancingData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBlueprintCookedComponentInstancingData.StaticStruct(), base.NativePtr + (IntPtr)FComponentOverrideRecord.__PropertyOffset_CookedComponentInstancingData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600879A RID: 34714 RVA: 0x000C2350 File Offset: 0x000C0550
		public FComponentOverrideRecord()
		{
		}

		// Token: 0x0600879B RID: 34715 RVA: 0x000C2358 File Offset: 0x000C0558
		public FComponentOverrideRecord(UClassStackOnlyPtr ComponentClass, UActorComponent ComponentTemplate, FComponentKey ComponentKey, FBlueprintCookedComponentInstancingData CookedComponentInstancingData)
		{
			this.ComponentClass = ComponentClass;
			this.ComponentTemplate = ComponentTemplate;
			this.ComponentKey = ComponentKey;
			this.CookedComponentInstancingData = CookedComponentInstancingData;
		}

		// Token: 0x0600879C RID: 34716 RVA: 0x000C237D File Offset: 0x000C057D
		protected override IntPtr GetUStructPtr()
		{
			return FComponentOverrideRecord.StaticStruct();
		}

		// Token: 0x0600879D RID: 34717 RVA: 0x000C2389 File Offset: 0x000C0589
		[NullableContext(2)]
		public FComponentOverrideRecord(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600879E RID: 34718 RVA: 0x000C2393 File Offset: 0x000C0593
		public FComponentOverrideRecord(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600879F RID: 34719 RVA: 0x000C239E File Offset: 0x000C059E
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FComponentOverrideRecord(Pointer, false, true);
		}

		// Token: 0x060087A0 RID: 34720 RVA: 0x000C23A8 File Offset: 0x000C05A8
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FComponentOverrideRecord(Pointer, MemoryOwner);
		}

		// Token: 0x04004075 RID: 16501
		public const string __ObjectPath = "/Script/Engine.ComponentOverrideRecord";

		// Token: 0x04004076 RID: 16502
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004077 RID: 16503
		internal static int __PropertyOffset_ComponentClass;

		// Token: 0x04004078 RID: 16504
		internal static int __PropertyOffset_ComponentTemplate;

		// Token: 0x04004079 RID: 16505
		internal static int __PropertyOffset_ComponentKey;

		// Token: 0x0400407A RID: 16506
		[Nullable(2)]
		private FComponentKey _ComponentKey;

		// Token: 0x0400407B RID: 16507
		internal static int __PropertyOffset_CookedComponentInstancingData;

		// Token: 0x0400407C RID: 16508
		[Nullable(2)]
		private FBlueprintCookedComponentInstancingData _CookedComponentInstancingData;
	}
}
