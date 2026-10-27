using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020001C8 RID: 456
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/AIModule.GenericTeamId")]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1)]
	public class FGenericTeamId : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06001B0D RID: 6925 RVA: 0x000285D9 File Offset: 0x000267D9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGenericTeamId._ScriptStructPtr != 0) ? FGenericTeamId._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AIModule.GenericTeamId", ref FGenericTeamId._ScriptStructPtr);
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x06001B0E RID: 6926 RVA: 0x000285FD File Offset: 0x000267FD
		// (set) Token: 0x06001B0F RID: 6927 RVA: 0x0002860D File Offset: 0x0002680D
		public unsafe byte TeamID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGenericTeamId.__PropertyOffset_TeamID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGenericTeamId.__PropertyOffset_TeamID) = value;
			}
		}

		// Token: 0x06001B10 RID: 6928 RVA: 0x0002861E File Offset: 0x0002681E
		public FGenericTeamId()
		{
		}

		// Token: 0x06001B11 RID: 6929 RVA: 0x00028626 File Offset: 0x00026826
		public FGenericTeamId(byte TeamID)
		{
			this.TeamID = TeamID;
		}

		// Token: 0x06001B12 RID: 6930 RVA: 0x00028635 File Offset: 0x00026835
		protected override IntPtr GetUStructPtr()
		{
			return FGenericTeamId.StaticStruct();
		}

		// Token: 0x06001B13 RID: 6931 RVA: 0x00028641 File Offset: 0x00026841
		[NullableContext(2)]
		public FGenericTeamId(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001B14 RID: 6932 RVA: 0x0002864B File Offset: 0x0002684B
		public FGenericTeamId(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001B15 RID: 6933 RVA: 0x00028656 File Offset: 0x00026856
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGenericTeamId(Pointer, false, true);
		}

		// Token: 0x06001B16 RID: 6934 RVA: 0x00028660 File Offset: 0x00026860
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGenericTeamId(Pointer, MemoryOwner);
		}

		// Token: 0x040008A6 RID: 2214
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AIModule.GenericTeamId";

		// Token: 0x040008A7 RID: 2215
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040008A8 RID: 2216
		internal static int __PropertyOffset_TeamID;
	}
}
