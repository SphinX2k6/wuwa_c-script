using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200226E RID: 8814
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MagtModule.MagtAPQualityGroup")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 144)]
	public class FMagtAPQualityGroup : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021802 RID: 137218 RVA: 0x00317C54 File Offset: 0x00315E54
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMagtAPQualityGroup._ScriptStructPtr != 0) ? FMagtAPQualityGroup._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MagtModule.MagtAPQualityGroup", ref FMagtAPQualityGroup._ScriptStructPtr);
		}

		// Token: 0x17008244 RID: 33348
		// (get) Token: 0x06021803 RID: 137219 RVA: 0x00317C78 File Offset: 0x00315E78
		// (set) Token: 0x06021804 RID: 137220 RVA: 0x00317C8C File Offset: 0x00315E8C
		public unsafe FName GroupName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMagtAPQualityGroup.__PropertyOffset_GroupName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMagtAPQualityGroup.__PropertyOffset_GroupName) = value;
			}
		}

		// Token: 0x17008245 RID: 33349
		// (get) Token: 0x06021805 RID: 137221 RVA: 0x00317CA1 File Offset: 0x00315EA1
		// (set) Token: 0x06021806 RID: 137222 RVA: 0x00317CB5 File Offset: 0x00315EB5
		public unsafe string CVarName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FMagtAPQualityGroup.__PropertyOffset_CVarName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FMagtAPQualityGroup.__PropertyOffset_CVarName)), value);
			}
		}

		// Token: 0x17008246 RID: 33350
		// (get) Token: 0x06021807 RID: 137223 RVA: 0x00317CCA File Offset: 0x00315ECA
		// (set) Token: 0x06021808 RID: 137224 RVA: 0x00317CDE File Offset: 0x00315EDE
		public unsafe string Description
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FMagtAPQualityGroup.__PropertyOffset_Description)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FMagtAPQualityGroup.__PropertyOffset_Description)), value);
			}
		}

		// Token: 0x17008247 RID: 33351
		// (get) Token: 0x06021809 RID: 137225 RVA: 0x00317CF3 File Offset: 0x00315EF3
		// (set) Token: 0x0602180A RID: 137226 RVA: 0x00317D03 File Offset: 0x00315F03
		public unsafe int CPUImpact
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMagtAPQualityGroup.__PropertyOffset_CPUImpact);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMagtAPQualityGroup.__PropertyOffset_CPUImpact) = value;
			}
		}

		// Token: 0x17008248 RID: 33352
		// (get) Token: 0x0602180B RID: 137227 RVA: 0x00317D14 File Offset: 0x00315F14
		// (set) Token: 0x0602180C RID: 137228 RVA: 0x00317D24 File Offset: 0x00315F24
		public unsafe int GPUImpact
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMagtAPQualityGroup.__PropertyOffset_GPUImpact);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMagtAPQualityGroup.__PropertyOffset_GPUImpact) = value;
			}
		}

		// Token: 0x17008249 RID: 33353
		// (get) Token: 0x0602180D RID: 137229 RVA: 0x00317D35 File Offset: 0x00315F35
		// (set) Token: 0x0602180E RID: 137230 RVA: 0x00317D45 File Offset: 0x00315F45
		public unsafe int PowerImpact
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMagtAPQualityGroup.__PropertyOffset_PowerImpact);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMagtAPQualityGroup.__PropertyOffset_PowerImpact) = value;
			}
		}

		// Token: 0x1700824A RID: 33354
		// (get) Token: 0x0602180F RID: 137231 RVA: 0x00317D58 File Offset: 0x00315F58
		// (set) Token: 0x06021810 RID: 137232 RVA: 0x00317D9B File Offset: 0x00315F9B
		public TMap<EMagtAPScenario, int> ScenarioLevels
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EMagtAPScenario, int> result;
				if ((result = this._ScenarioLevels) == null)
				{
					result = (this._ScenarioLevels = new TMap<EMagtAPScenario, int>(base.NativePtr + (IntPtr)FMagtAPQualityGroup.__PropertyOffset_ScenarioLevels, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ScenarioLevels.CopyAssign(value);
			}
		}

		// Token: 0x06021811 RID: 137233 RVA: 0x00317DA9 File Offset: 0x00315FA9
		public FMagtAPQualityGroup()
		{
		}

		// Token: 0x06021812 RID: 137234 RVA: 0x00317DB1 File Offset: 0x00315FB1
		public FMagtAPQualityGroup(FName GroupName, string CVarName, string Description, int CPUImpact, int GPUImpact, int PowerImpact, TMap<EMagtAPScenario, int> ScenarioLevels)
		{
			this.GroupName = GroupName;
			this.CVarName = CVarName;
			this.Description = Description;
			this.CPUImpact = CPUImpact;
			this.GPUImpact = GPUImpact;
			this.PowerImpact = PowerImpact;
			this.ScenarioLevels = ScenarioLevels;
		}

		// Token: 0x06021813 RID: 137235 RVA: 0x00317DEE File Offset: 0x00315FEE
		protected override IntPtr GetUStructPtr()
		{
			return FMagtAPQualityGroup.StaticStruct();
		}

		// Token: 0x06021814 RID: 137236 RVA: 0x00317DFA File Offset: 0x00315FFA
		[NullableContext(2)]
		public FMagtAPQualityGroup(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021815 RID: 137237 RVA: 0x00317E04 File Offset: 0x00316004
		public FMagtAPQualityGroup(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021816 RID: 137238 RVA: 0x00317E0F File Offset: 0x0031600F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMagtAPQualityGroup(Pointer, false, true);
		}

		// Token: 0x06021817 RID: 137239 RVA: 0x00317E19 File Offset: 0x00316019
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMagtAPQualityGroup(Pointer, MemoryOwner);
		}

		// Token: 0x04011E27 RID: 73255
		public const string __ObjectPath = "/Script/MagtModule.MagtAPQualityGroup";

		// Token: 0x04011E28 RID: 73256
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011E29 RID: 73257
		internal static int __PropertyOffset_GroupName;

		// Token: 0x04011E2A RID: 73258
		internal static int __PropertyOffset_CVarName;

		// Token: 0x04011E2B RID: 73259
		internal static int __PropertyOffset_Description;

		// Token: 0x04011E2C RID: 73260
		internal static int __PropertyOffset_CPUImpact;

		// Token: 0x04011E2D RID: 73261
		internal static int __PropertyOffset_GPUImpact;

		// Token: 0x04011E2E RID: 73262
		internal static int __PropertyOffset_PowerImpact;

		// Token: 0x04011E2F RID: 73263
		internal static int __PropertyOffset_ScenarioLevels;

		// Token: 0x04011E30 RID: 73264
		[Nullable(2)]
		private TMap<EMagtAPScenario, int> _ScenarioLevels;
	}
}
