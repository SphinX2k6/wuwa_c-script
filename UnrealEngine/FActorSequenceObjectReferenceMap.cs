using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020000D6 RID: 214
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ActorSequence.ActorSequenceObjectReferenceMap")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FActorSequenceObjectReferenceMap : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06001181 RID: 4481 RVA: 0x0001A1BF File Offset: 0x000183BF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FActorSequenceObjectReferenceMap._ScriptStructPtr != 0) ? FActorSequenceObjectReferenceMap._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ActorSequence.ActorSequenceObjectReferenceMap", ref FActorSequenceObjectReferenceMap._ScriptStructPtr);
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06001182 RID: 4482 RVA: 0x0001A1E4 File Offset: 0x000183E4
		// (set) Token: 0x06001183 RID: 4483 RVA: 0x0001A227 File Offset: 0x00018427
		public TArray<FGuid> BindingIds
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGuid> result;
				if ((result = this._BindingIds) == null)
				{
					result = (this._BindingIds = new TArray<FGuid>(base.NativePtr + (IntPtr)FActorSequenceObjectReferenceMap.__PropertyOffset_BindingIds, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BindingIds.CopyAssign(value);
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06001184 RID: 4484 RVA: 0x0001A238 File Offset: 0x00018438
		// (set) Token: 0x06001185 RID: 4485 RVA: 0x0001A27B File Offset: 0x0001847B
		public TArray<FActorSequenceObjectReferences> References
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FActorSequenceObjectReferences> result;
				if ((result = this._References) == null)
				{
					result = (this._References = new TArray<FActorSequenceObjectReferences>(base.NativePtr + (IntPtr)FActorSequenceObjectReferenceMap.__PropertyOffset_References, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.References.CopyAssign(value);
			}
		}

		// Token: 0x06001186 RID: 4486 RVA: 0x0001A289 File Offset: 0x00018489
		public FActorSequenceObjectReferenceMap()
		{
		}

		// Token: 0x06001187 RID: 4487 RVA: 0x0001A291 File Offset: 0x00018491
		public FActorSequenceObjectReferenceMap(TArray<FGuid> BindingIds, TArray<FActorSequenceObjectReferences> References)
		{
			this.BindingIds = BindingIds;
			this.References = References;
		}

		// Token: 0x06001188 RID: 4488 RVA: 0x0001A2A7 File Offset: 0x000184A7
		protected override IntPtr GetUStructPtr()
		{
			return FActorSequenceObjectReferenceMap.StaticStruct();
		}

		// Token: 0x06001189 RID: 4489 RVA: 0x0001A2B3 File Offset: 0x000184B3
		[NullableContext(2)]
		public FActorSequenceObjectReferenceMap(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x0001A2BD File Offset: 0x000184BD
		public FActorSequenceObjectReferenceMap(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x0001A2C8 File Offset: 0x000184C8
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FActorSequenceObjectReferenceMap(Pointer, false, true);
		}

		// Token: 0x0600118C RID: 4492 RVA: 0x0001A2D2 File Offset: 0x000184D2
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FActorSequenceObjectReferenceMap(Pointer, MemoryOwner);
		}

		// Token: 0x040002BB RID: 699
		public const string __ObjectPath = "/Script/ActorSequence.ActorSequenceObjectReferenceMap";

		// Token: 0x040002BC RID: 700
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040002BD RID: 701
		internal static int __PropertyOffset_BindingIds;

		// Token: 0x040002BE RID: 702
		[Nullable(2)]
		private TArray<FGuid> _BindingIds;

		// Token: 0x040002BF RID: 703
		internal static int __PropertyOffset_References;

		// Token: 0x040002C0 RID: 704
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FActorSequenceObjectReferences> _References;
	}
}
