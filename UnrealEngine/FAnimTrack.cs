using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200084A RID: 2122
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AnimTrack")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FAnimTrack : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600724D RID: 29261 RVA: 0x000A39A2 File Offset: 0x000A1BA2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimTrack._ScriptStructPtr != 0) ? FAnimTrack._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimTrack", ref FAnimTrack._ScriptStructPtr);
		}

		// Token: 0x17001AE4 RID: 6884
		// (get) Token: 0x0600724E RID: 29262 RVA: 0x000A39C8 File Offset: 0x000A1BC8
		// (set) Token: 0x0600724F RID: 29263 RVA: 0x000A3A0B File Offset: 0x000A1C0B
		public TArray<FAnimSegment> AnimSegments
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAnimSegment> result;
				if ((result = this._AnimSegments) == null)
				{
					result = (this._AnimSegments = new TArray<FAnimSegment>(base.NativePtr + (IntPtr)FAnimTrack.__PropertyOffset_AnimSegments, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AnimSegments.CopyAssign(value);
			}
		}

		// Token: 0x06007250 RID: 29264 RVA: 0x000A3A19 File Offset: 0x000A1C19
		public FAnimTrack()
		{
		}

		// Token: 0x06007251 RID: 29265 RVA: 0x000A3A21 File Offset: 0x000A1C21
		public FAnimTrack(TArray<FAnimSegment> AnimSegments)
		{
			this.AnimSegments = AnimSegments;
		}

		// Token: 0x06007252 RID: 29266 RVA: 0x000A3A30 File Offset: 0x000A1C30
		protected override IntPtr GetUStructPtr()
		{
			return FAnimTrack.StaticStruct();
		}

		// Token: 0x06007253 RID: 29267 RVA: 0x000A3A3C File Offset: 0x000A1C3C
		[NullableContext(2)]
		public FAnimTrack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007254 RID: 29268 RVA: 0x000A3A46 File Offset: 0x000A1C46
		public FAnimTrack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007255 RID: 29269 RVA: 0x000A3A51 File Offset: 0x000A1C51
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimTrack(Pointer, false, true);
		}

		// Token: 0x06007256 RID: 29270 RVA: 0x000A3A5B File Offset: 0x000A1C5B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimTrack(Pointer, MemoryOwner);
		}

		// Token: 0x040036DE RID: 14046
		public const string __ObjectPath = "/Script/Engine.AnimTrack";

		// Token: 0x040036DF RID: 14047
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040036E0 RID: 14048
		internal static int __PropertyOffset_AnimSegments;

		// Token: 0x040036E1 RID: 14049
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAnimSegment> _AnimSegments;
	}
}
