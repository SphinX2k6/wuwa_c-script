using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002278 RID: 8824
	[UnrealObjectPath("/Script/MagtModule.MagtThreadInfo")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FMagtThreadInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060218D2 RID: 137426 RVA: 0x00319CAB File Offset: 0x00317EAB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMagtThreadInfo._ScriptStructPtr != 0) ? FMagtThreadInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MagtModule.MagtThreadInfo", ref FMagtThreadInfo._ScriptStructPtr);
		}

		// Token: 0x1700826C RID: 33388
		// (get) Token: 0x060218D3 RID: 137427 RVA: 0x00319CCF File Offset: 0x00317ECF
		// (set) Token: 0x060218D4 RID: 137428 RVA: 0x00319CDF File Offset: 0x00317EDF
		public unsafe int ThreadID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMagtThreadInfo.__PropertyOffset_ThreadID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMagtThreadInfo.__PropertyOffset_ThreadID) = value;
			}
		}

		// Token: 0x1700826D RID: 33389
		// (get) Token: 0x060218D5 RID: 137429 RVA: 0x00319CF0 File Offset: 0x00317EF0
		// (set) Token: 0x060218D6 RID: 137430 RVA: 0x00319D00 File Offset: 0x00317F00
		public unsafe EMagtThreadGroup Group
		{
			get
			{
				return (EMagtThreadGroup)(*(base.NativePtr + (IntPtr)FMagtThreadInfo.__PropertyOffset_Group));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMagtThreadInfo.__PropertyOffset_Group) = (byte)value;
			}
		}

		// Token: 0x1700826E RID: 33390
		// (get) Token: 0x060218D7 RID: 137431 RVA: 0x00319D11 File Offset: 0x00317F11
		// (set) Token: 0x060218D8 RID: 137432 RVA: 0x00319D21 File Offset: 0x00317F21
		public unsafe EMagtThreadPriority Priority
		{
			get
			{
				return (EMagtThreadPriority)(*(base.NativePtr + (IntPtr)FMagtThreadInfo.__PropertyOffset_Priority));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMagtThreadInfo.__PropertyOffset_Priority) = (byte)value;
			}
		}

		// Token: 0x1700826F RID: 33391
		// (get) Token: 0x060218D9 RID: 137433 RVA: 0x00319D32 File Offset: 0x00317F32
		// (set) Token: 0x060218DA RID: 137434 RVA: 0x00319D42 File Offset: 0x00317F42
		public unsafe int PreemptTimeMs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMagtThreadInfo.__PropertyOffset_PreemptTimeMs);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMagtThreadInfo.__PropertyOffset_PreemptTimeMs) = value;
			}
		}

		// Token: 0x060218DB RID: 137435 RVA: 0x00319D53 File Offset: 0x00317F53
		public FMagtThreadInfo()
		{
		}

		// Token: 0x060218DC RID: 137436 RVA: 0x00319D5B File Offset: 0x00317F5B
		public FMagtThreadInfo(int ThreadID, EMagtThreadGroup Group, EMagtThreadPriority Priority, int PreemptTimeMs)
		{
			this.ThreadID = ThreadID;
			this.Group = Group;
			this.Priority = Priority;
			this.PreemptTimeMs = PreemptTimeMs;
		}

		// Token: 0x060218DD RID: 137437 RVA: 0x00319D80 File Offset: 0x00317F80
		protected override IntPtr GetUStructPtr()
		{
			return FMagtThreadInfo.StaticStruct();
		}

		// Token: 0x060218DE RID: 137438 RVA: 0x00319D8C File Offset: 0x00317F8C
		[NullableContext(2)]
		public FMagtThreadInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060218DF RID: 137439 RVA: 0x00319D96 File Offset: 0x00317F96
		public FMagtThreadInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060218E0 RID: 137440 RVA: 0x00319DA1 File Offset: 0x00317FA1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMagtThreadInfo(Pointer, false, true);
		}

		// Token: 0x060218E1 RID: 137441 RVA: 0x00319DAB File Offset: 0x00317FAB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMagtThreadInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04011EAF RID: 73391
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MagtModule.MagtThreadInfo";

		// Token: 0x04011EB0 RID: 73392
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011EB1 RID: 73393
		internal static int __PropertyOffset_ThreadID;

		// Token: 0x04011EB2 RID: 73394
		internal static int __PropertyOffset_Group;

		// Token: 0x04011EB3 RID: 73395
		internal static int __PropertyOffset_Priority;

		// Token: 0x04011EB4 RID: 73396
		internal static int __PropertyOffset_PreemptTimeMs;
	}
}
