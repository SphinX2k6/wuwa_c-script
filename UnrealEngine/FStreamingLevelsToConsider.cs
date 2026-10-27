using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020011AB RID: 4523
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.StreamingLevelsToConsider")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FStreamingLevelsToConsider : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010ACE RID: 68302 RVA: 0x00187DC4 File Offset: 0x00185FC4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FStreamingLevelsToConsider._ScriptStructPtr != 0) ? FStreamingLevelsToConsider._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.StreamingLevelsToConsider", ref FStreamingLevelsToConsider._ScriptStructPtr);
		}

		// Token: 0x1700411D RID: 16669
		// (get) Token: 0x06010ACF RID: 68303 RVA: 0x00187DE8 File Offset: 0x00185FE8
		// (set) Token: 0x06010AD0 RID: 68304 RVA: 0x00187E2B File Offset: 0x0018602B
		public TArray<ULevelStreaming> StreamingLevels
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ULevelStreaming> result;
				if ((result = this._StreamingLevels) == null)
				{
					result = (this._StreamingLevels = new TArray<ULevelStreaming>(base.NativePtr + (IntPtr)FStreamingLevelsToConsider.__PropertyOffset_StreamingLevels, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.StreamingLevels.CopyAssign(value);
			}
		}

		// Token: 0x06010AD1 RID: 68305 RVA: 0x00187E39 File Offset: 0x00186039
		public FStreamingLevelsToConsider()
		{
		}

		// Token: 0x06010AD2 RID: 68306 RVA: 0x00187E41 File Offset: 0x00186041
		public FStreamingLevelsToConsider(TArray<ULevelStreaming> StreamingLevels)
		{
			this.StreamingLevels = StreamingLevels;
		}

		// Token: 0x06010AD3 RID: 68307 RVA: 0x00187E50 File Offset: 0x00186050
		protected override IntPtr GetUStructPtr()
		{
			return FStreamingLevelsToConsider.StaticStruct();
		}

		// Token: 0x06010AD4 RID: 68308 RVA: 0x00187E5C File Offset: 0x0018605C
		[NullableContext(2)]
		public FStreamingLevelsToConsider(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010AD5 RID: 68309 RVA: 0x00187E66 File Offset: 0x00186066
		public FStreamingLevelsToConsider(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010AD6 RID: 68310 RVA: 0x00187E71 File Offset: 0x00186071
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FStreamingLevelsToConsider(Pointer, false, true);
		}

		// Token: 0x06010AD7 RID: 68311 RVA: 0x00187E7B File Offset: 0x0018607B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FStreamingLevelsToConsider(Pointer, MemoryOwner);
		}

		// Token: 0x04008EB2 RID: 36530
		public const string __ObjectPath = "/Script/Engine.StreamingLevelsToConsider";

		// Token: 0x04008EB3 RID: 36531
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008EB4 RID: 36532
		internal static int __PropertyOffset_StreamingLevels;

		// Token: 0x04008EB5 RID: 36533
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ULevelStreaming> _StreamingLevels;
	}
}
