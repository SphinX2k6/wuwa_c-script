using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020019CF RID: 6607
	[UnrealObjectPath("/Script/KuroMechanismSequenceRuntime.MovieSceneMechanismEventTriggerData")]
	[UnrealStructLayout(44, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 44)]
	public class FMovieSceneMechanismEventTriggerData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060188AB RID: 100523 RVA: 0x00242462 File Offset: 0x00240662
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneMechanismEventTriggerData._ScriptStructPtr != 0) ? FMovieSceneMechanismEventTriggerData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroMechanismSequenceRuntime.MovieSceneMechanismEventTriggerData", ref FMovieSceneMechanismEventTriggerData._ScriptStructPtr);
		}

		// Token: 0x170061D6 RID: 25046
		// (get) Token: 0x060188AC RID: 100524 RVA: 0x00242486 File Offset: 0x00240686
		// (set) Token: 0x060188AD RID: 100525 RVA: 0x0024249A File Offset: 0x0024069A
		public unsafe FName EventType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneMechanismEventTriggerData.__PropertyOffset_EventType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneMechanismEventTriggerData.__PropertyOffset_EventType) = value;
			}
		}

		// Token: 0x170061D7 RID: 25047
		// (get) Token: 0x060188AE RID: 100526 RVA: 0x002424AF File Offset: 0x002406AF
		// (set) Token: 0x060188AF RID: 100527 RVA: 0x002424C3 File Offset: 0x002406C3
		public unsafe FName EventName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneMechanismEventTriggerData.__PropertyOffset_EventName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneMechanismEventTriggerData.__PropertyOffset_EventName) = value;
			}
		}

		// Token: 0x170061D8 RID: 25048
		// (get) Token: 0x060188B0 RID: 100528 RVA: 0x002424D8 File Offset: 0x002406D8
		// (set) Token: 0x060188B1 RID: 100529 RVA: 0x002424E8 File Offset: 0x002406E8
		public unsafe uint UniqueID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneMechanismEventTriggerData.__PropertyOffset_UniqueID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneMechanismEventTriggerData.__PropertyOffset_UniqueID) = (int)value;
			}
		}

		// Token: 0x060188B2 RID: 100530 RVA: 0x002424F9 File Offset: 0x002406F9
		public FMovieSceneMechanismEventTriggerData()
		{
		}

		// Token: 0x060188B3 RID: 100531 RVA: 0x00242501 File Offset: 0x00240701
		public FMovieSceneMechanismEventTriggerData(FName EventType, FName EventName, uint UniqueID)
		{
			this.EventType = EventType;
			this.EventName = EventName;
			this.UniqueID = UniqueID;
		}

		// Token: 0x060188B4 RID: 100532 RVA: 0x0024251E File Offset: 0x0024071E
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneMechanismEventTriggerData.StaticStruct();
		}

		// Token: 0x060188B5 RID: 100533 RVA: 0x0024252A File Offset: 0x0024072A
		[NullableContext(2)]
		public FMovieSceneMechanismEventTriggerData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060188B6 RID: 100534 RVA: 0x00242534 File Offset: 0x00240734
		public FMovieSceneMechanismEventTriggerData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060188B7 RID: 100535 RVA: 0x0024253F File Offset: 0x0024073F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneMechanismEventTriggerData(Pointer, false, true);
		}

		// Token: 0x060188B8 RID: 100536 RVA: 0x00242549 File Offset: 0x00240749
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneMechanismEventTriggerData(Pointer, MemoryOwner);
		}

		// Token: 0x0400D429 RID: 54313
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroMechanismSequenceRuntime.MovieSceneMechanismEventTriggerData";

		// Token: 0x0400D42A RID: 54314
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D42B RID: 54315
		internal static int __PropertyOffset_EventType;

		// Token: 0x0400D42C RID: 54316
		internal static int __PropertyOffset_EventName;

		// Token: 0x0400D42D RID: 54317
		internal static int __PropertyOffset_UniqueID;
	}
}
