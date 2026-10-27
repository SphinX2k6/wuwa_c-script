using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000BD8 RID: 3032
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.FloatDistribution")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FFloatDistribution : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009516 RID: 38166 RVA: 0x000D4B71 File Offset: 0x000D2D71
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFloatDistribution._ScriptStructPtr != 0) ? FFloatDistribution._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.FloatDistribution", ref FFloatDistribution._ScriptStructPtr);
		}

		// Token: 0x170023AD RID: 9133
		// (get) Token: 0x06009517 RID: 38167 RVA: 0x000D4B98 File Offset: 0x000D2D98
		// (set) Token: 0x06009518 RID: 38168 RVA: 0x000D4BDB File Offset: 0x000D2DDB
		public FDistributionLookupTable Table
		{
			get
			{
				base.FastCheckIsValid();
				FDistributionLookupTable result;
				if ((result = this._Table) == null)
				{
					result = (this._Table = new FDistributionLookupTable(base.NativePtr + (IntPtr)FFloatDistribution.__PropertyOffset_Table, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FDistributionLookupTable.StaticStruct(), base.NativePtr + (IntPtr)FFloatDistribution.__PropertyOffset_Table, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06009519 RID: 38169 RVA: 0x000D4BFC File Offset: 0x000D2DFC
		public FFloatDistribution()
		{
		}

		// Token: 0x0600951A RID: 38170 RVA: 0x000D4C04 File Offset: 0x000D2E04
		public FFloatDistribution(FDistributionLookupTable Table)
		{
			this.Table = Table;
		}

		// Token: 0x0600951B RID: 38171 RVA: 0x000D4C13 File Offset: 0x000D2E13
		protected override IntPtr GetUStructPtr()
		{
			return FFloatDistribution.StaticStruct();
		}

		// Token: 0x0600951C RID: 38172 RVA: 0x000D4C1F File Offset: 0x000D2E1F
		[NullableContext(2)]
		public FFloatDistribution(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600951D RID: 38173 RVA: 0x000D4C29 File Offset: 0x000D2E29
		public FFloatDistribution(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600951E RID: 38174 RVA: 0x000D4C34 File Offset: 0x000D2E34
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFloatDistribution(Pointer, false, true);
		}

		// Token: 0x0600951F RID: 38175 RVA: 0x000D4C3E File Offset: 0x000D2E3E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFloatDistribution(Pointer, MemoryOwner);
		}

		// Token: 0x040053AE RID: 21422
		public const string __ObjectPath = "/Script/Engine.FloatDistribution";

		// Token: 0x040053AF RID: 21423
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040053B0 RID: 21424
		internal static int __PropertyOffset_Table;

		// Token: 0x040053B1 RID: 21425
		[Nullable(2)]
		private FDistributionLookupTable _Table;
	}
}
