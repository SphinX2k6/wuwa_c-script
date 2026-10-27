using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000468 RID: 1128
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Chaos.RecordedFrame")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 184)]
	public class FRecordedFrame : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003C12 RID: 15378 RVA: 0x0005A8FC File Offset: 0x00058AFC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRecordedFrame._ScriptStructPtr != 0) ? FRecordedFrame._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Chaos.RecordedFrame", ref FRecordedFrame._ScriptStructPtr);
		}

		// Token: 0x17000E87 RID: 3719
		// (get) Token: 0x06003C13 RID: 15379 RVA: 0x0005A920 File Offset: 0x00058B20
		// (set) Token: 0x06003C14 RID: 15380 RVA: 0x0005A963 File Offset: 0x00058B63
		public TArray<FTransform> Transforms
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._Transforms) == null)
				{
					result = (this._Transforms = new TArray<FTransform>(base.NativePtr + (IntPtr)FRecordedFrame.__PropertyOffset_Transforms, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Transforms.CopyAssign(value);
			}
		}

		// Token: 0x17000E88 RID: 3720
		// (get) Token: 0x06003C15 RID: 15381 RVA: 0x0005A974 File Offset: 0x00058B74
		// (set) Token: 0x06003C16 RID: 15382 RVA: 0x0005A9B7 File Offset: 0x00058BB7
		public TArray<int> TransformIndices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._TransformIndices) == null)
				{
					result = (this._TransformIndices = new TArray<int>(base.NativePtr + (IntPtr)FRecordedFrame.__PropertyOffset_TransformIndices, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TransformIndices.CopyAssign(value);
			}
		}

		// Token: 0x17000E89 RID: 3721
		// (get) Token: 0x06003C17 RID: 15383 RVA: 0x0005A9C8 File Offset: 0x00058BC8
		// (set) Token: 0x06003C18 RID: 15384 RVA: 0x0005AA0B File Offset: 0x00058C0B
		public TArray<int> PreviousTransformIndices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._PreviousTransformIndices) == null)
				{
					result = (this._PreviousTransformIndices = new TArray<int>(base.NativePtr + (IntPtr)FRecordedFrame.__PropertyOffset_PreviousTransformIndices, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PreviousTransformIndices.CopyAssign(value);
			}
		}

		// Token: 0x17000E8A RID: 3722
		// (get) Token: 0x06003C19 RID: 15385 RVA: 0x0005AA1C File Offset: 0x00058C1C
		// (set) Token: 0x06003C1A RID: 15386 RVA: 0x0005AA5F File Offset: 0x00058C5F
		public TArray<bool> DisabledFlags
		{
			get
			{
				base.FastCheckIsValid();
				TArray<bool> result;
				if ((result = this._DisabledFlags) == null)
				{
					result = (this._DisabledFlags = new TArray<bool>(base.NativePtr + (IntPtr)FRecordedFrame.__PropertyOffset_DisabledFlags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DisabledFlags.CopyAssign(value);
			}
		}

		// Token: 0x17000E8B RID: 3723
		// (get) Token: 0x06003C1B RID: 15387 RVA: 0x0005AA70 File Offset: 0x00058C70
		// (set) Token: 0x06003C1C RID: 15388 RVA: 0x0005AAB3 File Offset: 0x00058CB3
		public TArray<FSolverCollisionData> Collisions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSolverCollisionData> result;
				if ((result = this._Collisions) == null)
				{
					result = (this._Collisions = new TArray<FSolverCollisionData>(base.NativePtr + (IntPtr)FRecordedFrame.__PropertyOffset_Collisions, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Collisions.CopyAssign(value);
			}
		}

		// Token: 0x17000E8C RID: 3724
		// (get) Token: 0x06003C1D RID: 15389 RVA: 0x0005AAC4 File Offset: 0x00058CC4
		// (set) Token: 0x06003C1E RID: 15390 RVA: 0x0005AB07 File Offset: 0x00058D07
		public TArray<FSolverBreakingData> Breakings
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSolverBreakingData> result;
				if ((result = this._Breakings) == null)
				{
					result = (this._Breakings = new TArray<FSolverBreakingData>(base.NativePtr + (IntPtr)FRecordedFrame.__PropertyOffset_Breakings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Breakings.CopyAssign(value);
			}
		}

		// Token: 0x17000E8D RID: 3725
		// (get) Token: 0x06003C1F RID: 15391 RVA: 0x0005AB18 File Offset: 0x00058D18
		// (set) Token: 0x06003C20 RID: 15392 RVA: 0x0005AB5B File Offset: 0x00058D5B
		public TSet<FSolverTrailingData> Trailings
		{
			get
			{
				base.FastCheckIsValid();
				TSet<FSolverTrailingData> result;
				if ((result = this._Trailings) == null)
				{
					result = (this._Trailings = new TSet<FSolverTrailingData>(base.NativePtr + (IntPtr)FRecordedFrame.__PropertyOffset_Trailings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Trailings.CopyAssign(value);
			}
		}

		// Token: 0x17000E8E RID: 3726
		// (get) Token: 0x06003C21 RID: 15393 RVA: 0x0005AB69 File Offset: 0x00058D69
		// (set) Token: 0x06003C22 RID: 15394 RVA: 0x0005AB79 File Offset: 0x00058D79
		public unsafe float Timestamp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRecordedFrame.__PropertyOffset_Timestamp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRecordedFrame.__PropertyOffset_Timestamp) = value;
			}
		}

		// Token: 0x06003C23 RID: 15395 RVA: 0x0005AB8A File Offset: 0x00058D8A
		public FRecordedFrame()
		{
		}

		// Token: 0x06003C24 RID: 15396 RVA: 0x0005AB94 File Offset: 0x00058D94
		public FRecordedFrame(TArray<FTransform> Transforms, TArray<int> TransformIndices, TArray<int> PreviousTransformIndices, TArray<bool> DisabledFlags, TArray<FSolverCollisionData> Collisions, TArray<FSolverBreakingData> Breakings, TSet<FSolverTrailingData> Trailings, float Timestamp)
		{
			this.Transforms = Transforms;
			this.TransformIndices = TransformIndices;
			this.PreviousTransformIndices = PreviousTransformIndices;
			this.DisabledFlags = DisabledFlags;
			this.Collisions = Collisions;
			this.Breakings = Breakings;
			this.Trailings = Trailings;
			this.Timestamp = Timestamp;
		}

		// Token: 0x06003C25 RID: 15397 RVA: 0x0005ABE4 File Offset: 0x00058DE4
		protected override IntPtr GetUStructPtr()
		{
			return FRecordedFrame.StaticStruct();
		}

		// Token: 0x06003C26 RID: 15398 RVA: 0x0005ABF0 File Offset: 0x00058DF0
		[NullableContext(2)]
		public FRecordedFrame(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003C27 RID: 15399 RVA: 0x0005ABFA File Offset: 0x00058DFA
		public FRecordedFrame(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003C28 RID: 15400 RVA: 0x0005AC05 File Offset: 0x00058E05
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRecordedFrame(Pointer, false, true);
		}

		// Token: 0x06003C29 RID: 15401 RVA: 0x0005AC0F File Offset: 0x00058E0F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRecordedFrame(Pointer, MemoryOwner);
		}

		// Token: 0x04001C2D RID: 7213
		public const string __ObjectPath = "/Script/Chaos.RecordedFrame";

		// Token: 0x04001C2E RID: 7214
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001C2F RID: 7215
		internal static int __PropertyOffset_Transforms;

		// Token: 0x04001C30 RID: 7216
		[Nullable(2)]
		private TArray<FTransform> _Transforms;

		// Token: 0x04001C31 RID: 7217
		internal static int __PropertyOffset_TransformIndices;

		// Token: 0x04001C32 RID: 7218
		[Nullable(2)]
		private TArray<int> _TransformIndices;

		// Token: 0x04001C33 RID: 7219
		internal static int __PropertyOffset_PreviousTransformIndices;

		// Token: 0x04001C34 RID: 7220
		[Nullable(2)]
		private TArray<int> _PreviousTransformIndices;

		// Token: 0x04001C35 RID: 7221
		internal static int __PropertyOffset_DisabledFlags;

		// Token: 0x04001C36 RID: 7222
		[Nullable(2)]
		private TArray<bool> _DisabledFlags;

		// Token: 0x04001C37 RID: 7223
		internal static int __PropertyOffset_Collisions;

		// Token: 0x04001C38 RID: 7224
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSolverCollisionData> _Collisions;

		// Token: 0x04001C39 RID: 7225
		internal static int __PropertyOffset_Breakings;

		// Token: 0x04001C3A RID: 7226
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSolverBreakingData> _Breakings;

		// Token: 0x04001C3B RID: 7227
		internal static int __PropertyOffset_Trailings;

		// Token: 0x04001C3C RID: 7228
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<FSolverTrailingData> _Trailings;

		// Token: 0x04001C3D RID: 7229
		internal static int __PropertyOffset_Timestamp;
	}
}
