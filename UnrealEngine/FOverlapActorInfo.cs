using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EF7 RID: 7927
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.OverlapActorInfo")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FOverlapActorInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E1B8 RID: 123320 RVA: 0x002CBC40 File Offset: 0x002C9E40
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FOverlapActorInfo._ScriptStructPtr != 0) ? FOverlapActorInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroUtility.OverlapActorInfo", ref FOverlapActorInfo._ScriptStructPtr);
		}

		// Token: 0x170077BF RID: 30655
		// (get) Token: 0x0601E1B9 RID: 123321 RVA: 0x002CBC64 File Offset: 0x002C9E64
		// (set) Token: 0x0601E1BA RID: 123322 RVA: 0x002CBC78 File Offset: 0x002C9E78
		public unsafe string ActorLabel
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FOverlapActorInfo.__PropertyOffset_ActorLabel)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FOverlapActorInfo.__PropertyOffset_ActorLabel)), value);
			}
		}

		// Token: 0x170077C0 RID: 30656
		// (get) Token: 0x0601E1BB RID: 123323 RVA: 0x002CBC8D File Offset: 0x002C9E8D
		// (set) Token: 0x0601E1BC RID: 123324 RVA: 0x002CBCA1 File Offset: 0x002C9EA1
		public unsafe string ActorType
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FOverlapActorInfo.__PropertyOffset_ActorType)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FOverlapActorInfo.__PropertyOffset_ActorType)), value);
			}
		}

		// Token: 0x170077C1 RID: 30657
		// (get) Token: 0x0601E1BD RID: 123325 RVA: 0x002CBCB6 File Offset: 0x002C9EB6
		// (set) Token: 0x0601E1BE RID: 123326 RVA: 0x002CBCCA File Offset: 0x002C9ECA
		public unsafe string ActorPath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FOverlapActorInfo.__PropertyOffset_ActorPath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FOverlapActorInfo.__PropertyOffset_ActorPath)), value);
			}
		}

		// Token: 0x170077C2 RID: 30658
		// (get) Token: 0x0601E1BF RID: 123327 RVA: 0x002CBCDF File Offset: 0x002C9EDF
		// (set) Token: 0x0601E1C0 RID: 123328 RVA: 0x002CBCEF File Offset: 0x002C9EEF
		public unsafe bool bDirty
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOverlapActorInfo.__PropertyOffset_bDirty) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOverlapActorInfo.__PropertyOffset_bDirty) = (value ? 1 : 0);
			}
		}

		// Token: 0x170077C3 RID: 30659
		// (get) Token: 0x0601E1C1 RID: 123329 RVA: 0x002CBD00 File Offset: 0x002C9F00
		// (set) Token: 0x0601E1C2 RID: 123330 RVA: 0x002CBD43 File Offset: 0x002C9F43
		public FDateTime LastEditTimestamp
		{
			get
			{
				base.FastCheckIsValid();
				FDateTime result;
				if ((result = this._LastEditTimestamp) == null)
				{
					result = (this._LastEditTimestamp = new FDateTime(base.NativePtr + (IntPtr)FOverlapActorInfo.__PropertyOffset_LastEditTimestamp, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FDateTime.StaticStruct(), base.NativePtr + (IntPtr)FOverlapActorInfo.__PropertyOffset_LastEditTimestamp, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170077C4 RID: 30660
		// (get) Token: 0x0601E1C3 RID: 123331 RVA: 0x002CBD64 File Offset: 0x002C9F64
		// (set) Token: 0x0601E1C4 RID: 123332 RVA: 0x002CBD78 File Offset: 0x002C9F78
		public unsafe string LastEditPerson
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FOverlapActorInfo.__PropertyOffset_LastEditPerson)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FOverlapActorInfo.__PropertyOffset_LastEditPerson)), value);
			}
		}

		// Token: 0x0601E1C5 RID: 123333 RVA: 0x002CBD8D File Offset: 0x002C9F8D
		public FOverlapActorInfo()
		{
		}

		// Token: 0x0601E1C6 RID: 123334 RVA: 0x002CBD95 File Offset: 0x002C9F95
		public FOverlapActorInfo(string ActorLabel, string ActorType, string ActorPath, bool bDirty, FDateTime LastEditTimestamp, string LastEditPerson)
		{
			this.ActorLabel = ActorLabel;
			this.ActorType = ActorType;
			this.ActorPath = ActorPath;
			this.bDirty = bDirty;
			this.LastEditTimestamp = LastEditTimestamp;
			this.LastEditPerson = LastEditPerson;
		}

		// Token: 0x0601E1C7 RID: 123335 RVA: 0x002CBDCA File Offset: 0x002C9FCA
		protected override IntPtr GetUStructPtr()
		{
			return FOverlapActorInfo.StaticStruct();
		}

		// Token: 0x0601E1C8 RID: 123336 RVA: 0x002CBDD6 File Offset: 0x002C9FD6
		[NullableContext(2)]
		public FOverlapActorInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E1C9 RID: 123337 RVA: 0x002CBDE0 File Offset: 0x002C9FE0
		public FOverlapActorInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E1CA RID: 123338 RVA: 0x002CBDEB File Offset: 0x002C9FEB
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FOverlapActorInfo(Pointer, false, true);
		}

		// Token: 0x0601E1CB RID: 123339 RVA: 0x002CBDF5 File Offset: 0x002C9FF5
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FOverlapActorInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0401043F RID: 66623
		public const string __ObjectPath = "/Script/KuroUtility.OverlapActorInfo";

		// Token: 0x04010440 RID: 66624
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010441 RID: 66625
		internal static int __PropertyOffset_ActorLabel;

		// Token: 0x04010442 RID: 66626
		internal static int __PropertyOffset_ActorType;

		// Token: 0x04010443 RID: 66627
		internal static int __PropertyOffset_ActorPath;

		// Token: 0x04010444 RID: 66628
		internal static int __PropertyOffset_bDirty;

		// Token: 0x04010445 RID: 66629
		internal static int __PropertyOffset_LastEditTimestamp;

		// Token: 0x04010446 RID: 66630
		[Nullable(2)]
		private FDateTime _LastEditTimestamp;

		// Token: 0x04010447 RID: 66631
		internal static int __PropertyOffset_LastEditPerson;
	}
}
