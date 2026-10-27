using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001F14 RID: 7956
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.XboxAvoidListResult")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FXboxAvoidListResult : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E306 RID: 123654 RVA: 0x002CE2F6 File Offset: 0x002CC4F6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FXboxAvoidListResult._ScriptStructPtr != 0) ? FXboxAvoidListResult._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroUtility.XboxAvoidListResult", ref FXboxAvoidListResult._ScriptStructPtr);
		}

		// Token: 0x170077E6 RID: 30694
		// (get) Token: 0x0601E307 RID: 123655 RVA: 0x002CE31A File Offset: 0x002CC51A
		// (set) Token: 0x0601E308 RID: 123656 RVA: 0x002CE32A File Offset: 0x002CC52A
		public unsafe bool bSuccess
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FXboxAvoidListResult.__PropertyOffset_bSuccess) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FXboxAvoidListResult.__PropertyOffset_bSuccess) = (value ? 1 : 0);
			}
		}

		// Token: 0x170077E7 RID: 30695
		// (get) Token: 0x0601E309 RID: 123657 RVA: 0x002CE33C File Offset: 0x002CC53C
		// (set) Token: 0x0601E30A RID: 123658 RVA: 0x002CE37F File Offset: 0x002CC57F
		public TArray<long> Xuids
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._Xuids) == null)
				{
					result = (this._Xuids = new TArray<long>(base.NativePtr + (IntPtr)FXboxAvoidListResult.__PropertyOffset_Xuids, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Xuids.CopyAssign(value);
			}
		}

		// Token: 0x0601E30B RID: 123659 RVA: 0x002CE38D File Offset: 0x002CC58D
		public FXboxAvoidListResult()
		{
		}

		// Token: 0x0601E30C RID: 123660 RVA: 0x002CE395 File Offset: 0x002CC595
		public FXboxAvoidListResult(bool bSuccess, TArray<long> Xuids)
		{
			this.bSuccess = bSuccess;
			this.Xuids = Xuids;
		}

		// Token: 0x0601E30D RID: 123661 RVA: 0x002CE3AB File Offset: 0x002CC5AB
		protected override IntPtr GetUStructPtr()
		{
			return FXboxAvoidListResult.StaticStruct();
		}

		// Token: 0x0601E30E RID: 123662 RVA: 0x002CE3B7 File Offset: 0x002CC5B7
		[NullableContext(2)]
		public FXboxAvoidListResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E30F RID: 123663 RVA: 0x002CE3C1 File Offset: 0x002CC5C1
		public FXboxAvoidListResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E310 RID: 123664 RVA: 0x002CE3CC File Offset: 0x002CC5CC
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FXboxAvoidListResult(Pointer, false, true);
		}

		// Token: 0x0601E311 RID: 123665 RVA: 0x002CE3D6 File Offset: 0x002CC5D6
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FXboxAvoidListResult(Pointer, MemoryOwner);
		}

		// Token: 0x040104BE RID: 66750
		public const string __ObjectPath = "/Script/KuroUtility.XboxAvoidListResult";

		// Token: 0x040104BF RID: 66751
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040104C0 RID: 66752
		internal static int __PropertyOffset_bSuccess;

		// Token: 0x040104C1 RID: 66753
		internal static int __PropertyOffset_Xuids;

		// Token: 0x040104C2 RID: 66754
		[Nullable(2)]
		private TArray<long> _Xuids;
	}
}
