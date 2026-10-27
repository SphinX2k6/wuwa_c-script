using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001929 RID: 6441
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.PerformanceStatisticsSectionRecordSerialize")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FPerformanceStatisticsSectionRecordSerialize : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06017E1C RID: 97820 RVA: 0x002300D3 File Offset: 0x0022E2D3
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPerformanceStatisticsSectionRecordSerialize._ScriptStructPtr != 0) ? FPerformanceStatisticsSectionRecordSerialize._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.PerformanceStatisticsSectionRecordSerialize", ref FPerformanceStatisticsSectionRecordSerialize._ScriptStructPtr);
		}

		// Token: 0x17005FD7 RID: 24535
		// (get) Token: 0x06017E1D RID: 97821 RVA: 0x002300F7 File Offset: 0x0022E2F7
		// (set) Token: 0x06017E1E RID: 97822 RVA: 0x0023010B File Offset: 0x0022E30B
		public unsafe FName SectionName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPerformanceStatisticsSectionRecordSerialize.__PropertyOffset_SectionName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPerformanceStatisticsSectionRecordSerialize.__PropertyOffset_SectionName) = value;
			}
		}

		// Token: 0x17005FD8 RID: 24536
		// (get) Token: 0x06017E1F RID: 97823 RVA: 0x00230120 File Offset: 0x0022E320
		// (set) Token: 0x06017E20 RID: 97824 RVA: 0x00230163 File Offset: 0x0022E363
		public TArray<FPerformanceStatisticsUnitRecord> UnitRecordValues
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPerformanceStatisticsUnitRecord> result;
				if ((result = this._UnitRecordValues) == null)
				{
					result = (this._UnitRecordValues = new TArray<FPerformanceStatisticsUnitRecord>(base.NativePtr + (IntPtr)FPerformanceStatisticsSectionRecordSerialize.__PropertyOffset_UnitRecordValues, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.UnitRecordValues.CopyAssign(value);
			}
		}

		// Token: 0x06017E21 RID: 97825 RVA: 0x00230171 File Offset: 0x0022E371
		public FPerformanceStatisticsSectionRecordSerialize()
		{
		}

		// Token: 0x06017E22 RID: 97826 RVA: 0x00230179 File Offset: 0x0022E379
		public FPerformanceStatisticsSectionRecordSerialize(FName SectionName, TArray<FPerformanceStatisticsUnitRecord> UnitRecordValues)
		{
			this.SectionName = SectionName;
			this.UnitRecordValues = UnitRecordValues;
		}

		// Token: 0x06017E23 RID: 97827 RVA: 0x0023018F File Offset: 0x0022E38F
		protected override IntPtr GetUStructPtr()
		{
			return FPerformanceStatisticsSectionRecordSerialize.StaticStruct();
		}

		// Token: 0x06017E24 RID: 97828 RVA: 0x0023019B File Offset: 0x0022E39B
		[NullableContext(2)]
		public FPerformanceStatisticsSectionRecordSerialize(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017E25 RID: 97829 RVA: 0x002301A5 File Offset: 0x0022E3A5
		public FPerformanceStatisticsSectionRecordSerialize(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017E26 RID: 97830 RVA: 0x002301B0 File Offset: 0x0022E3B0
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPerformanceStatisticsSectionRecordSerialize(Pointer, false, true);
		}

		// Token: 0x06017E27 RID: 97831 RVA: 0x002301BA File Offset: 0x0022E3BA
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPerformanceStatisticsSectionRecordSerialize(Pointer, MemoryOwner);
		}

		// Token: 0x0400CEF6 RID: 52982
		public const string __ObjectPath = "/Script/KuroGameplay.PerformanceStatisticsSectionRecordSerialize";

		// Token: 0x0400CEF7 RID: 52983
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400CEF8 RID: 52984
		internal static int __PropertyOffset_SectionName;

		// Token: 0x0400CEF9 RID: 52985
		internal static int __PropertyOffset_UnitRecordValues;

		// Token: 0x0400CEFA RID: 52986
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPerformanceStatisticsUnitRecord> _UnitRecordValues;
	}
}
