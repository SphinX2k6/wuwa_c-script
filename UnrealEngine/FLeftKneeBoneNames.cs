using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D1F RID: 3359
	[UnrealObjectPath("/Script/Engine.LeftKneeBoneNames")]
	[UnrealStructLayout(36, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 36)]
	public class FLeftKneeBoneNames : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B40E RID: 46094 RVA: 0x00100C46 File Offset: 0x000FEE46
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLeftKneeBoneNames._ScriptStructPtr != 0) ? FLeftKneeBoneNames._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.LeftKneeBoneNames", ref FLeftKneeBoneNames._ScriptStructPtr);
		}

		// Token: 0x1700292A RID: 10538
		// (get) Token: 0x0600B40F RID: 46095 RVA: 0x00100C6A File Offset: 0x000FEE6A
		// (set) Token: 0x0600B410 RID: 46096 RVA: 0x00100C7E File Offset: 0x000FEE7E
		public unsafe FName LeftKneeBoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLeftKneeBoneNames.__PropertyOffset_LeftKneeBoneName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLeftKneeBoneNames.__PropertyOffset_LeftKneeBoneName) = value;
			}
		}

		// Token: 0x1700292B RID: 10539
		// (get) Token: 0x0600B411 RID: 46097 RVA: 0x00100C93 File Offset: 0x000FEE93
		// (set) Token: 0x0600B412 RID: 46098 RVA: 0x00100CA7 File Offset: 0x000FEEA7
		public unsafe FName LeftKneeUpBoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLeftKneeBoneNames.__PropertyOffset_LeftKneeUpBoneName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLeftKneeBoneNames.__PropertyOffset_LeftKneeUpBoneName) = value;
			}
		}

		// Token: 0x1700292C RID: 10540
		// (get) Token: 0x0600B413 RID: 46099 RVA: 0x00100CBC File Offset: 0x000FEEBC
		// (set) Token: 0x0600B414 RID: 46100 RVA: 0x00100CD0 File Offset: 0x000FEED0
		public unsafe FName LeftKneeDownBoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLeftKneeBoneNames.__PropertyOffset_LeftKneeDownBoneName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLeftKneeBoneNames.__PropertyOffset_LeftKneeDownBoneName) = value;
			}
		}

		// Token: 0x0600B415 RID: 46101 RVA: 0x00100CE5 File Offset: 0x000FEEE5
		public FLeftKneeBoneNames()
		{
		}

		// Token: 0x0600B416 RID: 46102 RVA: 0x00100CED File Offset: 0x000FEEED
		public FLeftKneeBoneNames(FName LeftKneeBoneName, FName LeftKneeUpBoneName, FName LeftKneeDownBoneName)
		{
			this.LeftKneeBoneName = LeftKneeBoneName;
			this.LeftKneeUpBoneName = LeftKneeUpBoneName;
			this.LeftKneeDownBoneName = LeftKneeDownBoneName;
		}

		// Token: 0x0600B417 RID: 46103 RVA: 0x00100D0A File Offset: 0x000FEF0A
		protected override IntPtr GetUStructPtr()
		{
			return FLeftKneeBoneNames.StaticStruct();
		}

		// Token: 0x0600B418 RID: 46104 RVA: 0x00100D16 File Offset: 0x000FEF16
		[NullableContext(2)]
		public FLeftKneeBoneNames(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B419 RID: 46105 RVA: 0x00100D20 File Offset: 0x000FEF20
		public FLeftKneeBoneNames(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B41A RID: 46106 RVA: 0x00100D2B File Offset: 0x000FEF2B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLeftKneeBoneNames(Pointer, false, true);
		}

		// Token: 0x0600B41B RID: 46107 RVA: 0x00100D35 File Offset: 0x000FEF35
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLeftKneeBoneNames(Pointer, MemoryOwner);
		}

		// Token: 0x04005EA2 RID: 24226
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.LeftKneeBoneNames";

		// Token: 0x04005EA3 RID: 24227
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005EA4 RID: 24228
		internal static int __PropertyOffset_LeftKneeBoneName;

		// Token: 0x04005EA5 RID: 24229
		internal static int __PropertyOffset_LeftKneeUpBoneName;

		// Token: 0x04005EA6 RID: 24230
		internal static int __PropertyOffset_LeftKneeDownBoneName;
	}
}
