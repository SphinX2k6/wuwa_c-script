using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001F15 RID: 7957
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.XboxGamertagResult")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FXboxGamertagResult : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E312 RID: 123666 RVA: 0x002CE3DF File Offset: 0x002CC5DF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FXboxGamertagResult._ScriptStructPtr != 0) ? FXboxGamertagResult._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroUtility.XboxGamertagResult", ref FXboxGamertagResult._ScriptStructPtr);
		}

		// Token: 0x170077E8 RID: 30696
		// (get) Token: 0x0601E313 RID: 123667 RVA: 0x002CE403 File Offset: 0x002CC603
		// (set) Token: 0x0601E314 RID: 123668 RVA: 0x002CE413 File Offset: 0x002CC613
		public unsafe bool bSuccess
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FXboxGamertagResult.__PropertyOffset_bSuccess) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FXboxGamertagResult.__PropertyOffset_bSuccess) = (value ? 1 : 0);
			}
		}

		// Token: 0x170077E9 RID: 30697
		// (get) Token: 0x0601E315 RID: 123669 RVA: 0x002CE424 File Offset: 0x002CC624
		// (set) Token: 0x0601E316 RID: 123670 RVA: 0x002CE438 File Offset: 0x002CC638
		public unsafe string Gamertag
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FXboxGamertagResult.__PropertyOffset_Gamertag)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FXboxGamertagResult.__PropertyOffset_Gamertag)), value);
			}
		}

		// Token: 0x0601E317 RID: 123671 RVA: 0x002CE44D File Offset: 0x002CC64D
		public FXboxGamertagResult()
		{
		}

		// Token: 0x0601E318 RID: 123672 RVA: 0x002CE455 File Offset: 0x002CC655
		public FXboxGamertagResult(bool bSuccess, string Gamertag)
		{
			this.bSuccess = bSuccess;
			this.Gamertag = Gamertag;
		}

		// Token: 0x0601E319 RID: 123673 RVA: 0x002CE46B File Offset: 0x002CC66B
		protected override IntPtr GetUStructPtr()
		{
			return FXboxGamertagResult.StaticStruct();
		}

		// Token: 0x0601E31A RID: 123674 RVA: 0x002CE477 File Offset: 0x002CC677
		[NullableContext(2)]
		public FXboxGamertagResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E31B RID: 123675 RVA: 0x002CE481 File Offset: 0x002CC681
		public FXboxGamertagResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E31C RID: 123676 RVA: 0x002CE48C File Offset: 0x002CC68C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FXboxGamertagResult(Pointer, false, true);
		}

		// Token: 0x0601E31D RID: 123677 RVA: 0x002CE496 File Offset: 0x002CC696
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FXboxGamertagResult(Pointer, MemoryOwner);
		}

		// Token: 0x040104C3 RID: 66755
		public const string __ObjectPath = "/Script/KuroUtility.XboxGamertagResult";

		// Token: 0x040104C4 RID: 66756
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040104C5 RID: 66757
		internal static int __PropertyOffset_bSuccess;

		// Token: 0x040104C6 RID: 66758
		internal static int __PropertyOffset_Gamertag;
	}
}
