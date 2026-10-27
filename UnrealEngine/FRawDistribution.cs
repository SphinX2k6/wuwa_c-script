using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001066 RID: 4198
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.RawDistribution")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FRawDistribution : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600EEDE RID: 61150 RVA: 0x0016254C File Offset: 0x0016074C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRawDistribution._ScriptStructPtr != 0) ? FRawDistribution._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.RawDistribution", ref FRawDistribution._ScriptStructPtr);
		}

		// Token: 0x170039D0 RID: 14800
		// (get) Token: 0x0600EEDF RID: 61151 RVA: 0x00162570 File Offset: 0x00160770
		// (set) Token: 0x0600EEE0 RID: 61152 RVA: 0x001625B3 File Offset: 0x001607B3
		public FDistributionLookupTable Table
		{
			get
			{
				base.FastCheckIsValid();
				FDistributionLookupTable result;
				if ((result = this._Table) == null)
				{
					result = (this._Table = new FDistributionLookupTable(base.NativePtr + (IntPtr)FRawDistribution.__PropertyOffset_Table, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FDistributionLookupTable.StaticStruct(), base.NativePtr + (IntPtr)FRawDistribution.__PropertyOffset_Table, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600EEE1 RID: 61153 RVA: 0x001625D4 File Offset: 0x001607D4
		public FRawDistribution()
		{
		}

		// Token: 0x0600EEE2 RID: 61154 RVA: 0x001625DC File Offset: 0x001607DC
		public FRawDistribution(FDistributionLookupTable Table)
		{
			this.Table = Table;
		}

		// Token: 0x0600EEE3 RID: 61155 RVA: 0x001625EB File Offset: 0x001607EB
		protected override IntPtr GetUStructPtr()
		{
			return FRawDistribution.StaticStruct();
		}

		// Token: 0x0600EEE4 RID: 61156 RVA: 0x001625F7 File Offset: 0x001607F7
		[NullableContext(2)]
		public FRawDistribution(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600EEE5 RID: 61157 RVA: 0x00162601 File Offset: 0x00160801
		public FRawDistribution(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600EEE6 RID: 61158 RVA: 0x0016260C File Offset: 0x0016080C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRawDistribution(Pointer, false, true);
		}

		// Token: 0x0600EEE7 RID: 61159 RVA: 0x00162616 File Offset: 0x00160816
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRawDistribution(Pointer, MemoryOwner);
		}

		// Token: 0x04008149 RID: 33097
		public const string __ObjectPath = "/Script/Engine.RawDistribution";

		// Token: 0x0400814A RID: 33098
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400814B RID: 33099
		internal static int __PropertyOffset_Table;

		// Token: 0x0400814C RID: 33100
		[Nullable(2)]
		private FDistributionLookupTable _Table;
	}
}
