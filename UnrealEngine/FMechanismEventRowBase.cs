using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002325 RID: 8997
	[UnrealObjectPath("/Script/MovieSceneTracks.MechanismEventRowBase")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FMechanismEventRowBase : FTableRowBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602209B RID: 139419 RVA: 0x0032519E File Offset: 0x0032339E
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMechanismEventRowBase._ScriptStructPtr != 0) ? FMechanismEventRowBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MechanismEventRowBase", ref FMechanismEventRowBase._ScriptStructPtr);
		}

		// Token: 0x1700837E RID: 33662
		// (get) Token: 0x0602209C RID: 139420 RVA: 0x003251C2 File Offset: 0x003233C2
		// (set) Token: 0x0602209D RID: 139421 RVA: 0x003251D6 File Offset: 0x003233D6
		public unsafe FName EventType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMechanismEventRowBase.__PropertyOffset_EventType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMechanismEventRowBase.__PropertyOffset_EventType) = value;
			}
		}

		// Token: 0x1700837F RID: 33663
		// (get) Token: 0x0602209E RID: 139422 RVA: 0x003251EB File Offset: 0x003233EB
		// (set) Token: 0x0602209F RID: 139423 RVA: 0x003251FB File Offset: 0x003233FB
		public unsafe bool bSupportAnimNotify
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMechanismEventRowBase.__PropertyOffset_bSupportAnimNotify) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMechanismEventRowBase.__PropertyOffset_bSupportAnimNotify) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008380 RID: 33664
		// (get) Token: 0x060220A0 RID: 139424 RVA: 0x0032520C File Offset: 0x0032340C
		// (set) Token: 0x060220A1 RID: 139425 RVA: 0x0032521C File Offset: 0x0032341C
		public unsafe bool bSupportAnimNotifyState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMechanismEventRowBase.__PropertyOffset_bSupportAnimNotifyState) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMechanismEventRowBase.__PropertyOffset_bSupportAnimNotifyState) = (value ? 1 : 0);
			}
		}

		// Token: 0x060220A2 RID: 139426 RVA: 0x0032522D File Offset: 0x0032342D
		public FMechanismEventRowBase()
		{
		}

		// Token: 0x060220A3 RID: 139427 RVA: 0x00325235 File Offset: 0x00323435
		public FMechanismEventRowBase(FName EventType, bool bSupportAnimNotify, bool bSupportAnimNotifyState)
		{
			this.EventType = EventType;
			this.bSupportAnimNotify = bSupportAnimNotify;
			this.bSupportAnimNotifyState = bSupportAnimNotifyState;
		}

		// Token: 0x060220A4 RID: 139428 RVA: 0x00325252 File Offset: 0x00323452
		protected override IntPtr GetUStructPtr()
		{
			return FMechanismEventRowBase.StaticStruct();
		}

		// Token: 0x060220A5 RID: 139429 RVA: 0x0032525E File Offset: 0x0032345E
		[NullableContext(2)]
		public FMechanismEventRowBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060220A6 RID: 139430 RVA: 0x00325268 File Offset: 0x00323468
		public FMechanismEventRowBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060220A7 RID: 139431 RVA: 0x00325273 File Offset: 0x00323473
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMechanismEventRowBase(Pointer, false, true);
		}

		// Token: 0x060220A8 RID: 139432 RVA: 0x0032527D File Offset: 0x0032347D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMechanismEventRowBase(Pointer, MemoryOwner);
		}

		// Token: 0x04012299 RID: 74393
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MechanismEventRowBase";

		// Token: 0x0401229A RID: 74394
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401229B RID: 74395
		internal static int __PropertyOffset_EventType;

		// Token: 0x0401229C RID: 74396
		internal static int __PropertyOffset_bSupportAnimNotify;

		// Token: 0x0401229D RID: 74397
		internal static int __PropertyOffset_bSupportAnimNotifyState;
	}
}
