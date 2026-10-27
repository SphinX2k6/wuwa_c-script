using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020000D7 RID: 215
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ActorSequence.ActorSequenceObjectReferences")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FActorSequenceObjectReferences : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600118D RID: 4493 RVA: 0x0001A2DB File Offset: 0x000184DB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FActorSequenceObjectReferences._ScriptStructPtr != 0) ? FActorSequenceObjectReferences._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ActorSequence.ActorSequenceObjectReferences", ref FActorSequenceObjectReferences._ScriptStructPtr);
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x0600118E RID: 4494 RVA: 0x0001A300 File Offset: 0x00018500
		// (set) Token: 0x0600118F RID: 4495 RVA: 0x0001A343 File Offset: 0x00018543
		public TArray<FActorSequenceObjectReference> Array
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FActorSequenceObjectReference> result;
				if ((result = this._Array) == null)
				{
					result = (this._Array = new TArray<FActorSequenceObjectReference>(base.NativePtr + (IntPtr)FActorSequenceObjectReferences.__PropertyOffset_Array, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Array.CopyAssign(value);
			}
		}

		// Token: 0x06001190 RID: 4496 RVA: 0x0001A351 File Offset: 0x00018551
		public FActorSequenceObjectReferences()
		{
		}

		// Token: 0x06001191 RID: 4497 RVA: 0x0001A359 File Offset: 0x00018559
		public FActorSequenceObjectReferences(TArray<FActorSequenceObjectReference> Array)
		{
			this.Array = Array;
		}

		// Token: 0x06001192 RID: 4498 RVA: 0x0001A368 File Offset: 0x00018568
		protected override IntPtr GetUStructPtr()
		{
			return FActorSequenceObjectReferences.StaticStruct();
		}

		// Token: 0x06001193 RID: 4499 RVA: 0x0001A374 File Offset: 0x00018574
		[NullableContext(2)]
		public FActorSequenceObjectReferences(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001194 RID: 4500 RVA: 0x0001A37E File Offset: 0x0001857E
		public FActorSequenceObjectReferences(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001195 RID: 4501 RVA: 0x0001A389 File Offset: 0x00018589
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FActorSequenceObjectReferences(Pointer, false, true);
		}

		// Token: 0x06001196 RID: 4502 RVA: 0x0001A393 File Offset: 0x00018593
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FActorSequenceObjectReferences(Pointer, MemoryOwner);
		}

		// Token: 0x040002C1 RID: 705
		public const string __ObjectPath = "/Script/ActorSequence.ActorSequenceObjectReferences";

		// Token: 0x040002C2 RID: 706
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040002C3 RID: 707
		internal static int __PropertyOffset_Array;

		// Token: 0x040002C4 RID: 708
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FActorSequenceObjectReference> _Array;
	}
}
