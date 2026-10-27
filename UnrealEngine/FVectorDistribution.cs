using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200121F RID: 4639
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.VectorDistribution")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FVectorDistribution : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06011137 RID: 69943 RVA: 0x00190F6B File Offset: 0x0018F16B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVectorDistribution._ScriptStructPtr != 0) ? FVectorDistribution._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.VectorDistribution", ref FVectorDistribution._ScriptStructPtr);
		}

		// Token: 0x170042AB RID: 17067
		// (get) Token: 0x06011138 RID: 69944 RVA: 0x00190F90 File Offset: 0x0018F190
		// (set) Token: 0x06011139 RID: 69945 RVA: 0x00190FD3 File Offset: 0x0018F1D3
		public FDistributionLookupTable Table
		{
			get
			{
				base.FastCheckIsValid();
				FDistributionLookupTable result;
				if ((result = this._Table) == null)
				{
					result = (this._Table = new FDistributionLookupTable(base.NativePtr + (IntPtr)FVectorDistribution.__PropertyOffset_Table, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FDistributionLookupTable.StaticStruct(), base.NativePtr + (IntPtr)FVectorDistribution.__PropertyOffset_Table, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601113A RID: 69946 RVA: 0x00190FF4 File Offset: 0x0018F1F4
		public FVectorDistribution()
		{
		}

		// Token: 0x0601113B RID: 69947 RVA: 0x00190FFC File Offset: 0x0018F1FC
		public FVectorDistribution(FDistributionLookupTable Table)
		{
			this.Table = Table;
		}

		// Token: 0x0601113C RID: 69948 RVA: 0x0019100B File Offset: 0x0018F20B
		protected override IntPtr GetUStructPtr()
		{
			return FVectorDistribution.StaticStruct();
		}

		// Token: 0x0601113D RID: 69949 RVA: 0x00191017 File Offset: 0x0018F217
		[NullableContext(2)]
		public FVectorDistribution(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601113E RID: 69950 RVA: 0x00191021 File Offset: 0x0018F221
		public FVectorDistribution(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601113F RID: 69951 RVA: 0x0019102C File Offset: 0x0018F22C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FVectorDistribution(Pointer, false, true);
		}

		// Token: 0x06011140 RID: 69952 RVA: 0x00191036 File Offset: 0x0018F236
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FVectorDistribution(Pointer, MemoryOwner);
		}

		// Token: 0x04009245 RID: 37445
		public const string __ObjectPath = "/Script/Engine.VectorDistribution";

		// Token: 0x04009246 RID: 37446
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009247 RID: 37447
		internal static int __PropertyOffset_Table;

		// Token: 0x04009248 RID: 37448
		[Nullable(2)]
		private FDistributionLookupTable _Table;
	}
}
