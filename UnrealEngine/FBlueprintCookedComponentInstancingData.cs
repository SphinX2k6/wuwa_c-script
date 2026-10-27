using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020008BC RID: 2236
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BlueprintCookedComponentInstancingData")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FBlueprintCookedComponentInstancingData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007A2F RID: 31279 RVA: 0x000AEC1B File Offset: 0x000ACE1B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBlueprintCookedComponentInstancingData._ScriptStructPtr != 0) ? FBlueprintCookedComponentInstancingData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BlueprintCookedComponentInstancingData", ref FBlueprintCookedComponentInstancingData._ScriptStructPtr);
		}

		// Token: 0x17001CE0 RID: 7392
		// (get) Token: 0x06007A30 RID: 31280 RVA: 0x000AEC40 File Offset: 0x000ACE40
		// (set) Token: 0x06007A31 RID: 31281 RVA: 0x000AEC83 File Offset: 0x000ACE83
		public TArray<FBlueprintComponentChangedPropertyInfo> ChangedPropertyList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBlueprintComponentChangedPropertyInfo> result;
				if ((result = this._ChangedPropertyList) == null)
				{
					result = (this._ChangedPropertyList = new TArray<FBlueprintComponentChangedPropertyInfo>(base.NativePtr + (IntPtr)FBlueprintCookedComponentInstancingData.__PropertyOffset_ChangedPropertyList, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ChangedPropertyList.CopyAssign(value);
			}
		}

		// Token: 0x17001CE1 RID: 7393
		// (get) Token: 0x06007A32 RID: 31282 RVA: 0x000AEC91 File Offset: 0x000ACE91
		// (set) Token: 0x06007A33 RID: 31283 RVA: 0x000AECA1 File Offset: 0x000ACEA1
		public unsafe bool bHasValidCookedData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBlueprintCookedComponentInstancingData.__PropertyOffset_bHasValidCookedData) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBlueprintCookedComponentInstancingData.__PropertyOffset_bHasValidCookedData) = (value ? 1 : 0);
			}
		}

		// Token: 0x06007A34 RID: 31284 RVA: 0x000AECB2 File Offset: 0x000ACEB2
		public FBlueprintCookedComponentInstancingData()
		{
		}

		// Token: 0x06007A35 RID: 31285 RVA: 0x000AECBA File Offset: 0x000ACEBA
		public FBlueprintCookedComponentInstancingData(TArray<FBlueprintComponentChangedPropertyInfo> ChangedPropertyList, bool bHasValidCookedData)
		{
			this.ChangedPropertyList = ChangedPropertyList;
			this.bHasValidCookedData = bHasValidCookedData;
		}

		// Token: 0x06007A36 RID: 31286 RVA: 0x000AECD0 File Offset: 0x000ACED0
		protected override IntPtr GetUStructPtr()
		{
			return FBlueprintCookedComponentInstancingData.StaticStruct();
		}

		// Token: 0x06007A37 RID: 31287 RVA: 0x000AECDC File Offset: 0x000ACEDC
		[NullableContext(2)]
		public FBlueprintCookedComponentInstancingData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007A38 RID: 31288 RVA: 0x000AECE6 File Offset: 0x000ACEE6
		public FBlueprintCookedComponentInstancingData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007A39 RID: 31289 RVA: 0x000AECF1 File Offset: 0x000ACEF1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBlueprintCookedComponentInstancingData(Pointer, false, true);
		}

		// Token: 0x06007A3A RID: 31290 RVA: 0x000AECFB File Offset: 0x000ACEFB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBlueprintCookedComponentInstancingData(Pointer, MemoryOwner);
		}

		// Token: 0x04003ABE RID: 15038
		public const string __ObjectPath = "/Script/Engine.BlueprintCookedComponentInstancingData";

		// Token: 0x04003ABF RID: 15039
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003AC0 RID: 15040
		internal static int __PropertyOffset_ChangedPropertyList;

		// Token: 0x04003AC1 RID: 15041
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBlueprintComponentChangedPropertyInfo> _ChangedPropertyList;

		// Token: 0x04003AC2 RID: 15042
		internal static int __PropertyOffset_bHasValidCookedData;
	}
}
