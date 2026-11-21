using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000620 RID: 1568
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.XboxGamertagResult")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FXboxGamertagResult : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008936 RID: 35126 RVA: 0x000CF021 File Offset: 0x000CD221
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FXboxGamertagResult._ScriptStructPtr != 0) ? FXboxGamertagResult._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroUtility.XboxGamertagResult", ref FXboxGamertagResult._ScriptStructPtr);
		}

		// Token: 0x17001998 RID: 6552
		// (get) Token: 0x06008937 RID: 35127 RVA: 0x000CF045 File Offset: 0x000CD245
		// (set) Token: 0x06008938 RID: 35128 RVA: 0x000CF055 File Offset: 0x000CD255
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

		// Token: 0x17001999 RID: 6553
		// (get) Token: 0x06008939 RID: 35129 RVA: 0x000CF066 File Offset: 0x000CD266
		// (set) Token: 0x0600893A RID: 35130 RVA: 0x000CF07A File Offset: 0x000CD27A
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

		// Token: 0x0600893B RID: 35131 RVA: 0x000CF08F File Offset: 0x000CD28F
		public FXboxGamertagResult()
		{
		}

		// Token: 0x0600893C RID: 35132 RVA: 0x000CF097 File Offset: 0x000CD297
		protected override IntPtr GetUStructPtr()
		{
			return FXboxGamertagResult.StaticStruct();
		}

		// Token: 0x0600893D RID: 35133 RVA: 0x000CF0A3 File Offset: 0x000CD2A3
		[NullableContext(2)]
		public FXboxGamertagResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600893E RID: 35134 RVA: 0x000CF0AD File Offset: 0x000CD2AD
		public FXboxGamertagResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600893F RID: 35135 RVA: 0x000CF0B8 File Offset: 0x000CD2B8
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FXboxGamertagResult(Pointer, false, true);
		}

		// Token: 0x06008940 RID: 35136 RVA: 0x000CF0C2 File Offset: 0x000CD2C2
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FXboxGamertagResult(Pointer, MemoryOwner);
		}

		// Token: 0x04003B8E RID: 15246
		public const string __ObjectPath = "/Script/KuroUtility.XboxGamertagResult";

		// Token: 0x04003B8F RID: 15247
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003B90 RID: 15248
		internal static int __PropertyOffset_bSuccess;

		// Token: 0x04003B91 RID: 15249
		internal static int __PropertyOffset_Gamertag;
	}
}
