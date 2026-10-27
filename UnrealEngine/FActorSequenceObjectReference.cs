using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020000D5 RID: 213
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ActorSequence.ActorSequenceObjectReference")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FActorSequenceObjectReference : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06001173 RID: 4467 RVA: 0x0001A0CF File Offset: 0x000182CF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FActorSequenceObjectReference._ScriptStructPtr != 0) ? FActorSequenceObjectReference._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ActorSequence.ActorSequenceObjectReference", ref FActorSequenceObjectReference._ScriptStructPtr);
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06001174 RID: 4468 RVA: 0x0001A0F3 File Offset: 0x000182F3
		// (set) Token: 0x06001175 RID: 4469 RVA: 0x0001A103 File Offset: 0x00018303
		public unsafe EActorSequenceObjectReferenceType Type
		{
			get
			{
				return (EActorSequenceObjectReferenceType)(*(base.NativePtr + (IntPtr)FActorSequenceObjectReference.__PropertyOffset_Type));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FActorSequenceObjectReference.__PropertyOffset_Type) = (byte)value;
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06001176 RID: 4470 RVA: 0x0001A114 File Offset: 0x00018314
		// (set) Token: 0x06001177 RID: 4471 RVA: 0x0001A128 File Offset: 0x00018328
		public unsafe FGuid ActorId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FActorSequenceObjectReference.__PropertyOffset_ActorId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FActorSequenceObjectReference.__PropertyOffset_ActorId) = value;
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06001178 RID: 4472 RVA: 0x0001A13D File Offset: 0x0001833D
		// (set) Token: 0x06001179 RID: 4473 RVA: 0x0001A151 File Offset: 0x00018351
		public unsafe string PathToComponent
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FActorSequenceObjectReference.__PropertyOffset_PathToComponent)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FActorSequenceObjectReference.__PropertyOffset_PathToComponent)), value);
			}
		}

		// Token: 0x0600117A RID: 4474 RVA: 0x0001A166 File Offset: 0x00018366
		public FActorSequenceObjectReference()
		{
		}

		// Token: 0x0600117B RID: 4475 RVA: 0x0001A16E File Offset: 0x0001836E
		public FActorSequenceObjectReference(EActorSequenceObjectReferenceType Type, FGuid ActorId, string PathToComponent)
		{
			this.Type = Type;
			this.ActorId = ActorId;
			this.PathToComponent = PathToComponent;
		}

		// Token: 0x0600117C RID: 4476 RVA: 0x0001A18B File Offset: 0x0001838B
		protected override IntPtr GetUStructPtr()
		{
			return FActorSequenceObjectReference.StaticStruct();
		}

		// Token: 0x0600117D RID: 4477 RVA: 0x0001A197 File Offset: 0x00018397
		[NullableContext(2)]
		public FActorSequenceObjectReference(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600117E RID: 4478 RVA: 0x0001A1A1 File Offset: 0x000183A1
		public FActorSequenceObjectReference(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600117F RID: 4479 RVA: 0x0001A1AC File Offset: 0x000183AC
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FActorSequenceObjectReference(Pointer, false, true);
		}

		// Token: 0x06001180 RID: 4480 RVA: 0x0001A1B6 File Offset: 0x000183B6
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FActorSequenceObjectReference(Pointer, MemoryOwner);
		}

		// Token: 0x040002B6 RID: 694
		public const string __ObjectPath = "/Script/ActorSequence.ActorSequenceObjectReference";

		// Token: 0x040002B7 RID: 695
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040002B8 RID: 696
		internal static int __PropertyOffset_Type;

		// Token: 0x040002B9 RID: 697
		internal static int __PropertyOffset_ActorId;

		// Token: 0x040002BA RID: 698
		internal static int __PropertyOffset_PathToComponent;
	}
}
