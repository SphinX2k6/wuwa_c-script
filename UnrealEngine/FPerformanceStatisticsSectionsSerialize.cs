using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200192A RID: 6442
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.PerformanceStatisticsSectionsSerialize")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FPerformanceStatisticsSectionsSerialize : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06017E28 RID: 97832 RVA: 0x002301C3 File Offset: 0x0022E3C3
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPerformanceStatisticsSectionsSerialize._ScriptStructPtr != 0) ? FPerformanceStatisticsSectionsSerialize._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.PerformanceStatisticsSectionsSerialize", ref FPerformanceStatisticsSectionsSerialize._ScriptStructPtr);
		}

		// Token: 0x17005FD9 RID: 24537
		// (get) Token: 0x06017E29 RID: 97833 RVA: 0x002301E8 File Offset: 0x0022E3E8
		// (set) Token: 0x06017E2A RID: 97834 RVA: 0x0023022B File Offset: 0x0022E42B
		public TArray<FPerformanceStatisticsSectionRecordSerialize> SectionRecords
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPerformanceStatisticsSectionRecordSerialize> result;
				if ((result = this._SectionRecords) == null)
				{
					result = (this._SectionRecords = new TArray<FPerformanceStatisticsSectionRecordSerialize>(base.NativePtr + (IntPtr)FPerformanceStatisticsSectionsSerialize.__PropertyOffset_SectionRecords, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SectionRecords.CopyAssign(value);
			}
		}

		// Token: 0x06017E2B RID: 97835 RVA: 0x00230239 File Offset: 0x0022E439
		public FPerformanceStatisticsSectionsSerialize()
		{
		}

		// Token: 0x06017E2C RID: 97836 RVA: 0x00230241 File Offset: 0x0022E441
		public FPerformanceStatisticsSectionsSerialize(TArray<FPerformanceStatisticsSectionRecordSerialize> SectionRecords)
		{
			this.SectionRecords = SectionRecords;
		}

		// Token: 0x06017E2D RID: 97837 RVA: 0x00230250 File Offset: 0x0022E450
		protected override IntPtr GetUStructPtr()
		{
			return FPerformanceStatisticsSectionsSerialize.StaticStruct();
		}

		// Token: 0x06017E2E RID: 97838 RVA: 0x0023025C File Offset: 0x0022E45C
		[NullableContext(2)]
		public FPerformanceStatisticsSectionsSerialize(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017E2F RID: 97839 RVA: 0x00230266 File Offset: 0x0022E466
		public FPerformanceStatisticsSectionsSerialize(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017E30 RID: 97840 RVA: 0x00230271 File Offset: 0x0022E471
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPerformanceStatisticsSectionsSerialize(Pointer, false, true);
		}

		// Token: 0x06017E31 RID: 97841 RVA: 0x0023027B File Offset: 0x0022E47B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPerformanceStatisticsSectionsSerialize(Pointer, MemoryOwner);
		}

		// Token: 0x0400CEFB RID: 52987
		public const string __ObjectPath = "/Script/KuroGameplay.PerformanceStatisticsSectionsSerialize";

		// Token: 0x0400CEFC RID: 52988
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400CEFD RID: 52989
		internal static int __PropertyOffset_SectionRecords;

		// Token: 0x0400CEFE RID: 52990
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPerformanceStatisticsSectionRecordSerialize> _SectionRecords;
	}
}
