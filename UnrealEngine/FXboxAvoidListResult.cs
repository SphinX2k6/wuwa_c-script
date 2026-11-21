using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200061F RID: 1567
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.XboxAvoidListResult")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FXboxAvoidListResult : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600892B RID: 35115 RVA: 0x000CEF4D File Offset: 0x000CD14D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FXboxAvoidListResult._ScriptStructPtr != 0) ? FXboxAvoidListResult._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroUtility.XboxAvoidListResult", ref FXboxAvoidListResult._ScriptStructPtr);
		}

		// Token: 0x17001996 RID: 6550
		// (get) Token: 0x0600892C RID: 35116 RVA: 0x000CEF71 File Offset: 0x000CD171
		// (set) Token: 0x0600892D RID: 35117 RVA: 0x000CEF81 File Offset: 0x000CD181
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

		// Token: 0x17001997 RID: 6551
		// (get) Token: 0x0600892E RID: 35118 RVA: 0x000CEF94 File Offset: 0x000CD194
		// (set) Token: 0x0600892F RID: 35119 RVA: 0x000CEFD7 File Offset: 0x000CD1D7
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

		// Token: 0x06008930 RID: 35120 RVA: 0x000CEFE5 File Offset: 0x000CD1E5
		public FXboxAvoidListResult()
		{
		}

		// Token: 0x06008931 RID: 35121 RVA: 0x000CEFED File Offset: 0x000CD1ED
		protected override IntPtr GetUStructPtr()
		{
			return FXboxAvoidListResult.StaticStruct();
		}

		// Token: 0x06008932 RID: 35122 RVA: 0x000CEFF9 File Offset: 0x000CD1F9
		[NullableContext(2)]
		public FXboxAvoidListResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008933 RID: 35123 RVA: 0x000CF003 File Offset: 0x000CD203
		public FXboxAvoidListResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008934 RID: 35124 RVA: 0x000CF00E File Offset: 0x000CD20E
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FXboxAvoidListResult(Pointer, false, true);
		}

		// Token: 0x06008935 RID: 35125 RVA: 0x000CF018 File Offset: 0x000CD218
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FXboxAvoidListResult(Pointer, MemoryOwner);
		}

		// Token: 0x04003B89 RID: 15241
		public const string __ObjectPath = "/Script/KuroUtility.XboxAvoidListResult";

		// Token: 0x04003B8A RID: 15242
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003B8B RID: 15243
		internal static int __PropertyOffset_bSuccess;

		// Token: 0x04003B8C RID: 15244
		internal static int __PropertyOffset_Xuids;

		// Token: 0x04003B8D RID: 15245
		[Nullable(2)]
		private TArray<long> _Xuids;
	}
}
